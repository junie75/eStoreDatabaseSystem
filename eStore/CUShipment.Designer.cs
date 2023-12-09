namespace eStore
{
    partial class CUShipment
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
            this.lblUpdateShipment = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.cmbCustomerID = new System.Windows.Forms.ComboBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.lblAddShipment = new System.Windows.Forms.Label();
            this.txtShipTo = new System.Windows.Forms.TextBox();
            this.lblShipTo = new System.Windows.Forms.Label();
            this.txtShipDate = new System.Windows.Forms.TextBox();
            this.lblShipDate = new System.Windows.Forms.Label();
            this.txtShipFrom = new System.Windows.Forms.TextBox();
            this.lblShipFrom = new System.Windows.Forms.Label();
            this.txtShipArriveDate = new System.Windows.Forms.TextBox();
            this.lblShipArriveDate = new System.Windows.Forms.Label();
            this.txtOrderNum = new System.Windows.Forms.TextBox();
            this.btnSaveShipment = new System.Windows.Forms.Button();
            this.dbConnection = new System.Data.SqlClient.SqlConnection();
            this.lblShipNum = new System.Windows.Forms.Label();
            this.cmbShipNum = new System.Windows.Forms.ComboBox();
            this.cmbOrderNum = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUpdateShipment
            // 
            this.lblUpdateShipment.AutoSize = true;
            this.lblUpdateShipment.Location = new System.Drawing.Point(276, 35);
            this.lblUpdateShipment.Name = "lblUpdateShipment";
            this.lblUpdateShipment.Size = new System.Drawing.Size(134, 20);
            this.lblUpdateShipment.TabIndex = 28;
            this.lblUpdateShipment.Text = "Update Shipment";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(364, 142);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(132, 20);
            this.lblCustomerName.TabIndex = 27;
            this.lblCustomerName.Text = "Customer Name: ";
            // 
            // cmbCustomerID
            // 
            this.cmbCustomerID.FormattingEnabled = true;
            this.cmbCustomerID.Location = new System.Drawing.Point(160, 138);
            this.cmbCustomerID.Name = "cmbCustomerID";
            this.cmbCustomerID.Size = new System.Drawing.Size(121, 28);
            this.cmbCustomerID.TabIndex = 26;
            this.cmbCustomerID.TextChanged += new System.EventHandler(this.cmbCustomerID_TextChanged);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(12, 138);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(103, 20);
            this.lblCustomerID.TabIndex = 25;
            this.lblCustomerID.Text = "CustomerID: ";
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.Location = new System.Drawing.Point(364, 88);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(66, 20);
            this.lblOrderNum.TabIndex = 24;
            this.lblOrderNum.Text = "Order#: ";
            // 
            // lblAddShipment
            // 
            this.lblAddShipment.AutoSize = true;
            this.lblAddShipment.Location = new System.Drawing.Point(276, 9);
            this.lblAddShipment.Name = "lblAddShipment";
            this.lblAddShipment.Size = new System.Drawing.Size(164, 20);
            this.lblAddShipment.TabIndex = 23;
            this.lblAddShipment.Text = "Create New Shipment";
            // 
            // txtShipTo
            // 
            this.txtShipTo.Location = new System.Drawing.Point(16, 232);
            this.txtShipTo.Name = "txtShipTo";
            this.txtShipTo.Size = new System.Drawing.Size(300, 26);
            this.txtShipTo.TabIndex = 30;
            // 
            // lblShipTo
            // 
            this.lblShipTo.AutoSize = true;
            this.lblShipTo.Location = new System.Drawing.Point(12, 198);
            this.lblShipTo.Name = "lblShipTo";
            this.lblShipTo.Size = new System.Drawing.Size(97, 20);
            this.lblShipTo.TabIndex = 29;
            this.lblShipTo.Text = "Shipping To:";
            // 
            // txtShipDate
            // 
            this.txtShipDate.Location = new System.Drawing.Point(16, 322);
            this.txtShipDate.Name = "txtShipDate";
            this.txtShipDate.Size = new System.Drawing.Size(300, 26);
            this.txtShipDate.TabIndex = 32;
            // 
            // lblShipDate
            // 
            this.lblShipDate.AutoSize = true;
            this.lblShipDate.Location = new System.Drawing.Point(12, 288);
            this.lblShipDate.Name = "lblShipDate";
            this.lblShipDate.Size = new System.Drawing.Size(111, 20);
            this.lblShipDate.TabIndex = 31;
            this.lblShipDate.Text = "Date Shipped:";
            // 
            // txtShipFrom
            // 
            this.txtShipFrom.Location = new System.Drawing.Point(370, 232);
            this.txtShipFrom.Name = "txtShipFrom";
            this.txtShipFrom.Size = new System.Drawing.Size(300, 26);
            this.txtShipFrom.TabIndex = 34;
            // 
            // lblShipFrom
            // 
            this.lblShipFrom.AutoSize = true;
            this.lblShipFrom.Location = new System.Drawing.Point(366, 198);
            this.lblShipFrom.Name = "lblShipFrom";
            this.lblShipFrom.Size = new System.Drawing.Size(116, 20);
            this.lblShipFrom.TabIndex = 33;
            this.lblShipFrom.Text = "Shipping From:";
            // 
            // txtShipArriveDate
            // 
            this.txtShipArriveDate.Location = new System.Drawing.Point(368, 322);
            this.txtShipArriveDate.Name = "txtShipArriveDate";
            this.txtShipArriveDate.Size = new System.Drawing.Size(300, 26);
            this.txtShipArriveDate.TabIndex = 36;
            // 
            // lblShipArriveDate
            // 
            this.lblShipArriveDate.AutoSize = true;
            this.lblShipArriveDate.Location = new System.Drawing.Point(364, 288);
            this.lblShipArriveDate.Name = "lblShipArriveDate";
            this.lblShipArriveDate.Size = new System.Drawing.Size(173, 20);
            this.lblShipArriveDate.TabIndex = 35;
            this.lblShipArriveDate.Text = "Date Shipment Arrived:";
            // 
            // txtOrderNum
            // 
            this.txtOrderNum.Location = new System.Drawing.Point(436, 58);
            this.txtOrderNum.Name = "txtOrderNum";
            this.txtOrderNum.Size = new System.Drawing.Size(232, 26);
            this.txtOrderNum.TabIndex = 38;
            // 
            // btnSaveShipment
            // 
            this.btnSaveShipment.Location = new System.Drawing.Point(474, 365);
            this.btnSaveShipment.Name = "btnSaveShipment";
            this.btnSaveShipment.Size = new System.Drawing.Size(194, 74);
            this.btnSaveShipment.TabIndex = 39;
            this.btnSaveShipment.Text = "Create Shipment";
            this.btnSaveShipment.UseVisualStyleBackColor = true;
            this.btnSaveShipment.Click += new System.EventHandler(this.btnSaveShipment_Click);
            // 
            // dbConnection
            // 
            this.dbConnection.ConnectionString = "Data Source=DESKTOP-8S93ROH;Initial Catalog=eStoreDatabase;Integrated Security=Tr" +
    "ue";
            this.dbConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // lblShipNum
            // 
            this.lblShipNum.AutoSize = true;
            this.lblShipNum.Location = new System.Drawing.Point(12, 89);
            this.lblShipNum.Name = "lblShipNum";
            this.lblShipNum.Size = new System.Drawing.Size(94, 20);
            this.lblShipNum.TabIndex = 40;
            this.lblShipNum.Text = "Shipment#: ";
            // 
            // cmbShipNum
            // 
            this.cmbShipNum.FormattingEnabled = true;
            this.cmbShipNum.Location = new System.Drawing.Point(112, 88);
            this.cmbShipNum.Name = "cmbShipNum";
            this.cmbShipNum.Size = new System.Drawing.Size(121, 28);
            this.cmbShipNum.TabIndex = 41;
            this.cmbShipNum.TextChanged += new System.EventHandler(this.cmbShipNum_TextChanged);
            // 
            // cmbOrderNum
            // 
            this.cmbOrderNum.FormattingEnabled = true;
            this.cmbOrderNum.Location = new System.Drawing.Point(436, 85);
            this.cmbOrderNum.Name = "cmbOrderNum";
            this.cmbOrderNum.Size = new System.Drawing.Size(121, 28);
            this.cmbOrderNum.TabIndex = 42;
            this.cmbOrderNum.LostFocus += new System.EventHandler(this.cmbOrderNum_LostFocus);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(16, 9);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(45, 40);
            this.backButton.TabIndex = 43;
            this.backButton.Text = "←";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // CUShipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 449);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.cmbOrderNum);
            this.Controls.Add(this.cmbShipNum);
            this.Controls.Add(this.lblShipNum);
            this.Controls.Add(this.btnSaveShipment);
            this.Controls.Add(this.txtOrderNum);
            this.Controls.Add(this.txtShipArriveDate);
            this.Controls.Add(this.lblShipArriveDate);
            this.Controls.Add(this.txtShipFrom);
            this.Controls.Add(this.lblShipFrom);
            this.Controls.Add(this.txtShipDate);
            this.Controls.Add(this.lblShipDate);
            this.Controls.Add(this.txtShipTo);
            this.Controls.Add(this.lblShipTo);
            this.Controls.Add(this.lblUpdateShipment);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.cmbCustomerID);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblOrderNum);
            this.Controls.Add(this.lblAddShipment);
            this.Name = "CUShipment";
            this.Text = "CUShipment";
            this.Click += new System.EventHandler(this.Form_Clicked);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpdateShipment;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.ComboBox cmbCustomerID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.Label lblAddShipment;
        private System.Windows.Forms.TextBox txtShipTo;
        private System.Windows.Forms.Label lblShipTo;
        private System.Windows.Forms.TextBox txtShipDate;
        private System.Windows.Forms.Label lblShipDate;
        private System.Windows.Forms.TextBox txtShipFrom;
        private System.Windows.Forms.Label lblShipFrom;
        private System.Windows.Forms.TextBox txtShipArriveDate;
        private System.Windows.Forms.Label lblShipArriveDate;
        private System.Windows.Forms.TextBox txtOrderNum;
        private System.Windows.Forms.Button btnSaveShipment;
        private System.Data.SqlClient.SqlConnection dbConnection;
        private System.Windows.Forms.Label lblShipNum;
        private System.Windows.Forms.ComboBox cmbShipNum;
        private System.Windows.Forms.ComboBox cmbOrderNum;
        private System.Windows.Forms.Button backButton;
    }
}