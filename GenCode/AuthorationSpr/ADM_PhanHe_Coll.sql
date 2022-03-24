/****** Object:  StoredProcedure [dbo].[ADM_PhanHe_Coll_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_PhanHe_Coll_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_PhanHe_Coll_Get]
GO

CREATE PROCEDURE [dbo].[ADM_PhanHe_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get ADM_PhanHe_Info from table */
        SELECT
            [ADM_PhanHe].[ID],
            [ADM_PhanHe].[Ma],
            [ADM_PhanHe].[TenPhanHe],
            [ADM_PhanHe].[MoTa]
        FROM [dbo].[ADM_PhanHe]

    END
GO

