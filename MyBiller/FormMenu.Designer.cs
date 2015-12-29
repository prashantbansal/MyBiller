namespace MyBiller
{
    partial class FormMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgMenuView = new System.Windows.Forms.DataGridView();
            this.dcItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcItemQuantity = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dcItemTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFinalizeOrder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddressLine1 = new System.Windows.Forms.TextBox();
            this.txtAddressLine2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPinCode = new System.Windows.Forms.TextBox();
            this.rdoUpdateAddress = new System.Windows.Forms.RadioButton();
            this.rdoCreateAddress = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoUpdateCustomer = new System.Windows.Forms.RadioButton();
            this.rdoCreateCustomer = new System.Windows.Forms.RadioButton();
            this.lblAddressId = new System.Windows.Forms.Label();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.lblCustomerId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMenuView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(345, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the items";
            // 
            // dgMenuView
            // 
            this.dgMenuView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMenuView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dcItemId,
            this.dcItemName,
            this.dcDescription,
            this.dcCategory,
            this.dcItemType,
            this.dcItemPrice,
            this.dcItemQuantity,
            this.dcItemTotal,
            this.dcActive});
            this.dgMenuView.Location = new System.Drawing.Point(97, 196);
            this.dgMenuView.Name = "dgMenuView";
            this.dgMenuView.Size = new System.Drawing.Size(632, 295);
            this.dgMenuView.TabIndex = 1;
            // 
            // dcItemId
            // 
            this.dcItemId.DataPropertyName = "ItemId";
            this.dcItemId.HeaderText = "Item Id";
            this.dcItemId.Name = "dcItemId";
            // 
            // dcItemName
            // 
            this.dcItemName.DataPropertyName = "Name";
            this.dcItemName.HeaderText = "Item Name";
            this.dcItemName.Name = "dcItemName";
            // 
            // dcDescription
            // 
            this.dcDescription.DataPropertyName = "Description";
            this.dcDescription.HeaderText = "Description";
            this.dcDescription.Name = "dcDescription";
            // 
            // dcCategory
            // 
            this.dcCategory.DataPropertyName = "Category";
            this.dcCategory.HeaderText = "Category";
            this.dcCategory.Name = "dcCategory";
            this.dcCategory.Visible = false;
            // 
            // dcItemType
            // 
            this.dcItemType.DataPropertyName = "Type";
            this.dcItemType.HeaderText = "Type";
            this.dcItemType.Name = "dcItemType";
            this.dcItemType.Visible = false;
            // 
            // dcItemPrice
            // 
            this.dcItemPrice.DataPropertyName = "Price";
            this.dcItemPrice.HeaderText = "Price";
            this.dcItemPrice.Name = "dcItemPrice";
            // 
            // dcItemQuantity
            // 
            this.dcItemQuantity.HeaderText = "Quantity";
            this.dcItemQuantity.MaxDropDownItems = 20;
            this.dcItemQuantity.Name = "dcItemQuantity";
            this.dcItemQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dcItemTotal
            // 
            this.dcItemTotal.DataPropertyName = "ItemTotal";
            this.dcItemTotal.HeaderText = "Item Total";
            this.dcItemTotal.Name = "dcItemTotal";
            // 
            // dcActive
            // 
            this.dcActive.DataPropertyName = "Active";
            this.dcActive.HeaderText = "Active";
            this.dcActive.Name = "dcActive";
            this.dcActive.Visible = false;
            // 
            // btnFinalizeOrder
            // 
            this.btnFinalizeOrder.Location = new System.Drawing.Point(559, 545);
            this.btnFinalizeOrder.Name = "btnFinalizeOrder";
            this.btnFinalizeOrder.Size = new System.Drawing.Size(170, 34);
            this.btnFinalizeOrder.TabIndex = 2;
            this.btnFinalizeOrder.Text = "Place Order";
            this.btnFinalizeOrder.UseVisualStyleBackColor = true;
            this.btnFinalizeOrder.Click += new System.EventHandler(this.btnFinalizeOrder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(110, 95);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(136, 20);
            this.txtFirstName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone Number";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(252, 95);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(136, 20);
            this.txtLastName.TabIndex = 6;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(193, 124);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(195, 20);
            this.txtPhoneNumber.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address";
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.Location = new System.Drawing.Point(436, 95);
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.Size = new System.Drawing.Size(293, 20);
            this.txtAddressLine1.TabIndex = 9;
            // 
            // txtAddressLine2
            // 
            this.txtAddressLine2.Location = new System.Drawing.Point(436, 121);
            this.txtAddressLine2.Name = "txtAddressLine2";
            this.txtAddressLine2.Size = new System.Drawing.Size(293, 20);
            this.txtAddressLine2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(454, 151);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(136, 20);
            this.txtCity.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(596, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pincode";
            // 
            // txtPinCode
            // 
            this.txtPinCode.Location = new System.Drawing.Point(648, 151);
            this.txtPinCode.Name = "txtPinCode";
            this.txtPinCode.Size = new System.Drawing.Size(81, 20);
            this.txtPinCode.TabIndex = 14;
            // 
            // rdoUpdateAddress
            // 
            this.rdoUpdateAddress.AutoSize = true;
            this.rdoUpdateAddress.Location = new System.Drawing.Point(613, 72);
            this.rdoUpdateAddress.Name = "rdoUpdateAddress";
            this.rdoUpdateAddress.Size = new System.Drawing.Size(99, 17);
            this.rdoUpdateAddress.TabIndex = 15;
            this.rdoUpdateAddress.TabStop = true;
            this.rdoUpdateAddress.Text = "Update Existing";
            this.rdoUpdateAddress.UseVisualStyleBackColor = true;
            // 
            // rdoCreateAddress
            // 
            this.rdoCreateAddress.AutoSize = true;
            this.rdoCreateAddress.Location = new System.Drawing.Point(505, 72);
            this.rdoCreateAddress.Name = "rdoCreateAddress";
            this.rdoCreateAddress.Size = new System.Drawing.Size(81, 17);
            this.rdoCreateAddress.TabIndex = 16;
            this.rdoCreateAddress.TabStop = true;
            this.rdoCreateAddress.Text = "Create New";
            this.rdoCreateAddress.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 512);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Discount (Rs)";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(195, 509);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(110, 20);
            this.txtDiscount.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(508, 509);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Final Price (Rs)";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTotalPrice.Location = new System.Drawing.Point(644, 506);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(40, 17);
            this.lblTotalPrice.TabIndex = 20;
            this.lblTotalPrice.Text = "0.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Customer Id";
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Location = new System.Drawing.Point(85, 545);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(170, 34);
            this.btnSearchCustomer.TabIndex = 25;
            this.btnSearchCustomer.Text = "Search Customer again";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoUpdateCustomer);
            this.panel1.Controls.Add(this.rdoCreateCustomer);
            this.panel1.Location = new System.Drawing.Point(110, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 25);
            this.panel1.TabIndex = 28;
            // 
            // rdoUpdateCustomer
            // 
            this.rdoUpdateCustomer.AutoSize = true;
            this.rdoUpdateCustomer.Location = new System.Drawing.Point(142, 3);
            this.rdoUpdateCustomer.Name = "rdoUpdateCustomer";
            this.rdoUpdateCustomer.Size = new System.Drawing.Size(99, 17);
            this.rdoUpdateCustomer.TabIndex = 1;
            this.rdoUpdateCustomer.TabStop = true;
            this.rdoUpdateCustomer.Text = "Update Existing";
            this.rdoUpdateCustomer.UseVisualStyleBackColor = true;
            // 
            // rdoCreateCustomer
            // 
            this.rdoCreateCustomer.AutoSize = true;
            this.rdoCreateCustomer.Location = new System.Drawing.Point(13, 3);
            this.rdoCreateCustomer.Name = "rdoCreateCustomer";
            this.rdoCreateCustomer.Size = new System.Drawing.Size(81, 17);
            this.rdoCreateCustomer.TabIndex = 0;
            this.rdoCreateCustomer.TabStop = true;
            this.rdoCreateCustomer.Text = "Create New";
            this.rdoCreateCustomer.UseVisualStyleBackColor = true;
            // 
            // lblAddressId
            // 
            this.lblAddressId.AutoSize = true;
            this.lblAddressId.Location = new System.Drawing.Point(715, 30);
            this.lblAddressId.Name = "lblAddressId";
            this.lblAddressId.Size = new System.Drawing.Size(54, 13);
            this.lblAddressId.TabIndex = 29;
            this.lblAddressId.Text = "AddressId";
            this.lblAddressId.Visible = false;
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(715, 54);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(42, 13);
            this.lblOrderId.TabIndex = 30;
            this.lblOrderId.Text = "OrderId";
            this.lblOrderId.Visible = false;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(107, 44);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(63, 13);
            this.lblCustomerId.TabIndex = 31;
            this.lblCustomerId.Text = "Customer Id";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 610);
            this.Controls.Add(this.lblCustomerId);
            this.Controls.Add(this.lblOrderId);
            this.Controls.Add(this.lblAddressId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearchCustomer);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rdoCreateAddress);
            this.Controls.Add(this.rdoUpdateAddress);
            this.Controls.Add(this.txtPinCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAddressLine2);
            this.Controls.Add(this.txtAddressLine1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFinalizeOrder);
            this.Controls.Add(this.dgMenuView);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FormMenu";
            this.Text = "Place Order";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dgMenuView, 0);
            this.Controls.SetChildIndex(this.btnFinalizeOrder, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtFirstName, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtLastName, 0);
            this.Controls.SetChildIndex(this.txtPhoneNumber, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtAddressLine1, 0);
            this.Controls.SetChildIndex(this.txtAddressLine2, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtCity, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtPinCode, 0);
            this.Controls.SetChildIndex(this.rdoUpdateAddress, 0);
            this.Controls.SetChildIndex(this.rdoCreateAddress, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtDiscount, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.lblTotalPrice, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.btnSearchCustomer, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.lblAddressId, 0);
            this.Controls.SetChildIndex(this.lblOrderId, 0);
            this.Controls.SetChildIndex(this.lblCustomerId, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgMenuView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFinalizeOrder;
        private System.Windows.Forms.DataGridView dgMenuView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddressLine1;
        private System.Windows.Forms.TextBox txtAddressLine2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPinCode;
        private System.Windows.Forms.RadioButton rdoUpdateAddress;
        private System.Windows.Forms.RadioButton rdoCreateAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoUpdateCustomer;
        private System.Windows.Forms.RadioButton rdoCreateCustomer;
        private System.Windows.Forms.Label lblAddressId;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcItemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcItemPrice;
        private System.Windows.Forms.DataGridViewComboBoxColumn dcItemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcItemTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcActive;
    }
}