USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[BC_HuyBienLairpt]    Script Date: 19/01/2018 10:28:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- báo cáo huỷ biên lai
create proc [dbo].[BC_HuyBienLairpt]
(@TuNgay datetime,
@DenNgay datetime,
@DieuKien int,
@IdNguoiDung bigint

)
as
begin
    DECLARE @strTuNgay varchar(10)
	DECLARE @strDenNgay varchar(19)
          SET @strTuNgay  = Convert(varchar(10),@TuNgay,101) + '00:00:00'
        SET @strDenNgay = Convert(varchar(10),@DenNgay,101)+ ' 23:59:00.000'
			
   select convert(date,hbl.NgayHuy,103) as NgayHuy,(bl.MaBienLai) as SoBienLai,hbl.SoPhieuHuy,hbl.LyDoHuy,n.TenDayDu as NguoiHuy ,convert(int,hbl.soTien) as SoTien
	from HuyBienLai hbl
	left   join BienLai bl on bl.IDBienLai=hbl.IDBienLai
    left   join ADM_NguoiDung n on (hbl.IDNguoiHuy=n.IDNguoiDung)
	where 
	(@DieuKien =1 and hbl.NgayHuy between @strTuNgay and @strDenNgay and @IdNguoiDung=hbl.IDNguoiHuy
	or @DieuKien=2 and hbl.NgayHuy between @strTuNgay and @strDenNgay 
	 )
	order by bl.MaBienLai,hbl.NgayHuy asc
	end
	go

	-- phiếu yêu cầu hoàn học phi

create proc [dbo].[BaoCaoHoanTienHocPhirpt]
(
@IDHocVien bigint
)
as
begin 
		 SELECT DISTINCT hv.HoTen as HoTenHocVien ,hv.MaHocVien as MaTiepNhan, hv.TenBenhVien as NoiCongTac, convert(datetime,hv.NgayBatDau,103) as NgayNhapHoc,
		 hv.TenChuyenKhoaLopHoc as DangKyVienKhoaPhong,  hv.NoiDungDaoTao as NoiDungHoc,kl.TenLop  as TenLopDaoTao, Case when hv.DiaChiNhaRieng is not null and hv.DiaChiNhaRieng <>
		 '' then hv.DiaChiNhaRieng else + ' ' + t.Ten end as DiaChi,hv.DiDong as SoDienThoai,	 bl.soTien as SoTien,	CONVERT(date,bl.NgayThu,103) as NgayThu , bl.MaBienLai as SoBienLai
		  from DT_View_LienTuc_HocVien hv
		 left join BienLai bl on bl.IDHocVien=hv.id
	     left join DT_LienTuc_KhungLopHoc kl on kl.id=hv.idKhungLopHoc
		 left join DIC_Tinh t on t.ID=hv.idTinhThanh
         where hv.id=@IDHocVien
		 
		 end
		 go





