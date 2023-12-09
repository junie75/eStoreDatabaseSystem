namespace eStore
{
    partial class CRDItemsOnSale
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
            this.dgvStoreItems = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvSaleItems = new System.Windows.Forms.DataGridView();
            this.lblStoreItemHeader = new System.Windows.Forms.Label();
            this.lblSaleItemHeader = new System.Windows.Forms.Label();
            this.lblNotice = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSaleItem = new System.Windows.Forms.Label();
            this.lblStoreItem = new System.Windows.Forms.Label();
            this.cmbStoreItem = new System.Windows.Forms.ComboBox();
            this.cmbSaleItem = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblSaleNum = new System.Windows.Forms.Label();
            this.dbConnection = new System.Data.SqlClient.SqlConnection();
            this.btnSave = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStoreItems
            // 
            this.dgvStoreItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStoreItems.Location = new System.Drawing.Point(24, 126);
            this.dgvStoreItems.Name = "dgvStoreItems";
            this.dgvStoreItems.RowHeadersWidth = 62;
            this.dgvStoreItems.RowTemplate.Height = 28;
            this.dgvStoreItems.Size = new System.Drawing.Size(368, 245);
            this.dgvStoreItems.TabIndex = 0;
            this.dgvStoreItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStoreItems_CellClick);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(282, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(213, 20);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Add/Remove Items with Sale";
            // 
            // dgvSaleItems
            // 
            this.dgvSaleItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleItems.Location = new System.Drawing.Point(412, 126);
            this.dgvSaleItems.Name = "dgvSaleItems";
            this.dgvSaleItems.RowHeadersWidth = 62;
            this.dgvSaleItems.RowTemplate.Height = 28;
            this.dgvSaleItems.Size = new System.Drawing.Size(368, 245);
            this.dgvSaleItems.TabIndex = 4;
            this.dgvSaleItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSaleItems_CellClick);
            // 
            // lblStoreItemHeader
            // 
            this.lblStoreItemHeader.AutoSize = true;
            this.lblStoreItemHeader.Location = new System.Drawing.Point(20, 103);
            this.lblStoreItemHeader.Name = "lblStoreItemHeader";
            this.lblStoreItemHeader.Size = new System.Drawing.Size(108, 20);
            this.lblStoreItemHeader.TabIndex = 5;
            this.lblStoreItemHeader.Text = "Items in Store";
            // 
            // lblSaleItemHeader
            // 
            this.lblSaleItemHeader.AutoSize = true;
            this.lblSaleItemHeader.Location = new System.Drawing.Point(410, 103);
            this.lblSaleItemHeader.Name = "lblSaleItemHeader";
            this.lblSaleItemHeader.Size = new System.Drawing.Size(130, 20);
            this.lblSaleItemHeader.TabIndex = 6;
            this.lblSaleItemHeader.Text = "Items with Sale# ";
            // 
            // lblNotice
            // 
            this.lblNotice.AutoSize = true;
            this.lblNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotice.Location = new System.Drawing.Point(20, 538);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(605, 20);
            this.lblNotice.TabIndex = 7;
            this.lblNotice.Text = "*NOTICE* Current Sale# has expired; items with Sale# cannot be modified.";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(182, 85);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(208, 35);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Store Item to Sale";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSaleItem
            // 
            this.lblSaleItem.AutoSize = true;
            this.lblSaleItem.Location = new System.Drawing.Point(412, 378);
            this.lblSaleItem.Name = "lblSaleItem";
            this.lblSaleItem.Size = new System.Drawing.Size(148, 20);
            this.lblSaleItem.TabIndex = 10;
            this.lblSaleItem.Text = "Selected Sale Item:";
            // 
            // lblStoreItem
            // 
            this.lblStoreItem.AutoSize = true;
            this.lblStoreItem.Location = new System.Drawing.Point(20, 378);
            this.lblStoreItem.Name = "lblStoreItem";
            this.lblStoreItem.Size = new System.Drawing.Size(155, 20);
            this.lblStoreItem.TabIndex = 11;
            this.lblStoreItem.Text = "Selected Store Item:";
            // 
            // cmbStoreItem
            // 
            this.cmbStoreItem.FormattingEnabled = true;
            this.cmbStoreItem.Location = new System.Drawing.Point(182, 378);
            this.cmbStoreItem.Name = "cmbStoreItem";
            this.cmbStoreItem.Size = new System.Drawing.Size(210, 28);
            this.cmbStoreItem.TabIndex = 12;
            // 
            // cmbSaleItem
            // 
            this.cmbSaleItem.FormattingEnabled = true;
            this.cmbSaleItem.Location = new System.Drawing.Point(572, 377);
            this.cmbSaleItem.Name = "cmbSaleItem";
            this.cmbSaleItem.Size = new System.Drawing.Size(210, 28);
            this.cmbSaleItem.TabIndex = 13;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(572, 85);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(208, 35);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "Remove Item From Sale";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblSaleNum
            // 
            this.lblSaleNum.AutoSize = true;
            this.lblSaleNum.Location = new System.Drawing.Point(306, 51);
            this.lblSaleNum.Name = "lblSaleNum";
            this.lblSaleNum.Size = new System.Drawing.Size(58, 20);
            this.lblSaleNum.TabIndex = 9;
            this.lblSaleNum.Text = "Sale#: ";
            // 
            // dbConnection
            // 
            this.dbConnection.ConnectionString = "Data Source=DESKTOP-8S93ROH;Initial Catalog=eStoreDatabase;Integrated Security=Tr" +
    "ue";
            this.dbConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(328, 452);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 55);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(18, 18);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(44, 38);
            this.backButton.TabIndex = 16;
            this.backButton.Text = "←";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // CRDItemsOnSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 568);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.cmbSaleItem);
            this.Controls.Add(this.cmbStoreItem);
            this.Controls.Add(this.lblStoreItem);
            this.Controls.Add(this.lblSaleItem);
            this.Controls.Add(this.lblSaleNum);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblNotice);
            this.Controls.Add(this.lblSaleItemHeader);
            this.Controls.Add(this.lblStoreItemHeader);
            this.Controls.Add(this.dgvSaleItems);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvStoreItems);
            this.Name = "CRDItemsOnSale";
            this.Text = "CRDItemsOnSale";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStoreItems;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvSaleItems;
        private System.Windows.Forms.Label lblStoreItemHeader;
        private System.Windows.Forms.Label lblSaleItemHeader;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSaleItem;
        private System.Windows.Forms.Label lblStoreItem;
        private System.Windows.Forms.ComboBox cmbStoreItem;
        private System.Windows.Forms.ComboBox cmbSaleItem;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblSaleNum;
        private System.Data.SqlClient.SqlConnection dbConnection;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button backButton;
    }
}