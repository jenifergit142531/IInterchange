

use interchange

select * from prop

-- rename database

alter database interchange 
modify name = inter


select * from prop

-- Key constraint

create table employee(eid int primary key,ename varchar(20),role varchar(20),salary int)

--alter table employee
--add primary key (ename)

insert into employee(eid,ename,role,salary)
values

(3,'aaa','hr',30000),
(4,'bbb','sales',45000)


(null,'ddd','IT',45000),

select * from employee


alter table employee
drop constraint PK__employee__D9509F6DBB1757D1


truncate table employee

alter table employee
add constraint pk_employee primary key(eid)


-- Identity key (auto increment key)

create table emp(eid int identity,ename varchar(20))

insert into emp(ename)
values
('aaa'),
('bbb')

select * from emp

-- adding identity key to the new table

create table emp2(emp int identity(1000,2),ename varchar(21))

insert into emp2(ename)
values
('ccc'),
('ddd')


select * from emp2

-- Making changes to the existing identity key

alter table emp
drop column eid 

alter table emp
add eid int identity(100,1)

select * from emp

-- Decimal values(float,double,decimal)

alter table emp
add salary decimal 

select * from emp

insert into emp
values
('ccc',1200.25),
('ddd',1234.45)

alter table emp
drop column salary

alter table emp
add salary float

-- Unique identifier

create table emp3(eid uniqueidentifier PRIMARY KEY default newid(),ename varchar(20))

create table emp3(eid uniqueidentifier PRIMARY KEY default newsequentialid(),ename varchar(20))

drop table emp3
truncate table emp3

insert into emp3(ename)
values
('one'),
('two'),
('three'),
('four')


select * from emp3

select * from emp3 where ename='two'

-- Foreign key

select * from employee

create table department(deptid int primary key,dname varchar(20),eid int)
eid int foreign key references employee(eid))
on delete cascade
on update cascade) 

drop table department

insert into department(deptid,dname,eid)
values 
(102,'HR',null),

(101,'IT',3),

(103,'Sales',4)

select * from department

select * from employee

-- update & delete commands 

-- with & without cascade option

-- delete

delete from employee where eid=3

update employee set eid=5 where ename='bbb'

alter table department
add constraint fk_empid foreign key(eid) references employee(eid)
on delete cascade
on update cascade

insert into employee(eid,ename,role,salary)
values
(6,'jack','analyst',35000),
(7,'jon','tester',30000),
(8,'aron','SE',135000),
(9,'amy','business analyst',25000),
(10,'steve','Scrum master',45000)

insert into department(deptid,dname,eid)
values
(103,'hr',null)
(101,'IT',8),
(102,'Project',9)

create table payroll(pid int,pdate date,eid int foreign key references employee(eid))

insert into payroll(pid,pdate,eid)
values
(0002,'9-10-2023',8)


select * from department
select * from employee
select * from payroll

-- Joins
-- Inner join

select e1.eid,e1.ename,d1.dname
from 
employee e1
inner join
department d1
on e1.eid=d1.eid

-- full join

select e1.eid,e1.ename,d1.dname
from 
employee e1
full join
department d1
on e1.eid=d1.eid

-- left join 

select e1.eid,e1.ename,d1.dname
from 
employee e1
left  join
department d1
on e1.eid=d1.eid

- right join 

select e1.eid,e1.ename,d1.dname
from 
employee e1
right join
department d1
on e1.eid=d1.eid


-- joining 3 tables

select e1.eid,d1.dname,p1.pdate
from
employee e1
inner join
department d1
on e1.eid=d1.eid
inner join
payroll p1
on p1.eid=e1.eid




-- Self join

select e1.eid,e2.ename
from 
employee e1,
employee e2
where e1.eid < e2.eid


-- CROSS JOIN (CARTESIAN JOIN)

select employee.eid,department.dname
from 
employee 
cross join
department


-- Subquery - query within another query

-- inner query(subquery)

-- outer query(main query)

select * from employee
select * from department
select * from payroll


-- who earns more than jon ??

select ename,salary from employee 
where salary >
(select salary from employee where ename='jon')


-- List of employee who works in the same role

select * from employee
where role IN
(select role from employee where ename in ('bbb','amy')) 

-- ranking

-- find nth highest salary

select * from (
select ename,salary,DENSE_RANK() over 
(order by salary desc) as result
from employee) as subquery
where result=2;

--select distinct salary from employee order by salary desc limit 2,1;  syntax check required


select top 3 * from employee order by salary desc

select * from employee

-- clustered index

create table product(pid int,pname varchar(20))

insert into product(pid,pname)
values
(3,'macbook'),
(1,'iphone'),
(2,'laptop')

select * from product

create clustered index cx_pro
on product(pid)

alter table product
add purchasemail varchar(45)

alter table product
add phoneno varchar(45)


update product set purchasemail='one@gmail.com' where pid=1
update product set purchasemail='two@gmail.com' where pid=2
update product set purchasemail='three@gmail.com' where pid=3


update product set phoneno='12345' where pid=1
update product set phoneno='23456' where pid=2
update product set phoneno='34567' where pid=3

create nonclustered index ncx_mail
on product(purchasemail)

create nonclustered index ncx_phoneno
on product(phoneno)

drop index ncx_phoneno on product
drop index ncx_mail on product

alter table product 
drop column phoneno

alter table product
add phoneno int 

alter table product
add unique(phoneno)

insert into product values(4,'xbox','jeni@gmail.com','23456')













