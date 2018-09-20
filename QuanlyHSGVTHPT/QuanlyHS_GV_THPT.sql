create database QuanlyHS_GV_THPT
go
use QuanlyHS_GV_THPT
go
Create table TOBM
(
	ID int Identity(1,1) primary key not null,
	TENTO nvarchar(50) unique,
	SOGV int
)
go
create table GIAOVIEN
(
	ID int Identity(1,1) primary key not null,
	TENGV nvarchar(50),
	NGAYSINH Date default (getdate()),
	SDT char(11),
	DIACHI nvarchar(50),
	TOBMID int REFERENCES TOBM (ID)
)
go
create table MONHOC
(
	ID int Identity(1,1) primary key not null,
	TENMH nvarchar(50) unique,
	TOBMID int references TOBM(ID)
)
go
Create table LOP
(
	ID int Identity(1,1) primary key not null,
	TENLOP nvarchar(50),
	SYSO int
)
go
Create table HOCSINH
(
	ID int Identity(1,1) primary key not null,
	HOTEN nvarchar(10),
	NGAYSINH Date default (getdate()),
	DIACHI nvarchar(50),
	LOPID int references LOP(ID)
) 
go
alter table HOCSINH
alter column HOTEN nvarchar(50)
go
create table THOIKHOABIEU
(
	ID int IDENTITY(1,1) primary key,
	MAGV int references GIAOVIEN(ID),
	MALOP int references LOP(ID),
	THU nvarchar(20),
	TIET char(10)
)
go
Create table TAIKHOAN
(
	ID int IDENTITY(1,1) primary key,
	Username nvarchar(50) not null,
	Password varchar(50) not null
)
go
alter table TAIKHOAN
add Permission int
insert into TAIKHOAN values ('long','123',1)

--Trigger cập nhật số giáo viên của tổ
Alter trigger TGUpdateTO on GIAOVIEN for INSERT,DELETE
as
declare @to1 int, @to2 int
begin
	select @to1=TOBMID from deleted
	update TOBM set SOGV = SOGV - 1 where ID = @to1
	select @to2=TOBMID from inserted
	update TOBM set SOGV = SOGV + 1 where ID = @to2
end
--Trigger cập nhật sỹ số của lớp
Create trigger TGUpdateLop on HOCSINH for INSERT,DELETE
as
declare @lop1 int, @lop2 int
begin
	select @lop1=LOPID from deleted
	update LOP set SYSO = SYSO - 1 where ID = @lop1
	select @lop2=LOPID from inserted
	update LOP set SYSO = SYSO + 1 where ID = @lop2
end