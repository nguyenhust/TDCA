/****** Object:  StoredProcedure [dbo].[ADM_VaiTro_Info_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_VaiTro_Info_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_VaiTro_Info_Add]
GO

CREATE PROCEDURE [dbo].[ADM_VaiTro_Info_Add]
    @ID int OUTPUT,
    @TenVaiTro nvarchar(100)
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.ADM_VaiTro */
        INSERT INTO [dbo].[ADM_VaiTro]
        (
            [TenVaiTro]
        )
        VALUES
        (
            @TenVaiTro
        )

        /* Return new primary key */
        SET @ID = SCOPE_IDENTITY()

    END
GO

/****** Object:  StoredProcedure [dbo].[ADM_VaiTro_Info_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_VaiTro_Info_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_VaiTro_Info_Upd]
GO

CREATE PROCEDURE [dbo].[ADM_VaiTro_Info_Upd]
    @ID int,
    @TenVaiTro nvarchar(100)
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[ADM_VaiTro]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.ADM_VaiTro_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.ADM_VaiTro */
        UPDATE [dbo].[ADM_VaiTro]
        SET
            [TenVaiTro] = @TenVaiTro
        WHERE
            [ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[ADM_VaiTro_Info_Delete] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_VaiTro_Info_Delete]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_VaiTro_Info_Delete]
GO

CREATE PROCEDURE [dbo].[ADM_VaiTro_Info_Delete]
    @ID int
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[ADM_VaiTro]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.ADM_VaiTro_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete ADM_VaiTro_Info object from ADM_VaiTro */
        DELETE
        FROM [dbo].[ADM_VaiTro]
        WHERE
            [dbo].[ADM_VaiTro].[ID] = @ID

    END
GO
