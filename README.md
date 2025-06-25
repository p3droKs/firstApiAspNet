# ASP.NET Core API with Entity Framework Core (In-Memory Database)

## Overview

This is a simple RESTful API developed using **ASP.NET Core** and **Entity Framework Core** with an in-memory database. The API manages two main entities: **Categories** and **Products**, where each product is linked to a category.

---

## Features

- CRUD operations for Categories and Products
- Products include their related Category details
- Filtering products by category
- Input validation with proper HTTP status codes:
  - `200 OK` for successful GET requests
  - `201 Created` for successful POST requests
  - `400 Bad Request` for validation errors
  - `404 Not Found` when requested resource does not exist
- Integrated Swagger UI for API documentation and testing

---

## Getting Started

### Prerequisites

- [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) or later
- A tool to test API endpoints like [Postman](https://www.postman.com/) or your browser

### Setup and Run

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/your-repo.git
   cd your-repo
   ```

2. Restore dependencies:
   ```bash
   dotnet restore
   ```

3. Run the API:
   ```bash
   dotnet run
   ```

4. Open your browser and navigate to:
   ```
   https://localhost:5137/swagger
   ```
   (Port may vary — check your console output.)

5. Use the Swagger UI to explore and test API endpoints.

---

## API Endpoints

### Categories

- `GET /v1/categories` — Get all categories
- `GET /v1/categories/{id}` — Get category by ID
- `POST /v1/categories` — Create a new category

### Products

- `GET /v1/products` — Get all products with category details
- `GET /v1/products/{id}` — Get product by ID with category details
- `GET /v1/products/categories/{categoryId}` — Get products by category ID
- `POST /v1/products` — Create a new product

---

## Models

### Category

| Property | Type    | Description                       |
| -------- | ------- | -------------------------------- |
| Id       | int     | Primary key (auto-generated)      |
| Title    | string  | Required, between 3 and 60 characters |

### Product

| Property    | Type    | Description                         |
| ----------- | ------- | ---------------------------------- |
| Id          | int     | Primary key (auto-generated)        |
| Title       | string  | Required                           |
| Price       | decimal | Required                           |
| CategoryId  | int     | Foreign key referencing Category   |
| Category    | Category| Navigation property (Category info)|

---

## Notes

- This project uses an in-memory database, so data is **not persisted** after the application stops.
- Ideal for learning, prototyping, or testing purposes.
- For production, switch to a persistent database provider like SQL Server.

---

## Contributing

Feel free to fork the project and send pull requests!

---
