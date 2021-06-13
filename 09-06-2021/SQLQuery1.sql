select @@VERSION
--get all databases
select * from sys.databases
--list tables under an database
use AdventureWorks2019
select * from sys.tables
-------------------------------------------------------------------------------------------------
select * from HumanResources.EmployeeDepartmentHistory
select * from Person.Person
-------------------------------------------------------------------------------------------------
select * from Person.Person where Title like 'Ms.'or title like 'Ms'
-------------------------------------------------------------------------------------------------
select distinct Title from Person.Person
-------------------------------------------------------------------------------------------------
select distinct ShiftID
from HumanResources.EmployeeDepartmentHistory

select * from HumanResources.Employee
-------------------------------------------------------------------------------------------------
select BusinessEntityID,DATEDIFF(YY,HireDate,getdate())
from HumanResources.Employee 
-------------------------------------------------------------------------------------------------
select BusinessEntityID,DATEDIFF(YY,BirthDate,getdate()) as Age
from HumanResources.Employee 
-------------------------------------------------------------------------------------------------
select emp.BusinessEntityID,DepartmentID,JobTitle,
DATEDIFF(yy,StartDate,(CASE WHEN EndDate IS NULL THEN GETDATE() ELSE EndDate END)) as Experience
from HumanResources.Employee emp join HumanResources.EmployeeDepartmentHistory edh
on emp.BusinessEntityID = edh.BusinessEntityID
							--or--
select emp.BusinessEntityID,DepartmentID,JobTitle,DATEDIFF(yy,StartDate,getdate()) as Experience
from HumanResources.Employee emp join HumanResources.EmployeeDepartmentHistory edh
on emp.BusinessEntityID = edh.BusinessEntityID where EndDate is null
union
select emp.BusinessEntityID,DepartmentID,JobTitle,DATEDIFF(yy,StartDate,EndDate) as Experience
from HumanResources.Employee emp join HumanResources.EmployeeDepartmentHistory edh
on emp.BusinessEntityID = edh.BusinessEntityID where EndDate is not null
---------------------------------------------------------------------------------------------------
select * from HumanResources.Shift
select * from Person.Address
select * from HumanResources.EmployeeDepartmentHistory
select * from HumanResources.Employee

select BusinessEntityID,
(65-datediff(yy,BirthDate,GETDATE())) as Balance,
DATEADD(yy,65,BirthDate) as Retired_Date
from HumanResources.Employee
----------------------------------------------------------------------------------------------------
select distinct Color
from Production.Product 

select ProductID,isnull(Color,'multicolor')
from Production.Product
select ProductID,coalesce(Color,'multicolor')
from Production.Product
----------------------------------------------------------------------------------------------------
select BusinessEntityID,coalesce(EndDate,getdate()) from HumanResources.EmployeeDepartmentHistory 
----------------------------------------------------------------------------------------------------
select * from Production.Product
select * from Production.ProductCategory
select * from Production.ProductSubcategory

select ProductID,cat.Name category,sub.Name subcategory,
p.Name productname,ListPrice
from Production.Product p
join Production.ProductSubcategory sub
on p.ProductSubcategoryID = sub.ProductSubcategoryID join
Production.ProductCategory cat on
cat.ProductCategoryID = sub.ProductCategoryID


