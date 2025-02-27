use Northwind
Go
SELECT DISTINCT p.ProductName FROM Products p JOIN [Order Details] od ON p.ProductID = od.ProductID JOIN Orders o ON od.OrderID = o.OrderID WHERE DATEDIFF(YEAR, o.OrderDate, GETDATE()) <= 27;
WITH SalesByZip AS (
    SELECT c.PostalCode, COUNT(o.OrderID) AS SalesCount,
           RANK() OVER(ORDER BY COUNT(o.OrderID) DESC) AS RankVal
    FROM Customers c
    JOIN Orders o ON c.CustomerID = o.CustomerID
    GROUP BY c.PostalCode
)
SELECT PostalCode, SalesCount, RankVal
FROM SalesByZip
WHERE RankVal <= 5;
WITH SalesByZip AS (
    SELECT c.PostalCode, COUNT(o.OrderID) AS SalesCount,
           RANK() OVER(ORDER BY COUNT(o.OrderID) DESC) AS RankVal
    FROM Customers c
    JOIN Orders o ON c.CustomerID = o.CustomerID
    WHERE DATEDIFF(YEAR, o.OrderDate, GETDATE()) <= 27
    GROUP BY c.PostalCode
)
SELECT PostalCode, SalesCount, RankVal
FROM SalesByZip
WHERE RankVal <= 5;
SELECT City, COUNT(CustomerID) AS NumberOfCustomers
FROM Customers
GROUP BY City;
WITH CityCustomerCount AS (
    SELECT City, COUNT(CustomerID) AS CustomerCount
    FROM Customers
    GROUP BY City
)
SELECT City, CustomerCount
FROM CityCustomerCount
WHERE CustomerCount > 2;
SELECT DISTINCT c.CompanyName, o.OrderDate 
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE o.OrderDate > '1998-01-01';
SELECT c.CompanyName, MAX(o.OrderDate) OVER(PARTITION BY c.CustomerID) AS MostRecentOrder
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID;
SELECT c.CompanyName, MAX(o.OrderDate) OVER(PARTITION BY c.CustomerID) AS MostRecentOrder
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID;
WITH ProductCountByCustomer AS (
    SELECT c.CustomerID, COUNT(od.ProductID) AS ProductCount
    FROM Customers c
    JOIN Orders o ON c.CustomerID = o.CustomerID
    JOIN [Order Details] od ON o.OrderID = od.OrderID
    GROUP BY c.CustomerID
)
SELECT CustomerID, ProductCount 
FROM ProductCountByCustomer
WHERE ProductCount > 100;
SELECT s.CompanyName AS SupplierCompanyName, sh.CompanyName AS ShippingCompanyName
FROM Suppliers s
CROSS JOIN Shippers sh;
SELECT o.OrderDate, p.ProductName
FROM Orders o
JOIN [Order Details] od ON o.OrderID = od.OrderID
JOIN Products p ON od.ProductID = p.ProductID;
SELECT e1.EmployeeID, e1.LastName AS Employee1, e2.EmployeeID, e2.LastName AS Employee2, e1.Title
FROM Employees e1
JOIN Employees e2 ON e1.Title = e2.Title AND e1.EmployeeID < e2.EmployeeID;
WITH EmployeeCount AS (
    SELECT e.ReportsTo AS ManagerID, m.LastName AS ManagerName, COUNT(e.EmployeeID) AS EmployeeCount
    FROM Employees e
    JOIN Employees m ON e.ReportsTo = m.EmployeeID
    GROUP BY e.ReportsTo, m.LastName
)
SELECT ManagerID, ManagerName, EmployeeCount
FROM EmployeeCount
WHERE EmployeeCount > 2;
SELECT c.City, c.CompanyName AS Name, c.ContactName, 'Customer' AS Type 
FROM Customers c
UNION ALL
SELECT s.City, s.CompanyName AS Name, s.ContactName, 'Supplier' AS Type 
FROM Suppliers s
ORDER BY City;

