/****** Object:  StoredProcedure [dbo].[DIC_SLChucVuBV_Info_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_SLChucVuBV_Info_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_SLChucVuBV_Info_Add]
GO

CREATE PROCEDURE [dbo].[DIC_SLChucVuBV_Info_Add]
    @ID int OUTPUT,
    @IDBenhVien bigint,
    @IDChucVu int,
    @SLChucVu int,
    @GhiChu nvarchar(100)
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.DIC_SLChucVuBV */
        INSERT INTO [dbo].[DIC_SLChucVuBV]
        (
            [IDBenhVien],
            [IDChucVu],
            [SLChucVu],
            [GhiChu]
        )
        VALUES
        (
            @IDBenhVien,
            @IDChucVu,
            @SLChucVu,
            @GhiChu
        )

        /* Return new primary key */
        SET @ID = SCOPE_IDENTITY()

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_SLChucVuBV_Info_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_SLChucVuBV_Info_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_SLChucVuBV_Info_Upd]
GO

CREATE PROCEDURE [dbo].[DIC_SLChucVuBV_Info_Upd]
    @ID int,
    @IDBenhVien bigint,
    @IDChucVu int,
    @SLChucVu int,
    @GhiChu nvarchar(100)
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_SLChucVuBV]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_SLChucVuBV_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.DIC_SLChucVuBV */
        UPDATE [dbo].[DIC_SLChucVuBV]
        SET
            [IDBenhVien] = @IDBenhVien,
            [IDChucVu] = @IDChucVu,
            [SLChucVu] = @SLChucVu,
            [GhiChu] = @GhiChu
        WHERE
            [ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_SLChucVuBV_Info_Delete] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_SLChucVuBV_Info_Delete]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_SLChucVuBV_Info_Delete]
GO

CREATE PROCEDURE [dbo].[DIC_SLChucVuBV_Info_Delete]
    @ID int
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_SLChucVuBV]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_SLChucVuBV_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete DIC_SLChucVuBV_Info object from DIC_SLChucVuBV */
        DELETE
        FROM [dbo].[DIC_SLChucVuBV]
        WHERE
            [dbo].[DIC_SLChucVuBV].[ID] = @ID

    END
GO
