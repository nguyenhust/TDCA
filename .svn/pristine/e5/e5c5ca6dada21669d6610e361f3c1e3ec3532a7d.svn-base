/****** Object:  StoredProcedure [dbo].[DIC_Tinh_Coll_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_Tinh_Coll_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_Tinh_Coll_Get]
GO

CREATE PROCEDURE [dbo].[DIC_Tinh_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DIC_Tinh_Info from table */
        SELECT
            [DIC_Tinh].[ID],
            [DIC_Tinh].[Ma],
            [DIC_Tinh].[MaDK],
            [DIC_Tinh].[TieuDe],
            [DIC_Tinh].[Ten],
            [DIC_Tinh].[IDRefer],
            [DIC_Tinh].[SuDung],
            [DIC_Tinh].[GhiChu]
        FROM [dbo].[DIC_Tinh]

    END
GO

