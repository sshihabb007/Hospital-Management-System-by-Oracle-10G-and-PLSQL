# 🏥 Hospital Management System

An advanced database management project built to handle the complex operations of a hospital environment. This system is developed using **C#** for the frontend/application layer and relies heavily on **Oracle 10G and PL/SQL** for robust backend database operations. 

## 🚀 Overview
The project is designed with a multi-layered architecture (Business Layer, Database Access Layer) to maintain clean code and ensure efficient data management. It serves as a comprehensive solution for managing patient records, staff administration, and overall hospital workflows through an intuitive Windows Form-based GUI.

---

## 🛠️ Technology Stack

This application emphasizes strong database management and utilizes a classic enterprise tech stack:

* **Frontend / Application Logic:** C# (.NET Framework / Windows Forms)
* **Database Management System:** Oracle 10G
* **Database Scripting:** PL/SQL (Procedures, Triggers, Functions)
* **Architecture:** N-Tier Architecture (UI, Business Layer, Data Access Layer)

---

## ✨ Key Features

Based on the project structure, the system incorporates the following core functionalities:

* **Admin Controls (`AdminForm`):** A dedicated interface for hospital administrators to manage system configurations, staff accounts, and operational oversight.
* **Database Integration (`DBAccess` & `Database`):** Complex query handling, data retrieval, and secure storage utilizing Oracle 10G and customized PL/SQL scripts.
* **Business Logic Separation (`BusinessLayer`):** Structured business rules separated from the UI and Data access layers for better maintainability and scalability.
* **Media Handling (`Pictures`):** Integration of visual assets, potentially for patient profiles, staff IDs, or UI enhancement.

---

## 📁 Repository Structure

The codebase is organized into distinct modules to separate user interfaces, database connections, and core logic:

```text
📦 Hospital-Management-System-by-Oracle-10G-and-PLSQL
 ┣ 📂 AdminForm/                 # UI components and logic for the Administrator panel
 ┣ 📂 BusinessLayer/             # Core business logic and rules processing
 ┣ 📂 DBAccess/                  # Database connectivity and query execution components
 ┣ 📂 Database/                  # Oracle PL/SQL scripts, schemas, and database configurations
 ┣ 📂 HospitalManagementSystem/  # Main application UI and entry point
 ┣ 📂 Pictures/                  # Image assets used within the application
 ┣ 📜 Hospital Management System.docx # Detailed project documentation/report
 ┗ 📜 LICENSE                    # Apache 2.0 License file
