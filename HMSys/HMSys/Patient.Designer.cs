namespace HMSys
{
    partial class Patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient));
            this.label1 = new System.Windows.Forms.Label();
            this.DocID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ptID = new System.Windows.Forms.TextBox();
            this.ptName = new System.Windows.Forms.TextBox();
            this.ptAddress = new System.Windows.Forms.TextBox();
            this.ptPhone = new System.Windows.Forms.TextBox();
            this.ptAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.BloodGroup = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MajorDisease = new System.Windows.Forms.TextBox();
            this.PatientdataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PatientdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(62, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 78);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hospital Management System\r\n                   Patient";
            // 
            // DocID
            // 
            this.DocID.AutoSize = true;
            this.DocID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocID.Location = new System.Drawing.Point(66, 159);
            this.DocID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DocID.Name = "DocID";
            this.DocID.Size = new System.Drawing.Size(69, 17);
            this.DocID.TabIndex = 23;
            this.DocID.Text = "Patient ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Patient Name";
            // 
            // ptID
            // 
            this.ptID.Location = new System.Drawing.Point(190, 158);
            this.ptID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ptID.Name = "ptID";
            this.ptID.Size = new System.Drawing.Size(342, 20);
            this.ptID.TabIndex = 25;
            // 
            // ptName
            // 
            this.ptName.Location = new System.Drawing.Point(190, 186);
            this.ptName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ptName.Name = "ptName";
            this.ptName.Size = new System.Drawing.Size(342, 20);
            this.ptName.TabIndex = 26;
            // 
            // ptAddress
            // 
            this.ptAddress.Location = new System.Drawing.Point(190, 210);
            this.ptAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ptAddress.Name = "ptAddress";
            this.ptAddress.Size = new System.Drawing.Size(342, 20);
            this.ptAddress.TabIndex = 27;
            // 
            // ptPhone
            // 
            this.ptPhone.Location = new System.Drawing.Point(190, 232);
            this.ptPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ptPhone.Name = "ptPhone";
            this.ptPhone.Size = new System.Drawing.Size(342, 20);
            this.ptPhone.TabIndex = 28;
            // 
            // ptAge
            // 
            this.ptAge.Location = new System.Drawing.Point(190, 255);
            this.ptAge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ptAge.Name = "ptAge";
            this.ptAge.Size = new System.Drawing.Size(342, 20);
            this.ptAge.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 257);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Patient Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 234);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Patient Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 211);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Patient Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 280);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Gender";
            // 
            // Gender
            // 
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gender.Location = new System.Drawing.Point(190, 276);
            this.Gender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(342, 21);
            this.Gender.TabIndex = 35;
            // 
            // BloodGroup
            // 
            this.BloodGroup.FormattingEnabled = true;
            this.BloodGroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.BloodGroup.Location = new System.Drawing.Point(190, 301);
            this.BloodGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BloodGroup.Name = "BloodGroup";
            this.BloodGroup.Size = new System.Drawing.Size(342, 21);
            this.BloodGroup.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 304);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "Blood Group";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(66, 328);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "Major Disease";
            // 
            // MajorDisease
            // 
            this.MajorDisease.Location = new System.Drawing.Point(190, 327);
            this.MajorDisease.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MajorDisease.Name = "MajorDisease";
            this.MajorDisease.Size = new System.Drawing.Size(342, 20);
            this.MajorDisease.TabIndex = 39;
            // 
            // PatientdataGridView1
            // 
            this.PatientdataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.PatientdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientdataGridView1.Location = new System.Drawing.Point(69, 361);
            this.PatientdataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PatientdataGridView1.Name = "PatientdataGridView1";
            this.PatientdataGridView1.RowTemplate.Height = 24;
            this.PatientdataGridView1.Size = new System.Drawing.Size(461, 115);
            this.PatientdataGridView1.TabIndex = 44;
            this.PatientdataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientdataGridView1_CellClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Aqua;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(406, 481);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 26);
            this.button4.TabIndex = 43;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Aqua;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(310, 481);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 26);
            this.button3.TabIndex = 42;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aqua;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(213, 481);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 26);
            this.button2.TabIndex = 41;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(116, 481);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 26);
            this.button1.TabIndex = 40;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(296, 113);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(116, 20);
            this.txtSearch.TabIndex = 46;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(232, 115);
            this.Search.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(53, 17);
            this.Search.TabIndex = 45;
            this.Search.Text = "Search";
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 534);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.PatientdataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MajorDisease);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BloodGroup);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ptAge);
            this.Controls.Add(this.ptPhone);
            this.Controls.Add(this.ptAddress);
            this.Controls.Add(this.ptName);
            this.Controls.Add(this.ptID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DocID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.Patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PatientdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DocID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ptID;
        private System.Windows.Forms.TextBox ptName;
        private System.Windows.Forms.TextBox ptAddress;
        private System.Windows.Forms.TextBox ptPhone;
        private System.Windows.Forms.TextBox ptAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.ComboBox BloodGroup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MajorDisease;
        private System.Windows.Forms.DataGridView PatientdataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label Search;
    }
}