/****** Object:  StoredProcedure [dbo].[ADM_QuyenNguoiDung_Info_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_QuyenNguoiDung_Info_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_QuyenNguoiDung_Info_Add]
GO

CREATE PROCEDURE [dbo].[ADM_QuyenNguoiDung_Info_Add]
    @IDNguoiDung bigint,@IDQuyenND BIGINT,
    @IDChucNang int,
    @ThemMoi bit,
    @Xoa bit,
    @Sua bit,
    @Xem bit,
    @TatCa bit
AS
    BEGIN
		
        SET NOCOUNT ON

		IF @TatCa = 1
		BEGIN
			set @ThemMoi = 1
			set @Xem = 1
			set @Xoa = 1
			set @Sua = 1
		END
		-- check người dùng này đã sở hữu chức năng này chưa. Nếu sở hữu rồi thì không cho thêm mới
		IF EXISTS(SELECT  1 FROM ADM_QuyenNguoiDung aqnd WHERE aqnd.IDChucNang = @IDChucNang AND aqnd.IDNguoiDung = @IDNguoiDung)
		BEGIN
			DECLARE @ChucNang NVARCHAR(100)
			SET @ChucNang = (SELECT acn.TenCN FROM ADM_ChucNang acn WHERE acn.IDCN = @IDChucNang)
			RAISERROR(N'Chức năng [%s] này người dùng đã sở hữu. Bạn hãy xem lại nhé',16,1,@ChucNang)
		END

        /* Insert object into dbo.ADM_QuyenNguoiDung */
        INSERT INTO [dbo].[ADM_QuyenNguoiDung]
        (
            [IDNguoiDung],
            [IDChucNang],
            [ThemMoi],
            [Xoa],
            [Sua],
            [Xem],
            [TatCa]
        )
        VALUES
        (
            @IDNguoiDung,
            @IDChucNang,
            @ThemMoi,
            @Xoa,
            @Sua,
            @Xem,
            @TatCa
        )

    END
GO

/****** Object:  StoredProcedure [dbo].[ADM_QuyenNguoiDung_Info_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_QuyenNguoiDung_Info_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_QuyenNguoiDung_Info_Upd]
GO

CREATE PROCEDURE [dbo].[ADM_QuyenNguoiDung_Info_Upd]
    @IDQuyenND bigint,
    @IDChucNang int,
    @ThemMoi bit,
    @Xoa bit,
    @Sua bit,
    @Xem bit,
    @TatCa bit
AS
    BEGIN

        SET NOCOUNT ON

		IF @TatCa = 1
		BEGIN
			set @ThemMoi = 1
			set @Xem = 1
			set @Xoa = 1
			set @Sua = 1
		END

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [IDChucNang] FROM [dbo].[ADM_QuyenNguoiDung]
            WHERE
                [IDQuyenND] = @IDQuyenND
        )
        BEGIN
            RAISERROR ('''dbo.ADM_QuyenNguoiDung_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.ADM_QuyenNguoiDung */
        UPDATE [dbo].[ADM_QuyenNguoiDung]
        SET
            [ThemMoi] = @ThemMoi,
            [Xoa] = @Xoa,
            [Sua] = @Sua,
            [Xem] = @Xem,
            [TatCa] = @TatCa
        WHERE
            [IDQuyenND] = @IDQuyenND

    END
GO

/****** Object:  StoredProcedure [dbo].[ADM_QuyenNguoiDung_Info_Delete] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_QuyenNguoiDung_Info_Delete]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_QuyenNguoiDung_Info_Delete]
GO

CREATE PROCEDURE [dbo].[ADM_QuyenNguoiDung_Info_Delete]
    @IDQuyenND BIGINT
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [IDChucNang] FROM [dbo].[ADM_QuyenNguoiDung]
            WHERE
                [IDQuyenND] = @IDQuyenND
        )
        BEGIN
            RAISERROR ('''dbo.ADM_QuyenNguoiDung_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete ADM_QuyenNguoiDung_Info object from ADM_QuyenNguoiDung */
        DELETE
        FROM [dbo].[ADM_QuyenNguoiDung]
        WHERE
            [dbo].[ADM_QuyenNguoiDung].[IDQuyenND] = @IDQuyenND

    END
GO
