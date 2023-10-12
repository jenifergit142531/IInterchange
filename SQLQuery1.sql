

use inter

-- Concurrency problem


create table customer(custid int primary key,cuscode varchar(10),cusname varchar(20))

insert into customer(custid,cuscode,cusname)
values
(1,'code_1','Amy'),
(2,'code_2','Aron'),
(3,'code_3','Steve'),
(4,'code_4','Julie')

select * from customer

-- transaction

begin transaction 

update customer set cuscode='code_101'
where custid=1

waitfor delay '00:00:10'

update customer set cuscode='code_1011'
where custid=1

rollback transaction

-- dirty read

begin transaction

update customer set cusname='Amy Jackson'
where custid =1

-- amy wants to add the surname to billing

waitfor delay '00:00:15'

-- changes her mind and decided to go ahead with the old details

rollback transaction


-- create table product

create table pro(id int primary key,name varchar(100),quantity int)

insert into pro(id,name,quantity)
values
(1001,'mobile',10),
(1002,'Tablet',20),
(1003,'laptop',30)

select * from pro

-- lost update 

-- transaction 1

set transaction isolation level repeatable read

begin transaction

declare @quantity int

select  @quantity=quantity from pro where id=1001

waitfor delay '00:00:10'

set @quantity=@quantity-1
update pro set quantity=@quantity where id =1001
print @quantity

commit transaction


-- Non repeatable read problem

--set transaction isolation level read committed

set transaction isolation level repeatable read

begin transaction

select quantity from pro where id=1001

--wait time

waitfor delay '00:00:15'

select quantity from pro where id=1001

commit transaction

-- Phantom read problem
-- Transaction 1 

set transaction isolation level serializable
begin transaction
select count(*) from pro
waitfor delay '00:00:15'
select count(*) from pro
commit transaction


-- snapshot 

--set transaction isolation level serializable

begin transaction
select count(*) from pro
waitfor delay '00:00:15'
select count(*) from pro
commit transaction


begin transaction
update pro set quantity=30 where id=1001
waitfor delay '00:00:15'
select * from pro
commit transaction







