namespace InventoryManagement
{
    // Turns a failed validation rule into an ArgumentException whose message names the bad value.
    class ErrorHandler
    {
        // Throws ArgumentException for the first of name, price or quantity that is not valid.
        public static void HandleAddError(string name, decimal price, int quantity)
        {
            if (!InputValidator.isValidName(name))
            {
                throw new ArgumentException("Enter a name for the item.");
            }
            if (!InputValidator.isValidPrice(price))
            {
                throw new ArgumentException("Invalid price: " + price + ". The price cannot be negative.");
            }
            if (!InputValidator.isValidQuantity(quantity))
            {
                throw new ArgumentException("Invalid quantity: " + quantity + ". The quantity cannot be negative.");
            }
        }
    }
}
