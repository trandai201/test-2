create database BanNongSan
go 
use BanNongSan
go

create table NhanVien_table(
	maNV varchar(7) primary key,
	tenNV nvarchar(50),
	tenDN varchar(25),
	matKhau varchar(25)
)


insert into NhanVien_table values
('NV00001','Lâm Trường Trương','truong1','12345'),
('NV00002','Quỳnh Nga Ngô','nga2','12345'),
('NV00003','Thiên Ðức Phan','duc3','12345'),
('NV00004','Ðăng Khánh Trịnh','khanh4','12345'),
('NV00005','Thanh Loan Vương','ThanhLoan70','12345'),
('NV00006','Trường Phát Vương','phattruong02','12345')


create table KhachHang_table(
	maKH varchar(7) primary key,
	tenKH nvarchar(50),
	SoTienDaDung int default 0
)
insert into KhachHang_table values
('KH00001',N'Trần Đại',default),
('KH00002',N'THu Hòa',default),
('KH00003',N'Thu Hằng',default),
('KH00004',N'Thu Hiền',default),
('KH00005',N'NHật Nga',default),
('KH00006',N'Hùng Hoàng',default),
('KH00007',N'Huỳnh Trí',default),
('KH00008',N'Đõ Nghĩa',default)


create table  DanhMucNongSan_table(
	maDM varchar(7) primary key,
	tenDM nvarchar(50)
)

insert into DanhMucNongSan_table values
('DM00001',N'Rau'),
('DM00002',N'Hoa Quả'),
('DM00003',N'Trứng Thịt')


create table  ChiTietNongSan(
	maNS varchar(7) primary key,
	tenNS nvarchar(50),
	soLuong int,
	chiTiet nvarchar(50),
	maSMNS varchar(7),
	gia int


)
insert into ChiTietNongSan values
('NS00001','Rau Má',23,'Rau Má Nhà Trồng','DM00001',10000),
('NS00002','Rau Muốn',23,'Trồng dưới mương','DM00001',15000),
('NS00003','Rau Chân Vịt',23,'Nông Sản Sạch','DM00001',20000),
('NS00004','Rau Cần Em',23,'Đảm bảo chất lượng','DM00001',12000),
('NS00005','Xoài QN',23,'Những Quả Tuyệt Nhất','DM00002',12300),
('NS00006','Dưa Hấu',23,'Được Trồng trên Đảo','DM00002',14000),
('NS00007','Táo Tây',23,'Trồng trên vường Địa Đàn','DM00002',45000),
('NS00008','Lê',23,'Từ Cây Lê Trong Truyện Kiều','DM00002',30000),
('NS00009','Thịt bò Cube',23,'Ít Mỡ Tố cho sức khỏe','DM00003',1000000),
('NS00010','Thịt Dê',23,'Cực Kì ngon','DM00003',150000),
('NS00011','Thịt Gà',23,'Thực phẩm sạch không chất tạo nạt','DM00003',146000)

create table  HoaDonNhapXuat_table(
	maHD varchar(50) primary key,
	maNV varchar(7),
	maKH varchar(7),
	LoaiHD varchar(1)
)
insert into HoaDonNhapXuat_table values
('HD00001','NV00001','KH00001','N')


create table ChiTietHoaDon_table(
maHD varchar(7) primary key,
maNS varchar(7),
soLuong int,
DonGia int
)
insert into ChiTietHoaDon_table values
('HD00001','NS00001',1,10000)






insert into KhachHang_table values
('KH00001','Tr?n D?i','0'),
('KH00002','THu Hòa','0'),
('KH00003','Thu H?ng','0'),
('KH00004','Thu Hi?n','0'),
('KH00005','NH?t Nga','0'),
('KH00006','Hùng Hoàng','0'),
('KH00007','Hu?nh Trí','0'),
('KH00008','Do Nghia','0')
DELETE FROM KhachHang_table

DROP DATABASE BanNongSan
/*
CREATE PROCEDURE UpdateData 
AS 
BEGIN
	BEGIN TRY
	print('1')
	END TRY
	BEGIN CATCH
	END CATCH



END
*/

CREATE PROCEDURE UpdateData 
AS 
BEGIN
	
END
drop procedure UpdateData


BEGIN TRY  
    if exists(select * from KhachHang_table where maKH ='KH00001')
	begin
		print('1 \')
	end else
	print('3')
END TRY  
BEGIN CATCH  
		print('2') 
END CATCH 
