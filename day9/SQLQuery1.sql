create function fn_CalSal(@basic float,@hra float,@da float,@ded float)
returns float
as
begin
declare
@netSal float
set @netSal = @basic+@hra+@da-@ded
return @netSal
end

select basic,hra,da,deductions,dbo.fn_CalSal(basic,hra,da,deductions) 'Net Total' from salary

create function fn_PrintCompleteSalDetails(@eid int)
returns @EmpSalTax Table(
Ename varchar(15),
TotalSal float,
Tax float)
as
begin
declare
@total float,
@tax float,
@taxPayable float,
@Ename varchar(15)
set @total = (select sum(basic+hra+da+deductions) from EmployeeSalary es join salary s
on es.sal_id = s.sal_id
where es.emp_id = @eid)
if(@total<100000)
set @tax = 0
else if(@total > 100000 and @total < 200000)
set @tax = 5
else if(@total>200000 and @total <3500000)
set @tax = 6
else
set @tax = 7.5
set @taxPayable = @total*@tax/100
set @ename = (select name from Employee where emp_id = @eid)
insert into @EmpSalTax values(@Ename,@total,@taxPayable)
return
end

select * from dbo.fn_PrintCompleteSalDetails(100)

create table btblDummy(
f1 int,f2 varchar(20))

create trigger trgInsertDummy
on btblDummy
after Insert
as begin
	select 'Hello there!!!'
end

select * from btblDummy

insert into btblDummy values(1,'Ramu')

drop trigger trgInsertDummy

create trigger trgInsertDummy
on btblDummy
after Insert
as begin
	select concat('Hello there!!!', f2) from inserted
end

create table EmployeeNetSal(
transaction_id int,
netsal float)

select * from EmployeeNetSal
Select * from salary
select * from EmployeeSalary

create trigger trg_InsertNetSal
on EmployeeSalary
after insert
as
begin
	declare
	@totalSal float
	set @totalSal = (select dbo.fn_CalSal(basic,hra,da,deductions) from salary where sal_id = (select sal_id from inserted))
	insert into EmployeeNetSal values((select transaction_no from inserted),@totalSal)
end

insert into EmployeeSalary values(1007,102,201,'2011-03-28')

select * from Employee

create trigger trg_name
on Employee
after insert
as 
begin
	if((select gender from inserted) = 'male')
		select concat('welcome Mr.',name) from inserted
	else
		select concat('welcome Miss.',name) from inserted
end
drop trigger trg_name
insert into Employee(name,age,phone,gender,email) values('fimu',20,9876543210,'female','fimu@gmail.com')

begin transaction
insert into employee(name,age,gender,phone,email) values('Yomu',27,'Male',6578901234,'Yomu@gmail.com')
insert into EmployeeSalary values(1008,108,101,'2021-04-27')
if((select max(emp_id) from EmployeeSalary)=108)
commit
else
rollback --all DML queries from begin transaction

declare @eid int,@ename varchar(15)
declare cur_employee cursor for
select emp_id,name from Employee

open cur_employee
fetch next from cur_employee
into @eid,@ename
print 'Employee Data'
while @@FETCH_STATUS = 0
begin
	print 'Employee ID:'+cast(@eid as varchar(10))
	print 'Employee name:'+@ename
	print '---------------------------'
	fetch next from cur_employee 
	into @eid,@ename
end
close cur_employee
deallocate cur_employee
