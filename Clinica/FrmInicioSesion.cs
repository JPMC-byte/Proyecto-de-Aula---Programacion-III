using System;
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
    public partial class FrmInicioSesion : Form
    {
        public FrmInicioSesion()
        {
            InitializeComponent();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            InicioPaciente();
        }

        public void InicioPaciente()
        {
            var F = new FrmLogin();
            F.Show();
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            InicioOrtodoncista();
        }

        public void InicioOrtodoncista()
        {
            var F = new FrmLoginOrtodoncista();
            F.Show();
        }
    }
}
