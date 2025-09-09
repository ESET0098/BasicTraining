create database SmartMeter

use  SmartMeter
---------------------------TASK 0--------------------------------------------------
create table customer(customerid int primary key,names varchar(50), addres varchar(100),region varchar(10))

create table smartMeterRead(Meterid int primary key,customerid int foreign key references customer, loaction varchar(10),InstalledDate varchar(20),ReadingDateTime varchar(20), EnergyConsumed float)

Insert into customer values(1,'kunal','Bangalore','south')
Insert into customer values(2,'abhishek','Mangalore','south')
Insert into customer values(3,'manjit','Rourkela ','south')
Insert into customer values(4,'vijay','Delhi','north')

insert into smartMeterRead values (10,1,'rooftop','15/08/2021','2024-03-15 10:00',15)
insert into smartMeterRead values (20,2,'basement','18/09/2021','2024-02-18 11:00',45)
insert into smartMeterRead values (30,3,'rooftop','17/01/2021','2024-01-17 12:00',50)
insert into smartMeterRead values (40,4,'basement','20/08/2021','2024-08-20 11:00',100)

select *from smartMeterRead
select *from customer


----------------------------------------TASK 1---------------------------------------------------

----Query for EnergyConsumed between 10 to 50-----------
select *from smartMeterRead where EnergyConsumed>=10 and EnergyConsumed<=50



----Query for readingdatetime between 2024-01-01 00:00  to 2024-12-01 23:59-----------
SELECT *
FROM smartMeterRead
WHERE ReadingDateTime BETWEEN '2024-01-01 00:00' AND '2024-12-01 23:59';



----Query for InstalledDate after specific Date-----------
select *from smartMeterRead where InstalledDate>'15/08/2021';

------------------------TASK 2------------------------------------------
--------------Avg Energy consumed---------------------
select avg(EnergyConsumed) as AvgEnergyConsumed from smartMeterRead;

--------------MAX Energy consumed---------------------
select max(EnergyConsumed) as MaxEnergyConsumed from smartMeterRead;

--------------only inlude reading for current year  ---------------------

select *from smartMeterRead where  year(ReadingDateTime) = 2025;
