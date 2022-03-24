/****** Object:  StoredProcedure [dbo].[DIC_Tinh_Get] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_Tinh_Get]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_Tinh_Get]
GO

CREATE PROCEDURE [dbo].[DIC_Tinh_Get]
    @ID bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DIC_Tinh from table */
        SELECT
            [DIC_Tinh].[ID],
            [DIC_Tinh].[Ma],
            [DIC_Tinh].[MaDK],
            [DIC_Tinh].[TieuDe],
            [DIC_Tinh].[Ten],
            [DIC_Tinh].[IDRefer],
            [DIC_Tinh].[SuDung],
            [DIC_Tinh].[GhiChu]
        FROM [dbo].[DIC_Tinh]
        WHERE
            [DIC_Tinh].[ID] = @ID

        /* Get DIC_TinhChild_Info from table */
        SELECT
            [DIC_Tinh].[ID],
            [DIC_Tinh].[Ma],
            [DIC_Tinh].[MaDK],
            [DIC_Tinh].[TieuDe],
            [DIC_Tinh].[Ten],
            [DIC_Tinh].[SuDung],
            [DIC_Tinh].[GhiChu]
        FROM [dbo].[DIC_Tinh]
        WHERE
            [DIC_Tinh].[ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_Tinh_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_Tinh_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_Tinh_Add]
GO

CREATE PROCEDURE [dbo].[DIC_Tinh_Add]
    @ID bigint,
    @Ma varchar(10),
    @MaDK varchar(2),
    @TieuDe nvarchar(50),
    @Ten nvarchar(100),
    @IDRefer bigint,
    @SuDung bit,
    @GhiChu nvarchar(100)
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.DIC_Tinh */
        INSERT INTO [dbo].[DIC_Tinh]
        (
            [ID],
            [Ma],
            [MaDK],
            [TieuDe],
            [Ten],
            [IDRefer],
            [SuDung],
            [GhiChu]
        )
        VALUES
        (
            @ID,
            @Ma,
            @MaDK,
            @TieuDe,
            @Ten,
            @IDRefer,
            @SuDung,
            @GhiChu
        )

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_Tinh_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_Tinh_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_Tinh_Upd]
GO

CREATE PROCEDURE [dbo].[DIC_Tinh_Upd]
    @ID bigint,
    @Ma varchar(10),
    @MaDK varchar(2),
    @TieuDe nvarchar(50),
    @Ten nvarchar(100),
    @IDRefer bigint,
    @SuDung bit,
    @GhiChu nvarchar(100)
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_Tinh]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_Tinh'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.DIC_Tinh */
        UPDATE [dbo].[DIC_Tinh]
        SET
            [Ma] = @Ma,
            [MaDK] = @MaDK,
            [TieuDe] = @TieuDe,
            [Ten] = @Ten,
            [IDRefer] = @IDRefer,
            [SuDung] = @SuDung,
            [GhiChu] = @GhiChu
        WHERE
            [ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_Tinh_Delete] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_Tinh_Delete]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_Tinh_Delete]
GO

CREATE PROCEDURE [dbo].[DIC_Tinh_Delete]
    @ID bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_Tinh]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_Tinh'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete child DIC_TinhChild_Info from DIC_Tinh */
        DELETE
            [dbo].[DIC_Tinh]
        FROM [dbo].[DIC_Tinh]
        WHERE
            [dbo].[DIC_Tinh].[ID] = @ID

        /* Delete DIC_Tinh object from DIC_Tinh */
        DELETE
        FROM [dbo].[DIC_Tinh]
        WHERE
            [dbo].[DIC_Tinh].[ID] = @ID

    END
GO
