/****** Object:  StoredProcedure [dbo].[DIC_ChucVu_Info_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_ChucVu_Info_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_ChucVu_Info_Add]
GO

CREATE PROCEDURE [dbo].[DIC_ChucVu_Info_Add]
    @ID int OUTPUT,
    @Ten nvarchar(50),
    @GhiChu nvarchar(100),
    @SuDung bit
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.DIC_ChucVu */
        INSERT INTO [dbo].[DIC_ChucVu]
        (
            [Ten],
            [GhiChu],
            [SuDung]
        )
        VALUES
        (
            @Ten,
            @GhiChu,
            @SuDung
        )

        /* Return new primary key */
        SET @ID = SCOPE_IDENTITY()

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_ChucVu_Info_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_ChucVu_Info_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_ChucVu_Info_Upd]
GO

CREATE PROCEDURE [dbo].[DIC_ChucVu_Info_Upd]
    @ID int,
    @Ten nvarchar(50),
    @GhiChu nvarchar(100),
    @SuDung bit
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_ChucVu]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_ChucVu_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.DIC_ChucVu */
        UPDATE [dbo].[DIC_ChucVu]
        SET
            [Ten] = @Ten,
            [GhiChu] = @GhiChu,
            [SuDung] = @SuDung
        WHERE
            [ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_ChucVu_Info_Del] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_ChucVu_Info_Del]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_ChucVu_Info_Del]
GO

CREATE PROCEDURE [dbo].[DIC_ChucVu_Info_Del]
    @ID int
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_ChucVu]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_ChucVu_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete DIC_ChucVu_Info object from DIC_ChucVu */
        DELETE
        FROM [dbo].[DIC_ChucVu]
        WHERE
            [dbo].[DIC_ChucVu].[ID] = @ID

    END
GO
