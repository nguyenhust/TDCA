/****** Object:  StoredProcedure [dbo].[TT_PhongVanCT_Coll_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_PhongVanCT_Coll_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[TT_PhongVanCT_Coll_Get]
GO

CREATE PROCEDURE [dbo].[TT_PhongVanCT_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get TT_PhongVanCT_Info from table */
        SELECT
            [TT_PhongVanCT].[ID],
            [TT_PhongVanCT].[IDPhongVan],
            [TT_PhongVanCT].[HoVaTen],
            [TT_PhongVanCT].[IDChucVu],
            [TT_PhongVanCT].[PhongVienOrCanBo]
        FROM [dbo].[TT_PhongVanCT]

    END
GO

