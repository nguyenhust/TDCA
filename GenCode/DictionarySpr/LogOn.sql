/*
 * Create by: TUYLV
 * Create date: 27122013
 * Purpose: Kiểm tra tài khoản và lấy ra quyền người dùng
 */
DROP PROC ADM_LogOn
GO
CREATE PROC ADM_Logon @TenDangNhap NVARCHAR(20), @MatKhau NVARCHAR(100)
AS
BEGIN
	DECLARE @IDNguoiDung BIGINT

	IF NOT EXISTS(SELECT 1 FROM  ADM_NguoiDung and1 WHERE and1.TenDangNhap =@TenDangNhap AND and1.MatKhau =@MatKhau)
		BEGIN
			raiserror(N'Người dùng [%s] hoặc mật khẩu không đúng',16,1,@TenDangNhap)
			RETURN;		
		END

	SELECT @IDNguoiDung = and1.IDNguoiDung
		FROM  ADM_NguoiDung and1 WHERE and1.TenDangNhap =@TenDangNhap AND and1.MatKhau =@MatKhau

	SELECT (ChucNangQuyen.MaCN + ':' + ChucNangQuyen.Quyen) CNQ  FROM (
		-- lay quyen trong nguoi dung
		SELECT acn.MaCN,CASE WHEN aqnd.ThemMoi=1 THEN 'I' ELSE NULL END  AS Quyen
		  FROM ADM_QuyenNguoiDung aqnd 
			JOIN ADM_ChucNang acn ON acn.IDCN = aqnd.IDChucNang
		WHERE aqnd.IDNguoiDung = @IDNguoiDung
		UNION
		SELECT acn.MaCN,CASE WHEN aqnd.Xoa=1 THEN 'D' ELSE NULL END AS Quyen 
		  FROM ADM_QuyenNguoiDung aqnd 
			JOIN ADM_ChucNang acn ON acn.IDCN = aqnd.IDChucNang
		WHERE aqnd.IDNguoiDung = @IDNguoiDung
		UNION
		SELECT acn.MaCN,CASE WHEN aqnd.Sua=1 THEN 'U' ELSE NULL END AS Quyen 
		  FROM ADM_QuyenNguoiDung aqnd 
			JOIN ADM_ChucNang acn ON acn.IDCN = aqnd.IDChucNang
		WHERE aqnd.IDNguoiDung = @IDNguoiDung
		UNION
		SELECT acn.MaCN,CASE WHEN aqnd.Xem=1 THEN 'S' ELSE NULL END AS Quyen 
		  FROM ADM_QuyenNguoiDung aqnd 
			JOIN ADM_ChucNang acn ON acn.IDCN = aqnd.IDChucNang
		WHERE aqnd.IDNguoiDung = @IDNguoiDung
		UNION
		 --lay quyen trong nhom nguoi dung
		SELECT acn.MaCN,CASE WHEN aqnnd.ThemMoi = 1 THEN 'I' ELSE NULL END  AS Quyen
		  FROM ADM_QuyenNhomNguoiDung aqnnd 
			JOIN ADM_NhomNguoiDung annd ON annd.ID = aqnnd.IDNhomNguoiDung
			JOIN ADM_ThanhVien atv ON atv.IDNhomNguoiDung = annd.ID
			JOIN ADM_ChucNang acn ON acn.IDCN = aqnnd.IDChucNang
		WHERE atv.IDNguoiDung =@IDNguoiDung 
		UNION
		SELECT acn.MaCN,CASE WHEN aqnnd.Sua = 1 THEN 'U' ELSE NULL END  AS Quyen
		  FROM ADM_QuyenNhomNguoiDung aqnnd 
			JOIN ADM_NhomNguoiDung annd ON annd.ID = aqnnd.IDNhomNguoiDung
			JOIN ADM_ThanhVien atv ON atv.IDNhomNguoiDung = annd.ID
			JOIN ADM_ChucNang acn ON acn.IDCN = aqnnd.IDChucNang
		WHERE atv.IDNguoiDung =@IDNguoiDung
		UNION
		SELECT acn.MaCN,CASE WHEN aqnnd.Xoa = 1 THEN 'D' ELSE NULL END  AS Quyen
		  FROM ADM_QuyenNhomNguoiDung aqnnd 
			JOIN ADM_NhomNguoiDung annd ON annd.ID = aqnnd.IDNhomNguoiDung
			JOIN ADM_ThanhVien atv ON atv.IDNhomNguoiDung = annd.ID
			JOIN ADM_ChucNang acn ON acn.IDCN = aqnnd.IDChucNang
		WHERE atv.IDNguoiDung =@IDNguoiDung
		UNION
		SELECT acn.MaCN,CASE WHEN aqnnd.Xem = 1 THEN 'S' ELSE NULL END  AS Quyen
		  FROM ADM_QuyenNhomNguoiDung aqnnd 
			JOIN ADM_NhomNguoiDung annd ON annd.ID = aqnnd.IDNhomNguoiDung
			JOIN ADM_ThanhVien atv ON atv.IDNhomNguoiDung = annd.ID
			JOIN ADM_ChucNang acn ON acn.IDCN = aqnnd.IDChucNang
		WHERE atv.IDNguoiDung =@IDNguoiDung  ) AS ChucNangQuyen WHERE ChucNangQuyen.Quyen IS NOT NULL	
		
		SELECT and1.TenDayDu, avt.TenVaiTro FROM ADM_VaiTro avt  
			JOIN ADM_NguoiDung and1 ON and1.IDVaiTro = avt.ID
		WHERE and1.IDNguoiDung = @IDNguoiDung 
END

GO
EXEC ADM_LogOn 'minh','huy'