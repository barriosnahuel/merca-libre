DECLARE @Publ_Cli_Dni NUMERIC(18, 0),
@Publ_Cli_Apellido NVARCHAR(255),
@Publ_Cli_Nombre NVARCHAR(255),
@Publ_Cli_Fecha_Nac DATETIME,
@Publ_Cli_Mail NVARCHAR(255),
@Publ_Cli_Dom_Calle NVARCHAR(255),
@Publ_Cli_Nro_Calle NUMERIC(18, 0),
@Publ_Cli_Piso NUMERIC(18, 0),
@Publ_Cli_Depto NVARCHAR(50),
@Publ_Cli_Cod_Postal NVARCHAR(50),
@Publ_Empresa_Razon_Social NVARCHAR(255),
@Publ_Empresa_Cuit NVARCHAR(50),
@Publ_Empresa_Fecha_Creacion DATETIME,
@Publ_Empresa_Mail NVARCHAR(50),
@Publ_Empresa_Dom_Calle NVARCHAR(100),
@Publ_Empresa_Nro_Calle NUMERIC(18, 0),
@Publ_Empresa_Piso NUMERIC(18, 0),
@Publ_Empresa_Depto NVARCHAR(50),
@Publ_Empresa_Cod_Postal NVARCHAR(50),
@Publicacion_Cod NUMERIC(18, 0),
@Publicacion_Descripcion NVARCHAR(255),
@Publicacion_Stock NUMERIC(18, 0),
@Publicacion_Fecha DATETIME,
@Publicacion_Fecha_Venc DATETIME,
@Publicacion_Precio NUMERIC(18, 2),
@Publicacion_Tipo NVARCHAR(255),
@Publicacion_Visibilidad_Cod NUMERIC(18, 0),
@Publicacion_Visibilidad_Desc NVARCHAR(255),
@Publicacion_Visibilidad_Precio NUMERIC(18, 2),
@Publicacion_Visibilidad_Porcentaje NUMERIC(18, 2),
@Publicacion_Estado NVARCHAR(255),
@Publicacion_Rubro_Descripcion NVARCHAR(255),
@Cli_Dni NUMERIC(18, 0),
@Cli_Apeliido NVARCHAR(255),
@Cli_Nombre NVARCHAR(255),
@Cli_Fecha_Nac DATETIME,
@Cli_Mail NVARCHAR(255),
@Cli_Dom_Calle NVARCHAR(255),
@Cli_Nro_Calle NUMERIC(18, 0),
@Cli_Piso NUMERIC(18, 0),
@Cli_Depto NVARCHAR(50),
@Cli_Cod_Postal NVARCHAR(50),
@Compra_Fecha DATETIME,
@Compra_Cantidad NUMERIC(18, 0),
@Oferta_Fecha DATETIME,
@Oferta_Monto NUMERIC(18, 2),
@Calificacion_Codigo NUMERIC(18, 0),
@Calificacion_Cant_Estrellas NUMERIC(18, 0),
@Calificacion_Descripcion NVARCHAR(255),
@Item_Factura_Monto NUMERIC(18, 2),
@Item_Factura_Cantidad NUMERIC(18, 0),
@Factura_Nro NUMERIC(18, 0),
@Factura_Fecha DATETIME,
@Factura_Total NUMERIC(18, 2),
@Forma_Pago_Desc NVARCHAR(255);

-- READ_ONLY dramatically improves the performance of the cursor.
DECLARE maestra_cursor CURSOR

FOR
    SELECT *
    FROM [GD1C2014].[gd_esquema].[Maestra]
    ORDER BY Publicacion_Cod, Factura_Fecha, Factura_Nro, Compra_Fecha, Calificacion_Codigo;

OPEN maestra_cursor
FETCH NEXT FROM maestra_cursor
INTO @Publ_Cli_Dni, @Publ_Cli_Apellido, @Publ_Cli_Nombre, @Publ_Cli_Fecha_Nac, @Publ_Cli_Mail, @Publ_Cli_Dom_Calle, @Publ_Cli_Nro_Calle, @Publ_Cli_Piso, @Publ_Cli_Depto, @Publ_Cli_Cod_Postal, @Publ_Empresa_Razon_Social, @Publ_Empresa_Cuit, @Publ_Empresa_Fecha_Creacion, @Publ_Empresa_Mail, @Publ_Empresa_Dom_Calle, @Publ_Empresa_Nro_Calle, @Publ_Empresa_Piso, @Publ_Empresa_Depto, @Publ_Empresa_Cod_Postal, @Publicacion_Cod, @Publicacion_Descripcion, @Publicacion_Stock, @Publicacion_Fecha, @Publicacion_Fecha_Venc, @Publicacion_Precio, @Publicacion_Tipo, @Publicacion_Visibilidad_Cod, @Publicacion_Visibilidad_Desc, @Publicacion_Visibilidad_Precio, @Publicacion_Visibilidad_Porcentaje, @Publicacion_Estado, @Publicacion_Rubro_Descripcion, @Cli_Dni, @Cli_Apeliido, @Cli_Nombre, @Cli_Fecha_Nac, @Cli_Mail, @Cli_Dom_Calle, @Cli_Nro_Calle, @Cli_Piso, @Cli_Depto, @Cli_Cod_Postal, @Compra_Fecha, @Compra_Cantidad, @Oferta_Fecha, @Oferta_Monto, @Calificacion_Codigo, @Calificacion_Cant_Estrellas, @Calificacion_Descripcion, @Item_Factura_Monto, @Item_Factura_Cantidad, @Factura_Nro, @Factura_Fecha, @Factura_Total, @Forma_Pago_Desc

DECLARE @Current_Publicacion_Cod NUMERIC(18, 0)
DECLARE @Current_Factura_Nro NUMERIC(18, 0)
SET @Current_Factura_Nro = 0
DECLARE @Factura_Nro_Nuevo NUMERIC(18, 0)
DECLARE @Publicacion_Nuevo_ID BIGINT
DECLARE @username NVARCHAR(100)
DECLARE @dir NVARCHAR(MAX)
DECLARE @Publ_Owner BIGINT
DECLARE @tipoPublicacionId SMALLINT
DECLARE @rubroId int
DECLARE @estadoPublicacionId SMALLINT
DECLARE @visibilidadPublicacionId NUMERIC(18, 0)
DECLARE @Publ_Buyer BIGINT
DECLARE @Forma_pago_ID smallint
-- ID del usuario duenio de la publicacion
SET @Current_Publicacion_Cod = 0;
WHILE @@FETCH_STATUS = 0
    BEGIN

        IF (@Current_Publicacion_Cod <> @Publicacion_Cod)
        BEGIN

		    SET @Current_Publicacion_Cod = @Publicacion_Cod

            IF (@Publ_Cli_Dni IS NOT NULL)
            BEGIN
--Guardar el cliente si no existe, sino seteo el @Publ_Owner con el id existente
				IF NOT EXISTS(SELECT 1
                              FROM GOODTIMES.CLIENTE
                              WHERE DNI = @Publ_Cli_Dni)
                    BEGIN
                        SET @username = GOODTIMES.GET_UNIQUE_USERNAME(@Publ_Cli_Nombre)
                        SET @dir =
                        @Publ_Cli_Dom_Calle + ' ' + CONVERT(VARCHAR, @Publ_Cli_Nro_Calle) + ' ' + CONVERT(VARCHAR, @Publ_Cli_Piso) + ' ' +
                        CONVERT(VARCHAR, @Publ_Cli_Depto)

                        EXEC [GOODTIMES].[CrearCliente] @Publ_Cli_Nombre, @Publ_Cli_Apellido, @Publ_Cli_Dni, 'DNI', @Publ_Cli_Fecha_Nac, @username, "123456", 0, 1, 0, @Publ_Cli_Mail, '', @dir, @Publ_Cli_Cod_Postal, 'Buenos Aires'
                        SET @Publ_Owner = @@IDENTITY;
                    END
                ELSE
                    BEGIN
                        SET @Publ_Owner = (
                            SELECT ID
                            FROM GOODTIMES.CLIENTE
                            WHERE DNI = @Publ_Cli_Dni);
                    END
            END


            IF (@Publ_Empresa_Razon_Social IS NOT NULL)
            BEGIN
--Guardar empresa si no existe, sino seteo el @Publ_Owner con el id existente
                IF NOT EXISTS(SELECT 1 FROM GOODTIMES.EMPRESA WHERE CUIT = @Publ_Empresa_Cuit)
                    BEGIN
                        SET @username = GOODTIMES.GET_UNIQUE_USERNAME(@Publ_Empresa_Razon_Social)
                        SET @dir =
                        @Publ_Empresa_Dom_Calle + ' ' + CONVERT(VARCHAR, @Publ_Empresa_Nro_Calle) + ' ' + CONVERT(VARCHAR, @Publ_Empresa_Piso)
                        + ' ' + CONVERT(VARCHAR, @Publ_Empresa_Depto)

                        EXEC [GOODTIMES].CrearEmpresa @Publ_Empresa_Razon_Social, @Publ_Empresa_Cuit, '', @Publ_Empresa_Fecha_Creacion, @username, '123456', 0, 1, 0, @Publ_Empresa_Mail, '', @dir, @Publ_Empresa_Cod_Postal, 'Buenos Aires'
                        SET @Publ_Owner = @@IDENTITY;
                    END
                ELSE
                    BEGIN
                        SET @Publ_Owner = (
                            SELECT ID
                            FROM GOODTIMES.EMPRESA
                            WHERE CUIT = @Publ_Empresa_Cuit);
                    END
            END

-- Guardar y Asociar PUBLICACION al USUARIO @Publ_Owner
			EXEC GOODTIMES.CrearTipoPublicacion @Publicacion_Tipo, @tipoPublicacionId OUTPUT
			EXEC GOODTIMES.CrearEstadoPublicacion @Publicacion_Estado, @Publicacion_Fecha_Venc, @estadoPublicacionId OUTPUT
			EXEC GOODTIMES.CrearVisibilidadPublicacion @Publicacion_Visibilidad_Cod, @Publicacion_Visibilidad_Desc, @Publicacion_Visibilidad_Porcentaje, @Publicacion_Visibilidad_Precio, @visibilidadPublicacionId OUTPUT
			
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
                (cast(@Publicacion_Cod as bigint),
                 @Publ_Owner,
                 @Publicacion_Descripcion,
                 @Publicacion_Stock,
                 @Publicacion_Precio,
                 @Publicacion_Fecha,
                 @Publicacion_Fecha_Venc,
                 @tipoPublicacionId,
                 @estadoPublicacionId,
                 @visibilidadPublicacionId,
                 1)
            SET @Publicacion_Nuevo_ID = @Publicacion_Cod;

-- Asociar RUBROS y RUBROS_X_PUBLICACION
			EXEC [GOODTIMES].[CrearRubro] @Publicacion_Rubro_Descripcion, @rubroId OUTPUT
			EXEC [GOODTIMES].[AsignarRubroAPublicacion] @Publicacion_Nuevo_ID, @rubroId
        END
		
        IF (@Cli_Dni IS NOT NULL)            
        BEGIN
            --Guardar el cliente si no existe, sino seteo el @Publ_Buyer con el id existente
            IF NOT EXISTS(SELECT 1
                          FROM GOODTIMES.CLIENTE
                          WHERE DNI = @Cli_Dni)
                BEGIN
                    SET @username = GOODTIMES.GET_UNIQUE_USERNAME(@Cli_Nombre)
                    SET @dir = @Cli_Dom_Calle + ' ' + CONVERT(VARCHAR, @Cli_Nro_Calle) + ' ' + CONVERT(VARCHAR, @Cli_Piso) + ' ' + CONVERT(VARCHAR, @Cli_Depto)
                    EXEC GOODTIMES.CrearCliente @Cli_Nombre, @Cli_Apeliido, @Cli_Dni, 'DNI', @Cli_Fecha_Nac, @username, "123456", 0, 1, 0, @Cli_Mail, '', @dir, @Cli_Cod_Postal, 'Buenos Aires'
                    SET @Publ_Buyer = @@IDENTITY;
                END
            ELSE
                BEGIN
                    SET @Publ_Buyer = (
                        SELECT ID
                        FROM GOODTIMES.CLIENTE
                        WHERE DNI = @Cli_Dni);
                END
        END
            
        IF (@Cli_Dni IS NOT NULL AND @Oferta_Fecha IS NULL AND @Calificacion_Codigo IS NULL)
        BEGIN
			-- Asociar COMPRA a @Publ_Buyer	
			EXEC [GOODTIMES].[GuardarCompra] @Publ_Buyer, @Publicacion_Nuevo_ID, @Compra_Cantidad, @Compra_Fecha
        END
        
        IF (@Cli_Dni IS NOT NULL AND @Oferta_Fecha IS NOT NULL AND @Calificacion_Codigo IS NULL)
        BEGIN
			-- Asociar OFERTA a @Publ_Buyer			
			EXEC [GOODTIMES].[CrearOferta] @Publ_Buyer, @Publicacion_Nuevo_ID, @Oferta_Fecha, @Oferta_Monto
        END    
        
        IF (@Cli_Dni IS NOT NULL AND @Oferta_Fecha IS NULL AND @Calificacion_Codigo IS NOT NULL)
        BEGIN
			-- Asociar CALIFICACION a @Publ_Buyer	
			EXEC [GOODTIMES].[GuardarCalificacion] @Publ_Buyer, @Publicacion_Nuevo_ID, @Calificacion_Cant_Estrellas, @Calificacion_Descripcion
        END    
        
        IF (@Factura_Nro IS NOT NULL)
        BEGIN
			IF (@Factura_Nro <> @Current_Factura_Nro)
			BEGIN
				-- Guardar forma de pago si no existe
				IF (NOT EXISTS(SELECT 1 FROM GOODTIMES.FORMA_PAGO WHERE DESCRIPCION = @Forma_Pago_Desc))
				BEGIN
					EXEC [GOODTIMES].[CrearFormaPago] @Forma_Pago_Desc
					SET @Forma_pago_ID = @@IDENTITY;
				END
				ELSE
				BEGIN
					SET @Forma_pago_ID = (SELECT ID FROM GOODTIMES.FORMA_PAGO WHERE DESCRIPCION = @Forma_Pago_Desc);
				END
				-- Guardar la factura y guardar ID en @Factura_Nro_Nuevo
				EXEC [GOODTIMES].[CrearFactura] @Publ_Owner, @Factura_Fecha, @Forma_pago_ID, 0
				SET @Factura_Nro_Nuevo = @@IDENTITY;			
			END
			
			-- Agregar el item factura a la factura
			EXEC [GOODTIMES].[CrearItemFactura] @Factura_Nro_Nuevo, @Publicacion_Nuevo_ID, @Item_Factura_Cantidad, @Item_Factura_Monto, ''			
        END

        FETCH NEXT FROM maestra_cursor
        INTO @Publ_Cli_Dni, @Publ_Cli_Apellido, @Publ_Cli_Nombre, @Publ_Cli_Fecha_Nac, @Publ_Cli_Mail, @Publ_Cli_Dom_Calle, @Publ_Cli_Nro_Calle, @Publ_Cli_Piso, @Publ_Cli_Depto, @Publ_Cli_Cod_Postal, @Publ_Empresa_Razon_Social, @Publ_Empresa_Cuit, @Publ_Empresa_Fecha_Creacion, @Publ_Empresa_Mail, @Publ_Empresa_Dom_Calle, @Publ_Empresa_Nro_Calle, @Publ_Empresa_Piso, @Publ_Empresa_Depto, @Publ_Empresa_Cod_Postal, @Publicacion_Cod, @Publicacion_Descripcion, @Publicacion_Stock, @Publicacion_Fecha, @Publicacion_Fecha_Venc, @Publicacion_Precio, @Publicacion_Tipo, @Publicacion_Visibilidad_Cod, @Publicacion_Visibilidad_Desc, @Publicacion_Visibilidad_Precio, @Publicacion_Visibilidad_Porcentaje, @Publicacion_Estado, @Publicacion_Rubro_Descripcion, @Cli_Dni, @Cli_Apeliido, @Cli_Nombre, @Cli_Fecha_Nac, @Cli_Mail, @Cli_Dom_Calle, @Cli_Nro_Calle, @Cli_Piso, @Cli_Depto, @Cli_Cod_Postal, @Compra_Fecha, @Compra_Cantidad, @Oferta_Fecha, @Oferta_Monto, @Calificacion_Codigo, @Calificacion_Cant_Estrellas, @Calificacion_Descripcion, @Item_Factura_Monto, @Item_Factura_Cantidad, @Factura_Nro, @Factura_Fecha, @Factura_Total, @Forma_Pago_Desc
    END
CLOSE maestra_cursor;
DEALLOCATE maestra_cursor;