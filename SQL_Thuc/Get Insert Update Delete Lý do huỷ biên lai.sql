USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[LyDoHuy_Coll_Get]    Script Date: 13/02/2018 11:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- get lý do huỷ biên lai
create proc [dbo].[LyDoHuy_Coll_Get]
as SET NOCOUNT ON
select 
	IDHuy,LyDoHuy
 from LyDoHuyBienLai

 go

 -- insert lý do huỷ biên lai
 create proc [dbo].[LyDoHuyBienLai_ins]


@LyDoHuy nvarchar(max)

as  SET NOCOUNT ON

insert into LyDoHuyBienLai(LyDoHuy) values(@LyDoHuy)

go
-- update lý do huỷ biên lai

create proc [dbo].[LyDoHuyBienLai_update]
@IDHuy bigint,
@LyDoHuy nvarchar(max)
as set NOCOUNT ON
begin
update LyDoHuyBienLai set LyDoHuy=@LyDoHuy where IDHuy=@IDHuy
end
go

-- delete lý do huỷ biên lai
create PROCEDURE [dbo].[LyDoHuyBienLai_delete]
    @IDHuy bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT IDHuy FROM LyDoHuyBienLai
            WHERE
               IDHuy = @IDHuy
        )
        BEGIN
            RAISERROR ('''dbo.LyDoHuyBienLai'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete dbo.LyDoHuyBienLai object from dbo.LyDoHuyBienLai*/
        DELETE
        FROM LyDoHuyBienLai
        WHERE
         LyDoHuyBienLai.IDHuy=@IDHuy

    END


go


--- thêm id phiếu huỷ vào dbo.BIenLaiTamThu_Gets
create proc [dbo].[BienLaiTamThu_Gets]
@IDBienLai bigint
as SET NOCOUNT ON
select 
	bl.IDBienLai,
	bl.MaBienLai,
	Convert(bigint,bl.IDHocVien) as IDHocVien,
	bl.SoLan,
	bl.SoTien,
	Convert(Date,bl.NgayThu) as NgayThu,
	bl.TenNguoiThu,
	bl.IDNguoiThu,
	bl.TenNguoiDong,
	bl.HinhThucThu,
	bl.XuatHD,
	bl.Huy,
	hbl.IDPhieuHuy 
 from BienLai bl
left  join HuyBienLai hbl on hbl.IDBienLai=bl.IDBienLai
 WHERE bl.IDBienLai = @IDBienLai

  go

  -- insert dữ liệu hoàn biên lai đã huỷ vào bảng dbo.HoanTamThu_ins
create proc [dbo].[HoanTamThu_ins]
--@IDPhieuHoan bigint output,
@IDHocVien bigint,
@SoPhieuHoan varchar(12),
@SoTien numeric,
@NgayHoan datetime,
@NguoiNhan nvarchar(50),
@IDNguoiHoan bigint,
@IDPhieuHuy bigint,
@IDBienLai bigint
as  SET NOCOUNT ON

begin
	insert into HoanTamThu(IDHocVien, SoPhieuHoan, SoTien, NgayHoan, IDNguoiHoan, NguoiNhan,IDPhieuHuy)
	values(@IDHocVien, @SoPhieuHoan, @SoTien, @NgayHoan, @IDNguoiHoan, @NguoiNhan,@IDPhieuHuy)
	--set @IDPhieuHoan = SCOPE_IDENTITY()

   update BienLai set Huy =0 where IDBienLai=@IDBienLai
end
go