create database AdvancedDB
use AdvancedDB

create table Employees (
    EmployeeId int primary key,
    FirstName nvarchar(50),
    LastName nvarchar(50),
    Birthdate date,
    Salary decimal
)

create table Products
(ProductId int primary key,
ProductName nvarchar(50),
Description nvarchar(50),
price money,
ReleaseDate datetime
)

create table Orders
(OrderId int primary key,
OrderDate datetime,
Quantity smallint,
Discount float,
isShipped bit
)
