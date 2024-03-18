namespace RestaurantOldies.view
{
    partial class EmployeeView
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
            this.billGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billIdtextBox = new System.Windows.Forms.TextBox();
            this.itemIdtextBox = new System.Windows.Forms.TextBox();
            this.quantitytextBox = new System.Windows.Forms.TextBox();
            this.orderButton = new System.Windows.Forms.Button();
            this.itemDataGridView = new System.Windows.Forms.DataGridView();
            this.itemIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createBill = new System.Windows.Forms.Button();
            this.updateBillButton = new System.Windows.Forms.Button();
            this.viewBillButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.billGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // billGridView
            // 
            this.billGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.totalCostColumn,
            this.statusColumn,
            this.dateColumn});
            this.billGridView.Location = new System.Drawing.Point(33, 40);
            this.billGridView.Name = "billGridView";
            this.billGridView.RowHeadersWidth = 51;
            this.billGridView.RowTemplate.Height = 24;
            this.billGridView.Size = new System.Drawing.Size(741, 430);
            this.billGridView.TabIndex = 0;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "id";
            this.idColumn.MinimumWidth = 6;
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 125;
            // 
            // totalCostColumn
            // 
            this.totalCostColumn.HeaderText = "totalCost";
            this.totalCostColumn.MinimumWidth = 6;
            this.totalCostColumn.Name = "totalCostColumn";
            this.totalCostColumn.ReadOnly = true;
            this.totalCostColumn.Width = 125;
            // 
            // statusColumn
            // 
            this.statusColumn.HeaderText = "status";
            this.statusColumn.MinimumWidth = 6;
            this.statusColumn.Name = "statusColumn";
            this.statusColumn.Width = 125;
            // 
            // dateColumn
            // 
            this.dateColumn.HeaderText = "dateColumn";
            this.dateColumn.MinimumWidth = 6;
            this.dateColumn.Name = "dateColumn";
            this.dateColumn.ReadOnly = true;
            this.dateColumn.Width = 125;
            // 
            // billIdtextBox
            // 
            this.billIdtextBox.Location = new System.Drawing.Point(866, 78);
            this.billIdtextBox.Name = "billIdtextBox";
            this.billIdtextBox.Size = new System.Drawing.Size(100, 22);
            this.billIdtextBox.TabIndex = 1;
            this.billIdtextBox.Text = "bill id";
            // 
            // itemIdtextBox
            // 
            this.itemIdtextBox.Location = new System.Drawing.Point(1029, 78);
            this.itemIdtextBox.Name = "itemIdtextBox";
            this.itemIdtextBox.Size = new System.Drawing.Size(100, 22);
            this.itemIdtextBox.TabIndex = 2;
            this.itemIdtextBox.Text = "item id";
            // 
            // quantitytextBox
            // 
            this.quantitytextBox.Location = new System.Drawing.Point(1199, 78);
            this.quantitytextBox.Name = "quantitytextBox";
            this.quantitytextBox.Size = new System.Drawing.Size(100, 22);
            this.quantitytextBox.TabIndex = 3;
            this.quantitytextBox.Text = "quantity";
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(1043, 125);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(75, 23);
            this.orderButton.TabIndex = 4;
            this.orderButton.Text = "order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // itemDataGridView
            // 
            this.itemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIdColumn,
            this.itemNameColumn,
            this.itemPriceColumn,
            this.itemQuantityColumn});
            this.itemDataGridView.Location = new System.Drawing.Point(801, 176);
            this.itemDataGridView.Name = "itemDataGridView";
            this.itemDataGridView.RowHeadersWidth = 51;
            this.itemDataGridView.RowTemplate.Height = 24;
            this.itemDataGridView.Size = new System.Drawing.Size(773, 294);
            this.itemDataGridView.TabIndex = 5;
            // 
            // itemIdColumn
            // 
            this.itemIdColumn.HeaderText = "id";
            this.itemIdColumn.MinimumWidth = 6;
            this.itemIdColumn.Name = "itemIdColumn";
            this.itemIdColumn.ReadOnly = true;
            this.itemIdColumn.Width = 125;
            // 
            // itemNameColumn
            // 
            this.itemNameColumn.HeaderText = "name";
            this.itemNameColumn.MinimumWidth = 6;
            this.itemNameColumn.Name = "itemNameColumn";
            this.itemNameColumn.ReadOnly = true;
            this.itemNameColumn.Width = 125;
            // 
            // itemPriceColumn
            // 
            this.itemPriceColumn.HeaderText = "price";
            this.itemPriceColumn.MinimumWidth = 6;
            this.itemPriceColumn.Name = "itemPriceColumn";
            this.itemPriceColumn.ReadOnly = true;
            this.itemPriceColumn.Width = 125;
            // 
            // itemQuantityColumn
            // 
            this.itemQuantityColumn.HeaderText = "quantity";
            this.itemQuantityColumn.MinimumWidth = 6;
            this.itemQuantityColumn.Name = "itemQuantityColumn";
            this.itemQuantityColumn.ReadOnly = true;
            this.itemQuantityColumn.Width = 125;
            // 
            // createBill
            // 
            this.createBill.Location = new System.Drawing.Point(33, 477);
            this.createBill.Name = "createBill";
            this.createBill.Size = new System.Drawing.Size(75, 23);
            this.createBill.TabIndex = 6;
            this.createBill.Text = "create";
            this.createBill.UseVisualStyleBackColor = true;
            this.createBill.Click += new System.EventHandler(this.createBill_Click);
            // 
            // updateBillButton
            // 
            this.updateBillButton.Location = new System.Drawing.Point(127, 477);
            this.updateBillButton.Name = "updateBillButton";
            this.updateBillButton.Size = new System.Drawing.Size(75, 23);
            this.updateBillButton.TabIndex = 7;
            this.updateBillButton.Text = "update";
            this.updateBillButton.UseVisualStyleBackColor = true;
            this.updateBillButton.Click += new System.EventHandler(this.updateBillButton_Click);
            // 
            // viewBillButton
            // 
            this.viewBillButton.Location = new System.Drawing.Point(230, 477);
            this.viewBillButton.Name = "viewBillButton";
            this.viewBillButton.Size = new System.Drawing.Size(75, 23);
            this.viewBillButton.TabIndex = 8;
            this.viewBillButton.Text = "view";
            this.viewBillButton.UseVisualStyleBackColor = true;
            this.viewBillButton.Click += new System.EventHandler(this.viewBillButton_Click);
            // 
            // EmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1912, 694);
            this.Controls.Add(this.viewBillButton);
            this.Controls.Add(this.updateBillButton);
            this.Controls.Add(this.createBill);
            this.Controls.Add(this.itemDataGridView);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.quantitytextBox);
            this.Controls.Add(this.itemIdtextBox);
            this.Controls.Add(this.billIdtextBox);
            this.Controls.Add(this.billGridView);
            this.Name = "EmployeeView";
            this.Text = "EmployeeView";
            ((System.ComponentModel.ISupportInitialize)(this.billGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView billGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private System.Windows.Forms.TextBox billIdtextBox;
        private System.Windows.Forms.TextBox itemIdtextBox;
        private System.Windows.Forms.TextBox quantitytextBox;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.DataGridView itemDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQuantityColumn;
        private System.Windows.Forms.Button createBill;
        private System.Windows.Forms.Button updateBillButton;
        private System.Windows.Forms.Button viewBillButton;
    }
}