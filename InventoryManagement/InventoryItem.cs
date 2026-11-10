namespace InventoryManagement
{
    // A stocked item: its name, unit price in rand, quantity on hand and category.
    public class InventoryItem
    {
        public InventoryItem(string name, decimal price, int quantity, Category category)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Category = category;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Category Category { get; set; }
    }
}
