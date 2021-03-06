use adventureworks2019

go

Select AVG(column_Name) from Table_Name

SELECT AVG(VacationHours)as 'Average vacation hours',

    SUM  (SickLeaveHours) as 'Total sick leave hours'

FROM HumanResources.Employee

WHERE Title LIKE 'Vice President%';

 

Select AVG(DISTINCT COL_NAME ) from Table_Name

SELECT AVG(DISTINCT ListPrice)

FROM Production.Product

--Checksum to detct changes

--get checksum before changes

select CHECKSUM_AGG(CAST(Quantity as int))

from Production.ProductInventory

--Modify Data

Update Production.ProductInventory

Set Quantity = 200

where Quantity =125;

 

select CHECKSUM_AGG(CAST(Quantity as int))

from Production.ProductInventory

 

---Count to get the total number of rows

--REturns Int

Select COUNT(Distinct Title )

from Humanresources.Employee

 

Select COUNT(*)

from humanResources.Employee

 

Select COUNT(*), AVG(Quantity)

from Production.Product

 

--Count_BIG() returns BigInt

-- COunt of all rows

Select COUNT_BIG(*) from persons.contact

--Grouping() is to list aggregated or not

-- returns tiny int

--used with select list, Having and oredrby

Select SaleQuota, SalesYTD,GROUPING(SqlesQuota) AS 'Group'

from Sales.Salesperson

group by SalesQuota

--group by salesQuota with ROLLUP

--Max() Maximum Value

Select MAX(Col_Name) from Table_name

--MIn() MInimum Vale

-- Can be used with char. varchar, numeric,datetime

-- not with bit

select MIN(Col_Name) from Table_Name

--Sum of values. Null iignored

select SUM(Col_Name) from Table_name

SELECT Color, ListPrice, StandardCost

FROM Production.Product

WHERE Color IS NOT NULL

    AND ListPrice != 0.00

    AND Name LIKE 'Mountain%'

ORDER BY Color

COMPUTE SUM(ListPrice), SUM(StandardCost) BY Color;

GO

 

--STDDEV standard Deviation returns float

Select STDEV(Bonus) from sales.SalesPerson

 

 

Select VAR(Bonus) from Sales.SAlesPerson

--------------------------------------------------------------------

Date And Time Functions

--------------------------------------------------------------------

SELECT SYSDATETIME()

    ,SYSDATETIMEOFFSET()

    ,SYSUTCDATETIME()

    ,CURRENT_TIMESTAMP

    ,GETDATE()

    ,GETUTCDATE();

 

SELECT CONVERT (date, SYSDATETIME())

    ,CONVERT (date, SYSDATETIMEOFFSET())

    ,CONVERT (date, SYSUTCDATETIME())

    ,CONVERT (date, CURRENT_TIMESTAMP)

    ,CONVERT (date, GETDATE())

    ,CONVERT (date, GETUTCDATE());

 

SELECT CONVERT (time, SYSDATETIME())

    ,CONVERT (time, SYSDATETIMEOFFSET())

    ,CONVERT (time, SYSUTCDATETIME())

    ,CONVERT (time, CURRENT_TIMESTAMP)

    ,CONVERT (time, GETDATE())

    ,CONVERT (time, GETUTCDATE());

--Dateadd()

SELECT DATEADD(DAY, 1, SYSDATETIME());

SELECT DATEADD(D, 1, SYSDATETIME());

SELECT DATEADD(DAYOFYEAR, 1, SYSDATETIME());

SELECT DATEADD(DD, 1, SYSDATETIME());

SELECT DATEADD(HH, 1, SYSDATETIME());

SELECT DATEADD(HOUR, 1, SYSDATETIME());

SELECT DATEADD(M, 1, SYSDATETIME());

SELECT DATEADD(MCS, 1, SYSDATETIME());

SELECT DATEADD(MINUTE, 1, SYSDATETIME());

SELECT DATEADD(NANOSECOND, 1, SYSDATETIME());

SELECT DATEADD(Q, 1, SYSDATETIME());

SELECT DATEADD(WEEK, 1, SYSDATETIME());

 

SELECT DATEDIFF(millisecond, GETDATE(), SYSDATETIME());

SELECT DATEDIFF(M, GETDATE(), SYSDATETIME());

SELECT DATEDIFF(day, '1977-10-26',GETDATE());

SELECT DATEDIFF(YEAR, '1977-10-26',GETDATE());

SELECT DATEDIFF(M, '1977-10-26',GETDATE());

SELECT DATEDIFF(Q, '1977-10-26',GETDATE());

 

CREATE TABLE dbo.Duration

    (

    startDate datetime2

    ,endDate datetime2

    )

INSERT INTO dbo.Duration(startDate,endDate)

    VALUES('2007-05-06 12:10:09','2007-05-07 12:10:09')

SELECT DATEDIFF(day,startDate,endDate) AS 'Duration'

FROM dbo.Duration;

 

SELECT DATENAME(d,Getdate());

SELECT DATENAME(DW,Getdate());

SELECT DATENAME(HOUR,Getdate());

SELECT DATENAME(M,Getdate());

 

SELECT DATEPART(yy,Getdate());

SELECT DAY(GetDate());

--UTC Universal Coordinated Time

SELECT GETUTCDATE();

Select ISDATE(GetDate());

SELECT ISDATE('2010-2-30')

SELECT MONTH(GetDate())

SELECT YEAR(GETDATE());

CREATE TABLE dbo.test

    (

    ColDatetimeoffset datetimeoffset

    );

GO

INSERT INTO dbo.test

VALUES ('2004-06-19 10:25:50.71345 -10:00');

GO

SELECT SWITCHOFFSET (ColDatetimeoffset, '-08:00')

FROM dbo.test;

GO

SELECT ColDatetimeoffset

FROM dbo.test;

DECLARE @DTiime DateTime2

SELECT @DTiime = GETDATE()

SELECT TODATETIMEOFFSET(@DTiime,'-02:00')

SELECT TODATETIMEOFFSET(@DTiime,-120)

SELECT TODATETIMEOFFSET(@DTiime,'+13:00')

 

------------------------------------------------------------------------

Mathematical Functions

------------------------------------------------------------------------

--Absolute Positive Value

Select ABS(-16)

Declare @var1 float

Declare @var2 float

set @var1 = 16

set @var2 = 2.45

Select ABS(@var1-@var2)

 

Select ACOS(-1.0)