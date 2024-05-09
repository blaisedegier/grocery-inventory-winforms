using System.Text;

namespace InventoryManagement
{
    // Inventory class
    // This class represents the grocery store inventory as a collection of InventoryItem objects.
    public class Inventory
    {
        // Attributes
        //This data structure can be used to store the inventory items as key-value pairs.
        //The keys can represent the item categories, and the values can be a list of InventoryItem objects.
        private Dictionary<Category, List<InventoryItem>> items;
        // This data structure can be used to keep track of the history of items added to the inventory.
        // When an item is added to the inventory, it can be pushed onto the stack. When an item is removed from the inventory, it can be popped from the stack.
        private Stack<InventoryItem> history;
        // This data structure can be used to keep track of the items that need to be restocked.
        // When an item's quantity goes below a certain threshold, it can be added to the queue.
        private Queue<InventoryItem> restock;
        // This constant can be used to set the threshold quantity for restocking items.
        private const int RESTOCK_THRESHOLD = 10;

        // Constructor
        public Inventory()
        {
            items = new Dictionary<Category, List<InventoryItem>>();
            history = new Stack<InventoryItem>();
            restock = new Queue<InventoryItem>();
        }

        // AddItem method
        // This method adds an item to the inventory by taking in an InventoryItem object as a parameter.
        public void AddItem(InventoryItem item)
        {
            // Check if the category exists in the dictionary
            if (!items.ContainsKey(item.Category))
            {
                // If the category does not exist, add it to the dictionary
                items[item.Category] = new List<InventoryItem>();
            }
            // Add the item to the list of items in the category
            items[item.Category].Add(item);
            // Push the item onto the history stack
            history.Push(item);
        }

        // RemoveItem method
        // This method removes an item from the inventory by taking in an InventoryItem object as a parameter.
        public void RemoveItem(InventoryItem item)
        {
            // Removes the item from the list of items in the category
            items[item.Category].Remove(item);
            // Check if the item is in the history stack
            if (history.Count > 0 && history.Peek() == item)
            {
                // If the item is in the history stack, pop it from the stack
                history.Pop();
            }
        }

        // DisplayInventory method
        // This method displays the current inventory by item categories.
        public string DisplayInventory()
        {
            // Create a StringBuilder to store the display
            StringBuilder display = new StringBuilder();
            // Loop through the dictionary by category
            foreach (var category in items.Keys)
            {
                // Display the category
                display.AppendLine($"Category: {category}");
                // Loop through the items in the category
                foreach (var item in items[category])
                {
                    // Display the item
                    display.AppendLine($"Item: {item.Name}\tPrice: R{item.Price}\tQuantity: {item.Quantity}");
                }
            }
            // Return the display as a string
            return display.ToString();
        }

        // GetItems method
        // Get the items in the specified category
        public List<InventoryItem> GetItems(Category category)
        {
            // Check if the category exists in the dictionary
            if (items.ContainsKey(category))
            {
                // Return the list of items in the category
                return items[category];
            }
            // If the category does not exist, return an empty list
            else
            {
                return new List<InventoryItem>();
            }
        }

        // CheckRestock method
        // Check if an item needs to be restocked
        public void CheckRestock(InventoryItem item)
        {
            // Check if the item's quantity is below the restock threshold
            if (item.Quantity < RESTOCK_THRESHOLD)
            {
                // If the item's quantity is below the restock threshold, add it to the restock queue
                restock.Enqueue(item);
            }
        }
    }
}
