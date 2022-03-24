/****** Object:  StoredProcedure [dbo].[ADM_ThanhVien_Info_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_ThanhVien_Info_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_ThanhVien_Info_Add]
GO

CREATE PROCEDURE [dbo].[ADM_ThanhVien_Info_Add]
    @IDNguoiDung bigint,@IDQuyenDuocPhan BIGINT,
    @IDNhomNguoiDung bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.ADM_ThanhVien */
        INSERT INTO [dbo].[ADM_ThanhVien]
        (
            [IDNguoiDung],
            [IDNhomNguoiDung]
        )
        VALUES
        (
            @IDNguoiDung,
            @IDNhomNguoiDung
        )

    END
GO

/****** Object:  StoredProcedure [dbo].[ADM_ThanhVien_Info_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_ThanhVien_Info_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_ThanhVien_Info_Upd]
GO

CREATE PROCEDURE [dbo].[ADM_ThanhVien_Info_Upd]
    @IDQuyenDuocPhan bigint,
    @IDNhomNguoiDung bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Update object in dbo.ADM_ThanhVien */
        UPDATE [dbo].[ADM_ThanhVien]
        SET
            [IDNhomNguoiDung] = @IDNhomNguoiDung
        WHERE
            [IDQuyenDuocPhan] = @IDQuyenDuocPhan

    END
GO

/****** Object:  StoredProcedure [dbo].[ADM_ThanhVien_Info_Delete] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_ThanhVien_Info_Delete]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_ThanhVien_Info_Delete]
GO

CREATE PROCEDURE [dbo].[ADM_ThanhVien_Info_Delete]
    @IDQuyenDuocPhan bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [IDNhomNguoiDung] FROM [dbo].[ADM_ThanhVien]
            WHERE
                IDQuyenDuocPhan = @IDQuyenDuocPhan
        )
        BEGIN
            RAISERROR ('''dbo.ADM_ThanhVien_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete ADM_ThanhVien_Info object from ADM_ThanhVien */
        DELETE
        FROM [dbo].[ADM_ThanhVien]
        WHERE
            [dbo].[ADM_ThanhVien].IDQuyenDuocPhan = @IDQuyenDuocPhan

    END
GO
