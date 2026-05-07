# Customer Feedback Portal

## Overview
The Customer Feedback Portal is an ASP.NET Core MVC application developed to allow users to submit feedback regarding products or services. This project serves as a practical implementation of various ASP.NET Core UI generation tools, specifically focusing on the use of built-in and custom TagHelpers, as well as built-in and custom HTML Helper methods to create a seamless, user-friendly data entry form.

## Key Features
* **Built-in TagHelpers:** Utilizes Form and Anchor TagHelpers to manage form submission routing and navigation.
* **HTML Helper Integration:** Implements standard HTML Helpers (`TextBoxFor`, `TextAreaFor`, `DropDownListFor`) to dynamically generate strongly-typed form fields bound to the data model.
* **Custom TagHelper:** Features a custom `<star-rating>` component that programmatically generates a visual 5-star rating interface based on integer input.
* **Custom HTML Helper:** Includes a custom extension method (`StyledInput`) that generates highly customized input fields with injected inline CSS styling and placeholder text.

## Technologies Used
* C#
* ASP.NET Core MVC (.NET)
* Razor Syntax (HTML/CSS)

## Project Structure
* **Models/Feedback.cs:** Defines the data structure for capturing the user's Name, Email, Rating, and Comments.
* **Controllers/FeedbackController.cs:** Manages HTTP GET and POST requests, handling the display of the form and the processing of submitted data.
* **Views/Feedback/Index.cshtml:** The primary Razor view containing the feedback form and integrated UI components.
* **TagHelpers/StarRatingTagHelper.cs:** Contains the backend logic for the custom visual star-rating component.
* **Helpers/MyHtmlHelpers.cs:** Contains the extension methods for generating custom-styled HTML inputs.

## How to Run the Project
1. Clone the repository to your local machine.
2. Open the solution file in Visual Studio.
3. Ensure that the required ASP.NET Core Web development tools are installed.
4. Press the **Start** (Play) button or press `F5` to build and run the application.
5. In your web browser, navigate to `/Feedback` to access the portal.
