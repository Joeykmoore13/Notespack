# Login & Sign-In QA Test Plan

# Notespack

## Purpose

The purpose of this test plan is to verify that the Login and Sign-In pages of Notespack function correctly, validate user input, handle authentication errors gracefully, and meet accessibility and responsiveness requirements.

---

# Test Environment

## Supported Browsers
* Google Chrome
* Microsoft Edge
* Mozilla Firefox

## Supported Devices
* Desktop
* Tablet
* Mobile

---

# Functional Testing

## TC-AUTH-001: Login Page Loads Successfully

| Item            | Description                                          |
| --------------- |------------------------------------------------------|
| Priority        | High                                                 |
| Preconditions   | Application is running                               |
| Steps           | 1. Open the application.<br>2. Navigate to `/login`. |
| Expected Result | Login page loads fully without errors.               |
| Status          | [x] Pass [ ] Fail                                    |

---

## TC-AUTH-002: Sign-In Page Loads Successfully

### Steps
1. Navigate to `/register` or `/sign-in`.

### Expected Result
* Page loads without errors.
* All form fields visible.

**Status:** [x] Pass [ ] Fail

---

## TC-AUTH-003: Login Form Fields Display Correctly

### Verify
* Email field
* Password field
* Login button
* “Forgot password” link (if present)

### Expected Result
* All fields visible and labeled correctly.
* No overlapping elements.

**Status:** [ ] Pass [x] Fail
Forgot Password not Implemented
---

## TC-AUTH-004: Sign-In Form Fields Display Correctly

### Verify
* Name field
* Email field
* Password field
* Confirm password field
* Register button

### Expected Result
* All fields visible and labeled correctly.
* No missing or placeholder text.

**Status:** [x] Pass [ ] Fail

---

## TC-AUTH-005: Required Field Validation

### Steps
1. Leave all fields empty.
2. Click Login or Register.

### Expected Result
* Required field messages appear.
* No form submission occurs.

**Status:** [x] Pass [ ] Fail

---

## TC-AUTH-006: Email Format Validation

### Steps
1. Enter invalid email formats (e.g., `abc`, `user@`, `@domain.com`).
2. Submit form.

### Expected Result
* Email validation error appears.
* Form does not submit.

**Status:** [x] Pass [ ] Fail

---

## TC-AUTH-007: Password Length Validation

### Steps
1. Enter a password shorter than the minimum requirement.
2. Submit form.

### Expected Result
* Password validation error appears.
* Form does not submit.

**Status:** [x] Pass [ ] Fail

---

## TC-AUTH-008: Confirm Password Validation (Sign-In)

### Steps
1. Enter mismatched passwords.
2. Submit form.

### Expected Result
* “Passwords do not match” error appears.
* Form does not submit.

**Status:** [x] Pass [ ] Fail

---

## TC-AUTH-009: Successful Login

### Steps
1. Enter valid credentials.
2. Click Login.

### Expected Result
* User is authenticated.
* Redirects to dashboard or homepage.
* No errors displayed.

**Status:** [x] Pass [ ] Fail

---

## TC-AUTH-010: Failed Login (Incorrect Credentials)

### Steps
1. Enter incorrect email or password.
2. Submit form.

### Expected Result
* Error message appears (e.g., “Invalid email or password”).
* User remains on login page.

**Status:** [x] Pass [ ] Fail

---

## TC-AUTH-011: Successful Registration

### Steps
1. Enter valid registration details.
2. Submit form.

### Expected Result
* Account created successfully.
* User redirected to login or dashboard.

**Status:** [x] Pass [ ] Fail

---

## TC-AUTH-012: Duplicate Email Registration

### Steps
1. Attempt to register with an email already in use.

### Expected Result
* Error message appears (e.g., “Email already registered”).
* No account created.

**Status:** [x] Pass [ ] Fail

---

# Layout Testing

## TC-AUTH-013: No Overlapping Elements

### Expected Result
* Labels, inputs, and buttons do not overlap.
* Error messages do not distort layout.

**Status:** [x] Pass [ ] Fail

---

## TC-AUTH-014: No Horizontal Scrolling

### Expected Result
* Page fits within viewport width.
* No unintended horizontal scrollbars.

**Status:** [x] Pass [ ] Fail

---

# Responsive Testing

## TC-AUTH-015: Desktop View

### Expected Result
* Form centered or properly aligned.
* Text readable.

**Status:** [x] Pass [ ] Fail

---

## TC-AUTH-016: Tablet View

### Expected Result
* Form scales appropriately.
* Buttons remain accessible.

**Status:** [x] Pass [ ] Fail

---

## TC-AUTH-017: Mobile View

### Expected Result
* Inputs stack vertically.
* Buttons large enough to tap.
* No clipped text.

**Status:** [x] Pass [ ] Fail

---

# Accessibility Testing

## TC-AUTH-018: Keyboard Navigation

### Steps
Navigate using only the Tab key.

### Expected Result
* All fields reachable.
* **Focus indicators visible** on inputs and buttons.
* No keyboard traps.

**Status:** [x] Pass [ ] Fail

---

## TC-AUTH-019: Screen Reader Labels

### Expected Result
* Inputs have accessible labels.
* Error messages announced correctly.

**Status:** [x] Pass [ ] Fail

---

## TC-AUTH-020: Color Contrast

### Expected Result
* Text meets WCAG AA contrast requirements.
* Error messages clearly visible.

**Status:** [x] Pass [ ] Fail

---

# Security UI Testing

## TC-AUTH-021: Password Field Masking

### Expected Result
* Password characters are hidden.
* No accidental plaintext display.

**Status:** [x] Pass [ ] Fail

---

## TC-AUTH-022: No Sensitive Data in Error Messages

### Expected Result
* Errors do not reveal internal system details.
* No stack traces or debug info.

**Status:** [x] Pass [ ] Fail

---

# Performance Testing

## TC-AUTH-023: Login Page Load Speed

### Expected Result
* Page loads quickly.
* No noticeable lag.

**Status:** [x] Pass [ ] Fail

---

## TC-AUTH-024: Browser Compatibility

### Expected Result
* Login and Sign-In pages display consistently across browsers.

**Status:** [x] Pass [ ] Fail

---

# Stability Testing

## TC-AUTH-025: Refresh Stability

### Steps
1. Refresh login or sign-in page multiple times.

### Expected Result
* Page remains functional.
* No rendering issues.

**Status:** [x] Pass [ ] Fail

---

# QA Summary Checklist

| Test                      | Pass | Fail |
|---------------------------|:----:|:----:|
| Login Page Loads          | [x]  | [ ]  |
| Sign-In Page Loads        | [x]  | [ ]  |
| Form Fields Display       | [ ]  | [x]  |
| Required Validation       | [x]  | [ ]  |
| Email Validation          | [x]  | [ ]  |
| Password Validation       | [x]  | [ ]  |
| Confirm Password          | [x]  | [ ]  |
| Successful Login          | [x]  | [ ]  |
| Failed Login              | [x]  | [ ]  |
| Successful Registration   | [x]  | [ ]  |
| Duplicate Email           | [x]  | [ ]  |
| Layout                    | [x]  | [ ]  |
| No Horizontal Scroll      | [x]  | [ ]  |
| Desktop View              | [x]  | [ ]  |
| Tablet View               | [x]  | [ ]  |
| Mobile View               | [x]  | [ ]  |
| Keyboard Navigation       | [x]  | [ ]  |
| Screen Reader Labels      | [x]  | [ ]  |
| Color Contrast            | [x]  | [ ]  |
| Password Masking          | [x]  | [ ]  |
| Error Message Safety      | [x]  | [ ]  |
| Performance               | [x]  | [ ]  |
| Browser Compatibility     | [x]  | [ ]  |
| Stability                 | [x]  | [ ]  |

---

# Testing Notes

**Tester:** Melissa Dickerson  
**Date:** 07/18/2026  
**Version Tested:** 1.0  
**Additional Notes:**  
(Write observations here.)

