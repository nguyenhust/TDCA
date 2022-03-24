/****** Object:  StoredProcedure [dbo].[TT_AnPham_Coll_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_AnPham_Coll_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[TT_AnPham_Coll_Get]
GO

CREATE PROCEDURE [dbo].[TT_AnPham_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get TT_AnPham_Info from table */
        SELECT
            [TT_AnPham].[ID],
            [TT_AnPham].[Ten],
            [TT_AnPham].[IDLoai],
            [TT_AnPham].[DonViDat],
            [TT_AnPham].[NoiDung],
            [TT_AnPham].[SoLuong],
            [TT_AnPham].[TuNgay],
            [TT_AnPham].[DenNgay],
            [TT_AnPham].[GhiChu],
            dl.Ten AS Loai
        FROM [dbo].[TT_AnPham] 
        JOIN DIC_Loai dl ON dl.ID = [dbo].[TT_AnPham].IDLoai

    END
GO

