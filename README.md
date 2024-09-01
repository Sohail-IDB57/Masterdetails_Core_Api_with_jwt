# Masterdetails_Core_Api_with_jwt

**Masterdetails_Core_Api_with_jwt** is a .NET Core 3.1 web API project that demonstrates how to build a RESTful API with a master-detail data model and JWT (JSON Web Token) authentication. The project leverages ASP.NET Core Identity for user management and Entity Framework Core with SQL Server for data access.

## Features

- **Master-Detail Data Model:** Efficiently handles and manages master-detail relationships.
- **JWT Authentication:** Secure API endpoints using JWT with customizable token validation.
- **ASP.NET Core Identity:** Provides authentication and user management.
- **Entity Framework Core:** ORM for database operations with SQL Server.
- **Static Files & HTTPS:** Configured to serve static files and enforce HTTPS.

## Technologies

- **.NET Core 3.1**: Framework for building the web API.
- **ASP.NET Core**: Framework for building the web application and configuring authentication.
- **Entity Framework Core**: ORM for data access.
- **Microsoft SQL Server**: Database provider.
- **JWT (JSON Web Token)**: Used for securing API access.

## Installation and Setup

1. **Clone the Repository**

   ```bash
   git clone https://github.com/Sohail-IDB57/Masterdetails_Core_Api_with_jwt.git
   cd Masterdetails_Core_Api_with_jwt
   ```

2. **Configure the Database**

   Open `appsettings.json` and set up your SQL Server connection string under the `ConnectionStrings` section:

   ```json
   "ConnectionStrings": {
     "DbCon": "YourConnectionStringHere"
   }
   ```

3. **Configure JWT Settings**

   Define your JWT secret and other settings in the `appsettings.json` file under the `JwtConfig` section:

   ```json
   "JwtConfig": {
     "Secret": "YourJwtSecretHere"
   }
   ```

4. **Install Dependencies**

   Make sure you have the required packages installed. Use the .NET CLI to restore them:

   ```bash
   dotnet restore
   ```

5. **Run Migrations**

   Create and apply database migrations using the .NET CLI:

   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

6. **Run the Application**

   Start the application:

   ```bash
   dotnet run
   ```

   The API will be accessible at `https://localhost:5001`.

## Usage

- **Authentication**: Use JWT for accessing secured endpoints. Include the JWT in the `Authorization` header as a Bearer token.

- **Endpoints**: The API supports various endpoints for managing master-detail data. Refer to the API documentation or source code for specific endpoint details.

## Contributing

Contributions are welcome! Please fork the repository and submit a pull request with your changes.

## Contact

For any questions or feedback, please open an issue on the [GitHub repository](https://github.com/Sohail-IDB57/Masterdetails_Core_Api_with_jwt).

```
