USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[AgregarFuncionalidadARol]    Script Date: 05/17/2014 21:10:01 ******/
IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[GOODTIMES].[AgregarFuncionalidadARol]') AND type IN (N'P', N'PC'))
    DROP PROCEDURE [GOODTIMES].[AgregarFuncionalidadARol]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[AgregarFuncionalidadARol]    Script Date: 05/17/2014 21:10:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

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

GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[AgregarRubroAPublicacion]    Script Date: 05/17/2014 21:10:44 ******/
IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[GOODTIMES].[AgregarRubroAPublicacion]') AND type IN (N'P', N'PC'))
    DROP PROCEDURE [GOODTIMES].[AgregarRubroAPublicacion]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[AgregarRubroAPublicacion]    Script Date: 05/17/2014 21:10:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GOODTIMES].[AgregarRubroAPublicacion]
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

GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[BajaRol]    Script Date: 05/17/2014 21:10:57 ******/
IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BajaRol]') AND type IN (N'P', N'PC'))
    DROP PROCEDURE [GOODTIMES].[BajaRol]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[BajaRol]    Script Date: 05/17/2014 21:10:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [GOODTIMES].[BajaRol]
        @ID INT

AS
    BEGIN
        SET NOCOUNT ON;
        UPDATE [GOODTIMES].[ROL]
        SET ELIMINADO = 1
        WHERE [GOODTIMES].[ROL].ID = @ID


    END

GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[BuscarClientePorDNITipoYDNI]    Script Date: 05/17/2014 21:11:02 ******/
IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarClientePorDNITipoYDNI]') AND type IN (N'P', N'PC'))
    DROP PROCEDURE [GOODTIMES].[BuscarClientePorDNITipoYDNI]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[BuscarClientePorDNITipoYDNI]    Script Date: 05/17/2014 21:11:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GOODTIMES].[BuscarClientePorDNITipoYDNI]
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

GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[BuscarClientePorTelefono]    Script Date: 05/17/2014 21:11:16 ******/
IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarClientePorTelefono]') AND type IN (N'P', N'PC'))
    DROP PROCEDURE [GOODTIMES].[BuscarClientePorTelefono]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[BuscarClientePorTelefono]    Script Date: 05/17/2014 21:11:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GOODTIMES].[BuscarClientePorTelefono]
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

GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[BuscarClientes]    Script Date: 05/17/2014 21:11:22 ******/
IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarClientes]') AND type IN (N'P', N'PC'))
    DROP PROCEDURE [GOODTIMES].[BuscarClientes]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[BuscarClientes]    Script Date: 05/17/2014 21:11:22 ******/
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
              AND C.NOMBRE LIKE ISNULL('%' + @NOMBRE + '%', '%')
              AND C.APELLIDO LIKE ISNULL('%' + @APELLIDO + '%', '%')
              AND U.MAIL LIKE ISNULL('%' + @MAIL + '%', '%')
              AND C.DNI_TIPO LIKE ISNULL('%' + @DNI_TIPO + '%', '%')
              AND C.DNI LIKE ISNULL('%' + @DNI + '%', '%')
              AND U.ELIMINADO = 0;
    END

GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[BuscarEmpresaPorCuit]    Script Date: 05/17/2014 21:11:31 ******/
IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarEmpresaPorCuit]') AND type IN (N'P', N'PC'))
    DROP PROCEDURE [GOODTIMES].[BuscarEmpresaPorCuit]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[BuscarEmpresaPorCuit]    Script Date: 05/17/2014 21:11:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GOODTIMES].[BuscarEmpresaPorCuit]
        @CUIT BIGINT

AS
    SELECT E.CUIT
        , E.RAZON_SOCIAL
        , E.CONTACTO
        , E.FECHA_CREACION
        , U.ID
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
    FROM GOODTIMES.USUARIO U, GOODTIMES.EMPRESA E
    WHERE U.EMPRESA_ID = E.ID AND
          E.CUIT = @CUIT;

GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[BuscarEmpresaPorRazonSocial]    Script Date: 05/17/2014 21:11:38 ******/
IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarEmpresaPorRazonSocial]') AND type IN (N'P', N'PC'))
    DROP PROCEDURE [GOODTIMES].[BuscarEmpresaPorRazonSocial]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[BuscarEmpresaPorRazonSocial]    Script Date: 05/17/2014 21:11:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GOODTIMES].[BuscarEmpresaPorRazonSocial]
        @RAZON_SOCIAL NVARCHAR(100)

AS
    SELECT E.CUIT
        , E.RAZON_SOCIAL
        , E.CONTACTO
        , E.FECHA_CREACION
        , U.ID
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
    FROM GOODTIMES.USUARIO U, GOODTIMES.EMPRESA E
    WHERE U.EMPRESA_ID = E.ID AND
          E.RAZON_SOCIAL = @RAZON_SOCIAL;

GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[BuscarEmpresas]    Script Date: 05/17/2014 21:11:44 ******/
IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarEmpresas]') AND type IN (N'P', N'PC'))
    DROP PROCEDURE [GOODTIMES].[BuscarEmpresas]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[BuscarEmpresas]    Script Date: 05/17/2014 21:11:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GOODTIMES].[BuscarEmpresas]
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
              AND E.RAZON_SOCIAL LIKE ISNULL('%' + @RAZON_SOCIAL + '%', '%')
              AND E.CUIT LIKE ISNULL('%' + @CUIT + '%', '%')
              AND E.CONTACTO LIKE ISNULL('%' + @CONTACTO + '%', '%')
              AND U.ELIMINADO = 0;
    END

GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[BuscarFuncionalidadSinAsignarARol]    Script Date: 05/17/2014 21:11:52 ******/
IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarFuncionalidadSinAsignarARol]') AND type IN (N'P', N'PC'))
    DROP PROCEDURE [GOODTIMES].[BuscarFuncionalidadSinAsignarARol]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[BuscarFuncionalidadSinAsignarARol]    Script Date: 05/17/2014 21:11:52 ******/
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

GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[BuscarRolPorId]    Script Date: 05/17/2014 21:12:00 ******/
IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarRolPorId]') AND type IN (N'P', N'PC'))
    DROP PROCEDURE [GOODTIMES].[BuscarRolPorId]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[BuscarRolPorId]    Script Date: 05/17/2014 21:12:00 ******/
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
        @ID INT
AS
    BEGIN
        SELECT *
        FROM GOODTIMES.ROL R
        WHERE R.ID = @ID
    END

GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[BuscarRolPorNombre]    Script Date: 05/17/2014 21:12:06 ******/
IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarRolPorNombre]') AND type IN (N'P', N'PC'))
    DROP PROCEDURE [GOODTIMES].[BuscarRolPorNombre]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[BuscarRolPorNombre]    Script Date: 05/17/2014 21:12:06 ******/
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
        @NOMBRE NVARCHAR(100)
AS
    BEGIN
        SELECT *
        FROM GOODTIMES.ROL R
        WHERE R.ELIMINADO = 0 AND R.NOMBRE LIKE '%' + @NOMBRE + '%'
    END

GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[BuscarUsuarioPorUsername]    Script Date: 05/17/2014 21:12:11 ******/
IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[GOODTIMES].[BuscarUsuarioPorUsername]') AND type IN (N'P', N'PC'))
    DROP PROCEDURE [GOODTIMES].[BuscarUsuarioPorUsername]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[BuscarUsuarioPorUsername]    Script Date: 05/17/2014 21:12:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GOODTIMES].[BuscarUsuarioPorUsername]
        @USERNAME NVARCHAR(100)

AS
    SELECT *
    FROM GOODTIMES.USUARIO
    WHERE USERNAME = @USERNAME;

GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[CrearCliente]    Script Date: 05/17/2014 21:12:18 ******/
IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[GOODTIMES].[CrearCliente]') AND type IN (N'P', N'PC'))
    DROP PROCEDURE [GOODTIMES].[CrearCliente]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[CrearCliente]    Script Date: 05/17/2014 21:12:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GOODTIMES].[CrearCliente]
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
        @LOCALIDAD      NVARCHAR(100)

AS
    BEGIN TRANSACTION;

    INSERT INTO GOODTIMES.CLIENTE (NOMBRE, APELLIDO, DNI, DNI_TIPO, FECHA_NAC)
    VALUES (@NOMBRE, @APELLIDO, @DNI, @DNI_TIPO, @FECHA_NAC);

    INSERT INTO GOODTIMES.USUARIO (USERNAME, PASSWORD, CLIENTE_ID, LOGIN_FALLIDOS, HABILITADO, ELIMINADO, MAIL, TELEFONO, DIRECCION, CODIGO_POSTAL, LOCALIDAD)
    VALUES
        (@USERNAME, @PASSWORD, SCOPE_IDENTITY(), @LOGIN_FALLIDOS, @HABILITADO, @ELIMINADO, @MAIL, @TELEFONO, @DIRECCION, @CODIGO_POSTAL, @LOCALIDAD);

    COMMIT TRANSACTION;

GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[CrearEmpresa]    Script Date: 05/17/2014 21:12:27 ******/
IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[GOODTIMES].[CrearEmpresa]') AND type IN (N'P', N'PC'))
    DROP PROCEDURE [GOODTIMES].[CrearEmpresa]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[CrearEmpresa]    Script Date: 05/17/2014 21:12:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GOODTIMES].[CrearEmpresa]
        @RAZON_SOCIAL   NVARCHAR(100),
        @CUIT           BIGINT,
        @CONTACTO       NVARCHAR(100),
        @FECHA_CREACION NVARCHAR(100),

        @USERNAME       NVARCHAR(100),
        @PASSWORD       NVARCHAR(100),
        @LOGIN_FALLIDOS INT,
        @HABILITADO     BIT,
        @ELIMINADO      BIT,
        @MAIL           NVARCHAR(100),
        @TELEFONO       NVARCHAR(100),
        @DIRECCION      NVARCHAR(100),
        @CODIGO_POSTAL  NVARCHAR(100),
        @LOCALIDAD      NVARCHAR(100)

AS
    BEGIN TRANSACTION;

    INSERT INTO GOODTIMES.EMPRESA (CUIT, RAZON_SOCIAL, CONTACTO, FECHA_CREACION)
    VALUES (@CUIT, @RAZON_SOCIAL, @CONTACTO, @FECHA_CREACION);

    INSERT INTO GOODTIMES.USUARIO (USERNAME, PASSWORD, EMPRESA_ID, LOGIN_FALLIDOS, HABILITADO, ELIMINADO, MAIL, TELEFONO, DIRECCION, CODIGO_POSTAL, LOCALIDAD)
    VALUES
        (@USERNAME, @PASSWORD, SCOPE_IDENTITY(), @LOGIN_FALLIDOS, @HABILITADO, @ELIMINADO, @MAIL, @TELEFONO, @DIRECCION, @CODIGO_POSTAL, @LOCALIDAD);

    COMMIT TRANSACTION;

GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[EliminarUsuario]    Script Date: 05/17/2014 21:12:31 ******/
IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[GOODTIMES].[EliminarUsuario]') AND type IN (N'P', N'PC'))
    DROP PROCEDURE [GOODTIMES].[EliminarUsuario]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[EliminarUsuario]    Script Date: 05/17/2014 21:12:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GOODTIMES].[EliminarUsuario]
        @ID BIGINT

AS
    UPDATE GOODTIMES.USUARIO
    SET ELIMINADO = 1
    WHERE ID = @ID;

GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[GuardarPublicacion]    Script Date: 05/17/2014 21:12:45 ******/
IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[GOODTIMES].[GuardarPublicacion]') AND type IN (N'P', N'PC'))
    DROP PROCEDURE [GOODTIMES].[GuardarPublicacion]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[GuardarPublicacion]    Script Date: 05/17/2014 21:12:45 ******/
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
                INSERT INTO [GOODTIMES].[PUBLICACION]
                ([USUARIO_ID]
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
                    (@USUARIO_ID,
                     @DESCRIPCION,
                     @UNIDADES,
                     @PRECIO,
                     @FEC_INICIO,
                     @FEC_FIN,
                     @TIPO_PUBLICACION_ID,
                     @ESTADO_ID,
                     @VISIBILIDAD_ID,
                     @ADMITE_PREGUNTAS)
                SELECT @@Identity AS ID
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

            SELECT @ID
        END
    END

GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[GuardarRol]    Script Date: 05/17/2014 21:12:59 ******/
IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[GOODTIMES].[GuardarRol]') AND type IN (N'P', N'PC'))
    DROP PROCEDURE [GOODTIMES].[GuardarRol]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[GuardarRol]    Script Date: 05/17/2014 21:12:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GOODTIMES].[GuardarRol]
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

GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[ListarFuncionalidad]    Script Date: 05/17/2014 21:13:07 ******/
IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[GOODTIMES].[ListarFuncionalidad]') AND type IN (N'P', N'PC'))
    DROP PROCEDURE [GOODTIMES].[ListarFuncionalidad]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[ListarFuncionalidad]    Script Date: 05/17/2014 21:13:07 ******/
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
        @ID_ROL INTEGER
AS
    BEGIN
        SELECT F.*
        FROM GOODTIMES.FUNCIONALIDAD F

    END

GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[ListarFuncionalidadPorRol]    Script Date: 05/17/2014 21:13:13 ******/
IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[GOODTIMES].[ListarFuncionalidadPorRol]') AND type IN (N'P', N'PC'))
    DROP PROCEDURE [GOODTIMES].[ListarFuncionalidadPorRol]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[ListarFuncionalidadPorRol]    Script Date: 05/17/2014 21:13:13 ******/
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
        @ID_ROL INTEGER
AS
    BEGIN
        SELECT F.*
        FROM GOODTIMES.FUNCIONALIDAD F
            JOIN GOODTIMES.FUNCIONALIDAD_X_ROL FR ON F.ID = FR.FUNCIONALIDAD_ID
        WHERE FR.ROL_ID = @ID_ROL
    END

GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[ListarRoles]    Script Date: 05/17/2014 21:13:19 ******/
IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[GOODTIMES].[ListarRoles]') AND type IN (N'P', N'PC'))
    DROP PROCEDURE [GOODTIMES].[ListarRoles]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[ListarRoles]    Script Date: 05/17/2014 21:13:19 ******/
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
        SELECT *
        FROM GOODTIMES.ROL
        WHERE ELIMINADO = 0
    END

GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[login]    Script Date: 05/17/2014 21:13:24 ******/
IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[GOODTIMES].[login]') AND type IN (N'P', N'PC'))
    DROP PROCEDURE [GOODTIMES].[login]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[login]    Script Date: 05/17/2014 21:13:24 ******/
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

GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[ModificarCliente]    Script Date: 05/17/2014 21:13:34 ******/
IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[GOODTIMES].[ModificarCliente]') AND type IN (N'P', N'PC'))
    DROP PROCEDURE [GOODTIMES].[ModificarCliente]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[ModificarCliente]    Script Date: 05/17/2014 21:13:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GOODTIMES].[ModificarCliente]
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

GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[ModificarEmpresa]    Script Date: 05/17/2014 21:13:42 ******/
IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[GOODTIMES].[ModificarEmpresa]') AND type IN (N'P', N'PC'))
    DROP PROCEDURE [GOODTIMES].[ModificarEmpresa]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[ModificarEmpresa]    Script Date: 05/17/2014 21:13:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GOODTIMES].[ModificarEmpresa]

        @RAZON_SOCIAL   NVARCHAR(100),
        @CUIT           BIGINT,
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

GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[QuitarFuncionalidadARol]    Script Date: 05/17/2014 21:13:48 ******/
IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[GOODTIMES].[QuitarFuncionalidadARol]') AND type IN (N'P', N'PC'))
    DROP PROCEDURE [GOODTIMES].[QuitarFuncionalidadARol]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[QuitarFuncionalidadARol]    Script Date: 05/17/2014 21:13:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GOODTIMES].[QuitarFuncionalidadARol]
        @ROL_ID           INT,
        @FUNCIONALIDAD_ID INT
AS
    BEGIN
        SET NOCOUNT ON;

        DELETE FROM [GOODTIMES].[FUNCIONALIDAD_X_ROL]
        WHERE (@ROL_ID = GOODTIMES.FUNCIONALIDAD_X_ROL.ROL_ID
               AND @FUNCIONALIDAD_ID = GOODTIMES.FUNCIONALIDAD_X_ROL.FUNCIONALIDAD_ID)
    END

GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[QuitarRubroAPublicacion]    Script Date: 05/17/2014 21:13:54 ******/
IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[GOODTIMES].[QuitarRubroAPublicacion]') AND type IN (N'P', N'PC'))
    DROP PROCEDURE [GOODTIMES].[QuitarRubroAPublicacion]
GO

USE [GD1C2014]
GO

/****** Object:  StoredProcedure [GOODTIMES].[QuitarRubroAPublicacion]    Script Date: 05/17/2014 21:13:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GOODTIMES].[QuitarRubroAPublicacion]
        @PUBLICACION_ID BIGINT,
        @RUBRO_ID       INT

AS

    BEGIN
        SET NOCOUNT ON;

        DELETE FROM [GOODTIMES].[RUBROS_X_PUBLICACION]
        WHERE ([PUBLICACION_ID] = @PUBLICACION_ID AND [RUBRO_ID] = @RUBRO_ID)
    END

GO

