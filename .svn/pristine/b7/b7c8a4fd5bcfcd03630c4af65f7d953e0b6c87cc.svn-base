/****** Object:  StoredProcedure [dbo].[DIC_SLHocViBV_Info_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_SLHocViBV_Info_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_SLHocViBV_Info_Add]
GO

CREATE PROCEDURE [dbo].[DIC_SLHocViBV_Info_Add]
    @ID int OUTPUT,
    @IDBenhVien bigint,
    @IDHocVi int,
    @SLHocVi int,
    @GhiChu nvarchar(100)
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.DIC_SLHocViBV */
        INSERT INTO [dbo].[DIC_SLHocViBV]
        (
            [IDBenhVien],
            [IDHocVi],
            [SLHocVi],
            [GhiChu]
        )
        VALUES
        (
            @IDBenhVien,
            @IDHocVi,
            @SLHocVi,
            @GhiChu
        )

        /* Return new primary key */
        SET @ID = SCOPE_IDENTITY()

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_SLHocViBV_Info_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_SLHocViBV_Info_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_SLHocViBV_Info_Upd]
GO

CREATE PROCEDURE [dbo].[DIC_SLHocViBV_Info_Upd]
    @ID int,
    @IDBenhVien bigint,
    @IDHocVi int,
    @SLHocVi int,
    @GhiChu nvarchar(100)
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_SLHocViBV]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_SLHocViBV_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.DIC_SLHocViBV */
        UPDATE [dbo].[DIC_SLHocViBV]
        SET
            [IDBenhVien] = @IDBenhVien,
            [IDHocVi] = @IDHocVi,
            [SLHocVi] = @SLHocVi,
            [GhiChu] = @GhiChu
        WHERE
            [ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_SLHocViBV_Info_Delete] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_SLHocViBV_Info_Delete]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_SLHocViBV_Info_Delete]
GO

CREATE PROCEDURE [dbo].[DIC_SLHocViBV_Info_Delete]
    @ID int
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_SLHocViBV]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_SLHocViBV_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete DIC_SLHocViBV_Info object from DIC_SLHocViBV */
        DELETE
        FROM [dbo].[DIC_SLHocViBV]
        WHERE
            [dbo].[DIC_SLHocViBV].[ID] = @ID

    END
GO
