Create table CDT_LichGiangTheoLop
(
IDLichGiang bigint identity primary key ,
MaLop nvarchar(100),
TenLop nvarchar(200),
NgayBatDau datetime,
NgayKetThuc datetime,
SoTietLyThuyet int,
SoTietThucHanh int,
NgayTao datetime
)

GO

Create table CDT_LichGiangTheoLop_CT
(
IDLichGiangCT bigint identity primary key,
IDLichGiang bigint,
NgayGiang nvarchar(150),
BuoiGiang nvarchar(502),
NoiDungGiang nvarchar(300),
LoaiDaoTao nvarchar(30),
IDGiangVien bigint,
IDNguoiDung bigint,
Ngay nvarchar(30)
FOREIGN KEY (IDLichGiang) REFERENCES CDT_LichGiangTheoLop (IDLichGiang)
)

GO
--drop table CDT_LichGiangTheoLop_CT
Create PROCEDURE [dbo].[DT_LichGiangTheoLop_get]
    @MaLop nvarchar(100)
AS
    BEGIN

        SET NOCOUNT ON

        /* Get PhieuNhap from table */
        SELECT
            *
        FROM [dbo].[CDT_LichGiangTheoLop]
        WHERE
            [CDT_LichGiangTheoLop].MaLop = @MaLop

        /* Get PhieuNhapCTInfo from table */
        SELECT
            ct.*
        FROM [dbo].[CDT_LichGiangTheoLop_CT] ct
            Inner JOIN [dbo].[CDT_LichGiangTheoLop] ON ct.IDLichGiang = [CDT_LichGiangTheoLop].IDLichGiang
        WHERE
            [CDT_LichGiangTheoLop].IDLichGiang = (select IDLichGiang from CDT_LichGiangTheoLop where MaLop = @MaLop)

    END
GO

CREATE PROCEDURE [dbo].[DT_LichGiangTheoLop_ins]
    @IDLichGiang bigint OUTPUT,
    @MaLop nvarchar(150),
    @TenLop nvarchar(200),
    @NgayBatDau datetime,
    @NgayKetThuc datetime,
    @SoTietLyThuyet int,
    @SoTietThucHanh int,
    @NgayTao datetime
AS
    BEGIN

        SET NOCOUNT ON
		
		IF(dbo.KiemTraNgayNhap(@NgayBatDau) = 0)
		BEGIN
			DECLARE @Message NVARCHAR(200)
			SET @Message = N'Bạn đang ở năm: ' + cast(YEAR(GETDATE()) AS CHAR(4)) + N' không thể cập nhật trường dữ liệu "Ngày bắt đầu" ở năm: ' + CAST(YEAR(@NgayBatDau) AS CHAR(4))
			raiserror(@Message,16,1)
			return;
		END
		
		IF(dbo.KiemTraNgayNhap(@NgayKetThuc) = 0)
		BEGIN
			DECLARE @Message1 NVARCHAR(200)
			SET @Message1 = N'Bạn đang ở năm: ' + cast(YEAR(GETDATE()) AS CHAR(4)) + N' không thể cập nhật trường dữ liệu "Ngày két thúc" ở năm: ' + CAST(YEAR(@NgayKetThuc) AS CHAR(4))
			raiserror(@Message1,16,1)
			return;
		END
			
        /* Insert object into dbo.PhieuNhap */
        INSERT INTO [dbo].[CDT_LichGiangTheoLop]
        (        
            [MaLop],
            [TenLop],
            [NgayBatDau],
            [NgayKetThuc],
            [SoTietLyThuyet],
            [SoTietThucHanh],
            [NgayTao]
        )
        VALUES
        (
            @MaLop,
            @TenLop,
            @NgayBatDau,
            @NgayKetThuc,
            @SoTietLyThuyet,
            @SoTietThucHanh,
            @NgayTao
		)

        /* Return new primary key */
        SET @IDLichGiang = SCOPE_IDENTITY()

    END
GO

CREATE PROCEDURE [dbo].[DT_LichGiangTheoLop_upd]
    @IDLichGiang bigint OUTPUT,
    @MaLop nvarchar(150),
    @TenLop nvarchar(200),
    @NgayBatDau datetime,
    @NgayKetThuc datetime,
    @SoTietLyThuyet int,
    @SoTietThucHanh int,
    @NgayTao datetime
AS
    BEGIN

        SET NOCOUNT ON
        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [IDLichGiang] FROM [dbo].[CDT_LichGiangTheoLop]
            WHERE
                [IDLichGiang] = @IDLichGiang
        )
        BEGIN
            RAISERROR ('''dbo.PhieuNhap'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END
        /*Check field NgayNhapHoaDon */
        IF(dbo.KiemTraNgayNhap(@NgayBatDau) = 0)
		BEGIN
			DECLARE @Message NVARCHAR(200)
			SET @Message = N'Bạn đang ở năm: ' + cast(YEAR(GETDATE()) AS CHAR(4)) + N' không thể cập nhật trường dữ liệu "Ngày bắt đầu" ở năm: ' + CAST(YEAR(@NgayBatDau) AS CHAR(4))
			raiserror(@Message,16,1)
			return;
		END
		/*Check field NgayNhanHang */
		IF(dbo.KiemTraNgayNhap(@NgayKetThuc) = 0)
		BEGIN
			DECLARE @Message1 NVARCHAR(200)
			SET @Message1 = N'Bạn đang ở năm: ' + cast(YEAR(GETDATE()) AS CHAR(4)) + N' không thể cập nhật trường dữ liệu "Ngày kết thúc" ở năm: ' + CAST(YEAR(@NgayKetThuc) AS CHAR(4))
			raiserror(@Message1,16,1)
			return;
		END

        /* Update object in dbo.PhieuNhap */
        UPDATE [dbo].[CDT_LichGiangTheoLop]
        SET
            [MaLop] = @MaLop,
            [TenLop] = @TenLop,
            [NgayBatDau] = @NgayBatDau,
            [NgayKetThuc] = @NgayKetThuc,
            [SoTietLythuyet] = @SoTietLyThuyet,
            [SoTietThucHanh] = @SoTietThucHanh,
            [NgayTao] = @NgayTao
        WHERE
            [IDLichGiang] = @IDLichGiang

    END
GO

CREATE PROCEDURE [dbo].[DT_LichGiangTheoLop_CT_Info_ins]
    @IDLichGiangCT bigint OUTPUT,
    @IDLichGiang bigint,
    @NgayGiang nvarchar(150),
    @BuoiGiang nvarchar(50),
    @NoiDungGiang nvarchar(300),
    @LoaiDaoTao nvarchar(30),
    @IDGiangVien bigint,
    @IDNguoiDung bigint,
	@Ngay nvarchar(30)
AS
    BEGIN

        SET NOCOUNT ON

        INSERT INTO [dbo].[CDT_LichGiangTheoLop_CT]
        (
            IDLichGiang,
            [NgayGiang],
            [BuoiGiang],
            [NoiDungGiang],
            [LoaiDaoTao],
            [IDGiangVien],
            [IDNguoiDung],
			[Ngay]
        )
        VALUES
        (
            @IDLichGiang,
            @NgayGiang,
            @BuoiGiang,
            @NoiDungGiang,
            @LoaiDaoTao,
            @IDGiangVien,
            @IDNguoiDung,
			@Ngay
        )

        /* Return new primary key */
        SET @IDLichGiangCT = SCOPE_IDENTITY()

    END

GO

CREATE PROCEDURE [dbo].[DT_LichGiangTheoLop_CT_Info_upd]
    @IDLichGiangCT bigint OUTPUT,
    @NgayGiang nvarchar(150),
    @BuoiGiang nvarchar(50),
    @NoiDungGiang nvarchar(300),
    @LoaiDaoTao nvarchar(30),
    @IDGiangVien bigint,
    @IDNguoiDung bigint,
	@Ngay nvarchar(30)
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT @IDLichGiangCT FROM [dbo].[CDT_LichGiangTheoLop_CT]
            WHERE
                IDLichGiangCT = @IDLichGiangCT
        )
        BEGIN
            RAISERROR ('''dbo.[CDT_LichGiangTheoLop_CT]'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.[CDT_LichGiangTheoLop_CT] */
        UPDATE [dbo].[CDT_LichGiangTheoLop_CT]
        SET
            [NgayGiang] = @NgayGiang,
            [BuoiGiang] = @BuoiGiang,
            [NoiDungGiang] = @NoiDungGiang,
            [LoaiDaoTao] = @LoaiDaoTao,
            [IDGiangVien] = @IDGiangVien,
            [IDNguoiDung] = @IDNguoiDung,
			[Ngay] = @Ngay
        WHERE
            [IDLichGiangCT] = @IDLichGiangCT

    END

GO

Create FUNCTION [dbo].[KiemTraNgayNhap] (@NgayNhap DATETIME)
RETURNS BIT
AS
BEGIN
	DECLARE @isBool BIT = 1
	IF(YEAR(GETDATE()) <> YEAR(@NgayNhap))
		set @isBool = 0
	--RETURN (@isBool)
	return 1			
END

GO

USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[DT_DuAn_Info_delete]    Script Date: 27/06/2019 10:37:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[DT_LichGiangTheoLop_CT_Info_del]
    @IDLichGiangCT bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT IDLichGiangCT FROM [dbo].[CDT_LichGiangTheoLop_CT]
            WHERE
                IDLichGiangCT = @IDLichGiangCT
        )
        BEGIN
            RAISERROR ('''dbo.CDT_LichGiangTheoLop_CT'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete DT_DuAn_Info object from DT_DuAn */
        DELETE
        FROM [dbo].[CDT_LichGiangTheoLop_CT]
        WHERE
            [dbo].[CDT_LichGiangTheoLop_CT].[IDLichGiangCT] = @IDLichGiangCT

    END

GO

USE [MDCT]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[DT_LichGiangTheoLop_del]
    @IDLichGiang int
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [IDLichGiang] FROM [dbo].[CDT_LichGiangTheoLop]
            WHERE
                [IDLichGiang] = @IDLichGiang
        )
        BEGIN
            RAISERROR ('''dbo.[CDT_LichGiangTheoLop]'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END
		/* Delete [CDT_LichGiangTheoLop_CT] object from CDT_LichGiangTheoLop_CT */
        DELETE
        FROM [dbo].[CDT_LichGiangTheoLop_CT]
        WHERE
            [dbo].[CDT_LichGiangTheoLop_CT].[IDLichGiang] = @IDLichGiang
        /* Delete [CDT_LichGiangTheoLop] object from [CDT_LichGiangTheoLop] */
        DELETE
        FROM [dbo].[CDT_LichGiangTheoLop]
        WHERE
            [dbo].[CDT_LichGiangTheoLop].[IDLichGiang] = @IDLichGiang

    END

GO

USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[DT_LichGiangTheoLop_get]    Script Date: 26/06/2019 10:26:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DT_LichGiangTheoLop_get]
    @MaLop nvarchar(100)
AS
    BEGIN

        SET NOCOUNT ON

        /* Get PhieuNhap from table */
        SELECT
            *
        FROM [dbo].[CDT_LichGiangTheoLop]
        WHERE
            [CDT_LichGiangTheoLop].MaLop = @MaLop

        /* Get PhieuNhapCTInfo from table */
        SELECT
            case when BuoiGiang = N'Sáng' then 0 else 1 end as LoaiBuoi, ct.*
        FROM [dbo].[CDT_LichGiangTheoLop_CT] ct
            Inner JOIN [dbo].[CDT_LichGiangTheoLop] ON ct.IDLichGiang = [CDT_LichGiangTheoLop].IDLichGiang
        WHERE
            [CDT_LichGiangTheoLop].IDLichGiang = (select IDLichGiang from CDT_LichGiangTheoLop where MaLop = @MaLop)
			order by Ngay, LoaiBuoi asc
    END
GO

USE [MDCT]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CDT_KiemTraLichGiang]
@IDGiangVien bigint ,
@BuoiGiang nvarchar(12),
@Ngay nvarchar(30)
AS
    BEGIN	
        SET NOCOUNT ON
		declare @dk int
		set @dk = (select 1 from CDT_LichGiangTheoLop_CT where IDGiangVien = @IDGiangVien and BuoiGiang = @BuoiGiang and Ngay = @Ngay)
        if (@dk = 1 and @IDGiangVien <> 0)
	select N'Buổi ' + @BuoiGiang + N' ngày ' + lgct.Ngay  + N', giảng viên ' + gv.HoTen + N' đã có lịch giảng ở lớp ' + lh.TenLop + N'( ' + lh.MaLop + N' )'  as NoiDung from CDT_LichGiangTheoLop_CT lgct
	join CDT_LichGiangTheoLop lg on lg.IDLichGiang = lgct.IDLichGiang
	join DT_LienTuc_LopHoc lh on lh.MaLop = lg.MaLop 
	join DIC_GiangVien gv on gv.ID = lgct.IDGiangVien
	Where lgct.IDGiangVien = @IDGiangVien and Ngay = @Ngay and BuoiGiang = @BuoiGiang
	else
	select top 1 '' as NoiDung from CDT_LichGiangTheoLop_CT
    END

GO

USE [MDCT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[BC_LichGiangChiTiet]
(
@IDLichGiang bigint
)
as
begin

    select NgayGiang,BuoiGiang,NoiDungGiang,HoTen, N'Tuần ' +  Convert(varchar(3),SoTuan) as TuanThu from (select distinct lgct.IDLichGiang, NgayGiang, BuoiGiang, lgct.NoiDungGiang,gv.HoTen , Ngay
	,case when BuoiGiang = N'Sáng' then 0 else 1 end as LoaiBuoi, DATEPART(wk,Convert(datetime,lgct.Ngay,103)) as Tuan from CDT_LichGiangTheoLop_CT lgct 
	join CDT_LichGiangTheoLop lg on lg.IDLichGiang = lgct.IDLichGiang
	left join DIC_GiangVien gv on gv.ID = lgct.IDGiangVien
	where lgct.IDLichGiang = @IDLichGiang and NgayGiang not like N'%Chủ Nhật%' and NgayGiang not like N'%Thứ Bảy%')a
	join (select ROW_NUMBER() OVER (ORDER BY Tuan) AS SoTuan,Tuan from (select distinct DATEPART(wk,Convert(datetime,lgct.Ngay,103)) as Tuan from CDT_LichGiangTheoLop_CT lgct
	where lgct.IDLichGiang = @IDLichGiang)a) t on t.Tuan = a.Tuan 
	order by Ngay,LoaiBuoi
end
GO

USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[DT_LienTuc_LopHoc_Coll_get]    Script Date: 26/07/2019 11:02:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[DT_LienTuc_LopHoc_Coll_get]
	@BoPhan INT = 0,
	@Nam INT = 0
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DT_LienTuc_LopHoc_Info from table */
        IF ( @Nam > 0
             AND @BoPhan > 0
           )
            BEGIN
                SELECT  v.* ,
                        cb.HoTen AS CanBoPhoiHop
                FROM    DT_View_LienTuc_LopHoc v
                        LEFT JOIN dbo.DIC_CanBo cb ON cb.ID = v.idCanBoPhoiHop
                WHERE   YEAR(NgayBatDau) = @Nam
                        AND IDBoPhan = @BoPhan
                ORDER BY NgayBatDau DESC

            END
			ELSE
			IF ( @Nam = 0
             AND @BoPhan > 0
           )
            BEGIN
                SELECT  v.* ,
                        cb.HoTen AS CanBoPhoiHop
                FROM    DT_View_LienTuc_LopHoc v
                        LEFT JOIN dbo.DIC_CanBo cb ON cb.ID = v.idCanBoPhoiHop
                WHERE   IDBoPhan = @BoPhan
                ORDER BY NgayBatDau DESC

            END
			ELSE
			IF ( @Nam > 0
             AND @BoPhan = 0
           )
            BEGIN
                SELECT  v.* ,
                        cb.HoTen AS CanBoPhoiHop
                FROM    DT_View_LienTuc_LopHoc v
                        LEFT JOIN dbo.DIC_CanBo cb ON cb.ID = v.idCanBoPhoiHop
                WHERE   YEAR(NgayBatDau) = @Nam
                        
                ORDER BY NgayBatDau DESC

            END
			ELSE
			IF ( @Nam = 0
             AND @BoPhan = 0
           )
            BEGIN
                SELECT  v.* ,
                        cb.HoTen AS CanBoPhoiHop, 0 as TongSo
                FROM    DT_View_LienTuc_LopHoc v
                        LEFT JOIN dbo.DIC_CanBo cb ON cb.ID = v.idCanBoPhoiHop
                
                ORDER BY NgayBatDau DESC

            END
    END

GO

USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[BC_ChamCongGiangVien]    Script Date: 26/07/2019 11:18:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER proc [dbo].[BC_ChamCongGiangVien]
(
@MaLop nvarchar(150),
@Thang nvarchar(10)
)
as
begin
	declare @DoDaiThang int
	declare @IDLichGiang bigint
	set @IDLichGiang = (select IDLichGiang from CDT_LichGiangTheoLop where MaLop = @MaLop)
	set @Thang = SUBSTRING(@Thang,CHARINDEX(' ',@Thang ) + 1, LEN(@Thang) - CHARINDEX(' ',@Thang ))
    select distinct HoTen, m1.S1,m1.C1,m2.S2,m2.C2,m3.S3, m3.C3,m4.S4, m4.C4, m5.S5,M5.C5, m6.S6 ,C6, S7, C7, S8, C8, S9, C9, S10, C10, S11, C11, S12, C12, S13, C13, S14, C14, S15, C15,
	S16, C16, S17, C17, S18, C18, S19, C19, S20, C20, S21, C21, S22, C22, S23, C23, S24, C24, S25, C25,S26, C26, S27, C27, S28, C28, S29,C29, S30,C30, S31, C31, SoLT, SoTH from CDT_LichGiangTheoLop_CT lgct
	join DIC_GiangVien gv on gv.ID = lgct.IDGiangVien
	--Ngày mồng 1
	Left join (select distinct lgct.IDGiangVien,S1,C1 from CDT_LichGiangTheoLop_CT lgct
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS S1 from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 1 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Sáng') s on s.IDGiangVien = lgct.IDGiangVien	
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS C1 from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 1 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Chiều') c on c.IDGiangVien = lgct.IDGiangVien
			where day(Convert(datetime,Ngay,103)) = 1 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang) m1 on m1.IDGiangVien = lgct.IDGiangVien

	Left Join (select distinct lgct.IDGiangVien,Sang as S2,Chieu as C2 from CDT_LichGiangTheoLop_CT lgct
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Sang from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 2 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Sáng') s on s.IDGiangVien = lgct.IDGiangVien	
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Chieu from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 2 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Chiều') c on c.IDGiangVien = lgct.IDGiangVien
			where day(Convert(datetime,Ngay,103)) = 2 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang) m2 on m2.IDGiangVien = lgct.IDGiangVien

	Left Join (select distinct lgct.IDGiangVien,Sang as S3, Chieu as C3 from CDT_LichGiangTheoLop_CT lgct
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Sang from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 3 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Sáng') s on s.IDGiangVien = lgct.IDGiangVien	
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Chieu from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 3 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Chiều') c on c.IDGiangVien = lgct.IDGiangVien
			where day(Convert(datetime,Ngay,103)) = 3 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang) m3 on m3.IDGiangVien = lgct.IDGiangVien

	Left Join ( select distinct lgct.IDGiangVien,Sang as S4, Chieu as C4 from CDT_LichGiangTheoLop_CT lgct
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Sang from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 4 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Sáng') s on s.IDGiangVien = lgct.IDGiangVien	
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Chieu from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 4 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Chiều') c on c.IDGiangVien = lgct.IDGiangVien
			where day(Convert(datetime,Ngay,103)) = 4 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang) m4 on m4.IDGiangVien = lgct.IDGiangVien

	Left Join ( select distinct lgct.IDGiangVien,Sang as S5, Chieu as C5 from CDT_LichGiangTheoLop_CT lgct
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Sang from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 5 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Sáng') s on s.IDGiangVien = lgct.IDGiangVien	
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Chieu from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 5 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Chiều') c on c.IDGiangVien = lgct.IDGiangVien
			where day(Convert(datetime,Ngay,103)) = 5 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang) m5 on m5.IDGiangVien = lgct.IDGiangVien

	Left join (select distinct lgct.IDGiangVien,S6,C6 from CDT_LichGiangTheoLop_CT lgct
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS S6 from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 6 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Sáng') s on s.IDGiangVien = lgct.IDGiangVien	
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS C6 from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 6 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Chiều') c on c.IDGiangVien = lgct.IDGiangVien
			where day(Convert(datetime,Ngay,103)) = 6 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang) m6 on m6.IDGiangVien = lgct.IDGiangVien

	Left Join (select distinct lgct.IDGiangVien,Sang as S7,Chieu as C7 from CDT_LichGiangTheoLop_CT lgct
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Sang from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 7 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Sáng') s on s.IDGiangVien = lgct.IDGiangVien	
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Chieu from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 7 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Chiều') c on c.IDGiangVien = lgct.IDGiangVien
			where day(Convert(datetime,Ngay,103)) = 7 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang) m7 on m7.IDGiangVien = lgct.IDGiangVien

	Left Join (select distinct lgct.IDGiangVien,Sang as S8, Chieu as C8 from CDT_LichGiangTheoLop_CT lgct
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Sang from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 8 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Sáng') s on s.IDGiangVien = lgct.IDGiangVien	
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Chieu from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 8 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Chiều') c on c.IDGiangVien = lgct.IDGiangVien
			where day(Convert(datetime,Ngay,103)) = 8 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang) m8 on m8.IDGiangVien = lgct.IDGiangVien

	Left Join ( select distinct lgct.IDGiangVien,Sang as S9, Chieu as C9 from CDT_LichGiangTheoLop_CT lgct
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Sang from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 9 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Sáng') s on s.IDGiangVien = lgct.IDGiangVien	
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Chieu from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 9 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Chiều') c on c.IDGiangVien = lgct.IDGiangVien
			where day(Convert(datetime,Ngay,103)) = 9 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang) m9 on m9.IDGiangVien = lgct.IDGiangVien

	Left Join ( select distinct lgct.IDGiangVien,Sang as S10, Chieu as C10 from CDT_LichGiangTheoLop_CT lgct
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Sang from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 10 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Sáng') s on s.IDGiangVien = lgct.IDGiangVien	
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Chieu from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 10 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Chiều') c on c.IDGiangVien = lgct.IDGiangVien
			where day(Convert(datetime,Ngay,103)) = 10 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang) m10 on m10.IDGiangVien = lgct.IDGiangVien
	
	Left join (select distinct lgct.IDGiangVien,S11,C11 from CDT_LichGiangTheoLop_CT lgct
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS S11 from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 11 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Sáng') s on s.IDGiangVien = lgct.IDGiangVien	
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS C11 from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 11 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Chiều') c on c.IDGiangVien = lgct.IDGiangVien
			where day(Convert(datetime,Ngay,103)) = 11 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang) m11 on m11.IDGiangVien = lgct.IDGiangVien

	Left Join (select distinct lgct.IDGiangVien,Sang as S12,Chieu as C12 from CDT_LichGiangTheoLop_CT lgct
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Sang from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 12 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Sáng') s on s.IDGiangVien = lgct.IDGiangVien	
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Chieu from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 12 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Chiều') c on c.IDGiangVien = lgct.IDGiangVien
			where day(Convert(datetime,Ngay,103)) = 12 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang) m12 on m12.IDGiangVien = lgct.IDGiangVien

	Left Join (select distinct lgct.IDGiangVien,Sang as S13, Chieu as C13 from CDT_LichGiangTheoLop_CT lgct
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Sang from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 13 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Sáng') s on s.IDGiangVien = lgct.IDGiangVien	
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Chieu from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 13 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Chiều') c on c.IDGiangVien = lgct.IDGiangVien
			where day(Convert(datetime,Ngay,103)) = 13 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang) m13 on m13.IDGiangVien = lgct.IDGiangVien

	Left Join ( select distinct lgct.IDGiangVien,Sang as S14, Chieu as C14 from CDT_LichGiangTheoLop_CT lgct
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Sang from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 14 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Sáng') s on s.IDGiangVien = lgct.IDGiangVien	
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Chieu from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 14 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Chiều') c on c.IDGiangVien = lgct.IDGiangVien
			where day(Convert(datetime,Ngay,103)) = 14 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang) m14 on m14.IDGiangVien = lgct.IDGiangVien

	Left Join ( select distinct lgct.IDGiangVien,Sang as S15, Chieu as C15 from CDT_LichGiangTheoLop_CT lgct
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Sang from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 15 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Sáng') s on s.IDGiangVien = lgct.IDGiangVien	
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Chieu from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 15 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Chiều') c on c.IDGiangVien = lgct.IDGiangVien
			where day(Convert(datetime,Ngay,103)) = 15 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang) m15 on m15.IDGiangVien = lgct.IDGiangVien
	
	Left join (select distinct lgct.IDGiangVien,S16,C16 from CDT_LichGiangTheoLop_CT lgct
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS S16 from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 16 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Sáng') s on s.IDGiangVien = lgct.IDGiangVien	
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS C16 from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 16 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Chiều') c on c.IDGiangVien = lgct.IDGiangVien
			where day(Convert(datetime,Ngay,103)) = 16 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang) m16 on m16.IDGiangVien = lgct.IDGiangVien

	Left Join (select distinct lgct.IDGiangVien,Sang as S17,Chieu as C17 from CDT_LichGiangTheoLop_CT lgct
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Sang from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 17 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Sáng') s on s.IDGiangVien = lgct.IDGiangVien	
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Chieu from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 17 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Chiều') c on c.IDGiangVien = lgct.IDGiangVien
			where day(Convert(datetime,Ngay,103)) = 17 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang) m17 on m17.IDGiangVien = lgct.IDGiangVien

	Left Join (select distinct lgct.IDGiangVien,Sang as S18, Chieu as C18 from CDT_LichGiangTheoLop_CT lgct
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Sang from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 18 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Sáng') s on s.IDGiangVien = lgct.IDGiangVien	
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Chieu from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 18 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Chiều') c on c.IDGiangVien = lgct.IDGiangVien
			where day(Convert(datetime,Ngay,103)) = 18 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang) m18 on m18.IDGiangVien = lgct.IDGiangVien

	Left Join ( select distinct lgct.IDGiangVien,Sang as S19, Chieu as C19 from CDT_LichGiangTheoLop_CT lgct
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Sang from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 19 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Sáng') s on s.IDGiangVien = lgct.IDGiangVien	
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Chieu from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 19 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Chiều') c on c.IDGiangVien = lgct.IDGiangVien
			where day(Convert(datetime,Ngay,103)) = 19 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang) m19 on m19.IDGiangVien = lgct.IDGiangVien

	Left Join ( select distinct lgct.IDGiangVien,Sang as S20, Chieu as C20 from CDT_LichGiangTheoLop_CT lgct
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Sang from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 20 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Sáng') s on s.IDGiangVien = lgct.IDGiangVien	
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Chieu from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 20 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Chiều') c on c.IDGiangVien = lgct.IDGiangVien
			where day(Convert(datetime,Ngay,103)) = 20 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang) m20 on m20.IDGiangVien = lgct.IDGiangVien
	
	Left join (select distinct lgct.IDGiangVien,S21,C21 from CDT_LichGiangTheoLop_CT lgct
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS S21 from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 21 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Sáng') s on s.IDGiangVien = lgct.IDGiangVien	
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS C21 from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 21 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Chiều') c on c.IDGiangVien = lgct.IDGiangVien
			where day(Convert(datetime,Ngay,103)) = 21 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang) m21 on m21.IDGiangVien = lgct.IDGiangVien

	Left Join (select distinct lgct.IDGiangVien,Sang as S22,Chieu as C22 from CDT_LichGiangTheoLop_CT lgct
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Sang from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 22 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Sáng') s on s.IDGiangVien = lgct.IDGiangVien	
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Chieu from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 22 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Chiều') c on c.IDGiangVien = lgct.IDGiangVien
			where day(Convert(datetime,Ngay,103)) = 22 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang) m22 on m22.IDGiangVien = lgct.IDGiangVien

	Left Join (select distinct lgct.IDGiangVien,Sang as S23, Chieu as C23 from CDT_LichGiangTheoLop_CT lgct
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Sang from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 23 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Sáng') s on s.IDGiangVien = lgct.IDGiangVien	
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Chieu from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 23 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Chiều') c on c.IDGiangVien = lgct.IDGiangVien
			where day(Convert(datetime,Ngay,103)) = 23 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang) m23 on m23.IDGiangVien = lgct.IDGiangVien

	Left Join ( select distinct lgct.IDGiangVien,Sang as S24, Chieu as C24 from CDT_LichGiangTheoLop_CT lgct
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Sang from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 24 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Sáng') s on s.IDGiangVien = lgct.IDGiangVien	
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Chieu from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 24 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Chiều') c on c.IDGiangVien = lgct.IDGiangVien
			where day(Convert(datetime,Ngay,103)) = 24 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang) m24 on m24.IDGiangVien = lgct.IDGiangVien

	Left Join ( select distinct lgct.IDGiangVien,Sang as S25, Chieu as C25 from CDT_LichGiangTheoLop_CT lgct
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Sang from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 25 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Sáng') s on s.IDGiangVien = lgct.IDGiangVien	
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Chieu from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 25 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Chiều') c on c.IDGiangVien = lgct.IDGiangVien
			where day(Convert(datetime,Ngay,103)) = 25 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang) m25 on m25.IDGiangVien = lgct.IDGiangVien
	
	Left join (select distinct lgct.IDGiangVien,S26,C26 from CDT_LichGiangTheoLop_CT lgct
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS S26 from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 26 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Sáng') s on s.IDGiangVien = lgct.IDGiangVien	
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS C26 from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 26 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Chiều') c on c.IDGiangVien = lgct.IDGiangVien
			where day(Convert(datetime,Ngay,103)) = 26 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang) m26 on m26.IDGiangVien = lgct.IDGiangVien

	Left Join (select distinct lgct.IDGiangVien,Sang as S27,Chieu as C27 from CDT_LichGiangTheoLop_CT lgct
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Sang from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 27 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Sáng') s on s.IDGiangVien = lgct.IDGiangVien	
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Chieu from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 27 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Chiều') c on c.IDGiangVien = lgct.IDGiangVien
			where day(Convert(datetime,Ngay,103)) = 27 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang) m27 on m27.IDGiangVien = lgct.IDGiangVien

	Left Join (select distinct lgct.IDGiangVien,Sang as S28, Chieu as C28 from CDT_LichGiangTheoLop_CT lgct
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Sang from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 28 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Sáng') s on s.IDGiangVien = lgct.IDGiangVien	
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Chieu from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 28 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Chiều') c on c.IDGiangVien = lgct.IDGiangVien
			where day(Convert(datetime,Ngay,103)) = 28 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang) m28 on m28.IDGiangVien = lgct.IDGiangVien

	Left Join ( select distinct lgct.IDGiangVien,Sang as S29, Chieu as C29 from CDT_LichGiangTheoLop_CT lgct
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Sang from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 29 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Sáng') s on s.IDGiangVien = lgct.IDGiangVien	
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Chieu from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 29 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Chiều') c on c.IDGiangVien = lgct.IDGiangVien
			where day(Convert(datetime,Ngay,103)) = 29 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang) m29 on m29.IDGiangVien = lgct.IDGiangVien

	Left Join ( select distinct lgct.IDGiangVien,Sang as S30, Chieu as C30 from CDT_LichGiangTheoLop_CT lgct
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Sang from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 30 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Sáng') s on s.IDGiangVien = lgct.IDGiangVien	
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Chieu from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 30 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Chiều') c on c.IDGiangVien = lgct.IDGiangVien
			where day(Convert(datetime,Ngay,103)) = 30 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang) m30 on m30.IDGiangVien = lgct.IDGiangVien
	
	Left Join ( select distinct lgct.IDGiangVien,Sang as S31, Chieu as C31 from CDT_LichGiangTheoLop_CT lgct
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Sang from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 31 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Sáng') s on s.IDGiangVien = lgct.IDGiangVien	
				left join (select IDGiangVien, Case when LoaiDaoTao = N'Lý thuyết' then N'LT' else Case when LoaiDaoTao = N'Thực hành' then N'TH' else '' end end AS Chieu from CDT_LichGiangTheoLop_CT
				where day(Convert(datetime,Ngay,103)) = 31 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang and BuoiGiang = N'Chiều') c on c.IDGiangVien = lgct.IDGiangVien
			where day(Convert(datetime,Ngay,103)) = 31 and IDLichGiang = @IDLichGiang and month(Convert(datetime,Ngay,103)) = @Thang) m31 on m31.IDGiangVien = lgct.IDGiangVien
	left join (select IDGiangVien,count(LoaiDaoTao) as SoLT from CDT_LichGiangTheoLop_CT where IDLichGiang = @IDLichGiang  and  LoaiDaoTao = N'Lý thuyết'
				group by IDGiangVien) slt on slt.IDGiangVien = lgct.IDGiangVien

	left join (select IDGiangVien,count(LoaiDaoTao) as SoTH from CDT_LichGiangTheoLop_CT where IDLichGiang = @IDLichGiang  and  LoaiDaoTao = N'Thực hành'
				group by IDGiangVien) sth on sth.IDGiangVien = lgct.IDGiangVien

	Where month(Convert(datetime,Ngay,103)) = @Thang and IDLichGiang = @IDLichGiang
end

GO

USE [MDCT]
GO

/****** Object:  View [dbo].[DT_View_LienTuc_HocVien]    Script Date: 28/08/2019 4:09:39 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



ALTER VIEW [dbo].[DT_View_LienTuc_HocVien]
AS
SELECT        TOP (100) PERCENT dbo.DT_LienTuc_HocVien.id, dbo.DT_LienTuc_HocVien.HoTen, dbo.DT_LienTuc_HocVien.NgaySinh, dbo.DT_LienTuc_HocVien.SoCMT, dbo.DT_LienTuc_HocVien.HinhThucHoc, 
                         dbo.DT_LienTuc_HocVien.MaLopHoc, dbo.DT_LienTuc_HocVien.TrangThai, dbo.DT_LienTuc_HocVien.DaDongHocPhi, dbo.DT_LienTuc_HocVien.idNguoiQuanLy, dbo.DT_LienTuc_HocVien.MaHocVien, 
                         dbo.DT_LienTuc_HocVien.GioiTinh, dbo.DT_LienTuc_HocVien.idTrinhDo, dbo.DT_LienTuc_HocVien.idChuyenNganh, dbo.DT_LienTuc_HocVien.TruongTotNghiep, dbo.DT_LienTuc_HocVien.NamTotNghiep, 
                         dbo.DT_LienTuc_HocVien.SoBang, dbo.DT_LienTuc_HocVien.NoiCongTac, dbo.DT_LienTuc_HocVien.idTinhThanh, dbo.DT_LienTuc_HocVien.DiaChiCoQuan, dbo.DT_LienTuc_HocVien.DiaChiNhaRieng, 
                         dbo.DT_LienTuc_HocVien.DienThoaiCoQuan, dbo.DT_LienTuc_HocVien.DienThoaiNhaRieng, dbo.DT_LienTuc_HocVien.DiDong, dbo.DT_LienTuc_HocVien.Email, dbo.DT_LienTuc_HocVien.NgayCapCMT, 
                         dbo.DT_LienTuc_HocVien.NoiCapCMT, dbo.DT_LienTuc_HocVien.NgayDangKi, dbo.DT_LienTuc_HocVien.idChuyenNganhDangKi, dbo.DT_LienTuc_HocVien.NoiDungDaoTao, 
                         dbo.DT_LienTuc_HocVien.NgayBatDau, dbo.DT_LienTuc_HocVien.NgayKetThuc, dbo.DT_LienTuc_HocVien.Anh, dbo.DT_LienTuc_HocVien.idKhungLopHoc, dbo.DT_LienTuc_HocVien.TongHocPhi, 
                         dbo.DT_LienTuc_HocVien.DiemThi, dbo.DT_LienTuc_HocVien.XepLoai, dbo.DT_LienTuc_HocVien.Lan1, dbo.DT_LienTuc_HocVien.Lan2, dbo.DT_LienTuc_HocVien.Lan3, dbo.DT_LienTuc_HocVien.Lan4, 
                         dbo.DT_LienTuc_HocVien.DangKiTuCTT, dbo.DT_LienTuc_HocVien.idBenhVienCongTac, dbo.DT_LienTuc_HocVien.TongSoLanInThe, dbo.DT_LienTuc_HocVien.TongSoLanInGiayChungNhan, 
                         dbo.DT_LienTuc_HocVien.TongSoLanInBangTotNghiep, dbo.DT_LienTuc_HocVien.TongSoLanInHoaDon, dbo.DT_LienTuc_HocVien.GhiChu, dbo.DT_LienTuc_HocVien.LastEdited_User, 
                         dbo.DT_LienTuc_HocVien.LastEdited_Date, dbo.DT_LienTuc_HocVien.TongTienHoc, dbo.DT_LienTuc_HocVien.TongChiPhiKhac, dbo.DT_LienTuc_HocVien.Nhom, dbo.DT_LienTuc_HocVien.Lan5, 
                         dbo.DT_LienTuc_HocVien.HoaDonHocPhi, dbo.DT_LienTuc_HocVien.NgayDong, dbo.DT_LienTuc_HocVien.SoTienHoan, dbo.DT_LienTuc_HocVien.LyDoHoanTien, dbo.DT_LienTuc_HocVien.IdBoPhan, 
                         dbo.DT_LienTuc_HocVien.NgayDongDetail, dbo.DT_LienTuc_HocVien.backup01, dbo.DT_LienTuc_HocVien.backup02, dbo.DT_LienTuc_HocVien.backup03, dbo.DT_LienTuc_HocVien.backup04, 
                         dbo.DT_LienTuc_HocVien.backup05, dbo.DT_LienTuc_HocVien.SoTienDongDetail, dbo.DT_LienTuc_HocVien.idLopHoc, benhvien.Ten AS TenBenhVien, tinhthanh.Ten AS TenTinhThanh, 
                         chuyennganh.Ten AS TenChuyenNganh, trinhdo.TenHocVi AS TenTrinhDo, bophan.Ten AS TenBoPhan, lophoc.TenLop AS TenLopHoc, chuyenkhoalophoc.Ten AS TenChuyenKhoaLopHoc, 
                         lophoc.NgayBatDau AS NgayBatDauLop, lophoc.NgayKetThuc AS NgayKetThucLop, lophoc.KhoaHoc AS TenKhoaHoc, lastedited.TenDayDu AS TenLastEdited_UserName, 
                         tennguoiquanly.TenDayDu AS TenNguoiQuanLy, lophoc.TongSoTiet,dbo.DT_LienTuc_HocVien.MaSothue
FROM            dbo.DT_LienTuc_HocVien LEFT OUTER JOIN
                         dbo.DIC_BenhVien AS benhvien ON dbo.DT_LienTuc_HocVien.idBenhVienCongTac = benhvien.ID LEFT OUTER JOIN
                         dbo.DIC_Tinh AS tinhthanh ON dbo.DT_LienTuc_HocVien.idTinhThanh = tinhthanh.ID LEFT OUTER JOIN
                         dbo.DIC_ChuyenNganh AS chuyennganh ON dbo.DT_LienTuc_HocVien.idChuyenNganh = chuyennganh.ID LEFT OUTER JOIN
                         dbo.DIC_HocVi AS trinhdo ON dbo.DT_LienTuc_HocVien.idTrinhDo = trinhdo.ID LEFT OUTER JOIN
                         dbo.DIC_BoPhan AS bophan ON dbo.DT_LienTuc_HocVien.IdBoPhan = bophan.ID LEFT OUTER JOIN
                         dbo.DT_LienTuc_LopHoc AS lophoc ON dbo.DT_LienTuc_HocVien.idLopHoc = lophoc.IDLopHoc LEFT OUTER JOIN
                         dbo.DT_LienTuc_KhungLopHoc AS khunglophoc ON dbo.DT_LienTuc_HocVien.idKhungLopHoc = khunglophoc.id LEFT OUTER JOIN
                         dbo.DIC_ChuyenKhoa AS chuyenkhoalophoc ON khunglophoc.idChuyenKhoa = chuyenkhoalophoc.ID LEFT OUTER JOIN
                         dbo.ADM_NguoiDung AS lastedited ON dbo.DT_LienTuc_HocVien.LastEdited_User = lastedited.IDNguoiDung LEFT OUTER JOIN
                         dbo.ADM_NguoiDung AS tennguoiquanly ON dbo.DT_LienTuc_HocVien.idNguoiQuanLy = tennguoiquanly.IDNguoiDung



GO



















