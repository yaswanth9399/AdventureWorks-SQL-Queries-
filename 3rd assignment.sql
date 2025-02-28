use Northwind
Go
SELECT DISTINCT c.City 
FROM Customers c
JOIN Employees e ON c.City = e.City;
SELECT DISTINCT City 
FROM Customers 
WHERE City NOT IN (SELECT DISTINCT City FROM Employees);
SELECT DISTINCT c.City 
FROM Customers c
LEFT JOIN Employees e ON c.City = e.City
WHERE e.City IS NULL;
SELECT p.ProductName, SUM(od.Quantity) AS TotalOrdered
FROM Products p
JOIN [Order Details] od ON p.ProductID = od.ProductID
GROUP BY p.ProductName;
SELECT c.City, SUM(od.Quantity) AS TotalProductsOrdered
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.City;
SELECT City, COUNT(CustomerID) AS CustomerCount
FROM Customers
GROUP BY City
HAVING COUNT(CustomerID) >= 2;
SELECT c.City, COUNT(DISTINCT od.ProductID) AS UniqueProductsOrdered
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.City
HAVING COUNT(DISTINCT od.ProductID) >= 2;
SELECT DISTINCT c.CustomerID, c.ContactName, c.City AS CustomerCity, o.ShipCity 
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE c.City <> o.ShipCity;
WITH ProductPopularity AS (
    SELECT 
        od.ProductID, 
        p.ProductName, 
        AVG(p.UnitPrice) AS AvgPrice, 
        SUM(od.Quantity) AS TotalQuantity
    FROM [Order Details] od
    JOIN Products p ON od.ProductID = p.ProductID
    GROUP BY od.ProductID, p.ProductName
),
CityOrders AS (
    SELECT 
        od.ProductID, 
        o.ShipCity, 
        SUM(od.Quantity) AS TotalOrdered,
        RANK() OVER (PARTITION BY od.ProductID ORDER BY SUM(od.Quantity) DESC) AS RankVal
    FROM [Order Details] od
    JOIN Orders o ON od.OrderID = o.OrderID
    GROUP BY od.ProductID, o.ShipCity
)
SELECT TOP 5 
    p.ProductName, 
    p.AvgPrice, 
    c.ShipCity AS TopOrderingCity, 
    p.TotalQuantity
FROM ProductPopularity p
JOIN CityOrders c ON p.ProductID = c.ProductID
WHERE c.RankVal = 1
ORDER BY p.TotalQuantity DESC;
SELECT DISTINCT City 
FROM Employees
WHERE City NOT IN (SELECT DISTINCT ShipCity FROM Orders);
SELECT DISTINCT e.City
FROM Employees e
LEFT JOIN Orders o ON e.City = o.ShipCity
WHERE o.ShipCity IS NULL;
WITH EmployeeSales AS (
    SELECT 
        e.City AS EmployeeCity, 
        COUNT(o.OrderID) AS TotalOrders,
        RANK() OVER (ORDER BY COUNT(o.OrderID) DESC) AS RankVal
    FROM Employees e
    JOIN Orders o ON e.EmployeeID = o.EmployeeID
    GROUP BY e.City
),
CustomerOrders AS (
    SELECT 
        o.ShipCity, 
        SUM(od.Quantity) AS TotalQuantity,
        RANK() OVER (ORDER BY SUM(od.Quantity) DESC) AS RankVal
    FROM Orders o
    JOIN [Order Details] od ON o.OrderID = od.OrderID
    GROUP BY o.ShipCity
)
SELECT TOP 1 
    e.EmployeeCity AS TopEmployeeCity,
    c.ShipCity AS TopCustomerCity,
    e.TotalOrders,
    c.TotalQuantity
FROM EmployeeSales e
JOIN CustomerOrders c ON e.EmployeeCity = c.ShipCity
WHERE e.RankVal = 1 AND c.RankVal = 1;
WITH CTE AS (
    SELECT *, ROW_NUMBER() OVER (PARTITION BY column1, column2, column3 ORDER BY id) AS RowNum
    FROM TableName
)
DELETE FROM TableName WHERE id IN (SELECT id FROM CTE WHERE RowNum > 1);


