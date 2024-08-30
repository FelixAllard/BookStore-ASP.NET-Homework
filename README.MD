# Online Bookstore with ASP.NET Core




This is a simple project made in the context of my ASP.NET class in which we had to create a simple application implementing MVC pattern. You can find the assignment detail linked in the pdf file
---
## Overview
This project simulates the development of key features for an online bookstore using ASP.NET Core, focusing on Razor Pages, external CSS integration, data retrieval with `FirstOrDefault`, passing models to views, and using Tag Helpers. The project provides practical experience in ASP.NET Core web development.

## Objectives
- Implement Razor Pages for dynamic web UI development.
- Link external CSS files for consistent visual styling.
- Use the `FirstOrDefault` method to retrieve data from the database.
- Pass models from controllers to views for dynamic data display.
- Utilize Tag Helpers to create dynamic HTML content.

## Tasks and Deliverables

### Task 1: Implementing Razor Pages
- **Scenario**: The bookstore needs dynamic pages for book categories, individual book details, and user profiles.
- **Requirement**: Create a Razor Page for displaying individual book details, including HTML markup and C# code.
- **Example**: Implement a `BookDetailModel` Razor Page to display the title and description of a book.

### Task 2: Linking an External CSS File
- **Scenario**: The bookstore should maintain a consistent visual style across all pages.
- **Requirement**: Link an external CSS file to a Razor View.
- **Example**: Add a link to an external CSS file named `site.css` in the `<head>` section of a Razor View.

### Task 3: Using the FirstOrDefault Method
- **Scenario**: Retrieve book details from the database when a user selects a book.
- **Requirement**: Use the `FirstOrDefault` method in the data context to find a book by its ISBN.
- **Example**: Write a method in your data context to retrieve a book's details using its ISBN.

### Task 4: Passing a Model to a View Through the Controller
- **Scenario**: Display detailed information of a book on a separate page when a user clicks on the book title.
- **Requirement**: Pass a model containing book details from the controller to the view.
- **Example**: Implement an `IActionResult` method in the controller that retrieves a book by ID and passes it to a view.

### Task 5: Using Tag Helpers for Dynamic Link Creation
- **Scenario**: Dynamically create navigation links to different book categories in the bookstore’s menu.
- **Requirement**: Utilize Tag Helpers to generate dynamic links based on book categories.
- **Example**: Use Tag Helpers to create a link to the "Science" category in the bookstore navigation menu.
