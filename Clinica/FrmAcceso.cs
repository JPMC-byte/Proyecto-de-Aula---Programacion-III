﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class FrmAcceso : Form
    {
        FrmRegistrar frmRegistrar = new FrmRegistrar();
        FrmContraseña frmContraseña = new FrmContraseña();
        public FrmAcceso()
        {
            InitializeComponent();
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            IngresoMedico();
        }

        private void IngresoMedico()
        {
            frmContraseña.Show();
            this.Hide();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            IngresoPaciente();
        }

        private void IngresoPaciente()
        {
            frmRegistrar.Show();
            this.Hide();
        }
    }
}
