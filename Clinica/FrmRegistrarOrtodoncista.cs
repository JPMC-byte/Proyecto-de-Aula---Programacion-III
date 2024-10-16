using BLL;
using Entidadeds;
using ENTITY;
using Logica;
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
    public partial class FrmRegistrarOrtodoncista : Form
    {
        FrmIngreso frmIngreso;
        ServicioOrtodoncista servispaciente = new ServicioOrtodoncista();
        ServicioConsultorio servisconsulto = new ServicioConsultorio();
        public FrmRegistrarOrtodoncista()
        {
            InitializeComponent();
        }

        private void btnRegistrado_Click(object sender, EventArgs e)
        {
            Registrar();
        }

        public void Registrar()
        {
            this.Hide();
            Ortodoncista ortodoncista = new Ortodoncista();
            ortodoncista.CodigoConsultorio = "P101";
            ortodoncista.Nombre = txtNombre.Text;
            ortodoncista.Apellido = txtApellido.Text;
            ortodoncista.Telefono = txtTelefono.Text;
            ortodoncista.Cedula = txtCedula.Text;
            ortodoncista.Fecha_De_Nacimiento = DTFecha_Nacimiento.Value;
            ortodoncista.Edad = ortodoncista.CalcularEdad(DTFecha_Nacimiento.Value);
            ortodoncista.Contraseña = txtContraseña.Text;
            servispaciente.Add(ortodoncista);
            this.DialogResult = DialogResult.OK;
            Limpiar();
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtApellido.Clear();
            txtCedula.Clear();
            txtContraseña.Clear();
        }
    }
}
