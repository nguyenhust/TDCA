Create table DIC_TrangThaiHocVien
(
IDTrangThai bigint primary key identity,
TenTrangThai nvarchar(150),
GhiChu nvarchar(150)
)

GO

USE [MDCT]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[DM_TrangThaiHocVien_get]
    @IDTrangThai int
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DIC_ChucVu from table */
		SELECT *
        FROM [dbo].[DIC_TrangThaiHocVien]
        WHERE
            [DIC_TrangThaiHocVien].[IDTrangThai] = @IDTrangThai

    END

Go

USE [MDCT]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[DM_TrangThaiHocVien_add]
    @IDTrangThai int OUTPUT,
    @TenTrangThai nvarchar(50),
    @GhiChu nvarchar(100)
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.DIC_ChucVu */
        INSERT INTO [dbo].[DIC_TrangThaiHocVien]
        (
            [TenTrangThai],
            [GhiChu]
        )
        VALUES
        (
            @TenTrangThai,
            @GhiChu
        )

        /* Return new primary key */
        SET @IDTrangThai = SCOPE_IDENTITY()

    END

GO

USE [MDCT]
GO
/****** Object:  StoredProcedure [dbo].[DIC_ChucVu_update]    Script Date: 11/06/2019 5:26:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DM_TrangThaiHocVien_update]
    @IDTrangThai bigint,
    @TenTrangThai nvarchar(150),
    @GhiChu nvarchar(100)
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [IDTrangThai] FROM [dbo].[DIC_TrangThaiHocVien]
            WHERE
                [IDTrangThai] = @IDTrangThai
        )
        BEGIN
            RAISERROR ('''dbo.DIC_TrangThaiHocVien'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.DIC_ChucVu */
        UPDATE [dbo].[DIC_TrangThaiHocVien]
        SET
            [TenTrangThai] = @TenTrangThai,
            [GhiChu] = @GhiChu
        WHERE
            [IDTrangThai] = @IDTrangThai

    END

GO

USE [MDCT]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[DM_TrangThaiHocVien_delete]
    @IDTrangThai int
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [IDTrangThai] FROM [dbo].[DIC_TrangThaiHocVien]
            WHERE
                [IDTrangThai] = @IDTrangThai
        )
        BEGIN
            RAISERROR ('''dbo.DIC_TrangThaiHocVien'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete DIC_ChucVu object from DIC_ChucVu */
        DELETE
        FROM [dbo].[DIC_TrangThaiHocVien]
        WHERE
            [dbo].[DIC_TrangThaiHocVien].[IDTrangThai] = @IDTrangThai

    END

GO

USE [MDCT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[TrangThaiCuaHocVien_Coll_Get]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DIC_ChucVu_Info from table */
        SELECT
            *
        FROM [dbo].[DIC_TrangThaiHocVien]

    END









