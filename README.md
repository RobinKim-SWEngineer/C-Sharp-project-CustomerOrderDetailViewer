![Image](https://github.com/RobinKim-SWEngineer/Images-for-document/blob/master/HappyProgrammer%20(1).jpg)

# Customer Order Detail Viewer

## What is this application about ?

This console application shows detail information about customer order, such as order-id and customer-id etc.

It gets necessary data from it's local Database and prints them on the console.


## How this program is made ?

1. MS SQL : Making a `View` in SQL and `Server connection`
   - View is a virtual table where our application *looks at* when running the program to fetch the data.
   - We connect to Database through Server Explorer in Visual Studio.
	 
	 > When making View from several tables, often **Inner Join** statement is used

2. C# : Making objects for `Data Model` and `Command`
   - Data model is simply a object whose properties are what we want to get from the DB's View.
     - Ex) order-id (int), product-name (string) etc.
   - Each model object is a single row returned from the interaction with DB, which is later appended to a list as `Data Models` object.
   - Command object has *commands* that we want to implement such as getting detail information about customer order.
   - It is good practice to put Data model class and Command class to **seperate folder** under the name `Model` and `Respository` repectively.
	 
	 > Key library and classes : System.Data.SqlClient => Class SqlConnection, SqlCommand, SqlDataReader.
