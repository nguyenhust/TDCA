USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[BC_HocVienDongHocPhi_DTLT1]    Script Date: 19/04/2018 13:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[BC_HocVienDongHocPhi_DTLT1]
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
	SET @sql = ' SELECT 		NgayBatDau = Convert(varchar(10),t1.NgayBatDau,103) +''-''+Convert(varchar(10),t1.NgayKetThuc,103),
				t1.MaBienLai,t1.HinhThucHoc,t1.MaHocVien,t1.HoTen,t1.NoiDung,t1.ChuyenKhoa,t1.SoTien
				FROM (SELECT hv.NgayBatDau, hv.NgayKetThuc,bl.MaBienLai,hv.HinhThucHoc,hv.MaHocVien,hv.HoTen,hv.NoiDungDaoTao as NoiDung,k.Ten as ChuyenKhoa,bl.soTien as SoTien				
				FROM dbo.DT_LienTuc_HocVien hv
				--left JOIN dbo.DIC_HocVi td ON hv.idTrinhDo = td.ID
				left join dbo.BienLai bl on bl.IDHocVien=hv.id
				left JOIN dbo.DT_LienTuc_KhungLopHoc kl ON hv.idKhungLopHoc = kl.id
				left JOIN dbo.DIC_ChuyenKhoa k ON kl.idChuyenKhoa = k.ID
				JOIN (SELECT TienDaDong = SUM(a.soTien),a.IDHocVien,a.NgayThu FROM 
				(SELECT soTien,IDHocVien,NgayThu FROM dbo.BienLai WHERE Huy = 0)a group by IDHocVien,NgayThu) t2 ON hv.id = t2.IDHocVien '
	-- trường hợp lấy tất cả học viên
	IF @KieuBaoCao = 1
		SET @sqlWhere = 'where (t2.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+'''))t1';
	
	-- trường hợp lấy học viên kèm cặp
	IF @KieuBaoCao = 2
		SET @sqlWhere = 'where (t2.NgayThu between '''+@strTuNgay+'''and '''+@strDenNgay+''') and hv.idKhungLopHoc='+CONVERT(nvarchar(10),@IDKhungLopHoc)+' and hv.HinhThucHoc like N''%'+@HinhThucHoc+'%'')t1';
	
	-- trường hợp lấy theo lớp
	IF @KieuBaoCao = 3
		BEGIN
		SET @sqlWhere='where (t2.NgayThu between '''+@strTuNgay+''' and '''+@strDenNgay+''') and hv.idKhungLopHoc = '+CONVERT(NVARCHAR(10),@IDKhungLopHoc)+' and hv.HinhThucHoc like N''%'+@HinhThucHoc+'%'')t1';
		END 
	SET @sql = @sql + @sqlWhere;
	EXEC(@sql)
	PRINT(@sql)
END
