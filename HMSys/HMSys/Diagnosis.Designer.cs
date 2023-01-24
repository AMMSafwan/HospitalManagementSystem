namespace HMSys
{
    partial class Diagnosis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diagnosis));
            this.label1 = new System.Windows.Forms.Label();
            this.DiaID = new System.Windows.Forms.TextBox();
            this.DocID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ptID = new System.Windows.Forms.TextBox();
            this.ptName = new System.Windows.Forms.TextBox();
            this.DiaSymp = new System.Windows.Forms.TextBox();
            this.diagno = new System.Windows.Forms.TextBox();
            this.Diagnos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Medicin = new System.Windows.Forms.TextBox();
            this.DiagnosdataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Medicineslbl = new System.Windows.Forms.Label();
            this.Symptomslbl = new System.Windows.Forms.Label();
            this.Diagnosislbl = new System.Windows.Forms.Label();
            this.PatientNamelbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.patientnametxt = new System.Windows.Forms.TextBox();
            this.diagnosistxt = new System.Windows.Forms.TextBox();
            this.symptomstxt = new System.Windows.Forms.TextBox();
            this.medicinestxt = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosdataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(63, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 78);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hospital Management System\r\n                 Diagnosis";
            // 
            // DiaID
            // 
            this.DiaID.Location = new System.Drawing.Point(206, 148);
            this.DiaID.Margin = new System.Windows.Forms.Padding(2);
            this.DiaID.Name = "DiaID";
            this.DiaID.Size = new System.Drawing.Size(326, 20);
            this.DiaID.TabIndex = 6;
            // 
            // DocID
            // 
            this.DocID.AutoSize = true;
            this.DocID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocID.Location = new System.Drawing.Point(67, 148);
            this.DocID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DocID.Name = "DocID";
            this.DocID.Size = new System.Drawing.Size(87, 17);
            this.DocID.TabIndex = 24;
            this.DocID.Text = "Diagnosis ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Symptoms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Patient Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Patient ID";
            // 
            // ptID
            // 
            this.ptID.Location = new System.Drawing.Point(206, 171);
            this.ptID.Margin = new System.Windows.Forms.Padding(2);
            this.ptID.Name = "ptID";
            this.ptID.Size = new System.Drawing.Size(326, 20);
            this.ptID.TabIndex = 28;
            // 
            // ptName
            // 
            this.ptName.Location = new System.Drawing.Point(206, 193);
            this.ptName.Margin = new System.Windows.Forms.Padding(2);
            this.ptName.Name = "ptName";
            this.ptName.Size = new System.Drawing.Size(326, 20);
            this.ptName.TabIndex = 29;
            // 
            // DiaSymp
            // 
            this.DiaSymp.Location = new System.Drawing.Point(206, 216);
            this.DiaSymp.Margin = new System.Windows.Forms.Padding(2);
            this.DiaSymp.Name = "DiaSymp";
            this.DiaSymp.Size = new System.Drawing.Size(326, 20);
            this.DiaSymp.TabIndex = 30;
            // 
            // diagno
            // 
            this.diagno.Location = new System.Drawing.Point(206, 239);
            this.diagno.Margin = new System.Windows.Forms.Padding(2);
            this.diagno.Name = "diagno";
            this.diagno.Size = new System.Drawing.Size(326, 20);
            this.diagno.TabIndex = 31;
            // 
            // Diagnos
            // 
            this.Diagnos.AutoSize = true;
            this.Diagnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diagnos.Location = new System.Drawing.Point(67, 240);
            this.Diagnos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Diagnos.Name = "Diagnos";
            this.Diagnos.Size = new System.Drawing.Size(70, 17);
            this.Diagnos.TabIndex = 32;
            this.Diagnos.Text = "Diagnosis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 263);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Medicines";
            // 
            // Medicin
            // 
            this.Medicin.Location = new System.Drawing.Point(206, 262);
            this.Medicin.Margin = new System.Windows.Forms.Padding(2);
            this.Medicin.Name = "Medicin";
            this.Medicin.Size = new System.Drawing.Size(326, 20);
            this.Medicin.TabIndex = 34;
            // 
            // DiagnosdataGridView1
            // 
            this.DiagnosdataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DiagnosdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiagnosdataGridView1.Location = new System.Drawing.Point(70, 284);
            this.DiagnosdataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.DiagnosdataGridView1.Name = "DiagnosdataGridView1";
            this.DiagnosdataGridView1.RowTemplate.Height = 24;
            this.DiagnosdataGridView1.Size = new System.Drawing.Size(461, 115);
            this.DiagnosdataGridView1.TabIndex = 39;
            this.DiagnosdataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DiagnosdataGridView1_CellClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Aqua;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(407, 405);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 26);
            this.button4.TabIndex = 38;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Aqua;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(310, 405);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 26);
            this.button3.TabIndex = 37;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aqua;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(214, 405);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 26);
            this.button2.TabIndex = 36;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(117, 405);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 26);
            this.button1.TabIndex = 35;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.medicinestxt);
            this.panel1.Controls.Add(this.symptomstxt);
            this.panel1.Controls.Add(this.diagnosistxt);
            this.panel1.Controls.Add(this.patientnametxt);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Medicineslbl);
            this.panel1.Controls.Add(this.Symptomslbl);
            this.panel1.Controls.Add(this.Diagnosislbl);
            this.panel1.Controls.Add(this.PatientNamelbl);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(13, 436);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 243);
            this.panel1.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(212, 219);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Code By SafwanAMM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(13, 179);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Date";
            // 
            // Medicineslbl
            // 
            this.Medicineslbl.AutoSize = true;
            this.Medicineslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medicineslbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Medicineslbl.Location = new System.Drawing.Point(13, 146);
            this.Medicineslbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Medicineslbl.Name = "Medicineslbl";
            this.Medicineslbl.Size = new System.Drawing.Size(71, 17);
            this.Medicineslbl.TabIndex = 4;
            this.Medicineslbl.Text = "Medicines";
            // 
            // Symptomslbl
            // 
            this.Symptomslbl.AutoSize = true;
            this.Symptomslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Symptomslbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Symptomslbl.Location = new System.Drawing.Point(13, 110);
            this.Symptomslbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Symptomslbl.Name = "Symptomslbl";
            this.Symptomslbl.Size = new System.Drawing.Size(73, 17);
            this.Symptomslbl.TabIndex = 3;
            this.Symptomslbl.Text = "Symptoms";
            // 
            // Diagnosislbl
            // 
            this.Diagnosislbl.AutoSize = true;
            this.Diagnosislbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diagnosislbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Diagnosislbl.Location = new System.Drawing.Point(13, 74);
            this.Diagnosislbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Diagnosislbl.Name = "Diagnosislbl";
            this.Diagnosislbl.Size = new System.Drawing.Size(70, 17);
            this.Diagnosislbl.TabIndex = 2;
            this.Diagnosislbl.Text = "Diagnosis";
            // 
            // PatientNamelbl
            // 
            this.PatientNamelbl.AutoSize = true;
            this.PatientNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientNamelbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PatientNamelbl.Location = new System.Drawing.Point(13, 40);
            this.PatientNamelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PatientNamelbl.Name = "PatientNamelbl";
            this.PatientNamelbl.Size = new System.Drawing.Size(93, 17);
            this.PatientNamelbl.TabIndex = 1;
            this.PatientNamelbl.Text = "Patient Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Location = new System.Drawing.Point(194, 8);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(194, 24);
            this.label12.TabIndex = 0;
            this.label12.Text = "Diagnosis Summary";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(267, 107);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(116, 20);
            this.txtSearch.TabIndex = 42;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(203, 109);
            this.Search.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(53, 17);
            this.Search.TabIndex = 41;
            this.Search.Text = "Search";
            // 
            // patientnametxt
            // 
            this.patientnametxt.Location = new System.Drawing.Point(110, 40);
            this.patientnametxt.Margin = new System.Windows.Forms.Padding(2);
            this.patientnametxt.Name = "patientnametxt";
            this.patientnametxt.Size = new System.Drawing.Size(326, 20);
            this.patientnametxt.TabIndex = 43;
            // 
            // diagnosistxt
            // 
            this.diagnosistxt.Location = new System.Drawing.Point(110, 74);
            this.diagnosistxt.Margin = new System.Windows.Forms.Padding(2);
            this.diagnosistxt.Name = "diagnosistxt";
            this.diagnosistxt.Size = new System.Drawing.Size(326, 20);
            this.diagnosistxt.TabIndex = 44;
            // 
            // symptomstxt
            // 
            this.symptomstxt.Location = new System.Drawing.Point(110, 110);
            this.symptomstxt.Margin = new System.Windows.Forms.Padding(2);
            this.symptomstxt.Name = "symptomstxt";
            this.symptomstxt.Size = new System.Drawing.Size(326, 20);
            this.symptomstxt.TabIndex = 45;
            // 
            // medicinestxt
            // 
            this.medicinestxt.Location = new System.Drawing.Point(110, 146);
            this.medicinestxt.Margin = new System.Windows.Forms.Padding(2);
            this.medicinestxt.Name = "medicinestxt";
            this.medicinestxt.Size = new System.Drawing.Size(326, 20);
            this.medicinestxt.TabIndex = 46;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(110, 179);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(326, 20);
            this.textBox5.TabIndex = 47;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Aqua;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(248, 684);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 26);
            this.button5.TabIndex = 43;
            this.button5.Text = "Print";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Diagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 723);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DiagnosdataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Medicin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Diagnos);
            this.Controls.Add(this.diagno);
            this.Controls.Add(this.DiaSymp);
            this.Controls.Add(this.ptName);
            this.Controls.Add(this.ptID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DocID);
            this.Controls.Add(this.DiaID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Diagnosis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diagnosis";
            this.Load += new System.EventHandler(this.Diagnosis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosdataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DiaID;
        private System.Windows.Forms.Label DocID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ptID;
        private System.Windows.Forms.TextBox ptName;
        private System.Windows.Forms.TextBox DiaSymp;
        private System.Windows.Forms.TextBox diagno;
        private System.Windows.Forms.Label Diagnos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Medicin;
        private System.Windows.Forms.DataGridView DiagnosdataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Medicineslbl;
        private System.Windows.Forms.Label Symptomslbl;
        private System.Windows.Forms.Label Diagnosislbl;
        private System.Windows.Forms.Label PatientNamelbl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox medicinestxt;
        private System.Windows.Forms.TextBox symptomstxt;
        private System.Windows.Forms.TextBox diagnosistxt;
        private System.Windows.Forms.TextBox patientnametxt;
        private System.Windows.Forms.Button button5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}