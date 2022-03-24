/****** Object:  StoredProcedure [dbo].[ADM_NguoiDung_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_NguoiDung_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_NguoiDung_Get]
GO

CREATE PROCEDURE [dbo].[ADM_NguoiDung_Get]
    @IDNguoiDung bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Get ADM_NguoiDung from table */
        SELECT
            [ADM_NguoiDung].[IDNguoiDung],
            [ADM_NguoiDung].[TenDangNhap],
            [ADM_NguoiDung].[MatKhau],
            [ADM_NguoiDung].[TenDayDu],
            [ADM_NguoiDung].[IDVaiTro],
            [ADM_NguoiDung].[HoatDong],
            [ADM_NguoiDung].[DaDoiMatKhau]
        FROM [dbo].[ADM_NguoiDung]
        WHERE
            [ADM_NguoiDung].[IDNguoiDung] = @IDNguoiDung

        /* Get ADM_ThanhVien_Info from table */
        SELECT
            [ADM_ThanhVien].[IDQuyenDuocPhan],
            [ADM_ThanhVien].[IDNhomNguoiDung]
        FROM [dbo].[ADM_ThanhVien]
            INNER JOIN [dbo].[ADM_NguoiDung] ON [ADM_ThanhVien].[IDNguoiDung] = [ADM_NguoiDung].[IDNguoiDung]
        WHERE
            [ADM_NguoiDung].[IDNguoiDung] = @IDNguoiDung

    END
GO

/****** Object:  StoredProcedure [dbo].[ADM_NguoiDung_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_NguoiDung_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_NguoiDung_Add]
GO

CREATE PROCEDURE [dbo].[ADM_NguoiDung_Add]
    @IDNguoiDung bigint OUTPUT,
    @TenDangNhap nvarchar(20),
    @MatKhau nvarchar(100),
    @TenDayDu nvarchar(50),
    @IDVaiTro int,
    @HoatDong bit,
    @DaDoiMatKhau bit
AS
    BEGIN

        SET NOCOUNT ON

		-- check username. If exits username in database then messgebox
		IF EXISTS(SELECT 1 FROM ADM_NguoiDung and1 WHERE and1.TenDangNhap = @TenDangNhap)
			RAISERROR(N'Đã tồn tại user [%s]. Vui lòng chọn tên đăng nhập khác',16,1,@TenDangNhap)
        /* Insert object into dbo.ADM_NguoiDung */
        INSERT INTO [dbo].[ADM_NguoiDung]
        (
            [TenDangNhap],
            [MatKhau],
            [TenDayDu],
            [IDVaiTro],
            [HoatDong],
            [DaDoiMatKhau]
        )
        VALUES
        (
            @TenDangNhap,
            @MatKhau,
            @TenDayDu,
            @IDVaiTro,
            @HoatDong,
            @DaDoiMatKhau
        )

        /* Return new primary key */
        SET @IDNguoiDung = SCOPE_IDENTITY()

    END
GO

/****** Object:  StoredProcedure [dbo].[ADM_NguoiDung_Upd] ******/ 
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_NguoiDung_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_NguoiDung_Upd]
GO
/*
Modified by: TUYLV
Modified date: 01/02/2014
Purpose: Kiểm tra tồn tại tên đăng nhập của người dùng
*/
CREATE PROCEDURE [dbo].[ADM_NguoiDung_Upd]
    @IDNguoiDung bigint,
    @TenDangNhap nvarchar(20),
    @MatKhau nvarchar(100),
    @TenDayDu nvarchar(50),
    @IDVaiTro int,
    @HoatDong bit,
    @DaDoiMatKhau bit
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [IDNguoiDung] FROM [dbo].[ADM_NguoiDung]
            WHERE
                [IDNguoiDung] = @IDNguoiDung
        )
        BEGIN
            RAISERROR ('''dbo.ADM_NguoiDung'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

		-- check username. If exits username in database then messgebox 
		IF EXISTS(SELECT 1 FROM ADM_NguoiDung and1 WHERE and1.TenDangNhap = @TenDangNhap)
			RAISERROR(N'Đã tồn tại user [%s]. Vui lòng chọn tên đăng nhập khác',16,1,@TenDangNhap)

        /* Update object in dbo.ADM_NguoiDung */
        UPDATE [dbo].[ADM_NguoiDung]
        SET
            [TenDangNhap] = @TenDangNhap,
            [MatKhau] = @MatKhau,
            [TenDayDu] = @TenDayDu,
            [IDVaiTro] = @IDVaiTro,
            [HoatDong] = @HoatDong,
            [DaDoiMatKhau] = @DaDoiMatKhau
        WHERE
            [IDNguoiDung] = @IDNguoiDung

    END
GO

/****** Object:  StoredProcedure [dbo].[ADM_NguoiDung_Delete] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_NguoiDung_Delete]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_NguoiDung_Delete]
GO

CREATE PROCEDURE [dbo].[ADM_NguoiDung_Delete]
    @IDNguoiDung bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [IDNguoiDung] FROM [dbo].[ADM_NguoiDung]
            WHERE
                [IDNguoiDung] = @IDNguoiDung
        )
        BEGIN
            RAISERROR ('''dbo.ADM_NguoiDung'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete child ADM_ThanhVien_Info from ADM_ThanhVien */
        DELETE
            [dbo].[ADM_ThanhVien]
        FROM [dbo].[ADM_ThanhVien]
            INNER JOIN [dbo].[ADM_NguoiDung] ON [ADM_ThanhVien].[IDNguoiDung] = [ADM_NguoiDung].[IDNguoiDung]
        WHERE
            [dbo].[ADM_NguoiDung].[IDNguoiDung] = @IDNguoiDung
		-- Delete child ADM_QuyenNguoiDung
		DELETE ADM_QuyenNguoiDung WHERE IDNguoiDung = @IDNguoiDung
		
        /* Delete ADM_NguoiDung object from ADM_NguoiDung */
        DELETE
        FROM [dbo].[ADM_NguoiDung]
        WHERE
            [dbo].[ADM_NguoiDung].[IDNguoiDung] = @IDNguoiDung

    END
GO
