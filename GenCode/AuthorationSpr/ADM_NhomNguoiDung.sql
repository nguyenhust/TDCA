/****** Object:  StoredProcedure [dbo].[ADM_NhomNguoiDung_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_NhomNguoiDung_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_NhomNguoiDung_Get]
GO

CREATE PROCEDURE [dbo].[ADM_NhomNguoiDung_Get]
    @ID bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Get ADM_NhomNguoiDung from table */
        SELECT
            [ADM_NhomNguoiDung].[ID],
            [ADM_NhomNguoiDung].[TenNhom],
            [ADM_NhomNguoiDung].[MoTa],
            [ADM_NhomNguoiDung].[HoatDong]
        FROM [dbo].[ADM_NhomNguoiDung]
        WHERE
            [ADM_NhomNguoiDung].[ID] = @ID

        /* Get ADM_QuyenNhomNguoiDung_Info from table */
        SELECT
            [ADM_QuyenNhomNguoiDung].[IDQuyenNhomND],
            [ADM_QuyenNhomNguoiDung].[IDChucNang],
            [ADM_QuyenNhomNguoiDung].[ThemMoi],
            [ADM_QuyenNhomNguoiDung].[Sua],
            [ADM_QuyenNhomNguoiDung].[Xoa],
            [ADM_QuyenNhomNguoiDung].[TatCa],
            [ADM_QuyenNhomNguoiDung].[Xem]
        FROM [dbo].[ADM_QuyenNhomNguoiDung]
            INNER JOIN [dbo].[ADM_NhomNguoiDung] ON [ADM_QuyenNhomNguoiDung].[IDNhomNguoiDung] = [ADM_NhomNguoiDung].[ID]
        WHERE
            [ADM_NhomNguoiDung].[ID] = @ID

        /* Get ADM_QuyenNhomNguoiDung_Info from table */
        SELECT
            [ADM_QuyenNhomNguoiDung].[IDQuyenNhomND],
            [ADM_QuyenNhomNguoiDung].[IDChucNang],
            [ADM_QuyenNhomNguoiDung].[ThemMoi],
            [ADM_QuyenNhomNguoiDung].[Sua],
            [ADM_QuyenNhomNguoiDung].[Xoa],
            [ADM_QuyenNhomNguoiDung].[TatCa],
            [ADM_QuyenNhomNguoiDung].[Xem]
        FROM [dbo].[ADM_QuyenNhomNguoiDung]
            INNER JOIN [dbo].[ADM_NhomNguoiDung] ON [ADM_QuyenNhomNguoiDung].[IDNhomNguoiDung] = [ADM_NhomNguoiDung].[ID]
        WHERE
            [ADM_NhomNguoiDung].[ID] = @ID

        /* Get ADM_QuyenNhomNguoiDung_Info from table */
        SELECT
            [ADM_QuyenNhomNguoiDung].[IDQuyenNhomND],
            [ADM_QuyenNhomNguoiDung].[IDChucNang],
            [ADM_QuyenNhomNguoiDung].[ThemMoi],
            [ADM_QuyenNhomNguoiDung].[Sua],
            [ADM_QuyenNhomNguoiDung].[Xoa],
            [ADM_QuyenNhomNguoiDung].[TatCa],
            [ADM_QuyenNhomNguoiDung].[Xem]
        FROM [dbo].[ADM_QuyenNhomNguoiDung]
            INNER JOIN [dbo].[ADM_NhomNguoiDung] ON [ADM_QuyenNhomNguoiDung].[IDNhomNguoiDung] = [ADM_NhomNguoiDung].[ID]
        WHERE
            [ADM_NhomNguoiDung].[ID] = @ID

        /* Get ADM_QuyenNhomNguoiDung_Info from table */
        SELECT
            [ADM_QuyenNhomNguoiDung].[IDQuyenNhomND],
            [ADM_QuyenNhomNguoiDung].[IDChucNang],
            [ADM_QuyenNhomNguoiDung].[ThemMoi],
            [ADM_QuyenNhomNguoiDung].[Sua],
            [ADM_QuyenNhomNguoiDung].[Xoa],
            [ADM_QuyenNhomNguoiDung].[TatCa],
            [ADM_QuyenNhomNguoiDung].[Xem]
        FROM [dbo].[ADM_QuyenNhomNguoiDung]
            INNER JOIN [dbo].[ADM_NhomNguoiDung] ON [ADM_QuyenNhomNguoiDung].[IDNhomNguoiDung] = [ADM_NhomNguoiDung].[ID]
        WHERE
            [ADM_NhomNguoiDung].[ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[ADM_NhomNguoiDung_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_NhomNguoiDung_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_NhomNguoiDung_Add]
GO

CREATE PROCEDURE [dbo].[ADM_NhomNguoiDung_Add]
    @ID bigint OUTPUT,
    @TenNhom nvarchar(50),
    @MoTa nvarchar(255),
    @HoatDong bit
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.ADM_NhomNguoiDung */
        INSERT INTO [dbo].[ADM_NhomNguoiDung]
        (
            [TenNhom],
            [MoTa],
            [HoatDong]
        )
        VALUES
        (
            @TenNhom,
            @MoTa,
            @HoatDong
        )

        /* Return new primary key */
        SET @ID = SCOPE_IDENTITY()

    END
GO

/****** Object:  StoredProcedure [dbo].[ADM_NhomNguoiDung_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_NhomNguoiDung_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_NhomNguoiDung_Upd]
GO

CREATE PROCEDURE [dbo].[ADM_NhomNguoiDung_Upd]
    @ID bigint,
    @TenNhom nvarchar(50),
    @MoTa nvarchar(255),
    @HoatDong bit
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[ADM_NhomNguoiDung]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.ADM_NhomNguoiDung'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.ADM_NhomNguoiDung */
        UPDATE [dbo].[ADM_NhomNguoiDung]
        SET
            [TenNhom] = @TenNhom,
            [MoTa] = @MoTa,
            [HoatDong] = @HoatDong
        WHERE
            [ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[ADM_NhomNguoiDung_Delete] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_NhomNguoiDung_Delete]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_NhomNguoiDung_Delete]
GO

CREATE PROCEDURE [dbo].[ADM_NhomNguoiDung_Delete]
    @ID bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[ADM_NhomNguoiDung]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.ADM_NhomNguoiDung'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete child ADM_QuyenNhomNguoiDung_Info from ADM_QuyenNhomNguoiDung */
        DELETE
            [dbo].[ADM_QuyenNhomNguoiDung]
        FROM [dbo].[ADM_QuyenNhomNguoiDung]
            INNER JOIN [dbo].[ADM_NhomNguoiDung] ON [ADM_QuyenNhomNguoiDung].[IDNhomNguoiDung] = [ADM_NhomNguoiDung].[ID]
        WHERE
            [dbo].[ADM_NhomNguoiDung].[ID] = @ID

        /* Delete child ADM_QuyenNhomNguoiDung_Info from ADM_QuyenNhomNguoiDung */
        DELETE
            [dbo].[ADM_QuyenNhomNguoiDung]
        FROM [dbo].[ADM_QuyenNhomNguoiDung]
            INNER JOIN [dbo].[ADM_NhomNguoiDung] ON [ADM_QuyenNhomNguoiDung].[IDNhomNguoiDung] = [ADM_NhomNguoiDung].[ID]
        WHERE
            [dbo].[ADM_NhomNguoiDung].[ID] = @ID

        /* Delete child ADM_QuyenNhomNguoiDung_Info from ADM_QuyenNhomNguoiDung */
        DELETE
            [dbo].[ADM_QuyenNhomNguoiDung]
        FROM [dbo].[ADM_QuyenNhomNguoiDung]
            INNER JOIN [dbo].[ADM_NhomNguoiDung] ON [ADM_QuyenNhomNguoiDung].[IDNhomNguoiDung] = [ADM_NhomNguoiDung].[ID]
        WHERE
            [dbo].[ADM_NhomNguoiDung].[ID] = @ID

        /* Delete child ADM_QuyenNhomNguoiDung_Info from ADM_QuyenNhomNguoiDung */
        DELETE
            [dbo].[ADM_QuyenNhomNguoiDung]
        FROM [dbo].[ADM_QuyenNhomNguoiDung]
            INNER JOIN [dbo].[ADM_NhomNguoiDung] ON [ADM_QuyenNhomNguoiDung].[IDNhomNguoiDung] = [ADM_NhomNguoiDung].[ID]
        WHERE
            [dbo].[ADM_NhomNguoiDung].[ID] = @ID

        /* Delete ADM_NhomNguoiDung object from ADM_NhomNguoiDung */
        DELETE
        FROM [dbo].[ADM_NhomNguoiDung]
        WHERE
            [dbo].[ADM_NhomNguoiDung].[ID] = @ID

    END
GO
