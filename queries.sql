

select * from employee

delete from employee where eid=201

create table employee2(eid int,ename varchar(20),role varchar(20),salary int)


alter procedure usp_insert
@eid int =5
as
begin
insert into employee2
select * from employee where eid=@eid
end


exec usp_insert

select * from employee2

truncate table employee2

-- while loop : executing set of statements for N number of times (multiple times)  until the condition is met

create procedure usp_mylist
@counter int=1
as
while @counter<5
begin
print @counter
set @counter=@counter+1
end


exec usp_mylist


alter procedure usp_traverse
as
declare @maxid int,@counter int,@empname varchar(20)
select @counter = min(eid),@maxid=max(eid) 
from employee
while(@counter is not null 
and @counter <= @maxid)
begin
select @empname = ename
from employee where eid=@counter
print @empname
set @counter=@counter +1
end

exec usp_traverse

-- case statement : multiple conditions evaluated 

create procedure usp_case
as
begin
select ename,
case
when salary > 35000 then 'Management' 
when salary < 30000 then 'Admin'
else 'IT'
end as profile
from employee
end

exec usp_case


-- 

select * from employee

alter table employee 
add profile varchar(20)


use inter

select * from employee

alter PROCEDURE usp_updatecase
AS 
BEGIN 
    DECLARE @counter INT, @maxid INT, @salary INT

 

    SELECT @maxid = MAX(eid) FROM employee 

    SET @counter = 1 

    WHILE @counter <= @maxid
    BEGIN
        SELECT @salary = salary FROM employee WHERE eid = @counter 

        IF @salary > 35000
            UPDATE employee SET profile = 'management' WHERE eid = @counter
			
        ELSE 
            UPDATE employee SET profile = 'admin' WHERE eid = @counter
			

        SET @counter = @counter + 1;
    END

	select * from employee
END

exec usp_updatecase

alter table employee
drop column profile

alter table employee
add profile varchar(20)




alter procedure usp_cursor
as
begin
declare @ename varchar(20),
@role varchar(20)

declare cursor10 CURSOR scroll 
for select
ename,role
from
employee

open cursor10
--fetch next from cursor7
fetch last from cursor10
while @@FETCH_STATUS=0
--fetch next from cursor7
fetch prior from cursor10
close cursor10
deallocate cursor10

end

exec usp_cursor


-- Functions
-- scalar functions

alter function avgsalary()
returns int
as
begin
declare @avgsal int
set @avgsal=0
select @avgsal=avg(salary) from employee
return @avgsal
end

select dbo.avgsalary() as average

select * from employee

alter function getemployees(@salary money)
returns table
as
return
select * from employee
where salary>@salary

select * from getemployees(30000)

-- call function inside stored procedure

create procedure usp_callfunction
as
begin
select * from getemployees(30000)
end

exec usp_callfunction

-- calling procedure inside procedure(nested procedure)
create procedure one
as
begin
exec usp_callfunction
end


exec one


alter function getemp()
returns @sremp table
(employeeid int,employeename varchar(20))
as
begin
insert into @sremp select eid,ename from employee where eid<7
return
end

select * from getemp()

-- Ranking functions 

create table movie(mname varchar(25),language varchar(20),tprice int)

insert into movie(mname,language,tprice)
values
('inception','english',400)
('ddreturns','tamil',250),
('tenet','english',300),
('jawan','hindi',250),
('leo','tamil',300),
('avatar','english',350),
('pathaan','hindi',275)

-- row_number() : unique sequential number to each row 

select mname,language,tprice,ROW_NUMBER() over (order by tprice desc) as  rownumber
from movie


-- rank() - specify the rank for the result set

select mname,language,tprice,rank() over (partition by language order by tprice desc) as  rank
from movie

select mname,language,tprice,rank() over (order by tprice desc) as  rank
from movie


-- dense_rank() - avoid gaps in the numbering 

select mname,language,tprice,dense_rank() over (order by tprice desc) as  rank
from movie

select mname,language,tprice,dense_rank() over (partition by language order by tprice desc) as  rank
from movie


-- ntile

select *,
ntile(3) over(
partition by language order by tprice desc) as rank
from movie
order by rank