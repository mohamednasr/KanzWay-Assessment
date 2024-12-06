# KanzWay Assessment
this project implements a REST API Endpoint that returns a list of strings starting from 1 until the entered number, any number divisible by 3 is shown as "Kanz", any number divisible by 5 is shown as "Way" and if the number is divisible by both 3 and 5 shown as "KanzWay", The API Project Includes a swagger for documentation and easy usage.
A Unit Test Project added to verify the test cases


# Project Structure

```
|KanzWay
│
├── Kanzway.API/                # API Project
│   ├── Controllers/            # Contains API Controllers
│   │   └── ScreeningController.cs      # Logic for the Screening API
│   └── Program.cs              # Entry point for the API project
│
├── Kanzway.Unittest/           # Unit Test Project
│   └── ScreeningAPITests.cs    # Unit tests for the Screening API
│
└── README.md                   # Description, file structure, and how to use
```


# API Endpoint

## Base URL
- **HTTP:** http://localhost:5270
- **HTTPS:** https://localhost:7246

## Endpoints
```GET /api/v1/screening/{number}```
Accepts a number as input and returns a list of strings based on the Business logic.


# How to Run the Project

### Prerequisites
- .NET SDK: Install the latest .NET 8 SDK or higher.

### Clone the repository
``` terminal
git clone https://github.com/mohamednasr/KanzWay-MohamedNasr.git
cd KanzWay-MohamedNasr
```

### Run The API Project

**1. Restore the required packages:**
``` terminal
cd Kanzway.API
dotnet restore
```

**2. Run the application:**
``` terminal
dotnet run --launch-profile "https"
```
you can change "https" into "http" to use the http port.

**3. Open the Swagger UI:**
```terminal
https://localhost:7246/swagger/index.html
```

# How to Run the Unit Test
### Prerequisites
- xUnit test framework
- cloning the respository

### Running Tests
**1. Navigate to the test project directory:**
```terminal
cd Kanzway.Unittest
```

**2. Run the tests:**
``` terminal
dotnet test
```
