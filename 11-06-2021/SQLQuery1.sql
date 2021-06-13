create database BookDb
go

create table tbl_author(
AuthorId int identity(1,1),
AuthorName varchar(20),
constraint PK_author primary key(AuthorId)
)
create table tbl_book(
BookId int identity(1000,1),
Title varchar(50),
AuthorId int,
Price money,
constraint PK_book primary key(BookId),
constraint Fk_author foreign key(AuthorId) 
references tbl_author(AuthorId)
)
select * from tbl_author
select * from tbl_book

create proc sp_InsBook
@Title varchar(50),
@AuthorId int,
@Price money
as 
begin
insert into tbl_Book(Title,AuthorId,Price)
values(@Title,@AuthorId,@Price)
end

create proc sp_InsAuthor
@AuthorName varchar(20)
as 
begin
insert into tbl_author(AuthorName)
values(@AuthorName)
end
