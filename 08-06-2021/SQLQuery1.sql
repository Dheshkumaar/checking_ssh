use dbRegister

CREATE TABLE employers(id INTEGER NOT NULL PRIMARY KEY,  
first_name VARCHAR(10),last_name  VARCHAR(10),salary DECIMAL(10, 2),
city VARCHAR(20))  

-----------4
create procedure insertupdatedelete (@id INTEGER,@first_name VARCHAR(10),  
@last_name  VARCHAR(10),@salary DECIMAL(10, 2),@city VARCHAR(20),@StatementType NVARCHAR(20) = '')  
AS  
BEGIN  
	IF @StatementType = 'Insert'  
	BEGIN  
		INSERT INTO employers(id,first_name,last_name,salary,city)  
		VALUES( @id,@first_name,@last_name,@salary,@city)  
	END   
	IF @StatementType = 'Update'  
	BEGIN  
		UPDATE employers SET first_name = @first_name,last_name = @last_name,salary = @salary,city = @city 
		WHERE  id = @id  
	END  
	IF @StatementType = 'Delete'  
	BEGIN  
		DELETE FROM employers WHERE  id = @id  
	END  
END
-----------------3
create view v_employer
as
select * from employers

select * from v_employer

insert into v_employer values(1,'hari','b',20000,'vellore')
insert into employers values(2,'fazil','M',20000,'Gingee')

--------------------2
DECLARE @currency money = 1234.56;
SELECT FORMAT(@currency, 'C', 'en-in')

--------------------1

select DATEDIFF(day,'2021/04/12',getdate())

SELECT DATEADD(year, 1, '2017/08/25') AS DateAdd;

SELECT REVERSE('SQL Tutorial');

SELECT LEFT('SQL Tutorial', 4) AS ExtractString;

select Len('dhesh') as Length

select count(*) as Count from v_employer

select sum(salary) as sum from employers

select convert(int,salary) as conversion from employers