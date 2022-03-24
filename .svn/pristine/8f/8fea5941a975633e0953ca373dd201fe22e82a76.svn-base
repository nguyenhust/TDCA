USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[BienLai_Get]    Script Date: 26/04/2018 21:00:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BienLai_Get]
@IDHocVien bigint
as SET NOCOUNT ON
select 
CONVERT(int,bl.IDBienLai) as IDBienLai,
	MaBienLai,
	SoLan,
	bl.SoTien,
	Convert(Date,NgayThu) as NgayThu,
	TenNguoiThu as NguoiThu,
	IDNguoiThu,
	Huy,
	HinhThucThu,
	SoLanIn,
	hd.SoHoaDon,
	CONVERT(int,bl.IDHocVien) as IDHocVien

 from BienLai bl
 left join HoaDonCT hdct on hdct.IDBienLai=bl.IDBienLai
 left join HoaDon hd on hd.IDHoaDon=hdct.IDHoaDon
  where bl.IDHocVien = @idHocVien