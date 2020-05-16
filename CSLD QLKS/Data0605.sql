CREATE DATABASE QuanLyKhachSan
GO
USE	QuanLyKhachSan
GO
--Account( thông tin đăng nhập)
--CheckOut(Hóa đơn)
--CheckIn(Thông tin khách hàng)
--Room
--Sevice(Dịch vụ)

CREATE TABLE Account
(
	UserName NVARCHAR(100) NOT NULL PRIMARY KEY,
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'CTN', --tên hiển thị
	PassWord NVARCHAR(1000)NOT NULL DEFAULT 0,
	--Type INT NOT NULL DEFAULT 0
)
GO

CREATE TABLE CategoryRoom
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(20) default N'Chưa đặt tên',
	price FLOAT
)
GO	
select * from CategoryRoom
CREATE TABLE Room
(
	id INT identity PRIMARY KEY,--mã
	name nvarchar(100) default N'Chưa đặt tên',
	idCatagoryRoom INT default 1,
	status NVARCHAR(100) default N'Trống',
	FOREIGN KEY (idCatagoryRoom) REFERENCES dbo.CategoryRoom
)
GO	
select * from Room
CREATE TABLE PhieuDangKy
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) default N'Nguyễn Văn A',
	tuoi INT default 20,
	CNND NCHAR(10),
	sdt NCHAR(11),
	dateCheckIn DATE default GETDATE(),
	dateCheckOut DATE default GETDATE(),
	idRoom INT, 
	statu INT  DEFAULT 0 --1: đã thanh toán && : chưa thanh toán 

	FOREIGN KEY(idRoom) REFERENCES dbo.Room
)
select * from PhieuDangKy
GO
CREATE TABLE Sevice
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100),
	price int default 0
)
CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	idPhieuDangKy INT,
	idSevice INT,
	cout INT default 1,
	
    FOREIGN KEY(idPhieuDangKy) REFERENCES dbo.PhieuDangKy,
	FOREIGN KEY (idSevice) REFERENCES dbo.Sevice
)
GO

select * from Bill

select * from Bill where idPhieuDangKy=2

CREATE PROC USP_Login
@userName nvarchar(100), @passWord nvarchar(100)

AS
BEGIN
	SELECT* FROM dbo.Account WHERE UserName = @userName AND	 PassWord = @passWord 
END
GO
drop proc USP_GetTableList
CREATE PROC USP_GetTableList
AS SELECT * FROM dbo.Room
GO
EXEC usp_GetTableList

select *  from bill

declare @TienPhong int,
@idRoom int=3
set @TienPhong= (select c.price from CategoryRoom as c,Room where idCatagoryRoom=c.id and Room.id=@idRoom)
select @TienPhong


select @TienPhong,s.name, bi.cout, s.price,s.price*bi.cout as totalPrice from Bill as bi, PhieuDangKy as p, Sevice as s 
where bi.idPhieuDangKy = p.id and bi.idSevice = s.id and p.idRoom=@idRoom

select s.name, bi.cout, s.price,s.price*bi.cout as totalPrice 
from Bill as bi,PhieuDangKy as p, Sevice as s where bi.idPhieuDangKy = p.id and bi.idSevice = s.id and p.idRoom =3 and p.statu=0

select * from PhieuDangKy
select * from Room
select * from 
