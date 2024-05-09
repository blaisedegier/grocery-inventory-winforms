namespace InventoryManagement
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            btnRemove = new Button();
            redtDisplay = new RichTextBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAdd.Location = new Point(12, 396);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 42);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add Item";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRemove.Location = new Point(316, 396);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(133, 42);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Remove Item";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // redtDisplay
            // 
            redtDisplay.Font = new Font("Arial", 16F);
            redtDisplay.Location = new Point(12, 12);
            redtDisplay.Name = "redtDisplay";
            redtDisplay.Size = new Size(437, 378);
            redtDisplay.TabIndex = 2;
            redtDisplay.Text = "";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 450);
            Controls.Add(redtDisplay);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Name = "Home";
            Text = "Inventory Manager";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdd;
        private Button btnRemove;
        private RichTextBox redtDisplay;
    }
}
