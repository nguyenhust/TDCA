USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[SeachHocVien_Get]    Script Date: 19/04/2018 10:08:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  proc [dbo].[SeachHocVien_Get]
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


set @Sql= 'select a.HoTen,a.MaHocVien,a.HinhThucHoc,a.NoiDungDaoTao,a.ChuyenKhoa,a.SoTien
 from(select hv.HoTen,hv.MaHocVien,hv.HinhThucHoc,hv.NoiDungDaoTao,ck.Ten as ChuyenKhoa,bl.soTien as SoTien,hbl.SoTien as TienDaHuy 
 from DT_LienTuc_HocVien hv
 left  join BienLai bl on bl.IDHocVien=hv.id
 left  join HuyBienLai hbl on hbl.IDBienLai=bl.IDBienLai
 left  join DT_LienTuc_KhungLopHoc kl on kl.id=hv.idKhungLopHoc
 left  join DIC_ChuyenKhoa ck on ck.ID=kl.idChuyenKhoa   '
 -- lấy theo mã học viên
 if @TimKiem = 0
 set @SqlWhere='where (hv.MaHocVien='''+@MaHocVien+''') )a';
 --tìm kiếm theo ngày
 if @TimKiem = 2
 set @SqlWhere='WHERE (hv.NgayBatDau between '''+@strTuNgay+''' and '''+@strDenNgay+'''))a';
-- tòm kiếm tất cả
 if(@TimKiem=1)
 begin
 if(@TrangThaiDHP=0)
 begin
 IF(@IDChuyenKhoa IS NOT NULL and @LoaiHinhDT=0 and @IDKhungLop='')
 set @SqlWhere= 'where ck.ID='+CONVERT(nvarchar(10),@IDChuyenKhoa)+' and (hv.NgayBatDau between '''+@strTuNgay+''' and '''+@strDenNgay+''' and bl.IDBienLai is null or (bl.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''' and bl.IDBienLai is not null and bl.Huy='+CONVERT(nvarchar(1),0)+' or bl.Huy='+CONVERT(nvarchar(1),1)+'))) a';

 IF(@IDChuyenKhoa IS NOT NULL and @LoaiHinhDT=1 and @IDKhungLop='')
  set @SqlWhere= 'where ck.ID='+CONVERT(nvarchar(10),@IDChuyenKhoa)+' and hv.HinhThucHoc like N''%'+@HinhThucHoc+'%'' and (hv.NgayBatDau between '''+@strTuNgay+''' and '''+@strDenNgay+''' and bl.IDBienLai is null or (bl.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''' and  bl.IDBienLai is not null and bl.Huy='+CONVERT(nvarchar(1),0)+' or bl.Huy='+CONVERT(nvarchar(1),1)+'))) a';

  IF(@IDChuyenKhoa IS NOT NULL and @LoaiHinhDT=2 and @IDKhungLop='')
  set @SqlWhere= 'where ck.ID='+CONVERT(nvarchar(10),@IDChuyenKhoa)+' and hv.HinhThucHoc like N''%'+@HinhThucHoc+'%'' and (hv.NgayBatDau between '''+@strTuNgay+''' and '''+@strDenNgay+''' and bl.IDBienLai is null or (bl.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''' and bl.IDBienLai is not null and bl.Huy='+CONVERT(nvarchar(1),0)+' or bl.Huy='+CONVERT(nvarchar(1),1)+'))) a';

  IF(@IDChuyenKhoa IS NOT NULL and @LoaiHinhDT=0 and @IDKhungLop<>'')
 set @SqlWhere= 'where ck.ID='+CONVERT(nvarchar(10),@IDChuyenKhoa)+' and kl.id='+CONVERT(nvarchar(10),@IDKhungLop)+' and (hv.NgayBatDau between '''+@strTuNgay+''' and '''+@strDenNgay+''' and bl.IDBienLai is null or (bl.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''' and  bl.IDBienLai is not null and bl.Huy='+CONVERT(nvarchar(1),0)+' or bl.Huy='+CONVERT(nvarchar(1),1)+'))) a';

 IF(@IDChuyenKhoa IS NOT NULL and @LoaiHinhDT=1 and @IDKhungLop<>'')
  set @SqlWhere= 'where ck.ID='+CONVERT(nvarchar(10),@IDChuyenKhoa)+' and kl.id='+CONVERT(nvarchar(10),@IDKhungLop)+'  and hv.HinhThucHoc like N''%'+@HinhThucHoc+'%'' and (hv.NgayBatDau between '''+@strTuNgay+''' and '''+@strDenNgay+''' and bl.IDBienLai is null or (bl.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''' and  bl.IDBienLai is not null and bl.Huy='+CONVERT(nvarchar(1),0)+' or bl.Huy='+CONVERT(nvarchar(1),1)+'))) a';

  IF(@IDChuyenKhoa IS NOT NULL and @LoaiHinhDT=2 and @IDKhungLop<>'')
  set @SqlWhere= 'where ck.ID='+CONVERT(nvarchar(10),@IDChuyenKhoa)+' and kl.id='+CONVERT(nvarchar(10),@IDKhungLop)+' and hv.HinhThucHoc like N''%'+@HinhThucHoc+'%'' and (hv.NgayBatDau between '''+@strTuNgay+''' and '''+@strDenNgay+''' and bl.IDBienLai is null or (bl.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''' and bl.IDBienLai is not null  and bl.Huy='+CONVERT(nvarchar(1),0)+' or bl.Huy='+CONVERT(nvarchar(1),1)+'))) a';
 
 end

 if @TrangThaiDHP =1
 begin
  IF(@IDChuyenKhoa IS NOT NULL and @LoaiHinhDT=0 and @IDKhungLop='')
 set @SqlWhere= 'where ck.ID='+CONVERT(nvarchar(10),@IDChuyenKhoa)+' and (hv.NgayBatDau between '''+@strTuNgay+''' and '''+@strDenNgay+''' and bl.IDBienLai is null or (bl.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''' and bl.IDBienLai is  null and  bl.Huy='+CONVERT(nvarchar(1),1)+'))) a';

 IF(@IDChuyenKhoa IS NOT NULL and @LoaiHinhDT=1 and @IDKhungLop='')
  set @SqlWhere= 'where ck.ID='+CONVERT(nvarchar(10),@IDChuyenKhoa)+' and hv.HinhThucHoc like N''%'+@HinhThucHoc+'%'' and (hv.NgayBatDau between '''+@strTuNgay+''' and '''+@strDenNgay+''' and bl.IDBienLai is null or (bl.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''' and  bl.IDBienLai is  null and bl.Huy='+CONVERT(nvarchar(1),1)+'))) a';
  

  IF(@IDChuyenKhoa IS NOT NULL and @LoaiHinhDT=2 and @IDKhungLop='')
  set @SqlWhere= 'where ck.ID='+CONVERT(nvarchar(10),@IDChuyenKhoa)+' and hv.HinhThucHoc like N''%'+@HinhThucHoc+'%'' and (hv.NgayBatDau between '''+@strTuNgay+''' and '''+@strDenNgay+''' and bl.IDBienLai is null or (bl.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''' and bl.IDBienLai is  null and  bl.Huy='+CONVERT(nvarchar(1),1)+'))) a';

  IF(@IDChuyenKhoa IS NOT NULL and @LoaiHinhDT=0 and @IDKhungLop<>'')
 set @SqlWhere= 'where ck.ID='+CONVERT(nvarchar(10),@IDChuyenKhoa)+' and kl.id='+CONVERT(nvarchar(10),@IDKhungLop)+' and (hv.NgayBatDau between '''+@strTuNgay+''' and '''+@strDenNgay+''' and bl.IDBienLai is null or (bl.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''' and  bl.IDBienLai is  null and  bl.Huy='+CONVERT(nvarchar(1),1)+'))) a';

 IF(@IDChuyenKhoa IS NOT NULL and @LoaiHinhDT=1 and @IDKhungLop<>'')
  set @SqlWhere= 'where ck.ID='+CONVERT(nvarchar(10),@IDChuyenKhoa)+' and kl.id='+CONVERT(nvarchar(10),@IDKhungLop)+'  and hv.HinhThucHoc like N''%'+@HinhThucHoc+'%'' and (hv.NgayBatDau between '''+@strTuNgay+''' and '''+@strDenNgay+''' and bl.IDBienLai is null or (bl.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''' and  bl.IDBienLai is  null and  bl.Huy='+CONVERT(nvarchar(1),1)+'))) a';

  IF(@IDChuyenKhoa IS NOT NULL and @LoaiHinhDT=2 and @IDKhungLop<>'')
  set @SqlWhere= 'where ck.ID='+CONVERT(nvarchar(10),@IDChuyenKhoa)+' and kl.id='+CONVERT(nvarchar(10),@IDKhungLop)+' and hv.HinhThucHoc like N''%'+@HinhThucHoc+'%'' and (hv.NgayBatDau between '''+@strTuNgay+''' and '''+@strDenNgay+''' and bl.IDBienLai is null or (bl.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''' and bl.IDBienLai is  null  and bl.Huy='+CONVERT(nvarchar(1),1)+'))) a';
 end

 if(@TrangThaiDHP=2)
 begin
  IF(@IDChuyenKhoa IS NOT NULL and @LoaiHinhDT=0 and @IDKhungLop='')
 set @SqlWhere= 'where ck.ID='+CONVERT(nvarchar(10),@IDChuyenKhoa)+' and (hv.NgayBatDau between '''+@strTuNgay+''' and '''+@strDenNgay+''' and bl.IDBienLai is not null or (bl.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''' and bl.IDBienLai is not null and  bl.Huy='+CONVERT(nvarchar(1),0)+'))) a';

 IF(@IDChuyenKhoa IS NOT NULL and @LoaiHinhDT=1 and @IDKhungLop='')
  set @SqlWhere= 'where ck.ID='+CONVERT(nvarchar(10),@IDChuyenKhoa)+' and hv.HinhThucHoc like N''%'+@HinhThucHoc+'%'' and (hv.NgayBatDau between '''+@strTuNgay+''' and '''+@strDenNgay+''' and bl.IDBienLai is not null or (bl.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''' and  bl.IDBienLai is not null and bl.Huy='+CONVERT(nvarchar(1),0)+'))) a';

  IF(@IDChuyenKhoa IS NOT NULL and @LoaiHinhDT=2 and @IDKhungLop='')
  set @SqlWhere= 'where ck.ID='+CONVERT(nvarchar(10),@IDChuyenKhoa)+' and hv.HinhThucHoc like N''%'+@HinhThucHoc+'%'' and (hv.NgayBatDau between '''+@strTuNgay+''' and '''+@strDenNgay+''' and bl.IDBienLai is not null or (bl.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''' and bl.IDBienLai is not null and  bl.Huy='+CONVERT(nvarchar(1),0)+'))) a';

  IF(@IDChuyenKhoa IS NOT NULL and @LoaiHinhDT=0 and @IDKhungLop<>'')
 set @SqlWhere= 'where ck.ID='+CONVERT(nvarchar(10),@IDChuyenKhoa)+' and kl.id='+CONVERT(nvarchar(10),@IDKhungLop)+' and (hv.NgayBatDau between '''+@strTuNgay+''' and '''+@strDenNgay+''' and bl.IDBienLai is  not null or (bl.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''' and  bl.IDBienLai is not null and  bl.Huy='+CONVERT(nvarchar(1),0)+'))) a';

 IF(@IDChuyenKhoa IS NOT NULL and @LoaiHinhDT=1 and @IDKhungLop<>'')
  set @SqlWhere= 'where ck.ID='+CONVERT(nvarchar(10),@IDChuyenKhoa)+' and kl.id='+CONVERT(nvarchar(10),@IDKhungLop)+'  and hv.HinhThucHoc like N''%'+@HinhThucHoc+'%'' and (hv.NgayBatDau between '''+@strTuNgay+''' and '''+@strDenNgay+''' and bl.IDBienLai is not null or (bl.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''' and  bl.IDBienLai is not null and  bl.Huy='+CONVERT(nvarchar(1),0)+'))) a';

  IF(@IDChuyenKhoa IS NOT NULL and @LoaiHinhDT=2 and @IDKhungLop<>'')
  set @SqlWhere= 'where ck.ID='+CONVERT(nvarchar(10),@IDChuyenKhoa)+' and kl.id='+CONVERT(nvarchar(10),@IDKhungLop)+' and hv.HinhThucHoc like N''%'+@HinhThucHoc+'%'' and (hv.NgayBatDau between '''+@strTuNgay+''' and '''+@strDenNgay+''' and bl.IDBienLai is not null or (bl.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''' and bl.IDBienLai is not null  and bl.Huy='+CONVERT(nvarchar(1),0)+'))) a';
 end
 end
 set @Sql=@Sql +@SqlWhere;
 exec (@Sql)
 print  (@Sql)

end

