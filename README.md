
# Rubik's Cube Project

This repository contains a full-stack Rubik's Cube project with separate backend and frontend implementations.

## Repository Structure
```
.
├── rubiks-cube-be
│   ├── RubiksCube
│   └── RubiksCube.UnitTests
└── rubiks-cube-fe
```


- **rubiks-cube-be:** The backend is built with .NET.
  - **RubiksCube:** Main backend application.
  - **RubiksCube.UnitTests:** Unit tests for the backend.

- **rubiks-cube-fe:** The frontend is built using Vite with React and TypeScript.

## Prerequisites

- **Backend:**
  - [.NET SDK](https://dotnet.microsoft.com/download) (version 9.0 or later)
- **Frontend:**
  - [Node.js](https://nodejs.org/en/download/) (v14 or later)
  - npm (comes with Node.js)

## Getting Started

### Clone the Repository

```
git clone https://github.com/1vaPetkova/rubiks-cube.git
cd rubiks-cube
```
#### Backend Setup

Navigate to the backend folder:
```
cd rubiks-cube-be
```
Build and run the main project:
```
dotnet build RubiksCube
dotnet run --project RubiksCube
```

The backend server will run at http://localhost:5176.

To run unit tests:
```
dotnet test RubiksCube.UnitTests
```
#### Frontend Setup

Navigate to the frontend folder:
```
cd rubiks-cube-fe
```
Install dependencies:
```
npm install
```
Run the development server:
```
npm run dev
```

The frontend will be available at http://localhost:5173.

### Project Details
#### Backend:
Developed with .NET to handle the rotation logic and API endpoints to return the modified cube to the frontend after each Rubik's Cube operation. Unit tests ensure the core logic's reliability.
#### Frontend:
Built with React and TypeScript using Vite, the frontend offers a responsive and interactive interface for users to engage with the Rubik's Cube posible side movements.
