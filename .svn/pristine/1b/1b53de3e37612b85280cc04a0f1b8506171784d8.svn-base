/****** Object:  StoredProcedure [dbo].[DIC_DonViTinh_Coll_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_DonViTinh_Coll_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_DonViTinh_Coll_Get]
GO

CREATE PROCEDURE [dbo].[DIC_DonViTinh_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DIC_DonViTinh_Info from table */
        SELECT
            [DIC_DonViTinh].[ID],
            [DIC_DonViTinh].[Name],
            [DIC_DonViTinh].[NameShort],
            [DIC_DonViTinh].[SuDung],
            [DIC_DonViTinh].[GhiChu]
        FROM [dbo].[DIC_DonViTinh]

    END
GO

