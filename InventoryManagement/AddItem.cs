namespace InventoryManagement
{
    public partial class AddItem : Form
    {
        // Attributes
        private GroceryStore groceryStore;

        public AddItem(GroceryStore groceryStore)
        {
            InitializeComponent();
            this.groceryStore = groceryStore;
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            // Get the input values
            string name = txtName.Text;
            double price = double.Parse(txtPrice.Text);
            int quantity = int.Parse(txtQuantity.Text);
            Category category = Category.Fruits;

            // Convert the selected category to an enum
            switch (cmbCategory.Text)
            {
                case "Fruits":
                    category = Category.Fruits;
                    break;
                case "Vegetables":
                    category = Category.Vegetables;
                    break;
                case "Dairy":
                    category = Category.Dairy;
                    break;
                case "Meat":
                    category = Category.Meat;
                    break;
                case "Bakery":
                    category = Category.Bakery;
                    break;
                case "Beverages":
                    category = Category.Beverages;
                    break;
                case "Snacks":
                    category = Category.Snacks;
                    break;
                case "Household":
                    category = Category.Household;
                    break;
            }

            // Validate the input values
            try
            {
                ErrorHandler.HandleAddError(name, price, quantity);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Create an InventoryItem object
            /*
             * Code Attribution:
             * Convert String to Enum in C#
             * TutorialsTeacher
             * www.tutorialsteacher.com
             * 17 August 2021
             * https://www.tutorialsteacher.com/articles/convert-string-to-enum-in-csharp
             */
            InventoryItem item = new InventoryItem(name, price, quantity, category);

            // Add the item to the inventory
            groceryStore.Inventory.AddItem(item);

            // Close the form
            Close();
        }
    }
}
