USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[DT_LienTuc_HocVien_Coll_get_ThongKe]    Script Date: 3/12/2015 1:56:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--thêm trạng thái của học viên
--Nguyen QUynh
ALTER PROCEDURE [dbo].[DT_LienTuc_HocVien_Coll_get_ThongKe]
@PhongQuanLy int,
@LoaiHinhDaoTao nvarchar(MAX),
@NgayBatDau datetime,
@NgayKetThuc DATETIME,
@TrangThai nvarchar(50)
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DT_LienTuc_HocVien_Info from table */
	    if(@LoaiHinhDaoTao not like N'%Theo%' and @LoaiHinhDaoTao not like N'%Kèm%')
		Begin
		  Set @LoaiHinhDaoTao = '%%'
		End
		IF(@PhongQuanLy <> 0)
		Begin
		 IF(LOWER(@TrangThai) = N'kết thúc - đã cấp chứng chỉ')
		   SELECT
           *
			FROM [dbo].DT_View_LienTuc_HocVien as a
			where a.IdBoPhan = @PhongQuanLy
			AND a.HinhThucHoc like @LoaiHinhDaoTao
			AND a.NgayBatDau >= @NgayBatDau
			AND a.NgayBatDau <= @NgayKetThuc
			AND LOWER(TrangThai) = N'Kết thúc - đã cấp chứng chỉ'

        ELSE IF(LOWER(@TrangThai) = N'Chưa bắt đầu học')
			SELECT
			   *
			FROM [dbo].DT_View_LienTuc_HocVien as a
			where a.IdBoPhan = @PhongQuanLy
			AND a.HinhThucHoc like @LoaiHinhDaoTao
			AND a.NgayBatDau >= @NgayBatDau
			AND a.NgayBatDau <= @NgayKetThuc
			AND LOWER(TrangThai) = N'Chưa bắt đầu học'

		ELSE IF(LOWER(@TrangThai) = N'đang học')
			SELECT
			   *
			FROM [dbo].DT_View_LienTuc_HocVien as a
			where a.IdBoPhan = @PhongQuanLy
			AND a.HinhThucHoc like @LoaiHinhDaoTao
			AND a.NgayBatDau >= @NgayBatDau
			AND a.NgayBatDau <= @NgayKetThuc
			AND LOWER(TrangThai) = N'đang học'
		ELSE
           SELECT
           *
        FROM [dbo].DT_View_LienTuc_HocVien as a
	    where a.IdBoPhan = @PhongQuanLy
		AND a.HinhThucHoc like @LoaiHinhDaoTao
		AND a.NgayBatDau >= @NgayBatDau
		AND a.NgayBatDau <= @NgayKetThuc
		End
		Else
		Begin
		
		     SELECT
           *
        FROM [dbo].DT_View_LienTuc_HocVien as a
	    where a.HinhThucHoc like @LoaiHinhDaoTao
		AND a.NgayBatDau >= @NgayBatDau
		AND a.NgayBatDau <= @NgayKetThuc
		End
    END










