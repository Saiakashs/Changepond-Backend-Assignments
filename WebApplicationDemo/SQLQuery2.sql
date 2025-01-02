create table dbo.Department(
id int Identity(1,1) not null,
name varchar(50),
constraint pk_department primary key clustered 
(id asc)
);




create table employee(
id int identity(1,1) not null,
departmentId int not null,
name varchar(100) not null,
designation varchar(25) not null,
constraint pk_employee primary key clustered
(id asc)
);




alter table employee with check add constraint fk_employee_department
foreign key(departmentid) references department(id)

alter table employee check constraint fk_employee_department