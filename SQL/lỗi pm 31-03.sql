USE [MDCT]
GO

/****** Object:  View [dbo].[DIC_View_CanBo_Coll_getWithCanBoTypeIncludeIDUser]    Script Date: 31/03/2015 15:10:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[DIC_View_CanBo_Coll_getWithCanBoTypeIncludeIDUser]
AS
    SELECT  dbo.DIC_CanBo.ID ,
            dbo.DIC_CanBo.HoTen ,
            dbo.DIC_CanBo.GioiTinh ,
            dbo.DIC_CanBo.NgaySinh ,
            dbo.DIC_CanBo.IDTinh ,
            dbo.DIC_CanBo.ChoOHiennay ,
            dbo.DIC_CanBo.QuocGia ,
            dbo.DIC_CanBo.NgayVaoDang ,
            dbo.DIC_CanBo.IDTrinhDo ,
            dbo.DIC_CanBo.IDCoQuan ,
            dbo.DIC_CanBo.IDChucVu ,
            dbo.DIC_CanBo.QTDaoTao ,
            dbo.DIC_CanBo.QTCongTac ,
            dbo.DIC_CanBo.KinhNghiemNN ,
            dbo.DIC_CanBo.NghienCuuTGia ,
            dbo.DIC_CanBo.NgoaiNguTinHoc ,
            dbo.DIC_CanBo.KhenThuongKyLuat ,
            dbo.DIC_CanBo.HTapNCuuNNgoai ,
            dbo.DIC_CanBo.IDBoPhan ,
            dbo.DIC_CanBo.MaNhanVien ,
            dbo.DIC_CanBo.MaNhanVienTheoMayCC ,
            dbo.DIC_CanBo.DienThoai ,
            dbo.DIC_CanBo.Email ,
            dbo.DIC_CanBo.LoaiCanBo ,
            dbo.DIC_CanBo.DanToc ,
            dbo.DIC_CanBo.SoCMT ,
            dbo.DIC_CanBo.NgayCap ,
            dbo.DIC_CanBo.NoiCap ,
            dbo.DIC_CanBo.GhiChu ,
            dbo.DIC_CanBo.idChuyenNganh ,
            dbo.DIC_CanBo.idChuyenKhoa ,
            dbo.DIC_CanBo.Backup01 ,
            dbo.DIC_CanBo.Backup02 ,
            dbo.DIC_CanBo.backup03 ,
            dbo.DIC_CanBo.LoaiHopDong ,
            dbo.DIC_CanBo.backupDate ,
            dbo.DIC_CanBo.LastEdited_IdUser ,
            dbo.DIC_CanBo.LastEdited_Datetime ,
            dbo.DIC_ChucVu.Ten AS TenChucVu ,
            dbo.DIC_HocVi.TenHocVi AS TenTrinhDo ,
            dbo.DIC_BoPhan.Ten AS TenBoPhan ,
            dbo.DIC_Tinh.Ten AS TenTinh
			 ,dbo.ADM_NguoiDung.IDNguoiDung AS IDUser
    FROM    dbo.DIC_CanBo
            LEFT OUTER JOIN dbo.DIC_ChucVu ON dbo.DIC_CanBo.IDChucVu = dbo.DIC_ChucVu.ID
            LEFT OUTER JOIN dbo.DIC_HocVi ON dbo.DIC_CanBo.IDTrinhDo = dbo.DIC_HocVi.ID
            LEFT OUTER JOIN dbo.DIC_BoPhan ON dbo.DIC_CanBo.IDBoPhan = dbo.DIC_BoPhan.ID
            LEFT OUTER JOIN dbo.DIC_Tinh ON dbo.DIC_CanBo.IDTinh = dbo.DIC_Tinh.ID
            LEFT OUTER JOIN dbo.ADM_NguoiDung ON dbo.DIC_CanBo.ID = dbo.ADM_NguoiDung.IDCanBo


go
--INSERT INTO dbo.ADM_ChucNang
--        ( MaCN, TenCN, Mota, IDNhomCN )
--VALUES  ( N'CanBoDiTinh', -- MaCN - nvarchar(50)
--          N'Chỉ đạo tuyến - Quản lý cán bộ đi tuyến', -- TenCN - nvarchar(100)
--          N'Quản lý cán bộ đi tuyến, đi các tỉnh', -- Mota - nvarchar(255)
--          7  -- IDNhomCN - int
--          )








GO


