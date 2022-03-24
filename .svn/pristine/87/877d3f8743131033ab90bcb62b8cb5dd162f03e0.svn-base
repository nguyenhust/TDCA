/****** Object:  StoredProcedure [dbo].[ADM_ChucNang_Info_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_ChucNang_Info_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_ChucNang_Info_Add]
GO

CREATE PROCEDURE [dbo].[ADM_ChucNang_Info_Add]
    @IDCN int OUTPUT,
    @ID int,
    @MaCN nvarchar(50),
    @TenCN nvarchar(100),
    @Mota nvarchar(255)
AS
    BEGIN

        SET NOCOUNT ON
		-- check ma va ten chuc năng đã có chưa trước insert
		IF EXISTS(SELECT 1 FROM ADM_ChucNang acn WHERE acn.MaCN = @MaCN OR acn.TenCN = @TenCN)
		BEGIN
			RAISERROR(N'Mã hoặc tên chức năng đã tồn tại trong hệ thống',16,1)
			RETURN
		END

        /* Insert object into dbo.ADM_ChucNang */
        INSERT INTO [dbo].[ADM_ChucNang]
        (
            [IDNhomCN],
            [MaCN],
            [TenCN],
            [Mota]
        )
        VALUES
        (
            @ID,
            @MaCN,
            @TenCN,
            @Mota
        )

        /* Return new primary key */
        SET @IDCN = SCOPE_IDENTITY()

    END
GO

/****** Object:  StoredProcedure [dbo].[ADM_ChucNang_Info_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_ChucNang_Info_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_ChucNang_Info_Upd]
GO

CREATE PROCEDURE [dbo].[ADM_ChucNang_Info_Upd]
    @IDCN int,
    @MaCN nvarchar(50),
    @TenCN nvarchar(100),
    @Mota nvarchar(255)
AS
    BEGIN

        SET NOCOUNT ON

		-- check ma va ten chuc năng đã có chưa trước update
		IF EXISTS(SELECT 1 FROM ADM_ChucNang acn WHERE acn.MaCN = @MaCN OR acn.TenCN = @TenCN)
		BEGIN
			RAISERROR(N'Mã hoặc tên chức năng đã tồn tại trong hệ thống',16,1)
			RETURN
		END

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [IDCN] FROM [dbo].[ADM_ChucNang]
            WHERE
                [IDCN] = @IDCN
        )
        BEGIN
            RAISERROR ('''dbo.ADM_ChucNang_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.ADM_ChucNang */
        UPDATE [dbo].[ADM_ChucNang]
        SET
            [MaCN] = @MaCN,
            [TenCN] = @TenCN,
            [Mota] = @Mota
        WHERE
            [IDCN] = @IDCN

    END
GO

/****** Object:  StoredProcedure [dbo].[ADM_ChucNang_Info_Delete] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADM_ChucNang_Info_Delete]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ADM_ChucNang_Info_Delete]
GO

CREATE PROCEDURE [dbo].[ADM_ChucNang_Info_Delete]
    @IDCN int
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [IDCN] FROM [dbo].[ADM_ChucNang]
            WHERE
                [IDCN] = @IDCN
        )
        BEGIN
            RAISERROR ('''dbo.ADM_ChucNang_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete ADM_ChucNang_Info object from ADM_ChucNang */
        DELETE
        FROM [dbo].[ADM_ChucNang]
        WHERE
            [dbo].[ADM_ChucNang].[IDCN] = @IDCN

    END
GO
