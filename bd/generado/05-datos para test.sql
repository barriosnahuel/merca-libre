
-- Inserts funcionalidad 
INSERT INTO [GD1C2014].[GOODTIMES].[FUNCIONALIDAD]
           ([NOMBRE])
     VALUES
           ('funcionalidad1')
GO

INSERT INTO [GD1C2014].[GOODTIMES].[FUNCIONALIDAD]
           ([NOMBRE])
     VALUES
           ('funcionalidad2')
GO



-- Inserts funcionalidad X rol
INSERT INTO [GD1C2014].[GOODTIMES].[FUNCIONALIDAD_X_ROL]
           ([ROL_ID]
           ,[FUNCIONALIDAD_ID])
     VALUES
           (1
           ,1)
GO


INSERT INTO [GD1C2014].[GOODTIMES].[FUNCIONALIDAD_X_ROL]
           ([ROL_ID]
           ,[FUNCIONALIDAD_ID])
     VALUES
           (1
           ,2)
GO

INSERT INTO [GD1C2014].[GOODTIMES].[FUNCIONALIDAD_X_ROL]
           ([ROL_ID]
           ,[FUNCIONALIDAD_ID])
     VALUES
           (2
           ,1)
GO