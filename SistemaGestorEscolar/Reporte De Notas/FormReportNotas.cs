using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorEscolar.Reporte_De_Notas
{
    public partial class FormReportNotas : Form
    {
        public FormReportNotas()
        {
            InitializeComponent();
        }

        private void FormReportNotas_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
