# Grocery Inventory

A Windows Forms stock list for a grocery store that groups items by category and flags low stock for restocking.

[![CI](https://github.com/blaisedegier/grocery-inventory-winforms/actions/workflows/ci.yml/badge.svg)](https://github.com/blaisedegier/grocery-inventory-winforms/actions/workflows/ci.yml)

## What it does

- **Add Item** opens a form for a name, a price in rand, a quantity and a category. Invalid input (an empty name, a
  price or quantity that is not a number, or a negative value) shows a message and keeps the form open; nothing is
  added until the input is valid.
- **Remove Item** opens a form where you pick a category and then one of its items. **Remove** is enabled only once
  an item is selected.
- The home screen lists the stock by category, names the most recently added item, and lists every item with a
  quantity below 10 under **Restock**.

Categories: Fruits, Vegetables, Dairy, Meat, Bakery, Beverages, Snacks, Household.

## How it works

`Inventory` keeps three collections, each doing one job:

| Collection                                  | Purpose                                                                 |
| ------------------------------------------- | ----------------------------------------------------------------------- |
| `Dictionary<Category, List<InventoryItem>>` | The stock itself, one list per category, created on first use.           |
| `Stack<InventoryItem>`                      | Additions in order, so the most recent is on top.                        |
| `Queue<InventoryItem>`                      | Items to restock, in the order they were found to be low, each once.     |

`AddItem` files the item under its category, pushes it onto the history and calls `CheckRestock`, which enqueues it
when its quantity is below the threshold. `RemoveItem` takes the item out of its category list and, because a
stack or queue cannot remove from the middle, rebuilds both without it while keeping their order.

Input checks are split in two: `InputValidator` holds the rules, and `ErrorHandler` turns the first failed rule into
an `ArgumentException` that the add form shows. Prices are `decimal`. The home form refreshes its display from the
`FormClosed` event of the add and remove forms.

## Running it

Prerequisites: Windows and the [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0).

```bash
git clone https://github.com/blaisedegier/grocery-inventory-winforms.git
cd grocery-inventory-winforms
dotnet build InventoryManagement/InventoryManagement.sln -c Release
dotnet run --project InventoryManagement/InventoryManagement.csproj
```

Run the commands from the repository root: the root holds no project file, so they name the solution and project
by path. Visual Studio users can open `InventoryManagement/InventoryManagement.sln`.

## Tech

C# 14, .NET 10 (`net10.0-windows`), Windows Forms. No NuGet packages.

## Known limitations

- Stock is held in memory only and is lost when the window closes.
- An item's quantity cannot be edited after it is added; to change it, remove the item and add it again.
- The restock threshold (10) is a constant in `Inventory.cs`.
- Item names are not required to be unique.
- Windows only, as Windows Forms is.
- No automated tests.

## Licence

MIT. See [LICENSE](LICENSE).
