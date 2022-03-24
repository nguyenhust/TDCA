/****** Object:  StoredProcedure [dbo].[DIC_ChuyenKhoa_Coll_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_ChuyenKhoa_Coll_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_ChuyenKhoa_Coll_Get]
GO

CREATE PROCEDURE [dbo].[DIC_ChuyenKhoa_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DIC_ChuyenKhoa_Info from table */
        SELECT
            [DIC_ChuyenKhoa].[ID],
            [DIC_ChuyenKhoa].[Ten],
            [DIC_ChuyenKhoa].[GhiChu],
            [DIC_ChuyenKhoa].[SuDung]
        FROM [dbo].[DIC_ChuyenKhoa]

    END
GO

