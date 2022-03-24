/****** Object:  StoredProcedure [dbo].[DIC_SLChucVuBV_Coll_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_SLChucVuBV_Coll_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_SLChucVuBV_Coll_Get]
GO

CREATE PROCEDURE [dbo].[DIC_SLChucVuBV_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DIC_SLChucVuBV_Info from table */
        SELECT
            [DIC_SLChucVuBV].[ID],
            [DIC_SLChucVuBV].[IDBenhVien],
            [DIC_SLChucVuBV].[IDChucVu],
            [DIC_SLChucVuBV].[SLChucVu],
            [DIC_SLChucVuBV].[GhiChu]
        FROM [dbo].[DIC_SLChucVuBV]

    END
GO

