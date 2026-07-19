# Test Plan

# The Syntax Errors - Notespack

## Purpose

The purpose of this test plan is to ensure that the Notespack Website functions correctly, meets project requirements, and provides a reliable and accessible experience for users. Testing will verify functionality, usability, accessibility, performance, and integration between system components.

---

# Testing Objectives

The project will be tested to ensure:

* Features work as intended.
* Invalid inputs are handled appropriately.
* User data remains secure.
* Pages display correctly across devices.
* Accessibility standards are met.
* Database operations function correctly.
* Frontend and backend integrate successfully.

---

# Testing Environment

## Hardware

* Desktop Computer
* Laptop
* Mobile Device (optional)

## Software

* Visual Studio
* .NET 8
* Blazor
* SQLite
* Google Chrome
* Microsoft Edge
* Firefox

## Testing Tools

* Lighthouse
* Browser Developer Tools
* GitHub
* Manual User Testing

---

# Functional Testing

## User Registration

### Test Case: Valid Registration

**Input:**

* Valid username
* Valid email
* Valid password

**Expected Result:**

* User account created successfully.

---

### Test Case: Missing Required Fields

**Input:**

* Blank fields

**Expected Result:**

* Validation messages displayed.
* Account not created.

---

### Test Case: Duplicate Account

**Input:**

* Existing email address

**Expected Result:**

* Error message displayed.
* Duplicate account prevented.

---

# User Login

## Valid Login

Expected:

* User successfully authenticated.
* Redirected to appropriate page.

## Invalid Login

Expected:

* Error message displayed.
* Access denied.

---

## Logout

Expected:

* Session terminated.
* User returned to public page.

---

# Event Management Testing

## Create Event

Expected:

* Event saved to database.
* Event appears in event list.

---

## Read Event

Expected:

* Event details displayed correctly.

---

## Update Event

Expected:

* Changes saved successfully.
* Updated information displayed.

---

## Delete Event

Expected:

* Event removed from database.
* Event no longer appears in listings.

---

# Event Details Testing

Verify that event pages correctly display:

* Title
* Description
* Date
* Start Time
* End Time
* Location
* Category
* Creator
* RSVP Count (if enabled)
* Image (if enabled)

---

# Search and Filter Testing

## Search

Expected:

* Matching events returned.

---

## Category Filter

Expected:

* Only selected category displayed.

---

## Date Filter

Expected:

* Only matching dates displayed.

---

# Form Validation Testing

Verify:

* Required fields.
* Character limits.
* Valid dates.
* Valid times.
* Proper email format.
* Prevention of invalid submissions.

---

# Database Testing

Verify:

## Data Creation

* Records inserted correctly.

## Data Updates

* Records modified correctly.

## Data Deletion

* Records removed correctly.

## Data Integrity

* No duplicate primary keys.
* Required relationships maintained.

---

# Integration Testing

Verify communication between:

* Frontend and backend.
* Backend and database.
* Authentication system and event management.

Expected:

* Data flows correctly without errors.

---

# Responsive Testing

Verify layout on:

## Desktop

* Navigation functions.
* Content aligned properly.

## Tablet

* Responsive layout maintained.

## Mobile

* Navigation usable.
* Content readable.
* Forms accessible.

---

# Accessibility Testing

The application should follow WCAG 2.1 AA guidelines.

Verify:

* Keyboard navigation.
* Color contrast.
* Form labels.
* Button accessibility.
* Heading hierarchy.
* Alternative text for images.
* Focus indicators.

Testing Tool:

* Lighthouse Accessibility Audit.

---

# Performance Testing

Verify:

* Fast page loading.
* Smooth navigation.
* Efficient database queries.
* Minimal unnecessary resource usage.

Testing Tool:

* Lighthouse Performance Audit.

---

# Security Testing

Verify:

## Authentication

* Unauthorized users cannot access protected pages.

## Input Validation

* Invalid inputs rejected.

## Session Management

* Users properly logged out.

---

# Browser Compatibility Testing

Test on:

* Google Chrome
* Microsoft Edge
* Mozilla Firefox

Verify:

* Layout consistency.
* Form functionality.
* Navigation.
* Authentication.

---

# User Acceptance Testing

Sample user tasks:

* Register an account.
* Log in.
* Create an event.
* Edit an event.
* Search for an event.
* View event details.
* Delete an event.
* Log out.

Expected:

* Users complete tasks successfully without assistance.

---

# Bug Tracking

Defects should include:

* Bug ID
* Description
* Steps to reproduce
* Expected result
* Actual result
* Severity
* Status
* Assigned developer

Suggested statuses:

* Open
* In Progress
* Testing
* Resolved
* Closed

---

# Pass/Fail Criteria

A feature passes testing if:

* Expected behavior occurs.
* No critical errors are encountered.
* Validation functions correctly.
* Accessibility requirements are met.
* Integration works properly.

A feature fails if:

* Functionality does not match requirements.
* Errors prevent intended use.
* Security or accessibility issues are discovered.

---

# Quality Assurance Checklist

| Feature               | Status |
| --------------------- | ------ |
| User Registration     | ☐      |
| User Login            | ☐      |
| User Logout           | ☐      |
| Create Event          | ☐      |
| Read Events           | ☐      |
| Update Event          | ☐      |
| Delete Event          | ☐      |
| Event Details         | ☐      |
| Search                | ☐      |
| Filters               | ☐      |
| Form Validation       | ☐      |
| Database Operations   | ☐      |
| Responsive Design     | ☐      |
| Accessibility         | ☐      |
| Performance           | ☐      |
| Security              | ☐      |
| Browser Compatibility | ☐      |
| Cloud Deployment      | ☐      |

---

# Approval

Testing is considered complete when:

* All critical functionality passes.
* Major defects are resolved.
* Accessibility checks pass.
* Performance goals are met.
* User acceptance testing is successful.
* The application is approved for deployment.
