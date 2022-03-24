/****** Object:  StoredProcedure [dbo].[DIC_Phong_Coll_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_Phong_Coll_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_Phong_Coll_Get]
GO

CREATE PROCEDURE [dbo].[DIC_Phong_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DIC_Phong_Info from table */
        SELECT
            [DIC_Phong].[ID],
            [DIC_Phong].[Ma],
            [DIC_Phong].[Ten],
            [DIC_Phong].[IDCanBo],
            [DIC_Phong].[TinhTrang],
            [DIC_Phong].[MucDich],
            [DIC_Phong].[DiaDiem],
            [DIC_Phong].[NgayTao],
            [DIC_Phong].[SuDung],
            [DIC_Phong].[GhiChu],
            [DIC_Phong].[SucChua],
            [DIC_Phong].[TrangThietBi]
        FROM [dbo].[DIC_Phong]

    END
GO

