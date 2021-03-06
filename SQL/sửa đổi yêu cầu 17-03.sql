
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--ALTER TABLE dbo.DT_ChinhQuy_HocVien
--ADD 
 --NoiSinh NVARCHAR(max)
-- MienThi1 bit
--,MienThi2 bit
--,MienThi3 bit
--,MienThi4 bit
--,MienThi5 bit
--,MienThi BIT
--go
--ALTER TABLE dbo.HC_PhieuGiaoViec 
--ADD Link NVARCHAR(max)
ALTER VIEW [dbo].[DT_View_ChinhQuy_HocVien]
AS
SELECT        a.id, a.HoTen, a.NgaySinh, a.SoCMT, a.MaHocVien, a.GioiTinh, a.idTrinhDo, a.idChuyenNganh, a.TruongTotNghiep, a.NamTotNghiep, a.SoBang, a.NoiCongTac, a.DiaChiNhaRieng, a.DienThoaiNhaRieng, 
                         a.DiDong, a.Email, a.NgayCapCMT, a.NoiCapCMT, a.NgayDangKi, a.Anh, a.DauVaoMon1, a.DauVaoDiem1, a.DauVaoMon2, a.DauVaoDiem2, a.DauVaoMon3, a.DauVaoDiem3, a.DauVaoMon4, a.DauVaoDiem4, 
                         a.DauVaoMon5, a.DauVaoDiem5, a.DauVaoMon6, a.DauVaoDiem6, a.DanToc, a.TonGiao, a.QuanHeGiaDinh, a.DuocPhepThiLai, a.LyDoKhongDuocThiLai, a.LastEdited_User, a.LastEdited_Date, a.backup01, 
                         a.backup02, a.backup03, a.backup04, a.backup05, a.backup06, a.backup07, a.backup08, a.TongHocPhiPhaiDong, a.TongHocPhiDaDong, a.AllInOneHoaDon, a.SoLanInThe, a.SoLanInBangDiem, a.SoLanInBang, 
                         a.idLopHoc, a.SBD, a.idChuyenNganhDuThi, a.CapDoDuTuyen, a.KhoaDuTuyen, a.NamDuTuyen, a.TongDiemDauVao, a.TotNghiepLT, a.TotNghiepTH, a.BaoVeLuanVan,a.NoiSinh, b.TenLop, b.MaLop AS TenMaLop, 
                         b.NamHoc AS TenNamHocLop, c.Ten AS TenChuyenKhoaLop, d2.Ten AS TenChuyenNganhLop, d1.Ten AS TenChuyenNganh, e.TenHocVi AS TenTrinhDo, b.Khoa AS TenKhoaLop, 
                         d3.Ten AS TenChuyenNganhDuThi
FROM            dbo.DT_ChinhQuy_HocVien AS a LEFT OUTER JOIN
                         dbo.DT_ChinhQuy_LopHoc AS b ON a.idLopHoc = b.ID LEFT OUTER JOIN
                         dbo.DIC_ChuyenKhoa AS c ON b.idChuyenKhoa = c.ID LEFT OUTER JOIN
                         dbo.DIC_ChuyenNganh AS d1 ON a.idChuyenNganh = d1.ID LEFT OUTER JOIN
                         dbo.DIC_ChuyenNganh AS d2 ON b.idChuyenNganh = d2.ID LEFT OUTER JOIN
                         dbo.DIC_ChuyenNganh AS d3 ON a.idChuyenNganhDuThi = d3.ID LEFT OUTER JOIN
                         dbo.DIC_HocVi AS e ON a.idTrinhDo = e.ID
GO
ALTER PROCEDURE [dbo].[HC_VatTuTaiSan_update]
    @ID int,
    @TenVatTu nvarchar(MAX),
    @MaVatTu nvarchar(MAX),
    @NgayNhan datetime,
    @HieuMay nvarchar(MAX),
    @SerialMay nvarchar(MAX),
    @NguonKinhPhi nvarchar(MAX),
    @TyLeKhauHao nvarchar(MAX),
    @TinhTrang nvarchar(MAX),
    @XuatXu nvarchar(MAX),
    @NgayNhap nvarchar(MAX),
    @NhanVienQuanLy nvarchar(MAX),
    @ViTriDatMay nvarchar(MAX),
    @SoLanHong nvarchar(MAX),
    @PhuKien nvarchar(MAX),
    @GhiChu nvarchar(MAX),
    @idNguonKinhPhi int,
    @idCanBoQuanLy bigint,
    @LastEdited_UserID bigint,
    @LastEdited_Date datetime,
	@Type NVARCHAR(max),
	@Backup1 NVARCHAR(max),
	@Backup2 NVARCHAR(max),
	@Backup3 NVARCHAR(max),
	@Backup4 INT,
	@DonVi	 NVARCHAR(max),
	@NamDuaVaoSuDung INT
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[HC_VatTuTaiSan]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.HC_VatTuTaiSan'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END
		 IF EXISTS
        (
            SELECT [ID] FROM [dbo].[HC_VatTuTaiSan]
            WHERE
                [SerialMay] = @SerialMay and [ID] != @ID
        )
        BEGIN
            RAISERROR ('Lỗi UPD-001: Thiết bị với cùng số Serial đã tồn tại trong hệ thống, vui lòng kiểm tra lại', 16, 1)
     RETURN
	 END

        /* Update object in dbo.HC_VatTuTaiSan */
        UPDATE [dbo].[HC_VatTuTaiSan]
        SET
            [TenVatTu] = @TenVatTu,
            [MaVatTu] = @MaVatTu,
            [NgayNhan] = @NgayNhan,
            [HieuMay] = @HieuMay,
            [SerialMay] = @SerialMay,
            [NguonKinhPhi] = @NguonKinhPhi,
            [TyLeKhauHao] = @TyLeKhauHao,
            [TinhTrang] = @TinhTrang,
            [XuatXu] = @XuatXu,
            [NgayNhap] = @NgayNhap,
            [NhanVienQuanLy] = @NhanVienQuanLy,
            [ViTriDatMay] = @ViTriDatMay,
            [SoLanHong] = @SoLanHong,
            [PhuKien] = @PhuKien,
            [GhiChu] = @GhiChu,
            [idNguonKinhPhi] = @idNguonKinhPhi,
            [idCanBoQuanLy] = @idCanBoQuanLy,
            [LastEdited_UserID] = @LastEdited_UserID,
            [LastEdited_Date] = @LastEdited_Date,
			[Type] = @Type,
			Backup1 = @Backup1,
			backup2 = @Backup2,
			backup3 = backup3,
			backup4 = @Backup4,
			DonVi = @DonVi,
			NamDuaVaoSuDung = @NamDuaVaoSuDung
        WHERE
            [ID] = @ID

    END

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
			kl.idChuyenKhoa
        FROM [dbo].[DT_LienTuc_LopHoc]
		LEFT JOIN dbo.DT_LienTuc_KhungLopHoc kl ON idKhungLopHoc = kl.id

        WHERE
            [DT_LienTuc_LopHoc].[MaLop] = @MaLop

    END
go
ALTER PROCEDURE [dbo].[DT_LienTuc_LopHoc_Coll_get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DT_LienTuc_LopHoc_Info from table */
        SELECT
           v.*,
		   cb.HoTen AS CanBoPhoiHop
		   From DT_View_LienTuc_LopHoc v
		   LEFT JOIN dbo.DIC_CanBo cb ON cb.ID = v.idCanBoPhoiHop
		  order by NgayBatDau desc
    END

go

IF EXISTS (SELECT * FROM sys.objects WHERE name = 'DT_LienTuc_LopHoc_Coll_getbyNamAndId')
DROP PROC DT_LienTuc_LopHoc_Coll_getbyNamAndId
go 
CREATE PROCEDURE [dbo].DT_LienTuc_LopHoc_Coll_getbyNamAndId
@id BIGINT,
@nam INT
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DT_LienTuc_LopHoc_Info from table */
        SELECT
           v.*,
		   cb.HoTen AS CanBoPhoiHop
		   From DT_View_LienTuc_LopHoc v
		   LEFT JOIN dbo.DIC_CanBo cb ON cb.ID = v.idCanBoPhoiHop
		   WHERE v.IdChuyenKhoaLopHoc = @id AND YEAR(NgayBatDau) = @nam
		  order by NgayBatDau desc
    END
	
go

ALTER PROCEDURE [dbo].[DT_LienTuc_HocVien_Coll_getDiemKemCap]
@IdNguoiQuanLy BIGINT,
@nam INT = NULL,
@ngayhoc DATETIME = NULL
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DT_LienTuc_HocVien_Info from table */
		IF(@nam IS NULL)
		BEGIN
			        SELECT DISTINCT
					   *
					FROM [dbo].DT_View_LienTuc_HocVien
					Where LOWER([HinhThucHoc]) like N'kèm cặp' 
					--and (idNguoiQuanLy = @IdNguoiQuanLy or @IdNguoiQuanLy = -1)
					And (LOWER([TrangThai]) like N'đang học' or LOWER([TrangThai]) like N'%chưa cấp%')
		End
		ELSE IF(@nam IS NOT NULL)
		BEGIN
		        SELECT DISTINCT
				   *
				FROM [dbo].DT_View_LienTuc_HocVien
				Where LOWER([HinhThucHoc]) like N'kèm cặp' 
				--and (idNguoiQuanLy = @IdNguoiQuanLy or @IdNguoiQuanLy = -1)
				And (LOWER([TrangThai]) like N'đang học' or LOWER([TrangThai]) like N'%chưa cấp%')
				AND YEAR(NgayBatDau) = @nam
		End
    END
GO
GO

ALTER PROCEDURE [dbo].[DT_ChinhQuy_HocVien_get]
    @id int
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DT_ChinhQuy_HocVien from table */
        SELECT
            [DT_ChinhQuy_HocVien].[id],
            [DT_ChinhQuy_HocVien].[HoTen],
            [DT_ChinhQuy_HocVien].[NgaySinh],
            [DT_ChinhQuy_HocVien].[SoCMT],
            [DT_ChinhQuy_HocVien].[MaHocVien],
            [DT_ChinhQuy_HocVien].[GioiTinh],
            [DT_ChinhQuy_HocVien].[idTrinhDo],
            [DT_ChinhQuy_HocVien].[idChuyenNganh],
            [DT_ChinhQuy_HocVien].[TruongTotNghiep],
            [DT_ChinhQuy_HocVien].[NamTotNghiep],
            [DT_ChinhQuy_HocVien].[SoBang],
            [DT_ChinhQuy_HocVien].[NoiCongTac],
            [DT_ChinhQuy_HocVien].[DiaChiNhaRieng],
            [DT_ChinhQuy_HocVien].[DienThoaiNhaRieng],
            [DT_ChinhQuy_HocVien].[DiDong],
            [DT_ChinhQuy_HocVien].[Email],
            [DT_ChinhQuy_HocVien].[NgayCapCMT],
            [DT_ChinhQuy_HocVien].[NoiCapCMT],
            [DT_ChinhQuy_HocVien].[NgayDangKi],
            [DT_ChinhQuy_HocVien].[Anh],
            [DT_ChinhQuy_HocVien].[DauVaoMon1],
            [DT_ChinhQuy_HocVien].[DauVaoDiem1],
            [DT_ChinhQuy_HocVien].[DauVaoMon2],
            [DT_ChinhQuy_HocVien].[DauVaoDiem2],
            [DT_ChinhQuy_HocVien].[DauVaoMon3],
            [DT_ChinhQuy_HocVien].[DauVaoDiem3],
            [DT_ChinhQuy_HocVien].[DauVaoMon4],
            [DT_ChinhQuy_HocVien].[DauVaoDiem4],
            [DT_ChinhQuy_HocVien].[DauVaoMon5],
            [DT_ChinhQuy_HocVien].[DauVaoDiem5],
            [DT_ChinhQuy_HocVien].[DauVaoMon6],
            [DT_ChinhQuy_HocVien].[DauVaoDiem6],
            [DT_ChinhQuy_HocVien].[DanToc],
            [DT_ChinhQuy_HocVien].[TonGiao],
            [DT_ChinhQuy_HocVien].[QuanHeGiaDinh],
            [DT_ChinhQuy_HocVien].[DuocPhepThiLai],
            [DT_ChinhQuy_HocVien].[LyDoKhongDuocThiLai],
            [DT_ChinhQuy_HocVien].[LastEdited_User],
            [DT_ChinhQuy_HocVien].[LastEdited_Date],
            [DT_ChinhQuy_HocVien].[backup01],
            [DT_ChinhQuy_HocVien].[backup02],
            [DT_ChinhQuy_HocVien].[backup03],
            [DT_ChinhQuy_HocVien].[backup04],
            [DT_ChinhQuy_HocVien].[backup05],
            [DT_ChinhQuy_HocVien].[backup06],
            [DT_ChinhQuy_HocVien].[backup07],
            [DT_ChinhQuy_HocVien].[backup08],
            [DT_ChinhQuy_HocVien].[TongHocPhiPhaiDong],
            [DT_ChinhQuy_HocVien].[TongHocPhiDaDong],
            [DT_ChinhQuy_HocVien].[AllInOneHoaDon],
            [DT_ChinhQuy_HocVien].[SoLanInThe],
            [DT_ChinhQuy_HocVien].[SoLanInBangDiem],
            [DT_ChinhQuy_HocVien].[SoLanInBang],
            [DT_ChinhQuy_HocVien].[idLopHoc],
            [DT_ChinhQuy_HocVien].[SBD],
            [DT_ChinhQuy_HocVien].[idChuyenNganhDuThi],
            [DT_ChinhQuy_HocVien].[CapDoDuTuyen],
            [DT_ChinhQuy_HocVien].[KhoaDuTuyen],
            [DT_ChinhQuy_HocVien].[NamDuTuyen],
            [DT_ChinhQuy_HocVien].[TongDiemDauVao],
            [DT_ChinhQuy_HocVien].[TotNghiepLT],
            [DT_ChinhQuy_HocVien].[TotNghiepTH],
            [DT_ChinhQuy_HocVien].[BaoVeLuanVan],
			[DT_ChinhQuy_HocVien].NoiSinh,
			[DT_ChinhQuy_HocVien].MienThi1,
			[DT_ChinhQuy_HocVien].MienThi2,
			[DT_ChinhQuy_HocVien].MienThi3,
			[DT_ChinhQuy_HocVien].MienThi4,
			[DT_ChinhQuy_HocVien].MienThi5
        FROM [dbo].[DT_ChinhQuy_HocVien]
        WHERE
            [DT_ChinhQuy_HocVien].[id] = @id

    END
	go
	ALTER PROCEDURE [dbo].[DT_ChinhQuy_HocVien_add]
    @id int OUTPUT,
    @HoTen nvarchar(150),
    @NgaySinh datetime,
    @SoCMT nvarchar(20),
    @MaHocVien nvarchar(50),
    @GioiTinh nvarchar(50),
    @idTrinhDo bigint,
    @idChuyenNganh int,
    @TruongTotNghiep nvarchar(150),
    @NamTotNghiep int,
    @SoBang nvarchar(50),
    @NoiCongTac nvarchar(150),
    @DiaChiNhaRieng nvarchar(250),
    @DienThoaiNhaRieng nvarchar(50),
    @DiDong nvarchar(50),
    @Email nvarchar(50),
    @NgayCapCMT datetime,
    @NoiCapCMT nvarchar(50),
    @NgayDangKi datetime,
    @Anh nvarchar(300),
    @DauVaoMon1 nvarchar(50),
    @DauVaoDiem1 float,
    @DauVaoMon2 nvarchar(50),
    @DauVaoDiem2 float,
    @DauVaoMon3 nvarchar(50),
    @DauVaoDiem3 float,
    @DauVaoMon4 nvarchar(50),
    @DauVaoDiem4 float,
    @DauVaoMon5 nvarchar(50),
    @DauVaoDiem5 float,
    @DauVaoMon6 nvarchar(MAX),
    @DauVaoDiem6 float,
    @DanToc nvarchar(MAX),
    @TonGiao nvarchar(MAX),
    @QuanHeGiaDinh nvarchar(MAX),
    @DuocPhepThiLai bit,
    @LyDoKhongDuocThiLai nvarchar(MAX),
    @LastEdited_User bigint,
    @LastEdited_Date datetime,
    @backup01 nvarchar(MAX),
    @backup02 nvarchar(MAX),
    @backup03 nvarchar(MAX),
    @backup04 nvarchar(MAX),
    @backup05 int,
    @backup06 int,
    @backup07 datetime,
    @backup08 datetime,
    @TongHocPhiPhaiDong nvarchar(MAX),
    @TongHocPhiDaDong nvarchar(MAX),
    @AllInOneHoaDon nvarchar(MAX),
    @SoLanInThe int,
    @SoLanInBangDiem int,
    @SoLanInBang int,
    @idLopHoc int,
    @SBD nvarchar(MAX),
    @idChuyenNganhDuThi int,
    @CapDoDuTuyen nvarchar(20),
    @KhoaDuTuyen nvarchar(20),
    @NamDuTuyen int,
    @TongDiemDauVao float,
    @TotNghiepLT float,
    @TotNghiepTH float,
    @BaoVeLuanVan FLOAT,
	@NoiSinh NVARCHAR(max),
	@MienThi1 BIT,
	@MienThi2 BIT,
	@MienThi3 BIT,
	@MienThi4 BIT,
	@MienThi5 BIT
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.DT_ChinhQuy_HocVien */
        INSERT INTO [dbo].[DT_ChinhQuy_HocVien]
        (
            [HoTen],
            [NgaySinh],
            [SoCMT],
            [MaHocVien],
            [GioiTinh],
            [idTrinhDo],
            [idChuyenNganh],
            [TruongTotNghiep],
            [NamTotNghiep],
            [SoBang],
            [NoiCongTac],
            [DiaChiNhaRieng],
            [DienThoaiNhaRieng],
            [DiDong],
            [Email],
            [NgayCapCMT],
            [NoiCapCMT],
            [NgayDangKi],
            [Anh],
            [DauVaoMon1],
            [DauVaoDiem1],
            [DauVaoMon2],
            [DauVaoDiem2],
            [DauVaoMon3],
            [DauVaoDiem3],
            [DauVaoMon4],
            [DauVaoDiem4],
            [DauVaoMon5],
            [DauVaoDiem5],
            [DauVaoMon6],
            [DauVaoDiem6],
            [DanToc],
            [TonGiao],
            [QuanHeGiaDinh],
            [DuocPhepThiLai],
            [LyDoKhongDuocThiLai],
            [LastEdited_User],
            [LastEdited_Date],
            [backup01],
            [backup02],
            [backup03],
            [backup04],
            [backup05],
            [backup06],
            [backup07],
            [backup08],
            [TongHocPhiPhaiDong],
            [TongHocPhiDaDong],
            [AllInOneHoaDon],
            [SoLanInThe],
            [SoLanInBangDiem],
            [SoLanInBang],
            [idLopHoc],
            [SBD],
            [idChuyenNganhDuThi],
            [CapDoDuTuyen],
            [KhoaDuTuyen],
            [NamDuTuyen],
            [TongDiemDauVao],
            [TotNghiepLT],
            [TotNghiepTH],
            [BaoVeLuanVan],
			NoiSinh,
			MienThi1,
			MienThi2,
			MienThi3,
			MienThi4,
			MienThi5
        )
        VALUES
        (
            @HoTen,
            @NgaySinh,
            @SoCMT,
            @MaHocVien,
            @GioiTinh,
            @idTrinhDo,
            @idChuyenNganh,
            @TruongTotNghiep,
            @NamTotNghiep,
            @SoBang,
            @NoiCongTac,
            @DiaChiNhaRieng,
            @DienThoaiNhaRieng,
            @DiDong,
            @Email,
            @NgayCapCMT,
            @NoiCapCMT,
            @NgayDangKi,
            @Anh,
            @DauVaoMon1,
            @DauVaoDiem1,
            @DauVaoMon2,
            @DauVaoDiem2,
            @DauVaoMon3,
            @DauVaoDiem3,
            @DauVaoMon4,
            @DauVaoDiem4,
            @DauVaoMon5,
            @DauVaoDiem5,
            @DauVaoMon6,
            @DauVaoDiem6,
            @DanToc,
            @TonGiao,
            @QuanHeGiaDinh,
            @DuocPhepThiLai,
            @LyDoKhongDuocThiLai,
            @LastEdited_User,
            @LastEdited_Date,
            @backup01,
            @backup02,
            @backup03,
            @backup04,
            @backup05,
            @backup06,
            @backup07,
            @backup08,
            @TongHocPhiPhaiDong,
            @TongHocPhiDaDong,
            @AllInOneHoaDon,
            @SoLanInThe,
            @SoLanInBangDiem,
            @SoLanInBang,
            @idLopHoc,
            @SBD,
            @idChuyenNganhDuThi,
            @CapDoDuTuyen,
            @KhoaDuTuyen,
            @NamDuTuyen,
            @TongDiemDauVao,
            @TotNghiepLT,
            @TotNghiepTH,
            @BaoVeLuanVan,
			@NoiSinh,
			@MienThi1,
			@MienThi2,
			@MienThi3,
			@MienThi4,
			@MienThi5
        )

        /* Return new primary key */
        SET @id = SCOPE_IDENTITY()

    END

GO

ALTER PROCEDURE [dbo].[DT_ChinhQuy_HocVien_update]
    @id int,
    @HoTen nvarchar(150),
    @NgaySinh datetime,
    @SoCMT nvarchar(20),
    @MaHocVien nvarchar(50),
    @GioiTinh nvarchar(50),
    @idTrinhDo bigint,
    @idChuyenNganh int,
    @TruongTotNghiep nvarchar(150),
    @NamTotNghiep int,
    @SoBang nvarchar(50),
    @NoiCongTac nvarchar(150),
    @DiaChiNhaRieng nvarchar(250),
    @DienThoaiNhaRieng nvarchar(50),
    @DiDong nvarchar(50),
    @Email nvarchar(50),
    @NgayCapCMT datetime,
    @NoiCapCMT nvarchar(50),
    @NgayDangKi datetime,
    @Anh nvarchar(300),
    @DauVaoMon1 nvarchar(50),
    @DauVaoDiem1 float,
    @DauVaoMon2 nvarchar(50),
    @DauVaoDiem2 float,
    @DauVaoMon3 nvarchar(50),
    @DauVaoDiem3 float,
    @DauVaoMon4 nvarchar(50),
    @DauVaoDiem4 float,
    @DauVaoMon5 nvarchar(50),
    @DauVaoDiem5 float,
    @DauVaoMon6 nvarchar(MAX),
    @DauVaoDiem6 float,
    @DanToc nvarchar(MAX),
    @TonGiao nvarchar(MAX),
    @QuanHeGiaDinh nvarchar(MAX),
    @DuocPhepThiLai bit,
    @LyDoKhongDuocThiLai nvarchar(MAX),
    @LastEdited_User bigint,
    @LastEdited_Date datetime,
    @backup01 nvarchar(MAX),
    @backup02 nvarchar(MAX),
    @backup03 nvarchar(MAX),
    @backup04 nvarchar(MAX),
    @backup05 int,
    @backup06 int,
    @backup07 datetime,
    @backup08 datetime,
    @TongHocPhiPhaiDong nvarchar(MAX),
    @TongHocPhiDaDong nvarchar(MAX),
    @AllInOneHoaDon nvarchar(MAX),
    @SoLanInThe int,
    @SoLanInBangDiem int,
    @SoLanInBang int,
    @idLopHoc int,
    @SBD nvarchar(MAX),
    @idChuyenNganhDuThi int,
    @CapDoDuTuyen nvarchar(20),
    @KhoaDuTuyen nvarchar(20),
    @NamDuTuyen int,
    @TongDiemDauVao float,
    @TotNghiepLT float,
    @TotNghiepTH float,
    @BaoVeLuanVan FLOAT,
	@NoiSinh NVARCHAR(max),
	@MienThi1 BIT,
	@MienThi2 BIT,
	@MienThi3 BIT,
	@MienThi4 BIT,
	@MienThi5 BIT
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [id] FROM [dbo].[DT_ChinhQuy_HocVien]
            WHERE
                [id] = @id
        )
        BEGIN
            RAISERROR ('''dbo.DT_ChinhQuy_HocVien'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.DT_ChinhQuy_HocVien */
        UPDATE [dbo].[DT_ChinhQuy_HocVien]
        SET
            [HoTen] = @HoTen,
            [NgaySinh] = @NgaySinh,
            [SoCMT] = @SoCMT,
            [MaHocVien] = @MaHocVien,
            [GioiTinh] = @GioiTinh,
            [idTrinhDo] = @idTrinhDo,
            [idChuyenNganh] = @idChuyenNganh,
            [TruongTotNghiep] = @TruongTotNghiep,
            [NamTotNghiep] = @NamTotNghiep,
            [SoBang] = @SoBang,
            [NoiCongTac] = @NoiCongTac,
            [DiaChiNhaRieng] = @DiaChiNhaRieng,
            [DienThoaiNhaRieng] = @DienThoaiNhaRieng,
            [DiDong] = @DiDong,
            [Email] = @Email,
            [NgayCapCMT] = @NgayCapCMT,
            [NoiCapCMT] = @NoiCapCMT,
            [NgayDangKi] = @NgayDangKi,
            [Anh] = @Anh,
            [DauVaoMon1] = @DauVaoMon1,
            [DauVaoDiem1] = @DauVaoDiem1,
            [DauVaoMon2] = @DauVaoMon2,
            [DauVaoDiem2] = @DauVaoDiem2,
            [DauVaoMon3] = @DauVaoMon3,
            [DauVaoDiem3] = @DauVaoDiem3,
            [DauVaoMon4] = @DauVaoMon4,
            [DauVaoDiem4] = @DauVaoDiem4,
            [DauVaoMon5] = @DauVaoMon5,
            [DauVaoDiem5] = @DauVaoDiem5,
            [DauVaoMon6] = @DauVaoMon6,
            [DauVaoDiem6] = @DauVaoDiem6,
            [DanToc] = @DanToc,
            [TonGiao] = @TonGiao,
            [QuanHeGiaDinh] = @QuanHeGiaDinh,
            [DuocPhepThiLai] = @DuocPhepThiLai,
            [LyDoKhongDuocThiLai] = @LyDoKhongDuocThiLai,
            [LastEdited_User] = @LastEdited_User,
            [LastEdited_Date] = @LastEdited_Date,
            [backup01] = @backup01,
            [backup02] = @backup02,
            [backup03] = @backup03,
            [backup04] = @backup04,
            [backup05] = @backup05,
            [backup06] = @backup06,
            [backup07] = @backup07,
            [backup08] = @backup08,
            [TongHocPhiPhaiDong] = @TongHocPhiPhaiDong,
            [TongHocPhiDaDong] = @TongHocPhiDaDong,
            [AllInOneHoaDon] = @AllInOneHoaDon,
            [SoLanInThe] = @SoLanInThe,
            [SoLanInBangDiem] = @SoLanInBangDiem,
            [SoLanInBang] = @SoLanInBang,
            [idLopHoc] = @idLopHoc,
            [SBD] = @SBD,
            [idChuyenNganhDuThi] = @idChuyenNganhDuThi,
            [CapDoDuTuyen] = @CapDoDuTuyen,
            [KhoaDuTuyen] = @KhoaDuTuyen,
            [NamDuTuyen] = @NamDuTuyen,
            [TongDiemDauVao] = @TongDiemDauVao,
            [TotNghiepLT] = @TotNghiepLT,
            [TotNghiepTH] = @TotNghiepTH,
            [BaoVeLuanVan] = @BaoVeLuanVan,
			NoiSinh = @NoiSinh,
			MienThi1 = @MienThi1,
			MienThi2 = @MienThi2,
			MienThi3 = @MienThi3,
			MienThi4 = @MienThi4,
			MienThi5 = @MienThi5
        WHERE
            [id] = @id

    END
	go
	
ALTER PROCEDURE [dbo].[HC_VatTuTaiSan_Coll_get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get HC_VatTuTaiSan_Info from table */
        SELECT
            [HC_VatTuTaiSan].[ID],
            [HC_VatTuTaiSan].[TenVatTu],
            [HC_VatTuTaiSan].[MaVatTu],
            [HC_VatTuTaiSan].[NgayNhan],
            [HC_VatTuTaiSan].[HieuMay],
            [HC_VatTuTaiSan].[SerialMay],
            [HC_VatTuTaiSan].[NguonKinhPhi],
            [HC_VatTuTaiSan].[TyLeKhauHao],
            [HC_VatTuTaiSan].[TinhTrang],
            [HC_VatTuTaiSan].[XuatXu],
            [HC_VatTuTaiSan].[NgayNhap],
            [HC_VatTuTaiSan].[NhanVienQuanLy],
            [HC_VatTuTaiSan].[ViTriDatMay],
            [HC_VatTuTaiSan].[SoLanHong],
            [HC_VatTuTaiSan].[PhuKien],
            [HC_VatTuTaiSan].[GhiChu],
            [HC_VatTuTaiSan].[idNguonKinhPhi],
            [HC_VatTuTaiSan].[idCanBoQuanLy],
            [HC_VatTuTaiSan].[LastEdited_UserID],
            [HC_VatTuTaiSan].[LastEdited_Date],
            [HC_VatTuTaiSan].[Type],
            [HC_VatTuTaiSan].[Backup1],
            [HC_VatTuTaiSan].[backup2],
            [HC_VatTuTaiSan].[backup3],
            [HC_VatTuTaiSan].[backup4],
            [HC_VatTuTaiSan].[DonVi],
            [HC_VatTuTaiSan].[NamDuaVaoSuDung],
       DIC_NguonKinhPhi.Ten as TenNguonKinhPhi,
			DIC_CanBo.HoTen as TenCanBoQuanLy,
			pgntb.MuonTen1 AS NguoiMuonCuoi
        FROM [dbo].[HC_VatTuTaiSan] left join DIC_CanBo on HC_VatTuTaiSan.idCanBoQuanLy = DIC_CanBo.ID
		left join DIC_NguonKinhPhi on HC_VatTuTaiSan.idNguonKinhPhi = DIC_NguonKinhPhi.ID
		LEFT JOIN dbo.HC_PhieuGiaoNhanThietBi pgntb ON pgntb.ID = (SELECT TOP(1) vp.IDPhieuGiaoNhan FROM HC_VatTuTaiSan_PhieuGiaoNhan vp WHERE vp.IDVatTuTaiSan = [HC_VatTuTaiSan].ID ORDER BY vp.IDPhieuGiaoNhan DESC )


    END
	go
	
ALTER PROCEDURE [dbo].[HC_PhieuGiaoViec_update]
    @ID int,
    @idNguoiDuocGiao bigint,
    @idNguoiGiaoViec bigint,
    @idNguoiTongHop1 bigint,
    @idNguoiTongHop2 bigint,
    @NoiDungCongViec nvarchar(MAX),
    @GhiChu nvarchar(MAX),
    @TrangThai nvarchar(MAX),
    @NgayGiao datetime,
    @BatDauTuNgay datetime,
    @LyDo nvarchar(MAX),
    @PhaiXongNgay datetime,
    @idBoPhanCanBoDuocGiao int,
    @idUserLastEdited bigint,
    @DateLastEdited datetime,
    @ListIDCanBoDuocGiao nvarchar(MAX),
    @ListHoTenCanBoDuocGiao nvarchar(MAX),
    @backup01 nvarchar(MAX),
    @backup02 nvarchar(MAX),
    @backup03 nvarchar(MAX),
    @ListIDUserDuocGiao nvarchar(MAX),
	@Link nvarchar(max)
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[HC_PhieuGiaoViec]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.HC_PhieuGiaoViec'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.HC_PhieuGiaoViec */
        UPDATE [dbo].[HC_PhieuGiaoViec]
        SET
            [idNguoiDuocGiao] = @idNguoiDuocGiao,
            [idNguoiGiaoViec] = @idNguoiGiaoViec,
            [idNguoiTongHop1] = @idNguoiTongHop1,
            [idNguoiTongHop2] = @idNguoiTongHop2,
            [NoiDungCongViec] = @NoiDungCongViec,
            [GhiChu] = @GhiChu,
            [TrangThai] = @TrangThai,
            [NgayGiao] = @NgayGiao,
            [BatDauTuNgay] = @BatDauTuNgay,
            [LyDo] = @LyDo,
            [PhaiXongNgay] = @PhaiXongNgay,
            [idBoPhanCanBoDuocGiao] = @idBoPhanCanBoDuocGiao,
            [idUserLastEdited] = @idUserLastEdited,
            [DateLastEdited] = @DateLastEdited,
            [ListIDCanBoDuocGiao] = @ListIDCanBoDuocGiao,
            [ListHoTenCanBoDuocGiao] = @ListHoTenCanBoDuocGiao,
            [backup01] = @backup01,
            [backup02] = @backup02,
            [backup03] = @backup03,
            [ListIDUserDuocGiao] = @ListIDUserDuocGiao,
			Link = @Link
        WHERE
            [ID] = @ID

    END
go

ALTER PROCEDURE [dbo].[HC_PhieuGiaoViec_get]
    @ID int
AS
    BEGIN

        SET NOCOUNT ON

        /* Get HC_PhieuGiaoViec from table */
        SELECT
            [HC_PhieuGiaoViec].[ID],
            [HC_PhieuGiaoViec].[idNguoiDuocGiao],
            [HC_PhieuGiaoViec].[idNguoiGiaoViec],
            [HC_PhieuGiaoViec].[idNguoiTongHop1],
            [HC_PhieuGiaoViec].[idNguoiTongHop2],
            [HC_PhieuGiaoViec].[NoiDungCongViec],
            [HC_PhieuGiaoViec].[GhiChu],
            [HC_PhieuGiaoViec].[TrangThai],
            [HC_PhieuGiaoViec].[NgayGiao],
            [HC_PhieuGiaoViec].[BatDauTuNgay],
            [HC_PhieuGiaoViec].[LyDo],
            [HC_PhieuGiaoViec].[PhaiXongNgay],
            [HC_PhieuGiaoViec].[idBoPhanCanBoDuocGiao],
            [HC_PhieuGiaoViec].[idUserLastEdited],
            [HC_PhieuGiaoViec].[DateLastEdited],
            [HC_PhieuGiaoViec].[ListIDCanBoDuocGiao],
            [HC_PhieuGiaoViec].[ListHoTenCanBoDuocGiao],
            [HC_PhieuGiaoViec].[backup01],
            [HC_PhieuGiaoViec].[backup02],
            [HC_PhieuGiaoViec].[backup03],
			dbo.HC_PhieuGiaoViec.Link,
            [HC_PhieuGiaoViec].[ListIDUserDuocGiao],
			ADM_NguoiDung.TenDayDu as TenNguoiGiaoViec
        FROM [dbo].[HC_PhieuGiaoViec] left join ADM_NguoiDung on HC_PhieuGiaoViec.idNguoiGiaoViec = ADM_NguoiDung.IDNguoiDung
        WHERE
            [HC_PhieuGiaoViec].[ID] = @ID

    END

	GO

	
ALTER PROCEDURE [dbo].[HC_PhieuGiaoViec_add]
    @ID int OUTPUT,
    @idNguoiDuocGiao bigint,
    @idNguoiGiaoViec bigint,
    @idNguoiTongHop1 bigint,
    @idNguoiTongHop2 bigint,
    @NoiDungCongViec nvarchar(MAX),
    @GhiChu nvarchar(MAX),
    @TrangThai nvarchar(MAX),
    @NgayGiao datetime,
    @BatDauTuNgay datetime,
    @LyDo nvarchar(MAX),
    @PhaiXongNgay datetime,
    @idBoPhanCanBoDuocGiao int,
    @idUserLastEdited bigint,
    @DateLastEdited datetime,
    @ListIDCanBoDuocGiao nvarchar(MAX),
    @ListHoTenCanBoDuocGiao nvarchar(MAX),
    @backup01 nvarchar(MAX),
    @backup02 nvarchar(MAX),
    @backup03 nvarchar(MAX),
    @ListIDUserDuocGiao nvarchar(MAX),
	@Link NVARCHAR(max)
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.HC_PhieuGiaoViec */
        INSERT INTO [dbo].[HC_PhieuGiaoViec]
        (
            [idNguoiDuocGiao],
            [idNguoiGiaoViec],
            [idNguoiTongHop1],
            [idNguoiTongHop2],
            [NoiDungCongViec],
            [GhiChu],
            [TrangThai],
            [NgayGiao],
            [BatDauTuNgay],
            [LyDo],
            [PhaiXongNgay],
            [idBoPhanCanBoDuocGiao],
            [idUserLastEdited],
            [DateLastEdited],
            [ListIDCanBoDuocGiao],
            [ListHoTenCanBoDuocGiao],
            [backup01],
            [backup02],
            [backup03],
            [ListIDUserDuocGiao],
			Link
        )
        VALUES
        (
            @idNguoiDuocGiao,
            @idNguoiGiaoViec,
            @idNguoiTongHop1,
            @idNguoiTongHop2,
            @NoiDungCongViec,
            @GhiChu,
            @TrangThai,
            @NgayGiao,
            @BatDauTuNgay,
            @LyDo,
            @PhaiXongNgay,
            @idBoPhanCanBoDuocGiao,
            @idUserLastEdited,
            @DateLastEdited,
            @ListIDCanBoDuocGiao,
            @ListHoTenCanBoDuocGiao,
            @backup01,
            @backup02,
            @backup03,
            @ListIDUserDuocGiao,
			@Link
        )

        /* Return new primary key */
        SET @ID = SCOPE_IDENTITY()

    END

	go
	ALTER VIEW [dbo].[DT_View_ChinhQuy_HocVien]
AS
SELECT        a.id, a.HoTen, a.NgaySinh, a.SoCMT, a.MaHocVien, a.GioiTinh, a.idTrinhDo, a.idChuyenNganh, a.TruongTotNghiep, a.NamTotNghiep, a.SoBang, a.NoiCongTac, a.DiaChiNhaRieng, a.DienThoaiNhaRieng, 
                         a.DiDong, a.Email, a.NgayCapCMT, a.NoiCapCMT, a.NgayDangKi, a.Anh, a.DauVaoMon1, a.DauVaoDiem1, a.DauVaoMon2, a.DauVaoDiem2, a.DauVaoMon3, a.DauVaoDiem3, a.DauVaoMon4, a.DauVaoDiem4, 
                         a.DauVaoMon5, a.DauVaoDiem5, a.DauVaoMon6, a.DauVaoDiem6, a.DanToc, a.TonGiao, a.QuanHeGiaDinh, a.DuocPhepThiLai, a.LyDoKhongDuocThiLai, a.LastEdited_User, a.LastEdited_Date, a.backup01, 
                         a.backup02, a.backup03, a.backup04, a.backup05, a.backup06, a.backup07, a.backup08, a.TongHocPhiPhaiDong, a.TongHocPhiDaDong, a.AllInOneHoaDon, a.SoLanInThe, a.SoLanInBangDiem, a.SoLanInBang, 
                         a.idLopHoc, a.SBD, a.idChuyenNganhDuThi, a.CapDoDuTuyen, a.KhoaDuTuyen, a.NamDuTuyen, a.TongDiemDauVao, a.TotNghiepLT, a.TotNghiepTH, a.BaoVeLuanVan,a.NoiSinh,a.mienthi1,a.MienThi2,a.MienThi3,a.mienthi4,a.mienthi5, b.TenLop, b.MaLop AS TenMaLop, 
                         b.NamHoc AS TenNamHocLop, c.Ten AS TenChuyenKhoaLop, d2.Ten AS TenChuyenNganhLop, d1.Ten AS TenChuyenNganh, e.TenHocVi AS TenTrinhDo, b.Khoa AS TenKhoaLop, 
                         d3.Ten AS TenChuyenNganhDuThi
FROM            dbo.DT_ChinhQuy_HocVien AS a LEFT OUTER JOIN
                         dbo.DT_ChinhQuy_LopHoc AS b ON a.idLopHoc = b.ID LEFT OUTER JOIN
                         dbo.DIC_ChuyenKhoa AS c ON b.idChuyenKhoa = c.ID LEFT OUTER JOIN
                         dbo.DIC_ChuyenNganh AS d1 ON a.idChuyenNganh = d1.ID LEFT OUTER JOIN
                         dbo.DIC_ChuyenNganh AS d2 ON b.idChuyenNganh = d2.ID LEFT OUTER JOIN
                         dbo.DIC_ChuyenNganh AS d3 ON a.idChuyenNganhDuThi = d3.ID LEFT OUTER JOIN
                         dbo.DIC_HocVi AS e ON a.idTrinhDo = e.ID

GO



