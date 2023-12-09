namespace eStore
{
    partial class CUItem
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
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblIsBuyable = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.rbBuyableYes = new System.Windows.Forms.RadioButton();
            this.rbBuyableNo = new System.Windows.Forms.RadioButton();
            this.rbOnSaleNo = new System.Windows.Forms.RadioButton();
            this.rbOnSaleYes = new System.Windows.Forms.RadioButton();
            this.lblIsOnSale = new System.Windows.Forms.Label();
            this.cmbSales = new System.Windows.Forms.ComboBox();
            this.lblAddItem = new System.Windows.Forms.Label();
            this.lblUpdateItem = new System.Windows.Forms.Label();
            this.btnSaveItem = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.dbConnection = new System.Data.SqlClient.SqlConnection();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.backButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(10, 332);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(618, 178);
            this.txtDesc.TabIndex = 0;
            this.txtDesc.Text = "";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(12, 311);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(125, 20);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Item Description";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 86);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Item Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(12, 158);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(80, 20);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Item Price";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(16, 118);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 26);
            this.txtName.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(16, 198);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(160, 26);
            this.txtPrice.TabIndex = 5;
            // 
            // lblIsBuyable
            // 
            this.lblIsBuyable.AutoSize = true;
            this.lblIsBuyable.Location = new System.Drawing.Point(362, 86);
            this.lblIsBuyable.Name = "lblIsBuyable";
            this.lblIsBuyable.Size = new System.Drawing.Size(165, 20);
            this.lblIsBuyable.TabIndex = 6;
            this.lblIsBuyable.Text = "Available to Purchase:";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(225, 198);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(91, 26);
            this.txtQty.TabIndex = 8;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(216, 158);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(100, 20);
            this.lblQty.TabIndex = 7;
            this.lblQty.Text = "Qty Available";
            // 
            // rbBuyableYes
            // 
            this.rbBuyableYes.AutoSize = true;
            this.rbBuyableYes.Location = new System.Drawing.Point(3, 3);
            this.rbBuyableYes.Name = "rbBuyableYes";
            this.rbBuyableYes.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.rbBuyableYes.Size = new System.Drawing.Size(92, 24);
            this.rbBuyableYes.TabIndex = 9;
            this.rbBuyableYes.TabStop = true;
            this.rbBuyableYes.Text = "Yes";
            this.rbBuyableYes.UseVisualStyleBackColor = true;
            this.rbBuyableYes.CheckedChanged += new System.EventHandler(this.rbBuyableYes_CheckedChanged);
            // 
            // rbBuyableNo
            // 
            this.rbBuyableNo.AutoSize = true;
            this.rbBuyableNo.Location = new System.Drawing.Point(101, 3);
            this.rbBuyableNo.Name = "rbBuyableNo";
            this.rbBuyableNo.Size = new System.Drawing.Size(54, 24);
            this.rbBuyableNo.TabIndex = 10;
            this.rbBuyableNo.TabStop = true;
            this.rbBuyableNo.Text = "No";
            this.rbBuyableNo.UseVisualStyleBackColor = true;
            this.rbBuyableNo.CheckedChanged += new System.EventHandler(this.rbBuyableNo_CheckedChanged);
            // 
            // rbOnSaleNo
            // 
            this.rbOnSaleNo.AutoSize = true;
            this.rbOnSaleNo.Location = new System.Drawing.Point(465, 212);
            this.rbOnSaleNo.Name = "rbOnSaleNo";
            this.rbOnSaleNo.Size = new System.Drawing.Size(54, 24);
            this.rbOnSaleNo.TabIndex = 13;
            this.rbOnSaleNo.TabStop = true;
            this.rbOnSaleNo.Text = "No";
            this.rbOnSaleNo.UseVisualStyleBackColor = true;
            this.rbOnSaleNo.CheckedChanged += new System.EventHandler(this.rbOnSaleNo_CheckedChanged);
            // 
            // rbOnSaleYes
            // 
            this.rbOnSaleYes.AutoSize = true;
            this.rbOnSaleYes.Location = new System.Drawing.Point(366, 212);
            this.rbOnSaleYes.Name = "rbOnSaleYes";
            this.rbOnSaleYes.Size = new System.Drawing.Size(62, 24);
            this.rbOnSaleYes.TabIndex = 12;
            this.rbOnSaleYes.TabStop = true;
            this.rbOnSaleYes.Text = "Yes";
            this.rbOnSaleYes.UseVisualStyleBackColor = true;
            this.rbOnSaleYes.CheckedChanged += new System.EventHandler(this.rbOnSaleYes_CheckedChanged);
            // 
            // lblIsOnSale
            // 
            this.lblIsOnSale.AutoSize = true;
            this.lblIsOnSale.Location = new System.Drawing.Point(362, 178);
            this.lblIsOnSale.Name = "lblIsOnSale";
            this.lblIsOnSale.Size = new System.Drawing.Size(84, 20);
            this.lblIsOnSale.TabIndex = 11;
            this.lblIsOnSale.Text = "Is on Sale:";
            // 
            // cmbSales
            // 
            this.cmbSales.FormattingEnabled = true;
            this.cmbSales.Location = new System.Drawing.Point(542, 212);
            this.cmbSales.Name = "cmbSales";
            this.cmbSales.Size = new System.Drawing.Size(188, 28);
            this.cmbSales.TabIndex = 14;
            // 
            // lblAddItem
            // 
            this.lblAddItem.AutoSize = true;
            this.lblAddItem.Location = new System.Drawing.Point(267, 25);
            this.lblAddItem.Name = "lblAddItem";
            this.lblAddItem.Size = new System.Drawing.Size(74, 20);
            this.lblAddItem.TabIndex = 15;
            this.lblAddItem.Text = "Add Item";
            // 
            // lblUpdateItem
            // 
            this.lblUpdateItem.AutoSize = true;
            this.lblUpdateItem.Location = new System.Drawing.Point(366, 25);
            this.lblUpdateItem.Name = "lblUpdateItem";
            this.lblUpdateItem.Size = new System.Drawing.Size(98, 20);
            this.lblUpdateItem.TabIndex = 16;
            this.lblUpdateItem.Text = "Update Item";
            // 
            // btnSaveItem
            // 
            this.btnSaveItem.Location = new System.Drawing.Point(642, 332);
            this.btnSaveItem.Name = "btnSaveItem";
            this.btnSaveItem.Size = new System.Drawing.Size(136, 138);
            this.btnSaveItem.TabIndex = 17;
            this.btnSaveItem.Text = "Add";
            this.btnSaveItem.UseVisualStyleBackColor = true;
            this.btnSaveItem.Click += new System.EventHandler(this.btnSaveItem_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(16, 49);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(58, 20);
            this.lblNumber.TabIndex = 18;
            this.lblNumber.Text = "Item#: ";
            // 
            // dbConnection
            // 
            this.dbConnection.ConnectionString = "Data Source=DESKTOP-8S93ROH;Initial Catalog=eStoreDatabase;Integrated Security=Tr" +
    "ue";
            this.dbConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(16, 275);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(300, 26);
            this.txtCategory.TabIndex = 20;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(12, 243);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(109, 20);
            this.lblCategory.TabIndex = 19;
            this.lblCategory.Text = "Item Category";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.rbBuyableYes);
            this.flowLayoutPanel1.Controls.Add(this.rbBuyableNo);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(364, 111);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 35);
            this.flowLayoutPanel1.TabIndex = 21;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(10, 5);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(45, 40);
            this.backButton.TabIndex = 24;
            this.backButton.Text = "←";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // CUItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnSaveItem);
            this.Controls.Add(this.lblUpdateItem);
            this.Controls.Add(this.lblAddItem);
            this.Controls.Add(this.cmbSales);
            this.Controls.Add(this.rbOnSaleNo);
            this.Controls.Add(this.rbOnSaleYes);
            this.Controls.Add(this.lblIsOnSale);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblIsBuyable);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtDesc);
            this.Name = "CUItem";
            this.Text = "NewItem";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblIsBuyable;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.RadioButton rbBuyableYes;
        private System.Windows.Forms.RadioButton rbBuyableNo;
        private System.Windows.Forms.RadioButton rbOnSaleNo;
        private System.Windows.Forms.RadioButton rbOnSaleYes;
        private System.Windows.Forms.Label lblIsOnSale;
        private System.Windows.Forms.ComboBox cmbSales;
        private System.Windows.Forms.Label lblAddItem;
        private System.Windows.Forms.Label lblUpdateItem;
        private System.Windows.Forms.Button btnSaveItem;
        private System.Windows.Forms.Label lblNumber;
        private System.Data.SqlClient.SqlConnection dbConnection;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button backButton;
    }
}