

use inter


select * from employee

select * from emp

select * from product

-- Non clustered Index


create table game(gid int,gname varchar(20),type varchar(20),loginmail varchar(25),phoneno varchar(20))


drop table game

insert into game(gid,gname,type,loginmail,phoneno)
values
(101,'xoxo','multiplayer','player1@gmail.com','12345'),
(102,'rockpaper','multiplayer','player2@gmail.com','23456'),
(103,'ludo','multiplayer','player3@gmail.com','34567'),
(104,'snooker','singleplayer','player4@gmail.com','45678')

select * from game

create nonclustered index ncx_email
on game(loginmail)


-- self join

SELECT * FROM EMPLOYEE

select e1.eid,e2.ename
from 
employee e1,
employee e2
where e1.eid < e2.eid

select * from employee

-- create procedure

create procedure sp_select
as
begin
select * from employee where salary > 30000
end

alter procedure sp_select
as
begin
select * from employee where salary > 30000
select * from product
end

exec sp_select

-- insert  

create procedure sp_insert
(@id int,
@name varchar(20),
@role varchar(20),
@sal int)
as
begin
insert into employee(eid,ename,role,salary)
values
(@id,@name,@role,@sal)
end

exec sp_insert
@id=201,
@name='aaa',
@role='pilot',
@sal=67890

exec sp_select

select * from employee

-- procedure to delete

create procedure sp_deleteemp
@id int
as
begin
delete from employee where eid=@id
end

exec sp_deleteemp @id=200

select * from employee

-- procedure to update

create procedure sp_update
@id int,
@role varchar(20)
as
begin
update employee set role=@role where eid=@id
end

exec sp_update @id=201,@role='promptengineer'

exec sp_select

--view the procedure

sp_helptext sp_insert
sp_help <procedurename>

exec sp_help

-- encrpt the procedure

alter procedure sp_select
with encryption
as
begin
select * from employee 
end

exec sp_select

sp_helptext sp_select

alter procedure sp_select
as
begin
select * from employee 
end

-- Exception handling try...catch

alter procedure usp_divide
@a decimal,
@b decimal,
@c decimal output
as
begin
  begin try
  set @c=@a/@b
  end try

  begin catch
     select ERROR_LINE() as errorline,
	 ERROR_SEVERITY() as severitylevel,
	 ERROR_MESSAGE() as message
  end catch
end


declare @c decimal
exec usp_divide 10,0,@c output
print @c


select * from employee
select * from department

-- using try ..catch block for table

create procedure usp_emptable
@id int
as
begin
begin try
delete from department where deptid=@id
end try
begin catch
select
ERROR_MESSAGE() as errormessage
end catch
end

exec usp_emptable @id=123


-- If else in stored procedure 


select * from employee

alter procedure usp_check
as
begin 
declare @result int
set @result=0
select @result=avg(salary) from employee
if @result > 150000
select * from employee
else
print 'salary is less than 50000 for this employee group'
end

exec usp_check