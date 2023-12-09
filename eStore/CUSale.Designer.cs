namespace eStore
{
    partial class CUSale
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
            this.btnSaveSale = new System.Windows.Forms.Button();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblSale = new System.Windows.Forms.Label();
            this.cmbSaleNum = new System.Windows.Forms.ComboBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblSaleNum = new System.Windows.Forms.Label();
            this.lblSaleAmount = new System.Windows.Forms.Label();
            this.txtSaleAmount = new System.Windows.Forms.TextBox();
            this.lblSaleType = new System.Windows.Forms.Label();
            this.rbMultiply = new System.Windows.Forms.RadioButton();
            this.rbSubtract = new System.Windows.Forms.RadioButton();
            this.rbChange = new System.Windows.Forms.RadioButton();
            this.dbConnection = new System.Data.SqlClient.SqlConnection();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaveSale
            // 
            this.btnSaveSale.Location = new System.Drawing.Point(340, 340);
            this.btnSaveSale.Name = "btnSaveSale";
            this.btnSaveSale.Size = new System.Drawing.Size(132, 58);
            this.btnSaveSale.TabIndex = 0;
            this.btnSaveSale.Text = "Sale";
            this.btnSaveSale.UseVisualStyleBackColor = true;
            this.btnSaveSale.Click += new System.EventHandler(this.btnSaveSale_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(160, 225);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(118, 26);
            this.dtpStart.TabIndex = 1;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(160, 271);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(118, 26);
            this.dtpEnd.TabIndex = 2;
            // 
            // lblSale
            // 
            this.lblSale.AutoSize = true;
            this.lblSale.Location = new System.Drawing.Point(202, 9);
            this.lblSale.Name = "lblSale";
            this.lblSale.Size = new System.Drawing.Size(41, 20);
            this.lblSale.TabIndex = 3;
            this.lblSale.Text = "Sale";
            // 
            // cmbSaleNum
            // 
            this.cmbSaleNum.FormattingEnabled = true;
            this.cmbSaleNum.Location = new System.Drawing.Point(100, 75);
            this.cmbSaleNum.Name = "cmbSaleNum";
            this.cmbSaleNum.Size = new System.Drawing.Size(121, 28);
            this.cmbSaleNum.TabIndex = 4;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(32, 225);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(123, 20);
            this.lblStart.TabIndex = 5;
            this.lblStart.Text = "Sale Start Date:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(32, 271);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(117, 20);
            this.lblEnd.TabIndex = 6;
            this.lblEnd.Text = "Sale End Date:";
            // 
            // lblSaleNum
            // 
            this.lblSaleNum.AutoSize = true;
            this.lblSaleNum.Location = new System.Drawing.Point(32, 75);
            this.lblSaleNum.Name = "lblSaleNum";
            this.lblSaleNum.Size = new System.Drawing.Size(54, 20);
            this.lblSaleNum.TabIndex = 7;
            this.lblSaleNum.Text = "Sale#:";
            // 
            // lblSaleAmount
            // 
            this.lblSaleAmount.AutoSize = true;
            this.lblSaleAmount.Location = new System.Drawing.Point(32, 134);
            this.lblSaleAmount.Name = "lblSaleAmount";
            this.lblSaleAmount.Size = new System.Drawing.Size(101, 20);
            this.lblSaleAmount.TabIndex = 8;
            this.lblSaleAmount.Text = "Sale Amount";
            // 
            // txtSaleAmount
            // 
            this.txtSaleAmount.Location = new System.Drawing.Point(34, 157);
            this.txtSaleAmount.Name = "txtSaleAmount";
            this.txtSaleAmount.Size = new System.Drawing.Size(186, 26);
            this.txtSaleAmount.TabIndex = 9;
            // 
            // lblSaleType
            // 
            this.lblSaleType.AutoSize = true;
            this.lblSaleType.Location = new System.Drawing.Point(336, 75);
            this.lblSaleType.Name = "lblSaleType";
            this.lblSaleType.Size = new System.Drawing.Size(143, 20);
            this.lblSaleType.TabIndex = 10;
            this.lblSaleType.Text = "Sale Amount Type:";
            // 
            // rbMultiply
            // 
            this.rbMultiply.AutoSize = true;
            this.rbMultiply.Location = new System.Drawing.Point(340, 112);
            this.rbMultiply.Name = "rbMultiply";
            this.rbMultiply.Size = new System.Drawing.Size(89, 24);
            this.rbMultiply.TabIndex = 11;
            this.rbMultiply.TabStop = true;
            this.rbMultiply.Text = "Percent";
            this.rbMultiply.UseVisualStyleBackColor = true;
            // 
            // rbSubtract
            // 
            this.rbSubtract.AutoSize = true;
            this.rbSubtract.Location = new System.Drawing.Point(340, 143);
            this.rbSubtract.Name = "rbSubtract";
            this.rbSubtract.Size = new System.Drawing.Size(95, 24);
            this.rbSubtract.TabIndex = 12;
            this.rbSubtract.TabStop = true;
            this.rbSubtract.Text = "Subtract";
            this.rbSubtract.UseVisualStyleBackColor = true;
            // 
            // rbChange
            // 
            this.rbChange.AutoSize = true;
            this.rbChange.Location = new System.Drawing.Point(340, 172);
            this.rbChange.Name = "rbChange";
            this.rbChange.Size = new System.Drawing.Size(74, 24);
            this.rbChange.TabIndex = 13;
            this.rbChange.TabStop = true;
            this.rbChange.Text = "Exact";
            this.rbChange.UseVisualStyleBackColor = true;
            // 
            // dbConnection
            // 
            this.dbConnection.ConnectionString = "Data Source=DESKTOP-8S93ROH;Initial Catalog=eStoreDatabase;Integrated Security=Tr" +
    "ue";
            this.dbConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(18, 360);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(44, 38);
            this.backButton.TabIndex = 16;
            this.backButton.Text = "←";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // CUSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 440);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.rbChange);
            this.Controls.Add(this.rbSubtract);
            this.Controls.Add(this.rbMultiply);
            this.Controls.Add(this.lblSaleType);
            this.Controls.Add(this.txtSaleAmount);
            this.Controls.Add(this.lblSaleAmount);
            this.Controls.Add(this.lblSaleNum);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.cmbSaleNum);
            this.Controls.Add(this.lblSale);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.btnSaveSale);
            this.Name = "CUSale";
            this.Text = "CUSale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveSale;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblSale;
        private System.Windows.Forms.ComboBox cmbSaleNum;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblSaleNum;
        private System.Windows.Forms.Label lblSaleAmount;
        private System.Windows.Forms.TextBox txtSaleAmount;
        private System.Windows.Forms.Label lblSaleType;
        private System.Windows.Forms.RadioButton rbMultiply;
        private System.Windows.Forms.RadioButton rbSubtract;
        private System.Windows.Forms.RadioButton rbChange;
        private System.Data.SqlClient.SqlConnection dbConnection;
        private System.Windows.Forms.Button backButton;
    }
}