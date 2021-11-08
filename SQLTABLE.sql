CREATE TABLE KHACHHANG
(
	MAKH INT PRIMARY KEY identity(1,1),
	HOTEN VARCHAR(40),
	DCHI VARCHAR(50),
	SODT VARCHAR(20),
	NGSINH SMALLDATETIME
)

CREATE TABLE SANPHAM
(
	MASP INT PRIMARY KEY IDENTITY(1,1),
	TEN nvarchar(50),
	GIA real,
	SL int,
	DANHGIA real,
	DABAN int,
	MOTA nvarchar(100),
	IDLOAI int,
	ANH image
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
	TRIGIA MONEY
)

CREATE TABLE CTHD
(
	SOHD INT, 
	MASP INT,
	SL INT,
	PRIMARY KEY(SOHD,MASP)
)

ALTER TABLE HOADON ADD CONSTRAINT FK_HD_KH FOREIGN KEY(MAKH)
REFERENCES KHACHHANG(MAKH)

ALTER TABLE CTHD ADD CONSTRAINT FK_CTHD_HD FOREIGN KEY(SOHD)
REFERENCES HOADON(SOHD)

ALTER TABLE CTHD ADD CONSTRAINT FK_CTHD_SP FOREIGN KEY(MASP)
REFERENCES SANPHAM(MASP)

ALTER TABLE SANPHAM ADD CONSTRAINT FK_LOAI_SP FOREIGN KEY(IDLOAI)
REFERENCES LOAISP(ID)

insert LOAISP(TENLOAI) values('quan')
insert LOAISP(TENLOAI) values('ao')
insert LOAISP(TENLOAI) values('mu')
insert LOAISP(TENLOAI) values('giay')

SELECT * FROM SANPHAM
SELECT * FROM HOADON
SELECT * FROM KHACHHANG
SELECT * FROM CTHD

drop table  LOAISP

insert into HOADON(NGHD,MAKH,TRIGIA) values ('2006-07-23','1','320000')
insert into CTHD(SOHD,MASP,SL) values ('2','5','10')
insert into KHACHHANG(HOTEN, DCHI, SODT,NGSINH) values('khanh', 'daklak', '039', '2002-03-04')