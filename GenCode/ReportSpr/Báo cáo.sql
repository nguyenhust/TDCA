SELECT * FROM DIC_CoQuan dcq
GO
exec dbo.DIC_CoQuan_Info_Upd @ID=1,@Ten=N'Dân trí',@DiaChi=N'Cầu diễn',@SuDung=1,@GhiChu=N''
GO
DROP PROC BC_BaiViet
GO
/*
 * Create by: TUYLV
 * Create date: 23/01/2014
 * Purpose: Lấy ra các bài viết đã được đăng
 */
CREATE PROC BC_BaiViet
AS
BEGIN
	SELECT tbv.*,dl.Ten FROM TT_BaiViet tbv
		JOIN DIC_Loai dl ON dl.ID = tbv.IDLoai	
END


