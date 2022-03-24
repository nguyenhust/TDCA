/****** Object:  StoredProcedure [dbo].[TT_AnPham_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_AnPham_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[TT_AnPham_Get]
GO

CREATE PROCEDURE [dbo].[TT_AnPham_Get]
    @ID bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Get TT_AnPham from table */
        SELECT
            [TT_AnPham].[ID],
            [TT_AnPham].[Ten],
            [TT_AnPham].[IDLoai],
            [TT_AnPham].[DonViDat],
            [TT_AnPham].[NoiDung],
            [TT_AnPham].[SoLuong],
            [TT_AnPham].[TuNgay],
            [TT_AnPham].[DenNgay],
            [TT_AnPham].[GhiChu]
        FROM [dbo].[TT_AnPham]
        WHERE
            [TT_AnPham].[ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[TT_AnPham_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_AnPham_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[TT_AnPham_Add]
GO

CREATE PROCEDURE [dbo].[TT_AnPham_Add]
    @ID bigint OUTPUT,
    @Ten nvarchar(100),
    @IDLoai int,
    @DonViDat nvarchar(200),
    @NoiDung nvarchar(200),
    @SoLuong int,
    @TuNgay datetime,
    @DenNgay datetime,
    @GhiChu nvarchar(100)
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.TT_AnPham */
        INSERT INTO [dbo].[TT_AnPham]
        (
            [Ten],
            [IDLoai],
            [DonViDat],
            [NoiDung],
            [SoLuong],
            [TuNgay],
            [DenNgay],
            [GhiChu]
        )
        VALUES
        (
            @Ten,
            @IDLoai,
            @DonViDat,
            @NoiDung,
            @SoLuong,
            @TuNgay,
            @DenNgay,
            @GhiChu
        )

        /* Return new primary key */
        SET @ID = SCOPE_IDENTITY()

    END
GO

/****** Object:  StoredProcedure [dbo].[TT_AnPham_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_AnPham_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[TT_AnPham_Upd]
GO

CREATE PROCEDURE [dbo].[TT_AnPham_Upd]
    @ID bigint,
    @Ten nvarchar(100),
    @IDLoai int,
    @DonViDat nvarchar(200),
    @NoiDung nvarchar(200),
    @SoLuong int,
    @TuNgay datetime,
    @DenNgay datetime,
    @GhiChu nvarchar(100)
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[TT_AnPham]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.TT_AnPham'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.TT_AnPham */
        UPDATE [dbo].[TT_AnPham]
        SET
            [Ten] = @Ten,
            [IDLoai] = @IDLoai,
            [DonViDat] = @DonViDat,
            [NoiDung] = @NoiDung,
            [SoLuong] = @SoLuong,
            [TuNgay] = @TuNgay,
            [DenNgay] = @DenNgay,
            [GhiChu] = @GhiChu
        WHERE
            [ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[TT_AnPham_Delete] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_AnPham_Delete]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[TT_AnPham_Delete]
GO

CREATE PROCEDURE [dbo].[TT_AnPham_Delete]
    @ID bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[TT_AnPham]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.TT_AnPham'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete TT_AnPham object from TT_AnPham */
        DELETE
        FROM [dbo].[TT_AnPham]
        WHERE
            [dbo].[TT_AnPham].[ID] = @ID

    END
GO
