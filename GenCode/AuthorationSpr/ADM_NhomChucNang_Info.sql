/****** Object:  StoredProcedure [dbo].[ADM_NhomChucNang_Info_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_NhomChucNang_Info_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_NhomChucNang_Info_Add]
GO

CREATE PROCEDURE [dbo].[ADM_NhomChucNang_Info_Add]
    @ID int OUTPUT,
    @Ma varchar(10),
    @IDPhanHe int,
    @TenNhomCN nvarchar(100)
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.ADM_NhomChucNang */
        INSERT INTO [dbo].[ADM_NhomChucNang]
        (
            [Ma],
            [IDPhanHe],
            [TenNhomCN]
        )
        VALUES
        (
            @Ma,
            @IDPhanHe,
            @TenNhomCN
        )

        /* Return new primary key */
        SET @ID = SCOPE_IDENTITY()

    END
GO

/****** Object:  StoredProcedure [dbo].[ADM_NhomChucNang_Info_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_NhomChucNang_Info_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_NhomChucNang_Info_Upd]
GO

CREATE PROCEDURE [dbo].[ADM_NhomChucNang_Info_Upd]
    @ID int,
    @Ma varchar(10),
    @IDPhanHe int,
    @TenNhomCN nvarchar(100)
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[ADM_NhomChucNang]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.ADM_NhomChucNang_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.ADM_NhomChucNang */
        UPDATE [dbo].[ADM_NhomChucNang]
        SET
            [Ma] = @Ma,
            [IDPhanHe] = @IDPhanHe,
            [TenNhomCN] = @TenNhomCN
        WHERE
            [ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[ADM_NhomChucNang_Info_Delete] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_NhomChucNang_Info_Delete]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_NhomChucNang_Info_Delete]
GO

CREATE PROCEDURE [dbo].[ADM_NhomChucNang_Info_Delete]
    @ID int
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[ADM_NhomChucNang]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.ADM_NhomChucNang_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete ADM_NhomChucNang_Info object from ADM_NhomChucNang */
        DELETE
        FROM [dbo].[ADM_NhomChucNang]
        WHERE
            [dbo].[ADM_NhomChucNang].[ID] = @ID

    END
GO
