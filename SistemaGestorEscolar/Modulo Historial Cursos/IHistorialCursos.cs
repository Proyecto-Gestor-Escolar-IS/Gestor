using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorEscolar.Modulo_Historial_Cursos
{
    public partial class IHistorialCursos : Form
    {
        public IHistorialCursos()
        {
            InitializeComponent();
        }

        databaseConnection dbConn = new databaseConnection();

        private void IHistorialCursos_Load(object sender, EventArgs e)
        {
            dbConn.llenarDGV(dgvHistorialCursos, "select s.[nombreSeccion] as 'Sección', c.[nombreCurso] as 'Curso', de.[identidadEstudiante] as 'ID Alumno', CONCAT(de.[primerNombre], ' ', de.[segundoNombre], ' ', de.[primerApellido], ' ', de.[segundoApellido]) as 'Nombre Estudiante' from[dbo].[seccion]s join[dbo].[cursos]c on s.id_Curso = c.id_Curso join[dbo].[detalleMatricula]dm on c.id_Curso = dm.id_Curso join[dbo].[matricula]m on dm.id_RegistroMatricula = m.id_RegistroMatricula join[dbo].[datosEstudiante]de on m.id_Estudiante = de.identidadEstudiante");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda;
            busqueda = txtBusqueda.Text;

            dbConn.llenarDGV(dgvHistorialCursos, "select s.[nombreSeccion] as 'Sección', c.[nombreCurso] as 'Curso', de.[identidadEstudiante] as 'ID Alumno', CONCAT(de.[primerNombre], ' ', de.[segundoNombre], ' ', de.[primerApellido], ' ', de.[segundoApellido]) as 'Nombre Estudiante' from[dbo].[seccion]s join[dbo].[cursos]c on s.id_Curso = c.id_Curso join[dbo].[detalleMatricula]dm on c.id_Curso = dm.id_Curso join[dbo].[matricula]m on dm.id_RegistroMatricula = m.id_RegistroMatricula join[dbo].[datosEstudiante]de on m.id_Estudiante = de.identidadEstudiante where (de.[identidadEstudiante] like '" + busqueda + "%' or de.[primerNombre] like '" + busqueda + "%')");

            txtBusqueda.Clear();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dbConn.llenarDGV(dgvHistorialCursos, "select s.[nombreSeccion] as 'Sección', c.[nombreCurso] as 'Curso', de.[identidadEstudiante] as 'ID Alumno', CONCAT(de.[primerNombre], ' ', de.[segundoNombre], ' ', de.[primerApellido], ' ', de.[segundoApellido]) as 'Nombre Estudiante' from[dbo].[seccion]s join[dbo].[cursos]c on s.id_Curso = c.id_Curso join[dbo].[detalleMatricula]dm on c.id_Curso = dm.id_Curso join[dbo].[matricula]m on dm.id_RegistroMatricula = m.id_RegistroMatricula join[dbo].[datosEstudiante]de on m.id_Estudiante = de.identidadEstudiante ");
        
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string busqueda;
            busqueda = txtBusqueda.Text;

            dbConn.llenarDGV(dgvHistorialCursos, "select s.[nombreSeccion] as 'Sección', c.[nombreCurso] as 'Curso', de.[identidadEstudiante] as 'ID Alumno', CONCAT(de.[primerNombre], ' ', de.[segundoNombre], ' ', de.[primerApellido], ' ', de.[segundoApellido]) as 'Nombre Estudiante' from[dbo].[seccion]s join[dbo].[cursos]c on s.id_Curso = c.id_Curso join[dbo].[detalleMatricula]dm on c.id_Curso = dm.id_Curso join[dbo].[matricula]m on dm.id_RegistroMatricula = m.id_RegistroMatricula join[dbo].[datosEstudiante]de on m.id_Estudiante = de.identidadEstudiante ");
        }
    }
}
