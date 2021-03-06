USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[UpdateSoLanInBL]    Script Date: 13/01/2018 11:27:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC UpdateSoLanInBL
(
	@IDBienLai BIGINT,
	@SoLanIn TINYINT
)
AS
BEGIN
	UPDATE dbo.BienLai SET SoLanIn = @SoLanIn WHERE IDBienLai = @IDBienLai
END
GO

----------------------------------------

ALTER TABLE dbo.BienLai ALTER COLUMN SoLanIn TINYINT
GO

----------------------------------------

ALTER proc [dbo].[BIenLaiTamThu_Get]
@IDHocVien bigint
as SET NOCOUNT ON
select 
	IDBienLai,
	MaBienLai,
	SoLan,
	SoTien,
	Convert(Date,NgayThu) as NgayThu,
	TenNguoiThu as NguoiThu,
	IDNguoiThu,
	Huy,
	HinhThucThu,
	XuatHD,
	SoLanIn
 from BienLai where idHocVien = @idHocVien
 GO

 -------------------------

 UPDATE dbo.BienLai SET SoLanIn = 1
 GO
 
 