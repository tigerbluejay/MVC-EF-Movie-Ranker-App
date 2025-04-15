# MVC Entity Framework Movie Ranker App

This project is an ideal foundational example to learn MVC with Entity Framework.

This web application is a full-stack .NET 6 MVC app built with Entity Framework Core 6 using the Code-First approach. Users can add, edit, and rank movies, with full CRUD functionality, model validation, and LINQ-based data access. Designed as a learning tool, it showcases how to build a real-world MVC app with EF Core 6 from scratch.

At its core, it is simply a table displaying records of Movies and their ranking (in descending order) according to a score - assigned by the user, which is defined between 0 and 100. The user can visualize the records ranked by Score, they can add new records, edit existing records and delete them as well. Notification messages show at the top right every time an operation has been successful.

Although the app is simple, there are many features of MVC applications at play.

The list of features is long, here are some of them:

## Features

### On the Front End:
- Creation of Models inside the view with the Create action to add records.
- Displaying of Model data within the Views
- Use of GetBootstrap.com's navigation bar and icons
- Implementation of Bootswatch Theme
- The implementation of Views using Tag Helpers
- Use of jQuery to provide front end validation
- Implementation of Tostr Notification Alerts

### On the Back End - Database Related:
- The addition of a Model with Data Annotations that impact table design in the database as well as front end display
- EF Core, EF SQL, EF Tools Dependencies added via the NuGet Console Manager
- Definition of a connection string in appsettings.json
- The creation of ApplicationDbContext class
- Adding scripts in the pipeline in Program.cs to connect with the database 
- Use of EF migrations to create the database table based on the Model
- Creation of relevant Actions for GET and POST scenarios (Create, Edit, Delete)
- The use of Add, Update and Remove to impact records in the database in the respective actions within the Movie Controller.
- Fetching object models by id
- Passing object models to the Views
- LINQ Query ordering movies by score in the Index Action
- Server Side Validations with ModelState.IsValid
- Implementation of Temp Data to display Success Messages
- Decoration with Attributes on the Post Methods

Debugging the project with breakpoints might be the most useful thing beginners can do to understand the different parts at play. 

## Release Publication

Learn more about how to use this repo in the following link:

[Read Article](https://dev.to/josemariairiarte/create-a-basic-crud-app-with-net-mvc-ef-35in)
