USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[BIenLaiTamThu_Get]    Script Date: 26/04/2018 21:54:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

----------------------------------------

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
	hd.SoHoaDon
 from BienLai bl
  left join HoaDonCT hdct on hdct.IDBienLai=bl.IDBienLai
 left join HoaDon hd on hd.IDHoaDon=hdct.IDHoaDon
 where bl.IDHocVien = @idHocVien
