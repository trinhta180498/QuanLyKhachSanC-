USE QuanLyKhachSan
GO	
insert into Account(UserName,DisplayName,PassWord) values (N'oanhtrinh', N'Oanh Trịnh',1)
insert into Account(UserName,DisplayName,PassWord) values (N'congtrinh', N'Công Trịnh',2)
insert into Account(UserName,DisplayName,PassWord) values (N'anhhoang', N'Anh Hoàng',3)
insert into Account(UserName,DisplayName,PassWord) values (N'tam', N'Tâm',4)

--Sevice
INSERT INTO dbo.Sevice( name, price )VALUES  ( N'Giải trí', 500.0  )
INSERT INTO dbo.Sevice( name, price )VALUES  ( N'Giặt đồ', 250.0 )
INSERT INTO	 dbo.Sevice( name, price )VALUES  ( N'Đồ uống', 100.0 )

GO
--category
INSERT INTO dbo.CategoryRoom( name, price )VALUES  ( N'VIP1', 1000.0  )
INSERT INTO dbo.CategoryRoom( name, price )VALUES  ( N'VIP2',500.0 )
INSERT INTO dbo.CategoryRoom
        ( name, price )VALUES  ( N'VIP3', 150.0 )
GO
--room
INSERT INTO dbo.Room( idCatagoryRoom)VALUES  (1)
INSERT INTO dbo.Room( idCatagoryRoom)VALUES  (1)
INSERT INTO dbo.Room( idCatagoryRoom)VALUES  (1)
INSERT INTO dbo.Room( idCatagoryRoom)VALUES  (1)
INSERT INTO dbo.Room( idCatagoryRoom)VALUES  (2)
INSERT INTO dbo.Room( idCatagoryRoom)VALUES  (2)
INSERT INTO dbo.Room( idCatagoryRoom)VALUES  (2)
INSERT INTO dbo.Room( idCatagoryRoom)VALUES  (2)
INSERT INTO dbo.Room( idCatagoryRoom)VALUES  (3)
INSERT INTO dbo.Room( idCatagoryRoom)VALUES  (3)
INSERT INTO dbo.Room( idCatagoryRoom)VALUES  (3)

DECLARE @i INT =1
WHILE @i <=20
BEGIN
	Update dbo.Room set name=N'Phòng'+CAST(@i AS nvarchar(100)) where id=@i
	SET @i=@i+1
END

go
--Phieu dang ky
INSERT INTO dbo.PhieuDangKy( name,dateCheckIn, dateCheckOut, idRoom )VALUES  (N'Oanh', GETDATE(), GETDATE(),  1  )
INSERT INTO dbo.PhieuDangKy( name,dateCheckIn, dateCheckOut, idRoom )VALUES  ( N'Trịnh',GETDATE(),GETDATE(), 2 )
INSERT INTO dbo.PhieuDangKy( name,dateCheckIn, dateCheckOut, idRoom )VALUES  ( N'Tâm',GETDATE(), null, 3 )
INSERT INTO dbo.PhieuDangKy( name,dateCheckIn, dateCheckOut, idRoom )VALUES  (N'Công', GETDATE(), GETDATE(), 4 )
INSERT INTO dbo.PhieuDangKy( name,dateCheckIn, dateCheckOut, idRoom )VALUES  (N'Hoàng', GETDATE(), GETDATE(), 6 )
INSERT INTO dbo.PhieuDangKy( name,dateCheckIn, dateCheckOut, idRoom )VALUES  (N'Thắng', GETDATE(), GETDATE(), 7 )
INSERT INTO dbo.PhieuDangKy( name,dateCheckIn, dateCheckOut, idRoom )VALUES  (N'Linh', GETDATE(), GETDATE(), 5 )
go
--Bill
INSERT INTO dbo.Bill( idPhieuDangKy, idSevice, cout )VALUES  ( 1, 1,1  )
INSERT INTO dbo.Bill ( idPhieuDangKy, idSevice, cout )VALUES  ( 1, 2, 3 )
INSERT INTO dbo.Bill ( idPhieuDangKy, idSevice, cout )VALUES  ( 1, 3, 4 )
INSERT INTO dbo.Bill ( idPhieuDangKy, idSevice, cout )VALUES  ( 2, 3, 4 )
INSERT INTO dbo.Bill ( idPhieuDangKy, idSevice, cout )VALUES  ( 2, 2, 5 )
INSERT INTO dbo.Bill ( idPhieuDangKy, idSevice, cout )VALUES  ( 2, 1, 6 )
INSERT INTO dbo.Bill ( idPhieuDangKy, idSevice, cout )VALUES  (3, 3, 2 )
INSERT INTO dbo.Bill ( idPhieuDangKy, idSevice, cout )VALUES  ( 3, 2, 1 )
INSERT INTO dbo.Bill ( idPhieuDangKy, idSevice, cout )VALUES  ( 3, 1, 2 )


SELECT id FROM dbo.Bill

select * from Account
select * from CategoryRoom
select * from Room
select * from PhieuDangKy
select * from Sevice
select * from Bill

create proc USP_GetTableList
as select * From Room
exec USP_GetTableList

DECLARE @i INT =4
WHILE @i <=30
BEGIN
	INSERT INTO dbo.Room( ,status ) VALUES  ( N'Phòng'+CAST(@i AS nvarchar(100)),0)
	SET @i=@i+1
END
go

select * from PhieuDangKy where idRoom=3 and statu=0

select * from Bill where idPhieuDangKy=2
select * from Bill
select * from Account
