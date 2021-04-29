create procedure proc_example
as
begin
	select * from authors
end

exec proc_example

create proc proc_SampleInput(@un varchar(20))
as
begin
	select @un
end

exec proc_SampleInput 'Ramu'

alter proc proc_SampleInput(@un varchar(20))
as
begin
	select concat('Welcome ',@un)
end

alter proc proc_SampleInput(@un varchar(20),@gen varchar(6))
as
begin
	if(@gen = 'Male')
		select concat('Welcome Mr.',@un)
	else
		select concat('welcome Miss.',@un)
end

exec proc_SampleInput 'Ramu','Male'
exec proc_SampleInput 'Rita','Female'

create proc proc_FetchTitleUsingauthorName(@auname varchar(20))
as
begin
select * from titles where title_id in
(select title_id from titleauthor where au_id in
(select au_id from authors where au_fname=@auname))
end
select * from authors
exec proc_FetchTitleUsingauthorName 'Marjorie'

create proc proc_FetchUsingSale(@title varchar(100))
as 
begin
select * from sales where title_id in(
select title_id from titles where title = @title)
end

exec proc_FetchUsingSale 'The Busy Executive''s Database Guide'

alter proc proc_FetchUsingSale(@title varchar(50))
as
begin
declare
@saleCount int
set @saleCount = (select count(*) from sales where title_id =(select title_id from titles where title = @title))
if(@saleCount >1)
select concat('Good sales.number ',@saleCount)
else
select concat('Not that great. Count is',@saleCount)
end

exec proc_FetchUsingSale 'You Can Combat Computer Stress!'
exec proc_FetchUsingSale 'The Busy Executive''s Database Guide'

select * from titles

-- in and out parameter
create proc proc_UnderstandingOutParameter(@dataIN int,@dataOut int out)
as
begin
set @dataOut = @dataIn *100;
end

declare
@myData int
exec proc_UnderstandingOutParameter 25,@myData out
select @myData

