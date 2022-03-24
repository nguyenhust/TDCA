/****** Object:  StoredProcedure [dbo].[TT_SuKien_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_SuKien_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[TT_SuKien_Get]
GO

CREATE PROCEDURE [dbo].[TT_SuKien_Get]
    @ID bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Get TT_SuKien from table */
        SELECT
            [TT_SuKien].[ID],
            [TT_SuKien].[Ten],
            [TT_SuKien].[IDChuyenNganh],
            [TT_SuKien].[DiaDiem],
            [TT_SuKien].[ThoiGian],
            [TT_SuKien].[IDLoai],
            [TT_SuKien].[ChuTri],
            [TT_SuKien].[GhiChu]
        FROM [dbo].[TT_SuKien]
        WHERE
            [TT_SuKien].[ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[TT_SuKien_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_SuKien_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[TT_SuKien_Add]
GO

CREATE PROCEDURE [dbo].[TT_SuKien_Add]
    @ID bigint OUTPUT,
    @Ten nvarchar(300),
    @IDChuyenNganh int,
    @DiaDiem nvarchar(300),
    @ThoiGian datetime,
    @IDLoai int,
    @ChuTri nvarchar(100),
    @GhiChu nvarchar(100)
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.TT_SuKien */
        INSERT INTO [dbo].[TT_SuKien]
        (
            [Ten],
            [IDChuyenNganh],
            [DiaDiem],
            [ThoiGian],
            [IDLoai],
            [ChuTri],
            [GhiChu]
        )
        VALUES
        (
            @Ten,
            @IDChuyenNganh,
            @DiaDiem,
            @ThoiGian,
            @IDLoai,
            @ChuTri,
            @GhiChu
        )

        /* Return new primary key */
        SET @ID = SCOPE_IDENTITY()

    END
GO

/****** Object:  StoredProcedure [dbo].[TT_SuKien_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_SuKien_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[TT_SuKien_Upd]
GO

CREATE PROCEDURE [dbo].[TT_SuKien_Upd]
    @ID bigint,
    @Ten nvarchar(300),
    @IDChuyenNganh int,
    @DiaDiem nvarchar(300),
    @ThoiGian datetime,
    @IDLoai int,
    @ChuTri nvarchar(100),
    @GhiChu nvarchar(100)
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[TT_SuKien]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.TT_SuKien'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.TT_SuKien */
        UPDATE [dbo].[TT_SuKien]
        SET
            [Ten] = @Ten,
            [IDChuyenNganh] = @IDChuyenNganh,
            [DiaDiem] = @DiaDiem,
            [ThoiGian] = @ThoiGian,
            [IDLoai] = @IDLoai,
            [ChuTri] = @ChuTri,
            [GhiChu] = @GhiChu
        WHERE
            [ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[TT_SuKien_Delete] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_SuKien_Delete]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[TT_SuKien_Delete]
GO

CREATE PROCEDURE [dbo].[TT_SuKien_Delete]
    @ID bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[TT_SuKien]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.TT_SuKien'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete TT_SuKien object from TT_SuKien */
        DELETE
        FROM [dbo].[TT_SuKien]
        WHERE
            [dbo].[TT_SuKien].[ID] = @ID

    END
GO
