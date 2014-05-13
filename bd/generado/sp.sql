USE [GD1C2014]
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarFuncionalidadSinAsignarARol]    Script Date: 05/13/2014 01:28:47 ******/
DROP PROCEDURE [GOODTIMES].[BuscarFuncionalidadSinAsignarARol]
GO
/****** Object:  StoredProcedure [GOODTIMES].[AgregarFuncionalidadARol]    Script Date: 05/13/2014 01:28:47 ******/
DROP PROCEDURE [GOODTIMES].[AgregarFuncionalidadARol]
GO
/****** Object:  StoredProcedure [GOODTIMES].[ListarFuncionalidadPorRol]    Script Date: 05/13/2014 01:28:47 ******/
DROP PROCEDURE [GOODTIMES].[ListarFuncionalidadPorRol]
GO
/****** Object:  StoredProcedure [GOODTIMES].[QuitarFuncionalidadARol]    Script Date: 05/13/2014 01:28:47 ******/
DROP PROCEDURE [GOODTIMES].[QuitarFuncionalidadARol]
GO
/****** Object:  StoredProcedure [GOODTIMES].[ListarRoles]    Script Date: 05/13/2014 01:28:47 ******/
DROP PROCEDURE [GOODTIMES].[ListarRoles]
GO
/****** Object:  StoredProcedure [GOODTIMES].[BajaRol]    Script Date: 05/13/2014 01:28:47 ******/
DROP PROCEDURE [GOODTIMES].[BajaRol]
GO
/****** Object:  StoredProcedure [GOODTIMES].[ListarFuncionalidad]    Script Date: 05/13/2014 01:28:47 ******/
DROP PROCEDURE [GOODTIMES].[ListarFuncionalidad]
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarRolPorId]    Script Date: 05/13/2014 01:28:47 ******/
DROP PROCEDURE [GOODTIMES].[BuscarRolPorId]
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarRolPorNombre]    Script Date: 05/13/2014 01:28:47 ******/
DROP PROCEDURE [GOODTIMES].[BuscarRolPorNombre]
GO
/****** Object:  StoredProcedure [GOODTIMES].[CrearRol]    Script Date: 05/13/2014 01:28:47 ******/
DROP PROCEDURE [GOODTIMES].[CrearRol]
GO
/****** Object:  StoredProcedure [GOODTIMES].[CrearRol]    Script Date: 05/13/2014 01:28:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [GOODTIMES].[CrearRol]
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
/****** Object:  StoredProcedure [GOODTIMES].[BuscarRolPorNombre]    Script Date: 05/13/2014 01:28:47 ******/
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
/****** Object:  StoredProcedure [GOODTIMES].[BuscarRolPorId]    Script Date: 05/13/2014 01:28:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [GOODTIMES].[BuscarRolPorId]
@ID int
AS
BEGIN
	SELECT * FROM GOODTIMES.ROL R WHERE R.ID = @ID
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[ListarFuncionalidad]    Script Date: 05/13/2014 01:28:47 ******/
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
/****** Object:  StoredProcedure [GOODTIMES].[BajaRol]    Script Date: 05/13/2014 01:28:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [GOODTIMES].[BajaRol]
	@ID int
	
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [GOODTIMES].[ROL] 
	 SET ELIMINADO = 1
		WHERE [GOODTIMES].[ROL].ID = @ID

	
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[ListarRoles]    Script Date: 05/13/2014 01:28:47 ******/
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
/****** Object:  StoredProcedure [GOODTIMES].[QuitarFuncionalidadARol]    Script Date: 05/13/2014 01:28:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [GOODTIMES].[QuitarFuncionalidadARol]
	@ROL_ID int,
	@FUNCIONALIDAD_ID int
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [GOODTIMES].[FUNCIONALIDAD_X_ROL] 
      WHERE (@ROL_ID = GOODTIMES.FUNCIONALIDAD_X_ROL.ROL_ID 
      and @FUNCIONALIDAD_ID = GOODTIMES.FUNCIONALIDAD_X_ROL.FUNCIONALIDAD_ID)
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[ListarFuncionalidadPorRol]    Script Date: 05/13/2014 01:28:47 ******/
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
/****** Object:  StoredProcedure [GOODTIMES].[AgregarFuncionalidadARol]    Script Date: 05/13/2014 01:28:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [GOODTIMES].[AgregarFuncionalidadARol]
	@ROL_ID int,
	@FUNCIONALIDAD_ID int
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [GD1C2014].[GOODTIMES].[FUNCIONALIDAD_X_ROL]
           ([ROL_ID]
           ,[FUNCIONALIDAD_ID])
     VALUES
           (@ROL_ID
           ,@FUNCIONALIDAD_ID)
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarFuncionalidadSinAsignarARol]    Script Date: 05/13/2014 01:28:47 ******/
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
