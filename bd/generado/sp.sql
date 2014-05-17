USE [GD1C2014]
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarClientePorDNITipoYDNI]    Script Date: 05/16/2014 22:37:57 ******/
DROP PROCEDURE [GOODTIMES].[BuscarClientePorDNITipoYDNI]
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarClientePorTelefono]    Script Date: 05/16/2014 22:37:57 ******/
DROP PROCEDURE [GOODTIMES].[BuscarClientePorTelefono]
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarClientes]    Script Date: 05/16/2014 22:37:57 ******/
DROP PROCEDURE [GOODTIMES].[BuscarClientes]
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarEmpresaPorCuit]    Script Date: 05/16/2014 22:37:57 ******/
DROP PROCEDURE [GOODTIMES].[BuscarEmpresaPorCuit]
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarEmpresaPorRazonSocial]    Script Date: 05/16/2014 22:37:57 ******/
DROP PROCEDURE [GOODTIMES].[BuscarEmpresaPorRazonSocial]
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarEmpresas]    Script Date: 05/16/2014 22:37:57 ******/
DROP PROCEDURE [GOODTIMES].[BuscarEmpresas]
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarFuncionalidadSinAsignarARol]    Script Date: 05/16/2014 22:37:57 ******/
DROP PROCEDURE [GOODTIMES].[BuscarFuncionalidadSinAsignarARol]
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarUsuarioPorUsername]    Script Date: 05/16/2014 22:37:57 ******/
DROP PROCEDURE [GOODTIMES].[BuscarUsuarioPorUsername]
GO
/****** Object:  StoredProcedure [GOODTIMES].[AgregarFuncionalidadARol]    Script Date: 05/16/2014 22:37:57 ******/
DROP PROCEDURE [GOODTIMES].[AgregarFuncionalidadARol]
GO
/****** Object:  StoredProcedure [GOODTIMES].[CrearCliente]    Script Date: 05/16/2014 22:37:57 ******/
DROP PROCEDURE [GOODTIMES].[CrearCliente]
GO
/****** Object:  StoredProcedure [GOODTIMES].[CrearEmpresa]    Script Date: 05/16/2014 22:37:57 ******/
DROP PROCEDURE [GOODTIMES].[CrearEmpresa]
GO
/****** Object:  StoredProcedure [GOODTIMES].[EliminarUsuario]    Script Date: 05/16/2014 22:37:57 ******/
DROP PROCEDURE [GOODTIMES].[EliminarUsuario]
GO
/****** Object:  StoredProcedure [GOODTIMES].[login]    Script Date: 05/16/2014 22:37:57 ******/
DROP PROCEDURE [GOODTIMES].[login]
GO
/****** Object:  StoredProcedure [GOODTIMES].[ModificarCliente]    Script Date: 05/16/2014 22:37:57 ******/
DROP PROCEDURE [GOODTIMES].[ModificarCliente]
GO
/****** Object:  StoredProcedure [GOODTIMES].[ModificarEmpresa]    Script Date: 05/16/2014 22:37:57 ******/
DROP PROCEDURE [GOODTIMES].[ModificarEmpresa]
GO
/****** Object:  StoredProcedure [GOODTIMES].[QuitarFuncionalidadARol]    Script Date: 05/16/2014 22:37:57 ******/
DROP PROCEDURE [GOODTIMES].[QuitarFuncionalidadARol]
GO
/****** Object:  StoredProcedure [GOODTIMES].[ListarFuncionalidadPorRol]    Script Date: 05/16/2014 22:37:57 ******/
DROP PROCEDURE [GOODTIMES].[ListarFuncionalidadPorRol]
GO
/****** Object:  StoredProcedure [GOODTIMES].[ListarRoles]    Script Date: 05/16/2014 22:37:57 ******/
DROP PROCEDURE [GOODTIMES].[ListarRoles]
GO
/****** Object:  StoredProcedure [GOODTIMES].[GuardarRol]    Script Date: 05/16/2014 22:37:57 ******/
DROP PROCEDURE [GOODTIMES].[GuardarRol]
GO
/****** Object:  StoredProcedure [GOODTIMES].[ListarFuncionalidad]    Script Date: 05/16/2014 22:37:57 ******/
DROP PROCEDURE [GOODTIMES].[ListarFuncionalidad]
GO
/****** Object:  StoredProcedure [GOODTIMES].[CrearRol]    Script Date: 05/16/2014 22:37:57 ******/
DROP PROCEDURE [GOODTIMES].[CrearRol]
GO
/****** Object:  StoredProcedure [GOODTIMES].[BajaRol]    Script Date: 05/16/2014 22:37:57 ******/
DROP PROCEDURE [GOODTIMES].[BajaRol]
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarRolPorId]    Script Date: 05/16/2014 22:37:57 ******/
DROP PROCEDURE [GOODTIMES].[BuscarRolPorId]
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarRolPorNombre]    Script Date: 05/16/2014 22:37:57 ******/
DROP PROCEDURE [GOODTIMES].[BuscarRolPorNombre]
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarRolPorNombre]    Script Date: 05/16/2014 22:37:57 ******/
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
/****** Object:  StoredProcedure [GOODTIMES].[BuscarRolPorId]    Script Date: 05/16/2014 22:37:57 ******/
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
/****** Object:  StoredProcedure [GOODTIMES].[BajaRol]    Script Date: 05/16/2014 22:37:57 ******/
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
/****** Object:  StoredProcedure [GOODTIMES].[ListarFuncionalidad]    Script Date: 05/16/2014 22:37:57 ******/
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
/****** Object:  StoredProcedure [GOODTIMES].[GuardarRol]    Script Date: 05/16/2014 22:37:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [GOODTIMES].[GuardarRol]
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
/****** Object:  StoredProcedure [GOODTIMES].[ListarRoles]    Script Date: 05/16/2014 22:37:57 ******/
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
/****** Object:  StoredProcedure [GOODTIMES].[ListarFuncionalidadPorRol]    Script Date: 05/16/2014 22:37:57 ******/
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
/****** Object:  StoredProcedure [GOODTIMES].[QuitarFuncionalidadARol]    Script Date: 05/16/2014 22:37:57 ******/
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
/****** Object:  StoredProcedure [GOODTIMES].[ModificarEmpresa]    Script Date: 05/16/2014 22:37:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [GOODTIMES].[ModificarEmpresa]

@RAZON_SOCIAL nvarchar(100), 
@CUIT bigint,
@CONTACTO nvarchar(100), 
@FECHA_CREACION nvarchar(100),
@EMPRESA_ID bigint,

@ID bigint,
@USERNAME nvarchar(100),
@LOGIN_FALLIDOS int, 
@HABILITADO bit, 
@ELIMINADO bit, 
@MAIL nvarchar(100), 
@TELEFONO nvarchar(100), 
@DIRECCION nvarchar(100), 
@CODIGO_POSTAL nvarchar(100), 
@LOCALIDAD nvarchar(100)

AS
BEGIN TRANSACTION

	UPDATE GOODTIMES.EMPRESA
	SET RAZON_SOCIAL = @RAZON_SOCIAL,
	CONTACTO = @CONTACTO, 
	FECHA_CREACION = @FECHA_CREACION,
	CUIT = @CUIT
	WHERE ID = @EMPRESA_ID;


	UPDATE GOODTIMES.USUARIO
	SET USERNAME = @USERNAME,
	HABILITADO = @HABILITADO,
	ELIMINADO = @ELIMINADO,
	MAIL = @MAIL,
	TELEFONO = @TELEFONO,
	DIRECCION = @DIRECCION,
	CODIGO_POSTAL = @CODIGO_POSTAL,
	LOCALIDAD = @LOCALIDAD,
	LOGIN_FALLIDOS = @LOGIN_FALLIDOS,
	EMPRESA_ID = @EMPRESA_ID
	WHERE ID = @ID;
	
COMMIT TRANSACTION;
GO
/****** Object:  StoredProcedure [GOODTIMES].[ModificarCliente]    Script Date: 05/16/2014 22:37:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [GOODTIMES].[ModificarCliente]
@NOMBRE nvarchar(100), 
@APELLIDO nvarchar(100), 
@DNI nvarchar(100), 
@DNI_TIPO nvarchar(100), 
@FECHA_NAC nvarchar(100),
@CLIENTE_ID bigint,

@ID bigint,
@USERNAME nvarchar(100),
@HABILITADO bit, 
@ELIMINADO bit, 
@MAIL nvarchar(100), 
@TELEFONO nvarchar(100), 
@DIRECCION nvarchar(100), 
@CODIGO_POSTAL nvarchar(100), 
@LOCALIDAD nvarchar(100),
@LOGIN_FALLIDOS int

AS
BEGIN TRANSACTION;

	UPDATE GOODTIMES.CLIENTE
	SET NOMBRE = @NOMBRE,
	APELLIDO = @APELLIDO, 
	DNI = @DNI, 
	DNI_TIPO = @DNI_TIPO, 
	FECHA_NAC = @FECHA_NAC
	WHERE ID = @CLIENTE_ID;
	
	UPDATE GOODTIMES.USUARIO
	SET USERNAME = @USERNAME,
	HABILITADO = @HABILITADO,
	ELIMINADO = @ELIMINADO,
	MAIL = @MAIL,
	TELEFONO = @TELEFONO,
	DIRECCION = @DIRECCION,
	CODIGO_POSTAL = @CODIGO_POSTAL,
	LOCALIDAD = @LOCALIDAD,
	LOGIN_FALLIDOS = @LOGIN_FALLIDOS
	WHERE ID = @ID;
	
COMMIT TRANSACTION;
GO
/****** Object:  StoredProcedure [GOODTIMES].[login]    Script Date: 05/16/2014 22:37:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

-- Devuelve FUNCIONES, 0 si logro loguearse (aunque no tenga funciones)
-- Devuelve NULL, 1 si la contraseña es incorrecta
-- Devuelve NULL, 2 si el usuario es inexistente
-- Devuelve NULL, 3 si el usuario exedio la cantidad de intentos

CREATE PROCEDURE [GOODTIMES].[login]
	@USUARIO nvarchar(255),
	@CONTRASENIA nvarchar(255)
AS
BEGIN
	SET NOCOUNT ON;
	   
	declare @CANT_INT INT
	set @CANT_INT = -1
	
	
	select @CANT_INT = LOGIN_FALLIDOS
	from GOODTIMES.USUARIO
	where @USUARIO = USERNAME
	
	IF (@CANT_INT >= 3)
	BEGIN
		select 3 ESTADO
	END
	IF (@CANT_INT = -1)
	BEGIN
		
		select 2 ESTADO
	END
	
	IF (@CANT_INT >= 0 AND @CANT_INT < 3)
	BEGIN
	
		IF(ISNULL((select TOP 1 1 from GOODTIMES.USUARIO where @USUARIO = USERNAME and @CONTRASENIA = PASSWORD),0) = 1)
		BEGIN
	
			UPDATE [GD1C2014].[GOODTIMES].[USUARIO]
			SET [LOGIN_FALLIDOS] = 0
			WHERE USERNAME = @USUARIO
    		
			select 0 ESTADO
		
		END
		ELSE
		BEGIN
			
			UPDATE [GD1C2014].[GOODTIMES].[USUARIO]
			SET [LOGIN_FALLIDOS] += 1
			WHERE USERNAME = @USUARIO
		
			select  1 ESTADO

		END
	END

END
GO
/****** Object:  StoredProcedure [GOODTIMES].[EliminarUsuario]    Script Date: 05/16/2014 22:37:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [GOODTIMES].[EliminarUsuario]
@ID bigint

AS
	UPDATE GOODTIMES.USUARIO
	SET ELIMINADO = 1
	WHERE ID = @ID;
GO
/****** Object:  StoredProcedure [GOODTIMES].[CrearEmpresa]    Script Date: 05/16/2014 22:37:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [GOODTIMES].[CrearEmpresa]
@RAZON_SOCIAL nvarchar(100), 
@CUIT bigint,
@CONTACTO nvarchar(100), 
@FECHA_CREACION nvarchar(100),

@USERNAME nvarchar(100), 
@PASSWORD nvarchar(100),
@LOGIN_FALLIDOS int, 
@HABILITADO bit, 
@ELIMINADO bit, 
@MAIL nvarchar(100), 
@TELEFONO nvarchar(100), 
@DIRECCION nvarchar(100), 
@CODIGO_POSTAL nvarchar(100), 
@LOCALIDAD nvarchar(100)

AS
BEGIN TRANSACTION;

	INSERT INTO GOODTIMES.EMPRESA(CUIT, RAZON_SOCIAL, CONTACTO, FECHA_CREACION)
	VALUES (@CUIT, @RAZON_SOCIAL, @CONTACTO, @FECHA_CREACION);
	
	INSERT INTO GOODTIMES.USUARIO(USERNAME, PASSWORD, EMPRESA_ID, LOGIN_FALLIDOS, HABILITADO, ELIMINADO, MAIL, TELEFONO, DIRECCION, CODIGO_POSTAL, LOCALIDAD)
	VALUES (@USERNAME, @PASSWORD, SCOPE_IDENTITY(), @LOGIN_FALLIDOS, @HABILITADO, @ELIMINADO, @MAIL, @TELEFONO, @DIRECCION, @CODIGO_POSTAL, @LOCALIDAD);
	
COMMIT TRANSACTION;
GO
/****** Object:  StoredProcedure [GOODTIMES].[CrearCliente]    Script Date: 05/16/2014 22:37:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [GOODTIMES].[CrearCliente]
@NOMBRE nvarchar(100), 
@APELLIDO nvarchar(100), 
@DNI nvarchar(100), 
@DNI_TIPO nvarchar(100), 
@FECHA_NAC nvarchar(100),

@USERNAME nvarchar(100), 
@PASSWORD nvarchar(100),
@LOGIN_FALLIDOS int, 
@HABILITADO bit, 
@ELIMINADO bit, 
@MAIL nvarchar(100), 
@TELEFONO nvarchar(100), 
@DIRECCION nvarchar(100), 
@CODIGO_POSTAL nvarchar(100), 
@LOCALIDAD nvarchar(100)

AS
BEGIN TRANSACTION;

	INSERT INTO GOODTIMES.CLIENTE(NOMBRE, APELLIDO, DNI, DNI_TIPO, FECHA_NAC)
	VALUES (@NOMBRE, @APELLIDO, @DNI, @DNI_TIPO, @FECHA_NAC);
	
	INSERT INTO GOODTIMES.USUARIO(USERNAME, PASSWORD, CLIENTE_ID, LOGIN_FALLIDOS, HABILITADO, ELIMINADO, MAIL, TELEFONO, DIRECCION, CODIGO_POSTAL, LOCALIDAD)
	VALUES (@USERNAME, @PASSWORD, SCOPE_IDENTITY(), @LOGIN_FALLIDOS, @HABILITADO, @ELIMINADO, @MAIL, @TELEFONO, @DIRECCION, @CODIGO_POSTAL, @LOCALIDAD);
	
COMMIT TRANSACTION;
GO
/****** Object:  StoredProcedure [GOODTIMES].[AgregarFuncionalidadARol]    Script Date: 05/16/2014 22:37:57 ******/
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
/****** Object:  StoredProcedure [GOODTIMES].[BuscarUsuarioPorUsername]    Script Date: 05/16/2014 22:37:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [GOODTIMES].[BuscarUsuarioPorUsername]
@USERNAME nvarchar(100)

AS
	SELECT * FROM GOODTIMES.USUARIO 
	WHERE USERNAME = @USERNAME;
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarFuncionalidadSinAsignarARol]    Script Date: 05/16/2014 22:37:57 ******/
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
/****** Object:  StoredProcedure [GOODTIMES].[BuscarEmpresas]    Script Date: 05/16/2014 22:37:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [GOODTIMES].[BuscarEmpresas]
@RAZON_SOCIAL nvarchar(100), 
@CUIT nvarchar(100),
@CONTACTO nvarchar(100)
AS
	BEGIN
		SELECT E.CUIT, E.RAZON_SOCIAL, E.CONTACTO, E.FECHA_CREACION, U.ID, U.USERNAME, U.EMPRESA_ID, U.LOGIN_FALLIDOS, U.HABILITADO, U.ELIMINADO, U.MAIL, U.TELEFONO, U.DIRECCION, U.CODIGO_POSTAL, U.LOCALIDAD 
		FROM GOODTIMES.USUARIO U, GOODTIMES.EMPRESA E 
		WHERE U.EMPRESA_ID = E.ID
		AND E.RAZON_SOCIAL like ISNULL('%' + @RAZON_SOCIAL + '%', '%')
		AND E.CUIT like ISNULL('%' + @CUIT + '%', '%')
		AND E.CONTACTO like ISNULL('%' + @CONTACTO + '%', '%')
		AND U.ELIMINADO = 0;
	END
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarEmpresaPorRazonSocial]    Script Date: 05/16/2014 22:37:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [GOODTIMES].[BuscarEmpresaPorRazonSocial]
@RAZON_SOCIAL nvarchar(100)

AS
	SELECT E.CUIT, E.RAZON_SOCIAL, E.CONTACTO, E.FECHA_CREACION, U.ID, U.USERNAME, U.CLIENTE_ID, U.LOGIN_FALLIDOS, U.HABILITADO, U.ELIMINADO, U.MAIL, U.TELEFONO, U.DIRECCION, U.CODIGO_POSTAL, U.LOCALIDAD 
	FROM GOODTIMES.USUARIO U, GOODTIMES.EMPRESA E 
	WHERE U.EMPRESA_ID = E.ID AND
	E.RAZON_SOCIAL = @RAZON_SOCIAL;
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarEmpresaPorCuit]    Script Date: 05/16/2014 22:37:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [GOODTIMES].[BuscarEmpresaPorCuit]
@CUIT bigint

AS
	SELECT E.CUIT, E.RAZON_SOCIAL, E.CONTACTO, E.FECHA_CREACION, U.ID, U.USERNAME, U.CLIENTE_ID, U.LOGIN_FALLIDOS, U.HABILITADO, U.ELIMINADO, U.MAIL, U.TELEFONO, U.DIRECCION, U.CODIGO_POSTAL, U.LOCALIDAD
	FROM GOODTIMES.USUARIO U, GOODTIMES.EMPRESA E 
	WHERE U.EMPRESA_ID = E.ID AND
	E.CUIT = @CUIT;
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarClientes]    Script Date: 05/16/2014 22:37:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*

drop procedure GOODTIMES.BuscarClientes;
drop procedure GOODTIMES.CrearCliente;
drop procedure GOODTIMES.CrearEmpresa;
drop procedure GOODTIMES.BuscarEmpresaPorRazonSocial;
drop procedure GOODTIMES.BuscarEmpresaPorCuit;
drop procedure GOODTIMES.BuscarClientePorTelefono;
drop procedure GOODTIMES.BuscarClientePorDNITipoYDNI;
drop procedure GOODTIMES.BuscarUsuarioPorUsername;
drop procedure GOODTIMES.ModificarCliente;
drop procedure GOODTIMES.EliminarUsuario;
drop procedure GOODTIMES.ModificarEmpresa;
drop procedure GOODTIMES.BuscarEmpresas;

*/

CREATE PROCEDURE [GOODTIMES].[BuscarClientes]
@NOMBRE nvarchar(100), 
@APELLIDO nvarchar(100),
@MAIL nvarchar(100), 
@DNI_TIPO nvarchar(10),
@DNI nvarchar(100)
AS
	BEGIN
		SELECT U.ID, U.USERNAME, U.CLIENTE_ID, U.LOGIN_FALLIDOS, U.HABILITADO, U.ELIMINADO, U.MAIL, U.TELEFONO, U.DIRECCION, U.CODIGO_POSTAL, U.LOCALIDAD, C.NOMBRE, C.APELLIDO, C.APELLIDO, C.DNI, C.DNI_TIPO, C.FECHA_NAC 
		FROM GOODTIMES.CLIENTE C, GOODTIMES.USUARIO U
		WHERE U.CLIENTE_ID = C.ID 
		AND C.NOMBRE like ISNULL('%' + @NOMBRE + '%', '%')
		AND C.APELLIDO like ISNULL('%' + @APELLIDO + '%', '%')
		AND U.MAIL like ISNULL('%' + @MAIL + '%', '%')
		AND C.DNI_TIPO like ISNULL('%' + @DNI_TIPO + '%', '%')
		AND C.DNI like ISNULL('%' + @DNI + '%', '%')
		AND U.ELIMINADO = 0;
	END
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarClientePorTelefono]    Script Date: 05/16/2014 22:37:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [GOODTIMES].[BuscarClientePorTelefono]
@TELEFONO nvarchar(100)

AS
	SELECT U.ID, U.USERNAME, U.CLIENTE_ID, U.LOGIN_FALLIDOS, U.HABILITADO, U.ELIMINADO, U.MAIL, U.TELEFONO, U.DIRECCION, U.CODIGO_POSTAL, U.LOCALIDAD, C.NOMBRE, C.APELLIDO, C.APELLIDO, C.DNI, C.DNI_TIPO, C.FECHA_NAC 
	FROM GOODTIMES.CLIENTE C, GOODTIMES.USUARIO U 
	WHERE U.CLIENTE_ID = C.ID AND
	      U.TELEFONO = @TELEFONO;
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarClientePorDNITipoYDNI]    Script Date: 05/16/2014 22:37:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [GOODTIMES].[BuscarClientePorDNITipoYDNI]
@DNI_TIPO nvarchar(10),
@DNI nvarchar(100)

AS
	SELECT U.ID, U.USERNAME, U.CLIENTE_ID, U.LOGIN_FALLIDOS, U.HABILITADO, U.ELIMINADO, U.MAIL, U.TELEFONO, U.DIRECCION, U.CODIGO_POSTAL, U.LOCALIDAD, C.NOMBRE, C.APELLIDO, C.APELLIDO, C.DNI, C.DNI_TIPO, C.FECHA_NAC 
	FROM GOODTIMES.CLIENTE C, GOODTIMES.USUARIO U 
	WHERE U.CLIENTE_ID = C.ID AND
	C.DNI_TIPO = @DNI_TIPO AND
	c.DNI = @DNI;
GO
