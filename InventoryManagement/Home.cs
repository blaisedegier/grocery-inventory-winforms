namespace InventoryManagement
{
    public partial class Home : Form
    {
        // Create a new GroceryStore object
        GroceryStore groceryStore = new GroceryStore();

        public Home()
        {
            InitializeComponent();
        }

        // Add Item
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Create a new AddItem form and pass the groceryStore object
            AddItem addItemForm = new AddItem(groceryStore);
            // Subscribe to the FormClosed event
            addItemForm.FormClosed += AddItemForm_FormClosed;
            // Show the form
            addItemForm.Show();
        }
        /*
         * Code Attribution
         * Form.Closed Event
         * Microsoft
         * https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.form.closed?view=windowsdesktop-8.0
         */
        private void AddItemForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            // Display the inventory
            redtDisplay.Text = groceryStore.Inventory.DisplayInventory();
        }

        // Remove Item
        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Create a new RemoveItem form and pass the groceryStore object
            RemoveItem removeItemForm = new RemoveItem(groceryStore);
            // Subscribe to the FormClosed event
            removeItemForm.FormClosed += RemoveItemForm_FormClosed;
            // Show the form
            removeItemForm.Show();
        }
        private void RemoveItemForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            // Display the inventory
            redtDisplay.Text = groceryStore.Inventory.DisplayInventory();
        }
    }
}
