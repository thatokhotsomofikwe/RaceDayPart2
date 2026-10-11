# RaceDay API - Part 2

## Project Overview
This is the RESTful API backend for the RaceDay system, built with ASP.NET Core Web API, Entity Framework Core (Code-First), and SQL Server. It handles user authentication, role-based access control (Organiser vs. Participant), event management, categories, enrolments, and results.

## Setup & Run Instructions
1. Clone this repository.
2. Open `RaceDay.sln` in Visual Studio 2022/2026.
3. Ensure your SQL Server instance is running and update the `DefaultConnection` string in `appsettings.json`.
4. Open the Package Manager Console and run: `Update-Database`
5. Build and run the project (F5). Swagger UI will open automatically at `/swagger`.
6. Use the `/api/auth/register` endpoint to create an Organiser and a Participant.

## Roles
- **Organiser**: Create/edit/delete own events, manage categories/routes, view event enrolments, capture/update/delete results.
- **Participant**: Update profile, view events, enrol in events, cancel own enrolment, view own results.

## CI/CD
A GitHub Actions workflow is configured in `.github/workflows/dotnet-ci.yml`. It automatically builds the project and runs unit tests on every push to the `main` branch. 

Successful Test and Build
<img width="1366" height="768" alt="Screenshot 2026-10-11 111925" src="https://github.com/user-attachments/assets/c936aacd-c505-480a-9b87-89d9e89d2976" />

Successful Workflow
<img width="1366" height="768" alt="Screenshot 2026-10-11 111824" src="https://github.com/user-attachments/assets/060d0a32-b0ca-41e7-bbd7-9a792e47459b" />

Unlisted YouTube Link



