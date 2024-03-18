namespace RestaurantOldies.view
{
    partial class BillItemView
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
            this.itemGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // itemGridView
            // 
            this.itemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nameColumn,
            this.priceColumn});
            this.itemGridView.Location = new System.Drawing.Point(52, 43);
            this.itemGridView.Name = "itemGridView";
            this.itemGridView.RowHeadersWidth = 51;
            this.itemGridView.RowTemplate.Height = 24;
            this.itemGridView.Size = new System.Drawing.Size(596, 363);
            this.itemGridView.TabIndex = 0;
            this.itemGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemGridView_CellContentClick);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "id";
            this.idColumn.MinimumWidth = 6;
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 125;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "name";
            this.nameColumn.MinimumWidth = 6;
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            this.nameColumn.Width = 125;
            // 
            // priceColumn
            // 
            this.priceColumn.HeaderText = "price";
            this.priceColumn.MinimumWidth = 6;
            this.priceColumn.Name = "priceColumn";
            this.priceColumn.ReadOnly = true;
            this.priceColumn.Width = 125;
            // 
            // BillItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.itemGridView);
            this.Name = "BillItemView";
            this.Text = "BillItemView";
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView itemGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
    }
}