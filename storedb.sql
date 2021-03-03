--Drop sequence for tables

drop table customers;
drop table products;
drop table locations; 
drop table inventory;

--Create Tables

create table customers
(
    id int IDENTITY primary key,
    FirstName varchar(50) not null,
	LastName varchar(50) not null,
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

create table inventory
(
	id int IDENTITY primary key,
	LocationIdentity int not null,
	InventoryID int not null,
	InventoryQuantity int not null


);



insert into Customers (FirstName, LastName, PhoneNumber) values
	('Joshua', 'Hepson', '704-649-2486'),
	('Jennifer','Li', '650-959-6880'),
	('Tom', 'Stephens', '108-656-2880');

insert into locations (LocationAddress, LocationID) values
	('480 Maclane St. Palo ALto, CA. 95051.', '1'),
	('187 Primrose Dr. Allentown, PA. 18107.', '2'),
	('1200 Park Ave. Bridgeport, CT. 06604.', '3');


insert into Products (ProductName, ProductDescription, ProductID, ProductPrice) values
	('Horizon Original', 'Original Flavored Chips', '1001', '5.99'),
	('Horizon Barbeque Chips', 'Barbeque Flavored Chips', '1002', '6.20'),
	('Horizon Salt and Vinegar', 'Salt and Vinegar Flavored Chips', '1003', '4.99'),
	('Horizon Sour Cream and Onion', 'Sour Crean and Onion Flavored Chips', '1004', '5.49');

insert into inventory (LocationIdentity, InventoryID, InventoryQuantity) values
	(1, 1001, 80),
	(1, 1002, 50),
	(1, 1003, 39),
	(1, 1004, 22),
	(2, 1001, 150),
	(2, 1002, 110),
	(2, 1003, 142),
	(2, 1004, 123),
	(3, 1001, 6),
	(3, 1002, 5),
	(3, 1003, 2),
	(3, 1004, 3);

	


	Select*From customers;
	Select*From locations;
	Select*From products;
	Select *From inventory;