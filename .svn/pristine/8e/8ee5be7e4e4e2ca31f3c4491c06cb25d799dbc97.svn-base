/****** Object:  StoredProcedure [dbo].[TT_PhieuDangKyThietKe_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_PhieuDangKyThietKe_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[TT_PhieuDangKyThietKe_Get]
GO

CREATE PROCEDURE [dbo].[TT_PhieuDangKyThietKe_Get]
    @ID bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Get TT_PhieuDangKyThietKe from table */
        SELECT
            [TT_PhieuDangKyThietKe].[ID],
            [TT_PhieuDangKyThietKe].[NoiDung],
            [TT_PhieuDangKyThietKe].[IDLoai],
            [TT_PhieuDangKyThietKe].[TuNgay],
            [TT_PhieuDangKyThietKe].[DenNgay],
            [TT_PhieuDangKyThietKe].[IDCanBo],
            [TT_PhieuDangKyThietKe].[SLYeuCau],
            [TT_PhieuDangKyThietKe].[SLDuyet],
            [TT_PhieuDangKyThietKe].[TinhTrang],
            [TT_PhieuDangKyThietKe].[GhiChu]
        FROM [dbo].[TT_PhieuDangKyThietKe]
        WHERE
            [TT_PhieuDangKyThietKe].[ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[TT_PhieuDangKyThietKe_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_PhieuDangKyThietKe_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[TT_PhieuDangKyThietKe_Add]
GO
CREATE PROCEDURE [dbo].[TT_PhieuDangKyThietKe_Add]
    @NoiDung nvarchar(200),
    @IDLoai int,
    @TuNgay datetime,
    @DenNgay datetime,
    @IDCanBo bigint,
    @SLYeuCau int,
    @SLDuyet int,
    @TinhTrang int,
    @GhiChu nvarchar(100)
AS
    BEGIN
        SET NOCOUNT ON
        /* Insert object into dbo.TT_PhieuDangKyThietKe */
        INSERT INTO [dbo].[TT_PhieuDangKyThietKe]
        (            
            [NoiDung],
            [IDLoai],
            [TuNgay],
            [DenNgay],
            [IDCanBo],
            [SLYeuCau],
            [SLDuyet],
            [TinhTrang],
            [GhiChu]
        )
        VALUES
        (
            @NoiDung,
            @IDLoai,
            @TuNgay,
            @DenNgay,
            @IDCanBo,
            @SLYeuCau,
            @SLDuyet,
            @TinhTrang,
            @GhiChu
        )
    END
GO

/****** Object:  StoredProcedure [dbo].[TT_PhieuDangKyThietKe_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_PhieuDangKyThietKe_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[TT_PhieuDangKyThietKe_Upd]
GO

CREATE PROCEDURE [dbo].[TT_PhieuDangKyThietKe_Upd]
    @ID bigint,
    @NoiDung nvarchar(200),
    @IDLoai int,
    @TuNgay datetime,
    @DenNgay datetime,
    @IDCanBo bigint,
    @SLYeuCau int,
    @SLDuyet int,
    @TinhTrang int,
    @GhiChu nvarchar(100)
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[TT_PhieuDangKyThietKe]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.TT_PhieuDangKyThietKe'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.TT_PhieuDangKyThietKe */
        UPDATE [dbo].[TT_PhieuDangKyThietKe]
        SET
            [NoiDung] = @NoiDung,
            [IDLoai] = @IDLoai,
            [TuNgay] = @TuNgay,
            [DenNgay] = @DenNgay,
            [IDCanBo] = @IDCanBo,
            [SLYeuCau] = @SLYeuCau,
            [SLDuyet] = @SLDuyet,
            [TinhTrang] = @TinhTrang,
            [GhiChu] = @GhiChu
        WHERE
            [ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[TT_PhieuDangKyThietKe_Delete] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_PhieuDangKyThietKe_Delete]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[TT_PhieuDangKyThietKe_Delete]
GO

CREATE PROCEDURE [dbo].[TT_PhieuDangKyThietKe_Delete]
    @ID bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[TT_PhieuDangKyThietKe]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.TT_PhieuDangKyThietKe'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete TT_PhieuDangKyThietKe object from TT_PhieuDangKyThietKe */
        DELETE
        FROM [dbo].[TT_PhieuDangKyThietKe]
        WHERE
            [dbo].[TT_PhieuDangKyThietKe].[ID] = @ID

    END
GO
