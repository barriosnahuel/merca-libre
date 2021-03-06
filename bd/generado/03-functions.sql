USE [GD1C2014]
GO

/****** Object:  UserDefinedFunction [GOODTIMES].[GET_UNIQUE_USERNAME]    Script Date: 05/17/2014 21:05:56 ******/
IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[GOODTIMES].[GET_UNIQUE_USERNAME]') AND type IN (N'FN', N'IF', N'TF', N'FS', N'FT'))
    DROP FUNCTION [GOODTIMES].[GET_UNIQUE_USERNAME]
GO

/****** Object:  UserDefinedFunction [GOODTIMES].[GET_UNIQUE_USERNAME]    Script Date: 05/17/2014 21:05:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE FUNCTION [GOODTIMES].[GET_UNIQUE_USERNAME]
    (
        @name NVARCHAR(100)
    )
    RETURNS NVARCHAR(100)
AS
    BEGIN

        DECLARE @username NVARCHAR(100), @number INTEGER

        SET @username = @name
        SET @number = 0

        WHILE EXISTS(SELECT 1
                     FROM GOODTIMES.USUARIO
                     WHERE USERNAME = @username)
            BEGIN
                SET @number = @number + 1;
                SET @username = RTRIM(LTRIM(@username)) + RTRIM(LTRIM(STR(@number)))
            END

        RETURN @username
    END

GO

/****** Object:  UserDefinedFunction [GOODTIMES].[GET_ESTADO_PUBLICACION_BY_DESCRIPCION]    Script Date: 05/18/2014 13:55:57 ******/
IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[GOODTIMES].[GET_ESTADO_PUBLICACION_BY_DESCRIPCION]') AND type IN (N'FN', N'IF', N'TF', N'FS', N'FT'))
    DROP FUNCTION [GOODTIMES].[GET_ESTADO_PUBLICACION_BY_DESCRIPCION]
GO


/****** Object:  UserDefinedFunction [GOODTIMES].[GET_ESTADO_PUBLICACION_BY_DESCRIPCION]    Script Date: 05/18/2014 13:55:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE FUNCTION [GOODTIMES].[GET_ESTADO_PUBLICACION_BY_DESCRIPCION](@descripcion NVARCHAR(255))
    RETURNS SMALLINT
AS
    BEGIN

        DECLARE @estadoId SMALLINT

        SELECT @estadoId = ID
        FROM GD1C2014.GOODTIMES.ESTADO
        WHERE DESCRIPCION = @descripcion

        RETURN @estadoId
    END
GO


/****** Object:  UserDefinedFunction [GOODTIMES].[GET_TIPO_PUBLICACION_BY_DESCRIPCION]    Script Date: 05/18/2014 14:12:03 ******/
IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[GOODTIMES].[GET_TIPO_PUBLICACION_BY_DESCRIPCION]') AND type IN (N'FN', N'IF', N'TF', N'FS', N'FT'))
    DROP FUNCTION [GOODTIMES].[GET_TIPO_PUBLICACION_BY_DESCRIPCION]
GO

/****** Object:  UserDefinedFunction [GOODTIMES].[GET_TIPO_PUBLICACION_BY_DESCRIPCION]    Script Date: 05/18/2014 14:12:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE FUNCTION [GOODTIMES].[GET_TIPO_PUBLICACION_BY_DESCRIPCION](@descripcion NVARCHAR(255))
    RETURNS SMALLINT
AS
    BEGIN

        DECLARE @tipoPublicacionId SMALLINT

        SELECT @tipoPublicacionId = ID
        FROM GD1C2014.GOODTIMES.TIPO_PUBLICACION
        WHERE DESCRIPCION = @descripcion

        RETURN @tipoPublicacionId
    END

GO


/****** Object:  UserDefinedFunction [GOODTIMES].[GET_VISIBILIDAD_PUBLICACION_BY_DESCRIPCION]    Script Date: 05/18/2014 15:47:59 ******/
IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[GOODTIMES].[GET_VISIBILIDAD_PUBLICACION_BY_DESCRIPCION]') AND type IN (N'FN', N'IF', N'TF', N'FS', N'FT'))
    DROP FUNCTION [GOODTIMES].[GET_VISIBILIDAD_PUBLICACION_BY_DESCRIPCION]
GO

/****** Object:  UserDefinedFunction [GOODTIMES].[GET_VISIBILIDAD_PUBLICACION_BY_DESCRIPCION]    Script Date: 05/18/2014 15:47:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE FUNCTION [GOODTIMES].[GET_VISIBILIDAD_PUBLICACION_BY_DESCRIPCION](@descripcion NVARCHAR(255))
    RETURNS NUMERIC(18, 0)
AS
    BEGIN
        DECLARE @visibilidadPublicacionId NUMERIC(18, 0)

        SELECT @visibilidadPublicacionId = ID
        FROM GD1C2014.GOODTIMES.VISIBILIDAD_PUBLICACION
        WHERE DESCRIPCION = @descripcion

        RETURN @visibilidadPublicacionId
    END
GO


/****** Object:  UserDefinedFunction [GOODTIMES].[GET_RUBRO_BY_DESCRIPCION]    Script Date: 05/18/2014 16:18:37 ******/
IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[GOODTIMES].[GET_RUBRO_BY_DESCRIPCION]') AND type IN (N'FN', N'IF', N'TF', N'FS', N'FT'))
    DROP FUNCTION [GOODTIMES].[GET_RUBRO_BY_DESCRIPCION]
GO

/****** Object:  UserDefinedFunction [GOODTIMES].[GET_RUBRO_BY_DESCRIPCION]    Script Date: 05/18/2014 16:18:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE FUNCTION [GOODTIMES].[GET_RUBRO_BY_DESCRIPCION](@descripcion NVARCHAR(255))
    RETURNS INT
AS
    BEGIN
        DECLARE @rubroId INT

        SELECT @rubroId = CODIGO
        FROM GD1C2014.GOODTIMES.RUBRO
        WHERE DESCRIPCION = @descripcion

        RETURN @rubroId
    END
GO

USE [GD1C2014]
GO

/****** Object:  UserDefinedFunction [GOODTIMES].[SPLIT_STRING]    Script Date: 06/07/2014 14:54:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[SPLIT_STRING]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [GOODTIMES].[SPLIT_STRING]
GO

USE [GD1C2014]
GO

/****** Object:  UserDefinedFunction [GOODTIMES].[SPLIT_STRING]    Script Date: 06/07/2014 14:54:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [GOODTIMES].[SPLIT_STRING]
( 
    @string NVARCHAR(MAX), 
    @delimiter CHAR(1) 
) 
RETURNS @output TABLE(splitdata NVARCHAR(MAX) 
) 
BEGIN 
    DECLARE @start INT, @end INT 
    SELECT @start = 1, @end = CHARINDEX(@delimiter, @string) 
    WHILE @start < LEN(@string) + 1 BEGIN 
        IF @end = 0  
            SET @end = LEN(@string) + 1
       
        INSERT INTO @output (splitdata)  
        VALUES(SUBSTRING(@string, @start, @end - @start)) 
        SET @start = @end + 1 
        SET @end = CHARINDEX(@delimiter, @string, @start)
        
    END 
    RETURN 
END
GO

