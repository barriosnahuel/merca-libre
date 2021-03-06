USE [GD1C2014]
GO
/****** Object:  StoredProcedure [GOODTIMES].[AgregarRubroAPublicacion]    Script Date: 06/07/2014 19:56:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[AgregarRubroAPublicacion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[AgregarRubroAPublicacion]
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarPreguntas]    Script Date: 06/07/2014 19:56:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarPreguntas]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[BuscarPreguntas]
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarRubroPorPublicacion]    Script Date: 06/07/2014 19:56:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarRubroPorPublicacion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[BuscarRubroPorPublicacion]
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarRubrosNotPublicacion]    Script Date: 06/07/2014 19:56:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarRubrosNotPublicacion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[BuscarRubrosNotPublicacion]
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarPublicacionesActivas]    Script Date: 06/07/2014 19:56:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarPublicacionesActivas]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[BuscarPublicacionesActivas]
GO
/****** Object:  StoredProcedure [GOODTIMES].[CrearItemFactura]    Script Date: 06/07/2014 19:56:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[CrearItemFactura]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[CrearItemFactura]
GO
/****** Object:  StoredProcedure [GOODTIMES].[CrearOferta]    Script Date: 06/07/2014 19:56:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[CrearOferta]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[CrearOferta]
GO
/****** Object:  StoredProcedure [GOODTIMES].[GuardarCalificacion]    Script Date: 06/07/2014 19:56:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[GuardarCalificacion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[GuardarCalificacion]
GO
/****** Object:  StoredProcedure [GOODTIMES].[GuardarCompra]    Script Date: 06/07/2014 19:56:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[GuardarCompra]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[GuardarCompra]
GO
/****** Object:  StoredProcedure [GOODTIMES].[QuitarRubroAPublicacion]    Script Date: 06/07/2014 19:56:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[QuitarRubroAPublicacion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[QuitarRubroAPublicacion]
GO
/****** Object:  StoredProcedure [GOODTIMES].[ResponderPregunta]    Script Date: 06/07/2014 19:56:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[ResponderPregunta]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[ResponderPregunta]
GO
/****** Object:  StoredProcedure [GOODTIMES].[GuardarPublicacion]    Script Date: 06/07/2014 19:56:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[GuardarPublicacion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[GuardarPublicacion]
GO
/****** Object:  StoredProcedure [GOODTIMES].[CrearFactura]    Script Date: 06/07/2014 19:56:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[CrearFactura]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[CrearFactura]
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarPublicacion]    Script Date: 06/07/2014 19:56:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarPublicacion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[BuscarPublicacion]
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarPublicaciones]    Script Date: 06/07/2014 19:56:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarPublicaciones]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[BuscarPublicaciones]
GO
/****** Object:  StoredProcedure [GOODTIMES].[CrearCliente]    Script Date: 06/07/2014 19:56:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[CrearCliente]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[CrearCliente]
GO
/****** Object:  StoredProcedure [GOODTIMES].[CrearEmpresa]    Script Date: 06/07/2014 19:56:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[CrearEmpresa]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[CrearEmpresa]
GO
/****** Object:  StoredProcedure [GOODTIMES].[CrearEstadoPublicacion]    Script Date: 06/07/2014 19:56:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[CrearEstadoPublicacion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[CrearEstadoPublicacion]
GO
/****** Object:  StoredProcedure [GOODTIMES].[CrearTipoPublicacion]    Script Date: 06/07/2014 19:56:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[CrearTipoPublicacion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[CrearTipoPublicacion]
GO
/****** Object:  StoredProcedure [GOODTIMES].[CrearVisibilidadPublicacion]    Script Date: 06/07/2014 19:56:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[CrearVisibilidadPublicacion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[CrearVisibilidadPublicacion]
GO
/****** Object:  StoredProcedure [GOODTIMES].[EliminarUsuario]    Script Date: 06/07/2014 19:56:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[EliminarUsuario]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[EliminarUsuario]
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarClientePorDNITipoYDNI]    Script Date: 06/07/2014 19:56:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarClientePorDNITipoYDNI]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[BuscarClientePorDNITipoYDNI]
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarClientePorTelefono]    Script Date: 06/07/2014 19:56:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarClientePorTelefono]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[BuscarClientePorTelefono]
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarClientes]    Script Date: 06/07/2014 19:56:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarClientes]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[BuscarClientes]
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarEmpresaPorCuit]    Script Date: 06/07/2014 19:56:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarEmpresaPorCuit]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[BuscarEmpresaPorCuit]
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarEmpresaPorRazonSocial]    Script Date: 06/07/2014 19:56:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarEmpresaPorRazonSocial]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[BuscarEmpresaPorRazonSocial]
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarEmpresas]    Script Date: 06/07/2014 19:56:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarEmpresas]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[BuscarEmpresas]
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarFuncionalidadSinAsignarARol]    Script Date: 06/07/2014 19:56:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarFuncionalidadSinAsignarARol]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[BuscarFuncionalidadSinAsignarARol]
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarUsuarioPorUsername]    Script Date: 06/07/2014 19:56:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarUsuarioPorUsername]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[BuscarUsuarioPorUsername]
GO
/****** Object:  StoredProcedure [GOODTIMES].[QuitarFuncionalidadARol]    Script Date: 06/07/2014 19:56:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[QuitarFuncionalidadARol]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[QuitarFuncionalidadARol]
GO
/****** Object:  StoredProcedure [GOODTIMES].[ListarFuncionalidadPorRol]    Script Date: 06/07/2014 19:56:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[ListarFuncionalidadPorRol]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[ListarFuncionalidadPorRol]
GO
/****** Object:  StoredProcedure [GOODTIMES].[login]    Script Date: 06/07/2014 19:56:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[login]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[login]
GO
/****** Object:  StoredProcedure [GOODTIMES].[ModificarCliente]    Script Date: 06/07/2014 19:56:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[ModificarCliente]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[ModificarCliente]
GO
/****** Object:  StoredProcedure [GOODTIMES].[ModificarEmpresa]    Script Date: 06/07/2014 19:56:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[ModificarEmpresa]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[ModificarEmpresa]
GO
/****** Object:  StoredProcedure [GOODTIMES].[AgregarFuncionalidadARol]    Script Date: 06/07/2014 19:56:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[AgregarFuncionalidadARol]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[AgregarFuncionalidadARol]
GO
/****** Object:  StoredProcedure [GOODTIMES].[ListarRoles]    Script Date: 06/07/2014 19:56:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[ListarRoles]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[ListarRoles]
GO
/****** Object:  StoredProcedure [GOODTIMES].[ListarRubros]    Script Date: 06/07/2014 19:56:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[ListarRubros]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[ListarRubros]
GO
/****** Object:  StoredProcedure [GOODTIMES].[ListarTipoPublicacion]    Script Date: 06/07/2014 19:56:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[ListarTipoPublicacion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[ListarTipoPublicacion]
GO
/****** Object:  StoredProcedure [GOODTIMES].[ListarVisibilidadPublicacion]    Script Date: 06/07/2014 19:56:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[ListarVisibilidadPublicacion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[ListarVisibilidadPublicacion]
GO
/****** Object:  StoredProcedure [GOODTIMES].[CrearFormaPago]    Script Date: 06/07/2014 19:56:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[CrearFormaPago]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[CrearFormaPago]
GO
/****** Object:  StoredProcedure [GOODTIMES].[CrearRubro]    Script Date: 06/07/2014 19:56:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[CrearRubro]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[CrearRubro]
GO
/****** Object:  StoredProcedure [GOODTIMES].[GuardarRol]    Script Date: 06/07/2014 19:56:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[GuardarRol]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[GuardarRol]
GO
/****** Object:  StoredProcedure [GOODTIMES].[ListarFuncionalidad]    Script Date: 06/07/2014 19:56:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[ListarFuncionalidad]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[ListarFuncionalidad]
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarVisibilidad]    Script Date: 06/07/2014 19:56:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarVisibilidad]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[BuscarVisibilidad]
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarRolPorId]    Script Date: 06/07/2014 19:56:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarRolPorId]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[BuscarRolPorId]
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarRolPorNombre]    Script Date: 06/07/2014 19:56:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarRolPorNombre]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[BuscarRolPorNombre]
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarTipoPublicacion]    Script Date: 06/07/2014 19:56:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarTipoPublicacion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[BuscarTipoPublicacion]
GO
/****** Object:  StoredProcedure [GOODTIMES].[BajaRol]    Script Date: 06/07/2014 19:56:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BajaRol]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[BajaRol]
GO
/****** Object:  StoredProcedure [GOODTIMES].[BajaRol]    Script Date: 06/07/2014 19:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BajaRol]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [GOODTIMES].[BajaRol]
        @ID INT

AS
    BEGIN
        SET NOCOUNT ON;
        UPDATE [GOODTIMES].[ROL]
        SET ELIMINADO = 1
        WHERE [GOODTIMES].[ROL].ID = @ID


    END
'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarTipoPublicacion]    Script Date: 06/07/2014 19:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarTipoPublicacion]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'


CREATE PROCEDURE [GOODTIMES].[BuscarTipoPublicacion]
		@ID                  BIGINT

AS
    BEGIN
	select * from GOODTIMES.TIPO_PUBLICACION where ID = @ID;
    END




'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarRolPorNombre]    Script Date: 06/07/2014 19:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarRolPorNombre]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [GOODTIMES].[BuscarRolPorNombre]
        @NOMBRE NVARCHAR(100)
AS
    BEGIN
        SELECT *
        FROM GOODTIMES.ROL R
        WHERE R.ELIMINADO = 0 AND R.NOMBRE LIKE ''%'' + @NOMBRE + ''%''
    END
'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarRolPorId]    Script Date: 06/07/2014 19:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarRolPorId]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [GOODTIMES].[BuscarRolPorId]
        @ID INT
AS
    BEGIN
        SELECT *
        FROM GOODTIMES.ROL R
        WHERE R.ID = @ID
    END
'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarVisibilidad]    Script Date: 06/07/2014 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarVisibilidad]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'


CREATE PROCEDURE [GOODTIMES].[BuscarVisibilidad]
		@ID                  BIGINT

AS
    BEGIN
	select * from GOODTIMES.VISIBILIDAD_PUBLICACION where ID = @ID;
    END




'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[ListarFuncionalidad]    Script Date: 06/07/2014 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[ListarFuncionalidad]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [GOODTIMES].[ListarFuncionalidad]
        @ID_ROL INTEGER
AS
    BEGIN
        SELECT F.*
        FROM GOODTIMES.FUNCIONALIDAD F

    END
'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[GuardarRol]    Script Date: 06/07/2014 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[GuardarRol]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [GOODTIMES].[GuardarRol]
        @ID         INT,
        @NOMBRE     NVARCHAR(100),
        @HABILITADO BIT,
        @ELIMINADO  BIT
AS
    BEGIN
        SET NOCOUNT ON;

        IF @ID = -1
            BEGIN
                INSERT INTO [GOODTIMES].[ROL]
                ([NOMBRE]
                    , [HABILITADO]
                    , [ELIMINADO])
                VALUES
                    (@NOMBRE, @HABILITADO, 0)
                SELECT @@Identity AS ID
            END
        ELSE BEGIN

            UPDATE [GOODTIMES].[ROL]
            SET [NOMBRE]       = @NOMBRE
                , [HABILITADO] = @HABILITADO
                , [ELIMINADO]  = @ELIMINADO
            WHERE @ID = ID

            SELECT @ID
        END


    END
'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[CrearRubro]    Script Date: 06/07/2014 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[CrearRubro]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [GOODTIMES].[CrearRubro]
        @descripcion NVARCHAR(max),
        @rubroId INT OUTPUT

AS
    BEGIN
        SET NOCOUNT ON;

        SET @rubroId = (SELECT CODIGO FROM GOODTIMES.RUBRO WHERE DESCRIPCION = @descripcion)

        IF (@rubroId IS NULL)
            BEGIN
                INSERT INTO [GD1C2014].[GOODTIMES].[RUBRO]
                ([DESCRIPCION])
                VALUES
                    (@descripcion)

                SET @rubroId = @@IDENTITY
            END
    END


'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[CrearFormaPago]    Script Date: 06/07/2014 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[CrearFormaPago]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [GOODTIMES].[CrearFormaPago]
        @DESCRIPCION nvarchar(max)
AS
    BEGIN
        SET NOCOUNT ON;

        INSERT INTO [GOODTIMES].[FORMA_PAGO] (DESCRIPCION)
                VALUES (@DESCRIPCION)

    END


'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[ListarVisibilidadPublicacion]    Script Date: 06/07/2014 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[ListarVisibilidadPublicacion]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'



-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [GOODTIMES].[ListarVisibilidadPublicacion]
as

begin
SELECT vp.*
  FROM [GOODTIMES].[VISIBILIDAD_PUBLICACION] vp
end




'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[ListarTipoPublicacion]    Script Date: 06/07/2014 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[ListarTipoPublicacion]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [GOODTIMES].[ListarTipoPublicacion]
AS
    BEGIN
        SELECT TP.*
  FROM [GOODTIMES].[TIPO_PUBLICACION] TP
	order by TP.DESCRIPCION
    END
'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[ListarRubros]    Script Date: 06/07/2014 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[ListarRubros]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [GOODTIMES].[ListarRubros]
as

begin
SELECT r.*
  FROM [GD1C2014].[GOODTIMES].[RUBRO] r
  order by r.DESCRIPCION
end
'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[ListarRoles]    Script Date: 06/07/2014 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[ListarRoles]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [GOODTIMES].[ListarRoles]
AS
    BEGIN
        SELECT *
        FROM GOODTIMES.ROL
        WHERE ELIMINADO = 0
        order by ROL.NOMBRE
    END
'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[AgregarFuncionalidadARol]    Script Date: 06/07/2014 19:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[AgregarFuncionalidadARol]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [GOODTIMES].[AgregarFuncionalidadARol]
        @ROL_ID           INT,
        @FUNCIONALIDAD_ID INT
AS
    BEGIN
        SET NOCOUNT ON;

        INSERT INTO [GD1C2014].[GOODTIMES].[FUNCIONALIDAD_X_ROL]
        ([ROL_ID]
            , [FUNCIONALIDAD_ID])
        VALUES
            (@ROL_ID
                , @FUNCIONALIDAD_ID)
    END

'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[ModificarEmpresa]    Script Date: 06/07/2014 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[ModificarEmpresa]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [GOODTIMES].[ModificarEmpresa]

        @RAZON_SOCIAL   NVARCHAR(100),
        @CUIT           NVARCHAR(100),
        @CONTACTO       NVARCHAR(100),
        @FECHA_CREACION NVARCHAR(100),
        @EMPRESA_ID     BIGINT,

        @ID             BIGINT,
        @USERNAME       NVARCHAR(100),
        @LOGIN_FALLIDOS INT,
        @HABILITADO     BIT,
        @ELIMINADO      BIT,
        @MAIL           NVARCHAR(100),
        @TELEFONO       NVARCHAR(100),
        @DIRECCION      NVARCHAR(100),
        @CODIGO_POSTAL  NVARCHAR(100),
        @LOCALIDAD      NVARCHAR(100)

AS
    BEGIN TRANSACTION

    UPDATE GOODTIMES.EMPRESA
    SET RAZON_SOCIAL   = @RAZON_SOCIAL,
        CONTACTO       = @CONTACTO,
        FECHA_CREACION = @FECHA_CREACION,
        CUIT           = @CUIT
    WHERE ID = @EMPRESA_ID;


    UPDATE GOODTIMES.USUARIO
    SET USERNAME       = @USERNAME,
        HABILITADO     = @HABILITADO,
        ELIMINADO      = @ELIMINADO,
        MAIL           = @MAIL,
        TELEFONO       = @TELEFONO,
        DIRECCION      = @DIRECCION,
        CODIGO_POSTAL  = @CODIGO_POSTAL,
        LOCALIDAD      = @LOCALIDAD,
        LOGIN_FALLIDOS = @LOGIN_FALLIDOS,
        EMPRESA_ID     = @EMPRESA_ID
    WHERE ID = @ID;

    COMMIT TRANSACTION;
'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[ModificarCliente]    Script Date: 06/07/2014 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[ModificarCliente]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [GOODTIMES].[ModificarCliente]
        @NOMBRE         NVARCHAR(100),
        @APELLIDO       NVARCHAR(100),
        @DNI            NVARCHAR(100),
        @DNI_TIPO       NVARCHAR(100),
        @FECHA_NAC      NVARCHAR(100),
        @CLIENTE_ID     BIGINT,

        @ID             BIGINT,
        @USERNAME       NVARCHAR(100),
        @HABILITADO     BIT,
        @ELIMINADO      BIT,
        @MAIL           NVARCHAR(100),
        @TELEFONO       NVARCHAR(100),
        @DIRECCION      NVARCHAR(100),
        @CODIGO_POSTAL  NVARCHAR(100),
        @LOCALIDAD      NVARCHAR(100),
        @LOGIN_FALLIDOS INT

AS
    BEGIN TRANSACTION;

    UPDATE GOODTIMES.CLIENTE
    SET NOMBRE    = @NOMBRE,
        APELLIDO  = @APELLIDO,
        DNI       = @DNI,
        DNI_TIPO  = @DNI_TIPO,
        FECHA_NAC = @FECHA_NAC
    WHERE ID = @CLIENTE_ID;

    UPDATE GOODTIMES.USUARIO
    SET USERNAME       = @USERNAME,
        HABILITADO     = @HABILITADO,
        ELIMINADO      = @ELIMINADO,
        MAIL           = @MAIL,
        TELEFONO       = @TELEFONO,
        DIRECCION      = @DIRECCION,
        CODIGO_POSTAL  = @CODIGO_POSTAL,
        LOCALIDAD      = @LOCALIDAD,
        LOGIN_FALLIDOS = @LOGIN_FALLIDOS
    WHERE ID = @ID;

    COMMIT TRANSACTION;
'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[login]    Script Date: 06/07/2014 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[login]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

-- Devuelve FUNCIONES, 0 si logro loguearse (aunque no tenga funciones)
-- Devuelve NULL, 1 si la contraseña es incorrecta
-- Devuelve NULL, 2 si el usuario es inexistente
-- Devuelve NULL, 3 si el usuario exedio la cantidad de intentos

CREATE PROCEDURE [GOODTIMES].[login]
        @USUARIO     NVARCHAR(255),
        @CONTRASENIA NVARCHAR(255)
AS
    BEGIN
        SET NOCOUNT ON;

        DECLARE @CANT_INT INT
        SET @CANT_INT = -1


        SELECT @CANT_INT = LOGIN_FALLIDOS
        FROM GOODTIMES.USUARIO
        WHERE @USUARIO = USERNAME

        IF (@CANT_INT >= 3)
            BEGIN
                SELECT 3 ESTADO
            END
        IF (@CANT_INT = -1)
            BEGIN

                SELECT 2 ESTADO
            END

        IF (@CANT_INT >= 0 AND @CANT_INT < 3)
            BEGIN

                IF (ISNULL((
                               SELECT TOP 1 1
                               FROM GOODTIMES.USUARIO
                               WHERE @USUARIO = USERNAME AND @CONTRASENIA = PASSWORD), 0) = 1)
                    BEGIN

                        UPDATE [GD1C2014].[GOODTIMES].[USUARIO]
                        SET [LOGIN_FALLIDOS] = 0
                        WHERE USERNAME = @USUARIO

                        SELECT 0 ESTADO

                    END
                ELSE
                    BEGIN

                        UPDATE [GD1C2014].[GOODTIMES].[USUARIO]
                        SET [LOGIN_FALLIDOS] += 1
                        WHERE USERNAME = @USUARIO

                        SELECT 1 ESTADO

                    END
            END

    END
'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[ListarFuncionalidadPorRol]    Script Date: 06/07/2014 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[ListarFuncionalidadPorRol]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [GOODTIMES].[ListarFuncionalidadPorRol]
        @ID_ROL INTEGER
AS
    BEGIN
        SELECT F.*
        FROM GOODTIMES.FUNCIONALIDAD F
            JOIN GOODTIMES.FUNCIONALIDAD_X_ROL FR ON F.ID = FR.FUNCIONALIDAD_ID
        WHERE FR.ROL_ID = @ID_ROL
    END
'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[QuitarFuncionalidadARol]    Script Date: 06/07/2014 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[QuitarFuncionalidadARol]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [GOODTIMES].[QuitarFuncionalidadARol]
        @ROL_ID           INT,
        @FUNCIONALIDAD_ID INT
AS
    BEGIN
        SET NOCOUNT ON;

        DELETE FROM [GOODTIMES].[FUNCIONALIDAD_X_ROL]
        WHERE (@ROL_ID = GOODTIMES.FUNCIONALIDAD_X_ROL.ROL_ID
               AND @FUNCIONALIDAD_ID = GOODTIMES.FUNCIONALIDAD_X_ROL.FUNCIONALIDAD_ID)
    END
'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarUsuarioPorUsername]    Script Date: 06/07/2014 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarUsuarioPorUsername]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [GOODTIMES].[BuscarUsuarioPorUsername]
        @USERNAME NVARCHAR(100)

AS
    SELECT * FROM GOODTIMES.USUARIO 
    WHERE USERNAME = @USERNAME;
'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarFuncionalidadSinAsignarARol]    Script Date: 06/07/2014 19:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarFuncionalidadSinAsignarARol]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [GOODTIMES].[BuscarFuncionalidadSinAsignarARol]
        @ID_ROL INTEGER
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
'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarEmpresas]    Script Date: 06/07/2014 19:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarEmpresas]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [GOODTIMES].[BuscarEmpresas]
        @RAZON_SOCIAL NVARCHAR(100),
        @CUIT         NVARCHAR(100),
        @CONTACTO     NVARCHAR(100)
AS
    BEGIN
        SELECT E.CUIT
            , E.RAZON_SOCIAL
            , E.CONTACTO
            , E.FECHA_CREACION
            , U.ID
            , U.USERNAME
            , U.EMPRESA_ID
            , U.LOGIN_FALLIDOS
            , U.HABILITADO
            , U.ELIMINADO
            , U.MAIL
            , U.TELEFONO
            , U.DIRECCION
            , U.CODIGO_POSTAL
            , U.LOCALIDAD
        FROM GOODTIMES.USUARIO U, GOODTIMES.EMPRESA E
        WHERE U.EMPRESA_ID = E.ID
              AND E.RAZON_SOCIAL LIKE ISNULL(''%'' + @RAZON_SOCIAL + ''%'', ''%'')
              AND E.CUIT LIKE ISNULL(''%'' + @CUIT + ''%'', ''%'')
              AND E.CONTACTO LIKE ISNULL(''%'' + @CONTACTO + ''%'', ''%'')
              AND U.ELIMINADO = 0;
    END
'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarEmpresaPorRazonSocial]    Script Date: 06/07/2014 19:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarEmpresaPorRazonSocial]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [GOODTIMES].[BuscarEmpresaPorRazonSocial]
        @RAZON_SOCIAL NVARCHAR(100)

AS
    SELECT E.CUIT
        , E.RAZON_SOCIAL
        , E.CONTACTO
        , E.FECHA_CREACION
        , U.ID
        , U.USERNAME
        , U.EMPRESA_ID
        , U.LOGIN_FALLIDOS
        , U.HABILITADO
        , U.ELIMINADO
        , U.MAIL
        , U.TELEFONO
        , U.DIRECCION
        , U.CODIGO_POSTAL
        , U.LOCALIDAD
    FROM GOODTIMES.USUARIO U, GOODTIMES.EMPRESA E
    WHERE U.EMPRESA_ID = E.ID AND
          E.RAZON_SOCIAL = @RAZON_SOCIAL;
'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarEmpresaPorCuit]    Script Date: 06/07/2014 19:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarEmpresaPorCuit]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [GOODTIMES].[BuscarEmpresaPorCuit]
        @CUIT NVARCHAR(100)

AS
    SELECT E.CUIT
        , E.RAZON_SOCIAL
        , E.CONTACTO
        , E.FECHA_CREACION
        , U.ID
        , U.USERNAME
        , U.EMPRESA_ID
        , U.LOGIN_FALLIDOS
        , U.HABILITADO
        , U.ELIMINADO
        , U.MAIL
        , U.TELEFONO
        , U.DIRECCION
        , U.CODIGO_POSTAL
        , U.LOCALIDAD
    FROM GOODTIMES.USUARIO U, GOODTIMES.EMPRESA E
    WHERE U.EMPRESA_ID = E.ID AND
          E.CUIT = @CUIT;
'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarClientes]    Script Date: 06/07/2014 19:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarClientes]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [GOODTIMES].[BuscarClientes]
        @NOMBRE   NVARCHAR(100),
        @APELLIDO NVARCHAR(100),
        @MAIL     NVARCHAR(100),
        @DNI_TIPO NVARCHAR(10),
        @DNI      NVARCHAR(100)
AS
    BEGIN
        SELECT U.ID
            , U.USERNAME
            , U.CLIENTE_ID
            , U.LOGIN_FALLIDOS
            , U.HABILITADO
            , U.ELIMINADO
            , U.MAIL
            , U.TELEFONO
            , U.DIRECCION
            , U.CODIGO_POSTAL
            , U.LOCALIDAD
            , C.NOMBRE
            , C.APELLIDO
            , C.APELLIDO
            , C.DNI
            , C.DNI_TIPO
            , C.FECHA_NAC
        FROM GOODTIMES.CLIENTE C, GOODTIMES.USUARIO U
        WHERE U.CLIENTE_ID = C.ID
              AND C.NOMBRE LIKE ISNULL(''%'' + @NOMBRE + ''%'', ''%'')
              AND C.APELLIDO LIKE ISNULL(''%'' + @APELLIDO + ''%'', ''%'')
              AND U.MAIL LIKE ISNULL(''%'' + @MAIL + ''%'', ''%'')
              AND C.DNI_TIPO LIKE ISNULL(''%'' + @DNI_TIPO + ''%'', ''%'')
              AND C.DNI LIKE ISNULL(''%'' + @DNI + ''%'', ''%'')
              AND U.ELIMINADO = 0;
    END
'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarClientePorTelefono]    Script Date: 06/07/2014 19:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarClientePorTelefono]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [GOODTIMES].[BuscarClientePorTelefono]
        @TELEFONO NVARCHAR(100)

AS
    SELECT U.ID
        , U.USERNAME
        , U.CLIENTE_ID
        , U.LOGIN_FALLIDOS
        , U.HABILITADO
        , U.ELIMINADO
        , U.MAIL
        , U.TELEFONO
        , U.DIRECCION
        , U.CODIGO_POSTAL
        , U.LOCALIDAD
        , C.NOMBRE
        , C.APELLIDO
        , C.APELLIDO
        , C.DNI
        , C.DNI_TIPO
        , C.FECHA_NAC
    FROM GOODTIMES.CLIENTE C, GOODTIMES.USUARIO U
    WHERE U.CLIENTE_ID = C.ID AND
          U.TELEFONO = @TELEFONO;
'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarClientePorDNITipoYDNI]    Script Date: 06/07/2014 19:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarClientePorDNITipoYDNI]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [GOODTIMES].[BuscarClientePorDNITipoYDNI]
        @DNI_TIPO NVARCHAR(10),
        @DNI      NVARCHAR(100)

AS
    SELECT U.ID
        , U.USERNAME
        , U.CLIENTE_ID
        , U.LOGIN_FALLIDOS
        , U.HABILITADO
        , U.ELIMINADO
        , U.MAIL
        , U.TELEFONO
        , U.DIRECCION
        , U.CODIGO_POSTAL
        , U.LOCALIDAD
        , C.NOMBRE
        , C.APELLIDO
        , C.APELLIDO
        , C.DNI
        , C.DNI_TIPO
        , C.FECHA_NAC
    FROM GOODTIMES.CLIENTE C, GOODTIMES.USUARIO U
    WHERE U.CLIENTE_ID = C.ID AND
          C.DNI_TIPO = @DNI_TIPO AND
          c.DNI = @DNI;
'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[EliminarUsuario]    Script Date: 06/07/2014 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[EliminarUsuario]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [GOODTIMES].[EliminarUsuario]
        @ID BIGINT

AS
    UPDATE GOODTIMES.USUARIO
    SET ELIMINADO = 1
    WHERE ID = @ID;
'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[CrearVisibilidadPublicacion]    Script Date: 06/07/2014 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[CrearVisibilidadPublicacion]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [GOODTIMES].[CrearVisibilidadPublicacion]
        @codigo        NUMERIC(18, 0),
        @descripcion   NVARCHAR(255),
        @porcentaje    NUMERIC(18, 2),
        @precio        NUMERIC(18, 2),
        @visibilidadId NUMERIC(18, 0) OUTPUT

AS
    BEGIN
        SET NOCOUNT ON;

        SET @visibilidadId = GOODTIMES.GET_VISIBILIDAD_PUBLICACION_BY_DESCRIPCION(@descripcion)

        IF (@visibilidadId IS NULL)
            BEGIN

                INSERT INTO [GD1C2014].[GOODTIMES].[VISIBILIDAD_PUBLICACION]
                ([ID]
                    , [DESCRIPCION]
                    , [PRECIO]
                    , [PORC_GANANCIA])
                VALUES
                    (@codigo
                        , @descripcion
                        , @precio
                        , @porcentaje)

                SET @visibilidadId = GOODTIMES.GET_VISIBILIDAD_PUBLICACION_BY_DESCRIPCION(@descripcion)
            END
    END
'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[CrearTipoPublicacion]    Script Date: 06/07/2014 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[CrearTipoPublicacion]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [GOODTIMES].[CrearTipoPublicacion]
        @descripcion       NVARCHAR(255),
        @tipoPublicacionId SMALLINT OUTPUT

AS
    BEGIN
        SET NOCOUNT ON;

        SET @tipoPublicacionId = GOODTIMES.GET_TIPO_PUBLICACION_BY_DESCRIPCION(@descripcion)

        IF (@tipoPublicacionId IS NULL)
            BEGIN
                INSERT INTO [GD1C2014].[GOODTIMES].[TIPO_PUBLICACION]
                ([DESCRIPCION])
                VALUES
                    (@descripcion)

                SET @tipoPublicacionId = GOODTIMES.GET_TIPO_PUBLICACION_BY_DESCRIPCION(@descripcion)
            END
    END
'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[CrearEstadoPublicacion]    Script Date: 06/07/2014 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[CrearEstadoPublicacion]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [GOODTIMES].[CrearEstadoPublicacion]
        @descripcion     NVARCHAR(255),
        @fechaVecimiento DATETIME,
        @estadoId        SMALLINT OUTPUT

AS
    BEGIN
        SET NOCOUNT ON;

        IF (@fechaVecimiento IS NOT NULL)
            BEGIN
                IF (@descripcion = ''Publicada'')
                    BEGIN
                        IF (@fechaVecimiento <= GETDATE())
                            SET @descripcion = ''Finalizada''
                        ELSE
                            SET @descripcion = ''Activa''
                    END
            END

        SET @estadoId = GOODTIMES.GET_ESTADO_PUBLICACION_BY_DESCRIPCION(@descripcion)

        IF (@estadoId IS NULL)
            BEGIN
                INSERT INTO [GD1C2014].[GOODTIMES].[ESTADO]
                ([DESCRIPCION])
                VALUES
                    (@descripcion)

                SET @estadoId = GOODTIMES.GET_ESTADO_PUBLICACION_BY_DESCRIPCION(@descripcion)
            END
    END
'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[CrearEmpresa]    Script Date: 06/07/2014 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[CrearEmpresa]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [GOODTIMES].[CrearEmpresa]
        @RAZON_SOCIAL   NVARCHAR(100),
        @CUIT           nvarchar(50),
        @CONTACTO       NVARCHAR(max),
        @FECHA_CREACION datetime,

        @USERNAME       NVARCHAR(50),
        @PASSWORD       NVARCHAR(max),
        @LOGIN_FALLIDOS INT,
        @HABILITADO     BIT,
        @ELIMINADO      BIT,
        @MAIL           NVARCHAR(50),
        @TELEFONO       NVARCHAR(max),
        @DIRECCION      NVARCHAR(max),
        @CODIGO_POSTAL  NVARCHAR(50),
        @LOCALIDAD      NVARCHAR(100),
		@ID_EMPRESA_CREADO bigint OUTPUT

AS
    BEGIN TRANSACTION;

    INSERT INTO GOODTIMES.EMPRESA (CUIT, RAZON_SOCIAL, CONTACTO, FECHA_CREACION)
    VALUES (@CUIT, @RAZON_SOCIAL, @CONTACTO, @FECHA_CREACION);

    INSERT INTO GOODTIMES.USUARIO (USERNAME, PASSWORD, EMPRESA_ID, LOGIN_FALLIDOS, HABILITADO, ELIMINADO, MAIL, TELEFONO, DIRECCION, CODIGO_POSTAL, LOCALIDAD, ROL_ID)
    VALUES
        (@USERNAME, @PASSWORD, SCOPE_IDENTITY(), @LOGIN_FALLIDOS, @HABILITADO, @ELIMINADO, @MAIL, @TELEFONO, @DIRECCION, @CODIGO_POSTAL, @LOCALIDAD, 1);

	SET @ID_EMPRESA_CREADO = SCOPE_IDENTITY();	

    COMMIT TRANSACTION;
'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[CrearCliente]    Script Date: 06/07/2014 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[CrearCliente]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [GOODTIMES].[CrearCliente]
        @NOMBRE         NVARCHAR(100),
        @APELLIDO       NVARCHAR(100),
        @DNI            NVARCHAR(100),
        @DNI_TIPO       NVARCHAR(100),
        @FECHA_NAC      NVARCHAR(100),

        @USERNAME       NVARCHAR(100),
        @PASSWORD       NVARCHAR(100),
        @LOGIN_FALLIDOS INT,
        @HABILITADO     BIT,
        @ELIMINADO      BIT,
        @MAIL           NVARCHAR(100),
        @TELEFONO       NVARCHAR(100),
        @DIRECCION      NVARCHAR(100),
        @CODIGO_POSTAL  NVARCHAR(100),
        @LOCALIDAD      NVARCHAR(100),
		@ID_CLIENTE_CREADO bigint OUTPUT

AS
    BEGIN TRANSACTION;
	
    INSERT INTO GOODTIMES.CLIENTE (NOMBRE, APELLIDO, DNI, DNI_TIPO, FECHA_NAC)
    VALUES (@NOMBRE, @APELLIDO, @DNI, @DNI_TIPO, @FECHA_NAC);

    INSERT INTO GOODTIMES.USUARIO (USERNAME, PASSWORD, CLIENTE_ID, LOGIN_FALLIDOS, HABILITADO, ELIMINADO, MAIL, TELEFONO, DIRECCION, CODIGO_POSTAL, LOCALIDAD, ROL_ID)
    VALUES
        (@USERNAME, @PASSWORD, SCOPE_IDENTITY(), @LOGIN_FALLIDOS, @HABILITADO, @ELIMINADO, @MAIL, @TELEFONO, @DIRECCION, @CODIGO_POSTAL, @LOCALIDAD, 2);

	SET @ID_CLIENTE_CREADO = SCOPE_IDENTITY();

    COMMIT TRANSACTION;
'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarPublicaciones]    Script Date: 06/07/2014 19:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarPublicaciones]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [GOODTIMES].[BuscarPublicaciones]
		@ID                  BIGINT,
		@USUARIO_ID          BIGINT

AS
    BEGIN
		IF @ID = -1
			select * from GOODTIMES.PUBLICACION where USUARIO_ID = @USUARIO_ID;
		ELSE BEGIN
			select * from GOODTIMES.PUBLICACION where USUARIO_ID = @USUARIO_ID and ID = @ID;
		END
    END


'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarPublicacion]    Script Date: 06/07/2014 19:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarPublicacion]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

CREATE PROCEDURE [GOODTIMES].[BuscarPublicacion]
		@ID                  BIGINT

AS
    BEGIN
	select * from GOODTIMES.PUBLICACION where ID = @ID;
    END



'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[CrearFactura]    Script Date: 06/07/2014 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[CrearFactura]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [GOODTIMES].[CrearFactura]
        @USUARIO_ID BIGINT,
        @FECHA datetime,
        @FORMA_PAGO_ID smallint
AS
    BEGIN
        SET NOCOUNT ON;

        declare @nuevoId numeric(18, 0)
        set @nuevoId = (select top 1 ID from GOODTIMES.FACTURA order by ID desc)+1;

        INSERT INTO [GOODTIMES].[FACTURA] (ID, USUARIO_ID, FECHA, FORMA_PAGO_ID)
        VALUES (@nuevoId, @USUARIO_ID,@FECHA,@FORMA_PAGO_ID)

    END


'
END
GO

/****** Object:  StoredProcedure [GOODTIMES].[GuardarPublicacion]    Script Date: 06/18/2014 00:23:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GOODTIMES].[GuardarPublicacion]
        @ID                  BIGINT,
        @USUARIO_ID          BIGINT,
        @DESCRIPCION         NVARCHAR(MAX),
        @UNIDADES            NUMERIC(18, 0),
        @PRECIO              NUMERIC(18, 2),
        @FEC_INICIO          DATETIME,
        @FEC_FIN             DATETIME,
        @TIPO_PUBLICACION_ID SMALLINT,
        @ESTADO_ID           SMALLINT,
        @VISIBILIDAD_ID      SMALLINT,
        @ADMITE_PREGUNTAS    BIT

AS
    BEGIN
        SET NOCOUNT ON;
        IF @ID = -1
            BEGIN
                declare @nuevoId bigint
                set @nuevoId = (select top 1 ID from GOODTIMES.PUBLICACION order by ID desc)+1;

                INSERT INTO [GOODTIMES].[PUBLICACION]
                ([ID]
                    , [USUARIO_ID]
                    , [DESCRIPCION]
                    , [UNIDADES]
                    , [PRECIO]
                    , [FEC_INICIO]
                    , [FEC_FIN]
                    , [TIPO_PUBLICACION_ID]
                    , [ESTADO_ID]
                    , [VISIBILIDAD_ID]
                    , [ADMITE_PREGUNTAS])
                VALUES
                    (@nuevoId,
                     @USUARIO_ID,
                     @DESCRIPCION,
                     @UNIDADES,
                     @PRECIO,
                     @FEC_INICIO,
                     @FEC_FIN,
                     @TIPO_PUBLICACION_ID,
                     @ESTADO_ID,
                     @VISIBILIDAD_ID,
                     @ADMITE_PREGUNTAS)
                SELECT @nuevoId AS ID
            END
        ELSE BEGIN
	        		
				UPDATE [GOODTIMES].[PUBLICACION]
					SET [USUARIO_ID]          = @USUARIO_ID,
						[DESCRIPCION]         = @DESCRIPCION,
						[UNIDADES]            = @UNIDADES,
						[PRECIO]              = @PRECIO,
						[FEC_INICIO]          = @FEC_INICIO,
						[FEC_FIN]             = @FEC_FIN,
						[TIPO_PUBLICACION_ID] = @TIPO_PUBLICACION_ID,
						[ESTADO_ID]           = @ESTADO_ID,
						[VISIBILIDAD_ID]      = @VISIBILIDAD_ID,
						[ADMITE_PREGUNTAS]    = @ADMITE_PREGUNTAS
					WHERE @ID = ID
					
			IF (@ESTADO_ID = 4 and @TIPO_PUBLICACION_ID = 2 and GETDATE() > @FEC_FIN)
			BEGIN
				
				DECLARE @PUBLICACION_ID bigint
				DECLARE @CANTIDAD numeric(18,0)
				
				SET @PUBLICACION_ID = @ID
				SET @CANTIDAD = @UNIDADES

				SET @PRECIO = (select MAX (o2.MONTO) from GOODTIMES.OFERTA o2 where o2.PUBLICACION_ID = @PUBLICACION_ID)

				SET @USUARIO_ID = (select o.USUARIO_ID from GOODTIMES.OFERTA o 
				where o.PUBLICACION_ID = @PUBLICACION_ID
				and MONTO = @PRECIO)

				SET @CANTIDAD = (select p.UNIDADES from GOODTIMES.PUBLICACION p  where p.ID = @PUBLICACION_ID)

				EXECUTE [GD1C2014].[GOODTIMES].[ComprarPublicacion] 
				   @PUBLICACION_ID
				  ,@USUARIO_ID
				  ,@CANTIDAD
				  ,@PRECIO			
			END
			
			END
				SELECT @ID
	END

GO



/****** Object:  StoredProcedure [GOODTIMES].[ResponderPregunta]    Script Date: 06/07/2014 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[ResponderPregunta]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [GOODTIMES].[ResponderPregunta]
        @ID BIGINT,
        @RESPUESTA NVARCHAR(MAX)
AS
    BEGIN

       update GOODTIMES.PREGUNTA set RESPUESTA = @RESPUESTA, FEC_RESP = GETDATE() where ID = @ID

    END
'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[QuitarRubroAPublicacion]    Script Date: 06/07/2014 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[QuitarRubroAPublicacion]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [GOODTIMES].[QuitarRubroAPublicacion]
        @PUBLICACION_ID BIGINT,
        @RUBRO_ID       INT

AS

    BEGIN
        SET NOCOUNT ON;

        DELETE FROM [GOODTIMES].[RUBROS_X_PUBLICACION]
        WHERE ([PUBLICACION_ID] = @PUBLICACION_ID AND [RUBRO_ID] = @RUBRO_ID)
    END
'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[GuardarCompra]    Script Date: 06/07/2014 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[GuardarCompra]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [GOODTIMES].[GuardarCompra]
        @USUARIO_ID BIGINT,
        @PUBLICACION_ID BIGINT,
        @CANTIDAD NUMERIC(18,0),
        @FECHA datetime,
        @PRECIO numeric(18,2)
AS
    BEGIN
        SET NOCOUNT ON;

        INSERT INTO [GOODTIMES].[COMPRA] (USUARIO_ID, PUBLICACION_ID, CANTIDAD, FECHA, PRECIO)
                VALUES (@USUARIO_ID, @PUBLICACION_ID, @CANTIDAD, @FECHA, @PRECIO)

    END


'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[GuardarCalificacion]    Script Date: 06/07/2014 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[GuardarCalificacion]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [GOODTIMES].[GuardarCalificacion]
        @USUARIO_ID BIGINT,
        @COMPRA_ID BIGINT,
        @PUNTAJE NUMERIC(18,0),
        @DETALLE nvarchar(max)
AS
    BEGIN
        SET NOCOUNT ON;

        INSERT INTO [GOODTIMES].[CALIFICACION] (USUARIO_ID, COMPRA_ID, PUNTAJE, DETALLE)
                VALUES (@USUARIO_ID, @COMPRA_ID, @PUNTAJE, @DETALLE)

    END


'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[CrearOferta]    Script Date: 06/07/2014 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[CrearOferta]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [GOODTIMES].[CrearOferta]
        @USUARIO_ID BIGINT,
        @PUBLICACION_ID Numeric(18,0),
        @FECHA datetime,
        @MONTO Numeric(18,2)
AS
    BEGIN
        SET NOCOUNT ON;

        INSERT INTO [GOODTIMES].[OFERTA] (USUARIO_ID, PUBLICACION_ID, FECHA, MONTO)
                VALUES (@USUARIO_ID,@PUBLICACION_ID,@FECHA,@MONTO)

    END


'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[CrearItemFactura]    Script Date: 06/07/2014 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[CrearItemFactura]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [GOODTIMES].[CrearItemFactura]
        @FACTURA_ID Numeric(18,0),
        @COMPRA_ID bigint,
		@PUBLICACION_ID bigint,
        @CANTIDAD Numeric(18,0),
        @MONTO Numeric(18,2),
        @DETALLE nvarchar(max)
AS
    BEGIN
        SET NOCOUNT ON;

		INSERT INTO [GOODTIMES].[FACTURA_ITEM] (FACTURA_ID, COMPRA_ID, PUBLICACION_ID, CANTIDAD, MONTO, DETALLE)
		VALUES (@FACTURA_ID,@COMPRA_ID, @PUBLICACION_ID,@CANTIDAD,@MONTO,@DETALLE)

    END


'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarPublicacionesActivas]    Script Date: 06/07/2014 19:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarPublicacionesActivas]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [GOODTIMES].[BuscarPublicacionesActivas]
		@ESTADO                  NVARCHAR(MAX),
		@DESCRIPCION 			 NVARCHAR(MAX),
		@NUMERO_PAGINA 			 INT,
		@RUBROS 				 NVARCHAR(MAX)

AS
    BEGIN
		IF @RUBROS = ''''
		BEGIN
		select * from (select distinct ROW_NUMBER() OVER ( order by V.PRECIO DESC) AS RowNum,
					   P.* from GOODTIMES.PUBLICACION P
		JOIN GOODTIMES.ESTADO E ON P.ESTADO_ID = E.ID
		JOIN GOODTIMES.VISIBILIDAD_PUBLICACION V ON P.VISIBILIDAD_ID = V.ID
		where E.DESCRIPCION LIKE ISNULL(''%'' + @ESTADO + ''%'', ''%'')
		AND P.DESCRIPCION LIKE ISNULL(''%'' + @DESCRIPCION + ''%'', ''%'')
		AND P.FEC_FIN > GETDATE()
		AND P.UNIDADES > 0
		) AS RowConstrainedResult
		WHERE   RowNum > (@NUMERO_PAGINA-1)*20
		AND RowNum <= @NUMERO_PAGINA*20;
		END
		ELSE BEGIN
		select * from (select distinct ROW_NUMBER() OVER ( order by V.PRECIO DESC) AS RowNum,
					   P.* from GOODTIMES.PUBLICACION P
		JOIN GOODTIMES.ESTADO E ON P.ESTADO_ID = E.ID
		JOIN GOODTIMES.VISIBILIDAD_PUBLICACION V ON P.VISIBILIDAD_ID = V.ID
		where E.DESCRIPCION LIKE ISNULL(''%'' + @ESTADO + ''%'', ''%'')
		AND P.DESCRIPCION LIKE ISNULL(''%'' + @DESCRIPCION + ''%'', ''%'')
		AND P.FEC_FIN > GETDATE()
		AND P.UNIDADES > 0
		AND (select RU.DESCRIPCION from GOODTIMES.RUBROS_X_PUBLICACION RXP
			JOIN GOODTIMES.RUBRO RU ON RU.CODIGO = RXP.RUBRO_ID where PUBLICACION_ID = P.ID)
			in (select * from GOODTIMES.SPLIT_STRING(@RUBROS,''|''))
		) AS RowConstrainedResult
		WHERE   RowNum > (@NUMERO_PAGINA-1)*20
		AND RowNum <= @NUMERO_PAGINA*20;
		END
    END
'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarRubrosNotPublicacion]    Script Date: 06/07/2014 19:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarRubrosNotPublicacion]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [GOODTIMES].[BuscarRubrosNotPublicacion]
@ID_PUBLICACION numeric(18,0)
as
begin
SELECT r.* FROM [GOODTIMES].[RUBRO] r
EXCEPT
SELECT r.* FROM [GOODTIMES].[RUBRO] r
  join GOODTIMES.RUBROS_X_PUBLICACION rxp on r.CODIGO = rxp.RUBRO_ID
  where
    rxp.PUBLICACION_ID = @ID_PUBLICACION
end
'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarRubroPorPublicacion]    Script Date: 06/07/2014 19:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarRubroPorPublicacion]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'


CREATE PROCEDURE [GOODTIMES].[BuscarRubroPorPublicacion]
		@ID    BIGINT

AS
    BEGIN
		select r.*
		 from GOODTIMES.RUBRO r
		 JOIN GOODTIMES.RUBROS_X_PUBLICACION rxp on rxp.RUBRO_ID = r.CODIGO
		 where rxp.PUBLICACION_ID = @ID;
    END




'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[BuscarPreguntas]    Script Date: 06/07/2014 19:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarPreguntas]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [GOODTIMES].[BuscarPreguntas]
        @PUBLICACION_ID BIGINT
AS
    BEGIN

       select * from GOODTIMES.PREGUNTA WHERE PUBLICACION_ID = @PUBLICACION_ID;

    END'
END
GO
/****** Object:  StoredProcedure [GOODTIMES].[AgregarRubroAPublicacion]    Script Date: 06/07/2014 19:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[AgregarRubroAPublicacion]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [GOODTIMES].[AgregarRubroAPublicacion]
        @PUBLICACION_ID BIGINT,
        @RUBRO_ID       INT

AS

    BEGIN
        SET NOCOUNT ON;

        INSERT INTO [GD1C2014].[GOODTIMES].[RUBROS_X_PUBLICACION]
        ([PUBLICACION_ID]
            , [RUBRO_ID])
        VALUES
            (@PUBLICACION_ID,
             @RUBRO_ID)

    END
'
END
GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarComprasPorUsuario]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[BuscarComprasPorUsuario]
GO

USE [GD1C2014]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [GOODTIMES].[BuscarComprasPorUsuario]
        @ID BIGINT
AS
    BEGIN

        SELECT P.DESCRIPCION, C.PRECIO, C.CANTIDAD, (C.PRECIO * C.CANTIDAD) AS TOTAL, C.FECHA FROM GOODTIMES.PUBLICACION P
		INNER JOIN GOODTIMES.COMPRA C ON C.PUBLICACION_ID = P.ID
		INNER JOIN GOODTIMES.USUARIO U ON U.ID = C.USUARIO_ID
		WHERE U.ID = @ID

    END
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarOfertasPorUsuario]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[BuscarOfertasPorUsuario]
GO

USE [GD1C2014]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [GOODTIMES].[BuscarOfertasPorUsuario]
        @ID BIGINT
AS
    BEGIN

        SELECT P.DESCRIPCION, O.MONTO, O.FECHA, ISNULL((SELECT 'Si' FROM GOODTIMES.COMPRA C WHERE C.PUBLICACION_ID = P.ID AND C.USUARIO_ID = U.ID),'No') AS GANO
        FROM GOODTIMES.PUBLICACION P
		INNER JOIN GOODTIMES.OFERTA O ON O.PUBLICACION_ID = P.ID
		INNER JOIN GOODTIMES.USUARIO U ON U.ID = O.USUARIO_ID
		WHERE U.ID = @ID

    END
GO
USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[BuscarEstadoPublicacion]    Script Date: 06/08/2014 12:39:13 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarEstadoPublicacion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[BuscarEstadoPublicacion]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[BuscarEstadoPublicacion]    Script Date: 06/08/2014 12:39:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GOODTIMES].[BuscarEstadoPublicacion]
		@ID                  BIGINT

AS
    BEGIN
	select * from GOODTIMES.ESTADO where ID = @ID;
    END
GO



IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarCalificacionesHechasPorUsuario]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[BuscarCalificacionesHechasPorUsuario]
GO

USE [GD1C2014]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [GOODTIMES].[BuscarCalificacionesHechasPorUsuario]
        @ID BIGINT
AS
    BEGIN

        SELECT C.PUNTAJE, C.DETALLE, U.USERNAME, P.DESCRIPCION
		FROM GOODTIMES.CALIFICACION C
		INNER JOIN GOODTIMES.COMPRA CO ON CO.ID = C.COMPRA_ID
		INNER JOIN GOODTIMES.PUBLICACION P ON P.ID = CO.PUBLICACION_ID
		INNER JOIN GOODTIMES.USUARIO U ON U.ID = P.USUARIO_ID
		WHERE C.USUARIO_ID = @ID

    END
GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarCalificacionesRecibidas]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[BuscarCalificacionesRecibidas]
GO

USE [GD1C2014]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [GOODTIMES].[BuscarCalificacionesRecibidas]
        @ID BIGINT
AS
    BEGIN

        SELECT C.PUNTAJE, C.DETALLE, U.USERNAME, P.DESCRIPCION
		FROM GOODTIMES.CALIFICACION C
		INNER JOIN GOODTIMES.COMPRA CO ON CO.ID = C.COMPRA_ID
		INNER JOIN GOODTIMES.PUBLICACION P ON P.ID = CO.PUBLICACION_ID
		INNER JOIN GOODTIMES.USUARIO U ON U.ID = P.USUARIO_ID
		WHERE P.USUARIO_ID = @ID

    END
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[HacerPregunta]    Script Date: 06/08/2014 18:41:44 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[HacerPregunta]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[HacerPregunta]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[HacerPregunta]    Script Date: 06/08/2014 18:41:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [GOODTIMES].[HacerPregunta]
        @PUBLICACION_ID BIGINT,
        @USUARIO_ID BIGINT,
        @PREGUNTA NVARCHAR(255)
AS
    BEGIN

       insert into GOODTIMES.PREGUNTA
       values (@USUARIO_ID, @PUBLICACION_ID, @PREGUNTA, GETDATE(), '', '');

    END


GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[BuscarPreguntasDeUsuario]    Script Date: 06/08/2014 19:13:10 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarPreguntasDeUsuario]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[BuscarPreguntasDeUsuario]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[BuscarPreguntasDeUsuario]    Script Date: 06/08/2014 19:13:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GOODTIMES].[BuscarPreguntasDeUsuario]
        @USUARIO_ID BIGINT
AS
    BEGIN

       select * from GOODTIMES.PREGUNTA WHERE USUARIO_ID = @USUARIO_ID;

    END
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[BuscarUsuarioPorId]    Script Date: 06/08/2014 23:55:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarUsuarioPorId]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[BuscarUsuarioPorId]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[BuscarUsuarioPorId]    Script Date: 06/08/2014 23:55:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GOODTIMES].[BuscarUsuarioPorId]
        @ID bigint

AS
BEGIN
    SELECT *
    FROM GOODTIMES.USUARIO
    WHERE ID = @ID;
    
    END
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[ComprarPublicacion]    Script Date: 06/08/2014 23:56:13 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[ComprarPublicacion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[ComprarPublicacion]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[ComprarPublicacion]    Script Date: 06/08/2014 23:56:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [GOODTIMES].[ComprarPublicacion]
	@PUBLICACION_ID bigint,
	@USUARIO_ID bigint,
	@CANTIDAD numeric(18),
	@PRECIO numeric(18,2)
AS
BEGIN

	declare @UNIDADES_DISPONIBLES INT

	SET @UNIDADES_DISPONIBLES = (select UNIDADES from GOODTIMES.PUBLICACION where ID = @PUBLICACION_ID)

	IF @CANTIDAD <= @UNIDADES_DISPONIBLES
	BEGIN

		insert into GOODTIMES.COMPRA (USUARIO_ID, PUBLICACION_ID, CANTIDAD, FECHA, PRECIO)
		values (@USUARIO_ID, @PUBLICACION_ID, @CANTIDAD, GETDATE(), @PRECIO);

		update GOODTIMES.PUBLICACION set UNIDADES = UNIDADES - @CANTIDAD where ID = @PUBLICACION_ID;

	END

	IF @CANTIDAD = @UNIDADES_DISPONIBLES
	BEGIN
		update GOODTIMES.PUBLICACION set ESTADO_ID = 4 where ID = @PUBLICACION_ID;
	END

END
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[OfertarPublicacion]    Script Date: 06/10/2014 20:09:08 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[OfertarPublicacion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[OfertarPublicacion]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[OfertarPublicacion]    Script Date: 06/10/2014 20:09:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [GOODTIMES].[OfertarPublicacion]
	@PUBLICACION_ID bigint,
	@USUARIO_ID bigint,
	@MONTO numeric(18)
AS
BEGIN

	declare @PRECIO INT

	SET @PRECIO = (select PRECIO from GOODTIMES.PUBLICACION where ID = @PUBLICACION_ID)

	IF @PRECIO < @MONTO
	BEGIN

		insert into GOODTIMES.OFERTA (USUARIO_ID, PUBLICACION_ID, FECHA, MONTO)
		values (@USUARIO_ID, @PUBLICACION_ID, GETDATE(), @MONTO);

		update GOODTIMES.PUBLICACION set PRECIO = @MONTO where ID = @PUBLICACION_ID;		
	END

END

GO

USE [GD1C2014]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[BorrarVisibilidad]    Script Date: 06/10/2014 22:39:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BorrarVisibilidad]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[BorrarVisibilidad]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[BorrarVisibilidad]    Script Date: 06/10/2014 22:39:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [GOODTIMES].[BorrarVisibilidad]
		@CODIGO            bigint
AS
BEGIN

	Delete from GOODTIMES.VISIBILIDAD_PUBLICACION where ID = @CODIGO;

END

GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[CrearOModificarVisibilidad]    Script Date: 06/10/2014 22:49:01 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[CrearOModificarVisibilidad]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[CrearOModificarVisibilidad]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[CrearOModificarVisibilidad]    Script Date: 06/10/2014 22:49:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


create procedure [GOODTIMES].[CrearOModificarVisibilidad]
		@CODIGO            bigint,
        @DESCRIPCION   NVARCHAR(255),
        @PORCENTAJE    NUMERIC(18, 2),
        @PRECIO        NUMERIC(18, 2)
AS
BEGIN

	DECLARE @CODIGO_EXISTENTE bigint

	SET @CODIGO_EXISTENTE = (SELECT ID FROM GOODTIMES.VISIBILIDAD_PUBLICACION WHERE ID = @CODIGO);

	IF @CODIGO_EXISTENTE IS NULL
		INSERT INTO GOODTIMES.VISIBILIDAD_PUBLICACION (ID, DESCRIPCION, PRECIO, PORC_GANANCIA)
		VALUES (@CODIGO, @DESCRIPCION, @PRECIO, @PORCENTAJE);
	ELSE
		UPDATE GOODTIMES.VISIBILIDAD_PUBLICACION 
		SET DESCRIPCION = @DESCRIPCION, PORC_GANANCIA = @PORCENTAJE, PRECIO = @PRECIO
		where ID = @CODIGO;

END
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[BuscarComprasSinCalificarPorUsuario]    Script Date: 06/14/2014 13:23:16 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarComprasSinCalificarPorUsuario]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[BuscarComprasSinCalificarPorUsuario]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[BuscarComprasSinCalificarPorUsuario]    Script Date: 06/14/2014 13:23:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GOODTIMES].[BuscarComprasSinCalificarPorUsuario]
        @ID BIGINT
AS
    BEGIN
        
        SELECT P.DESCRIPCION, U.USERNAME, CO.FECHA, CO.ID FROM GOODTIMES.COMPRA CO
		INNER JOIN GOODTIMES.PUBLICACION P ON P.ID = CO.PUBLICACION_ID
		INNER JOIN GOODTIMES.USUARIO U ON U.ID = P.USUARIO_ID
		WHERE (SELECT COUNT(*) FROM GOODTIMES.CALIFICACION CA WHERE CA.COMPRA_ID = CO.ID) = 0
		AND CO.USUARIO_ID = @ID
        
    END

GO

USE [GD1C2014]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarComprasSinFacturar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[BuscarComprasSinFacturar]
GO

USE [GD1C2014]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GOODTIMES].[BuscarComprasSinFacturar]
		@USER_ID BIGINT

AS
    BEGIN
    
		SELECT * 
		FROM GOODTIMES.COMPRA C
		WHERE NOT EXISTS(SELECT 1 FROM GOODTIMES.FACTURA_ITEM WHERE COMPRA_ID = C.ID)		
		AND C.USUARIO_ID = @USER_ID
    
    END
GO


USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[Top5ClientesSinCalificar]    Script Date: 06/15/2014 13:56:21 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[Top5ClientesSinCalificar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[Top5ClientesSinCalificar]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[Top5ClientesSinCalificar]    Script Date: 06/15/2014 13:56:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [GOODTIMES].[Top5ClientesSinCalificar]
	@DESDE datetime,
	@HASTA datetime
AS
    BEGIN
    
    
SELECT TOP(5) u.USERNAME as 'Username', SUM(1) as 'Falta calificar (publicaciones)'
	FROM [GOODTIMES].COMPRA c
	join GOODTIMES.USUARIO u on u.ID = c.USUARIO_ID 
	where not exists 
	(select * from GOODTIMES.CALIFICACION cal where cal.compra_ID = c.ID)
	and c.FECHA >= @DESDE and c.FECHA< @HASTA
	group by c.USUARIO_ID, u.username
	order by 'Falta calificar (publicaciones)' desc


    END




GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[Top5Facturacion]    Script Date: 06/15/2014 13:56:33 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[Top5Facturacion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[Top5Facturacion]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[Top5Facturacion]    Script Date: 06/15/2014 13:56:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [GOODTIMES].[Top5Facturacion]
	@DESDE datetime,
	@HASTA datetime
AS
    BEGIN
    
	select TOP (5) u.USERNAME as 'Username', SUM(c.PRECIO)  as 'Monto Facturado'
	from GOODTIMES.COMPRA c
	join GOODTIMES.PUBLICACION p on p.ID = c.PUBLICACION_ID
	join GOODTIMES.USUARIO u on u.ID = p.USUARIO_ID
	where
			c.FECHA>= @DESDE and c.FECHA<@HASTA 
	group by u.USERNAME
	order by 'Monto Facturado' desc



    END




GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[Top5VendedoresCalificacion]    Script Date: 06/15/2014 13:56:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[Top5VendedoresCalificacion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[Top5VendedoresCalificacion]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[Top5VendedoresCalificacion]    Script Date: 06/15/2014 13:56:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [GOODTIMES].[Top5VendedoresCalificacion]
	@DESDE datetime,
	@HASTA datetime
AS
    BEGIN
   
      
	select TOP(5) u.username as 'Vendedor', SUM(cal.PUNTAJE) Calificacion
		from GOODTIMES.USUARIO u
		join GOODTIMES.PUBLICACION p on p.USUARIO_ID = u.ID
		join GOODTIMES.COMPRA c on c.PUBLICACION_ID = p.ID
		join GOODTIMES.CALIFICACION cal on cal.COMPRA_ID = c.ID
		where
			c.FECHA>= @DESDE and c.FECHA<@HASTA 
	group by u.USERNAME
	order by Calificacion desc

    END




GO


USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[Top5VendedoresConStock]    Script Date: 06/15/2014 13:57:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[Top5VendedoresConStock]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[Top5VendedoresConStock]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[Top5VendedoresConStock]    Script Date: 06/15/2014 13:57:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO





-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [GOODTIMES].[Top5VendedoresConStock]
	@DESDE datetime,
	@HASTA datetime,
	@ID_VISIBILIDAD int
AS
    BEGIN
    	
	select TOP(5) u.USERNAME 'Usuario', SUM(p.unidades) 'Unidades sin vender'
		from  GOODTIMES.USUARIO u
			join GOODTIMES.PUBLICACION p on p.USUARIO_ID = u.ID
			join GOODTIMES.VISIBILIDAD_PUBLICACION vp on vp.ID = p.VISIBILIDAD_ID
		where p.VISIBILIDAD_ID = @ID_VISIBILIDAD
			and p.FEC_INICIO >= @DESDE and p.FEC_INICIO< @HASTA
		group by u.USERNAME
		order by 'Unidades sin vender' desc


    END
    

GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[CambiarPasswordDeUsuario]    Script Date: 06/15/2014 17:54:41 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[CambiarPasswordDeUsuario]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[CambiarPasswordDeUsuario]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[CambiarPasswordDeUsuario]    Script Date: 06/15/2014 17:54:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [GOODTIMES].[CambiarPasswordDeUsuario]
	@ID bigint,
	@PASSWORD nvarchar(max)
	AS
	BEGIN
		update GOODTIMES.USUARIO set PASSWORD = @PASSWORD where ID = @ID;
	END
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[ObtenerCantidadComprasSinCalificar]    Script Date: 06/18/2014 00:12:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[ObtenerCantidadComprasSinCalificar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[ObtenerCantidadComprasSinCalificar]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[ObtenerCantidadComprasSinCalificar]    Script Date: 06/18/2014 00:12:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [GOODTIMES].[ObtenerCantidadComprasSinCalificar]
	@USUARIO_ID bigint
AS
BEGIN
	DECLARE @CANTIDAD_COMPRAS int
	DECLARE @CANTIDAD_CALIFICACIONES int

	SET @CANTIDAD_COMPRAS = (select COUNT(*) from GOODTIMES.COMPRA WHERE USUARIO_ID = @USUARIO_ID);

	SET @CANTIDAD_CALIFICACIONES = (select COUNT(*) from GOODTIMES.COMPRA CO JOIN GOODTIMES.CALIFICACION CA ON CO.ID = CA.COMPRA_ID WHERE CO.USUARIO_ID = @USUARIO_ID);

	RETURN @CANTIDAD_COMPRAS - @CANTIDAD_CALIFICACIONES;

END
GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[ObtenerItemsSinFacturar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[ObtenerItemsSinFacturar]
GO

USE [GD1C2014]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GOODTIMES].[ObtenerItemsSinFacturar]
		@USUARIO_ID BIGINT

AS
    BEGIN
    
		SELECT T.* FROM
			(SELECT P.ID AS PUBLICACION_ID, C.ID AS COMPRA_ID, C.FECHA, C.CANTIDAD, (P.PRECIO * C.CANTIDAD * V.PORC_GANANCIA) AS MONTO, 'Compra '+P.DESCRIPCION AS DETALLE
			FROM GOODTIMES.PUBLICACION P
			JOIN GOODTIMES.COMPRA C ON C.PUBLICACION_ID = P.ID
			JOIN GOODTIMES.VISIBILIDAD_PUBLICACION V ON V.ID = P.VISIBILIDAD_ID
			WHERE P.USUARIO_ID = @USUARIO_ID
			AND NOT EXISTS(SELECT 1 FROM GOODTIMES.FACTURA_ITEM WHERE COMPRA_ID = C.ID)

			UNION

			SELECT P.ID AS PUBLICACION_ID, NULL AS COMPRA_ID, P.FEC_INICIO, 1, V.PRECIO AS MONTO, 'Visibilidad '+P.DESCRIPCION
			FROM GOODTIMES.PUBLICACION P 
			JOIN GOODTIMES.VISIBILIDAD_PUBLICACION V ON V.ID = P.VISIBILIDAD_ID
			WHERE NOT EXISTS(SELECT 1 FROM GOODTIMES.FACTURA_ITEM WHERE COMPRA_ID IS NULL AND PUBLICACION_ID = P.ID)
			AND P.USUARIO_ID = @USUARIO_ID) T
		ORDER BY T.FECHA ASC
    
    END
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[GuardarFactura]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[GuardarFactura]
GO

USE [GD1C2014]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [GOODTIMES].[GuardarFactura]
        @USUARIO_ID          BIGINT,
        @FECHA				 DATETIME,
        @FORMA_PAGO_ID       NVARCHAR(MAX)

AS
    BEGIN
        SET NOCOUNT ON;
        
                declare @nuevoId numeric(18, 0)
				set @nuevoId = (select top 1 ID from GOODTIMES.FACTURA order by ID desc)+1;

                INSERT INTO [GOODTIMES].[FACTURA]
                (ID, USUARIO_ID, FECHA, FORMA_PAGO_ID)
                VALUES
                    (@nuevoId, @USUARIO_ID, @FECHA, @FORMA_PAGO_ID)
                
                SELECT @nuevoId AS ID
            
    END
GO
	
/****** Object:  StoredProcedure [GOODTIMES].[GuardarTarjeta]    Script Date: 06/18/2014 00:45:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[GOODTIMES].[GuardarTarjeta]') AND type in (N'P', N'PC'))
DROP PROCEDURE [GOODTIMES].[GuardarTarjeta] 
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[GuardarTarjeta]    Script Date: 06/18/2014 00:45:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GOODTIMES].[GuardarTarjeta]
        @FACTURA_ID          NUMERIC(18,0),
        @NUMERO				 NVARCHAR(MAX),
        @TITULAR			 NVARCHAR(MAX),
        @CODIGO_SEGURIDAD       NVARCHAR(20)

AS
    BEGIN
        SET NOCOUNT ON;
        
                INSERT INTO [GOODTIMES].[TARJETA]
                (FACTURA_ID, NUMERO, TITULAR, CODIGO_SEGURIDAD)
                VALUES
                    (@FACTURA_ID, @NUMERO, @TITULAR, @CODIGO_SEGURIDAD)                
            
    END

GO