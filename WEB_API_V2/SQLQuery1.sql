Create database Test_v2
go
use Test_v2
go
create table Tbl_Store
(
storeid int identity(1,1)  primary key,
storename varchar(50),
storelocation varchar(50)
)
go
create table Tbl_Staff
(
staffid int identity(1,1) primary key,
storeid int references Tbl_Store(storeid),
staffname varchar(50),
staffaddress varchar(50)
)
go
create table Tbl_Product
(
productid int identity(1,1) primary key,
storeid int references Tbl_Store(storeid),
staffid int references Tbl_Staff(staffid),
productname varchar(50),
productquantity int,
productprice decimal
)

insert into Tbl_Store values ('AStore','Canada'),('BStore','USA'),('CStore','Texas'),('DStore','Las Vegas')

select * from Tbl_Store

insert into Tbl_Staff values (1,'Carlo','Balamban'),(2,'Erika','Banilad'),(3,'Sarah','Talisay'),(4,'John','Carbon')

select * from Tbl_Staff

insert into Tbl_Product values (1,5,'Royal',20,18),(2,6,'Royal',45,18),(3,7,'Sprite',38,18),(4,8,'Royal',15,18)

select * from Tbl_Product


select distinct productname as 'Product Name' from Tbl_Product prod 
inner join Tbl_Staff staff on prod.staffid = staff.staffid
inner join Tbl_Store store on prod.storeid= store.storeid
where storelocation='Canada'


Create Proc sp_GetProducts as Select * from Tbl_Product
Create Proc sp_GetStaff as Select * from Tbl_Staff
Create Proc sp_GetStore as Select * from Tbl_Store

