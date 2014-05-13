USE [GD1C2014]
GO
/****** Object:  StoredProcedure [GOODTIMES].[ListarFuncionalidad]    Script Date: 05/12/2014 21:05:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [GOODTIMES].[ListarFuncionalidad]
@ID_ROL integer
AS
BEGIN
	SELECT F.* 
	FROM GOODTIMES.FUNCIONALIDAD F 
		
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[GUARDAR_ROL]    Script Date: 05/12/2014 21:05:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [GOODTIMES].[GUARDAR_ROL]
	@ID int,
	@NOMBRE nvarchar(100),
	@HABILITADO bit,
	@ELIMINADO bit
AS
BEGIN
	SET NOCOUNT ON;
	
	if @ID = -1 BEGIN
	INSERT INTO [GOODTIMES].[ROL]
           ([NOMBRE]
           ,[HABILITADO]
           ,[ELIMINADO])
     VALUES
           (@NOMBRE ,@HABILITADO ,0)
	SELECT @@Identity AS ID
	END
	ELSE begin
		
		UPDATE [GOODTIMES].[ROL]
	   SET [NOMBRE] = @NOMBRE
		  ,[HABILITADO] = @HABILITADO
		  ,[ELIMINADO] = @ELIMINADO
	 WHERE @ID = ID
	
	SELECT @ID
	END
	
	
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarRolPorNombre]    Script Date: 05/12/2014 21:05:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [GOODTIMES].[BuscarRolPorNombre]
@NOMBRE nvarchar(100)
AS
BEGIN
	SELECT * FROM GOODTIMES.ROL R WHERE R.ELIMINADO = 0 AND R.NOMBRE like '%' + @NOMBRE + '%'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[ListarRoles]    Script Date: 05/12/2014 21:05:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [GOODTIMES].[ListarRoles]
AS
BEGIN
	SELECT * FROM GOODTIMES.ROL WHERE ELIMINADO = 0
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[ListarFuncionalidadPorRol]    Script Date: 05/12/2014 21:05:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [GOODTIMES].[ListarFuncionalidadPorRol]
@ID_ROL integer
AS
BEGIN
	SELECT F.* 
	FROM GOODTIMES.FUNCIONALIDAD F 
		JOIN GOODTIMES.FUNCIONALIDAD_X_ROL FR ON F.ID = FR.FUNCIONALIDAD_ID 
	WHERE FR.ROL_ID = @ID_ROL
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarFuncionalidadSinAsignarARol]    Script Date: 05/12/2014 21:05:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [GOODTIMES].[BuscarFuncionalidadSinAsignarARol]
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
