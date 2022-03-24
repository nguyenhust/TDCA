/****** Object:  StoredProcedure [dbo].[DIC_CoQuan_Coll_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_CoQuan_Coll_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_CoQuan_Coll_Get]
GO

CREATE PROCEDURE [dbo].[DIC_CoQuan_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DIC_CoQuan_Info from table */
        SELECT
            [DIC_CoQuan].[ID],
            [DIC_CoQuan].[Ten],
            [DIC_CoQuan].[DiaChi],
            [DIC_CoQuan].[SuDung],
            [DIC_CoQuan].[GhiChu]
        FROM [dbo].[DIC_CoQuan]

    END
GO

