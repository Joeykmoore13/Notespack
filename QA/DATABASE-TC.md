# Database QA Test Plan
# Notespack
## Purpose
The purpose of this test plan is to verify that the **database layer** of the Notespack application functions correctly, maintains data integrity, enforces validation rules, and supports all CRUD operations required by the system.

This includes testing:
- Event Data Model
- User Authentication Data
- CRUD operations
- Validation
- Referential integrity
- Performance
- Stability

---

# Test Environment

## Database
- SQL Server
- EF Core Migrations Applied
- Seed Data (Optional)

## Tools
- SQL Server Management Studio (SSMS)
- Application UI (for CRUD testing)
- EF Core logs

---

# Functional Testing

## TC-DB-001: Event Record Saves Successfully
**Priority:** High  
**Preconditions:** User authenticated; database running

### Steps
1. Navigate to **Create Event** page.
2. Enter valid values for all required fields.
3. Submit the form.
4. Open SSMS and query the Events table.
5. Locate the newly created event.

### Expected Result
- Event record exists in the database.
- All required fields contain correct values.
- No null values for required fields.
- No constraint violations.

**Status:** [ ] Pass [ ] Fail

---

## TC-DB-002: Event Record Retrieves Correctly

### Steps
1. Create an event.
2. Navigate to **Events Page** or **Dashboard**.
3. Locate the event card.
4. Compare displayed values with database values.

### Expected Result
- UI displays the exact values stored in the database.
- No mismatched or stale data.
- No formatting errors.

**Status:** [ ] Pass [ ] Fail

---

## TC-DB-003: Event Update Persists Correctly

### Steps
1. Create an event.
2. Open **Edit Event** modal.
3. Modify at least three fields.
4. Save changes.
5. Query the database for the updated event.

### Expected Result
- Updated values are saved correctly.
- No partial updates.
- No duplicate records created.
- UI reflects updated values.

**Status:** [ ] Pass [ ] Fail

---

## TC-DB-004: Event Delete Removes Record

### Steps
1. Create an event.
2. Delete the event using the UI.
3. Query the database for the event ID.

### Expected Result
- Event record is fully removed.
- No orphaned or ghost records.
- No foreign key violations.

**Status:** [ ] Pass [ ] Fail

---

## TC-DB-005: Required Fields Enforce Validation

### Steps
1. Attempt to create an event with missing required fields:
    - Title
    - Description
    - Date
    - Start Time
    - End Time
    - Location
    - Category
2. Submit the form.

### Expected Result
- Database rejects invalid inserts.
- EF Core validation prevents saving.
- No malformed records appear in the database.

**Status:** [ ] Pass [ ] Fail

---

## TC-DB-006: String Length Constraints Enforced

### Steps
1. Attempt to save:
    - Title < 6 characters
    - Title > 60 characters
    - Description > 200 characters
    - Address > 100 characters
2. Submit the form.

### Expected Result
- Database prevents invalid string lengths.
- EF Core model validation triggers errors.
- No truncated or malformed data saved.

**Status:** [ ] Pass [ ] Fail

---

## TC-DB-007: Date and Time Fields Validate Correctly

### Steps
1. Attempt to save:
    - End Date earlier than Start Date
    - Invalid date formats
    - Invalid time formats
2. Submit the form.

### Expected Result
- Database rejects invalid date/time combinations.
- EF Core validation prevents saving.
- No corrupted date/time values stored.

**Status:** [ ] Pass [ ] Fail

---

## TC-DB-008: User Authentication Records Save Correctly

### Steps
1. Register a new user.
2. Query the Users table.
3. Verify:
    - Username
    - Email
    - Password hash
    - Created date

### Expected Result
- User record saved correctly.
- Password stored as a hash (never plain text).
- No duplicate users.

**Status:** [ ] Pass [ ] Fail

---

## TC-DB-009: User Authentication Retrieves Correctly

### Steps
1. Log in using a registered user.
2. Verify login succeeds.
3. Query database for user record.

### Expected Result
- Login matches stored credentials.
- No authentication errors.
- No incorrect user associations.

**Status:** [ ] Pass [ ] Fail

---

## TC-DB-010: Referential Integrity Maintained

### Steps
1. Create an event.
2. Delete the user who created the event (if allowed).
3. Check event record.

### Expected Result
- Either:
    - Event is deleted automatically (cascade), **or**
    - Event remains but references a valid user ID
- No foreign key violations.

**Status:** [ ] Pass [ ] Fail

---

# Performance Testing

## TC-DB-011: Query Performance

### Steps
1. Populate database with 100+ events.
2. Load Events page.
3. Measure query time.

### Expected Result
- Query executes within acceptable performance limits.
- No noticeable UI lag.
- No EF Core timeout errors.

**Status:** [ ] Pass [ ] Fail

---

## TC-DB-012: Bulk Insert Stability

### Steps
1. Insert 50+ events rapidly (script or UI).
2. Monitor database logs.

### Expected Result
- No deadlocks.
- No duplicate primary keys.
- No constraint violations.

**Status:** [ ] Pass [ ] Fail

---

# Stability Testing

## TC-DB-013: Migration Stability

### Steps
1. Run EF Core migrations.
2. Start application.
3. Verify database schema.

### Expected Result
- Migrations apply without errors.
- Schema matches Event Data Model.
- No missing tables or columns.

**Status:** [ ] Pass [ ] Fail

---

## TC-DB-014: Refresh Stability

### Steps
1. Perform multiple CRUD operations.
2. Refresh the application repeatedly.
3. Query database.

### Expected Result
- No duplicate records.
- No partial saves.
- No corrupted data.

**Status:** [ ] Pass [ ] Fail

---

# QA Summary Checklist

| Test | Pass | Fail |
|------|:---:|:---:|
| Event Save | [ ] | [ ] |
| Event Retrieve | [ ] | [ ] |
| Event Update | [ ] | [ ] |
| Event Delete | [ ] | [ ] |
| Required Field Validation | [ ] | [ ] |
| String Length Validation | [ ] | [ ] |
| Date/Time Validation | [ ] | [ ] |
| User Save | [ ] | [ ] |
| User Retrieve | [ ] | [ ] |
| Referential Integrity | [ ] | [ ] |
| Query Performance | [ ] | [ ] |
| Bulk Insert Stability | [ ] | [ ] |
| Migration Stability | [ ] | [ ] |
| Refresh Stability | [ ] | [ ] |

---

# Bug Severity Guidelines

| Severity | Description |
|---------|-------------|
| 🔴 Critical | Data corruption or loss; CRUD failure. |
| 🟠 High | Validation failures; incorrect data saved. |
| 🟡 Medium | Performance issues; slow queries. |
| 🔵 Low | Minor inconsistencies or formatting issues. |

---

# Testing Notes

**Tester:** Melissa Dickerson  
**Date:** *(Fill in during testing)*  
**Version Tested:** Version 1.0  
**Additional Notes:** Full CRUD testing requires backend integration.

