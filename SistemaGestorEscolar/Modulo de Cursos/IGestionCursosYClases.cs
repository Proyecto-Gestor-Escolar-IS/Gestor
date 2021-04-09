using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestorEscolar.Utilidades;

namespace SistemaGestorEscolar.Modulo_de_Cursos
{
    public partial class IGestionCursosYClases : Form
    {
        public IGestionCursosYClases()
        {
            InitializeComponent();
        }

        private databaseConnection dbConn = new databaseConnection();
        clsUtilidades utilidades = new clsUtilidades();
        IMessageBoxCheck message = new IMessageBoxCheck();
        IMessageBoxError messageError = new IMessageBoxError();

        int idClaseAgregarRegistro = 0;
        String nombreClaseRegistro = "";

        int celdaActualTablaGrande = 0;

        int idClaseAgregarRegistroPeque = 0;
        String nombreClaseRegistroPeque = "";

        int celdaActualTablaPeque = 0;

        DataTable existentes = new DataTable();
        DataTable originales = new DataTable();

        String identidadDocente = "";
        String identidadDocenteActualizar = "";
        String nombreDocente = "";

        int idSeccionModificar = 0;
        int idSiguienteClase = 0;

        private void panelGrande_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void btnRegistrarCurso_Click(object sender, EventArgs e)
        {
            hideShowButtons(0);

            panelRegistroNuevoCurso.Visible = true;
            panelRegistroNuevoCurso.Dock = DockStyle.Fill;
            grpActualizarCurso.Visible = false;
            grpRegistroCurso.Visible = true;

            existentes.Rows.Clear();
            originales.Rows.Clear();


            dbConn.llenarDGV(dgvClasesDisponibles, "SELECT id_Clase as ID, nombreClase as 'Nombre de Clase' FROM clases WHERE estado = 1");


            foreach (DataGridViewRow rowG in dgvClasesDisponibles.Rows)
            {
                int idClaseOriginal;
                String nombreOriginal;
                idClaseOriginal = int.Parse(rowG.Cells[0].Value.ToString());
                nombreOriginal = rowG.Cells[1].Value.ToString();

                originales.Rows.Add(idClaseOriginal, nombreOriginal);
            }


        }

        private void hideShowButtons(int code) {

            if (code == 0)
            {
                btnRegistrarCurso.Visible = false;
                btnModificarCurso.Visible = false;
                btnCrearSeccion.Visible = false;
                btnModificarSeccion.Visible = false;
                btnGestionClases.Visible = false;
            }
            else if (code == 1) {
                btnRegistrarCurso.Visible = true;
                btnModificarCurso.Visible = true;
                btnCrearSeccion.Visible = true;
                btnModificarSeccion.Visible = true;
                btnGestionClases.Visible = true;
            }
        
        }

        private void btnModificarSeccion_Click(object sender, EventArgs e)
        {
            hideShowButtons(0);

            panelIngresarCurso.Visible = true;
            panelIngresarCurso.Dock = DockStyle.Fill;

            grpDGVSecciones.Visible = true;
            grpActualizarSeccion.Visible = false;
            grpRegistrarSeccion.Visible = false;
            dbConn.llenarDGV(dgvSecciones, "SELECT A.[id_Seccion] AS 'ID', C.nombreCurso AS 'Curso', A.nombreSeccion as 'Seccion', CONCAT(B.primerNombre, ' ', B.segundoNombre, ' ', B.primerApellido, ' ', B.segundoApellido) AS 'Docente', D.descripcionEstado as 'Estado'  FROM[dbo].[seccion] A INNER JOIN[dbo].[datosEmpleados] B ON A.id_Docente = B.identidadPersona INNER JOIN[dbo].[cursos] C ON A.id_Curso = C.id_Curso INNER JOIN estados D ON A.estado = D.id_Estado ");

            cmbDocentesActualizacion.Items.Clear();
            dbConn.llenarComboBoxValorInicial(cmbDocentesActualizacion, "SELECT CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido)Nombre FROM datosEmpleados INNER JOIN detalleCargos ON datosEmpleados.identidadPersona = detalleCargos.identidadEmpleado INNER JOIN cargos ON cargos.id_Cargo = detalleCargos.idCargoAsociado WHERE id_Cargo = 3");
            cmbDocentesActualizacion.SelectedIndex = 0;

        }

        private void btnCrearSeccion_Click(object sender, EventArgs e)
        {
            hideShowButtons(0);

            panelIngresarCurso.Visible = true;
            panelIngresarCurso.Dock = DockStyle.Fill;

            grpDGVSecciones.Visible = false;
            grpActualizarSeccion.Visible = false;
            grpRegistrarSeccion.Visible = true;

            cmbCursos.Items.Clear();
            dbConn.llenarComboBoxValorInicial(cmbCursos, "SELECT nombreCurso FROM cursos");
            cmbCursos.SelectedIndex = 0;

            cmbDocentes.Items.Clear();
            dbConn.llenarComboBoxValorInicial(cmbDocentes, "SELECT CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido)Nombre FROM datosEmpleados INNER JOIN detalleCargos ON datosEmpleados.identidadPersona = detalleCargos.identidadEmpleado INNER JOIN cargos ON cargos.id_Cargo = detalleCargos.idCargoAsociado WHERE id_Cargo = 3");
            cmbDocentes.SelectedIndex = 0;

        }

        private void btnModificarCurso_Click(object sender, EventArgs e)
        {
            hideShowButtons(0);

            panelRegistroNuevoCurso.Visible = true;
            panelRegistroNuevoCurso.Dock = DockStyle.Fill;
            grpActualizarCurso.Visible = true;
            grpRegistroCurso.Visible = false;
            cmbCursosExistentes.Items.Clear();
            dbConn.llenarComboBoxValorInicial(cmbCursosExistentes, "SELECT nombreCurso FROM cursos");
            cmbCursosExistentes.SelectedIndex = 0;

        }

        private void btnGestionClases_Click(object sender, EventArgs e)
        {
            hideShowButtons(0);

            panelGestionClases.Visible = true;
            panelGestionClases.Dock = DockStyle.Fill;

            dbConn.llenarDGV(dgvClasesRegistradas, "SELECT id_Clase as 'ID', nombreClase as 'Clase', descripcionEstado as 'Estado' FROM clases INNER JOIN estados on clases.estado = estados.id_Estado");

            siguienteClase();

        }

        private void siguienteClase()
        {
            if (dbConn.obtenerVariableString("SELECT MAX(id_Clase) FROM clases") == "")
            {
                idSiguienteClase = 1;
                txtIDNuevaClase.Text = "" + idSiguienteClase;
            }
            else
            {
                idSiguienteClase = (dbConn.obtenerVariableEntera("SELECT MAX(id_Clase) FROM clases") + 1);
                txtIDNuevaClase.Text = "" + idSiguienteClase;
            }

        }

        private void IGestionCursosYClases_Load(object sender, EventArgs e)
        {
            ClsCambioTema.cambiarTemaBoton(panelGestionClases);
            ClsCambioTema.cambiarTemaBoton(grpGestionClases);
            ClsCambioTema.cambiarTemaBoton(groupBox3);
            ClsCambioTema.cambiarTemaBoton(groupBox5);
            ClsCambioTema.cambiarTemaBoton(grpActualizarCurso);
            ClsCambioTema.cambiarTemaBoton(groupBox4);
            ClsCambioTema.cambiarTemaBoton(grpDGVSecciones);
            ClsCambioTema.cambiarTemaBoton(grpActualizarSeccion);
            ClsCambioTema.cambiarTemaBoton(grpRegistroCurso);
            ClsCambioTema.cambiarTemaBoton(groupBox2);
            ClsCambioTema.cambiarTemaBoton(groupBox1);
            ClsCambioTema.cambiarTemaBoton(panelRegistroNuevoCurso);
            ClsCambioTema.cambiarTemaBoton(panelIngresarCurso);
            ClsCambioTema.cambiarTemaBoton(panelGrande);
            ClsCambioTema.cambiarTemaBoton(grpRegistrarSeccion);
            


            if (Properties.Settings.Default.isModoOscuro == true)
            {
                panelRegistroNuevoCurso.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
                panelGestionClases.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
                grpGestionClases.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
                groupBox3.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
                groupBox5.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
                grpActualizarCurso.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
                groupBox4.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
                grpDGVSecciones.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
                grpActualizarSeccion.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
                grpRegistroCurso.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
                groupBox2.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
                groupBox1.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
                panelIngresarCurso.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
                panelGrande.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
                grpRegistrarSeccion.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
                this.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
            }
            else
            {
                panelRegistroNuevoCurso.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
                panelGestionClases.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
                grpGestionClases.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
                groupBox3.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
                groupBox5.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
                grpActualizarCurso.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
                groupBox4.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
                grpDGVSecciones.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
                grpActualizarSeccion.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
                grpRegistroCurso.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
                groupBox2.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
                groupBox1.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
                panelIngresarCurso.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
                panelGrande.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
                grpRegistrarSeccion.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
                this.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
            }

            panelGestionClases.Visible = false;
            panelRegistroNuevoCurso.Visible = false;
            panelIngresarCurso.Visible = false;


            existentes.Columns.Add("ID");
            existentes.Columns.Add("Nombre de la Clase");

            originales.Columns.Add("ID");
            originales.Columns.Add("Nombre de la Clase");

        }

      
        private void btnAtrasActualizar_Click_1(object sender, EventArgs e)
        {
            hideShowButtons(1);
            panelRegistroNuevoCurso.Visible = false;
            cmbCursosExistentes.SelectedIndex = 0;
            txtPrecioCurso.Clear();
        }

        private void altoButton1_Click(object sender, EventArgs e)
        {
            hideShowButtons(1);
            panelRegistroNuevoCurso.Visible = false;
            txtNombreCursoIngresar.Clear();
            txtPrecioMensualAgregar.Clear();
        }

        private void btnAtrasDGVSecciones_Click(object sender, EventArgs e)
        {
            hideShowButtons(1);
            panelIngresarCurso.Visible = false;
            idSeccionModificar = 0;
        }

        private void btnAtrasActualizarSeccion_Click(object sender, EventArgs e)
        {
            grpActualizarSeccion.Visible = false;
            grpRegistrarSeccion.Visible = false;
            grpDGVSecciones.Visible = true;
            idSeccionModificar = 0;
            btnSiguienteDGVSeccion.Enabled = false;
        }

        private void btnAtrasRegistrarSeccion_Click(object sender, EventArgs e)
        {
            hideShowButtons(1);
            panelIngresarCurso.Visible = false;
            mskNombreSeccionRegistrar.Clear();
        }

        private void btnAtrasClases_Click(object sender, EventArgs e)
        {
            hideShowButtons(1);
            panelGestionClases.Visible = false;
            idSeccionModificar = 0;
        }

        private void btnRegistrarCursoNuevo_Click(object sender, EventArgs e)
        {

            int tipoCalificacion = 0;

            if (radioTipoFloat.Checked == true) {
                tipoCalificacion = 1;
            }
            else if (radioTipoChar.Checked == true)
            {
                tipoCalificacion = 2;
            }
            else if (radioSinEvaluacion.Checked == true) {
                tipoCalificacion = 3;
            }

            if (txtNombreCursoIngresar.Text != "")
            {
                if (dbConn.obtenerVariableString("SELECT nombreCurso FROM cursos WHERE nombreCurso = '" + txtNombreCursoIngresar.Text + "'") == null)
                {
                    if (utilidades.isNumeric(txtPrecioMensualAgregar.Text))
                    {

                        if ((radioTipoFloat.Checked == true) || (radioTipoChar.Checked == true) || (radioSinEvaluacion.Checked == true))
                        {

                            if (dgvClasesSelected.RowCount > 0)
                            {
                                if (double.Parse(txtPrecioMensualAgregar.Text) > 0)
                                {

                                    if (dbConn.PAInsertarCurso(txtNombreCursoIngresar.Text, float.Parse(txtPrecioMensualAgregar.Text), tipoCalificacion, 1))
                                    {
                                        int idCursoAgregado;

                                        idCursoAgregado = dbConn.obtenerVariableEntera("SELECT id_Curso FROM cursos WHERE nombreCurso = '" + txtNombreCursoIngresar.Text + "'");


                                        for (int i = 0; i < existentes.Rows.Count; i++)
                                        {
                                            dbConn.PAInsertarDetalleClases(int.Parse(existentes.Rows[i]["ID"].ToString()), idCursoAgregado);
                                        }
                                        message.lblCheck.Text = "CURSO REGISTRADO";
                                        message.ShowDialog();
                                        
                                    }
                                    else
                                    {
                                    messageError.lblError.Text = "ERROR INESPERADO";
                                    messageError.ShowDialog();
                                    }

                                }
                                else 
                                {
                                    messageError.lblError.Text = "EL PRECIO ES INCORRECTO";
                                    messageError.ShowDialog();
                                    txtPrecioMensualAgregar.Clear();
                                }

                                    
                            }
                            else
                            {
                                messageError.lblError.Text = "SELECCIONE AL MENOS 1 CLASE";
                                messageError.ShowDialog();
                            }
                        }
                        else
                        {
                            messageError.lblError.Text = "SELECCIONE UNA EVALUACION";
                            messageError.ShowDialog();

                        }
                    }
                    else
                    {
                        messageError.lblError.Text = "INGRESE UN PRECIO CORRECTO";
                        messageError.ShowDialog();
                        txtPrecioMensualAgregar.Clear();
                    }
                }
                else
                {
                    messageError.lblError.Text = "ESTE CURSO YA EXISTE";
                    messageError.ShowDialog();
                    txtNombreCursoIngresar.Clear();
                }


            }
            else {
                messageError.lblError.Text = "ESCRIBA EL NOMBRE DEL CURSO";
                messageError.ShowDialog();

            }



        }

        private void dgvClasesDisponibles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idClaseAgregarRegistro = int.Parse(dgvClasesDisponibles.Rows[e.RowIndex].Cells[0].Value.ToString());
                nombreClaseRegistro = dgvClasesDisponibles.Rows[e.RowIndex].Cells[1].Value.ToString();
                celdaActualTablaGrande = e.RowIndex;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        private void btnAgregarClase_Click(object sender, EventArgs e)
        {
            if (idClaseAgregarRegistro != 0)
            {
                existentes.Rows.Add(idClaseAgregarRegistro, nombreClaseRegistro);
                dgvClasesSelected.DataSource = existentes;

                originales.Rows.RemoveAt(celdaActualTablaGrande);
                dgvClasesDisponibles.DataSource = originales;

                idClaseAgregarRegistro = 0;
                nombreClaseRegistro = "";
            }
            else
            {
                messageError.lblError.Text = "SELECCIONE UNA CLASE";
                messageError.ShowDialog();

            }

        }

        private void btnEliminarClaseSeleccionada_Click(object sender, EventArgs e)
        {
            if (idClaseAgregarRegistroPeque != 0)
            {
                originales.Rows.Add(idClaseAgregarRegistroPeque, nombreClaseRegistroPeque);
                dgvClasesDisponibles.DataSource = originales;

                existentes.Rows.RemoveAt(celdaActualTablaPeque);
                dgvClasesSelected.DataSource = existentes;

                idClaseAgregarRegistroPeque = 0;
                nombreClaseRegistroPeque = "";
            }
            else
            {
                messageError.lblError.Text = "SELECCIONE UNA CLASE";
                messageError.ShowDialog();
            }
        }

        private void dgvClasesSelected_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                idClaseAgregarRegistroPeque = int.Parse(dgvClasesSelected.Rows[e.RowIndex].Cells[0].Value.ToString());
                nombreClaseRegistroPeque = dgvClasesSelected.Rows[e.RowIndex].Cells[1].Value.ToString();
                celdaActualTablaPeque = e.RowIndex;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void cmbCursosExistentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbCursosExistentes.SelectedIndex != 0)
            {
                int idCurso, idClaseExistente, idClaseoriginal, IdEvaluacion;
                float precioCurso;
                String nombreClaseExistente, idNombreoriginal, formaEvaluacion;

                originales.Rows.Clear();
                existentes.Rows.Clear();

                idCurso = dbConn.obtenerVariableEntera("SELECT id_Curso FROM cursos WHERE nombreCurso = '" + cmbCursosExistentes.SelectedItem.ToString() + "'");
                dbConn.llenarDGV(dgvClasesDisponiblesActualizar, "SELECT id_Clase as ID, nombreClase as 'Nombre de Clase' FROM clases WHERE estado = 1");
         
                dbConn.llenarDGV(dgvClasesExistentesActualizar, "SELECT clases.id_Clase as ID, clases.nombreClase as 'Nombre de Clase' FROM clases INNER JOIN clasesCurso ON clasesCurso.id_Clase = clases.id_Clase INNER JOIN cursos ON clasesCurso.id_Curso = cursos.id_Curso WHERE cursos.id_Curso = " + idCurso +  " AND clases.estado = 1");
                
                foreach (DataGridViewRow row in dgvClasesExistentesActualizar.Rows)
                {
                   idClaseExistente = int.Parse(row.Cells[0].Value.ToString());
                   nombreClaseExistente = row.Cells[1].Value.ToString();
                   existentes.Rows.Add(idClaseExistente, nombreClaseExistente);
                   
                    foreach (DataGridViewRow rowG in dgvClasesDisponiblesActualizar.Rows)
                    {
                        if (int.Parse(rowG.Cells[0].Value.ToString()) == idClaseExistente)
                        {
                            dgvClasesDisponiblesActualizar.Rows.RemoveAt(rowG.Index);
                        }
                    }
    
                }

                foreach (DataGridViewRow rowG in dgvClasesDisponiblesActualizar.Rows)
                {
                    idClaseoriginal = int.Parse(rowG.Cells[0].Value.ToString());
                    idNombreoriginal = rowG.Cells[1].Value.ToString();
                    originales.Rows.Add(idClaseoriginal, idNombreoriginal);
                }

                dgvClasesDisponiblesActualizar.DataSource = originales;
                dgvClasesExistentesActualizar.DataSource = existentes;


                dbConn.llenarTextBox(txtPrecioCurso, "SELECT precioCompleto FROM cursos where id_Curso = " + idCurso);
                IdEvaluacion = dbConn.obtenerVariableEntera("SELECT [tipoCalificacion] FROM [dbo].[cursos] WHERE [id_Curso] = " + idCurso);
                if (IdEvaluacion == 1)
                {
                    formaEvaluacion = "Numérica";
                }else if(IdEvaluacion == 2)
                {
                    formaEvaluacion = "Letras";
                }
                else
                {
                    formaEvaluacion = "Sin Evaluación";
                }
                LblFormaEva.Text = formaEvaluacion;
            }
            else
            {
                dgvClasesDisponiblesActualizar.DataSource = "";
                dgvClasesExistentesActualizar.DataSource = "";
                txtPrecioCurso.Text = "";

            }

        }

        private void btnAgregarClaseActualizar_Click(object sender, EventArgs e)
        {
            if (idClaseAgregarRegistro != 0)
            {
                existentes.Rows.Add(idClaseAgregarRegistro, nombreClaseRegistro);
                dgvClasesDisponiblesActualizar.DataSource = existentes;

                originales.Rows.RemoveAt(celdaActualTablaGrande);
                dgvClasesDisponiblesActualizar.DataSource = originales;


                idClaseAgregarRegistro = 0;
                nombreClaseRegistro = "";
            }
            else
            {
                messageError.lblError.Text = "SELECCIONE UNA CLASE";
                messageError.ShowDialog();

            }
        }

        private void btnEliminarClaseActualizar_Click(object sender, EventArgs e)
        {
            if (idClaseAgregarRegistroPeque != 0)
            {
                originales.Rows.Add(idClaseAgregarRegistroPeque, nombreClaseRegistroPeque);
                dgvClasesDisponiblesActualizar.DataSource = originales;
                
                existentes.Rows.RemoveAt(celdaActualTablaPeque);
                dgvClasesExistentesActualizar.DataSource = existentes;

                idClaseAgregarRegistroPeque = 0;
                nombreClaseRegistroPeque = "";
            }
            else
            {
                messageError.lblError.Text = "SELECCIONE UNA CLASE";
                messageError.ShowDialog();
            }
        }
        private void dgvClasesDisponiblesActualizar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex != -1)
                {
                    idClaseAgregarRegistro = int.Parse(dgvClasesDisponiblesActualizar.Rows[e.RowIndex].Cells[0].Value.ToString());
                    nombreClaseRegistro = dgvClasesDisponiblesActualizar.Rows[e.RowIndex].Cells[1].Value.ToString();
                    celdaActualTablaGrande = e.RowIndex;
    
                }   

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void dgvClasesExistentesActualizar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    idClaseAgregarRegistroPeque = int.Parse(dgvClasesExistentesActualizar.Rows[e.RowIndex].Cells[0].Value.ToString());
                nombreClaseRegistroPeque = dgvClasesExistentesActualizar.Rows[e.RowIndex].Cells[1].Value.ToString();
                celdaActualTablaPeque = e.RowIndex;
                }   

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnActualizarCurso_Click(object sender, EventArgs e)
        {

            int codigoCurso;

            codigoCurso = dbConn.obtenerVariableEntera("SELECT id_Curso FROM cursos WHERE nombreCurso = '" + cmbCursosExistentes.SelectedItem.ToString() + "'");

            if (cmbCursosExistentes.SelectedIndex != 0)
            {
                if (txtNombreCursoIngresar.Text != "")
                {
                    if (txtPrecioCurso.Text != "")
                    {
                        if (utilidades.isNumeric(txtPrecioCurso.Text))
                        {
                            if (double.Parse(txtPrecioCurso.Text) > 0)
                            {
                                if (existentes.Rows.Count != 0)
                                {
                                    if (dbConn.PAActualizarCurso(codigoCurso, float.Parse(txtPrecioCurso.Text)))
                                    {

                                      dbConn.PAEliminarDetallesClases(codigoCurso);
                                      for (int i = 0; i < existentes.Rows.Count; i++)
                                      {
                                          dbConn.PAInsertarDetalleClases(int.Parse(existentes.Rows[i]["ID"].ToString()), codigoCurso);
                                      }

                                      message.lblCheck.Text = "CURSO ACTUALIZADO";
                                      message.ShowDialog();
                                      
                                      }
                                      else
                                      {
                                      messageError.lblError.Text = "ERROR INESPERADO";
                                      messageError.ShowDialog();
                                      }

                                    }
                                    else
                                    {
                                        messageError.lblError.Text = "DEBE SELECCIONAR UNA CLASE";
                                        messageError.ShowDialog();
                                    }

                                }
                                else
                                {
                                    messageError.lblError.Text = "EL PRECIO ES INCORRECTO";
                                    messageError.ShowDialog();
                                    txtPrecioCurso.Clear();
                                }
                        


                            }
                            else
                            {
                                messageError.lblError.Text = "EL PRECIO ES INCORRECTO";
                                messageError.ShowDialog();

                            }
                        }
                        else
                        {
                            messageError.lblError.Text = "ESPECIFIQUE UN PRECIO";
                            messageError.ShowDialog();
                        }
                }
                else
                {

                }
                
            }
            else {
                messageError.lblError.Text = "SELECCIONE UN CURSO";
                messageError.ShowDialog();
            }
        }

        private void btnRegistrarSecc_Click(object sender, EventArgs e)
        {


            int idCursoActualizacionSeccion;
            idCursoActualizacionSeccion = dbConn.obtenerVariableEntera("SELECT id_Curso FROM cursos WHERE nombreCurso = '" + cmbCursos.SelectedItem.ToString() + "'");


            if(cmbCursos.SelectedIndex != 0)
            {
                if(cmbDocentes.SelectedIndex != 0)
                {
                    if(mskNombreSeccionRegistrar.MaskCompleted == true)
                    {
                        if(dbConn.obtenerVariableString("SELECT id_Seccion from seccion WHERE id_Curso = " + idCursoActualizacionSeccion + " AND nombreSeccion = '" + mskNombreSeccionRegistrar.Text + "'") == null)
                        {
                            if (dbConn.PARegistrarSeccion(idCursoActualizacionSeccion, identidadDocente, char.Parse(mskNombreSeccionRegistrar.Text)))
                            {
                                message.lblCheck.Text = "SECCION REGISTRADA";
                                message.ShowDialog();
                            }
                            else
                            {
                                messageError.lblError.Text = "ERROR INESPERADO";
                                messageError.ShowDialog();
                            }

                        }
                        else
                        {
                            messageError.lblError.Text = "LA SECCION YA EXISTE";
                            messageError.ShowDialog();
                            mskNombreSeccionRegistrar.ResetText();
                        }
                    }
                    else
                    {
                        messageError.lblError.Text = "ESCRIBA EL NOMBRE DE SECCION";
                        messageError.ShowDialog();
                    }

                }
                else
                {
                    messageError.lblError.Text = "SELECCIONE UN DOCENTE";
                    messageError.ShowDialog();
                }

            }
            else {
                messageError.lblError.Text = "SELECCIONE UN CURSO";
                messageError.ShowDialog();
            }
        }

        private void cmbDocentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDocentes.SelectedIndex != 0) {
                identidadDocente = dbConn.obtenerVariableString("SELECT identidadPersona FROM datosEmpleados WHERE CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) = '" + cmbDocentes.SelectedItem.ToString() + "'");
            }
            else
            {
                identidadDocente = "";

            }
        }
        private void dgvSecciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex != -1)
                {
                    idSeccionModificar = int.Parse(dgvSecciones.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
                if (idSeccionModificar != 0)
                {
                    btnSiguienteDGVSeccion.Enabled = true;
                }
                else
                {
                    btnSiguienteDGVSeccion.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void mskNombreSeccionRegistrar_TextChanged(object sender, EventArgs e)
        {
            mskNombreSeccionRegistrar.Text = mskNombreSeccionRegistrar.Text.ToUpper();
        }

        private void btnSiguienteDGVSeccion_Click(object sender, EventArgs e)
        {

            int estadoSeccion;
            
            grpDGVSecciones.Visible = false;
            grpActualizarSeccion.Visible = true;
            grpRegistrarSeccion.Visible = false;

            dbConn.llenarTextBox(txtCursos, "SELECT C.nombreCurso FROM [dbo].[seccion] A INNER JOIN[dbo].[cursos] C ON A.id_Curso = C.id_Curso WHERE A.id_Seccion = " + idSeccionModificar);
            nombreDocente = dbConn.obtenerVariableString("SELECT CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) FROM [dbo].[seccion] A INNER JOIN datosEmpleados B ON A.id_Docente = B.identidadPersona WHERE A.id_Seccion = " + idSeccionModificar);
            cmbDocentesActualizacion.SelectedItem = nombreDocente;
            dbConn.llenarTextBox(txtNombreSeccion, "SELECT A.nombreSeccion FROM [dbo].[seccion] A WHERE A.id_Seccion = " + idSeccionModificar);
            estadoSeccion = dbConn.obtenerVariableEntera("SELECT A.estado FROM [dbo].[seccion] A WHERE A.id_Seccion = " + idSeccionModificar);
            switch (estadoSeccion)
            {
                case 1: cmbEstadoSeccion.SelectedIndex = 0;
                    break;
                case 2: cmbEstadoSeccion.SelectedIndex = 1;
                    break;
            }
        }

        private void btnActualizarSeccion_Click(object sender, EventArgs e)
        {

            int estado;
            if(cmbEstadoSeccion.SelectedIndex == 0)
            {
                estado = 1;
            }
            else
            {
                estado = 2;
            }

            if (estado == 1 && !cmbDocentesActualizacion.SelectedItem.Equals(nombreDocente))
            {

                if(cmbDocentesActualizacion.SelectedIndex != 0)
                {

                    if (dbConn.PAActualizarSeccion(idSeccionModificar, identidadDocenteActualizar, estado)) 
                    {
                        message.lblCheck.Text = "SECCION ACTUALIZADA";
                        message.ShowDialog();
                        dbConn.llenarDGV(dgvSecciones, "SELECT A.[id_Seccion] AS 'ID', C.nombreCurso AS 'Curso', A.nombreSeccion as 'Seccion', CONCAT(B.primerNombre, ' ', B.segundoNombre, ' ', B.primerApellido, ' ', B.segundoApellido) AS 'Docente', D.descripcionEstado as 'Estado'  FROM[dbo].[seccion] A INNER JOIN[dbo].[datosEmpleados] B ON A.id_Docente = B.identidadPersona INNER JOIN[dbo].[cursos] C ON A.id_Curso = C.id_Curso INNER JOIN estados D ON A.estado = D.id_Estado ");

                    }
                    else
                    {
                        messageError.lblError.Text = "ERROR INESPERADO";
                        messageError.ShowDialog();
                    }
                }
                else
                {
                messageError.lblError.Text = "SELECCIONE UN DOCENTE";
                messageError.ShowDialog();
                }

            }
            else
            {
                messageError.lblError.Text = "CAMBIE EL ESTADO A ACTIVO";
                messageError.ShowDialog();
            }
            
        }

        private void cmbDocentesActualizacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDocentesActualizacion.SelectedIndex != 0)
            {
                identidadDocenteActualizar = dbConn.obtenerVariableString("SELECT identidadPersona FROM datosEmpleados WHERE CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) = '" + cmbDocentesActualizacion.SelectedItem.ToString() + "'");
            }
            else
            {
                identidadDocenteActualizar = "";

            }
        }

        private void dgvClasesRegistradas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex != -1)
                {
                    txtIDClaseSelected.Text = "" + int.Parse(dgvClasesRegistradas.Rows[e.RowIndex].Cells[0].Value.ToString());
                    txtNombreClaseSelected.Text = "" + dgvClasesRegistradas.Rows[e.RowIndex].Cells[1].Value.ToString();
                }   

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            if(txtIDClaseSelected.Text != "" && txtNombreClaseSelected.Text != "")
            {
                if(dbConn.PAActualizarClase(int.Parse(txtIDClaseSelected.Text), 1))
                {
                    message.lblCheck.Text = "CLASE HABILITADA";
                    message.ShowDialog();
                    dbConn.llenarDGV(dgvClasesRegistradas, "SELECT id_Clase as 'ID', nombreClase as 'Clase', descripcionEstado as 'Estado' FROM clases INNER JOIN estados on clases.estado = estados.id_Estado");


                }
                else
                {
                    messageError.lblError.Text = "ERROR INESPERADO";
                    messageError.ShowDialog();
                }
            }
            else
            {
                messageError.lblError.Text = "SELECCIONE UNA CLASE";
                messageError.ShowDialog();
            }
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            if (txtIDClaseSelected.Text != "" && txtNombreClaseSelected.Text != "")
            {
                if (dbConn.PAActualizarClase(int.Parse(txtIDClaseSelected.Text), 2))
                {
                    message.lblCheck.Text = "CLASE INHABILITADA";
                    message.ShowDialog();
                    dbConn.llenarDGV(dgvClasesRegistradas, "SELECT id_Clase as 'ID', nombreClase as 'Clase', descripcionEstado as 'Estado' FROM clases INNER JOIN estados on clases.estado = estados.id_Estado");


                }
                else
                {
                    messageError.lblError.Text = "ERROR INESPERADO";
                    messageError.ShowDialog();
                }
            }
            else
            {
                messageError.lblError.Text = "SELECCIONE UNA CLASE";
                messageError.ShowDialog();
            }
        }

        private void btnAgregarNuevaClase_Click(object sender, EventArgs e)
        {
            if(txtNombreClase.Text != "")
            {
                if (dbConn.PARegistrarClase(txtNombreClase.Text))
                {
                    message.lblCheck.Text = "CLASE AGREGADA";
                    txtNombreClase.Clear();
                    message.ShowDialog();
                    dbConn.llenarDGV(dgvClasesRegistradas, "SELECT id_Clase as 'ID', nombreClase as 'Clase', descripcionEstado as 'Estado' FROM clases INNER JOIN estados on clases.estado = estados.id_Estado");
                    siguienteClase();
                }
                else
                {
                    messageError.lblError.Text = "ERROR INESPERADO";
                    messageError.ShowDialog();
                }

            }
            else
            {
                messageError.lblError.Text = "ESCRIBA EL NOMBRE DE LA CLASE";
                messageError.ShowDialog();
            }

        }

        private void btnLimpiarClaseModi_Click(object sender, EventArgs e)
        {
            txtNombreClaseSelected.Clear();
            txtIDClaseSelected.Clear();
        }

        private void btnLimpiarNombreClase_Click(object sender, EventArgs e)
        {
            txtNombreClase.Clear();
        }

        private void btnLimpiarPrecioCurso_Click(object sender, EventArgs e)
        {
            txtPrecioCurso.Clear();
        }

        private void btnLimpiarRegistroCurso_Click(object sender, EventArgs e)
        {
            txtNombreCursoIngresar.Clear();
            txtPrecioMensualAgregar.Clear();
            radioTipoFloat.Checked = false;
            radioTipoChar.Checked = false;
            radioSinEvaluacion.Checked = false;

        }

        private void btnLimpiarRegistroSecc_Click(object sender, EventArgs e)
        {
            mskNombreSeccionRegistrar.ResetText();
            cmbCursos.SelectedIndex = 0;
            cmbDocentes.SelectedIndex = 0;
        }

    }
}
