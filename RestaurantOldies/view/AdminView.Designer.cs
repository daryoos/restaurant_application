namespace RestaurantOldies.view
{
    partial class AdminView
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
            this.components = new System.ComponentModel.Container();
            this.itemGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateItemsButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.createEmployeeAccountButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // itemGridView
            // 
            this.itemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nameColumn,
            this.priceColumn,
            this.quantityColumn});
            this.itemGridView.Location = new System.Drawing.Point(44, 48);
            this.itemGridView.Name = "itemGridView";
            this.itemGridView.RowHeadersWidth = 51;
            this.itemGridView.RowTemplate.Height = 24;
            this.itemGridView.Size = new System.Drawing.Size(739, 393);
            this.itemGridView.TabIndex = 0;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "id";
            this.idColumn.MinimumWidth = 6;
            this.idColumn.Name = "idColumn";
            this.idColumn.Width = 125;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "name";
            this.nameColumn.MinimumWidth = 6;
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.Width = 125;
            // 
            // priceColumn
            // 
            this.priceColumn.HeaderText = "price";
            this.priceColumn.MinimumWidth = 6;
            this.priceColumn.Name = "priceColumn";
            this.priceColumn.Width = 125;
            // 
            // quantityColumn
            // 
            this.quantityColumn.HeaderText = "quantity";
            this.quantityColumn.MinimumWidth = 6;
            this.quantityColumn.Name = "quantityColumn";
            this.quantityColumn.Width = 125;
            // 
            // updateItemsButton
            // 
            this.updateItemsButton.Location = new System.Drawing.Point(304, 447);
            this.updateItemsButton.Name = "updateItemsButton";
            this.updateItemsButton.Size = new System.Drawing.Size(248, 23);
            this.updateItemsButton.TabIndex = 1;
            this.updateItemsButton.Text = "update";
            this.updateItemsButton.UseVisualStyleBackColor = true;
            this.updateItemsButton.Click += new System.EventHandler(this.updateItemsButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(44, 447);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(254, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(558, 447);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(225, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(RestaurantOldies.model.Item);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Item List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(868, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Create Employee Account";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(871, 72);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(257, 22);
            this.usernameTextBox.TabIndex = 6;
            this.usernameTextBox.Text = "username";
            this.usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(873, 118);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(255, 22);
            this.passwordTextBox.TabIndex = 7;
            this.passwordTextBox.Text = "password";
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(871, 168);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(257, 22);
            this.nameTextBox.TabIndex = 8;
            this.nameTextBox.Text = "name";
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // createEmployeeAccountButton
            // 
            this.createEmployeeAccountButton.Location = new System.Drawing.Point(873, 221);
            this.createEmployeeAccountButton.Name = "createEmployeeAccountButton";
            this.createEmployeeAccountButton.Size = new System.Drawing.Size(75, 23);
            this.createEmployeeAccountButton.TabIndex = 9;
            this.createEmployeeAccountButton.Text = "create";
            this.createEmployeeAccountButton.UseVisualStyleBackColor = true;
            this.createEmployeeAccountButton.Click += new System.EventHandler(this.createEmployeeAccountButton_Click);
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 526);
            this.Controls.Add(this.createEmployeeAccountButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.updateItemsButton);
            this.Controls.Add(this.itemGridView);
            this.Name = "AdminView";
            this.Text = "AdminView";
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.DataGridView itemGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.Button updateItemsButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button createEmployeeAccountButton;
    }
}