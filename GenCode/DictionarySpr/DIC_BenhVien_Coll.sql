/****** Object:  StoredProcedure [dbo].[DIC_BenhVien_Coll_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_BenhVien_Coll_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_BenhVien_Coll_Get]
GO

CREATE PROCEDURE [dbo].[DIC_BenhVien_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DIC_BenhVien_Info from table */
        SELECT
            [DIC_BenhVien].[ID],
            [DIC_BenhVien].[Ma],
            [DIC_BenhVien].[Ten],
            [DIC_BenhVien].[IDTinh],
            [DIC_BenhVien].[DienTich],
            [DIC_BenhVien].[DacDiem],
            [DIC_BenhVien].[KhoangCach],
            [DIC_BenhVien].[Email],
            [DIC_BenhVien].[Fax],
            [DIC_BenhVien].[IDLoai],
            [DIC_BenhVien].[GiuongTK],
            [DIC_BenhVien].[GiuongKH],
            [DIC_BenhVien].[KhoaLS],
            [DIC_BenhVien].[KhoaCLS],
            [DIC_BenhVien].[Phong],
            [DIC_BenhVien].[GhiChu],
            [DIC_BenhVien].[SuDung]
        FROM [dbo].[DIC_BenhVien]

    END
GO

