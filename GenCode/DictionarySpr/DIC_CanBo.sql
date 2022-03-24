/****** Object:  StoredProcedure [dbo].[DIC_CanBo_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_CanBo_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_CanBo_Get]
GO

CREATE PROCEDURE [dbo].[DIC_CanBo_Get]
    @ID bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DIC_CanBo from table */
        SELECT
            [DIC_CanBo].[ID],
            [DIC_CanBo].[HoTen],
            [DIC_CanBo].[IDGioiTinh],
            [DIC_CanBo].[NgaySinh],
            [DIC_CanBo].[IDTinh],
            [DIC_CanBo].[ChoOHiennay],
            [DIC_CanBo].[IDQuocGia],
            [DIC_CanBo].[NgayVaoDang],
            [DIC_CanBo].[TrinhDoCM],
            [DIC_CanBo].[IDCoQuan],
            [DIC_CanBo].[IDChucVu],
            [DIC_CanBo].[QTDaoTao],
            [DIC_CanBo].[QTCongTac],
            [DIC_CanBo].[KinhNghiemNN],
            [DIC_CanBo].[NghienCuuTGia],
            [DIC_CanBo].[NgoaiNguTinHoc],
            [DIC_CanBo].[KhenThuongKyLuat],
            [DIC_CanBo].[HTapNCuuNNgoai],
            [DIC_CanBo].[IDBoPhan]
        FROM [dbo].[DIC_CanBo]
        WHERE
            [DIC_CanBo].[ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_CanBo_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_CanBo_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_CanBo_Add]
GO

CREATE PROCEDURE [dbo].[DIC_CanBo_Add]
    @ID bigint,
    @HoTen nvarchar(30),
    @IDGioiTinh int,
    @NgaySinh datetime,
    @IDTinh bigint,
    @ChoOHiennay nvarchar(100),
    @IDQuocGia int,
    @NgayVaoDang datetime,
    @TrinhDoCM nvarchar(100),
    @IDCoQuan int,
    @IDChucVu int,
    @QTDaoTao nvarchar(200),
    @QTCongTac nvarchar(200),
    @KinhNghiemNN nvarchar(200),
    @NghienCuuTGia nvarchar(200),
    @NgoaiNguTinHoc nvarchar(200),
    @KhenThuongKyLuat nvarchar(200),
    @HTapNCuuNNgoai nvarchar(200),
    @IDBoPhan int
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.DIC_CanBo */
        INSERT INTO [dbo].[DIC_CanBo]
        (
            [ID],
            [HoTen],
            [IDGioiTinh],
            [NgaySinh],
            [IDTinh],
            [ChoOHiennay],
            [IDQuocGia],
            [NgayVaoDang],
            [TrinhDoCM],
            [IDCoQuan],
            [IDChucVu],
            [QTDaoTao],
            [QTCongTac],
            [KinhNghiemNN],
            [NghienCuuTGia],
            [NgoaiNguTinHoc],
            [KhenThuongKyLuat],
            [HTapNCuuNNgoai],
            [IDBoPhan]
        )
        VALUES
        (
            @ID,
            @HoTen,
            @IDGioiTinh,
            @NgaySinh,
            @IDTinh,
            @ChoOHiennay,
            @IDQuocGia,
            @NgayVaoDang,
            @TrinhDoCM,
            @IDCoQuan,
            @IDChucVu,
            @QTDaoTao,
            @QTCongTac,
            @KinhNghiemNN,
            @NghienCuuTGia,
            @NgoaiNguTinHoc,
            @KhenThuongKyLuat,
            @HTapNCuuNNgoai,
            @IDBoPhan
        )

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_CanBo_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_CanBo_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_CanBo_Upd]
GO

CREATE PROCEDURE [dbo].[DIC_CanBo_Upd]
    @ID bigint,
    @HoTen nvarchar(30),
    @IDGioiTinh int,
    @NgaySinh datetime,
    @IDTinh bigint,
    @ChoOHiennay nvarchar(100),
    @IDQuocGia int,
    @NgayVaoDang datetime,
    @TrinhDoCM nvarchar(100),
    @IDCoQuan int,
    @IDChucVu int,
    @QTDaoTao nvarchar(200),
    @QTCongTac nvarchar(200),
    @KinhNghiemNN nvarchar(200),
    @NghienCuuTGia nvarchar(200),
    @NgoaiNguTinHoc nvarchar(200),
    @KhenThuongKyLuat nvarchar(200),
    @HTapNCuuNNgoai nvarchar(200),
    @IDBoPhan int
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_CanBo]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_CanBo'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.DIC_CanBo */
        UPDATE [dbo].[DIC_CanBo]
        SET
            [HoTen] = @HoTen,
            [IDGioiTinh] = @IDGioiTinh,
            [NgaySinh] = @NgaySinh,
            [IDTinh] = @IDTinh,
            [ChoOHiennay] = @ChoOHiennay,
            [IDQuocGia] = @IDQuocGia,
            [NgayVaoDang] = @NgayVaoDang,
            [TrinhDoCM] = @TrinhDoCM,
            [IDCoQuan] = @IDCoQuan,
            [IDChucVu] = @IDChucVu,
            [QTDaoTao] = @QTDaoTao,
            [QTCongTac] = @QTCongTac,
            [KinhNghiemNN] = @KinhNghiemNN,
            [NghienCuuTGia] = @NghienCuuTGia,
            [NgoaiNguTinHoc] = @NgoaiNguTinHoc,
            [KhenThuongKyLuat] = @KhenThuongKyLuat,
            [HTapNCuuNNgoai] = @HTapNCuuNNgoai,
            [IDBoPhan] = @IDBoPhan
        WHERE
            [ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_CanBo_Delete] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_CanBo_Delete]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_CanBo_Delete]
GO

CREATE PROCEDURE [dbo].[DIC_CanBo_Delete]
    @ID bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_CanBo]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_CanBo'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete DIC_CanBo object from DIC_CanBo */
        DELETE
        FROM [dbo].[DIC_CanBo]
        WHERE
            [dbo].[DIC_CanBo].[ID] = @ID

    END
GO
