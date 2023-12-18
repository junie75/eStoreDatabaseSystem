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
  - [Overview](#overview)
  - [Table of Contents](#table-of-contents)
  - [Features](#features)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
  - [Usage](#usage)
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

## Installation

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/junie75/eStoreDatabaseSystem.git
   cd eStoreDatabaseSystem

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
   - Click "New Connection" and add your SQL Server instance.
   
6. **Build and Run:**
   Build and run the application using Visual Studio.


## Usage

1. **Login:** <br> Use your credentials to log in to the application. <br><br> ![image](https://github.com/junie75/eStoreDatabaseSystem/blob/master/Images/login.png)
2. **Explore System:** <br> Navigate from the home screen to the next form of your choice. <br><br> ![image](https://github.com/junie75/eStoreDatabaseSystem/blob/master/Images/homeScreen.png)
3. **Manipulate DB:** <br> From the orders screen, we are able to see all of the orders placed by customers, add a new order, edit an existing order, or delete an order. <br> ![image](https://github.com/junie75/eStoreDatabaseSystem/blob/master/Images/ordersScreen.png) <br><br> **When a query has been completed, a pop-up will display a confirmation message to the user.** <br><br>
 Adding an order <br><br> ![image](https://github.com/junie75/eStoreDatabaseSystem/blob/master/Images/orderAdded.png) <br> Deleting an order <br><br> ![image](https://github.com/junie75/eStoreDatabaseSystem/blob/master/Images/orderDeleted.png) <br><br> ***Note: For a full tutorial of the system, please visit the user manual section in the [project
documentation](https://github.com/junie75/eStoreDatabaseSystem/blob/master/Documentation/eStoreProjectDocumentation.pdf).***
5. **Change Password:** <br> The admin can also choose to change their password by clicking the change password button on the homescreen. <br> ![image](https://github.com/junie75/eStoreDatabaseSystem/blob/master/Images/changePW.png)

## Acknowledgements

The eStore database project builds upon concepts learned from the "Files and Databases" CS6320 course at St. Mary's University, San Antonio, Texas.
This project was created throughout the Fall 2023 semester with group partners Emily Medlin and Faith Chapman.





