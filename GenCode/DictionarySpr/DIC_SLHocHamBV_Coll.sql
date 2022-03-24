/****** Object:  StoredProcedure [dbo].[DIC_SLHocHamBV_Coll_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_SLHocHamBV_Coll_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_SLHocHamBV_Coll_Get]
GO

CREATE PROCEDURE [dbo].[DIC_SLHocHamBV_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DIC_SLHocHamBV_Info from table */
        SELECT
            [DIC_SLHocHamBV].[ID],
            [DIC_SLHocHamBV].[IDBenhVien],
            [DIC_SLHocHamBV].[IDHocHam],
            [DIC_SLHocHamBV].[SLHocHam],
            [DIC_SLHocHamBV].[GhiChu]
        FROM [dbo].[DIC_SLHocHamBV]

    END
GO

