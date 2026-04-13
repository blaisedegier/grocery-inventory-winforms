# Inventory Management 📦

A Windows Forms desktop application for managing grocery store inventory, built with C# and .NET 8. Users can add and remove inventory items across multiple product categories, with all data displayed in a clean, categorized view.

## Table of Contents

- [Features](#features)
- [Tech Stack](#tech-stack)
- [Prerequisites](#prerequisites)
- [Getting Started](#getting-started)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [Architecture](#architecture)
- [Categories](#categories)
- [Input Validation](#input-validation)

## Features

- **Add items** to inventory with a name, price, quantity, and category
- **Remove items** by selecting a category and then choosing from the items within it
- **View inventory** in a formatted, categorized display with prices shown in South African Rand (R)
- **Input validation** ensures item names are non-empty and prices/quantities are non-negative
- **Error handling** with user-friendly message box alerts for invalid input
- **History tracking** via an internal stack that records the order of items added

## Tech Stack

| Component    | Technology               |
| ------------ | ------------------------ |
| Language     | C# 12                    |
| Framework    | .NET 8 (Windows)         |
| UI Framework | Windows Forms (WinForms) |
| IDE          | Visual Studio 2022       |
| Build System | MSBuild / dotnet CLI     |

## Prerequisites

- **Windows 10** or later
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) (or later)
- (Optional) [Visual Studio 2022](https://visualstudio.microsoft.com/) with the **.NET desktop development** workload

## Getting Started

### Clone the repository

```bash
git clone https://github.com/<your-username>/BasicInventoryManagement.git
cd BasicInventoryManagement/InventoryManagement
```

### Build and run with the .NET CLI

```bash
dotnet build
dotnet run
```

### Build and run with Visual Studio

1. Open `InventoryManagement.sln` in Visual Studio 2022.
2. Press **F5** (or click **Start**) to build and launch the application.

## Usage

### Home Screen

The main window displays the current inventory grouped by category. Two buttons provide access to the core functionality:

- **Add Item** opens a dialog to enter a new inventory item.
- **Remove Item** opens a dialog to select and delete an existing item.

### Adding an Item

1. Click **Add Item** on the home screen.
2. Enter the item **Name**, **Price**, and **Quantity**.
3. Select a **Category** from the dropdown.
4. Click **Add** to save the item and return to the home screen.

### Removing an Item

1. Click **Remove Item** on the home screen.
2. Select a **Category** from the first dropdown.
3. The second dropdown populates with items in that category. Select the item to remove.
4. Click **Remove** to delete it and return to the home screen.

## Project Structure

```text
BasicInventoryManagement/
└── InventoryManagement/
    ├── InventoryManagement.sln        # Visual Studio solution file
    ├── InventoryManagement.csproj     # .NET project file (net8.0-windows, WinForms)
    ├── Program.cs                     # Application entry point
    │
    ├── Home.cs / .Designer.cs         # Main form: inventory display, navigation
    ├── AddItem.cs / .Designer.cs      # Add item dialog form
    ├── RemoveItem.cs / .Designer.cs   # Remove item dialog form
    │
    ├── GroceryStore.cs                # Grocery store wrapper holding an Inventory instance
    ├── Inventory.cs                   # Core inventory logic (Dictionary, Stack, Queue)
    ├── InventoryItem.cs               # Item model: Name, Price, Quantity, Category
    ├── Category.cs                    # Enum of product categories
    │
    ├── InputValidator.cs              # Static validation methods for user input
    └── ErrorHandler.cs                # Throws exceptions on invalid add-item input
```

## Architecture

The application follows a simple layered structure:

```text
┌────────────────────────────────────────────┐
│              UI Layer (WinForms)           │
│   Home  ·  AddItem  ·  RemoveItem          │
└──────────────────┬─────────────────────────┘
                   │
┌──────────────────▼─────────────────────────┐
│            Business Logic Layer            │
│   GroceryStore  ·  Inventory               │
│   InputValidator  ·  ErrorHandler          │
└──────────────────┬─────────────────────────┘
                   │
┌──────────────────▼─────────────────────────┐
│              Data / Model Layer            │
│   InventoryItem  ·  Category (enum)        │
└────────────────────────────────────────────┘
```

### Data Structures Used

| Structure                                   | Purpose                                                     |
| ------------------------------------------- | ----------------------------------------------------------- |
| `Dictionary<Category, List<InventoryItem>>` | Primary storage, mapping each category to its list of items |
| `Stack<InventoryItem>`                      | Tracks the history of items as they are added               |
| `Queue<InventoryItem>`                      | Designed for restock tracking when quantity drops below 10  |

> **Note:** All data is stored in memory for the lifetime of the application. Closing the app will reset the inventory.

## Categories

The following product categories are available:

| Category   | Description              |
| ---------- | ------------------------ |
| Fruits     | Fresh fruit products     |
| Vegetables | Fresh vegetable products |
| Dairy      | Milk, cheese, yogurt     |
| Meat       | Beef, chicken, pork      |
| Bakery     | Bread, pastries, cakes   |
| Beverages  | Drinks and juices        |
| Snacks     | Chips, candy, nuts       |
| Household  | Cleaning and home items  |

## Input Validation

When adding an item, the following rules are enforced:

| Field    | Rule                                   |
| -------- | -------------------------------------- |
| Name     | Must not be empty or null              |
| Price    | Must be a valid number, zero or above  |
| Quantity | Must be a valid integer, zero or above |

If validation fails, an error message is shown in a dialog box describing the issue.
