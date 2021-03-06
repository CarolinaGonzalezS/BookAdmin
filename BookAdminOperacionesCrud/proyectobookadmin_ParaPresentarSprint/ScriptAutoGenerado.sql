USE [master]
GO
/****** Object:  Database [BDDLibrary]    Script Date: 08/11/2017 23:48:02 ******/
CREATE DATABASE [BDDLibrary] ON  PRIMARY 
( NAME = N'BDDLibrary', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\BDDLibrary.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BDDLibrary_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\BDDLibrary_log.LDF' , SIZE = 576KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BDDLibrary] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BDDLibrary].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BDDLibrary] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [BDDLibrary] SET ANSI_NULLS OFF
GO
ALTER DATABASE [BDDLibrary] SET ANSI_PADDING OFF
GO
ALTER DATABASE [BDDLibrary] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [BDDLibrary] SET ARITHABORT OFF
GO
ALTER DATABASE [BDDLibrary] SET AUTO_CLOSE ON
GO
ALTER DATABASE [BDDLibrary] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [BDDLibrary] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [BDDLibrary] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [BDDLibrary] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [BDDLibrary] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [BDDLibrary] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [BDDLibrary] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [BDDLibrary] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [BDDLibrary] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [BDDLibrary] SET  ENABLE_BROKER
GO
ALTER DATABASE [BDDLibrary] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [BDDLibrary] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [BDDLibrary] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [BDDLibrary] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [BDDLibrary] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [BDDLibrary] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [BDDLibrary] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [BDDLibrary] SET  READ_WRITE
GO
ALTER DATABASE [BDDLibrary] SET RECOVERY SIMPLE
GO
ALTER DATABASE [BDDLibrary] SET  MULTI_USER
GO
ALTER DATABASE [BDDLibrary] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [BDDLibrary] SET DB_CHAINING OFF
GO
USE [BDDLibrary]
GO
/****** Object:  Table [dbo].[Editorial]    Script Date: 08/11/2017 23:48:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Editorial](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](30) NOT NULL,
	[country] [varchar](30) NULL,
	[city] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 08/11/2017 23:48:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[identificationCard] [varchar](10) NOT NULL,
	[name] [varchar](30) NOT NULL,
	[lastName] [varchar](30) NOT NULL,
	[phone] [varchar](10) NOT NULL,
	[celphone] [varchar](10) NOT NULL,
	[addres] [varchar](30) NOT NULL,
	[mail] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[identificationCard] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Category]    Script Date: 08/11/2017 23:48:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Category](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](30) NOT NULL,
	[descriptionC] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Author]    Script Date: 08/11/2017 23:48:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Author](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](30) NOT NULL,
	[lastName] [varchar](30) NULL,
	[nationality] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Administrator]    Script Date: 08/11/2017 23:48:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Administrator](
	[id] [int] NOT NULL,
	[name] [varchar](30) NOT NULL,
	[passwordA] [varchar](256) NOT NULL,
 CONSTRAINT [PK__Administ__3213E83F7F60ED59] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Fine]    Script Date: 08/11/2017 23:48:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Fine](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[value] [money] NOT NULL,
	[descriptionF] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/***Procedimientos Almacenados*/
/****** Object:  StoredProcedure [dbo].[updateAuthor]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[updateAuthor]
@id int,
@name varchar(30),
@lastName varchar(30),
@nationality varchar(30)
as
update dbo.Author
set name=@name, lastName=@lastName, nationality=@nationality
where id=@id
GO
/****** Object:  StoredProcedure [dbo].[updateEditorial]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[updateEditorial]
@id int,
@name varchar(30),
@country varchar(30),
@city varchar(30)
as
update dbo.Editorial
set name=@name, country=@country, city=@city
where id=@id
GO
/****** Object:  StoredProcedure [dbo].[updateCustomer]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[updateCustomer]
@identificationCard varchar(10),
@name varchar(30),
@lastName varchar(30),
@phone varchar(30),
@celphone varchar(30),
@addres varchar(30),
@mail varchar(30)
as
update dbo.Customer
set name=@name, lastName=@lastName, phone=@phone, celphone=@celphone, addres=@addres, mail=@mail
where identificationCard=@identificationCard
GO
/****** Object:  StoredProcedure [dbo].[searchAuthor]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[searchAuthor]
@name varchar(30),
@lastName varchar(30)
as
select id
from Author
where name like @name and
		lastName like @lastName
GO
/****** Object:  StoredProcedure [dbo].[SearchEditorial]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SearchEditorial]
	@name varchar(30)
	as
		select name from dbo.Editorial
		where editorial.name like @name
GO
/****** Object:  StoredProcedure [dbo].[ListCategoryforid]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ListCategoryforid]
@id int
as
	select id,name,descriptionC
	from  dbo.Category where id = @id
GO
/****** Object:  StoredProcedure [dbo].[ListCategory]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ListCategory]
as
select id,name,descriptionC
from category
GO
/****** Object:  StoredProcedure [dbo].[listAuthor]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[listAuthor]		
as
select name, lastname from author
GO
/****** Object:  StoredProcedure [dbo].[insertEditorial]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[insertEditorial]		
@name varchar(30),
@country varchar(30),
@city varchar(30)
as
insert dbo.Editorial
values(@name,@country,@city)
GO
/****** Object:  StoredProcedure [dbo].[RegisterCustomer]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[RegisterCustomer]
@identificationCard varchar(10),
@name varchar(30),
@lastName varchar(30),
@phone varchar(10),
@celphone varchar(10),
@addres varchar(30),
@mail varchar(30)
as
insert dbo.Customer(identificationCard,name,lastName,phone,celphone,addres,mail) 
values(@identificationCard,@name,@lastName,@phone,@celphone,@addres,@mail)
GO
/****** Object:  StoredProcedure [dbo].[loginAdministrator]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[loginAdministrator]
	@name varchar(30),
	@passwordA varchar(256)
	
	as	
		select name,passwordA from Administrator 
		where  name= @name and 
				passwordA=@passwordA
GO
/****** Object:  StoredProcedure [dbo].[insertAuthor]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[insertAuthor]		
@name varchar(30),
@lastName varchar(30),
@nationality varchar(30)
as
insert dbo.Author
values(@name,@lastName,@nationality)
GO
/****** Object:  StoredProcedure [dbo].[IdAuthor]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[IdAuthor]
@name varchar(30),
@lastName varchar(30)
as
select dbo.Author.id,name,lastName,nationality from dbo.Author
where   lastName like @lastName and
		name like @name
GO
/****** Object:  StoredProcedure [dbo].[existEditorial]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[existEditorial]
@name varchar(30)
as
select id,name,country,city
from dbo.Editorial
where name like @name
GO
/****** Object:  StoredProcedure [dbo].[existCustomer]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[existCustomer]
@identificationCard varchar(10)
as
select *
from dbo.Customer
where identificationCard like @identificationCard
GO
/****** Object:  Table [dbo].[FineCustomer]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FineCustomer](
	[identificationCard] [varchar](10) NOT NULL,
	[id] [int] NOT NULL,
	[dateF] [date] NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[checkEditorialId]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[checkEditorialId]
@id int
as 
select name,country,city
from dbo.Editorial
where id=@id
GO
/****** Object:  StoredProcedure [dbo].[existAuthor]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[existAuthor]
@name varchar(30),
@lastName varchar(30)
as
select id,name,lastName,nationality
from dbo.Author
where name like @name and
		lastName like @lastName
GO
/****** Object:  StoredProcedure [dbo].[EditorialList]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EditorialList]
as
select id, name, country, city from dbo.Editorial
GO
/****** Object:  Table [dbo].[Book]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Book](
	[code] [varchar](10) NOT NULL,
	[isbn] [varchar](15) NOT NULL,
	[name] [varchar](30) NULL,
	[datePublish] [date] NULL,
	[idEdit] [int] NOT NULL,
	[idCateg] [int] NOT NULL,
	[stateB] [varchar](30) NOT NULL,
	[stock] [int] NOT NULL,
	[idAdmin] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[isbn] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[AuthorList]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AuthorList]
as
select id,name,lastName,nationality
from dbo.Author
GO
/****** Object:  StoredProcedure [dbo].[deleteAuthor]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[deleteAuthor]
@id int
as
delete dbo.Author
where id=@id
GO
/****** Object:  StoredProcedure [dbo].[CustomerSearch]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[CustomerSearch]
@identificationCard varchar(10)
as
select *
from dbo.Customer
where identificationCard = @identificationCard
GO
/****** Object:  StoredProcedure [dbo].[CustomerReport]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[CustomerReport]
as
select identificationCard as Cedula, name as Nombre, lastName as Apellido, 
phone as Telefono, celphone as Celular, addres as Direccion, mail as Email
from dbo.Customer
GO
/****** Object:  StoredProcedure [dbo].[deleteEditorial]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[deleteEditorial]
@id int
as
delete dbo.Editorial
where id=@id
GO
/****** Object:  StoredProcedure [dbo].[deleteCustomer]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[deleteCustomer]
@identificationCard varchar(10)
as
delete dbo.Customer
where identificationCard=@identificationCard
GO
/****** Object:  StoredProcedure [dbo].[CodeBook]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[CodeBook]
@code varchar(20)
as
select code,isbn,name,Convert(varchar(20),datePublish),idEdit,idCateg,stateB,stock
from dbo.Book
where   Book.code like @code
GO
/****** Object:  StoredProcedure [dbo].[EditorialBook]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EditorialBook]
@id int
as
select Editorial.id,Editorial.name,Editorial.country, Editorial.city  from dbo.Book,dbo.Editorial
where Book.idEdit=Editorial.id and
		Editorial.id=@id
GO
/****** Object:  StoredProcedure [dbo].[existBook]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[existBook]
@name varchar(30)
as
select *
from book
where name like @name
GO
/****** Object:  Table [dbo].[Loan]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Loan](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[dateLoan] [date] NOT NULL,
	[dateLimit] [date] NULL,
	[identificationCard] [varchar](10) NOT NULL,
	[code] [varchar](10) NOT NULL,
	[stateL] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[insertBook]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertBook]		
@code varchar(10),
@isbn varchar(15),
@name varchar(30),
@datePublish varchar(30),
@idedit int,
@idcateg int,
@stateB varchar(30),
@stock int,
@idAdmin int
as
insert book
values(@code,@isbn,@name,Convert(date,@datePublish),@idedit,@idcateg,@stateB,@stock,@idAdmin)
GO
/****** Object:  StoredProcedure [dbo].[listBook]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[listBook]
as
select code, isbn,name,datePublish=Convert(varchar(30),datePublish),idEdit,idCateg,stateB,stock,idAdmin
from dbo.Book
GO
/****** Object:  Table [dbo].[Write]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Write](
	[id] [int] NOT NULL,
	[code] [varchar](10) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[UpdateStockBook]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UpdateStockBook]
@code varchar(10),
@stock int
as
update dbo.Book
 set stock=@stock, stateB= 'Disponible'
 where code=@code and @stock>0
GO
/****** Object:  StoredProcedure [dbo].[SearchBook]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SearchBook]
@code varchar(20)
as
select code,isbn,name,Convert(varchar(20),datePublish) as datePublish,idCateg,stateB,stock
from dbo.Book
where   Book.code like @code
GO
/****** Object:  StoredProcedure [dbo].[SearchEditOfBook]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SearchEditOfBook]
@code varchar(20)
as
select idEdit
from dbo.Book,dbo.Editorial
where   Book.code like @code
GO
/****** Object:  StoredProcedure [dbo].[updateBook]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[updateBook]
@code varchar(10),
@isbn varchar(15),
@name varchar(30),
@datePublish varchar(30),
@idEdit int, 
@idCateg int,
@stateB varchar(30),
@stock int
as
update dbo.Book 
set isbn=@isbn,name=@name,datePublish=Convert(date,@datePublish),idEdit=@idEdit,idCateg=@idCateg,stateB=@stateB,stock=@stock
where code=@code
GO
/****** Object:  StoredProcedure [dbo].[searchLoan]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[searchLoan]
@id int
as
select id, stateL
from loan
where id= @id
GO
/****** Object:  StoredProcedure [dbo].[SearchBookForCode]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SearchBookForCode]
@code varchar(30)
as
select id,Book.code,isbn,name,Convert(varchar(30),datePublish) as datePublish,idEdit,idCateg,stateB,stock,idAdmin
from dbo.Book,dbo.Write
where Book.code=Write.code and
		Book.code=@code
GO
/****** Object:  StoredProcedure [dbo].[SearchAuthorOfBook]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SearchAuthorOfBook]
@code varchar(20)
as
select id
from dbo.Write
where Write.code like @code
GO
/****** Object:  StoredProcedure [dbo].[ReturnBook]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ReturnBook] 
@id int
as
select Loan.id,Customer.identificationCard,Customer.name,Customer.lastName,Book.name as nameBook,Book.code
from Loan,Customer,Book
where book.code=Loan.code and 
		customer.identificationCard=Loan.IdentificationCard and
		Loan.id=@id
GO
/****** Object:  StoredProcedure [dbo].[reportLoan]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[reportLoan]
@identificationCard varchar(10)
as
select C.name,C.lastName,C.identificationCard,L.id,dateLoan,dateLimit,B.code,B.name
from Customer C inner join Loan L on C.identificationCard=L.identificationCard
	 inner join dbo.Book B on B.code = L.code 
	 where C.identificationCard=@identificationCard
GO
/****** Object:  StoredProcedure [dbo].[registerLoan]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[registerLoan]
@dateLoan varchar(30),
@dateLimit varchar(30),
@identificationCard varchar(10),
@code varchar (10)
as
insert into dbo.Loan(dateLoan,dateLimit,identificationCard,code) 
values(convert(date,@dateLoan),convert(date,@dateLimit),@identificationCard,@code)
GO
/****** Object:  StoredProcedure [dbo].[UpdateStateLoan]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UpdateStateLoan]
@id int
as
update dbo.Loan
 set stateL='Finalizado'
 where id=@id
GO
/****** Object:  StoredProcedure [dbo].[listAuthorWithBook]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[listAuthorWithBook]
@code varchar(10)
as 
select id
from dbo.Write
where code=@code
GO
/****** Object:  StoredProcedure [dbo].[InsertWrite]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertWrite]
@id int,
@code varchar(10)	
as
insert dbo.write(id,code) values(@id,@code)
GO
/****** Object:  StoredProcedure [dbo].[ForNameEditorial]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ForNameEditorial]
	@name varchar(30)
	as
		select book.code,book.name as NameBook,stateB,stock,dbo.Author.name as nameAuth,lastName,dbo.Editorial.name as nameEdit from dbo.Author,dbo.Book,dbo.Write,dbo.Editorial
		where   book.idedit= dbo.Editorial.id and Author.id=Write.id and Book.code=Write.code and
				editorial.name like @name
GO
/****** Object:  StoredProcedure [dbo].[ForNameBook]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ForNameBook]
@name varchar(30)
as
select book.code,book.name as NameBook,stateB,stock,dbo.Author.name as nameAuth,lastName,dbo.Editorial.name as nameEdit from dbo.Author,dbo.Book,dbo.Write,dbo.Editorial
where   book.idedit= dbo.Editorial.id and Author.id=Write.id and Book.code=Write.code and
		Book.name like @name
GO
/****** Object:  StoredProcedure [dbo].[ForNameAuthor]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ForNameAuthor]
@name varchar(30)
as
select book.code,book.name as NameBook,stateB,stock,dbo.Author.name as nameAuth,lastName,dbo.Editorial.name as nameEdit from dbo.Author,dbo.Book,dbo.Write,dbo.Editorial
where   book.idedit= dbo.Editorial.id and Author.id=Write.id and Book.code=Write.code and
		Author.name like @name
GO
/****** Object:  StoredProcedure [dbo].[ForLastNameAuthor]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ForLastNameAuthor]
@lastName varchar(30)
as
select book.code,book.name as NameBook,stateB,stock,dbo.Author.name as nameAuth,lastName,dbo.Editorial.name as nameEdit from dbo.Author,dbo.Book,dbo.Write,dbo.Editorial
where   book.idedit= dbo.Editorial.id and Author.id=Write.id and Book.code=Write.code and
		Author.lastName like @lastName
GO
/****** Object:  StoredProcedure [dbo].[ForIsbnBook]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ForIsbnBook]
@isbn varchar(20)
as
select book.code,book.name as NameBook,stateB,stock,dbo.Author.name as nameAuth,lastName,dbo.Editorial.name as nameEdit from dbo.Author,dbo.Book,dbo.Write,dbo.Editorial
where   book.idedit= dbo.Editorial.id and Author.id=Write.id and Book.code=Write.code and
		Book.isbn like @isbn
GO
/****** Object:  StoredProcedure [dbo].[ForCodeBook]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ForCodeBook]
@code varchar(20)
as
select book.code,book.name as NameBook,stateB,stock,dbo.Author.name as nameAuth,lastName,dbo.Editorial.name as nameEdit from dbo.Author,dbo.Book,dbo.Write,dbo.Editorial
where   book.idedit= dbo.Editorial.id and Author.id=Write.id and Book.code=Write.code and
		Book.code like @code
GO
/****** Object:  StoredProcedure [dbo].[ForCategoryBook]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ForCategoryBook]
@name varchar(30)
as
select book.code,book.name as NameBook,stateB,stock,dbo.Author.name as nameAuth,lastName,dbo.Editorial.name as nameEdit from dbo.Author,dbo.Book,dbo.Write,dbo.Editorial,dbo.Category
where   book.idedit= dbo.Editorial.id and Author.id=Write.id and Book.code=Write.code and
		Category.Id=Book.idCateg and
		Category.name like @name
GO
/****** Object:  StoredProcedure [dbo].[ForAuthorCompleteName]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ForAuthorCompleteName]
@name varchar(30),
@lastName varchar(30)
as
select book.code,book.name as NameBook,stateB,stock,dbo.Author.name as nameAuth,lastName,dbo.Editorial.name as nameEdit from dbo.Author,dbo.Book,dbo.Write,dbo.Editorial
where   book.idedit= dbo.Editorial.id and Author.id=Write.id and Book.code=Write.code and
		Author.lastName like @lastName and
		Author.name like @name
GO
/****** Object:  StoredProcedure [dbo].[DeleteWrite]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[DeleteWrite]
@id int,
@code varchar(10)
as
delete dbo.Write
where id=@id and
		code like @code
GO
/****** Object:  StoredProcedure [dbo].[deleteBook]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[deleteBook]
@code varchar(10)
as
delete dbo.Write
where code=@code
delete dbo.Book 
where code=@code
GO
/****** Object:  StoredProcedure [dbo].[BookReport]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[BookReport]
as
select Book.code as Codigo, Book.isbn as ISBN, Book.name as Titulo, Convert(varchar(20),Book.datePublish) as FechaPublicacion, 
Editorial.name as Editorial, Author.name as Nombre, Author.lastName as Apellido, Category.name as Categoria, 
Book.stateB as Estado, Book.stock as Stock
from dbo.Book, dbo.Editorial, dbo.Author, dbo.Write, dbo.Category
where Book.idEdit = Editorial.id and Author.id = Write.id and Book.code = Write.code and Book.idCateg = Category.id
GO
/****** Object:  StoredProcedure [dbo].[AuthorforId]    Script Date: 08/11/2017 23:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AuthorforId]
@id int
as
select name,lastName,nationality
from dbo.Author
where id=@id
exec listAuthorWithBook
GO
/****** Object:  ForeignKey [FK__FineCusto__ident__24927208]    Script Date: 08/11/2017 23:48:09 ******/
ALTER TABLE [dbo].[FineCustomer]  WITH CHECK ADD FOREIGN KEY([identificationCard])
REFERENCES [dbo].[Customer] ([identificationCard])
GO
/****** Object:  ForeignKey [FK__FineCustomer__id__25869641]    Script Date: 08/11/2017 23:48:09 ******/
ALTER TABLE [dbo].[FineCustomer]  WITH CHECK ADD FOREIGN KEY([id])
REFERENCES [dbo].[Fine] ([id])
GO
/****** Object:  ForeignKey [FK__Book__idAdmin__2BFE89A6]    Script Date: 08/11/2017 23:48:09 ******/
ALTER TABLE [dbo].[Book]  WITH CHECK ADD FOREIGN KEY([idAdmin])
REFERENCES [dbo].[Administrator] ([id])
GO
/****** Object:  ForeignKey [FK__Book__idCateg__2B0A656D]    Script Date: 08/11/2017 23:48:09 ******/
ALTER TABLE [dbo].[Book]  WITH CHECK ADD FOREIGN KEY([idCateg])
REFERENCES [dbo].[Category] ([id])
GO
/****** Object:  ForeignKey [FK__Book__idEdit__2A164134]    Script Date: 08/11/2017 23:48:09 ******/
ALTER TABLE [dbo].[Book]  WITH CHECK ADD FOREIGN KEY([idEdit])
REFERENCES [dbo].[Editorial] ([id])
GO
/****** Object:  ForeignKey [FK__Loan__code__31B762FC]    Script Date: 08/11/2017 23:48:09 ******/
ALTER TABLE [dbo].[Loan]  WITH CHECK ADD FOREIGN KEY([code])
REFERENCES [dbo].[Book] ([code])
GO
/****** Object:  ForeignKey [FK__Loan__identifica__30C33EC3]    Script Date: 08/11/2017 23:48:09 ******/
ALTER TABLE [dbo].[Loan]  WITH CHECK ADD FOREIGN KEY([identificationCard])
REFERENCES [dbo].[Customer] ([identificationCard])
GO
/****** Object:  ForeignKey [FK__Write__code__3493CFA7]    Script Date: 08/11/2017 23:48:09 ******/
ALTER TABLE [dbo].[Write]  WITH CHECK ADD FOREIGN KEY([code])
REFERENCES [dbo].[Book] ([code])
GO
/****** Object:  ForeignKey [FK__Write__id__339FAB6E]    Script Date: 08/11/2017 23:48:09 ******/
ALTER TABLE [dbo].[Write]  WITH CHECK ADD FOREIGN KEY([id])
REFERENCES [dbo].[Author] ([id])
GO
