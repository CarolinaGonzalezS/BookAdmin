create database BDDLibrary
use BDDLibrary

-- Creacion de Tablas

-- Administrador
create table Administrator(
id int primary key not null,
name varchar(30) not null,
passwordA varchar(256) not null
)

-- Categoria
create table Category(
id int identity(1,1) primary key not null,
name varchar(30) unique not null,
descriptionC varchar(100) not null
)

-- Editorial
create table Editorial(
id int identity(1,1) primary key not null,
name varchar(30) unique not null,
country varchar(30) null,
city varchar(30) null
)

-- Autor
create table Author(
id int identity(1,1) primary key not null,
name varchar(30) not null,
lastName varchar(30)null,
nationality varchar(30) null 
)

-- Libro
create table Book(
code varchar(10) primary key not null,
isbn varchar(15) unique not null,
name varchar(30) unique null,
datePublish date null,
idEdit int foreign key references Editorial(id)not null,
idCateg int foreign key references Category(id)not null,
stateB varchar(30) not null,
stock int not null,
idAdmin int foreign key references Administrator(id)
)

-- Escribe (Rompe relacion n-n de Libro y Autor)
create table Write(
id int foreign key references Author(id)not null,
code varchar(10) foreign key references Book(code)not null
)

-- Cliente
create table Customer(
identificationCard varchar(10)primary key not null,
name varchar(30)not null,
lastName varchar(30)not null,
phone varchar(10)not null,
celphone varchar(10)not null,
addres varchar(30) not null,
mail varchar(30)not null
)

-- Prestamo
create table Loan(
id int identity(1,1) primary key not null,
dateLoan date not null,
dateLimit date null,
identificationCard varchar(10) foreign key references Customer(identificationCard)not null,
code varchar(10) foreign key references book(code) not null,
stateL varchar(20) not null
)

-- Multa
create table Fine(
id int identity(1,1) primary key not null,
value money not null,
descriptionF varchar(50) not null
)

-- Multa-Cliente (Rompe relacion n-n de Multa y Cliente)
create table FineCustomer(
identificationCard varchar(10) foreign key references Customer(identificationCard)not null,
id int foreign key references Fine(ID)not null,
dateF date not null
)

-- Creacion de Procedimientos Almacenados

-- Procedimientos de Administrador
-- Insercion de Administrador
insert into dbo.Administrator
values
(1,'Admin','a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')

-- Seleccion de Verificacion  
select * from dbo.Administrator

-- Verifica el Login
create procedure loginAdministrator
	@name varchar(30),
	@passwordA varchar(256)
	as	
		select name,passwordA from Administrator 
		where  name= @name and passwordA=@passwordA
		
-- Ejecucion de Verificacion
exec loginAdministrator 'Admin','a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3'				 

-- Procedimientos de Autor
-- Inserta Autores
create procedure insertAuthor		
	@name varchar(30),
	@lastName varchar(30),
	@nationality varchar(30)
	as
		insert into dbo.Author
		values
		(@name,@lastName,@nationality)

-- Ejecucion de Verificacion
exec insertAuthor 'STEPHEN', 'KING', 'ESTADOUNIDENSE'
exec insertAuthor 'ABRAHAM', 'MERRITT', 'ESTADOUNIDENSE'
exec insertAuthor 'EDGAR ALLAN', 'POE', 'ESTADOUNIDENSE'
exec insertAuthor 'DAN', 'BROWN', 'ESTADOUNIDENSE'
exec insertAuthor 'ADOLFO', 'BIOY', 'ARGENTINO'
exec insertAuthor 'FRANZ', 'KAFKA', 'JUDIO'
exec insertAuthor 'MICHIO', 'KAKU', 'ESTADOUNIDENSE'
exec insertAuthor 'STEPHEN', 'HAWKING', 'BRITANICO'

-- Verifica la existencia del Autor 
create procedure existAuthor
	@name varchar(30),
	@lastName varchar(30)
	as
		select id,name,lastName,nationality
		from dbo.Author
		where name like @name and lastName like @lastName

-- Ejecucion de Verificacion 
exec existAuthor 'STEPHEN', 'KING'

-- Insercion de categorias
insert into dbo.Category
values
('Suspenso','Los libros mas famosos de suspenso'),
('Misterio','Los libros mas famosos de misterio'),
('Biografias','Las biografias mas famosos'),
('Terror','Los libros mas famosos de terror'),
('Ciencia','Los libros mas famosos de ciencia')

-- Seleccion de Verificacion 
select * from dbo.Category

-- Procedimientos de Editorial
-- Inserta Editoriales
create procedure insertEditorial		
	@name varchar(30),
	@country varchar(30),
	@city varchar(30)
	as
		insert dbo.Editorial
		values(@name,@country,@city)

-- Ejecucion de Verificacion
exec insertEditorial 'DOUBLEDAY', 'ESTADOS UNIDOS', 'NEW YORK'
exec insertEditorial 'ANAYA', 'ESPAÑA', 'SALAMANCA'
exec insertEditorial 'DEBOLSILLO', 'ESTADOS UNIDOS', 'NEW YORK'
exec insertEditorial 'CASA DEL LIBRO', 'ESPAÑA', 'BARCELONA'
exec insertEditorial 'UMBRIEL EDITORES', 'ESPAÑA', 'BARCELONA'

-- Verifica la existencia de la Editorial
create procedure existEditorial
	@name varchar(30)
	as
		select id,name,country,city
		from dbo.Editorial
		where name like @name 

-- Ejecucion de Verificacion
exec existEditorial 'DOUBLEDAY' 

-- Procedimientos de Libro
-- Inserta Libros
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
		insert into book
		values(@code,@isbn,@name,Convert(date,@datePublish),@idedit,@idcateg,@stateB,@stock,@idAdmin)

-- Ejecucion de Verificacion 
exec insertBook 1001, 9788497931021, 'EL MISTERIO DE SALEMS LOT', '1975-10-17', 1, 1, 'Disponible', 2, 1
exec insertBook 2001, 9788420757643, 'ARDE BRUJA ARDE', '1994-06-23', 2, 1, 'Disponible', 2, 1
exec insertBook 3001, 9780816156856, 'EL RESPLANDOR', '1977-05-20', 3, 2, 'Disponible', 3, 1
exec insertBook 4001, 9788435010375, 'CUENTOS COMPLETOS', '1831-09-17', 2, 2, 'Disponible', 1, 1
exec insertBook 5001, 9788495618771, 'ANGELES Y DEMONIOS', '2000-03-23', 3, 4, 'Disponible', 1, 1
exec insertBook 6001, 9781417580538, 'CARRIE', '1974-04-05', 1, 4, 'Disponible', 1, 1
exec insertBook 7001, 9788423338733, 'BORGES', '2006-05-11', 5, 3,	'Disponible', 1, 1
exec insertBook 8001, 9781847490254, 'CARTA AL PADRE', '1919-11-01', 2, 3,	'Disponible', 2, 1
exec insertBook 9001, 9788499923925, 'EL FUTURO DE NUESTRA MENTE', '2014-06-13', 4, 5,	'Disponible', 2, 1
exec insertBook 10001, 9788498926606, 'BREVE HISTORIA DE MI VIDA', '1999-02-04', 5, 5,	'Disponible', 1, 1

-- Verifica la existencia del Libro
create procedure existBook
	@name varchar(30)
	as
		select *
		from book
		where name like @name 

-- Ejecucion de Verificacion 
exec existBook 'ARDE BRUJA ARDE'

-- Procedimientos de Categoria
-- Despliega las categorias existentes
create procedure ListCategory
	as
		select id,name,descriptionC
		from dbo.Category

-- Ejecucion de Verificacion
exec ListCategory

-- Despliega las categorias por id
create procedure ListCategoryforid
	@id int
	as
		select id,name,descriptionC
		from  dbo.Category where id = @id

-- Ejecucion de Verificacion 
exec ListCategoryforid 1

-- Procedimientos de Escribe
-- Inserta la relacion entre Libro y Autor	
create procedure InsertWrite
	@id int,
	@code varchar(10)	
	as
		insert dbo.write(id,code) values(@id,@code)

-- Ejecucion de Verificacion
exec InsertWrite 1,1001
exec InsertWrite 2,2001
exec InsertWrite 1,3001
exec InsertWrite 3,4001
exec InsertWrite 4,5001
exec InsertWrite 1,6001
exec InsertWrite 5,7001
exec InsertWrite 6,8001
exec InsertWrite 7,9001
exec InsertWrite 8,10001

-- Procedimientos de Busqueda
-- Busca al Autor por su Nombre
create procedure ForNameAuthor
	@name varchar(30)
	as
		select book.name as NameBook,stateB,stock,dbo.Author.name as nameAuth,lastName,dbo.Editorial.name as nameEdit from dbo.Author,dbo.Book,dbo.Write,dbo.Editorial
		where   book.idedit= dbo.Editorial.id and Author.id=Write.id and Book.code=Write.code and
				Author.name like @name 

-- Ejecucion de Verificacion		
exec ForNameAuthor '%STEPHEN%'

-- Busca al Autor por su Apellido
create procedure ForLastNameAuthor
	@lastName varchar(30)
	as
		select book.name as NameBook,stateB,stock,dbo.Author.name as nameAuth,lastName,dbo.Editorial.name as nameEdit from dbo.Author,dbo.Book,dbo.Write,dbo.Editorial
		where   book.idedit= dbo.Editorial.id and Author.id=Write.id and Book.code=Write.code and
				Author.lastName like @lastName 

-- Ejecucion de Verificacion		
exec ForLastNameAuthor '%POE%'		

-- Busca al Autor por su Nobmre Completo
create procedure ForAuthorCompleteName
	@name varchar(30),
	@lastName varchar(30)
	as
		select book.name as NameBook,stateB,stock,dbo.Author.name as nameAuth,lastName,dbo.Editorial.name as nameEdit from dbo.Author,dbo.Book,dbo.Write,dbo.Editorial
		where   book.idedit= dbo.Editorial.id and Author.id=Write.id and Book.code=Write.code and
				Author.lastName like @lastName and
				Author.name like @name 
		
-- Ejecucion de Verificacion
exec ForAuthorCompleteName '%STEPHEN%','%HAWKING%'

-- Busca a la Editorial por su Nombre
create procedure ForNameEditorial
	@name varchar(30)
	as
		select book.name as NameBook,stateB,stock,dbo.Author.name as nameAuth,lastName,dbo.Editorial.name as nameEdit from dbo.Author,dbo.Book,dbo.Write,dbo.Editorial
		where   book.idedit= dbo.Editorial.id and Author.id=Write.id and Book.code=Write.code and
				editorial.name like @name  

-- Ejecucion de Verificacion
exec ForNameEditorial 'DEBOLSILLO' 

-- Busca al Libro por su Nombre
create procedure ForNameBook
	@name varchar(30)
	as
		select book.code,book.name as NameBook,stateB,stock,lastName,dbo.Editorial.name as nameEdit,dbo.Author.name as nameAuth from dbo.Author,dbo.Book,dbo.Write,dbo.Editorial
		where   book.idedit= dbo.Editorial.id and Author.id=Write.id and Book.code=Write.code and
				Book.name like @name  

-- Ejecucion de Verificacion	
exec ForNameBook 'ARDE BRUJA ARDE'

-- Busca al Libro por su ISBN
create procedure ForIsbnBook
	@isbn varchar(20)
	as
		select book.name as NameBook,stateB,stock,dbo.Author.name as nameAuth,lastName,dbo.Editorial.name as nameEdit from dbo.Author,dbo.Book,dbo.Write,dbo.Editorial
		where   book.idedit= dbo.Editorial.id and Author.id=Write.id and Book.code=Write.code and
				Book.isbn like @isbn  

-- Ejecucion de Verificacion
exec ForIsbnBook '9788497931021'

-- Busca al Libro por su Codigo
create procedure ForCodeBook
	@code varchar(20)
	as
		select book.name as NameBook,stateB,stock,dbo.Author.name as nameAuth,lastName,dbo.Editorial.name as nameEdit from dbo.Author,dbo.Book,dbo.Write,dbo.Editorial
		where   book.idedit= dbo.Editorial.id and Author.id=Write.id and Book.code=Write.code and
				Book.code like @code  

-- Ejecucion de Verificacion 
exec ForCodeBook '2001'

-- Busca al Libro por su Categoria
create procedure ForCategoryBook
@name varchar(30)
as
select book.name as NameBook,stateB,stock,dbo.Author.name as nameAuth,lastName,dbo.Editorial.name as nameEdit from dbo.Author,dbo.Book,dbo.Write,dbo.Editorial,dbo.Category
where   book.idedit= dbo.Editorial.id and Author.id=Write.id and Book.code=Write.code and
		Category.Id=Book.idCateg and
		Category.name like @name  

-- Ejecucion de Verificacion
exec ForCategoryBook 'Biografias'

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
@code varchar (10),
@stateL varchar(20)
as
insert into dbo.Loan(dateLoan,dateLimit,identificationCard,code,stateL) 
values(convert(date,@dateLoan),convert(date,@dateLimit),@identificationCard,@code,@stateL)

-- Actualizaciones de Tabla
create procedure updateBook
@code varchar(10),
@isbn varchar(15),
@name varchar(30),
@datePublish varchar(30),
@idEdit int, 
@idCateg int,
@stateB varchar(30),
@stock int,
as
update dbo.Book 
set isbn=@isbn,name=@name,datePublish=Convert(date,@datePublish),idEdit=@idEdit,idCateg=@idCateg,stateB=@stateB,stock=@stock
where code=@code



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
select Loan.id,Customer.identificationCard,Customer.name,Customer.lastName,Book.name as nameBook,Book.code
from Loan,Customer,Book
where book.code=Loan.code and 
		customer.identificationCard=Loan.IdentificationCard and
		Loan.id=@id
		
exec ReturnBook 1
	
select * from book
select * from customer
select * from loan
select * from fine

insert into dbo.Loan values('12/12/2016','12/01/2017','1723842314','1s34añ','pendiente')		
exec 
		
update dbo.Book
 set stock=12
 where 	code='dgf457657'

CREATE TRIGGER Nonavailable
ON Book
AFTER UPDATE
      AS
BEGIN
SET NOCOUNT ON;
 update dbo.Book
 set stateB='No disponible'
 where stock=0
END	
	
alter procedure DeleteWrite
@id int,
@code varchar(10)
as
delete dbo.Write
where id=@id and
		code like @code

alter procedure UpdateStockBook
@code varchar(10),
@stock int
as
update dbo.Book
 set stock=@stock, stateB= 'Disponible'
 where code=@code and @stock>0
	
create procedure updateStockBook
@stock int,
@code varchar(10)
as
update dbo.Book set stock=@stock
where code=@code

exec updateStockBook 3
		
alter procedure UpdateStateLoan
@id int
as
update dbo.Loan
 set stateL='Finalizado'
 where id=@id
		
create procedure CustomerSearch
@identificationCard varchar(10)
as
select *
from dbo.Customer
where identificationCard = @identificationCard

--procedimientos para el prestamo
alter procedure insertLoan
@dateLoan varchar(10),
@dateLimit varchar(10),
@identificationCard varchar(10),
@code varchar(10),
@stateL varchar(20)
as
insert into dbo.Loan 
values(convert(date,@dateLoan),convert(date,@dateLimit),@identificationCard,@code,@stateL)

create procedure updateStockBook
@stock int,
@code varchar(10)
as
update dbo.Book set stock=@stock
where code=@code

--procedimiento para el reporte del prestamo
alter proc reportLoan
@identificationCard varchar(10)
as
select C.name,C.lastName,C.identificationCard,L.id,dateLoan,dateLimit,stateL,B.code,B.name
from Customer C inner join Loan L on C.identificationCard=L.identificationCard
	 inner join dbo.Book B on B.code = L.code 
	 where C.identificationCard=@identificationCard

exec CodeBook 'asd345'

alter procedure SearchBook
@code varchar(20)
as
select code,isbn,name,Convert(varchar(20),datePublish) as datePublish,idCateg,stateB,stock
from dbo.Book
where   Book.code like @code  

exec SearchBook '1001'

create procedure SearchEditOfBook
@code varchar(20)
as
select idEdit
from dbo.Book,dbo.Editorial
where   Book.code like @code 

create procedure SearchAuthorOfBook
@code varchar(20)
as
select id
from dbo.Write
where Write.code like @code

create procedure searchLoan
@id int
as
select id, stateL
from loan
where id= @id 

exec searchLoan 4

alter procedure updateStateB
@code varchar(10),
@stock int
as
update dbo.Book
 set stock=@stock, stateB= 'No Disponible'
 where code=@code and @stock= 0 
update dbo.Book
 set stock=@stock, stateB= 'Disponible'
 where code=@code and @stock>0 

exec updateStateB 10001,0

select * from loan

insert into loan
values
('2016-12-12', '2017-01-12', '1723434203', '1001', 'En Proceso'),
('2017-07-22', '2017-08-22', '1723434211', '2001', 'Finalizado'),
('2017-07-22', '2017-08-22', '1723434203', '3001', 'En Proceso'),
('2017-07-22', '2017-08-22', '1723434211', '3001', 'En Proceso'),
('2017-07-22', '2017-08-22', '1723434203', '8001', 'En Proceso')

alter procedure fineLoan
@id int
as
select Loan.id, Loan.identificationCard, Convert(varchar(20),Loan.dateLoan) as dateLoan
from Customer, Loan
where id=@id and Customer.identificationCard = Loan.identificationCard

exec fineLoan 15

alter procedure insertFine
	@value money,
	@descriptionF varchar(50)
	as
		insert into dbo.Fine
		values(@value, @descriptionF)

select * from fine

-- Procedimientos Para Reporte

-- Por Libro
alter procedure BookReport
as
select Book.code as Codigo, Book.isbn as ISBN, Book.name as Titulo, Convert(varchar(20),Book.datePublish) as FechaPublicacion, 
Editorial.name as Editorial, Author.name as Nombre, Author.lastName as Apellido, Category.name as Categoria, 
Book.stateB as Estado, Book.stock as Stock
from dbo.Book, dbo.Editorial, dbo.Author, dbo.Write, dbo.Category
where Book.idEdit = Editorial.id and Author.id = Write.id and Book.code = Write.code and Book.idCateg = Category.id

exec BookReport

-- Por Cliente
create procedure CustomerReport
as
select identificationCard as Cedula, name as Nombre, lastName as Apellido, 
phone as Telefono, celphone as Celular, addres as Direccion, mail as Email
from dbo.Customer	

exec CustomerReport

select * from book

select idEdit,count(IdEdit) from book group by (IdEdit)
