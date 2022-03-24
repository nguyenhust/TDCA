/****** Object:  StoredProcedure [dbo].[ADM_QuyenNhomNguoiDung_Info_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_QuyenNhomNguoiDung_Info_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_QuyenNhomNguoiDung_Info_Add]
GO

CREATE PROCEDURE [dbo].[ADM_QuyenNhomNguoiDung_Info_Add]
    @IDQuyenNhomND bigint OUTPUT,
    @ID bigint,
    @IDChucNang int,
    @ThemMoi bit,
    @Sua bit,
    @Xoa bit,
    @TatCa bit,
    @Xem bit
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
		IF EXISTS(SELECT  1 FROM ADM_QuyenNhomNguoiDung aqnnd  WHERE aqnnd.IDChucNang = @IDChucNang AND aqnnd.IDNhomNguoiDung = @ID)
		BEGIN
			DECLARE @ChucNang NVARCHAR(100)
			SET @ChucNang = (SELECT acn.TenCN FROM ADM_ChucNang acn WHERE acn.IDCN = @IDChucNang)
			RAISERROR(N'Chức năng [%s] này người dùng đã sở hữu. Bạn hãy xem lại nhé',16,1,@ChucNang)
		END

        /* Insert object into dbo.ADM_QuyenNhomNguoiDung */
        INSERT INTO [dbo].[ADM_QuyenNhomNguoiDung]
        (
            [IDNhomNguoiDung],
            [IDChucNang],
            [ThemMoi],
            [Sua],
            [Xoa],
            [TatCa],
            [Xem]
        )
        VALUES
        (
            @ID,
            @IDChucNang,
            @ThemMoi,
            @Sua,
            @Xoa,
            @TatCa,
            @Xem
        )

        /* Return new primary key */
        SET @IDQuyenNhomND = SCOPE_IDENTITY()

    END
GO

/****** Object:  StoredProcedure [dbo].[ADM_QuyenNhomNguoiDung_Info_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_QuyenNhomNguoiDung_Info_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_QuyenNhomNguoiDung_Info_Upd]
GO

CREATE PROCEDURE [dbo].[ADM_QuyenNhomNguoiDung_Info_Upd]
    @IDQuyenNhomND bigint,
    @IDChucNang int,
    @ThemMoi bit,
    @Sua bit,
    @Xoa bit,
    @TatCa bit,
    @Xem bit
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
            SELECT [IDQuyenNhomND] FROM [dbo].[ADM_QuyenNhomNguoiDung]
            WHERE
                [IDQuyenNhomND] = @IDQuyenNhomND
        )
        BEGIN
            RAISERROR ('''dbo.ADM_QuyenNhomNguoiDung_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.ADM_QuyenNhomNguoiDung */
        UPDATE [dbo].[ADM_QuyenNhomNguoiDung]
        SET
            [IDChucNang] = @IDChucNang,
            [ThemMoi] = @ThemMoi,
            [Sua] = @Sua,
            [Xoa] = @Xoa,
            [TatCa] = @TatCa,
            [Xem] = @Xem
        WHERE
            [IDQuyenNhomND] = @IDQuyenNhomND

    END
GO

/****** Object:  StoredProcedure [dbo].[ADM_QuyenNhomNguoiDung_Info_Delete] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_QuyenNhomNguoiDung_Info_Delete]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_QuyenNhomNguoiDung_Info_Delete]
GO

CREATE PROCEDURE [dbo].[ADM_QuyenNhomNguoiDung_Info_Delete]
    @IDQuyenNhomND bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [IDQuyenNhomND] FROM [dbo].[ADM_QuyenNhomNguoiDung]
            WHERE
                [IDQuyenNhomND] = @IDQuyenNhomND
        )
        BEGIN
            RAISERROR ('''dbo.ADM_QuyenNhomNguoiDung_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete ADM_QuyenNhomNguoiDung_Info object from ADM_QuyenNhomNguoiDung */
        DELETE
        FROM [dbo].[ADM_QuyenNhomNguoiDung]
        WHERE
            [dbo].[ADM_QuyenNhomNguoiDung].[IDQuyenNhomND] = @IDQuyenNhomND

    END
GO
