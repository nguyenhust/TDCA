/****** Object:  StoredProcedure [dbo].[ADM_PhanHe_Info_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_PhanHe_Info_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_PhanHe_Info_Add]
GO

CREATE PROCEDURE [dbo].[ADM_PhanHe_Info_Add]
    @ID int OUTPUT,
    @Ma varchar(10),
    @TenPhanHe nvarchar(100),
    @MoTa nvarchar(200)
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.ADM_PhanHe */
        INSERT INTO [dbo].[ADM_PhanHe]
        (
            [Ma],
            [TenPhanHe],
            [MoTa]
        )
        VALUES
        (
            @Ma,
            @TenPhanHe,
            @MoTa
        )

        /* Return new primary key */
        SET @ID = SCOPE_IDENTITY()

    END
GO

/****** Object:  StoredProcedure [dbo].[ADM_PhanHe_Info_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_PhanHe_Info_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_PhanHe_Info_Upd]
GO

CREATE PROCEDURE [dbo].[ADM_PhanHe_Info_Upd]
    @ID int,
    @Ma varchar(10),
    @TenPhanHe nvarchar(100),
    @MoTa nvarchar(200)
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[ADM_PhanHe]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.ADM_PhanHe_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.ADM_PhanHe */
        UPDATE [dbo].[ADM_PhanHe]
        SET
            [Ma] = @Ma,
            [TenPhanHe] = @TenPhanHe,
            [MoTa] = @MoTa
        WHERE
            [ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[ADM_PhanHe_Info_Delete] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_PhanHe_Info_Delete]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_PhanHe_Info_Delete]
GO

CREATE PROCEDURE [dbo].[ADM_PhanHe_Info_Delete]
    @ID int
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[ADM_PhanHe]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.ADM_PhanHe_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete ADM_PhanHe_Info object from ADM_PhanHe */
        DELETE
        FROM [dbo].[ADM_PhanHe]
        WHERE
            [dbo].[ADM_PhanHe].[ID] = @ID

    END
GO
