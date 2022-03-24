/****** Object:  StoredProcedure [dbo].[DIC_VatTu_Coll_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_VatTu_Coll_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_VatTu_Coll_Get]
GO

CREATE PROCEDURE [dbo].[DIC_VatTu_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DIC_VatTu_Info from table */
        SELECT
            [DIC_VatTu].[ID],
            [DIC_VatTu].[Ten],
            [DIC_VatTu].[Ma],
            [DIC_VatTu].[IDLoai],
            [DIC_VatTu].[IDDonViTinh],
            [DIC_VatTu].[MauSac],
            [DIC_VatTu].[NhaSX],
            [DIC_VatTu].[NguonGocXuatXu],
            [DIC_VatTu].[DonGia],
            [DIC_VatTu].[PhuKien],
            [DIC_VatTu].[Serial],
            [DIC_VatTu].[NgayTao],
            [DIC_VatTu].[SuDung],
            [DIC_VatTu].[GhiChu]
        FROM [dbo].[DIC_VatTu]

    END
GO

