/****** Object:  StoredProcedure [dbo].[DIC_HocVi_Coll_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_HocVi_Coll_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_HocVi_Coll_Get]
GO

CREATE PROCEDURE [dbo].[DIC_HocVi_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DIC_HocVi_Info from table */
        SELECT
            [DIC_HocVi].[ID],
            [DIC_HocVi].[TenHocVi],
            [DIC_HocVi].[SuDung]
        FROM [dbo].[DIC_HocVi]

    END
GO

