/****** Object:  StoredProcedure [dbo].[DIC_GioiTinh_Coll_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_GioiTinh_Coll_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_GioiTinh_Coll_Get]
GO

CREATE PROCEDURE [dbo].[DIC_GioiTinh_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DIC_GioiTInh_Info from table */
        SELECT
            [DIC_GioiTinh].[ID],
            [DIC_GioiTinh].[Ten],
            [DIC_GioiTinh].[GhiChu],
            [DIC_GioiTinh].[SuDung]
        FROM [dbo].[DIC_GioiTinh]

    END
GO

