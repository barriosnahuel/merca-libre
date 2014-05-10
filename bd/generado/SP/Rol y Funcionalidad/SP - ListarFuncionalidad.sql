/****** Object:  StoredProcedure [GOODTIMES].[ListarFuncionalidad]    Script Date: 05/11/2014 15:55:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE GOODTIMES.ListarFuncionalidad
@ID_ROL integer
AS
BEGIN
	SELECT F.* 
	FROM GOODTIMES.FUNCIONALIDAD F 
		
END

GO


