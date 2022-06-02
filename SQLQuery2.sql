create table employe (id int,name varchar(200),departmentid int)
create table depart(id int,department varchar(20))
insert into employe values(1,'sneha',1)
insert into employe values(2,'sangam',2)
insert into employe values(3,'sneha',1)
insert into employe values(4,'Rohan',3)

insert into depart values(1,'IT') 
insert into depart  values(2,'Sales')
insert into depart values(4,'Admin')

select * from employe
select * from depart

select emp.name,dep.department from employe as emp inner join depart as dep on emp.departmentid=dep.id

select emp.name,dep.department from employe as emp left join depart as dep on emp.departmentid=dep.id

select emp.name,dep.department from employe as emp right join depart as dep on emp.departmentid=dep.id

select * from employe as emp inner join depart as dep on emp.departmentid=dep.id;

