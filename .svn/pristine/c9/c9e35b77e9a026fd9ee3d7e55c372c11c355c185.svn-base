USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[BienLaiLopHoc_Gets]    Script Date: 01/09/2018 09:21:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- thêm mới bảng giảng viên
CREATE TABLE DIC_GiangVien
(
	ID bigint IDENTITY NOT NULL,
	HoTen nvarchar(50) NULL,
	GioiTinh nvarchar(10) NULL,
	NgaySinh datetime NULL,
	IDTinh bigint NULL,
	ChoOHiennay nvarchar(max) NULL,
	QuocGia nvarchar(50) NULL,
	NgayVaoDang datetime NULL,
	IDCoQuan int NULL,
	IDChucVu int NULL,
	QTDaoTao nvarchar(max) NULL,
	QTCongTa nvarchar(max) NULL,
	KinhNghiemNN nvarchar(max) NULL,
	NghienCuuTGia nvarchar(max) NULL,
	NgoaiNguTinHoc nvarchar(max) NULL,
	KhenThuongKyLuat nvarchar(max) NULL,
	HTapNCuuNNgoai nvarchar(max) NULL,
	MaNhanVien nvarchar(10) NULL,
	MaNhanVienTheoMayCC nvarchar(10) NULL,
	DienThoai nvarchar(12) NULL,
	Email nvarchar(20) NULL,
	LoaiCanBo int NULL,
	DanToc nvarchar(15) NULL,
	SoCMT nvarchar(10) NULL,
	NgayCap datetime NULL,
	NoiCap nvarchar(30) NULL,
	GhiChu nvarchar(max) NULL,
	idChuyenNganh int NULL,
	idChuyenKhoa int NULL,
	idHocHam int NULL,
	IDTrinhDo int NULL,
	ChungChi nvarchar(50) NULL,
	NamBatDau int NULL,
	FOREIGN KEY (IDChucVu)
 REFERENCES  DIC_ChucVu (ID),
	)

go

create PROCEDURE [dbo].[DIC_GiangVien_add]
 (   @ID bigint OUTPUT,
    @HoTen nvarchar(50),
    @GioiTinh nvarchar(10),
    @NgaySinh datetime,
    @IDTinh bigint,
    @ChoOHiennay nvarchar(MAX),
    @QuocGia nvarchar(50),
    @NgayVaoDang datetime,
   
    @IDCoQuan int,
    @IDChucVu int,
    @QTDaoTao nvarchar(MAX),
    @QTCongTac nvarchar(MAX),
    @KinhNghiemNN nvarchar(MAX),
    @NghienCuuTGia nvarchar(MAX),
    @NgoaiNguTinHoc nvarchar(MAX),
    @KhenThuongKyLuat nvarchar(MAX),
    @HTapNCuuNNgoai nvarchar(MAX),
   -- @IDBoPhan int,
    @MaNhanVien nvarchar(10),
    @MaNhanVienTheoMayCC nvarchar(10),
    @DienThoai nvarchar(12),
    @Email nvarchar(20),
    @LoaiCanBo int,
    @DanToc nvarchar(15),
    @SoCMT nvarchar(20),
    @NgayCap datetime,
    @NoiCap nvarchar(MAX),
    @GhiChu nvarchar(MAX),
    @idChuyenNganh int,
    @idChuyenKhoa int,
	@idHocHam int, @IDTrinhDo int,
	@ChungChi nvarchar(50),
	@NamBatDau int 
	)
	as
	begin
	declare @strNgaySinh varchar(10),@strNgayVaoDang varchar(10),@strNgayCap varchar(10)
	set @strNgaySinh=CONVERT(varchar(10),@NgaySinh,103)
	set @strNgayVaoDang=CONVERT(varchar(10),@NgayVaoDang,103)
	set @strNgayCap=CONVERT(varchar(10),@NgayCap,103)
	set nocount on
	 INSERT INTO DIC_GiangVien
	(HoTen,
	NgaySinh,
	GioiTinh,
	IDTinh,
	ChoOHiennay,
	QuocGia,
	NgayVaoDang,
	IDCoQuan,
	IDChucVu,
	QTDaoTao,
	QTCongTa,
	KinhNghiemNN,
	NghienCuuTGia,
	NgoaiNguTinHoc,
    KhenThuongKyLuat,
    HTapNCuuNNgoai,
  --  IDBoPhan,
    MaNhanVien,
    MaNhanVienTheoMayCC,
    DienThoai,
	Email,
    LoaiCanBo,
    DanToc,
    SoCMT,
    NgayCap,
    NoiCap,
    GhiChu,
    idChuyenNganh,
	idChuyenKhoa,
	 idHocHam,
	IDTrinhDo,
	ChungChi,NamBatDau
	)
	VALUES
	( @HoTen ,
    
    @strNgaySinh ,
	@GioiTinh ,
    @IDTinh ,
    @ChoOHiennay ,
    @QuocGia ,
    @strNgayVaoDang ,
    
    @IDCoQuan ,
    @IDChucVu ,
    @QTDaoTao ,
    @QTCongTac ,
    @KinhNghiemNN ,
    @NghienCuuTGia ,
    @NgoaiNguTinHoc,
    @KhenThuongKyLuat ,
    @HTapNCuuNNgoai ,
  --  @IDBoPhan ,
    @MaNhanVien ,
    @MaNhanVienTheoMayCC ,
    @DienThoai ,
    @Email ,
    @LoaiCanBo ,
    @DanToc,
    @SoCMT ,
    @strNgayCap ,
    @NoiCap ,
    @GhiChu ,
    @idChuyenNganh ,
    @idChuyenKhoa ,
	@idHocHam ,
	@IDTrinhDo,@ChungChi,@NamBatDau
	)
	SET @ID = SCOPE_IDENTITY()
	end

	go


	---
	create proc [dbo].[DIC_GiangVien_Coll_Get]
as
set nocount on
begin
select gv.ID,gv.HoTen,gv.GioiTinh,gv.NgaySinh,gv.IDTinh,gv.ChoOHiennay,gv.QuocGia,gv.NgayVaoDang,gv.IDCoQuan,gv.IDChucVu,gv.QTDaoTao,gv.QTCongTa,gv.KinhNghiemNN,
gv.NghienCuuTGia,gv.NgoaiNguTinHoc,gv.KhenThuongKyLuat,gv.HTapNCuuNNgoai,gv.MaNhanVien,gv.MaNhanVienTheoMayCC,gv.DienThoai,gv.Email,gv.LoaiCanBo,gv.DanToc,gv.SoCMT,
gv.NgayCap,gv.NoiCap,gv.GhiChu,gv.idChuyenNganh,gv.idChuyenKhoa,gv.idHocHam,gv.IDTrinhDo,gv.ChungChi,gv.NamBatDau,
cn.Ten as TenChuyenNganh ,
hh.TenHocHam,
hv.TenHocVi,
cv.Ten as TenChucVu,
t.Ten as TenTinhThanh,
ck.Ten as ChuyenKhoa
from DIC_GiangVien gv
left  join DIC_HocVi hv on hv.ID=gv.idtrinhdo
left join DIC_ChucVu cv on cv.ID=gv.IDChucVu
left join DIC_HocHam hh on hh.ID=gv.idHocHam
left join DIC_ChuyenNganh cn on cn.ID=gv.idChuyenNganh
left join DIC_Tinh t on t.ID=gv.IDTinh
left join DIC_ChuyenKhoa ck on ck.ID=gv.idChuyenKhoa

end


go


create PROCEDURE [dbo].[DIC_GiangVien_delete]
    @ID bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT ID FROM DIC_GiangVien
            WHERE
                ID = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_GiangVien'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete DIC_CanBo object from DIC_CanBo */
        DELETE
        FROM DIC_GiangVien
        WHERE
            DIC_GiangVien.ID = @ID

    END

	go

	create proc [dbo].[DIC_GiangVien_Get]
(
@ID bigint)
as
set nocount on
begin
select ID,HoTen,GioiTinh,NgaySinh,IDTinh,ChoOHiennay,QuocGia,NgayVaoDang,IDCoQuan,IDChucVu,QTDaoTao,QTCongTa,KinhNghiemNN,NghienCuuTGia
,NgoaiNguTinHoc,KhenThuongKyLuat,HTapNCuuNNgoai,MaNhanVien,MaNhanVienTheoMayCC,DienThoai,Email,LoaiCanBo,DanToc,SoCMT,NgayCap,NoiCap,
GhiChu,idChuyenNganh,idChuyenKhoa,idHocHam,IDTrinhDo,ChungChi,NamBatDau from DIC_GiangVien where ID=@ID
end

go

create PROCEDURE [dbo].[DIC_GiangVien_Info_add]
 (   @ID bigint OUTPUT,
    @HoTen nvarchar(50),
    @GioiTinh nvarchar(10),
    @NgaySinh datetime,
    @IDTinh bigint,
    @ChoOHiennay nvarchar(MAX),
    @QuocGia nvarchar(50),
    @NgayVaoDang datetime,
    @IDTrinhDo int,
    @IDCoQuan int,
    @IDChucVu int,
    @QTDaoTao nvarchar(MAX),
    @QTCongTac nvarchar(MAX),
    @KinhNghiemNN nvarchar(MAX),
    @NghienCuuTGia nvarchar(MAX),
    @NgoaiNguTinHoc nvarchar(MAX),
    @KhenThuongKyLuat nvarchar(MAX),
    @HTapNCuuNNgoai nvarchar(MAX),
   -- @IDBoPhan int,
    @MaNhanVien nvarchar(10),
    @MaNhanVienTheoMayCC nvarchar(10),
    @DienThoai nvarchar(12),
    @Email nvarchar(20),
    @LoaiCanBo int,
    @DanToc nvarchar(15),
    @SoCMT nvarchar(20),
    @NgayCap datetime,
    @NoiCap nvarchar(MAX),
    @GhiChu nvarchar(MAX),
    @idChuyenNganh int,
    @idChuyenKhoa int,
	@idHocHam int
	)
	as
	begin
	set nocount on
	 INSERT INTO DIC_GiangVien
	(HoTen,
	NgaySinh,
	GioiTinh,
	IDTinh,
	ChoOHiennay,
	QuocGia,
	NgayVaoDang,
	IDCoQuan,
	IDChucVu,
	QTDaoTao,
	QTCongTa,
	KinhNghiemNN,
	NghienCuuTGia,
	NgoaiNguTinHoc,
    KhenThuongKyLuat,
    HTapNCuuNNgoai,
   -- IDBoPhan,
    MaNhanVien,
    MaNhanVienTheoMayCC,
    DienThoai,
	Email,
    LoaiCanBo,
    DanToc,
    SoCMT,
    NgayCap,
    NoiCap,
    GhiChu,
    idChuyenNganh,
    idHocHam,
	idChuyenKhoa,
	IDTrinhDo
	)
	VALUES
	( @HoTen ,
    @GioiTinh ,
    @NgaySinh ,
    @IDTinh ,
    @ChoOHiennay ,
    @QuocGia ,
    @NgayVaoDang ,
    @IDTrinhDo ,
    @IDCoQuan ,
    @IDChucVu ,
    @QTDaoTao ,
    @QTCongTac ,
    @KinhNghiemNN ,
    @NghienCuuTGia ,
    @NgoaiNguTinHoc,
    @KhenThuongKyLuat ,
    @HTapNCuuNNgoai ,
   -- @IDBoPhan ,
    @MaNhanVien ,
    @MaNhanVienTheoMayCC ,
    @DienThoai ,
    @Email ,
    @LoaiCanBo ,
    @DanToc,
    @SoCMT ,
    @NgayCap ,
    @NoiCap ,
    @GhiChu ,
    @idChuyenNganh ,
    @idChuyenKhoa ,
	@idHocHam 
	)
	SET @ID = SCOPE_IDENTITY()
	end

	go

	create PROCEDURE [dbo].[DIC_GiangVien_Info_delete]
    @ID bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT ID FROM DIC_GiangVien
            WHERE
                ID = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_GiangVien'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete DIC_CanBo object from DIC_CanBo */
        DELETE
        FROM DIC_GiangVien
        WHERE
            DIC_GiangVien.ID = @ID

    END

	go

	create PROCEDURE [dbo].[DIC_GiangVien_Info_update]
 (   @ID bigint OUTPUT,
    @HoTen nvarchar(50),
    @GioiTinh nvarchar(10),
    @NgaySinh datetime,
    @IDTinh bigint,
    @ChoOHiennay nvarchar(MAX),
    @QuocGia nvarchar(50),
    @NgayVaoDang datetime,
    @IDTrinhDo int,
    @IDCoQuan int,
    @IDChucVu int,
    @QTDaoTao nvarchar(MAX),
    @QTCongTac nvarchar(MAX),
    @KinhNghiemNN nvarchar(MAX),
    @NghienCuuTGia nvarchar(MAX),
    @NgoaiNguTinHoc nvarchar(MAX),
    @KhenThuongKyLuat nvarchar(MAX),
    @HTapNCuuNNgoai nvarchar(MAX),
  --  @IDBoPhan int,
    @MaNhanVien nvarchar(10),
    @MaNhanVienTheoMayCC nvarchar(10),
    @DienThoai nvarchar(12),
    @Email nvarchar(20),
    @LoaiCanBo int,
    @DanToc nvarchar(15),
    @SoCMT nvarchar(20),
    @NgayCap datetime,
    @NoiCap nvarchar(MAX),
    @GhiChu nvarchar(MAX),
    @idChuyenNganh int,
    @idChuyenKhoa int,
	@idHocHam int
	)
	as
	begin
	set nocount on
	IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_GiangVien]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_GiangVien'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
			end
	 update  DIC_GiangVien
	 set
	HoTen=@HoTen,
	NgaySinh=@NgaySinh,
	GioiTinh=@GioiTinh,
	IDTinh=@IDTinh,
	ChoOHiennay=@ChoOHiennay,
	QuocGia=@QuocGia,
	NgayVaoDang=@NgayVaoDang,
	IDCoQuan=@IDCoQuan,
	IDChucVu=@IDChucVu,
	QTDaoTao=@QTDaoTao,
	QTCongTa=@QTCongTac,
	KinhNghiemNN=@KinhNghiemNN,
	NghienCuuTGia=@NghienCuuTGia,
	NgoaiNguTinHoc=@NgoaiNguTinHoc,
    KhenThuongKyLuat=@KhenThuongKyLuat,
    HTapNCuuNNgoai=@HTapNCuuNNgoai,
    --IDBoPhan=@IDBoPhan,
    MaNhanVien=@MaNhanVien,
    MaNhanVienTheoMayCC=@MaNhanVienTheoMayCC,
    DienThoai=@DienThoai,
	Email=@Email,
    LoaiCanBo=@LoaiCanBo,
    DanToc=@DanToc,
    SoCMT=@SoCMT,
    NgayCap=@NgayCap,
    NoiCap=@NoiCap,
    GhiChu=@GhiChu,
    idChuyenNganh=@idChuyenNganh,
    idHocHam=@idHocHam,
	idChuyenKhoa=@idChuyenKhoa,
	IDTrinhDo=@IDTrinhDo
	where ID=@ID		
	end

	go

	creaTE PROCEDURE [dbo].[DIC_GiangVien_update]
 (   @ID bigint OUTPUT,
    @HoTen nvarchar(50),
    @GioiTinh nvarchar(10),
    @NgaySinh datetime,
    @IDTinh bigint,
    @ChoOHiennay nvarchar(MAX),
    @QuocGia nvarchar(50),
    @NgayVaoDang datetime,

    @IDCoQuan int,
    @IDChucVu int,
    @QTDaoTao nvarchar(MAX),
    @QTCongTac nvarchar(MAX),
    @KinhNghiemNN nvarchar(MAX),
    @NghienCuuTGia nvarchar(MAX),
    @NgoaiNguTinHoc nvarchar(MAX),
    @KhenThuongKyLuat nvarchar(MAX),
    @HTapNCuuNNgoai nvarchar(MAX),
  --  @IDBoPhan int,
    @MaNhanVien nvarchar(10),
    @MaNhanVienTheoMayCC nvarchar(10),
    @DienThoai nvarchar(12),
    @Email nvarchar(20),
    @LoaiCanBo int,
    @DanToc nvarchar(15),
    @SoCMT nvarchar(20),
    @NgayCap datetime,
    @NoiCap nvarchar(MAX),
    @GhiChu nvarchar(MAX),
    @idChuyenNganh int,
    @idChuyenKhoa int,
	@idHocHam int,    @IDTrinhDo int,@ChungChi nvarchar(50),@NamBatDau int
	)
	as
	begin
	set nocount on
	IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_GiangVien]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_GiangVien'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
			end
	 update  DIC_GiangVien
	 set
	HoTen=@HoTen,
	GioiTinh=@GioiTinh,
	NgaySinh=@NgaySinh,
	IDTinh=@IDTinh,
	ChoOHiennay=@ChoOHiennay,
	QuocGia=@QuocGia,
	NgayVaoDang=@NgayVaoDang,
	IDCoQuan=@IDCoQuan,
	IDChucVu=@IDChucVu,
	QTDaoTao=@QTDaoTao,
	QTCongTa=@QTCongTac,
	KinhNghiemNN=@KinhNghiemNN,
	NghienCuuTGia=@NghienCuuTGia,
	NgoaiNguTinHoc=@NgoaiNguTinHoc,
    KhenThuongKyLuat=@KhenThuongKyLuat,
    HTapNCuuNNgoai=@HTapNCuuNNgoai,
    --IDBoPhan=@IDBoPhan,
    MaNhanVien=@MaNhanVien,
    MaNhanVienTheoMayCC=@MaNhanVienTheoMayCC,
    DienThoai=@DienThoai,
	Email=@Email,
    LoaiCanBo=@LoaiCanBo,
    DanToc=@DanToc,
    SoCMT=@SoCMT,
    NgayCap=@NgayCap,
    NoiCap=@NoiCap,
    GhiChu=@GhiChu,
    idChuyenNganh=@idChuyenNganh,
   
	idChuyenKhoa=@idChuyenKhoa,
	 idHocHam=@idHocHam,
	IDTrinhDo=@IDTrinhDo,
	ChungChi=@ChungChi,
	NamBatDau=@NamBatDau
	where ID=@ID		
	end

	GO

	-- thủ tục lấy ra danh sách giagr viên

	create proc [dbo].[BC_DanhSachGiangVien]
(@ID nvarchar(max))
as
set nocount on
declare @Sql varchar(max)   
begin
set @Sql='
select gv.HoTen,CONVERT(varchar(10), gv.NgaySinh,101) NgaySinh,hh.TenHocHam as HoHamCaoNhat,hv.TenHocVi as HocViCaoNhat,cn.Ten as ChuyenNganh,cv.Ten as ChucVu,CONVERT(varchar(4),gv.NamBatDau) NamBatDau,gv.ChungChi,ck.Ten as ChuyenKhoa from DIC_GiangVien gv
left join DIC_HocHam hh on hh.ID=gv.idHocHam
left join DIC_HocVi hv on hv.ID=gv.IDTrinhDo
left join DIC_ChucVu cv on cv.ID=gv.IDChucVu
left join DIC_ChuyenNganh cn on cn.ID=gv.idChuyenNganh
left join DIC_ChuyenKhoa ck on ck.ID=GV.idChuyenKhoa where gv.ID in('+@ID+')'
exec(@Sql)
end

go

-- thủ tục lấy ra danh sách học viên chưa đóng học phí
create proc [dbo].[BC_HocVienChuaDongHocPhi]
(@TuNgay datetime,
@DenNgay datetime
)
as
set nocount on
-- thủ tục lấy ra danh sách học viên chưa đóng học phí
--createby : thucnt
--createdate: 23/10/2018
declare @strTuNgay varchar(10)
declare @strDenNgay varchar(10)

set @strTuNgay=CONVERT(varchar(10),@TuNgay,102)
set @strDenNgay=CONVERT(varchar(10),@DenNgay,102)

begin
select c.HinhThucHoc,
       c.MaHocVien as MaHoVien,
       c.HoTen,
       c.NoiDung,
       c.ChuyenKhoa,
       c.SoTienDaDong as SoTienDongLan1,
       c.NgayThu as NgaThangNam,
       c.MaBienLai,c.SoTienConLai 
      from (
      select b.HinhThucHoc,
      b.MaHocVien,
      b.HoTen,
      b.NoiDung,
      b.ChuyenKhoa,
      b.SoTienDaDong,
     b.NgayThu ,
     b.MaBienLai,
     isnull(b.TongHocPhi,0) - isnull(b.SoTienDaDong,0) as SoTienConLai,
     b.id,
     b.NgayBatDau
       from
     (
    select distinct 
    bl.IDBienLai,
    a.HinhThucHoc,
    a.MaHocVien,
    a.HoTen,
    a.NoiDung,
    a.ChuyenKhoa,
   case when bl.IDBienLai is null and bl.IDBienLai='' then 0 
   else 
    (select distinct CONVERT(bigint,  sum(isnull(bl.soTien,0) - isnull(hbl.SoTien,0))  )  
    from BienLai bl 
    left join HuyBienLai hbl on hbl.IDBienLai=bl.IDBienLai  
    where bl.IDHocVien=id and bl.LoaiPhieu=0   
	group by bl.IDHocVien  ) 
	end as SoTienDaDong 
	,bl.NgayThu,
	bl.MaBienLai ,
	a.TongHocPhi,
	ID ,
	a.NgayBatDau
	from
	(  
	select distinct 
	TRY_PARSE(hv.TongHocPhi as bigint) as TongHocPhi,
	klh.TenLop as NoiDung,
	ck.Ten as ChuyenKhoa,
	hv.HinhThucHoc,hv.MaHocVien,
	hv.HoTen,
	hv.id,
	hv.NgayBatDau
    from DT_LienTuc_HocVien hv
   left  join DT_LienTuc_KhungLopHoc klh on klh.id=hv.idKhungLopHoc
   left  join DIC_ChuyenKhoa ck on ck.ID=klh.idChuyenKhoa
   )a
   left  join BienLai bl on bl.IDHocVien=a.id 
   left join HuyBienLai hbl on hbl.IDBienLai=bl.IDBienLai 
   where hbl.IDBienLai is null and LoaiPhieu=0 or LoaiPhieu is null 
   )b
   )c 
   where c.SoTienConLai>0 and c.NgayBatDau between @strTuNgay and @strDenNgay
--order by id asc
end

go

-- sửa thủ tục DT_LienTuc_HocVien_get thêm trường số tiền vào mục đích để tính toán lại những học viên nào đã đóng học phí hết và còn một số học viên chưa đóng học phí

ALTER PROCEDURE [dbo].[DT_LienTuc_HocVien_get]
    @id int
AS
    BEGIN
	declare @SoTien bigint
	set @SoTien=(select CONVERT(bigint,  sum(isnull(bl.soTien,0))  )  from BienLai bl 
    left join HuyBienLai hbl on hbl.IDBienLai=bl.IDBienLai
    where bl.IDHocVien=@id and LoaiPhieu=0 and hbl.IDBienLai is null)
        SET NOCOUNT ON

        /* Get DT_LienTuc_HocVien from table */
        SELECT
    --      *,(select CONVERT(bigint,  sum(isnull(bl.soTien,0) - isnull(hbl.SoTien,0))  )  from BienLai bl 
    -- left join HuyBienLai hbl on hbl.IDBienLai=bl.IDBienLai
    --where bl.IDHocVien=id
    --group by bl.IDHocVien ) as SoTien
	*,@SoTien as SoTien
    FROM [dbo].DT_View_LienTuc_HocVien
        WHERE
            [dbo].DT_View_LienTuc_HocVien.[id] = @id

    END

	--  update lại trường hợp tự động chuyển trạng thái học viên

	ALTER PROCEDURE [dbo].[DT_LienTuc_HocVien_Coll_getByNguoiQuanLyWithGridView] @Nam INT,
    @BoPhan INT
AS
    BEGIN
	DECLARE @NgayHienTai datetime
	declare @DenNgay nvarchar(10)
	set @NgayHienTai=(select  GETDATE())

        SET NOCOUNT ON

        /* Get DT_LienTuc_HocVien_Info from table */
        IF ( @Nam <> 0 )
            BEGIN
                IF ( @BoPhan <> 0 )
                    BEGIN
                        SELECT  *
                        FROM    [dbo].DT_View_LienTuc_HocVien
                        WHERE   IdBoPhan = @BoPhan
                                AND YEAR(NgayBatDau) = @Nam 	
								
                    END
                ELSE
                    BEGIN
                        SELECT  *
                        FROM    [dbo].DT_View_LienTuc_HocVien
                        WHERE   YEAR(NgayBatDau) = @Nam
                    END 
			
            END
		
				
        ELSE
            IF ( @BoPhan <> 0 )
                BEGIN
                    SELECT  *
                    FROM    [dbo].DT_View_LienTuc_HocVien
                    WHERE   @BoPhan = IdBoPhan	
                END
            ELSE
                BEGIN
                    SELECT  *
                    FROM    [dbo].DT_View_LienTuc_HocVien
                END
	update DT_LienTuc_HocVien set TrangThai=N'Kết thúc - Chưa cấp chứng chỉ' where @NgayHienTai>NgayKetThuc and TrangThai<>N'Kết thúc - Đã cấp chứng chỉ' and  MaHocVien is not null and MaHocVien<>''
	update DT_LienTuc_HocVien set TrangThai=N'Thôi học, đã trả lại học phí' where id in 
	(  select IDHocVien from HuyBienLai where IDHocVien not in 
	(select bl.IDHocVien from BienLai bl join HuyBienLai hbl on hbl.IDHocVien=bl.IDHocVien 
	where bl.IDBienLai<>hbl.IDBienLai and LoaiPhieu=0))
    END

	go
