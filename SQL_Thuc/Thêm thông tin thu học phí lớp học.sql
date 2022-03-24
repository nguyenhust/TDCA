 USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[BienLaiLopHoc_Gets]    Script Date: 01/09/2018 09:21:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- biên lai lớp học get
create proc [dbo].[BienLaiLopHoc_Get]
@IDLopHoc int
as SET NOCOUNT ON
select 
	bl.IDBienLai,
	MaBienLai,
	SoLan,
	bl.soTien,
	Convert(Date,NgayThu) as NgayThu,
	TenNguoiThu as NguoiThu,
	IDNguoiThu,
	Huy,
	HinhThucThu,
	XuatHD,
	SoLanIn,
	hd.SoHoaDon,
	LoaiPhieu
 from BienLai bl
  left join HoaDonCT hdct on hdct.IDBienLai=bl.IDBienLai
 left join HoaDon hd on hd.IDHoaDon=hdct.IDHoaDon
 left join DT_LienTuc_LopHoc lh on lh.IDLopHoc=bl.IDLopHoc
 where bl.IDLopHoc=@IDLopHoc

 go

 --biên lai lớp học gets
create proc [dbo].[BienLaiLopHoc_Gets]
@IDBienLai bigint
as SET NOCOUNT ON
select 
	bl.IDBienLai,
	bl.MaBienLai,
    bl.IDLopHoc as IDLopHoc,
	bl.SoLan,
	bl.soTien,
	Convert(Date,bl.NgayThu) as NgayThu,
	bl.TenNguoiThu,
	bl.IDNguoiThu,
	bl.TenNguoiDong,
	bl.HinhThucThu,
	bl.XuatHD,
	bl.Huy,	
	bl.LoaiPhieu	
 from BienLai bl
left join DT_LienTuc_LopHoc lh on bl.IDLopHoc=lh.IDLopHoc
 WHERE bl.IDBienLai = @IDBienLai

 go
 -- insert  biên lai lớp học 
 create proc [dbo].[BienLaiLopHoc_ins]
--@idHocVien bigint,
@Mabienlai varchar(12),
@Solan tinyint output, 
@Sotien numeric,
@NgayThu datetime,
@IDNguoiThu bigint,
@NguoiThu nvarchar(50),
@NguoiDong nvarchar(50),
@HinhThucThu tinyint,
--@XuatHD bit,
@IDBienLai bigint output,
@LoaiPhieu tinyint,@IDLopHoc int
as  SET NOCOUNT ON
if(exists(select 1 from BienLai where mabienlai = @Mabienlai))
begin
	raiserror ('Mã biên lai [%s] này đã tồn tại, Bạn hãy kiểm tra lại!',16,1,@mabienlai)
	return
end
declare @LoaiPhieu1 nvarchar(100)

set @LoaiPhieu1=CONVERT(nvarchar(100),@LoaiPhieu)

if(@LoaiPhieu=0)
set @LoaiPhieu1=N'PDNTT làm thẻ'
if(@LoaiPhieu=1)
set @LoaiPhieu1=N'PDNTT làm chứng chỉ'


declare @IDBenhNhan bigint, @strNgayKyQuy varchar(10)
set @strNgayKyQuy = convert(varchar(10), @NgayThu, 103) 
set @solan = (select count(*) + 1 from BienLai kq where kq.IDLopHoc=@IDLopHoc)
insert into BienLai(Mabienlai,Solan,Sotien,NgayThu, IDNguoiThu,TenNguoiDong,TenNguoiThu, HinhThucThu,XuatHD,SoLanIn,LoaiPhieu,IDLopHoc)
values(@Mabienlai,@Solan,@Sotien,@Ngaythu, @IDNguoiThu,@NguoiDong,@NguoiThu, @HinhThucThu,0,1,@LoaiPhieu,@IDLopHoc)


set @IDBienLai = SCOPE_IDENTITY()
update BienLai set Huy=0 where IDBienLai=@IDBienLai


go
--update  biên lai lớp học 
create proc [dbo].[BienLaiLopHoc_Upd]
@idHocVien bigint,
@Mabienlai varchar(12),
@Solan tinyint output, 
@Sotien numeric,
@NgayThu datetime,
@IDNguoiThu bigint,
@NguoiThu nvarchar(50),
@NguoiDong nvarchar(50),
@HinhThucThu tinyint,
@IDBienLai bigint output,
@IDLopHoc int

as SET NOCOUNT ON
if(exists(select 1 from BienLai where mabienlai = @Mabienlai and idbienlai<>@idbienlai))
begin
raiserror ('Mã biên lai [%s] này đã tồn tại, Bạn hãy kiểm tra lại!',16,1,@mabienlai)
return
end
update BienLai
set
IDHocVien=@idHocVien,
Mabienlai=@Mabienlai,
Solan=@Solan,
Sotien=@Sotien,
TenNguoiDong = @NguoiDong,
HinhThucThu = @HinhThucThu,
IDLopHoc=@IDLopHoc
--Ngaykyquy=@Ngaykyquy,
--Nguoikyquy=@Nguoikyquy
where IdBienlai = @idbienlai
Insert into LogUpdateBienLai(IDHocVien,IDBienLai,IDNguoiCapNhat,TenNguoiCapNhat,SoTien,NgayCapNhat)
values (@idHocVien,@IDBienLai,@IDNguoiThu,@NguoiThu,@Sotien,@NgayThu)

if(exists(select 1 from HoaDonCT where  idbienlai = @idbienlai and SoTien <> @Sotien))
begin
update HoaDonCT set SoTien = @SoTien where IDBienLai = (select bl.IDBienLai from BienLai bl join HoaDonCT ct on ct.IDBienLai = bl.IDBienLai where ct.IDBienLai = @IDBienLai)
end

go
-- get thông tin lớp học
create PROCEDURE [dbo].[DT_LopHoc_gets]
@IDLopHoc int

AS
    BEGIN
        SET NOCOUNT ON
		
        /* Get ADM_ChucNang_Info from table */
   select lh.IDLopHoc,lh.MaLop as MaLopHoc,case when lh.TenCanBoPhuTrachNgoai ='' or lh.TenCanBoPhuTrachNgoai is null then cb.HoTen else lh.TenCanBoPhuTrachNgoai end as TenCanBoPhuTrach,ck.Ten as TenChuyenKhoa,lh.TenLop from DT_LienTuc_LopHoc lh
   left join DT_LienTuc_KhungLopHoc klh on klh.id=lh.idKhungLopHoc
   left join DIC_ChuyenKhoa ck on ck.ID=klh.idChuyenKhoa
   left join DIC_CanBo cb on cb.ID=lh.idCanBoPhuTrach
	  where lh.IDLopHoc=@IDLopHoc
    END

	go
-- get thông tin lớp học để view dữ liệu vào báo cáo thu tiền làm chứng chỉ và làm thẻ học viên
	create proc [dbo].[DT_LienTuc_LopHoc_Gets]
@MaLopHoc nvarchar(50)
--@IDHocVien bigint
AS
    BEGIN

        SET NOCOUNT ON
		declare @IDHocVien bigint
		set @IDHocVien=(select id from DT_LienTuc_HocVien where id=@IDHocVien AND MaLopHoc=@MaLopHoc)
		select 
		[DT_LienTuc_LopHoc].[MaLop],
            [DT_LienTuc_LopHoc].[TenLop],
            [DT_LienTuc_LopHoc].[DoiTuong],
            [DT_LienTuc_LopHoc].[NguonKinhPhi],
            [DT_LienTuc_LopHoc].[idCanBoPhuTrach],
            [DT_LienTuc_LopHoc].[idCanBoPhoiHop],
            [DT_LienTuc_LopHoc].[NgayBatDau],
            [DT_LienTuc_LopHoc].[NgayKetThuc],
            [DT_LienTuc_LopHoc].[HocPhi],
            [DT_LienTuc_LopHoc].[idCanBoGiangVien1],
            [DT_LienTuc_LopHoc].[idCanBoGiangVien2],
            [DT_LienTuc_LopHoc].[idCanBoGiangVien3],
            [DT_LienTuc_LopHoc].[idCanBoGiangVien4],
            [DT_LienTuc_LopHoc].[idCanBoGiangVien5],
            [DT_LienTuc_LopHoc].[idKhungLopHoc],
            [DT_LienTuc_LopHoc].[KhoaHoc],
            [DT_LienTuc_LopHoc].[IdNguonKinhPhi],
            [DT_LienTuc_LopHoc].[LastEdited_User],
            [DT_LienTuc_LopHoc].[LastEdited_Date],
            [DT_LienTuc_LopHoc].[TongSoTiet],
            [DT_LienTuc_LopHoc].[Backup01],
            [DT_LienTuc_LopHoc].[Backup02],
            [DT_LienTuc_LopHoc].[Backup03],
            [DT_LienTuc_LopHoc].[Backup04],
            [DT_LienTuc_LopHoc].[Backup05],
            [DT_LienTuc_LopHoc].[Backup06],
			klh.idChuyenKhoa,
			DT_LienTuc_LopHoc.TenCanBoPhuTrachNgoai,
			DT_LienTuc_LopHoc.GioiTinh,		
			cb.NgaySinh,
			bp.Ten as NoiCongTac,
			hv.TenHocVi as TrinhDo,
			cb.GioiTinh as GioiTinhCBT,
		
		IDLopHoc as IDHocVien
			 from DT_LienTuc_LopHoc 
		join DT_LienTuc_KhungLopHoc klh on klh.id=idKhungLopHoc
		 join DIC_CanBo cb on cb.ID=idCanBoPhuTrach
		join DIC_BoPhan bp on bp.ID=cb.IDBoPhan
		join DIC_HocVi hv on cb.IDTrinhDo=hv.ID
		where MaLop=@MaLopHoc
		end


		go

-- hóa đơn thanh toán lớp học làm thẻ và làm chứng chỉ
		create proc [dbo].[HoaDonThanhToanLopHoc_XuanHD]
@IDLopHoc bigint,
@DieuKien int 
as set nocount on
begin
if(@DieuKien =0 )
begin
   select CONVERT(bigint,bl.IDLopHoc) as IDHocVien,lh.MaLop as MaHocVien,case when  lh.TenCanBoPhuTrachNgoai ='' or lh.TenCanBoPhuTrachNgoai is null then cb.HoTen else lh.TenCanBoPhuTrachNgoai end   as HoTenHocVien,case when  lh.TenCanBoPhuTrachNgoai ='' or lh.TenCanBoPhuTrachNgoai is null then  SUBSTRING(Convert(varchar(12),cb.NgaySinh,102),1,4)   else '' end  as NamSinh,case when  lh.GioiTinh ='' or lh.GioiTinh is null then cb.GioiTinh else lh.GioiTinh end as GioiTinh ,
	'' as MaSoThhue,hd.SoHoaDon as SoPhieu, case when bl.HinhThucThu = 0 then N'Tiền mặt' else N'Chuyển khoản hợp đồng' end as HinhThucThu,lh.TenLop as NoiDungThanhToan, N'Khóa học' as DVT,ck.Ten  +'-'+ N'Bệnh Viện Bạch Mai' as TenDonVi
	, case when lh.TenCanBoPhuTrachNgoai ='' or lh.TenCanBoPhuTrachNgoai is null then cb.ChoOHiennay else '' end as DiaChi, 1 as SoLuong,bl.soTien as DonGia, bl.soTien as ThanhTien,sl.TongChiPhi  from BienLai bl 
left join DT_LienTuc_HocVien hv on bl.IDHocVien=hv.id
join HoaDonCT hdct on hdct.IDBienLai=bl.IDBienLai
join HoaDon hd on hd.IDHoaDon=hdct.IDHoaDon
left join DT_LienTuc_LopHoc lh on lh.IDLopHoc=hd.IDLopHoc
left join DIC_CanBo cb on cb.ID=lh.idCanBoPhuTrach
left join DIC_BoPhan bp on bp.ID=cb.IDBoPhan
left join DT_LienTuc_KhungLopHoc klh on klh.id=lh.idKhungLopHoc
left join DIC_ChuyenKhoa ck on ck.ID=klh.idChuyenKhoa
  join (select hd.IDHoaDon,sum(SoTien) as TongChiPhi from HoaDon hd
 join HoaDonCT hdct on hdct.IDHoaDon = hd.IDHoaDon
where IDLopHoc=@IDLopHoc and hd.IDHoaDon in (select top 1 IDHoaDon from HoaDon where IDLopHoc=@IDLopHoc order by IDHoaDon desc) and hdct.IDHoaDonCT <> 32
group by hd.IDHoaDon) sl on sl.IDHoaDon = hd.IDHoaDon
where bl.IDLopHoc=@IDLopHoc  and  hd.IDHoaDon = (select top 1 IDHoaDon from HoaDon where IDLopHoc=@IDLopHoc order by IDHoaDon desc ) and hdct.TrangThai = 0 and hdct.IDHoaDonCT <> 32
end
if(@DieuKien=1)
begin
  select CONVERT(bigint,bl.IDLopHoc) as IDHocVien,lh.MaLop as MaHocVien,case when  lh.TenCanBoPhuTrachNgoai ='' or lh.TenCanBoPhuTrachNgoai is null then cb.HoTen else lh.TenCanBoPhuTrachNgoai end   as HoTenHocVien,case when  lh.TenCanBoPhuTrachNgoai ='' or lh.TenCanBoPhuTrachNgoai is null then  SUBSTRING(Convert(varchar(12),cb.NgaySinh,102),1,4)   else '' end  as NamSinh,case when  lh.GioiTinh ='' or lh.GioiTinh is null then cb.GioiTinh else lh.GioiTinh end as GioiTinh ,
	'' as MaSoThhue,hd.SoHoaDon as SoPhieu, case when bl.HinhThucThu = 0 then N'Tiền mặt' else N'Chuyển khoản hợp đồng' end as HinhThucThu,lh.TenLop as NoiDungThanhToan, N'Khóa học' as DVT,ck.Ten  +'-'+ N'Bệnh Viện Bạch Mai' as TenDonVi
	, case when lh.TenCanBoPhuTrachNgoai ='' or lh.TenCanBoPhuTrachNgoai is null then cb.ChoOHiennay else '' end as DiaChi, 1 as SoLuong,bl.soTien as DonGia, bl.soTien as ThanhTien,sl.TongChiPhi from BienLai bl 
left join DT_LienTuc_HocVien hv on bl.IDHocVien=hv.id
join HoaDonCT hdct on hdct.IDBienLai=bl.IDBienLai
join HoaDon hd on hd.IDHoaDon=hdct.IDHoaDon
left join DT_LienTuc_LopHoc lh on lh.IDLopHoc=hd.IDLopHoc
left join DIC_CanBo cb on cb.ID=lh.idCanBoPhuTrach
left join DIC_BoPhan bp on bp.ID=cb.IDBoPhan
left join DT_LienTuc_KhungLopHoc klh on klh.id=lh.idKhungLopHoc
left join DIC_ChuyenKhoa ck on ck.ID=klh.idChuyenKhoa
  join (select hd.IDHoaDon,sum(SoTien) as TongChiPhi from HoaDon hd
 join HoaDonCT hdct on hdct.IDHoaDon = hd.IDHoaDon
where IDLopHoc=@IDLopHoc and hd.IDHoaDon in (select top 1 IDHoaDon from HoaDon where IDLopHoc=@IDLopHoc order by IDHoaDon desc) and hdct.IDHoaDonCT <> 32
group by hd.IDHoaDon) sl on sl.IDHoaDon = hd.IDHoaDon
where bl.IDLopHoc=@IDLopHoc  and  hd.IDHoaDon = (select top 1 IDHoaDon from HoaDon where IDLopHoc=@IDLopHoc order by IDHoaDon desc ) and hdct.TrangThai = 0 and hdct.IDHoaDonCT <> 32
end
end

go

-- in lại hóa đơn thanh toán
create proc [dbo].[InLaiHoaDonLopHoc]
(
	@IDLopHoc bigint,
	@IDBienLai bigint
)
	
as SET NOCOUNT ON
begin
  select CONVERT(bigint,bl.IDLopHoc) as IDHocVien,lh.MaLop as MaHocVien,case when  lh.TenCanBoPhuTrachNgoai ='' or lh.TenCanBoPhuTrachNgoai is null  then cb.HoTen else lh.TenCanBoPhuTrachNgoai end   as HoTenHocVien,case when  lh.TenCanBoPhuTrachNgoai ='' or lh.TenCanBoPhuTrachNgoai is null then  SUBSTRING(Convert(varchar(12),cb.NgaySinh,102),1,4)   else '' end  as NamSinh,case when  lh.GioiTinh ='' or lh.GioiTinh is null then cb.GioiTinh else lh.GioiTinh end as GioiTinh ,
	'' as MaSoThhue,hd.SoHoaDon as SoPhieu, case when bl.HinhThucThu = 0 then N'Tiền mặt' else N'Chuyển khoản hợp đồng' end as HinhThucThu,lh.TenLop as NoiDungThanhToan, N'Khóa học' as DVT,ck.Ten  +' - '+ N'Bệnh Viện Bạch Mai' as TenDonVi
	, case when lh.TenCanBoPhuTrachNgoai ='' or lh.TenCanBoPhuTrachNgoai is null then cb.ChoOHiennay else '' end as DiaChi, 1 as SoLuong,bl.soTien as DonGia, bl.soTien as ThanhTien,sl.TongChiPhi from BienLai bl 
left join DT_LienTuc_HocVien hv on bl.IDHocVien=hv.id
join HoaDonCT hdct on hdct.IDBienLai=bl.IDBienLai
join HoaDon hd on hd.IDHoaDon=hdct.IDHoaDon
left join DT_LienTuc_LopHoc lh on lh.IDLopHoc=hd.IDLopHoc
left join DIC_CanBo cb on cb.ID=lh.idCanBoPhuTrach
left join DIC_BoPhan bp on bp.ID=cb.IDBoPhan
left join DT_LienTuc_KhungLopHoc klh on klh.id=lh.idKhungLopHoc
left join DIC_ChuyenKhoa ck on ck.ID=klh.idChuyenKhoa
  join (select hd.IDHoaDon,sum(SoTien) as TongChiPhi from HoaDon hd
 join HoaDonCT hdct on hdct.IDHoaDon = hd.IDHoaDon
where IDLopHoc=@IDLopHoc 
group by hd.IDHoaDon) sl on sl.IDHoaDon = hd.IDHoaDon
where bl.IDBienLai=@IDBienLai
end

go

-- thêm các trường vào bảng lớp học

alter table DT_LienTuc_LopHoc
add TenCanBoPhuTrachNgoai nvarchar(50) 
go
alter table DT_LienTuc_LopHoc
add GioiTinh nvarchar(50) 

-- Thêm dữ liệu IDLopHoc vào các bảng
go
 alter table bienlai
add IDLopHoc int 
CONSTRAINT IDLopHoc FOREIGN KEY (IDLopHoc)
 REFERENCES  DT_LienTuc_LopHoc (IDLopHoc);
 go
 alter table hoadon
add IDLopHoc int 
CONSTRAINT FK_HoaDon_IDLopHoc FOREIGN KEY (IDLopHoc)
 REFERENCES  DT_LienTuc_LopHoc (IDLopHoc);
 go
 alter table huybienlai
add IDLopHoc int 
CONSTRAINT FK_HuyBienLai_IDLopHoc FOREIGN KEY (IDLopHoc)
 REFERENCES  DT_LienTuc_LopHoc (IDLopHoc);
 go
 -- thay đổi dữ liêu IDHocVien là not null chuyển thành null ở các bảng
 alter table BienLai
 alter column IDHocVien int null
go
  alter table HuyBienLai
 alter column IDHocVien int null
 go
  alter table HoaDon
 alter column IDHocVien int null
 go

 -- thêm dữ liệu IDLopHoc vào bảng view ww_HoaDon

 ALTER VIEW [dbo].[vw_HoaDon]
AS

select hd.IDHoaDon as HOADON_ID, SoHoaDon as SOHOADON, 1 as LANDONG,IDHocVien as HOCVIEN_ID,IDNguoiXuat as NGUOILAP_ID,NgayHoaDon as NGAYHOADON, sum(hdct.SoTien) as GIATRIHOADON, 1 as DATHANHTOAN,0 as HUYHOADON,hd.IDLopHoc as LOPHOC_ID from HoaDon hd
join HoaDonCT hdct on hdct.IDHoaDon = hd.IDHoaDon
group by hd.IDHoaDon,SoHoaDon,IDHocVien,IDNguoiXuat,NgayHoaDon,IDLopHoc


GO