namespace InventoryManagement
{
    public partial class Home : Form
    {
        private readonly GroceryStore groceryStore = new GroceryStore();

        public Home()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddItem addItemForm = new AddItem(groceryStore);
            addItemForm.FormClosed += ChildForm_FormClosed;
            addItemForm.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveItem removeItemForm = new RemoveItem(groceryStore);
            removeItemForm.FormClosed += ChildForm_FormClosed;
            removeItemForm.Show();
        }

        // Refreshes the inventory display whenever the add or remove form closes.
        // Adapted from https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.form.closed?view=windowsdesktop-8.0
        private void ChildForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            redtDisplay.Text = groceryStore.Inventory.DisplayInventory();
        }
    }
}
