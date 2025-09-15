
--create procedure retrieve_data
--as

--begin

--select *from Students2024


----end

--exec retrieve_data

--drop procedure retrieve_data



create procedure retrieve_dataa
@id int
as 

begin

select *from Students2024 where id = @id


end

exec retrieve_dataa @id=5

use  employe

create procedure checkEmployeeSalary
 @Id int
 as 
 begin
 declare @salary int;
 select @salary = salary
 from em
 where Id = @Id

 if @salary >=50000
     print 'High Salary';
 
 else if @salary>=30000
	print 'Medium Salary';

 else
	print 'Low Salary';

end

exec checkEmployeeSalary @id=2

create trigger try_to_insert
on em
after insert
as 
begin
    print 'A new employee inserted';

end

insert into em values(10,'k','machanical',4562)