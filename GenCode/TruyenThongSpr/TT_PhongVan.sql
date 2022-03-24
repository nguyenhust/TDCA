/****** Object:  StoredProcedure [dbo].[TT_PhongVan_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_PhongVan_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[TT_PhongVan_Get]
GO

CREATE PROCEDURE [dbo].[TT_PhongVan_Get]
    @ID bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Get TT_PhongVan from table */
        SELECT
            [TT_PhongVan].[ID],
            [TT_PhongVan].[NoiDung],
            [TT_PhongVan].[IDCoQuanCT],
            [TT_PhongVan].[KhoaLamViec],
            [TT_PhongVan].[SoGiayGioiThieu],
            [TT_PhongVan].[SoDienThoai],
            [TT_PhongVan].[ThoiGian],
            [TT_PhongVan].[Ghichu]
        FROM [dbo].[TT_PhongVan]
        WHERE
            [TT_PhongVan].[ID] = @ID

        /* Get TT_PhongVanCT_Info from table */
        SELECT
            [TT_PhongVanCT].[IDCT],
            [TT_PhongVanCT].[HoVaTen],
            [TT_PhongVanCT].[IDChucVu],
            [TT_PhongVanCT].[PhongVienOrCanBo]
        FROM [dbo].[TT_PhongVanCT]
            INNER JOIN [dbo].[TT_PhongVan] ON [TT_PhongVanCT].[IDPhongVan] = [TT_PhongVan].[ID]
        WHERE
            [TT_PhongVan].[ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[TT_PhongVan_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_PhongVan_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[TT_PhongVan_Add]
GO

CREATE PROCEDURE [dbo].[TT_PhongVan_Add]
    @ID bigint OUTPUT,
    @NoiDung nvarchar(200),
    @IDCoQuanCT int,
    @KhoaLamViec nvarchar(100),
    @SoGiayGioiThieu varchar(50),
    @SoDienThoai varchar(20),
    @ThoiGian datetime,
    @Ghichu nvarchar(200)
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.TT_PhongVan */
        INSERT INTO [dbo].[TT_PhongVan]
        (
            [NoiDung],
            [IDCoQuanCT],
            [KhoaLamViec],
            [SoGiayGioiThieu],
            [SoDienThoai],
            [ThoiGian],
            [Ghichu]
        )
        VALUES
        (
            @NoiDung,
            @IDCoQuanCT,
            @KhoaLamViec,
            @SoGiayGioiThieu,
            @SoDienThoai,
            @ThoiGian,
            @Ghichu
        )

        /* Return new primary key */
        SET @ID = SCOPE_IDENTITY()

    END
GO

/****** Object:  StoredProcedure [dbo].[TT_PhongVan_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_PhongVan_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[TT_PhongVan_Upd]
GO

CREATE PROCEDURE [dbo].[TT_PhongVan_Upd]
    @ID bigint,
    @NoiDung nvarchar(200),
    @IDCoQuanCT int,
    @KhoaLamViec nvarchar(100),
    @SoGiayGioiThieu varchar(50),
    @SoDienThoai varchar(20),
    @ThoiGian datetime,
    @Ghichu nvarchar(200)
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[TT_PhongVan]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.TT_PhongVan'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.TT_PhongVan */
        UPDATE [dbo].[TT_PhongVan]
        SET
            [NoiDung] = @NoiDung,
            [IDCoQuanCT] = @IDCoQuanCT,
            [KhoaLamViec] = @KhoaLamViec,
            [SoGiayGioiThieu] = @SoGiayGioiThieu,
            [SoDienThoai] = @SoDienThoai,
            [ThoiGian] = @ThoiGian,
            [Ghichu] = @Ghichu
        WHERE
            [ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[TT_PhongVan_Delete] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_PhongVan_Delete]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[TT_PhongVan_Delete]
GO

CREATE PROCEDURE [dbo].[TT_PhongVan_Delete]
    @ID bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[TT_PhongVan]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.TT_PhongVan'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete child TT_PhongVanCT_Info from TT_PhongVanCT */
        DELETE
            [dbo].[TT_PhongVanCT]
        FROM [dbo].[TT_PhongVanCT]
            INNER JOIN [dbo].[TT_PhongVan] ON [TT_PhongVanCT].[IDPhongVan] = [TT_PhongVan].[ID]
        WHERE
            [dbo].[TT_PhongVan].[ID] = @ID

        /* Delete TT_PhongVan object from TT_PhongVan */
        DELETE
        FROM [dbo].[TT_PhongVan]
        WHERE
            [dbo].[TT_PhongVan].[ID] = @ID

    END
GO
