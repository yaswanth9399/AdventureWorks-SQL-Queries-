USE AdventureWorks2019
GO
SELECT COUNT(*) AS TotalProducts FROM Production.Product;
SELECT COUNT(*) AS ProductsWithSubcategory FROM Production.Product WHERE ProductSubcategoryID IS NOT NULL;
SELECT ProductSubcategoryID, COUNT(*) AS CountedProducts FROM Production.Product GROUP BY ProductSubcategoryID;
SELECT COUNT(*) AS ProductsWithoutSubcategory FROM Production.Product WHERE ProductSubcategoryID IS NULL;
SELECT SUM(Quantity) AS TotalQuantity FROM Production.ProductInventory;
SELECT ProductID, SUM(Quantity) AS TheSum FROM Production.ProductInventory WHERE LocationID = 40 GROUP BY ProductID HAVING SUM(Quantity) < 100;
SELECT Shelf, ProductID, SUM(Quantity) AS TheSum FROM Production.ProductInventory WHERE LocationID = 40 GROUP BY Shelf, ProductID HAVING SUM(Quantity) < 100;
SELECT AVG(Quantity) AS AverageQuantity FROM Production.ProductInventory WHERE LocationID = 10;
SELECT ProductID, Shelf, AVG(Quantity) AS TheAvg FROM Production.ProductInventory GROUP BY ProductID, Shelf;
SELECT ProductID, Shelf, AVG(Quantity) AS TheAvg FROM Production.ProductInventory WHERE Shelf <> 'N/A' GROUP BY ProductID, Shelf;
SELECT Color, Class, COUNT(*) AS TheCount, AVG(ListPrice) AS AvgPrice FROM Production.Product WHERE Color IS NOT NULL AND Class IS NOT NULL GROUP BY Color, Class;
SELECT c.Name AS Country, s.Name AS Province FROM Person.CountryRegion c JOIN Person.StateProvince s ON c.CountryRegionCode = s.CountryRegionCode;
SELECT c.Name AS Country, s.Name AS Province FROM Person.CountryRegion c JOIN Person.StateProvince s ON c.CountryRegionCode = s.CountryRegionCode WHERE c.Name IN ('Germany', 'Canada');
