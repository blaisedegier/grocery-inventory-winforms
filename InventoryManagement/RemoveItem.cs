namespace InventoryManagement
{
    public partial class RemoveItem : Form
    {
        private readonly GroceryStore groceryStore;
        private InventoryItem? item;

        public RemoveItem(GroceryStore groceryStore)
        {
            InitializeComponent();
            this.groceryStore = groceryStore;

            // Selecting the first category raises SelectedIndexChanged, which fills the item list.
            cmbCategory.SelectedIndex = 0;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Enum.TryParse(cmbCategory.Text, out Category category))
            {
                return;
            }

            List<InventoryItem> items = groceryStore.Inventory.GetItems(category);
            lblItem.Enabled = items.Count > 0;
            cmbItem.Enabled = items.Count > 0;

            // Adapted from https://stackoverflow.com/questions/9521980/combobox-valuemember-and-displaymember
            cmbItem.DataSource = items;
            cmbItem.DisplayMember = "Name";

            item = cmbItem.SelectedItem as InventoryItem;
            btnRemove.Enabled = item != null;
        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            item = cmbItem.SelectedItem as InventoryItem;
            btnRemove.Enabled = item != null;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (item != null)
            {
                groceryStore.Inventory.RemoveItem(item);
            }
            Close();
        }
    }
}
