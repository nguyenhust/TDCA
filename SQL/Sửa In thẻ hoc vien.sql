
alter table DT_LienTuc_LopHoc add CanBoNgoaiTT nvarchar(50), GioiTinh varchar(10)
GO
alter table DT_LienTuc_LopHoc add IDLopHoc bigint identity
GO

USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[DT_LienTuc_LopHoc_add]    Script Date: 05/08/2018 10:12:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[DT_LienTuc_LopHoc_add]
    @MaLop nvarchar(50),
    @TenLop nvarchar(150),
    @DoiTuong nvarchar(150),
    @NguonKinhPhi nvarchar(150),
    @idCanBoPhuTrach bigint,
    @idCanBoPhoiHop bigint,
    @NgayBatDau date,
    @NgayKetThuc date,
    @HocPhi nvarchar(50),
    @idCanBoGiangVien1 bigint,
    @idCanBoGiangVien2 bigint,
    @idCanBoGiangVien3 bigint,
    @idCanBoGiangVien4 bigint,
    @idCanBoGiangVien5 bigint,
    @idKhungLopHoc int,
    @KhoaHoc nvarchar(MAX),
    @IdNguonKinhPhi int,
    @LastEdited_User bigint,
    @LastEdited_Date datetime,
    @TongSoTiet int,
    @Backup01 nvarchar(200),
    @Backup02 nvarchar(200),
    @Backup03 nvarchar(200),
    @Backup04 nvarchar(200),
    @Backup05 int,
    @Backup06 int,
	@CanBoNgoaiTT nvarchar(50),
	@GioiTinh varchar(10)
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.DT_LienTuc_LopHoc */
        INSERT INTO [dbo].[DT_LienTuc_LopHoc]
        (
            [MaLop],
            [TenLop],
            [DoiTuong],
            [NguonKinhPhi],
            [idCanBoPhuTrach],
            [idCanBoPhoiHop],
            [NgayBatDau],
            [NgayKetThuc],
            [HocPhi],
            [idCanBoGiangVien1],
            [idCanBoGiangVien2],
            [idCanBoGiangVien3],
            [idCanBoGiangVien4],
            [idCanBoGiangVien5],
            [idKhungLopHoc],
            [KhoaHoc],
            [IdNguonKinhPhi],
            [LastEdited_User],
            [LastEdited_Date],
            [TongSoTiet],
            [Backup01],
            [Backup02],
            [Backup03],
            [Backup04],
            [Backup05],
            [Backup06],
			[CanBoNgoaiTT],
			[GioiTinh]
        )
        VALUES
        (
            @MaLop,
            @TenLop,
            @DoiTuong,
            @NguonKinhPhi,
            @idCanBoPhuTrach,
            @idCanBoPhoiHop,
            @NgayBatDau,
            @NgayKetThuc,
            @HocPhi,
            @idCanBoGiangVien1,
            @idCanBoGiangVien2,
            @idCanBoGiangVien3,
            @idCanBoGiangVien4,
            @idCanBoGiangVien5,
            @idKhungLopHoc,
            @KhoaHoc,
            @IdNguonKinhPhi,
            @LastEdited_User,
            @LastEdited_Date,
            @TongSoTiet,
            @Backup01,
            @Backup02,
            @Backup03,
            @Backup04,
            @Backup05,
            @Backup06,
			@CanBoNgoaiTT,
			@GioiTinh
        )

    END
GO

USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[DT_LienTuc_LopHoc_update]    Script Date: 05/08/2018 10:19:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[DT_LienTuc_LopHoc_update]
    @MaLop nvarchar(50),
    @TenLop nvarchar(150),
    @DoiTuong nvarchar(150),
    @NguonKinhPhi nvarchar(150),
    @idCanBoPhuTrach bigint,
    @idCanBoPhoiHop bigint,
    @NgayBatDau date,
    @NgayKetThuc date,
    @HocPhi nvarchar(50),
    @idCanBoGiangVien1 bigint,
    @idCanBoGiangVien2 bigint,
    @idCanBoGiangVien3 bigint,
    @idCanBoGiangVien4 bigint,
    @idCanBoGiangVien5 bigint,
    @idKhungLopHoc int,
    @KhoaHoc nvarchar(MAX),
    @IdNguonKinhPhi int,
    @LastEdited_User bigint,
    @LastEdited_Date datetime,
    @TongSoTiet int,
    @Backup01 nvarchar(200),
    @Backup02 nvarchar(200),
    @Backup03 nvarchar(200),
    @Backup04 nvarchar(200),
    @Backup05 int,
    @Backup06 int,
	@CanBoNgoaiTT nvarchar(50),
	@GioiTinh varchar(10)
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [MaLop] FROM [dbo].[DT_LienTuc_LopHoc]
            WHERE
                [MaLop] = @MaLop
        )
        BEGIN
            RAISERROR ('''dbo.DT_LienTuc_LopHoc'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END
		IF(@MaLop <> '')
		BEGIN
			UPDATE dbo.DT_LienTuc_HocVien
			SET idNguoiQuanLy = (select IDNguoiDung FROM dbo.ADM_NguoiDung WHERE IDCanBo = @idCanBoPhuTrach)
			WHERE idKhungLopHoc = @idKhungLopHoc 
		end
        /* Update object in dbo.DT_LienTuc_LopHoc */
        UPDATE [dbo].[DT_LienTuc_LopHoc]
        SET
            [TenLop] = @TenLop,
            [DoiTuong] = @DoiTuong,
            [NguonKinhPhi] = @NguonKinhPhi,
            [idCanBoPhuTrach] = @idCanBoPhuTrach,
            [idCanBoPhoiHop] = @idCanBoPhoiHop,
            [NgayBatDau] = @NgayBatDau,
            [NgayKetThuc] = @NgayKetThuc,
            [HocPhi] = @HocPhi,
            [idCanBoGiangVien1] = @idCanBoGiangVien1,
            [idCanBoGiangVien2] = @idCanBoGiangVien2,
            [idCanBoGiangVien3] = @idCanBoGiangVien3,
            [idCanBoGiangVien4] = @idCanBoGiangVien4,
            [idCanBoGiangVien5] = @idCanBoGiangVien5,
            [idKhungLopHoc] = @idKhungLopHoc,
            [KhoaHoc] = @KhoaHoc,
            [IdNguonKinhPhi] = @IdNguonKinhPhi,
            [LastEdited_User] = @LastEdited_User,
            [LastEdited_Date] = @LastEdited_Date,
            [TongSoTiet] = @TongSoTiet,
            [Backup01] = @Backup01,
            [Backup02] = @Backup02,
            [Backup03] = @Backup03,
            [Backup04] = @Backup04,
            [Backup05] = @Backup05,
            [Backup06] = @Backup06,
			[CanBoNgoaiTT] = @CanBoNgoaiTT,
			[GioiTinh] = @GioiTinh
        WHERE
            [MaLop] = @MaLop
		

		

    END

GO
USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[DT_LienTuc_LopHoc_get]    Script Date: 05/08/2018 10:21:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	
ALTER PROCEDURE [dbo].[DT_LienTuc_LopHoc_get]
    @MaLop nvarchar(50)
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DT_LienTuc_LopHoc from table */
        SELECT
            [DT_LienTuc_LopHoc].[MaLop],
            [DT_LienTuc_LopHoc].[TenLop],
            [DT_LienTuc_LopHoc].[DoiTuong],
            [DT_LienTuc_LopHoc].[NguonKinhPhi],
            [DT_LienTuc_LopHoc].[idCanBoPhuTrach],
            [DT_LienTuc_LopHoc].[idCanBoPhoiHop],
            [DT_LienTuc_LopHoc].[NgayBatDau],
            [DT_LienTuc_LopHoc].[NgayKetThuc],
            [DT_LienTuc_LopHoc].[HocPhi],
            [DT_LienTuc_LopHoc].[idCanBoGiangVien1],
            [DT_LienTuc_LopHoc].[idCanBoGiangVien2],
            [DT_LienTuc_LopHoc].[idCanBoGiangVien3],
            [DT_LienTuc_LopHoc].[idCanBoGiangVien4],
            [DT_LienTuc_LopHoc].[idCanBoGiangVien5],
            [DT_LienTuc_LopHoc].[idKhungLopHoc],
            [DT_LienTuc_LopHoc].[KhoaHoc],
            [DT_LienTuc_LopHoc].[IdNguonKinhPhi],
            [DT_LienTuc_LopHoc].[LastEdited_User],
            [DT_LienTuc_LopHoc].[LastEdited_Date],
            [DT_LienTuc_LopHoc].[TongSoTiet],
            [DT_LienTuc_LopHoc].[Backup01],
            [DT_LienTuc_LopHoc].[Backup02],
            [DT_LienTuc_LopHoc].[Backup03],
            [DT_LienTuc_LopHoc].[Backup04],
            [DT_LienTuc_LopHoc].[Backup05],
            [DT_LienTuc_LopHoc].[Backup06],
			kl.idChuyenKhoa,
			[DT_LienTuc_LopHoc].[CanBoNgoaiTT],
            [DT_LienTuc_LopHoc].[GioiTinh],
			[DT_LienTuc_LopHoc].[IDLopHoc]
        FROM [dbo].[DT_LienTuc_LopHoc]
		LEFT JOIN dbo.DT_LienTuc_KhungLopHoc kl ON idKhungLopHoc = kl.id

        WHERE
            [DT_LienTuc_LopHoc].[MaLop] = @MaLop

    END
GO

--Alter Table BienLai add IDLopHoc bigint null

--GO

--USE [MDCT]
--GO
--/****** Object:  StoredProcedure [dbo].[DT_LienTuc_LopHoc_get]    Script Date: 05/08/2018 11:56:35 PM ******/
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO

	
--CREATE PROCEDURE [dbo].[LoadLopHocLienTuc_Get]
--    @IDLopHoc bigint
--AS
--    BEGIN

--        SET NOCOUNT ON

--        /* Get DT_LienTuc_LopHoc from table */
--        SELECT lh.IDLopHoc, lh.MaLop,case when CanBoNgoaiTT <> '' or CanBoNgoaiTT is not null then lh.CanBoNgoaiTT else cb.HoTen end as TenNguoiDong , case when CanBoNgoaiTT <> '' or CanBoNgoaiTT is not null then ck.Ten + N'- Bệnh viện bạch mai' else N'Trung tâm chỉ đạo tuyến - Bệnh viện bạch mai' end as NoiCongTac,lh.TenLop as NoiDungDT  FROM [dbo].[DT_LienTuc_LopHoc] lh
--		LEFT JOIN dbo.DT_LienTuc_KhungLopHoc kl ON idKhungLopHoc = kl.id
--		left join DIC_ChuyenKhoa ck on ck.ID = kl.idChuyenKhoa
--		left join DIC_CanBo cb on cb.ID = lh.idCanBoPhuTrach

--        WHERE
--            lh.IDLopHoc = @IDLopHoc

--    END
--GO








