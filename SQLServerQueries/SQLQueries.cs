using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServerQueries
{
  class SQLQueries
  {
    static void Main(string[] args)
    {
    }

    static void Queries()
    {
      /**
The following SQL statement selects all the records in the "Customers" table
SELECT * FROM Customers;


The following SQL statement selects the "CustomerName" and "City" columns from the "Customers" table
SELECT CustomerName,City FROM Customers;
      
The following SQL statement selects only the distinct values from the "City" columns from the "Customers" table
  SELECT DISTINCT City FROM Customers;

The following SQL statement selects all the customers from the country "Mexico", in the "Customers" table

SELECT * FROM Customers
WHERE Country='Mexico';
  
The following SQL statement selects all customers from the country "Germany" AND the city "Berlin", 
       * in the "Customers" table
SELECT * FROM Customers
WHERE Country='Germany'
AND City='Berlin';


The following SQL statement selects all customers from the "Customers" table, sorted by the "Country" column:
SELECT * FROM Customers
ORDER BY Country;

The following SQL statement selects all customers from the "Customers" table, sorted DESCENDING by the "Country" column:
SELECT * FROM Customers
ORDER BY Country DESC;


Assume we wish to insert a new row in the "Customers" table.

We can use the following SQL statement:
INSERT INTO Customers (CustomerName, ContactName, Address, City, PostalCode, Country)
VALUES ('Cardinal','Tom B. Erichsen','Skagen 21','Stavanger','4006','Norway');


The following SQL statement will insert a new row, but only insert data in the "CustomerName", "City", and "Country" columns
       * (and the CustomerID field will of course also be updated automatically):
INSERT INTO Customers (CustomerName, City, Country)
VALUES ('Cardinal', 'Stavanger', 'Norway');


Assume we wish to update the customer "Alfreds Futterkiste" with a new contact person and city.

We use the following SQL statement:
UPDATE Customers
SET ContactName='Alfred Schmidt', City='Hamburg'
WHERE CustomerName='Alfreds Futterkiste';


Assume we wish to delete the customer "Alfreds Futterkiste" from the "Customers" table.

We use the following SQL statement:
DELETE FROM Customers
WHERE CustomerName='Alfreds Futterkiste' AND ContactName='Maria Anders';

SQL injection
The only proven way to protect a web site from SQL injection attacks, is to use SQL parameters.

SQL parameters are values that are added to an SQL query at execution time, in a controlled manner.
  txtUserId = getRequestString("UserId");
txtSQL = "SELECT * FROM Users WHERE UserId = @0";
db.Execute(txtSQL,txtUserId);
  
   another example
     txtNam = getRequestString("CustomerName");
txtAdd = getRequestString("Address");
txtCit = getRequestString("City");
txtSQL = "INSERT INTO Customers (CustomerName,Address,City) Values(@0,@1,@2)";
db.Execute(txtSQL,txtNam,txtAdd,txtCit);


select statement
txtUserId = getRequestString("UserId");
sql = "SELECT * FROM Customers WHERE CustomerId = @0";
command = new SqlCommand(sql);
command.Parameters.AddWithValue("@0",txtUserID);
command.ExecuteReader();

insert statement
txtNam = getRequestString("CustomerName");
txtAdd = getRequestString("Address");
txtCit = getRequestString("City");
txtSQL = "INSERT INTO Customers (CustomerName,Address,City) Values(@0,@1,@2)";
command = new SqlCommand(txtSQL);
command.Parameters.AddWithValue("@0",txtNam);
command.Parameters.AddWithValue("@1",txtAdd);
command.Parameters.AddWithValue("@2",txtCit);
command.ExecuteNonQuery();


The following SQL statement selects the two first records from the "Customers" table:
SELECT TOP 2 * FROM Customers;


The following SQL statement selects the first 50% of the records from the "Customers" table:
SELECT TOP 50 PERCENT * FROM Customers;
  
The following SQL statement selects all customers with a City ending with the letter "s": 

The following SQL statement selects all customers with a Country containing the pattern "land":
      SELECT * FROM Customers
WHERE Country LIKE '%land%';
    
The following SQL statement selects all customers with Country NOT containing the pattern "land":
 SELECT * FROM Customers
WHERE Country NOT LIKE '%land%';

 The following SQL statement selects all customers with a City containing the pattern "es": 
SELECT * FROM Customers
WHERE City LIKE '%es%';
  
  
The following SQL statement selects all customers with a City starting with any character, followed by "erlin":
SELECT * FROM Customers
WHERE City LIKE '_erlin';
   
The following SQL statement selects all customers with a City starting with "L", followed by any character, followed by "n",
       * followed by any character, followed by "on":
SELECT * FROM Customers
WHERE City LIKE 'L_n_on';
  
The following SQL statement selects all customers with a City starting with "b", "s", or "p":
SELECT * FROM Customers
WHERE City LIKE '[bsp]%';
 
The following SQL statement selects all customers with a City starting with "a", "b", or "c":
SELECT * FROM Customers
WHERE City LIKE '[a-c]%';
 
The following SQL statement selects all customers with a City NOT starting with "b", "s", or "p":
SELECT * FROM Customers
WHERE City LIKE '[!bsp]%';

or

SELECT * FROM Customers
WHERE City NOT LIKE '[bsp]%';
    
The following SQL statement selects all customers with a City of "Paris" or "London":
SELECT * FROM Customers
WHERE City IN ('Paris','London');
   
 
The following SQL statement selects all products with a price BETWEEN 10 and 20:
SELECT * FROM Products
WHERE Price BETWEEN 10 AND 20;
   

The following SQL statement selects all products with a price BETWEEN 10 and 20, but products with a CategoryID of 1,2, 
       * or 3 should not be displayed:
 SELECT * FROM Products
WHERE (Price BETWEEN 10 AND 20)
AND NOT CategoryID IN (1,2,3);
 
   
The following SQL statement selects all orders with an OrderDate BETWEEN '04-July-1996' and '09-July-1996':
SELECT * FROM Orders
WHERE OrderDate BETWEEN #07/04/1996# AND #07/09/1996#;
    
The following SQL statement specifies two aliases, one for the CustomerName column and one for the ContactName column. 
       * Tip: It requires double quotation marks or square brackets if the column name contains spaces:
SELECT CustomerName AS Customer, ContactName AS [Contact Person]
FROM Customers; 


In the following SQL statement we combine four columns (Address, City, PostalCode, and Country) and create an alias 
       * named "Address":
SELECT CustomerName, Address+', '+City+', '+PostalCode+', '+Country AS Address
FROM Customers;

The following SQL statement selects all the orders from the customer with CustomerID=4 (Around the Horn).
       * We use the "Customers" and "Orders" tables, and give them the table aliases of "c" and "o" respectively
       * (Here we have used aliases to make the SQL shorter):
SELECT o.OrderID, o.OrderDate, c.CustomerName
FROM Customers AS c, Orders AS o
WHERE c.CustomerName="Around the Horn" AND c.CustomerID=o.CustomerID;


INNER JOIN: Returns all rows when there is at least one match in BOTH tables
LEFT JOIN: Return all rows from the left table, and the matched rows from the right table
RIGHT JOIN: Return all rows from the right table, and the matched rows from the left table
FULL JOIN: Return all rows when there is a match in ONE of the tables


Notice that the "CustomerID" column in the "Orders" table refers to the "CustomerID" in the "Customers" table. 
       * The relationship between the two tables above is the "CustomerID" column.

Then, if we run the following SQL statement (that contains an INNER JOIN):
 SELECT Orders.OrderID, Customers.CustomerName, Orders.OrderDate
FROM Orders
INNER JOIN Customers
ON Orders.CustomerID=Customers.CustomerID;
   
The following SQL statement will return all customers with orders:
SELECT Customers.CustomerName, Orders.OrderID
FROM Customers
INNER JOIN Orders
ON Customers.CustomerID=Orders.CustomerID
ORDER BY Customers.CustomerName;
   
The following SQL statement will return all customers, and any orders they might have: 
 SELECT Customers.CustomerName, Orders.OrderID
FROM Customers
LEFT JOIN Orders
ON Customers.CustomerID=Orders.CustomerID
ORDER BY Customers.CustomerName;
    
The following SQL statement selects all customers, and all orders:
SELECT Customers.CustomerName, Orders.OrderID
FROM Customers
FULL OUTER JOIN Orders
ON Customers.CustomerID=Orders.CustomerID
ORDER BY Customers.CustomerName;


The following SQL statement selects all the different cities (only distinct values) from the "Customers" and 
       * the "Suppliers" tables:
SELECT City FROM Customers
UNION
SELECT City FROM Suppliers
ORDER BY City;

The following SQL statement uses UNION ALL to select all (duplicate values also) German cities from the "Customers" and
       * "Suppliers" tables:
SELECT City, Country FROM Customers
WHERE Country='Germany'
UNION ALL
SELECT City, Country FROM Suppliers
WHERE Country='Germany'
ORDER BY City;

Create a backup copy of Customers:
SELECT *
INTO CustomersBackup2013
FROM Customers;
       
Use the IN clause to copy the table into another database:
SELECT *
INTO CustomersBackup2013 IN 'Backup.mdb'
FROM Customers;
       
Copy only a few columns into the new table:
SELECT CustomerName, ContactName
INTO CustomersBackup2013
FROM Customers;
       
Copy only the German customers into the new table:
SELECT *
INTO CustomersBackup2013
FROM Customers
WHERE Country='Germany';
       
Copy data from more than one table into the new table:
SELECT Customers.CustomerName, Orders.OrderID
INTO CustomersOrderBackup2013
FROM Customers
LEFT JOIN Orders
ON Customers.CustomerID=Orders.CustomerID;
   
Copy only a few columns from "Suppliers" into "Customers":
INSERT INTO Customers (CustomerName, Country)
SELECT SupplierName, Country FROM Suppliers;
       
Copy only the German suppliers into "Customers":
INSERT INTO Customers (CustomerName, Country)
SELECT SupplierName, Country FROM Suppliers
WHERE Country='Germany';
  

The following SQL statement creates a database called "my_db":
CREATE DATABASE my_db;


We use the following CREATE TABLE statement:

Example
CREATE TABLE Persons
(
PersonID int,
LastName varchar(255),
FirstName varchar(255),
Address varchar(255),
City varchar(255)
);

NOT NULL - Indicates that a column cannot store NULL value
UNIQUE - Ensures that each row for a column must have a unique value
PRIMARY KEY - A combination of a NOT NULL and UNIQUE. Ensures that a column (or combination of two or more columns) 
       * have a unique identity which helps to find a particular record in a table more easily and quickly
FOREIGN KEY - Ensure the referential integrity of the data in one table to match values in another table
CHECK - Ensures that the value in a column meets a specific condition
DEFAULT - Specifies a default value for a column
The next chapters will describe each constraint in detail.
The following SQL enforces the "P_Id" column and the "LastName" column to not accept NULL values:

Example
CREATE TABLE PersonsNotNull
(
P_Id int NOT NULL,
LastName varchar(255) NOT NULL,
FirstName varchar(255),
Address varchar(255),
City varchar(255)
) 

To allow naming of a UNIQUE constraint, and for defining a UNIQUE constraint on multiple columns, 
       * use the following SQL syntax:

MySQL / SQL Server / Oracle / MS Access:

ALTER TABLE Persons
ADD CONSTRAINT uc_PersonID UNIQUE (P_Id,LastName)

To drop a UNIQUE constraint, use the following SQL:

MySQL:

ALTER TABLE Persons
DROP INDEX uc_PersonID
SQL Server / Oracle / MS Access:

ALTER TABLE Persons
DROP CONSTRAINT uc_PersonID
    
To create a PRIMARY KEY constraint on the "P_Id" column when the table is already created, use the following SQL:
ALTER TABLE Persons
ADD PRIMARY KEY (P_Id)

To allow naming of a PRIMARY KEY constraint, and for defining a PRIMARY KEY constraint on multiple columns,
       * use the following SQL syntax:

MySQL / SQL Server / Oracle / MS Access:

ALTER TABLE Persons
ADD CONSTRAINT pk_PersonID PRIMARY KEY (P_Id,LastName)

To drop a PRIMARY KEY constraint, use the following SQL:

MySQL:

ALTER TABLE Persons
DROP PRIMARY KEY
SQL Server / Oracle / MS Access:

ALTER TABLE Persons
DROP CONSTRAINT pk_PersonID
  
The following SQL creates a FOREIGN KEY on the "P_Id" column when the "Orders" table is created:

MySQL:

CREATE TABLE Orders
(
O_Id int NOT NULL,
OrderNo int NOT NULL,
P_Id int,
PRIMARY KEY (O_Id),
FOREIGN KEY (P_Id) REFERENCES Persons(P_Id)
)
SQL Server / Oracle / MS Access:

CREATE TABLE Orders
(
O_Id int NOT NULL PRIMARY KEY,
OrderNo int NOT NULL,
P_Id int FOREIGN KEY REFERENCES Persons(P_Id)
)
To allow naming of a FOREIGN KEY constraint, and for defining a FOREIGN KEY constraint on multiple columns, 
       * use the following SQL syntax:

MySQL / SQL Server / Oracle / MS Access:

CREATE TABLE Orders
(
O_Id int NOT NULL,
OrderNo int NOT NULL,
P_Id int,
PRIMARY KEY (O_Id),
CONSTRAINT fk_PerOrders FOREIGN KEY (P_Id)
REFERENCES Persons(P_Id)
)
SQL FOREIGN KEY Constraint on ALTER TABLE
To create a FOREIGN KEY constraint on the "P_Id" column when the "Orders" table is already created, use the following SQL:

MySQL / SQL Server / Oracle / MS Access:

ALTER TABLE Orders
ADD FOREIGN KEY (P_Id)
REFERENCES Persons(P_Id)
To allow naming of a FOREIGN KEY constraint, and for defining a FOREIGN KEY constraint on multiple columns, 
       * use the following SQL syntax:

MySQL / SQL Server / Oracle / MS Access:

ALTER TABLE Orders
ADD CONSTRAINT fk_PerOrders
FOREIGN KEY (P_Id)
REFERENCES Persons(P_Id)
To DROP a FOREIGN KEY Constraint
To drop a FOREIGN KEY constraint, use the following SQL:

MySQL:

ALTER TABLE Orders
DROP FOREIGN KEY fk_PerOrders
SQL Server / Oracle / MS Access:

ALTER TABLE Orders
DROP CONSTRAINT fk_PerOrders

CREATE INDEX Example
The SQL statement below creates an index named "PIndex" on the "LastName" column in the "Persons" table:

CREATE INDEX PIndex
ON Persons (LastName)
If you want to create an index on a combination of columns, you can list the column names within the parentheses, 
       * separated by commas:

CREATE INDEX PIndex
ON Persons (LastName, FirstName)
   

The DROP DATABASE statement is used to delete a database.

DROP DATABASE database_name
The TRUNCATE TABLE Statement
What if we only want to delete the data inside the table, and not the table itself?

Then, use the TRUNCATE TABLE statement:

TRUNCATE TABLE table_name
   
Next, we want to delete the column named "DateOfBirth" in the "Persons" table.

We use the following SQL statement:

ALTER TABLE Persons
DROP COLUMN DateOfBirth
    
If you have the Northwind database you can see that it has several views installed by default.

The view "Current Product List" lists all active products (products that are not discontinued) from the "Products" table. 
       * The view is created with the following SQL:

CREATE VIEW [Current Product List] AS
SELECT ProductID,ProductName
FROM Products
WHERE Discontinued=No
We can query the view above as follows:

SELECT * FROM [Current Product List]
Another view in the Northwind sample database selects every product in the "Products" table with a unit price higher 
       * than the average unit price:

CREATE VIEW [Products Above Average Price] AS
SELECT ProductName,UnitPrice
FROM Products
WHERE UnitPrice>(SELECT AVG(UnitPrice) FROM Products)
We can query the view above as follows:

SELECT * FROM [Products Above Average Price]
Another view in the Northwind database calculates the total sale for each category in 1997. 
       * Note that this view selects its data from another view called "Product Sales for 1997":

CREATE VIEW [Category Sales For 1997] AS
SELECT DISTINCT CategoryName,Sum(ProductSales) AS CategorySales
FROM [Product Sales for 1997]
GROUP BY CategoryName
We can query the view above as follows:

SELECT * FROM [Category Sales For 1997]
We can also add a condition to the query. Now we want to see the total sale only for the category "Beverages":

SELECT * FROM [Category Sales For 1997]
WHERE CategoryName='Beverages'  
   
Date
If we use the same SELECT statement as above:

SELECT * FROM Orders WHERE OrderDate='2008-11-11'


How do we select only the records with no NULL values in the "Address" column?

We will have to use the IS NOT NULL operator:

SELECT LastName,FirstName,Address FROM Persons
WHERE Address IS NOT NULL
    
SQL Aggregate Functions
SQL aggregate functions return a single value, calculated from values in a column.

Useful aggregate functions:

AVG() - Returns the average value
COUNT() - Returns the number of rows
FIRST() - Returns the first value
LAST() - Returns the last value
MAX() - Returns the largest value
MIN() - Returns the smallest value
SUM() - Returns the sum
SQL Scalar functions
SQL scalar functions return a single value, based on the input value.

Useful scalar functions:

UCASE() - Converts a field to upper case
LCASE() - Converts a field to lower case
MID() - Extract characters from a text field
LEN() - Returns the length of a text field
ROUND() - Rounds a numeric field to the number of decimals specified
NOW() - Returns the current system date and time
FORMAT() - Formats how a field is to be displayed 
   
SELECT AVG(Price) AS PriceAverage FROM Products;
SELECT ProductName, Price FROM Products
WHERE Price>(SELECT AVG(Price) FROM Products);

SQL FIRST() Example
The following SQL statement selects the first value of the "CustomerName" column from the "Customers" table:

Example
SELECT FIRST(CustomerName) AS FirstCustomer FROM Customers; 
SELECT LAST(CustomerName) AS LastCustomer FROM Customers;
    
SELECT MAX(Price) AS HighestPrice FROM Products;


SELECT MIN(Price) AS SmallestOrderPrice FROM Products;
SELECT SUM(Quantity) AS TotalItemsOrdered FROM OrderDetails; 
    
SELECT Shippers.ShipperName,COUNT(Orders.OrderID) AS NumberOfOrders FROM Orders
LEFT JOIN Shippers
ON Orders.ShipperID=Shippers.ShipperID
GROUP BY ShipperName;
    
GROUP BY More Than One Column
We can also use the GROUP BY statement on more than one column, like this:

Example
SELECT Shippers.ShipperName, Employees.LastName,
COUNT(Orders.OrderID) AS NumberOfOrders
FROM (
            (Orders
INNER JOIN Shippers
ON Orders.ShipperID=Shippers.ShipperID
            )
INNER JOIN Employees
ON Orders.EmployeeID=Employees.EmployeeID
     )
GROUP BY ShipperName,LastName;
   

SELECT Employees.LastName, COUNT(Orders.OrderID) AS NumberOfOrders FROM Orders
INNER JOIN Employees
ON Orders.EmployeeID=Employees.EmployeeID
WHERE LastName='Davolio' OR LastName='Fuller'
GROUP BY LastName
HAVING COUNT(Orders.OrderID) > 25;
  
  
The following SQL statement selects the "CustomerName" and "City" columns from the "Customers" table, 
       * and converts the "CustomerName" column to uppercase:

Example
SELECT UCASE(CustomerName) AS Customer, City
FROM Customers;

SELECT LCASE(CustomerName) AS Customer, City
FROM Customers;

The following SQL statement selects the first four characters from the "City" column from the "Customers" table:

Example
SELECT MID(City,1,4) AS ShortCity
FROM Customers;

The following SQL statement selects the "CustomerName" and the length of the values in the "Address" column from the 
       * "Customers" table:

Example
SELECT CustomerName,LEN(Address) as LengthOfAddress
FROM Customers;

The following SQL statement selects the product name and rounds the price in the "Products" table:

Example
SELECT ProductName, ROUND(Price,0) AS RoundedPrice
FROM Products;

The following SQL statement selects the product name, and price for today from the "Products" table:

Example
SELECT ProductName, Price, Now() AS PerDate
FROM Products;

The following SQL statement selects the product name, and price for today (formatted like YYYY-MM-DD) from 
       * the "Products" table:

Example
SELECT ProductName, Price, FORMAT(Now(),'YYYY-MM-DD') AS PerDate
FROM Products;
      **/
    }
  }
}
