##WebShop##

- Make sure Docker instance is running.
- Insert the correct password in the appsettings.json files (same as in project, not included here).
- In Package manager Console in Visual Studio, run:
Update-Database

Then run the solution via Visual Studio.

#Missing:#
- Unit and integration tests (they will be written first)
- Data in the database
- Implementation of Windsor Di Container?
- Implementation of Roles and AuthorizeAttribute
- Implementation of news controller
- Implemententation of orders controller to handle orders
- Checkout functionality
- Filter capability on fetching products from the api, on product names.
- pagination support from the api

#How to testst:#
- Run the code in Visual Studio after settig a break point in the controller, then it will be possible to step through and have a look.
- Run the automated tests
- Use the browser and brows to:
 -- api/products
- Use a Rest clieand and Post to:
 -- api/products
 

