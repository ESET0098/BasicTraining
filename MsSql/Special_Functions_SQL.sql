
create table a(id int,names varchar(50))

insert into a values(1,'k')
insert into a values(2,'ku')
insert into a values(3,'kunal')
insert into a values(4,'ki')
create table b(id int,names varchar(50))

insert into b values(5,'ki')
insert into b values(6,'kunm')
insert into b values(3,'kunal')
insert into b values(7,'kisdfgv')

---------union all containg the duplicate record also------------
select *from a union all
select *from b 

---------union not  containg the duplicate record ------------
select *from a union 
select *from b 


 -----------UPPER----------
select upper(names) as uppercase from a

----------LOWER--------
select lower(names)  from b


-------------Length- after joining two tables ----------

SELECT t.*,
       LEN(names) AS length_of_name
FROM (
    SELECT *
    FROM a
    UNION
    SELECT *
    FROM b
) AS t;

---------------SUBSTRING--------------------------

select SUBSTRING(names,2,3) as sub_name from b ;



--------------------REVERSE---------------


select *,REVERSE(names)  from b

----------REPLACE-----------------

select REPLACE(names,'ki','jindal') from b
select REPLACE('shivam likes tea','tea','coffee') as replace_word

------------NESTED Function-------------

select reverse(SUBSTRING(names,2,len(names))) from b 

-----------CONCAT-----------------

select concat('kunal','_','Jindal') as names1
--select concat(names,'','lastnames') from table--

---------cast(for changing the datatype)--------
select cast(id as float) from b

-------CONVERT------
select GETDATE() as todaydate

select convert(varchar(10) ,getdate(),103) as Date_DDMMYYYY --103 british date format--




