namespace InventoryManagement
{
    partial class AddItem
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
            lblTitle = new Label();
            lblName = new Label();
            txtName = new TextBox();
            txtPrice = new TextBox();
            lblPrice = new Label();
            txtQuantity = new TextBox();
            lblQuantity = new Label();
            lblCategory = new Label();
            butAdd = new Button();
            cmbCategory = new ComboBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(110, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add Item";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F);
            lblName.Location = new Point(12, 48);
            lblName.Name = "lblName";
            lblName.Size = new Size(95, 21);
            lblName.TabIndex = 1;
            lblName.Text = "Enter Name:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(12, 72);
            txtName.Name = "txtName";
            txtName.Size = new Size(284, 29);
            txtName.TabIndex = 0;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F);
            txtPrice.Location = new Point(12, 128);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(284, 29);
            txtPrice.TabIndex = 1;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 12F);
            lblPrice.Location = new Point(12, 104);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(87, 21);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Enter Price:";
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 12F);
            txtQuantity.Location = new Point(12, 184);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(284, 29);
            txtQuantity.TabIndex = 2;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 12F);
            lblQuantity.Location = new Point(12, 160);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(113, 21);
            lblQuantity.TabIndex = 5;
            lblQuantity.Text = "Enter Quantity:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 12F);
            lblCategory.Location = new Point(12, 216);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(116, 21);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "Enter Category:";
            // 
            // butAdd
            // 
            butAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            butAdd.Location = new Point(110, 287);
            butAdd.Name = "butAdd";
            butAdd.Size = new Size(88, 35);
            butAdd.TabIndex = 4;
            butAdd.Text = "Add";
            butAdd.UseVisualStyleBackColor = true;
            butAdd.Click += butAdd_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Segoe UI", 12F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Fruits", "Vegetables", "Dairy", "Meat", "Bakery", "Beverages", "Snacks", "Household" });
            cmbCategory.Location = new Point(12, 240);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(284, 29);
            cmbCategory.TabIndex = 3;
            cmbCategory.Text = "Fruits";
            // 
            // AddItem
            // 
            AcceptButton = butAdd;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 342);
            Controls.Add(cmbCategory);
            Controls.Add(butAdd);
            Controls.Add(lblCategory);
            Controls.Add(txtQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Name = "AddItem";
            Text = "Add Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private TextBox txtName;
        private TextBox txtPrice;
        private Label lblPrice;
        private TextBox txtQuantity;
        private Label lblQuantity;
        private Label lblCategory;
        private Button butAdd;
        private ComboBox cmbCategory;
    }
}