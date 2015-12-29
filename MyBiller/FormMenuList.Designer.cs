namespace MyBiller
{
    partial class FormMenuList
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
            this.dgMenuList = new System.Windows.Forms.DataGridView();
            this.dcItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcItemCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cboItemStatus = new System.Windows.Forms.ComboBox();
            this.btnGetItems = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgMenuList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMenuList
            // 
            this.dgMenuList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMenuList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dcItemId,
            this.dcItemName,
            this.dcDescription,
            this.dcItemCategory,
            this.dcItemType,
            this.dcEdit});
            this.dgMenuList.Location = new System.Drawing.Point(65, 152);
            this.dgMenuList.Name = "dgMenuList";
            this.dgMenuList.Size = new System.Drawing.Size(645, 371);
            this.dgMenuList.TabIndex = 14;
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
            this.dcItemName.HeaderText = "Name";
            this.dcItemName.Name = "dcItemName";
            // 
            // dcDescription
            // 
            this.dcDescription.DataPropertyName = "Description";
            this.dcDescription.HeaderText = "Description";
            this.dcDescription.MinimumWidth = 40;
            this.dcDescription.Name = "dcDescription";
            // 
            // dcItemCategory
            // 
            this.dcItemCategory.DataPropertyName = "Category";
            this.dcItemCategory.HeaderText = "Category";
            this.dcItemCategory.Name = "dcItemCategory";
            // 
            // dcItemType
            // 
            this.dcItemType.DataPropertyName = "Type";
            this.dcItemType.HeaderText = "Type";
            this.dcItemType.Name = "dcItemType";
            // 
            // dcEdit
            // 
            this.dcEdit.HeaderText = "Edit/View";
            this.dcEdit.Name = "dcEdit";
            this.dcEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dcEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dcEdit.Text = "Edit/View";
            this.dcEdit.UseColumnTextForLinkValue = true;
            // 
            // cboItemStatus
            // 
            this.cboItemStatus.FormattingEnabled = true;
            this.cboItemStatus.Location = new System.Drawing.Point(241, 58);
            this.cboItemStatus.Name = "cboItemStatus";
            this.cboItemStatus.Size = new System.Drawing.Size(133, 21);
            this.cboItemStatus.TabIndex = 15;
            // 
            // btnGetItems
            // 
            this.btnGetItems.Location = new System.Drawing.Point(426, 58);
            this.btnGetItems.Name = "btnGetItems";
            this.btnGetItems.Size = new System.Drawing.Size(112, 23);
            this.btnGetItems.TabIndex = 16;
            this.btnGetItems.Text = "Get Items";
            this.btnGetItems.UseVisualStyleBackColor = true;
            this.btnGetItems.Click += new System.EventHandler(this.btnGetItems_Click);
            // 
            // FormMenuList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 610);
            this.Controls.Add(this.btnGetItems);
            this.Controls.Add(this.cboItemStatus);
            this.Controls.Add(this.dgMenuList);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FormMenuList";
            this.Text = "Menu List";
            this.Controls.SetChildIndex(this.dgMenuList, 0);
            this.Controls.SetChildIndex(this.cboItemStatus, 0);
            this.Controls.SetChildIndex(this.btnGetItems, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgMenuList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMenuList;
        private System.Windows.Forms.ComboBox cboItemStatus;
        private System.Windows.Forms.Button btnGetItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcItemCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcItemType;
        private System.Windows.Forms.DataGridViewLinkColumn dcEdit;
    }
}