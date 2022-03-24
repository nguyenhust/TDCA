/****** Object:  StoredProcedure [dbo].[DIC_BoPhan_Info_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_BoPhan_Info_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_BoPhan_Info_Add]
GO

CREATE PROCEDURE [dbo].[DIC_BoPhan_Info_Add]
    @ID int OUTPUT,
    @Ten nvarchar(50),
    @Ma varchar(10),
    @SuDung bit,
    @GhiChu nvarchar(100)
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.DIC_BoPhan */
        INSERT INTO [dbo].[DIC_BoPhan]
        (
            [Ten],
            [Ma],
            [SuDung],
            [GhiChu]
        )
        VALUES
        (
            @Ten,
            @Ma,
            @SuDung,
            @GhiChu
        )

        /* Return new primary key */
        SET @ID = SCOPE_IDENTITY()

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_BoPhan_Info_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_BoPhan_Info_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_BoPhan_Info_Upd]
GO

CREATE PROCEDURE [dbo].[DIC_BoPhan_Info_Upd]
    @ID int,
    @Ten nvarchar(50),
    @Ma varchar(10),
    @SuDung bit,
    @GhiChu nvarchar(100)
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_BoPhan]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_BoPhan_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.DIC_BoPhan */
        UPDATE [dbo].[DIC_BoPhan]
        SET
            [Ten] = @Ten,
            [Ma] = @Ma,
            [SuDung] = @SuDung,
            [GhiChu] = @GhiChu
        WHERE
            [ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_BoPhan_Info_Del] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_BoPhan_Info_Del]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_BoPhan_Info_Del]
GO

CREATE PROCEDURE [dbo].[DIC_BoPhan_Info_Del]
    @ID int
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_BoPhan]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_BoPhan_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete DIC_BoPhan_Info object from DIC_BoPhan */
        DELETE
        FROM [dbo].[DIC_BoPhan]
        WHERE
            [dbo].[DIC_BoPhan].[ID] = @ID

    END
GO
