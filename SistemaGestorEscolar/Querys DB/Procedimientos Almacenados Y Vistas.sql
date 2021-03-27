USE StaMariaNazarethDatabaseService
GO

/*PROCEDIMIENTOS OSCAR MEJIA*/
--/*GENERAR LOS COBROS MENSUALES*/

CREATE PROCEDURE PAGeneracionPagos(@fechaFacturacion date,  @imagen as varbinary(max))
AS BEGIN
	
	DECLARE @cantidadEstudiantes as int, @contador as int = 1, @identidadEstudiante as varchar(13), @totalMatricula as money, 
			@idUltimoPago as int, @dineroUltimoPago as money, @ultimoSaldo as money, @ultimaDeuda as money, @mesesPago as int, @noFacturaActual as int,
			@idUltimoDetalleMatricula as int;

	SET @cantidadEstudiantes = (SELECT MAX(id_Registro) FROM datosEstudiante)

	WHILE @contador <= @cantidadEstudiantes
	BEGIN

		SET @identidadEstudiante = (SELECT identidadEstudiante FROM datosEstudiante WHERE id_Registro = @contador)
		

		IF @identidadEstudiante IS NOT NULL
		BEGIN

			SET @idUltimoDetalleMatricula = (SELECT MAX(id_DetalleMatricula) FROM
											detalleMatricula 
											INNER JOIN matricula ON detalleMatricula.id_RegistroMatricula = matricula.id_RegistroMatricula
										    WHERE matricula.id_Estudiante = @identidadEstudiante)

			SET @totalMatricula = (SELECT totalMatricula FROM 
										   detalleMatricula 
										   WHERE id_DetalleMatricula = @idUltimoDetalleMatricula)

			SET @idUltimoPago = (SELECT MAX(id_Mensualidad) FROM
													   detalleMensualidades 
													   WHERE id_Estudiante = @identidadEstudiante)
			
			SET @mesesPago = (SELECT mesesParaPagar FROM 
										                 detalleMatricula 
														 INNER JOIN matricula 
														 ON matricula.id_RegistroMatricula = detalleMatricula.id_RegistroMatricula 
														 WHERE matricula.id_RegistroMatricula = @idUltimoDetalleMatricula)

			SET @noFacturaActual = (SELECT noFacturaTemporal FROM 
										                 detalleMensualidades 
														 WHERE detalleMensualidades.id_Mensualidad = @idUltimoPago)

			
			SET @ultimaDeuda = (SELECT deudaPendiente FROM detalleMensualidades 
													  WHERE id_Mensualidad = @idUltimoPago)

			SET @ultimoSaldo = (SELECT saldoDisponible FROM detalleMensualidades 
					           WHERE id_Mensualidad = @idUltimoPago)
			
			If @noFacturaActual < @mesesPago
			BEGIN
				IF @mesesPago = 10
				BEGIN
					SET @totalMatricula = @totalMatricula * 12
					SET @totalMatricula = @totalMatricula / 10
				END

				IF @ultimaDeuda > 0
				BEGIN
					SET @totalMatricula += @ultimaDeuda
				END

				ELSE IF (@ultimoSaldo > 0) and (@ultimoSaldo < @totalMatricula)
				BEGIN
					SET @totalMatricula = @totalMatricula - @ultimoSaldo
					SET @ultimoSaldo = 0
				END

				ELSE IF @ultimoSaldo >= @totalMatricula
				BEGIN
					SET @ultimoSaldo = @ultimoSaldo - @totalMatricula
					SET @totalMatricula = 0
				END

				ELSE IF @ultimaDeuda = 0 and @ultimoSaldo = 0
				BEGIN
					SET @totalMatricula = @totalMatricula
					SET @ultimoSaldo = 0
				END
				
				SET @noFacturaActual += 1

				INSERT INTO detalleMensualidades VALUES(@identidadEstudiante, @noFacturaActual, @fechaFacturacion, null, @totalMatricula, @ultimoSaldo , 0, @imagen)
			END
		END
	
		SET @contador += 1
	END
END
GO

--EXECUTE PAFacturacionPrimerPago '1001200200094', '05/10/2020'

CREATE PROCEDURE PAFacturacionPrimerPago(@identidadEstudiante varchar(13))
AS BEGIN
	
	
	DECLARE @cantidadEstudiantes as int, @contador as int = 1, @totalMatricula as money, 
			@idUltimoDetalleMatricula as int, @dineroUltimoPago as money, @ultimoSaldo as money, @ultimaDeuda as money, @mesesPago as int, @idUltimoPago as Int, @fechaFacturacion as Date;
		
			SET @fechaFacturacion = GETDATE()
		
			SET @idUltimoDetalleMatricula = (SELECT MAX(id_DetalleMatricula) FROM
											detalleMatricula 
											INNER JOIN matricula ON detalleMatricula.id_RegistroMatricula = matricula.id_RegistroMatricula
										    WHERE matricula.id_Estudiante = @identidadEstudiante)

			SET @idUltimoPago = (SELECT MAX(id_Mensualidad) FROM
											detalleMensualidades 
											WHERE id_Estudiante = @identidadEstudiante)

			SET @ultimoSaldo = (SELECT saldoDisponible FROM detalleMensualidades 
					           WHERE id_Mensualidad = @idUltimoPago)

			SET @totalMatricula = (SELECT totalMatricula FROM 
										   detalleMatricula 
										   WHERE id_DetalleMatricula = @idUltimoDetalleMatricula)

			IF @totalMatricula <= @ultimoSaldo
			BEGIN
				SET @ultimoSaldo = @ultimoSaldo - @totalMatricula
				SET @totalMatricula = 0
			END

			ELSE IF @totalMatricula > @ultimoSaldo
			BEGIN
				SET @totalMatricula = @totalMatricula - @ultimoSaldo
				SET @ultimoSaldo = 0
			END

			ELSE IF @totalMatricula = @ultimoSaldo
			BEGIN
				SET @totalMatricula = 0
				SET @ultimoSaldo = 0
			END

		INSERT INTO detalleMensualidades VALUES(@identidadEstudiante, 1, @fechaFacturacion, null, @totalMatricula, @ultimoSaldo , 0, null)
END
GO

/*Procedimiento que registra los pagos de un estudiante*/
--EXEC PARegistroPago '1001200200094', 4000, '04/25/2020', 0

CREATE PROCEDURE PARegistroPago(@identidadEstudiante varchar(13), @montoPago as money, @fechaPago date, @descuento money, @imagen as image)
AS BEGIN
	
	DECLARE @id_Mensualidad as int, @saldoNuevo as money, @deudaMensualidad as money;

	SET @id_Mensualidad = (SELECT MAX(id_Mensualidad) FROM detalleMensualidades WHERE id_Estudiante = @identidadEstudiante)
	SET @deudaMensualidad = (SELECT deudaPendiente FROM detalleMensualidades WHERE id_Mensualidad = @id_Mensualidad)

	SET @deudaMensualidad = @deudaMensualidad - @descuento

	IF @deudaMensualidad = 0
	BEGIN 
		UPDATE detalleMensualidades SET fechaPago = @fechaPago,
										saldoDisponible = @montoPago + saldoDisponible
									WHERE id_Mensualidad = @id_Mensualidad
	END


	ELSE IF @deudaMensualidad > 0
	BEGIN 

		IF @deudaMensualidad > @montoPago
		BEGIN

		UPDATE detalleMensualidades SET fechaPago = @fechaPago,
										deudaPendiente = @deudaMensualidad - @montoPago,  
										descuentoMensualidad = @descuento, 
										comprobantePago =  @imagen
									WHERE id_Mensualidad = @id_Mensualidad
		END

		ELSE IF @deudaMensualidad <= @montoPago
		BEGIN

		UPDATE detalleMensualidades SET fechaPago = @fechaPago,
										saldoDisponible = @montoPago - @deudaMensualidad,
										deudaPendiente = 0,  
										descuentoMensualidad = @descuento,
										comprobantePago =  @imagen
								
									WHERE id_Mensualidad = @id_Mensualidad
		END
	END
END
GO


/*PROCEDIMIENTOS PARA INSERTAR EN MATRICULA Y DETALLE MATRICULA*/
create PROCEDURE PARegistroMatricula(@identidadAdministracion varchar(13), @identidadEncargado varchar(13), @identidadEstudiante varchar(13), @idCurso int, @idSeccion int, @totalMatricula float, @tipoMatricula int, @mesesPago int, @estado int, @codigoOperacion int)
AS BEGIN
	
	DECLARE @idMatricula as int, @ultimoDetalleMatricula as int;
	
	IF @codigoOperacion = 1
	BEGIN
		INSERT INTO matricula VALUES(GETDATE(), @identidadAdministracion, @identidadEncargado, @identidadEstudiante)
		SET @idMatricula = (SELECT id_RegistroMatricula FROM matricula WHERE id_Estudiante = @identidadEstudiante)
		
		INSERT INTO detalleMatricula VALUES(@idMatricula, GETDATE(), @idCurso, @idSeccion, @totalMatricula, @tipoMatricula, @mesesPago, @estado)
	END
	ELSE IF @codigoOperacion = 2
	BEGIN
		
		SET @idMatricula = (SELECT id_RegistroMatricula FROM matricula WHERE id_Estudiante = @identidadEstudiante)

		INSERT INTO detalleMatricula VALUES(@idMatricula, GETDATE(), @idCurso, @idSeccion, @totalMatricula, @tipoMatricula, @mesesPago, @estado)
	END

	ELSE IF @codigoOperacion = 3
	BEGIN
		SET @idMatricula = (SELECT id_RegistroMatricula FROM matricula WHERE id_Estudiante = @identidadEstudiante)
		SET @ultimoDetalleMatricula = (SELECT MAX(id_DetalleMatricula) FROM detalleMatricula WHERE id_RegistroMatricula = @idMatricula)

		UPDATE detalleMatricula SET estado = @estado WHERE id_DetalleMatricula = @ultimoDetalleMatricula 
	END
END
GO

/*ALEXIS*/
CREATE PROCEDURE PAAgregaYComprobarCargo(@identidad varchar(13), @cCargo int, @CODIGO int)
AS BEGIN
	
	IF(@CODIGO = 1)
	BEGIN
		IF (EXISTS(SELECT identidadEmpleado FROM detalleCargos WHERE identidadEmpleado = @identidad AND idCargoAsociado = @cCargo))
			raisError('Ya existe un registro con este ID', 16, 1)
		ELSE
			INSERT INTO detalleCargos VALUES(@identidad, @cCargo)
	END
	ELSE
	IF(@CODIGO = 2)
		IF (EXISTS(SELECT identidadEmpleado FROM detalleCargos WHERE identidadEmpleado = @identidad AND idCargoAsociado = @cCargo))
			raisError('Ya existe un registro con este ID', 16, 1)

END
GO

CREATE PROCEDURE PAOperacionEmpleados(@idPersona varchar(13), @prNombre varchar(20), @sgNombre varchar(20), 
@prApellido varchar(20), @sgApellido varchar(20), @numTelefono numeric(9,0), @fNacimiento date, @mail varchar(330),
@estEmpleado int, @contra varchar(80), @idCargo int, @idCargoAnterior int null, @CODIGO int)
AS BEGIN
	
	IF @CODIGO = 1
	BEGIN
		IF NOT EXISTS(SELECT identidadPersona FROM datosEmpleados where identidadPersona = @idPersona)
		BEGIN
			INSERT INTO datosEmpleados VALUES (@idPersona, @prNombre, @sgNombre, @prApellido, @sgApellido, @numTelefono,
			CAST(@fNacimiento AS DATE), @mail, @estEmpleado, @contra)
			INSERT INTO detalleCargos VALUES (@idPersona, @idCargo)
		END
		ELSE
			raisError('Ya existe un registro', 16, 1)
	END
	ELSE IF @CODIGO = 2
	BEGIN
		IF NOT EXISTS(SELECT identidadPersona FROM datosEmpleados where identidadPersona = @idPersona)
			raisError('No existe un registro con esta identidad', 16, 1)
		ELSE
			BEGIN
				UPDATE datosEmpleados SET primerNombre = @prNombre, segundoNombre = @sgNombre, primerApellido = @prApellido, segundoApellido = @sgApellido,
				numeroTelefono = @numTelefono, fechaNacimiento = CAST(@fNacimiento AS DATE), correoElectronico = @mail, estadoEmpleado = @estEmpleado, 
				contraseniaEmpleado = @contra WHERE identidadPersona = @idPersona
				--CUANDO SE LE ENVIE EL VALOR -1 NO ENTRARA A ACTUALIZAR EL CARGO ANTERIOR
				IF @idCargoAnterior <> -1
					UPDATE detalleCargos SET idCargoAsociado = @idCargo WHERE identidadEmpleado = @idPersona AND idCargoAsociado = @idCargoAnterior
			END
	END
END
GO


/*HECTOR*/



-------------------------------------------------------------Encargado---------------------------------------------------------------------


--Procedimiento almacenado para registrar un encargado 
CREATE procedure RegistrarEncargado
(
@NumidentidadEstudiante varchar(13), @Numidentidad varchar(13), @primerNombre varchar(20), @segundoNombre varchar(20), @primerApellido varchar(20), 
@segundoApellido varchar(20), @correoElectronico varchar(20), @numeroTelefono numeric(9,0), @numeroTelefonoAlt numeric(9,0),
 @direccionTrabajo varchar(MAX), @fechaNacimiento DATE
)
AS
BEGIN
if exists(select estado from datosEncargado where identidadEncargado = @Numidentidad and estado = 2)
begin
	update datosEncargado 
	set primerNombre = @PrimerNombre, segundoNombre = @segundoNombre, primerApellido = @PrimerApellido, segundoApellido = @SegundoApellido,
	correoElectronico = @correoElectronico, numeroTelefono = @numeroTelefono, numeroTelefonoAlt = @numeroTelefonoAlt, direccionTrabajo = @direccionTrabajo, estado = 1
	where identidadEncargado = @Numidentidad

end
else if not exists(select identidadEncargado from datosEncargado where identidadEncargado = @Numidentidad)
begin
	INSERT INTO datosEncargado VALUES(@Numidentidad, @primerNombre, @segundoNombre, @primerApellido, @segundoApellido, @numeroTelefono, @numeroTelefonoAlt,
	@correoElectronico, @direccionTrabajo, @fechaNacimiento, 1);
end

if not exists(select id_Estudiante from detalleEncargado where id_encargadoAlumno = @Numidentidad and  id_Estudiante = @NumidentidadEstudiante)
begin
INSERT INTO detalleEncargado VALUES(@Numidentidad, @NumidentidadEstudiante);
end

END
GO



--Procedimiento Almacenado para Actualizar Encargado
Create procedure ActualizarEncargado
(
@Numidentidad varchar(13), @primerNombre varchar(20), @segundoNombre varchar(20), @primerApellido varchar(20), 
@segundoApellido varchar(20), @correoElectronico varchar(20), @numeroTelefono numeric(9,0), @numeroTelefonoAlt numeric(9,0),
@direccionTrabajo varchar(MAX)
)
AS
BEGIN
	update datosEncargado 
	set primerNombre = @PrimerNombre, segundoNombre = @segundoNombre, primerApellido = @PrimerApellido, segundoApellido = @SegundoApellido,
	correoElectronico = @correoElectronico, numeroTelefono = @numeroTelefono, numeroTelefonoAlt = @numeroTelefonoAlt, direccionTrabajo = @direccionTrabajo
	where identidadEncargado = @Numidentidad
END
GO




---------------------------------------------------Estudiante-------------------------------------------------------------------------------------------

--Procedimiento Almacenado para registrar Estudiante
Create procedure RegistrarEstudiante
(
@identidadEstudiante varchar(13),
@primerNombre varchar(20),
@segundoNombre varchar(20),
@primerApellido varchar(20),
@segundoApellido varchar(20),
@fechaNacimiento DATE,
@genero char
)
AS
BEGIN

	if exists(select * from datosEstudiante where identidadEstudiante = @identidadEstudiante)BEGIN
		
		declare @verificarEstado int
		set @verificarEstado = (select estado from datosEstudiante where identidadEstudiante = @identidadEstudiante)
		
		if(@verificarEstado = 2)
		BEGIN
		update datosEstudiante 
		set primerNombre = @PrimerNombre, segundoNombre = @segundoNombre, primerApellido = @PrimerApellido, segundoApellido = @SegundoApellido, 
		fechaNacimiento = @fechaNacimiento, genero = @genero, estado = 1
		where identidadEstudiante = @identidadEstudiante
		END

	END

	ELSE
	BEGIN 
	INSERT INTO datosEstudiante VALUES(@identidadEstudiante, @primerNombre, @segundoNombre, @primerApellido, @segundoApellido, @fechaNacimiento,@genero, 1);
    END

END
GO


--Procedimiento Almacenado para Actualizar Estudiante
Create procedure ActualizarEstudiante
(
@identidadEstudiante varchar(13),
@primerNombre varchar(20),
@segundoNombre varchar(20),
@primerApellido varchar(20),
@segundoApellido varchar(20)
)
AS
BEGIN
	update datosEstudiante 
	set primerNombre = @PrimerNombre, segundoNombre = @segundoNombre, primerApellido = @PrimerApellido, segundoApellido = @SegundoApellido
	where identidadEstudiante = @identidadEstudiante
END
GO

--SamuelOviedo--
-----------------------------------------------------------------------Procedimientos Cursos----------------------------------------------------------------

---------------Actualizar curso-----------------
CREATE PROCEDURE PAActualizarCurso(
@id_Curso int,
@nombreCurso varchar(30),
@precioCompleto money
)

AS
BEGIN

	BEGIN

	UPDATE [dbo].[cursos] SET [nombreCurso] = @nombreCurso WHERE [id_Curso] = @id_Curso
    UPDATE [dbo].[cursos] SET [precioCompleto] = @precioCompleto WHERE [id_Curso] = @id_Curso

	END

END
GO
---------------Registrar curso-----------------
CREATE PROCEDURE PARegistrarCurso (
@nombreCurso varchar(30),
@precioCompleto money,
@estadoCurso int
)

AS
BEGIN

	BEGIN
		IF (EXISTS(SELECT [nombreCurso] from [dbo].[cursos] WHERE [nombreCurso] = @nombreCurso))

			UPDATE [dbo].[cursos] SET [estadoCurso] = @estadoCurso WHERE [nombreCurso] = @nombreCurso

		ELSE

			INSERT INTO [dbo].[cursos] VALUES (@nombreCurso, @precioCompleto, @estadoCurso)
	END

END
GO

/*YESSY TINOCO*/

--------------------------------------------------------- Apertura de Expediente Médico ---------------------------------------------------------------------

CREATE PROCEDURE abrirExpediente(@id_Estudiante varchar(13), @antecedentesMedicos text)
AS BEGIN
		INSERT INTO expedienteMedico( id_Estudiante, fechaCreacion, antecedentesMedicos) 
		VALUES( @id_Estudiante, GETDATE(), @antecedentesMedicos)
END
GO
--------------------------------------------------------- Registro de Visita Médica ---------------------------------------------------------------------

CREATE PROCEDURE registroVisitaMedica(@id_expediente int, @id_DoctorEncargado varchar(13), @sintomas text, @posibleEnfermedad text, @medicamentos text)
AS BEGIN
			INSERT INTO detalleExpedienteMedico(id_expediente, id_DoctorEncargado, fecha, sintomas, posibleEnfermadad, medicamentos) 
			VALUES( @id_expediente, @id_DoctorEncargado, GETDATE(), @sintomas, @posibleEnfermedad, @medicamentos)
END
GO