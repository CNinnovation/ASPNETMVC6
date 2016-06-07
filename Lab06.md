# Lab 06 - Entity Framework Core

## Create a Model

1. Create a .NET Core console application
2. Create a model type, e.g. the class `Book`
3. Add properties to the model type, e.g. BookId, Title, and Publisher

## Create a Context

1. Create a BooksContext class that derives from DbContext
2. Add the necessary NuGet packages
3. Define a property to access the Book type using DbSet

## Add new objects

1. Instantiate the context in the Main method
2. Add new objects
3. Save changes

## Make a connection to the SQL Server database

1. Override the configuring method of the context
2. Configure to use SQL Server
3. Add the necessary NuGet package
