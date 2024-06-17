# Google Keep Clone

This repository contains a clean architecture implementation of a Google Keep clone using .NET Core in backend development and Next.js in frontend development. Test suite will be implemented using XUnit.

## Table of Contents

- [Getting Started](#getting-started)
- [Project Structure](#project-structure)
- [Key Features](#key-features)
- [Technologies Used](#technologies-used)
- [Best Practices in Backend Development](#best-practices-in-backend-development)
- [Testing](#testing)
- [Frontend Development](#frontend-development)

## Getting Started

1. Clone the repository:

```bash
git clone https://github.com/your-username/google-keep-clone.git
```

2. Install dependencies:

```bash
cd google-keep-clone
dotnet restore
npm install
```

3. Configure environment variables:

Create a `.env` file in the root directory of the project and add the following variables:

```
JWT_SECRET=your_jwt_secret_key
CACHE_CONNECTION_STRING=your_cache_connection_string
LOGGING_PATH=logs/app.log
```

Replace `your_jwt_secret_key`, `your_cache_connection_string`, and `logs/app.log` with your desired values.

4. Build and run the application:

```bash
dotnet build
dotnet run
```

The backend will start listening on `https://localhost:5001` and the frontend will be available at `http://localhost:3000`.

## Project Structure

The project is organized into the following directories:

- `src/Backend`: Contains the backend code.
- `src/Frontend`: Contains the frontend code.
- `tests`: Contains the test suite.

## Key Features

- User registration and authentication using JWT.
- Creating, updating, deleting, and retrieving notes.
- Searching notes by title or content.
- Pagination, Filtering, and Sorting for retrieving notes.
- Caching frequently accessed data using Redis.
- Logging using Serilog.
- Input validation using FluentValidation.
- Load balancing and rate limiting.

## Technologies Used

- .NET Core minimal API
- JWT authentication
- Redis caching
- Serilog for logging
- FluentValidation for input validation
- XUnit for testing
- Next.js for frontend

## Best Practices in Backend Development

- SOLID principles: Single Responsibility, Open/Closed, Liskov Substitution, Interface Segregation, Dependency Inversion.
- Repository pattern for data access.
- Unit of work pattern for managing database transactions.
- CQRS pattern for separating read and write operations.
- MediatR for handling commands and queries.
- Dependency injection for managing dependencies.
- Logging using Serilog.
- Input validation using FluentValidation.
- Error handling using custom middleware.
- Pagination, Filtering, Sorting for retrieving data.
- Caching frequently accessed data using Redis.

## Testing

The test suite is implemented using XUnit and covers the following areas:

- Unit tests for domain entities and value objects.
- Integration tests for repository and service layers.
- Functional tests for API endpoints.

To run the tests, execute the following command:

```bash
dotnet test
```

## Frontend Development

The frontend of the project is built using Next.js, a React framework that provides server-side rendering and other features for building modern web applications.

- The frontend code is located in the `src/Frontend` directory.
- The project uses Next.js API routes for handling API requests from the frontend.
- The frontend is built using React components and follows best practices for component design and state management.
- The frontend uses Aceternity-UI as UI Library and Tailwind CSS for styling.
- The frontend includes features like user registration, note management, search, pagination, filtering, sorting, and caching.
- The frontend is designed to work seamlessly with the backend API.

## Contributing

Contributions are welcome! If you have any suggestions or improvements, feel free to open an issue or submit a pull request.


## Acknowledgments

This project was inspired by the Google Keep app and follows best practices in backend and frontend development. It also utilizes various open-source technologies and libraries.
