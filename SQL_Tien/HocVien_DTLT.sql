USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[BC_HocVienDongHocPhi_DTLT]    Script Date: 05/01/2018 09:49:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[BC_HocVienDongHocPhi_DTLT]
(
	@TuNgay DATETIME,
	@DenNgay DATETIME,
	@KieuBaoCao INT,
	@IDKhungLopHoc INT
)
AS
BEGIN
	DECLARE @sql NVARCHAR(4000)
	DECLARE @sqlWhere NVARCHAR(2000)
	DECLARE @strTuNgay varchar(10)
	DECLARE @strDenNgay varchar(19)
	DECLARE @HinhThucHoc NVARCHAR(50)
	IF(@KieuBaoCao = 2)
		SET @HinhThucHoc = N'Kèm cặp'
	ELSE
		SET @HinhThucHoc = N'Theo lớp'
	SET @strTuNgay = Convert(varchar(10),@TuNgay,101)
	SET @strDenNgay = Convert(varchar(10),@DenNgay,101)+ ' 23:59:00.000'
	SET @sql = 'SELECT t1.MaHocVien,t1.HoTen,t1.NgaySinh,t1.TenHocVi as TrinhDo,
				t1.NoiDungDaoTao,t1.ChuyenKhoa,NgayBatDau = Convert(varchar(10),t1.NgayBatDau,103) +''-''+Convert(varchar(10),t1.NgayKetThuc,103),
				TienDaDong,t1.NoiCongTac 
				FROM (SELECT hv.HinhThucHoc,hv.MaHocVien,hv.HoTen, hv.NgaySinh,hv.NgayBatDau, hv.NgayKetThuc,hv.NoiDungDaoTao,
				TienPhaiDong = hv.TongHocPhi,hv.NoiCongTac,
				td.TenHocVi,k.Ten AS ChuyenKhoa,hv.id,t2.TienDaDong
				FROM dbo.DT_LienTuc_HocVien hv
				left JOIN dbo.DIC_HocVi td ON hv.idTrinhDo = td.ID
				left JOIN dbo.DIC_ChuyenNganh cn ON hv.idChuyenNganhDangKi = cn.ID
				left JOIN dbo.DIC_ChuyenKhoa k ON cn.ID_ChuyenKhoa = k.ID
				JOIN (SELECT TienDaDong = SUM(a.soTien),a.IDHocVien,a.NgayThu FROM 
				(SELECT soTien,IDHocVien,NgayThu FROM dbo.BienLai WHERE Huy = 0)a group by IDHocVien,NgayThu) t2 ON hv.id = t2.IDHocVien '
	-- trường hợp lấy tất cả học viên
	IF @KieuBaoCao = 1
		SET @sqlWhere = 'where (t2.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+'''))t1';
	
	-- trường hợp lấy học viên kèm cặp
	IF @KieuBaoCao = 2
		SET @sqlWhere = 'where (t2.NgayThu between '''+@strTuNgay+'''and '''+@strDenNgay+''') and hv.HinhThucHoc like N''%'+@HinhThucHoc+'%'')t1';
	
	-- trường hợp lấy theo lớp
	IF @KieuBaoCao = 3
		BEGIN
		SET @sqlWhere='where (t2.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''') and hv.idKhungLopHoc = '+CONVERT(NVARCHAR(10),@IDKhungLopHoc)+' and hv.HinhThucHoc like N''%'+@HinhThucHoc+'%'')t1';
		END 
	SET @sql = @sql + @sqlWhere;
	EXEC(@sql)
	PRINT(@sql)
END
