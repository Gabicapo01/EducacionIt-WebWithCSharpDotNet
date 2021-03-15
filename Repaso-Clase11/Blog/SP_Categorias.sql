USE [EducacionIT.Blog]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_Categorias]
	@ParametroNumerico int,
	@ParametroText Varchar(120)
AS
BEGIN
	SELECT * FROM CATEGORIAS
END
GO