SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [GOODTIMES].GET_UNIQUE_USERNAME 
(
	@name nvarchar(100)
)
RETURNS nvarchar(100)
AS
BEGIN
	
	DECLARE @username nvarchar(100), @number integer
	
	SET @username = @name
	SET @number = 0
	
	WHILE EXISTS(SELECT 1 FROM GOODTIMES.USUARIO WHERE USERNAME = @username)
	BEGIN
		SET @number = @number + 1;	
		SET @username = RTRIM(LTRIM(@username)) + RTRIM(LTRIM(STR(@number)))
	END
	
	RETURN @username
END
GO