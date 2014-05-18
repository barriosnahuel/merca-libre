USE [GD1C2014]
GO

/****** Object:  UserDefinedFunction [GOODTIMES].[GET_UNIQUE_USERNAME]    Script Date: 05/17/2014 21:05:56 ******/
IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[GOODTIMES].[GET_UNIQUE_USERNAME]') AND type IN (N'FN', N'IF', N'TF', N'FS', N'FT'))
    DROP FUNCTION [GOODTIMES].[GET_UNIQUE_USERNAME]
GO

USE [GD1C2014]
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

