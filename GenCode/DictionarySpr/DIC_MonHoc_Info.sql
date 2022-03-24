/****** Object:  StoredProcedure [dbo].[DIC_MonHoc_Info_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_MonHoc_Info_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_MonHoc_Info_Add]
GO

CREATE PROCEDURE [dbo].[DIC_MonHoc_Info_Add]
    @ID bigint OUTPUT,
    @Ma varchar(10),
    @Ten nvarchar(100),
    @IDLoai int,
    @GhiChu nvarchar(100),
    @SuDung bit
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.DIC_MonHoc */
        INSERT INTO [dbo].[DIC_MonHoc]
        (
            [Ma],
            [Ten],
            [IDLoai],
            [GhiChu],
            [SuDung]
        )
        VALUES
        (
            @Ma,
            @Ten,
            @IDLoai,
            @GhiChu,
            @SuDung
        )

        /* Return new primary key */
        SET @ID = SCOPE_IDENTITY()

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_MonHoc_Info_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_MonHoc_Info_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_MonHoc_Info_Upd]
GO

CREATE PROCEDURE [dbo].[DIC_MonHoc_Info_Upd]
    @ID bigint,
    @Ma varchar(10),
    @Ten nvarchar(100),
    @IDLoai int,
    @GhiChu nvarchar(100),
    @SuDung bit
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_MonHoc]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_MonHoc_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.DIC_MonHoc */
        UPDATE [dbo].[DIC_MonHoc]
        SET
            [Ma] = @Ma,
            [Ten] = @Ten,
            [IDLoai] = @IDLoai,
            [GhiChu] = @GhiChu,
            [SuDung] = @SuDung
        WHERE
            [ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_MonHoc_Info_Delete] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_MonHoc_Info_Delete]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_MonHoc_Info_Delete]
GO

CREATE PROCEDURE [dbo].[DIC_MonHoc_Info_Delete]
    @ID bigint
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_MonHoc]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_MonHoc_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete DIC_MonHoc_Info object from DIC_MonHoc */
        DELETE
        FROM [dbo].[DIC_MonHoc]
        WHERE
            [dbo].[DIC_MonHoc].[ID] = @ID

    END
GO
