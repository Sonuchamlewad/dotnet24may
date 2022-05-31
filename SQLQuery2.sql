create table Emp(id int, empname varchar(200),gender varchar(10), salary varchar(10), department varchar(10));
select * from emp;
insert into Emp values(1,'A','female',20000,20);
insert into Emp values(2,'B','male',25000,10);
insert into Emp values(3,'C','female',21000,30);
insert into Emp values(4,'D','male',22000,40);
select max(salary) from Emp
select min(salary) from Emp
select count(*) from Emp

