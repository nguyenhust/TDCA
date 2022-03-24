Create Table HocVienImport
(
HoTen nvarchar(100),
NgaySinh DateTime,
GioiTinh nvarchar(20),
SoCMT nvarchar(30),
NgayCap Datetime,
NoiCap nvarchar(50),
TrinhDo nvarchar(50),
ChuyenNganh nvarchar(100),
TruongTotNghiep nvarchar(150),
SoBang nvarchar(50),
NamTotNghiep int,
NoiCongTac nvarchar(150),
TinhThanh nvarchar(150),
DiaChiCoQuan nvarchar(250),
BoPhanQuanLy nvarchar(250),
HinhThucHoc nvarchar(150),
NgayDangKy datetime,
ChuyenKhoa nvarchar(250),
NoiDungHoc nvarchar(250),
TrangThai nvarchar(150),
NgayBatDau datetime,
NgayKetThuc datetime,
SoTien nvarchar(50),
IDNguoiQuanLy bigint
)

GO

USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[HocVienImport_Ins]    Script Date: 10/06/2019 10:33:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[HocVienImport_Ins]
AS
    BEGIN

        SET NOCOUNT ON

        INSERT INTO DT_LienTuc_HocVien(HoTen,NgaySinh,GioiTinh,SoCMT,NgayCapCMT, IDTrinhDo,TruongTotNghiep,SoBang,NamTotNghiep,IDBenhVienCongTac,IDTinhThanh,
		DiaChiCoQuan, IDBoPhan, HinhThucHoc, NgayDangKi,IDChuyenNganhDangKi, idKhungLopHoc, TrangThai, NgayBatDau, NgayKetThuc, TongHocPhi, NoiDungDaoTao,idNguoiQuanLy,idChuyenNganh) 

		select HoTen,NgaySinh,GioiTinh,SoCMT,NgayCap as NgayCapCMT, IDTrinhDo,TruongTotNghiep,SoBang,NamTotNghiep,IDBenhVienCongTac,IDTinhThanh,
		DiaChiCoQuan, IDBoPhan, HinhThucHoc, NgayDangKy as NgayDangKi,IDChuyenNganhDangKy as IDChuyenNganhDangKi, klh.id as IDKhungLopHoc, TrangThai, NgayBatDau, NgayKetThuc, SoTien,NoiDungHoc,IDNguoiQuanLy,cn.ID as IDChuyenNganh from (
		select HoTen,NgaySinh,GioiTinh,SoCMT,NgayCap,hv.ID as IDTrinhDo,ChuyenNganh,TruongTotNghiep,SoBang,NamTotNghiep,bv.ID as IDBenhVienCongTac,tt.ID as IDTinhThanh,
		DiaChiCoQuan, bp.ID as IDBoPhan, HinhThucHoc, NgayDangKy,ck.ID as IDChuyenNganhDangKy, NoiDungHoc, TrangThai, NgayBatDau, NgayKetThuc, SoTien,IDNguoiQuanLy from HocVienImport ds
		left join DIC_Tinh t on t.Ten = ds.NoiCap
		left join DIC_HocVi hv on hv.TenHocVi = ds.TrinhDo
		left join DIC_BenhVien bv on bv.Ten = ds.NoiCongTac
		left join DIC_Tinh tt on tt.Ten = ds.TinhThanh
		left join DIC_BoPhan bp on bp.Ten = ds.BoPhanQuanLy
		left join DIC_ChuyenKhoa ck on ck.Ten = ds.ChuyenKhoa)a
		left join (select ID,TenLop,idChuyenKhoa from DT_LienTuc_KhungLopHoc ) klh on klh.TenLop = a.NoiDungHoc
		left join (select ID,Ten,ID_ChuyenKhoa from DIC_ChuyenNganh ) cn on cn.Ten = a.ChuyenNganh
		where klh.idChuyenKhoa = a.IDChuyenNganhDangKy and cn.ID_ChuyenKhoa = a.IDChuyenNganhDangKy
    END

GO

USE [MDCT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DT_GetKhungLopHoc]
@TenLop nvarchar(200),
@TenChuyenKhoa nvarchar(200)
AS
    BEGIN

        SET NOCOUNT ON

        SELECT TenLop FROM DT_LienTuc_KhungLopHoc klh
		join DIC_ChuyenKhoa ck ON ck.ID = klh.idChuyenKhoa
		WHERE TenLop = @TenLop AND ck.Ten = @TenChuyenKhoa
END
GO

USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[DIC_GiangVien_update]    Script Date: 26/09/2019 9:46:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	ALTER PROCEDURE [dbo].[DIC_GiangVien_update]
 (   @ID bigint OUTPUT,
    @HoTen nvarchar(50),
    @GioiTinh nvarchar(10),
    @NgaySinh datetime,
    @IDTinh bigint,
    @ChoOHiennay nvarchar(MAX),
    @QuocGia nvarchar(50),
    @NgayVaoDang datetime,

    @IDCoQuan int,
    @IDChucVu int,
    @QTDaoTao nvarchar(MAX),
    @QTCongTac nvarchar(MAX),
    @KinhNghiemNN nvarchar(MAX),
    @NghienCuuTGia nvarchar(MAX),
    @NgoaiNguTinHoc nvarchar(MAX),
    @KhenThuongKyLuat nvarchar(MAX),
    @HTapNCuuNNgoai nvarchar(MAX),
  --  @IDBoPhan int,
    @MaNhanVien nvarchar(10),
    @MaNhanVienTheoMayCC nvarchar(10),
    @DienThoai nvarchar(12),
    @Email nvarchar(20),
    @LoaiCanBo int,
    @DanToc nvarchar(15),
    @SoCMT nvarchar(20),
    @NgayCap datetime,
    @NoiCap nvarchar(MAX),
    @GhiChu nvarchar(MAX),
    @idChuyenNganh int,
    @idChuyenKhoa int,
	@idHocHam int,    @IDTrinhDo int,@ChungChi nvarchar(50),@NamBatDau int
	)
	as
	begin
	set nocount on
	if(exists(select 1 from [DIC_GiangVien] where HoTen = @HoTen and ID<>@ID))
	begin
	raiserror (N'Tên giảng viên này đã tồn tại!',16,1,@HoTen)
	return
	end
	IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_GiangVien]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_GiangVien'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
			end
	 update  DIC_GiangVien
	 set
	HoTen=@HoTen,
	GioiTinh=@GioiTinh,
	NgaySinh=@NgaySinh,
	IDTinh=@IDTinh,
	ChoOHiennay=@ChoOHiennay,
	QuocGia=@QuocGia,
	NgayVaoDang=@NgayVaoDang,
	IDCoQuan=@IDCoQuan,
	IDChucVu=@IDChucVu,
	QTDaoTao=@QTDaoTao,
	QTCongTa=@QTCongTac,
	KinhNghiemNN=@KinhNghiemNN,
	NghienCuuTGia=@NghienCuuTGia,
	NgoaiNguTinHoc=@NgoaiNguTinHoc,
    KhenThuongKyLuat=@KhenThuongKyLuat,
    HTapNCuuNNgoai=@HTapNCuuNNgoai,
    --IDBoPhan=@IDBoPhan,
    MaNhanVien=@MaNhanVien,
    MaNhanVienTheoMayCC=@MaNhanVienTheoMayCC,
    DienThoai=@DienThoai,
	Email=@Email,
    LoaiCanBo=@LoaiCanBo,
    DanToc=@DanToc,
    SoCMT=@SoCMT,
    NgayCap=@NgayCap,
    NoiCap=@NoiCap,
    GhiChu=@GhiChu,
    idChuyenNganh=@idChuyenNganh,
   
	idChuyenKhoa=@idChuyenKhoa,
	 idHocHam=@idHocHam,
	IDTrinhDo=@IDTrinhDo,
	ChungChi=@ChungChi,
	NamBatDau=@NamBatDau
	where ID=@ID		
	end

GO

USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[DIC_GiangVien_add]    Script Date: 26/09/2019 9:36:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[DIC_GiangVien_add]
 (   @ID bigint OUTPUT,
    @HoTen nvarchar(50),
    @GioiTinh nvarchar(10),
    @NgaySinh datetime,
    @IDTinh bigint,
    @ChoOHiennay nvarchar(MAX),
    @QuocGia nvarchar(50),
    @NgayVaoDang datetime,
   
    @IDCoQuan int,
    @IDChucVu int,
    @QTDaoTao nvarchar(MAX),
    @QTCongTac nvarchar(MAX),
    @KinhNghiemNN nvarchar(MAX),
    @NghienCuuTGia nvarchar(MAX),
    @NgoaiNguTinHoc nvarchar(MAX),
    @KhenThuongKyLuat nvarchar(MAX),
    @HTapNCuuNNgoai nvarchar(MAX),
   -- @IDBoPhan int,
    @MaNhanVien nvarchar(10),
    @MaNhanVienTheoMayCC nvarchar(10),
    @DienThoai nvarchar(12),
    @Email nvarchar(20),
    @LoaiCanBo int,
    @DanToc nvarchar(15),
    @SoCMT nvarchar(20),
    @NgayCap datetime,
    @NoiCap nvarchar(MAX),
    @GhiChu nvarchar(MAX),
    @idChuyenNganh int,
    @idChuyenKhoa int,
	@idHocHam int, @IDTrinhDo int,
	@ChungChi nvarchar(50),
	@NamBatDau int 
	)
	as
	begin
	declare @strNgaySinh varchar(10),@strNgayVaoDang varchar(10),@strNgayCap varchar(10)
	set @strNgaySinh=CONVERT(varchar(10),@NgaySinh,103)
	set @strNgayVaoDang=CONVERT(varchar(10),@NgayVaoDang,103)
	set @strNgayCap=CONVERT(varchar(10),@NgayCap,103)
	set nocount on

	if(exists(select 1 from DIC_GiangVien where HoTen = @HoTen and NgaySinh = @NgaySinh))
	begin
		raiserror(N'Đã tồn tại giảng viên trong danh sách giảng viên',16,1,@HoTen)
		return
	end

	 INSERT INTO DIC_GiangVien
	(HoTen,
	NgaySinh,
	GioiTinh,
	IDTinh,
	ChoOHiennay,
	QuocGia,
	NgayVaoDang,
	IDCoQuan,
	IDChucVu,
	QTDaoTao,
	QTCongTa,
	KinhNghiemNN,
	NghienCuuTGia,
	NgoaiNguTinHoc,
    KhenThuongKyLuat,
    HTapNCuuNNgoai,
  --  IDBoPhan,
    MaNhanVien,
    MaNhanVienTheoMayCC,
    DienThoai,
	Email,
    LoaiCanBo,
    DanToc,
    SoCMT,
    NgayCap,
    NoiCap,
    GhiChu,
    idChuyenNganh,
	idChuyenKhoa,
	 idHocHam,
	IDTrinhDo,
	ChungChi,NamBatDau
	)
	VALUES
	( @HoTen ,
    
    @strNgaySinh ,
	@GioiTinh ,
    @IDTinh ,
    @ChoOHiennay ,
    @QuocGia ,
    @strNgayVaoDang ,
    
    @IDCoQuan ,
    @IDChucVu ,
    @QTDaoTao ,
    @QTCongTac ,
    @KinhNghiemNN ,
    @NghienCuuTGia ,
    @NgoaiNguTinHoc,
    @KhenThuongKyLuat ,
    @HTapNCuuNNgoai ,
  --  @IDBoPhan ,
    @MaNhanVien ,
    @MaNhanVienTheoMayCC ,
    @DienThoai ,
    @Email ,
    @LoaiCanBo ,
    @DanToc,
    @SoCMT ,
    @strNgayCap ,
    @NoiCap ,
    @GhiChu ,
    @idChuyenNganh ,
    @idChuyenKhoa ,
	@idHocHam ,
	@IDTrinhDo,@ChungChi,@NamBatDau
	)
	SET @ID = SCOPE_IDENTITY()
	end

GO

USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[DIC_CanBo_add]    Script Date: 26/09/2019 9:58:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[DIC_CanBo_add]
    @ID bigint OUTPUT,
    @HoTen nvarchar(MAX),
    @GioiTinh nvarchar(MAX),
    @NgaySinh datetime,
    @IDTinh bigint,
    @ChoOHiennay nvarchar(MAX),
    @QuocGia nvarchar(MAX),
    @NgayVaoDang datetime,
    @IDTrinhDo int,
    @IDCoQuan int,
    @IDChucVu int,
    @QTDaoTao nvarchar(MAX),
    @QTCongTac nvarchar(MAX),
    @KinhNghiemNN nvarchar(MAX),
    @NghienCuuTGia nvarchar(MAX),
    @NgoaiNguTinHoc nvarchar(MAX),
    @KhenThuongKyLuat nvarchar(MAX),
    @HTapNCuuNNgoai nvarchar(MAX),
    @IDBoPhan int,
    @MaNhanVien nvarchar(MAX),
    @MaNhanVienTheoMayCC nvarchar(MAX),
    @DienThoai nvarchar(MAX),
    @Email nvarchar(MAX),
    @LoaiCanBo int,
    @DanToc nvarchar(MAX),
    @SoCMT nvarchar(MAX),
    @NgayCap datetime,
    @NoiCap nvarchar(MAX),
    @GhiChu nvarchar(MAX),
    @idChuyenNganh int,
    @idChuyenKhoa int,
    @Backup01 nvarchar(MAX),
    @Backup02 nvarchar(MAX),
    @backup03 nvarchar(MAX),
    @LoaiHopDong nvarchar(MAX),
    @backupDate datetime,
    @LastEdited_IdUser nvarchar(MAX),
    @LastEdited_Datetime datetime
AS
    BEGIN

        SET NOCOUNT ON
		if(exists(select 1 from DIC_CanBo where HoTen = @HoTen and NgaySinh = @NgaySinh))
		begin
			raiserror(N'Đã tồn tại cán bộ trong danh sách cán bộ',16,1,@HoTen)
			return
		end

        /* Insert object into dbo.DIC_CanBo */
        INSERT INTO [dbo].[DIC_CanBo]
        (
            [HoTen],
            [GioiTinh],
            [NgaySinh],
            [IDTinh],
            [ChoOHiennay],
            [QuocGia],
            [NgayVaoDang],
            [IDTrinhDo],
            [IDCoQuan],
            [IDChucVu],
            [QTDaoTao],
            [QTCongTac],
            [KinhNghiemNN],
            [NghienCuuTGia],
            [NgoaiNguTinHoc],
            [KhenThuongKyLuat],
            [HTapNCuuNNgoai],
            [IDBoPhan],
            [MaNhanVien],
            [MaNhanVienTheoMayCC],
            [DienThoai],
            [Email],
            [LoaiCanBo],
            [DanToc],
            [SoCMT],
            [NgayCap],
            [NoiCap],
            [GhiChu],
            [idChuyenNganh],
            [idChuyenKhoa],
            [Backup01],
            [Backup02],
            [backup03],
            [LoaiHopDong],
            [backupDate],
            [LastEdited_IdUser],
            [LastEdited_Datetime]
        )
        VALUES
        (
            @HoTen,
            @GioiTinh,
            @NgaySinh,
            @IDTinh,
            @ChoOHiennay,
            @QuocGia,
            @NgayVaoDang,
            @IDTrinhDo,
            @IDCoQuan,
            @IDChucVu,
            @QTDaoTao,
            @QTCongTac,
            @KinhNghiemNN,
            @NghienCuuTGia,
            @NgoaiNguTinHoc,
            @KhenThuongKyLuat,
            @HTapNCuuNNgoai,
            @IDBoPhan,
            @MaNhanVien,
            @MaNhanVienTheoMayCC,
            @DienThoai,
            @Email,
            @LoaiCanBo,
            @DanToc,
            @SoCMT,
            @NgayCap,
            @NoiCap,
            @GhiChu,
            @idChuyenNganh,
            @idChuyenKhoa,
            @Backup01,
            @Backup02,
            @backup03,
            @LoaiHopDong,
            @backupDate,
            @LastEdited_IdUser,
            @LastEdited_Datetime
        )

        /* Return new primary key */
        SET @ID = SCOPE_IDENTITY()

    END
GO

USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[DIC_CanBo_update]    Script Date: 26/09/2019 10:08:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[DIC_CanBo_update]
    @ID bigint,
    @HoTen nvarchar(MAX),
    @GioiTinh nvarchar(MAX),
    @NgaySinh datetime,
    @IDTinh bigint,
    @ChoOHiennay nvarchar(MAX),
    @QuocGia nvarchar(MAX),
    @NgayVaoDang datetime,
    @IDTrinhDo int,
    @IDCoQuan int,
    @IDChucVu int,
    @QTDaoTao nvarchar(MAX),
    @QTCongTac nvarchar(MAX),
    @KinhNghiemNN nvarchar(MAX),
    @NghienCuuTGia nvarchar(MAX),
    @NgoaiNguTinHoc nvarchar(MAX),
    @KhenThuongKyLuat nvarchar(MAX),
    @HTapNCuuNNgoai nvarchar(MAX),
    @IDBoPhan int,
    @MaNhanVien nvarchar(MAX),
    @MaNhanVienTheoMayCC nvarchar(MAX),
    @DienThoai nvarchar(MAX),
    @Email nvarchar(MAX),
    @LoaiCanBo int,
    @DanToc nvarchar(MAX),
    @SoCMT nvarchar(MAX),
    @NgayCap datetime,
    @NoiCap nvarchar(MAX),
    @GhiChu nvarchar(MAX),
    @idChuyenNganh int,
    @idChuyenKhoa int,
    @Backup01 nvarchar(MAX),
    @Backup02 nvarchar(MAX),
    @backup03 nvarchar(MAX),
    @LoaiHopDong nvarchar(MAX),
    @backupDate datetime,
    @LastEdited_IdUser nvarchar(MAX),
    @LastEdited_Datetime datetime
AS
    BEGIN

        SET NOCOUNT ON
		if(exists(select 1 from DIC_CanBo where HoTen = @HoTen and ID <> @ID))
		begin
			raiserror(N'Đã tồn tại cán bộ trong danh sách cán bộ',16,1,@HoTen)
			return
		end

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
            [GioiTinh] = @GioiTinh,
            [NgaySinh] = @NgaySinh,
            [IDTinh] = @IDTinh,
            [ChoOHiennay] = @ChoOHiennay,
            [QuocGia] = @QuocGia,
            [NgayVaoDang] = @NgayVaoDang,
            [IDTrinhDo] = @IDTrinhDo,
            [IDCoQuan] = @IDCoQuan,
            [IDChucVu] = @IDChucVu,
            [QTDaoTao] = @QTDaoTao,
            [QTCongTac] = @QTCongTac,
            [KinhNghiemNN] = @KinhNghiemNN,
            [NghienCuuTGia] = @NghienCuuTGia,
            [NgoaiNguTinHoc] = @NgoaiNguTinHoc,
            [KhenThuongKyLuat] = @KhenThuongKyLuat,
            [HTapNCuuNNgoai] = @HTapNCuuNNgoai,
            [IDBoPhan] = @IDBoPhan,
            [MaNhanVien] = @MaNhanVien,
            [MaNhanVienTheoMayCC] = @MaNhanVienTheoMayCC,
            [DienThoai] = @DienThoai,
            [Email] = @Email,
            [LoaiCanBo] = @LoaiCanBo,
            [DanToc] = @DanToc,
            [SoCMT] = @SoCMT,
            [NgayCap] = @NgayCap,
            [NoiCap] = @NoiCap,
            [GhiChu] = @GhiChu,
            [idChuyenNganh] = @idChuyenNganh,
            [idChuyenKhoa] = @idChuyenKhoa,
            [Backup01] = @Backup01,
            [Backup02] = @Backup02,
            [backup03] = @backup03,
            [LoaiHopDong] = @LoaiHopDong,
            [backupDate] = @backupDate,
            [LastEdited_IdUser] = @LastEdited_IdUser,
            [LastEdited_Datetime] = @LastEdited_Datetime
        WHERE
            [ID] = @ID

    END
GO

USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[DIC_HocVi_add]    Script Date: 26/09/2019 11:14:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[DIC_HocVi_add]
    @ID int OUTPUT,
    @TenHocVi nvarchar(50),
	@TenTat NVARCHAR(50),
    @SuDung bit
AS
    BEGIN

        SET NOCOUNT ON
		if(exists(select 1 from DIC_HocVi where TenHocVi = @TenHocVi))
		begin
			raiserror(N'Đã tồn tại tên học vị trong danh sách học vị',16,1,@TenHocVi)
			return
		end

        /* Insert object into dbo.DIC_HocVi */
        INSERT INTO [dbo].[DIC_HocVi]
        (
            [TenHocVi],
			TenTat,
            [SuDung]
        )
        VALUES
        (
            @TenHocVi,
			@TenTat,
            @SuDung
        )

        /* Return new primary key */
        SET @ID = SCOPE_IDENTITY()

    END

GO

USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[DIC_HocVi_update]    Script Date: 26/09/2019 11:16:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[DIC_HocVi_update]
    @ID int,
    @TenHocVi nvarchar(50),
	@TenTat nvarchar(50),
    @SuDung bit
AS
    BEGIN

        SET NOCOUNT ON
		if(exists(select 1 from [DIC_HocVi] where TenHocVi = @TenHocVi and ID <> @ID))
		begin
			raiserror(N'Đã tồn tại học vị trong danh sách học vị',16,1,@TenHocVi)
			return
		end
        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_HocVi]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_HocVi'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.DIC_HocVi */
        UPDATE [dbo].[DIC_HocVi]
        SET
            [TenHocVi] = @TenHocVi,
			TenTat = @TenTat,
            [SuDung] = @SuDung
        WHERE
            [ID] = @ID

    END
GO

CREATE TABLE DIC_TruongTotNghiep
(
IDTruong bigint primary key identity,
MaTruong nvarchar(20),
TenTruong nvarchar(200),
DiaChi nvarchar(200),
SoDienThoai varchar(15),
GhiChu nvarchar(300)
)

GO

USE [MDCT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DIC_TruongTotNghiep_add]
    @IDTruong bigint OUTPUT,
    @MaTruong nvarchar(50),
	@TenTruong nvarchar(300),
	@DiaChi nvarchar(200),
	@SoDienThoai varchar(15),
    @GhiChu nvarchar(100)
AS
    BEGIN

        SET NOCOUNT ON

		IF(exists(SELECT 1 FROM [DIC_TruongTotNghiep] WHERE TenTruong = @TenTruong))
		BEGIN
			raiserror(N'Đã tồn tại tên trường trong danh sách trường tốt nghiệp',16,1,@TenTruong)
			return
		END
        /* Insert object into dbo.DIC_TruongTotNghiep */
        INSERT INTO [dbo].[DIC_TruongTotNghiep]
        (
            MaTruong,
			TenTruong,
			DiaChi,
			SoDienThoai,
            [GhiChu]
        )
        VALUES
        (
            @MaTruong,
			@TenTruong,
			@DiaChi,
			@SoDienThoai,
            @GhiChu
        )

        /* Return new primary key */
        SET @IDTruong = SCOPE_IDENTITY()

    END
GO

USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[DM_TrangThaiHocVien_update]    Script Date: 26/09/2019 10:57:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DIC_TruongTotNghiep_update]
    @IDTruong bigint,
    @MaTruong nvarchar(50),
	@TenTruong nvarchar(300),
	@DiaChi nvarchar(200),
	@SoDienThoai varchar(15),
    @GhiChu nvarchar(100)
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [IDTruong] FROM [dbo].[DIC_TruongTotNghiep]
            WHERE
                [IDTruong] = @IDTruong
        )
        BEGIN
            RAISERROR ('''dbo.DIC_TruongTotNghiep'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.DIC_ChucVu */
        UPDATE [dbo].[DIC_TruongTotNghiep]
        SET
			MaTruong = @MaTruong,
            TenTruong = @TenTruong,
			DiaChi = @DiaChi,
			SoDienThoai = @SoDienThoai,
            [GhiChu] = @GhiChu
        WHERE
            IDTruong = @IDTruong

    END
GO

USE [MDCT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DIC_TruongTotNghiep_get]
    @IDTruong bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DIC_ChucVu from table */
        SELECT *
        FROM [dbo].[DIC_TruongTotNghiep]
        WHERE
            [DIC_TruongTotNghiep].IDTruong = @IDTruong

    END
GO

USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[DM_TrangThaiHocVien_delete]    Script Date: 26/09/2019 11:04:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DIC_TruongTotNghiep_delete]
    @IDTruong bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT IDTruong FROM [dbo].[DIC_TruongTotNghiep]
            WHERE
                IDTruong = @IDTruong
        )
        BEGIN
            RAISERROR ('''dbo.[DIC_TruongTotNghiep]'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete DIC_ChucVu object from DIC_ChucVu */
        DELETE
        FROM [dbo].[DIC_TruongTotNghiep]
        WHERE
            [dbo].[DIC_TruongTotNghiep].IDTruong = @IDTruong

    END
GO

USE [MDCT]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DIC_TruongTotNghiep_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        SELECT
            *
        FROM [dbo].[DIC_TruongTotNghiep]

    END
GO

USE [MDCT]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_taoMaHocVien]    Script Date: 27/09/2019 2:58:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[fn_taoMaHocVien]( @MaHocVien varchar(17),@year varchar(10))  
RETURNS varchar(17) 
AS  
BEGIN 
	/*
	tim ra gia tri max cua so bien lai
	neu max=99999 thi tang so dau [AA] -> [AB],(tang ky tu thu 2 tu A -> Z)
	khi ky tu thu 2 tang den Z thi tang ky tu dau [A] - [Z]
	*/
	declare @dem int
	declare @tmSoBLT varchar(17)
	declare @prefix varchar(5),@sprefix varchar(2), @eprefix varchar(2);
	----select @dem=isnull(max(Convert(bigint,SubString(MaHocVien,1,4))),0)+1 from DT_LienTuc_HocVien where   substring(MaHocVien,5,13)=N'-KC-BM-'+ substring(@MaHocVien,12,2) + N'-B24'
	--select @dem=isnull(max(Convert(bigint,SubString(MaHocVien,1,4))),0)+1 from DT_LienTuc_HocVien where   substring(MaHocVien,5,13)=N'-KC-BM-'+ substring(CONVERT(varchar(4),@year),3,2) + N'-B24'
	select @dem = isnull(max(Convert(bigint,SubString(MaHocVien,1,CHARINDEX( N'-',MaHocVien) -1))),0)+1 from DT_LienTuc_HocVien where   substring(MaHocVien,CHARINDEX( N'-',MaHocVien),13)=N'-KC-BM-'+ substring(CONVERT(varchar(4),@year),3,2) + N'-B24'
	--select @tmSoBLT=case len(@dem)
	--	when 1 then	'000'
	--	when 2 then 	'00'
	--	when 3 then 	'0'
	--	when 4 then 	''
	--	--when 5 then       ''
	--	end  
	--set @tmSoBLT= @tmSoBLT +convert(varchar,@dem )+ '-KC-BM-'+ substring(CONVERT(varchar(4),@year),3,2) + '-B24'
	set @tmSoBLT= convert(varchar,@dem )+ '-KC-BM-'+ substring(CONVERT(varchar(4),@year),3,2) + '-B24'
	return @tmSoBLT
END

GO

USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[DIC_GiangVien_Coll_Gets]    Script Date: 29/09/2019 2:48:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


	---
	Create proc [dbo].[DIC_GiangVien_Coll_Gets_ChuyenKhoa]
	@IDChuyenKhoa bigint
as
set nocount on
begin
select gv.ID,gv.HoTen,gv.GioiTinh,gv.NgaySinh,gv.IDTinh,gv.ChoOHiennay,gv.QuocGia,gv.NgayVaoDang,gv.IDCoQuan,gv.IDChucVu,gv.QTDaoTao,gv.QTCongTa,gv.KinhNghiemNN,
gv.NghienCuuTGia,gv.NgoaiNguTinHoc,gv.KhenThuongKyLuat,gv.HTapNCuuNNgoai,gv.MaNhanVien,gv.MaNhanVienTheoMayCC,gv.DienThoai,gv.Email,gv.LoaiCanBo,gv.DanToc,gv.SoCMT,
gv.NgayCap,gv.NoiCap,gv.GhiChu,gv.idChuyenNganh,gv.idChuyenKhoa,gv.idHocHam,gv.IDTrinhDo,gv.ChungChi,gv.NamBatDau,
cn.Ten as TenChuyenNganh ,
hh.TenHocHam,
hv.TenHocVi,
cv.Ten as TenChucVu,
t.Ten as TenTinhThanh,
ck.Ten as ChuyenKhoa
from DIC_GiangVien gv
left  join DIC_HocVi hv on hv.ID=gv.idtrinhdo
left join DIC_ChucVu cv on cv.ID=gv.IDChucVu
left join DIC_HocHam hh on hh.ID=gv.idHocHam
left join DIC_ChuyenNganh cn on cn.ID=gv.idChuyenNganh
left join DIC_Tinh t on t.ID=gv.IDTinh
left join DIC_ChuyenKhoa ck on ck.ID=gv.idChuyenKhoa
where gv.idChuyenKhoa = @IDChuyenKhoa
end
GO

USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[DT_LienTuc_GiangVien_add]    Script Date: 29/09/2019 3:43:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DT_LienTuc_GiangVien_add]
    @ID int OUTPUT,
    @idGiangVien bigint,
    @SoTietThucTe int,
    @SoTietDuKien int,
    @idLopHoc nvarchar(50),
    @LastEdited_User bigint,
    @LastEdited_Date datetime,
    @backup01 nvarchar(MAX),
    @backup02 nvarchar(MAX),
    @backup03 nvarchar(MAX),
    @backup04 nvarchar(MAX),
    @backup05 int,
    @backup06 datetime
AS
    BEGIN

        SET NOCOUNT ON
		IF EXISTS
        (
            SELECT [idGiangVien] FROM [dbo].[DT_LienTuc_GiangVien]
            WHERE
                [idGiangVien] = @idGiangVien and idLopHoc = @idLopHoc
        )
        BEGIN
            RAISERROR ('''Giảng viên đã tồn tại.', 16, 1)
            RETURN
        END

        /* Insert object into dbo.DT_LienTuc_GiangVien */
        INSERT INTO [dbo].[DT_LienTuc_GiangVien]
        (
            [idGiangVien],
            [SoTietThucTe],
            [SoTietDuKien],
            [idLopHoc],
            [LastEdited_User],
            [LastEdited_Date],
            [backup01],
            [backup02],
            [backup03],
            [backup04],
            [backup05],
            [backup06]
        )
        VALUES
        (
            @idGiangVien,
            @SoTietThucTe,
            @SoTietDuKien,
            @idLopHoc,
            @LastEdited_User,
            @LastEdited_Date,
            @backup01,
            @backup02,
            @backup03,
            @backup04,
            @backup05,
            @backup06
        )

        /* Return new primary key */
        SET @ID = SCOPE_IDENTITY()

    END
GO

USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[DT_LienTuc_KhungLopHoc_Coll_get]    Script Date: 29/09/2019 10:26:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DT_LienTuc_KhungLopHoc_Coll_get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DT_LienTuc_KhungLopHoc_Info from table */
        SELECT
            [DT_LienTuc_KhungLopHoc].[id],
            Case when [DT_LienTuc_KhungLopHoc].[ThoiGianHoc] is null then [DT_LienTuc_KhungLopHoc].[TenLop] else [DT_LienTuc_KhungLopHoc].[TenLop] + ' ( ' + [DT_LienTuc_KhungLopHoc].[ThoiGianHoc] + ' )' end as TenLop,
            [DT_LienTuc_KhungLopHoc].[idChuyenKhoa],
			[DIC_ChuyenKhoa].[Ten] as ChuyenKhoa,
            [DT_LienTuc_KhungLopHoc].[HocPhi]
        FROM [dbo].[DT_LienTuc_KhungLopHoc] LEFT JOIN DIC_ChuyenKhoa
		ON [DIC_ChuyenKhoa].[ID] = [DT_LienTuc_KhungLopHoc].[idChuyenKhoa]
		ORDER BY TenLop,Ten
    END
GO

Create table HC_LichLamViecTheoPhong
(
IDLich bigint primary key identity,
IDNguoiDung bigint,
TenPhong nvarchar(200),
NgayTao datetime,
TuNgay datetime,
DenNgay datetime,
GhiChu nvarchar(200)
)

Create table HC_LichLamViecTheoPhong_CT
(
IDLichChiTiet bigint primary key identity,
IDLich bigint,
Ngay datetime,
Thu nvarchar(50),
Gio nvarchar(50),
NgayTaoCT Datetime,
NoiDung nvarchar(500),
SoLuongHocVien nvarchar(100),
DiaDiem nvarchar(200),
CoDangKy bit,
IDCanBoPhuTrach bigint,
NguonKinhPhi nvarchar(200)
CONSTRAINT fk_idlich FOREIGN KEY (IDLich)
   REFERENCES HC_LichLamViecTheoPhong (IDLich)
)
GO

USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[DT_LichGiangTheoLop_CT_Info_ins]    Script Date: 30/09/2019 8:57:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[HC_LichLamViecTheoPhong_CT_Info_ins]
    @IDLichChiTiet bigint OUTPUT,
    @IDLich bigint,
    @Thu nvarchar(50),
    @Gio nvarchar(50),
	@Ngay Datetime,
    @NoiDung nvarchar(300),
    @NgayTaoCT Datetime,
    @SoLuongHocVien nvarchar(50),
	@DiaDiem nvarchar(200),
    @CoDangKy bit,
    @IDCanBoPhuTrach bigint,
	@NguonKinhPhi nvarchar(30)
AS
    BEGIN

        SET NOCOUNT ON

        INSERT INTO [dbo].[HC_LichLamViecTheoPhong_CT]
        (
            IDLich,
            Ngay,
			Thu,
            Gio,
            NoiDung,
            NgayTaoCT,
            SoLuongHocVien,
            DiaDiem,
			CoDangKy,
			IDCanBoPhuTrach,
			NguonKinhPhi
        )
        VALUES
        (
            @IDLich,
            @Ngay,
			@Thu,
            @Gio,
            @NoiDung,
			GETDATE(),
            @SoLuongHocVien,
            @DiaDiem,
            @CoDangKy,
			@IDCanBoPhuTrach,
			@NguonKinhPhi
        )

        /* Return new primary key */
        SET @IDLichChiTiet = SCOPE_IDENTITY()

    END
GO

USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[DT_LichGiangTheoLop_CT_Info_upd]    Script Date: 30/09/2019 9:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HC_LichLamViecTheoPhong_CT_Info_upd]
    @IDLichChiTiet bigint OUTPUT,
    @Thu nvarchar(50),
    @Gio nvarchar(50),
	@Ngay Datetime,
    @NoiDung nvarchar(300),
    @NgayTaoCT Datetime,
    @SoLuongHocVien nvarchar(50),
	@DiaDiem nvarchar(200),
    @CoDangKy bit,
    @IDCanBoPhuTrach bigint,
	@NguonKinhPhi nvarchar(30)
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT @IDLichChiTiet FROM [dbo].[HC_LichLamViecTheoPhong_CT]
            WHERE
                IDLichChiTiet = @IDLichChiTiet
        )
        BEGIN
            RAISERROR ('''dbo.[HC_LichLamViecTheoPhong_CT]'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.[CDT_LichGiangTheoLop_CT] */
        UPDATE [dbo].[HC_LichLamViecTheoPhong_CT]
        SET
            Ngay = @Ngay,
			Thu = @Thu,
            Gio = @Gio,
            [NoiDung] = @NoiDung,
            [NgayTaoCT] = @NgayTaoCT,
            SoLuongHocVien = @SoLuongHocVien,
			DiaDiem = @DiaDiem,
			CoDangKy = @CoDangKy,
			IDCanBoPhuTrach = @IDCanBoPhuTrach,
			NguonKinhPhi = @NguonKinhPhi
        WHERE
            [IDLichChiTiet] = @IDLichChiTiet

    END

GO

USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[DT_LichGiangTheoLop_CT_Info_del]    Script Date: 30/09/2019 9:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[HC_LichLamViecTheoPhong_CT_Info_del]
    @IDLichChiTiet bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT IDLichChiTiet FROM [dbo].[HC_LichLamViecTheoPhong_CT]
            WHERE
                IDLichChiTiet = @IDLichChiTiet
        )
        BEGIN
            RAISERROR ('''dbo.HC_LichLamViecTheoPhong_CT'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete DT_DuAn_Info object from DT_DuAn */
        DELETE
        FROM [dbo].[HC_LichLamViecTheoPhong_CT]
        WHERE
            [dbo].[HC_LichLamViecTheoPhong_CT].[IDLichChiTiet] = @IDLichChiTiet

    END
GO

USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[DT_LichGiangTheoLop_ins]    Script Date: 30/09/2019 9:14:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HC_LichLamViecTheoPhong_ins]
    @IDLich bigint OUTPUT,
	@IDNguoiDung bigint,
    @TenPhong nvarchar(200),
    @NgayTao datetime,
    @TuNgay datetime,
    @DenNgay datetime,
    @GhiChu nvarchar(200)
AS
    BEGIN

        SET NOCOUNT ON
		
		IF(dbo.KiemTraNgayNhap(@TuNgay) = 0)
		BEGIN
			DECLARE @Message NVARCHAR(200)
			SET @Message = N'Bạn đang ở năm: ' + cast(YEAR(GETDATE()) AS CHAR(4)) + N' không thể cập nhật trường dữ liệu "Từ ngày" ở năm: ' + CAST(YEAR(@TuNgay) AS CHAR(4))
			raiserror(@Message,16,1)
			return;
		END
		
		IF(dbo.KiemTraNgayNhap(@DenNgay) = 0)
		BEGIN
			DECLARE @Message1 NVARCHAR(200)
			SET @Message1 = N'Bạn đang ở năm: ' + cast(YEAR(GETDATE()) AS CHAR(4)) + N' không thể cập nhật trường dữ liệu "Đến ngày" ở năm: ' + CAST(YEAR(@DenNgay) AS CHAR(4))
			raiserror(@Message1,16,1)
			return;
		END
			
        /* Insert object into dbo.PhieuNhap */
        INSERT INTO [dbo].[HC_LichLamViecTheoPhong]
        (
            IDNguoiDung,
            TenPhong,
            NgayTao,
            TuNgay,
            DenNgay,
            GhiChu
        )
        VALUES
        (
            @IDNguoiDung,
            @TenPhong,
            GETDATE(),
            @TuNgay,
            @DenNgay,
            @GhiChu            
		)

        /* Return new primary key */
        SET @IDLich = SCOPE_IDENTITY()

    END
GO

USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[DT_LichGiangTheoLop_upd]    Script Date: 30/09/2019 9:19:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[HC_LichLamViecTheoPhong_upd]
    @IDLich bigint,
	@IDNguoiDung bigint,
    @TenPhong nvarchar(200),
    @NgayTao datetime,
    @TuNgay datetime,
    @DenNgay datetime,
    @GhiChu nvarchar(200)
AS
    BEGIN

        SET NOCOUNT ON
        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT IDLich FROM [dbo].[HC_LichLamViecTheoPhong]
            WHERE
                IDLich = @IDLich
        )
        BEGIN
            RAISERROR ('''dbo.HC_LichLamViecTheoPhong'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END
        /*Check field NgayNhapHoaDon */
        IF(dbo.KiemTraNgayNhap(@TuNgay) = 0)
		BEGIN
			DECLARE @Message NVARCHAR(200)
			SET @Message = N'Bạn đang ở năm: ' + cast(YEAR(GETDATE()) AS CHAR(4)) + N' không thể cập nhật trường dữ liệu "Từ ngày" ở năm: ' + CAST(YEAR(@TuNgay) AS CHAR(4))
			raiserror(@Message,16,1)
			return;
		END
		/*Check field NgayNhanHang */
		IF(dbo.KiemTraNgayNhap(@DenNgay) = 0)
		BEGIN
			DECLARE @Message1 NVARCHAR(200)
			SET @Message1 = N'Bạn đang ở năm: ' + cast(YEAR(GETDATE()) AS CHAR(4)) + N' không thể cập nhật trường dữ liệu "Đến ngày" ở năm: ' + CAST(YEAR(@DenNgay) AS CHAR(4))
			raiserror(@Message1,16,1)
			return;
		END

        /* Update object in dbo.PhieuNhap */
        UPDATE [dbo].[HC_LichLamViecTheoPhong]
        SET
            IDNguoiDung = @IDNguoiDung,
            TenPhong = @TenPhong,
            NgayTao = @NgayTao,
            TuNgay = @TuNgay,
            DenNgay = @DenNgay,
            GhiChu = @GhiChu
        WHERE
            IDLich = @IDLich

    END
GO

USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[DT_LichGiangTheoLop_del]    Script Date: 30/09/2019 9:25:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[HC_LichLamViecTheoPhong_del]
    @IDLich bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [IDLich] FROM [dbo].[HC_LichLamViecTheoPhong]
            WHERE
                [IDLich] = @IDLich
        )
        BEGIN
            RAISERROR ('''dbo.[HC_LichLamViecTheoPhong]'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END
		/* Delete [CDT_LichGiangTheoLop_CT] object from CDT_LichGiangTheoLop_CT */
        DELETE
        FROM [dbo].[HC_LichLamViecTheoPhong_CT]
        WHERE
            [dbo].[HC_LichLamViecTheoPhong_CT].[IDLich] = @IDLich
        /* Delete [CDT_LichGiangTheoLop] object from [CDT_LichGiangTheoLop] */
        DELETE
        FROM [dbo].[HC_LichLamViecTheoPhong]
        WHERE
            [dbo].[HC_LichLamViecTheoPhong].[IDLich] = @IDLich

    END
GO

USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[DT_LichGiangTheoLop_get]    Script Date: 30/09/2019 9:27:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[HC_LichLamViecTheoPhong_get]
    @IDLich bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Get PhieuNhap from table */
        SELECT
            *
        FROM [dbo].[HC_LichLamViecTheoPhong]
        WHERE
            [HC_LichLamViecTheoPhong].IDLich = @IDLich

        /* Get PhieuNhapCTInfo from table */
        SELECT  ct.* FROM [dbo].[HC_LichLamViecTheoPhong_CT] ct
            Inner JOIN [dbo].[HC_LichLamViecTheoPhong] ON ct.IDLich = [HC_LichLamViecTheoPhong].IDLich
        WHERE
            [HC_LichLamViecTheoPhong].IDLich= (select IDLich from HC_LichLamViecTheoPhong where IDLich = @IDLich)
			order by NgayThu, Gio asc
    END
GO

USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[HC_BieuMauISO_Coll_get]    Script Date: 30/09/2019 11:00:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[HC_BieuMauISO_Coll_get]
@IDUser bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Get HC_BieuMauISO_Info from table */
        SELECT
          *
        FROM [dbo].HC_View_BieuMauISO_ForGrid 
		--Where IDNguoiDung = @IDUser or idUserUp = @IDUser
	    Order by Ten asc

    END
GO





ALTER PROCEDURE [dbo].[DT_LienTuc_HocVien_Coll_get_ChuaInThe]
@NamHoc int,
@PhongQuanLy int,
@LoaiHinhDaoTao nvarchar(MAX)
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DT_LienTuc_HocVien_Info from table */
		IF(LOWER(@LoaiHinhDaoTao) = N'toàn bộ' AND @NamHoc = 0 AND @PhongQuanLy = 0)
		BEGIN
        select ID,HoTen,NgaySinh,SoCMT,HinhThucHoc,TrangThai,MaHocVien,hv.GioiTinh,NgayDangKi, hv.NgayBatDau, hv.NgayKetThuc,Anh,TongSoLanInThe, TongSoLanInGiayChungNhan,TenBenhVien, TenTinhThanh, 
case when hv.HinhThucHoc = N'Theo lớp' then lh.TenLop else hv.TenLopHoc end as TenLopHoc, TenChuyenKhoaLopHoc, TenKhoaHoc, idBenhVienCongTac,HinhThucHoc,MaLopHoc from DT_View_LienTuc_HocVien hv
left join DT_LienTuc_LopHoc lh on lh.MaLop = hv.MaLopHoc 
			Where (TongSoLanInThe <= 0 OR TongSoLanInThe is null)and (MaHocVien is not null or MaHocVien <> '') and (TrangThai = N'Chưa bắt đầu học' or TrangThai = N'Đang học')
			order by NgayKetThuc desc
		END
		ELSE
		IF(LOWER(@LoaiHinhDaoTao) = N'toàn bộ' AND @NamHoc > 0 AND @PhongQuanLy = 0)
		BEGIN
        select ID,HoTen,NgaySinh,SoCMT,HinhThucHoc,TrangThai,MaHocVien,hv.GioiTinh,NgayDangKi, hv.NgayBatDau, hv.NgayKetThuc,Anh,TongSoLanInThe, TongSoLanInGiayChungNhan,TenBenhVien, TenTinhThanh, 
case when hv.HinhThucHoc = N'Theo lớp' then lh.TenLop else hv.TenLopHoc end as TenLopHoc, TenChuyenKhoaLopHoc, TenKhoaHoc, idBenhVienCongTac,HinhThucHoc,MaLopHoc from DT_View_LienTuc_HocVien hv
left join DT_LienTuc_LopHoc lh on lh.MaLop = hv.MaLopHoc 
Where (TongSoLanInThe <= 0 OR TongSoLanInThe is null)and (MaHocVien is not null or MaHocVien <> '') and (TrangThai = N'Chưa bắt đầu học' or TrangThai = N'Đang học')
		AND YEAR(hv.NgayBatDau) = @NamHoc 
        order by NgayKetThuc desc
		END
		ELSE
		IF(LOWER(@LoaiHinhDaoTao) = N'toàn bộ' AND @NamHoc = 0 AND @PhongQuanLy > 0)
		BEGIN
        select ID,HoTen,NgaySinh,SoCMT,HinhThucHoc,TrangThai,MaHocVien,hv.GioiTinh,NgayDangKi, hv.NgayBatDau, hv.NgayKetThuc,Anh,TongSoLanInThe, TongSoLanInGiayChungNhan,TenBenhVien, TenTinhThanh, 
case when hv.HinhThucHoc = N'Theo lớp' then lh.TenLop else hv.TenLopHoc end as TenLopHoc, TenChuyenKhoaLopHoc, TenKhoaHoc, idBenhVienCongTac,HinhThucHoc,MaLopHoc from DT_View_LienTuc_HocVien hv
left join DT_LienTuc_LopHoc lh on lh.MaLop = hv.MaLopHoc
Where (TongSoLanInThe <= 0 OR TongSoLanInThe is null)and (MaHocVien is not null or MaHocVien <> '') and (TrangThai = N'Chưa bắt đầu học' or TrangThai = N'Đang học')
		And hv.IdBoPhan = @PhongQuanLy
        order by NgayKetThuc desc
		END
		ELSE
		IF(LOWER(@LoaiHinhDaoTao) = N'toàn bộ' AND @NamHoc > 0 AND @PhongQuanLy > 0)
		BEGIN
        select ID,HoTen,NgaySinh,SoCMT,HinhThucHoc,TrangThai,MaHocVien,hv.GioiTinh,NgayDangKi, hv.NgayBatDau, hv.NgayKetThuc,Anh,TongSoLanInThe, TongSoLanInGiayChungNhan,TenBenhVien, TenTinhThanh, 
case when hv.HinhThucHoc = N'Theo lớp' then lh.TenLop else hv.TenLopHoc end as TenLopHoc, TenChuyenKhoaLopHoc, TenKhoaHoc, idBenhVienCongTac,HinhThucHoc,MaLopHoc from DT_View_LienTuc_HocVien hv
left join DT_LienTuc_LopHoc lh on lh.MaLop = hv.MaLopHoc
Where (TongSoLanInThe <= 0 OR TongSoLanInThe is null)and (MaHocVien is not null or MaHocVien <> '') and (TrangThai = N'Chưa bắt đầu học' or TrangThai = N'Đang học')
				AND hv.[HinhThucHoc] like @LoaiHinhDaoTao
				AND YEAR(hv.NgayBatDau) = @NamHoc 
		And hv.IdBoPhan = @PhongQuanLy
        order by NgayKetThuc desc
		END
		ELSE
		IF(LOWER(@LoaiHinhDaoTao) <> N'toàn bộ' AND @NamHoc = 0 AND @PhongQuanLy = 0)
		BEGIN
        select ID,HoTen,NgaySinh,SoCMT,HinhThucHoc,TrangThai,MaHocVien,hv.GioiTinh,NgayDangKi, hv.NgayBatDau, hv.NgayKetThuc,Anh,TongSoLanInThe, TongSoLanInGiayChungNhan,TenBenhVien, TenTinhThanh, 
case when hv.HinhThucHoc = N'Theo lớp' then lh.TenLop else hv.TenLopHoc end as TenLopHoc, TenChuyenKhoaLopHoc, TenKhoaHoc, idBenhVienCongTac,HinhThucHoc,MaLopHoc from DT_View_LienTuc_HocVien hv
left join DT_LienTuc_LopHoc lh on lh.MaLop = hv.MaLopHoc 
Where (TongSoLanInThe <= 0 OR TongSoLanInThe is null)and (MaHocVien is not null or MaHocVien <> '') and (TrangThai = N'Chưa bắt đầu học' or TrangThai = N'Đang học')
				AND hv.[HinhThucHoc] like @LoaiHinhDaoTao
        order by NgayKetThuc desc
		END
		ELSE
		IF(LOWER(@LoaiHinhDaoTao) <> N'toàn bộ' AND @NamHoc > 0 AND @PhongQuanLy = 0)
		BEGIN
        select ID,HoTen,NgaySinh,SoCMT,HinhThucHoc,TrangThai,MaHocVien,hv.GioiTinh,NgayDangKi, hv.NgayBatDau, hv.NgayKetThuc,Anh,TongSoLanInThe, TongSoLanInGiayChungNhan,TenBenhVien, TenTinhThanh, 
case when hv.HinhThucHoc = N'Theo lớp' then lh.TenLop else hv.TenLopHoc end as TenLopHoc, TenChuyenKhoaLopHoc, TenKhoaHoc, idBenhVienCongTac,HinhThucHoc,MaLopHoc from DT_View_LienTuc_HocVien hv
left join DT_LienTuc_LopHoc lh on lh.MaLop = hv.MaLopHoc 
Where (TongSoLanInThe <= 0 OR TongSoLanInThe is null)and (MaHocVien is not null or MaHocVien <> '') and (TrangThai = N'Chưa bắt đầu học' or TrangThai = N'Đang học')
				AND hv.[HinhThucHoc] like @LoaiHinhDaoTao
		AND YEAR(hv.NgayBatDau) = @NamHoc 
        order by NgayKetThuc desc
		END
		ELSE
		IF(LOWER(@LoaiHinhDaoTao) <> N'toàn bộ' AND @NamHoc = 0 AND @PhongQuanLy > 0)
		BEGIN
        select ID,HoTen,NgaySinh,SoCMT,HinhThucHoc,TrangThai,MaHocVien,hv.GioiTinh,NgayDangKi, hv.NgayBatDau, hv.NgayKetThuc,Anh,TongSoLanInThe, TongSoLanInGiayChungNhan,TenBenhVien, TenTinhThanh, 
case when hv.HinhThucHoc = N'Theo lớp' then lh.TenLop else hv.TenLopHoc end as TenLopHoc, TenChuyenKhoaLopHoc, TenKhoaHoc, idBenhVienCongTac,HinhThucHoc,MaLopHoc from DT_View_LienTuc_HocVien hv
left join DT_LienTuc_LopHoc lh on lh.MaLop = hv.MaLopHoc 
Where (TongSoLanInThe <= 0 OR TongSoLanInThe is null)and (MaHocVien is not null or MaHocVien <> '') and (TrangThai = N'Chưa bắt đầu học' or TrangThai = N'Đang học')
				AND hv.[HinhThucHoc] like @LoaiHinhDaoTao
		And hv.IdBoPhan = @PhongQuanLy
        order by NgayKetThuc desc
		END
		ELSE
		IF(LOWER(@LoaiHinhDaoTao) <> N'toàn bộ' AND @NamHoc > 0 AND @PhongQuanLy > 0)
		BEGIN
        select ID,HoTen,NgaySinh,SoCMT,HinhThucHoc,TrangThai,MaHocVien,hv.GioiTinh,NgayDangKi, hv.NgayBatDau, hv.NgayKetThuc,Anh,TongSoLanInThe, TongSoLanInGiayChungNhan,TenBenhVien, TenTinhThanh, 
case when hv.HinhThucHoc = N'Theo lớp' then lh.TenLop else hv.TenLopHoc end as TenLopHoc, TenChuyenKhoaLopHoc, TenKhoaHoc, idBenhVienCongTac,HinhThucHoc,MaLopHoc from DT_View_LienTuc_HocVien hv
left join DT_LienTuc_LopHoc lh on lh.MaLop = hv.MaLopHoc 
Where (TongSoLanInThe <= 0 OR TongSoLanInThe is null)and (MaHocVien is not null or MaHocVien <> '') and (TrangThai = N'Chưa bắt đầu học' or TrangThai = N'Đang học')
				AND hv.[HinhThucHoc] like @LoaiHinhDaoTao
				AND YEAR(hv.NgayBatDau) = @NamHoc 
		And hv.IdBoPhan = @PhongQuanLy
        order by NgayKetThuc desc
		END
    END
GO

USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[DIC_Tinh_Info_Add]    Script Date: 08/10/2019 10:58:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[DIC_TinhThanh_Add]
    @ID bigint output,
    @Ma varchar(10),
    @Ten nvarchar(100),
    @SuDung bit,
    @GhiChu nvarchar(100)
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.DIC_Tinh */
        INSERT INTO [dbo].[DIC_Tinh]
        (
            
            [Ma],
            [Ten],
			[TieuDe],
            [SuDung],
            [GhiChu]
        )
        VALUES
        (
            
            @Ma,
            @Ten,
			@Ten,
            @SuDung,
            @GhiChu
        )
		 SET @ID = SCOPE_IDENTITY()
    END

GO

USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[DIC_Tinh_Info_Upd]    Script Date: 08/10/2019 11:11:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DIC_TinhThanh_Upd]
    @ID bigint,
    @Ma varchar(10),
    @Ten nvarchar(100),
    @SuDung bit,
    @GhiChu nvarchar(100)
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_Tinh]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_TinhThanh_Coll'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.DIC_Tinh */
        UPDATE [dbo].[DIC_Tinh]
        SET
            [Ma] = @Ma,
            [Ten] = @Ten,
			[TieuDe] = @Ten,
            [SuDung] = @SuDung,
            [GhiChu] = @GhiChu
        WHERE
            [ID] = @ID

    END

GO

USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[DIC_Tinh_Coll_Get]    Script Date: 08/10/2019 2:40:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[DIC_Tinh_Coll_Get]
@ID bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DIC_Tinh_Info from table */
        SELECT
            [DIC_Tinh].[ID],
            [DIC_Tinh].[Ma],
            [DIC_Tinh].[MaDK],
            [DIC_Tinh].[TieuDe],
            [DIC_Tinh].[Ten],
            [DIC_Tinh].[IDRefer],
            [DIC_Tinh].[SuDung],
            [DIC_Tinh].[GhiChu]
        FROM [dbo].[DIC_Tinh]
		where ID = @ID
    END
GO

USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[DT_LienTuc_HocVien_Coll_get_ChuaInThe]    Script Date: 08/10/2019 5:00:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DT_LienTuc_HocVien_Coll_get_ChuaInThe]
@NamHoc int,
@PhongQuanLy int,
@LoaiHinhDaoTao nvarchar(MAX)
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DT_LienTuc_HocVien_Info from table */
		IF(LOWER(@LoaiHinhDaoTao) = N'toàn bộ' AND @NamHoc = 0 AND @PhongQuanLy = 0)
		BEGIN
        select ID,HoTen,NgaySinh,SoCMT,HinhThucHoc,MaLopHoc,TrangThai,DaDongHocPhi,idNguoiQuanLy,MaHocVien,hv.GioiTinh,idTrinhDo,idChuyenNganh,TruongTotNghiep, NamTotNghiep, SoBang,
			NoiCongTac,idTinhThanh, DiaChiCoQuan, DiaChiNhaRieng, DienThoaiCoQuan, DienThoaiNhaRieng,DiDong,Email, NgayCapCMT, NoiCapCMT, NgayDangKi, idChuyenNganhDangKi, NoiDungDaoTao, hv.NgayBatDau, hv.NgayKetThuc,Anh,hv.idKhungLopHoc,TongHocPhi,DiemThi, XepLoai,Lan1,Lan2, Lan3, Lan4, 
			DangKiTuCTT, idBenhVienCongTac, TongSoLanInThe, TongSoLanInGiayChungNhan, TongSoLanInBangTotNghiep, TongSoLanInHoaDon, GhiChu,hv.LastEdited_User, hv.LastEdited_Date, TongTienHoc, TongChiPhiKhac, Nhom, Lan5, HoaDonHocPhi, NgayDong, SoTienHoan, LyDoHoanTien, 
			IdBoPhan, NgayDongDetail, hv.backup01, hv.backup02, hv.backup03, hv.backup04, hv.backup05, SoTienDongDetail, hv.idLopHoc, TenBenhVien, TenTinhThanh, TenChuyenNganh, TenTrinhDo, TenBoPhan, case when hv.HinhThucHoc = N'Theo lớp' then lh.TenLop else hv.TenLopHoc end as TenLopHoc, 
			TenChuyenKhoaLopHoc, NgayBatDauLop, NgayKetThucLop, TenKhoaHoc, TenLastEdited_UserName, TenNguoiQuanLy, hv.TongSoTiet, MaSothue,hv.ThoiGianHoc  from DT_View_LienTuc_HocVien hv
			join DT_LienTuc_LopHoc lh on lh.MaLop = hv.MaLopHoc
			Where (TongSoLanInThe <= 0 OR TongSoLanInThe is null)and (MaHocVien is not null or MaHocVien <> '') and (TrangThai = N'Chưa bắt đầu học' or TrangThai = N'Đang học')
			order by NgayKetThuc desc
		END
		ELSE
		IF(LOWER(@LoaiHinhDaoTao) = N'toàn bộ' AND @NamHoc > 0 AND @PhongQuanLy = 0)
		BEGIN
        select ID,HoTen,NgaySinh,SoCMT,HinhThucHoc,MaLopHoc,TrangThai,DaDongHocPhi,idNguoiQuanLy,MaHocVien,hv.GioiTinh,idTrinhDo,idChuyenNganh,TruongTotNghiep, NamTotNghiep, SoBang,
NoiCongTac,idTinhThanh, DiaChiCoQuan, DiaChiNhaRieng, DienThoaiCoQuan, DienThoaiNhaRieng,DiDong,Email, NgayCapCMT, NoiCapCMT, NgayDangKi, idChuyenNganhDangKi, NoiDungDaoTao, hv.NgayBatDau, hv.NgayKetThuc,Anh,hv.idKhungLopHoc,TongHocPhi,DiemThi, XepLoai,Lan1,Lan2, Lan3, Lan4, 
DangKiTuCTT, idBenhVienCongTac, TongSoLanInThe, TongSoLanInGiayChungNhan, TongSoLanInBangTotNghiep, TongSoLanInHoaDon, GhiChu,hv.LastEdited_User, hv.LastEdited_Date, TongTienHoc, TongChiPhiKhac, Nhom, Lan5, HoaDonHocPhi, NgayDong, SoTienHoan, LyDoHoanTien, 
IdBoPhan, NgayDongDetail, hv.backup01, hv.backup02, hv.backup03, hv.backup04, hv.backup05, SoTienDongDetail, hv.idLopHoc, TenBenhVien, TenTinhThanh, TenChuyenNganh, TenTrinhDo, TenBoPhan, case when hv.HinhThucHoc = N'Theo lớp' then lh.TenLop else hv.TenLopHoc end as TenLopHoc, 
TenChuyenKhoaLopHoc, NgayBatDauLop, NgayKetThucLop, TenKhoaHoc, TenLastEdited_UserName, TenNguoiQuanLy, hv.TongSoTiet, MaSothue,hv.ThoiGianHoc  from DT_View_LienTuc_HocVien hv
join DT_LienTuc_LopHoc lh on lh.MaLop = hv.MaLopHoc
Where (TongSoLanInThe <= 0 OR TongSoLanInThe is null)and (MaHocVien is not null or MaHocVien <> '') and (TrangThai = N'Chưa bắt đầu học' or TrangThai = N'Đang học')
		AND YEAR(hv.NgayBatDau) = @NamHoc 
        order by NgayKetThuc desc
		END
		ELSE
		IF(LOWER(@LoaiHinhDaoTao) = N'toàn bộ' AND @NamHoc = 0 AND @PhongQuanLy > 0)
		BEGIN
        select ID,HoTen,NgaySinh,SoCMT,HinhThucHoc,MaLopHoc,TrangThai,DaDongHocPhi,idNguoiQuanLy,MaHocVien,hv.GioiTinh,idTrinhDo,idChuyenNganh,TruongTotNghiep, NamTotNghiep, SoBang,
NoiCongTac,idTinhThanh, DiaChiCoQuan, DiaChiNhaRieng, DienThoaiCoQuan, DienThoaiNhaRieng,DiDong,Email, NgayCapCMT, NoiCapCMT, NgayDangKi, idChuyenNganhDangKi, NoiDungDaoTao, hv.NgayBatDau, hv.NgayKetThuc,Anh,hv.idKhungLopHoc,TongHocPhi,DiemThi, XepLoai,Lan1,Lan2, Lan3, Lan4, 
DangKiTuCTT, idBenhVienCongTac, TongSoLanInThe, TongSoLanInGiayChungNhan, TongSoLanInBangTotNghiep, TongSoLanInHoaDon, GhiChu,hv.LastEdited_User, hv.LastEdited_Date, TongTienHoc, TongChiPhiKhac, Nhom, Lan5, HoaDonHocPhi, NgayDong, SoTienHoan, LyDoHoanTien, 
IdBoPhan, NgayDongDetail, hv.backup01, hv.backup02, hv.backup03, hv.backup04, hv.backup05, SoTienDongDetail, hv.idLopHoc, TenBenhVien, TenTinhThanh, TenChuyenNganh, TenTrinhDo, TenBoPhan, case when hv.HinhThucHoc = N'Theo lớp' then lh.TenLop else hv.TenLopHoc end as TenLopHoc, 
TenChuyenKhoaLopHoc, NgayBatDauLop, NgayKetThucLop, TenKhoaHoc, TenLastEdited_UserName, TenNguoiQuanLy, hv.TongSoTiet, MaSothue,hv.ThoiGianHoc  from DT_View_LienTuc_HocVien hv
join DT_LienTuc_LopHoc lh on lh.MaLop = hv.MaLopHoc
Where (TongSoLanInThe <= 0 OR TongSoLanInThe is null)and (MaHocVien is not null or MaHocVien <> '') and (TrangThai = N'Chưa bắt đầu học' or TrangThai = N'Đang học')
		And hv.IdBoPhan = @PhongQuanLy
        order by NgayKetThuc desc
		END
		ELSE
		IF(LOWER(@LoaiHinhDaoTao) = N'toàn bộ' AND @NamHoc > 0 AND @PhongQuanLy > 0)
		BEGIN
        select ID,HoTen,NgaySinh,SoCMT,HinhThucHoc,MaLopHoc,TrangThai,DaDongHocPhi,idNguoiQuanLy,MaHocVien,hv.GioiTinh,idTrinhDo,idChuyenNganh,TruongTotNghiep, NamTotNghiep, SoBang,
NoiCongTac,idTinhThanh, DiaChiCoQuan, DiaChiNhaRieng, DienThoaiCoQuan, DienThoaiNhaRieng,DiDong,Email, NgayCapCMT, NoiCapCMT, NgayDangKi, idChuyenNganhDangKi, NoiDungDaoTao, hv.NgayBatDau, hv.NgayKetThuc,Anh,hv.idKhungLopHoc,TongHocPhi,DiemThi, XepLoai,Lan1,Lan2, Lan3, Lan4, 
DangKiTuCTT, idBenhVienCongTac, TongSoLanInThe, TongSoLanInGiayChungNhan, TongSoLanInBangTotNghiep, TongSoLanInHoaDon, GhiChu,hv.LastEdited_User, hv.LastEdited_Date, TongTienHoc, TongChiPhiKhac, Nhom, Lan5, HoaDonHocPhi, NgayDong, SoTienHoan, LyDoHoanTien, 
IdBoPhan, NgayDongDetail, hv.backup01, hv.backup02, hv.backup03, hv.backup04, hv.backup05, SoTienDongDetail, hv.idLopHoc, TenBenhVien, TenTinhThanh, TenChuyenNganh, TenTrinhDo, TenBoPhan, case when hv.HinhThucHoc = N'Theo lớp' then lh.TenLop else hv.TenLopHoc end as TenLopHoc, 
TenChuyenKhoaLopHoc, NgayBatDauLop, NgayKetThucLop, TenKhoaHoc, TenLastEdited_UserName, TenNguoiQuanLy, hv.TongSoTiet, MaSothue,hv.ThoiGianHoc  from DT_View_LienTuc_HocVien hv
join DT_LienTuc_LopHoc lh on lh.MaLop = hv.MaLopHoc
Where (TongSoLanInThe <= 0 OR TongSoLanInThe is null)and (MaHocVien is not null or MaHocVien <> '') and (TrangThai = N'Chưa bắt đầu học' or TrangThai = N'Đang học')
				AND hv.[HinhThucHoc] like @LoaiHinhDaoTao
				AND YEAR(hv.NgayBatDau) = @NamHoc 
		And hv.IdBoPhan = @PhongQuanLy
        order by NgayKetThuc desc
		END
		ELSE
		IF(LOWER(@LoaiHinhDaoTao) <> N'toàn bộ' AND @NamHoc = 0 AND @PhongQuanLy = 0)
		BEGIN
        select ID,HoTen,NgaySinh,SoCMT,HinhThucHoc,MaLopHoc,TrangThai,DaDongHocPhi,idNguoiQuanLy,MaHocVien,hv.GioiTinh,idTrinhDo,idChuyenNganh,TruongTotNghiep, NamTotNghiep, SoBang,
NoiCongTac,idTinhThanh, DiaChiCoQuan, DiaChiNhaRieng, DienThoaiCoQuan, DienThoaiNhaRieng,DiDong,Email, NgayCapCMT, NoiCapCMT, NgayDangKi, idChuyenNganhDangKi, NoiDungDaoTao, hv.NgayBatDau, hv.NgayKetThuc,Anh,hv.idKhungLopHoc,TongHocPhi,DiemThi, XepLoai,Lan1,Lan2, Lan3, Lan4, 
DangKiTuCTT, idBenhVienCongTac, TongSoLanInThe, TongSoLanInGiayChungNhan, TongSoLanInBangTotNghiep, TongSoLanInHoaDon, GhiChu,hv.LastEdited_User, hv.LastEdited_Date, TongTienHoc, TongChiPhiKhac, Nhom, Lan5, HoaDonHocPhi, NgayDong, SoTienHoan, LyDoHoanTien, 
IdBoPhan, NgayDongDetail, hv.backup01, hv.backup02, hv.backup03, hv.backup04, hv.backup05, SoTienDongDetail, hv.idLopHoc, TenBenhVien, TenTinhThanh, TenChuyenNganh, TenTrinhDo, TenBoPhan, case when hv.HinhThucHoc = N'Theo lớp' then lh.TenLop else hv.TenLopHoc end as TenLopHoc, 
TenChuyenKhoaLopHoc, NgayBatDauLop, NgayKetThucLop, TenKhoaHoc, TenLastEdited_UserName, TenNguoiQuanLy, hv.TongSoTiet, MaSothue ,hv.ThoiGianHoc from DT_View_LienTuc_HocVien hv
join DT_LienTuc_LopHoc lh on lh.MaLop = hv.MaLopHoc
Where (TongSoLanInThe <= 0 OR TongSoLanInThe is null)and (MaHocVien is not null or MaHocVien <> '') and (TrangThai = N'Chưa bắt đầu học' or TrangThai = N'Đang học')
				AND hv.[HinhThucHoc] like @LoaiHinhDaoTao
        order by NgayKetThuc desc
		END
		ELSE
		IF(LOWER(@LoaiHinhDaoTao) <> N'toàn bộ' AND @NamHoc > 0 AND @PhongQuanLy = 0)
		BEGIN
        select ID,HoTen,NgaySinh,SoCMT,HinhThucHoc,MaLopHoc,TrangThai,DaDongHocPhi,idNguoiQuanLy,MaHocVien,hv.GioiTinh,idTrinhDo,idChuyenNganh,TruongTotNghiep, NamTotNghiep, SoBang,
NoiCongTac,idTinhThanh, DiaChiCoQuan, DiaChiNhaRieng, DienThoaiCoQuan, DienThoaiNhaRieng,DiDong,Email, NgayCapCMT, NoiCapCMT, NgayDangKi, idChuyenNganhDangKi, NoiDungDaoTao, hv.NgayBatDau, hv.NgayKetThuc,Anh,hv.idKhungLopHoc,TongHocPhi,DiemThi, XepLoai,Lan1,Lan2, Lan3, Lan4, 
DangKiTuCTT, idBenhVienCongTac, TongSoLanInThe, TongSoLanInGiayChungNhan, TongSoLanInBangTotNghiep, TongSoLanInHoaDon, GhiChu,hv.LastEdited_User, hv.LastEdited_Date, TongTienHoc, TongChiPhiKhac, Nhom, Lan5, HoaDonHocPhi, NgayDong, SoTienHoan, LyDoHoanTien, 
IdBoPhan, NgayDongDetail, hv.backup01, hv.backup02, hv.backup03, hv.backup04, hv.backup05, SoTienDongDetail, hv.idLopHoc, TenBenhVien, TenTinhThanh, TenChuyenNganh, TenTrinhDo, TenBoPhan, case when hv.HinhThucHoc = N'Theo lớp' then lh.TenLop else hv.TenLopHoc end as TenLopHoc, 
TenChuyenKhoaLopHoc, NgayBatDauLop, NgayKetThucLop, TenKhoaHoc, TenLastEdited_UserName, TenNguoiQuanLy, hv.TongSoTiet, MaSothue ,hv.ThoiGianHoc from DT_View_LienTuc_HocVien hv
join DT_LienTuc_LopHoc lh on lh.MaLop = hv.MaLopHoc
Where (TongSoLanInThe <= 0 OR TongSoLanInThe is null)and (MaHocVien is not null or MaHocVien <> '') and (TrangThai = N'Chưa bắt đầu học' or TrangThai = N'Đang học')
				AND hv.[HinhThucHoc] like @LoaiHinhDaoTao
		AND YEAR(hv.NgayBatDau) = @NamHoc 
        order by NgayKetThuc desc
		END
		ELSE
		IF(LOWER(@LoaiHinhDaoTao) <> N'toàn bộ' AND @NamHoc = 0 AND @PhongQuanLy > 0)
		BEGIN
        select ID,HoTen,NgaySinh,SoCMT,HinhThucHoc,MaLopHoc,TrangThai,DaDongHocPhi,idNguoiQuanLy,MaHocVien,hv.GioiTinh,idTrinhDo,idChuyenNganh,TruongTotNghiep, NamTotNghiep, SoBang,
NoiCongTac,idTinhThanh, DiaChiCoQuan, DiaChiNhaRieng, DienThoaiCoQuan, DienThoaiNhaRieng,DiDong,Email, NgayCapCMT, NoiCapCMT, NgayDangKi, idChuyenNganhDangKi, NoiDungDaoTao, hv.NgayBatDau, hv.NgayKetThuc,Anh,hv.idKhungLopHoc,TongHocPhi,DiemThi, XepLoai,Lan1,Lan2, Lan3, Lan4, 
DangKiTuCTT, idBenhVienCongTac, TongSoLanInThe, TongSoLanInGiayChungNhan, TongSoLanInBangTotNghiep, TongSoLanInHoaDon, GhiChu,hv.LastEdited_User, hv.LastEdited_Date, TongTienHoc, TongChiPhiKhac, Nhom, Lan5, HoaDonHocPhi, NgayDong, SoTienHoan, LyDoHoanTien, 
IdBoPhan, NgayDongDetail, hv.backup01, hv.backup02, hv.backup03, hv.backup04, hv.backup05, SoTienDongDetail, hv.idLopHoc, TenBenhVien, TenTinhThanh, TenChuyenNganh, TenTrinhDo, TenBoPhan, case when hv.HinhThucHoc = N'Theo lớp' then lh.TenLop else hv.TenLopHoc end as TenLopHoc, 
TenChuyenKhoaLopHoc, NgayBatDauLop, NgayKetThucLop, TenKhoaHoc, TenLastEdited_UserName, TenNguoiQuanLy, hv.TongSoTiet, MaSothue,hv.ThoiGianHoc  from DT_View_LienTuc_HocVien hv
join DT_LienTuc_LopHoc lh on lh.MaLop = hv.MaLopHoc
Where (TongSoLanInThe <= 0 OR TongSoLanInThe is null)and (MaHocVien is not null or MaHocVien <> '') and (TrangThai = N'Chưa bắt đầu học' or TrangThai = N'Đang học')
				AND hv.[HinhThucHoc] like @LoaiHinhDaoTao
		And hv.IdBoPhan = @PhongQuanLy
        order by NgayKetThuc desc
		END
		ELSE
		IF(LOWER(@LoaiHinhDaoTao) <> N'toàn bộ' AND @NamHoc > 0 AND @PhongQuanLy > 0)
		BEGIN
        select ID,HoTen,NgaySinh,SoCMT,HinhThucHoc,MaLopHoc,TrangThai,DaDongHocPhi,idNguoiQuanLy,MaHocVien,hv.GioiTinh,idTrinhDo,idChuyenNganh,TruongTotNghiep, NamTotNghiep, SoBang,
NoiCongTac,idTinhThanh, DiaChiCoQuan, DiaChiNhaRieng, DienThoaiCoQuan, DienThoaiNhaRieng,DiDong,Email, NgayCapCMT, NoiCapCMT, NgayDangKi, idChuyenNganhDangKi, NoiDungDaoTao, hv.NgayBatDau, hv.NgayKetThuc,Anh,hv.idKhungLopHoc,TongHocPhi,DiemThi, XepLoai,Lan1,Lan2, Lan3, Lan4, 
DangKiTuCTT, idBenhVienCongTac, TongSoLanInThe, TongSoLanInGiayChungNhan, TongSoLanInBangTotNghiep, TongSoLanInHoaDon, GhiChu,hv.LastEdited_User, hv.LastEdited_Date, TongTienHoc, TongChiPhiKhac, Nhom, Lan5, HoaDonHocPhi, NgayDong, SoTienHoan, LyDoHoanTien, 
IdBoPhan, NgayDongDetail, hv.backup01, hv.backup02, hv.backup03, hv.backup04, hv.backup05, SoTienDongDetail, hv.idLopHoc, TenBenhVien, TenTinhThanh, TenChuyenNganh, TenTrinhDo, TenBoPhan, case when hv.HinhThucHoc = N'Theo lớp' then lh.TenLop else hv.TenLopHoc end as TenLopHoc, 
TenChuyenKhoaLopHoc, NgayBatDauLop, NgayKetThucLop, TenKhoaHoc, TenLastEdited_UserName, TenNguoiQuanLy, hv.TongSoTiet, MaSothue,hv.ThoiGianHoc  from DT_View_LienTuc_HocVien hv
join DT_LienTuc_LopHoc lh on lh.MaLop = hv.MaLopHoc
Where (TongSoLanInThe <= 0 OR TongSoLanInThe is null)and (MaHocVien is not null or MaHocVien <> '') and (TrangThai = N'Chưa bắt đầu học' or TrangThai = N'Đang học')
				AND hv.[HinhThucHoc] like @LoaiHinhDaoTao
				AND YEAR(hv.NgayBatDau) = @NamHoc 
		And hv.IdBoPhan = @PhongQuanLy
        order by NgayKetThuc desc
		END
    END
GO

USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[DT_LienTuc_HocVien_Coll_get_DaInThe]    Script Date: 08/10/2019 5:05:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	ALTER PROCEDURE [dbo].[DT_LienTuc_HocVien_Coll_get_DaInThe]
@NamHoc int,
@PhongQuanLy int,
@LoaiHinhDaoTao nvarchar(MAX)
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DT_LienTuc_HocVien_Info from table */
		IF(LOWER(@LoaiHinhDaoTao) = N'toàn bộ' AND @NamHoc = 0 AND @PhongQuanLy = 0)
		BEGIN
        select ID,HoTen,NgaySinh,SoCMT,HinhThucHoc,MaLopHoc,TrangThai,DaDongHocPhi,idNguoiQuanLy,MaHocVien,hv.GioiTinh,idTrinhDo,idChuyenNganh,TruongTotNghiep, NamTotNghiep, SoBang,
			NoiCongTac,idTinhThanh, DiaChiCoQuan, DiaChiNhaRieng, DienThoaiCoQuan, DienThoaiNhaRieng,DiDong,Email, NgayCapCMT, NoiCapCMT, NgayDangKi, idChuyenNganhDangKi, NoiDungDaoTao, hv.NgayBatDau, hv.NgayKetThuc,Anh,hv.idKhungLopHoc,TongHocPhi,DiemThi, XepLoai,Lan1,Lan2, Lan3, Lan4, 
			DangKiTuCTT, idBenhVienCongTac, TongSoLanInThe, TongSoLanInGiayChungNhan, TongSoLanInBangTotNghiep, TongSoLanInHoaDon, GhiChu,hv.LastEdited_User, hv.LastEdited_Date, TongTienHoc, TongChiPhiKhac, Nhom, Lan5, HoaDonHocPhi, NgayDong, SoTienHoan, LyDoHoanTien, 
			IdBoPhan, NgayDongDetail, hv.backup01, hv.backup02, hv.backup03, hv.backup04, hv.backup05, SoTienDongDetail, hv.idLopHoc, TenBenhVien, TenTinhThanh, TenChuyenNganh, TenTrinhDo, TenBoPhan, case when hv.HinhThucHoc = N'Theo lớp' then lh.TenLop else hv.TenLopHoc end as TenLopHoc, 
			TenChuyenKhoaLopHoc, NgayBatDauLop, NgayKetThucLop, TenKhoaHoc, TenLastEdited_UserName, TenNguoiQuanLy, hv.TongSoTiet, MaSothue,hv.ThoiGianHoc  from DT_View_LienTuc_HocVien hv
			join DT_LienTuc_LopHoc lh on lh.MaLop = hv.MaLopHoc
		Where TongSoLanInThe > 0 
        order by NgayKetThuc desc
		END
		ELSE
		IF(LOWER(@LoaiHinhDaoTao) = N'toàn bộ' AND @NamHoc > 0 AND @PhongQuanLy = 0)
		BEGIN
        select ID,HoTen,NgaySinh,SoCMT,HinhThucHoc,MaLopHoc,TrangThai,DaDongHocPhi,idNguoiQuanLy,MaHocVien,hv.GioiTinh,idTrinhDo,idChuyenNganh,TruongTotNghiep, NamTotNghiep, SoBang,
			NoiCongTac,idTinhThanh, DiaChiCoQuan, DiaChiNhaRieng, DienThoaiCoQuan, DienThoaiNhaRieng,DiDong,Email, NgayCapCMT, NoiCapCMT, NgayDangKi, idChuyenNganhDangKi, NoiDungDaoTao, hv.NgayBatDau, hv.NgayKetThuc,Anh,hv.idKhungLopHoc,TongHocPhi,DiemThi, XepLoai,Lan1,Lan2, Lan3, Lan4, 
			DangKiTuCTT, idBenhVienCongTac, TongSoLanInThe, TongSoLanInGiayChungNhan, TongSoLanInBangTotNghiep, TongSoLanInHoaDon, GhiChu,hv.LastEdited_User, hv.LastEdited_Date, TongTienHoc, TongChiPhiKhac, Nhom, Lan5, HoaDonHocPhi, NgayDong, SoTienHoan, LyDoHoanTien, 
			IdBoPhan, NgayDongDetail, hv.backup01, hv.backup02, hv.backup03, hv.backup04, hv.backup05, SoTienDongDetail, hv.idLopHoc, TenBenhVien, TenTinhThanh, TenChuyenNganh, TenTrinhDo, TenBoPhan, case when hv.HinhThucHoc = N'Theo lớp' then lh.TenLop else hv.TenLopHoc end as TenLopHoc, 
			TenChuyenKhoaLopHoc, NgayBatDauLop, NgayKetThucLop, TenKhoaHoc, TenLastEdited_UserName, TenNguoiQuanLy, hv.TongSoTiet, MaSothue ,hv.ThoiGianHoc from DT_View_LienTuc_HocVien hv
			join DT_LienTuc_LopHoc lh on lh.MaLop = hv.MaLopHoc
		Where TongSoLanInThe > 0 
		AND YEAR(hv.NgayBatDau) = @NamHoc 
        order by NgayKetThuc desc
		END
		ELSE
		IF(LOWER(@LoaiHinhDaoTao) = N'toàn bộ' AND @NamHoc = 0 AND @PhongQuanLy > 0)
		BEGIN
        select ID,HoTen,NgaySinh,SoCMT,HinhThucHoc,MaLopHoc,TrangThai,DaDongHocPhi,idNguoiQuanLy,MaHocVien,hv.GioiTinh,idTrinhDo,idChuyenNganh,TruongTotNghiep, NamTotNghiep, SoBang,
			NoiCongTac,idTinhThanh, DiaChiCoQuan, DiaChiNhaRieng, DienThoaiCoQuan, DienThoaiNhaRieng,DiDong,Email, NgayCapCMT, NoiCapCMT, NgayDangKi, idChuyenNganhDangKi, NoiDungDaoTao, hv.NgayBatDau, hv.NgayKetThuc,Anh,hv.idKhungLopHoc,TongHocPhi,DiemThi, XepLoai,Lan1,Lan2, Lan3, Lan4, 
			DangKiTuCTT, idBenhVienCongTac, TongSoLanInThe, TongSoLanInGiayChungNhan, TongSoLanInBangTotNghiep, TongSoLanInHoaDon, GhiChu,hv.LastEdited_User, hv.LastEdited_Date, TongTienHoc, TongChiPhiKhac, Nhom, Lan5, HoaDonHocPhi, NgayDong, SoTienHoan, LyDoHoanTien, 
			IdBoPhan, NgayDongDetail, hv.backup01, hv.backup02, hv.backup03, hv.backup04, hv.backup05, SoTienDongDetail, hv.idLopHoc, TenBenhVien, TenTinhThanh, TenChuyenNganh, TenTrinhDo, TenBoPhan, case when hv.HinhThucHoc = N'Theo lớp' then lh.TenLop else hv.TenLopHoc end as TenLopHoc, 
			TenChuyenKhoaLopHoc, NgayBatDauLop, NgayKetThucLop, TenKhoaHoc, TenLastEdited_UserName, TenNguoiQuanLy, hv.TongSoTiet, MaSothue ,hv.ThoiGianHoc from DT_View_LienTuc_HocVien hv
			join DT_LienTuc_LopHoc lh on lh.MaLop = hv.MaLopHoc
		Where TongSoLanInThe > 0 
		And hv.IdBoPhan = @PhongQuanLy
        order by NgayKetThuc desc
		END
		ELSE
		IF(LOWER(@LoaiHinhDaoTao) = N'toàn bộ' AND @NamHoc > 0 AND @PhongQuanLy > 0)
		BEGIN
        select ID,HoTen,NgaySinh,SoCMT,HinhThucHoc,MaLopHoc,TrangThai,DaDongHocPhi,idNguoiQuanLy,MaHocVien,hv.GioiTinh,idTrinhDo,idChuyenNganh,TruongTotNghiep, NamTotNghiep, SoBang,
			NoiCongTac,idTinhThanh, DiaChiCoQuan, DiaChiNhaRieng, DienThoaiCoQuan, DienThoaiNhaRieng,DiDong,Email, NgayCapCMT, NoiCapCMT, NgayDangKi, idChuyenNganhDangKi, NoiDungDaoTao, hv.NgayBatDau, hv.NgayKetThuc,Anh,hv.idKhungLopHoc,TongHocPhi,DiemThi, XepLoai,Lan1,Lan2, Lan3, Lan4, 
			DangKiTuCTT, idBenhVienCongTac, TongSoLanInThe, TongSoLanInGiayChungNhan, TongSoLanInBangTotNghiep, TongSoLanInHoaDon, GhiChu,hv.LastEdited_User, hv.LastEdited_Date, TongTienHoc, TongChiPhiKhac, Nhom, Lan5, HoaDonHocPhi, NgayDong, SoTienHoan, LyDoHoanTien, 
			IdBoPhan, NgayDongDetail, hv.backup01, hv.backup02, hv.backup03, hv.backup04, hv.backup05, SoTienDongDetail, hv.idLopHoc, TenBenhVien, TenTinhThanh, TenChuyenNganh, TenTrinhDo, TenBoPhan, case when hv.HinhThucHoc = N'Theo lớp' then lh.TenLop else hv.TenLopHoc end as TenLopHoc, 
			TenChuyenKhoaLopHoc, NgayBatDauLop, NgayKetThucLop, TenKhoaHoc, TenLastEdited_UserName, TenNguoiQuanLy, hv.TongSoTiet, MaSothue ,hv.ThoiGianHoc from DT_View_LienTuc_HocVien hv
			join DT_LienTuc_LopHoc lh on lh.MaLop = hv.MaLopHoc
		Where TongSoLanInThe > 0 
				AND hv.[HinhThucHoc] like @LoaiHinhDaoTao
				AND YEAR(hv.NgayBatDau) = @NamHoc 
		And hv.IdBoPhan = @PhongQuanLy
        order by NgayKetThuc desc
		END
		ELSE
		IF(LOWER(@LoaiHinhDaoTao) <> N'toàn bộ' AND @NamHoc = 0 AND @PhongQuanLy = 0)
		BEGIN
        select ID,HoTen,NgaySinh,SoCMT,HinhThucHoc,MaLopHoc,TrangThai,DaDongHocPhi,idNguoiQuanLy,MaHocVien,hv.GioiTinh,idTrinhDo,idChuyenNganh,TruongTotNghiep, NamTotNghiep, SoBang,
			NoiCongTac,idTinhThanh, DiaChiCoQuan, DiaChiNhaRieng, DienThoaiCoQuan, DienThoaiNhaRieng,DiDong,Email, NgayCapCMT, NoiCapCMT, NgayDangKi, idChuyenNganhDangKi, NoiDungDaoTao, hv.NgayBatDau, hv.NgayKetThuc,Anh,hv.idKhungLopHoc,TongHocPhi,DiemThi, XepLoai,Lan1,Lan2, Lan3, Lan4, 
			DangKiTuCTT, idBenhVienCongTac, TongSoLanInThe, TongSoLanInGiayChungNhan, TongSoLanInBangTotNghiep, TongSoLanInHoaDon, GhiChu,hv.LastEdited_User, hv.LastEdited_Date, TongTienHoc, TongChiPhiKhac, Nhom, Lan5, HoaDonHocPhi, NgayDong, SoTienHoan, LyDoHoanTien, 
			IdBoPhan, NgayDongDetail, hv.backup01, hv.backup02, hv.backup03, hv.backup04, hv.backup05, SoTienDongDetail, hv.idLopHoc, TenBenhVien, TenTinhThanh, TenChuyenNganh, TenTrinhDo, TenBoPhan, case when hv.HinhThucHoc = N'Theo lớp' then lh.TenLop else hv.TenLopHoc end as TenLopHoc, 
			TenChuyenKhoaLopHoc, NgayBatDauLop, NgayKetThucLop, TenKhoaHoc, TenLastEdited_UserName, TenNguoiQuanLy, hv.TongSoTiet, MaSothue ,hv.ThoiGianHoc from DT_View_LienTuc_HocVien hv
			join DT_LienTuc_LopHoc lh on lh.MaLop = hv.MaLopHoc
		Where TongSoLanInThe > 0 
				AND hv.[HinhThucHoc] like @LoaiHinhDaoTao
        order by NgayKetThuc desc
		END
		ELSE
		IF(LOWER(@LoaiHinhDaoTao) <> N'toàn bộ' AND @NamHoc > 0 AND @PhongQuanLy = 0)
		BEGIN
        select ID,HoTen,NgaySinh,SoCMT,HinhThucHoc,MaLopHoc,TrangThai,DaDongHocPhi,idNguoiQuanLy,MaHocVien,hv.GioiTinh,idTrinhDo,idChuyenNganh,TruongTotNghiep, NamTotNghiep, SoBang,
			NoiCongTac,idTinhThanh, DiaChiCoQuan, DiaChiNhaRieng, DienThoaiCoQuan, DienThoaiNhaRieng,DiDong,Email, NgayCapCMT, NoiCapCMT, NgayDangKi, idChuyenNganhDangKi, NoiDungDaoTao, hv.NgayBatDau, hv.NgayKetThuc,Anh,hv.idKhungLopHoc,TongHocPhi,DiemThi, XepLoai,Lan1,Lan2, Lan3, Lan4, 
			DangKiTuCTT, idBenhVienCongTac, TongSoLanInThe, TongSoLanInGiayChungNhan, TongSoLanInBangTotNghiep, TongSoLanInHoaDon, GhiChu,hv.LastEdited_User, hv.LastEdited_Date, TongTienHoc, TongChiPhiKhac, Nhom, Lan5, HoaDonHocPhi, NgayDong, SoTienHoan, LyDoHoanTien, 
			IdBoPhan, NgayDongDetail, hv.backup01, hv.backup02, hv.backup03, hv.backup04, hv.backup05, SoTienDongDetail, hv.idLopHoc, TenBenhVien, TenTinhThanh, TenChuyenNganh, TenTrinhDo, TenBoPhan, case when hv.HinhThucHoc = N'Theo lớp' then lh.TenLop else hv.TenLopHoc end as TenLopHoc, 
			TenChuyenKhoaLopHoc, NgayBatDauLop, NgayKetThucLop, TenKhoaHoc, TenLastEdited_UserName, TenNguoiQuanLy, hv.TongSoTiet, MaSothue ,hv.ThoiGianHoc from DT_View_LienTuc_HocVien hv
			join DT_LienTuc_LopHoc lh on lh.MaLop = hv.MaLopHoc
		Where TongSoLanInThe > 0 
				AND hv.[HinhThucHoc] like @LoaiHinhDaoTao
		AND YEAR(hv.NgayBatDau) = @NamHoc 
        order by NgayKetThuc desc
		END
		ELSE
		IF(LOWER(@LoaiHinhDaoTao) <> N'toàn bộ' AND @NamHoc = 0 AND @PhongQuanLy > 0)
		BEGIN
        select ID,HoTen,NgaySinh,SoCMT,HinhThucHoc,MaLopHoc,TrangThai,DaDongHocPhi,idNguoiQuanLy,MaHocVien,hv.GioiTinh,idTrinhDo,idChuyenNganh,TruongTotNghiep, NamTotNghiep, SoBang,
			NoiCongTac,idTinhThanh, DiaChiCoQuan, DiaChiNhaRieng, DienThoaiCoQuan, DienThoaiNhaRieng,DiDong,Email, NgayCapCMT, NoiCapCMT, NgayDangKi, idChuyenNganhDangKi, NoiDungDaoTao, hv.NgayBatDau, hv.NgayKetThuc,Anh,hv.idKhungLopHoc,TongHocPhi,DiemThi, XepLoai,Lan1,Lan2, Lan3, Lan4, 
			DangKiTuCTT, idBenhVienCongTac, TongSoLanInThe, TongSoLanInGiayChungNhan, TongSoLanInBangTotNghiep, TongSoLanInHoaDon, GhiChu,hv.LastEdited_User, hv.LastEdited_Date, TongTienHoc, TongChiPhiKhac, Nhom, Lan5, HoaDonHocPhi, NgayDong, SoTienHoan, LyDoHoanTien, 
			IdBoPhan, NgayDongDetail, hv.backup01, hv.backup02, hv.backup03, hv.backup04, hv.backup05, SoTienDongDetail, hv.idLopHoc, TenBenhVien, TenTinhThanh, TenChuyenNganh, TenTrinhDo, TenBoPhan, case when hv.HinhThucHoc = N'Theo lớp' then lh.TenLop else hv.TenLopHoc end as TenLopHoc, 
			TenChuyenKhoaLopHoc, NgayBatDauLop, NgayKetThucLop, TenKhoaHoc, TenLastEdited_UserName, TenNguoiQuanLy, hv.TongSoTiet, MaSothue ,hv.ThoiGianHoc from DT_View_LienTuc_HocVien hv
			join DT_LienTuc_LopHoc lh on lh.MaLop = hv.MaLopHoc
		Where TongSoLanInThe > 0 
				AND hv.[HinhThucHoc] like @LoaiHinhDaoTao
		And hv.IdBoPhan = @PhongQuanLy
        order by NgayKetThuc desc
		END
		ELSE
		IF(LOWER(@LoaiHinhDaoTao) <> N'toàn bộ' AND @NamHoc > 0 AND @PhongQuanLy > 0)
		BEGIN
        select ID,HoTen,NgaySinh,SoCMT,HinhThucHoc,MaLopHoc,TrangThai,DaDongHocPhi,idNguoiQuanLy,MaHocVien,hv.GioiTinh,idTrinhDo,idChuyenNganh,TruongTotNghiep, NamTotNghiep, SoBang,
			NoiCongTac,idTinhThanh, DiaChiCoQuan, DiaChiNhaRieng, DienThoaiCoQuan, DienThoaiNhaRieng,DiDong,Email, NgayCapCMT, NoiCapCMT, NgayDangKi, idChuyenNganhDangKi, NoiDungDaoTao, hv.NgayBatDau, hv.NgayKetThuc,Anh,hv.idKhungLopHoc,TongHocPhi,DiemThi, XepLoai,Lan1,Lan2, Lan3, Lan4, 
			DangKiTuCTT, idBenhVienCongTac, TongSoLanInThe, TongSoLanInGiayChungNhan, TongSoLanInBangTotNghiep, TongSoLanInHoaDon, GhiChu,hv.LastEdited_User, hv.LastEdited_Date, TongTienHoc, TongChiPhiKhac, Nhom, Lan5, HoaDonHocPhi, NgayDong, SoTienHoan, LyDoHoanTien, 
			IdBoPhan, NgayDongDetail, hv.backup01, hv.backup02, hv.backup03, hv.backup04, hv.backup05, SoTienDongDetail, hv.idLopHoc, TenBenhVien, TenTinhThanh, TenChuyenNganh, TenTrinhDo, TenBoPhan, case when hv.HinhThucHoc = N'Theo lớp' then lh.TenLop else hv.TenLopHoc end as TenLopHoc, 
			TenChuyenKhoaLopHoc, NgayBatDauLop, NgayKetThucLop, TenKhoaHoc, TenLastEdited_UserName, TenNguoiQuanLy, hv.TongSoTiet, MaSothue ,hv.ThoiGianHoc from DT_View_LienTuc_HocVien hv
			join DT_LienTuc_LopHoc lh on lh.MaLop = hv.MaLopHoc
		Where TongSoLanInThe > 0 
				AND hv.[HinhThucHoc] like @LoaiHinhDaoTao
				AND YEAR(hv.NgayBatDau) = @NamHoc 
		And hv.IdBoPhan = @PhongQuanLy
        order by NgayKetThuc desc
		END
    END
GO









































