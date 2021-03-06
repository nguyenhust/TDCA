USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[DT_LienTuc_KhungLopHoc_Coll_get]    Script Date: 03/12/2018 9:02:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DT_LienTuc_KhungLopHoc_Coll_get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DT_LienTuc_KhungLopHoc_Info from table */
        SELECT
            [DT_LienTuc_KhungLopHoc].[id],
            Case when [DT_LienTuc_KhungLopHoc].[ThoiGianHoc] is null then [DT_LienTuc_KhungLopHoc].[TenLop] else [DT_LienTuc_KhungLopHoc].[TenLop] + ' ( ' + [DT_LienTuc_KhungLopHoc].[ThoiGianHoc] + ' )' end as TenLop,
            [DT_LienTuc_KhungLopHoc].[idChuyenKhoa],
			[DIC_ChuyenKhoa].[Ten] as ChuyenKhoa,
            [DT_LienTuc_KhungLopHoc].[HocPhi]
        FROM [dbo].[DT_LienTuc_KhungLopHoc] LEFT JOIN DIC_ChuyenKhoa
		ON [DIC_ChuyenKhoa].[ID] = [DT_LienTuc_KhungLopHoc].[idChuyenKhoa]

    END

	Go

	USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[DT_LienTuc_KhungLopHoc_update]    Script Date: 03/12/2018 3:35:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[DT_LienTuc_KhungLopHoc_update]
    @id int,
    @TenLop nvarchar(50),
    @idChuyenKhoa bigint,
    @HocPhi nvarchar(50),
	@ThoiGianHoc nvarchar(50)
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [id] FROM [dbo].[DT_LienTuc_KhungLopHoc]
            WHERE
                [id] = @id
        )
        BEGIN
            RAISERROR ('''dbo.DT_LienTuc_KhungLopHoc'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.DT_LienTuc_KhungLopHoc */
        UPDATE [dbo].[DT_LienTuc_KhungLopHoc]
        SET
            [TenLop] = @TenLop,
            [idChuyenKhoa] = @idChuyenKhoa,
            [HocPhi] = @HocPhi,
			[ThoiGianHoc] = @ThoiGianHoc
        WHERE
            [id] = @id

    END
GO
USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[DT_LienTuc_KhungLopHoc_get]    Script Date: 03/12/2018 9:28:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DT_LienTuc_KhungLopHoc_get]
    @id int
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DT_LienTuc_KhungLopHoc from table */
        SELECT
            [DT_LienTuc_KhungLopHoc].[id],
            [DT_LienTuc_KhungLopHoc].[TenLop],
            [DT_LienTuc_KhungLopHoc].[idChuyenKhoa],
            [DT_LienTuc_KhungLopHoc].[HocPhi],
			[DIC_ChuyenKhoa].[Ten] as ChuyenKhoa,
			[DT_LienTuc_KhungLopHoc].[ThoiGianHoc]
            
        FROM [dbo].[DT_LienTuc_KhungLopHoc] LEFT JOIN DIC_ChuyenKhoa
		ON [DIC_ChuyenKhoa].[ID] = [DT_LienTuc_KhungLopHoc].[idChuyenKhoa]

        WHERE
            [DT_LienTuc_KhungLopHoc].[id] = @id

    END
	GO




