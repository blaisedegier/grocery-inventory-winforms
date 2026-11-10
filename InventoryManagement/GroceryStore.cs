namespace InventoryManagement
{
    // The store whose stock the forms work on. The home form creates one and passes it to the add and remove forms.
    public class GroceryStore
    {
        public Inventory Inventory { get; } = new Inventory();
    }
}
