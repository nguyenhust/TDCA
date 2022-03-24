/****** Object:  StoredProcedure [dbo].[ADM_NhomChucNang_Coll_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_NhomChucNang_Coll_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_NhomChucNang_Coll_Get]
GO

CREATE PROCEDURE [dbo].[ADM_NhomChucNang_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get ADM_NhomChucNang_Info from table */
        SELECT
            [ADM_NhomChucNang].[ID],
            [ADM_NhomChucNang].[Ma],
            [ADM_NhomChucNang].[IDPhanHe],
            [ADM_NhomChucNang].[TenNhomCN]
        FROM [dbo].[ADM_NhomChucNang]

    END
GO

