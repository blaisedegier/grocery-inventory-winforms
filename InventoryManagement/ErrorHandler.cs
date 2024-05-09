namespace InventoryManagement
{
    // ErrorHandler class
    // This class handles errors that occur during program execution.
    // It implements methods to handle exceptions that occur when adding or removing items from the inventory.
    class ErrorHandler
    {
        // HandleAddError method
        public static void HandleAddError(string name, double price, int quantity)
        {
            // Check if the name is valid
            if (!InputValidator.isValidName(name))
            {
                throw new ArgumentException("Invalid name: " + name);
            }
            // Check if the price is valid
            if (!InputValidator.isValidPrice(price))
            {
                throw new ArgumentException("Invalid price: " + price);
            }
            // Check if the quantity is valid
            if (!InputValidator.isValidQuantity(quantity))
            {
                throw new ArgumentException("Invalid quantity: " + quantity);
            }
        }
    }
}
