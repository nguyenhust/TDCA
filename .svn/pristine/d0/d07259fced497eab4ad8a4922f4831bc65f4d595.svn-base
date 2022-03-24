/****** Object:  StoredProcedure [dbo].[DIC_HocHam_Coll_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_HocHam_Coll_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_HocHam_Coll_Get]
GO

CREATE PROCEDURE [dbo].[DIC_HocHam_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DIC_HocHam_Info from table */
        SELECT
            [DIC_HocHam].[ID],
            [DIC_HocHam].[TenHocHam],
            [DIC_HocHam].[SuDung]
        FROM [dbo].[DIC_HocHam]

    END
GO

