/****** Object:  StoredProcedure [dbo].[DIC_HocHam_Info_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_HocHam_Info_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_HocHam_Info_Add]
GO

CREATE PROCEDURE [dbo].[DIC_HocHam_Info_Add]
    @ID int OUTPUT,
    @TenHocHam nvarchar(50),
    @SuDung bit
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.DIC_HocHam */
        INSERT INTO [dbo].[DIC_HocHam]
        (
            [TenHocHam],
            [SuDung]
        )
        VALUES
        (
            @TenHocHam,
            @SuDung
        )

        /* Return new primary key */
        SET @ID = SCOPE_IDENTITY()

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_HocHam_Info_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_HocHam_Info_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_HocHam_Info_Upd]
GO

CREATE PROCEDURE [dbo].[DIC_HocHam_Info_Upd]
    @ID int,
    @TenHocHam nvarchar(50),
    @SuDung bit
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_HocHam]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_HocHam_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.DIC_HocHam */
        UPDATE [dbo].[DIC_HocHam]
        SET
            [TenHocHam] = @TenHocHam,
            [SuDung] = @SuDung
        WHERE
            [ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_HocHam_Info_Del] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_HocHam_Info_Del]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_HocHam_Info_Del]
GO

CREATE PROCEDURE [dbo].[DIC_HocHam_Info_Del]
    @ID int
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_HocHam]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_HocHam_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete DIC_HocHam_Info object from DIC_HocHam */
        DELETE
        FROM [dbo].[DIC_HocHam]
        WHERE
            [dbo].[DIC_HocHam].[ID] = @ID

    END
GO
