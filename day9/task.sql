--1
create procedure proc_book(@aufname varchar(20),@aulname varchar(20))
as
begin
	select title_id from sales where title_id in(
	select title_id from titleauthor where au_id =(
	select au_id from authors 
	where au_fname = @aufname and au_lname = @aulname))
end
exec proc_book 'Johnson','White'

--2
select au_fname,au_lname,pub_name,price from authors a join titleauthor ta on
a.au_id = ta.au_id join titles t 
on ta.title_id = t.title_id join publishers p on
t.pub_id = p.pub_id 

--3
declare @pub_name varchar(30)
declare cur_pub cursor for
select pub_name from publishers
open cur_pub
fetch next from cur_pub into @pub_name
print 'Data'
while @@FETCH_STATUS=0
begin
	print 'Publisher name:' + @pub_name
	declare @t_name varchar(30)
	declare cur_title cursor for
	select title from titles where pub_id =(select pub_id from publishers where pub_name = @pub_name)
	open cur_title
	fetch next from cur_title into @t_name
	while @@FETCH_STATUS=0
	begin
		print 'title name:' + @t_name
		declare @a_name varchar(30)
		declare cur_author cursor for
		select au_fname from authors where au_id in(select au_id from titleauthor where title_id = (select title_id from titles where title=@t_name))
		open cur_author
		fetch next from cur_author into @a_name
		while @@FETCH_STATUS=0
		begin
			print'author name:'+@a_name
			fetch next from cur_author into @a_name
		end
		close cur_author
		deallocate cur_author
		declare @qty int,@date_no date
		declare cur_qty cursor for
		select qty,ord_date from sales where title_id = (select title_id from titles where title=@t_name)
		open cur_qty
		fetch next from cur_qty into @qty,@date_no
		while @@FETCH_STATUS=0
		begin
			print 'quantity:'+cast(@qty as varchar(5))
			print 'sale date:'+cast(@date_no as varchar(10))
			fetch next from cur_qty into @qty,@date_no
		end
		close cur_qty
		deallocate cur_qty
		print'---------------------'
		fetch next from cur_title into @t_name
	end
	close cur_title
	deallocate cur_title
	print '###################'
	fetch next from cur_pub into @pub_name
end
close cur_pub
deallocate cur_pub

--4
create table account(
acc_num varchar(20) primary key,
name varchar(20),
balance int,
status varchar(7) check(status in('open','blocked')) default 'open')

insert into account values('9182735','dk',3600,'open')
insert into account values('9182736','fazil',1600,'open'),('9182737','hari',2000,'blocked')

select * from account

create table transactions(
trans_id int primary key,
from_acc varchar(20) references account(acc_num),
to_acc varchar(20) references account(acc_num),
amount float,
remarks varchar(20))

select * from transactions
--a
begin transaction
insert into transactions values(1,'9182735','9182736',200,'Done')
update account set balance = balance-200 where acc_num = '9182735'
update account set balance = balance+200 where acc_num = '9182736'
if(select balance from account where acc_num='9182735')<1500
rollback
else 
commit

 --5

