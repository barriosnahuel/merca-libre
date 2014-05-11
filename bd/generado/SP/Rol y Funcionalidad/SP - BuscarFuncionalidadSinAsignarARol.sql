/****** Object:  StoredProcedure [GOODTIMES].[ListarFuncionalidadPorRol]    Script Date: 05/11/2014 15:55:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE GOODTIMES.ListarFuncionalidadPorRol
@ID_ROL integer
AS
BEGIN
	SELECT F.* 
		FROM GOODTIMES.FUNCIONALIDAD F
		EXCEPT
	SELECT F.* 
		FROM GOODTIMES.FUNCIONALIDAD F 
		 JOIN GOODTIMES.FUNCIONALIDAD_X_ROL FR ON F.ID = FR.FUNCIONALIDAD_ID 
		WHERE FR.ROL_ID = @ID_ROL
END

GO


