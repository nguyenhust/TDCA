USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[BaoCaoHuyBienLai_ThucTe]    Script Date: 18/04/2018 22:12:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BaoCaoHuyBienLai_ThucTe]
(
@TuNgay datetime,
@DenNgay datetime,
@DieuKien int,
@IDNguoiDung bigint
)
as
 set nocount on
 begin
declare @sql nvarchar(max)
declare @SqlWhere nvarchar(max)
DECLARE @strTuNgay varchar(10)
	DECLARE @strDenNgay varchar(19)
	SET @strTuNgay = Convert(varchar(10),@TuNgay,101)
	SET @strDenNgay = Convert(varchar(10),@DenNgay,101)+ ' 23:59:00.000'

set @sql=' select t2.NgayThu,t2.NgayHuy,t2.HoTen as TenHocVien,t2.MaHocVien,t2.SoHoaDon,t2.SoTien ,t2.LyDoHuy from
 (select bl.NgayThu,hbl.NgayHuy,hv.HoTen,hv.MaHocVien,hd.SoHoaDon,hbl.SoTien,hbl.LyDoHuy  from BienLai bl
 left join HuyBienLai hbl on bl.IDBienLai=hbl.IDBienLai
left join DT_LienTuc_HocVien hv on hv.id=bl.IDHocVien
left join HoaDonCT hdct on hdct.IDBienLai=bl.IDBienLai
left join HoaDon hd on hd.IDHoaDon=hdct.IDHoaDon  '
--hhhhhhhhhhhhhhhhh
if(@DieuKien=1)
set @SqlWhere= 'where (hbl.NgayHuy between '''+@strTuNgay+''' and '''+@strDenNgay+''' and hbl.IDNguoiHuy='+CONVERT(nvarchar(10),@IDNguoiDung)+')) t2';

if(@DieuKien=2)
begin
set @SqlWhere='where (hbl.NgayHuy between '''+@strTuNgay+''' and '''+@strDenNgay+''')) t2';
end
set @sql=@sql+@SqlWhere
exec (@sql)
print (@sql)
end


