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

alter table tblEmployee

create proc proc_InsertEmployee(@eName varchar(20),
create proc proc_GetAllEmployee
as
select * from tblEmployee