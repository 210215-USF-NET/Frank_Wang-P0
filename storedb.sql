--Drop sequence for tables

drop table customers;
drop table products;
drop table locations;

--creating tables

create table customers
(
    id int IDENTITY primary key,
    FirstName varchar(50) not null,
    PhoneNumber varchar(50) not NULL
    
);

create table locations
(
    id int IDENTITY primary key,
    LocationAddress varchar(50) not null,
    LocationID int not null
);

create table products
(
    id int IDENTITY primary key,
    ProductName varchar(50) not null,
    ProductDescription varchar(50) not null,
    ProductID int not null,
    ProductPrice decimal(10,2) not null
);



--Adding seed data
--insert into elementTypes (elementType) values 
--('Water'), ('Earth'), ('Air'), ('Fire');

--insert into heroes (heroName, hp, elementType) values
--('Spiderman', 100, 2), ('Thor', 1000, 4);

--insert into superpowers (name, description, damage, hero) values
--('Spidey senses', 'Anything a spider can', 10, 1),
--('Lightning control', 'Using a hammer as a conduit he controls lightning', 100, 2);

--select * from heroes in