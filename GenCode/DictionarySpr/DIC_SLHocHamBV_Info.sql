/****** Object:  StoredProcedure [dbo].[DIC_SLHocHamBV_Info_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_SLHocHamBV_Info_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_SLHocHamBV_Info_Add]
GO

CREATE PROCEDURE [dbo].[DIC_SLHocHamBV_Info_Add]
    @ID int OUTPUT,
    @IDBenhVien bigint,
    @IDHocHam int,
    @SLHocHam int,
    @GhiChu nvarchar(100)
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.DIC_SLHocHamBV */
        INSERT INTO [dbo].[DIC_SLHocHamBV]
        (
            [IDBenhVien],
            [IDHocHam],
            [SLHocHam],
            [GhiChu]
        )
        VALUES
        (
            @IDBenhVien,
            @IDHocHam,
            @SLHocHam,
            @GhiChu
        )

        /* Return new primary key */
        SET @ID = SCOPE_IDENTITY()

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_SLHocHamBV_Info_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_SLHocHamBV_Info_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_SLHocHamBV_Info_Upd]
GO

CREATE PROCEDURE [dbo].[DIC_SLHocHamBV_Info_Upd]
    @ID int,
    @IDBenhVien bigint,
    @IDHocHam int,
    @SLHocHam int,
    @GhiChu nvarchar(100)
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_SLHocHamBV]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_SLHocHamBV_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.DIC_SLHocHamBV */
        UPDATE [dbo].[DIC_SLHocHamBV]
        SET
            [IDBenhVien] = @IDBenhVien,
            [IDHocHam] = @IDHocHam,
            [SLHocHam] = @SLHocHam,
            [GhiChu] = @GhiChu
        WHERE
            [ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_SLHocHamBV_Info_Delete] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_SLHocHamBV_Info_Delete]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_SLHocHamBV_Info_Delete]
GO

CREATE PROCEDURE [dbo].[DIC_SLHocHamBV_Info_Delete]
    @ID int
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_SLHocHamBV]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_SLHocHamBV_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete DIC_SLHocHamBV_Info object from DIC_SLHocHamBV */
        DELETE
        FROM [dbo].[DIC_SLHocHamBV]
        WHERE
            [dbo].[DIC_SLHocHamBV].[ID] = @ID

    END
GO
