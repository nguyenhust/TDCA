/****** Object:  StoredProcedure [dbo].[TT_PhongVanCT_Info_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_PhongVanCT_Info_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[TT_PhongVanCT_Info_Add]
GO

CREATE PROCEDURE [dbo].[TT_PhongVanCT_Info_Add]
    @IDCT bigint OUTPUT,
    @ID bigint,
    @HoVaTen nvarchar(50),
    @IDChucVu int,
    @PhongVienOrCanBo bit
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.TT_PhongVanCT */
        INSERT INTO [dbo].[TT_PhongVanCT]
        (
            [IDPhongVan],
            [HoVaTen],
            [IDChucVu],
            [PhongVienOrCanBo]
        )
        VALUES
        (
            @ID,
            @HoVaTen,
            @IDChucVu,
            @PhongVienOrCanBo
        )

        /* Return new primary key */
        SET @IDCT = SCOPE_IDENTITY()

    END
GO

/****** Object:  StoredProcedure [dbo].[TT_PhongVanCT_Info_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_PhongVanCT_Info_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[TT_PhongVanCT_Info_Upd]
GO

CREATE PROCEDURE [dbo].[TT_PhongVanCT_Info_Upd]
    @IDCT bigint,
    @HoVaTen nvarchar(50),
    @IDChucVu int,
    @PhongVienOrCanBo bit
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [IDCT] FROM [dbo].[TT_PhongVanCT]
            WHERE
                [IDCT] = @IDCT
        )
        BEGIN
            RAISERROR ('''dbo.TT_PhongVanCT_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.TT_PhongVanCT */
        UPDATE [dbo].[TT_PhongVanCT]
        SET
            [HoVaTen] = @HoVaTen,
            [IDChucVu] = @IDChucVu,
            [PhongVienOrCanBo] = @PhongVienOrCanBo
        WHERE
            [IDCT] = @IDCT

    END
GO

/****** Object:  StoredProcedure [dbo].[TT_PhongVanCT_Info_Delete] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_PhongVanCT_Info_Delete]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[TT_PhongVanCT_Info_Delete]
GO

CREATE PROCEDURE [dbo].[TT_PhongVanCT_Info_Delete]
    @IDCT bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [IDCT] FROM [dbo].[TT_PhongVanCT]
            WHERE
                [IDCT] = @IDCT
        )
        BEGIN
            RAISERROR ('''dbo.TT_PhongVanCT_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete TT_PhongVanCT_Info object from TT_PhongVanCT */
        DELETE
        FROM [dbo].[TT_PhongVanCT]
        WHERE
            [dbo].[TT_PhongVanCT].[IDCT] = @IDCT

    END
GO
