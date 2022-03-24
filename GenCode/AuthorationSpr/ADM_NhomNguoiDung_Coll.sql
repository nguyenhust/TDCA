/****** Object:  StoredProcedure [dbo].[ADM_NhomNguoiDung_Coll_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_NhomNguoiDung_Coll_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_NhomNguoiDung_Coll_Get]
GO

CREATE PROCEDURE [dbo].[ADM_NhomNguoiDung_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get ADM_NhomNguoiDung_Info from table */
        SELECT
            [ADM_NhomNguoiDung].[ID],
            [ADM_NhomNguoiDung].[TenNhom],
            [ADM_NhomNguoiDung].[MoTa],
            [ADM_NhomNguoiDung].[HoatDong]
        FROM [dbo].[ADM_NhomNguoiDung]

    END
GO

