/****** Object:  StoredProcedure [dbo].[DIC_QuocGia_Coll_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_QuocGia_Coll_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_QuocGia_Coll_Get]
GO

CREATE PROCEDURE [dbo].[DIC_QuocGia_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DIC_QuocGia_Info from table */
        SELECT
            [DIC_QuocGia].[ID],
            [DIC_QuocGia].[TenQuocGia],
            [DIC_QuocGia].[SuDung]
        FROM [dbo].[DIC_QuocGia]

    END
GO

