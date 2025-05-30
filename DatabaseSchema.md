# **Database Schema**

This document outlines the database schema for the Annual Maintenance Contract Management System. The system utilizes SQL Server to store and manage all relevant data.

## **Tables**

### **1\. Users Table**

Stores user authentication details and roles.

| Column Name | Data Type | Allow Nulls | Description |
| :---- | :---- | :---- | :---- |
| UserID | int | No | Primary Key, unique user identifier. |
| Username | nvarchar(50) | No | Unique username for login. |
| Role | nvarchar(20) | Yes | User role (e.g., 'Admin', 'Customer'). |
| PasswordHash | nvarchar(255) | No | Hashed password for security. |

### **2\. Assets Table**

Stores details about assets managed under contracts.

| Column Name | Data Type | Allow Nulls | Description |
| :---- | :---- | :---- | :---- |
| AssetID | int | No | Primary Key, unique asset identifier. |
| PurchaseDate | date | Yes | Date the asset was purchased. |
| SerialNumber | int | Yes | Unique serial number of the asset. |
| WarrantyEndDate | date | Yes | End date of the asset's warranty. |
| LinkedContractID | int | Yes | Foreign Key to Contracts table, linking the asset to a contract. |
| AssetType | nvarchar(30) | Yes | Type of the asset (e.g., 'Laptop', 'Machine'). |

### **3\. Clients Table**

Stores information about clients.

| Column Name | Data Type | Allow Nulls | Description |
| :---- | :---- | :---- | :---- |
| ClientID | varchar(10) | No | Primary Key, unique client identifier. |
| CompanyName | nvarchar(100) | No | Name of the client's company. |
| ContactPerson | nvarchar(100) | Yes | Main contact person at the company. |
| Email | nvarchar(100) | Yes | Contact email address. |
| Phone | nvarchar(20) | Yes | Contact phone number. |
| BillingInformation | nvarchar(MAX) | Yes | Details for billing purposes. |

### **4\. Contracts Table**

Stores details about maintenance contracts.

| Column Name | Data Type | Allow Nulls | Description |
| :---- | :---- | :---- | :---- |
| ContractID | varchar(20) | No | Primary Key, unique contract identifier. |
| ClientID | varchar(10) | No | Foreign Key to Clients table. |
| StartDate | date | No | Start date of the contract. |
| EndDate | date | No | End date of the contract. |
| Scope | nvarchar(MAX) | Yes | Description of the contract's scope. |
| Pricing | decimal(18, 2\) | Yes | Contract pricing. |
| DurationInMonths | int | Yes | Duration of the contract in months. |
| DocumentPath | nvarchar(255) | Yes | File path to the attached contract document. |

### **5\. Feedbacks Table**

Stores user feedback.

| Column Name | Data Type | Allow Nulls | Description |
| :---- | :---- | :---- | :---- |
| FeedbackID | int | No | Primary Key, unique feedback identifier. |
| Client | nvarchar(40) | Yes | Username or name of the client providing feedback. |
| FeedbackText | nvarchar(255) | Yes | The feedback message. |
| Rating | int | Yes | Rating provided by the user (e.g., 1-5). |

### **6\. Renewals Table**

Records contract renewal requests.

| Column Name | Data Type | Allow Nulls | Description |
| :---- | :---- | :---- | :---- |
| RenewalID | varchar(25) | No | Primary Key, unique renewal request identifier. |
| ClientID | varchar(10) | No | Foreign Key to Clients table. |
| ContractID | varchar(20) | No | Foreign Key to Contracts table. |
| RenewalDate | date | No | Date the renewal request was made. |

### **7\. Reports Table**

Logs generated reports (admin only).

| Column Name | Data Type | Allow Nulls | Description |
| :---- | :---- | :---- | :---- |
| ReportID | int | No | Primary Key, unique report identifier. |
| ReportType | nvarchar(100) | Yes | Type of report generated (e.g., 'Clients', 'Assets'). |
| GeneratedDate | date | No | Date the report was generated. |

### **8\. ServiceRequests Table**

Records service requests.

| Column Name | Data Type | Allow Nulls | Description |
| :---- | :---- | :---- | :---- |
| RequestID | varchar(25) | No | Primary Key, unique service request identifier. |
| ClientID | varchar(10) | No | Foreign Key to Clients table. |
| ContractID | varchar(20) | No | Foreign Key to Contracts table. |
| IssueDescription | nvarchar(MAX) | Yes | Description of the issue or request. |
| DateLogged | date | No | Date the service request was logged. |

