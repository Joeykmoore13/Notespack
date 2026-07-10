# Requirements Document
# The Syntax Errors - Notespack

## Project Overview

### Project Name
**The Syntax Errors - Notespack**

### Target Audience
College students (Ages 18–30).

### Purpose
Provide a centralized platform where students can discover, create, and manage events in a simple and organized manner.

### Project Goal
Develop a complete, functional, and user-friendly .NET Blazor web application that is:

- Performant
- Accessible
- Responsive
- Secure
- Ready for real-world deployment

---

# Functional Requirements

## User Authentication

The system shall allow users to:

- Register for an account.
- Log in.
- Log out.

---

## Event Management (CRUD)

The system shall allow authenticated users to:

- Create events.
- View events.
- Update event information.
- Delete events.

---

## Event Details

The system shall provide:

- Full event information.
- Date and time.
- Location.
- Category.
- Creator information.
- RSVP count (optional).
- Event image/icon (optional).

---

## Search and Filtering

Users shall be able to:

- Search for events.
- Filter by category.
- Filter by date.
- Browse upcoming events.

---

## Responsive Design

The application shall support:

- Desktop devices.
- Tablet devices.
- Mobile devices.

---

## Validation

Forms shall validate:

- Required fields.
- String inputs.
- Data formatting.

---

## Accessibility

The application shall:

- Follow WCAG 2.1 AA guidelines.
- Support keyboard navigation.
- Maintain readable color contrast.
- Provide accessible forms and navigation.

---

## Cloud Deployment

The application shall be deployed to a cloud service and remain publicly accessible.

Possible deployment targets:

- Azure
- Render
- AWS

---

# Key Pages

## Home Page

Features:
- Welcome message.
- Project overview.
- Navigation to major sections.

---

## Events Page

Features:
- List upcoming events.
- Search and filtering.

---

## Event Details Page

Features:
- Display complete event information.

---

## Create Event Page

Features:
- Add new events.

---

## Edit Event Page

Features:
- Modify existing events.

---

## Login / Register Page

Features:
- User authentication.

---

## About / Team Page

Features:
- Project information.
- Team member information.

---

# Event Data Model

Each event should support the following fields:

| Field | Required |
|--------|-----------|
| Event ID (Primary Key) | Yes |
| Title | Yes |
| Description | Yes |
| Date | Yes |
| Start Time | Yes |
| End Time | Yes |
| Location | Yes |
| Category | Yes |
| Created By | Yes |
| RSVP Count | Optional |
| Image/Icon | Optional |

---

# Non-Functional Requirements

## Performance

The application shall:

- Minimize unnecessary resource usage.
- Provide fast loading times.
- Deliver smooth user interactions.

---

## Usability

The application shall:

- Be intuitive.
- Provide a consistent user experience.
- Work across various screen sizes.

---

## Branding

The application shall maintain:

- Consistent colors.
- Consistent typography.
- Uniform spacing and layout.

---

## Navigation

The application shall provide:

- Logical page organization.
- Easy movement throughout the website.
- Consistent navigation components.

---

# Technology Stack

## Framework

- .NET 8
- Blazor

## Database

- SQL Server

## Development Tools

- Visual Studio
- GitHub
- Trello

## UI Framework

- Bootstrap 5

## Deployment

- Azure
- Render
- AWS

---

# Project Requirements Checklist

The project must include:

- [x] .NET Blazor Web Application
- [x] Meet target audience needs
- [x] Complete and functional implementation
- [x] Good performance
- [x] Accessibility compliance
- [x] Usable interface
- [x] User authentication
- [x] CRUD functionality
- [x] Quality assurance and testing
- [x] Jira for project management
- [x] GitHub for source control
- [x] Code comments
- [x] User documentation
- [x] Deployment to a cloud service

---

# Development Workflow

1. Plan features and tasks.
2. Build functionality.
3. Commit changes to GitHub.
4. Review and test changes.
5. Deploy to cloud services.

---

# GitHub Workflow

1. Create a branch.
2. Make changes.
3. Commit changes.
4. Push branch.
5. Create pull request.
6. Review.
7. Merge into main.

---

# Trello Workflow

Backlog:
- Ideas
- Future tasks

To Do:
- Ready to start

In Progress:
- Active development

Review:
- Awaiting approval

Testing / QA:
- Quality checks

Done:
- Completed and approved

---

# Quality Assurance Requirements

## Testing

The project shall include:

- Functional testing.
- Form validation testing.
- Integration testing.
- Accessibility testing.
- Regression testing.

---

## Documentation

The project shall include:

- User guide.
- Basic start-up instructions.
- Bug tracking.
- Issue documentation.

---

# Team Responsibilities

## Frontend
- UI design
- Layout
- Navigation
- Responsive design

## Backend
- Database
- CRUD operations
- Controllers and services
- Data integrity

## Full Stack
- Frontend/backend integration
- Event pages
- Data flow

## Authentication & QA
- Login/registration support
- Form validation
- Accessibility testing
- Lighthouse checks
- User documentation
- Bug reporting
