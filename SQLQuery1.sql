create database QuanLyKho
go
use QuanLyKho
go
create table TaiKhoan
(
	id int primary key,
	tendangnhap varchar(20),
	matkhau varchar(20),
	typetk varchar(20)
)
go
insert into TaiKhoan values ('1', 'khanh','113','user')
insert into TaiKhoan values ('2', 'khanh113','113','admin')
go

select * from TaiKhoan
go
select count(*) from TaiKhoan where tendangnhap = 'khanh' and matkhau = '113'