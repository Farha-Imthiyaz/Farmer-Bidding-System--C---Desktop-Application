namespace AD
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.btnsave = new System.Windows.Forms.Button();
            this.tBGAID = new System.Windows.Forms.TextBox();
            this.dtpickerdob = new System.Windows.Forms.DateTimePicker();
            this.cbgender = new System.Windows.Forms.ComboBox();
            this.cbusertype = new System.Windows.Forms.ComboBox();
            this.lblregistration = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lbldob = new System.Windows.Forms.Label();
            this.lblusertype = new System.Windows.Forms.Label();
            this.lblnicno = new System.Windows.Forms.Label();
            this.tBnicno = new System.Windows.Forms.TextBox();
            this.lblGAID = new System.Windows.Forms.Label();
            this.tBpassword = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.tBusername = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblphonenumber = new System.Windows.Forms.Label();
            this.tBaddress = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.tBphonnumber = new System.Windows.Forms.TextBox();
            this.lblfullname = new System.Windows.Forms.Label();
            this.tBfullname = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.tBemail = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.tBsearch = new System.Windows.Forms.TextBox();
            this.dGVuser = new System.Windows.Forms.DataGridView();
            this.paneltop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelleftside = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVuser)).BeginInit();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelleftside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(138)))), ((int)(((byte)(7)))));
            this.btnsave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnsave.Location = new System.Drawing.Point(317, 535);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(86, 45);
            this.btnsave.TabIndex = 46;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // tBGAID
            // 
            this.tBGAID.Location = new System.Drawing.Point(372, 493);
            this.tBGAID.Name = "tBGAID";
            this.tBGAID.Size = new System.Drawing.Size(235, 20);
            this.tBGAID.TabIndex = 45;
            this.tBGAID.TextChanged += new System.EventHandler(this.tBGAID_TextChanged);
            // 
            // dtpickerdob
            // 
            this.dtpickerdob.CustomFormat = "dateTimePicker1.Format = DateTimePickerFormat.Custom;";
            this.dtpickerdob.Location = new System.Drawing.Point(372, 375);
            this.dtpickerdob.Name = "dtpickerdob";
            this.dtpickerdob.Size = new System.Drawing.Size(233, 20);
            this.dtpickerdob.TabIndex = 44;
            this.dtpickerdob.Value = new System.DateTime(2018, 12, 12, 6, 9, 57, 0);
            this.dtpickerdob.ValueChanged += new System.EventHandler(this.dtpickerdob_ValueChanged);
            // 
            // cbgender
            // 
            this.cbgender.FormattingEnabled = true;
            this.cbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbgender.Location = new System.Drawing.Point(372, 336);
            this.cbgender.Name = "cbgender";
            this.cbgender.Size = new System.Drawing.Size(233, 21);
            this.cbgender.TabIndex = 43;
            this.cbgender.SelectedIndexChanged += new System.EventHandler(this.cbgender_SelectedIndexChanged);
            // 
            // cbusertype
            // 
            this.cbusertype.FormattingEnabled = true;
            this.cbusertype.Items.AddRange(new object[] {
            "Farmer",
            "Miller",
            "Small Farming Cooperative Agency",
            "Agriculture Cooperative Agency"});
            this.cbusertype.Location = new System.Drawing.Point(368, 211);
            this.cbusertype.Name = "cbusertype";
            this.cbusertype.Size = new System.Drawing.Size(235, 21);
            this.cbusertype.TabIndex = 42;
            this.cbusertype.SelectedIndexChanged += new System.EventHandler(this.cbusertype_SelectedIndexChanged);
            // 
            // lblregistration
            // 
            this.lblregistration.AutoSize = true;
            this.lblregistration.Location = new System.Drawing.Point(428, 31);
            this.lblregistration.Name = "lblregistration";
            this.lblregistration.Size = new System.Drawing.Size(66, 13);
            this.lblregistration.TabIndex = 41;
            this.lblregistration.Text = "Registration ";
            this.lblregistration.Click += new System.EventHandler(this.lblregistration_Click);
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(275, 339);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(50, 16);
            this.lblgender.TabIndex = 40;
            this.lblgender.Text = "Gender";
            this.lblgender.Click += new System.EventHandler(this.lblgender_Click);
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldob.Location = new System.Drawing.Point(275, 381);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(83, 16);
            this.lbldob.TabIndex = 38;
            this.lbldob.Text = "Date Of Birth";
            this.lbldob.Click += new System.EventHandler(this.lbldob_Click);
            // 
            // lblusertype
            // 
            this.lblusertype.AutoSize = true;
            this.lblusertype.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusertype.Location = new System.Drawing.Point(270, 214);
            this.lblusertype.Name = "lblusertype";
            this.lblusertype.Size = new System.Drawing.Size(66, 16);
            this.lblusertype.TabIndex = 37;
            this.lblusertype.Text = "User Type";
            this.lblusertype.Click += new System.EventHandler(this.lblusertype_Click);
            // 
            // lblnicno
            // 
            this.lblnicno.AutoSize = true;
            this.lblnicno.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnicno.Location = new System.Drawing.Point(281, 416);
            this.lblnicno.Name = "lblnicno";
            this.lblnicno.Size = new System.Drawing.Size(47, 16);
            this.lblnicno.TabIndex = 36;
            this.lblnicno.Text = "NIC no";
            this.lblnicno.Click += new System.EventHandler(this.lblnicno_Click);
            // 
            // tBnicno
            // 
            this.tBnicno.Location = new System.Drawing.Point(372, 410);
            this.tBnicno.Name = "tBnicno";
            this.tBnicno.Size = new System.Drawing.Size(233, 20);
            this.tBnicno.TabIndex = 34;
            this.tBnicno.TextChanged += new System.EventHandler(this.tBnicno_TextChanged);
            // 
            // lblGAID
            // 
            this.lblGAID.AutoSize = true;
            this.lblGAID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGAID.Location = new System.Drawing.Point(268, 493);
            this.lblGAID.Name = "lblGAID";
            this.lblGAID.Size = new System.Drawing.Size(102, 16);
            this.lblGAID.TabIndex = 35;
            this.lblGAID.Text = "Gov Approved ID";
            this.lblGAID.Click += new System.EventHandler(this.lblGAID_Click);
            // 
            // tBpassword
            // 
            this.tBpassword.Location = new System.Drawing.Point(370, 294);
            this.tBpassword.Name = "tBpassword";
            this.tBpassword.Size = new System.Drawing.Size(233, 20);
            this.tBpassword.TabIndex = 33;
            this.tBpassword.TextChanged += new System.EventHandler(this.tBpassword_TextChanged);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(273, 294);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(65, 16);
            this.lblpassword.TabIndex = 32;
            this.lblpassword.Text = "Password";
            this.lblpassword.Click += new System.EventHandler(this.lblpassword_Click);
            // 
            // tBusername
            // 
            this.tBusername.Location = new System.Drawing.Point(370, 254);
            this.tBusername.Name = "tBusername";
            this.tBusername.Size = new System.Drawing.Size(233, 20);
            this.tBusername.TabIndex = 31;
            this.tBusername.TextChanged += new System.EventHandler(this.tBusername_TextChanged);
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(271, 254);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(67, 16);
            this.lblusername.TabIndex = 30;
            this.lblusername.Text = "Username";
            this.lblusername.Click += new System.EventHandler(this.lblusername_Click);
            // 
            // lblphonenumber
            // 
            this.lblphonenumber.AutoSize = true;
            this.lblphonenumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphonenumber.Location = new System.Drawing.Point(268, 173);
            this.lblphonenumber.Name = "lblphonenumber";
            this.lblphonenumber.Size = new System.Drawing.Size(94, 16);
            this.lblphonenumber.TabIndex = 28;
            this.lblphonenumber.Text = "Phone Number";
            this.lblphonenumber.Click += new System.EventHandler(this.lblphonenumber_Click);
            // 
            // tBaddress
            // 
            this.tBaddress.Location = new System.Drawing.Point(368, 127);
            this.tBaddress.Name = "tBaddress";
            this.tBaddress.Size = new System.Drawing.Size(235, 20);
            this.tBaddress.TabIndex = 27;
            this.tBaddress.TextChanged += new System.EventHandler(this.tBaddress_TextChanged);
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(268, 130);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(56, 16);
            this.lbladdress.TabIndex = 26;
            this.lbladdress.Text = "Address";
            this.lbladdress.Click += new System.EventHandler(this.lbladdress_Click);
            // 
            // tBphonnumber
            // 
            this.tBphonnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBphonnumber.Location = new System.Drawing.Point(368, 170);
            this.tBphonnumber.Name = "tBphonnumber";
            this.tBphonnumber.Size = new System.Drawing.Size(235, 20);
            this.tBphonnumber.TabIndex = 25;
            this.tBphonnumber.TextChanged += new System.EventHandler(this.tBphonnumber_TextChanged);
            // 
            // lblfullname
            // 
            this.lblfullname.AutoSize = true;
            this.lblfullname.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfullname.Location = new System.Drawing.Point(270, 92);
            this.lblfullname.Name = "lblfullname";
            this.lblfullname.Size = new System.Drawing.Size(67, 16);
            this.lblfullname.TabIndex = 24;
            this.lblfullname.Text = "Full Name";
            this.lblfullname.Click += new System.EventHandler(this.lblfullname_Click);
            // 
            // tBfullname
            // 
            this.tBfullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBfullname.Location = new System.Drawing.Point(368, 92);
            this.tBfullname.Name = "tBfullname";
            this.tBfullname.Size = new System.Drawing.Size(235, 20);
            this.tBfullname.TabIndex = 23;
            this.tBfullname.TextChanged += new System.EventHandler(this.tBfullname_TextChanged);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(277, 449);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(41, 16);
            this.lblemail.TabIndex = 35;
            this.lblemail.Text = "Email";
            this.lblemail.Click += new System.EventHandler(this.lblemail_Click);
            // 
            // tBemail
            // 
            this.tBemail.Location = new System.Drawing.Point(370, 446);
            this.tBemail.Name = "tBemail";
            this.tBemail.Size = new System.Drawing.Size(235, 20);
            this.tBemail.TabIndex = 45;
            this.tBemail.TextChanged += new System.EventHandler(this.tBemail_TextChanged);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(138)))), ((int)(((byte)(7)))));
            this.btndelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btndelete.Location = new System.Drawing.Point(409, 535);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(86, 45);
            this.btndelete.TabIndex = 46;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(138)))), ((int)(((byte)(7)))));
            this.btnclear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnclear.Location = new System.Drawing.Point(510, 535);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(82, 45);
            this.btnclear.TabIndex = 46;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(138)))), ((int)(((byte)(7)))));
            this.btnsearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnsearch.Location = new System.Drawing.Point(982, 78);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(94, 34);
            this.btnsearch.TabIndex = 47;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // tBsearch
            // 
            this.tBsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBsearch.Location = new System.Drawing.Point(741, 89);
            this.tBsearch.Name = "tBsearch";
            this.tBsearch.Size = new System.Drawing.Size(235, 20);
            this.tBsearch.TabIndex = 23;
            this.tBsearch.TextChanged += new System.EventHandler(this.tBsearch_TextChanged);
            // 
            // dGVuser
            // 
            this.dGVuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVuser.Location = new System.Drawing.Point(621, 118);
            this.dGVuser.Name = "dGVuser";
            this.dGVuser.Size = new System.Drawing.Size(588, 437);
            this.dGVuser.TabIndex = 48;
            this.dGVuser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV2_CellContentClick);
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(138)))), ((int)(((byte)(7)))));
            this.paneltop.Controls.Add(this.pictureBox1);
            this.paneltop.Controls.Add(this.pictureBox3);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(200, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(1033, 72);
            this.paneltop.TabIndex = 50;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 65);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(940, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(81, 65);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panelleftside
            // 
            this.panelleftside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.panelleftside.Controls.Add(this.label2);
            this.panelleftside.Controls.Add(this.pictureBox2);
            this.panelleftside.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleftside.Location = new System.Drawing.Point(0, 0);
            this.panelleftside.Name = "panelleftside";
            this.panelleftside.Size = new System.Drawing.Size(200, 636);
            this.panelleftside.TabIndex = 49;
            this.panelleftside.Paint += new System.Windows.Forms.PaintEventHandler(this.panelleftside_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(4, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 45);
            this.label2.TabIndex = 49;
            this.label2.Text = "User Details";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(31, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 121);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 636);
            this.Controls.Add(this.paneltop);
            this.Controls.Add(this.panelleftside);
            this.Controls.Add(this.dGVuser);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.tBemail);
            this.Controls.Add(this.tBGAID);
            this.Controls.Add(this.dtpickerdob);
            this.Controls.Add(this.cbgender);
            this.Controls.Add(this.cbusertype);
            this.Controls.Add(this.lblregistration);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lbldob);
            this.Controls.Add(this.lblusertype);
            this.Controls.Add(this.lblnicno);
            this.Controls.Add(this.tBnicno);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblGAID);
            this.Controls.Add(this.tBpassword);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.tBusername);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lblphonenumber);
            this.Controls.Add(this.tBaddress);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.tBphonnumber);
            this.Controls.Add(this.lblfullname);
            this.Controls.Add(this.tBsearch);
            this.Controls.Add(this.tBfullname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.Text = "AdminUser";
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVuser)).EndInit();
            this.paneltop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelleftside.ResumeLayout(false);
            this.panelleftside.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox tBGAID;
        private System.Windows.Forms.DateTimePicker dtpickerdob;
        private System.Windows.Forms.ComboBox cbgender;
        private System.Windows.Forms.ComboBox cbusertype;
        private System.Windows.Forms.Label lblregistration;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.Label lblusertype;
        private System.Windows.Forms.Label lblnicno;
        private System.Windows.Forms.TextBox tBnicno;
        private System.Windows.Forms.Label lblGAID;
        private System.Windows.Forms.TextBox tBpassword;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox tBusername;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblphonenumber;
        private System.Windows.Forms.TextBox tBaddress;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox tBphonnumber;
        private System.Windows.Forms.Label lblfullname;
        private System.Windows.Forms.TextBox tBfullname;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox tBemail;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox tBsearch;
        private System.Windows.Forms.DataGridView dGVuser;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panelleftside;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}