/****** Object:  StoredProcedure [dbo].[DIC_DanToc_Coll_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_DanToc_Coll_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_DanToc_Coll_Get]
GO

CREATE PROCEDURE [dbo].[DIC_DanToc_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DIC_DanToc_Info from table */
        SELECT
            [DIC_DanToc].[ID],
            [DIC_DanToc].[Ma],
            [DIC_DanToc].[Ten],
            [DIC_DanToc].[GhiChu],
            [DIC_DanToc].[SuDung]
        FROM [dbo].[DIC_DanToc]

    END
GO

