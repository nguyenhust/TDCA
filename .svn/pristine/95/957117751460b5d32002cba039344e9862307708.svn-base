/****** Object:  StoredProcedure [dbo].[DIC_Phong_Info_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_Phong_Info_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_Phong_Info_Add]
GO

CREATE PROCEDURE [dbo].[DIC_Phong_Info_Add]
    @ID int OUTPUT,
    @Ma varchar(10),
    @Ten nvarchar(50),
    @IDCanBo bigint,
    @TinhTrang nvarchar(200),
    @MucDich nvarchar(200),
    @DiaDiem nvarchar(200),
    @NgayTao datetime,
    @SuDung bit,
    @GhiChu nvarchar(100),
    @SucChua bit,
    @TrangThietBi nvarchar(200)
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.DIC_Phong */
        INSERT INTO [dbo].[DIC_Phong]
        (
            [Ma],
            [Ten],
            [IDCanBo],
            [TinhTrang],
            [MucDich],
            [DiaDiem],
            [NgayTao],
            [SuDung],
            [GhiChu],
            [SucChua],
            [TrangThietBi]
        )
        VALUES
        (
            @Ma,
            @Ten,
            @IDCanBo,
            @TinhTrang,
            @MucDich,
            @DiaDiem,
            @NgayTao,
            @SuDung,
            @GhiChu,
            @SucChua,
            @TrangThietBi
        )

        /* Return new primary key */
        SET @ID = SCOPE_IDENTITY()

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_Phong_Info_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_Phong_Info_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_Phong_Info_Upd]
GO

CREATE PROCEDURE [dbo].[DIC_Phong_Info_Upd]
    @ID int,
    @Ma varchar(10),
    @Ten nvarchar(50),
    @IDCanBo bigint,
    @TinhTrang nvarchar(200),
    @MucDich nvarchar(200),
    @DiaDiem nvarchar(200),
    @NgayTao datetime,
    @SuDung bit,
    @GhiChu nvarchar(100),
    @SucChua bit,
    @TrangThietBi nvarchar(200)
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_Phong]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_Phong_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.DIC_Phong */
        UPDATE [dbo].[DIC_Phong]
        SET
            [Ma] = @Ma,
            [Ten] = @Ten,
            [IDCanBo] = @IDCanBo,
            [TinhTrang] = @TinhTrang,
            [MucDich] = @MucDich,
            [DiaDiem] = @DiaDiem,
            [NgayTao] = @NgayTao,
            [SuDung] = @SuDung,
            [GhiChu] = @GhiChu,
            [SucChua] = @SucChua,
            [TrangThietBi] = @TrangThietBi
        WHERE
            [ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_Phong_Info_Delete] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_Phong_Info_Delete]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_Phong_Info_Delete]
GO

CREATE PROCEDURE [dbo].[DIC_Phong_Info_Delete]
    @ID int
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_Phong]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_Phong_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete DIC_Phong_Info object from DIC_Phong */
        DELETE
        FROM [dbo].[DIC_Phong]
        WHERE
            [dbo].[DIC_Phong].[ID] = @ID

    END
GO
