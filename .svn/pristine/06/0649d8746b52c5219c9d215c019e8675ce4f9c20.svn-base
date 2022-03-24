/****** Object:  StoredProcedure [dbo].[DIC_MonHoc_Coll_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_MonHoc_Coll_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_MonHoc_Coll_Get]
GO

CREATE PROCEDURE [dbo].[DIC_MonHoc_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DIC_MonHoc_Info from table */
        SELECT
            [DIC_MonHoc].[ID],
            [DIC_MonHoc].[Ma],
            [DIC_MonHoc].[Ten],
            [DIC_MonHoc].[IDLoai],
            [DIC_MonHoc].[GhiChu],
            [DIC_MonHoc].[SuDung]
        FROM [dbo].[DIC_MonHoc]

    END
GO

