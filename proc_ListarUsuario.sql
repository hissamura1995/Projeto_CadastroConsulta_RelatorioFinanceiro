IF EXISTS (SELECT * FROM dbo.sysobjects WHERE NAME LIKE 'proc_ListarUsuario')
BEGIN
	DROP PROCEDURE dbo.proc_ListarUsuario
END
GO

CREATE PROCEDURE proc_ListarUsuario
	@LoginUsuario VARCHAR(20),
	@SenhaUsuario VARCHAR(12)

------------------------------------------------------------------------------------------------
--// _______________________________________//
--//			DESCRIÇÃO					//
--//	Procedure de pesquisa de usuário	//
--//	Autor: Renan Hissamura				//
--//	10/10/2022							//
--//________________________________________//

--EXEC proc_ListarUsuario @LoginUsuario = 'Admin', @SenhaUsuario = '12345678'
------------------------------------------------------------------------------------------------

AS
BEGIN

SELECT * FROM tbUsuario as Usuario
	WHERE Usuario.LoginUsuario = @LoginUsuario COLLATE SQL_Latin1_General_CP1_CS_AS and Usuario.SenhaUsuario = @SenhaUsuario COLLATE SQL_Latin1_General_CP1_CS_AS

END;
GO
	
