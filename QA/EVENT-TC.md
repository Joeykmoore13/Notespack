# Events Page QA Test Plan

# Notespack

## Purpose
The purpose of this test plan is to verify that the **Events Page** (including Personal Events, University Events, and Event Modals) functions correctly, meets accessibility and responsiveness requirements, and aligns with the functional requirements defined in the project specification.

---

# Test Environment

## Supported Browsers
- Google Chrome
- Microsoft Edge
- Mozilla Firefox

## Supported Devices
- Desktop
- Tablet
- Mobile

---

# Functional Testing

## TC-EVENTS-001: Events Page Loads Successfully
**Priority:** High  
**Preconditions:** User is authenticated

### Steps
1. Log in.
2. Navigate to the Events page.

### Expected Result
- Events page loads fully without errors.

**Status:** [x] Pass [ ] Fail

---

## TC-EVENTS-002: Personal Events Display Correctly

### Steps
1. Ensure at least one personal event exists in the database.
2. Navigate to the Events page.
3. Locate the **My Personal Events** section.

### Expected Result
- Personal events appear in a grid layout.
- Each event card displays:
    - Title
    - Description
    - Date badge
    - Time
    - Location
- No missing or null fields.
- No broken images.

**Status:** [x] Pass[ ] Fail

---

## TC-EVENTS-003: University Events Display Correctly

### Steps
1. Ensure university events exist.
2. Scroll to the **Official University Events** section.

### Expected Result
- University events load correctly.
- Cards display:
    - Title
    - Description
    - Date badge
    - Time
    - Location (or “Campus”)
- No broken images or layout issues.

**Status:** [x] Pass [ ] Fail

---

## TC-EVENTS-004: Empty State Displays Correctly

### Steps
1. Remove all personal events for the test user.
2. Navigate to the Events page.

### Expected Result
- Empty state card appears.
- Message: *“No personal events yet”*
- CTA button: *“Create your first event”*
- No duplicate empty-state cards.

**Status:** [x] Pass [ ] Fail

---

## TC-EVENTS-005: Create Event Modal Opens

### Steps
1. Click **+ Create New Event** button.
2. Observe window behavior.

### Expected Result
- Create Event modal appears centered.
- Modal contains all required fields:
    - Title
    - Description
    - Start Date
    - End Date
    - Time
    - Address
- Close button works.

**Status:** [x] Pass [ ] Fail

---

## TC-EVENTS-006: Create Event Form Validation

### Steps
1. Open Create Event window.
2. Attempt to submit with empty fields.
3. Enter invalid values (too short title, missing date, etc.).

### Expected Result
- Required fields enforce validation.
- Title enforces minlength = 3, maxLength = 60.
- Description enforces maxlength = 200.
- Address enforces maxlength = 100.
- Dates and time must be valid.

**Status:** [x] Pass [ ] Fail

---

## TC-EVENTS-007: Event Creation Saves Correctly

### Steps
1. Fill out the Create Event form with valid data.
2. Submit the form.
3. Verify event appears in Personal Events grid.

### Expected Result
- Event is saved.
- Event card displays correct values.
- No missing fields.
- No console errors.

**Status:** [x] Pass [ ] Fail

---

## TC-EVENTS-008: Edit Event Modal Opens

### Steps
1. Click **Edit Event Details →** on a personal event card.
2. Observe window behavior.

### Expected Result
- Edit Event window opens.
- Fields are pre-filled with correct event data.
- Close button works.

**Status:** [x] Pass [ ] Fail

---

## TC-EVENTS-009: Edit Event Saves Correctly

### Steps
1. Open Edit Event window.
2. Modify at least three fields.
3. Save changes.
4. Verify updated event card.

### Expected Result
- Updated values appear immediately.
- No stale data.
- No console errors.

**Status:** [x] Pass [ ] Fail

---

## TC-EVENTS-010: Delete Event Works Correctly

### Steps
1. Click the trash icon on a personal event card.
2. Confirm deletion.
3. Refresh the page.

### Expected Result
- Event is removed from UI.
- Event is removed from database.
- No ghost cards remain.

**Status:** [x] Pass [ ] Fail

---

# Layout Testing

## TC-EVENTS-011: Grid Layout Renders Correctly

### Expected Result
- 3-column layout on desktop.
- 2-column layout on tablet.
- 1-column layout on mobile.
- No overlapping elements.

**Status:** [x] Pass [ ] Fail

---

## TC-EVENTS-012: No Horizontal Scrolling

### Expected Result
- Page fits screen width.
- No unintended horizontal scrollbars.

**Status:** [x] Pass [ ] Fail

---

# Responsive Testing

## TC-EVENTS-013: Desktop View (1920x1080)

### Expected Result
- Full grid visible.
- Windows centered.
- Text readable.

**Status:** [x] Pass [ ] Fail

---

## TC-EVENTS-014: Tablet View

### Expected Result
- Navigation adapts.
- Event cards resize properly.
- Windows remain usable.

**Status:** [x] Pass [ ] Fail

---

## TC-EVENTS-015: Mobile View

### Expected Result
- Single-column layout.
- Buttons accessible.
- Text readable.
- Windows fit screen.

**Status:** [x] Pass [ ] Fail

---

# Accessibility Testing

## TC-EVENTS-016: Keyboard Navigation

### Steps
Navigate entire Events page using only **Tab**.

### Expected Result
- All interactive elements reachable.
- Focus indicators visible.
- Windows trap focus correctly.

**Status:** [x] Pass [ ] Fail

---

## TC-EVENTS-017: Color Contrast

### Expected Result
- Text readable against backgrounds.
- Date badges and buttons meet WCAG contrast.

**Status:** [x] Pass [ ] Fail

---

## TC-EVENTS-018: Image Alt Text

### Expected Result
- All event images have alt text or decorative roles.
- No missing alt attributes.

**Status:** [x] Pass [ ] Fail

---

# Performance Testing

## TC-EVENTS-019: Events Page Load Speed

### Expected Result
- Page loads within acceptable time.
- No lag when rendering multiple cards.

**Status:** [x] Pass [ ] Fail

---

## TC-EVENTS-020: Browser Compatibility

### Expected Result
- Events page displays consistently across Chrome, Edge, Firefox.

**Status:** [x] Pass [ ] Fail

---

# Content Validation

## TC-EVENTS-021: Spelling and Grammar

### Expected Result
- No spelling errors in titles, labels, or descriptions.
- Consistent formatting.

**Status:** [x] Pass [ ] Fail

---

# Stability Testing

## TC-EVENTS-022: Refresh Stability

### Steps
1. Refresh the Events page multiple times.

### Expected Result
- Page remains functional.
- No rendering issues.
- No duplicate elements.

**Status:** [x] Pass [ ] Fail

---

# QA Summary Checklist

| Test                      | Pass | Fail |
|---------------------------|:----:|:---:|
| Events Page Loads         | [x]  | [ ] |
| Personal Events Display   | [x]  | [ ] |
| University Events Display | [x]  | [ ] |
| Empty State               | [x]  | [ ] |
| Create Modal              | [x]  | [ ] |
| Create Validation         | [x]  | [ ] |
| Create Saves              | [x]  | [ ] |
| Edit Modal                | [x]  | [ ] |
| Edit Saves                | [x]  | [ ] |
| Delete Event              | [x]  | [ ] |
| Layout                    | [x]  | [ ] |
| Desktop View              | [x]  | [ ] |
| Tablet View               | [x]  | [ ] |
| Mobile View               | [x]  | [ ] |
| Keyboard Navigation       | [x]  | [ ] |
| Color Contrast            | [x]  | [ ] |
| Alt Text                  | [x]  | [ ] |
| Performance               | [x]  | [ ] |
| Browser Compatibility     | [x]  | [ ] |
| Spelling & Grammar        | [x]  | [ ] |
| Stability                 | [x]  | [ ] |

---

# Testing Notes

**Tester:** Melissa Dickerson  
**Date:** *07/07/2026*  
**Version Tested:** Version 1.0  
**Additional Notes:** Backend integration required for full CRUD validation.

