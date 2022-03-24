/****** Object:  StoredProcedure [dbo].[DIC_DonViTinh_Info_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_DonViTinh_Info_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_DonViTinh_Info_Add]
GO

CREATE PROCEDURE [dbo].[DIC_DonViTinh_Info_Add]
    @ID int OUTPUT,
    @Name nvarchar(50),
    @NameShort nvarchar(20),
    @SuDung bit,
    @GhiChu nvarchar(100)
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.DIC_DonViTinh */
        INSERT INTO [dbo].[DIC_DonViTinh]
        (
            [Name],
            [NameShort],
            [SuDung],
            [GhiChu]
        )
        VALUES
        (
            @Name,
            @NameShort,
            @SuDung,
            @GhiChu
        )

        /* Return new primary key */
        SET @ID = SCOPE_IDENTITY()

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_DonViTinh_Info_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_DonViTinh_Info_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_DonViTinh_Info_Upd]
GO

CREATE PROCEDURE [dbo].[DIC_DonViTinh_Info_Upd]
    @ID int,
    @Name nvarchar(50),
    @NameShort nvarchar(20),
    @SuDung bit,
    @GhiChu nvarchar(100)
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_DonViTinh]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_DonViTinh_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.DIC_DonViTinh */
        UPDATE [dbo].[DIC_DonViTinh]
        SET
            [Name] = @Name,
            [NameShort] = @NameShort,
            [SuDung] = @SuDung,
            [GhiChu] = @GhiChu
        WHERE
            [ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_DonViTinh_Info_Del] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_DonViTinh_Info_Del]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_DonViTinh_Info_Del]
GO

CREATE PROCEDURE [dbo].[DIC_DonViTinh_Info_Del]
    @ID int
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_DonViTinh]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_DonViTinh_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete DIC_DonViTinh_Info object from DIC_DonViTinh */
        DELETE
        FROM [dbo].[DIC_DonViTinh]
        WHERE
            [dbo].[DIC_DonViTinh].[ID] = @ID

    END
GO
