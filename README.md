# eStore Database System

## Overview
This project is a Database Management GUI platform built using Visual Studio as a .NET Framework console application. 
The database was created and managed using Microsoft SQL Server Management Studio (SSMS). 
eStore provides a user-friendly interface for managing databases, executing SQL queries, and performing various database-related tasks.
This E-Store Database System project is meant to replicate the core functionalities of what an owner of a small online shop would need. 
Functionalities boil down to storing, retrieving, and updating information in a database. 
As the database is intended to be managed by the owner, the owner will have admin privileges (making the database operations) that will need to be verified by the GUI as well.

 ## Table of Contents

- [Project Title](#eStore-Database-System)
  - [Table of Contents](#table-of-contents)
  - [Features](#features)
    - [Requirements](#database=requirements)
    - [Tasks](#database-tasks)
    - [GUI](#graphical-user-interface)
  - [Getting Started](#getting-started)
    - [Prerequisites](#prerequisites)
    - [Installation](#installation)
  - [Language Syntax](#language-syntax)
  - [Usage](#usage)
  - [Example Code](#example-code)
  - [License](#license)
  - [Acknowledgments](#acknowledgments)

## Features

- **User-Friendly Interface:** Intuitive and easy-to-use graphical user interface for efficient database management.
- **SQL Query Execution:** Execute SQL queries directly within the application for data retrieval and manipulation.
- **Project Management:** Track customer information, product information, transaction/shipment history along with search operations.

## Prerequisites

Before getting started, ensure the following tools are installed on your machine:

- [Visual Studio](https://visualstudio.microsoft.com/downloads/) <br> Version 17.3 was used in the development of this project.
- [Microsoft SQL Server Management Studio (SSMS)](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms) <br> Version 19.1. was used in the development of this project.
- You must also insure that the Microsoft .NET Framework is installed within Visual Studio. Version 4.8 was used in the development of this project. 

## Getting Started

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/your-username/your-repository.git
   cd your-repository

2. **Open in Visual Studio:**
   Open the project solution in Visual Studio: eStore.sln.

3. **Create your Database:**
   Create in SQL Server Management Studio the database for the eStore Platform to manipulate. <br> This is the schema used with datatypes for each of the attributes. <br>
   ![image](https://github.com/junie75/eStoreDatabaseSystem/blob/master/Images/dbSchema.png) <br> This is the schema specified with relationships. <br>
   ![image](https://github.com/junie75/eStoreDatabaseSystem/blob/master/Images/dbSchemaRelationships.png)

4. **Configure Database Connection:**
   Update the connection strings named dbConnection on every form to point to your SQL Server instance.
   - Click the dbConnection object
   - In the properties section, scroll up to the "Data" subsection find the field labeled "Connection String".
   - Click "New Connection" and add your SQL Server instance
   
6. **Build and Run:**
   Build and run the application using Visual Studio.


## Usage

1. **Login:**
2. **Explore System:**
3. **Manipulate DB:**
4. **Change Password:**





