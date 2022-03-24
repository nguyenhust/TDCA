/****** Object:  StoredProcedure [dbo].[DIC_PARAMETERES_Info_Add] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_PARAMETERES_Info_Add]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_PARAMETERES_Info_Add]
GO

CREATE PROCEDURE [dbo].[DIC_PARAMETERES_Info_Add]
    @ID int,
    @ParaName nvarchar(100),
    @Descriptions nvarchar(100),
    @ParaValue nvarchar(1000),
    @ParaExpand nvarchar(100),
    @ParaType nvarchar(20),
    @ParaRoll nvarchar(100),
    @DefaultValue nvarchar(100)
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.DIC_PARAMETERES */
        INSERT INTO [dbo].[DIC_PARAMETERES]
        (
            [ID],
            [ParaName],
            [Descriptions],
            [ParaValue],
            [ParaExpand],
            [ParaType],
            [ParaRoll],
            [DefaultValue]
        )
        VALUES
        (
            @ID,
            @ParaName,
            @Descriptions,
            @ParaValue,
            @ParaExpand,
            @ParaType,
            @ParaRoll,
            @DefaultValue
        )

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_PARAMETERES_Info_Upd] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_PARAMETERES_Info_Upd]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_PARAMETERES_Info_Upd]
GO

CREATE PROCEDURE [dbo].[DIC_PARAMETERES_Info_Upd]
    @ID int,
    @ParaName nvarchar(100),
    @Descriptions nvarchar(100),
    @ParaValue nvarchar(1000),
    @ParaExpand nvarchar(100),
    @ParaType nvarchar(20),
    @ParaRoll nvarchar(100),
    @DefaultValue nvarchar(100)
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_PARAMETERES]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_PARAMETERES_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.DIC_PARAMETERES */
        UPDATE [dbo].[DIC_PARAMETERES]
        SET
            [ParaName] = @ParaName,
            [Descriptions] = @Descriptions,
            [ParaValue] = @ParaValue,
            [ParaExpand] = @ParaExpand,
            [ParaType] = @ParaType,
            [ParaRoll] = @ParaRoll,
            [DefaultValue] = @DefaultValue
        WHERE
            [ID] = @ID

    END
GO

/****** Object:  StoredProcedure [dbo].[DIC_PARAMETERES_Info_Delete] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DIC_PARAMETERES_Info_Delete]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DIC_PARAMETERES_Info_Delete]
GO

CREATE PROCEDURE [dbo].[DIC_PARAMETERES_Info_Delete]
    @ID int
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existance */
        IF NOT EXISTS
        (
            SELECT [ID] FROM [dbo].[DIC_PARAMETERES]
            WHERE
                [ID] = @ID
        )
        BEGIN
            RAISERROR ('''dbo.DIC_PARAMETERES_Info'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete DIC_PARAMETERES_Info object from DIC_PARAMETERES */
        DELETE
        FROM [dbo].[DIC_PARAMETERES]
        WHERE
            [dbo].[DIC_PARAMETERES].[ID] = @ID

    END
GO
