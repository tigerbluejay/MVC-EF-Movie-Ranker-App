# MVC Entity Framework Movie Ranker App

This project is an ideal foundational example to learn MVC with Entity Framework.

At its core, it is simply a table displaying records of Movies and their ranking (in descending order) according to a score - assigned by the user, which is defined between 0 and 100. The user can visualize the records ranked by Score, they can add new records, edit existing records and delete them as well. Notification messages show at the top right every time an operation has been successful.

Although the app is simple, there are many features of MVC applications at play.

The list of features is long, here are some of them:

## Features

### On the Front End:
- Use of GetBootstrap.com's navigation bar
- Implementation of Bootswatch Theme
- Implementation of Tostr Notifications
- The implementation of Views using Tag Helpers
- Use of jQuery to provide front end validation
- Creation of Models inside the view with the Create action to add records.
- Displaying of Model data within the Views
- Calls to relevant css files in the underscore Layout master page.

### On the Back End - Database Related:
- Definition of a connection string in appsettings.json
- The creation of ApplicationDbContext
- Adding scripts in the pipeline in Program.cs to connect with the database 
- The addition of a Model with Data Annotations that impact table design in the database as well as front end display
- Use of EF migrations to create the database table based on the Model
- The use of Add, Update and Remove to impact records in the database

### Additional Backend:
- EF Core, EF SQL, EF Tools Dependencies added via the NuGet Console Manager
- Fetching object models by id
- Passing object models to the Views
- LINQ Query ordering movies by score
- Backend validation that score does not exceed 100
- Implementation of Temp Data to display Success Messages
- Decoration with Attributes on the Post Methods

Debugging the project with breakpoints might be the most useful thing beginners can do to understand the different parts at play. 


