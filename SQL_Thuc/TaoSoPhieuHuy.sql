USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[BienLaiTamThu_ins]    Script Date: 12/03/2018 13:35:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--CREATE BY: thucnt tao so phieu huy 
--define: 15/03/2018
-- HPSYSMAN2018-00001
create function [dbo].[fn_TaoSoPhieuHuy](@year varchar(10),@user nvarchar(30))
returns varchar(14)
as 
begin
/* tim ra gia tri mã cua so phieu 
neu la max=999999 thi tang so dau [AA] ->[AB],(tang ky tu thu 2 tu A->Z)
khi ky tu thu 2 tang den Z thu tang ky tu dau [A] - [Z]
*/
   declare @ID nvarchar(2)
   declare @dem int
	declare @tmSoBLT varchar(14)
	declare @prefix varchar(5),@sprefix varchar(2), @eprefix varchar(2);
	set @ID='HP'
	set @prefix=UPPER(substring(@user,charindex('_',@user) +1,5))
	select @dem=isnull(max(Convert(bigint,SubString(SoPhieuHuy,10,5))),0)+1 from HuyBienLai where   substring(SoPhieuHuy,1,9)=@ID + @prefix+ substring(convert(varchar(4),@year),3,2)
		--TuanLM: nếu muốn SoBL tự tăng: select @dem=isnull(max(cast(substring(MaBienLai,5,5) as decimal(5))),0)+1 from IP_KyQuy where   substring(MaBienLai,1,4)=@prefix+ substring(convert(varchar(4),@year),3,2)
	if @dem=100000 
	Begin
		if substring(@prefix,2,1)>=substring(@sprefix,2,1) 
		and substring(@prefix,2,1)<=substring(@eprefix,2,1)
		and substring(@prefix,1,1)>=substring(@sprefix,1,1) 
		and substring(@prefix,1,1)<=substring(@eprefix,1,1)
		Begin
			if substring(@prefix,2,1)=substring(@eprefix,2,1)
			Begin
				if substring(@prefix,1,1)=substring(@eprefix,1,1)
					set @prefix=@eprefix
				else
					set @prefix=char(ascii(substring(@prefix,1,1))+1) + substring(@sprefix,2,1)
			End
			else
			set @prefix=substring(@prefix,1,1) + char(ascii(substring(@prefix,2,1))+1)
		End
		else
		set @prefix = '16'
		set @dem=1
	End
	select @tmSoBLT=case len(@dem)
		when 1 then	'0000'
		when 2 then 	'000'
		when 3 then 	'00'
		when 4 then 	'0'
		when 5 then       ''
		end  
	set @tmSoBLT=@ID + @prefix +substring(convert(varchar(4),@year),3,2) + @tmSoBLT + convert(varchar,@dem)
	return @tmSoBLT
	end

	go

-- tao so phieu phieu huy khi insert vao thu tuc HuyBienLai_ins
create proc [dbo].[HuyBienLai_ins]

@IDHocVien int,
@IDBienLai bigint,
@SoPhieuHuy nvarchar(30),
@SoTien decimal(10,0),
@NgayHuy datetime,
@IDNguoiHuy bigint,
@NguoiNhan nvarchar(50),
@LyDoHuy nvarchar(50),
@TrangThai int
as SET NOCOUNT ON
---set @SoPhieuHuy=dbo.fn_TaoSoPhieuHuy( year(SYSDATETIME()))
if(exists(select 1 from BienLai bl left join HuyBienLai hbl on bl.IDBienLai = hbl.IDBienLai where bl.Huy=1 and   bl.IDHocVien = @IDHocVien))

	
	declare @User nvarchar(50)
	select @User=n.TenDangNhap from ADM_NguoiDung n  where n.IDNguoiDung=@IDNguoiHuy
	declare  @strNgayHuy varchar(10)
	set @strNgayHuy = convert(varchar(10), @NgayHuy, 102) 
	set @strNgayHuy = REPLACE(@strNgayHuy,'.', '')
	set @SoPhieuHuy = dbo.fn_TaoSoPhieuHuy(@strNgayHuy,@User)
Insert into HuyBienLai(IDHocVien,IDBienLai,SoPhieuHuy,SoTien,NgayHuy,IDNguoiHuy,NguoiNhan,LyDoHuy,TrangThai) values (@IDHocVien,@IDBienLai,@SoPhieuHuy,@SoTien,@NgayHuy,@IDNguoiHuy,@NguoiNhan,@LyDoHuy,@TrangThai)

update BienLai set Huy = 1 where IDBienLai = @IDBienLai

go


