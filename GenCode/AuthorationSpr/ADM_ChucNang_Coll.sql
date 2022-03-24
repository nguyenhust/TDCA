/****** Object:  StoredProcedure [dbo].[ADM_ChucNang_Coll_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_ChucNang_Coll_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_ChucNang_Coll_Get]
GO

CREATE PROCEDURE [dbo].[ADM_ChucNang_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get ADM_ChucNang_Info from table */
        SELECT
            [ADM_ChucNang].[IDCN],
            [ADM_ChucNang].[MaCN],
            [ADM_ChucNang].[TenCN],
            [ADM_ChucNang].[Mota],
            [ADM_ChucNang].[IDNhomCN]
        FROM [dbo].[ADM_ChucNang]

    END
GO

