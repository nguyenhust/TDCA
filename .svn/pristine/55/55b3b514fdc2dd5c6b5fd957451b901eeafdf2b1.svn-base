/****** Object:  StoredProcedure [dbo].[DIC_VienKhoaPhong_Coll_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_VienKhoaPhong_Coll_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_VienKhoaPhong_Coll_Get]
GO

CREATE PROCEDURE [dbo].[DIC_VienKhoaPhong_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DIC_VienKhoaPhong_Info from table */
        SELECT
            [DIC_VienKhoaPhong].[IDKhoa],
            [DIC_VienKhoaPhong].[MaKhoa],
            [DIC_VienKhoaPhong].[TenKhoa],
            [DIC_VienKhoaPhong].[MaNhanDang],
            [DIC_VienKhoaPhong].[YTaTruong],
            [DIC_VienKhoaPhong].[TruongKhoa],
            [DIC_VienKhoaPhong].[TenTat],
            [DIC_VienKhoaPhong].[SuDung]
        FROM [dbo].[DIC_VienKhoaPhong]

    END
GO

