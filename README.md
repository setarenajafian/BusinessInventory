<div align="center">

# 📦 BusinessInventory

[![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet)](https://dotnet.microsoft.com/)
[![MAUI](https://img.shields.io/badge/.NET%20MAUI-Cross--Platform-blueviolet)](https://learn.microsoft.com/dotnet/maui/)
[![License](https://img.shields.io/badge/License-Educational-green.svg)](#-license)
[![Platform](https://img.shields.io/badge/Platform-Android%20%7C%20Windows%20%7C%20iOS-lightgrey)](#-supported-platforms)

</div>

---

## 🧾 Overview

**BusinessInventory** is a cross-platform mobile application built with **.NET MAUI**. It provides a simple business inventory system for managing products, tracking stock, and performing basic CRUD operations.

This project serves as an **educational and extensible base** for future improvements such as cloud integration, authentication, reporting, and real-time synchronization.

---

## 🎯 Features

- ➕ Add new products
- ✏️ Edit existing products
- 🗑️ Delete products
- 📋 View product list
- 💾 Simple local data management
- 🧱 Clean MVVM-based architecture
- 🌍 Cross-platform support (Android / Windows / iOS-ready)

---

## 🏗️ Architecture

The project follows a **layered architecture** for maintainability and scalability:

```
┌─────────────────────────────┐
│      Presentation Layer      │
│  MAUI Pages (UI) + ViewModels│
├─────────────────────────────┤
│     Business Logic Layer     │
│   Services for product mgmt  │
├─────────────────────────────┤
│         Data Layer           │
│  Local in-memory / file-based│
│         storage              │
└─────────────────────────────┘
```

This structure allows easy migration to:

- SQLite
- REST API backend
- Cloud database (Azure / Firebase)

---

## 🛠️ Technologies Used

| Technology | Purpose |
|---|---|
| .NET 8 / .NET MAUI | Cross-platform app framework |
| C# | Application logic |
| XAML | UI markup |
| MVVM | Architectural pattern |

---

## 📱 Supported Platforms

| Platform | Status |
|---|---|
| Android | ✅ Primary target |
| Windows | ⚙️ Optional |
| iOS | 🧩 Build-ready (untested without macOS) |

---

## 🚀 Getting Started

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- Visual Studio 2022 (with **.NET MAUI workload** installed)
- Android Emulator or physical device (for Android builds)

### Installation

**1. Clone the repository**
```bash
git clone <repository-url>
cd BusinessInventory
```

**2. Open in Visual Studio**

Open `BusinessInventory.sln`

**3. Restore dependencies**
```bash
dotnet restore
```

**4. Run the project**

Select your target device (Android Emulator / Windows) and press **F5** or click **Run**.

---

## 🔮 Future Improvements

- [ ] SQLite database integration
- [ ] REST API backend (ASP.NET Core)
- [ ] User authentication (JWT)
- [ ] Cloud sync (Azure / Firebase)
- [ ] Barcode scanner integration
- [ ] Reporting & analytics dashboard
- [ ] Multi-user support

---

## ⚠️ Notes

> This project is currently intended for **educational purposes**.
> Data persistence is minimal or local-only depending on implementation.
> For production use, a proper database and authentication layer should be added.

---

## 👨‍💻 Author

Developed as a **student project** using .NET MAUI for learning and demonstration purposes.

---

## 📄 License

This project is free to use for **educational purposes**.
