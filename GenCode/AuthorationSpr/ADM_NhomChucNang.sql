/****** Object:  StoredProcedure [dbo].[ADM_NhomChucNang_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_NhomChucNang_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_NhomChucNang_Get]
GO

CREATE PROCEDURE [dbo].[ADM_NhomChucNang_Get]
    @ID int
AS
    BEGIN

        SET NOCOUNT ON

        /* Get ADM_NhomChucNang from table */
        SELECT
            [ADM_NhomChucNang].[ID],
            [ADM_NhomChucNang].[Ma],
            [ADM_NhomChucNang].[IDPhanHe],
            [ADM_NhomChucNang].[TenNhomCN]
        FROM [dbo].[ADM_NhomChucNang]
        WHERE
            [ADM_NhomChucNang].[ID] = @ID

        /* Get ADM_ChucNang_Info from table */
        SELECT
            [ADM_ChucNang].[IDCN],
            [ADM_ChucNang].[MaCN],
            [ADM_ChucNang].[TenCN],
            [ADM_ChucNang].[Mota]
        FROM [dbo].[ADM_ChucNang]
            INNER JOIN [dbo].[ADM_NhomChucNang] ON [ADM_ChucNang].[IDNhomCN] = [ADM_NhomChucNang].[ID]
        WHERE
            [ADM_NhomChucNang].[ID] = @ID

        /* Get ADM_ChucNang_Info from table */
        SELECT
            [ADM_ChucNang].[IDCN],
            [ADM_ChucNang].[MaCN],
            [ADM_ChucNang].[TenCN],
            [ADM_ChucNang].[Mota]
        FROM [dbo].[ADM_ChucNang]
            INNER JOIN [dbo].[ADM_NhomChucNang] ON [ADM_ChucNang].[IDNhomCN] = [ADM_NhomChucNang].[ID]
        WHERE
            [ADM_NhomChucNang].[ID] = @ID

        /* Get ADM_ChucNang_Info from table */
        SELECT
            [ADM_ChucNang].[IDCN],
            [ADM_ChucNang].[MaCN],
            [ADM_ChucNang].[TenCN],
            [ADM_ChucNang].[Mota]
        FROM [dbo].[ADM_ChucNang]
            INNER JOIN [dbo].[ADM_NhomChucNang] ON [ADM_ChucNang].[IDNhomCN] = [ADM_NhomChucNang].[ID]
        WHERE
            [ADM_NhomChucNang].[ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[ADM_NhomChucNang_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_NhomChucNang_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_NhomChucNang_Add]
GO

CREATE PROCEDURE [dbo].[ADM_NhomChucNang_Add]
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

/****** Object:  StoredProcedure [dbo].[ADM_NhomChucNang_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_NhomChucNang_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_NhomChucNang_Upd]
GO

CREATE PROCEDURE [dbo].[ADM_NhomChucNang_Upd]
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
            RAISERROR ('''dbo.ADM_NhomChucNang'' object not found. It was probably removed by another user.', 16, 1)
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

/****** Object:  StoredProcedure [dbo].[ADM_NhomChucNang_Delete] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_NhomChucNang_Delete]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_NhomChucNang_Delete]
GO

CREATE PROCEDURE [dbo].[ADM_NhomChucNang_Delete]
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
            RAISERROR ('''dbo.ADM_NhomChucNang'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete child ADM_ChucNang_Info from ADM_ChucNang */
        DELETE
            [dbo].[ADM_ChucNang]
        FROM [dbo].[ADM_ChucNang]
            INNER JOIN [dbo].[ADM_NhomChucNang] ON [ADM_ChucNang].[IDNhomCN] = [ADM_NhomChucNang].[ID]
        WHERE
            [dbo].[ADM_NhomChucNang].[ID] = @ID

        /* Delete child ADM_ChucNang_Info from ADM_ChucNang */
        DELETE
            [dbo].[ADM_ChucNang]
        FROM [dbo].[ADM_ChucNang]
            INNER JOIN [dbo].[ADM_NhomChucNang] ON [ADM_ChucNang].[IDNhomCN] = [ADM_NhomChucNang].[ID]
        WHERE
            [dbo].[ADM_NhomChucNang].[ID] = @ID

        /* Delete child ADM_ChucNang_Info from ADM_ChucNang */
        DELETE
            [dbo].[ADM_ChucNang]
        FROM [dbo].[ADM_ChucNang]
            INNER JOIN [dbo].[ADM_NhomChucNang] ON [ADM_ChucNang].[IDNhomCN] = [ADM_NhomChucNang].[ID]
        WHERE
            [dbo].[ADM_NhomChucNang].[ID] = @ID

        /* Delete ADM_NhomChucNang object from ADM_NhomChucNang */
        DELETE
        FROM [dbo].[ADM_NhomChucNang]
        WHERE
            [dbo].[ADM_NhomChucNang].[ID] = @ID

    END
GO
