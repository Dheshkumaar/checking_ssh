--------------2
use model
go 

create database best

--------------3
use model

create table t1(sno int,name varchar(10)) 

select * from t1

use master

create database dhoni

--------------4
ALTER TABLE t1
ALTER COLUMN sno int NOT NULL;
ALTER TABLE t1
ADD PRIMARY KEY (sno)

insert into t1 values (1,'dhesh')

ALTER TABLE t1
DROP CONSTRAINT PK__t1__DDDF64465E5CFE8F;


--------------5
select sno
from t1 where name='dhesh'

sp_help t1





