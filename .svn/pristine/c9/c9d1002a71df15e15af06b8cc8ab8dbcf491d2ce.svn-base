/****** Object:  StoredProcedure [dbo].[DIC_ChuyenNganh_Info_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_ChuyenNganh_Info_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_ChuyenNganh_Info_Add]
GO

CREATE PROCEDURE [dbo].[DIC_ChuyenNganh_Info_Add]
    @ID int OUTPUT,
    @Ma varchar(10),
    @Ten nvarchar(100),
    @TenTat nvarchar(20),
    @TruongCN nvarchar(50),
    @ID_ChuyenKhoa int,
    @GhiChu nvarchar(100),
    @SuDung bit
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.DIC_ChuyenNganh */
        INSERT INTO [dbo].[DIC_ChuyenNganh]
        (
            [Ma],
            [Ten],
            [TenTat],
            [TruongCN],
            [ID_ChuyenKhoa],
            [GhiChu],
            [SuDung]
        )
        VALUES
        (
            @Ma,
            @Ten,
            @TenTat,
            @TruongCN,
            @ID_ChuyenKhoa,
            @GhiChu,
            @SuDung
        )

        /* Return new primary key */
        SET @ID = SCOPE_IDENTITY()

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_ChuyenNganh_Info_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_ChuyenNganh_Info_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_ChuyenNganh_Info_Upd]
GO

CREATE PROCEDURE [dbo].[DIC_ChuyenNganh_Info_Upd]
    @ID int,
    @Ma varchar(10),
    @Ten nvarchar(100),
    @TenTat nvarchar(20),
    @TruongCN nvarchar(50),
    @ID_ChuyenKhoa int,
    @GhiChu nvarchar(100),
    @SuDung bit
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_ChuyenNganh]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_ChuyenNganh_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.DIC_ChuyenNganh */
        UPDATE [dbo].[DIC_ChuyenNganh]
        SET
            [Ma] = @Ma,
            [Ten] = @Ten,
            [TenTat] = @TenTat,
            [TruongCN] = @TruongCN,
            [ID_ChuyenKhoa] = @ID_ChuyenKhoa,
            [GhiChu] = @GhiChu,
            [SuDung] = @SuDung
        WHERE
            [ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_ChuyenNganh_Info_Del] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_ChuyenNganh_Info_Del]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_ChuyenNganh_Info_Del]
GO

CREATE PROCEDURE [dbo].[DIC_ChuyenNganh_Info_Del]
    @ID int
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_ChuyenNganh]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_ChuyenNganh_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete DIC_ChuyenNganh_Info object from DIC_ChuyenNganh */
        DELETE
        FROM [dbo].[DIC_ChuyenNganh]
        WHERE
            [dbo].[DIC_ChuyenNganh].[ID] = @ID

    END
GO
