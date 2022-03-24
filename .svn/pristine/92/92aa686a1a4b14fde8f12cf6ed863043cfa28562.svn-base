/****** Object:  StoredProcedure [dbo].[DIC_Loai_Info_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_Loai_Info_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_Loai_Info_Add]
GO

CREATE PROCEDURE [dbo].[DIC_Loai_Info_Add]
    @ID int OUTPUT,
    @Ma varchar(10),
    @Ten nvarchar(100),
    @GhiChu nvarchar(100),
    @SuDung bit
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.DIC_Loai */
        INSERT INTO [dbo].[DIC_Loai]
        (
            [Ma],
            [Ten],
            [GhiChu],
            [SuDung]
        )
        VALUES
        (
            @Ma,
            @Ten,
            @GhiChu,
            @SuDung
        )

        /* Return new primary key */
        SET @ID = SCOPE_IDENTITY()

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_Loai_Info_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_Loai_Info_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_Loai_Info_Upd]
GO

CREATE PROCEDURE [dbo].[DIC_Loai_Info_Upd]
    @ID int,
    @Ma varchar(10),
    @Ten nvarchar(100),
    @GhiChu nvarchar(100),
    @SuDung bit
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_Loai]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_Loai_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.DIC_Loai */
        UPDATE [dbo].[DIC_Loai]
        SET
            [Ma] = @Ma,
            [Ten] = @Ten,
            [GhiChu] = @GhiChu,
            [SuDung] = @SuDung
        WHERE
            [ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_Loai_Info_Del] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_Loai_Info_Del]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_Loai_Info_Del]
GO

CREATE PROCEDURE [dbo].[DIC_Loai_Info_Del]
    @ID int
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_Loai]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_Loai_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete DIC_Loai_Info object from DIC_Loai */
        DELETE
        FROM [dbo].[DIC_Loai]
        WHERE
            [dbo].[DIC_Loai].[ID] = @ID

    END
GO
