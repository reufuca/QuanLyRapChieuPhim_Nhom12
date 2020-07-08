create table tblHangSX(
	MaHangSX char(10) primary key,
	TenHangSX nvarchar(50) not null);
create table tblRap(
	MaRap char(10) primary key,
	TenRap nvarchar(50) not null,
	DiaChi nvarchar(100) not null,
	DienThoai varchar(15) not null,
	SoPhong nvarchar(10) not null,
	TongSoGhe float not null default 0);
create table tblTheLoai(
	MaTheLoai char(10) primary key,
	TenTheLoai nvarchar(50) not null);
create table tblNuocSX(
	MaNuocSX char(10) primary key,
	TenNuocSX nvarchar(50) not null);
create table tblPhongChieu(
	MaPhong char(10) primary key,
	MaRap char(10) not null,
	TenPhong nvarchar(50) not null,
	TongSoGhe float not null,
	constraint fk_RapPhongChieu foreign key (MaRap) references tblRap(MaRap));
create table tblPhim(
	MaPhim char(10) primary key,
	TenPhim nvarchar(50) not null,
	MaNuocSX char(10) not null,
	MaHangSX char(10) not null,
	DaoDien nvarchar(50) not null,
	MaTheLoai char(10) not null,
	NgayKhoiChieu datetime not null,
	NgayKetThuc datetime not null,
	NuDVChinh nvarchar(50),
	NamDVChinh nvarchar(50),
	NoiDungChinh nvarchar(250),
	TongChiPhi float,
	TongThu float default 0,
	Anh image,
	constraint fk_PhimNuocSX foreign key (MaNuocSX) references tblNuocSX(MaNuocSX),
	constraint fk_PhimTheLoai foreign key (MaTheLoai) references tblTheLoai(MaTheLoai),
	constraint fk_PhimHangSX foreign key (MaHangSX) references tblHangSX(MaHangSX));
create table tblGioChieu(
	MaGioChieu char(10) primary key,
	MaRap char(10) not null,
	GioChieu time not null,
	constraint fk_GioChieuRap foreign key (MaRap) references tblRap(MaRap));
create table tblLichChieu(
	MaShow char(10) primary key,
	MaPhim char(10) not null,
	MaRap char(10) not null,
	MaPhong char(10) not null,
	NgayChieu datetime not null,
	MaGioChieu char(10) not null,
	GiaVe float not null,
	SoVeDaBan float not null default 0,
	TongTien float not null default 0,
	constraint fk_LichChieuRap foreign key (MaRap) references tblRap(MaRap),
	constraint fk_LichChieuPhong foreign key (MaPhong) references tblPhongChieu(MaPhong),
	constraint fk_LichChieuPhim foreign key (MaPhim) references tblPhim(MaPhim),
	constraint fk_LichChieuGio foreign key (MaGioChieu) references tblGioChieu(MaGioChieu));
create table tblVe(
	MaGhe char(10) primary key,
	MaShow char(10) not null, 
	constraint fk_VeShow foreign key (MaShow) references tblLichChieu(MaShow));
create table tblPhongChieuGhe(
	MaRap char(10) not null,
	MaPhong char(10) not null,
	MaGhe char(10) primary key not null,
	TrangThai nvarchar(15),
	constraint fk_PCG1 foreign key (MaRap) references tblRap(MaRap),
	constraint fk_PCG2 foreign key (MaPhong) references tblPhongChieu(MaPhong),
	constraint fk_PCG3 foreign key (MaGhe) references tblVe(MaGhe));

-- Cập nhật tổng số phòng một rạp khi có phòng mới
create trigger SoPhongRap
on tblPhongChieu after insert as
begin
update tblRap
set SoPhong = SoPhong +( select count(MaPhong) from inserted where MaRap= tblRap.MaRap) from tblRap join inserted on tblRap.MaRap =inserted.MaRap
end 
-- Cập nhật tổng số ghế một rạp khi có phòng mới
create trigger TongSoGheRap on tblPhongChieu after insert as
begin 
update tblRap
set TongSoGhe = tblRap.TongSoGhe +(select TongSoGhe from inserted where MaRap = tblRap.MaRap) from tblRap join inserted on tblRap.MaRap=inserted.MaRap
end
-- Cập nhật tổng số phòng một rạp sau khi một phòng bị xóa
create trigger XoaSoPhongRap 
on tblPhongChieu for delete as
begin
update tblRap
set SoPhong = SoPhong -( select count(MaPhong) from deleted where MaRap= tblRap.MaRap) from tblRap join deleted on tblRap.MaRap =deleted.MaRap
end 
-- Cập nhật tổng số ghế một rạp sau khi một phòng bị xóa
create trigger XoaTongSoGheRap on tblPhongChieu for delete as
begin 
update tblRap
set TongSoGhe = tblRap.TongSoGhe -(select TongSoGhe from deleted where MaRap =tblRap.MaRap) from tblRap join deleted on tblRap.MaRap =deleted.MaRap
end
-- Cập nhật tổng số ghế một rạp sau khi sửa số liệu một phòng
create trigger SuaTongSoGhe on tblPhongChieu after update as
begin 
update tblRap
set TongSoGhe = tblRap.TongSoGhe +(select TongSoGhe from inserted where MaRap =tblRap.MaRap ) - (select TongSoGhe from deleted where MaRap =tblRap.MaRap) from tblRap join deleted on tblRap.MaRap =deleted.MaRap
end
-- Cập nhật tổng số ghế một phòng sau khi một ghế được thêm
create trigger TongSoGhePC on tblPhongChieuGhe after insert as
begin 
update tblPhongChieu
set TongSoGhe = tblPhongChieu.TongSoGhe +(select count (MaGhe) from inserted where MaPhong =tblPhongChieu.MaPhong) from tblPhongChieu join inserted on tblPhongChieu.MaPhong=inserted.MaPhong
end

-- Cập nhật tổng số ghế một phòng sau khi một ghế bị xóa
create trigger XoaTongSoGhePC on tblPhongChieuGhe for delete as
begin 
update tblPhongChieu
set TongSoGhe = tblPhongChieu.TongSoGhe -(select count (MaGhe) from deleted where MaPhong =tblPhongChieu.MaPhong) from tblPhongChieu join deleted on tblPhongChieu.MaPhong =deleted.MaPhong
end
Create trigger DatVe on tblVe AFTER INSERT AS 
	BEGIN UPDATE tblPhongChieuGhe
	SET TrangThai= N'Đã Đặt'
	From tblPhongChieuGhe join inserted on tblPhongChieuGhe.MaGhe = inserted.MaGhe
	where tblPhongChieuGhe.MaGhe = inserted.MaGhe
	END
Create trigger HuyVe on tblVe AFTER DELETE AS 
	BEGIN UPDATE tblPhongChieuGhe
	SET TrangThai= N'Trống'
	From tblPhongChieuGhe join deleted on tblPhongChieuGhe.MaGhe = deleted.MaGhe
	where tblPhongChieuGhe.MaGhe = deleted.MaGhe
	END
        -- Cập nhật tổng tiền khi có thêm vé được bán
Create trigger TongTienist on tblVe AFTER INSERT AS 
	BEGIN UPDATE tblLichChieu
	SET TongTien = (GiaVe * SoVeDaBan) FROM tblLichChieu join inserted on tblLichChieu.MaShow = inserted.MaShow
	WHERE tblLichChieu.MaShow = inserted.MaShow
	END
-- Cập nhật tổng tiền khi có vé bị hủy
Create trigger TongTiendlt on tblVe AFTER DELETE AS 
	BEGIN UPDATE tblLichChieu
	SET TongTien = (GiaVe * SoVeDaBan) FROM tblLichChieu join deleted on tblLichChieu.MaShow = deleted.MaShow
	WHERE tblLichChieu.MaShow = deleted.MaShow
	END
-- Cập nhật tổng tiền khi có vé thay đổi phim
Create trigger TongTienudt on tblVe AFTER UPDATE AS 
	BEGIN UPDATE tblLichChieu
	SET TongTien = (GiaVe * SoVeDaBan) FROM tblLichChieu join inserted on tblLichChieu.MaShow = inserted.MaShow
	WHERE tblLichChieu.MaShow = inserted.MaShow
	END

-- Cập nhật tổng thu khi show được cập nhật
Create trigger TongThuupdate on tblLichChieu AFTER UPDATE AS 
	BEGIN UPDATE tblPhim
	SET TongThu = (select SUM(TongTien) from tblPhim join inserted on tblPhim.MaPhim = inserted.MaPhim
	GROUP BY tblPhim.MaPhim)
	END
-- Cập nhật tổng tiền khi có một show bị hủy
Create trigger TongThudelete on tblLichChieu AFTER DELETE AS 
	BEGIN UPDATE tblPhim
	SET TongThu = (select SUM(TongTien) from tblPhim join deleted on tblPhim.MaPhim = deleted.MaPhim
	GROUP BY tblPhim.MaPhim)
	END
