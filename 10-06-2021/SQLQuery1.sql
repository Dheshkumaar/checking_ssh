select max(Rate) as highest,min(Rate) as lowest,
AVG(Rate) as average
from HumanResources.EmployeePayHistory

select DepartmentID,MAX(Rate) as highestSalary,Min(rate) as lowestsalary
from HumanResources.EmployeePayHistory emp 
join HumanResources.EmployeeDepartmentHistory edp
on emp.BusinessEntityID = edp.BusinessEntityID
group by DepartmentID

select eph.BusinessEntityID,FirstName,LastName,Rate
from HumanResources.EmployeePayHistory eph
join Person.Person per
on eph.BusinessEntityID = per.BusinessEntityID
where Rate=
(select max(rate) from HumanResources.EmployeePayHistory)

select * from Production.Product 

select ProductID,Name,ListPrice
from Production.Product where ListPrice =
(select max(ListPrice) from Production.Product)

select ProductID,Name,Color
from Production.Product where color != 
(select color from Production.Product where ProductID = 317)

select ProductID,Name,ListPrice,
listPrice-(select avg(ListPrice) from Production.Product) as diffPrice
from Production.Product 

select Name,ListPrice
from Production.Product
where ListPrice >= any
(select Max(ListPrice) 
from production.Product
group by ProductSubcategoryID)

select bonus 
from Sales.SalesPerson

select firstName,LastName
from HumanResources.Employee emp 
join person.Person per
on emp.BusinessEntityID = per.BusinessEntityID
where 6700 in
(select Bonus
from Sales.SalesPerson sp
where sp.BusinessEntityID = emp.BusinessEntityID)

select * from Sales.Customer
select * from Sales.store
select * from Sales.SalesTerritory

select name
from Sales.Store
where BusinessEntityID in(
select CustomerID
from sales.Customer
where TerritoryID = 1)

select emp1.BusinessEntityID,LoginID,
emp1.JobTitle,VacationHours,Avg_vacation
from  HumanResources.Employee emp1
join 
(select JobTitle,avg(VacationHours) as Avg_vacation
from HumanResources.Employee emp2
group by JobTitle) as tle
on emp1.JobTitle = tle.JobTitle

create table #tm_table(
sno int primary key,
name varchar(10))

create table ##tm_table(
sno int primary key,
name varchar(10))

-- Define the CTE expression name and column list.  
WITH Sales_CTE (SalesPersonID, SalesOrderID, SalesYear)  
AS  
-- Define the CTE query.  
(  
    SELECT SalesPersonID, SalesOrderID, YEAR(OrderDate) AS SalesYear  
    FROM Sales.SalesOrderHeader  
    WHERE SalesPersonID IS NOT NULL  
)  
-- Define the outer query referencing the CTE name.  
SELECT SalesPersonID, COUNT(SalesOrderID) AS TotalSales, SalesYear  
FROM Sales_CTE  
GROUP BY SalesYear, SalesPersonID  
ORDER BY SalesPersonID, SalesYear;


with Topsales(salesPersonID,NumSales)as
(select SalesPersonID,count(*)
from Sales.SalesOrderHeader group by SalesPersonID)

select LoginId,NumSales
from HumanResources.Employee e
join Topsales
on Topsales.salesPersonID = e.BusinessEntityID
order by NumSales



