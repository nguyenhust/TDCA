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
    @PhongQuanLy INT ,
    @LoaiHinhDaoTao NVARCHAR(MAX) ,
    @NgayBatDau DATETIME ,
    @NgayKetThuc DATETIME ,
    @TrangThai NVARCHAR(50)
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DT_LienTuc_HocVien_Info from table */
        IF ( @LoaiHinhDaoTao NOT LIKE N'%Theo%'
             AND @LoaiHinhDaoTao NOT LIKE N'%Kèm%'
           )
            BEGIN
                SET @LoaiHinhDaoTao = '%%'
            END
        IF ( @PhongQuanLy <> 0 )
            BEGIN
                IF ( @TrangThai <> '' )
                    BEGIN
                        SELECT  *
                        FROM    [dbo].DT_View_LienTuc_HocVien AS a
                        WHERE   a.IdBoPhan = @PhongQuanLy
                                AND a.HinhThucHoc LIKE @LoaiHinhDaoTao
                                AND a.NgayBatDau >= @NgayBatDau
                                AND a.NgayBatDau <= @NgayKetThuc
                                AND LOWER(TrangThai) = LOWER(@TrangThai)

                    END
                ELSE
                    BEGIN
                        SELECT  *
                        FROM    [dbo].DT_View_LienTuc_HocVien AS a
                        WHERE   a.IdBoPhan = @PhongQuanLy
                                AND a.HinhThucHoc LIKE @LoaiHinhDaoTao
                                AND a.NgayBatDau >= @NgayBatDau
                                AND a.NgayBatDau <= @NgayKetThuc
                    END
            END
        ELSE
            BEGIN
                IF ( @TrangThai = '' )
                    BEGIN
                        SELECT  *
                        FROM    [dbo].DT_View_LienTuc_HocVien AS a
                        WHERE   a.HinhThucHoc LIKE @LoaiHinhDaoTao
                                AND a.NgayBatDau >= @NgayBatDau
                                AND a.NgayBatDau <= @NgayKetThuc
                    END
                ELSE
                    IF ( @TrangThai <> '' )
                        BEGIN
                            SELECT  *
                            FROM    [dbo].DT_View_LienTuc_HocVien AS a
                            WHERE   a.HinhThucHoc LIKE @LoaiHinhDaoTao
                                    AND a.NgayBatDau >= @NgayBatDau
                                    AND a.NgayBatDau <= @NgayKetThuc
                                    AND LOWER(a.TrangThai) = LOWER(@TrangThai)
                        END 

            END
    END









