using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using pe.com.fertec.bo;
using pe.com.fertec.ui.util;

namespace pe.com.fertec.ui
{
    public partial class frmmenuprincipal : Form
    {
        // Empleado que inició sesión
        private EmpleadoBO empleadologin;

        // Reloj
        private void Reloj()
        {
            lblReloj.Text = "Fecha y Hora: " +
                            DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
        public frmmenuprincipal(EmpleadoBO empleado)
        {
            InitializeComponent();

            // Guardamos el empleado que inició sesión
            empleadologin = empleado;

            // Lo dejamos disponible para todo el sistema
            Util.empleadoactual = empleadologin;
        }

        private void tsmiCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = Util.MensajePersonalizado("¿Estas seguro que quieres cerrar sesion ?", "Menu principal", 4, 32);
            if (respuesta == DialogResult.Yes)
            {
                Util.CerrarSesion();
                frmingreso formulario = new frmingreso();
                formulario.Show();
                Close();
            }
        }

        private void tsmiSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = Util.MensajePersonalizado("¿Estas seguro que quieres salir del sistema?", "Menu principal", 4, 32);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Reloj();
        }

        private void frmmenuprincipal_Load(object sender, EventArgs e)
        {
            // Mostrar datos del usuario
            lblCargo.Text = $"Cargo: {empleadologin.rol.nombre}";
            lblUsu.Text = $"Usuario: {empleadologin.usuario}";
            lblEmpleado.Text = $"Empleado: {empleadologin.nombre} {empleadologin.apellidopaterno} {empleadologin.apellidomaterno}";

            // Configurar reloj
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void tsmiCategoria_Click(object sender, EventArgs e)
        {
            Util.AbrirFormulario<categoriaFrm>(this);
        }

        private void tsmiMarca_Click(object sender, EventArgs e)
        {
            Util.AbrirFormulario<marcaFrm>(this);
        }

        private void tsmiRol_Click(object sender, EventArgs e)
        {
            Util.AbrirFormulario<rolFrm>(this);
        }

        private void tsmiDistrito_Click(object sender, EventArgs e)
        {
            Util.AbrirFormulario<distritoFrm>(this);
        }

        private void tsmiSexo_Click(object sender, EventArgs e)
        {
            Util.AbrirFormulario<sexoFrm>(this);
        }

        private void tsmiTipoDocumento_Click(object sender, EventArgs e)
        {
            Util.AbrirFormulario<tipoDocumentoFrm>(this);
        }

        private void tsmiProducto_Click(object sender, EventArgs e)
        {
            Util.AbrirFormulario<productoFrm>(this);
        }

        private void tsmiCliente_Click(object sender, EventArgs e)
        {
            Util.AbrirFormulario<clienteFrm>(this);
        }

        private void tsmiEmpleado_Click(object sender, EventArgs e)
        {
            // Util.AbrirFormulario<tipoDocumentoFrm>(this);
        }

        private void tsmiVenta_Click(object sender, EventArgs e)
        {
            // Util.AbrirFormulario<tipoDocumentoFrm>(this);
        }

        private void tsmiListadoVenta_Click(object sender, EventArgs e)
        {
            // Util.AbrirFormulario<tipoDocumentoFrm>(this);
        }
    }
}
