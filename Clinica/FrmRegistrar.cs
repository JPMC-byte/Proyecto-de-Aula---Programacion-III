using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using ENTITY;
using BLL;

namespace Clinica
{
    public partial class FrmRegistrar : Form
    {
        FrmIngreso frmIngreso;
        ServicioPaciente servispaciente = new ServicioPaciente();
        ServicioConsultorio servisconsulto = new ServicioConsultorio();
        public FrmRegistrar()
        {
            InitializeComponent();
            
        }

        private void btnRegistrado_Click(object sender, EventArgs e)
        {
            Registrar();
        }

        private void Registrar()
        {
            this.Hide();
            Paciente paciente = new Paciente();
            paciente.CodigoConsultorio = "P101";
            paciente.Nombre = txtNombre.Text;
            paciente.Apellido = txtApellido.Text;
            paciente.Telefono = txtTelefono.Text;
            paciente.Cedula = txtCedula.Text;
            paciente.Fecha_De_Nacimiento = DTFecha_Nacimiento.Value.Date;
            paciente.Edad = paciente.CalcularEdad(paciente.Fecha_De_Nacimiento);
            paciente.Contraseña = txtContraseña.Text;
            servispaciente.Add(paciente);
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
