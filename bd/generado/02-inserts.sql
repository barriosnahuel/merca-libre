--	Inserts para tabla maestra ROL
INSERT INTO [GD1C2014].[dbo].[ROL]
           ([NOMBRE])
     VALUES
           ('Administrativo')
           
INSERT INTO [GD1C2014].[dbo].[ROL]
           ([NOMBRE])
     VALUES
           ('Cliente')
           
INSERT INTO [GD1C2014].[dbo].[ROL]
           ([NOMBRE])
     VALUES
           ('Empresa')
GO


--	Inserts para tabla maestra ESTADO
INSERT INTO [GD1C2014].[dbo].[ESTADO]
           ([DESCRIPCION])
     VALUES
           ('Borrador')
INSERT INTO [GD1C2014].[dbo].[ESTADO]
           ([DESCRIPCION])
     VALUES
           ('Publicada')
INSERT INTO [GD1C2014].[dbo].[ESTADO]
           ([DESCRIPCION])
     VALUES
           ('Pausada')
INSERT INTO [GD1C2014].[dbo].[ESTADO]
           ([DESCRIPCION])
     VALUES
           ('Finalizada')
GO

--	Inserts para tabla maestra TIPO_PUBLICACION
INSERT INTO [GD1C2014].[dbo].[TIPO_PUBLICACION]
           ([DESCRIPCION])
     VALUES
           ('Compra inmediata')
INSERT INTO [GD1C2014].[dbo].[TIPO_PUBLICACION]
           ([DESCRIPCION])
     VALUES
           ('Subasta')
GO


--	Inserts para tabla maestra RUBRO
INSERT INTO [GD1C2014].[dbo].[RUBRO]
           ([DESCRIPCION])
     VALUES
           ('Entretenimiento')
INSERT INTO [GD1C2014].[dbo].[RUBRO]
           ([DESCRIPCION])
     VALUES
           ('Hogar')
INSERT INTO [GD1C2014].[dbo].[RUBRO]
           ([DESCRIPCION])
     VALUES
           ('Cuidado personal')
GO