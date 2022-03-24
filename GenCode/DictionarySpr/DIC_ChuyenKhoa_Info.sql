/****** Object:  StoredProcedure [dbo].[DIC_ChuyenKhoa_Info_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_ChuyenKhoa_Info_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_ChuyenKhoa_Info_Add]
GO

CREATE PROCEDURE [dbo].[DIC_ChuyenKhoa_Info_Add]
    @ID int OUTPUT,
    @Ten nvarchar(200),
    @GhiChu nvarchar(100),
    @SuDung bit
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.DIC_ChuyenKhoa */
        INSERT INTO [dbo].[DIC_ChuyenKhoa]
        (
            [Ten],
            [GhiChu],
            [SuDung]
        )
        VALUES
        (
            @Ten,
            @GhiChu,
            @SuDung
        )

        /* Return new primary key */
        SET @ID = SCOPE_IDENTITY()

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_ChuyenKhoa_Info_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_ChuyenKhoa_Info_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_ChuyenKhoa_Info_Upd]
GO

CREATE PROCEDURE [dbo].[DIC_ChuyenKhoa_Info_Upd]
    @ID int,
    @Ten nvarchar(200),
    @GhiChu nvarchar(100),
    @SuDung bit
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_ChuyenKhoa]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_ChuyenKhoa_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.DIC_ChuyenKhoa */
        UPDATE [dbo].[DIC_ChuyenKhoa]
        SET
            [Ten] = @Ten,
            [GhiChu] = @GhiChu,
            [SuDung] = @SuDung
        WHERE
            [ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_ChuyenKhoa_Info_Del] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_ChuyenKhoa_Info_Del]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_ChuyenKhoa_Info_Del]
GO

CREATE PROCEDURE [dbo].[DIC_ChuyenKhoa_Info_Del]
    @ID int
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_ChuyenKhoa]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_ChuyenKhoa_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete DIC_ChuyenKhoa_Info object from DIC_ChuyenKhoa */
        DELETE
        FROM [dbo].[DIC_ChuyenKhoa]
        WHERE
            [dbo].[DIC_ChuyenKhoa].[ID] = @ID

    END
GO
