create database QuanLyKho
go
use QuanLyKho
go
CREATE TABLE TAIKHOAN
(
	ID INT IDENTITY PRIMARY KEY,
	TENHIENTHI NVARCHAR(100) NOT NULL,
	TENDANGNHAP VARCHAR(50) NOT NULL,
	MATKHAU VARCHAR(50) NOT NULL,
	LOAITK	INT	NOT NULL
)

CREATE TABLE KHACHHANG
(
	MAKH INT PRIMARY KEY identity(1,1),
	IDTK int NOT NULL,
	HOTEN NVARCHAR(40),
	DCHI NVARCHAR(50),
	SODT VARCHAR(20),
	EMAIL VARCHAR(100),
	NGSINH DATE,
	GIOITINH INT, 
	ANH VARBINARY(max)
)
CREATE TABLE SANPHAM
(
	MASP INT PRIMARY KEY IDENTITY(1,1),
	TEN NVARCHAR(50) NOT NULL,
	GIA INT NOT NULL,
	GIANHAP INT NOT NULL,
	SL INT CHECK (SL >= 0),
	DANHGIA REAL,
	DABAN INT CHECK (DABAN >= 0),
	MOTA NVARCHAR(2000),
	IDLOAI INT NOT NULL,
	ANH VARBINARY(MAX)
)
CREATE TABLE LOAISP
(
	ID INT PRIMARY KEY IDENTITY(1,1),
	TENLOAI NVARCHAR(20) NOT NULL
)
CREATE TABLE HOADON
(
	SOHD INT PRIMARY KEY IDENTITY(1,1),
	NGHD SMALLDATETIME DEFAULT GETDATE(),
	MAKH INT NOT NULL,
	TRIGIA INT DEFAULT 0, 
	TRANG_THAI NVARCHAR(50) DEFAULT  N'Chờ',
	NGXN SMALLDATETIME
)
CREATE TABLE CTHD
(
	SOHD INT, 
	MASP INT,
	SL INT DEFAULT 1,
	GIA INT,
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

ALTER TABLE KHACHHANG ADD CONSTRAINT FK_KH_TK FOREIGN KEY(IDTK)
REFERENCES TAIKHOAN(ID)
go
create trigger CTHD_GIA
ON CTHD
for insert
as
	declare @GIA int
	declare @SOHD int
	declare @MASP int
	select @SOHD = SOHD from INSERTED
	select @MASP = MASP from INSERTED
	select @GIA = SANPHAM.GIA  from SANPHAM, INSERTED  where INSERTED.MASP  = SANPHAM.MASP
	update CTHD set GIA = @GIA where SOHD =  @SOHD and MASP = @MASP
go
insert LOAISP(TENLOAI) values(N'Quần')
insert LOAISP(TENLOAI) values(N'Áo')
insert LOAISP(TENLOAI) values(N'Mũ')
insert LOAISP(TENLOAI) values(N'Giày')

insert into TAIKHOAN(TENHIENTHI, TENDANGNHAP, MATKHAU, LOAITK) values ('admin', 'admin', 'a', 0)
insert into TAIKHOAN(TENHIENTHI, TENDANGNHAP, MATKHAU, LOAITK) values ('user1', 'user1', 'a', 1)
insert into TAIKHOAN(TENHIENTHI, TENDANGNHAP, MATKHAU, LOAITK) values ('user2', 'user2', 'a', 1)
insert into TAIKHOAN(TENHIENTHI, TENDANGNHAP, MATKHAU, LOAITK) values ('user3', 'user3', 'a', 1)
insert into TAIKHOAN(TENHIENTHI, TENDANGNHAP, MATKHAU, LOAITK) values ('user4', 'user4', 'a', 1)
insert into TAIKHOAN(TENHIENTHI, TENDANGNHAP, MATKHAU, LOAITK) values ('user5', 'user5', 'a', 1)
insert into TAIKHOAN(TENHIENTHI, TENDANGNHAP, MATKHAU, LOAITK) values ('user6', 'user6', 'a', 1)
insert into TAIKHOAN(TENHIENTHI, TENDANGNHAP, MATKHAU, LOAITK) values ('user7', 'user7', 'a', 1)
insert into TAIKHOAN(TENHIENTHI, TENDANGNHAP, MATKHAU, LOAITK) values ('user8', 'user8', 'a', 1)
insert into TAIKHOAN(TENHIENTHI, TENDANGNHAP, MATKHAU, LOAITK) values ('user9', 'user9', 'a', 1)



--KHACHHANG
insert into KHACHHANG (IDTK, HOTEN, DCHI, SODT, EMAIL, NGSINH, GIOITINH)
values(1, 'admin', 'VietNam', '1234','bakhanh113ct@gmail.com', '2002-01-01', 1)
insert into KHACHHANG (IDTK, HOTEN, DCHI, SODT,EMAIL, NGSINH, GIOITINH)
values(2,'Saitama', 'Japan', '1234', '20521450@gm.uit.edu.vn', '2000-01-01', 1)
insert into KHACHHANG (IDTK, HOTEN, DCHI, SODT,EMAIL, NGSINH, GIOITINH)
values(3,'Kanna', 'Japan', '1234', 'sv2htth@gmail.com', '1985-02-05',0)
insert into KHACHHANG (IDTK, HOTEN, DCHI, SODT,EMAIL, NGSINH, GIOITINH)
values(4,'Nobita', 'Japan', '1234', 'sv2htth@gmail.com',  '1961-07-08',1)
insert into KHACHHANG (IDTK, HOTEN, DCHI, SODT,EMAIL, NGSINH, GIOITINH)
values(5, 'Jaian', 'Japan', '1234', 'sv2htth@gmail.com',  '1962-06-15', 1)
insert into KHACHHANG (IDTK, HOTEN, DCHI, SODT,EMAIL, NGSINH, GIOITINH)
values(6, 'Kogoro', 'Japan', '1234', 'sv2htth@gmail.com',  '2002-03-17', 1)
insert into KHACHHANG (IDTK, HOTEN, DCHI, SODT,EMAIL, NGSINH, GIOITINH)
values(7, 'No Name', N'Lào', '1234', 'sv2htth@gmail.com',  '2002-03-17', 1)
insert into KHACHHANG (IDTK, HOTEN, DCHI, SODT,EMAIL, NGSINH, GIOITINH)
values(8, 'Riley Reid', 'USA', '1234', 'sv2htth@gmail.com',  '2002-03-17', 0)
insert into KHACHHANG (IDTK, HOTEN, DCHI, SODT,EMAIL, NGSINH, GIOITINH)
values(9, 'Lana Rhoades ', 'USA', '1234', 'sv2htth@gmail.com',  '2002-03-17', 0)
insert into KHACHHANG (IDTK, HOTEN, DCHI, SODT,EMAIL, NGSINH, GIOITINH)
values(10, N'Đức Long', N'Việt Nam', '1234', 'sv2htth@gmail.com',  '2002-03-17', 1)




--SANPHAM -giay
insert into SANPHAM ( TEN, GIA, GIANHAP, SL, DANHGIA, DABAN, MOTA, IDLOAI)
values(N'giày Adidas', 5000000,4800000, 100, 4, 12, N'Giày ngon 4*', 4)
insert into SANPHAM ( TEN, GIA, GIANHAP, SL, DANHGIA, DABAN, MOTA, IDLOAI)
values(N'Giày Balenciaga', 7000000, 68000000, 110, 5, 11, N'Giày ngon 5*', 4)
insert into SANPHAM ( TEN, GIA, GIANHAP, SL, DANHGIA, DABAN, MOTA, IDLOAI)
values(N'Giày Converse', 3000000,2800000, 9, 4, 77, N'Giày ngon 5*', 4)
insert into SANPHAM ( TEN, GIA, GIANHAP, SL, DANHGIA, DABAN, MOTA, IDLOAI)
values(N'Giày Chanel', 3500000,3300000, 33, 6, 55, N'Giày ngon 3*', 4)
insert into SANPHAM ( TEN, GIA, GIANHAP, SL, DANHGIA, DABAN, MOTA, IDLOAI)
values(N'Giày Balenciaga', 6050000,6000000, 110, 1, 10, N'Giày ngon 2.5*', 4)
insert into SANPHAM ( TEN, GIA, GIANHAP, SL, DANHGIA, DABAN, MOTA, IDLOAI)
values(N'Giày Gucci', 6050000,58000000, 110, 1, 10, N'Giày ngon 2.5*', 4)


--mu
insert into SANPHAM ( TEN, GIA, GIANHAP, SL, DANHGIA, DABAN, MOTA, IDLOAI)
values(N'Mũ Adidas', 500000,450000, 10, '5', 80, N'Mũ ngon 4*', 3)
insert into SANPHAM ( TEN, GIA, GIANHAP, SL, DANHGIA, DABAN, MOTA, IDLOAI)
values(N'Mũ Chanle', 75000,70000, 90, '4', 11, N'mũ ngon 5*', 3)
insert into SANPHAM ( TEN, GIA, GIANHAP, SL, DANHGIA, DABAN, MOTA, IDLOAI)
values(N'Mũ Gucci', 30000,25000, 9, 7, 60, N'mũ ngon 5*', 3)
insert into SANPHAM ( TEN, GIA, GIANHAP, SL, DANHGIA, DABAN, MOTA, IDLOAI)
values(N'Mũ Balenciaga ', 20100,18000, 9, 5, 66, N'mũ ngon 1*', 3)
insert into SANPHAM ( TEN, GIA, GIANHAP, SL, DANHGIA, DABAN, MOTA, IDLOAI)
values('Mũ Converse', 500000,490000, 10, '5', 80, N'Mũ ngon 4*', 3)

--SANPHAM --áo

insert into SANPHAM ( TEN, GIA, GIANHAP, SL, DANHGIA, DABAN, MOTA, IDLOAI)
values(N'Áo Adidas', 800000,750000, 10, 0, 10, N'áo ngon 4*', 2)
insert into SANPHAM ( TEN, GIA, GIANHAP, SL, DANHGIA, DABAN, MOTA, IDLOAI)
values(N'Áo Chanel', 715000,700000 ,90, 6.5, 17, N'áo ngon 5*', 2)
insert into SANPHAM ( TEN, GIA, GIANHAP, SL, DANHGIA, DABAN, MOTA, IDLOAI)
values(N'Áo Gucci ', 3200000,3000000, 9, 2, 18, N'áo ngon 5*', 2)
insert into SANPHAM ( TEN, GIA, GIANHAP, SL, DANHGIA, DABAN, MOTA, IDLOAI)
values(N'Áo Balenciaga ', 202100,200000 , 9, 7, 11, N'áo ngon 1*', 2)
insert into SANPHAM ( TEN, GIA, GIANHAP, SL, DANHGIA, DABAN, MOTA, IDLOAI)
values(N'Áo Converse', 202100,180000, 9, 7, 11, N'áo ngon 1*', 2)


--SANPHAM --Quần
insert into SANPHAM ( TEN, GIA, GIANHAP, SL, DANHGIA, DABAN, MOTA, IDLOAI)
values(N'Quần Adidas', 800000,760000, 10, 4, 22, N'quần ngon 4*', 1)
insert into SANPHAM ( TEN, GIA, GIANHAP, SL, DANHGIA, DABAN, MOTA, IDLOAI)
values(N'Quần Chanle', 715000,700000, 90, 5, 40, N'quần  ngon 5*', 1)
insert into SANPHAM ( TEN, GIA, GIANHAP, SL, DANHGIA, DABAN, MOTA, IDLOAI)
values(N'Quần Gucci ', 3200000,3000000 , 9, 4, 60, N'quần ngon 5*', 1)
insert into SANPHAM ( TEN, GIA, GIANHAP, SL, DANHGIA, DABAN, MOTA, IDLOAI)
values('Quần Balenciaga ', 202100,200000, 0, 3.5, 88, N'quần ngon 1*', 1)
insert into SANPHAM ( TEN, GIA, GIANHAP, SL, DANHGIA, DABAN, MOTA, IDLOAI)
values(N'Quần Converse', 202100, 180000, 9, 3.5, 88, N'quần ngon 1*', 1)

--HOADON
--thang1
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-01-01', 2, 12808400, N'Hoàn thành' )
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-01-02', 3, 25630000, N'Hoàn thành')
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-01-07', 4,52750000, N'Hủy' )
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-01-09', 5, 9236300, N'Hoàn thành' )

--thang2
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-02-12', 6, 98904200, N'Hủy' ) 
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-02-01', 7, 12808400, N'Hoàn thành')
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-02-02', 8, 25630000, N'Hoàn thành')
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-02-07', 9,52750000, N'Hủy')
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-02-09', 10, 9236300, N'Hoàn thành')
--thang3
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-03-02', 3, 69758400, N'Hoàn thành')
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-03-07', 4,3348900, N'Hủy')
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-03-09', 5, 61450000, N'Hoàn thành')
--thang4
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-04-01', 6, 34200000, N'Hoàn thành')
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-04-02', 3, 25630000, N'Hoàn thành')
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-04-07', 9,15818900, N'Hủy')
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-04-09', 2, 14287600, N'Hoàn thành')
--thang6
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-06-01', 9, 2393900, N'Hoàn thành')
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-06-02', 4, 43400000, N'Hoàn thành')
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-06-07', 2,17290000, N'Hủy')
--thang8
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-08-01', 3, 12808400, N'Hoàn thành')
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-08-02', 5, 25630000, N'Hoàn thành')
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-08-07', 7,52750000, N'Hủy')
--thang9
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-09-01', 8, 25250000, N'Hoàn thành')
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-09-02', 6, 46704200, N'Hoàn thành')
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-09-07', 2,1460500, N'Hủy')
--thang10
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-10-01', 4, 8752100, N'Hoàn thành')
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-10-02', 9, 16775000, N'Hoàn thành')
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-10-07', 5,6280400, N'Hủy')
--thang11
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-11-01', 2, 33875000, N'Hoàn thành')
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-11-02', 5, 13706300, N'Hoàn thành')
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-11-07', 8,15486700, N'Hủy')
--thang 12
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-12-01', 2, 28050000, N'Hoàn thành')
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-12-02', 7, 54800000, N'Hủy' )
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-12-12', 6, 8550000, N'Chờ' )
insert into HOADON ( NGHD, MAKH, TRIGIA, TRANG_THAI)
values('2021-12-12', 4, 28352100, N'Chờ' )



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
values(5, 2, 9)
insert into CTHD ( SOHD, MASP, SL)
values(5, 3, 9)

insert into CTHD ( SOHD, MASP, SL)
values(6, 1, 1)
insert into CTHD ( SOHD, MASP, SL)
values(6, 4, 2)
insert into CTHD ( SOHD, MASP, SL)
values(6, 16, 4)

insert into CTHD ( SOHD, MASP, SL)
values(7, 17, 2)
insert into CTHD ( SOHD, MASP, SL)
values(7, 9, 1)
insert into CTHD ( SOHD, MASP, SL)
values(7, 2, 2)
insert into CTHD ( SOHD, MASP, SL)
values(7, 1, 2)
insert into CTHD ( SOHD, MASP, SL)
values(7, 6, 2)
insert into CTHD ( SOHD, MASP, SL)
values(7, 5, 5)
insert into CTHD ( SOHD, MASP, SL)
values(7, 4, 3)
insert into CTHD ( SOHD, MASP, SL)
values(7, 11, 4)



insert into CTHD ( SOHD, MASP, SL)
values(8, 17, 2)
insert into CTHD ( SOHD, MASP, SL)
values(8, 9, 1)
insert into CTHD ( SOHD, MASP, SL)
values(8, 7, 6)
insert into CTHD ( SOHD, MASP, SL)
values(8, 16, 3)
insert into CTHD ( SOHD, MASP, SL)
values(8, 12, 5)

insert into CTHD ( SOHD, MASP, SL)
values(9 ,16, 2)
insert into CTHD ( SOHD, MASP, SL)
values(9, 1, 1)
insert into CTHD ( SOHD, MASP, SL)
values(9, 4, 1)
insert into CTHD ( SOHD, MASP, SL)
values(9, 2, 9)
insert into CTHD ( SOHD, MASP, SL)
values(9, 3, 9)

insert into CTHD ( SOHD, MASP, SL)
values(10, 16, 4)
insert into CTHD ( SOHD, MASP, SL)
values(10, 12, 2)
insert into CTHD ( SOHD, MASP, SL)
values(10, 5, 7)
insert into CTHD ( SOHD, MASP, SL)
values(10, 3, 3)
insert into CTHD ( SOHD, MASP, SL)
values(10, 14, 5)

insert into CTHD ( SOHD, MASP, SL)
values(11, 11, 2)
insert into CTHD ( SOHD, MASP, SL)
values(11, 7, 1)
insert into CTHD ( SOHD, MASP, SL)
values(11, 9, 1)
insert into CTHD ( SOHD, MASP, SL)
values(11, 20, 9)
insert into CTHD ( SOHD, MASP, SL)
values(11, 13, 4)

insert into CTHD ( SOHD, MASP, SL)
values(12, 5, 7)
insert into CTHD ( SOHD, MASP, SL)
values(12, 4, 2)
insert into CTHD ( SOHD, MASP, SL)
values(12, 6, 2)

insert into CTHD ( SOHD, MASP, SL)
values(13, 3, 1)
insert into CTHD ( SOHD, MASP, SL)
values(13, 4, 2)
insert into CTHD ( SOHD, MASP, SL)
values(13, 5, 4)

insert into CTHD ( SOHD, MASP, SL)
values(14, 17, 2)
insert into CTHD ( SOHD, MASP, SL)
values(14, 9, 1)
insert into CTHD ( SOHD, MASP, SL)
values(14, 2, 2)
insert into CTHD ( SOHD, MASP, SL)
values(14, 1, 2)

insert into CTHD ( SOHD, MASP, SL)
values(15, 2, 2)
insert into CTHD ( SOHD, MASP, SL)
values(15, 16, 5)
insert into CTHD ( SOHD, MASP, SL)
values(15, 21, 3)
insert into CTHD ( SOHD, MASP, SL)
values(15, 15, 4)

insert into CTHD ( SOHD, MASP, SL)
values(16, 20, 2)
insert into CTHD ( SOHD, MASP, SL)
values(16,11, 1)
insert into CTHD ( SOHD, MASP, SL)
values(16, 15, 6)
insert into CTHD ( SOHD, MASP, SL)
values(16, 3, 3)
insert into CTHD ( SOHD, MASP, SL)
values(16, 18, 5)

insert into CTHD ( SOHD, MASP, SL)
values(17, 8, 1)
insert into CTHD ( SOHD, MASP, SL)
values(17, 7, 1)
insert into CTHD ( SOHD, MASP, SL)
values(17, 20, 9)


insert into CTHD ( SOHD, MASP, SL)
values(18, 19, 7)
insert into CTHD ( SOHD, MASP, SL)
values(18, 2, 2)
insert into CTHD ( SOHD, MASP, SL)
values(18, 4, 2)

insert into CTHD ( SOHD, MASP, SL)
values(19, 18, 6)
insert into CTHD ( SOHD, MASP, SL)
values(19, 7, 2)
insert into CTHD ( SOHD, MASP, SL)
values(19, 3, 4)

insert into CTHD ( SOHD, MASP, SL)
values(20, 1, 1)
insert into CTHD ( SOHD, MASP, SL)
values(20, 4, 2)
insert into CTHD ( SOHD, MASP, SL)
values(20, 16, 4)

insert into CTHD ( SOHD, MASP, SL)
values(21, 17, 2)
insert into CTHD ( SOHD, MASP, SL)
values(21, 9, 1)
insert into CTHD ( SOHD, MASP, SL)
values(21, 2, 2)
insert into CTHD ( SOHD, MASP, SL)
values(21, 1, 2)

insert into CTHD ( SOHD, MASP, SL)
values(22, 1, 2)
insert into CTHD ( SOHD, MASP, SL)
values(22, 5, 5)
insert into CTHD ( SOHD, MASP, SL)
values(22, 4, 3)

insert into CTHD ( SOHD, MASP, SL)
values(23, 5, 1)
insert into CTHD ( SOHD, MASP, SL)
values(23, 14, 2)
insert into CTHD ( SOHD, MASP, SL)
values(23, 19, 4)

insert into CTHD ( SOHD, MASP, SL)
values(24, 1, 2)
insert into CTHD ( SOHD, MASP, SL)
values(24, 5, 6)
insert into CTHD ( SOHD, MASP, SL)
values(24, 20, 2)

insert into CTHD ( SOHD, MASP, SL)
values(25, 16, 1)
insert into CTHD ( SOHD, MASP, SL)
values(25, 21, 4)
insert into CTHD ( SOHD, MASP, SL)
values(25, 8, 6)

insert into CTHD ( SOHD, MASP, SL)
values(26, 5, 1)
insert into CTHD ( SOHD, MASP, SL)
values(26, 7, 5)
insert into CTHD ( SOHD, MASP, SL)
values(26, 16, 1)

insert into CTHD ( SOHD, MASP, SL)
values(27, 12, 2)
insert into CTHD ( SOHD, MASP, SL)
values(27, 11, 1)
insert into CTHD ( SOHD, MASP, SL)
values(27, 8, 9)
insert into CTHD ( SOHD, MASP, SL)
values(27, 4, 4)

insert into CTHD ( SOHD, MASP, SL)
values(28, 5, 1)
insert into CTHD ( SOHD, MASP, SL)
values(28, 8, 2)
insert into CTHD ( SOHD, MASP, SL)
values(28, 10, 4)

insert into CTHD ( SOHD, MASP, SL)
values(29, 4, 4)
insert into CTHD ( SOHD, MASP, SL)
values(29, 8, 9)
insert into CTHD ( SOHD, MASP, SL)
values(29, 14, 6)

insert into CTHD ( SOHD, MASP, SL)
values(30, 15, 2)
insert into CTHD ( SOHD, MASP, SL)
values(30, 21, 1)
insert into CTHD ( SOHD, MASP, SL)
values(30, 5, 2)
insert into CTHD ( SOHD, MASP, SL)
values(30, 7, 2)

insert into CTHD ( SOHD, MASP, SL)
values(31, 17, 2)
insert into CTHD ( SOHD, MASP, SL)
values(31, 2, 1)
insert into CTHD ( SOHD, MASP, SL)
values(31, 20, 3)
insert into CTHD ( SOHD, MASP, SL)
values(31, 5, 1)
insert into CTHD ( SOHD, MASP, SL)
values(31, 8, 2)
insert into CTHD ( SOHD, MASP, SL)
values(31, 10, 4)

insert into CTHD ( SOHD, MASP, SL)
values(33, 4, 4)
insert into CTHD ( SOHD, MASP, SL)
values(33, 7, 9)
insert into CTHD ( SOHD, MASP, SL)
values(33, 5, 6)

insert into CTHD ( SOHD, MASP, SL)
values(34, 17, 2)
insert into CTHD ( SOHD, MASP, SL)
values(34, 12, 1)
insert into CTHD ( SOHD, MASP, SL)
values(34, 8, 2)
insert into CTHD ( SOHD, MASP, SL)
values(34, 3, 2)

insert into CTHD ( SOHD, MASP, SL)
values(32, 7, 2)
insert into CTHD ( SOHD, MASP, SL)
values(32, 6, 1)
insert into CTHD ( SOHD, MASP, SL)
values(32, 2, 3)

insert into CTHD ( SOHD, MASP, SL)
values(35, 1, 2)
insert into CTHD ( SOHD, MASP, SL)
values(35, 21, 1)
insert into CTHD ( SOHD, MASP, SL)
values(35, 6, 3)

