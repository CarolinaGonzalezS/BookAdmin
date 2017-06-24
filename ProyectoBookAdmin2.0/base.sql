create database BDDLibrary
use BDDLibrary

create table Administrator
(
id int primary key not null,
name varchar(30) not null,
passwordA varchar(10) not null
)

create table Category
(
id int identity(1,1) primary key not null,
name varchar(30) not null,
descriptionC varchar(100) not null
)

create table Editorial
(
id int identity(1,1) primary key not null,
name varchar(30) not null,
country varchar(30) null,
city varchar(30) null
)

create table Author
(
id int identity(1,1) primary key not null,
name varchar(30) not null,
lastName varchar(30)null,
nationality varchar(30) null 
)

create table Book
(
code varchar(10) primary key not null,
isbn varchar(15) not null,
name varchar(30)null,
datePublish date null,
idEdit int foreign key references Editorial(id)not null,
idCateg int foreign key references Category(id)not null,
stateB varchar(30) not null,
stock int not null,
idAdmin int foreign key references Administrator(id)
)

create table Write
(
id int foreign key references Author(id)not null,
code varchar(10) foreign key references Book(code)not null
)

create table Customer
(
identificationCard varchar(10)primary key not null,
name varchar(30)not null,
lastName varchar(30)not null,
phone varchar(10)not null,
celphone varchar(10)not null,
addres varchar(30) not null,
mail varchar(30)not null
)

create table Loan
(
id int identity(1,1) primary key not null,
dateLoan date not null,
dateLimit date null,
identificationCard varchar(10) foreign key references Customer(identificationCard)not null,
code varchar(10) foreign key references book(code) not null
)

create table Fine
(
id int identity(1,1) primary key not null,
value money not null,
descriptionF varchar(50) not null
)

create table FineCustomer
(
identificationCard varchar(10) foreign key references Customer(identificationCard)not null,
id int foreign key references Fine(ID)not null,
dateF date not null
)

--procedimientos 

create procedure loginAdministrator
	@name varchar(30),
	@passwordA varchar(10)
	
	as	
		select * from Administrator 
		where  name= @name and 
				passwordA=@passwordA
		 
 Insert dbo.Administrator
 values(1,'Admin','123')
 
create procedure existAuthor
@name varchar(30),
@lastName varchar(30)
as
select id,name,lastName,nationality
from dbo.Author
where name like @name and
		lastName like @lastName
		

create procedure insertAuthor		
@name varchar(30),
@lastName varchar(30),
@nationality varchar(30)
as
insert dbo.Author
values(@name,@lastName,@nationality)

--Insercion de categorias
insert dbo.Category
values('suspenso','Los libros mas famosos de suspenso')
insert dbo.Category
values('misterio','Los libros mas famosos de misterio')
insert dbo.Category
values('Biografias','Las biografias mas famosos')
insert dbo.Category
values('Terror','Los libros mas famosos de terror')
insert dbo.Category
values('Ciencia','Los libros mas famosos de ciencia')

--
create procedure existEditorial
@name varchar(30)
as
select id,name,country,city
from dbo.Editorial
where name like @name 

create procedure insertEditorial		
@name varchar(30),
@country varchar(30),
@city varchar(30)
as
insert dbo.Editorial
values(@name,@country,@city)

create procedure existBook
@name varchar(30)
as
select *
from book
where name like @name 

alter procedure insertBook		
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

--procedimiento de despliege de categoria
create procedure ListCategory
as
select id,name,descriptionC
from category


CREATE procedure ListCategoryforid
@id int
as
	select id,name,descriptionC
	from  dbo.Category where id = @id
	
create procedure InsertWrite
@id int,
@code varchar(10)	
as
insert dbo.write(id,code) values(@id,@code)

create procedure ForNameAuthor
@name varchar(30)
as
select book.name as NameBook,stateB,stock,dbo.Author.name as nameAuth,lastName,dbo.Editorial.name as nameEdit from dbo.Author,dbo.Book,dbo.Write,dbo.Editorial
where   book.idedit= dbo.Editorial.id and Author.id=Write.id and Book.code=Write.code and
		Author.name like @name 
--prueba		
exec ForNameAuthor '%Gabriel%'

create procedure ForLastNameAuthor
@lastName varchar(30)
as
select book.name as NameBook,stateB,stock,dbo.Author.name as nameAuth,lastName,dbo.Editorial.name as nameEdit from dbo.Author,dbo.Book,dbo.Write,dbo.Editorial
where   book.idedit= dbo.Editorial.id and Author.id=Write.id and Book.code=Write.code and
		Author.lastName like @lastName 
		
exec ForLastNameAuthor '%Garcia%'		

create procedure ForAuthorCompleteName
@name varchar(30),
@lastName varchar(30)
as
select book.name as NameBook,stateB,stock,dbo.Author.name as nameAuth,lastName,dbo.Editorial.name as nameEdit from dbo.Author,dbo.Book,dbo.Write,dbo.Editorial
where   book.idedit= dbo.Editorial.id and Author.id=Write.id and Book.code=Write.code and
		Author.lastName like @lastName and
		Author.name like @name 
		

exec ForAuthorCompleteName '%Gabriel%','%Garcia%'


create procedure ForNameEditorial
@name varchar(30)
as
select book.name as NameBook,stateB,stock,dbo.Author.name as nameAuth,lastName,dbo.Editorial.name as nameEdit from dbo.Author,dbo.Book,dbo.Write,dbo.Editorial
where   book.idedit= dbo.Editorial.id and Author.id=Write.id and Book.code=Write.code and
		editorial.name like @name  
	
create procedure ForNameBook
@name varchar(30)
as
select book.name as NameBook,stateB,stock,dbo.Author.name as nameAuth,lastName,dbo.Editorial.name as nameEdit from dbo.Author,dbo.Book,dbo.Write,dbo.Editorial
where   book.idedit= dbo.Editorial.id and Author.id=Write.id and Book.code=Write.code and
		Book.name like @name  
	
	

create procedure ForIsbnBook
@isbn varchar(20)
as
select book.name as NameBook,stateB,stock,dbo.Author.name as nameAuth,lastName,dbo.Editorial.name as nameEdit from dbo.Author,dbo.Book,dbo.Write,dbo.Editorial
where   book.idedit= dbo.Editorial.id and Author.id=Write.id and Book.code=Write.code and
		Book.isbn like @isbn  
	
create procedure ForCodeBook
@code varchar(20)
as
select book.name as NameBook,stateB,stock,dbo.Author.name as nameAuth,lastName,dbo.Editorial.name as nameEdit from dbo.Author,dbo.Book,dbo.Write,dbo.Editorial
where   book.idedit= dbo.Editorial.id and Author.id=Write.id and Book.code=Write.code and
		Book.code like @code  


--estasdfsd	
select *
from book