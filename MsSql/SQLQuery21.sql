create database Employees

use Employees

create table Em(Id int,names varchar(50),dept varchar(50),salary float)

select *from Em

insert into Em(Id,names,dept,salary) values (1,'sharadh','hr',200000),(2,'akash','It',100000),(3,'abhishek','hr',250000),(4,'kunal','marketing',400000),(5,'soumya','It',100000)

update Em set salary=1.4*salary 

delete from Em where salary=350000

exec sp_rename 'Em','Family'

select *from Family;

alter table Family 
add addrs varchar(250)

alter table Family
alter column salary varchar(50)

exec sp_help Family

alter table Family
add phone_no varchar(10)

alter table Family
drop column addrs

update Family set phone_no='7894561223' where id=5;

exec sp_rename 'Family.phone_no','mob','column'