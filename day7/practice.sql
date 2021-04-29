use pubs
--all columns
select * from authors
--projection -restriction on columns for display
select au_lname,au_fname from authors
--Giving alias name for columns for display
select au_fname First_Name,au_lname Last_Name from authors
--selection -filter the rows
select * from authors where state = 'CA'
select * from authors where state != 'CA'
select * from employee where minit is not null
select * from employee where job_id >10
select * from employee where job_id <10
select * from employee where job_id >10 and job_id<15
select * from employee where job_id between 10 and 15
select * from employee where job_id=11 or job_id=14 or job_id=6
--same as above alernate method
select * from employee where job_id in(11,14,6)
select * from employee where job_id not in(11,14,6)
--alernate method
select * from employee where job_id!=11 and job_id!=14 and job_id!=6
select * from employee where fname = 'Maria'
--first three char
select * from employee where fname like 'Mar%'
--getting second character
select * from employee where fname like '_o%'
select fname,lname from employee where job_id not in (11,14,6)
--aggregation functions
select * from titles
select distinct(pub_id) from titles

select sum(advance) total from titles
select count(advance) number_count from titles
select min(advance) minimum from titles
select max(advance) maximum from titles
select avg(advance) average from titles

select count(*) number_count from titles where pub_id=0877
select count(*) number_count from titles where pub_id=1389
--group by
select pub_id,count(*) number_count from titles group by pub_id
--average advance for the titles pushed by every publisher
select pub_id,avg(advance) average_advance from titles group by pub_id

select pub_id,count(title),avg(advance) average_advance from titles group by pub_id

select * from sales

select title_id,sum(qty) sum_qty from sales group by title_id

select avg(royalty) Average,type from titles group by type

select count(*) ord_num,stor_id from sales group by stor_id

select count(*) ord_num,stor_id from sales group by stor_id having count(*)>2

select avg(royalty) Average,type from titles group by type having avg(royalty) <15
--sorting
select * from authors order by au_lname
select * from authors order by city 
select * from authors order by state,city
select * from authors order by city desc
select * from authors order by phone desc

select * from sales where title_id=
(select title_id from titles where title = 'The Busy Executive''s Database Guide' )

select * from sales where title_id in
(select title_id from titles where pub_id = 
(select pub_id from publishers where pub_name='New Moon Books'))

select title_id,sum(qty) from sales where title_id in
(select title_id from titles where pub_id = 
(select pub_id from publishers where pub_name='New Moon Books'))
group by title_id
having sum(qty)<=25
order by sum(qty) desc

select t.title_id,title,qty from titles t join sales s
on
t.title_id =s.title_id

select distinct(title_id) from sales

select title_id from titles where title_id not in (select distinct(title_id) from sales)
--left outer join - fetch all records from the left table
select t.title_id,title,qty from titles t left outer join sales s
on
t.title_id =s.title_id

select * from publishers
select * from titles

select pub_name,title from publishers p join titles t
on
p.pub_id = t.pub_id

select pub_name,title from publishers p left outer join titles t
on
p.pub_id = t.pub_id

--1  
select au_fname,au_lname from authors

--2  
select title,notes from titles 
order by title desc

--7  
select title,price from titles 
where title like '%s'

--3  
select au_id, count(title_id) no_of_titles from titleauthor 
group by au_id

-- 12  
select emp_id,fname,lname from employee 
where pub_id =(
select pub_id from publishers 
where pub_name='Algodata Infosystems')

--8  
select title from titles 
where title like '%and%' 

--9  
select fname,lname,pub_name from employee e join publishers p 
on e.pub_id = p.pub_id

--10 
select pub_name,count(fname) no_of_emp from publishers p join employee e 
on p.pub_id = e.pub_id 
group by pub_name 
having count(fname)>2

--5 
select pub_name, avg(advance) Advance from titles t join publishers p 
on t.pub_id = p.pub_id 
group by pub_name

--4 
select au_fname,au_lname,title from authors a ,titleauthor ta,titles t 
where a.au_id = ta.au_id and t.title_id = ta.title_id

--11 
select au_fname, au_lname from publishers p join titles t 
on p.pub_id= t.pub_id 
join titleauthor ta 
on t.title_id = ta.title_id 
join authors a 
on ta.au_id = a.au_id 
where p.pub_name='Algodata infosystems'

--6
select pub_name,au_fname,title,qty*price Sale_amount from titles t join sales s
on t.title_id = s.title_id join publishers p
on p.pub_id = t.pub_id join titleauthor ta
on ta.title_id = t.title_id join authors a
on a.au_id = ta.au_id
