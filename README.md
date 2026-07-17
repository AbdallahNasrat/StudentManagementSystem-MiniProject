# Student Management System (C# Fundamentals Mini-Project)

A Console-based Student Management System built using **C#** and **.NET Core**. This project was developed as a practical application to transition from theoretical programming fundamentals into structured, modular code design before diving deep into advanced Object-Oriented Programming (OOP).

## 🚀 Features

- **Add Student:** Securely insert new students with ID, Name, Age, and Grade.
- **View All Students:** Displays a formatted list of all enrolled students.
- **Update Student Info:** Modify an existing student's data using their unique ID.
- **Delete Student:** Safely remove a student record from the system.
- **Search:** Find and display a specific student's details by ID.
- **ID Availability Check:** Instantly verify if a student ID already exists.
- **Real-time Statistics:** Get the total count of students dynamically.

---

## 🛠️ Technical Concepts Applied

This project demonstrates a solid understanding of C# basics and architectural structure:

### 1. Control Flow & Data Structures
- **Collection Handling:** Utilized `List<T>` and advanced collection expressions (`return [];`) introduced in modern C# to manage data dynamically.
- **Conditional & Loops:** Structured the application runtime using `while` loops and clean `switch-case` blocks for menu navigation.

### 2. Separation of Concerns (SoC)
The project architecture cleanly isolates user interaction from business logic:
- `Program.cs`: Acts strictly as the User Interface (UI), managing `Console.ReadLine()` and `Console.WriteLine()`.
- `StudentManager.cs`: Handles the core business logic, validation, and data manipulation. It contains zero console dependencies, making it reusable.
- `School.cs` & `Student.cs`: Clean data models representing real-world entities.

### 3. Defensive Programming & Crash Prevention
- Replaced fragile `int.Parse()` with `int.TryParse()` combined with robust condition checks to handle invalid user inputs (e.g., text instead of numbers, negative values) without throwing unhandled exceptions.
- Implemented defensive code blocks like `if (school is null)` to prevent the notorious `NullReferenceException`.


## 💻 How to Run the Project

1. Clone the repository to your local machine:
   ```bash
   git clone [https://github.com/your-username/repository-name.git](https://github.com/your-username/repository-name.git)
