﻿use QuanLyKho
create table SanPham
(
	id int primary key IDENTITY(1,1),
	Ten nvarchar(50),
	Gia real,
	SoLuong int,
	DanhGia real,
	DaBan int,
	MoTa nvarchar(100),
	Loai nvarchar(20),
	Anh image
)

create table LoaiSanPham
(
	id int primary key IDENTITY(1,1),
	Ten nvarchar(20),

)


insert into SanPham(Ten, Gia, SoLuong, DanhGia, DaBan, MoTa, Loai)
values('adidas',999,10,3,5,'tot','giay')
insert into SanPham(Ten, Gia, SoLuong, DanhGia, DaBan, MoTa, Loai)
values('quần đùi',234,25,5,20,'tot','quan')
insert into SanPham(Ten, Gia, SoLuong, DanhGia, DaBan, MoTa, Loai)
values('áo 3 lỗ',999,10,3,5,'tot','ao')

select * from SanPham