##WebShop##

- Install dotnet core 3.1
- Make sure Docker instance with MySql is running (or any MySql instance).
- Insert the correct password in the appsettings.json files in the code projects (easily done with Ctrl+H).
- Change the default project to WebShop.DataAccess in package manager console
- In the Package manager Console in Visual Studio, run:
Update-Database

Then run the solution via Visual Studio, or see the 'How to test' section below.

#Missing:#
- Most Unit and integration tests for required functionality, there are some created. There are tests made for saving and reading products to database.
- Data in the database (you have to Post your own, see below in the 'How to test' section).
- Implementation of roles and AuthorizeAttribute.
- Implementation of the news controller.
- Implemententation of the orders controller to handle orders.
- Checkout functionality.

#Done stuff#
- Filter capability on fetching products from the api, on product names.
- Can save and read products from the database via Products controller
- Pagination support from the api


#How to test#
- Run the code in Visual Studio after settig a break point in the controller, it will then be possible to step through and have a look at stuff.
- Run the automated tests for products. Note: the tests delete all products from the database prior to using the db, this is a quick solution. Could be handeled with InMemoryDb instead that does not commit to database, or could have never comitted the transactions when testing. Or perhaps one could have a dedicated database for this, where we can mess around as we please.
- Run the code in Visual Studio and use a browser to browse to:
 -- /api/products
 
- Run the code in Visual Studio and use a Rest client and Post to:
 -- /api/products
 Content:
 ```json
[{
  "name": "ShinyStuff",
  "price": 99,
  "description": "From Sparkly Companies Limited"
},{
  "name": "Great shiny product",
  "price": 123,
  "description": "drop table product;"
}]
```
 , then browse to: /api/products
- Try: /api/products?nameFilter=drop%20table%20product
	, then /api/products - we can see everything i still there.
- Try: /api/products?itemsPerPage=1&getPage=2
	, we should get the second item in the list (order is not explicitly implemented, but from the list as shown by /api/products).
