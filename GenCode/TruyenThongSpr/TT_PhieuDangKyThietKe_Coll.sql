/****** Object:  StoredProcedure [dbo].[TT_PhieuDangKyThietKe_Coll_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_PhieuDangKyThietKe_Coll_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[TT_PhieuDangKyThietKe_Coll_Get]
GO

CREATE PROCEDURE [dbo].[TT_PhieuDangKyThietKe_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get TT_PhieuDangKyThietKe_Info from table */
        SELECT
            pdktk.[ID],
            pdktk.[NoiDung],
            pdktk.[IDLoai],
            pdktk.[TuNgay],
            pdktk.[DenNgay],
            pdktk.[IDCanBo],
            pdktk.[SLYeuCau],
            pdktk.[SLDuyet],
            pdktk.[TinhTrang],
            pdktk.[GhiChu],
            dl.Ten,
            dcb.HoTen,
            dl1.Ten AS TenTinhTrang
        FROM [dbo].[TT_PhieuDangKyThietKe] pdktk
        JOIN DIC_Loai dl ON dl.ID = pdktk.IDLoai
        JOIN DIC_CanBo dcb ON dcb.ID = pdktk.IDCanBo 
		JOIN DIC_Loai dl1 ON dl1.ID = pdktk.TinhTrang
    END
GO