namespace Print_barcode
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.edtCod = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.lvMain = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.numPos = new System.Windows.Forms.NumericUpDown();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.PNL = new System.Windows.Forms.Panel();
			this.lblDES3 = new System.Windows.Forms.Label();
			this.lblDES2 = new System.Windows.Forms.Label();
			this.BCODELBL = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.BCODE = new System.Windows.Forms.PictureBox();
			this.lblDES1 = new System.Windows.Forms.Label();
			this.lblART = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numPos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.PNL.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.BCODE)).BeginInit();
			this.SuspendLayout();
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Document = this.printDocument1;
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.Visible = false;
			// 
			// printDialog1
			// 
			this.printDialog1.Document = this.printDocument1;
			this.printDialog1.UseEXDialog = true;
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Location = new System.Drawing.Point(0, 750);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 15, 0);
			this.statusStrip1.Size = new System.Drawing.Size(1754, 22);
			this.statusStrip1.TabIndex = 15;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.edtCod);
			this.splitContainer2.Panel1.Controls.Add(this.label1);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
			this.splitContainer2.Size = new System.Drawing.Size(1754, 750);
			this.splitContainer2.SplitterDistance = 65;
			this.splitContainer2.SplitterWidth = 6;
			this.splitContainer2.TabIndex = 17;
			// 
			// edtCod
			// 
			this.edtCod.Location = new System.Drawing.Point(202, 23);
			this.edtCod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.edtCod.Name = "edtCod";
			this.edtCod.Size = new System.Drawing.Size(433, 26);
			this.edtCod.TabIndex = 1;
			this.edtCod.TextChanged += new System.EventHandler(this.edtCod_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(96, 29);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Filtro Ricerca";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.lvMain);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.numPos);
			this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
			this.splitContainer1.Panel2.Controls.Add(this.button3);
			this.splitContainer1.Panel2.Controls.Add(this.button2);
			this.splitContainer1.Panel2.Controls.Add(this.PNL);
			this.splitContainer1.Panel2.Controls.Add(this.button1);
			this.splitContainer1.Size = new System.Drawing.Size(1754, 679);
			this.splitContainer1.SplitterDistance = 1147;
			this.splitContainer1.TabIndex = 17;
			// 
			// lvMain
			// 
			this.lvMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader5});
			this.lvMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvMain.FullRowSelect = true;
			this.lvMain.HideSelection = false;
			this.lvMain.Location = new System.Drawing.Point(0, 0);
			this.lvMain.Name = "lvMain";
			this.lvMain.Size = new System.Drawing.Size(1147, 679);
			this.lvMain.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lvMain.TabIndex = 10;
			this.lvMain.UseCompatibleStateImageBehavior = false;
			this.lvMain.View = System.Windows.Forms.View.Details;
			this.lvMain.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvMain_ItemSelectionChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Codice";
			this.columnHeader1.Width = 100;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Articolo";
			this.columnHeader2.Width = 90;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Descrizione";
			this.columnHeader3.Width = 160;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Descrizione2";
			this.columnHeader4.Width = 150;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Descrizione 3";
			this.columnHeader6.Width = 150;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Barcode";
			this.columnHeader5.Width = 100;
			// 
			// numPos
			// 
			this.numPos.Location = new System.Drawing.Point(255, 452);
			this.numPos.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.numPos.Name = "numPos";
			this.numPos.Size = new System.Drawing.Size(120, 26);
			this.numPos.TabIndex = 18;
			this.numPos.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
			this.numPos.ValueChanged += new System.EventHandler(this.numPos_ValueChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(30, 440);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(158, 83);
			this.pictureBox1.TabIndex = 17;
			this.pictureBox1.TabStop = false;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(422, 534);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(105, 74);
			this.button3.TabIndex = 16;
			this.button3.Text = "Print";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(30, 534);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(141, 74);
			this.button2.TabIndex = 15;
			this.button2.Text = "Preview";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Visible = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// PNL
			// 
			this.PNL.BackColor = System.Drawing.Color.White;
			this.PNL.Controls.Add(this.lblDES3);
			this.PNL.Controls.Add(this.lblDES2);
			this.PNL.Controls.Add(this.BCODELBL);
			this.PNL.Controls.Add(this.label2);
			this.PNL.Controls.Add(this.BCODE);
			this.PNL.Controls.Add(this.lblDES1);
			this.PNL.Controls.Add(this.lblART);
			this.PNL.Location = new System.Drawing.Point(30, 34);
			this.PNL.Name = "PNL";
			this.PNL.Size = new System.Drawing.Size(519, 385);
			this.PNL.TabIndex = 14;
			// 
			// lblDES3
			// 
			this.lblDES3.AccessibleDescription = "";
			this.lblDES3.AutoSize = true;
			this.lblDES3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDES3.Location = new System.Drawing.Point(40, 312);
			this.lblDES3.Name = "lblDES3";
			this.lblDES3.Size = new System.Drawing.Size(84, 33);
			this.lblDES3.TabIndex = 9;
			this.lblDES3.Text = "Text2";
			// 
			// lblDES2
			// 
			this.lblDES2.AccessibleDescription = "";
			this.lblDES2.AutoSize = true;
			this.lblDES2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDES2.Location = new System.Drawing.Point(40, 278);
			this.lblDES2.Name = "lblDES2";
			this.lblDES2.Size = new System.Drawing.Size(84, 33);
			this.lblDES2.TabIndex = 8;
			this.lblDES2.Text = "Text2";
			// 
			// BCODELBL
			// 
			this.BCODELBL.AutoSize = true;
			this.BCODELBL.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BCODELBL.Location = new System.Drawing.Point(213, 157);
			this.BCODELBL.Name = "BCODELBL";
			this.BCODELBL.Size = new System.Drawing.Size(170, 41);
			this.BCODELBL.TabIndex = 7;
			this.BCODELBL.Text = "bcode_lbl";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(39, 200);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 41);
			this.label2.TabIndex = 6;
			this.label2.Text = "ART:";
			// 
			// BCODE
			// 
			this.BCODE.Location = new System.Drawing.Point(195, 3);
			this.BCODE.Name = "BCODE";
			this.BCODE.Size = new System.Drawing.Size(302, 146);
			this.BCODE.TabIndex = 5;
			this.BCODE.TabStop = false;
			// 
			// lblDES1
			// 
			this.lblDES1.AutoSize = true;
			this.lblDES1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDES1.Location = new System.Drawing.Point(40, 245);
			this.lblDES1.Name = "lblDES1";
			this.lblDES1.Size = new System.Drawing.Size(84, 33);
			this.lblDES1.TabIndex = 4;
			this.lblDES1.Text = "Text1";
			// 
			// lblART
			// 
			this.lblART.AutoSize = true;
			this.lblART.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblART.Location = new System.Drawing.Point(126, 200);
			this.lblART.Name = "lblART";
			this.lblART.Size = new System.Drawing.Size(101, 41);
			this.lblART.TabIndex = 3;
			this.lblART.Text = "Text0";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(225, 566);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(150, 42);
			this.button1.TabIndex = 13;
			this.button1.Text = "Reload XLS";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1754, 772);
			this.Controls.Add(this.splitContainer2);
			this.Controls.Add(this.statusStrip1);
			this.Name = "Form1";
			this.Text = "MAS Label Printer";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numPos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.PNL.ResumeLayout(false);
			this.PNL.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.BCODE)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
    private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ListView lvMain;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel PNL;
		private System.Windows.Forms.Label lblDES2;
		private System.Windows.Forms.Label BCODELBL;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox BCODE;
		private System.Windows.Forms.Label lblDES1;
		private System.Windows.Forms.Label lblART;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox edtCod;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.NumericUpDown numPos;
		private System.Windows.Forms.Label lblDES3;
	}
}

