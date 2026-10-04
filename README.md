# 🍕 Pizza Order Application (WinForms)

A Desktop Application built with C# and Windows Forms that allows users to customize a pizza order by selecting size, crust type, toppings, and dining option, automatically calculating the total cost in real-time.

---

## 🌟 Features

* **Interactive Pizza Customization**:
  * Select Pizza Size (*Small, Medium, Large*).
  * Choose Crust Type (*Thin Crust, Thick Crust*).
  * Add Extra Toppings (*Extra Cheese, Onion, Mushrooms, Olives, Tomatoes, Green Peppers*).
  * Choose Dining Location (*Eat In, Take Out*).
* **Real-Time Order Summary**: Live updates of selected items and instant price calculation.
* **Order Confirmation**: Displays a confirmation dialog before finalizing the order and disables input controls upon placement.
* **Reset Functionality**: Quick reset button to restore default selections and re-enable form controls.

---

## 📸 Screenshots

| Main Interface | Order Confirmation |
| :---: | :---: |
| ![Main UI](./images/main-ui.png) | ![Confirm Order](./images/confirm-order.png) |

---

## 🛠 Built With

* **Language**: C#
* **Framework**: .NET Framework / .NET Desktop SDK
* **UI Tooling**: Windows Forms (WinForms)
* **IDE**: Visual Studio

---

## 🚀 Getting Started

### Prerequisites

* Visual Studio 2019 / 2022 with the .NET desktop development workload installed.
* .NET Framework (version 4.7.2 or higher) or .NET 6.0+.

### Installation & Running

1. **Clone the repository:**

`git clone https://github.com/your-username/PizzaOrdersProject.git`

2. **Open the project:**

Double-click `PizzaOrdersProject.sln` to open it in Visual Studio.

3. **Build and Run:**

Press `F5` or click the green `Start` button in Visual Studio to compile and run the application.

---

## 📁 Project Structure

PizzaOrdersProject/
│
├── images/
│   ├── main-ui.png
│   └── confirm-order.png
├── Frm1.cs             # Main Form UI Logic & Event Handlers
├── Frm1.Designer.cs    # Windows Forms Generated UI Code
├── Program.cs          # Application Entry Point
└── PizzaOrdersProject.csproj

---

## 📝 Usage

* Select your desired pizza size, crust type, and dining preference using the radio buttons.
* Check or uncheck any additional toppings in the CheckBoxes list.
* Observe the Order Summary panel on the right side updating dynamically with the calculated total price.
* Click Order Pizza to confirm and complete your order.
* Click Reset Order to clear all selections and start over.

---

## 📄 License

This project is licensed under the MIT License - see the LICENSE file for details.
