# Annual Maintenance Contract Management System

## Project Overview
The Annual Maintenance Contract (AMC) Management System is a user-friendly and automated desktop application designed to efficiently manage tasks, contracts, clients, assets, and feedback. Developed as a Bachelor of Computer Applications (BCA) project, this system aims to streamline AMC planning, execution, and monitoring, reducing manual effort, minimizing errors, and enhancing productivity for individuals or small teams.

---

## Features

- **User Authentication:** Secure login for existing users and registration for new users with role-based access (User and Admin).
- **Dashboard:** Centralized hub for quick navigation to all modules and a live overview of active clients, contracts, and assets.
- **Asset Management:** Add, view, update, and delete asset records (name, type, serial number, purchase/warranty dates, linked contracts).
- **Client Management:** Store and manage client information (company name, contact details, billing information).
- **Contract Management:** Create, update, view, and delete maintenance contracts, including scope, pricing, duration, and document attachment.
- **Renewal Requests:** Submit requests for contract renewals with optional remarks.
- **Service Requests:** File service requests related to contracts or assets, logged for support team review.
- **Reports (Admin Only):** Administrators can view and download comprehensive data reports for clients, assets, contracts, renewals, service requests, and feedback.
- **Feedback Module:** Users can submit comments, suggestions, or issues, which are stored for admin review.

---

## Technology Stack

- **Frontend:** VB.NET (Visual Studio)
- **Backend:** SQL Server (Azure SQL Database)
- **Development Environment:** Microsoft Visual Studio
- **Operating System:** Microsoft Windows 8 or later

---

## System Requirements

### Hardware
- **RAM:** Minimum 4 GB (Recommended: 8 GB or higher)
- **Hard Disk:** 8 GB or more
- **Processor:** Intel(R) Core (TM) i3-1005G1 or higher
- **Processing Speed:** 1.20 GHz or above
- **Operating System:** Windows 10 or later (64-bit recommended)

### Software
- **Visual Studio** (for development and running the VB.NET application)
- **SQL Server 2022** (for the database backend)

---

## Installation and Setup

### 1. Clone the Repository

```sh
git clone https://github.com/your-username/AMC-Management-System.git
cd AMC-Management-System
```

### 2. Database Setup

- Install SQL Server 2022.
- Create a new database (e.g., AMC_DB).
- Refer to docs/database_schema.md to create the necessary tables.
- Update the connection string in the VB.NET project's App.config file to point to your SQL Server instance. The current connection string in the provided code snippets is Data Source=.\SQLEXPRESS;Initial Catalog=AMC_DB;Integrated Security=True;TrustServerCertificate=True;. Adjust this as per your SQL Server setup.

### 3. Application Setup

- Open the project in Visual Studio.
- Build the solution to restore any necessary dependencies.
- Run the application.

---

## Usage
Upon launching the application, you will be presented with a login screen.

- **New Users:** Click "Register now!" to create an account.
- **Existing Users:** Enter your username and password to log in.

Users will be directed to the Dashboard.

Admins will have access to the Reports section in addition to other functionalities.

Navigate through the various modules using the dashboard or the navigation panel to manage clients, assets, contracts, service requests, renewals, and feedback.

---

## Contributing
We welcome contributions to enhance the Annual Maintenance Contract Management System! If you have suggestions for improvements, bug fixes, or new features, please feel free to:

- Fork the repository.
- Create a new branch (git checkout -b feature/your-feature-name).
- Make your changes.
- Commit your changes (git commit -m 'Add new feature').
- Push to the branch (git push origin feature/your-feature-name).
- Open a Pull Request.

---

## License
This project is open-source and licensed under the MIT License. While the license grants broad permissions, we kindly request that you reach out to the original author, Chris Mathew Aje, for significant commercial use or major modifications. This helps the author track the impact and evolution of their academic work.

See the LICENSE file for more details.

---

## Acknowledgements
This project was developed by:

**Chris Mathew Aje** (23BCAB17)

Under the guidance of:

**Dr. V. S. Prakash**
Department of Computer Science (UG), BCA Programme
Kristu Jayanti College (Autonomous), Bengaluru
Academic Year: 2024-2025

---

## Contact
For any inquiries or to discuss the project, please reach out to Chris Mathew Aje via [chrismaje63@gmail.com](mailto:chrismaje63@gmail.com) or [contact.thecma.xyz](http://contact.thecma.xyz)