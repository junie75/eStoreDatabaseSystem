namespace eStore
{
    partial class CUOrder
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
            this.lblAddOrder = new System.Windows.Forms.Label();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.cmbCustomerID = new System.Windows.Forms.ComboBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.dgvItemsInStock = new System.Windows.Forms.DataGridView();
            this.dgvItemsInOrder = new System.Windows.Forms.DataGridView();
            this.cmbAddSelectedItem = new System.Windows.Forms.ComboBox();
            this.txtAddItemQty = new System.Windows.Forms.TextBox();
            this.lblItemToAdd = new System.Windows.Forms.Label();
            this.lblItemQtyToAdd = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.lblItemToRemove = new System.Windows.Forms.Label();
            this.cmbRemoveSelectedItem = new System.Windows.Forms.ComboBox();
            this.lblInStockItems = new System.Windows.Forms.Label();
            this.lblItemsInOrder = new System.Windows.Forms.Label();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dbConnection = new System.Data.SqlClient.SqlConnection();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblUpdateOrder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsInStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsInOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddOrder
            // 
            this.lblAddOrder.AutoSize = true;
            this.lblAddOrder.Location = new System.Drawing.Point(420, 31);
            this.lblAddOrder.Name = "lblAddOrder";
            this.lblAddOrder.Size = new System.Drawing.Size(136, 20);
            this.lblAddOrder.TabIndex = 0;
            this.lblAddOrder.Text = "Create New Order";
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.Location = new System.Drawing.Point(60, 105);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(66, 20);
            this.lblOrderNum.TabIndex = 1;
            this.lblOrderNum.Text = "Order#: ";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(60, 152);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(103, 20);
            this.lblCustomerID.TabIndex = 2;
            this.lblCustomerID.Text = "CustomerID: ";
            // 
            // cmbCustomerID
            // 
            this.cmbCustomerID.FormattingEnabled = true;
            this.cmbCustomerID.Location = new System.Drawing.Point(208, 152);
            this.cmbCustomerID.Name = "cmbCustomerID";
            this.cmbCustomerID.Size = new System.Drawing.Size(121, 28);
            this.cmbCustomerID.TabIndex = 3;
            this.cmbCustomerID.TextChanged += new System.EventHandler(this.cmbCustomerID_TextChanged);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(447, 152);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(132, 20);
            this.lblCustomerName.TabIndex = 4;
            this.lblCustomerName.Text = "Customer Name: ";
            // 
            // dgvItemsInStock
            // 
            this.dgvItemsInStock.AllowUserToAddRows = false;
            this.dgvItemsInStock.AllowUserToDeleteRows = false;
            this.dgvItemsInStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemsInStock.Location = new System.Drawing.Point(12, 277);
            this.dgvItemsInStock.Name = "dgvItemsInStock";
            this.dgvItemsInStock.ReadOnly = true;
            this.dgvItemsInStock.RowHeadersWidth = 62;
            this.dgvItemsInStock.RowTemplate.Height = 28;
            this.dgvItemsInStock.Size = new System.Drawing.Size(488, 346);
            this.dgvItemsInStock.TabIndex = 5;
            this.dgvItemsInStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemsInStock_CellClick);
            // 
            // dgvItemsInOrder
            // 
            this.dgvItemsInOrder.AllowUserToAddRows = false;
            this.dgvItemsInOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemsInOrder.Location = new System.Drawing.Point(522, 277);
            this.dgvItemsInOrder.Name = "dgvItemsInOrder";
            this.dgvItemsInOrder.RowHeadersWidth = 62;
            this.dgvItemsInOrder.RowTemplate.Height = 28;
            this.dgvItemsInOrder.Size = new System.Drawing.Size(488, 346);
            this.dgvItemsInOrder.TabIndex = 6;
            this.dgvItemsInOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemsInOrder_CellClick);
            // 
            // cmbAddSelectedItem
            // 
            this.cmbAddSelectedItem.FormattingEnabled = true;
            this.cmbAddSelectedItem.Location = new System.Drawing.Point(114, 631);
            this.cmbAddSelectedItem.Name = "cmbAddSelectedItem";
            this.cmbAddSelectedItem.Size = new System.Drawing.Size(121, 28);
            this.cmbAddSelectedItem.TabIndex = 7;
            // 
            // txtAddItemQty
            // 
            this.txtAddItemQty.Location = new System.Drawing.Point(434, 631);
            this.txtAddItemQty.Name = "txtAddItemQty";
            this.txtAddItemQty.Size = new System.Drawing.Size(66, 26);
            this.txtAddItemQty.TabIndex = 8;
            // 
            // lblItemToAdd
            // 
            this.lblItemToAdd.AutoSize = true;
            this.lblItemToAdd.Location = new System.Drawing.Point(14, 629);
            this.lblItemToAdd.Name = "lblItemToAdd";
            this.lblItemToAdd.Size = new System.Drawing.Size(95, 20);
            this.lblItemToAdd.TabIndex = 9;
            this.lblItemToAdd.Text = "Item Name: ";
            // 
            // lblItemQtyToAdd
            // 
            this.lblItemQtyToAdd.AutoSize = true;
            this.lblItemQtyToAdd.Location = new System.Drawing.Point(394, 626);
            this.lblItemQtyToAdd.Name = "lblItemQtyToAdd";
            this.lblItemQtyToAdd.Size = new System.Drawing.Size(34, 20);
            this.lblItemQtyToAdd.TabIndex = 10;
            this.lblItemQtyToAdd.Text = "qty.";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(16, 668);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(482, 46);
            this.btnAddItem.TabIndex = 11;
            this.btnAddItem.Text = "Add To Order";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(664, 668);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(346, 46);
            this.btnRemoveItem.TabIndex = 16;
            this.btnRemoveItem.Text = "Remove From Order";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // lblItemToRemove
            // 
            this.lblItemToRemove.AutoSize = true;
            this.lblItemToRemove.Location = new System.Drawing.Point(660, 632);
            this.lblItemToRemove.Name = "lblItemToRemove";
            this.lblItemToRemove.Size = new System.Drawing.Size(95, 20);
            this.lblItemToRemove.TabIndex = 14;
            this.lblItemToRemove.Text = "Item Name: ";
            // 
            // cmbRemoveSelectedItem
            // 
            this.cmbRemoveSelectedItem.FormattingEnabled = true;
            this.cmbRemoveSelectedItem.Location = new System.Drawing.Point(890, 632);
            this.cmbRemoveSelectedItem.Name = "cmbRemoveSelectedItem";
            this.cmbRemoveSelectedItem.Size = new System.Drawing.Size(121, 28);
            this.cmbRemoveSelectedItem.TabIndex = 12;
            // 
            // lblInStockItems
            // 
            this.lblInStockItems.AutoSize = true;
            this.lblInStockItems.Location = new System.Drawing.Point(8, 245);
            this.lblInStockItems.Name = "lblInStockItems";
            this.lblInStockItems.Size = new System.Drawing.Size(167, 20);
            this.lblInStockItems.TabIndex = 17;
            this.lblInStockItems.Text = "Store\'s In-Stock Items";
            // 
            // lblItemsInOrder
            // 
            this.lblItemsInOrder.AutoSize = true;
            this.lblItemsInOrder.Location = new System.Drawing.Point(522, 245);
            this.lblItemsInOrder.Name = "lblItemsInOrder";
            this.lblItemsInOrder.Size = new System.Drawing.Size(176, 20);
            this.lblItemsInOrder.TabIndex = 18;
            this.lblItemsInOrder.Text = "Items Currently in Order";
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.Location = new System.Drawing.Point(784, 178);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(213, 86);
            this.btnSaveOrder.TabIndex = 19;
            this.btnSaveOrder.Text = "Save Order";
            this.btnSaveOrder.UseVisualStyleBackColor = true;
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(182, 65);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel Order/Go Back";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dbConnection
            // 
            this.dbConnection.ConnectionString = "Data Source=DESKTOP-8S93ROH;Initial Catalog=eStoreDatabase;Integrated Security=Tr" +
    "ue";
            this.dbConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(522, 640);
            this.lblSubtotal.MaximumSize = new System.Drawing.Size(100, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(73, 20);
            this.lblSubtotal.TabIndex = 21;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblUpdateOrder
            // 
            this.lblUpdateOrder.AutoSize = true;
            this.lblUpdateOrder.Location = new System.Drawing.Point(420, 57);
            this.lblUpdateOrder.Name = "lblUpdateOrder";
            this.lblUpdateOrder.Size = new System.Drawing.Size(106, 20);
            this.lblUpdateOrder.TabIndex = 22;
            this.lblUpdateOrder.Text = "Update Order";
            // 
            // CUOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1022, 725);
            this.Controls.Add(this.lblUpdateOrder);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveOrder);
            this.Controls.Add(this.lblItemsInOrder);
            this.Controls.Add(this.lblInStockItems);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.lblItemToRemove);
            this.Controls.Add(this.cmbRemoveSelectedItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lblItemQtyToAdd);
            this.Controls.Add(this.lblItemToAdd);
            this.Controls.Add(this.txtAddItemQty);
            this.Controls.Add(this.cmbAddSelectedItem);
            this.Controls.Add(this.dgvItemsInOrder);
            this.Controls.Add(this.dgvItemsInStock);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.cmbCustomerID);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblOrderNum);
            this.Controls.Add(this.lblAddOrder);
            this.Name = "CUOrder";
            this.Text = "CUOrder";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsInStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsInOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAddOrder;
        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.ComboBox cmbCustomerID;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.DataGridView dgvItemsInStock;
        private System.Windows.Forms.DataGridView dgvItemsInOrder;
        private System.Windows.Forms.ComboBox cmbAddSelectedItem;
        private System.Windows.Forms.TextBox txtAddItemQty;
        private System.Windows.Forms.Label lblItemToAdd;
        private System.Windows.Forms.Label lblItemQtyToAdd;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Label lblItemToRemove;
        private System.Windows.Forms.ComboBox cmbRemoveSelectedItem;
        private System.Windows.Forms.Label lblInStockItems;
        private System.Windows.Forms.Label lblItemsInOrder;
        private System.Windows.Forms.Button btnSaveOrder;
        private System.Windows.Forms.Button btnCancel;
        private System.Data.SqlClient.SqlConnection dbConnection;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblUpdateOrder;
    }
}