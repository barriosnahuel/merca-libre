--	Pruebo los clientes. Tiene que dar 28.
DECLARE @registrosOriginales INT;
DECLARE @registrosMigrados INT;

SET @registrosOriginales = (
    SELECT count(DISTINCT Publ_Cli_Dni)
    FROM gd_esquema.Maestra)
SET @registrosMigrados = (
    SELECT COUNT(*)
    FROM GOODTIMES.CLIENTE)
IF (@registrosOriginales = @registrosMigrados)
    PRINT 'Clientes migrados OK: ' + cast(@registrosMigrados AS CHAR)
ELSE
    PRINT 'Clientes NO migrados OK: ' + cast(@registrosMigrados AS CHAR)

--	Pruebo las empresas. Tiene que dar 64.
SET @registrosOriginales = (
    SELECT count(DISTINCT Publ_Empresa_Cuit)
    FROM gd_esquema.Maestra)
SET @registrosMigrados = (
    SELECT COUNT(*)
    FROM GOODTIMES.EMPRESA)
IF (@registrosOriginales = @registrosMigrados)
    PRINT 'Empresas migradas OK: ' + cast(@registrosMigrados AS CHAR)
ELSE
    PRINT 'Empresas NO migradas OK: ' + cast(@registrosMigrados AS CHAR)


--	Pruebo las publicaciones. Tiene que dar 56028.
DECLARE @cantidadPublicaciones INT;
SET @registrosOriginales = (
    SELECT count(DISTINCT Publicacion_Cod)
    FROM gd_esquema.Maestra)
SET @registrosMigrados = (
    SELECT COUNT(*)
    FROM GOODTIMES.PUBLICACION)
SET @cantidadPublicaciones = @registrosMigrados
IF (@registrosOriginales = @registrosMigrados)
    PRINT 'Publicaciones migradas OK: ' + cast(@registrosMigrados AS CHAR)
ELSE
    PRINT 'Publicaciones NO migradas OK: ' + cast(@registrosMigrados AS CHAR)

--	Pruebo que las publicaciones tengan el estado que tienen que tener. Tiene que dar 1.
SET @registrosOriginales = (
    SELECT count(DISTINCT Publicacion_Estado)
    FROM gd_esquema.Maestra)
SET @registrosMigrados = (
    SELECT COUNT(DISTINCT ESTADO_ID)
    FROM GOODTIMES.PUBLICACION)
IF (@registrosOriginales = @registrosMigrados)
    PRINT 'Estado de las publicaciones migradas OK: ' + cast(@registrosMigrados AS CHAR)
ELSE
    PRINT 'Estado de las publicaciones NO migradas OK: ' + cast(@registrosMigrados AS CHAR)

--	Pruebo la visibilidad de la publicación. Tiene que dar 5.
SET @registrosOriginales = (
    SELECT count(DISTINCT Publicacion_Visibilidad_Cod)
    FROM gd_esquema.Maestra)
SET @registrosMigrados = (
    SELECT COUNT(*)
    FROM GOODTIMES.VISIBILIDAD_PUBLICACION)
IF (@registrosOriginales = @registrosMigrados)
    PRINT 'Visibilidad de las publicaciones migradas OK: ' + cast(@registrosMigrados AS CHAR)
ELSE
    PRINT 'Visibilidad de las publicaciones NO migradas OK: ' + cast(@registrosMigrados AS CHAR)

--	Pruebo las facturas. Tiene que dar 56028.
SET @registrosOriginales = (
    SELECT count(DISTINCT Factura_Nro)
    FROM gd_esquema.Maestra)
SET @registrosMigrados = (
    SELECT COUNT(*)
    FROM GOODTIMES.FACTURA)
IF (@registrosOriginales = @registrosMigrados)
    PRINT 'Facturas migradas OK: ' + cast(@registrosMigrados AS CHAR)
ELSE
    PRINT 'Facturas NO migradas OK: ' + cast(@registrosMigrados AS CHAR)

IF (@registrosMigrados = @cantidadPublicaciones)
    PRINT 'La cantidad de facturas es igual a la de publicaciones. Bien: ' + cast(@registrosMigrados AS CHAR)
ELSE
    PRINT
    'La cantidad de facturas debería ser igual a la cantidad de publicaciones dado que todas estan finalizadas y ya se deberían haber facturado: ' +
    cast(@registrosMigrados AS CHAR)
