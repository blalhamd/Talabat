# Talabat Project
---------------------------------
## Database Design
![image](https://github.com/user-attachments/assets/8f24a2c3-1ae0-4008-8186-391b1fa17ba7)

## Overview
The Talabat Project is a comprehensive application designed to facilitate delivery services, connecting users with local restaurants. This project aims to provide a seamless experience for customers to browse menus, place orders, and track deliveries in real-time.

## Features 
- **Authentication:**
  - User login
  - User registration
  - Password recovery (forget password)
  - Change password
  - Get user information
  - Confirm email address
  - Send verification code

- **User Management:**
  - Complete CRUD operations for users

- **Role Management:**
  - Role management with complete CRUD operations
    
- **Brands:**
  - Get all brands
  - Get specific brand details

- **Products:**
  - Get all products
  - Get specific product details
  - Add a new product
  - Update existing product
  - Delete a product

- **Basket:**
  - Get all items in the basket
  - Get specific item details from the basket
  - Add an item to the basket
  - Update item quantity in the basket
  - Delete an item from the basket


- **Orders:**
  - Create an order
  - Get orders for a specific user
 
## Technologies Used
  - ASP.NET Core: The API is built using the ASP.NET Core framework, which provides a robust and scalable platform for web development.
  - Entity Framework Core: Used for data access and database management, Entity Framework Core simplifies interacting with the database.
  - SQL Server: The API utilizes SQL Server as the underlying database to store book and user information.
  - Authentication and Authorization: The API employs token-based authentication using JSON Web Tokens (JWT) for secure user authentication and permission-based authorization.
  - Payment Processing: Stripe API
  - Caching: Redis

## Getting Started
To set up the project locally, follow these steps:

1. Clone the repository:
   ```bash
   git clone https://github.com/blalhamd/Talabat.git

2. Set up the database:
  - Create a new SQL Server database.
  - Update the connection string in the appsettings.json file with your database credentials.

3- Build and run the API:
   - Open the solution in Visual Studio or your preferred development environment.
   - Build the solution to restore NuGet packages and compile the project.
   - Run the project, which will start the API server.
   - 
4- Explore the API:
   - Open a web browser or an API testing tool (e.g., Postman).
   - Access the API endpoints using the base URL (http://localhost:port/api/), where port is the port number configured in your development environment.
   - Refer to the API documentation or the source code for details on the available endpoints and their usage.

## API Documentation

