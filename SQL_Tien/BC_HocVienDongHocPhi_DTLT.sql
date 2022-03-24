-- create proc BC_HocVienDongHocPhi_DTLT
USE MDCT
GO


CREATE PROC BC_HocVienDongHocPhi_DTLT
(
	@TuNgay DATETIME,
	@DenNgay DATETIME,
	@KieuBaoCao INT
)
AS
BEGIN
	DECLARE @sql VARCHAR(8000)
	DECLARE @sqlWhere VARCHAR(2000)
	DECLARE @strTuNgay varchar(10)
	DECLARE @strDenNgay varchar(19)
	SET @strTuNgay = Convert(varchar(10),@TuNgay,101)
	SET @strDenNgay = Convert(varchar(10),@DenNgay,101)+ ' 23:59:00.000'
	SET @sql = 'SELECT t1.MaHocVien,t1.HoTen,t1.NgaySinh,t1.TenHocVi as TrinhDo,
				t1.NoiDungDaoTao,t1.ChuyenKhoa,t1.NgayBatDau,t1.NgayKetThuc,
				t2.TienDaDong,t1.TienPhaiDong,t1.NoiCongTac 
				FROM (SELECT hv.MaLopHoc,hv.MaHocVien,hv.HoTen, hv.NgaySinh,hv.NgayBatDau, hv.NgayKetThuc,hv.NoiDungDaoTao,
				TienPhaiDong = hv.TongHocPhi,hv.NoiCongTac,
				td.TenHocVi,k.Ten AS ChuyenKhoa,hv.id
				FROM dbo.DT_LienTuc_HocVien hv
				JOIN dbo.DIC_HocVi td ON hv.idTrinhDo = td.ID
				JOIN dbo.DIC_ChuyenNganh cn ON hv.idChuyenNganhDangKi = cn.ID
				JOIN dbo.DIC_ChuyenKhoa k ON cn.ID_ChuyenKhoa = k.ID) t1
				JOIN (SELECT TienDaDong = SUM(a.soTien),a.IDHocVien,a.NgayThu FROM 
				(SELECT soTien,IDHocVien,NgayThu FROM dbo.BienLai WHERE Huy = 0)a group by IDHocVien,NgayThu) t2 ON t1.id = t2.IDHocVien '
	-- trường hợp lấy tất cả học viên
	IF @KieuBaoCao = 1
		SET @sqlWhere = 'where (t2.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''')';
	
	-- trường hợp lấy học viên kèm cặp
	IF @KieuBaoCao = 2
		SET @sqlWhere = 'where (t2.NgayThu between '''+@strTuNgay+'''and '''+@strDenNgay+''') and (t1.MaLopHoc is null or t1.MaLopHoc ='''')';
	
	-- trường hợp lấy theo lớp
	IF @KieuBaoCao = 3
		SET @sqlWhere='where (t2.NgayThu between '''+@strTuNgay+' and '''+@strDenNgay+''') and t1.MaLopHoc is not null and t1.MaLopHoc <> '''')';
	SET @sql = @sql + @sqlWhere;
	PRINT(@sql)
	EXEC(@sql)
END
GO

-- create proc Get_MaHocVienCu

CREATE PROC Get_MaHocVienCu
(@MaLopHoc NVARCHAR(30))
AS
BEGIN
	SELECT TOP(1) MaHocVien FROM dbo.DT_LienTuc_HocVien 
		WHERE MaLopHoc = @MaLopHoc AND MaHocVien IS NOT NULL ORDER BY id DESC
END
GO
