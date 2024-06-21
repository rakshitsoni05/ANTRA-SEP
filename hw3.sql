-- All scenarios are based on Database NORTHWIND.

-- 1.      List all cities that have both Employees and Customers.

SELECT DISTINCT e.City FROM Employees e JOIN Customers c ON e.City = c.City

-- 2.      List all cities that have Customers but no Employee.

-- a.      Use sub-query

SELECT  DISTINCT City 
FROM Customers 
WHERE City NOT IN (
    SELECT City FROM Employees
)

-- b.      Do not use sub-query

SELECT DISTINCT c.City
FROM Customers c
LEFT JOIN Employees e ON c.City = e.City
WHERE e.City IS NULL;


-- 3.      List all products and their total order quantities throughout all orders.
SELECT p.ProductName, SUM(od.Quantity) AS TotalOrders
FROM Products p
JOIN [Order Details] od ON p.ProductID = od.ProductID
GROUP BY p.ProductName;

-- 4.      List all Customer Cities and total products ordered by that city.

SELECT c.City, SUM(od.Quantity) AS TotalProducts
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.City;

-- 5.      List all Customer Cities that have at least two customers.



-- a.      Use union
SELECT City
FROM Customers
GROUP BY City
HAVING COUNT(CustomerID) = 2
UNION
SELECT City
FROM Customers
GROUP BY City
HAVING COUNT(CustomerID) > 2;

-- b.      Use sub-query and no union
SELECT City
FROM (
    SELECT City, COUNT(CustomerID) AS CustomerCount
    FROM Customers
    GROUP BY City
) AS CityCounts
WHERE CustomerCount >= 2;


-- 6.      List all Customer Cities that have ordered at least two different kinds of products.

SELECT c.City, COUNT(DISTINCT od.ProductID) AS DistinctProducts
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.City
HAVING COUNT(DISTINCT od.ProductID) >= 2;


-- 7.      List all Customers who have ordered products, but have the ‘ship city’ on the order different from their own customer cities.
SELECT DISTINCT c.CustomerID, c.ContactName, c.City AS CustomerCity, o.ShipCity
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE c.City <> o.ShipCity;


-- 8.      List 5 most popular products, their average price, and the customer city that ordered most quantity of it.

WITH PopularProductCTE AS (
    SELECT TOP 5
        od.ProductID,
        SUM(od.Quantity) AS TotalQuantity,
        AVG(od.UnitPrice) AS AveragePrice,
        RANK() OVER (ORDER BY SUM(od.Quantity) DESC) AS ProductRank
    FROM [Order Details] od 
    GROUP BY od.ProductID
)

SELECT cte.ProductID, p.ProductName,  cte.TotalQuantity,  cte.AveragePrice,
    (SELECT TOP 1 c.City
     FROM Customers c
     JOIN Orders o ON c.CustomerID = o.CustomerID
     JOIN [Order Details] od2 ON o.OrderID = od2.OrderID
     WHERE od2.ProductID = cte.ProductID
     GROUP BY c.City
     ORDER BY SUM(od2.Quantity) DESC) AS TopCustomerCity
FROM PopularProductCTE cte
JOIN Products p ON cte.ProductID = p.ProductID
ORDER BY cte.ProductRank;


-- 9.      List all cities that have never ordered something but we have employees there.

-- a.      Use sub-query

SELECT DISTINCT e.City
FROM Employees e
WHERE e.City NOT IN (SELECT DISTINCT City FROM Customers );

-- b.      Do not use sub-query

SELECT DISTINCT e.City
FROM Employees e
LEFT JOIN Customers c 
ON e.City = c.City
WHERE c.City IS NULL;


-- 10.  List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, and also the city of most total quantity of products ordered from. (tip: join  sub-query)

WITH EmployeeOrderCountCTE AS (
    SELECT TOP 1 e.City AS EmployeeCity, COUNT(o.OrderID) AS OrderCount
    FROM Employees e
    JOIN Orders o ON e.EmployeeID = o.EmployeeID
    GROUP BY e.City
    ORDER BY OrderCount DESC
),

CustomerOrderQuantityCTE AS (
    SELECT TOP 1 c.City AS CustomerCity, SUM(od.Quantity) AS TotalQuantity
    FROM Customers c
    JOIN Orders o ON c.CustomerID = o.CustomerID
    JOIN [Order Details] od ON o.OrderID = od.OrderID
    GROUP BY c.City
    ORDER BY TotalQuantity DESC
)

-- Main query to join the subqueries 
SELECT eCte.EmployeeCity
FROM EmployeeOrderCountCTE eCte
JOIN CustomerOrderQuantityCTE cCte ON eCte.EmployeeCity = cCte.CustomerCity;



-- 11. How do you remove the duplicates record of a table?

-- We can remove duplicate records from the table in 3 ways:
--1. Using Group By and having clause
--2. Using Common Table Expressions (CTE) and ROW_NUMBER()
--3. Using RANK function and Partition by.
