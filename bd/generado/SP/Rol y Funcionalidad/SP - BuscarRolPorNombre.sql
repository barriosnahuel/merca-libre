/****** Object:  StoredProcedure [GOODTIMES].[BuscarRolPorNombre]    Script Date: 05/11/2014 15:55:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE GOODTIMES.BuscarRolPorNombre
@NOMBRE nvarchar(100)
AS
BEGIN
	SELECT * FROM GOODTIMES.ROL R WHERE R.ELIMINADO = 0 AND R.NOMBRE like '%' + @NOMBRE + '%'
END

GO


