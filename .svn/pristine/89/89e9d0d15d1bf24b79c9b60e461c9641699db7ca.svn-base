USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[BaoCaoHoanTienHocPhirpt]    Script Date: 26/04/2018 13:26:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	-- phiếu yêu cầu hoàn học phi

ALTER proc [dbo].[BaoCaoHoanTienHocPhirpt]
(
@IDBienLai varchar(max) 
)
as

begin 
declare @Sql varchar(max)   

select @Sql=' SELECT DISTINCT   Row_number() over(order by HoTen) STT   , hv.HoTen as HoTenHocVien ,hv.MaHocVien as MaTiepNhan, bv.Ten as NoiCongTac, convert(nvarchar(10),hv.NgayBatDau,103) as NgayNhapHoc,
		ck.Ten as DangKyVienKhoaPhong,  hv.NoiDungDaoTao as NoiDungHoc,kl.TenLop  as TenLopDaoTao,t.Ten  as DiaChi,hv.DiDong as SoDienThoai, bl.soTien as SoTien,	CONVERT(nvarchar(10),bl.NgayThu,103) as NgayThu 
		, bl.MaBienLai as SoBienLai,hd.SoHoaDon
		  from DT_LienTuc_HocVien hv
		 left join BienLai bl on bl.IDHocVien=hv.id		 
	     left join DT_LienTuc_KhungLopHoc kl on kl.id=hv.idKhungLopHoc
		 left join DIC_ChuyenKhoa ck on kl.idChuyenKhoa=ck.ID
		 left join DIC_BenhVien bv on bv.ID=hv.idBenhVienCongTac
		 left join DIC_Tinh t on t.ID=hv.idTinhThanh
		 left join HoaDonCT hdct on hdct.IDBienLai=bl.IDBienLai
		 left join HoaDon hd on hd.IDHoaDon=hdct.IDHoaDon
         where bl.IDBienLai IN(' +@IDBienLai+')  and bl.Huy=('+CONVERT(varchar(1),0)+') '
		exec(@Sql)

		 end
	
	--exec BaoCaoHoanTienHocPhirpt @IDBienLai=N'10191', @IDBienLai=N'10192'
	-- exec BaoCaoHoanTienHocPhirpt '10191,10192'