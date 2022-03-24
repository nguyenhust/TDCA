/****** Object:  StoredProcedure [dbo].[ADM_VaiTro_Coll_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_VaiTro_Coll_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_VaiTro_Coll_Get]
GO

CREATE PROCEDURE [dbo].[ADM_VaiTro_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get ADM_VaiTro_Info from table */
        SELECT
            [ADM_VaiTro].[ID],
            [ADM_VaiTro].[TenVaiTro]
        FROM [dbo].[ADM_VaiTro]

    END
GO

