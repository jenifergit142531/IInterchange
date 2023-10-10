



use inter


select * from inserted

select * from deleted



select * from employee

-- create a employee log table 

create table emplog(logid int identity(1,1) not null,empid int not null,operation varchar(20),updatedate datetime not null)

alter table emplog
add empname varchar(20)

select * from emplog

-- create trigger

alter trigger trg_empinsert
on employee
FOR INSERT
as
insert into emplog(empid,operation,updatedate,empname)
select eid,'INSERT',GETDATE(),ename from INSERTED

-- insert values to employee table

insert into employee(eid,ename,role,salary,profile)
values
(12,'patrick','SE',20000,'IT')

select * from emplog

-- create a trigger for delete

create trigger trg_delete
on employee
FOR DELETE
as 
insert into emplog(empid,operation,updatedate,empName)
select eid, 'DELETE', GETDATE(),ename from DELETED

 

DELETE FROM EMPLOYEE WHERE eid = 10;

select * from emplog


-- create a trigger for update 

create trigger trg_update
on employee
FOR UPDATE    -- trigger gets fired when the execution starts
as 
insert into emplog(empid,operation,updatedate,empName)
select eid, 'UPDATE', GETDATE(),ename from DELETED


update employee set profile='it' where eid=9

-- use after clauses 

select * from movie

create table movielog(logid int identity(1,1) not null,moviename varchar(20),ticketprice int,operation varchar(10),changeddate datetime) 


create trigger trg_movieupdate
on movie
after UPDATE  -- trigger gets fired when the execution completes
as 
insert into movielog(moviename,ticketprice,operation,changeddate)
select mname,tprice, 'UPDATE', GETDATE() from INSERTED

update movie set tprice=500 where mname='ddreturns' 

select * from movielog


-- instead of clause => override the trigger for insert,delete,update


ALTER trigger trg_moviedelete
on movie
INSTEAD OF DELETE  
as 
insert into movielog(moviename,ticketprice,operation,changeddate)
select mname,tprice, 'DELETE', GETDATE() from DELETED

delete from movie where mname='ddreturns'

select * from movielog

SELECT * FROM MOVIE

-- DDL Trigger

-- create a database log 

create table databaselog(logid int identity(1,1) not null,
eventval xml ,
eventdate datetime,
changedby SYSNAME)

select * from databaselog

-- create a trigger 

create trigger trg_dbchange
on database
FOR
CREATE_TABLE,
ALTER_TABLE,
DROP_TABLE
--TRUNCATE_TABLE

as
begin
insert into databaselog
(eventval,eventdate,changedby)
values
(EVENTDATA(),GETDATE(),USER)

end

create table onetwo(id int,name varchar(20))

select * from databaselog

-- enable or disable the trigger

disable trigger trg_movieupdate
on movie

enable trigger trg_movieupdate
on movie

-- drop the trigger

drop trigger trg_movieupdate

drop trigger trg_dbchange on database

truncate table emp2

select * from emp2

drop table emp3

-- LOGON Trigger  

create trigger trglogin
on ALL SERVER WITH EXECUTE AS 'AzureAD\JeniferY'
FOR LOGON
as
begin
if ORIGINAL_LOGIN()='yourservername' and
(select count(*) from sys.dm_exec_sessions
where is_user_process = 1 and
original_login_name='yourservername')>2
rollback;
end


select * from employee

create view view_sal
as
select * from employee where salary > 35000

create view view_avgsal
as
select avg(salary) as average from employee


select eid,ename from view_sal

select * from view_avgsal

-- stored procedure calling a VIEW

create procedure usp_callview
as
begin
select * from view_avgsal
end

exec usp_callview




