/****** Object:  StoredProcedure [GOODTIMES].[[ListarRoles]]    Script Date: 05/11/2014 15:55:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE GOODTIMES.[ListarRoles]
AS
BEGIN
	SELECT * FROM GOODTIMES.ROL WHERE ELIMINADO = 0
END

GO


