namespace InventoryManagement
{
    // The rules an item must pass before it is added to the inventory.
    class InputValidator
    {
        // A name must contain something other than white space.
        public static bool isValidName(string name) => !string.IsNullOrWhiteSpace(name);

        // Zero is allowed for both price and quantity; negatives are not.
        public static bool isValidPrice(decimal price) => price >= 0;

        public static bool isValidQuantity(int quantity) => quantity >= 0;
    }
}
