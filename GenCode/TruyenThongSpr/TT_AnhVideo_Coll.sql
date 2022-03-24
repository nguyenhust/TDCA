/****** Object:  StoredProcedure [dbo].[TT_AnhVideo_Coll_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_AnhVideo_Coll_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[TT_AnhVideo_Coll_Get]
GO

CREATE PROCEDURE [dbo].[TT_AnhVideo_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get TT_AnhVideo_Info from table */
        SELECT
            [TT_AnhVideo].[ID],
            [TT_AnhVideo].[IDSuKien],
            [TT_AnhVideo].[IDCanBo],
            [TT_AnhVideo].[Loai],
            [TT_AnhVideo].[SoLuong],
            [TT_AnhVideo].[DuongDan],
            [TT_AnhVideo].[GhiChu],
            dcb.HoTen AS CanBo,
            tsk.Ten AS SuKien
        FROM [dbo].[TT_AnhVideo]
			JOIN DIC_CanBo dcb ON dcb.ID = [dbo].[TT_AnhVideo].IDCanBo
			JOIN TT_SuKien tsk ON tsk.ID = [dbo].[TT_AnhVideo].IDSuKien

    END
GO

