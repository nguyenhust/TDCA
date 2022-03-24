/****** Object:  StoredProcedure [dbo].[TT_PhongVan_Coll_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_PhongVan_Coll_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[TT_PhongVan_Coll_Get]
GO

CREATE PROCEDURE [dbo].[TT_PhongVan_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get TT_PhongVan_Info from table */
        SELECT
            [TT_PhongVan].[ID],
            [TT_PhongVan].[NoiDung],
            [TT_PhongVan].[IDCoQuanCT],
            [TT_PhongVan].[KhoaLamViec],
            [TT_PhongVan].[SoGiayGioiThieu],
            [TT_PhongVan].[SoDienThoai],
            [TT_PhongVan].[ThoiGian],
            [TT_PhongVan].[Ghichu],
            dcq.Ten TenCoQuan
        FROM [dbo].[TT_PhongVan]
			JOIN DIC_CoQuan dcq ON dcq.ID = [dbo].[TT_PhongVan].IDCoQuanCT
    END
GO

