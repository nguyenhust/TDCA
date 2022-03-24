/****** Object:  StoredProcedure [dbo].[DIC_BenhVien_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_BenhVien_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_BenhVien_Get]
GO

CREATE PROCEDURE [dbo].[DIC_BenhVien_Get]
    @ID bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DIC_BenhVien from table */
        SELECT
            [DIC_BenhVien].[ID],
            [DIC_BenhVien].[Ma],
            [DIC_BenhVien].[Ten],
            [DIC_BenhVien].[IDTinh],
            [DIC_BenhVien].[DienTich],
            [DIC_BenhVien].[DacDiem],
            [DIC_BenhVien].[KhoangCach],
            [DIC_BenhVien].[Email],
            [DIC_BenhVien].[Fax],
            [DIC_BenhVien].[IDLoai],
            [DIC_BenhVien].[GiuongTK],
            [DIC_BenhVien].[GiuongKH],
            [DIC_BenhVien].[KhoaLS],
            [DIC_BenhVien].[KhoaCLS],
            [DIC_BenhVien].[Phong],
            [DIC_BenhVien].[GhiChu],
            [DIC_BenhVien].[SuDung]
        FROM [dbo].[DIC_BenhVien]
        WHERE
            [DIC_BenhVien].[ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_BenhVien_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_BenhVien_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_BenhVien_Add]
GO

CREATE PROCEDURE [dbo].[DIC_BenhVien_Add]
    @ID bigint OUTPUT,
    @Ma nvarchar(10),
    @Ten nvarchar(200),
    @IDTinh bigint,
    @DienTich decimal(10, 3),
    @DacDiem nvarchar(200),
    @KhoangCach decimal(10, 3),
    @Email nvarchar(50),
    @Fax varchar(20),
    @IDLoai int,
    @GiuongTK int,
    @GiuongKH int,
    @KhoaLS int,
    @KhoaCLS int,
    @Phong int,
    @GhiChu nvarchar(100),
    @SuDung bit
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.DIC_BenhVien */
        INSERT INTO [dbo].[DIC_BenhVien]
        (
            [Ma],
            [Ten],
            [IDTinh],
            [DienTich],
            [DacDiem],
            [KhoangCach],
            [Email],
            [Fax],
            [IDLoai],
            [GiuongTK],
            [GiuongKH],
            [KhoaLS],
            [KhoaCLS],
            [Phong],
            [GhiChu],
            [SuDung]
        )
        VALUES
        (
            @Ma,
            @Ten,
            @IDTinh,
            @DienTich,
            @DacDiem,
            @KhoangCach,
            @Email,
            @Fax,
            @IDLoai,
            @GiuongTK,
            @GiuongKH,
            @KhoaLS,
            @KhoaCLS,
            @Phong,
            @GhiChu,
            @SuDung
        )

        /* Return new primary key */
        SET @ID = SCOPE_IDENTITY()

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_BenhVien_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_BenhVien_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_BenhVien_Upd]
GO

CREATE PROCEDURE [dbo].[DIC_BenhVien_Upd]
    @ID bigint,
    @Ma nvarchar(10),
    @Ten nvarchar(200),
    @IDTinh bigint,
    @DienTich decimal(10, 3),
    @DacDiem nvarchar(200),
    @KhoangCach decimal(10, 3),
    @Email nvarchar(50),
    @Fax varchar(20),
    @IDLoai int,
    @GiuongTK int,
    @GiuongKH int,
    @KhoaLS int,
    @KhoaCLS int,
    @Phong int,
    @GhiChu nvarchar(100),
    @SuDung bit
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_BenhVien]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_BenhVien'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.DIC_BenhVien */
        UPDATE [dbo].[DIC_BenhVien]
        SET
            [Ma] = @Ma,
            [Ten] = @Ten,
            [IDTinh] = @IDTinh,
            [DienTich] = @DienTich,
            [DacDiem] = @DacDiem,
            [KhoangCach] = @KhoangCach,
            [Email] = @Email,
            [Fax] = @Fax,
            [IDLoai] = @IDLoai,
            [GiuongTK] = @GiuongTK,
            [GiuongKH] = @GiuongKH,
            [KhoaLS] = @KhoaLS,
            [KhoaCLS] = @KhoaCLS,
            [Phong] = @Phong,
            [GhiChu] = @GhiChu,
            [SuDung] = @SuDung
        WHERE
            [ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_BenhVien_Delete] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_BenhVien_Delete]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_BenhVien_Delete]
GO

CREATE PROCEDURE [dbo].[DIC_BenhVien_Delete]
    @ID bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_BenhVien]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_BenhVien'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete DIC_BenhVien object from DIC_BenhVien */
        DELETE
        FROM [dbo].[DIC_BenhVien]
        WHERE
            [dbo].[DIC_BenhVien].[ID] = @ID

    END
GO
