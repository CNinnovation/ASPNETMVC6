# Lab 05 - ASP.NET MVC View

## Create a View

1. Create a new controller `ViewsController`
2. Create the action method `Index` and return a view
3. Create a view returning HTML in the correct folder for the `Index` action method and the `ViewsController`
4. Create the action method `PassingData1` and return data to a corresponding view using `ViewBag`
5. Use Razor syntax to display the view data
5. Create the action method `PassingData2` and return data to the view using a model
6. Use Razor syntax to display model information

## Create a layout

1. Create a layout page and define to use the layout page by default
2. Create the action method `UsingLayout` and return a view that makes use of the layout page
3. Create an optional section in the layout page and specify to replace this section using the view

## Partial Views

1. Create a partial view `MyPartialView` and use it directly from the view `UsingLayout` using Razor code
2. Create a partial view `MyPartialBookView` and use a model for this view
3. Create a view where the `MyPArtialBookView`is used and pass the model to the partial view
4. Create the action method `GetBooks` and return a partial view, use a model. Extend the repository to return a list of books.
5. Use the partial view from a view using jQuery
