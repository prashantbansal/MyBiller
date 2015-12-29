namespace MyBiller
{
    partial class FormCustomer
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber1 = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dgCustomerView = new System.Windows.Forms.DataGridView();
            this.btnSelectItems = new System.Windows.Forms.Button();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.dcSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dcCustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcAddressId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcAddressLine1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcAddressLine2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcPinCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomerView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AllowDrop = true;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(50, 74);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblHeader.Location = new System.Drawing.Point(50, 34);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(160, 17);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Search the Customer";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(380, 74);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(134, 71);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(185, 20);
            this.txtFirstName.TabIndex = 3;
            this.txtFirstName.Text = "Prashant";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(50, 131);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(48, 13);
            this.lblMobile.TabIndex = 4;
            this.lblMobile.Text = "Mobile #";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(456, 74);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(217, 20);
            this.txtLastName.TabIndex = 5;
            // 
            // txtPhoneNumber1
            // 
            this.txtPhoneNumber1.Location = new System.Drawing.Point(134, 128);
            this.txtPhoneNumber1.Name = "txtPhoneNumber1";
            this.txtPhoneNumber1.Size = new System.Drawing.Size(185, 20);
            this.txtPhoneNumber1.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(380, 135);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(454, 128);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(219, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // dgCustomerView
            // 
            this.dgCustomerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomerView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dcSelect,
            this.dcCustomerId,
            this.dcFirstName,
            this.dcLastName,
            this.dcMobile,
            this.dcAddressId,
            this.dcAddressLine1,
            this.dcAddressLine2,
            this.dcCity,
            this.dcPinCode,
            this.dcEmail});
            this.dgCustomerView.Location = new System.Drawing.Point(53, 237);
            this.dgCustomerView.Name = "dgCustomerView";
            this.dgCustomerView.Size = new System.Drawing.Size(676, 249);
            this.dgCustomerView.TabIndex = 9;
            // 
            // btnSelectItems
            // 
            this.btnSelectItems.Location = new System.Drawing.Point(571, 521);
            this.btnSelectItems.Name = "btnSelectItems";
            this.btnSelectItems.Size = new System.Drawing.Size(158, 23);
            this.btnSelectItems.TabIndex = 10;
            this.btnSelectItems.Text = "Add Items";
            this.btnSelectItems.UseVisualStyleBackColor = true;
            this.btnSelectItems.Click += new System.EventHandler(this.btnSelectItems_Click);
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Location = new System.Drawing.Point(503, 185);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(170, 23);
            this.btnSearchCustomer.TabIndex = 1;
            this.btnSearchCustomer.Text = "Search Customer";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // dcSelect
            // 
            this.dcSelect.HeaderText = "";
            this.dcSelect.Name = "dcSelect";
            this.dcSelect.Width = 30;
            // 
            // dcCustomerId
            // 
            this.dcCustomerId.DataPropertyName = "CustomerId";
            this.dcCustomerId.HeaderText = "Customer Id";
            this.dcCustomerId.Name = "dcCustomerId";
            // 
            // dcFirstName
            // 
            this.dcFirstName.DataPropertyName = "FirstName";
            this.dcFirstName.HeaderText = "First Name";
            this.dcFirstName.Name = "dcFirstName";
            // 
            // dcLastName
            // 
            this.dcLastName.DataPropertyName = "LastName";
            this.dcLastName.HeaderText = "Last Name";
            this.dcLastName.Name = "dcLastName";
            // 
            // dcMobile
            // 
            this.dcMobile.DataPropertyName = "PhoneNumber1";
            this.dcMobile.HeaderText = "Mobile #";
            this.dcMobile.Name = "dcMobile";
            // 
            // dcAddressId
            // 
            this.dcAddressId.DataPropertyName = "AddressId";
            this.dcAddressId.HeaderText = "AddressId";
            this.dcAddressId.Name = "dcAddressId";
            this.dcAddressId.Visible = false;
            // 
            // dcAddressLine1
            // 
            this.dcAddressLine1.DataPropertyName = "AddressLine1";
            this.dcAddressLine1.HeaderText = "Address Line 1";
            this.dcAddressLine1.Name = "dcAddressLine1";
            // 
            // dcAddressLine2
            // 
            this.dcAddressLine2.DataPropertyName = "AddressLine2";
            this.dcAddressLine2.HeaderText = "Address Line 2";
            this.dcAddressLine2.Name = "dcAddressLine2";
            // 
            // dcCity
            // 
            this.dcCity.DataPropertyName = "City";
            this.dcCity.HeaderText = "City";
            this.dcCity.Name = "dcCity";
            // 
            // dcPinCode
            // 
            this.dcPinCode.DataPropertyName = "PinCode";
            this.dcPinCode.HeaderText = "Pin Code";
            this.dcPinCode.Name = "dcPinCode";
            // 
            // dcEmail
            // 
            this.dcEmail.DataPropertyName = "Email";
            this.dcEmail.HeaderText = "Email";
            this.dcEmail.Name = "dcEmail";
            // 
            // FormCustomer
            // 
            this.AcceptButton = this.btnSearchCustomer;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(781, 610);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnSearchCustomer);
            this.Controls.Add(this.btnSelectItems);
            this.Controls.Add(this.dgCustomerView);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPhoneNumber1);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblHeader);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FormCustomer";
            this.Text = "Search Customer";
            this.Controls.SetChildIndex(this.lblHeader, 0);
            this.Controls.SetChildIndex(this.lblLastName, 0);
            this.Controls.SetChildIndex(this.txtFirstName, 0);
            this.Controls.SetChildIndex(this.lblMobile, 0);
            this.Controls.SetChildIndex(this.txtLastName, 0);
            this.Controls.SetChildIndex(this.txtPhoneNumber1, 0);
            this.Controls.SetChildIndex(this.lblEmail, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.dgCustomerView, 0);
            this.Controls.SetChildIndex(this.btnSelectItems, 0);
            this.Controls.SetChildIndex(this.btnSearchCustomer, 0);
            this.Controls.SetChildIndex(this.lblFirstName, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomerView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhoneNumber1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DataGridView dgCustomerView;
        private System.Windows.Forms.Button btnSelectItems;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dcSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcCustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcAddressId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcAddressLine1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcAddressLine2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcPinCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcEmail;
    }
}

