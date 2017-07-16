create database BDDLibrary
use BDDLibrary

create table Administrator
(
id int primary key not null,
name varchar(30) not null,
passwordA varchar(256) not null
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

alter procedure loginAdministrator
	@name varchar(30),
	@passwordA varchar(256)
	
	as	
		select name,passwordA from Administrator 
		where  name= @name and 
				passwordA=@passwordA
				
				select * from book
		 
 Insert dbo.Administrator
 values(1,'Admin','a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')
 
select * from administrator
 
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
values('Suspenso','Los libros mas famosos de suspenso')
insert dbo.Category
values('Misterio','Los libros mas famosos de misterio')
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

create procedure insertBook		
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

create procedure ForCategoryBook
@name varchar(30)
as
select book.name as NameBook,stateB,stock,dbo.Author.name as nameAuth,lastName,dbo.Editorial.name as nameEdit from dbo.Author,dbo.Book,dbo.Write,dbo.Editorial,dbo.Category
where   book.idedit= dbo.Editorial.id and Author.id=Write.id and Book.code=Write.code and
		Category.Id=Book.idCateg and
		Category.name like @name  

exec ForCategoryBook 'Suspenso'
--estasdfsd	

create procedure RegisterCustomer
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

create procedure existCustomer
@identificationCard varchar(10)
as
select *
from dbo.Customer
where identificationCard like @identificationCard

select * from write
select * from category
exec ForNameBook '%100%'

create procedure AuthorList
as
select id,name,lastName,nationality
from dbo.Author

create procedure IdAuthor
@name varchar(30),
@lastName varchar(30)
as
select dbo.Author.id,name,lastName,nationality from dbo.Author
where   lastName like @lastName and
		name like @name 
		
create procedure EditorialList
as
select id, name, country, city from dbo.Editorial

exec EditorialList


create procedure registerLoan
@dateLoan varchar(30),
@dateLimit varchar(30),
@identificationCard varchar(10),
@code varchar (10)
as
insert into dbo.Loan(dateLoan,dateLimit,identificationCard,code) 
values(convert(date,@dateLoan),convert(date,@dateLimit),@identificationCard,@code)

-- Actualizaciones de Tabla
create procedure updateBook
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

select *
from book

select *
from write
create procedure updateEditorial
@id int,
@name varchar(30),
@country varchar(30),
@city varchar(30)
as
update dbo.Editorial
set name=@name, country=@country, city=@city
where id=@id

create procedure updateAuthor
@id int,
@name varchar(30),
@lastName varchar(30),
@nationality varchar(30)
as
update dbo.Author
set name=@name, lastName=@lastName, nationality=@nationality
where id=@id

create procedure updateCustomer
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

-- Eliminacion de Contenido de Tabla
create procedure deleteBook
@code varchar(10)
as
delete dbo.Write
where code=@code
delete dbo.Book 
where code=@code

exec deleteBook 'dfsg'

create procedure deleteAuthor
@id int
as
delete dbo.Author
where id=@id

create procedure deleteCustomer
@identificationCard varchar(10)
as
delete dbo.Customer
where identificationCard=@identificationCard 

create procedure deleteEditorial
@id int
as
delete dbo.Editorial
where id=@id 

create procedure listBook
as
select code, isbn,name,datePublish=Convert(varchar(30),datePublish),idEdit,idCateg,stateB,stock,idAdmin
from dbo.Book

create procedure listAuthorWithBook
@code varchar(10)
as 
select id
from dbo.Write
where code=@code

create procedure AuthorforId
@id int
as
select name,lastName,nationality
from dbo.Author
where id=@id
exec listAuthorWithBook


create procedure checkEditorialId
@id int
as 
select name,country,city
from dbo.Editorial
where id=@id

create procedure SearchBookForCode
@code varchar(30)
as
select id,Book.code,isbn,name,Convert(varchar(30),datePublish) as datePublish,idEdit,idCateg,stateB,stock,idAdmin
from dbo.Book,dbo.Write
where Book.code=Write.code and
		Book.code=@code

exec SearchBookForCode 'sfgd'


-- Devolver libro
alter procedure ReturnBook 
@id int
as
select Customer.identificationCard,Customer.name,Customer.lastName,Book.name,Book.isbn
from Loan,Customer,Book
where book.code=Loan.code and customer.identificationCard=Loan.IdentificationCard and

	Loan.id=@id

exec ReturnBook 2
	
select * from book
select * from customer
select * from loan
select * from fine
insert into dbo.Loan values('12/12/2015','01/02/2017','0000000001','333')		
exec 
		
