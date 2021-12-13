create database QuanLyKho
go
use QuanLyKho
go

CREATE TABLE TAIKHOAN
(
	ID INT IDENTITY PRIMARY KEY,
	TENHIENTHI NVARCHAR(100) NOT NULL,
	USERNAME VARCHAR(50) NOT NULL,
	PASSWORD VARCHAR(50) NOT NULL,
	LOAITK INT NOT NULL
)

CREATE TABLE KHACHHANG
(
	MAKH INT PRIMARY KEY identity(1,1),
	IDUSERNAME int NOT NULL,
	HOTEN NVARCHAR(40),
	DCHI NVARCHAR(50),
	SODT VARCHAR(20),
	EMAIL VARCHAR(100),
	NGSINH DATE,
	GIOITINH int, 
	ANH varbinary(max)
)

CREATE TABLE SANPHAM
(
	MASP INT PRIMARY KEY IDENTITY(1,1),
	TEN nvarchar(50),
	GIA int,
	SL int ,
	DANHGIA real,
	DABAN int,
	MOTA nvarchar(100),
	IDLOAI int,
	ANH varbinary(max)
)

CREATE TABLE LOAISP
(
	ID INT PRIMARY KEY IDENTITY(1,1),
	TENLOAI NVARCHAR(20)
)

CREATE TABLE HOADON
(
	SOHD INT PRIMARY KEY IDENTITY(1,1),
	NGHD SMALLDATETIME,
	MAKH INT,
	TRIGIA INT, 
	TRANG_THAI nvarchar(50),
	NGXN smalldatetime
)

CREATE TABLE CTHD
(
	SOHD INT, 
	MASP INT,
	SL INT,
	PRIMARY KEY(SOHD,MASP)
)
go

ALTER TABLE HOADON ADD CONSTRAINT FK_HD_KH FOREIGN KEY(MAKH)
REFERENCES KHACHHANG(MAKH)

ALTER TABLE CTHD ADD CONSTRAINT FK_CTHD_HD FOREIGN KEY(SOHD)
REFERENCES HOADON(SOHD)

ALTER TABLE CTHD ADD CONSTRAINT FK_CTHD_SP FOREIGN KEY(MASP)
REFERENCES SANPHAM(MASP)

ALTER TABLE SANPHAM ADD CONSTRAINT FK_LOAI_SP FOREIGN KEY(IDLOAI)
REFERENCES LOAISP(ID)

ALTER TABLE KHACHHANG ADD CONSTRAINT FK_KH_TK FOREIGN KEY(IDUSERNAME)
REFERENCES TAIKHOAN(ID)

insert LOAISP(TENLOAI) values(N'Quần')
insert LOAISP(TENLOAI) values(N'Áo')
insert LOAISP(TENLOAI) values(N'Mũ')
insert LOAISP(TENLOAI) values(N'Giày')

--Thêm admin
insert into TAIKHOAN(DISPLAYNAME, USERNAME, PASSWORD, TYPETK) values ('admin', 'admin', 'admin', 0)
insert into KHACHHANG (IDUSERNAME, HOTEN, DCHI, SODT, EMAIL, NGSINH, GIOITINH)
values(1, 'admin', 'VietNam', '1234','kuti113ct@gmail.com', '2002-01-01', 1)

--Khach hang
insert into KHACHHANG ( HOTEN, DCHI, SODT, NGSINH, ANH)
values('Saitama', 'Japan', '1234', '2000-01-01', (SELECT * FROM OPENROWSET(BULK N'D:\HK3\LTTQ\Hinh\reload4.png', SINGLE_BLOB) as T1))
insert into KHACHHANG ( HOTEN, DCHI, SODT, NGSINH, ANH)
values('Kanna', 'Japan', '1234', '1985-02-05', (SELECT * FROM OPENROWSET(BULK N'D:\HK3\LTTQ\Hinh\reload4.png', SINGLE_BLOB) as T1))
insert into KHACHHANG ( HOTEN, DCHI, SODT, NGSINH, ANH)
values('Nobita', 'Japan', '1234', '1961-07-08', (SELECT * FROM OPENROWSET(BULK N'D:\HK3\LTTQ\Hinh\reload4.png', SINGLE_BLOB) as T1))
insert into KHACHHANG ( HOTEN, DCHI, SODT, NGSINH, ANH)
values('Jaian', 'Japan', '1234', '1962-06-15', (SELECT * FROM OPENROWSET(BULK N'D:\HK3\LTTQ\Hinh\reload4.png', SINGLE_BLOB) as T1))
insert into KHACHHANG ( HOTEN, DCHI, SODT, NGSINH, ANH)
values('Kogoro', 'Japan', '1234', '2002-03-17', (SELECT * FROM OPENROWSET(BULK N'D:\HK3\LTTQ\Hinh\reload4.png', SINGLE_BLOB) as T1))


--SANPHAM -giay
insert into SANPHAM ( TEN, GIA, SL, DANHGIA, DABAN, MOTA, IDLOAI)
values('Adidas', 5000000, 100, 4, 12, N'Giày ngon 4*', 4)
insert into SANPHAM ( TEN, GIA, SL, DANHGIA, DABAN, MOTA, IDLOAI, ANH)
values('Nike', 7000000, 110, 5, 11, N'Giày ngon 5*', 4, (SELECT * FROM OPENROWSET(BULK N'D:\HK3\LTTQ\Hinh\reload4.png', SINGLE_BLOB) as T1))
insert into SANPHAM ( TEN, GIA, SL, DANHGIA, DABAN, MOTA, IDLOAI, ANH)
values('Converse ', 3000000, 9, 4, 77, N'Giày ngon 5*', 4, (SELECT * FROM OPENROWSET(BULK N'D:\HK3\LTTQ\Hinh\reload4.png', SINGLE_BLOB) as T1))
insert into SANPHAM ( TEN, GIA, SL, DANHGIA, DABAN, MOTA, IDLOAI, ANH)
values('Puma', 3500000, 33, 6, 55, N'Giày ngon 3*', 4, (SELECT * FROM OPENROWSET(BULK N'D:\HK3\LTTQ\Hinh\reload4.png', SINGLE_BLOB) as T1))
insert into SANPHAM ( TEN, GIA, SL, DANHGIA, DABAN, MOTA, IDLOAI, ANH)
values('Balance ', 6050000, 110, 1, 10, N'Giày ngon 2.5*', 4, (SELECT * FROM OPENROWSET(BULK N'D:\HK3\LTTQ\Hinh\reload4.png', SINGLE_BLOB) as T1))

--SANPHAM -mu
insert into SANPHAM ( TEN, GIA, SL, DANHGIA, DABAN, MOTA, IDLOAI)
values('Adidas', 500000, 10, '5', 80, N'M? ngon 4*', 3)
insert into SANPHAM ( TEN, GIA, SL, DANHGIA, DABAN, MOTA, IDLOAI)
values('Levis', 75000, 90, '4', 11, N'm? ngon 5*', 3)
insert into SANPHAM ( TEN, GIA, SL, DANHGIA, DABAN, MOTA, IDLOAI)
values('Puma ', 30000, 9, 7, 60, N'm? ngon 5*', 3)
insert into SANPHAM ( TEN, GIA, SL, DANHGIA, DABAN, MOTA, IDLOAI)
values('Balenciaga ', 20100, 9, 5, 66, N'm? ngon 1*', 3)

--SANPHAM --áo

insert into SANPHAM ( TEN, GIA, SL, DANHGIA, DABAN, MOTA, IDLOAI)
values('Adidas', 800000, 10, 3, 10, N'áo ngon 4*', 2)
insert into SANPHAM ( TEN, GIA, SL, DANHGIA, DABAN, MOTA, IDLOAI)
values('Levis', 715000, 90, 6.5, 17, N'áo ngon 5*', 2)
insert into SANPHAM ( TEN, GIA, SL, DANHGIA, DABAN, MOTA, IDLOAI)
values('Puma ', 3200000, 9, 2, 18, N'áo ngon 5*', 2)
insert into SANPHAM ( TEN, GIA, SL, DANHGIA, DABAN, MOTA, IDLOAI)
values('Balenciaga ', 202100, 9, 7, 11, N'áo ngon 1*', 2)


--SANPHAM --Qu?n
insert into SANPHAM ( TEN, GIA, SL, DANHGIA, DABAN, MOTA, IDLOAI)
values('Adidas', 800000, 10, 4, 22, N'qu?n ngon 4*', 1)
insert into SANPHAM ( TEN, GIA, SL, DANHGIA, DABAN, MOTA, IDLOAI)
values('Levis', 715000, 90, 5, 40, N'qu?n  ngon 5*', 1)
insert into SANPHAM ( TEN, GIA, SL, DANHGIA, DABAN, MOTA, IDLOAI)
values('Puma ', 3200000, 9, 4, 60, N'qu?n ngon 5*', 1)
insert into SANPHAM ( TEN, GIA, SL, DANHGIA, DABAN, MOTA, IDLOAI)
values('Balenciaga ', 202100, 9, 3.5, 88, N'qu?n ngon 1*', 1)

--HOADON
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-10-20', 1,24800000, 'Waiting' )--(masp x sl)49x1, 52x2, 64x4
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-08-29', 3,11474300, 'Waiting')--(masp x sl)65x2, 57x1, 53x1, 49x2
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-05-15', 2,107850000, 'Waiting' )--(masp x sl)50x2, 53x5, 60x4, 59x4,49x3
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-01-01', 4, 26474300, 'Waiting' )--(masp x sl)65x2, 57x1,55x6, 64x3, 60x5
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-01-01', 5, 36920100, 'Waiting')--(masp x sl)64x2, 57x1, 52x1,57x2, 51x9


--CTHD
insert into CTHD ( SOHD, MASP, SL)
values(1, 1, 1)
insert into CTHD ( SOHD, MASP, SL)
values(1, 4, 2)
insert into CTHD ( SOHD, MASP, SL)
values(1, 16, 4)

insert into CTHD ( SOHD, MASP, SL)
values(2, 17, 2)
insert into CTHD ( SOHD, MASP, SL)
values(2, 9, 1)
insert into CTHD ( SOHD, MASP, SL)
values(2, 2, 2)
insert into CTHD ( SOHD, MASP, SL)
values(2, 1, 2)

insert into CTHD ( SOHD, MASP, SL)
values(3, 1, 2)
insert into CTHD ( SOHD, MASP, SL)
values(3, 5, 5)
insert into CTHD ( SOHD, MASP, SL)
values(3, 4, 3)
insert into CTHD ( SOHD, MASP, SL)
values(3, 11, 4)



insert into CTHD ( SOHD, MASP, SL)
values(4, 17, 2)
insert into CTHD ( SOHD, MASP, SL)
values(4, 9, 1)
insert into CTHD ( SOHD, MASP, SL)
values(4, 7, 6)
insert into CTHD ( SOHD, MASP, SL)
values(4, 16, 3)
insert into CTHD ( SOHD, MASP, SL)
values(4, 12, 5)

insert into CTHD ( SOHD, MASP, SL)
values(5, 16, 2)
insert into CTHD ( SOHD, MASP, SL)
values(5, 1, 1)
insert into CTHD ( SOHD, MASP, SL)
values(5, 4, 1)
insert into CTHD ( SOHD, MASP, SL)
values(4, 2, 9)
insert into CTHD ( SOHD, MASP, SL)
values(4, 3, 9)

go


create proc test
as select KHACHHANG.MAKH, HOTEN, NGHD, HOADON.SOHD, TRANG_THAI, ANH, SUM(SL) as SOHANG
from KHACHHANG, HOADON, CTHD
where KHACHHANG.MAKH = HOADON.MAKH
and HOADON.SOHD = CTHD.SOHD
group by KHACHHANG.MAKH, HOTEN, NGHD, HOADON.SOHD, TRANG_THAI, ANH
order by NGHD DESC 

select * from KHACHHANG
select * from TAIKHOAN
select * from SANPHAM
select * from HOADON
select * from CTHD
select * from LOAISP

delete from TAIKHOAN

delete from SANPHAM
exec test


