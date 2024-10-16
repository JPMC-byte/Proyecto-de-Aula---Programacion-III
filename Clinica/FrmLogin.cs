using ENTITY;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class FrmLogin : Form
    {
        FrmPaciente frmPaciente = new FrmPaciente();
        ServicioPaciente servispaciente = new ServicioPaciente();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e) 
        {
            Ingreso();
        }

        private void Ingreso()
        {
            string Cedula = txtUsuario.Text;
            string Contraseña = txtContraseña.Text;
            Paciente paciente = servispaciente.IniciarSesion(Cedula,Contraseña);
            if (paciente != null)
            {
                MessageBox.Show("Inicio de sesion exitoso");
                var F = new FrmPaciente();
                F.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error - Cedula y/o contraseña incorrectas");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Borrar(); 
        }

        private void Borrar()
        {
            txtUsuario.Clear();
            txtContraseña.Clear(); 
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void Salir()
        {
            this.Close();
        }
    }
}
