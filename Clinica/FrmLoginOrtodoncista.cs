using BLL;
using Entidadeds;
using ENTITY;
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
    public partial class FrmLoginOrtodoncista : Form
    {
        ServicioOrtodoncista servOrto = new ServicioOrtodoncista();
        public FrmLoginOrtodoncista()
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
            Ortodoncista ortodoncista = servOrto.IniciarSesion(Cedula, Contraseña);
            if (ortodoncista != null)
            {
                MessageBox.Show("Inicio de sesion exitoso");
                var F = new FrmMedico();
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
            this.Close();
        }
    }
}
