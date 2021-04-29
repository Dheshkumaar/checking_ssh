sp_help tblEmployee

create table tblEmployee
(id int identity(101,1) primary key,
name varchar(20),
age int default 18,
manager_id int)

alter table tblemployee
add constraint fk_mgrId foreign key(manager_id) references tblEmployee(id)

insert into tblEmployee(name,age) values('Ramu',35)
insert into tblEmployee(name,age) values('Somu',31)
insert into tblEmployee(name,age,manager_id) values('Sita',21,101)
insert into tblEmployee(name,age,manager_id) values('Geeta',22,101)
insert into tblEmployee(name,age,manager_id) values('Anita',20,102)

select * from tblEmployee

select id,manager_id from tblEmployee

select emp.id employee_id,emp.name employee_name,
mgr.id manager_id, mgr.name manager_name from 
tblEmployee emp join tblEmployee mgr on
emp.manager_id = mgr.id 

select * from employee cross join sales

create proc proc_insertEmployee(@ename varchar(20),@eage int,@emgrid int)
as
begin
if(@emgrid = 0)
insert into tblEmployee(name,age) values(@ename,@eage)
else
insert into tblEmployee(name,age,manager_id) values(@ename,@eage,@emgrid)
end

exec proc_insertEmployee 'Binu',29,0

select * from tblEmployee

alter proc proc_insertEmployee(@ename varchar(20),@eage int,@emgrid int)
as
begin
if(@emgrid = 0)
insert into tblEmployee(name,age) values(@ename,@eage)
else
begin
declare
@empCount int
set @empCount = (select count(*) from tblEmployee where manager_id = @emgrid)
if(@empCount <6)
insert into tblEmployee(name,age,manager_id) values(@ename,@eage,@emgrid)
else
select 'Manager already has 6 employees'
end
end

exec proc_insertEmployee 'dhesh',21,101
exec proc_insertEmployee 'somu',19,101
exec proc_insertEmployee 'dhesh',20,101
exec proc_insertEmployee 'fazil',21,101

exec proc_insertEmployee 'hari',21,102

select * from tblEmployee

create table Employee
(emp_id int identity(100,1) primary key,
name varchar(20),
age int default 18,
phone int not null,
gender varchar(6))

alter table Employee
ADD email varchar(100)

ALTER TABLE Employee
ALTER COLUMN phone varchar(15)

create table salary
(sal_id int identity(1,100) primary key,
basic float,
HRA float,
DA float,
deductions float)

create table EmployeeSalary
(transaction_no int primary key,
emp_id int references Employee(emp_id),
sal_id int references salary(sal_id),
date_no date)

Alter table EmployeeSalary
ADD constraint UC_EmployeeSalary unique (emp_id,sal_id,date_no)

insert into Employee(name,age,phone,email,gender) values('fazil',20,1234567890,'fazil@gmail.com','male')
insert into Employee(name,age,phone,email,gender) values('hari',21,1234567890,'hari@gmail.com','male')
insert into Employee(name,age,phone,email,gender) values('dk',21,1234567890,'dk@gmail.com','male')
insert into Employee(name,age,phone,email,gender) values('Ramu',30,1234567890,'ramu@gmail.com','male')

select * from Employee

insert into salary(basic,HRA,DA,deductions) values(70000,6000,3000,2500)
insert into salary(basic,HRA,DA,deductions) values(80000,7000,4000,3000)
insert into salary(basic,HRA,DA,deductions) values(90000,8000,5000,3500)
insert into salary(basic,HRA,DA,deductions) values(100000,9000,6000,4000)

select * from salary

insert into EmployeeSalary values(1234,100,1,'2021-04-26')
insert into EmployeeSalary values(1000,101,101,'2021-04-27')
insert into EmployeeSalary values(1100,102,201,'2021-04-28')
insert into EmployeeSalary values(1200,103,301,'2021-04-29')
insert into EmployeeSalary values(1300,101,1,'2021-04-30')

select * from EmployeeSalary
--1
alter proc proc_total(@empid int,@date date,@total float out)
as
begin
	set @total =(select (basic+HRA+DA-deductions) total from salary where sal_id =(select sal_id from EmployeeSalary where emp_id =@empid and date_no=@date));
end

declare
@myData int
exec proc_total 101,'2021-04-27',@myData out
select @myData

--2
alter proc proc_average(@empid int,@average float out)
as
begin
set @average = (select avg(basic+HRA+DA-deductions) total from salary where sal_id in(select sal_id from EmployeeSalary where emp_id =@empid))
end

declare
@myData int
exec proc_average 101,@myData out
select @myData

--3
alter proc proc_tax(@empid int,@date date)
as
begin
	declare
	@total float,
	@tax float
	set @total =(select (basic+HRA+DA-deductions) total from salary where sal_id in(select sal_id from EmployeeSalary where emp_id = @empid and date_no = @date));
	set @tax = 0
	if(@total < 100000)
		set @tax = @total * 0
	else if(@total >100000 and @total <200000)
		set @tax =@total * 0.05
	else
		set @tax=@total*0.06;
	select concat('Tax :',@tax)
end

exec proc_tax 101,'2021-04-30'

