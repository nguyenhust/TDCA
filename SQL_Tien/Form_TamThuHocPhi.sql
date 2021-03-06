USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[GetSoHoaDon]    Script Date: 27/12/2017 9:30:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- create proc Lấy số hóa đơn và trạng thái in chuyển đổi

CREATE PROC GetSoHoaDon
(
	@IDBienLai BIGINT
)
AS
BEGIN
	SELECT hd.SoHoaDon+'-'+hd.InChuyenDoi FROM dbo.BienLai bl 
JOIN dbo.HoaDonCT hdct ON bl.IDBienLai = hdct.IDBienLai 
JOIN dbo.HoaDon hd ON hd.IDHoaDon = hdct.IDHoaDon WHERE bl.IDBienLai = @IDBienLai
END

GO
-- create proc Get UserName

CREATE PROC Get_UserName
(@IDNguoiDung BIGINT)
AS
BEGIN
	SELECT TenDangNhap FROM dbo.ADM_NguoiDung WHERE IDNguoiDung = @IDNguoiDung
END
GO

-- create proc Update trạng thái in chuyển đổi

CREATE PROC UpdateStatusPrintHD
(
	@SoHoaDon VARCHAR(30)
)
AS
BEGIN
	UPDATE dbo.HoaDon SET InChuyenDoi = 'T' WHERE SoHoaDon = @SoHoaDon
END
GO

