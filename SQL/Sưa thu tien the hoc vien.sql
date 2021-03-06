USE [MDCT]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[IP_GetIDHocVien]
@MaLopHoc nvarchar(100)
as SET NOCOUNT ON
select top 1 ID from DT_LienTuc_HocVien where MaLopHoc = @MaLopHoc

GO
USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[BienLaiTamThu_ins]    Script Date: 13/08/2018 1:33:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 ALTER proc [dbo].[BienLaiTamThu_ins]
@idHocVien bigint,
@Mabienlai varchar(12),
@Solan tinyint output, 
@Sotien numeric,
@NgayThu datetime,
@IDNguoiThu bigint,
@NguoiThu nvarchar(50),
@NguoiDong nvarchar(50),
@HinhThucThu tinyint,
--@XuatHD bit,
@IDBienLai bigint output,
@LoaiPhieu tinyint
as  SET NOCOUNT ON
if(exists(select 1 from BienLai where mabienlai = @Mabienlai))
begin
	raiserror ('Mã biên lai [%s] này đã tồn tại, Bạn hãy kiểm tra lại!',16,1,@mabienlai)
	return
end
declare @LoaiPhieu1 nvarchar(100)

set @LoaiPhieu1=CONVERT(nvarchar(100),@LoaiPhieu)
if(@LoaiPhieu=0)
set @LoaiPhieu1=N'Phiếu thu học phí '
if(@LoaiPhieu=1)
set @LoaiPhieu1=N'PDNTT làm thẻ'
if(@LoaiPhieu=2)
set @LoaiPhieu1=N'PDNTT làm chứng chỉ'

declare @IDBenhNhan bigint, @strNgayKyQuy varchar(10)
set @strNgayKyQuy = convert(varchar(10), @NgayThu, 103) 
set @solan = (select count(*) + 1 from BienLai kq where kq.IDHocVien = @idHocVien)
insert into BienLai(IDHocVien,Mabienlai,Solan,Sotien,NgayThu, IDNguoiThu,TenNguoiDong,TenNguoiThu, HinhThucThu,XuatHD,SoLanIn,Huy,LoaiPhieu)
values(@idHocVien,@Mabienlai,@Solan,round(@Sotien,-2),@Ngaythu, @IDNguoiThu,@NguoiDong,@NguoiThu, @HinhThucThu,0,1,0,@LoaiPhieu)
set @IDBienLai = SCOPE_IDENTITY()

GO

USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[InLaiHoaDon]    Script Date: 13/08/2018 12:52:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




-- Thêm thủ tục thực hiện in lại biên lai cho học viên

ALTER proc [dbo].[InLaiHoaDon]
(
	@IDHocVien bigint,
	@IDBienLai bigint
)
	
as SET NOCOUNT ON
begin
	select bl.SoLanIn,bl.IDHocVien,hv.MaHocVien,Case when bl.LoaiPhieu = 0 then hv.HoTen else case when lh.CanBoNgoaiTT <> '' or lh.CanBONgoaiTT is not null then lh.CanBoNgoaiTT else cb.HoTen end end as HoTenHocVien,SUBSTRING(Convert(varchar(12),hv.NgaySinh,102),1,4) as NamSinh,Case when bl.LoaiPhieu = 0 then hv.GioiTinh else case when lh.CanBoNgoaiTT <> '' or lh.CanBONgoaiTT is not null then lh.GioiTinh else cb.GioiTinh end end as GioiTinh,
	'' as MaSoThhue,hd.SoHoaDon as SoPhieu, case when bl.HinhThucThu = 0 then N'Tiền mặt' else N'Chuyển khoản hợp đồng' end as HinhThucThu,hv.NoiDungDaoTao as NoiDungThanhToan, N'Khóa học' as DVT,case when bl.LoaiPhieu = 0 then bv.Ten else case when lh.CanBoNgoaiTT <> '' or lh.CanBONgoaiTT is not null then ck.Ten + N' - Bệnh viện bạch mai' else N'Trung tâm chỉ đạo tuyến - Bệnh viện bạch mai' end end as TenDonVi
	, Case when hv.DiaChiNhaRieng is not null and hv.DiaChiNhaRieng <> '' then hv.DiaChiNhaRieng else hv.DiDong + ', ' + t.Ten end as DiaChi, 1 as SoLuong,bl.soTien as DonGia, bl.soTien as ThanhTien, sl.TongChiPhi from BienLai bl
	join DT_LienTuc_HocVien hv on hv.id = bl.IDHocVien
	left join DIC_Tinh t on t.ID = hv.idTinhThanh
	left join DIC_BenhVien bv on bv.ID=hv.idBenhVienCongTac
	join HoaDonCT hdct on hdct.IDBienLai = bl.IDBienLai
	join HoaDon hd on hd.IDHoaDon = hdct.IDHoaDon
	left join DT_LienTuc_LopHoc lh on lh.MaLop = hv.MaLopHoc
	left join DIC_CanBo cb on cb.ID = lh.idCanBoPhuTrach 
	left join DT_LienTuc_KhungLopHoc klh on klh.id = lh.idKhungLopHoc
	left join DIC_ChuyenKhoa ck on ck.ID = klh.idChuyenKhoa
	join (select hd.IDHoaDon,sum(SoTien) as TongChiPhi from HoaDon hd
	join HoaDonCT hdct on hdct.IDHoaDon = hd.IDHoaDon
	where IDHocVien = @IDHocVien
	group by hd.IDHoaDon) sl on sl.IDHoaDon = hd.IDHoaDon
	where bl.IDBienLai = @IDBienLai
end
GO

USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[HoaDonThanhToan_XuatHD]    Script Date: 13/08/2018 12:42:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
ALTER proc [dbo].[HoaDonThanhToan_XuatHD]
	@IDHocVien bigint
as SET NOCOUNT ON
begin
	select bl.IDHocVien,hv.MaHocVien,Case when bl.LoaiPhieu = 0 then hv.HoTen else case when lh.CanBoNgoaiTT <> '' or lh.CanBONgoaiTT is not null then lh.CanBoNgoaiTT else cb.HoTen end end as HoTenHocVien,SUBSTRING(Convert(varchar(12),hv.NgaySinh,102),1,4) as NamSinh,Case when bl.LoaiPhieu = 0 then hv.GioiTinh else case when lh.CanBoNgoaiTT <> '' or lh.CanBONgoaiTT is not null then lh.GioiTinh else cb.GioiTinh end end as GioiTinh,
	'' as MaSoThhue,hd.SoHoaDon as SoPhieu, case when bl.HinhThucThu = 0 then N'Tiền mặt' else N'Chuyển khoản hợp đồng' end as HinhThucThu,hv.NoiDungDaoTao as NoiDungThanhToan, N'Khóa học' as DVT,case when bl.LoaiPhieu = 0 then bv.Ten else case when lh.CanBoNgoaiTT <> '' or lh.CanBONgoaiTT is not null then ck.Ten + N' - Bệnh viện bạch mai' else N'Trung tâm chỉ đạo tuyến - Bệnh viện bạch mai' end end as TenDonVi
	, Case when hv.DiaChiNhaRieng is not null and hv.DiaChiNhaRieng <> '' then hv.DiaChiNhaRieng else hv.DiDong + ', ' + t.Ten end as DiaChi, 1 as SoLuong,bl.soTien as DonGia, bl.soTien as ThanhTien, sl.TongChiPhi from BienLai bl
	join DT_LienTuc_HocVien hv on hv.id = bl.IDHocVien
	left join DIC_Tinh t on t.ID = hv.idTinhThanh
	left join DIC_BenhVien bv on bv.ID = hv.idBenhVienCongTac
	join HoaDonCT hdct on hdct.IDBienLai = bl.IDBienLai
	join HoaDon hd on hd.IDHoaDon = hdct.IDHoaDon
	left join DT_LienTuc_LopHoc lh on lh.MaLop = hv.MaLopHoc
	left join DIC_CanBo cb on cb.ID = lh.idCanBoPhuTrach 
	left join DT_LienTuc_KhungLopHoc klh on klh.id = lh.idKhungLopHoc
	left join DIC_ChuyenKhoa ck on ck.ID = klh.idChuyenKhoa
	join (select hd.IDHoaDon,sum(SoTien) as TongChiPhi from HoaDon hd
	join HoaDonCT hdct on hdct.IDHoaDon = hd.IDHoaDon
	where IDHocVien = @IDHocVien and hd.IDHoaDon in (select top 1 IDHoaDon from HoaDon where IDHocVien = @IDHocVien order by IDHoaDon desc) and hdct.IDHoaDonCT <> 32
	group by hd.IDHoaDon) sl on sl.IDHoaDon = hd.IDHoaDon
	where bl.IDHocVien = @IDHocVien  and hd.IDHoaDon = (select top 1 IDHoaDon from HoaDon where IDHocVien = @IDHocVien order by IDHoaDon desc ) and hdct.TrangThai = 0 and hdct.IDHoaDonCT <> 32
end
GO
