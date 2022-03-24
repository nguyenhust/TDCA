/****** Object:  StoredProcedure [dbo].[TT_AnhVideo_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_AnhVideo_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[TT_AnhVideo_Get]
GO

CREATE PROCEDURE [dbo].[TT_AnhVideo_Get]
    @ID bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Get TT_AnhVideo from table */
        SELECT
            [TT_AnhVideo].[ID],
            [TT_AnhVideo].[IDSuKien],
            [TT_AnhVideo].[IDCanBo],
            [TT_AnhVideo].[Loai],
            [TT_AnhVideo].[SoLuong],
            [TT_AnhVideo].[DuongDan],
            [TT_AnhVideo].[GhiChu]
        FROM [dbo].[TT_AnhVideo]
        WHERE
            [TT_AnhVideo].[ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[TT_AnhVideo_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_AnhVideo_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[TT_AnhVideo_Add]
GO

CREATE PROCEDURE [dbo].[TT_AnhVideo_Add]
    @ID bigint OUTPUT,
    @IDSuKien bigint,
    @IDCanBo bigint,
    @Loai bit,
    @SoLuong int,
    @DuongDan nvarchar(200),
    @GhiChu nvarchar(200)
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.TT_AnhVideo */
        INSERT INTO [dbo].[TT_AnhVideo]
        (
            [IDSuKien],
            [IDCanBo],
            [Loai],
            [SoLuong],
            [DuongDan],
            [GhiChu]
        )
        VALUES
        (
            @IDSuKien,
            @IDCanBo,
            @Loai,
            @SoLuong,
            @DuongDan,
            @GhiChu
        )

        /* Return new primary key */
        SET @ID = SCOPE_IDENTITY()

    END
GO

/****** Object:  StoredProcedure [dbo].[TT_AnhVideo_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_AnhVideo_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[TT_AnhVideo_Upd]
GO

CREATE PROCEDURE [dbo].[TT_AnhVideo_Upd]
    @ID bigint,
    @IDSuKien bigint,
    @IDCanBo bigint,
    @Loai bit,
    @SoLuong int,
    @DuongDan nvarchar(200),
    @GhiChu nvarchar(200)
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[TT_AnhVideo]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.TT_AnhVideo'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.TT_AnhVideo */
        UPDATE [dbo].[TT_AnhVideo]
        SET
            [IDSuKien] = @IDSuKien,
            [IDCanBo] = @IDCanBo,
            [Loai] = @Loai,
            [SoLuong] = @SoLuong,
            [DuongDan] = @DuongDan,
            [GhiChu] = @GhiChu
        WHERE
            [ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[TT_AnhVideo_Delete] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_AnhVideo_Delete]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[TT_AnhVideo_Delete]
GO

CREATE PROCEDURE [dbo].[TT_AnhVideo_Delete]
    @ID bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[TT_AnhVideo]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.TT_AnhVideo'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete TT_AnhVideo object from TT_AnhVideo */
        DELETE
        FROM [dbo].[TT_AnhVideo]
        WHERE
            [dbo].[TT_AnhVideo].[ID] = @ID

    END
GO
