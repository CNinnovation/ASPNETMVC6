# Lab 03 - ASP.NET Core

1. Create an empty ASP.NET Core Web Application
2. Add a simple HTML page (e.g. HelloWorld.html)
3. Try to access this HTML page from the browser
4. Enable returning a static HTML page
5. Use the *Map* method to create a simple route returning content to the client
6. Return data that is sent passing a parameter to the client, e.g. `server:port/Sample3?x=Hello`
7. Pass `x=<h1>Hello</h1>` from the client and return
8. Pass `x=<script>alert('hacker');</script>` from the client and return it
9. Encode the data before returned to the client
10. Use the *MapWhen* method to create a route with a condition
11. Create a HTML form and return it, like:

```html
<form method="post" action="/Sample4">
<input type="text" id="text1" name="text1" />
<br />
<button type="submit">Submit</button>
</form>
```

12. Return the information entered by the user to the browser - in an encoded form

## Dependency Injection

1. Create a custom service and a concrete implementation class
2. Add this service to the dependency injection container
3. Create a custom controller *SampleController* with constructor injection
4. Create another *Map* and use the custom controller

##  Middleware

1. Create and use a custom middleware
2. Define an extension method for easy use of the middleware
3. Add your own middleware to be used for each request


Questions:

1. What needs to be done to return static content like HTML, CSS, images...?
2. Which dependency injection framework is used with ASP.NET Core?
3. What are examples for pre-defined middleware?

