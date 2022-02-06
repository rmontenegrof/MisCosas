﻿-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Transacciones_Insertar
	@UsuarioId int,
	@FechaTransaccion date,
	@Monto decimal(18,2),
	@CategoriaId int,
	@CuentaId int,
	@Observaciones nvarchar(1000) = NULL
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
		INSERT INTO Transacciones(UsuarioId, FechaTransaccion, Monto, CategoriaId, CuentaId, Observaciones)
		VALUES(@UsuarioId, @FechaTransaccion, ABS(@Monto), @CategoriaId, @CuentaId, @Observaciones)

		UPDATE Cuentas
		SET Balance += @Monto
		WHERE Id = @CuentaId;

		SELECT SCOPE_IDENTITY();
END
