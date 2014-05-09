DECLARE @Publ_Cli_Dni numeric(18, 0),
@Publ_Cli_Apeliido nvarchar(255),
@Publ_Cli_Nombre nvarchar(255),
@Publ_Cli_Fecha_Nac datetime,
@Publ_Cli_Mail nvarchar(255),
@Publ_Cli_Dom_Calle nvarchar(255),
@Publ_Cli_Nro_Calle numeric(18, 0),
@Publ_Cli_Piso numeric(18, 0),
@Publ_Cli_Depto nvarchar(50),
@Publ_Cli_Cod_Postal nvarchar(50),
@Publ_Empresa_Razon_Social nvarchar(255),
@Publ_Empresa_Cuit nvarchar(50),
@Publ_Empresa_Fecha_Creacion datetime,
@Publ_Empresa_Mail nvarchar(50),
@Publ_Empresa_Dom_Calle nvarchar(100),
@Publ_Empresa_Nro_Calle numeric(18, 0),
@Publ_Empresa_Piso numeric(18, 0),
@Publ_Empresa_Depto nvarchar(50),
@Publ_Empresa_Cod_Postal nvarchar(50),
@Publicacion_Cod numeric(18, 0),
@Publicacion_Descripcion nvarchar(255),
@Publicacion_Stock numeric(18, 0),
@Publicacion_Fecha datetime,
@Publicacion_Fecha_Venc datetime,
@Publicacion_Precio numeric(18, 2),
@Publicacion_Tipo nvarchar(255),
@Publicacion_Visibilidad_Cod numeric(18, 0),
@Publicacion_Visibilidad_Desc nvarchar(255),
@Publicacion_Visibilidad_Precio numeric(18, 2),
@Publicacion_Visibilidad_Porcentaje numeric(18, 2),
@Publicacion_Estado nvarchar(255),
@Publicacion_Rubro_Descripcion nvarchar(255),
@Cli_Dni numeric(18, 0),
@Cli_Apeliido nvarchar(255),
@Cli_Nombre nvarchar(255),
@Cli_Fecha_Nac datetime,
@Cli_Mail nvarchar(255),
@Cli_Dom_Calle nvarchar(255),
@Cli_Nro_Calle numeric(18, 0),
@Cli_Piso numeric(18, 0),
@Cli_Depto nvarchar(50),
@Cli_Cod_Postal nvarchar(50),
@Compra_Fecha datetime,
@Compra_Cantidad numeric(18, 0),
@Oferta_Fecha datetime,
@Oferta_Monto numeric(18, 2),
@Calificacion_Codigo numeric(18, 0),
@Calificacion_Cant_Estrellas numeric(18, 0),
@Calificacion_Descripcion nvarchar(255),
@Item_Factura_Monto numeric(18, 2),
@Item_Factura_Cantidad numeric(18, 0),
@Factura_Nro numeric(18, 0),
@Factura_Fecha datetime,
@Factura_Total numeric(18, 2),
@Forma_Pago_Desc nvarchar(255);    

DECLARE maestra_cursor CURSOR FOR 
SELECT TOP 10 *
FROM [GD1C2014].[gd_esquema].[Maestra]
ORDER BY Publicacion_Cod, Factura_Fecha, Factura_Nro, Compra_Fecha, Calificacion_Codigo;

OPEN maestra_cursor
FETCH NEXT FROM maestra_cursor 
INTO @Publ_Cli_Dni,@Publ_Cli_Apeliido,@Publ_Cli_Nombre,@Publ_Cli_Fecha_Nac,@Publ_Cli_Mail,@Publ_Cli_Dom_Calle,@Publ_Cli_Nro_Calle,@Publ_Cli_Piso,@Publ_Cli_Depto,@Publ_Cli_Cod_Postal,@Publ_Empresa_Razon_Social,@Publ_Empresa_Cuit,@Publ_Empresa_Fecha_Creacion,@Publ_Empresa_Mail,@Publ_Empresa_Dom_Calle,@Publ_Empresa_Nro_Calle,@Publ_Empresa_Piso,@Publ_Empresa_Depto,@Publ_Empresa_Cod_Postal,@Publicacion_Cod,@Publicacion_Descripcion,@Publicacion_Stock,@Publicacion_Fecha,@Publicacion_Fecha_Venc,@Publicacion_Precio,@Publicacion_Tipo,@Publicacion_Visibilidad_Cod,@Publicacion_Visibilidad_Desc,@Publicacion_Visibilidad_Precio,@Publicacion_Visibilidad_Porcentaje,@Publicacion_Estado,@Publicacion_Rubro_Descripcion,@Cli_Dni,@Cli_Apeliido,@Cli_Nombre,@Cli_Fecha_Nac,@Cli_Mail,@Cli_Dom_Calle,@Cli_Nro_Calle,@Cli_Piso,@Cli_Depto,@Cli_Cod_Postal,@Compra_Fecha,@Compra_Cantidad,@Oferta_Fecha,@Oferta_Monto,@Calificacion_Codigo,@Calificacion_Cant_Estrellas,@Calificacion_Descripcion,@Item_Factura_Monto,@Item_Factura_Cantidad,@Factura_Nro,@Factura_Fecha,@Factura_Total,@Forma_Pago_Desc

WHILE @@FETCH_STATUS = 0
BEGIN

	IF @Publ_Cli_Dni IS NOT NULL
	BEGIN
		SELECT @Publ_Cli_Dni;
	END
	IF @Publ_Empresa_Razon_Social IS NOT NULL
	BEGIN
		SELECT @Publ_Empresa_Razon_Social;
	END
	
	FETCH NEXT FROM maestra_cursor 
    INTO @Publ_Cli_Dni,@Publ_Cli_Apeliido,@Publ_Cli_Nombre,@Publ_Cli_Fecha_Nac,@Publ_Cli_Mail,@Publ_Cli_Dom_Calle,@Publ_Cli_Nro_Calle,@Publ_Cli_Piso,@Publ_Cli_Depto,@Publ_Cli_Cod_Postal,@Publ_Empresa_Razon_Social,@Publ_Empresa_Cuit,@Publ_Empresa_Fecha_Creacion,@Publ_Empresa_Mail,@Publ_Empresa_Dom_Calle,@Publ_Empresa_Nro_Calle,@Publ_Empresa_Piso,@Publ_Empresa_Depto,@Publ_Empresa_Cod_Postal,@Publicacion_Cod,@Publicacion_Descripcion,@Publicacion_Stock,@Publicacion_Fecha,@Publicacion_Fecha_Venc,@Publicacion_Precio,@Publicacion_Tipo,@Publicacion_Visibilidad_Cod,@Publicacion_Visibilidad_Desc,@Publicacion_Visibilidad_Precio,@Publicacion_Visibilidad_Porcentaje,@Publicacion_Estado,@Publicacion_Rubro_Descripcion,@Cli_Dni,@Cli_Apeliido,@Cli_Nombre,@Cli_Fecha_Nac,@Cli_Mail,@Cli_Dom_Calle,@Cli_Nro_Calle,@Cli_Piso,@Cli_Depto,@Cli_Cod_Postal,@Compra_Fecha,@Compra_Cantidad,@Oferta_Fecha,@Oferta_Monto,@Calificacion_Codigo,@Calificacion_Cant_Estrellas,@Calificacion_Descripcion,@Item_Factura_Monto,@Item_Factura_Cantidad,@Factura_Nro,@Factura_Fecha,@Factura_Total,@Forma_Pago_Desc
END 
CLOSE maestra_cursor;
DEALLOCATE maestra_cursor;