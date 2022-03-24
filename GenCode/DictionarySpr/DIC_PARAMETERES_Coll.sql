/****** Object:  StoredProcedure [dbo].[DIC_PARAMETERES_Coll_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_PARAMETERES_Coll_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_PARAMETERES_Coll_Get]
GO

CREATE PROCEDURE [dbo].[DIC_PARAMETERES_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DIC_PARAMETERES_Info from table */
        SELECT
            [DIC_PARAMETERES].[ID],
            [DIC_PARAMETERES].[ParaName],
            [DIC_PARAMETERES].[Descriptions],
            [DIC_PARAMETERES].[ParaValue],
            [DIC_PARAMETERES].[ParaExpand],
            [DIC_PARAMETERES].[ParaType],
            [DIC_PARAMETERES].[ParaRoll],
            [DIC_PARAMETERES].[DefaultValue]
        FROM [dbo].[DIC_PARAMETERES]

    END
GO

