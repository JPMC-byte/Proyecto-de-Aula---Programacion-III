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
    public partial class FrmContraseña : Form
    {
        FrmRegistrarOrtodoncista frmRegistrarOrtodoncista = new FrmRegistrarOrtodoncista();
        public FrmContraseña()
        {
            InitializeComponent();
        }

        private void EntrarSistema_Click(object sender, EventArgs e)
        {
            if (txtContraseñasistema.Text == "sistema123")
            {
                frmRegistrarOrtodoncista.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Contraseña Invalida");
                txtContraseñasistema.Clear();
            }
        }
    }
}
