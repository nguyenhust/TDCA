/****** Object:  StoredProcedure [dbo].[DIC_BoPhan_Coll_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_BoPhan_Coll_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_BoPhan_Coll_Get]
GO

CREATE PROCEDURE [dbo].[DIC_BoPhan_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DIC_BoPhan_Info from table */
        SELECT
            [DIC_BoPhan].[ID],
            [DIC_BoPhan].[Ten],
            [DIC_BoPhan].[Ma],
            [DIC_BoPhan].[SuDung],
            [DIC_BoPhan].[GhiChu]
        FROM [dbo].[DIC_BoPhan]

    END
GO

