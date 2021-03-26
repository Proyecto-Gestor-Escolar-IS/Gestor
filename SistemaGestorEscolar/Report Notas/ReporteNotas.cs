using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorEscolar.Report_Notas
{
    public partial class ReporteNotas : Form
    {
        public ReporteNotas()
        {
            InitializeComponent();
        }

        private void ReporteNotas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetNotas.Tabla_Notas' Puede moverla o quitarla según sea necesario.
            this.Tabla_NotasTableAdapter.Fill(this.DataSetNotas.Tabla_Notas);

            this.reportViewer1.RefreshReport();
        }
    }
}
