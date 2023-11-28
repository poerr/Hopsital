# Hospital Management System

The Hospital Management System is a web-based application designed to streamline and enhance the management and operation of a hospital. This project incorporates a .NET Core Web API for the server-side logic and Angular for the client-side user interface.

## Features

- **Patient Management:** Easily manage patient records, appointments, and medical history.
- **Appointment Scheduling:** Schedule and manage appointments for doctors and patients.
- **Doctor Dashboard:** Provide doctors with a dedicated dashboard to access patient information and appointments.
- **User Authentication and Authorization:** Ensure secure access to the system with role-based authentication.

## Technologies Used

- **Server-Side:**
  - .NET Core Web API
  - Entity Framework Core for data access
  - Swagger for API documentation

- **Client-Side:**
  - Angular
  - TypeScript
  - Angular Material for UI components

## Prerequisites

Before running the application, ensure that you have the following installed:

- [.NET Core SDK](https://dotnet.microsoft.com/download)
- [Node.js](https://nodejs.org/)
- [Angular CLI](https://angular.io/cli)

## Getting Started

1. Clone the repository:

   ```bash
   git clone https://github.com/poerr/hospital.git

2. Navigate to the server-side (API) directory:

    cd Hospital/Hospital.API

3. Install the required packages:

    dotnet restore

4. Run the API:
    
    dotnet run

5. Open a new terminal and navigate to the clinet-side (Angular) directory:

    cd Hospital/hospital-frontend

6. Install the required packages:

    npm install

7. Run the Angular application

    ng serve

8. Open your browser and go to http://localhost:4200 to access the Hospital app
