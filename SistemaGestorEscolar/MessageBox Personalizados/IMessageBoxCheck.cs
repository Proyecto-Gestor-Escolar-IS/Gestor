﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorEscolar
{
    public partial class IMessageBoxCheck : Form
    {
        public IMessageBoxCheck()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IMessageBoxCheck_Load(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
        }

        private void panEncabezado_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
