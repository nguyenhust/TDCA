/****** Object:  StoredProcedure [dbo].[ADM_NguoiDung_Coll_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_NguoiDung_Coll_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_NguoiDung_Coll_Get]
GO

CREATE PROCEDURE [dbo].[ADM_NguoiDung_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get ADM_NguoiDung_Info from table */
        SELECT
            [ADM_NguoiDung].[IDNguoiDung],
            [ADM_NguoiDung].[TenDangNhap],
            [ADM_NguoiDung].[MatKhau],
            [ADM_NguoiDung].[TenDayDu],
            [ADM_NguoiDung].[IDVaiTro],
            [ADM_NguoiDung].[HoatDong],
            [ADM_NguoiDung].[DaDoiMatKhau]
        FROM [dbo].[ADM_NguoiDung]

    END
GO

