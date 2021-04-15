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
tipoCalificacion int not null,
estadoCurso int not null 
)

--Tabla que contiene la informacion relacionada a las secciones
CREATE TABLE seccion(
id_Seccion int identity primary key not null,
fechaCreacion datetime not null,
id_Curso int not null,
id_Docente varchar(13) not null,
nombreSeccion char(1) not null,
estado int not null,

FOREIGN KEY (estado) REFERENCES estados(id_Estado),
FOREIGN KEY (id_Curso) REFERENCES cursos(id_Curso),
FOREIGN KEY (id_Docente) REFERENCES datosEmpleados(identidadPersona)
)

CREATE TABLE clases(
id_Clase int primary key identity not null,
nombreClase varchar(25) not null,
estado int not null,

FOREIGN KEY (estado) REFERENCES estados(id_Estado)
)

--Tabla que contiene las clases que conlleva cada curso
CREATE TABLE clasesCurso(
id_DetalleClase int primary key identity not null,
id_Clase int not null,
id_Curso int not null,

FOREIGN KEY (id_Curso) REFERENCES cursos(id_Curso),
FOREIGN KEY (id_Clase) REFERENCES clases(id_Clase)
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
BoletaDeCalificaciones image null,

FOREIGN KEY (id_RegistroMatricula) REFERENCES matricula(id_RegistroMatricula),
FOREIGN KEY (id_Curso) REFERENCES cursos(id_Curso),
FOREIGN KEY (id_Seccion) REFERENCES seccion(id_Seccion),

)

--Tabla de detalle de notas, almacena la informacion relacionada a las notas de cada alumno por clase
Create TABLE detalleNotas(
id_DetalleNotas int identity primary key not null,
id_DetalleMatricula int not null,
id_Clase int not null,
nota1erParcial float null,
nota2doParcial float null,
nota3erParcial float null,
nota4toParcial float null,
notaFinal float null,
notaA char(1) null,
notaB char(1) null,
notaC char(1) null,
notaD char(1) null,
notaE char(1) null,

FOREIGN KEY(id_DetalleMatricula) REFERENCES detalleMatricula(id_DetalleMatricula),
FOREIGN KEY(id_Clase) REFERENCES clasesCurso(id_DetalleClase)
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

/*INSERCIONES DE EJEMPLO*/
INSERT INTO estados VALUES('Activo')
INSERT INTO estados VALUES('Inactivo')

INSERT INTO cargos VALUES('Super Usuario')
INSERT INTO cargos VALUES('Administrador')
INSERT INTO cargos VALUES('Docente')
INSERT INTO cargos VALUES('Medico')


