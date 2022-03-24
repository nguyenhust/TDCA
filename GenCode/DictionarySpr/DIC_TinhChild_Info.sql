/****** Object:  StoredProcedure [dbo].[DIC_TinhChild_Info_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_TinhChild_Info_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_TinhChild_Info_Add]
GO

CREATE PROCEDURE [dbo].[DIC_TinhChild_Info_Add]
    @IDRefer bigint,
    @ID bigint,
    @Ma varchar(10),
    @MaDK varchar(2),
    @TieuDe nvarchar(50),
    @Ten nvarchar(100),
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
            @SuDung,
            @GhiChu
        )

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_TinhChild_Info_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_TinhChild_Info_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_TinhChild_Info_Upd]
GO

CREATE PROCEDURE [dbo].[DIC_TinhChild_Info_Upd]
    @ID bigint,
    @Ma varchar(10),
    @MaDK varchar(2),
    @TieuDe nvarchar(50),
    @Ten nvarchar(100),
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
            RAISERROR ('''dbo.DIC_TinhChild_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.DIC_Tinh */
        UPDATE [dbo].[DIC_Tinh]
        SET
            [Ma] = @Ma,
            [MaDK] = @MaDK,
            [TieuDe] = @TieuDe,
            [Ten] = @Ten,
            [SuDung] = @SuDung,
            [GhiChu] = @GhiChu
        WHERE
            [ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_TinhChild_Info_Delete] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_TinhChild_Info_Delete]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_TinhChild_Info_Delete]
GO

CREATE PROCEDURE [dbo].[DIC_TinhChild_Info_Delete]
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
            RAISERROR ('''dbo.DIC_TinhChild_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete DIC_TinhChild_Info object from DIC_Tinh */
        DELETE
        FROM [dbo].[DIC_Tinh]
        WHERE
            [dbo].[DIC_Tinh].[ID] = @ID

    END
GO
