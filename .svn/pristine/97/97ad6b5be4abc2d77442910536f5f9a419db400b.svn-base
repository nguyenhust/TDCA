/****** Object:  StoredProcedure [dbo].[DIC_SLHocViBV_Coll_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_SLHocViBV_Coll_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_SLHocViBV_Coll_Get]
GO

CREATE PROCEDURE [dbo].[DIC_SLHocViBV_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DIC_SLHocViBV_Info from table */
        SELECT
            [DIC_SLHocViBV].[ID],
            [DIC_SLHocViBV].[IDBenhVien],
            [DIC_SLHocViBV].[IDHocVi],
            [DIC_SLHocViBV].[SLHocVi],
            [DIC_SLHocViBV].[GhiChu]
        FROM [dbo].[DIC_SLHocViBV]

    END
GO

