exec sp_help appartment

exec sp_rename 'appartment','society';

select *from society
exec sp_help society

exec sp_rename 'society.phone_no' ,'mob','column';
