/****** Object:  StoredProcedure [dbo].[TT_SuKien_Coll_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_SuKien_Coll_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[TT_SuKien_Coll_Get]
GO

CREATE PROCEDURE [dbo].[TT_SuKien_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get TT_SuKien_Info from table */
        SELECT
            [TT_SuKien].[ID],
            [TT_SuKien].[Ten],
            [TT_SuKien].[IDChuyenNganh],
            [TT_SuKien].[DiaDiem],
            [TT_SuKien].[ThoiGian],
            [TT_SuKien].[IDLoai],
            [TT_SuKien].[ChuTri],
            [TT_SuKien].[GhiChu],
            dcn.Ten AS TenChuyenNganh,
            dl.Ten AS TenLoai
        FROM [dbo].[TT_SuKien]
        JOIN DIC_Loai dl ON dl.ID = [dbo].[TT_SuKien].IDLoai
        JOIN DIC_ChuyenNganh dcn ON [dbo].[TT_SuKien].IDChuyenNganh = dcn.ID

    END
GO

