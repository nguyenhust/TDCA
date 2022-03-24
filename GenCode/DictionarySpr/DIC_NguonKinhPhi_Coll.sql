/****** Object:  StoredProcedure [dbo].[DIC_NguonKinhPhi_Coll_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_NguonKinhPhi_Coll_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_NguonKinhPhi_Coll_Get]
GO

CREATE PROCEDURE [dbo].[DIC_NguonKinhPhi_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DIC_NguonKinhPhi_Info from table */
        SELECT
            [DIC_NguonKinhPhi].[ID],
            [DIC_NguonKinhPhi].[Ten],
            [DIC_NguonKinhPhi].[GhiChu],
            [DIC_NguonKinhPhi].[SuDung]
        FROM [dbo].[DIC_NguonKinhPhi]

    END
GO

