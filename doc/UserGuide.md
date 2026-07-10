# User Guide

# The Syntax Errors - Notespack

## Introduction

Welcome to Notespack!

This application was developed to help college students discover, create, and manage events in one organized location. Users can browse upcoming events, create their own events, edit existing events, and manage their accounts through a simple and responsive interface.

---

# System Requirements

To run the application locally, ensure the following software is installed:

## Required Software

* .NET 8 SDK
* Visual Studio 2022 or later
* SQL Server
* SQL Server Management Studio (optional)
* Git
* Modern web browser:

    * Google Chrome
    * Microsoft Edge
    * Mozilla Firefox

---

# Installation

## Step 1: Clone the Repository

```bash
git clone <repository-url>
```

Navigate to the project directory:

```bash
cd CalendarEventsWebsite
```

---

## Step 2: Open the Project

Open the solution file in Visual Studio.

---

## Step 3: Configure the Database

Update the connection string in:

```
appsettings.json
```

Example:

```json
"ConnectionStrings": {
    "DefaultConnection": "Your SQL Server Connection String"
}
```

---

## Step 4: Apply Database Migrations

Open the Package Manager Console and run:

```powershell
Update-Database
```

Alternatively:

```bash
dotnet ef database update
```

---

## Step 5: Build the Project

In Visual Studio:

```
Build → Build Solution
```

Or use:

```bash
dotnet build
```

---

## Step 6: Run the Application

Press:

```
F5
```

or

```bash
dotnet run
```

Open the displayed localhost URL in your browser.

---

# Getting Started

When the application opens, users can:

* Browse upcoming events.
* Register for an account.
* Log in.
* Create events.
* Edit events.
* Search and filter events.

---

# Creating an Account

## Register

1. Navigate to the Register page.
2. Enter:

    * Username
    * Email
    * Password
3. Submit the form.

If successful:

* Account is created.
* User may log in.

---

# Logging In

1. Open the Login page.
2. Enter:

    * Email or username.
    * Password.
3. Click Login.

Successful login grants access to protected features.

---

# Logging Out

To log out:

1. Select the Logout option.
2. Session ends securely.
3. User returns to the public interface.

---

# Viewing Events

Navigate to the Events page.

Users can:

* View upcoming events.
* Browse event information.
* Select an event for additional details.

Information displayed may include:

* Event title
* Description
* Date
* Time
* Location
* Category
* Creator
* RSVP count
* Event image

---

# Searching for Events

Use the search bar to locate events.

Search options may include:

* Event title.
* Category.
* Date.

Matching events will be displayed automatically.

---

# Creating an Event

Authenticated users may create events.

## Steps

1. Navigate to Create Event.
2. Fill in required information:

    * Title
    * Description
    * Date
    * Start Time
    * End Time
    * Location
    * Category
3. Submit the form.

The event will appear in the event listing after creation.

---

# Editing an Event

To modify an event:

1. Open the event.
2. Select Edit.
3. Update desired information.
4. Save changes.

The updated information will be displayed immediately.

---

# Deleting an Event

To remove an event:

1. Open the event.
2. Select Delete.
3. Confirm deletion.

The event will be permanently removed.

---

# Responsive Design

The website supports:

## Desktop

Full functionality and navigation.

## Tablet

Responsive layout adjustments.

## Mobile

Optimized interface for smaller screens.

---

# Accessibility Features

The application aims to follow WCAG 2.1 AA guidelines.

Features include:

* Keyboard navigation.
* Clear form labels.
* Readable color contrast.
* Consistent navigation.
* Responsive layouts.

---

# Common Issues

## Cannot Log In

Possible causes:

* Incorrect password.
* Account not registered.
* Server unavailable.

Solution:

* Verify credentials.
* Register an account.
* Contact support if necessary.

---

## Event Not Saving

Possible causes:

* Missing required fields.
* Invalid input.
* Database connection issues.

Solution:

* Complete all required fields.
* Verify information.
* Try again.

---

## Page Loading Slowly

Possible causes:

* Slow internet connection.
* Server load.

Solution:

* Refresh the page.
* Check internet connectivity.

---

# Frequently Asked Questions

## Do I need an account to view events?

No. Public events may be viewed without authentication.

---

## Do I need an account to create events?

Yes. Authentication is required.

---

## Can I edit an event?

Yes, provided you have permission to modify it.

---

## Can I delete an event?

Yes, authorized users may remove events.

---

# Best Practices

For the best experience:

* Keep account credentials secure.
* Verify event information before submission.
* Use descriptive event titles.
* Keep event details up to date.

---

# Support

If you encounter problems:

1. Verify your internet connection.
2. Refresh the page.
3. Restart the application.
4. Check for server availability.
5. Contact the development team if issues persist.

---

# Version Information

**Application:** Notespack

**Framework:** .NET 8 Blazor

**Database:** SQL Server

**Current Version:** 1.0

---

# Revision History

| Version | Date            | Description                 |
| ------- | --------------- | --------------------------- |
| 1.0     | Initial Release | Initial user guide created. |
