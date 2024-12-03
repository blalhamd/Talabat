# Talabat Project

---

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
- Front-End: Angular https://github.com/blalhamd/Talabat-E-commerce-Angular.git

## Getting Started

To set up the project locally, follow these steps:

1. Clone the repository:

   ```bash
   git clone https://github.com/blalhamd/Talabat.git

   ```

2. Set up the database:

- Create a new SQL Server database.
- Update the connection string in the appsettings.json file with your database credentials.

3- Build and run the API:

- Open the solution in Visual Studio or your preferred development environment.
- Build the solution to restore NuGet packages and compile the project.
- Run the project, which will start the API server.
- 4- Explore the API:
- Open a web browser or an API testing tool (e.g., Postman).
- Access the API endpoints using the base URL (http://localhost:port/api/), where port is the port number configured in your development environment.
- Refer to the API documentation or the source code for details on the available endpoints and their usage.

## API Documentation

# Project: Talabat

StartFragmentThe Talabat Project is a comprehensive application designed to facilitate delivery services, connecting users with local restaurants. This project aims to provide a seamless experience for customers to browse menus, place orders, and track deliveries in real-time.EndFragment

# 📁 Collection: Auth

## End-point: Login

##### Description

Login action to enable you to be authenticated and access the resourse

### Method: POST

> ```
> {{BaseUrl}}/api/Authentication/Login
> ```

### Response: 200

```json
{
  "firstName": "Bilal",
  "lastName": "Sayed",
  "email": "blalhamd48@gmail.com",
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwiZ2l2ZW5fbmFtZSI6IkJpbGFsIiwidW5pcXVlX25hbWUiOiJCaWxhbDEyMyIsImVtYWlsIjoiYmxhbGhhbWQ0OEBnbWFpbC5jb20iLCJyb2xlcyI6WyJBZG1pbiIsIlNlbmlvciIsIlRlYW1MZWFkIl0sInBlcm1pc3Npb25zIjpbIlVzZXJzOkdldEFsbCIsIlVzZXJzOkdldEJ5SWQiLCJVc2VyczpBZGQiLCJVc2VyczpFZGl0IiwiVXNlcnM6RGVsZXRlIiwiVXNlcnM6VW5Mb2NrIiwiUm9sZXM6R2V0QWxsIiwiUm9sZXM6R2V0QnlJZCIsIlJvbGVzOkFkZCIsIlJvbGVzOkVkaXQiLCJSb2xlczpEZWxldGUiLCJCYXNrZXRzOkdldEFsbCIsIkJhc2tldHM6R2V0QnlJZCIsIkJhc2tldHM6QWRkIiwiQmFza2V0czpFZGl0IiwiQmFza2V0czpEZWxldGUiLCJCcmFuZHM6R2V0QWxsIiwiQnJhbmRzOkdldEJ5SWQiLCJQcm9kdWN0czpHZXRBbGwiLCJQcm9kdWN0czpHZXRCeUlkIiwiUHJvZHVjdHM6QWRkIiwiUHJvZHVjdHM6RWRpdCIsIlByb2R1Y3RzOkRlbGV0ZSIsIlByb2R1Y3RUeXBlczpHZXRBbGwiLCJQcm9kdWN0VHlwZXM6R2V0QnlJZCJdLCJuYmYiOjE3MzMwMTEzMzUsImV4cCI6MTczMzAxMzEzNSwiaWF0IjoxNzMzMDExMzM1LCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDUxIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMCJ9.nXWrBI1ZVdwHjAhCPVbOHiQC4I417pPeKs13aIrLbVU",
  "expireIn": 1800,
  "refreshToken": "TpY1HMb1ArjYNt5Gex06PNtVeh1UTWCEAEBGkZP04Cm38q2N9EuYY6Jv1B2WPUU2hrloieiFi5jw/RNf9ZT6Fg==",
  "refreshTokenExpiration": "2024-12-15T00:02:15.6801164Z"
}
```

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

## End-point: Register

##### Description

To Register and join us

### Method: POST

> ```
> {{BaseUrl}}/api/Authentication/Register
> ```

### Body (**raw**)

```json
{
  "firstName": "Ahmed",
  "lastName": "Abdo",
  "email": "Ahmed34@gmail.com",
  "phoneNumber": "01007656454",
  "password": "89223116Mo3er$"
}
```

### Response: 200

```json
null
```

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

## End-point: Forget-Password

##### Description

in case you forgot your password, you can redeclare it by enter your email

---

### Method: POST

> ```
> {{BaseUrl}}/api/Authentication/forgot-password
> ```

### Body (**raw**)

```json
{
  "email": "Ahmed48@gmail.com"
}
```

### Response: 200

```json
null
```

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

## End-point: Reset-Password

##### Description

you can reset your password by providing some of information.

---

##### Response

<img src="https://content.pstmn.io/113cca55-baa3-430f-883c-0a95511eda91/U2NyZWVuc2hvdCAyMDI0LTEyLTAxIDAyMjYwMC5wbmc=" alt="">
### Method: POST
>```
>{{BaseUrl}}/api/Authentication/reset-password
>```
### Body (**raw**)

```json
{
  "email": "Ahmed48@gmail.com",
  "newPassword": "89223116Mo3ez%",
  "confirmPassword": "89223116Mo3ez%",
  "code": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwiZ2l2ZW5fbmFtZSI6IkJpbGFsIiwidW5pcXVlX25hbWUiOiJCaWxhbDEyMyIsImVtYWlsIjoiYmxhbGhhbWQ0OEBnbWFpbC5jb20iLCJyb2xlcyI6WyJBZG1pbiIsIlNlbmlvciIsIlRlYW1MZWFkIl0sInBlcm1pc3Npb25zIjpbIlVzZXJzOkdldEFsbCIsIlVzZXJzOkdldEJ5SWQiLCJVc2VyczpBZGQiLCJVc2VyczpFZGl0IiwiVXNlcnM6RGVsZXRlIiwiVXNlcnM6VW5Mb2NrIiwiUm9sZXM6R2V0QWxsIiwiUm9sZXM6R2V0QnlJZCIsIlJvbGVzOkFkZCIsIlJvbGVzOkVkaXQiLCJSb2xlczpEZWxldGUiLCJCYXNrZXRzOkdldEFsbCIsIkJhc2tldHM6R2V0QnlJZCIsIkJhc2tldHM6QWRkIiwiQmFza2V0czpFZGl0IiwiQmFza2V0czpEZWxldGUiLCJCcmFuZHM6R2V0QWxsIiwiQnJhbmRzOkdldEJ5SWQiLCJQcm9kdWN0czpHZXRBbGwiLCJQcm9kdWN0czpHZXRCeUlkIiwiUHJvZHVjdHM6QWRkIiwiUHJvZHVjdHM6RWRpdCIsIlByb2R1Y3RzOkRlbGV0ZSIsIlByb2R1Y3RUeXBlczpHZXRBbGwiLCJQcm9kdWN0VHlwZXM6R2V0QnlJZCJdLCJuYmYiOjE3MzMwMTExMDksImV4cCI6MTczMzAxMjkwOSwiaWF0IjoxNzMzMDExMTA5LCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDUxIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMCJ9"
}
```

### Response: 500

```json
{
  "StatusCode": 400,
  "Message": "Invalid Code",
  "Details": null
}
```

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

## End-point: Confirm-Email

### Method: POST

> ```
> {{BaseUrl}}/api/Authentication/confirm-email?userId=11&Code=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwiZ2l2ZW5fbmFtZSI6IkJpbGFsIiwidW5pcXVlX25hbWUiOiJCaWxhbDEyMyIsImVtYWlsIjoiYmxhbGhhbWQ0OEBnbWFpbC5jb20iLCJyb2xlcyI6WyJBZG1pbiIsIlNlbmlvciIsIlRlYW1MZWFkIl0sInBlcm1pc3Npb25zIjpbIlVzZXJzOkdldEFsbCIsIlVzZXJzOkdldEJ5SWQiLCJVc2VyczpBZGQiLCJVc2VyczpFZGl0IiwiVXNlcnM6RGVsZXRlIiwiVXNlcnM6VW5Mb2NrIiwiUm9sZXM6R2V0QWxsIiwiUm9sZXM6R2V0QnlJZCIsIlJvbGVzOkFkZCIsIlJvbGVzOkVkaXQiLCJSb2xlczpEZWxldGUiLCJCYXNrZXRzOkdldEFsbCIsIkJhc2tldHM6R2V0QnlJZCIsIkJhc2tldHM6QWRkIiwiQmFza2V0czpFZGl0IiwiQmFza2V0czpEZWxldGUiLCJCcmFuZHM6R2V0QWxsIiwiQnJhbmRzOkdldEJ5SWQiLCJQcm9kdWN0czpHZXRBbGwiLCJQcm9kdWN0czpHZXRCeUlkIiwiUHJvZHVjdHM6QWRkIiwiUHJvZHVjdHM6RWRpdCIsIlByb2R1Y3RzOkRlbGV0ZSIsIlByb2R1Y3RUeXBlczpHZXRBbGwiLCJQcm9kdWN0VHlwZXM6R2V0QnlJZCJdLCJuYmYiOjE3MzMwMTExMDksImV4cCI6MTczMzAxMjkwOSwiaWF0IjoxNzMzMDExMTA5LCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDUxIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMCJ9.GcgsdpG8qfY7Xfbntq4yWr3XMfMxG_uSdHntHp1dpFk
> ```

### Query Params

| Param  | value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| ------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| userId | 11                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| Code   | eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwiZ2l2ZW5fbmFtZSI6IkJpbGFsIiwidW5pcXVlX25hbWUiOiJCaWxhbDEyMyIsImVtYWlsIjoiYmxhbGhhbWQ0OEBnbWFpbC5jb20iLCJyb2xlcyI6WyJBZG1pbiIsIlNlbmlvciIsIlRlYW1MZWFkIl0sInBlcm1pc3Npb25zIjpbIlVzZXJzOkdldEFsbCIsIlVzZXJzOkdldEJ5SWQiLCJVc2VyczpBZGQiLCJVc2VyczpFZGl0IiwiVXNlcnM6RGVsZXRlIiwiVXNlcnM6VW5Mb2NrIiwiUm9sZXM6R2V0QWxsIiwiUm9sZXM6R2V0QnlJZCIsIlJvbGVzOkFkZCIsIlJvbGVzOkVkaXQiLCJSb2xlczpEZWxldGUiLCJCYXNrZXRzOkdldEFsbCIsIkJhc2tldHM6R2V0QnlJZCIsIkJhc2tldHM6QWRkIiwiQmFza2V0czpFZGl0IiwiQmFza2V0czpEZWxldGUiLCJCcmFuZHM6R2V0QWxsIiwiQnJhbmRzOkdldEJ5SWQiLCJQcm9kdWN0czpHZXRBbGwiLCJQcm9kdWN0czpHZXRCeUlkIiwiUHJvZHVjdHM6QWRkIiwiUHJvZHVjdHM6RWRpdCIsIlByb2R1Y3RzOkRlbGV0ZSIsIlByb2R1Y3RUeXBlczpHZXRBbGwiLCJQcm9kdWN0VHlwZXM6R2V0QnlJZCJdLCJuYmYiOjE3MzMwMTExMDksImV4cCI6MTczMzAxMjkwOSwiaWF0IjoxNzMzMDExMTA5LCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDUxIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMCJ9.GcgsdpG8qfY7Xfbntq4yWr3XMfMxG_uSdHntHp1dpFk |

### Response: 500

```json
{
  "StatusCode": 400,
  "Message": "Email is already confirmed",
  "Details": null
}
```

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

## End-point: resend-confirmation-email

##### Description

in case you missed email or expired the oldest, can resend it

---

### Method: POST

> ```
> {{BaseUrl}}/api/Authentication/resend-confirmation-email
> ```

### Body (**raw**)

```json
{
  "email": "Ahmed48@gmail.com"
}
```

### Response: 200

```json
null
```

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

## End-point: Refresh-Token

##### Description

To increase the time of authenicated

### Method: POST

> ```
> {{BaseUrl}}/api/Authentication/refresh-token
> ```

### Body (**raw**)

```json
{
  "accessToken": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwiZ2l2ZW5fbmFtZSI6IkJpbGFsIiwidW5pcXVlX25hbWUiOiJCaWxhbDEyMyIsImVtYWlsIjoiYmxhbGhhbWQ0OEBnbWFpbC5jb20iLCJyb2xlcyI6WyJBZG1pbiIsIlNlbmlvciIsIlRlYW1MZWFkIl0sInBlcm1pc3Npb25zIjpbIlVzZXJzOkdldEFsbCIsIlVzZXJzOkdldEJ5SWQiLCJVc2VyczpBZGQiLCJVc2VyczpFZGl0IiwiVXNlcnM6RGVsZXRlIiwiVXNlcnM6VW5Mb2NrIiwiUm9sZXM6R2V0QWxsIiwiUm9sZXM6R2V0QnlJZCIsIlJvbGVzOkFkZCIsIlJvbGVzOkVkaXQiLCJSb2xlczpEZWxldGUiLCJCYXNrZXRzOkdldEFsbCIsIkJhc2tldHM6R2V0QnlJZCIsIkJhc2tldHM6QWRkIiwiQmFza2V0czpFZGl0IiwiQmFza2V0czpEZWxldGUiLCJCcmFuZHM6R2V0QWxsIiwiQnJhbmRzOkdldEJ5SWQiLCJQcm9kdWN0czpHZXRBbGwiLCJQcm9kdWN0czpHZXRCeUlkIiwiUHJvZHVjdHM6QWRkIiwiUHJvZHVjdHM6RWRpdCIsIlByb2R1Y3RzOkRlbGV0ZSIsIlByb2R1Y3RUeXBlczpHZXRBbGwiLCJQcm9kdWN0VHlwZXM6R2V0QnlJZCJdLCJuYmYiOjE3MzMwMTQwMzksImV4cCI6MTczMzAxNTgzOSwiaWF0IjoxNzMzMDE0MDM5LCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDUxIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMCJ9.2KoUUt2BG-LjZ69G9TyHosTC10c-vepAi7cMMjQQvw4",
  "refreshToken": "vNWaZA4LISwKkJqF8q0bV2yq+SfVYnnObXoKqJIbnpes0M2/tZs3bshA++xXNDKt5jieAZ0Cs407AXxrFHf5tg=="
}
```

### Response: 200

```json
{
  "firstName": "Bilal",
  "lastName": "Sayed",
  "email": "blalhamd48@gmail.com",
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwiZ2l2ZW5fbmFtZSI6IkJpbGFsIiwidW5pcXVlX25hbWUiOiJCaWxhbDEyMyIsImVtYWlsIjoiYmxhbGhhbWQ0OEBnbWFpbC5jb20iLCJyb2xlcyI6WyJBZG1pbiIsIlNlbmlvciIsIlRlYW1MZWFkIl0sInBlcm1pc3Npb25zIjpbIlVzZXJzOkdldEFsbCIsIlVzZXJzOkdldEJ5SWQiLCJVc2VyczpBZGQiLCJVc2VyczpFZGl0IiwiVXNlcnM6RGVsZXRlIiwiVXNlcnM6VW5Mb2NrIiwiUm9sZXM6R2V0QWxsIiwiUm9sZXM6R2V0QnlJZCIsIlJvbGVzOkFkZCIsIlJvbGVzOkVkaXQiLCJSb2xlczpEZWxldGUiLCJCYXNrZXRzOkdldEFsbCIsIkJhc2tldHM6R2V0QnlJZCIsIkJhc2tldHM6QWRkIiwiQmFza2V0czpFZGl0IiwiQmFza2V0czpEZWxldGUiLCJCcmFuZHM6R2V0QWxsIiwiQnJhbmRzOkdldEJ5SWQiLCJQcm9kdWN0czpHZXRBbGwiLCJQcm9kdWN0czpHZXRCeUlkIiwiUHJvZHVjdHM6QWRkIiwiUHJvZHVjdHM6RWRpdCIsIlByb2R1Y3RzOkRlbGV0ZSIsIlByb2R1Y3RUeXBlczpHZXRBbGwiLCJQcm9kdWN0VHlwZXM6R2V0QnlJZCJdLCJuYmYiOjE3MzMwMTQxMDksImV4cCI6MTczMzAxNTkwOSwiaWF0IjoxNzMzMDE0MTA5LCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDUxIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMCJ9.lwjaGKGZmFOMewAmUxO4ayYCyvoqyoG8Xmz2axThYsA",
  "expireIn": 1800,
  "refreshToken": "f9+mK+xNKhVjjydOnMCtXyT0QTTV8UMy/Cim48lzKVwMJfhFpMaNzoWLCgvz29B0FqjRSDQQ/MOIn5qtzo2pGg==",
  "refreshTokenExpiration": "2024-12-15T00:48:29.7242444Z"
}
```

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

# 📁 Collection: Brand

## End-point: Get All Brands

##### Description

Fetching all available Brands

### Method: GET

> ```
> {{BaseUrl}}/api/Brands
> ```

### 🔑 Authentication bearer

| Param | value                          | Type   |
| ----- | ------------------------------ | ------ |
| token | {{vault:authorization-secret}} | string |

### Response: 200

```json
[
  {
    "id": 1,
    "name": "Starbucks"
  },
  {
    "id": 2,
    "name": "Costa"
  },
  {
    "id": 3,
    "name": "Cilantro"
  },
  {
    "id": 4,
    "name": "TBS"
  },
  {
    "id": 5,
    "name": "On The Run"
  },
  {
    "id": 6,
    "name": "Caribou"
  },
  {
    "id": 7,
    "name": "Krispy Kreme"
  }
]
```

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

## End-point: Get Brand By Id

##### Description

Get specific Brand by Id

---

## Example

---

##### Request

```curl
curl --location 'https://localhost:44315/api/Brands/2'

```

---

##### Response

```json
{
  "id": 0,
  "name": "string"
}
```

### Method: GET

> ```
> {{BaseUrl}}/api/Brands/2
> ```

### 🔑 Authentication bearer

| Param | value                          | Type   |
| ----- | ------------------------------ | ------ |
| token | {{vault:authorization-secret}} | string |

### Response: 200

```json
{
  "id": 2,
  "name": "Costa"
}
```

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

# 📁 Collection: Product

## End-point: Get All Prouducts

##### Description

get all products and can specify specific brand,productType and pagination

---

### Method: GET

> ```
> {{BaseUrl}}/api/Products
> ```

### 🔑 Authentication bearer

| Param | value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | Type   |
| ----- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------ |
| token | eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwiZ2l2ZW5fbmFtZSI6IkJpbGFsIiwidW5pcXVlX25hbWUiOiJCaWxhbDEyMyIsImVtYWlsIjoiYmxhbGhhbWQ0OEBnbWFpbC5jb20iLCJyb2xlcyI6WyJBZG1pbiIsIlNlbmlvciIsIlRlYW1MZWFkIl0sInBlcm1pc3Npb25zIjpbIlVzZXJzOkdldEFsbCIsIlVzZXJzOkdldEJ5SWQiLCJVc2VyczpBZGQiLCJVc2VyczpFZGl0IiwiVXNlcnM6RGVsZXRlIiwiVXNlcnM6VW5Mb2NrIiwiUm9sZXM6R2V0QWxsIiwiUm9sZXM6R2V0QnlJZCIsIlJvbGVzOkFkZCIsIlJvbGVzOkVkaXQiLCJSb2xlczpEZWxldGUiLCJCYXNrZXRzOkdldEFsbCIsIkJhc2tldHM6R2V0QnlJZCIsIkJhc2tldHM6QWRkIiwiQmFza2V0czpFZGl0IiwiQmFza2V0czpEZWxldGUiLCJCcmFuZHM6R2V0QWxsIiwiQnJhbmRzOkdldEJ5SWQiLCJQcm9kdWN0czpHZXRBbGwiLCJQcm9kdWN0czpHZXRCeUlkIiwiUHJvZHVjdHM6QWRkIiwiUHJvZHVjdHM6RWRpdCIsIlByb2R1Y3RzOkRlbGV0ZSIsIlByb2R1Y3RUeXBlczpHZXRBbGwiLCJQcm9kdWN0VHlwZXM6R2V0QnlJZCIsIk9yZGVyczpDcmVhdGVPcmRlckFzeW5jIiwiT3JkZXJzOkdldE9yZGVyc0ZvclVzZXJBc3luYyIsIk9yZGVyczpHZXRPcmRlckJ5SWRBc3luYyIsIk9yZGVyczpHZXREZWxpdmVyeU1ldGhvZHNBc3luYyJdLCJuYmYiOjE3MzMxMDI2MzEsImV4cCI6MTczMzEwNDQzMSwiaWF0IjoxNzMzMTAyNjMxLCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDUxIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMCJ9.T1CFAjTb0m_oYe8NPkl99VMZqVCWMKkc_fMl0cZr0rQ | string |

### Response: 200

```json
[
  {
    "id": 1,
    "brandName": "Starbucks",
    "productTypeName": "Frappuccino",
    "name": "Double Caramel Frappuccino",
    "description": "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
    "pictureUrl": "http://localhost:44826/images/products/sb-ang1.png",
    "price": 200
  }
]
```

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

## End-point: Get Product By Id

### Method: GET

> ```
> {{BaseUrl}}/api/Products/2
> ```

### 🔑 Authentication bearer

| Param | value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | Type   |
| ----- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------ |
| token | eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwiZ2l2ZW5fbmFtZSI6IkJpbGFsIiwidW5pcXVlX25hbWUiOiJCaWxhbDEyMyIsImVtYWlsIjoiYmxhbGhhbWQ0OEBnbWFpbC5jb20iLCJyb2xlcyI6WyJBZG1pbiIsIlNlbmlvciIsIlRlYW1MZWFkIl0sInBlcm1pc3Npb25zIjpbIlVzZXJzOkdldEFsbCIsIlVzZXJzOkdldEJ5SWQiLCJVc2VyczpBZGQiLCJVc2VyczpFZGl0IiwiVXNlcnM6RGVsZXRlIiwiVXNlcnM6VW5Mb2NrIiwiUm9sZXM6R2V0QWxsIiwiUm9sZXM6R2V0QnlJZCIsIlJvbGVzOkFkZCIsIlJvbGVzOkVkaXQiLCJSb2xlczpEZWxldGUiLCJCYXNrZXRzOkdldEFsbCIsIkJhc2tldHM6R2V0QnlJZCIsIkJhc2tldHM6QWRkIiwiQmFza2V0czpFZGl0IiwiQmFza2V0czpEZWxldGUiLCJCcmFuZHM6R2V0QWxsIiwiQnJhbmRzOkdldEJ5SWQiLCJQcm9kdWN0czpHZXRBbGwiLCJQcm9kdWN0czpHZXRCeUlkIiwiUHJvZHVjdHM6QWRkIiwiUHJvZHVjdHM6RWRpdCIsIlByb2R1Y3RzOkRlbGV0ZSIsIlByb2R1Y3RUeXBlczpHZXRBbGwiLCJQcm9kdWN0VHlwZXM6R2V0QnlJZCIsIk9yZGVyczpDcmVhdGVPcmRlckFzeW5jIiwiT3JkZXJzOkdldE9yZGVyc0ZvclVzZXJBc3luYyIsIk9yZGVyczpHZXRPcmRlckJ5SWRBc3luYyIsIk9yZGVyczpHZXREZWxpdmVyeU1ldGhvZHNBc3luYyJdLCJuYmYiOjE3MzMxMDI2MzEsImV4cCI6MTczMzEwNDQzMSwiaWF0IjoxNzMzMTAyNjMxLCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDUxIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMCJ9.T1CFAjTb0m_oYe8NPkl99VMZqVCWMKkc_fMl0cZr0rQ | string |

### Response: 200

```json
{
  "id": 2,
  "brandName": "Starbucks",
  "productTypeName": "Frappuccino",
  "name": "White Chocolate Mocha Frappuccino",
  "description": "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
  "pictureUrl": "http://localhost:44826/images/products/sb-ang2.png",
  "price": 150
}
```

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

## End-point: Add Product

### Method: POST

> ```
> {{BaseUrl}}/api/Products
> ```

### Body (**raw**)

```json
{
  "name": "Iphone 14",
  "description": "This device looks nearly flawless, with a few minor signs of use. There may be light scratches",
  "pictureUrl": "https://i.ebayimg.com/images/g/O80AAOSwgm1mKX9S/s-l960.webp",
  "price": 15000,
  "brandId": 1,
  "productTypeId": 1
}
```

### 🔑 Authentication bearer

| Param | value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | Type   |
| ----- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------ |
| token | eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwiZ2l2ZW5fbmFtZSI6IkJpbGFsIiwidW5pcXVlX25hbWUiOiJCaWxhbDEyMyIsImVtYWlsIjoiYmxhbGhhbWQ0OEBnbWFpbC5jb20iLCJyb2xlcyI6WyJBZG1pbiIsIlNlbmlvciIsIlRlYW1MZWFkIl0sInBlcm1pc3Npb25zIjpbIlVzZXJzOkdldEFsbCIsIlVzZXJzOkdldEJ5SWQiLCJVc2VyczpBZGQiLCJVc2VyczpFZGl0IiwiVXNlcnM6RGVsZXRlIiwiVXNlcnM6VW5Mb2NrIiwiUm9sZXM6R2V0QWxsIiwiUm9sZXM6R2V0QnlJZCIsIlJvbGVzOkFkZCIsIlJvbGVzOkVkaXQiLCJSb2xlczpEZWxldGUiLCJCYXNrZXRzOkdldEFsbCIsIkJhc2tldHM6R2V0QnlJZCIsIkJhc2tldHM6QWRkIiwiQmFza2V0czpFZGl0IiwiQmFza2V0czpEZWxldGUiLCJCcmFuZHM6R2V0QWxsIiwiQnJhbmRzOkdldEJ5SWQiLCJQcm9kdWN0czpHZXRBbGwiLCJQcm9kdWN0czpHZXRCeUlkIiwiUHJvZHVjdHM6QWRkIiwiUHJvZHVjdHM6RWRpdCIsIlByb2R1Y3RzOkRlbGV0ZSIsIlByb2R1Y3RUeXBlczpHZXRBbGwiLCJQcm9kdWN0VHlwZXM6R2V0QnlJZCIsIk9yZGVyczpDcmVhdGVPcmRlckFzeW5jIiwiT3JkZXJzOkdldE9yZGVyc0ZvclVzZXJBc3luYyIsIk9yZGVyczpHZXRPcmRlckJ5SWRBc3luYyIsIk9yZGVyczpHZXREZWxpdmVyeU1ldGhvZHNBc3luYyJdLCJuYmYiOjE3MzMxMDI2MzEsImV4cCI6MTczMzEwNDQzMSwiaWF0IjoxNzMzMTAyNjMxLCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDUxIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMCJ9.T1CFAjTb0m_oYe8NPkl99VMZqVCWMKkc_fMl0cZr0rQ | string |

### Response: 200

```json
null
```

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

## End-point: Update Proudct

### Method: PUT

> ```
> {{BaseUrl}}/api/Products/?id=20
> ```

### Body (**raw**)

```json
{
  "name": "Iphone 14",
  "description": "This device looks nearly flawless, with a few minor signs of use. There may be light scratches",
  "pictureUrl": "sb-ang1.png",
  "price": 0,
  "brandId": 1,
  "productTypeId": 1
}
```

### Query Params

| Param | value |
| ----- | ----- |
| id    | 20    |

### 🔑 Authentication bearer

| Param | value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | Type   |
| ----- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------ |
| token | eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwiZ2l2ZW5fbmFtZSI6IkJpbGFsIiwidW5pcXVlX25hbWUiOiJCaWxhbDEyMyIsImVtYWlsIjoiYmxhbGhhbWQ0OEBnbWFpbC5jb20iLCJyb2xlcyI6WyJBZG1pbiIsIlNlbmlvciIsIlRlYW1MZWFkIl0sInBlcm1pc3Npb25zIjpbIlVzZXJzOkdldEFsbCIsIlVzZXJzOkdldEJ5SWQiLCJVc2VyczpBZGQiLCJVc2VyczpFZGl0IiwiVXNlcnM6RGVsZXRlIiwiVXNlcnM6VW5Mb2NrIiwiUm9sZXM6R2V0QWxsIiwiUm9sZXM6R2V0QnlJZCIsIlJvbGVzOkFkZCIsIlJvbGVzOkVkaXQiLCJSb2xlczpEZWxldGUiLCJCYXNrZXRzOkdldEFsbCIsIkJhc2tldHM6R2V0QnlJZCIsIkJhc2tldHM6QWRkIiwiQmFza2V0czpFZGl0IiwiQmFza2V0czpEZWxldGUiLCJCcmFuZHM6R2V0QWxsIiwiQnJhbmRzOkdldEJ5SWQiLCJQcm9kdWN0czpHZXRBbGwiLCJQcm9kdWN0czpHZXRCeUlkIiwiUHJvZHVjdHM6QWRkIiwiUHJvZHVjdHM6RWRpdCIsIlByb2R1Y3RzOkRlbGV0ZSIsIlByb2R1Y3RUeXBlczpHZXRBbGwiLCJQcm9kdWN0VHlwZXM6R2V0QnlJZCIsIk9yZGVyczpDcmVhdGVPcmRlckFzeW5jIiwiT3JkZXJzOkdldE9yZGVyc0ZvclVzZXJBc3luYyIsIk9yZGVyczpHZXRPcmRlckJ5SWRBc3luYyIsIk9yZGVyczpHZXREZWxpdmVyeU1ldGhvZHNBc3luYyJdLCJuYmYiOjE3MzMxMDI2MzEsImV4cCI6MTczMzEwNDQzMSwiaWF0IjoxNzMzMTAyNjMxLCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDUxIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMCJ9.T1CFAjTb0m_oYe8NPkl99VMZqVCWMKkc_fMl0cZr0rQ | string |

### Response: 200

```json
null
```

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

## End-point: Delete Product

### Method: DELETE

> ```
> {{BaseUrl}}/api/Products/20
> ```

### 🔑 Authentication bearer

| Param | value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | Type   |
| ----- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------ |
| token | eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwiZ2l2ZW5fbmFtZSI6IkJpbGFsIiwidW5pcXVlX25hbWUiOiJCaWxhbDEyMyIsImVtYWlsIjoiYmxhbGhhbWQ0OEBnbWFpbC5jb20iLCJyb2xlcyI6WyJBZG1pbiIsIlNlbmlvciIsIlRlYW1MZWFkIl0sInBlcm1pc3Npb25zIjpbIlVzZXJzOkdldEFsbCIsIlVzZXJzOkdldEJ5SWQiLCJVc2VyczpBZGQiLCJVc2VyczpFZGl0IiwiVXNlcnM6RGVsZXRlIiwiVXNlcnM6VW5Mb2NrIiwiUm9sZXM6R2V0QWxsIiwiUm9sZXM6R2V0QnlJZCIsIlJvbGVzOkFkZCIsIlJvbGVzOkVkaXQiLCJSb2xlczpEZWxldGUiLCJCYXNrZXRzOkdldEFsbCIsIkJhc2tldHM6R2V0QnlJZCIsIkJhc2tldHM6QWRkIiwiQmFza2V0czpFZGl0IiwiQmFza2V0czpEZWxldGUiLCJCcmFuZHM6R2V0QWxsIiwiQnJhbmRzOkdldEJ5SWQiLCJQcm9kdWN0czpHZXRBbGwiLCJQcm9kdWN0czpHZXRCeUlkIiwiUHJvZHVjdHM6QWRkIiwiUHJvZHVjdHM6RWRpdCIsIlByb2R1Y3RzOkRlbGV0ZSIsIlByb2R1Y3RUeXBlczpHZXRBbGwiLCJQcm9kdWN0VHlwZXM6R2V0QnlJZCIsIk9yZGVyczpDcmVhdGVPcmRlckFzeW5jIiwiT3JkZXJzOkdldE9yZGVyc0ZvclVzZXJBc3luYyIsIk9yZGVyczpHZXRPcmRlckJ5SWRBc3luYyIsIk9yZGVyczpHZXREZWxpdmVyeU1ldGhvZHNBc3luYyJdLCJuYmYiOjE3MzMxMDI2MzEsImV4cCI6MTczMzEwNDQzMSwiaWF0IjoxNzMzMTAyNjMxLCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDUxIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMCJ9.T1CFAjTb0m_oYe8NPkl99VMZqVCWMKkc_fMl0cZr0rQ | string |

### Response: 200

```json
null
```

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

# 📁 Collection: ProductTypes

## End-point: Get All ProductTypes

### Method: GET

> ```
> {{BaseUrl}}/api/ProductTypes
> ```

### 🔑 Authentication bearer

| Param | value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | Type   |
| ----- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------ |
| token | eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwiZ2l2ZW5fbmFtZSI6IkJpbGFsIiwidW5pcXVlX25hbWUiOiJCaWxhbDEyMyIsImVtYWlsIjoiYmxhbGhhbWQ0OEBnbWFpbC5jb20iLCJyb2xlcyI6WyJBZG1pbiIsIlNlbmlvciIsIlRlYW1MZWFkIl0sInBlcm1pc3Npb25zIjpbIlVzZXJzOkdldEFsbCIsIlVzZXJzOkdldEJ5SWQiLCJVc2VyczpBZGQiLCJVc2VyczpFZGl0IiwiVXNlcnM6RGVsZXRlIiwiVXNlcnM6VW5Mb2NrIiwiUm9sZXM6R2V0QWxsIiwiUm9sZXM6R2V0QnlJZCIsIlJvbGVzOkFkZCIsIlJvbGVzOkVkaXQiLCJSb2xlczpEZWxldGUiLCJCYXNrZXRzOkdldEFsbCIsIkJhc2tldHM6R2V0QnlJZCIsIkJhc2tldHM6QWRkIiwiQmFza2V0czpFZGl0IiwiQmFza2V0czpEZWxldGUiLCJCcmFuZHM6R2V0QWxsIiwiQnJhbmRzOkdldEJ5SWQiLCJQcm9kdWN0czpHZXRBbGwiLCJQcm9kdWN0czpHZXRCeUlkIiwiUHJvZHVjdHM6QWRkIiwiUHJvZHVjdHM6RWRpdCIsIlByb2R1Y3RzOkRlbGV0ZSIsIlByb2R1Y3RUeXBlczpHZXRBbGwiLCJQcm9kdWN0VHlwZXM6R2V0QnlJZCIsIk9yZGVyczpDcmVhdGVPcmRlckFzeW5jIiwiT3JkZXJzOkdldE9yZGVyc0ZvclVzZXJBc3luYyIsIk9yZGVyczpHZXRPcmRlckJ5SWRBc3luYyIsIk9yZGVyczpHZXREZWxpdmVyeU1ldGhvZHNBc3luYyJdLCJuYmYiOjE3MzMxMDI2MzEsImV4cCI6MTczMzEwNDQzMSwiaWF0IjoxNzMzMTAyNjMxLCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDUxIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMCJ9.T1CFAjTb0m_oYe8NPkl99VMZqVCWMKkc_fMl0cZr0rQ | string |

### Response: 200

```json
[
  {
    "id": 1,
    "name": "Frappuccino"
  },
  {
    "id": 2,
    "name": "Latte"
  },
  {
    "id": 3,
    "name": "Mocha"
  },
  {
    "id": 4,
    "name": "Macchiato"
  },
  {
    "id": 5,
    "name": "Matcha"
  },
  {
    "id": 6,
    "name": "Cake"
  },
  {
    "id": 7,
    "name": "Donuts"
  },
  {
    "id": 8,
    "name": "Salad"
  }
]
```

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

## End-point: Get ProductType By Id

#### Response

---

```json
{
  "id": 0,
  "name": "string"
}
```

### Method: GET

> ```
> {{BaseUrl}}/api/ProductTypes/1
> ```

### 🔑 Authentication bearer

| Param | value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | Type   |
| ----- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------ |
| token | eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwiZ2l2ZW5fbmFtZSI6IkJpbGFsIiwidW5pcXVlX25hbWUiOiJCaWxhbDEyMyIsImVtYWlsIjoiYmxhbGhhbWQ0OEBnbWFpbC5jb20iLCJyb2xlcyI6WyJBZG1pbiIsIlNlbmlvciIsIlRlYW1MZWFkIl0sInBlcm1pc3Npb25zIjpbIlVzZXJzOkdldEFsbCIsIlVzZXJzOkdldEJ5SWQiLCJVc2VyczpBZGQiLCJVc2VyczpFZGl0IiwiVXNlcnM6RGVsZXRlIiwiVXNlcnM6VW5Mb2NrIiwiUm9sZXM6R2V0QWxsIiwiUm9sZXM6R2V0QnlJZCIsIlJvbGVzOkFkZCIsIlJvbGVzOkVkaXQiLCJSb2xlczpEZWxldGUiLCJCYXNrZXRzOkdldEFsbCIsIkJhc2tldHM6R2V0QnlJZCIsIkJhc2tldHM6QWRkIiwiQmFza2V0czpFZGl0IiwiQmFza2V0czpEZWxldGUiLCJCcmFuZHM6R2V0QWxsIiwiQnJhbmRzOkdldEJ5SWQiLCJQcm9kdWN0czpHZXRBbGwiLCJQcm9kdWN0czpHZXRCeUlkIiwiUHJvZHVjdHM6QWRkIiwiUHJvZHVjdHM6RWRpdCIsIlByb2R1Y3RzOkRlbGV0ZSIsIlByb2R1Y3RUeXBlczpHZXRBbGwiLCJQcm9kdWN0VHlwZXM6R2V0QnlJZCIsIk9yZGVyczpDcmVhdGVPcmRlckFzeW5jIiwiT3JkZXJzOkdldE9yZGVyc0ZvclVzZXJBc3luYyIsIk9yZGVyczpHZXRPcmRlckJ5SWRBc3luYyIsIk9yZGVyczpHZXREZWxpdmVyeU1ldGhvZHNBc3luYyJdLCJuYmYiOjE3MzMxMTc0NjcsImV4cCI6MTczMzExOTI2NywiaWF0IjoxNzMzMTE3NDY3LCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDUxIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMCJ9.u7Wr6GzJDZBL-shVnJxzBsufL_h9UVHYmRw1DPc-g1M | string |

### Response: 200

```json
{
  "id": 1,
  "name": "Frappuccino"
}
```

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

# 📁 Collection: Account

## End-point: Accounts

### Method: GET

> ```
> {{BaseUrl}}/api/Accounts
> ```

### 🔑 Authentication bearer

| Param | value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | Type   |
| ----- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------ |
| token | eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwiZ2l2ZW5fbmFtZSI6IkJpbGFsIiwidW5pcXVlX25hbWUiOiJCaWxhbDEyMyIsImVtYWlsIjoiYmxhbGhhbWQ0OEBnbWFpbC5jb20iLCJyb2xlcyI6WyJBZG1pbiIsIlNlbmlvciIsIlRlYW1MZWFkIl0sInBlcm1pc3Npb25zIjpbIlVzZXJzOkdldEFsbCIsIlVzZXJzOkdldEJ5SWQiLCJVc2VyczpBZGQiLCJVc2VyczpFZGl0IiwiVXNlcnM6RGVsZXRlIiwiVXNlcnM6VW5Mb2NrIiwiUm9sZXM6R2V0QWxsIiwiUm9sZXM6R2V0QnlJZCIsIlJvbGVzOkFkZCIsIlJvbGVzOkVkaXQiLCJSb2xlczpEZWxldGUiLCJCYXNrZXRzOkdldEFsbCIsIkJhc2tldHM6R2V0QnlJZCIsIkJhc2tldHM6QWRkIiwiQmFza2V0czpFZGl0IiwiQmFza2V0czpEZWxldGUiLCJCcmFuZHM6R2V0QWxsIiwiQnJhbmRzOkdldEJ5SWQiLCJQcm9kdWN0czpHZXRBbGwiLCJQcm9kdWN0czpHZXRCeUlkIiwiUHJvZHVjdHM6QWRkIiwiUHJvZHVjdHM6RWRpdCIsIlByb2R1Y3RzOkRlbGV0ZSIsIlByb2R1Y3RUeXBlczpHZXRBbGwiLCJQcm9kdWN0VHlwZXM6R2V0QnlJZCIsIk9yZGVyczpDcmVhdGVPcmRlckFzeW5jIiwiT3JkZXJzOkdldE9yZGVyc0ZvclVzZXJBc3luYyIsIk9yZGVyczpHZXRPcmRlckJ5SWRBc3luYyIsIk9yZGVyczpHZXREZWxpdmVyeU1ldGhvZHNBc3luYyJdLCJuYmYiOjE3MzMxMDQ4MTgsImV4cCI6MTczMzEwNjYxOCwiaWF0IjoxNzMzMTA0ODE4LCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDUxIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMCJ9.RTpHXcsVD06pKp1GMOHasL37n1Hvmfe8bXlpBoU\_\_9A | string |

### Response: 200

```json
{
  "firstName": "Bilal",
  "lastName": "Sayed",
  "email": "blalhamd48@gmail.com",
  "phoneNumber": "01007656154"
}
```

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

## End-point: Update Profile

#### Response

---

| **Code** | **Description** |
| -------- | --------------- |
| 200      | success         |

### Method: PUT

> ```
> {{BaseUrl}}/api/Accounts
> ```

### Body (**raw**)

```json
{
  "firstName": "Bilal",
  "lastName": "Sayed",
  "phoneNumber": "01007656154"
}
```

### 🔑 Authentication bearer

| Param | value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | Type   |
| ----- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------ |
| token | eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwiZ2l2ZW5fbmFtZSI6IkJpbGFsIiwidW5pcXVlX25hbWUiOiJCaWxhbDEyMyIsImVtYWlsIjoiYmxhbGhhbWQ0OEBnbWFpbC5jb20iLCJyb2xlcyI6WyJBZG1pbiIsIlNlbmlvciIsIlRlYW1MZWFkIl0sInBlcm1pc3Npb25zIjpbIlVzZXJzOkdldEFsbCIsIlVzZXJzOkdldEJ5SWQiLCJVc2VyczpBZGQiLCJVc2VyczpFZGl0IiwiVXNlcnM6RGVsZXRlIiwiVXNlcnM6VW5Mb2NrIiwiUm9sZXM6R2V0QWxsIiwiUm9sZXM6R2V0QnlJZCIsIlJvbGVzOkFkZCIsIlJvbGVzOkVkaXQiLCJSb2xlczpEZWxldGUiLCJCYXNrZXRzOkdldEFsbCIsIkJhc2tldHM6R2V0QnlJZCIsIkJhc2tldHM6QWRkIiwiQmFza2V0czpFZGl0IiwiQmFza2V0czpEZWxldGUiLCJCcmFuZHM6R2V0QWxsIiwiQnJhbmRzOkdldEJ5SWQiLCJQcm9kdWN0czpHZXRBbGwiLCJQcm9kdWN0czpHZXRCeUlkIiwiUHJvZHVjdHM6QWRkIiwiUHJvZHVjdHM6RWRpdCIsIlByb2R1Y3RzOkRlbGV0ZSIsIlByb2R1Y3RUeXBlczpHZXRBbGwiLCJQcm9kdWN0VHlwZXM6R2V0QnlJZCIsIk9yZGVyczpDcmVhdGVPcmRlckFzeW5jIiwiT3JkZXJzOkdldE9yZGVyc0ZvclVzZXJBc3luYyIsIk9yZGVyczpHZXRPcmRlckJ5SWRBc3luYyIsIk9yZGVyczpHZXREZWxpdmVyeU1ldGhvZHNBc3luYyJdLCJuYmYiOjE3MzMxMDQ4MTgsImV4cCI6MTczMzEwNjYxOCwiaWF0IjoxNzMzMTA0ODE4LCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDUxIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMCJ9.RTpHXcsVD06pKp1GMOHasL37n1Hvmfe8bXlpBoU\_\_9A | string |

### Response: 200

```json
null
```

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

## End-point: Change Password

#### Response

| **Code** | **Description** |
| -------- | --------------- |
| 200      | success         |

### Method: PUT

> ```
> {{BaseUrl}}/api/Accounts/ChangePassword
> ```

### Body (**raw**)

```json
{
  "currentPassword": "99223116Mo3ez$$$$",
  "newPassword": "99223116Mo3ez$$$$",
  "confirmPassword": "99223116Mo3ez$$$$"
}
```

### 🔑 Authentication bearer

| Param | value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | Type   |
| ----- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------ |
| token | eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwiZ2l2ZW5fbmFtZSI6IkJpbGFsIiwidW5pcXVlX25hbWUiOiJCaWxhbDEyMyIsImVtYWlsIjoiYmxhbGhhbWQ0OEBnbWFpbC5jb20iLCJyb2xlcyI6WyJBZG1pbiIsIlNlbmlvciIsIlRlYW1MZWFkIl0sInBlcm1pc3Npb25zIjpbIlVzZXJzOkdldEFsbCIsIlVzZXJzOkdldEJ5SWQiLCJVc2VyczpBZGQiLCJVc2VyczpFZGl0IiwiVXNlcnM6RGVsZXRlIiwiVXNlcnM6VW5Mb2NrIiwiUm9sZXM6R2V0QWxsIiwiUm9sZXM6R2V0QnlJZCIsIlJvbGVzOkFkZCIsIlJvbGVzOkVkaXQiLCJSb2xlczpEZWxldGUiLCJCYXNrZXRzOkdldEFsbCIsIkJhc2tldHM6R2V0QnlJZCIsIkJhc2tldHM6QWRkIiwiQmFza2V0czpFZGl0IiwiQmFza2V0czpEZWxldGUiLCJCcmFuZHM6R2V0QWxsIiwiQnJhbmRzOkdldEJ5SWQiLCJQcm9kdWN0czpHZXRBbGwiLCJQcm9kdWN0czpHZXRCeUlkIiwiUHJvZHVjdHM6QWRkIiwiUHJvZHVjdHM6RWRpdCIsIlByb2R1Y3RzOkRlbGV0ZSIsIlByb2R1Y3RUeXBlczpHZXRBbGwiLCJQcm9kdWN0VHlwZXM6R2V0QnlJZCIsIk9yZGVyczpDcmVhdGVPcmRlckFzeW5jIiwiT3JkZXJzOkdldE9yZGVyc0ZvclVzZXJBc3luYyIsIk9yZGVyczpHZXRPcmRlckJ5SWRBc3luYyIsIk9yZGVyczpHZXREZWxpdmVyeU1ldGhvZHNBc3luYyJdLCJuYmYiOjE3MzMxMDQ4MTgsImV4cCI6MTczMzEwNjYxOCwiaWF0IjoxNzMzMTA0ODE4LCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDUxIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMCJ9.RTpHXcsVD06pKp1GMOHasL37n1Hvmfe8bXlpBoU\_\_9A | string |

### Response: 500

```json
{
  "StatusCode": 400,
  "Message": "Incorrect password.",
  "Details": null
}
```

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

# 📁 Collection: Orders

## End-point: Get Orders

### Method: GET

> ```
> {{BaseUrl}}/api/Orders
> ```

### 🔑 Authentication bearer

| Param | value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | Type   |
| ----- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------ |
| token | eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwiZ2l2ZW5fbmFtZSI6IkJpbGFsIiwidW5pcXVlX25hbWUiOiJCaWxhbDEyMyIsImVtYWlsIjoiYmxhbGhhbWQ0OEBnbWFpbC5jb20iLCJyb2xlcyI6WyJBZG1pbiIsIlNlbmlvciIsIlRlYW1MZWFkIl0sInBlcm1pc3Npb25zIjpbIlVzZXJzOkdldEFsbCIsIlVzZXJzOkdldEJ5SWQiLCJVc2VyczpBZGQiLCJVc2VyczpFZGl0IiwiVXNlcnM6RGVsZXRlIiwiVXNlcnM6VW5Mb2NrIiwiUm9sZXM6R2V0QWxsIiwiUm9sZXM6R2V0QnlJZCIsIlJvbGVzOkFkZCIsIlJvbGVzOkVkaXQiLCJSb2xlczpEZWxldGUiLCJCYXNrZXRzOkdldEFsbCIsIkJhc2tldHM6R2V0QnlJZCIsIkJhc2tldHM6QWRkIiwiQmFza2V0czpFZGl0IiwiQmFza2V0czpEZWxldGUiLCJCcmFuZHM6R2V0QWxsIiwiQnJhbmRzOkdldEJ5SWQiLCJQcm9kdWN0czpHZXRBbGwiLCJQcm9kdWN0czpHZXRCeUlkIiwiUHJvZHVjdHM6QWRkIiwiUHJvZHVjdHM6RWRpdCIsIlByb2R1Y3RzOkRlbGV0ZSIsIlByb2R1Y3RUeXBlczpHZXRBbGwiLCJQcm9kdWN0VHlwZXM6R2V0QnlJZCIsIk9yZGVyczpDcmVhdGVPcmRlckFzeW5jIiwiT3JkZXJzOkdldE9yZGVyc0ZvclVzZXJBc3luYyIsIk9yZGVyczpHZXRPcmRlckJ5SWRBc3luYyIsIk9yZGVyczpHZXREZWxpdmVyeU1ldGhvZHNBc3luYyJdLCJuYmYiOjE3MzMxMDQ4MTgsImV4cCI6MTczMzEwNjYxOCwiaWF0IjoxNzMzMTA0ODE4LCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDUxIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMCJ9.RTpHXcsVD06pKp1GMOHasL37n1Hvmfe8bXlpBoU\_\_9A | string |

### Response: 200

```json
[
  {
    "id": 1,
    "buyerEmail": "blalhamd48@gmail.com",
    "dateTime": "2024-10-14T01:55:22.5301152+03:00",
    "shippingAddress": {
      "firstName": "Bilal",
      "lastName": "Sayed",
      "country": "EGY",
      "cirt": "Fashn",
      "street": "123 Nabil Street"
    },
    "deliveryMethodId": 1,
    "deliveryMethod": {
      "shortName": "UPS1",
      "cost": 10
    },
    "orderStatus": "Pending",
    "items": [
      {
        "productId": 1,
        "productName": "Double Caramel Frappuccino",
        "pictureUrl": "http://localhost:44826/images/products/sb-ang1.png",
        "price": 200,
        "qunatity": 2,
        "orderId": 1
      }
    ],
    "subTotal": 400,
    "total": 410,
    "paymentIntentId": ""
  },
  {
    "id": 2,
    "buyerEmail": "blalhamd48@gmail.com",
    "dateTime": "2024-10-14T02:09:02.5803895+03:00",
    "shippingAddress": {
      "firstName": "Ahmed",
      "lastName": "Tawfiq",
      "country": "EGY",
      "cirt": "Giza",
      "street": "124 Moez st"
    },
    "deliveryMethodId": 2,
    "deliveryMethod": {
      "shortName": "UPS2",
      "cost": 5
    },
    "orderStatus": "Pending",
    "items": [
      {
        "productId": 1,
        "productName": "Double Caramel Frappuccino",
        "pictureUrl": "http://localhost:44826/images/products/sb-ang1.png",
        "price": 200,
        "qunatity": 2,
        "orderId": 2
      },
      {
        "productId": 2,
        "productName": "White Chocolate Mocha Frappuccino",
        "pictureUrl": "http://localhost:44826/images/products/sb-ang2.png",
        "price": 150,
        "qunatity": 3,
        "orderId": 2
      }
    ],
    "subTotal": 850,
    "total": 855,
    "paymentIntentId": ""
  },
  {
    "id": 3,
    "buyerEmail": "blalhamd48@gmail.com",
    "dateTime": "2024-10-14T02:21:52.1686189+03:00",
    "shippingAddress": {
      "firstName": "Kareem",
      "lastName": "Azzam",
      "country": "London",
      "cirt": "Manchester",
      "street": "121 st"
    },
    "deliveryMethodId": 3,
    "deliveryMethod": {
      "shortName": "UPS3",
      "cost": 2
    },
    "orderStatus": "Pending",
    "items": [
      {
        "productId": 1,
        "productName": "Double Caramel Frappuccino",
        "pictureUrl": "http://localhost:44826/images/products/sb-ang1.png",
        "price": 200,
        "qunatity": 2,
        "orderId": 3
      },
      {
        "productId": 2,
        "productName": "White Chocolate Mocha Frappuccino",
        "pictureUrl": "http://localhost:44826/images/products/sb-ang2.png",
        "price": 150,
        "qunatity": 3,
        "orderId": 3
      }
    ],
    "subTotal": 850,
    "total": 852,
    "paymentIntentId": ""
  },
  {
    "id": 4,
    "buyerEmail": "blalhamd48@gmail.com",
    "dateTime": "2024-10-14T02:24:47.7383391+03:00",
    "shippingAddress": {
      "firstName": "Ahmed",
      "lastName": "Adel",
      "country": "KSA",
      "cirt": "RYADH",
      "street": "156 st"
    },
    "deliveryMethodId": 3,
    "deliveryMethod": {
      "shortName": "UPS3",
      "cost": 2
    },
    "orderStatus": "Pending",
    "items": [
      {
        "productId": 1,
        "productName": "Double Caramel Frappuccino",
        "pictureUrl": "http://localhost:44826/images/products/sb-ang1.png",
        "price": 200,
        "qunatity": 2,
        "orderId": 4
      },
      {
        "productId": 2,
        "productName": "White Chocolate Mocha Frappuccino",
        "pictureUrl": "http://localhost:44826/images/products/sb-ang2.png",
        "price": 150,
        "qunatity": 3,
        "orderId": 4
      }
    ],
    "subTotal": 850,
    "total": 852,
    "paymentIntentId": ""
  },
  {
    "id": 5,
    "buyerEmail": "blalhamd48@gmail.com",
    "dateTime": "2024-10-14T02:26:38.6721377+03:00",
    "shippingAddress": {
      "firstName": "Hussien",
      "lastName": "Sayed",
      "country": "EGY",
      "cirt": "Fashn",
      "street": "123 Nabil Street"
    },
    "deliveryMethodId": 4,
    "deliveryMethod": {
      "shortName": "FREE",
      "cost": 0
    },
    "orderStatus": "Pending",
    "items": [
      {
        "productId": 1,
        "productName": "Double Caramel Frappuccino",
        "pictureUrl": "http://localhost:44826/images/products/sb-ang1.png",
        "price": 200,
        "qunatity": 2,
        "orderId": 5
      },
      {
        "productId": 2,
        "productName": "White Chocolate Mocha Frappuccino",
        "pictureUrl": "http://localhost:44826/images/products/sb-ang2.png",
        "price": 150,
        "qunatity": 3,
        "orderId": 5
      }
    ],
    "subTotal": 850,
    "total": 850,
    "paymentIntentId": ""
  },
  {
    "id": 6,
    "buyerEmail": "blalhamd48@gmail.com",
    "dateTime": "2024-10-14T02:28:55.9518136+03:00",
    "shippingAddress": {
      "firstName": "Momen",
      "lastName": "Sayed",
      "country": "EGY",
      "cirt": "Fashn",
      "street": "123 Nabil Street"
    },
    "deliveryMethodId": 4,
    "deliveryMethod": {
      "shortName": "FREE",
      "cost": 0
    },
    "orderStatus": "Pending",
    "items": [
      {
        "productId": 1,
        "productName": "Double Caramel Frappuccino",
        "pictureUrl": "http://localhost:44826/images/products/sb-ang1.png",
        "price": 200,
        "qunatity": 2,
        "orderId": 6
      },
      {
        "productId": 2,
        "productName": "White Chocolate Mocha Frappuccino",
        "pictureUrl": "http://localhost:44826/images/products/sb-ang2.png",
        "price": 150,
        "qunatity": 3,
        "orderId": 6
      }
    ],
    "subTotal": 850,
    "total": 850,
    "paymentIntentId": ""
  },
  {
    "id": 7,
    "buyerEmail": "blalhamd48@gmail.com",
    "dateTime": "2024-10-14T14:40:08.8520547+03:00",
    "shippingAddress": {
      "firstName": "Abdo",
      "lastName": "Adel",
      "country": "Portogal",
      "cirt": "shpona",
      "street": "cr7 st"
    },
    "deliveryMethodId": 3,
    "deliveryMethod": {
      "shortName": "UPS3",
      "cost": 2
    },
    "orderStatus": "Pending",
    "items": [
      {
        "productId": 1,
        "productName": "Double Caramel Frappuccino",
        "pictureUrl": "http://localhost:44826/images/products/sb-ang1.png",
        "price": 200,
        "qunatity": 2,
        "orderId": 7
      },
      {
        "productId": 2,
        "productName": "White Chocolate Mocha Frappuccino",
        "pictureUrl": "http://localhost:44826/images/products/sb-ang2.png",
        "price": 150,
        "qunatity": 3,
        "orderId": 7
      }
    ],
    "subTotal": 850,
    "total": 852,
    "paymentIntentId": ""
  },
  {
    "id": 8,
    "buyerEmail": "blalhamd48@gmail.com",
    "dateTime": "2024-10-14T15:18:16.7612885+03:00",
    "shippingAddress": {
      "firstName": "Mohamed",
      "lastName": "Maher",
      "country": "EGYPT",
      "cirt": "Fashn",
      "street": "121 st"
    },
    "deliveryMethodId": 4,
    "deliveryMethod": {
      "shortName": "FREE",
      "cost": 0
    },
    "orderStatus": "Pending",
    "items": [
      {
        "productId": 1,
        "productName": "Double Caramel Frappuccino",
        "pictureUrl": "http://localhost:44826/images/products/sb-ang1.png",
        "price": 200,
        "qunatity": 2,
        "orderId": 8
      },
      {
        "productId": 2,
        "productName": "White Chocolate Mocha Frappuccino",
        "pictureUrl": "http://localhost:44826/images/products/sb-ang2.png",
        "price": 150,
        "qunatity": 3,
        "orderId": 8
      }
    ],
    "subTotal": 850,
    "total": 850,
    "paymentIntentId": ""
  }
]
```

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

## End-point: Get Order By Id

### Method: GET

> ```
> {{BaseUrl}}/api/Orders/1
> ```

### 🔑 Authentication bearer

| Param | value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | Type   |
| ----- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------ |
| token | eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwiZ2l2ZW5fbmFtZSI6IkJpbGFsIiwidW5pcXVlX25hbWUiOiJCaWxhbDEyMyIsImVtYWlsIjoiYmxhbGhhbWQ0OEBnbWFpbC5jb20iLCJyb2xlcyI6WyJBZG1pbiIsIlNlbmlvciIsIlRlYW1MZWFkIl0sInBlcm1pc3Npb25zIjpbIlVzZXJzOkdldEFsbCIsIlVzZXJzOkdldEJ5SWQiLCJVc2VyczpBZGQiLCJVc2VyczpFZGl0IiwiVXNlcnM6RGVsZXRlIiwiVXNlcnM6VW5Mb2NrIiwiUm9sZXM6R2V0QWxsIiwiUm9sZXM6R2V0QnlJZCIsIlJvbGVzOkFkZCIsIlJvbGVzOkVkaXQiLCJSb2xlczpEZWxldGUiLCJCYXNrZXRzOkdldEFsbCIsIkJhc2tldHM6R2V0QnlJZCIsIkJhc2tldHM6QWRkIiwiQmFza2V0czpFZGl0IiwiQmFza2V0czpEZWxldGUiLCJCcmFuZHM6R2V0QWxsIiwiQnJhbmRzOkdldEJ5SWQiLCJQcm9kdWN0czpHZXRBbGwiLCJQcm9kdWN0czpHZXRCeUlkIiwiUHJvZHVjdHM6QWRkIiwiUHJvZHVjdHM6RWRpdCIsIlByb2R1Y3RzOkRlbGV0ZSIsIlByb2R1Y3RUeXBlczpHZXRBbGwiLCJQcm9kdWN0VHlwZXM6R2V0QnlJZCIsIk9yZGVyczpDcmVhdGVPcmRlckFzeW5jIiwiT3JkZXJzOkdldE9yZGVyc0ZvclVzZXJBc3luYyIsIk9yZGVyczpHZXRPcmRlckJ5SWRBc3luYyIsIk9yZGVyczpHZXREZWxpdmVyeU1ldGhvZHNBc3luYyJdLCJuYmYiOjE3MzMxMDQ4MTgsImV4cCI6MTczMzEwNjYxOCwiaWF0IjoxNzMzMTA0ODE4LCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDUxIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMCJ9.RTpHXcsVD06pKp1GMOHasL37n1Hvmfe8bXlpBoU\_\_9A | string |

### Response: 200

```json
{
  "id": 1,
  "buyerEmail": "blalhamd48@gmail.com",
  "dateTime": "2024-10-14T01:55:22.5301152+03:00",
  "shippingAddress": {
    "firstName": "Bilal",
    "lastName": "Sayed",
    "country": "EGY",
    "cirt": "Fashn",
    "street": "123 Nabil Street"
  },
  "deliveryMethodId": 1,
  "deliveryMethod": {
    "shortName": "UPS1",
    "cost": 10
  },
  "orderStatus": "Pending",
  "items": [
    {
      "productId": 1,
      "productName": "Double Caramel Frappuccino",
      "pictureUrl": "http://localhost:44826/images/products/sb-ang1.png",
      "price": 200,
      "qunatity": 2,
      "orderId": 1
    }
  ],
  "subTotal": 400,
  "total": 410,
  "paymentIntentId": ""
}
```

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

## End-point: Get DeliveryMethods

### Method: GET

> ```
> {{BaseUrl}}/api/Orders/DeliveryMethods
> ```

### 🔑 Authentication bearer

| Param | value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | Type   |
| ----- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------ |
| token | eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwiZ2l2ZW5fbmFtZSI6IkJpbGFsIiwidW5pcXVlX25hbWUiOiJCaWxhbDEyMyIsImVtYWlsIjoiYmxhbGhhbWQ0OEBnbWFpbC5jb20iLCJyb2xlcyI6WyJBZG1pbiIsIlNlbmlvciIsIlRlYW1MZWFkIl0sInBlcm1pc3Npb25zIjpbIlVzZXJzOkdldEFsbCIsIlVzZXJzOkdldEJ5SWQiLCJVc2VyczpBZGQiLCJVc2VyczpFZGl0IiwiVXNlcnM6RGVsZXRlIiwiVXNlcnM6VW5Mb2NrIiwiUm9sZXM6R2V0QWxsIiwiUm9sZXM6R2V0QnlJZCIsIlJvbGVzOkFkZCIsIlJvbGVzOkVkaXQiLCJSb2xlczpEZWxldGUiLCJCYXNrZXRzOkdldEFsbCIsIkJhc2tldHM6R2V0QnlJZCIsIkJhc2tldHM6QWRkIiwiQmFza2V0czpFZGl0IiwiQmFza2V0czpEZWxldGUiLCJCcmFuZHM6R2V0QWxsIiwiQnJhbmRzOkdldEJ5SWQiLCJQcm9kdWN0czpHZXRBbGwiLCJQcm9kdWN0czpHZXRCeUlkIiwiUHJvZHVjdHM6QWRkIiwiUHJvZHVjdHM6RWRpdCIsIlByb2R1Y3RzOkRlbGV0ZSIsIlByb2R1Y3RUeXBlczpHZXRBbGwiLCJQcm9kdWN0VHlwZXM6R2V0QnlJZCIsIk9yZGVyczpDcmVhdGVPcmRlckFzeW5jIiwiT3JkZXJzOkdldE9yZGVyc0ZvclVzZXJBc3luYyIsIk9yZGVyczpHZXRPcmRlckJ5SWRBc3luYyIsIk9yZGVyczpHZXREZWxpdmVyeU1ldGhvZHNBc3luYyJdLCJuYmYiOjE3MzMxMDQ4MTgsImV4cCI6MTczMzEwNjYxOCwiaWF0IjoxNzMzMTA0ODE4LCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDUxIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMCJ9.RTpHXcsVD06pKp1GMOHasL37n1Hvmfe8bXlpBoU\_\_9A | string |

### Response: 200

```json
[
  {
    "id": 1,
    "shortName": "UPS1",
    "description": "Fastest delivery time",
    "cost": 10,
    "deliveryTime": "1-2 Days"
  },
  {
    "id": 2,
    "shortName": "UPS2",
    "description": "Get it within 5 days",
    "cost": 5,
    "deliveryTime": "2-5 Days"
  },
  {
    "id": 3,
    "shortName": "UPS3",
    "description": "Slower but cheap",
    "cost": 2,
    "deliveryTime": "5-10 Days"
  },
  {
    "id": 4,
    "shortName": "FREE",
    "description": "Free! You get what you pay for",
    "cost": 0,
    "deliveryTime": "1-2 Weeks"
  }
]
```

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

## End-point: Add Order

### Method: POST

> ```
> {{BaseUrl}}/api/Orders
> ```

### Body (**raw**)

```json
{
  "basketId": "1",
  "deliveryMethodId": 1,
  "address": {
    "firstName": "Bilal",
    "lastName": "Sayed",
    "country": "Egy",
    "cirt": "giza",
    "street": "123"
  }
}
```

### 🔑 Authentication bearer

| Param | value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | Type   |
| ----- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------ |
| token | eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwiZ2l2ZW5fbmFtZSI6IkJpbGFsIiwidW5pcXVlX25hbWUiOiJCaWxhbDEyMyIsImVtYWlsIjoiYmxhbGhhbWQ0OEBnbWFpbC5jb20iLCJyb2xlcyI6WyJBZG1pbiIsIlNlbmlvciIsIlRlYW1MZWFkIl0sInBlcm1pc3Npb25zIjpbIlVzZXJzOkdldEFsbCIsIlVzZXJzOkdldEJ5SWQiLCJVc2VyczpBZGQiLCJVc2VyczpFZGl0IiwiVXNlcnM6RGVsZXRlIiwiVXNlcnM6VW5Mb2NrIiwiUm9sZXM6R2V0QWxsIiwiUm9sZXM6R2V0QnlJZCIsIlJvbGVzOkFkZCIsIlJvbGVzOkVkaXQiLCJSb2xlczpEZWxldGUiLCJCYXNrZXRzOkdldEFsbCIsIkJhc2tldHM6R2V0QnlJZCIsIkJhc2tldHM6QWRkIiwiQmFza2V0czpFZGl0IiwiQmFza2V0czpEZWxldGUiLCJCcmFuZHM6R2V0QWxsIiwiQnJhbmRzOkdldEJ5SWQiLCJQcm9kdWN0czpHZXRBbGwiLCJQcm9kdWN0czpHZXRCeUlkIiwiUHJvZHVjdHM6QWRkIiwiUHJvZHVjdHM6RWRpdCIsIlByb2R1Y3RzOkRlbGV0ZSIsIlByb2R1Y3RUeXBlczpHZXRBbGwiLCJQcm9kdWN0VHlwZXM6R2V0QnlJZCIsIk9yZGVyczpDcmVhdGVPcmRlckFzeW5jIiwiT3JkZXJzOkdldE9yZGVyc0ZvclVzZXJBc3luYyIsIk9yZGVyczpHZXRPcmRlckJ5SWRBc3luYyIsIk9yZGVyczpHZXREZWxpdmVyeU1ldGhvZHNBc3luYyJdLCJuYmYiOjE3MzMxMDQ4MTgsImV4cCI6MTczMzEwNjYxOCwiaWF0IjoxNzMzMTA0ODE4LCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDUxIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMCJ9.RTpHXcsVD06pKp1GMOHasL37n1Hvmfe8bXlpBoU\_\_9A | string |

### Response: 500

```json
{
  "StatusCode": 404,
  "Message": "Basket is not exist",
  "Details": null
}
```

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

# 📁 Collection: Payments

## End-point: Get Payment

| **Name**     | **value** |
| ------------ | --------- |
| **BasketId** | **1**     |

### Method: POST

> ```
> {{BaseUrl}}/api/Payments/1
> ```

### 🔑 Authentication bearer

| Param | value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | Type   |
| ----- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------ |
| token | eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwiZ2l2ZW5fbmFtZSI6IkJpbGFsIiwidW5pcXVlX25hbWUiOiJCaWxhbDEyMyIsImVtYWlsIjoiYmxhbGhhbWQ0OEBnbWFpbC5jb20iLCJyb2xlcyI6WyJBZG1pbiIsIlNlbmlvciIsIlRlYW1MZWFkIl0sInBlcm1pc3Npb25zIjpbIlVzZXJzOkdldEFsbCIsIlVzZXJzOkdldEJ5SWQiLCJVc2VyczpBZGQiLCJVc2VyczpFZGl0IiwiVXNlcnM6RGVsZXRlIiwiVXNlcnM6VW5Mb2NrIiwiUm9sZXM6R2V0QWxsIiwiUm9sZXM6R2V0QnlJZCIsIlJvbGVzOkFkZCIsIlJvbGVzOkVkaXQiLCJSb2xlczpEZWxldGUiLCJCYXNrZXRzOkdldEFsbCIsIkJhc2tldHM6R2V0QnlJZCIsIkJhc2tldHM6QWRkIiwiQmFza2V0czpFZGl0IiwiQmFza2V0czpEZWxldGUiLCJCcmFuZHM6R2V0QWxsIiwiQnJhbmRzOkdldEJ5SWQiLCJQcm9kdWN0czpHZXRBbGwiLCJQcm9kdWN0czpHZXRCeUlkIiwiUHJvZHVjdHM6QWRkIiwiUHJvZHVjdHM6RWRpdCIsIlByb2R1Y3RzOkRlbGV0ZSIsIlByb2R1Y3RUeXBlczpHZXRBbGwiLCJQcm9kdWN0VHlwZXM6R2V0QnlJZCIsIk9yZGVyczpDcmVhdGVPcmRlckFzeW5jIiwiT3JkZXJzOkdldE9yZGVyc0ZvclVzZXJBc3luYyIsIk9yZGVyczpHZXRPcmRlckJ5SWRBc3luYyIsIk9yZGVyczpHZXREZWxpdmVyeU1ldGhvZHNBc3luYyJdLCJuYmYiOjE3MzMxMDQ4MTgsImV4cCI6MTczMzEwNjYxOCwiaWF0IjoxNzMzMTA0ODE4LCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDUxIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMCJ9.RTpHXcsVD06pKp1GMOHasL37n1Hvmfe8bXlpBoU\_\_9A | string |

### Response: 500

```json
{
  "StatusCode": 0,
  "Message": "The amount must be greater than or equal to the minimum charge amount allowed for your account and the currency set (https://docs.stripe.com/currencies#minimum-and-maximum-charge-amounts).  If you want to save a Payment Method for future use without an immediate payment, use a Setup Intent instead: https://docs.stripe.com/payments/setup-intents",
  "Details": null
}
```

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

## End-point: test

#### Description

---

this is for you to authenticate and enable you from access resources

#### Body

---

```json
{
  "email": "user@example.com",
  "password": "!?:xW>gFxV_?/27tQsJV<\"Lg8_j.VZhgMKw9MdXS=R"
}
```

### Example

---

#### `Request`

```bash
curl  --location '{{Baseurl}}/api/Authentication/Login' \
  -data-row '{
  "email": "user@example.com",
  "password": "!?:xW>gFxV_?/27tQsJV<\"Lg8_j.VZhgMKw9MdXS=R"
}'

```

`success Response`

```json
{
  "firstName": "string",
  "lastName": "string",
  "email": "string",
  "token": "string",
  "expireIn": 0,
  "refreshToken": "string",
  "refreshTokenExpiration": "2024-12-02T06:11:43.962Z"
}
```

`Bad Request`

```json
{
  "statusCode": 0,
  "message": "string",
  "details": "string"
}
```

### Method: POST

> ```
> {{BaseUrl}}/api/tests/test
> ```

### Body (**raw**)

```json

```

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

# 📁 Collection: Roles

## End-point: Get All Roles

### Method: GET

> ```
> {{BaseUrl}}/api/Roles?IncludeDeleted=false
> ```

### Query Params

| Param          | value |
| -------------- | ----- |
| IncludeDeleted | false |

### 🔑 Authentication bearer

| Param | value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | Type   |
| ----- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------ |
| token | eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwiZ2l2ZW5fbmFtZSI6IkJpbGFsIiwidW5pcXVlX25hbWUiOiJCaWxhbDEyMyIsImVtYWlsIjoiYmxhbGhhbWQ0OEBnbWFpbC5jb20iLCJyb2xlcyI6WyJBZG1pbiIsIlNlbmlvciIsIlRlYW1MZWFkIl0sInBlcm1pc3Npb25zIjpbIlVzZXJzOkdldEFsbCIsIlVzZXJzOkdldEJ5SWQiLCJVc2VyczpBZGQiLCJVc2VyczpFZGl0IiwiVXNlcnM6RGVsZXRlIiwiVXNlcnM6VW5Mb2NrIiwiUm9sZXM6R2V0QWxsIiwiUm9sZXM6R2V0QnlJZCIsIlJvbGVzOkFkZCIsIlJvbGVzOkVkaXQiLCJSb2xlczpEZWxldGUiLCJCYXNrZXRzOkdldEFsbCIsIkJhc2tldHM6R2V0QnlJZCIsIkJhc2tldHM6QWRkIiwiQmFza2V0czpFZGl0IiwiQmFza2V0czpEZWxldGUiLCJCcmFuZHM6R2V0QWxsIiwiQnJhbmRzOkdldEJ5SWQiLCJQcm9kdWN0czpHZXRBbGwiLCJQcm9kdWN0czpHZXRCeUlkIiwiUHJvZHVjdHM6QWRkIiwiUHJvZHVjdHM6RWRpdCIsIlByb2R1Y3RzOkRlbGV0ZSIsIlByb2R1Y3RUeXBlczpHZXRBbGwiLCJQcm9kdWN0VHlwZXM6R2V0QnlJZCIsIk9yZGVyczpDcmVhdGVPcmRlckFzeW5jIiwiT3JkZXJzOkdldE9yZGVyc0ZvclVzZXJBc3luYyIsIk9yZGVyczpHZXRPcmRlckJ5SWRBc3luYyIsIk9yZGVyczpHZXREZWxpdmVyeU1ldGhvZHNBc3luYyJdLCJuYmYiOjE3MzMxMTQxMDYsImV4cCI6MTczMzExNTkwNiwiaWF0IjoxNzMzMTE0MTA2LCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDUxIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMCJ9.EDaeCPrEzDjhXING_ajJRIsUbsLv1TIE4YiYCF8WSPg | string |

### Response: 200

```json
[
  {
    "id": 1,
    "name": "Admin",
    "isDeleted": false,
    "permissions": null
  },
  {
    "id": 2,
    "name": "HR",
    "isDeleted": false,
    "permissions": null
  },
  {
    "id": 3,
    "name": "Manager",
    "isDeleted": false,
    "permissions": null
  },
  {
    "id": 4,
    "name": "Member",
    "isDeleted": false,
    "permissions": null
  },
  {
    "id": 5,
    "name": "Senior",
    "isDeleted": false,
    "permissions": null
  },
  {
    "id": 6,
    "name": "TeamLead",
    "isDeleted": false,
    "permissions": null
  },
  {
    "id": 8,
    "name": "CEO",
    "isDeleted": false,
    "permissions": null
  }
]
```

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

## End-point: Get Role

##### Response

---

```json
{
  "id": 0,
  "name": "string",
  "isDeleted": true,
  "permissions": ["string"]
}
```

### Method: GET

> ```
> {{BaseUrl}}/api/Roles/GetById/1
> ```

### 🔑 Authentication bearer

| Param | value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | Type   |
| ----- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------ |
| token | eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwiZ2l2ZW5fbmFtZSI6IkJpbGFsIiwidW5pcXVlX25hbWUiOiJCaWxhbDEyMyIsImVtYWlsIjoiYmxhbGhhbWQ0OEBnbWFpbC5jb20iLCJyb2xlcyI6WyJBZG1pbiIsIlNlbmlvciIsIlRlYW1MZWFkIl0sInBlcm1pc3Npb25zIjpbIlVzZXJzOkdldEFsbCIsIlVzZXJzOkdldEJ5SWQiLCJVc2VyczpBZGQiLCJVc2VyczpFZGl0IiwiVXNlcnM6RGVsZXRlIiwiVXNlcnM6VW5Mb2NrIiwiUm9sZXM6R2V0QWxsIiwiUm9sZXM6R2V0QnlJZCIsIlJvbGVzOkFkZCIsIlJvbGVzOkVkaXQiLCJSb2xlczpEZWxldGUiLCJCYXNrZXRzOkdldEFsbCIsIkJhc2tldHM6R2V0QnlJZCIsIkJhc2tldHM6QWRkIiwiQmFza2V0czpFZGl0IiwiQmFza2V0czpEZWxldGUiLCJCcmFuZHM6R2V0QWxsIiwiQnJhbmRzOkdldEJ5SWQiLCJQcm9kdWN0czpHZXRBbGwiLCJQcm9kdWN0czpHZXRCeUlkIiwiUHJvZHVjdHM6QWRkIiwiUHJvZHVjdHM6RWRpdCIsIlByb2R1Y3RzOkRlbGV0ZSIsIlByb2R1Y3RUeXBlczpHZXRBbGwiLCJQcm9kdWN0VHlwZXM6R2V0QnlJZCIsIk9yZGVyczpDcmVhdGVPcmRlckFzeW5jIiwiT3JkZXJzOkdldE9yZGVyc0ZvclVzZXJBc3luYyIsIk9yZGVyczpHZXRPcmRlckJ5SWRBc3luYyIsIk9yZGVyczpHZXREZWxpdmVyeU1ldGhvZHNBc3luYyJdLCJuYmYiOjE3MzMxMTQxMDYsImV4cCI6MTczMzExNTkwNiwiaWF0IjoxNzMzMTE0MTA2LCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDUxIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMCJ9.EDaeCPrEzDjhXING_ajJRIsUbsLv1TIE4YiYCF8WSPg | string |

### Response: 200

```json
{
  "id": 1,
  "name": "Admin",
  "isDeleted": false,
  "permissions": null
}
```

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

## End-point: Add Role

##### Response

---

```json
{
  "id": 0,
  "name": "string",
  "isDeleted": true,
  "permissions": ["string"]
}
```

### Method: POST

> ```
> {{BaseUrl}}/api/Roles
> ```

### Body (**raw**)

```json
{
  "name": "submanager",
  "permissions": ["Users:GetAll"]
}
```

### 🔑 Authentication bearer

| Param | value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | Type   |
| ----- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------ |
| token | eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwiZ2l2ZW5fbmFtZSI6IkJpbGFsIiwidW5pcXVlX25hbWUiOiJCaWxhbDEyMyIsImVtYWlsIjoiYmxhbGhhbWQ0OEBnbWFpbC5jb20iLCJyb2xlcyI6WyJBZG1pbiIsIlNlbmlvciIsIlRlYW1MZWFkIl0sInBlcm1pc3Npb25zIjpbIlVzZXJzOkdldEFsbCIsIlVzZXJzOkdldEJ5SWQiLCJVc2VyczpBZGQiLCJVc2VyczpFZGl0IiwiVXNlcnM6RGVsZXRlIiwiVXNlcnM6VW5Mb2NrIiwiUm9sZXM6R2V0QWxsIiwiUm9sZXM6R2V0QnlJZCIsIlJvbGVzOkFkZCIsIlJvbGVzOkVkaXQiLCJSb2xlczpEZWxldGUiLCJCYXNrZXRzOkdldEFsbCIsIkJhc2tldHM6R2V0QnlJZCIsIkJhc2tldHM6QWRkIiwiQmFza2V0czpFZGl0IiwiQmFza2V0czpEZWxldGUiLCJCcmFuZHM6R2V0QWxsIiwiQnJhbmRzOkdldEJ5SWQiLCJQcm9kdWN0czpHZXRBbGwiLCJQcm9kdWN0czpHZXRCeUlkIiwiUHJvZHVjdHM6QWRkIiwiUHJvZHVjdHM6RWRpdCIsIlByb2R1Y3RzOkRlbGV0ZSIsIlByb2R1Y3RUeXBlczpHZXRBbGwiLCJQcm9kdWN0VHlwZXM6R2V0QnlJZCIsIk9yZGVyczpDcmVhdGVPcmRlckFzeW5jIiwiT3JkZXJzOkdldE9yZGVyc0ZvclVzZXJBc3luYyIsIk9yZGVyczpHZXRPcmRlckJ5SWRBc3luYyIsIk9yZGVyczpHZXREZWxpdmVyeU1ldGhvZHNBc3luYyJdLCJuYmYiOjE3MzMxMTQxMDYsImV4cCI6MTczMzExNTkwNiwiaWF0IjoxNzMzMTE0MTA2LCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDUxIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMCJ9.EDaeCPrEzDjhXING_ajJRIsUbsLv1TIE4YiYCF8WSPg | string |

### Response: 200

```json
{
  "id": 9,
  "name": "submanager",
  "isDeleted": false,
  "permissions": ["Users:GetAll"]
}
```

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

## End-point: Update Role

### Method: PUT

> ```
> {{BaseUrl}}/api/Roles/Edit/9
> ```

### Body (**raw**)

```json
{
  "name": "submanager",
  "permissions": ["Users:GetAll"]
}
```

### 🔑 Authentication bearer

| Param | value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | Type   |
| ----- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------ |
| token | eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwiZ2l2ZW5fbmFtZSI6IkJpbGFsIiwidW5pcXVlX25hbWUiOiJCaWxhbDEyMyIsImVtYWlsIjoiYmxhbGhhbWQ0OEBnbWFpbC5jb20iLCJyb2xlcyI6WyJBZG1pbiIsIlNlbmlvciIsIlRlYW1MZWFkIl0sInBlcm1pc3Npb25zIjpbIlVzZXJzOkdldEFsbCIsIlVzZXJzOkdldEJ5SWQiLCJVc2VyczpBZGQiLCJVc2VyczpFZGl0IiwiVXNlcnM6RGVsZXRlIiwiVXNlcnM6VW5Mb2NrIiwiUm9sZXM6R2V0QWxsIiwiUm9sZXM6R2V0QnlJZCIsIlJvbGVzOkFkZCIsIlJvbGVzOkVkaXQiLCJSb2xlczpEZWxldGUiLCJCYXNrZXRzOkdldEFsbCIsIkJhc2tldHM6R2V0QnlJZCIsIkJhc2tldHM6QWRkIiwiQmFza2V0czpFZGl0IiwiQmFza2V0czpEZWxldGUiLCJCcmFuZHM6R2V0QWxsIiwiQnJhbmRzOkdldEJ5SWQiLCJQcm9kdWN0czpHZXRBbGwiLCJQcm9kdWN0czpHZXRCeUlkIiwiUHJvZHVjdHM6QWRkIiwiUHJvZHVjdHM6RWRpdCIsIlByb2R1Y3RzOkRlbGV0ZSIsIlByb2R1Y3RUeXBlczpHZXRBbGwiLCJQcm9kdWN0VHlwZXM6R2V0QnlJZCIsIk9yZGVyczpDcmVhdGVPcmRlckFzeW5jIiwiT3JkZXJzOkdldE9yZGVyc0ZvclVzZXJBc3luYyIsIk9yZGVyczpHZXRPcmRlckJ5SWRBc3luYyIsIk9yZGVyczpHZXREZWxpdmVyeU1ldGhvZHNBc3luYyJdLCJuYmYiOjE3MzMxMTQxMDYsImV4cCI6MTczMzExNTkwNiwiaWF0IjoxNzMzMTE0MTA2LCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDUxIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMCJ9.EDaeCPrEzDjhXING_ajJRIsUbsLv1TIE4YiYCF8WSPg | string |

### Response: 200

```json
{
  "id": 9,
  "name": "submanager",
  "isDeleted": false,
  "permissions": ["Users:GetAll"]
}
```

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

## End-point: Delete Role

#### Response

---

| **Code** | **Description** |
| -------- | --------------- |
| 200      | success         |

### Method: DELETE

> ```
> {{BaseUrl}}/api/Roles/Delete/9
> ```

### 🔑 Authentication bearer

| Param | value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | Type   |
| ----- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------ |
| token | eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwiZ2l2ZW5fbmFtZSI6IkJpbGFsIiwidW5pcXVlX25hbWUiOiJCaWxhbDEyMyIsImVtYWlsIjoiYmxhbGhhbWQ0OEBnbWFpbC5jb20iLCJyb2xlcyI6WyJBZG1pbiIsIlNlbmlvciIsIlRlYW1MZWFkIl0sInBlcm1pc3Npb25zIjpbIlVzZXJzOkdldEFsbCIsIlVzZXJzOkdldEJ5SWQiLCJVc2VyczpBZGQiLCJVc2VyczpFZGl0IiwiVXNlcnM6RGVsZXRlIiwiVXNlcnM6VW5Mb2NrIiwiUm9sZXM6R2V0QWxsIiwiUm9sZXM6R2V0QnlJZCIsIlJvbGVzOkFkZCIsIlJvbGVzOkVkaXQiLCJSb2xlczpEZWxldGUiLCJCYXNrZXRzOkdldEFsbCIsIkJhc2tldHM6R2V0QnlJZCIsIkJhc2tldHM6QWRkIiwiQmFza2V0czpFZGl0IiwiQmFza2V0czpEZWxldGUiLCJCcmFuZHM6R2V0QWxsIiwiQnJhbmRzOkdldEJ5SWQiLCJQcm9kdWN0czpHZXRBbGwiLCJQcm9kdWN0czpHZXRCeUlkIiwiUHJvZHVjdHM6QWRkIiwiUHJvZHVjdHM6RWRpdCIsIlByb2R1Y3RzOkRlbGV0ZSIsIlByb2R1Y3RUeXBlczpHZXRBbGwiLCJQcm9kdWN0VHlwZXM6R2V0QnlJZCIsIk9yZGVyczpDcmVhdGVPcmRlckFzeW5jIiwiT3JkZXJzOkdldE9yZGVyc0ZvclVzZXJBc3luYyIsIk9yZGVyczpHZXRPcmRlckJ5SWRBc3luYyIsIk9yZGVyczpHZXREZWxpdmVyeU1ldGhvZHNBc3luYyJdLCJuYmYiOjE3MzMxMTQxMDYsImV4cCI6MTczMzExNTkwNiwiaWF0IjoxNzMzMTE0MTA2LCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDUxIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMCJ9.EDaeCPrEzDjhXING_ajJRIsUbsLv1TIE4YiYCF8WSPg | string |

### Response: 200

```json
null
```

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

# 📁 Collection: Users

## End-point: Get All Users

#### Response

---

```json
[
  {
    "id": 0,
    "firstName": "string",
    "lastName": "string",
    "email": "string",
    "isDisabled": true,
    "roles": ["string"]
  }
]
```

### Method: GET

> ```
> {{BaseUrl}}/api/Users
> ```

### 🔑 Authentication bearer

| Param | value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | Type   |
| ----- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------ |
| token | eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwiZ2l2ZW5fbmFtZSI6IkJpbGFsIiwidW5pcXVlX25hbWUiOiJCaWxhbDEyMyIsImVtYWlsIjoiYmxhbGhhbWQ0OEBnbWFpbC5jb20iLCJyb2xlcyI6WyJBZG1pbiIsIlNlbmlvciIsIlRlYW1MZWFkIl0sInBlcm1pc3Npb25zIjpbIlVzZXJzOkdldEFsbCIsIlVzZXJzOkdldEJ5SWQiLCJVc2VyczpBZGQiLCJVc2VyczpFZGl0IiwiVXNlcnM6RGVsZXRlIiwiVXNlcnM6VW5Mb2NrIiwiUm9sZXM6R2V0QWxsIiwiUm9sZXM6R2V0QnlJZCIsIlJvbGVzOkFkZCIsIlJvbGVzOkVkaXQiLCJSb2xlczpEZWxldGUiLCJCYXNrZXRzOkdldEFsbCIsIkJhc2tldHM6R2V0QnlJZCIsIkJhc2tldHM6QWRkIiwiQmFza2V0czpFZGl0IiwiQmFza2V0czpEZWxldGUiLCJCcmFuZHM6R2V0QWxsIiwiQnJhbmRzOkdldEJ5SWQiLCJQcm9kdWN0czpHZXRBbGwiLCJQcm9kdWN0czpHZXRCeUlkIiwiUHJvZHVjdHM6QWRkIiwiUHJvZHVjdHM6RWRpdCIsIlByb2R1Y3RzOkRlbGV0ZSIsIlByb2R1Y3RUeXBlczpHZXRBbGwiLCJQcm9kdWN0VHlwZXM6R2V0QnlJZCIsIk9yZGVyczpDcmVhdGVPcmRlckFzeW5jIiwiT3JkZXJzOkdldE9yZGVyc0ZvclVzZXJBc3luYyIsIk9yZGVyczpHZXRPcmRlckJ5SWRBc3luYyIsIk9yZGVyczpHZXREZWxpdmVyeU1ldGhvZHNBc3luYyJdLCJuYmYiOjE3MzMxMTQxMDYsImV4cCI6MTczMzExNTkwNiwiaWF0IjoxNzMzMTE0MTA2LCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDUxIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMCJ9.EDaeCPrEzDjhXING_ajJRIsUbsLv1TIE4YiYCF8WSPg | string |

### Response: 200

```json
[
  {
    "id": 1,
    "firstName": "Bilal",
    "lastName": "Sayed",
    "email": "blalhamd48@gmail.com",
    "isDisabled": false,
    "roles": ["Admin", "Senior", "TeamLead"]
  },
  {
    "id": 3,
    "firstName": "Ahmed",
    "lastName": "Khatab",
    "email": "AhmedKhatab45@gmail.com",
    "isDisabled": false,
    "roles": []
  },
  {
    "id": 4,
    "firstName": "Admin",
    "lastName": "Admin",
    "email": "Admin48@gmail.com",
    "isDisabled": false,
    "roles": ["Admin"]
  },
  {
    "id": 5,
    "firstName": "Khaled",
    "lastName": "Nady",
    "email": "blalsy682@gmail.com",
    "isDisabled": false,
    "roles": ["Senior"]
  },
  {
    "id": 6,
    "firstName": "Shimaa",
    "lastName": "Sayed",
    "email": "Shimaa48@gmail.com",
    "isDisabled": false,
    "roles": ["Member"]
  },
  {
    "id": 7,
    "firstName": "Tameem",
    "lastName": "Mohamed",
    "email": "Tameem48@gmail.com",
    "isDisabled": false,
    "roles": ["Member"]
  },
  {
    "id": 11,
    "firstName": "blal",
    "lastName": "sy",
    "email": "blalsy681@gmail.com",
    "isDisabled": false,
    "roles": ["Member"]
  },
  {
    "id": 1009,
    "firstName": "Ahmed",
    "lastName": "Abdo",
    "email": "Ahmed34@gmail.com",
    "isDisabled": false,
    "roles": []
  }
]
```

### Response: 200

```json
[
  {
    "id": 1,
    "firstName": "Bilal",
    "lastName": "Sayed",
    "email": "blalhamd48@gmail.com",
    "isDisabled": false,
    "roles": ["Admin", "Senior", "TeamLead"]
  },
  {
    "id": 3,
    "firstName": "Ahmed",
    "lastName": "Khatab",
    "email": "AhmedKhatab45@gmail.com",
    "isDisabled": false,
    "roles": []
  },
  {
    "id": 4,
    "firstName": "Admin",
    "lastName": "Admin",
    "email": "Admin48@gmail.com",
    "isDisabled": false,
    "roles": ["Admin"]
  },
  {
    "id": 5,
    "firstName": "Khaled",
    "lastName": "Nady",
    "email": "blalsy682@gmail.com",
    "isDisabled": false,
    "roles": ["Senior"]
  },
  {
    "id": 6,
    "firstName": "Shimaa",
    "lastName": "Sayed",
    "email": "Shimaa48@gmail.com",
    "isDisabled": false,
    "roles": ["Member"]
  },
  {
    "id": 7,
    "firstName": "Tameem",
    "lastName": "Mohamed",
    "email": "Tameem48@gmail.com",
    "isDisabled": false,
    "roles": ["Member"]
  },
  {
    "id": 11,
    "firstName": "blal",
    "lastName": "sy",
    "email": "blalsy681@gmail.com",
    "isDisabled": false,
    "roles": ["Member"]
  },
  {
    "id": 1009,
    "firstName": "Ahmed",
    "lastName": "Abdo",
    "email": "Ahmed34@gmail.com",
    "isDisabled": false,
    "roles": []
  }
]
```

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

## End-point: Get User

#### Response

---

```json
{
  "id": 0,
  "firstName": "string",
  "lastName": "string",
  "email": "string",
  "isDisabled": true,
  "roles": ["string"]
}
```

### Method: GET

> ```
> {{BaseUrl}}/api/Users/GetById/1
> ```

### 🔑 Authentication bearer

| Param | value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | Type   |
| ----- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------ |
| token | eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwiZ2l2ZW5fbmFtZSI6IkJpbGFsIiwidW5pcXVlX25hbWUiOiJCaWxhbDEyMyIsImVtYWlsIjoiYmxhbGhhbWQ0OEBnbWFpbC5jb20iLCJyb2xlcyI6WyJBZG1pbiIsIlNlbmlvciIsIlRlYW1MZWFkIl0sInBlcm1pc3Npb25zIjpbIlVzZXJzOkdldEFsbCIsIlVzZXJzOkdldEJ5SWQiLCJVc2VyczpBZGQiLCJVc2VyczpFZGl0IiwiVXNlcnM6RGVsZXRlIiwiVXNlcnM6VW5Mb2NrIiwiUm9sZXM6R2V0QWxsIiwiUm9sZXM6R2V0QnlJZCIsIlJvbGVzOkFkZCIsIlJvbGVzOkVkaXQiLCJSb2xlczpEZWxldGUiLCJCYXNrZXRzOkdldEFsbCIsIkJhc2tldHM6R2V0QnlJZCIsIkJhc2tldHM6QWRkIiwiQmFza2V0czpFZGl0IiwiQmFza2V0czpEZWxldGUiLCJCcmFuZHM6R2V0QWxsIiwiQnJhbmRzOkdldEJ5SWQiLCJQcm9kdWN0czpHZXRBbGwiLCJQcm9kdWN0czpHZXRCeUlkIiwiUHJvZHVjdHM6QWRkIiwiUHJvZHVjdHM6RWRpdCIsIlByb2R1Y3RzOkRlbGV0ZSIsIlByb2R1Y3RUeXBlczpHZXRBbGwiLCJQcm9kdWN0VHlwZXM6R2V0QnlJZCIsIk9yZGVyczpDcmVhdGVPcmRlckFzeW5jIiwiT3JkZXJzOkdldE9yZGVyc0ZvclVzZXJBc3luYyIsIk9yZGVyczpHZXRPcmRlckJ5SWRBc3luYyIsIk9yZGVyczpHZXREZWxpdmVyeU1ldGhvZHNBc3luYyJdLCJuYmYiOjE3MzMxMTQxMDYsImV4cCI6MTczMzExNTkwNiwiaWF0IjoxNzMzMTE0MTA2LCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDUxIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMCJ9.EDaeCPrEzDjhXING_ajJRIsUbsLv1TIE4YiYCF8WSPg | string |

### Response: 200

```json
{
  "id": 1,
  "firstName": "Bilal",
  "lastName": "Sayed",
  "email": "blalhamd48@gmail.com",
  "isDisabled": false,
  "roles": ["Admin", "Senior", "TeamLead"]
}
```

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

## End-point: Add User

#### Response

---

```json
{
  "id": 0,
  "firstName": "string",
  "lastName": "string",
  "email": "string",
  "isDisabled": true,
  "roles": ["string"]
}
```

### Method: POST

> ```
> {{BaseUrl}}/api/Users
> ```

### Body (**raw**)

```json
{
  "firstName": "John",
  "lastName": "Johny",
  "email": "user@example.com",
  "password": "[<coboAM}Y@z%7ECex'A8>_ki}X\"z,Y PUEx(QlD,p3\\lekK/SD!C-o6B_?#d#S&-Z=WU%XcrM[we`t'|&;ZsMq>pw0D",
  "roles": ["string"]
}
```

### 🔑 Authentication bearer

| Param | value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | Type   |
| ----- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------ |
| token | eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwiZ2l2ZW5fbmFtZSI6IkJpbGFsIiwidW5pcXVlX25hbWUiOiJCaWxhbDEyMyIsImVtYWlsIjoiYmxhbGhhbWQ0OEBnbWFpbC5jb20iLCJyb2xlcyI6WyJBZG1pbiIsIlNlbmlvciIsIlRlYW1MZWFkIl0sInBlcm1pc3Npb25zIjpbIlVzZXJzOkdldEFsbCIsIlVzZXJzOkdldEJ5SWQiLCJVc2VyczpBZGQiLCJVc2VyczpFZGl0IiwiVXNlcnM6RGVsZXRlIiwiVXNlcnM6VW5Mb2NrIiwiUm9sZXM6R2V0QWxsIiwiUm9sZXM6R2V0QnlJZCIsIlJvbGVzOkFkZCIsIlJvbGVzOkVkaXQiLCJSb2xlczpEZWxldGUiLCJCYXNrZXRzOkdldEFsbCIsIkJhc2tldHM6R2V0QnlJZCIsIkJhc2tldHM6QWRkIiwiQmFza2V0czpFZGl0IiwiQmFza2V0czpEZWxldGUiLCJCcmFuZHM6R2V0QWxsIiwiQnJhbmRzOkdldEJ5SWQiLCJQcm9kdWN0czpHZXRBbGwiLCJQcm9kdWN0czpHZXRCeUlkIiwiUHJvZHVjdHM6QWRkIiwiUHJvZHVjdHM6RWRpdCIsIlByb2R1Y3RzOkRlbGV0ZSIsIlByb2R1Y3RUeXBlczpHZXRBbGwiLCJQcm9kdWN0VHlwZXM6R2V0QnlJZCIsIk9yZGVyczpDcmVhdGVPcmRlckFzeW5jIiwiT3JkZXJzOkdldE9yZGVyc0ZvclVzZXJBc3luYyIsIk9yZGVyczpHZXRPcmRlckJ5SWRBc3luYyIsIk9yZGVyczpHZXREZWxpdmVyeU1ldGhvZHNBc3luYyJdLCJuYmYiOjE3MzMxMTQxMDYsImV4cCI6MTczMzExNTkwNiwiaWF0IjoxNzMzMTE0MTA2LCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDUxIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMCJ9.EDaeCPrEzDjhXING_ajJRIsUbsLv1TIE4YiYCF8WSPg | string |

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

## End-point: Update User

#### Response

---

```json
{
  "id": 0,
  "firstName": "string",
  "lastName": "string",
  "email": "string",
  "isDisabled": true,
  "roles": ["string"]
}
```

### Method: PUT

> ```
> {{BaseUrl}}/api/Users/20
> ```

### Body (**raw**)

```json
{
  "firstName": "John",
  "lastName": "Johny",
  "email": "user@example.com",
  "password": "[<coboAM}Y@z%7ECex'A8>_ki}X\"",
  "roles": ["string"]
}
```

### 🔑 Authentication bearer

| Param | value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | Type   |
| ----- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------ |
| token | eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwiZ2l2ZW5fbmFtZSI6IkJpbGFsIiwidW5pcXVlX25hbWUiOiJCaWxhbDEyMyIsImVtYWlsIjoiYmxhbGhhbWQ0OEBnbWFpbC5jb20iLCJyb2xlcyI6WyJBZG1pbiIsIlNlbmlvciIsIlRlYW1MZWFkIl0sInBlcm1pc3Npb25zIjpbIlVzZXJzOkdldEFsbCIsIlVzZXJzOkdldEJ5SWQiLCJVc2VyczpBZGQiLCJVc2VyczpFZGl0IiwiVXNlcnM6RGVsZXRlIiwiVXNlcnM6VW5Mb2NrIiwiUm9sZXM6R2V0QWxsIiwiUm9sZXM6R2V0QnlJZCIsIlJvbGVzOkFkZCIsIlJvbGVzOkVkaXQiLCJSb2xlczpEZWxldGUiLCJCYXNrZXRzOkdldEFsbCIsIkJhc2tldHM6R2V0QnlJZCIsIkJhc2tldHM6QWRkIiwiQmFza2V0czpFZGl0IiwiQmFza2V0czpEZWxldGUiLCJCcmFuZHM6R2V0QWxsIiwiQnJhbmRzOkdldEJ5SWQiLCJQcm9kdWN0czpHZXRBbGwiLCJQcm9kdWN0czpHZXRCeUlkIiwiUHJvZHVjdHM6QWRkIiwiUHJvZHVjdHM6RWRpdCIsIlByb2R1Y3RzOkRlbGV0ZSIsIlByb2R1Y3RUeXBlczpHZXRBbGwiLCJQcm9kdWN0VHlwZXM6R2V0QnlJZCIsIk9yZGVyczpDcmVhdGVPcmRlckFzeW5jIiwiT3JkZXJzOkdldE9yZGVyc0ZvclVzZXJBc3luYyIsIk9yZGVyczpHZXRPcmRlckJ5SWRBc3luYyIsIk9yZGVyczpHZXREZWxpdmVyeU1ldGhvZHNBc3luYyJdLCJuYmYiOjE3MzMxMTQxMDYsImV4cCI6MTczMzExNTkwNiwiaWF0IjoxNzMzMTE0MTA2LCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDUxIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMCJ9.EDaeCPrEzDjhXING_ajJRIsUbsLv1TIE4YiYCF8WSPg | string |

### Response: 500

```json
{
  "StatusCode": 404,
  "Message": "User not found",
  "Details": null
}
```

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

## End-point: UnLock

#### Response

| **Code** | **Description** |
| -------- | --------------- |
| 200      | Success         |

### Method: PUT

> ```
> {{BaseUrl}}/api/Users/UnLock/20
> ```

### 🔑 Authentication bearer

| Param | value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | Type   |
| ----- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------ |
| token | eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwiZ2l2ZW5fbmFtZSI6IkJpbGFsIiwidW5pcXVlX25hbWUiOiJCaWxhbDEyMyIsImVtYWlsIjoiYmxhbGhhbWQ0OEBnbWFpbC5jb20iLCJyb2xlcyI6WyJBZG1pbiIsIlNlbmlvciIsIlRlYW1MZWFkIl0sInBlcm1pc3Npb25zIjpbIlVzZXJzOkdldEFsbCIsIlVzZXJzOkdldEJ5SWQiLCJVc2VyczpBZGQiLCJVc2VyczpFZGl0IiwiVXNlcnM6RGVsZXRlIiwiVXNlcnM6VW5Mb2NrIiwiUm9sZXM6R2V0QWxsIiwiUm9sZXM6R2V0QnlJZCIsIlJvbGVzOkFkZCIsIlJvbGVzOkVkaXQiLCJSb2xlczpEZWxldGUiLCJCYXNrZXRzOkdldEFsbCIsIkJhc2tldHM6R2V0QnlJZCIsIkJhc2tldHM6QWRkIiwiQmFza2V0czpFZGl0IiwiQmFza2V0czpEZWxldGUiLCJCcmFuZHM6R2V0QWxsIiwiQnJhbmRzOkdldEJ5SWQiLCJQcm9kdWN0czpHZXRBbGwiLCJQcm9kdWN0czpHZXRCeUlkIiwiUHJvZHVjdHM6QWRkIiwiUHJvZHVjdHM6RWRpdCIsIlByb2R1Y3RzOkRlbGV0ZSIsIlByb2R1Y3RUeXBlczpHZXRBbGwiLCJQcm9kdWN0VHlwZXM6R2V0QnlJZCIsIk9yZGVyczpDcmVhdGVPcmRlckFzeW5jIiwiT3JkZXJzOkdldE9yZGVyc0ZvclVzZXJBc3luYyIsIk9yZGVyczpHZXRPcmRlckJ5SWRBc3luYyIsIk9yZGVyczpHZXREZWxpdmVyeU1ldGhvZHNBc3luYyJdLCJuYmYiOjE3MzMxMTQxMDYsImV4cCI6MTczMzExNTkwNiwiaWF0IjoxNzMzMTE0MTA2LCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDUxIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMCJ9.EDaeCPrEzDjhXING_ajJRIsUbsLv1TIE4YiYCF8WSPg | string |

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

## End-point: Delete User

#### Response

---

| **Code** | **Description** |
| -------- | --------------- |
| 200      | success         |

### Method: DELETE

> ```
> {{BaseUrl}}/api/Users/20
> ```

### 🔑 Authentication bearer

| Param | value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | Type   |
| ----- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------ |
| token | eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwiZ2l2ZW5fbmFtZSI6IkJpbGFsIiwidW5pcXVlX25hbWUiOiJCaWxhbDEyMyIsImVtYWlsIjoiYmxhbGhhbWQ0OEBnbWFpbC5jb20iLCJyb2xlcyI6WyJBZG1pbiIsIlNlbmlvciIsIlRlYW1MZWFkIl0sInBlcm1pc3Npb25zIjpbIlVzZXJzOkdldEFsbCIsIlVzZXJzOkdldEJ5SWQiLCJVc2VyczpBZGQiLCJVc2VyczpFZGl0IiwiVXNlcnM6RGVsZXRlIiwiVXNlcnM6VW5Mb2NrIiwiUm9sZXM6R2V0QWxsIiwiUm9sZXM6R2V0QnlJZCIsIlJvbGVzOkFkZCIsIlJvbGVzOkVkaXQiLCJSb2xlczpEZWxldGUiLCJCYXNrZXRzOkdldEFsbCIsIkJhc2tldHM6R2V0QnlJZCIsIkJhc2tldHM6QWRkIiwiQmFza2V0czpFZGl0IiwiQmFza2V0czpEZWxldGUiLCJCcmFuZHM6R2V0QWxsIiwiQnJhbmRzOkdldEJ5SWQiLCJQcm9kdWN0czpHZXRBbGwiLCJQcm9kdWN0czpHZXRCeUlkIiwiUHJvZHVjdHM6QWRkIiwiUHJvZHVjdHM6RWRpdCIsIlByb2R1Y3RzOkRlbGV0ZSIsIlByb2R1Y3RUeXBlczpHZXRBbGwiLCJQcm9kdWN0VHlwZXM6R2V0QnlJZCIsIk9yZGVyczpDcmVhdGVPcmRlckFzeW5jIiwiT3JkZXJzOkdldE9yZGVyc0ZvclVzZXJBc3luYyIsIk9yZGVyczpHZXRPcmRlckJ5SWRBc3luYyIsIk9yZGVyczpHZXREZWxpdmVyeU1ldGhvZHNBc3luYyJdLCJuYmYiOjE3MzMxMTc0NjcsImV4cCI6MTczMzExOTI2NywiaWF0IjoxNzMzMTE3NDY3LCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDUxIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMCJ9.u7Wr6GzJDZBL-shVnJxzBsufL_h9UVHYmRw1DPc-g1M | string |

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

# 📁 Collection: Baskets

## End-point: Get Basket

#### Response

```coffeescript
{
  "id": "string",
  "items": [
    {
      "id": 0,
      "name": "string",
      "pictureUrl": "string",
      "price": 0.1,
      "quantity": 2147483647,
      "brand": "string",
      "type": "string"
    }
  ],
  "deliveryMethodId": 0,
  "shippingCost": 0,
  "paymentIntentId": "string",
  "clientSecret": "string"
}

```

### Method: GET

> ```
> {{BaseUrl}}/api/Baskets/20
> ```

### 🔑 Authentication bearer

| Param | value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | Type   |
| ----- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------ |
| token | eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwiZ2l2ZW5fbmFtZSI6IkJpbGFsIiwidW5pcXVlX25hbWUiOiJCaWxhbDEyMyIsImVtYWlsIjoiYmxhbGhhbWQ0OEBnbWFpbC5jb20iLCJyb2xlcyI6WyJBZG1pbiIsIlNlbmlvciIsIlRlYW1MZWFkIl0sInBlcm1pc3Npb25zIjpbIlVzZXJzOkdldEFsbCIsIlVzZXJzOkdldEJ5SWQiLCJVc2VyczpBZGQiLCJVc2VyczpFZGl0IiwiVXNlcnM6RGVsZXRlIiwiVXNlcnM6VW5Mb2NrIiwiUm9sZXM6R2V0QWxsIiwiUm9sZXM6R2V0QnlJZCIsIlJvbGVzOkFkZCIsIlJvbGVzOkVkaXQiLCJSb2xlczpEZWxldGUiLCJCYXNrZXRzOkdldEFsbCIsIkJhc2tldHM6R2V0QnlJZCIsIkJhc2tldHM6QWRkIiwiQmFza2V0czpFZGl0IiwiQmFza2V0czpEZWxldGUiLCJCcmFuZHM6R2V0QWxsIiwiQnJhbmRzOkdldEJ5SWQiLCJQcm9kdWN0czpHZXRBbGwiLCJQcm9kdWN0czpHZXRCeUlkIiwiUHJvZHVjdHM6QWRkIiwiUHJvZHVjdHM6RWRpdCIsIlByb2R1Y3RzOkRlbGV0ZSIsIlByb2R1Y3RUeXBlczpHZXRBbGwiLCJQcm9kdWN0VHlwZXM6R2V0QnlJZCIsIk9yZGVyczpDcmVhdGVPcmRlckFzeW5jIiwiT3JkZXJzOkdldE9yZGVyc0ZvclVzZXJBc3luYyIsIk9yZGVyczpHZXRPcmRlckJ5SWRBc3luYyIsIk9yZGVyczpHZXREZWxpdmVyeU1ldGhvZHNBc3luYyJdLCJuYmYiOjE3MzMxMTQxMDYsImV4cCI6MTczMzExNTkwNiwiaWF0IjoxNzMzMTE0MTA2LCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDUxIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMCJ9.EDaeCPrEzDjhXING_ajJRIsUbsLv1TIE4YiYCF8WSPg | string |

### Response: 200

```json
{
  "id": null,
  "items": [],
  "deliveryMethodId": null,
  "shippingCost": 0,
  "paymentIntentId": null,
  "clientSecret": null
}
```

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

## End-point: Add Basket

#### Response

---

```json
{
  "id": "string",
  "items": [
    {
      "id": 0,
      "name": "string",
      "pictureUrl": "string",
      "price": 0.1,
      "quantity": 2147483647,
      "brand": "string",
      "type": "string"
    }
  ],
  "deliveryMethodId": 0,
  "shippingCost": 0,
  "paymentIntentId": "string",
  "clientSecret": "string"
}
```

### Method: POST

> ```
> {{BaseUrl}}/api/Baskets
> ```

### Body (**raw**)

```json
{
  "id": "string",
  "items": [
    {
      "id": 0,
      "name": "string",
      "pictureUrl": "string",
      "price": 0.1,
      "quantity": 2147483647,
      "brand": "string",
      "type": "string"
    }
  ],
  "deliveryMethodId": 0,
  "shippingCost": 0,
  "paymentIntentId": "string",
  "clientSecret": "string"
}
```

### 🔑 Authentication bearer

| Param | value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | Type   |
| ----- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------ |
| token | eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwiZ2l2ZW5fbmFtZSI6IkJpbGFsIiwidW5pcXVlX25hbWUiOiJCaWxhbDEyMyIsImVtYWlsIjoiYmxhbGhhbWQ0OEBnbWFpbC5jb20iLCJyb2xlcyI6WyJBZG1pbiIsIlNlbmlvciIsIlRlYW1MZWFkIl0sInBlcm1pc3Npb25zIjpbIlVzZXJzOkdldEFsbCIsIlVzZXJzOkdldEJ5SWQiLCJVc2VyczpBZGQiLCJVc2VyczpFZGl0IiwiVXNlcnM6RGVsZXRlIiwiVXNlcnM6VW5Mb2NrIiwiUm9sZXM6R2V0QWxsIiwiUm9sZXM6R2V0QnlJZCIsIlJvbGVzOkFkZCIsIlJvbGVzOkVkaXQiLCJSb2xlczpEZWxldGUiLCJCYXNrZXRzOkdldEFsbCIsIkJhc2tldHM6R2V0QnlJZCIsIkJhc2tldHM6QWRkIiwiQmFza2V0czpFZGl0IiwiQmFza2V0czpEZWxldGUiLCJCcmFuZHM6R2V0QWxsIiwiQnJhbmRzOkdldEJ5SWQiLCJQcm9kdWN0czpHZXRBbGwiLCJQcm9kdWN0czpHZXRCeUlkIiwiUHJvZHVjdHM6QWRkIiwiUHJvZHVjdHM6RWRpdCIsIlByb2R1Y3RzOkRlbGV0ZSIsIlByb2R1Y3RUeXBlczpHZXRBbGwiLCJQcm9kdWN0VHlwZXM6R2V0QnlJZCIsIk9yZGVyczpDcmVhdGVPcmRlckFzeW5jIiwiT3JkZXJzOkdldE9yZGVyc0ZvclVzZXJBc3luYyIsIk9yZGVyczpHZXRPcmRlckJ5SWRBc3luYyIsIk9yZGVyczpHZXREZWxpdmVyeU1ldGhvZHNBc3luYyJdLCJuYmYiOjE3MzMxMTQxMDYsImV4cCI6MTczMzExNTkwNiwiaWF0IjoxNzMzMTE0MTA2LCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDUxIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMCJ9.EDaeCPrEzDjhXING_ajJRIsUbsLv1TIE4YiYCF8WSPg | string |

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

## End-point: Update Basket

#### Response

---

```json
{
  "id": "string",
  "items": [
    {
      "id": 0,
      "name": "string",
      "pictureUrl": "string",
      "price": 0.1,
      "quantity": 2147483647,
      "brand": "string",
      "type": "string"
    }
  ],
  "deliveryMethodId": 0,
  "shippingCost": 0,
  "paymentIntentId": "string",
  "clientSecret": "string"
}
```

### Method: PUT

> ```
> {{BaseUrl}}/api/Baskets
> ```

### Body (**raw**)

```json
{
  "id": "string",
  "items": [
    {
      "id": 0,
      "name": "string",
      "pictureUrl": "string",
      "price": 0.1,
      "quantity": 2147483647,
      "brand": "string",
      "type": "string"
    }
  ],
  "deliveryMethodId": 0,
  "shippingCost": 0,
  "paymentIntentId": "string",
  "clientSecret": "string"
}
```

### 🔑 Authentication bearer

| Param | value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | Type   |
| ----- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------ |
| token | eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwiZ2l2ZW5fbmFtZSI6IkJpbGFsIiwidW5pcXVlX25hbWUiOiJCaWxhbDEyMyIsImVtYWlsIjoiYmxhbGhhbWQ0OEBnbWFpbC5jb20iLCJyb2xlcyI6WyJBZG1pbiIsIlNlbmlvciIsIlRlYW1MZWFkIl0sInBlcm1pc3Npb25zIjpbIlVzZXJzOkdldEFsbCIsIlVzZXJzOkdldEJ5SWQiLCJVc2VyczpBZGQiLCJVc2VyczpFZGl0IiwiVXNlcnM6RGVsZXRlIiwiVXNlcnM6VW5Mb2NrIiwiUm9sZXM6R2V0QWxsIiwiUm9sZXM6R2V0QnlJZCIsIlJvbGVzOkFkZCIsIlJvbGVzOkVkaXQiLCJSb2xlczpEZWxldGUiLCJCYXNrZXRzOkdldEFsbCIsIkJhc2tldHM6R2V0QnlJZCIsIkJhc2tldHM6QWRkIiwiQmFza2V0czpFZGl0IiwiQmFza2V0czpEZWxldGUiLCJCcmFuZHM6R2V0QWxsIiwiQnJhbmRzOkdldEJ5SWQiLCJQcm9kdWN0czpHZXRBbGwiLCJQcm9kdWN0czpHZXRCeUlkIiwiUHJvZHVjdHM6QWRkIiwiUHJvZHVjdHM6RWRpdCIsIlByb2R1Y3RzOkRlbGV0ZSIsIlByb2R1Y3RUeXBlczpHZXRBbGwiLCJQcm9kdWN0VHlwZXM6R2V0QnlJZCIsIk9yZGVyczpDcmVhdGVPcmRlckFzeW5jIiwiT3JkZXJzOkdldE9yZGVyc0ZvclVzZXJBc3luYyIsIk9yZGVyczpHZXRPcmRlckJ5SWRBc3luYyIsIk9yZGVyczpHZXREZWxpdmVyeU1ldGhvZHNBc3luYyJdLCJuYmYiOjE3MzMxMTQxMDYsImV4cCI6MTczMzExNTkwNiwiaWF0IjoxNzMzMTE0MTA2LCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDUxIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMCJ9.EDaeCPrEzDjhXING_ajJRIsUbsLv1TIE4YiYCF8WSPg | string |

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

## End-point: Delete Basket

#### Response

---

| **Code** | **Description** |
| -------- | --------------- |
| 200      | success         |

### Method: DELETE

> ```
> {{BaseUrl}}/api/Baskets/20
> ```

### 🔑 Authentication bearer

| Param | value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | Type   |
| ----- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------ |
| token | eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwiZ2l2ZW5fbmFtZSI6IkJpbGFsIiwidW5pcXVlX25hbWUiOiJCaWxhbDEyMyIsImVtYWlsIjoiYmxhbGhhbWQ0OEBnbWFpbC5jb20iLCJyb2xlcyI6WyJBZG1pbiIsIlNlbmlvciIsIlRlYW1MZWFkIl0sInBlcm1pc3Npb25zIjpbIlVzZXJzOkdldEFsbCIsIlVzZXJzOkdldEJ5SWQiLCJVc2VyczpBZGQiLCJVc2VyczpFZGl0IiwiVXNlcnM6RGVsZXRlIiwiVXNlcnM6VW5Mb2NrIiwiUm9sZXM6R2V0QWxsIiwiUm9sZXM6R2V0QnlJZCIsIlJvbGVzOkFkZCIsIlJvbGVzOkVkaXQiLCJSb2xlczpEZWxldGUiLCJCYXNrZXRzOkdldEFsbCIsIkJhc2tldHM6R2V0QnlJZCIsIkJhc2tldHM6QWRkIiwiQmFza2V0czpFZGl0IiwiQmFza2V0czpEZWxldGUiLCJCcmFuZHM6R2V0QWxsIiwiQnJhbmRzOkdldEJ5SWQiLCJQcm9kdWN0czpHZXRBbGwiLCJQcm9kdWN0czpHZXRCeUlkIiwiUHJvZHVjdHM6QWRkIiwiUHJvZHVjdHM6RWRpdCIsIlByb2R1Y3RzOkRlbGV0ZSIsIlByb2R1Y3RUeXBlczpHZXRBbGwiLCJQcm9kdWN0VHlwZXM6R2V0QnlJZCIsIk9yZGVyczpDcmVhdGVPcmRlckFzeW5jIiwiT3JkZXJzOkdldE9yZGVyc0ZvclVzZXJBc3luYyIsIk9yZGVyczpHZXRPcmRlckJ5SWRBc3luYyIsIk9yZGVyczpHZXREZWxpdmVyeU1ldGhvZHNBc3luYyJdLCJuYmYiOjE3MzMxMTQxMDYsImV4cCI6MTczMzExNTkwNiwiaWF0IjoxNzMzMTE0MTA2LCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDUxIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMCJ9.EDaeCPrEzDjhXING_ajJRIsUbsLv1TIE4YiYCF8WSPg | string |

⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃ ⁃

---

Powered By: [postman-to-markdown](https://github.com/bautistaj/postman-to-markdown/)
