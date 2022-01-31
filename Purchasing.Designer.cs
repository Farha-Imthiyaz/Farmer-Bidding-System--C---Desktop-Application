namespace AD
{
    partial class Purchasing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchasing));
            this.lblPurchaseUP = new System.Windows.Forms.Label();
            this.tBPUPrice = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.tBPName = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.tBQuantity = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.tBTotalPrice = new System.Windows.Forms.TextBox();
            this.lblPType = new System.Windows.Forms.Label();
            this.lblPdate = new System.Windows.Forms.Label();
            this.cBPaymentType = new System.Windows.Forms.ComboBox();
            this.dateTimePickerPurchase = new System.Windows.Forms.DateTimePicker();
            this.dGPurchase = new System.Windows.Forms.DataGridView();
            this.tBSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.paneltop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelleftside = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGPurchase)).BeginInit();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelleftside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPurchaseUP
            // 
            this.lblPurchaseUP.AutoSize = true;
            this.lblPurchaseUP.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblPurchaseUP.Location = new System.Drawing.Point(208, 96);
            this.lblPurchaseUP.Name = "lblPurchaseUP";
            this.lblPurchaseUP.Size = new System.Drawing.Size(124, 16);
            this.lblPurchaseUP.TabIndex = 3;
            this.lblPurchaseUP.Text = "Purchase Unit Price";
            this.lblPurchaseUP.Click += new System.EventHandler(this.label2_Click);
            // 
            // tBPUPrice
            // 
            this.tBPUPrice.Location = new System.Drawing.Point(338, 93);
            this.tBPUPrice.Name = "tBPUPrice";
            this.tBPUPrice.ReadOnly = true;
            this.tBPUPrice.Size = new System.Drawing.Size(192, 20);
            this.tBPUPrice.TabIndex = 2;
            this.tBPUPrice.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblProductName.Location = new System.Drawing.Point(225, 147);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(91, 16);
            this.lblProductName.TabIndex = 7;
            this.lblProductName.Text = "Product Name";
            this.lblProductName.Click += new System.EventHandler(this.lblProductName_Click);
            // 
            // tBPName
            // 
            this.tBPName.Location = new System.Drawing.Point(338, 143);
            this.tBPName.Name = "tBPName";
            this.tBPName.ReadOnly = true;
            this.tBPName.Size = new System.Drawing.Size(192, 20);
            this.tBPName.TabIndex = 6;
            this.tBPName.TextChanged += new System.EventHandler(this.tBPName_TextChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblQuantity.Location = new System.Drawing.Point(225, 207);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(57, 16);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Quantity";
            this.lblQuantity.Click += new System.EventHandler(this.lblQuantity_Click);
            // 
            // tBQuantity
            // 
            this.tBQuantity.Location = new System.Drawing.Point(338, 204);
            this.tBQuantity.Name = "tBQuantity";
            this.tBQuantity.ReadOnly = true;
            this.tBQuantity.Size = new System.Drawing.Size(192, 20);
            this.tBQuantity.TabIndex = 8;
            this.tBQuantity.TextChanged += new System.EventHandler(this.tBQuantity_TextChanged);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblTotalPrice.Location = new System.Drawing.Point(225, 270);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(69, 16);
            this.lblTotalPrice.TabIndex = 13;
            this.lblTotalPrice.Text = "Total Price";
            this.lblTotalPrice.Click += new System.EventHandler(this.lblTotalPrice_Click);
            // 
            // tBTotalPrice
            // 
            this.tBTotalPrice.Location = new System.Drawing.Point(338, 263);
            this.tBTotalPrice.Name = "tBTotalPrice";
            this.tBTotalPrice.ReadOnly = true;
            this.tBTotalPrice.Size = new System.Drawing.Size(192, 20);
            this.tBTotalPrice.TabIndex = 12;
            this.tBTotalPrice.TextChanged += new System.EventHandler(this.tBTotalPrice_TextChanged);
            // 
            // lblPType
            // 
            this.lblPType.AutoSize = true;
            this.lblPType.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblPType.Location = new System.Drawing.Point(225, 379);
            this.lblPType.Name = "lblPType";
            this.lblPType.Size = new System.Drawing.Size(91, 16);
            this.lblPType.TabIndex = 13;
            this.lblPType.Text = "Payment Type";
            this.lblPType.Click += new System.EventHandler(this.lblPType_Click);
            // 
            // lblPdate
            // 
            this.lblPdate.AutoSize = true;
            this.lblPdate.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblPdate.Location = new System.Drawing.Point(225, 325);
            this.lblPdate.Name = "lblPdate";
            this.lblPdate.Size = new System.Drawing.Size(35, 16);
            this.lblPdate.TabIndex = 13;
            this.lblPdate.Text = "Date";
            this.lblPdate.Click += new System.EventHandler(this.lblPdate_Click);
            // 
            // cBPaymentType
            // 
            this.cBPaymentType.FormattingEnabled = true;
            this.cBPaymentType.Items.AddRange(new object[] {
            "Online Payment",
            "Cash On Delivery"});
            this.cBPaymentType.Location = new System.Drawing.Point(338, 376);
            this.cBPaymentType.Name = "cBPaymentType";
            this.cBPaymentType.Size = new System.Drawing.Size(192, 21);
            this.cBPaymentType.TabIndex = 14;
            this.cBPaymentType.SelectedIndexChanged += new System.EventHandler(this.cBPaymentType_SelectedIndexChanged);
            // 
            // dateTimePickerPurchase
            // 
            this.dateTimePickerPurchase.Location = new System.Drawing.Point(338, 325);
            this.dateTimePickerPurchase.Name = "dateTimePickerPurchase";
            this.dateTimePickerPurchase.Size = new System.Drawing.Size(192, 20);
            this.dateTimePickerPurchase.TabIndex = 15;
            this.dateTimePickerPurchase.ValueChanged += new System.EventHandler(this.dateTimePickerPurchase_ValueChanged);
            // 
            // dGPurchase
            // 
            this.dGPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGPurchase.Location = new System.Drawing.Point(556, 122);
            this.dGPurchase.Name = "dGPurchase";
            this.dGPurchase.Size = new System.Drawing.Size(492, 393);
            this.dGPurchase.TabIndex = 16;
            this.dGPurchase.DoubleClick += new System.EventHandler(this.dGPurchase_DoubleClick);
            // 
            // tBSearch
            // 
            this.tBSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSearch.Location = new System.Drawing.Point(605, 87);
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.Size = new System.Drawing.Size(192, 22);
            this.tBSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(138)))), ((int)(((byte)(7)))));
            this.btnSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(803, 83);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 29);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(138)))), ((int)(((byte)(7)))));
            this.btnSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(206, 435);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 34);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(138)))), ((int)(((byte)(7)))));
            this.btnClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(442, 435);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(77, 34);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(138)))), ((int)(((byte)(7)))));
            this.btnDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(325, 435);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 34);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(138)))), ((int)(((byte)(7)))));
            this.paneltop.Controls.Add(this.pictureBox1);
            this.paneltop.Controls.Add(this.pictureBox3);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(200, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(860, 72);
            this.paneltop.TabIndex = 23;
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
            this.pictureBox3.Location = new System.Drawing.Point(757, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 57);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panelleftside
            // 
            this.panelleftside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.panelleftside.Controls.Add(this.label1);
            this.panelleftside.Controls.Add(this.pictureBox2);
            this.panelleftside.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleftside.Location = new System.Drawing.Point(0, 0);
            this.panelleftside.Name = "panelleftside";
            this.panelleftside.Size = new System.Drawing.Size(200, 562);
            this.panelleftside.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 45);
            this.label1.TabIndex = 49;
            this.label1.Text = "Purchase ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(21, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 121);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Purchasing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 562);
            this.Controls.Add(this.paneltop);
            this.Controls.Add(this.panelleftside);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dGPurchase);
            this.Controls.Add(this.dateTimePickerPurchase);
            this.Controls.Add(this.cBPaymentType);
            this.Controls.Add(this.lblPdate);
            this.Controls.Add(this.lblPType);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.tBTotalPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.tBQuantity);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.tBPName);
            this.Controls.Add(this.lblPurchaseUP);
            this.Controls.Add(this.tBPUPrice);
            this.Controls.Add(this.tBSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Purchasing";
            this.Text = "Purchasing";
            this.Load += new System.EventHandler(this.Purchasing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGPurchase)).EndInit();
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

        private System.Windows.Forms.Label lblPurchaseUP;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox tBTotalPrice;
        private System.Windows.Forms.Label lblPType;
        private System.Windows.Forms.Label lblPdate;
        private System.Windows.Forms.ComboBox cBPaymentType;
        private System.Windows.Forms.DateTimePicker dateTimePickerPurchase;
        public System.Windows.Forms.TextBox tBPUPrice;
        public System.Windows.Forms.TextBox tBPName;
        public System.Windows.Forms.TextBox tBQuantity;
        private System.Windows.Forms.DataGridView dGPurchase;
        public System.Windows.Forms.TextBox tBSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panelleftside;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}