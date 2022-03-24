/****** Object:  StoredProcedure [dbo].[DIC_ChucVu_Coll_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_ChucVu_Coll_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_ChucVu_Coll_Get]
GO

CREATE PROCEDURE [dbo].[DIC_ChucVu_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DIC_ChucVu_Info from table */
        SELECT
            [DIC_ChucVu].[ID],
            [DIC_ChucVu].[Ten],
            [DIC_ChucVu].[GhiChu],
            [DIC_ChucVu].[SuDung]
        FROM [dbo].[DIC_ChucVu]

    END
GO

