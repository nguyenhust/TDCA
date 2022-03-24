/****** Object:  StoredProcedure [dbo].[DIC_CanBo_Coll_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_CanBo_Coll_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_CanBo_Coll_Get]
GO

CREATE PROCEDURE [dbo].[DIC_CanBo_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DIC_CanBo_Info from table */
        SELECT
            [DIC_CanBo].[ID],
            [DIC_CanBo].[HoTen],
            [DIC_CanBo].[IDGioiTinh],
            [DIC_CanBo].[NgaySinh],
            [DIC_CanBo].[IDTinh],
            [DIC_CanBo].[ChoOHiennay],
            [DIC_CanBo].[IDQuocGia],
            [DIC_CanBo].[NgayVaoDang],
            [DIC_CanBo].[TrinhDoCM],
            [DIC_CanBo].[IDCoQuan],
            [DIC_CanBo].[IDChucVu],
            [DIC_CanBo].[QTDaoTao],
            [DIC_CanBo].[QTCongTac],
            [DIC_CanBo].[KinhNghiemNN],
            [DIC_CanBo].[NghienCuuTGia],
            [DIC_CanBo].[NgoaiNguTinHoc],
            [DIC_CanBo].[KhenThuongKyLuat],
            [DIC_CanBo].[HTapNCuuNNgoai],
            [DIC_CanBo].[IDBoPhan]
        FROM [dbo].[DIC_CanBo]

    END
GO

