USE [MDCT1]
GO
/****** Object:  StoredProcedure [dbo].[BC_DanhSachLopHoc]    Script Date: 30/11/2018 09:15:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- createby :Thucnt
--createdate:01/11/2018

-- Báo cáo lấy ra danh sách lớp học
create proc [dbo].[BC_DanhSachLopHoc]
(@TuNgay datetime,
@DenNgay datetime
)
as
set nocount on
declare @strTuNgay varchar(10)
declare @strDenNgay varchar(10)
set @strTuNgay=CONVERT(varchar(10),@TuNgay,102)
set @strDenNgay=CONVERT(varchar(10),@DenNgay,102)
begin
 SELECT DISTINCT v.TenLop,count(hv.id)   as SoLuongHocVien,v.NguonKinhPhi2 as NguonKinhPhi,v.DoiTuong as DoiTuongHocVien,v.NgayBatDau,v.NgayKetThuc
                FROM    DT_View_LienTuc_LopHoc v

						left join DT_View_LienTuc_HocVien hv  on v.MaLop=hv.MaLopHoc
						where v.NgayBatDau between @strTuNgay and @strDenNgay
						group by v.TenLop,v.DoiTuong,v.NguonKinhPhi2,v.NgayBatDau,v.NgayKetThuc


end

go


-- báo cáo lấu ra số liệu hoạt động 
create proc [dbo].[BC_SoLieuHoatDongTELEMEDICINE]
as
begin
set nocount on
SELECT distinct hv.HinhThucHoc as LoaiHinh,lh.DoiTuong,nkp.Ten as NguonKinhPhi,
 substring(CONVERT(varchar(10),CONVERT(date,hc.NgayDienRa) ),9,2) Ngay,substring(CONVERT(varchar(10),CONVERT(date,hc.NgayDienRa) ),6,2) Thang,
 substring(CONVERT(varchar(10),CONVERT(date,hc.NgayDienRa) ),1,4) Nam,klh.TenLop as NoiDung,ck.Ten as ChuyenKhoaChuTri,''ChuyenKhoaPhoiHop,hc.sobenhvien as SoLuongBenhVien,bv.Ten as TenBenhVien,
hc.sothanhvien as SoLuongCanBoTaiBVBM ,'' SoLuongCanBoTaiTD,'' SuCo FROM DT_LienTuc_HocVien hv
left join DT_LienTuc_LopHoc lh on lh.MaLop=hv.MaLopHoc
left join DT_LienTuc_KhungLopHoc klh on klh.id=lh.idKhungLopHoc
left join DIC_ChuyenKhoa ck on ck.ID=klh.idChuyenKhoa
left join DIC_BenhVien bv on bv.ID=hv.idBenhVienCongTac
left join DIC_NguonKinhPhi nkp on nkp.ID=lh.IdNguonKinhPhi
left join CDT_HoiChuan hc on hc.idKhoaChuTri=ck.ID

end
	
	go
	

	-- báo cáo lấy ra số lượng học viên học thực hành theo khoa
	create proc [dbo].[BC_SoLuongHocVienHocThuHanhTheoKhoa]
(@TuNgay datetime,
@DenNgay datetime
)
as
begin
set nocount on
--declare @strTuNgay varchar(10)
--declare @strDenNgay varchar(10)
--set @strTuNgay=CONVERT(date,@strTuNgay)
--set @strDenNgay=CONVERT(date,@strDenNgay)


select ck.Ten as ChuyenKhoa,case datepart(dw,hv.NgayBatDau) when 1 then COUNT(ck.ID) end as ChuNhat ,
case datepart(dw,hv.NgayBatDau)when 2 then COUNT(ck.ID) end as ThuHai,
case datepart(dw,hv.NgayBatDau)when 3 then COUNT(ck.ID) end as ThuBa,
case datepart(dw,hv.NgayBatDau)when 4 then COUNT(ck.ID) end as ThuTu,
case datepart(dw,hv.NgayBatDau)when 5 then COUNT(ck.ID) end as ThuNam,
case datepart(dw,hv.NgayBatDau)when 6 then COUNT(ck.ID) end as ThuSau,
case datepart(dw,hv.NgayBatDau)when 7 then COUNT(ck.ID) end as ThuBay  from DT_LienTuc_HocVien hv
left join DT_LienTuc_KhungLopHoc klh on klh.id=hv.idKhungLopHoc
left join DIC_ChuyenKhoa ck on ck.ID=klh.idChuyenKhoa
where HinhThucHoc=N'Thực hành' and hv.NgayBatDau between  @TuNgay  and  @DenNgay
group by ck.ID,ck.Ten,hv.NgayBatDau
 end
	
	go


	-- báo cáo lấy ra số lượng học viên học thực hành theo tên
	create proc [dbo].[BC_SoLuongHocVienHocThuHanhTheoTen]
(@TuNgay datetime,
@DenNgay datetime
)
as
begin
set nocount on
--declare @strTuNgay varchar(10)
--declare @strDenNgay varchar(10)
--set @strTuNgay=CONVERT(date,@strTuNgay)
--set @strDenNgay=CONVERT(date,@strDenNgay)


select distinct hv.HoTen as TenHocVien ,case datepart(dw,hv.NgayBatDau) when 1 then COUNT(ck.ID) end as ChuNhat ,
case datepart(dw,hv.NgayBatDau)when 2 then COUNT(ck.ID) end as ThuHai,
case datepart(dw,hv.NgayBatDau)when 3 then COUNT(ck.ID) end as ThuBa,
case datepart(dw,hv.NgayBatDau)when 4 then COUNT(ck.ID) end as ThuTu,
case datepart(dw,hv.NgayBatDau)when 5 then COUNT(ck.ID) end as ThuNam,
case datepart(dw,hv.NgayBatDau)when 6 then COUNT(ck.ID) end as ThuSau,
case datepart(dw,hv.NgayBatDau)when 7 then COUNT(ck.ID) end as ThuBay  from DT_LienTuc_HocVien hv
left join DT_LienTuc_KhungLopHoc klh on klh.id=hv.idKhungLopHoc
left join DIC_ChuyenKhoa ck on ck.ID=klh.idChuyenKhoa
where HinhThucHoc=N'Thực hành' and hv.NgayBatDau between  @TuNgay  and  @DenNgay
group by ck.ID,ck.Ten,hv.NgayBatDau,hv.HoTen
 end

 go



 -- báo cáo lấy ra số lượng học viên học thực hành theo trường
 create proc [dbo].[BC_SoLuongHocVienHocThuHanhTheoTruong]
(@TuNgay datetime,
@DenNgay datetime
)
as
begin
set nocount on
--declare @strTuNgay varchar(10)
--declare @strDenNgay varchar(10)
--set @strTuNgay=CONVERT(date,@strTuNgay)
--set @strDenNgay=CONVERT(date,@strDenNgay)


select distinct hv.TruongTotNghiep as TenTruong,case datepart(dw,hv.NgayBatDau) when 1 then COUNT(ck.ID) end as ChuNhat ,
case datepart(dw,hv.NgayBatDau)when 2 then COUNT(ck.ID) end as ThuHai,
case datepart(dw,hv.NgayBatDau)when 3 then COUNT(ck.ID) end as ThuBa,
case datepart(dw,hv.NgayBatDau)when 4 then COUNT(ck.ID) end as ThuTu,
case datepart(dw,hv.NgayBatDau)when 5 then COUNT(ck.ID) end as ThuNam,
case datepart(dw,hv.NgayBatDau)when 6 then COUNT(ck.ID) end as ThuSau,
case datepart(dw,hv.NgayBatDau)when 7 then COUNT(ck.ID) end as ThuBay  from DT_LienTuc_HocVien hv
left join DT_LienTuc_KhungLopHoc klh on klh.id=hv.idKhungLopHoc
left join DIC_ChuyenKhoa ck on ck.ID=klh.idChuyenKhoa
where HinhThucHoc=N'Thực hành' and hv.NgayBatDau between  @TuNgay  and  @DenNgay
group by ck.ID,ck.Ten,hv.NgayBatDau,hv.TruongTotNghiep
 end

 go


 -- thêm loại hình đào tạo thực hành vào thủ tục DT_LienTuc_HocVien_add

 ALTER PROCEDURE [dbo].[DT_LienTuc_HocVien_add]
    @id int OUTPUT,
    @HoTen nvarchar(150),
    @NgaySinh datetime,
    @SoCMT nvarchar(20),
    @HinhThucHoc nvarchar(20),
    @MaLopHoc nvarchar(50),
    @TrangThai nvarchar(50),
    @DaDongHocPhi bit,
    @idNguoiQuanLy bigint,
    @MaHocVien nvarchar(50),
    @GioiTinh nvarchar(50),
    @idTrinhDo int,
    @idChuyenNganh int,
    @TruongTotNghiep nvarchar(150),
    @NamTotNghiep int,
    @SoBang nvarchar(50),
    @NoiCongTac nvarchar(150),
    @idTinhThanh bigint,
    @DiaChiCoQuan nvarchar(250),
    @DiaChiNhaRieng nvarchar(250),
    @DienThoaiCoQuan nvarchar(50),
    @DienThoaiNhaRieng nvarchar(50),
    @DiDong nvarchar(50),
    @Email nvarchar(50),
    @NgayCapCMT datetime,
    @NoiCapCMT nvarchar(50),
    @NgayDangKi datetime,
    @idChuyenNganhDangKi int,
    @NoiDungDaoTao nvarchar(500),
    @NgayBatDau datetime,
    @NgayKetThuc datetime,
    @Anh nvarchar(300),
    @idKhungLopHoc int,
    @TongHocPhi nvarchar(50),
    @DiemThi float,
    @XepLoai nvarchar(50),
    @Lan1 float,
    @Lan2 float,
    @Lan3 float,
    @Lan4 float,
    @DangKiTuCTT bit,
    @idBenhVienCongTac bigint,
    @TongSoLanInThe int,
    @TongSoLanInGiayChungNhan int,
    @TongSoLanInBangTotNghiep int,
    @TongSoLanInHoaDon int,
    @GhiChu nvarchar(MAX),
    @LastEdited_User bigint,
    @LastEdited_Date datetime,
    @TongTienHoc nvarchar(MAX),
    @TongChiPhiKhac nvarchar(MAX),
    @Nhom int,
    @Lan5 float,
    @HoaDonHocPhi nvarchar(MAX),
    @NgayDong datetime,
    @SoTienHoan nvarchar(MAX),
    @LyDoHoanTien nvarchar(MAX),
    @IdBoPhan int,
    @NgayDongDetail nvarchar(MAX),
    @backup01 nvarchar(MAX),
    @backup02 nvarchar(MAX),
    @backup03 nvarchar(MAX),
    @backup04 datetime,
    @backup05 int,
    @SoTienDongDetail nvarchar(MAX),
    @idLopHoc int,
	@MaSoThue varchar(30),
	@IDTinh int,
	@IDHuyen int,
	@IDXa int 
	--@SoTienDongMoiDot nvarchar(50)
AS
    BEGIN

        SET NOCOUNT ON
		declare @strNgayDangKy varchar(10)
		set @strNgayDangKy=CONVERT(varchar(10),@NgayDangKi,102)
		if @MaHocVien is not null and @HinhThucHoc = N'Kèm cặp'	or (@MaHocVien <> '' and @HinhThucHoc = N'Kèm cặp')
		set @MaHocVien = dbo.fn_taoMaHocVien(@MaHocVien,@strNgayDangKy)
		if @MaHocVien is not null and @HinhThucHoc=N'Thực hành' or(@MaHocVien<>'' and @HinhThucHoc=N'Thực hành')
		set @MaHocVien=dbo.fn_taoMaHocVien_ThucHanh(@MaHocVien,@strNgayDangKy)
        /* Insert object into dbo.DT_LienTuc_HocVien */
        INSERT INTO [dbo].[DT_LienTuc_HocVien]
        (
            [HoTen],
            [NgaySinh],
            [SoCMT],
            [HinhThucHoc],
            [MaLopHoc],
            [TrangThai],
            [DaDongHocPhi],
            [idNguoiQuanLy],
            [MaHocVien],
            [GioiTinh],
            [idTrinhDo],
            [idChuyenNganh],
            [TruongTotNghiep],
            [NamTotNghiep],
            [SoBang],
            [NoiCongTac],
            [idTinhThanh],
            [DiaChiCoQuan],
            [DiaChiNhaRieng],
            [DienThoaiCoQuan],
            [DienThoaiNhaRieng],
            [DiDong],
            [Email],
            [NgayCapCMT],
            [NoiCapCMT],
            [NgayDangKi],
            [idChuyenNganhDangKi],
            [NoiDungDaoTao],
            [NgayBatDau],
            [NgayKetThuc],
            [Anh],
            [idKhungLopHoc],
            [TongHocPhi],
            [DiemThi],
            [XepLoai],
            [Lan1],
            [Lan2],
            [Lan3],
            [Lan4],
            [DangKiTuCTT],
            [idBenhVienCongTac],
            [TongSoLanInThe],
            [TongSoLanInGiayChungNhan],
            [TongSoLanInBangTotNghiep],
            [TongSoLanInHoaDon],
            [GhiChu],
            [LastEdited_User],
            [LastEdited_Date],
            [TongTienHoc],
            [TongChiPhiKhac],
            [Nhom],
            [Lan5],
            [HoaDonHocPhi],
            [NgayDong],
            [SoTienHoan],
            [LyDoHoanTien],
            [IdBoPhan],
            [NgayDongDetail],
            [backup01],
            [backup02],
            [backup03],
            [backup04],
            [backup05],
            [SoTienDongDetail],
            [idLopHoc],
			[MaSoThue]
			
		--	SoTienDongMoiDot
        )
        VALUES
        (
            @HoTen,
            @NgaySinh,
            @SoCMT,
            @HinhThucHoc,
            @MaLopHoc,
            @TrangThai,
            @DaDongHocPhi,
            @idNguoiQuanLy,
            @MaHocVien,
            @GioiTinh,
            @idTrinhDo,
            @idChuyenNganh,
            @TruongTotNghiep,
            @NamTotNghiep,
            @SoBang,
            @NoiCongTac,
            @idTinhThanh,
            @DiaChiCoQuan,
            @DiaChiNhaRieng,
            @DienThoaiCoQuan,
            @DienThoaiNhaRieng,
            @DiDong,
            @Email,
            @NgayCapCMT,
            @NoiCapCMT,
            @NgayDangKi,
            @idChuyenNganhDangKi,
            @NoiDungDaoTao,
            @NgayBatDau,
            @NgayKetThuc,
            @Anh,
            @idKhungLopHoc,
         replace(@TongHocPhi,',',''),
            @DiemThi,
            @XepLoai,
            @Lan1,
            @Lan2,
            @Lan3,
            @Lan4,
            @DangKiTuCTT,
            @idBenhVienCongTac,
            @TongSoLanInThe,
            @TongSoLanInGiayChungNhan,
            @TongSoLanInBangTotNghiep,
            @TongSoLanInHoaDon,
            @GhiChu,
            @LastEdited_User,
            @LastEdited_Date,
            @TongTienHoc,
            @TongChiPhiKhac,
            @Nhom,
            @Lan5,
            @HoaDonHocPhi,
            @NgayDong,
            @SoTienHoan,
            @LyDoHoanTien,
            @IdBoPhan,
            @NgayDongDetail,
            @backup01,
            @backup02,
            @backup03,
            @backup04,
            @backup05,
            @SoTienDongDetail,
            @idLopHoc,
			@MaSoThue
			--@SoTienDongMoiDot
        )

        /* Return new primary key */
        SET @id = SCOPE_IDENTITY()

    END


	go

	  -- thêm loại hình đào tạo thực hành vào thủ tục DT_LienTuc_HocVien_update


	  ALTER PROCEDURE [dbo].[DT_LienTuc_HocVien_update]
    @id int,
    @HoTen nvarchar(150),
    @NgaySinh datetime,
    @SoCMT nvarchar(20),
    @HinhThucHoc nvarchar(20),
    @MaLopHoc nvarchar(50),
    @TrangThai nvarchar(50),
    @DaDongHocPhi bit,
    @idNguoiQuanLy bigint,
    @MaHocVien nvarchar(50),
    @GioiTinh nvarchar(50),
    @idTrinhDo int,
    @idChuyenNganh int,
    @TruongTotNghiep nvarchar(150),
    @NamTotNghiep int,
    @SoBang nvarchar(50),
    @NoiCongTac nvarchar(150),
    @idTinhThanh bigint,
    @DiaChiCoQuan nvarchar(250),
    @DiaChiNhaRieng nvarchar(250),
    @DienThoaiCoQuan nvarchar(50),
    @DienThoaiNhaRieng nvarchar(50),
    @DiDong nvarchar(50),
    @Email nvarchar(50),
    @NgayCapCMT datetime,
    @NoiCapCMT nvarchar(50),
    @NgayDangKi datetime,
    @idChuyenNganhDangKi int,
    @NoiDungDaoTao nvarchar(500),
    @NgayBatDau datetime,
    @NgayKetThuc datetime,
    @Anh nvarchar(300),
    @idKhungLopHoc int,
    @TongHocPhi nvarchar(50),
    @DiemThi float,
    @XepLoai nvarchar(50),
    @Lan1 float,
    @Lan2 float,
    @Lan3 float,
    @Lan4 float,
    @DangKiTuCTT bit,
    @idBenhVienCongTac bigint,
    @TongSoLanInThe int,
    @TongSoLanInGiayChungNhan int,
    @TongSoLanInBangTotNghiep int,
    @TongSoLanInHoaDon int,
    @GhiChu nvarchar(MAX),
    @LastEdited_User bigint,
    @LastEdited_Date datetime,
    @TongTienHoc nvarchar(MAX),
    @TongChiPhiKhac nvarchar(MAX),
    @Nhom int,
    @Lan5 float,
    @HoaDonHocPhi nvarchar(MAX),
    @NgayDong datetime,
    @SoTienHoan nvarchar(MAX),
    @LyDoHoanTien nvarchar(MAX),
    @IdBoPhan int,
    @NgayDongDetail nvarchar(MAX),
    @backup01 nvarchar(MAX),
    @backup02 nvarchar(MAX),
    @backup03 nvarchar(MAX),
    @backup04 datetime,
    @backup05 int,
    @SoTienDongDetail nvarchar(MAX),
    @idLopHoc int,
	@MaSoThue varchar(30)
	--@SoTienDongMoiDot nvarchar(50)
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
		
		declare @TThai nvarchar(50)
	    declare @Mahv varchar(17)
		declare @strNgayDangKi varchar(10)
		set @strNgayDangKi=CONVERT(nvarchar(10),@NgayDangKi,102)
		set @Mahv = (select isnull(MaHocVien,'') from DT_LienTuc_HocVien where ID = @Id and @HinhThucHoc = N'Kèm cặp' and TrangThai = N'Chưa bắt đầu học' )
		set @TThai = (select TrangThai from DT_LienTuc_HocVien where ID = @Id )	
		--set @MaHocVien=(select MaHocVien=@MaHocVien from DT_View_LienTuc_HocVien where @MaHocVien='' and TrangThai=N'Bảo Lưu' and TrangThai=N'Đình Chỉ')	
		if @Mahv is  null and @TThai = N'Chưa bắt đầu học' or( @MaHv = '' and @TThai = N'Chưa bắt đầu học')				
		set @MaHocVien=(select dbo.fn_taoMaHocVien(@MaHocVien,@strNgayDangKi) where @TrangThai=N'Đang học' and @HinhThucHoc=N'Kèm cặp')
		if(@Mahv is null and @TThai=N'Chưa bắt đầu học' or(@Mahv='' and @TThai=N'Chưa bắt đầu học'))
		set @MaHocVien=(select dbo.fn_taoMaHocVien_ThucHanh(@MaHocVien,@strNgayDangKi) where @TrangThai=N'Đang học' and @HinhThucHoc=N'Thực hành')
		
		
        IF NOT EXISTS
        (
            SELECT [id] FROM [dbo].[DT_LienTuc_HocVien]
            WHERE
                [id] = @id
        )

        BEGIN
            RAISERROR ('''dbo.DT_LienTuc_HocVien'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END
		--if @Mahv is null and @TThai = N'Chưa bắt đầu học' or( @MaHv = '' and @TThai = N'Chưa bắt đầu học')		
		--set @MaHocVien=NULL
		
        /* Update object in dbo.DT_LienTuc_HocVien */
        UPDATE [dbo].[DT_LienTuc_HocVien]
        SET
            [HoTen] = @HoTen,
            [NgaySinh] = @NgaySinh,
            [SoCMT] = @SoCMT,
            [HinhThucHoc] = @HinhThucHoc,
            [MaLopHoc] = @MaLopHoc,
            [TrangThai] = @TrangThai,
            [DaDongHocPhi] = @DaDongHocPhi,
            [idNguoiQuanLy] = @idNguoiQuanLy,
            [MaHocVien] = @MaHocVien,
            [GioiTinh] = @GioiTinh,
            [idTrinhDo] = @idTrinhDo,
            [idChuyenNganh] = @idChuyenNganh,
            [TruongTotNghiep] = @TruongTotNghiep,
            [NamTotNghiep] = @NamTotNghiep,
            [SoBang] = @SoBang,
            [NoiCongTac] = @NoiCongTac,
            [idTinhThanh] = @idTinhThanh,
            [DiaChiCoQuan] = @DiaChiCoQuan,
            [DiaChiNhaRieng] = @DiaChiNhaRieng,
            [DienThoaiCoQuan] = @DienThoaiCoQuan,
            [DienThoaiNhaRieng] = @DienThoaiNhaRieng,
            [DiDong] = @DiDong,
            [Email] = @Email,
            [NgayCapCMT] = @NgayCapCMT,
            [NoiCapCMT] = @NoiCapCMT,
            [NgayDangKi] = @NgayDangKi,
            [idChuyenNganhDangKi] = @idChuyenNganhDangKi,
            [NoiDungDaoTao] = @NoiDungDaoTao,
            [NgayBatDau] = @NgayBatDau,
            [NgayKetThuc] = @NgayKetThuc,
            [Anh] = @Anh,
            [idKhungLopHoc] = @idKhungLopHoc,
            [TongHocPhi] = @TongHocPhi,
            [DiemThi] = @DiemThi,
            [XepLoai] = @XepLoai,
            [Lan1] = @Lan1,
            [Lan2] = @Lan2,
            [Lan3] = @Lan3,
            [Lan4] = @Lan4,
            [DangKiTuCTT] = @DangKiTuCTT,
            [idBenhVienCongTac] = @idBenhVienCongTac,
            [TongSoLanInThe] = @TongSoLanInThe,
            [TongSoLanInGiayChungNhan] = @TongSoLanInGiayChungNhan,
            [TongSoLanInBangTotNghiep] = @TongSoLanInBangTotNghiep,
            [TongSoLanInHoaDon] = @TongSoLanInHoaDon,
            [GhiChu] = @GhiChu,
            [LastEdited_User] = @LastEdited_User,
            [LastEdited_Date] = @LastEdited_Date,
            [TongTienHoc] = @TongTienHoc,
            [TongChiPhiKhac] = @TongChiPhiKhac,
            [Nhom] = @Nhom,
            [Lan5] = @Lan5,
            [HoaDonHocPhi] = @HoaDonHocPhi,
            [NgayDong] = @NgayDong,
            [SoTienHoan] = @SoTienHoan,
            [LyDoHoanTien] = @LyDoHoanTien,
            [IdBoPhan] = @IdBoPhan,
            [NgayDongDetail] = @NgayDongDetail,
            [backup01] = @backup01,
            [backup02] = @backup02,
            [backup03] = @backup03,
            [backup04] = @backup04,
            [backup05] = @backup05,
            [SoTienDongDetail] = @SoTienDongDetail,
            [idLopHoc] = @idLopHoc,
			[MaSoThue] = @MaSoThue
			--SoTienDongMoiDot=@SoTienDongMoiDot
        WHERE
            [id] = @id

    END

-- tạo function lấy ra mã học viên thực hành có dạng 0001-TH-BM-18-B24

create FUNCTION [dbo].[fn_taoMaHocVien_ThucHanh]( @MaHocVien varchar(17),@year varchar(10))  
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
	--select @dem=isnull(max(Convert(bigint,SubString(MaHocVien,1,4))),0)+1 from DT_LienTuc_HocVien where   substring(MaHocVien,5,13)=N'-KC-BM-'+ substring(@MaHocVien,12,2) + N'-B24'
	select @dem=isnull(max(Convert(bigint,SubString(MaHocVien,1,4))),0)+1 from DT_LienTuc_HocVien where   substring(MaHocVien,5,13)=N'-TH-BM-'+ substring(CONVERT(varchar(4),@year),3,2) + N'-B24'
	select @tmSoBLT=case len(@dem)
		when 1 then	'000'
		when 2 then 	'00'
		when 3 then 	'0'
		when 4 then 	''
		--when 5 then       ''
		end  
	set @tmSoBLT= @tmSoBLT +convert(varchar,@dem )+ '-TH-BM-'+ substring(CONVERT(varchar(4),@year),3,2) + '-B24'
	return @tmSoBLT
END