USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[HoaDon_insert]    Script Date: 01/09/2018 13:49:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HoaDon_insert]
--@IDHocVien bigint =null,
@SoHoaDon varchar(12),
@NgayHoaDon datetime,
@IDNguoiXuat bigint,@IDLopHoc int
as  SET NOCOUNT ON
begin
if(exists(select 1 from HoaDon where SoHoaDon = @SoHoaDon))
begin
	raiserror ('Số hóa đơn [%s] này đã tồn tại, Bạn hãy kiểm tra lại!',16,1,@SoHoaDon )
	return
end
if(exists(select 1 from BienLai bl left join HoaDon hd on bl.IDLopHoc=hd.IDLopHoc where  bl.XuatHD=0 and bl.IDLopHoc=@IDLopHoc ))
begin
	declare  @strNgayXuatHD varchar(10)
	set @strNgayXuatHD = convert(varchar(10), @NgayHoaDon, 102) 
	set @strNgayXuatHD = REPLACE(@strNgayXuatHD,'.', '')
	set @SoHoaDon = dbo.fn_TaoSoHoaDon(@strNgayXuatHD)
--set @solan = (select count(*) + 1 from Ip_kyquy kq where kq.IDDieuTri in(select dt.IDDieuTri from IP_DieuTri dt where dt.IDBenhNhan = @IDBenhNhan))
	insert into HoaDon(SoHoaDon,NgayHoaDon, IDNguoiXuat,InChuyenDoi,IDLopHoc)
	values(@SoHoaDon,@NgayHoaDon,@IDNguoiXuat,'F',@IDLopHoc)
end
end

go

create proc [dbo].[HoaDonCT_Gets]
@IDLopHoc int
as SET NOCOUNT ON
begin
select distinct hd.IDHoaDon,bl.IDBienLai,(N'Thanh toán đợt ' + convert(varchar,bl.SoLan)) as TenHang,bl.SoTien, Convert(tinyint,0) as TrangThai from HoaDon hd
join BienLai bl on bl.IDLopHoc=@IDLopHoc
where bl.XuatHD = 0 and bl.IDLopHoc=@IDLopHoc  and hd.IDHoaDon = (select top 1 IDHoaDon from HoaDon where IDLopHoc=@IDLopHoc order by IDHoaDon desc)
end
go
ALTER PROCEDURE [dbo].[DT_LienTuc_LopHoc_Coll_getbyNam] @nam INT
AS
    BEGIN
--	declare @MaLop nvarchar(50)
	--set @MaLop=(select MaLop from DT_View_LienTuc_LopHoc where MaLop=@MaLop)
        SET NOCOUNT ON

        /* Get DT_LienTuc_LopHoc_Info from table */

        IF ( @nam <> 0 )
            BEGIN
                --SELECT  v.* ,
                --        cb.HoTen AS CanBoPhoiHop
                --FROM    DT_View_LienTuc_LopHoc v
                --        LEFT JOIN dbo.DIC_CanBo cb ON cb.ID = v.idCanBoPhoiHop
                --WHERE   YEAR(NgayBatDau) = @nam
                --ORDER BY NgayBatDau DESC
				  SELECT DISTINCT v.MaLop,v.TenLop,v.KhoaHoc,v.DoiTuong,v.NguonKinhPhi,v.NgayBatDau,v.NgayKetThuc,v.HocPhi,v.TenCanBoPhuTrach,v.TenChuyenKhoaLopHoc,cb.HoTen as CanBoPhoiHop, count(*)   as TongSo,v.idCanBoPhuTrach,v.idCanBoPhoiHop,v.idCanBoGiangVien1,v.idCanBoGiangVien2,v.idCanBoGiangVien3
                ,v.idCanBoGiangVien4,v.idCanBoGiangVien5,v.IdChuyenKhoaLopHoc,v.idKhungLopHoc,v.IdNguonKinhPhi,v.LastEdited_Date,v.LastEdited_User,v.TongSoTiet,v.Backup01,v.Backup02,v.Backup03,v.Backup04,v.Backup05,v.Backup06,v.NguonKinhPhi2
                FROM    DT_View_LienTuc_LopHoc v
                        LEFT JOIN dbo.DIC_CanBo cb ON cb.ID = v.idCanBoPhoiHop 
						left join DT_View_LienTuc_HocVien hv  on v.MaLop=hv.MaLopHoc
                WHERE   YEAR(v.NgayBatDau) = @Nam
                    
				group by v.MaLop,v.TenLop,v.KhoaHoc,v.DoiTuong,v.NguonKinhPhi,v.NgayBatDau,v.NgayKetThuc,v.HocPhi,v.TenCanBoPhuTrach,v.TenChuyenKhoaLopHoc,cb.HoTen ,v.idCanBoPhuTrach,v.idCanBoPhoiHop,v.idCanBoGiangVien1,v.idCanBoGiangVien2,v.idCanBoGiangVien3
                ,v.idCanBoGiangVien4,v.idCanBoGiangVien5,v.IdChuyenKhoaLopHoc,v.idKhungLopHoc,v.IdNguonKinhPhi,v.LastEdited_Date,v.LastEdited_User,v.TongSoTiet,v.Backup01,v.Backup02,v.Backup03,v.Backup04,v.Backup05,v.Backup06,v.NguonKinhPhi2
                ORDER BY NgayBatDau DESC
            END
        ELSE
            IF ( @nam = 0 )
                BEGIN
                    SELECT  v.* ,
                            cb.HoTen AS CanBoPhoiHop
                    FROM    DT_View_LienTuc_LopHoc v
                            LEFT JOIN dbo.DIC_CanBo cb ON cb.ID = v.idCanBoPhoiHop
                    ORDER BY NgayBatDau DESC
                END
    END
	go