/****** Object:  StoredProcedure [dbo].[DIC_Loai_Coll_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_Loai_Coll_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_Loai_Coll_Get]
GO

CREATE PROCEDURE [dbo].[DIC_Loai_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DIC_Loai_Info from table */
        SELECT
            [DIC_Loai].[ID],
            [DIC_Loai].[Ma],
            [DIC_Loai].[Ten],
            [DIC_Loai].[GhiChu],
            [DIC_Loai].[SuDung]
        FROM [dbo].[DIC_Loai]

    END
GO

