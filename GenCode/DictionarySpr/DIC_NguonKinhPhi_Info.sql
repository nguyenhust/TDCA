/****** Object:  StoredProcedure [dbo].[DIC_NguonKinhPhi_Info_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_NguonKinhPhi_Info_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_NguonKinhPhi_Info_Add]
GO

CREATE PROCEDURE [dbo].[DIC_NguonKinhPhi_Info_Add]
    @ID int OUTPUT,
    @Ten nvarchar(100),
    @GhiChu nvarchar(100),
    @SuDung bit
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.DIC_NguonKinhPhi */
        INSERT INTO [dbo].[DIC_NguonKinhPhi]
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

/****** Object:  StoredProcedure [dbo].[DIC_NguonKinhPhi_Info_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_NguonKinhPhi_Info_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_NguonKinhPhi_Info_Upd]
GO

CREATE PROCEDURE [dbo].[DIC_NguonKinhPhi_Info_Upd]
    @ID int,
    @Ten nvarchar(100),
    @GhiChu nvarchar(100),
    @SuDung bit
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_NguonKinhPhi]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_NguonKinhPhi_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.DIC_NguonKinhPhi */
        UPDATE [dbo].[DIC_NguonKinhPhi]
        SET
            [Ten] = @Ten,
            [GhiChu] = @GhiChu,
            [SuDung] = @SuDung
        WHERE
            [ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_NguonKinhPhi_Info_Del] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_NguonKinhPhi_Info_Del]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_NguonKinhPhi_Info_Del]
GO

CREATE PROCEDURE [dbo].[DIC_NguonKinhPhi_Info_Del]
    @ID int
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_NguonKinhPhi]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_NguonKinhPhi_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete DIC_NguonKinhPhi_Info object from DIC_NguonKinhPhi */
        DELETE
        FROM [dbo].[DIC_NguonKinhPhi]
        WHERE
            [dbo].[DIC_NguonKinhPhi].[ID] = @ID

    END
GO
