﻿USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[SeachHocVien_Get]    Script Date: 17/05/2018 15:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER  proc [dbo].[SeachHocVien_Get]
(
@TimKiem  int,
@TrangThaiDHP int,
@MaHocVien nvarchar(50),
@TuNgay datetime,
@DenNgay datetime ,
@IDChuyenKhoa int,
@IDKhungLop int ,
@LoaiHinhDT int
) 
as set nocount on
begin
declare @Sql nvarchar(max)
declare @SqlWhere nvarchar(max)
DECLARE @strTuNgay varchar(10)
DECLARE @strDenNgay varchar(19)
DECLARE @HinhThucHoc NVARCHAR(50)
declare @Huy int
if(@LoaiHinhDT=1)
set @Huy=1
else
set @Huy=0
if(@LoaiHinhDT=1)
set @HinhThucHoc=N'Kèm cặp'
else
set @HinhThucHoc=N'theo lớp'

SET @strTuNgay = Convert(varchar(10),@TuNgay,102)
	SET @strDenNgay = Convert(varchar(10),@DenNgay,102)+ ' 23:59:00.000'


set @Sql= 'select   NgayBatDau=Convert(varchar(10),a.NgayThu,103),a.MaBienLai,a.HinhThucHoc,a.MaHocVien,a.HoTen,a.NoiDung,a.ChuyenKhoa,a.SoTien
 from(select bl.NgayThu,bl.MaBienLai,hv.HinhThucHoc,hv.MaHocVien,hv.HoTen,hv.NoiDungDaoTao as NoiDung,ck.Ten as ChuyenKhoa,bl.soTien as SoTien,hbl.SoTien as TienDaHuy 
 from DT_LienTuc_HocVien hv
 left  join BienLai bl on bl.IDHocVien=hv.id
 left  join HuyBienLai hbl on hbl.IDBienLai=bl.IDBienLai
 left  join DT_LienTuc_KhungLopHoc kl on kl.id=hv.idKhungLopHoc
 left  join DIC_ChuyenKhoa ck on ck.ID=kl.idChuyenKhoa  '
 -- lấy theo mã học viên
 if @TimKiem = 0
 set @SqlWhere='where (hv.MaHocVien=N'''+@MaHocVien+''') )a';
 --tìm kiếm theo ngày
 if @TimKiem = 2
 set @SqlWhere='WHERE (bl.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+'''))a';
-- tòm kiếm tất cả
 if(@TimKiem=1)
 begin
 if(@TrangThaiDHP=0)
 begin
 IF(@IDChuyenKhoa IS NOT NULL and @LoaiHinhDT=0 and @IDKhungLop='')
 set @SqlWhere= 'where ck.ID='+CONVERT(nvarchar(10),@IDChuyenKhoa)+' and  (bl.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''' and bl.IDBienLai is not null and bl.Huy='+CONVERT(nvarchar(1),0)+' or bl.Huy='+CONVERT(nvarchar(1),1)+')) a';

 IF(@IDChuyenKhoa IS NOT NULL and @LoaiHinhDT=1 and @IDKhungLop='')
  set @SqlWhere= 'where ck.ID='+CONVERT(nvarchar(10),@IDChuyenKhoa)+' and hv.HinhThucHoc like N''%'+@HinhThucHoc+'%'' and  (bl.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''' and  bl.IDBienLai is not null and bl.Huy='+CONVERT(nvarchar(1),0)+' or bl.Huy='+CONVERT(nvarchar(1),1)+')) a';

  IF(@IDChuyenKhoa IS NOT NULL and @LoaiHinhDT=2 and @IDKhungLop='')
  set @SqlWhere= 'where ck.ID='+CONVERT(nvarchar(10),@IDChuyenKhoa)+' and hv.HinhThucHoc like N''%'+@HinhThucHoc+'%'' and  (bl.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''' and bl.IDBienLai is not null and bl.Huy='+CONVERT(nvarchar(1),0)+' or bl.Huy='+CONVERT(nvarchar(1),1)+')) a';

  IF(@IDChuyenKhoa IS NOT NULL and @LoaiHinhDT=0 and @IDKhungLop<>'')
 set @SqlWhere= 'where ck.ID='+CONVERT(nvarchar(10),@IDChuyenKhoa)+' and kl.id='+CONVERT(nvarchar(10),@IDKhungLop)+' and  (bl.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''' and  bl.IDBienLai is not null and bl.Huy='+CONVERT(nvarchar(1),0)+' or bl.Huy='+CONVERT(nvarchar(1),1)+')) a';

 IF(@IDChuyenKhoa IS NOT NULL and @LoaiHinhDT=1 and @IDKhungLop<>'')
  set @SqlWhere= 'where ck.ID='+CONVERT(nvarchar(10),@IDChuyenKhoa)+' and kl.id='+CONVERT(nvarchar(10),@IDKhungLop)+'  and hv.HinhThucHoc like N''%'+@HinhThucHoc+'%'' and  (bl.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''' and  bl.IDBienLai is not null and bl.Huy='+CONVERT(nvarchar(1),0)+' or bl.Huy='+CONVERT(nvarchar(1),1)+')) a';

  IF(@IDChuyenKhoa IS NOT NULL and @LoaiHinhDT=2 and @IDKhungLop<>'')
  set @SqlWhere= 'where ck.ID='+CONVERT(nvarchar(10),@IDChuyenKhoa)+' and kl.id='+CONVERT(nvarchar(10),@IDKhungLop)+' and hv.HinhThucHoc like N''%'+@HinhThucHoc+'%'' and  (bl.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''' and bl.IDBienLai is not null  and bl.Huy='+CONVERT(nvarchar(1),0)+' or bl.Huy='+CONVERT(nvarchar(1),1)+')) a';
 
 end

 if @TrangThaiDHP =1
 begin
  IF(@IDChuyenKhoa IS NOT NULL and @LoaiHinhDT=0 and @IDKhungLop='')
 set @SqlWhere= 'where ck.ID='+CONVERT(nvarchar(10),@IDChuyenKhoa)+' and  (bl.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''' and bl.IDBienLai is  null and  bl.Huy='+CONVERT(nvarchar(1),1)+')) a';

 IF(@IDChuyenKhoa IS NOT NULL and @LoaiHinhDT=1 and @IDKhungLop='')
  set @SqlWhere= 'where ck.ID='+CONVERT(nvarchar(10),@IDChuyenKhoa)+' and hv.HinhThucHoc like N''%'+@HinhThucHoc+'%'' and  (bl.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''' and  bl.IDBienLai is  null and bl.Huy='+CONVERT(nvarchar(1),1)+')) a';
  

  IF(@IDChuyenKhoa IS NOT NULL and @LoaiHinhDT=2 and @IDKhungLop='')
  set @SqlWhere= 'where ck.ID='+CONVERT(nvarchar(10),@IDChuyenKhoa)+' and hv.HinhThucHoc like N''%'+@HinhThucHoc+'%'' and  (bl.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''' and bl.IDBienLai is  null and  bl.Huy='+CONVERT(nvarchar(1),1)+')) a';

  IF(@IDChuyenKhoa IS NOT NULL and @LoaiHinhDT=0 and @IDKhungLop<>'')
 set @SqlWhere= 'where ck.ID='+CONVERT(nvarchar(10),@IDChuyenKhoa)+' and kl.id='+CONVERT(nvarchar(10),@IDKhungLop)+' and  (bl.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''' and  bl.IDBienLai is  null and  bl.Huy='+CONVERT(nvarchar(1),1)+')) a';

 IF(@IDChuyenKhoa IS NOT NULL and @LoaiHinhDT=1 and @IDKhungLop<>'')
  set @SqlWhere= 'where ck.ID='+CONVERT(nvarchar(10),@IDChuyenKhoa)+' and kl.id='+CONVERT(nvarchar(10),@IDKhungLop)+'  and hv.HinhThucHoc like N''%'+@HinhThucHoc+'%'' and (bl.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''' and  bl.IDBienLai is  null and  bl.Huy='+CONVERT(nvarchar(1),1)+')) a';

  IF(@IDChuyenKhoa IS NOT NULL and @LoaiHinhDT=2 and @IDKhungLop<>'')
  set @SqlWhere= 'where ck.ID='+CONVERT(nvarchar(10),@IDChuyenKhoa)+' and kl.id='+CONVERT(nvarchar(10),@IDKhungLop)+' and hv.HinhThucHoc like N''%'+@HinhThucHoc+'%'' and (bl.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''' and bl.IDBienLai is  null  and bl.Huy='+CONVERT(nvarchar(1),1)+')) a';
 end

 if(@TrangThaiDHP=2)
begin
  IF(@IDChuyenKhoa IS NOT NULL and @LoaiHinhDT=0 and @IDKhungLop='')
 set @SqlWhere= 'where ck.ID='+CONVERT(nvarchar(10),@IDChuyenKhoa)+' and  (bl.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''' and bl.IDBienLai is not null and  bl.Huy='+CONVERT(nvarchar(1),0)+')) a';

 IF(@IDChuyenKhoa IS NOT NULL and @LoaiHinhDT=1 and @IDKhungLop='')
  set @SqlWhere= 'where ck.ID='+CONVERT(nvarchar(10),@IDChuyenKhoa)+' and hv.HinhThucHoc like N''%'+@HinhThucHoc+'%'' and  (bl.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''' and  bl.IDBienLai is not null and bl.Huy='+CONVERT(nvarchar(1),0)+')) a';

  IF(@IDChuyenKhoa IS NOT NULL and @LoaiHinhDT=2 and @IDKhungLop='')
  set @SqlWhere= 'where ck.ID='+CONVERT(nvarchar(10),@IDChuyenKhoa)+' and hv.HinhThucHoc like N''%'+@HinhThucHoc+'%'' and  (bl.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''' and bl.IDBienLai is not null and  bl.Huy='+CONVERT(nvarchar(1),0)+')) a';

  IF(@IDChuyenKhoa IS NOT NULL and @LoaiHinhDT=0 and @IDKhungLop<>'')
 set @SqlWhere= 'where ck.ID='+CONVERT(nvarchar(10),@IDChuyenKhoa)+' and kl.id='+CONVERT(nvarchar(10),@IDKhungLop)+' and  (bl.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''' and  bl.IDBienLai is not null and  bl.Huy='+CONVERT(nvarchar(1),0)+')) a';

 IF(@IDChuyenKhoa IS NOT NULL and @LoaiHinhDT=1 and @IDKhungLop<>'')
  set @SqlWhere= 'where ck.ID='+CONVERT(nvarchar(10),@IDChuyenKhoa)+' and kl.id='+CONVERT(nvarchar(10),@IDKhungLop)+'  and hv.HinhThucHoc like N''%'+@HinhThucHoc+'%'' and  (bl.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''' and  bl.IDBienLai is not null and  bl.Huy='+CONVERT(nvarchar(1),0)+')) a';

  IF(@IDChuyenKhoa IS NOT NULL and @LoaiHinhDT=2 and @IDKhungLop<>'')
  set @SqlWhere= 'where ck.ID='+CONVERT(nvarchar(10),@IDChuyenKhoa)+' and kl.id='+CONVERT(nvarchar(10),@IDKhungLop)+' and hv.HinhThucHoc like N''%'+@HinhThucHoc+'%'' and  (bl.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''' and bl.IDBienLai is not null  and bl.Huy='+CONVERT(nvarchar(1),0)+')) a';
 end
 end
 set @Sql=@Sql +@SqlWhere;
 exec (@Sql)
 print  (@Sql)

end

go

ALTER proc [dbo].[BIenLaiTamThu_Get]
@IDHocVien bigint
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
 where bl.IDHocVien = @idHocVien

 go


  ALTER proc [dbo].[BienLaiTamThu_ins]
@idHocVien bigint,
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
@LoaiPhieu tinyint
as  SET NOCOUNT ON
if(exists(select 1 from BienLai where mabienlai = @Mabienlai))
begin
	raiserror ('Mã biên lai [%s] này đã tồn tại, Bạn hãy kiểm tra lại!',16,1,@mabienlai)
	return
end
declare @LoaiPhieu1 nvarchar(50)
set @LoaiPhieu1=CONVERT(nvarchar(50),@LoaiPhieu)
if(@LoaiPhieu=0)
set @LoaiPhieu1=N'Phiếu thu học phí'
if(@LoaiPhieu=1)
set @LoaiPhieu1=N'PDNTT làm thẻ'
if(@LoaiPhieu=2)
set @LoaiPhieu1=N'PDNTT làm chứng chỉ'

declare @IDBenhNhan bigint, @strNgayKyQuy varchar(10)
set @strNgayKyQuy = convert(varchar(10), @NgayThu, 103) 
set @solan = (select count(*) + 1 from BienLai kq where kq.IDHocVien = @idHocVien)
insert into BienLai(IDHocVien,Mabienlai,Solan,Sotien,NgayThu, IDNguoiThu,TenNguoiDong,TenNguoiThu, HinhThucThu,XuatHD,SoLanIn,LoaiPhieu)
values(@idHocVien,@Mabienlai,@Solan,@Sotien,@Ngaythu, @IDNguoiThu,@NguoiDong,@NguoiThu, @HinhThucThu,0,1,@LoaiPhieu)


set @IDBienLai = SCOPE_IDENTITY()
update BienLai set Huy=0 where IDBienLai=@IDBienLai

go

	ALTER proc [dbo].[BienLaiTamThu_Gets]
@IDBienLai bigint
as SET NOCOUNT ON
select 
	bl.IDBienLai,
	bl.MaBienLai,
	Convert(bigint,bl.IDHocVien) as IDHocVien,
	bl.SoLan,
	--Convert(decimal,bl.soTien) as SoTien,
	bl.soTien,
	Convert(Date,bl.NgayThu) as NgayThu,
	bl.TenNguoiThu,
	bl.IDNguoiThu,
	bl.TenNguoiDong,
	bl.HinhThucThu,
	bl.XuatHD,
	bl.Huy,
	hbl.IDPhieuHuy,
	bl.LoaiPhieu
	
 from BienLai bl
left join HuyBienLai hbl on hbl.IDBienLai=bl.IDBienLai


 WHERE bl.IDBienLai = @IDBienLai

go