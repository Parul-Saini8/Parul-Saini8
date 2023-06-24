# Fitness Tracker

This repository contains the code for a Fitness Tracker web application.

## Assignment 2 Updates

In Assignment 2, the following updates were made to the project:

### Craft Model (Craft.cs)

- Added additional properties relevant to the Fitness Tracker theme.
- Updated the Craft class to include new properties such as ID, Name, Description, DateCreated, Creator, Quantity, and Category.

### Index Page (Index.cshtml)

- Updated the Index page to display a table with the crafts' details.
- Added columns for ID, Name, Description, Date Created, Creator, Quantity, and Category.
- Iterated over the list of crafts in the Model to populate the table.

### Program.cs

- Updated the Main method to ensure the database is created and seeded when necessary.

## How to Run the Application

To run the Fitness Tracker application, follow these steps:

1. Clone the repository to your local machine.

2. Make sure you have the necessary software installed, including .NET Core.

3. Open a terminal or command prompt and navigate to the project directory.

4. Run the following command to build the application:

   ```bash
   dotnet build
