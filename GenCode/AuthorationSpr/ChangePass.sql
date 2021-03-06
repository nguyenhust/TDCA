DROP PROC ADM_NguoiDung_ChangePass
GO
/*
 * create by: TUYLV
 * Create date: 28-12-2013
 * Purpose: Đổi mật khẩu cho người dùng 
 */

CREATE PROCEDURE [dbo].[ADM_NguoiDung_ChangePass]
	@OldPass NVARCHAR(100),
    @TenDangNhap nvarchar(20),
    @NewPass nvarchar(100),
    @NewPassConfirm NVARCHAR(100)
AS
    BEGIN
		
		
        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [IDNguoiDung] FROM [dbo].[ADM_NguoiDung]
            WHERE
                TenDangNhap = @TenDangNhap
        )
        BEGIN
            RAISERROR ('''dbo.ADM_NguoiDung'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

		IF @NewPass <> @NewPassConfirm
		BEGIN
			RAISERROR ('''dbo.ADM_NguoiDung'' Hai mật khẩu mới nhập vào không trùng nhau.', 16, 1)
            RETURN
		END
		-- lấy ra IDNguoiDung cần đổi mật khẩu
		DECLARE @IDNguoiDung BIGINT
		SET @IDNguoiDung = (SELECT TOP 1 IDNguoiDung FROM ADM_NguoiDung and1 WHERE and1.TenDangNhap =@TenDangNhap AND and1.MatKhau = @OldPass)

        /* Update object in dbo.ADM_NguoiDung */
        UPDATE [dbo].[ADM_NguoiDung]
        SET
            [MatKhau] = @NewPass,
            [DaDoiMatKhau] = 1
        WHERE
            [IDNguoiDung] = @IDNguoiDung

    END
