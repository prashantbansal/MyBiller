namespace MyBiller
{
    partial class FormOrderList
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
            this.dgOrderList = new System.Windows.Forms.DataGridView();
            this.dcOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcPlacedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cboOrderStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGetOrderList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgOrderList
            // 
            this.dgOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dcOrderId,
            this.dcCustomerName,
            this.dcPlacedOn,
            this.dcTotal,
            this.dcStatus,
            this.dcEdit});
            this.dgOrderList.Location = new System.Drawing.Point(77, 114);
            this.dgOrderList.Name = "dgOrderList";
            this.dgOrderList.Size = new System.Drawing.Size(644, 433);
            this.dgOrderList.TabIndex = 14;
            // 
            // dcOrderId
            // 
            this.dcOrderId.DataPropertyName = "OrderId";
            this.dcOrderId.HeaderText = "Order Id";
            this.dcOrderId.Name = "dcOrderId";
            // 
            // dcCustomerName
            // 
            this.dcCustomerName.DataPropertyName = "CustomerName";
            this.dcCustomerName.HeaderText = "Customer Name";
            this.dcCustomerName.Name = "dcCustomerName";
            // 
            // dcPlacedOn
            // 
            this.dcPlacedOn.DataPropertyName = "PlacedOn";
            this.dcPlacedOn.HeaderText = "Placed On";
            this.dcPlacedOn.Name = "dcPlacedOn";
            // 
            // dcTotal
            // 
            this.dcTotal.DataPropertyName = "Total";
            this.dcTotal.HeaderText = "Total";
            this.dcTotal.Name = "dcTotal";
            // 
            // dcStatus
            // 
            this.dcStatus.DataPropertyName = "Status";
            this.dcStatus.HeaderText = "Status";
            this.dcStatus.Name = "dcStatus";
            // 
            // dcEdit
            // 
            this.dcEdit.HeaderText = "View/Edit";
            this.dcEdit.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.dcEdit.Name = "dcEdit";
            this.dcEdit.Text = "View/Edit";
            this.dcEdit.UseColumnTextForLinkValue = true;
            // 
            // cboOrderStatus
            // 
            this.cboOrderStatus.FormattingEnabled = true;
            this.cboOrderStatus.Location = new System.Drawing.Point(199, 49);
            this.cboOrderStatus.Name = "cboOrderStatus";
            this.cboOrderStatus.Size = new System.Drawing.Size(121, 21);
            this.cboOrderStatus.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Order Status";
            // 
            // btnGetOrderList
            // 
            this.btnGetOrderList.Location = new System.Drawing.Point(430, 49);
            this.btnGetOrderList.Name = "btnGetOrderList";
            this.btnGetOrderList.Size = new System.Drawing.Size(111, 23);
            this.btnGetOrderList.TabIndex = 17;
            this.btnGetOrderList.Text = "Get Order List";
            this.btnGetOrderList.UseVisualStyleBackColor = true;
            this.btnGetOrderList.Click += new System.EventHandler(this.btnGetOrderList_Click);
            // 
            // FormOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 610);
            this.Controls.Add(this.btnGetOrderList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboOrderStatus);
            this.Controls.Add(this.dgOrderList);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FormOrderList";
            this.Text = "Order List";
            this.Controls.SetChildIndex(this.dgOrderList, 0);
            this.Controls.SetChildIndex(this.cboOrderStatus, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.btnGetOrderList, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgOrderList;
        private System.Windows.Forms.ComboBox cboOrderStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGetOrderList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcPlacedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcStatus;
        private System.Windows.Forms.DataGridViewLinkColumn dcEdit;
    }
}