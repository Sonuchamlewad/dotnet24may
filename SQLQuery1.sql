create database SampleDb2;
Drop database SampleDb2;
create table sample(id int,name varchar(200));
select * from sample;
insert into sample values(1,'sneha1');
insert into sample values(1,'sneha2');
insert into sample values(1,'sneha3');
insert into sample values(1,'sneha4')
create table Employee(id int, empname varchar(200),gender varchar(10));
insert into Employee values(1,'sonu','female');
insert into Employee values(2,'sonu1','female');
insert into Employee values(3,'Abc','male');
select * from Employee;
create table student(id int,rollno int,FirstName varchar(20),LastName varchar(20),Gender varchar(10));

select * from student;


insert into student values(1,'101','sangam',' chamlewad','Male');
insert into student values(2,'102','mayur','budhware','Male');
insert into student values(3,'103','Vishal','ook','Male');
insert into student values(4,'104','swati','monit','FeMale');
insert into student values(5,'105','Shital','sharma','FeMale');

select * from student where Gender='Female';

select * from student where Gender='Male';

select * from student order by id desc 
select * from student order by id asc 

select * from student where rollno=101;
select * from student where rollno=103;
select * from student where rollno=105;

select * from student where rollno in (101,103,105);
select * from student where rollno not in (101,103,105);

select max(rollno) from student
select min(rollno) from student
select AVG(rollno) from student
select count(*) from student 

select  * from student where FirstName like 's%'
--name=s
--name=sangam
select  * from student where FirstName like '%m%'

select CONCAT(FirstName,' ',LastName) as FullName  from student

