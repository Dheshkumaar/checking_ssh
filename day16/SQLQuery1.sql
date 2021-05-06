create database dbSoftTransport

use dbSoftTransport

create table tblEmployee(
Id int identity (101,1) primary key,
name varchar(20) not null,
password varchar(20) not null,
Location varchar(20),
phone varchar(20),
vechicle_Id char(8))

create table tblDriver(
Id int identity(1000,1) primary key,
name varchar(20),
phone varchar(20),
status varchar(50) check(status in ('active','not active'))
)

create table tblvehicle(
Vechicle_number char(8) primary key,
Type varchar(10),
Capacity int,
Driver_ID int references tblDriver(id),
Filled_Status int,
status varchar(50) check(status in ('running','discard')))

alter table tblEmployeeadd constraint fk_VID foreign key(Vechicle_Id) references tblVehicle(Vechicle_number)

create proc proc_InsertEmployee(@eName varchar(20),@ePassword varchar(20),@eLocation varchar(20),@ephone varchar(20))as Insert into tblEmployee(Name,password,Location,Phone) values(@ename,@ePassword,@elocation,@ephone)create proc proc_UpdatePassword(@eid int,@ePassword varchar(20))asupdate tblEmployee set password=@ePassword where id =@eid
create proc proc_GetAllEmployee
as
select * from tblEmployee