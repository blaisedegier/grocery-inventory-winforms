using System.Text;

namespace InventoryManagement
{
    // The store's stock, grouped by category, plus a history of additions and a queue of items to reorder.
    public class Inventory
    {
        // An item whose quantity is below this is queued for restocking.
        private const int RESTOCK_THRESHOLD = 10;

        // Items grouped by category. A category's list is created the first time an item is added to it.
        private readonly Dictionary<Category, List<InventoryItem>> items;

        // Items in the order they were added, most recent on top. Removed items are taken out.
        private Stack<InventoryItem> history;

        // Items below RESTOCK_THRESHOLD, in the order they were found to be low. Each item appears at most once.
        private Queue<InventoryItem> restock;

        public Inventory()
        {
            items = new Dictionary<Category, List<InventoryItem>>();
            history = new Stack<InventoryItem>();
            restock = new Queue<InventoryItem>();
        }

        // Items currently queued for restocking, oldest first.
        public IReadOnlyCollection<InventoryItem> RestockQueue => restock;

        // Adds an item under its category, records it in the history and checks whether it needs restocking.
        public void AddItem(InventoryItem item)
        {
            if (!items.ContainsKey(item.Category))
            {
                items[item.Category] = new List<InventoryItem>();
            }
            items[item.Category].Add(item);
            history.Push(item);
            CheckRestock(item);
        }

        // Removes an item from its category, the history and the restock queue.
        public void RemoveItem(InventoryItem item)
        {
            if (items.TryGetValue(item.Category, out List<InventoryItem>? list))
            {
                list.Remove(item);
            }

            // Stack and Queue cannot remove from the middle, so rebuild each without the item, keeping the order.
            history = new Stack<InventoryItem>(history.Where(i => i != item).Reverse());
            restock = new Queue<InventoryItem>(restock.Where(i => i != item));
        }

        // Builds the text shown on the home screen: items by category, the most recent addition and the restock queue.
        public string DisplayInventory()
        {
            StringBuilder display = new StringBuilder();
            foreach (var category in items.Keys)
            {
                if (items[category].Count == 0)
                {
                    continue;
                }
                display.AppendLine($"Category: {category}");
                foreach (var item in items[category])
                {
                    display.AppendLine($"Item: {item.Name}\tPrice: R{item.Price:0.00}\tQuantity: {item.Quantity}");
                }
            }

            if (history.Count > 0)
            {
                display.AppendLine();
                display.AppendLine($"Last added: {history.Peek().Name}");
            }

            if (restock.Count > 0)
            {
                display.AppendLine();
                display.AppendLine($"Restock (quantity below {RESTOCK_THRESHOLD}):");
                foreach (var item in restock)
                {
                    display.AppendLine($"{item.Name}\tQuantity: {item.Quantity}");
                }
            }
            return display.ToString();
        }

        // Returns the items in a category, or an empty list when the category has none.
        public List<InventoryItem> GetItems(Category category)
        {
            if (items.TryGetValue(category, out List<InventoryItem>? list))
            {
                return list;
            }
            return new List<InventoryItem>();
        }

        // Queues an item for restocking when its quantity is below the threshold and it is not already queued.
        public void CheckRestock(InventoryItem item)
        {
            if (item.Quantity < RESTOCK_THRESHOLD && !restock.Contains(item))
            {
                restock.Enqueue(item);
            }
        }
    }
}
