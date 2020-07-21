use master
go
if(exists(select name from sys.databases where name = 'quanlynhahang'))
drop database quanlynhahang
go
create database quanlynhahang 
go
use quanlynhahang
go
create table Account (
	Id int primary key identity,
	Name nvarchar(100),
	Email nvarchar(100),
	Pass nvarchar(100),
	Avatar nvarchar(100) default 'accountavatar.png',
	Rights bit
)
go
create table Desk( 
	Id varchar(30) primary key,
	Name nvarchar(50) not null,
	Status tinyint default 0
)
go
create table Bill (
	Id varchar(30) primary key,
	DeskId Varchar(30),
	AccountId int,
	Total int,
	Status int default 0,
	CreatedAt datetime default getdate() ,
	Constraint fk_tbl foreign key (DeskId) references Desk(Id),
	Constraint fk_user foreign key (AccountId) references Account(Id)
)
go
create table FoodType(
	Id varchar(30) primary key,
	Name nvarchar(100) not null
)
go
create table Food (
	Id varchar(30) primary key,
	TypeId Varchar(30) not null,
	Name nvarchar(100) not null,
	Price int not null,
	Unit nvarchar(20),
	Picture nvarchar(100) default 'foodpicture.png',
	Status tinyint default 0	,
	Constraint fk_type foreign key (TypeId) references FoodType(Id)
)
go
create table BillDetail (
	Id int primary key identity,
	FoodId varchar(30) not null,
	BillId varchar(30) not null,
	Quantity int,
	CreatedDate datetime default getdate(),
	Constraint fk_fi foreign key (FoodId) references Food(Id),
	Constraint fk_bi foreign key (BillId) references Bill(Id),
)
go
--insert Account
insert into Account(Name, Email, Pass, Rights) values(N'Administrator', 'admin@gmail.com','admin',1),(N'Employee1', 'employee1@gmail.com','employee',0)
GO
--insert FoodType
insert into FoodType(Id,Name) values('1',N'Đồ ăn'),('2',N'Đồ uống'),('3',N'Đồ tráng miệng')
go
--Insert Desk
insert into Desk(Id,Name,Status) values ('D001',N'Bàn số 1',0),('D002',N'Bàn số 2',0),('D003',N'Bàn số 3',0),('D004',N'Bàn số 4',0),
('D005',N'Bàn số 5',0),('D006',N'Bàn số 6',0),('D007',N'Bàn số 7',0),('D008',N'Bàn số 8',0),('D009',N'Bàn số 9',0),('D010',N'Bàn số 10',0)
go
--insert Bill
insert into Bill(Id,DeskId,AccountId,Status) values('B001','D001',1,0),('B002','D002',1,1),('B003','D003',1,0),('B004','D004',1,0)
go
--insert Food
insert into Food(Id,TypeId,Name,Price,Unit) values('F001','1',N'Bún Đậu',30000,N'Đĩa'),('F002','1',N'Bún Canh',30000,N'Bát'),('F003','1',N'Bánh Cuốn',30000,N'Đĩa'),
('F004','1',N'Bánh Đa Cua',35000,N'Bát'),('F005','2',N'Coca',10000,N'lon'),('F006','3',N'Bánh Ngọt',10000,N'chiếc')
go
--Insert BillDetail
insert into BillDetail(FoodId,BillId,Quantity)values('F001','B001',2),('F002','B001',2),('F003','B001',2),('F004','B001',1),('F001','B002',3),('F005','B002',5),
('F006','B003',2),('F003','B004',2)
go
--Account
create proc Usp_GetAccountByLoginInfo(@email AS Varchar(50), @password AS VARCHAR(100))
AS
SELECT * FROM Account WHERE Email = @email AND Pass = @password
go
create proc Usp_UpdateAccountById(@id as int,@name as nvarchar(100),@pass as nvarchar(100),@avatar as nvarchar(100)) as
Update Account Set Name=@name,Pass=@pass,Avatar=@avatar where Id=@id
go
--Food;
create proc Usp_GetAllFood as SELECT * FROM Food 
go
create proc Usp_UpdateFood
(@id as varchar(30) ,@typeId as varchar(30) , @name as nvarchar(100),@price as int,@unit as nvarchar(20),@picture as nvarchar(100))
 as update Food
 SET TypeId=@typeId,Name=@name,Price=@price,Unit=@unit,Picture=@picture Where Id=@id   
go
create proc Usp_DeleteFood (@id as varchar(30)) as Delete From Food where Id =@id
go
create proc Usp_SearchFoodByName(@name as nvarchar(100)) as SELECT * From Food where Name like '%'+@name+'%'
go
create proc Usp_GetFoodById(@id as varchar(30)) as SELECT * FROM Food where Id=@id
go
create proc Usp_GetFoodByFoodType(@typeId as nvarchar(30)) as SELECT * FROM Food where TypeId=@typeId
go
Create proc Usp_InsertFood
(@id as varchar(30) ,@typeId as varchar(30) , @name as nvarchar(100),@price as int,@unit as nvarchar(20),@picture as nvarchar(100)) as
Insert into Food(Id,TypeId,Name,Price,Unit,Picture)values(@id,@typeId,@name,@price,@unit,@picture)
go

--FoodType
create proc Usp_GetAllFoodType as SELECT * FROM FoodType
go

--Bill
create proc Usp_GetAllBill (@from as datetime , @to as datetime ) as SELECT Bill.*, Desk.Name , Account.Name FROM ((Bill 
inner join Desk on Bill.DeskId =Desk.Id) inner join Account on Bill.AccountId=Account.Id) where Bill.CreatedAt between @from AND @to
go
create proc Usp_InsertBill(@id as varchar(30),@deskId as varchar(30),@accountId as int) as
insert into Bill(Id,DeskId,AccountId)values(@id,@deskId,@accountId)
go
create proc Usp_UpdateBill(@id as varchar(30),@total as int)as 
update Bill set Total=@total where Id=@id
go
create proc Usp_GetBillByDeskId(@deskId as varchar(30),@status as int)as
Select * from Bill where DeskId=@deskId and Status=@status
go
--BillDetail
Create proc Usp_GetAllBillDetailByBill(@billId as varchar(30)) as SELECT BillDetail.* , Food.*
From BillDetail inner join Food on BillDetail.FoodId=Food.Id where BillId = @billId
go
Create proc Usp_GetAllBillDetail as SELECT *From BillDetail
go
create proc Usp_InsertBillDetail(@foodId as varchar(30),@billId as varchar(30),@quantity as int) as
insert into BillDetail (FoodId,BillId,Quantity) values(@foodId,@billId,@quantity)
go

--Desk 
create proc Usp_GetAllDesk as SELECT * FROM Desk
go
Create proc Usp_InsertDesk (@id as varchar(30),@name as nvarchar(50),@status as tinyint) as
insert into Desk(Id,Name,Status) values(@id,@name,@status)
go
create proc Usp_DeleteDesk (@id as varchar(30)) as Delete From Desk where Id =@id
go
Create proc USp_UpdateDesk (@id as varchar(30),@status as tinyint) as update Desk Set Status=@status where Id=@id
go
create proc Usp_GetDeskById(@id as varchar(30))as select * from Desk where Id=@id

select * from Bill , BillDetail where BillDetail.BillId = Bill.id
