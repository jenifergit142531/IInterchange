

use inter


set transaction isolation level read committed
select * from customer where custid=1

-- transaction 2

select * from pro


set transaction isolation level repeatable read

begin transaction

declare @quantity int

select  @quantity=quantity from pro where id=1001

--waitfor delay '00:00:10'

set @quantity=@quantity-2

update pro set quantity=@quantity where id =1001
print @quantity

commit transaction


-- transaction 2

--set transaction isolation level read committed

set transaction isolation level repeatable read
update pro set quantity=3 where id=1001


-- transaction 2


set transaction isolation level serializable
begin transaction
insert into pro values(1010,'pods',12)
select count(*) from pro
commit transaction

-- set transaction isolation level serializable

alter database inter
set allow_snapshot_isolation on 
begin transaction
insert into pro values(1004,'pods',12)
select count(*) from pro
commit transaction



delete from pro where id between 1004 and 1111

select * from pro

alter database inter
set allow_snapshot_isolation on 
begin transaction
update pro set quantity=40 where id=1001
select * from pro
commit transaction

