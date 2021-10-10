create database QuanLyKho

use QuanLyKho

create table TaiKhoan
(
	id int primary key,
	tendangnhap varchar(20),
	matkhau varchar(20),
	typetk varchar(20)
)

insert into TaiKhoan values ('1', 'khanh','113','user')
insert into TaiKhoan values ('2', 'khanh113','113','admin')

select * from TaiKhoan
select count(*) from TaiKhoan where tendangnhap = 'khanh' and matkhau = '113'