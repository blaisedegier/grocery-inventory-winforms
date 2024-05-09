namespace InventoryManagement
{
    partial class RemoveItem
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
            cmbCategory = new ComboBox();
            lblCategory = new Label();
            lblTitle = new Label();
            cmbItem = new ComboBox();
            lblItem = new Label();
            btnRemove = new Button();
            SuspendLayout();
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Segoe UI", 12F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Fruits", "Vegetables", "Dairy", "Meat", "Bakery", "Beverages", "Snacks", "Household" });
            cmbCategory.Location = new Point(12, 72);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(284, 29);
            cmbCategory.TabIndex = 8;
            cmbCategory.Text = "Fruits";
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 12F);
            lblCategory.Location = new Point(12, 48);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(116, 21);
            lblCategory.TabIndex = 9;
            lblCategory.Text = "Enter Category:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(149, 30);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "Remove Item";
            // 
            // cmbItem
            // 
            cmbItem.Enabled = false;
            cmbItem.Font = new Font("Segoe UI", 12F);
            cmbItem.FormattingEnabled = true;
            cmbItem.Location = new Point(12, 128);
            cmbItem.Name = "cmbItem";
            cmbItem.Size = new Size(284, 29);
            cmbItem.TabIndex = 11;
            cmbItem.SelectedIndexChanged += cmbItem_SelectedIndexChanged;
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Enabled = false;
            lblItem.Font = new Font("Segoe UI", 12F);
            lblItem.Location = new Point(12, 104);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(89, 21);
            lblItem.TabIndex = 12;
            lblItem.Text = "Select Item:";
            // 
            // btnRemove
            // 
            btnRemove.Enabled = false;
            btnRemove.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRemove.Location = new Point(110, 163);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(88, 35);
            btnRemove.TabIndex = 13;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // RemoveItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 204);
            Controls.Add(btnRemove);
            Controls.Add(cmbItem);
            Controls.Add(lblItem);
            Controls.Add(lblTitle);
            Controls.Add(cmbCategory);
            Controls.Add(lblCategory);
            Name = "RemoveItem";
            Text = "Remove Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCategory;
        private Label lblCategory;
        private Label lblTitle;
        private ComboBox cmbItem;
        private Label lblItem;
        private Button btnRemove;
    }
}