create database CalendarFinal;

use CalendarFinal;

create table dbo.Person
(
FirstName nchar(10) not null,
LastName nchar(10) not null, 
ID int primary key not null,
);

insert into Person values ('Alex', 'Carter', 1)
insert into Person values ('Steve', 'Rogers', 2)
insert into Person values ('Josh', 'Dontcare', 3)

create table dbo.InputEvent
(
ChosenDate datetime not null,
Purpose nvarchar(50) not null,
Describe nvarchar(60) not null,
TimeLength int not null,
ID int not null,
);

insert into InputEvent values ('2019-01-09', 'Try Me', 'Why Should I', 1, 1)
insert into InputEvent values ('2019-02-09', 'Try Us', 'Why Me', 2, 2)
insert into InputEvent values ('2019-03-09', 'Try IT', 'Why You', 2, 2)

create table dbo.Balancer
(
TimeLength int not null,
isitHealthy nvarchar(10) not null,
);

insert into Balancer values ('2019-01-09', 'No')
insert into Balancer values ('2019-02-09', 'Reconsider')
insert into Balancer values ('2019-03-09', 'Nada')
