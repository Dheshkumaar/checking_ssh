create database dbSoftTraining

use dbSoftTraining

create table tblSample
(id int,
name varchar(20)
)

select * from tblSample

sp_help tblSample

drop table tblSample

create table skills(
skill_name varchar(20) primary key,
skill_description text)

sp_help skills

drop table skills

create table skills(
skill_name varchar(20) constraint pk_skills primary key,
skill_description text)

create table cities(
zipcode char(4),
city varchar(20),
primary key(zipcode))

create table Employees(
id char(4) primary key,
name varchar(20) not null,
phone varchar(15) not null,
zip char(4) references cities(zipcode))

sp_help Employees

create table employeeSkill(
employee_id char(4) references Employees(id),
skill_name varchar(20) references skills(skill_name),
skill_level float default 1,
constraint pk_empskill primary key(employee_id,skill_name))

sp_help employeeSkill

insert into skills(skill_name,skill_description)
values('C','PLT')
insert into skills values('C++','OOPS')
insert into skills values('h',null)
insert into skills(skill_description,skill_name)
values('web','Java')
insert into skills values(null,'OOPS')

update skills set skill_description = 'something'
where skill_name='h'

delete from skills where skill_name='h'

select * from skills

insert into cities values('1234','ABC'),('3211','DFG')
select * from cities

insert into employees values('E001','Ramu','1234567890','1234')
insert into employees values('E002','Somu','9876543210','3211')
insert into employees values('E003','Ramu','9876543210','1234'),('E004','Ramu','1234567890','1234')

select * from employees 

insert into employeeSkill values('E001','C',7),('E001','C++',7)
insert into employeeSkill values('E003','C',7),('E003','Java',default)

insert into employeeSkill(employee_id,skill_name)
values('E002','Java')

select * from employeeSkill

delete from cities where zipcode = '1234'

