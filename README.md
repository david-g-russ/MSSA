# MSSA
Projects completed while attending Microsoft Software &amp; Systems Academy

WEEK 1:

	Assignment 1.1 - 
    	1. Create a simple console application and store your name, age (should take decimal), 
	address in a string variable and print them back on console.
   		2. Create a simple console application and declare basic datatypes like int, float, decimal,
		double and print their min and	max values.
	Assignment 1.2 -
		1. Write a simple application to perform calculation functions. Call them appropriately when user
		selects the proper menu.
		2. Write a C# Sharp program to accept two integers and check whether they are equal or not.
		3. Write a C# Sharp program to find the sum of first 10 natural numbers.
	Assignment 1.3 - 
		1. Write a program in C# to calculate area of triangle, square and rectangle. Write 3 different
		functions for each shape .
		to take dimensions of figure and display the area. You may create menus.
		2. Write a program in C# to read n number of values in an array and display it in reverse order.
		3. Write a program to sort an integer array in ascending and descending order. Array can be
		created with hard coded values.
	Assignment 1.3.1 -
		1. Write a simple console application to generate mathematical errors and handle them by exception
		handling.
		2. Use debugging tools in Visual studio.
	Assignment 1.4 -
		1. Create a structure named “Point” and 2 data members: X and Y coordinate. Declare 2 points: P1
		and P2. Determine if P2 is to the right or left of P1 or on same axis , by comparing the x
		coordinates. (if p1.x is more than p2.x , it is to the right)
		2. Write a class: “Student” with private data members: StudentId ( int), StudentFname (stirng),
		StudentLname (string ), StudentGrade ( char ) and public properties for each data member. 
		Instantiate the class and assign data to properties.call get and set properties.

WEEK 2:

	Assignment 2.1 -
		1. Write a base class: ‘Shape’ and add properties like id, name and color and method like 
		‘calculate area’ . Inherit circle shape from base class and add properties like radius. override 
		calculate area logic for circle. Inherit square class from shape and add change the calculate area
		logic. Add property like side of square. Take the input from user to select circle or square and 
		display the calculated area . no hard coded values!
		2. Design a class hierarchy of your choice.
	Assignment 2.2 -
		1. Write a console application to create a text file and save your basic details like name, age,
		address ( use dummy data). Read the details from same file and print on console.
		2. Design a tip calculator : enter the bill total, tip % and display grand total after adding tip.
		Use the format specifiers to display currency, % symbol.
		
WEEK 3: SQL Training, completed in virtual machine labs.

WEEK 4:

	Assignment 4.1 -
		1. Return even numbers. Write a method that returns a string of even numbers greater than 0 and 
		less than 100.
		2. If year is leap. Given a year as integer, write a method that checks if year is leap.
		3. String in reverse order. Given a string, write a method that returns that string in reverse 
		order.
		4. Write a program in C# Sharp to create a function to input a string and count number of spaces
		are in the string.
	Assignment 4.2 -
		1. Create a 2D array to store integers and print them in matrix format with proper formatting.
		2. Write a program in C# Sharp for addition of two Matrices of same size.
		3. Create a console application to create following overloaded methods:
			Int Add(int a, int b) , int Add(int a,int b, int c)
			float Multiply(float a, float b), float Multiply(float a , float b, float c)
			Call the above methods by providing a menu to user.
		4. Create a console application to overload “+” and “-“ operator for adding the areas of 2 circles
		and getting their area difference respectively.
	Assignment 4.3 -
		1. Windows form assignment: Use different controls on windows forms and change their properties.
		2. Create a structure : Student with fields like studid, firstname, lastname, address,
		monthofadmission,grade .: A, B,C. Create a list of students and perform following operations in
		windows application: Add new records, delete record and display them in grid. Monthofadmission 
		should be enum.
	Assignment 4.4 -
		1. Events, delegates:
		Create a windows form application to display bank account details. Create an event for low 
		balance and as soon as balance goes lower than 200, notify by raising the low balance event.
		Use delegates.
		2. Organizing data into collections:
		Create an abstract base class to represent “Beverage” and inherit “Coffee” class from it. Create
		a generic list ( you may use Dictionary/Sortedlist) of coffees. Design windows form application
		to display the list of coffees in grid and perform add/ delete.
		
WEEK 5:

	Assignment 5.1 -
		1. Create employee class and use type safe collections like stack, dictionary etc. to store
		employee records and to use basic methods like add, delete on these collections.
		2. Create an interface for ICalculator for methods like add, subtract, divide , multiply and
		implement them in a class.etc.
	Assignment 5.3 -
		1. Create any user defined class of your choice like Student, Customer etc. Add 3 properties in it
		(of your choice). Serialize and deserialize the object of this class by Binary, XML, JSON format.
	Assignment 5.4 -
		1. Try out different controls in wpf (xaml application).
		2. Create a class library with BookRepository class and add methods like AddBook, DisplayBooks. Add 
		reference of this class library in windows form application and call methods appropriately. Convert 
		the windows forms application ( of emp management system) to use class library

WEEK 6:

	Assignment 6.2 -
		1. Create a table "Cars". Add columns like VIN, Make, Model, Year, Price etc.
		2. Create a Windows forms app to display records in grid. Perform basic CRUD.

WEEK 7: Creating Reusable Types & Assemblies, Encrypting and Decrypting Data. Assignments completed in virtual labs.

WEEK 8: Project Week.

WEEK 9: Project Week.

	Project: Personal Financial Application
	Functionality:
		1. User log-in, log-out, registration, password recovery, password update.
		2. User dashboard displaying graph visualization of past month of transactions, table of past and 
		future	transactions, loan balance, and budget category spending for the past month.
		3. View, modify, remove transactions (both positive and negative) stored in SQL database. 
		Transaction properties: name, value, date (past or future), recurrence interval, contribution 
		towards a loan, budget category. Table display (separated by past and future), graph visualization
		for past month.	Updating (or removing) any recurring transaction will modify all future occurences.
		4. View, modify, remove loans stored in SQL database. Loan properties: name, balance, duration, 
		APR, standard payment amount (auto-calculated based on other fields). Table display and chart 
		visualization for loan pay-off with balance paid and remaining. Modification of loan will update 
		anticipated future transactions with appropriate standard payment amount.
		5. Calendar that allows user to view the net change and balance for each day of the month, 
		scrollable. Graph visualization for currently displayed month finances.
		6. View, modify, and remove budget categories stored in SQL database. Graph visualization of 
		spending for the past month, pie chart for budget category spending for the past month. Updating a
		budget category will update all relevant transactions to reflect the new category, removing will 
		modify all relevant transactions to the Miscellaneous category.

WEEK 10: 

	Assignment 10.1 -
		1. Design an “About Me” page to describe about your educational background, work experience, 
		hobbies, professional aspirations. Use all the basic text tags that we have used like headings, 
		paragraph, styles, links, images. You may use colors, styles , formatting. This will be a read only 
		page( no input controls).
		2. Use HTML5 controls as needed.
	Assignment 10.2 -
		1. Write inline javascript functions to perform simple arithmetic functions like add, subtract, 
		multiply and divide. Provide 2 input boxes to enter 2 numbers. Search these input boxes by using DOM
		and then perform the calculations. 4 buttons can be used to invoke the functions.
		2. Design a simple form to allow users to enter their hobby. If user clicks on “add more hobby” add
		more text box control dynamically using DOM.
		3. Declare arrays of string. Enter user defined data into it and perform basic operations on array.
	Assignment 10.2.1 - 
		1. Design a registration form having minimum 10 fields. Apply validations using HTML5 attributes and
		using javascript.
	Assignment 10.3 -
		1. Modify the about us page to use text styling, graphical effects.
		2. Modify the existing website to add video and audio tags. Also add the geolocation api to get 
		user’s location.
	Assignment 10.4 -
		1. Modify existing website to have adaptive user interface. Modify the about us page to print it 
		without graphics and multimedia.
		2. Design a static website for an “Art Gallery”. Have following pages in them:
			-Home page
			-About Us page
			-Contact Us page
			-Sign up page to get updates ( user can register to get good deals)
			-Gallery page to display products ( paintings, frames) with description and price.

WEEK 11:

	Assignment 11.1 -
		1. Continue on art gallery website.
	Assignment 11.3 -
		1. Create a simple ASP.NET CORE MVC application and print “hello world”.
	Assignment 11.4 -
		1. Create an empty mvc application . add the static files created in html5. Use the static files 
		middleware to display static files. You may use the About Me html page created before.
		2. Create an empty mvc application . Add interface: Idata containing basic CRUD , 
		add model : Product. Add class : ProductData implementing Idata to create repository. 
		Use dependency injection.
		
WEEK 12:

	Assignment 12.1 -
		1. Create an empty template mvc project. Add Product class as a model class with following fields:
			a. Product Id
			b. Product Name
			c. Product Description
			d. Product price
			e. Product image
		2. Add a IproductRepository with basic CRUD methods and write a class ProductRepository to implement
		these methods.
		3. Register this service in Configure services method
		4.  Add a ProductController to have action method “DisplayAll” which will return “AllProductsView”.
		This view will display all the products from repository.
		5. Provide a link to click on each product and see the details of individual product like photo, 
		description and price.
	Assignment 12.2 -
		1. Use the HTML / tag Helpers to create display and edit views in product website.
		2. Create MVC core web app to create: “Books Gallery” . UI to display necessary menu links like : 
		Home, About, Books. Click on Books link to display names of books and click on each book to see details
		of each book ( like photo, author, description). Book model class will also be needed.
	Assignment 12.3 -
		1. Implement CRUD by using repository pattern for product website. Modify the existing mod 4 lab to add
		create, update and delete products.
		2. Use validation attributes.
	Assignment 12.4 -
		1. Modify existing products website application to now work with SQL databases.
		
WEEK 13:

	Assignment 13.1 -
		1. Create a separate layout for 1 or 2 views to display different layout than other. You may decide 
		which views from product website.
		2. Explore different bootstrap elements and check whether you could modify the product website with 
		different bootstrap.
	Assignment 13.2 -
		1. Modify product website to redirect to custom error page in production environment and developer 
		exception page in development environment.
	Assignment 13.2.1 -
		1. Create a web api to return data from a repository. May use the products related repository classes.
		2. Use this web api in any (new) mvc application to display the data.
	Assignment 13.3 -
		1. Apply security in products website to create login and account creation for new customer . Allow 
		customer to log in.
		2. Restrict the crud operations to only admins. Allow product display to customers.

WEEK 14: Azure Fundamentals, assignments completed in virtual labs.

WEEK 15: Project Week.

WEEK 16: Developing Solutions for Azure, assignments completed in virtual labs.
