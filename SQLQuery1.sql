

use inter

select * from employee

alter table employee
drop column profile

-- Create transaction
-- explicit transaction
begin transaction
insert into employee values(15,'jack','admin',25000)
update employee set salary=325000 where eid=6
delete from employee where eid=13
select * from employee
commit transaction

-- @@error - global variable if there is any error or not

begin transaction
insert into employee values(10,'success','hr',155000)
insert into employee values(null,'fail',45,5000)
if(@@ERROR>0)
begin
rollback transaction
select * from employee
end
else
begin
commit transaction
select * from employee
end

delete from employee where eid between 11 and 23

-- implicit transaction

set implicit_transactions on
insert into employee values(12,'success','hr',155000)
insert into employee values(13,'fail','it',5000)
select * from employee
commit transaction

-- autocommit transaction

insert into employee values(14,'success','hr',155000)
insert into employee values(15,'fail','it',5000)
select * from employee

-- @@trancount - returns the count of active/current transaction

set implicit_transactions on
insert into employee values(16,'success','hr',155000)
insert into employee values(17,'fail','it',5000)
--select * from employee
select @@TRANCOUNT as opentransaction
commit transaction
select @@TRANCOUNT as opentransaction


delete from employee where eid between 10 and 15

-- nested transaction(transaction inside another transaction)

begin transaction T1

insert into employee values(14,'success','hr',155000)
insert into employee values(15,'fail','it',5000)

begin transaction T2

update employee set ename='tom' where eid=14
update employee set ename='jerry' where eid=15


commit transaction t2
select @@TRANCOUNT as opentransaction

commit transaction t1
select @@TRANCOUNT as opentransaction

select * from employee


-- finding all the tables

select * from sys.tables

-- SAVEPOINT : break the transaction into multiple parts , so that user can roll back to any specified point.

1 - 100   : rollback 100 ---> 1

p1 - 1-25
p2 - 26 - 50
p3 - 51-75
p4 - 76 - 100 
rollback p4


delete from employee where eid between 10 and 15

begin transaction

save transaction savepoint1

insert into employee values(10,'success','hr',155000)
insert into employee values(11,'fail','it',5000)

save transaction savepoint2

insert into employee values(12,'success','hr',155000)
insert into employee values(13,'fail','it',5000)

save transaction savepoint3

insert into employee values(14,'success','hr',155000)
insert into employee values(15,'fail','it',5000)

--rollback transaction savepoint1

 rollback transaction savepoint2

--rollback transaction savepoint3

select * from employee


begin transaction
update employee
set ename='xxx'
where eid=5

rollback transaction


-- grant & revoke(grant or remove the permissions)

create table userlogin(userid int,username varchar(20))

insert into userlogin(userid,username)
values
(101,'user1'),
(102,'user2'),
(103,'user3'),
(104,'user4')

select * from userlogin


grant select
on userlogin
to public  -- public , username ,roleName


revoke select 
on userlogin
from public -- public , username ,roleName














