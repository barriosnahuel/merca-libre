USE GD1C2014;
GO


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.FK_FUNCIONALIDAD_X_ROL_FUNCIONALIDAD') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE GOODTIMES.FUNCIONALIDAD_X_ROL DROP CONSTRAINT FK_FUNCIONALIDAD_X_ROL_FUNCIONALIDAD;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.FK_FUNCIONALIDAD_X_ROL_ROL') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE GOODTIMES.FUNCIONALIDAD_X_ROL DROP CONSTRAINT FK_FUNCIONALIDAD_X_ROL_ROL;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.FK_USUARIO_CLIENTE') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE GOODTIMES.USUARIO DROP CONSTRAINT FK_USUARIO_CLIENTE;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.FK_USUARIO_EMPRESA') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE GOODTIMES.USUARIO DROP CONSTRAINT FK_USUARIO_EMPRESA;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.FK_USUARIO_LOCALIDAD') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE GOODTIMES.USUARIO DROP CONSTRAINT FK_USUARIO_LOCALIDAD;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.FK_ROLES_X_USUARIO_ROL') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE GOODTIMES.ROLES_X_USUARIO DROP CONSTRAINT FK_ROLES_X_USUARIO_ROL;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.FK_ROLES_X_USUARIO_USUARIO') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE GOODTIMES.ROLES_X_USUARIO DROP CONSTRAINT FK_ROLES_X_USUARIO_USUARIO;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.FK_PUBLICACION_ESTADO') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE GOODTIMES.PUBLICACION DROP CONSTRAINT FK_PUBLICACION_ESTADO;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.FK_PUBLICACION_TIPO_PUBLICACION') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE GOODTIMES.PUBLICACION DROP CONSTRAINT FK_PUBLICACION_TIPO_PUBLICACION;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.FK_PUBLICACION_USUARIO') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE GOODTIMES.PUBLICACION DROP CONSTRAINT FK_PUBLICACION_USUARIO;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.FK_PUBLICACION_VISIBILIDAD_PUBLICACION') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE GOODTIMES.PUBLICACION DROP CONSTRAINT FK_PUBLICACION_VISIBILIDAD_PUBLICACION;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.FK_RUBROS_X_PUBLICACION_PUBLICACION') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE GOODTIMES.RUBROS_X_PUBLICACION DROP CONSTRAINT FK_RUBROS_X_PUBLICACION_PUBLICACION;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.FK_RUBROS_X_PUBLICACION_RUBRO') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE GOODTIMES.RUBROS_X_PUBLICACION DROP CONSTRAINT FK_RUBROS_X_PUBLICACION_RUBRO;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.FK_CALIFICACION_PUBLICACION') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE GOODTIMES.CALIFICACION DROP CONSTRAINT FK_CALIFICACION_PUBLICACION;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.FK_CALIFICACION_USUARIO') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE GOODTIMES.CALIFICACION DROP CONSTRAINT FK_CALIFICACION_USUARIO;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.FK_COMPRA_PUBLICACION') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE GOODTIMES.COMPRA DROP CONSTRAINT FK_COMPRA_PUBLICACION;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.FK_COMPRA_USUARIO') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE GOODTIMES.COMPRA DROP CONSTRAINT FK_COMPRA_USUARIO;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.FK_FACTURA_FORMA_PAGO') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE GOODTIMES.FACTURA DROP CONSTRAINT FK_FACTURA_FORMA_PAGO;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.FK_FACTURA_USUARIO') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE GOODTIMES.FACTURA DROP CONSTRAINT FK_FACTURA_USUARIO;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.FK_FACTURA_ITEM_FACTURA') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE GOODTIMES.FACTURA_ITEM DROP CONSTRAINT FK_FACTURA_ITEM_FACTURA;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.FK_FACTURA_ITEM_PUBLICACION') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE GOODTIMES.FACTURA_ITEM DROP CONSTRAINT FK_FACTURA_ITEM_PUBLICACION;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.FK_OFERTA_PUBLICACION') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE GOODTIMES.OFERTA DROP CONSTRAINT FK_OFERTA_PUBLICACION;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.FK_OFERTA_USUARIO') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE GOODTIMES.OFERTA DROP CONSTRAINT FK_OFERTA_USUARIO;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.FK_PREGUNTA_PUBLICACION') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE GOODTIMES.PREGUNTA DROP CONSTRAINT FK_PREGUNTA_PUBLICACION;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.FK_PREGUNTA_USUARIO') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE GOODTIMES.PREGUNTA DROP CONSTRAINT FK_PREGUNTA_USUARIO;



IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.CLIENTE') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GOODTIMES.CLIENTE;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.EMPRESA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GOODTIMES.EMPRESA;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.FUNCIONALIDAD') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GOODTIMES.FUNCIONALIDAD;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.FUNCIONALIDAD_X_ROL') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GOODTIMES.FUNCIONALIDAD_X_ROL;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.ROL') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GOODTIMES.ROL;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.USUARIO') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GOODTIMES.USUARIO;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.LOCALIDAD') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GOODTIMES.LOCALIDAD;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.ESTADO') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GOODTIMES.ESTADO;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.ROLES_X_USUARIO') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GOODTIMES.ROLES_X_USUARIO;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.PUBLICACION') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GOODTIMES.PUBLICACION;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.RUBRO') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GOODTIMES.RUBRO;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.RUBROS_X_PUBLICACION') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GOODTIMES.RUBROS_X_PUBLICACION;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.TIPO_PUBLICACION') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GOODTIMES.TIPO_PUBLICACION;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.VISIBILIDAD_PUBLICACION') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GOODTIMES.VISIBILIDAD_PUBLICACION;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.CALIFICACION') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GOODTIMES.CALIFICACION;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.COMPRA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GOODTIMES.COMPRA;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.FACTURA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GOODTIMES.FACTURA;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.FACTURA_ITEM') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GOODTIMES.FACTURA_ITEM;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.FORMA_PAGO') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GOODTIMES.FORMA_PAGO;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.OFERTA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GOODTIMES.OFERTA;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('GOODTIMES.PREGUNTA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GOODTIMES.PREGUNTA;


CREATE TABLE GOODTIMES.CLIENTE ( 
	ID bigint identity(1,1)  NOT NULL,
	NOMBRE nvarchar(max) NOT NULL,
	APELLIDO nvarchar(max) NOT NULL,
	DNI numeric(18) NOT NULL,
	DNI_TIPO char(3) NOT NULL,
	FECHA_NAC datetime NOT NULL
);

CREATE TABLE GOODTIMES.EMPRESA ( 
	CUIT bigint NOT NULL,
	RAZON_SOCIAL nvarchar(max) NOT NULL,
	CONTACTO nvarchar(max) NOT NULL,
	FECHA_CREACION datetime NOT NULL
);

CREATE TABLE GOODTIMES.FUNCIONALIDAD ( 
	ID int identity(1,1)  NOT NULL,
	NOMBRE nvarchar(max) NOT NULL
);

CREATE TABLE GOODTIMES.FUNCIONALIDAD_X_ROL ( 
	ROL_ID int NOT NULL,
	FUNCIONALIDAD_ID int NOT NULL
);

CREATE TABLE GOODTIMES.ROL ( 
	ID int identity(1,1)  NOT NULL,
	NOMBRE nvarchar(50) NOT NULL,
	HABILITADO bit DEFAULT 1 NOT NULL,
	ELIMINADO bit DEFAULT 0 NOT NULL
);

CREATE TABLE GOODTIMES.USUARIO ( 
	ID bigint identity(1,1)  NOT NULL,
	USERNAME nvarchar(50) NOT NULL,
	PASSWORD nvarchar(max) NOT NULL,
	CLIENTE_ID bigint,
	EMPRESA_ID bigint,
	LOGIN_FALLIDOS int DEFAULT 0 NOT NULL,
	HABILITADO bit DEFAULT 1 NOT NULL,
	ELIMINADO bit DEFAULT 0 NOT NULL,
	MAIL nvarchar(50) NOT NULL,
	TELEFONO int NOT NULL,
	COD_POSTAL int NOT NULL,
	DIRECCION nvarchar(max) NOT NULL,
	PISO numeric(18) NOT NULL,
	DTO nvarchar(50) NOT NULL
);

CREATE TABLE GOODTIMES.LOCALIDAD ( 
	COD_POSTAL int NOT NULL,
	NOMBRE nvarchar(max) NOT NULL
);

CREATE TABLE GOODTIMES.ESTADO ( 
	ID smallint identity(1,1)  NOT NULL,
	DESCRIPCION nvarchar(max) NOT NULL
);

CREATE TABLE GOODTIMES.ROLES_X_USUARIO ( 
	USUARIO_ID bigint NOT NULL,
	ROL_ID int NOT NULL
);

CREATE TABLE GOODTIMES.PUBLICACION ( 
	ID numeric(18) identity(1,1)  NOT NULL,
	USUARIO_ID bigint NOT NULL,
	DESCRIPCION nvarchar(max) NOT NULL,
	UNIDADES numeric(18) NOT NULL,
	PRECIO numeric(18,2) NOT NULL,
	FEC_INICIO datetime NOT NULL,
	FEC_FIN datetime NOT NULL,
	TIPO_PUBLICACION_ID smallint NOT NULL,
	ESTADO_ID smallint NOT NULL,
	VISIBILIDAD_ID smallint NOT NULL,
	ADMITE_PREGUNTAS bit DEFAULT 1 NOT NULL
);

CREATE TABLE GOODTIMES.RUBRO ( 
	CODIGO int identity(1,1)  NOT NULL,
	DESCRIPCION varchar(max) NOT NULL
);

CREATE TABLE GOODTIMES.RUBROS_X_PUBLICACION ( 
	PUBLICACION_ID numeric(18) NOT NULL,
	RUBRO_ID int NOT NULL
);

CREATE TABLE GOODTIMES.TIPO_PUBLICACION ( 
	ID smallint identity(1,1)  NOT NULL,
	DESCRIPCION nvarchar(max) NOT NULL
);

CREATE TABLE GOODTIMES.VISIBILIDAD_PUBLICACION ( 
	ID smallint NOT NULL,
	DESCRIPCION nvarchar(max) NOT NULL,
	PRECIO int NOT NULL,
	PORC_GANANCIA float NOT NULL
);

CREATE TABLE GOODTIMES.CALIFICACION ( 
	ID numeric(18) identity(1,1)  NOT NULL,
	USUARIO_ID bigint NOT NULL,
	PUBLICACION_ID numeric(18) NOT NULL,
	PUNTAJE numeric(18) NOT NULL,
	DETALLE nvarchar(max)
);

CREATE TABLE GOODTIMES.COMPRA ( 
	ID bigint identity(1,1)  NOT NULL,
	USUARIO_ID bigint NOT NULL,
	PUBLICACION_ID numeric(18) NOT NULL,
	CANTIDAD numeric(18) NOT NULL,
	FECHA datetime NOT NULL
);

CREATE TABLE GOODTIMES.FACTURA ( 
	ID numeric(18) identity(1,1)  NOT NULL,
	USUARIO_ID bigint NOT NULL,
	FECHA datetime NOT NULL,
	FORMA_PAGO_ID smallint NOT NULL,
	CODIGO_TARJETA bigint
);

CREATE TABLE GOODTIMES.FACTURA_ITEM ( 
	ID bigint identity(1,1)  NOT NULL,
	FACTURA_ID numeric(18) NOT NULL,
	PUBLICACION_ID numeric(18) NOT NULL,
	CANTIDAD numeric(18) NOT NULL,
	MONTO numeric(18,2) NOT NULL,
	DETALLE nvarchar(max) NOT NULL
);

CREATE TABLE GOODTIMES.FORMA_PAGO ( 
	ID smallint identity(1,1)  NOT NULL,
	DESCRIPCION nvarchar(max) NOT NULL
);

CREATE TABLE GOODTIMES.OFERTA ( 
	ID bigint identity(1,1)  NOT NULL,
	USUARIO_ID bigint NOT NULL,
	PUBLICACION_ID numeric(18) NOT NULL,
	FECHA datetime NOT NULL,
	MONTO numeric(18) NOT NULL,
	COMPRO bit DEFAULT 0 NOT NULL
);

CREATE TABLE GOODTIMES.PREGUNTA ( 
	ID bigint identity(1,1)  NOT NULL,
	USUARIO_ID bigint NOT NULL,
	PUBLICACION_ID numeric(18) NOT NULL,
	PREGUNTA nvarchar(max) NOT NULL,
	FEC_PREG datetime NOT NULL,
	RESPUESTA nvarchar(max),
	FEC_RESP datetime
);


ALTER TABLE GOODTIMES.CLIENTE ADD CONSTRAINT PK_CLIENTE 
	PRIMARY KEY CLUSTERED (ID);

ALTER TABLE GOODTIMES.EMPRESA ADD CONSTRAINT PK_EMPRESA 
	PRIMARY KEY CLUSTERED (CUIT);

ALTER TABLE GOODTIMES.FUNCIONALIDAD ADD CONSTRAINT PK_FUNCIONALIDAD 
	PRIMARY KEY CLUSTERED (ID);

ALTER TABLE GOODTIMES.FUNCIONALIDAD_X_ROL ADD CONSTRAINT PK_FUNCIONALIDAD_X_ROL 
	PRIMARY KEY CLUSTERED (ROL_ID, FUNCIONALIDAD_ID);

ALTER TABLE GOODTIMES.ROL ADD CONSTRAINT PK_ROL 
	PRIMARY KEY CLUSTERED (ID);

ALTER TABLE GOODTIMES.USUARIO ADD CONSTRAINT PK_USUARIO 
	PRIMARY KEY CLUSTERED (ID);

ALTER TABLE GOODTIMES.LOCALIDAD ADD CONSTRAINT PK_LOCALIDAD 
	PRIMARY KEY CLUSTERED (COD_POSTAL);

ALTER TABLE GOODTIMES.ESTADO ADD CONSTRAINT PK_ESTADO 
	PRIMARY KEY CLUSTERED (ID);

ALTER TABLE GOODTIMES.ROLES_X_USUARIO ADD CONSTRAINT PK_ROLES_X_USUARIO 
	PRIMARY KEY CLUSTERED (USUARIO_ID, ROL_ID);

ALTER TABLE GOODTIMES.PUBLICACION ADD CONSTRAINT PK_PUBLICACION 
	PRIMARY KEY CLUSTERED (ID);

ALTER TABLE GOODTIMES.RUBRO ADD CONSTRAINT PK_RUBRO 
	PRIMARY KEY CLUSTERED (CODIGO);

ALTER TABLE GOODTIMES.RUBROS_X_PUBLICACION ADD CONSTRAINT PK_RUBROS_X_PUBLICACION 
	PRIMARY KEY CLUSTERED (PUBLICACION_ID, RUBRO_ID);

ALTER TABLE GOODTIMES.TIPO_PUBLICACION ADD CONSTRAINT PK_TIPO_PUBLICACION 
	PRIMARY KEY CLUSTERED (ID);

ALTER TABLE GOODTIMES.VISIBILIDAD_PUBLICACION ADD CONSTRAINT PK_VISIBILIDAD_PUBLICACION 
	PRIMARY KEY CLUSTERED (ID);

ALTER TABLE GOODTIMES.CALIFICACION ADD CONSTRAINT PK_CALIFICACION 
	PRIMARY KEY CLUSTERED (ID);

ALTER TABLE GOODTIMES.COMPRA ADD CONSTRAINT PK_COMPRA 
	PRIMARY KEY CLUSTERED (ID);

ALTER TABLE GOODTIMES.FACTURA ADD CONSTRAINT PK_FACTURA 
	PRIMARY KEY CLUSTERED (ID);

ALTER TABLE GOODTIMES.FACTURA_ITEM ADD CONSTRAINT PK_FACTURA_ITEM 
	PRIMARY KEY CLUSTERED (ID);

ALTER TABLE GOODTIMES.FORMA_PAGO ADD CONSTRAINT PK_FORMA_PAGO 
	PRIMARY KEY CLUSTERED (ID);

ALTER TABLE GOODTIMES.OFERTA ADD CONSTRAINT PK_OFERTA 
	PRIMARY KEY CLUSTERED (ID);

ALTER TABLE GOODTIMES.PREGUNTA ADD CONSTRAINT PK_PREGUNTA 
	PRIMARY KEY CLUSTERED (ID);



ALTER TABLE GOODTIMES.FUNCIONALIDAD_X_ROL ADD CONSTRAINT FK_FUNCIONALIDAD_X_ROL_FUNCIONALIDAD 
	FOREIGN KEY (FUNCIONALIDAD_ID) REFERENCES GOODTIMES.FUNCIONALIDAD (ID);

ALTER TABLE GOODTIMES.FUNCIONALIDAD_X_ROL ADD CONSTRAINT FK_FUNCIONALIDAD_X_ROL_ROL 
	FOREIGN KEY (ROL_ID) REFERENCES GOODTIMES.ROL (ID);

ALTER TABLE GOODTIMES.USUARIO ADD CONSTRAINT FK_USUARIO_CLIENTE 
	FOREIGN KEY (CLIENTE_ID) REFERENCES GOODTIMES.CLIENTE (ID);

ALTER TABLE GOODTIMES.USUARIO ADD CONSTRAINT FK_USUARIO_EMPRESA 
	FOREIGN KEY (EMPRESA_ID) REFERENCES GOODTIMES.EMPRESA (CUIT);

ALTER TABLE GOODTIMES.USUARIO ADD CONSTRAINT FK_USUARIO_LOCALIDAD 
	FOREIGN KEY (COD_POSTAL) REFERENCES GOODTIMES.LOCALIDAD (COD_POSTAL);

ALTER TABLE GOODTIMES.ROLES_X_USUARIO ADD CONSTRAINT FK_ROLES_X_USUARIO_ROL 
	FOREIGN KEY (ROL_ID) REFERENCES GOODTIMES.ROL (ID);

ALTER TABLE GOODTIMES.ROLES_X_USUARIO ADD CONSTRAINT FK_ROLES_X_USUARIO_USUARIO 
	FOREIGN KEY (USUARIO_ID) REFERENCES GOODTIMES.USUARIO (ID);

ALTER TABLE GOODTIMES.PUBLICACION ADD CONSTRAINT FK_PUBLICACION_ESTADO 
	FOREIGN KEY (ESTADO_ID) REFERENCES GOODTIMES.ESTADO (ID);

ALTER TABLE GOODTIMES.PUBLICACION ADD CONSTRAINT FK_PUBLICACION_TIPO_PUBLICACION 
	FOREIGN KEY (TIPO_PUBLICACION_ID) REFERENCES GOODTIMES.TIPO_PUBLICACION (ID);

ALTER TABLE GOODTIMES.PUBLICACION ADD CONSTRAINT FK_PUBLICACION_USUARIO 
	FOREIGN KEY (USUARIO_ID) REFERENCES GOODTIMES.USUARIO (ID);

ALTER TABLE GOODTIMES.PUBLICACION ADD CONSTRAINT FK_PUBLICACION_VISIBILIDAD_PUBLICACION 
	FOREIGN KEY (VISIBILIDAD_ID) REFERENCES GOODTIMES.VISIBILIDAD_PUBLICACION (ID);

ALTER TABLE GOODTIMES.RUBROS_X_PUBLICACION ADD CONSTRAINT FK_RUBROS_X_PUBLICACION_PUBLICACION 
	FOREIGN KEY (PUBLICACION_ID) REFERENCES GOODTIMES.PUBLICACION (ID);

ALTER TABLE GOODTIMES.RUBROS_X_PUBLICACION ADD CONSTRAINT FK_RUBROS_X_PUBLICACION_RUBRO 
	FOREIGN KEY (RUBRO_ID) REFERENCES GOODTIMES.RUBRO (CODIGO);

ALTER TABLE GOODTIMES.CALIFICACION ADD CONSTRAINT FK_CALIFICACION_PUBLICACION 
	FOREIGN KEY (PUBLICACION_ID) REFERENCES GOODTIMES.PUBLICACION (ID);

ALTER TABLE GOODTIMES.CALIFICACION ADD CONSTRAINT FK_CALIFICACION_USUARIO 
	FOREIGN KEY (USUARIO_ID) REFERENCES GOODTIMES.USUARIO (ID);

ALTER TABLE GOODTIMES.COMPRA ADD CONSTRAINT FK_COMPRA_PUBLICACION 
	FOREIGN KEY (PUBLICACION_ID) REFERENCES GOODTIMES.PUBLICACION (ID);

ALTER TABLE GOODTIMES.COMPRA ADD CONSTRAINT FK_COMPRA_USUARIO 
	FOREIGN KEY (USUARIO_ID) REFERENCES GOODTIMES.USUARIO (ID);

ALTER TABLE GOODTIMES.FACTURA ADD CONSTRAINT FK_FACTURA_FORMA_PAGO 
	FOREIGN KEY (FORMA_PAGO_ID) REFERENCES GOODTIMES.FORMA_PAGO (ID);

ALTER TABLE GOODTIMES.FACTURA ADD CONSTRAINT FK_FACTURA_USUARIO 
	FOREIGN KEY (USUARIO_ID) REFERENCES GOODTIMES.USUARIO (ID);

ALTER TABLE GOODTIMES.FACTURA_ITEM ADD CONSTRAINT FK_FACTURA_ITEM_FACTURA 
	FOREIGN KEY (FACTURA_ID) REFERENCES GOODTIMES.FACTURA (ID);

ALTER TABLE GOODTIMES.FACTURA_ITEM ADD CONSTRAINT FK_FACTURA_ITEM_PUBLICACION 
	FOREIGN KEY (PUBLICACION_ID) REFERENCES GOODTIMES.PUBLICACION (ID);

ALTER TABLE GOODTIMES.OFERTA ADD CONSTRAINT FK_OFERTA_PUBLICACION 
	FOREIGN KEY (PUBLICACION_ID) REFERENCES GOODTIMES.PUBLICACION (ID);

ALTER TABLE GOODTIMES.OFERTA ADD CONSTRAINT FK_OFERTA_USUARIO 
	FOREIGN KEY (USUARIO_ID) REFERENCES GOODTIMES.USUARIO (ID);

ALTER TABLE GOODTIMES.PREGUNTA ADD CONSTRAINT FK_PREGUNTA_PUBLICACION 
	FOREIGN KEY (PUBLICACION_ID) REFERENCES GOODTIMES.PUBLICACION (ID);

ALTER TABLE GOODTIMES.PREGUNTA ADD CONSTRAINT FK_PREGUNTA_USUARIO 
	FOREIGN KEY (USUARIO_ID) REFERENCES GOODTIMES.USUARIO (ID);
