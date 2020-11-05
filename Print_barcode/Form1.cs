using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

using System.IO; //legge file
using NPOI.HSSF.Model; // InternalWorkbook
using NPOI.HSSF.UserModel; // HSSFWorkbook, HSSFSheet
using System.Text.RegularExpressions;

namespace Print_barcode
{

  public partial class Form1 : Form
  {
    
    public Form1()
    {
    InitializeComponent();
    }
    //lettura file xls
    HSSFWorkbook wb;
    HSSFSheet sh;
    //generazione immagine barcode
    Bitmap bmp;
    //lista con i dati
    List<ListViewItem> allItems = new List<ListViewItem>();

    void _genBarcode(string _pText)
    {
      if (_pText!="")
      {
        try
        {
          Zen.Barcode.CodeEan13BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.CodeEan13WithChecksum;
          BCODE.Image = barcode.Draw(_pText, BCODE.Height, 2);
					BCODELBL.Text = _pText + IsValidGtin(_pText);

          //_pText;
        }
        catch (System.ArgumentException)
        {
          MessageBox.Show("Codice a Barre Errato");
          //throw;
        }

      } 
    }

    public string IsValidGtin(string code)
    {
      if (code != (new Regex("[^0-9]")).Replace(code, ""))
      {
        // is not numeric
        return "X";
      }
      // pad with zeros to lengthen to 14 digits
      /* switch (code.Length)
      {
        case 8:
          code = "000000" + code;
          break;
        case 12:
          code = "00" + code;
          break;
        case 13:
          code = "0" + code;
          break;
        case 14:
          break;
        default:
          // wrong number of digits
          return "X";
      }
      */
      // calculate check digit
      int[] a = new int[13];
      a[0] = int.Parse(code[0].ToString());
      a[1] = int.Parse(code[1].ToString()) * 3;
      a[2] = int.Parse(code[2].ToString());
      a[3] = int.Parse(code[3].ToString()) * 3;
      a[4] = int.Parse(code[4].ToString());
      a[5] = int.Parse(code[5].ToString()) * 3;
      a[6] = int.Parse(code[6].ToString());
      a[7] = int.Parse(code[7].ToString()) * 3;
      a[8] = int.Parse(code[8].ToString());
      a[9] = int.Parse(code[9].ToString()) * 3;
      a[10] = int.Parse(code[10].ToString());
      a[11] = int.Parse(code[11].ToString()) * 3;
      //a[12] = int.Parse(code[12].ToString()) * 3;
      int sum = a[0] + a[1] + a[2] + a[3] + a[4] + a[5] + a[6] + a[7] + a[8] + a[9] + a[10] + a[11];
        //+ a[12];
      int check = (10 - (sum % 10)) % 10;
      return check.ToString();

      //// evaluate check digit
      //int last = int.Parse(code[13].ToString());
      //return check == last;
    }

    public bool _selectPrinter()
    {
      bool _result = false;
      if (printDialog1.ShowDialog() == DialogResult.OK)
      {
        printDocument1.PrinterSettings.PrinterName = printDialog1.PrinterSettings.PrinterName;
        printDocument1.PrinterSettings.Copies = printDialog1.PrinterSettings.Copies;
        _result = true;
      }

      return _result;
    }

    
    void _readXLS ()
    {
      if (File.Exists("CodiciABarre.xls"))
      {
        //ripulisco la itemlistbox
        lvMain.Items.Clear();
        //inizio lettura file excel
        using (var fs = new FileStream("CodiciABarre.xls", FileMode.Open, FileAccess.Read))
        {
          wb = new HSSFWorkbook(fs);
          sh = (HSSFSheet)wb.GetSheet("Etichette");

          for (int row = 0; row <= sh.LastRowNum; row++) //Loop the records upto filled row  
          {
            if (sh.GetRow(row) != null) //null is when the row only contains empty cells   
            {
              //carico la listview
              ListViewItem _lvItem;
              _lvItem = lvMain.Items.Add(sh.GetRow(row).GetCell(0).ToString());
              
              for (int I = 1; I<=5; I++)  //ciclo sulle celle rimanenti xls da caricare
              {
                if (sh.GetRow(row).GetCell(I) == null)
                  _lvItem.SubItems.Add("");
                else
                  _lvItem.SubItems.Add(sh.GetRow(row).GetCell(I).ToString());
              }
              //string value = sh.GetRow(row).GetCell(0).ToString(); //Here for sample , I just save the value in "value" field, Here you can write your custom logics...  
              //MessageBox.Show(value);
            }
          }
        }
        lvMain.Items[0].Selected = true;

        allItems.Clear();
        allItems.AddRange(lvMain.Items.Cast<ListViewItem>());

//        lvFull.Items.AddRange(lvMain.Items); //copio i dati nella lview di backup su cui effettuare le ricerche
      }
      else
        MessageBox.Show("File etichette non trovato");
    }

    void _filterList()
		{
      /*clono la lista dei dati
       * la filtro
       * sostituisco la lista iniziale
       
      lvMain.Items.Clear();
      foreach(ListViewItem itm in lvFull.Items)
      {
        if (itm.Text.Contains(edtCod.Text))
          lvMain.Items.Add(itm);
			}
      */
      lvMain.Items.Clear();   // clear all items we have atm
      if (edtCod.Text == "")
      {
        lvMain.Items.AddRange(allItems.ToArray());  // no filter: add all items
        return;
      }
      // now we find all items that have a suitable text in any subitem/field/column
      var list = allItems.Cast<ListViewItem>()
                         .Where(x => x.SubItems
                                      .Cast<ListViewItem.ListViewSubItem>()
                                      .Any(y => y.Text.Contains(edtCod.Text)))
                         .ToArray();
      lvMain.Items.AddRange(list);  // now we add the result
      

    }


    /*
     * versione originale con carico del file id excel direttamente nella listview
     * 
         void _readXLS ()
    {
      if (File.Exists("CodiciABarre.xls"))
      {
        //ripulisco la itemlistbox
        lvMain.Items.Clear();
        //inizio lettura file excel
        using (var fs = new FileStream("CodiciABarre.xls", FileMode.Open, FileAccess.Read))
        {
          wb = new HSSFWorkbook(fs);
          sh = (HSSFSheet)wb.GetSheet("Etichette");

          for (int row = 0; row <= sh.LastRowNum; row++) //Loop the records upto filled row  
          {
            if (sh.GetRow(row) != null) //null is when the row only contains empty cells   
            {
              //carico la listview
              ListViewItem _lvItem;
              _lvItem = lvMain.Items.Add(sh.GetRow(row).GetCell(0).ToString());
              for (int I = 1; I<=5; I++)
              {
                if (sh.GetRow(row).GetCell(I) == null)
                  _lvItem.SubItems.Add("");
                else
              _lvItem.SubItems.Add(sh.GetRow(row).GetCell(I).ToString());
              }
              //string value = sh.GetRow(row).GetCell(0).ToString(); //Here for sample , I just save the value in "value" field, Here you can write your custom logics...  
              //MessageBox.Show(value);
            }
          }
        }
        lvMain.Items[0].Selected = true;
      }
      else
        MessageBox.Show("File etichette non trovato");
    }*/

    private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
      bmp = new Bitmap(PNL.Width, PNL.Height);
      bmp.SetResolution(Convert.ToSingle(numResDPI.Value), Convert.ToSingle(numResDPI.Value));
      PNL.DrawToBitmap(bmp, new Rectangle(0, 0, PNL.Width, PNL.Height));
      e.Graphics.DrawImage(bmp, 0, 0);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      //carico list view
      _readXLS();
      numPos.Value = BCODE.Left;
            
    }
    
    private void lvMain_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
    {
      //al cambio dell'indice di selezione aggiorno i controlli dell'etichetta
      //if (e.IsSelected)
      if (lvMain.SelectedIndices.Count > 0)
      {
        lblART.Text = lvMain.SelectedItems[0].SubItems[1].Text;
        lblDES1.Text = lvMain.SelectedItems[0].SubItems[2].Text;
        lblDES2.Text = lvMain.SelectedItems[0].SubItems[3].Text;
        lblDES3.Text = lvMain.SelectedItems[0].SubItems[4].Text;

        if (lvMain.SelectedItems[0].SubItems[5].Text != "")
          _genBarcode(lvMain.SelectedItems[0].SubItems[5].Text);
      }
    }

		private void numPos_ValueChanged(object sender, EventArgs e)
		{
      //sposto il riquadro del docie a barre
      BCODE.Left = Convert.ToInt32(numPos.Value);

    }

		private void edtCod_TextChanged(object sender, EventArgs e)
		{
      _filterList();
		}

		private void button3_Click(object sender, EventArgs e)
		{
      if (_selectPrinter())
        printDocument1.Print();
    }

		private void button1_Click(object sender, EventArgs e)
		{
      _readXLS();
    }

		private void button2_Click(object sender, EventArgs e)
		{
      printPreviewDialog1.ShowDialog();
    }
	}
}
