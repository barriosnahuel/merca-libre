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
DECLARE maestra_cursor CURSOR READ_ONLY

FOR
    SELECT TOP 10 *
    FROM [GD1C2014].[gd_esquema].[Maestra]
    WHERE Publ_Cli_Dni is not NULL
    ORDER BY Publicacion_Cod, Factura_Fecha, Factura_Nro, Compra_Fecha, Calificacion_Codigo;

OPEN maestra_cursor
FETCH NEXT FROM maestra_cursor
INTO @Publ_Cli_Dni, @Publ_Cli_Apellido, @Publ_Cli_Nombre, @Publ_Cli_Fecha_Nac, @Publ_Cli_Mail, @Publ_Cli_Dom_Calle, @Publ_Cli_Nro_Calle, @Publ_Cli_Piso, @Publ_Cli_Depto, @Publ_Cli_Cod_Postal, @Publ_Empresa_Razon_Social, @Publ_Empresa_Cuit, @Publ_Empresa_Fecha_Creacion, @Publ_Empresa_Mail, @Publ_Empresa_Dom_Calle, @Publ_Empresa_Nro_Calle, @Publ_Empresa_Piso, @Publ_Empresa_Depto, @Publ_Empresa_Cod_Postal, @Publicacion_Cod, @Publicacion_Descripcion, @Publicacion_Stock, @Publicacion_Fecha, @Publicacion_Fecha_Venc, @Publicacion_Precio, @Publicacion_Tipo, @Publicacion_Visibilidad_Cod, @Publicacion_Visibilidad_Desc, @Publicacion_Visibilidad_Precio, @Publicacion_Visibilidad_Porcentaje, @Publicacion_Estado, @Publicacion_Rubro_Descripcion, @Cli_Dni, @Cli_Apeliido, @Cli_Nombre, @Cli_Fecha_Nac, @Cli_Mail, @Cli_Dom_Calle, @Cli_Nro_Calle, @Cli_Piso, @Cli_Depto, @Cli_Cod_Postal, @Compra_Fecha, @Compra_Cantidad, @Oferta_Fecha, @Oferta_Monto, @Calificacion_Codigo, @Calificacion_Cant_Estrellas, @Calificacion_Descripcion, @Item_Factura_Monto, @Item_Factura_Cantidad, @Factura_Nro, @Factura_Fecha, @Factura_Total, @Forma_Pago_Desc

DECLARE @Current_Publicacion_Cod NUMERIC(18, 0);
DECLARE @Publ_Owner bigint; -- ID del usuario duenio de la publicacion
SET @Current_Publicacion_Cod = 0;
WHILE @@FETCH_STATUS = 0
    BEGIN

-- Tablas a completar:
--		PUBLICACION
--		USUARIO
--		EMPRESA

--		RUBROS
--		RUBROS_X_PUBLICACION

--		VISIBILIDAD_PUBLICACION
--		ESTADO
--		TIPO_PUBLICACION

--		PREGUNTA

--		COMPRA
--		OFERTA
--		CALIFICACION

--		FACTURA
--		FACTURA_ITEM
--		FORMA_PAGO

		


        IF (@Current_Publicacion_Cod <> @Publicacion_Cod)
        BEGIN
        
			SET @Current_Publicacion_Cod = @Publicacion_Cod
            
            IF (@Publ_Cli_Dni IS NOT NULL)
            BEGIN            
				--Guardar el cliente si no existe
				IF NOT EXISTS(SELECT 1 FROM GOODTIMES.CLIENTE WHERE DNI = @Publ_Cli_Dni)
				BEGIN                        
					DECLARE @username nvarchar(100)
					SET @username = GOODTIMES. GET_UNIQUE_USERNAME(@Publ_Cli_Nombre)
					DECLARE @dir nvarchar(max)
					PRINT @username
					SET @dir = @Publ_Cli_Dom_Calle + ' ' + CONVERT(varchar, @Publ_Cli_Nro_Calle) + ' ' + CONVERT(varchar, @Publ_Cli_Piso) + ' ' + CONVERT(varchar, @Publ_Cli_Depto)
					
					EXEC [GOODTIMES].[CrearCliente] @Publ_Cli_Nombre, @Publ_Cli_Apellido, @Publ_Cli_Dni, 'DNI', @Publ_Cli_Fecha_Nac, @username, "123456", 0, 1, 0, @Publ_Cli_Mail, '', @dir, @Publ_Cli_Cod_Postal, 'Buenos Aires'
					SET @Publ_Owner = @@IDENTITY;
				END
				ELSE
				BEGIN
					SET @Publ_Owner = (SELECT ID FROM GOODTIMES.CLIENTE WHERE DNI = @Publ_Cli_Dni);
				END		
            END


            IF (@Publ_Empresa_Razon_Social IS NOT NULL)
            BEGIN
				PRINT 'Guardar publicacion y asociarla a la empresa'
            END

-- Guardar y Asociar PUBLICACION al USUARIO @Publ_Owner

                
         END

-- Asociar VISIBILIDAD_PUBLICACION
-- Asociar TIPO_PUBLICACION
-- Asociar ESTADO
-- Asociar RUBROS y RUBROS_X_PUBLICACION

-- Guardar compra del cliente
        IF (@Cli_Dni IS NOT NULL AND @Oferta_Fecha IS NULL AND @Calificacion_Codigo IS NULL)
            BEGIN
                PRINT 'Guardar compra del cliente'

-- Asociar COMPRA, OFERTA y CALIFICACION
            END

-- Asociar PREGUNTA
        
        -- Asociar FACTURA, FACTURA_ITEM y FORMA_PAGO

        FETCH NEXT FROM maestra_cursor
        INTO @Publ_Cli_Dni, @Publ_Cli_Apellido, @Publ_Cli_Nombre, @Publ_Cli_Fecha_Nac, @Publ_Cli_Mail, @Publ_Cli_Dom_Calle, @Publ_Cli_Nro_Calle, @Publ_Cli_Piso, @Publ_Cli_Depto, @Publ_Cli_Cod_Postal, @Publ_Empresa_Razon_Social, @Publ_Empresa_Cuit, @Publ_Empresa_Fecha_Creacion, @Publ_Empresa_Mail, @Publ_Empresa_Dom_Calle, @Publ_Empresa_Nro_Calle, @Publ_Empresa_Piso, @Publ_Empresa_Depto, @Publ_Empresa_Cod_Postal, @Publicacion_Cod, @Publicacion_Descripcion, @Publicacion_Stock, @Publicacion_Fecha, @Publicacion_Fecha_Venc, @Publicacion_Precio, @Publicacion_Tipo, @Publicacion_Visibilidad_Cod, @Publicacion_Visibilidad_Desc, @Publicacion_Visibilidad_Precio, @Publicacion_Visibilidad_Porcentaje, @Publicacion_Estado, @Publicacion_Rubro_Descripcion, @Cli_Dni, @Cli_Apeliido, @Cli_Nombre, @Cli_Fecha_Nac, @Cli_Mail, @Cli_Dom_Calle, @Cli_Nro_Calle, @Cli_Piso, @Cli_Depto, @Cli_Cod_Postal, @Compra_Fecha, @Compra_Cantidad, @Oferta_Fecha, @Oferta_Monto, @Calificacion_Codigo, @Calificacion_Cant_Estrellas, @Calificacion_Descripcion, @Item_Factura_Monto, @Item_Factura_Cantidad, @Factura_Nro, @Factura_Fecha, @Factura_Total, @Forma_Pago_Desc
    END
CLOSE maestra_cursor;
DEALLOCATE maestra_cursor;