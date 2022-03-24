/****** Object:  StoredProcedure [dbo].[DIC_VatTu_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_VatTu_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_VatTu_Get]
GO

CREATE PROCEDURE [dbo].[DIC_VatTu_Get]
    @ID bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DIC_VatTu from table */
        SELECT
            [DIC_VatTu].[ID],
            [DIC_VatTu].[Ten],
            [DIC_VatTu].[Ma],
            [DIC_VatTu].[IDLoai],
            [DIC_VatTu].[IDDonViTinh],
            [DIC_VatTu].[MauSac],
            [DIC_VatTu].[NhaSX],
            [DIC_VatTu].[NguonGocXuatXu],
            [DIC_VatTu].[DonGia],
            [DIC_VatTu].[PhuKien],
            [DIC_VatTu].[Serial],
            [DIC_VatTu].[NgayTao],
            [DIC_VatTu].[SuDung],
            [DIC_VatTu].[GhiChu]
        FROM [dbo].[DIC_VatTu]
        WHERE
            [DIC_VatTu].[ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_VatTu_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_VatTu_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_VatTu_Add]
GO

CREATE PROCEDURE [dbo].[DIC_VatTu_Add]
    @ID bigint OUTPUT,
    @Ten nvarchar(50),
    @Ma varchar(20),
    @IDLoai int,
    @IDDonViTinh int,
    @MauSac nvarchar(50),
    @NhaSX nvarchar(100),
    @NguonGocXuatXu nvarchar(100),
    @DonGia decimal(10, 2),
    @PhuKien nvarchar(100),
    @Serial varchar(20),
    @NgayTao datetime,
    @SuDung bit,
    @GhiChu nvarchar(100)
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.DIC_VatTu */
        INSERT INTO [dbo].[DIC_VatTu]
        (
            [Ten],
            [Ma],
            [IDLoai],
            [IDDonViTinh],
            [MauSac],
            [NhaSX],
            [NguonGocXuatXu],
            [DonGia],
            [PhuKien],
            [Serial],
            [NgayTao],
            [SuDung],
            [GhiChu]
        )
        VALUES
        (
            @Ten,
            @Ma,
            @IDLoai,
            @IDDonViTinh,
            @MauSac,
            @NhaSX,
            @NguonGocXuatXu,
            @DonGia,
            @PhuKien,
            @Serial,
            @NgayTao,
            @SuDung,
            @GhiChu
        )

        /* Return new primary key */
        SET @ID = SCOPE_IDENTITY()

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_VatTu_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_VatTu_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_VatTu_Upd]
GO

CREATE PROCEDURE [dbo].[DIC_VatTu_Upd]
    @ID bigint,
    @Ten nvarchar(50),
    @Ma varchar(20),
    @IDLoai int,
    @IDDonViTinh int,
    @MauSac nvarchar(50),
    @NhaSX nvarchar(100),
    @NguonGocXuatXu nvarchar(100),
    @DonGia decimal(10, 2),
    @PhuKien nvarchar(100),
    @Serial varchar(20),
    @NgayTao datetime,
    @SuDung bit,
    @GhiChu nvarchar(100)
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_VatTu]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_VatTu'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.DIC_VatTu */
        UPDATE [dbo].[DIC_VatTu]
        SET
            [Ten] = @Ten,
            [Ma] = @Ma,
            [IDLoai] = @IDLoai,
            [IDDonViTinh] = @IDDonViTinh,
            [MauSac] = @MauSac,
            [NhaSX] = @NhaSX,
            [NguonGocXuatXu] = @NguonGocXuatXu,
            [DonGia] = @DonGia,
            [PhuKien] = @PhuKien,
            [Serial] = @Serial,
            [NgayTao] = @NgayTao,
            [SuDung] = @SuDung,
            [GhiChu] = @GhiChu
        WHERE
            [ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_VatTu_Delete] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_VatTu_Delete]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_VatTu_Delete]
GO

CREATE PROCEDURE [dbo].[DIC_VatTu_Delete]
    @ID bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_VatTu]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_VatTu'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete DIC_VatTu object from DIC_VatTu */
        DELETE
        FROM [dbo].[DIC_VatTu]
        WHERE
            [dbo].[DIC_VatTu].[ID] = @ID

    END
GO
