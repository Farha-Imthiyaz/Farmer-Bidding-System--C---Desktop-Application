namespace AD
{
    partial class Signup
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.btnsave = new System.Windows.Forms.Button();
            this.tBemail = new System.Windows.Forms.TextBox();
            this.tBGAID = new System.Windows.Forms.TextBox();
            this.dtpickerdob = new System.Windows.Forms.DateTimePicker();
            this.cbgender = new System.Windows.Forms.ComboBox();
            this.cbusertype = new System.Windows.Forms.ComboBox();
            this.lblgender = new System.Windows.Forms.Label();
            this.lbldob = new System.Windows.Forms.Label();
            this.lblusertype = new System.Windows.Forms.Label();
            this.lblnicno = new System.Windows.Forms.Label();
            this.tBnicno = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(506, 940);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(100, 32);
            this.btnsave.TabIndex = 72;
            this.btnsave.Text = "SignUp";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // tBemail
            // 
            this.tBemail.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBemail.Location = new System.Drawing.Point(368, 792);
            this.tBemail.Margin = new System.Windows.Forms.Padding(4);
            this.tBemail.Name = "tBemail";
            this.tBemail.Size = new System.Drawing.Size(312, 20);
            this.tBemail.TabIndex = 71;
            this.tBemail.TextChanged += new System.EventHandler(this.tBemail_TextChanged);
            // 
            // tBGAID
            // 
            this.tBGAID.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBGAID.Location = new System.Drawing.Point(370, 858);
            this.tBGAID.Margin = new System.Windows.Forms.Padding(4);
            this.tBGAID.Name = "tBGAID";
            this.tBGAID.Size = new System.Drawing.Size(312, 20);
            this.tBGAID.TabIndex = 70;
            this.tBGAID.TextChanged += new System.EventHandler(this.tBGAID_TextChanged);
            // 
            // dtpickerdob
            // 
            this.dtpickerdob.CustomFormat = "dateTimePicker1.Format = DateTimePickerFormat.Custom;";
            this.dtpickerdob.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpickerdob.Location = new System.Drawing.Point(374, 395);
            this.dtpickerdob.Margin = new System.Windows.Forms.Padding(4);
            this.dtpickerdob.Name = "dtpickerdob";
            this.dtpickerdob.Size = new System.Drawing.Size(309, 20);
            this.dtpickerdob.TabIndex = 69;
            this.dtpickerdob.Value = new System.DateTime(2018, 12, 12, 6, 9, 57, 0);
            this.dtpickerdob.ValueChanged += new System.EventHandler(this.dtpickerdob_ValueChanged);
            // 
            // cbgender
            // 
            this.cbgender.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbgender.FormattingEnabled = true;
            this.cbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbgender.Location = new System.Drawing.Point(374, 354);
            this.cbgender.Margin = new System.Windows.Forms.Padding(4);
            this.cbgender.Name = "cbgender";
            this.cbgender.Size = new System.Drawing.Size(309, 22);
            this.cbgender.TabIndex = 68;
            this.cbgender.SelectedIndexChanged += new System.EventHandler(this.cbgender_SelectedIndexChanged);
            // 
            // cbusertype
            // 
            this.cbusertype.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbusertype.FormattingEnabled = true;
            this.cbusertype.Items.AddRange(new object[] {
            "Farmer",
            "Miller",
            "SFCA",
            "Admin"});
            this.cbusertype.Location = new System.Drawing.Point(374, 232);
            this.cbusertype.Margin = new System.Windows.Forms.Padding(4);
            this.cbusertype.Name = "cbusertype";
            this.cbusertype.Size = new System.Drawing.Size(312, 22);
            this.cbusertype.TabIndex = 67;
            this.cbusertype.SelectedIndexChanged += new System.EventHandler(this.cbusertype_SelectedIndexChanged);
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblgender.Location = new System.Drawing.Point(261, 355);
            this.lblgender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(50, 16);
            this.lblgender.TabIndex = 65;
            this.lblgender.Text = "Gender";
            this.lblgender.Click += new System.EventHandler(this.lblgender_Click);
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lbldob.Location = new System.Drawing.Point(261, 395);
            this.lbldob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(83, 16);
            this.lbldob.TabIndex = 63;
            this.lbldob.Text = "Date Of Birth";
            this.lbldob.Click += new System.EventHandler(this.lbldob_Click);
            // 
            // lblusertype
            // 
            this.lblusertype.AutoSize = true;
            this.lblusertype.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblusertype.Location = new System.Drawing.Point(253, 233);
            this.lblusertype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblusertype.Name = "lblusertype";
            this.lblusertype.Size = new System.Drawing.Size(66, 16);
            this.lblusertype.TabIndex = 62;
            this.lblusertype.Text = "User Type";
            this.lblusertype.Click += new System.EventHandler(this.lblusertype_Click);
            // 
            // lblnicno
            // 
            this.lblnicno.AutoSize = true;
            this.lblnicno.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblnicno.Location = new System.Drawing.Point(261, 437);
            this.lblnicno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnicno.Name = "lblnicno";
            this.lblnicno.Size = new System.Drawing.Size(47, 16);
            this.lblnicno.TabIndex = 61;
            this.lblnicno.Text = "NIC no";
            this.lblnicno.Click += new System.EventHandler(this.lblnicno_Click);
            // 
            // tBnicno
            // 
            this.tBnicno.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBnicno.Location = new System.Drawing.Point(374, 433);
            this.tBnicno.Margin = new System.Windows.Forms.Padding(4);
            this.tBnicno.Name = "tBnicno";
            this.tBnicno.Size = new System.Drawing.Size(309, 20);
            this.tBnicno.TabIndex = 58;
            this.tBnicno.TextChanged += new System.EventHandler(this.tBnicno_TextChanged);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(244, 796);
            this.lblemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(31, 14);
            this.lblemail.TabIndex = 60;
            this.lblemail.Text = "Email";
            this.lblemail.Click += new System.EventHandler(this.lblemail_Click);
            // 
            // lblGAID
            // 
            this.lblGAID.AutoSize = true;
            this.lblGAID.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGAID.Location = new System.Drawing.Point(246, 863);
            this.lblGAID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGAID.Name = "lblGAID";
            this.lblGAID.Size = new System.Drawing.Size(89, 14);
            this.lblGAID.TabIndex = 59;
            this.lblGAID.Text = "Gov Approved ID";
            this.lblGAID.Click += new System.EventHandler(this.lblGAID_Click);
            // 
            // tBpassword
            // 
            this.tBpassword.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBpassword.Location = new System.Drawing.Point(374, 311);
            this.tBpassword.Margin = new System.Windows.Forms.Padding(4);
            this.tBpassword.Name = "tBpassword";
            this.tBpassword.Size = new System.Drawing.Size(309, 20);
            this.tBpassword.TabIndex = 57;
            this.tBpassword.TextChanged += new System.EventHandler(this.tBpassword_TextChanged);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblpassword.Location = new System.Drawing.Point(257, 311);
            this.lblpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(65, 16);
            this.lblpassword.TabIndex = 56;
            this.lblpassword.Text = "Password";
            this.lblpassword.Click += new System.EventHandler(this.lblpassword_Click);
            // 
            // tBusername
            // 
            this.tBusername.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBusername.Location = new System.Drawing.Point(374, 273);
            this.tBusername.Margin = new System.Windows.Forms.Padding(4);
            this.tBusername.Name = "tBusername";
            this.tBusername.Size = new System.Drawing.Size(309, 20);
            this.tBusername.TabIndex = 55;
            this.tBusername.TextChanged += new System.EventHandler(this.tBusername_TextChanged);
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblusername.Location = new System.Drawing.Point(253, 273);
            this.lblusername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(67, 16);
            this.lblusername.TabIndex = 54;
            this.lblusername.Text = "Username";
            this.lblusername.Click += new System.EventHandler(this.lblusername_Click);
            // 
            // lblphonenumber
            // 
            this.lblphonenumber.AutoSize = true;
            this.lblphonenumber.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblphonenumber.Location = new System.Drawing.Point(245, 192);
            this.lblphonenumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblphonenumber.Name = "lblphonenumber";
            this.lblphonenumber.Size = new System.Drawing.Size(94, 16);
            this.lblphonenumber.TabIndex = 52;
            this.lblphonenumber.Text = "Phone Number";
            this.lblphonenumber.Click += new System.EventHandler(this.lblphonenumber_Click);
            // 
            // tBaddress
            // 
            this.tBaddress.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBaddress.Location = new System.Drawing.Point(374, 150);
            this.tBaddress.Margin = new System.Windows.Forms.Padding(4);
            this.tBaddress.Name = "tBaddress";
            this.tBaddress.Size = new System.Drawing.Size(312, 20);
            this.tBaddress.TabIndex = 51;
            this.tBaddress.TextChanged += new System.EventHandler(this.tBaddress_TextChanged);
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lbladdress.Location = new System.Drawing.Point(244, 153);
            this.lbladdress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(56, 16);
            this.lbladdress.TabIndex = 50;
            this.lbladdress.Text = "Address";
            this.lbladdress.Click += new System.EventHandler(this.lbladdress_Click);
            // 
            // tBphonnumber
            // 
            this.tBphonnumber.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBphonnumber.Location = new System.Drawing.Point(374, 192);
            this.tBphonnumber.Margin = new System.Windows.Forms.Padding(4);
            this.tBphonnumber.Name = "tBphonnumber";
            this.tBphonnumber.Size = new System.Drawing.Size(312, 20);
            this.tBphonnumber.TabIndex = 49;
            this.tBphonnumber.TextChanged += new System.EventHandler(this.tBphonnumber_TextChanged);
            // 
            // lblfullname
            // 
            this.lblfullname.AutoSize = true;
            this.lblfullname.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblfullname.Location = new System.Drawing.Point(244, 112);
            this.lblfullname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfullname.Name = "lblfullname";
            this.lblfullname.Size = new System.Drawing.Size(67, 16);
            this.lblfullname.TabIndex = 48;
            this.lblfullname.Text = "Full Name";
            this.lblfullname.Click += new System.EventHandler(this.lblfullname_Click);
            // 
            // tBfullname
            // 
            this.tBfullname.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBfullname.Location = new System.Drawing.Point(374, 112);
            this.tBfullname.Margin = new System.Windows.Forms.Padding(4);
            this.tBfullname.Name = "tBfullname";
            this.tBfullname.Size = new System.Drawing.Size(312, 20);
            this.tBfullname.TabIndex = 47;
            this.tBfullname.TextChanged += new System.EventHandler(this.tBfullname_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 635);
            this.panel1.TabIndex = 73;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 79);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(173, 168);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 45);
            this.label1.TabIndex = 48;
            this.label1.Text = "Registration";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(138)))), ((int)(((byte)(7)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(199, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 93);
            this.panel2.TabIndex = 74;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 65);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(498, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(102, 74);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(138)))), ((int)(((byte)(7)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(537, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 44);
            this.button1.TabIndex = 75;
            this.button1.Text = "Sign up";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial", 8.25F);
            this.textBox2.Location = new System.Drawing.Point(377, 472);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(309, 20);
            this.textBox2.TabIndex = 78;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.textBox1.Location = new System.Drawing.Point(377, 514);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 20);
            this.textBox1.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.Location = new System.Drawing.Point(264, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 76;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.Location = new System.Drawing.Point(261, 515);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 77;
            this.label3.Text = "Gov Approved ID";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 635);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.tBemail);
            this.Controls.Add(this.tBGAID);
            this.Controls.Add(this.dtpickerdob);
            this.Controls.Add(this.cbgender);
            this.Controls.Add(this.cbusertype);
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
            this.Controls.Add(this.tBfullname);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Signup";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox tBemail;
        private System.Windows.Forms.TextBox tBGAID;
        private System.Windows.Forms.DateTimePicker dtpickerdob;
        private System.Windows.Forms.ComboBox cbgender;
        private System.Windows.Forms.ComboBox cbusertype;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.Label lblusertype;
        private System.Windows.Forms.Label lblnicno;
        private System.Windows.Forms.TextBox tBnicno;
        private System.Windows.Forms.Label lblemail;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}