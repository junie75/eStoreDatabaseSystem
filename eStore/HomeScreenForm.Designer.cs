namespace eStore
{
    partial class HomeScreenForm
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
            this.PasswordBtn = new System.Windows.Forms.Button();
            this.CustomerBtn = new System.Windows.Forms.Button();
            this.OrderBtn = new System.Windows.Forms.Button();
            this.ShipmentBtn = new System.Windows.Forms.Button();
            this.ItemBtn = new System.Windows.Forms.Button();
            this.SaleBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PasswordBtn
            // 
            this.PasswordBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBtn.Location = new System.Drawing.Point(126, 84);
            this.PasswordBtn.Name = "PasswordBtn";
            this.PasswordBtn.Size = new System.Drawing.Size(130, 50);
            this.PasswordBtn.TabIndex = 0;
            this.PasswordBtn.Text = "Change Password";
            this.PasswordBtn.UseVisualStyleBackColor = true;
            this.PasswordBtn.Click += new System.EventHandler(this.PasswordBtn_Click);
            // 
            // CustomerBtn
            // 
            this.CustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerBtn.Location = new System.Drawing.Point(126, 173);
            this.CustomerBtn.Name = "CustomerBtn";
            this.CustomerBtn.Size = new System.Drawing.Size(130, 50);
            this.CustomerBtn.TabIndex = 1;
            this.CustomerBtn.Text = "Customers";
            this.CustomerBtn.UseVisualStyleBackColor = true;
            this.CustomerBtn.Click += new System.EventHandler(this.CustomerBtn_Click);
            // 
            // OrderBtn
            // 
            this.OrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderBtn.Location = new System.Drawing.Point(328, 84);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Size = new System.Drawing.Size(130, 50);
            this.OrderBtn.TabIndex = 2;
            this.OrderBtn.Text = "Orders";
            this.OrderBtn.UseVisualStyleBackColor = true;
            this.OrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // ShipmentBtn
            // 
            this.ShipmentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipmentBtn.Location = new System.Drawing.Point(328, 173);
            this.ShipmentBtn.Name = "ShipmentBtn";
            this.ShipmentBtn.Size = new System.Drawing.Size(130, 50);
            this.ShipmentBtn.TabIndex = 3;
            this.ShipmentBtn.Text = "Shipments";
            this.ShipmentBtn.UseVisualStyleBackColor = true;
            this.ShipmentBtn.Click += new System.EventHandler(this.ShipmentBtn_Click);
            // 
            // ItemBtn
            // 
            this.ItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemBtn.Location = new System.Drawing.Point(526, 84);
            this.ItemBtn.Name = "ItemBtn";
            this.ItemBtn.Size = new System.Drawing.Size(130, 50);
            this.ItemBtn.TabIndex = 4;
            this.ItemBtn.Text = "Items";
            this.ItemBtn.UseVisualStyleBackColor = true;
            this.ItemBtn.Click += new System.EventHandler(this.ItemBtn_Click);
            // 
            // SaleBtn
            // 
            this.SaleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleBtn.Location = new System.Drawing.Point(526, 173);
            this.SaleBtn.Name = "SaleBtn";
            this.SaleBtn.Size = new System.Drawing.Size(130, 50);
            this.SaleBtn.TabIndex = 5;
            this.SaleBtn.Text = "Sales";
            this.SaleBtn.UseVisualStyleBackColor = true;
            this.SaleBtn.Click += new System.EventHandler(this.SaleBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.Location = new System.Drawing.Point(722, 408);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(66, 30);
            this.LogoutBtn.TabIndex = 6;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // HomeScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.SaleBtn);
            this.Controls.Add(this.ItemBtn);
            this.Controls.Add(this.ShipmentBtn);
            this.Controls.Add(this.OrderBtn);
            this.Controls.Add(this.CustomerBtn);
            this.Controls.Add(this.PasswordBtn);
            this.Name = "HomeScreenForm";
            this.Text = "HomeScreenForm";
            this.Load += new System.EventHandler(this.HomeScreenForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PasswordBtn;
        private System.Windows.Forms.Button CustomerBtn;
        private System.Windows.Forms.Button OrderBtn;
        private System.Windows.Forms.Button ShipmentBtn;
        private System.Windows.Forms.Button ItemBtn;
        private System.Windows.Forms.Button SaleBtn;
        private System.Windows.Forms.Button LogoutBtn;
    }
}