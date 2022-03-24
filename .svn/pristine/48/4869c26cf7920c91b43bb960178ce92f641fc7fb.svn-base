/****** Object:  StoredProcedure [dbo].[DIC_ChuyenNganh_Coll_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_ChuyenNganh_Coll_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_ChuyenNganh_Coll_Get]
GO

CREATE PROCEDURE [dbo].[DIC_ChuyenNganh_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DIC_ChuyenNganh_Info from table */
        SELECT
            [DIC_ChuyenNganh].[ID],
            [DIC_ChuyenNganh].[Ma],
            [DIC_ChuyenNganh].[Ten],
            [DIC_ChuyenNganh].[TenTat],
            [DIC_ChuyenNganh].[TruongCN],
            [DIC_ChuyenNganh].[ID_ChuyenKhoa],
            [DIC_ChuyenNganh].[GhiChu],
            [DIC_ChuyenNganh].[SuDung]
        FROM [dbo].[DIC_ChuyenNganh]

    END
GO

