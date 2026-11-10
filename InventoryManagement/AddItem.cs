using System.Globalization;

namespace InventoryManagement
{
    public partial class AddItem : Form
    {
        private readonly GroceryStore groceryStore;

        public AddItem(GroceryStore groceryStore)
        {
            InitializeComponent();
            this.groceryStore = groceryStore;
            cmbCategory.SelectedIndex = 0;
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();

            if (!TryParsePrice(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Enter the price as a number, for example 12.50.", "Add Item");
                txtPrice.Focus();
                return;
            }

            if (!int.TryParse(txtQuantity.Text, NumberStyles.Integer, CultureInfo.CurrentCulture, out int quantity))
            {
                MessageBox.Show("Enter the quantity as a whole number.", "Add Item");
                txtQuantity.Focus();
                return;
            }

            // Adapted from https://www.tutorialsteacher.com/articles/convert-string-to-enum-in-csharp
            if (!Enum.TryParse(cmbCategory.Text, out Category category))
            {
                MessageBox.Show("Select a category.", "Add Item");
                return;
            }

            try
            {
                ErrorHandler.HandleAddError(name, price, quantity);
            }
            catch (ArgumentException ex)
            {
                // Leave the form open so the input can be corrected; nothing is added.
                MessageBox.Show(ex.Message, "Add Item");
                return;
            }

            groceryStore.Inventory.AddItem(new InventoryItem(name, price, quantity, category));
            Close();
        }

        // Accepts the current culture's decimal separator, and also a full stop when that culture uses a comma.
        private static bool TryParsePrice(string text, out decimal price) =>
            decimal.TryParse(text, NumberStyles.Number, CultureInfo.CurrentCulture, out price)
            || decimal.TryParse(text, NumberStyles.Number, CultureInfo.InvariantCulture, out price);
    }
}
