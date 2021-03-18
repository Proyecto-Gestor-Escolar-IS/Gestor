USE master
GO

DROP DATABASE IF EXISTS StaMariaNazarethDatabaseService
GO

CREATE DATABASE StaMariaNazarethDatabaseService
GO

USE StaMariaNazarethDatabaseService
GO

--Tabla contenedora de los correos de Recuperacion
CREATE TABLE informacionCorreoRecuperacion(
correo nvarchar(300) NOT NULL,
contra nvarchar(300) NOT NULL,
host nvarchar(300) NOT NULL,
puerto int NOT NULL
)

--Tabla contenedora de los estados de un detalleMatricula
CREATE TABLE estados(
id_Estado int identity primary key  not null,
descripcionEstado varchar(15) not null 
)

--Tabla encargada de los datos de los empleados
CREATE TABLE datosEmpleados(
id_Registro int identity not null,
identidadPersona varchar(13) primary key not null,
primerNombre varchar(20) not null,
segundoNombre varchar(20) null,
primerApellido varchar(20) not null,
segundoApellido varchar(20) null,
numeroTelefono numeric(9,0) not null,
fechaNacimiento DATE not null,
correoElectronico varchar(330) null,
estadoEmpleado int NOT NULL,
contraseniaEmpleado varchar(80) not null,
)


--Tabla que contiene los nombres y precios de los cursos
CREATE TABLE cursos(
id_Curso int identity primary key not null,
nombreCurso varchar(30) not null,
precioCompleto money not null,
estadoCurso int not null 
)

--Tabla que contiene la informacion relacionada a las secciones
CREATE TABLE seccion(
id_Seccion int identity primary key not null,
id_Curso int not null,
id_Docente varchar(13) not null,
nombreSeccion char(1) not null,

FOREIGN KEY (id_Curso) REFERENCES cursos(id_Curso),
FOREIGN KEY (id_Docente) REFERENCES datosEmpleados(identidadPersona)
)


--Tabla que contiene las clases que conlleva cada curso
CREATE TABLE clasesCurso(
id_Clase int primary key identity not null,
id_Curso int not null,
nombreClase varchar(25),

FOREIGN KEY (id_Curso) REFERENCES cursos(id_Curso)
)

--Tabla encargada de los datos de los estudiantes
CREATE TABLE datosEstudiante(
id_Registro int identity  not null,
identidadEstudiante varchar(13)primary key not null,
primerNombre varchar(20) not null,
segundoNombre varchar(20) null,
primerApellido varchar(20) not null,
segundoApellido varchar(20) null,
fechaNacimiento DATE not null,
genero char(1) not null,
estado int not null,
)

--Tabla encargada de los datos de los Padres de Familia 
CREATE TABLE datosEncargado(
id_encargadoAlumno int identity  not null,
identidadEncargado varchar(13) primary key not null,
primerNombre varchar(20) not null,
segundoNombre varchar(20) null,
primerApellido varchar(20) not null,
segundoApellido varchar(20) null,
numeroTelefono int not null,
numeroTelefonoAlt int null,
correoElectronico varchar(20) null,
direccionTrabajo varchar(MAX) not null,
fechaNacimiento DATE not null,
estado int not null
)

--Tabla de Detalle Encargado. Sirve cuando un niño tiene mas de un encargado
CREATE TABLE detalleEncargado(
id_encargadoAlumno varchar(13) not null,
id_Estudiante varchar(13) not null,

PRIMARY KEY(id_encargadoAlumno, id_Estudiante),
FOREIGN KEY (id_encargadoAlumno) REFERENCES datosEncargado(identidadEncargado),
FOREIGN KEY (id_Estudiante) REFERENCES datosEstudiante(identidadEstudiante)
)

--Tabla que contiene los diversos cargos que puede tener un empleado
CREATE TABLE cargos(
id_Cargo int identity primary key not null,
descripcionCargo varchar(20)
)

--Tabla de Detalle Cargos. Sirve cuando un empleado tiene mas de un cargo
CREATE TABLE detalleCargos(
identidadEmpleado varchar(13) not null,
idCargoAsociado int not null,

FOREIGN KEY (identidadEmpleado) REFERENCES datosEmpleados(identidadPersona),
FOREIGN KEY (idCargoAsociado) REFERENCES cargos(id_Cargo),
PRIMARY KEY (identidadEmpleado, idCargoAsociado)
)


--Tabla de Matricula, almacena la informacion relacionada a la matricula de un estudiante
CREATE TABLE matricula(
id_RegistroMatricula int identity primary key not null,
fechaMatricula DATE not null,
id_EncargadoAdministracion varchar(13) not null,
id_EncargadoAlumno varchar(13) not null,
id_Estudiante varchar(13) not null,

FOREIGN KEY (id_encargadoAlumno) REFERENCES datosEncargado(identidadEncargado),
FOREIGN KEY (id_Estudiante) REFERENCES datosEstudiante(identidadEstudiante),
FOREIGN KEY (id_EncargadoAdministracion) REFERENCES datosEmpleados(identidadPersona)
)


--Tabla de detalle Matricula, almacena la informacion relacionada a los cursos que lleva un estudiante
CREATE TABLE detalleMatricula(
id_DetalleMatricula int identity primary key not null,
id_RegistroMatricula int not null,
fechaRegistroCurso DATE not null,
id_Curso int not null,
id_Seccion int not null,
totalMatricula money null,
tipoMatricula varchar(15) null,
mesesParaPagar int not null,
estado int not null,

FOREIGN KEY (id_RegistroMatricula) REFERENCES matricula(id_RegistroMatricula),
FOREIGN KEY (id_Curso) REFERENCES cursos(id_Curso),
FOREIGN KEY (id_Seccion) REFERENCES seccion(id_Seccion),

)


--Tabla de detalle de notas, almacena la informacion relacionada a las notas de cada alumno por clase
CREATE TABLE detalleNotas(
id_DetalleNotas int identity primary key not null,
id_DetalleMatricula int not null,
id_Clase int not null,
nota1erParcial numeric(3,2) not null,
nota2doParcial numeric(3,2) not null,
nota3erParcial numeric(3,2) not null,
nota4toParcial numeric(3,2) not null,
notaFinal numeric(3,2) not null,
estado int not null

FOREIGN KEY(id_DetalleMatricula) REFERENCES detalleMatricula(id_DetalleMatricula),
FOREIGN KEY(id_Clase) REFERENCES clasesCurso(id_Clase)
)

--Tabla de detalle de mensualidades, almacena la informacion relacionada a los pagos de un estudiante
CREATE TABLE detalleMensualidades(
id_Mensualidad int identity primary key not null,
id_Estudiante varchar(13) not null,
noFacturaTemporal int not null,
fechaFacturacion DATE not null,
fechaPago DATE null,
deudaPendiente money not null,
saldoDisponible money null,
descuentoMensualidad money not null,
comprobantePago image null,

FOREIGN KEY (id_Estudiante) REFERENCES datosEstudiante(identidadEstudiante)
)

--Tabla de expediente medico, almacena la informacion relacionada al expediente general de un estudiante
CREATE TABLE expedienteMedico(
id_expediente int identity primary key not null,
id_Estudiante varchar(13) not null, 
fechaCreacion date not null,
antecedentesMedicos text not null

FOREIGN KEY (id_Estudiante) REFERENCES datosEstudiante(identidadEstudiante)
)

--Tabla de detalle expediente medico, registra las visitas de un estudiante al medico.
CREATE TABLE detalleExpedienteMedico(
id_detalleExpediente int identity not null,
id_expediente int not null,
id_DoctorEncargado varchar(13) not null,
fecha date not null,
sintomas text not null,
posibleEnfermadad text not null,
medicamentos text not null,

FOREIGN KEY (id_expediente) REFERENCES expedienteMedico(id_expediente),
FOREIGN KEY (id_DoctorEncargado) REFERENCES datosEmpleados(identidadPersona)

)

--SELECT * FROM datosEmpleados INNER JOIN detalleCargos ON datosEmpleados.identidadPersona = detalleCargos.identidadEmpleado
--									   INNER JOIN cargos ON cargos.id_Cargo = detalleCargos.idCargoAsociado WHERE id_Cargo = 4

INSERT INTO estados VALUES('Activo')
INSERT INTO estados VALUES('Inactivo')

INSERT INTO cargos VALUES('Super Usuario')
INSERT INTO cargos VALUES('Administrador')
INSERT INTO cargos VALUES('Docente')
INSERT INTO cargos VALUES('Medico')

--INSERT INTO datosEmpleados VALUES('1010202000034', 'Andres', 'Antonio', 'Ferrera', 'Lopez', 95104555, '06/06/1983', 'antoniof3@gmail.com', 1, '1234');
----INSERT INTO datosEmpleados VALUES('1010202000035', 'Juan', 'Fernando', 'Pineda', 'Gomez', 96124555, '07/06/1990', 'fergomez@gmail.com', 'Activo', '4321');

--INSERT INTO cursos VALUES('Nursery', 3200)

--INSERT INTO seccion VALUES(1, '1010202000034', 'A')

--INSERT INTO datosEstudiante VALUES('1001200200094', 'Oscar', 'Josue', 'Mejia', 'Seren', '12/22/2001', 'M', 1);

--INSERT INTO datosEncargado VALUES('1001200200011', 'Victor', 'Manuel', 'Mejia', 'Alvarado', 95104226, 99779209, 'manuel473@gmail.com', 'Barrio Lempira, CEB Valero Meza','05-04-1973',1);

--INSERT INTO detalleEncargado VALUES('1001200200011', '1001200200094')


--INSERT INTO detalleCargos VALUES('1010202000034', 1)
--INSERT INTO detalleCargos VALUES('1010202000035', 2)

--INSERT INTO matricula VALUES ('02/21/2021', '1010202000035', '1001200200011', '1001200200094')
--INSERT INTO detalleMatricula VALUES (1, '02/21/2021', 1, 1, 300, 3200, 3500, 'Reingreso', 12, 1)


--SELECT concat(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) FROM datosEncargado INNER JOIN detalleEncargado ON detalleEncargado.id_encargadoAlumno = datosEncargado.identidadEncargado WHERE detalleEncargado.id_Estudiante = '1001200200094'


--SELECT identidadEncargado FROM datosEncargado WHERE concat(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) = 'Victor Manuel Mejia Alvarado'
----SELECT id_Registro as 'ID', identidadEstudiante as 'Identidad', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as 'Nombre', fechaNacimiento as 'Fecha de Nacimiento', genero as 'Genero', estado as 'Estado' FROM datosEstudiante WHERE identidadEstudiante LIKE '100%'
----SELECT id_Registro as 'ID', identidadEstudiante as 'Identidad', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as 'Nombre', fechaNacimiento as 'Fecha de Nacimiento', genero as 'Genero', estado as 'Estado' FROM datosEstudiante WHERE CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido)  LIKE 'Os%'
----SELECT * FROM matricula
----SELECT * FROM detalleMatricula
----SELECT nombreSeccion FROM seccion INNER JOIN cursos ON seccion.id_Curso = cursos.id_Curso WHERE cursos.nombreCurso = 'Nursery'
--SELECT CONVERT(VARCHAR(25), MAX(fechaFacturacion)) FROM detalleMensualidades

--SELECT nombreCurso FROM cursos INNER JOIN detalleMatricula ON detalleMatricula.id_Curso = cursos.id_Curso WHERE id_DetalleMatricula = 