namespace InventoryManagement
{
    public partial class RemoveItem : Form
    {
        // Attributes
        private GroceryStore groceryStore;
        private InventoryItem? item;

        public RemoveItem(GroceryStore groceryStore)
        {
            InitializeComponent();
            this.groceryStore = groceryStore;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Enable the item label and combo box
            lblItem.Enabled = true;
            cmbItem.Enabled = true;

            // Convert the selected category to an enum
            switch (cmbCategory.Text)
            {
                case "Fruits":
                    cmbItem.DataSource = groceryStore.Inventory.GetItems(Category.Fruits);
                    break;
                case "Vegetables":
                    cmbItem.DataSource = groceryStore.Inventory.GetItems(Category.Vegetables);
                    break;
                case "Dairy":
                    cmbItem.DataSource = groceryStore.Inventory.GetItems(Category.Dairy);
                    break;
                case "Meat":
                    cmbItem.DataSource = groceryStore.Inventory.GetItems(Category.Meat);
                    break;
                case "Bakery":
                    cmbItem.DataSource = groceryStore.Inventory.GetItems(Category.Bakery);
                    break;
                case "Beverages":
                    cmbItem.DataSource = groceryStore.Inventory.GetItems(Category.Beverages);
                    break;
                case "Snacks":
                    cmbItem.DataSource = groceryStore.Inventory.GetItems(Category.Snacks);
                    break;
                case "Household":
                    cmbItem.DataSource = groceryStore.Inventory.GetItems(Category.Household);
                    break;
            }

            // Set the display member
            /*
             * Code Attribution
             * ComboBox.ValueMember and DisplayMember
             * Visitor
             * Stack Overflow
             * 24 September 2014
             * https://stackoverflow.com/questions/9521980/combobox-valuemember-and-displaymember
             */
            cmbItem.DisplayMember = "Name";
        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Enable the remove button
            btnRemove.Enabled = true;

            // Get the selected item
            item = cmbItem.SelectedItem as InventoryItem;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Check if the item is not null
            if (item != null)
            {
                // Remove the item from the inventory
                groceryStore.Inventory.RemoveItem(item);
            }

            // Close the form
            Close();
        }
    }
}
