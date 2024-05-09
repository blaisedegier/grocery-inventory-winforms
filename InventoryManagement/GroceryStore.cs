namespace InventoryManagement
{
    // GroceryStore class
    // This class represents the grocery store as a whole.
    public class GroceryStore
    {
        // It has a property called Inventory that is an instance of the Inventory class.
        public Inventory Inventory;

        // Constructor
        public GroceryStore() => Inventory = new Inventory();
    }
}
