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
   
    public partial class FrmIngreso : Form
    {
        FrmAcceso frmAcceso = new FrmAcceso();
        public FrmIngreso()
        {
            InitializeComponent();
        }


        private void btnResgistrar_Click(object sender, EventArgs e)
        {
            EntrarAlRegistro();
        }

        private void EntrarAlRegistro()
        {
            frmAcceso.Show();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            Ingreso(); 
        }

        private void Ingreso()
        {
            var F = new FrmInicioSesion();
            F.Show();
            this.Hide();
        }
    }
}
