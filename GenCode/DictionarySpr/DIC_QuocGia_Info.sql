/****** Object:  StoredProcedure [dbo].[DIC_QuocGia_Info_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_QuocGia_Info_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_QuocGia_Info_Add]
GO

CREATE PROCEDURE [dbo].[DIC_QuocGia_Info_Add]
    @ID int OUTPUT,
    @TenQuocGia nvarchar(50),
    @SuDung bit
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.DIC_QuocGia */
        INSERT INTO [dbo].[DIC_QuocGia]
        (
            [TenQuocGia],
            [SuDung]
        )
        VALUES
        (
            @TenQuocGia,
            @SuDung
        )

        /* Return new primary key */
        SET @ID = SCOPE_IDENTITY()

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_QuocGia_Info_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_QuocGia_Info_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_QuocGia_Info_Upd]
GO

CREATE PROCEDURE [dbo].[DIC_QuocGia_Info_Upd]
    @ID int,
    @TenQuocGia nvarchar(50),
    @SuDung bit
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_QuocGia]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_QuocGia_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.DIC_QuocGia */
        UPDATE [dbo].[DIC_QuocGia]
        SET
            [TenQuocGia] = @TenQuocGia,
            [SuDung] = @SuDung
        WHERE
            [ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_QuocGia_Info_Del] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_QuocGia_Info_Del]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_QuocGia_Info_Del]
GO

CREATE PROCEDURE [dbo].[DIC_QuocGia_Info_Del]
    @ID int
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_QuocGia]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_QuocGia_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete DIC_QuocGia_Info object from DIC_QuocGia */
        DELETE
        FROM [dbo].[DIC_QuocGia]
        WHERE
            [dbo].[DIC_QuocGia].[ID] = @ID

    END
GO
