/****** Object:  StoredProcedure [dbo].[TT_BaiViet_Coll_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_BaiViet_Coll_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[TT_BaiViet_Coll_Get]
GO

CREATE PROCEDURE [dbo].[TT_BaiViet_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get TT_BaiViet_Info from table */
        SELECT
            [TT_BaiViet].[ID],
            [TT_BaiViet].[TacGia],
            [TT_BaiViet].[TieuDe],
            [TT_BaiViet].[NoiDung],
            [TT_BaiViet].[IDLoai],
            [TT_BaiViet].[ThoiGianDang],
            [TT_BaiViet].[ThoiGianDuyet],
            [TT_BaiViet].[NguoiDuyet],
            [TT_BaiViet].[Link],
            [TT_BaiViet].[DuongDan],
            [TT_BaiViet].[GhiChu],
            dl.Ten AS Loai
        FROM [dbo].[TT_BaiViet]
			JOIN DIC_Loai dl ON dl.ID = [dbo].[TT_BaiViet].IDLoai

    END
GO

