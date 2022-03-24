/****** Object:  StoredProcedure [dbo].[DIC_HocVi_Info_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_HocVi_Info_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_HocVi_Info_Add]
GO

CREATE PROCEDURE [dbo].[DIC_HocVi_Info_Add]
    @ID int OUTPUT,
    @TenHocVi nvarchar(50),
    @SuDung bit
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.DIC_HocVi */
        INSERT INTO [dbo].[DIC_HocVi]
        (
            [TenHocVi],
            [SuDung]
        )
        VALUES
        (
            @TenHocVi,
            @SuDung
        )

        /* Return new primary key */
        SET @ID = SCOPE_IDENTITY()

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_HocVi_Info_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_HocVi_Info_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_HocVi_Info_Upd]
GO

CREATE PROCEDURE [dbo].[DIC_HocVi_Info_Upd]
    @ID int,
    @TenHocVi nvarchar(50),
    @SuDung bit
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_HocVi]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_HocVi_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.DIC_HocVi */
        UPDATE [dbo].[DIC_HocVi]
        SET
            [TenHocVi] = @TenHocVi,
            [SuDung] = @SuDung
        WHERE
            [ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_HocVi_Info_Del] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_HocVi_Info_Del]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_HocVi_Info_Del]
GO

CREATE PROCEDURE [dbo].[DIC_HocVi_Info_Del]
    @ID int
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_HocVi]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_HocVi_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete DIC_HocVi_Info object from DIC_HocVi */
        DELETE
        FROM [dbo].[DIC_HocVi]
        WHERE
            [dbo].[DIC_HocVi].[ID] = @ID

    END
GO
