create database Student_Management
use Student_Management


CREATE TABLE [Student] (
SId varchar(80) primary key NOT NULL,
  First_Name varchar(80) NOT NULL,
  Middle_Name varchar(80) NOT NULL,
  Last_Name varchar(80) NOT NULL,
  Gender varchar(10) NOT NULL,
  Department varchar(80) NOT NULL,
  Photo image NOT NULL,
  Password varchar(80) NOT NULL,
  Batch varchar(80)NOT NULL,
  Phone varchar(80) NOT NULL,
  email varchar(80) NOT NULL,
  DOB date NOT NULL,
  programme varchar(80)NOT NULL


)
drop table Student


GO
CREATE TABLE [Course] (
CourseId varchar(80) primary key NOT NULL,
  Course_Code varchar(80) NOT NULL,
  Course_Name varchar(80)  NOT NULL,
  Credit_Hour integer NOT NULL,
  Term varchar(20), 
  TId varchar(80) NOT NULL
)

Insert into Course 
values ('DRB2001ccCalc','ccCalc','Calculus','4','Summer','1'),
('DRB2001ccPsy','ccPsy','Psychology','4','Summer','2'),
('DRB1801ccHis','ccHis','History','3','Winter','3'),
('DRB2001ccOOP','ccOOP','Object Oriented Programming','5','Summer','5'),
('DRB1801ccFP1','ccFP1','Fundametals of Programming I','5','Spring','4')



drop table Course

GO
CREATE TABLE [Teacher] (
  TId varchar(80) primary key NOT NULL,
  First_Name varchar(80) NOT NULL,
  Middle_Name varchar(80) NOT NULL,
  Last_Name varchar(80) NOT NULL,

  DOB date NOT NULL,
  Phone varchar(80) NOT NULL,
  Educational_Level varchar(80) NOT NULL,
  Gender varchar(10) NOT NULL,
  Teaches_course varchar(80) NOT NULL,
  Photo image NOT NULL,
  Password varchar(80) NOT NULL,
   email varchar(80) NOT NULL

)

select * from Student

drop table Teacher
GO
CREATE TABLE [Admin] (
  AId varchar(80) primary key NOT NULL,
  First_Name varchar(80) NOT NULL,
  Middle_Name varchar(80) NOT NULL,
  Last_Name varchar(80) NOT NULL,

  DOB date,
  Phone varchar(80)  NOT NULL,
  Gender varchar(10) NOT NULL,
  Photo image ,
  Password varchar(80)  NOT NULL,
  email varchar(80) NOT NULL
  
 
)
drop table Admin
GO
CREATE TABLE [Score] (
SId varchar(80) ,
CourseId varchar(80) ,
 Mid integer ,
  Final integer ,
  Assesment integer,
  Total integer ,
  grade varchar(30) 
 
  
)
drop table Score
GO

ALTER TABLE Score
ADD FOREIGN KEY (SId) REFERENCES Student(SId)

ALTER TABLE Score
ADD FOREIGN KEY (CourseId ) REFERENCES Course(CourseId );

ALTER TABLE Course
ADD FOREIGN KEY (TId) REFERENCES Teacher(TId );

Go
create proc [dbo].[spInsertStud]
@username varchar(30),
@firstname varchar(30),
@middlename varchar(30),
@lastname varchar(30),
@email varchar(30),
@password varchar(30),
@department varchar(30),
@programme varchar(30),
@photo image,
@phone varchar(30),
@batch varchar(30),
@gender varchar(30),
@date varchar(80)

AS
Begin
declare @datet date
set @datet=CAST (@date as date) 
Insert into Student values
(@username,@firstname,@middlename,@lastname,@gender,@department,@photo,@password,@batch,@phone,@email,@datet,@programme)
End


select* from Student

delete from Student
where Batch='DRB 2001'


Go
create proc [dbo].[spInsertteacher]
@usernamet varchar(30),
@firstname varchar(30),
@middlename varchar(30),
@lastname varchar(30),
@email varchar(30),
@password varchar(30),
@edulevel varchar(30),
@courseoff varchar(30),
@photo image,
@phone varchar(30),
@gender varchar(30),
@date varchar(80)

AS
Begin
declare @datet date
set @datet=CAST (@date as date) 
Insert into Teacher values
(@usernamet,@firstname,@middlename,@lastname,@datet,@phone,@edulevel, @gender,@courseoff,@photo,@password,@email)
End

select * from Teacher

Go
create proc [dbo].[spInsertadmin]
@username varchar(30),
@firstname varchar(30),
@middlename varchar(30),
@lastname varchar(30),
@email varchar(30),
@password varchar(30),
@photo image,
@phone varchar(30),
@gender varchar(30),
@date varchar(80)

AS
Begin
declare @datet date
set @datet=CAST (@date as date) 
Insert into Admin values
(@username,@firstname,@middlename,@lastname,@datet, @phone, @gender,@photo,@password,@email)
End

select* from Admin

select * from tblUser
alter proc [dbo].[spGetstudent]
@firstname varchar(30),
@middlename varchar(30),
@lastname varchar(30),
@Sid varchar(30),
@batch varchar(30)

AS
Begin
Select * from Student
where   First_Name like   @firstname + '%' and Middle_Name like  @middlename + '%' and Last_Name like   @lastname +'%' and SId LIKE @Sid + '%' and Batch LIKE @batch + '%' 
End 

Go
create proc [dbo].[spGetteacher]
@firstname varchar(30),
@middlename varchar(30),
@lastname varchar(30),
@tid varchar(30),
@course varchar(30)

AS
Begin
Select * from Teacher
where   First_Name like   @firstname + '%' and Middle_Name like  @middlename + '%' and Last_Name like   @lastname +'%' and TId LIKE @tid + '%' and Teaches_course LIKE @course + '%' 
End 



Go
create proc [dbo].[spGetadmin]
@firstname varchar(30),
@middlename varchar(30),
@lastname varchar(30),
@aid varchar(30)

AS
Begin
Select * from Admin
where   First_Name like   @firstname + '%' and Middle_Name like  @middlename + '%' and Last_Name like   @lastname +'%' and AId LIKE @aid + '%'
End 






Go
create proc [dbo].[spUpdatestudent]
@username varchar(30),
@firstname varchar(30),
@middlename varchar(30),
@lastname varchar(30),
@email varchar(30),
@password varchar(30),
@department varchar(30),
@programme varchar(30),
@photo image,
@phone varchar(30),
@batch varchar(30),
@gender varchar(30),
@date varchar(80)
AS

declare @datet date
set @datet=CAST (@date as date) 
update Student 
set First_Name=@firstname,Middle_Name=@middlename,Last_Name=@lastname,SId=@username,Photo=@photo,
Password=@password,Batch=@batch,Phone=@phone,email=@email,DOB=@datet,programme=@programme
where SId=@username


Go
create proc [dbo].[spUpdateteacher]
@username varchar(30),
@firstname varchar(30),
@middlename varchar(30),
@lastname varchar(30),
@email varchar(30),
@password varchar(30),
@edulevel varchar(30),
@courseoff varchar(30),
@photo image,
@phone varchar(30),
@date varchar(80)
AS

declare @datet date
set @datet=CAST (@date as date) 
update Teacher
set First_Name=@firstname,Middle_Name=@middlename,Last_Name=@lastname,TId=@username,Photo=@photo,
Password=@password,Teaches_course=@courseoff,Phone=@phone,email=@email,DOB=@datet,Educational_Level=@edulevel
where TId=@username





Go
create proc [dbo].[spUpdateadmin]
@username varchar(30),
@firstname varchar(30),
@middlename varchar(30),
@lastname varchar(30),
@email varchar(30),
@password varchar(30),
@photo image,
@phone varchar(30),
@date varchar(80)
AS

declare @datet date
set @datet=CAST (@date as date) 
update Admin
set First_Name=@firstname,Middle_Name=@middlename,Last_Name=@lastname,AId=@username,Photo=@photo,
Password=@password,Phone=@phone,email=@email,DOB=@datet
where AId=@username







create  proc [dbo].[spDeletestudent]
@id varchar(30)
as 
begin
delete Student where SId=@id
end



Go
alter  proc [dbo].[spDeleteteacher]
@tid varchar(30)
as 
begin
delete Teacher where TId=@tid
end


Go
create  proc [dbo].[spDeleteAdmin]
@aid varchar(30)
as 
begin
delete Admin where AId=@aid
end

Go
create proc [dbo].[spaddcourse]
@username varchar(30),
@courseid varchar(30)
AS
Begin

Insert into Score(SId,CourseId) values
(@username,@courseid)
End



select * from Score



Go
create proc [dbo].[spscoreteacher]
@firstname varchar(30),
@middlename varchar(30),
@lastname varchar(30),
@sid varchar(30),
@batch varchar(30),
@term varchar(30)

AS
Begin
Select * from Admin
where   First_Name like   @firstname + '%' and Middle_Name like  @middlename + '%' and Last_Name like   @lastname +'%' and AId LIKE @aid + '%'

select Student.First_Name,Student.Middle_Name,Student.Last_Name,Student.SId,Course.Course_Name, Student.Batch, Score.Assesment, Score.Mid,Score.Final,Score.Total,Score.grade 
from Score 
inner join Student on Score.SId=Student.SId
inner join Course on Score.CourseId=Course.CourseId ;


End 


go

create proc admincheck
@username varchar(50),
@password varchar(50)
as
begin
select First_Name+' '+Last_Name from [Admin]
where AId=@username and Password=@password
end

create proc studentcheck
@username varchar(50),
@password varchar(50)
as
begin
select First_Name+' '+Last_Name from Student
where SId=@username and Password=@password
end

create proc teachercheck
@username varchar(50),
@password varchar(50)
as
begin
select First_Name+' '+Last_Name from Teacher
where TId=@username and Password=@password
end

drop proc admincheck
exec admincheck Aba,123

select *from [Admin]
insert into [Admin] values ('AA1','ama','abubeker','omer',null,0947424209,'m',null,'123','ama@gmail.com')