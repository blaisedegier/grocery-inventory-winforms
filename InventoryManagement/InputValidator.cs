namespace InventoryManagement
{
    // InputValidator class
    // This class is responsible for validating user input. It implements methods to validate user input for adding and removing items from the inventory.
    class InputValidator
    {
        // ValidateItemAdd method
        // Validate the name of the item
        public static bool isValidName(string name) => name != null && name != "";
        // Validate the price of the item
        public static bool isValidPrice(double price) => price >= 0;
        // Validate the quantity of the item
        public static bool isValidQuantity(int quantity) => quantity >= 0;
    }
}
