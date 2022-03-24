/****** Object:  StoredProcedure [dbo].[DIC_GioiTInh_Info_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_GioiTInh_Info_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_GioiTInh_Info_Add]
GO

CREATE PROCEDURE [dbo].[DIC_GioiTInh_Info_Add]
    @ID int OUTPUT,
    @Ten nvarchar(10),
    @GhiChu nvarchar(100),
    @SuDung bit
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.DIC_GioiTinh */
        INSERT INTO [dbo].[DIC_GioiTinh]
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

/****** Object:  StoredProcedure [dbo].[DIC_GioiTInh_Info_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_GioiTInh_Info_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_GioiTInh_Info_Upd]
GO

CREATE PROCEDURE [dbo].[DIC_GioiTInh_Info_Upd]
    @ID int,
    @Ten nvarchar(10),
    @GhiChu nvarchar(100),
    @SuDung bit
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_GioiTinh]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_GioiTInh_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.DIC_GioiTinh */
        UPDATE [dbo].[DIC_GioiTinh]
        SET
            [Ten] = @Ten,
            [GhiChu] = @GhiChu,
            [SuDung] = @SuDung
        WHERE
            [ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_GioiTInh_Info_Delete] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_GioiTInh_Info_Delete]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_GioiTInh_Info_Delete]
GO

CREATE PROCEDURE [dbo].[DIC_GioiTInh_Info_Delete]
    @ID int
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_GioiTinh]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_GioiTInh_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete DIC_GioiTInh_Info object from DIC_GioiTinh */
        DELETE
        FROM [dbo].[DIC_GioiTinh]
        WHERE
            [dbo].[DIC_GioiTinh].[ID] = @ID

    END
GO
