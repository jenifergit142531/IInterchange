


use jeni

select * from one

select * from verify

delete from verify

-- DDL

-- CREATE DATABASE

create database inter

-- DROP DATABASE

drop database inter

-- truncate database

truncate table prop

-- alter database

alter table prop
add servicetype varchar(25)



use inter

-- data modelling
-- Property management

create table prop(propid int,propname varchar(20),ownername varchar(20),posteddate date,proprice money)

select * from prop


-- DML Commands 
-- make changes to the values inside the table
-- INSERT,DELETE,UPDATE

-- insert command

insert into prop(propid,propname,ownername,posteddate,proprice,servicetype)
values
(1,'Tulive','Jeni','10-3-2023',200000,'buy'),
(2,'Prestige','hari','10-2-2023',210000,'sell'),
(3,'Tul','gowri','10-1-2023',220000,'buy'),
(4,'arbor','sivasankari','09-10-2023',230000,'sell'),
(6,'bay','chitra','09-14-2023',240000,'buy')

-- delete command 

delete from prop where propid=3

delete from prop

-- update command

update prop set proprice=4200000 where propid=2

-- DQL : Data query language
-- SELECT 

select * from prop

select propname from prop

select * from prop where propid=5

select count(propid) from prop group by servicetype

select * from prop order by proprice

select distinct servicetype from prop

select max(proprice) from prop


select sum(proprice) from prop


select avg(proprice) from prop

select min(proprice) from prop


-- LIKE : Matches the pattern

select * from prop 
where propname LIKE 'T%'

select top 3 * from prop

select * from prop
where propname in('tul','arbor')

select * from prop
where propname not in ('tul','atbor')

select * from prop
where proprice between 200000 and 230000.00

select count(propid)
from prop
group by servicetype
having count(propid) < 3

select propname as propertyname
from prop

select propname from prop where ownername='jeni' and servicetype='sell'


select propname from prop where ownername='jeni' or servicetype='sell'


select propname,proprice from prop
where proprice > 
(select proprice from prop where propid=4)

select proprice from prop where propid=4 and servicetype='sell' or propid=3 and servicetype='buy'

alter table prop
alter column ownername varchar(24)


-- Why truncate is ddl ??

-- 1.faster
-- 2.Cannot roll back the data(transaction)

