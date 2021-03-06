USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[BienLaiTamThu_ins]    Script Date: 12/03/2018 13:35:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Modify by: Nguyen Anh Duc
--Modify date: 30/06/2009
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
@IDBienLai bigint output
as  SET NOCOUNT ON
if(exists(select 1 from BienLai where mabienlai = @Mabienlai))
begin
	raiserror ('Mã biên lai [%s] này đã tồn tại, Bạn hãy kiểm tra lại!',16,1,@mabienlai)
	return
end
declare @IDBenhNhan bigint, @strNgayKyQuy varchar(10)
set @strNgayKyQuy = convert(varchar(10), @NgayThu, 103) 
set @solan = (select count(*) + 1 from BienLai kq where kq.IDHocVien = @idHocVien)
insert into BienLai(IDHocVien,Mabienlai,Solan,Sotien,NgayThu, IDNguoiThu,TenNguoiDong,TenNguoiThu, HinhThucThu,XuatHD,SoLanIn)
values(@idHocVien,@Mabienlai,@Solan,@Sotien,@Ngaythu, @IDNguoiThu,@NguoiDong,@NguoiThu, @HinhThucThu,0,1)


set @IDBienLai = SCOPE_IDENTITY()
update BienLai set Huy=0 where IDBienLai=@IDBienLai
go




-- Thêm thủ tục thực hiện in lại biên lai cho học viên

create proc InLaiHoaDon
(
	@IDHocVien bigint,
	@IDBienLai bigint
)
	
as SET NOCOUNT ON
begin
	select bl.SoLanIn,bl.IDHocVien,hv.MaHocVien,hv.HoTen as HoTenHocVien,SUBSTRING(Convert(varchar(12),NgaySinh,102),1,4) as NamSinh,hv.GioiTinh,
	'' as MaSoThhue,hd.SoHoaDon as SoPhieu, case when bl.HinhThucThu = 0 then N'Tiền mặt' else N'Chuyển khoản hợp đồng' end as HinhThucThu,hv.NoiDungDaoTao as NoiDungThanhToan, N'Khóa học' as DVT,hv.NoiCongTac as TenDonVi
	, Case when hv.DiaChiNhaRieng is not null and hv.DiaChiNhaRieng <> '' then hv.DiaChiNhaRieng else hv.DiDong + ', ' + t.Ten end as DiaChi, 1 as SoLuong,bl.soTien as DonGia, bl.soTien as ThanhTien, sl.TongChiPhi from BienLai bl
	join DT_LienTuc_HocVien hv on hv.id = bl.IDHocVien
	left join DIC_Tinh t on t.ID = hv.idTinhThanh
	join HoaDonCT hdct on hdct.IDBienLai = bl.IDBienLai
	join HoaDon hd on hd.IDHoaDon = hdct.IDHoaDon
	join (select hd.IDHoaDon,sum(SoTien) as TongChiPhi from HoaDon hd
	join HoaDonCT hdct on hdct.IDHoaDon = hd.IDHoaDon
	where IDHocVien = @IDHocVien
	group by hd.IDHoaDon) sl on sl.IDHoaDon = hd.IDHoaDon
	where bl.IDBienLai = @IDBienLai
end
go


--- thủ tục update lại số lần in phiếu thu

ALTER PROC [dbo].[UpdateSoLanInBL]
(
	@IDBienLai BIGINT
)
AS
BEGIN
	UPDATE dbo.BienLai SET SoLanIn = (SoLanIn+1) WHERE IDBienLai = @IDBienLai
END
go



