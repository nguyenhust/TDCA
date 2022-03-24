/****** Object:  StoredProcedure [dbo].[DIC_DanToc_Info_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_DanToc_Info_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_DanToc_Info_Add]
GO

CREATE PROCEDURE [dbo].[DIC_DanToc_Info_Add]
    @ID int OUTPUT,
    @Ma varchar(2),
    @Ten nvarchar(20),
    @GhiChu nvarchar(100),
    @SuDung bit
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.DIC_DanToc */
        INSERT INTO [dbo].[DIC_DanToc]
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

/****** Object:  StoredProcedure [dbo].[DIC_DanToc_Info_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_DanToc_Info_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_DanToc_Info_Upd]
GO

CREATE PROCEDURE [dbo].[DIC_DanToc_Info_Upd]
    @ID int,
    @Ma varchar(2),
    @Ten nvarchar(20),
    @GhiChu nvarchar(100),
    @SuDung bit
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_DanToc]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_DanToc_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.DIC_DanToc */
        UPDATE [dbo].[DIC_DanToc]
        SET
            [Ma] = @Ma,
            [Ten] = @Ten,
            [GhiChu] = @GhiChu,
            [SuDung] = @SuDung
        WHERE
            [ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_DanToc_Info_Del] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_DanToc_Info_Del]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_DanToc_Info_Del]
GO

CREATE PROCEDURE [dbo].[DIC_DanToc_Info_Del]
    @ID int
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_DanToc]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_DanToc_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete DIC_DanToc_Info object from DIC_DanToc */
        DELETE
        FROM [dbo].[DIC_DanToc]
        WHERE
            [dbo].[DIC_DanToc].[ID] = @ID

    END
GO
