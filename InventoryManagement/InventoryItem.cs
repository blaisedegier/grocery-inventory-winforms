namespace InventoryManagement
{
    // InventoryItem class
    // This class represents an item in the grocery store inventory. It has properties such as Name, Price, Quantity, and Category.
    class InventoryItem
    {
        // Attributes
        private string name;
        private double price;
        private int quantity;
        private string category;

        // Constructor
        public InventoryItem(string name, double price, int quantity, string category)
        {
            // Initialize attributes
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.category = category;
        }

        // Properties
        // Getter and setter for the name of the item
        public string Name { get { return name; } set { name = value; } }
        // Getter and setter for the price of the item
        public double Price { get { return price; } set { price = value; } }
        // Getter and setter for the quantity of the item
        public int Quantity { get { return quantity; } set { quantity = value; } }
        // Getter and setter for the category of the item
        public string Category { get { return category; } set { category = value; } }
    }
}
