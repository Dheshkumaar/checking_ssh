----------1-------------
select * from Production.Product
select Name
from Production.Product where DaysToManufacture = 
(select DaysToManufacture from Production.Product where Name='Blade')
----------2-------------
select Name
from Production.Product
where weight >= Any(
select Max(Weight) 
from production.Product
where weight is not null
group by ProductModelID)

select Name
from Production.Product
where weight >= all(
select max(Weight) 
from production.Product
where weight is not null
group by ProductModelID)

select Name
from Production.Product
where weight >= some(
select Max(Weight) 
from production.Product
where weight is not null
group by ProductModelID)
----------3-------------
select * from Person.person
select * from sales.SalesTerritory
select * from sales.SalesPerson 

select FirstName,LastName,sl.Name,CountryRegionCode, MAX(sl.SalesLastYear) as MaxSale 
from Sales.SalesPerson sal
join Sales.SalesTerritory sl
on sal.TerritoryID=sl.TerritoryID
join Person.Person per
on sal.BusinessEntityID=per.BusinessEntityID
group by FirstName,LastName,sl.Name,CountryRegionCode
----------4-------------

select FirstName,LastName,SalesQuota
from Person.Person per
join 
(Select BusinessEntityID,SalesQuota
from Sales.SalesPerson
where SalesQuota>=25000)as sal
on per.BusinessEntityID=sal.BusinessEntityID

----------5-------------

select distinct ord1.ProductID,OrderQty,UnitPrice
from  sales.SalesOrderDetail ord1
join 
(select productID,avg(unitPrice) as Avg_Price
from Sales.SalesOrderDetail ord2
group by productId) as tle
on ord1.ProductID = tle.ProductID
where UnitPrice < Avg_Price
order by ord1.ProductID
