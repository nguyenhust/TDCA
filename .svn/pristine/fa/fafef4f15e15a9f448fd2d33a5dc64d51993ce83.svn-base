/****** Object:  StoredProcedure [dbo].[TT_BaiViet_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_BaiViet_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[TT_BaiViet_Get]
GO

CREATE PROCEDURE [dbo].[TT_BaiViet_Get]
    @ID bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Get TT_BaiViet from table */
        SELECT
            [TT_BaiViet].[ID],
            [TT_BaiViet].[TacGia],
            [TT_BaiViet].[TieuDe],
            [TT_BaiViet].[NoiDung],
            [TT_BaiViet].[IDLoai],
            [TT_BaiViet].[ThoiGianDang],
            [TT_BaiViet].[ThoiGianDuyet],
            [TT_BaiViet].[NguoiDuyet],
            [TT_BaiViet].[Link],
            [TT_BaiViet].[DuongDan],
            [TT_BaiViet].[GhiChu]
        FROM [dbo].[TT_BaiViet]
        WHERE
            [TT_BaiViet].[ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[TT_BaiViet_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_BaiViet_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[TT_BaiViet_Add]
GO

CREATE PROCEDURE [dbo].[TT_BaiViet_Add]
    @ID bigint OUTPUT,
    @TacGia nvarchar(50),
    @TieuDe nvarchar(100),
    @NoiDung nvarchar(1000),
    @IDLoai int,
    @ThoiGianDang datetime,
    @ThoiGianDuyet datetime,
    @NguoiDuyet nvarchar(50),
    @Link nvarchar(200),
    @DuongDan nvarchar(200),
    @GhiChu nvarchar(100)
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.TT_BaiViet */
        INSERT INTO [dbo].[TT_BaiViet]
        (
            [TacGia],
            [TieuDe],
            [NoiDung],
            [IDLoai],
            [ThoiGianDang],
            [ThoiGianDuyet],
            [NguoiDuyet],
            [Link],
            [DuongDan],
            [GhiChu]
        )
        VALUES
        (
            @TacGia,
            @TieuDe,
            @NoiDung,
            @IDLoai,
            @ThoiGianDang,
            @ThoiGianDuyet,
            @NguoiDuyet,
            @Link,
            @DuongDan,
            @GhiChu
        )

        /* Return new primary key */
        SET @ID = SCOPE_IDENTITY()

    END
GO

/****** Object:  StoredProcedure [dbo].[TT_BaiViet_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_BaiViet_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[TT_BaiViet_Upd]
GO

CREATE PROCEDURE [dbo].[TT_BaiViet_Upd]
    @ID bigint,
    @TacGia nvarchar(50),
    @TieuDe nvarchar(100),
    @NoiDung nvarchar(1000),
    @IDLoai int,
    @ThoiGianDang datetime,
    @ThoiGianDuyet datetime,
    @NguoiDuyet nvarchar(50),
    @Link nvarchar(200),
    @DuongDan nvarchar(200),
    @GhiChu nvarchar(100)
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[TT_BaiViet]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.TT_BaiViet'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.TT_BaiViet */
        UPDATE [dbo].[TT_BaiViet]
        SET
            [TacGia] = @TacGia,
            [TieuDe] = @TieuDe,
            [NoiDung] = @NoiDung,
            [IDLoai] = @IDLoai,
            [ThoiGianDang] = @ThoiGianDang,
            [ThoiGianDuyet] = @ThoiGianDuyet,
            [NguoiDuyet] = @NguoiDuyet,
            [Link] = @Link,
            [DuongDan] = @DuongDan,
            [GhiChu] = @GhiChu
        WHERE
            [ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[TT_BaiViet_Delete] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_BaiViet_Delete]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[TT_BaiViet_Delete]
GO

CREATE PROCEDURE [dbo].[TT_BaiViet_Delete]
    @ID bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[TT_BaiViet]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.TT_BaiViet'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete TT_BaiViet object from TT_BaiViet */
        DELETE
        FROM [dbo].[TT_BaiViet]
        WHERE
            [dbo].[TT_BaiViet].[ID] = @ID

    END
GO
