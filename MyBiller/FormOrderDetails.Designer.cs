namespace MyBiller
{
    partial class FormOrderDetails
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
            this.dgOrderItems = new System.Windows.Forms.DataGridView();
            this.btnModifyOrder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblTotalWithoutTax = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.lblAddressId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlacedOn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.btnOrderDelivered = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.dcItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgOrderItems
            // 
            this.dgOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dcItemName,
            this.dcQuantity,
            this.dcItemPrice,
            this.dcTotalPrice});
            this.dgOrderItems.Location = new System.Drawing.Point(64, 174);
            this.dgOrderItems.Name = "dgOrderItems";
            this.dgOrderItems.Size = new System.Drawing.Size(441, 225);
            this.dgOrderItems.TabIndex = 0;
            // 
            // btnModifyOrder
            // 
            this.btnModifyOrder.Location = new System.Drawing.Point(589, 376);
            this.btnModifyOrder.Name = "btnModifyOrder";
            this.btnModifyOrder.Size = new System.Drawing.Size(157, 23);
            this.btnModifyOrder.TabIndex = 1;
            this.btnModifyOrder.Text = "Modify the Order";
            this.btnModifyOrder.UseVisualStyleBackColor = true;
            this.btnModifyOrder.Click += new System.EventHandler(this.btnModifyOrder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer Details:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(520, 93);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(398, 93);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(48, 13);
            this.Address.TabIndex = 5;
            this.Address.Text = "Address:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(398, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Phone#:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(520, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label21.Location = new System.Drawing.Point(575, 216);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 15);
            this.label21.TabIndex = 9;
            this.label21.Text = "Discount:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label20.Location = new System.Drawing.Point(520, 187);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(122, 15);
            this.label20.TabIndex = 10;
            this.label20.Text = "Total Without Tax:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(61, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Order ID:";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(142, 51);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(47, 13);
            this.lblOrderID.TabIndex = 16;
            this.lblOrderID.Text = "Order ID";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(520, 69);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(48, 13);
            this.lblPhone.TabIndex = 18;
            this.lblPhone.Text = "Phone #";
            // 
            // lblTotalWithoutTax
            // 
            this.lblTotalWithoutTax.AutoSize = true;
            this.lblTotalWithoutTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWithoutTax.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTotalWithoutTax.Location = new System.Drawing.Point(659, 187);
            this.lblTotalWithoutTax.Name = "lblTotalWithoutTax";
            this.lblTotalWithoutTax.Size = new System.Drawing.Size(110, 15);
            this.lblTotalWithoutTax.TabIndex = 19;
            this.lblTotalWithoutTax.Text = "TotalWithoutTax";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblDiscount.Location = new System.Drawing.Point(659, 216);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(63, 15);
            this.lblDiscount.TabIndex = 20;
            this.lblDiscount.Text = "Discount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(599, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTotal.Location = new System.Drawing.Point(659, 244);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(39, 15);
            this.lblTotal.TabIndex = 22;
            this.lblTotal.Text = "Total";
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(589, 507);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(157, 23);
            this.btnNewOrder.TabIndex = 23;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(697, 47);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(60, 13);
            this.lblCustomerId.TabIndex = 24;
            this.lblCustomerId.Text = "CustomerId";
            this.lblCustomerId.Visible = false;
            // 
            // lblAddressId
            // 
            this.lblAddressId.AutoSize = true;
            this.lblAddressId.Location = new System.Drawing.Point(703, 69);
            this.lblAddressId.Name = "lblAddressId";
            this.lblAddressId.Size = new System.Drawing.Size(54, 13);
            this.lblAddressId.TabIndex = 25;
            this.lblAddressId.Text = "AddressId";
            this.lblAddressId.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Placed On:";
            // 
            // lblPlacedOn
            // 
            this.lblPlacedOn.AutoSize = true;
            this.lblPlacedOn.Location = new System.Drawing.Point(142, 79);
            this.lblPlacedOn.Name = "lblPlacedOn";
            this.lblPlacedOn.Size = new System.Drawing.Size(57, 13);
            this.lblPlacedOn.TabIndex = 27;
            this.lblPlacedOn.Text = "Placed On";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Status:";
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.Location = new System.Drawing.Point(142, 104);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(66, 13);
            this.lblOrderStatus.TabIndex = 29;
            this.lblOrderStatus.Text = "Order Status";
            // 
            // btnOrderDelivered
            // 
            this.btnOrderDelivered.Location = new System.Drawing.Point(125, 507);
            this.btnOrderDelivered.Name = "btnOrderDelivered";
            this.btnOrderDelivered.Size = new System.Drawing.Size(157, 23);
            this.btnOrderDelivered.TabIndex = 30;
            this.btnOrderDelivered.Text = "Mark Order as Completed";
            this.btnOrderDelivered.UseVisualStyleBackColor = true;
            this.btnOrderDelivered.Click += new System.EventHandler(this.btnOrderDelivered_Click);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(348, 507);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(157, 23);
            this.btnCancelOrder.TabIndex = 31;
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // dcItemName
            // 
            this.dcItemName.DataPropertyName = "ItemName";
            this.dcItemName.HeaderText = "Item Name";
            this.dcItemName.Name = "dcItemName";
            // 
            // dcQuantity
            // 
            this.dcQuantity.DataPropertyName = "Quantity";
            this.dcQuantity.HeaderText = "Quantity";
            this.dcQuantity.Name = "dcQuantity";
            // 
            // dcItemPrice
            // 
            this.dcItemPrice.DataPropertyName = "PricePerItem";
            this.dcItemPrice.HeaderText = "Price Per Item";
            this.dcItemPrice.Name = "dcItemPrice";
            // 
            // dcTotalPrice
            // 
            this.dcTotalPrice.DataPropertyName = "TotalPrice";
            this.dcTotalPrice.HeaderText = "Total Price";
            this.dcTotalPrice.Name = "dcTotalPrice";
            // 
            // FormOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 610);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.btnOrderDelivered);
            this.Controls.Add(this.lblOrderStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPlacedOn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAddressId);
            this.Controls.Add(this.lblCustomerId);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblTotalWithoutTax);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnModifyOrder);
            this.Controls.Add(this.dgOrderItems);
            this.Name = "FormOrderDetails";
            this.Text = "Order Details";
            this.Controls.SetChildIndex(this.dgOrderItems, 0);
            this.Controls.SetChildIndex(this.btnModifyOrder, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lblAddress, 0);
            this.Controls.SetChildIndex(this.Address, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.label21, 0);
            this.Controls.SetChildIndex(this.label20, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.lblOrderID, 0);
            this.Controls.SetChildIndex(this.lblPhone, 0);
            this.Controls.SetChildIndex(this.lblTotalWithoutTax, 0);
            this.Controls.SetChildIndex(this.lblDiscount, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.lblTotal, 0);
            this.Controls.SetChildIndex(this.btnNewOrder, 0);
            this.Controls.SetChildIndex(this.lblCustomerId, 0);
            this.Controls.SetChildIndex(this.lblAddressId, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblPlacedOn, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblOrderStatus, 0);
            this.Controls.SetChildIndex(this.btnOrderDelivered, 0);
            this.Controls.SetChildIndex(this.btnCancelOrder, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgOrderItems;
        private System.Windows.Forms.Button btnModifyOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblTotalWithoutTax;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblAddressId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlacedOn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOrderStatus;
        private System.Windows.Forms.Button btnOrderDelivered;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcTotalPrice;
    }
}