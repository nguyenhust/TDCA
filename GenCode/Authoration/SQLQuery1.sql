
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
 *create by: TUYLV
 *create date: 23-12-2013
 *purpose: Tạo bảng phân hệ. Ví dụ như: đào tạo, truyền thông ... 
 */
 CREATE TABLE [dbo].[ADM_PhanHe](
	[ID] INT IDENTITY(1,1) NOT NULL,
	[Ma] VARCHAR(10) NOT NULL, 
	[TenPhanHe] [nvarchar](100) NOT NULL,
	[MoTa] [nvarchar](200) NULL,
	PRIMARY KEY(ID))
GO
/*
 *create by:TUYLV
 *create date: 23-12-2013
 *purpose: Nhóm chức năng. có thể người dùng  tự định nghĩa nhóm chức năng cho mình 
 */ 
CREATE TABLE [dbo].[ADM_NhomChucNang](
	[ID] INT IDENTITY(1,1) NOT NULL,
	[Ma] VARCHAR(10) NOT NULL,
	[IDPhanHe] INT NOT NULL,
	[TenNhomCN] [nvarchar](100) NOT NULL,
	PRIMARY KEY(ID), FOREIGN KEY(IDPhanHe) REFERENCES ADM_PhanHe(ID)
)
GO
/*
 * create by: TUYLV
 * create date: 23-12-2013
 * purpose: Chức năng của hệ thống
 */
CREATE TABLE [dbo].[ADM_ChucNang](
	[ID] INT IDENTITY(1,1),
	[MaCN] [nvarchar](50) NOT NULL,
	[TenCN] [nvarchar](100) NOT NULL,
	[Mota] [nvarchar](255) NULL,
	[IDNhomCN] INT NOT NULL,
	PRIMARY KEY(ID),
	FOREIGN KEY(IDNhomCN) REFERENCES ADM_NhomChucNang(ID)
)
GO
 /*
 * create by: TUYLV
 * create date: 223-12-2013
 * purpose: Vai tro cua nguoi dung trong he thong
 */
 CREATE TABLE [dbo].[ADM_VaiTro](
	[ID] INT  IDENTITY(1,1) NOT NULL,
	[TenVaiTro] [nvarchar](100) NOT NULL,
	PRIMARY KEY(ID))
 GO
 /*
 * create by: TUYLV
 * create date: 23-12-2013
 * purpose: Chua nguoi dung cua he thong
 */
 CREATE TABLE [dbo].[ADM_NguoiDung](
	[IDNguoiDung] [bigint] IDENTITY(1,1) NOT NULL,
	[TenDangNhap] [nvarchar](20) NOT NULL,
	[MatKhau] [nvarchar](100) NOT NULL,
	[TenDayDu] [nvarchar](50) NOT NULL,
	[IDVaiTro] INT NOT NULL,
	[HoatDong] [bit] NOT NULL,
	[DaDoiMatKhau] [bit] NOT NULL,
	PRIMARY KEY(IDNguoiDung), FOREIGN KEY(IDVaiTro) REFERENCES ADM_VaiTro(ID))
 GO
 /*
 * create by: TUYLV
 * create date: 23-12-2013
 * purpose: Tao nhom nguoi dung dinh nghia
 */
 CREATE TABLE [dbo].[ADM_NhomNguoiDung](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[TenNhom] [nvarchar](50) NOT NULL,
	[MoTa] [nvarchar](255) NULL,
	[HoatDong] [bit] NOT NULL, 
	PRIMARY KEY(ID))
 GO
 /*
 * create by: TUYLV
 * create date: 23-12-2013
 * purpose: Tao quyen cua nguoi dung
 */
 CREATE TABLE [dbo].[ADM_QuyenNguoiDung](
	[IDQuyenND] bigint IDENTITY(1,1) NOT NULL,
	[IDChucNang] INT  NOT NULL,
	[IDNguoiDung] bigint NOT NULL,
	[ThemMoi] BIT NOT NULL,
	Xoa BIT NOT NULL,
	Sua BIT NOT NULL,
	Xem BIT NOT NULL,  
	TatCa BIT NOT NULL,
	PRIMARY KEY(IDQuyenND), FOREIGN KEY(IDChucNang) REFERENCES ADM_ChucNang(ID),
	FOREIGN KEY(IDNguoiDung) REFERENCES ADM_NguoiDung(IDNguoiDung)) 
GO
/*
 * create by:TUYLV
 * create date: 23-12-2013
 * purpose: Tao quyen nhom nguoi dung
 */
 --EXEC sp_rename 'ADM_QuyenNhomNguoiDung.ID','IDQuyenNhomND','COLUMN'
 GO
 CREATE TABLE [dbo].[ADM_QuyenNhomNguoiDung](
	[IDQuyenNhomND] [bigint] IDENTITY(1,1) NOT NULL,
	[IDChucNang] INT  NOT NULL,
	[IDNhomNguoiDung] [bigint] NOT NULL,
	[ThemMoi] BIT NOT NULL,
	Sua BIT NOT NULL,
	Xoa BIT NOT NULL,
	TatCa BIT NOT NULL,
	Xem BIT NOT NULL,
	PRIMARY KEY(IDQuyenNhomND), FOREIGN KEY(IDChucNang) REFERENCES ADM_ChucNang(IDCN),
	FOREIGN KEY(IDNhomNguoiDung) REFERENCES ADM_NhomNguoiDung(ID))
GO
/*
 * create by:TUYLV
 * create date: 23-12-2013
 * purpose: Tao quyen nhom nguoi dung
 */
CREATE TABLE [dbo].[ADM_ThanhVien](
	[IDQuyenDuocPhan] [bigint] IDENTITY(1,1) NOT NULL,
	[IDNhomNguoiDung] [bigint] NOT NULL,
	[IDNguoiDung] [bigint] NOT NULL,
	PRIMARY KEY(IDQuyenDuocPhan),
	FOREIGN KEY(IDNhomNguoiDung) REFERENCES ADM_NhomNguoiDung(ID),
	FOREIGN KEY(IDNguoiDung) REFERENCES ADM_NguoiDung(IDNguoiDung))
GO
/*
 * create by:TUYLV
 * create date: 23-12-2013
 * purpose: Tao quyen nhom nguoi dung
 */
--DROP TABLE ADM_NguoiDungThuocTinh
--CREATE TABLE [dbo].[ADM_NguoiDungThuocTinh](
--	[IDQuyenDuocPhan] [bigint] IDENTITY(1,1) NOT NULL,
--	[IDNguoiDung] [bigint] NOT NULL,
--	[ThuocTinh] [varchar](100) NOT NULL,
--	FOREIGN KEY(IDNguoiDung) REFERENCES ADM_NguoiDung(IDNguoiDung))
--/*
-- * create by: TUYLV
-- * create date: 23-12-2013
-- * purpose: Chức năng của hệ thống
-- */
--CREATE TABLE [dbo].[ADM_ThuocTinh](
--	[ID] INT IDENTITY(1,1),
--	[MaTT] [nvarchar](50) NOT NULL,
--	[TenTT] [nvarchar](100) NOT NULL,
--	[Mota] [nvarchar](255) NULL,
--	PRIMARY KEY(ID)
--)
--ung bieu
--bien lai thanh toan ngoai,
--he thong mt; 1sl may tram, duong, sip, tai cua may, 
--bac si san sang,

 