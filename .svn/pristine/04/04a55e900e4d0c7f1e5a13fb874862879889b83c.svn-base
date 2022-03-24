/****** Object:  StoredProcedure [dbo].[DIC_CoQuan_Info_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_CoQuan_Info_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_CoQuan_Info_Add]
GO

CREATE PROCEDURE [dbo].[DIC_CoQuan_Info_Add]
    @ID int OUTPUT,
    @Ten nvarchar(100),
    @DiaChi nvarchar(100),
    @SuDung bit,
    @GhiChu nvarchar(100)
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.DIC_CoQuan */
        INSERT INTO [dbo].[DIC_CoQuan]
        (
            [Ten],
            [DiaChi],
            [SuDung],
            [GhiChu]
        )
        VALUES
        (
            @Ten,
            @DiaChi,
            @SuDung,
            @GhiChu
        )

        /* Return new primary key */
        SET @ID = SCOPE_IDENTITY()

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_CoQuan_Info_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_CoQuan_Info_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_CoQuan_Info_Upd]
GO

CREATE PROCEDURE [dbo].[DIC_CoQuan_Info_Upd]
    @ID int,
    @Ten nvarchar(100),
    @DiaChi nvarchar(100),
    @SuDung bit,
    @GhiChu nvarchar(100)
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_CoQuan]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_CoQuan_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.DIC_CoQuan */
        UPDATE [dbo].[DIC_CoQuan]
        SET
            [Ten] = @Ten,
            [DiaChi] = @DiaChi,
            [SuDung] = @SuDung,
            [GhiChu] = @GhiChu
        WHERE
            [ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_CoQuan_Info_Del] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_CoQuan_Info_Del]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_CoQuan_Info_Del]
GO

CREATE PROCEDURE [dbo].[DIC_CoQuan_Info_Del]
    @ID int
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_CoQuan]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_CoQuan_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete DIC_CoQuan_Info object from DIC_CoQuan */
        DELETE
        FROM [dbo].[DIC_CoQuan]
        WHERE
            [dbo].[DIC_CoQuan].[ID] = @ID

    END
GO
