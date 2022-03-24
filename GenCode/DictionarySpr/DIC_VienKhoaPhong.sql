/****** Object:  StoredProcedure [dbo].[DIC_VienKhoaPhong_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_VienKhoaPhong_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_VienKhoaPhong_Get]
GO

CREATE PROCEDURE [dbo].[DIC_VienKhoaPhong_Get]
    @IDKhoa bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DIC_VienKhoaPhong from table */
        SELECT
            [DIC_VienKhoaPhong].[IDKhoa],
            [DIC_VienKhoaPhong].[MaKhoa],
            [DIC_VienKhoaPhong].[TenKhoa],
            [DIC_VienKhoaPhong].[MaNhanDang],
            [DIC_VienKhoaPhong].[YTaTruong],
            [DIC_VienKhoaPhong].[TruongKhoa],
            [DIC_VienKhoaPhong].[TenTat],
            [DIC_VienKhoaPhong].[SuDung]
        FROM [dbo].[DIC_VienKhoaPhong]
        WHERE
            [DIC_VienKhoaPhong].[IDKhoa] = @IDKhoa

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_VienKhoaPhong_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_VienKhoaPhong_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_VienKhoaPhong_Add]
GO

CREATE PROCEDURE [dbo].[DIC_VienKhoaPhong_Add]
    @IDKhoa bigint OUTPUT,
    @MaKhoa smallint,
    @TenKhoa nvarchar(50),
    @MaNhanDang nvarchar(1),
    @YTaTruong nvarchar(50),
    @TruongKhoa nvarchar(50),
    @TenTat nvarchar(50),
    @SuDung bit
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.DIC_VienKhoaPhong */
        INSERT INTO [dbo].[DIC_VienKhoaPhong]
        (
            [MaKhoa],
            [TenKhoa],
            [MaNhanDang],
            [YTaTruong],
            [TruongKhoa],
            [TenTat],
            [SuDung]
        )
        VALUES
        (
            @MaKhoa,
            @TenKhoa,
            @MaNhanDang,
            @YTaTruong,
            @TruongKhoa,
            @TenTat,
            @SuDung
        )

        /* Return new primary key */
        SET @IDKhoa = SCOPE_IDENTITY()

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_VienKhoaPhong_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_VienKhoaPhong_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_VienKhoaPhong_Upd]
GO

CREATE PROCEDURE [dbo].[DIC_VienKhoaPhong_Upd]
    @IDKhoa bigint,
    @MaKhoa smallint,
    @TenKhoa nvarchar(50),
    @MaNhanDang nvarchar(1),
    @YTaTruong nvarchar(50),
    @TruongKhoa nvarchar(50),
    @TenTat nvarchar(50),
    @SuDung bit
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [IDKhoa] FROM [dbo].[DIC_VienKhoaPhong]
            WHERE
                [IDKhoa] = @IDKhoa
        )
        BEGIN
            RAISERROR ('''dbo.DIC_VienKhoaPhong'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.DIC_VienKhoaPhong */
        UPDATE [dbo].[DIC_VienKhoaPhong]
        SET
            [MaKhoa] = @MaKhoa,
            [TenKhoa] = @TenKhoa,
            [MaNhanDang] = @MaNhanDang,
            [YTaTruong] = @YTaTruong,
            [TruongKhoa] = @TruongKhoa,
            [TenTat] = @TenTat,
            [SuDung] = @SuDung
        WHERE
            [IDKhoa] = @IDKhoa

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_VienKhoaPhong_Delete] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_VienKhoaPhong_Delete]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_VienKhoaPhong_Delete]
GO

CREATE PROCEDURE [dbo].[DIC_VienKhoaPhong_Delete]
    @IDKhoa bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [IDKhoa] FROM [dbo].[DIC_VienKhoaPhong]
            WHERE
                [IDKhoa] = @IDKhoa
        )
        BEGIN
            RAISERROR ('''dbo.DIC_VienKhoaPhong'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete DIC_VienKhoaPhong object from DIC_VienKhoaPhong */
        DELETE
        FROM [dbo].[DIC_VienKhoaPhong]
        WHERE
            [dbo].[DIC_VienKhoaPhong].[IDKhoa] = @IDKhoa

    END
GO
