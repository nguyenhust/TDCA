USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[SeachHocVien_Get]    Script Date: 18/04/2018 21:13:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- sửa thông tin thu học viên
ALTER PROC [dbo].[BC_ThuHocPhiHocVien]
(
	@IDNguoiDung BIGINT,
	@DieuKien INT,
	@TuNgay DATETIME,
	@DenNgay DATETIME
)
AS
DECLARE @sql VARCHAR(8000)
BEGIN
	IF @DieuKien = 1
		SELECT 
			NgayThu = Convert(Datetime,bl.NgayThu),
			HoTen = hv.HoTen,
			MaHocVien = hv.MaHocVien,
			HinhThucHoc = hv.HinhThucHoc,
			MaBienLai = bl.MaBienLai,
			SoTien = Convert(int,bl.soTien),
			GhiChu = '',
			hd.SoHoaDon,
			0 as Huy,
			hbl.SoTien as SoTienHuy
			FROM BienLai BL
			left join HuyBienLai hbl on bl.IDBienLai=hbl.IDBienLai
			LEFT JOIN DT_LienTuc_HocVien HV ON HV.id=bl.IDHocVien
			 LEFT  join HoaDonCT HDCT ON HDCT.IDBienLai=BL.IDBienLai
		   LEFT JOIN HoaDon HD ON HD.IDHoaDon=HDCT.IDHoaDon
			WHERE (bl.NgayThu between @TuNgay AND @DenNgay) AND bl.IDNguoiThu=@IDNguoiDung 

			union   
			SELECT 
			NgayThu = Convert(Datetime,bl.NgayThu),
			HoTen = hv.HoTen,
			MaHocVien = hv.MaHocVien,
			HinhThucHoc = hv.HinhThucHoc,
			MaBienLai = bl.MaBienLai,
			hbl.SoTien as SoTienHuy,
			
			GhiChu = '',
			hd.SoHoaDon,
		   1 as Huy,
		   bl.soTien as SoTien
			FROM HuyBienLai hbl
		   left JOIN dbo.BienLai bl ON hbl.IDBienLai=bl.IDBienLai
		   left join DT_LienTuc_HocVien hv on hv.id=bl.IDHocVien
		   LEFT  join HoaDonCT HDCT ON HDCT.IDBienLai=BL.IDBienLai
		   LEFT JOIN HoaDon HD ON HD.IDHoaDon=HDCT.IDHoaDon
			

			WHERE (bl.NgayThu between @TuNgay AND @DenNgay) AND bl.IDNguoiThu=@IDNguoiDung 
		    order by Huy asc
		

	ELSE
		SELECT 
			NgayThu = Convert(Datetime,bl.NgayThu),
			HoTen = hv.HoTen,
			MaHocVien = hv.MaHocVien,
			HinhThucHoc = hv.HinhThucHoc,
			MaBienLai = bl.MaBienLai,
			SoTien = Convert(int,bl.soTien),
			GhiChu = '',
			hd.SoHoaDon,			
			0 as Huy,
			hbl.SoTien as SoTienHuy
			FROM BienLai BL
			left join HuyBienLai hbl on bl.IDBienLai=hbl.IDBienLai
			LEFT JOIN DT_LienTuc_HocVien HV ON HV.id=BL.IDHocVien
			 LEFT  join HoaDonCT HDCT ON HDCT.IDBienLai=BL.IDBienLai
		     LEFT JOIN HoaDon HD ON HD.IDHoaDon=HDCT.IDHoaDon
			 WHERE bl.NgayThu between @TuNgay and @DenNgay

			union 
			SELECT 
			NgayThu = Convert(Datetime,bl.NgayThu),
			HoTen = hv.HoTen,
			MaHocVien = hv.MaHocVien,
			HinhThucHoc = hv.HinhThucHoc,
			MaBienLai = bl.MaBienLai,
			hbl.SoTien as SoTienHuy,
			GhiChu = '',
			hd.SoHoaDon,
		    1 as Huy,
			bl.soTien as SoTien
			FROM HuyBienLai hbl
		   left JOIN dbo.BienLai bl ON hbl.IDBienLai=bl.IDBienLai
		   left join DT_LienTuc_HocVien hv on hv.id=bl.IDHocVien
		    LEFT  join HoaDonCT HDCT ON HDCT.IDBienLai=BL.IDBienLai
		   LEFT JOIN HoaDon HD ON HD.IDHoaDon=HDCT.IDHoaDon
			 WHERE bl.NgayThu between @TuNgay and @DenNgay
			 order by Huy asc

	PRINT (@sql)
	EXEC (@sql)
END


