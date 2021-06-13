------------1----------------
select FirstName,LastName
from Person.Person where Title is not null
------------2----------------
select FirstName,LastName
from Person.Person where FirstName like '%a%' and LastName like '%a%'
------------3----------------
select Name,c.CurrencyCode,CountryRegionCode
from Sales.Currency c,Sales.CountryRegionCurrency crc where c.CurrencyCode = crc.CurrencyCode
------------4----------------
Select * into HumanResources.Dept from 
HumanResources.Department 
------------5----------------
create table sample
(s_no int identity(1,1) primary key,
name varchar(10),
Age int,
city varchar(10),email varchar(20))

insert into sample values('aaa',21,'chennai','aaa@gmail.com')
insert into sample values('bbb',22,'chennai','bbb@gmail.com')
insert into sample values('ccc',23,'chennai','ccc@gmail.com')
insert into sample values('ddd',24,'chennai','ddd@gmail.com')
insert into sample values('eee',25,'chennai','eee@gmail.com')
insert into sample values('fff',26,'chennai','fff@gmail.com')
insert into sample values('ggg',27,'chennai','ggg@gmail.com')
insert into sample values('hhh',28,'chennai','hhh@gmail.com')
insert into sample values('iii',21,'chennai','iii@gmail.com')
insert into sample values('jjj',22,'chennai','jjj@gmail.com')
insert into sample values('kkk',23,'chennai','kkk@gmail.com')
insert into sample values('lll',24,'chennai','lll@gmail.com')
insert into sample values('mmm',25,'chennai','mmm@gmail.com')
insert into sample values('nnn',26,'chennai','nnn@gmail.com')
insert into sample values('ooo',27,'chennai','ooo@gmail.com')
insert into sample values('ppp',28,'chennai','ppp@gmail.com')
insert into sample values('qqq',21,'chennai','qqq@gmail.com')
insert into sample values('rrr',22,'chennai','rrr@gmail.com')
insert into sample values('sss',23,'chennai','sss@gmail.com')
insert into sample values('ttt',24,'chennai','ttt@gmail.com')
------------6----------------
select BusinessEntityID,AddressTypeID
from  Person.BusinessEntityAddress 
------------7-----------------
select distinct(GroupName) from HumanResources.Department 
------------8-----------------
select DocumentNode,StandardCost,(StandardCost+ListPrice) as Cost
from Production.Product p join Production.ProductDocument pch
on p.ProductID = pch.ProductID 
------------9-----------------
select BusinessEntityID,
DATEDIFF(yy,StartDate,CASE WHEN EndDate IS NULL THEN GETDATE() ELSE EndDate END) as Years_On_Role  
from HumanResources.EmployeeDepartmentHistory
------------10-----------------
select BusinessEntityID,(SalesQuota+5000) as sales
from Sales.SalesPersonQuotaHistory
where (SalesQuota+5000) > 100000 
order by sales
------------11-----------------
select MAX(TaxRate)as Max_taxrate  from Sales.SalesTaxRate
------------12-----------------
select emp.DepartmentID,emp.BusinessEntityID,ShiftID,BirthDate,DATEDIFF(yy,BirthDate,GETDATE()) as age
from HumanResources.Employee e join HumanResources.EmployeeDepartmentHistory emp
on e.BusinessEntityID = emp.BusinessEntityID 
join HumanResources.Department d 
on emp.DepartmentID = d.DepartmentID
------------13-----------------
create view Name_age
as 
select emp.DepartmentID,emp.BusinessEntityID,ShiftID,BirthDate,DATEDIFF(yy,BirthDate,GETDATE()) as age
from HumanResources.Employee e join HumanResources.EmployeeDepartmentHistory emp
on e.BusinessEntityID = emp.BusinessEntityID 
join HumanResources.Department d 
on emp.DepartmentID = d.DepartmentID
------------14-----------------
select * from sys.tables where schema_id = 5 

------------15-----------------
select * from HumanResources.Department
select * from HumanResources.EmployeeDepartmentHistory
select * from HumanResources.EmployeePayHistory

------------16-----------------

------------17-----------------

------------18-----------------

------------19-----------------

------------20-----------------

