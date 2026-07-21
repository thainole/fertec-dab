using pe.com.fertec.bal;
using pe.com.fertec.bo;
using pe.com.fertec.ui.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pe.com.fertec.ui
{
    public partial class frmingreso : Form
    {
        private EmpleadoBAL bal = new EmpleadoBAL();

        string usu = "", cla = "";

        List<EmpleadoBO> empleados = new List<EmpleadoBO>();
        public frmingreso()
        {
            InitializeComponent();
            pgbInicio.Visible = false;

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Validar usuario
            if (txtUsu.Text.Trim() == "")
            {
                Util.MensajePersonalizado(
                    "Ingrese el nombre de usuario.",
                    "Ingreso al Sistema",
                    0,
                    48);

                txtUsu.Focus();
            }
            // Validar contraseña
            else if (txtCla.Text.Trim() == "")
            {
                Util.MensajePersonalizado(
                    "Ingrese la contraseña.",
                    "Ingreso al Sistema",
                    0,
                    48);

                txtCla.Focus();
            }
            else
            {
                // Capturar datos
                usu = txtUsu.Text.Trim();
                cla = txtCla.Text.Trim();

                // Validar login
                empleados = bal.login(usu, cla);

                if (empleados != null && empleados.Count == 1)
                {
                    if (empleados[0].estado)
                    {
                        pgbInicio.Value = 0;
                        pgbInicio.Visible = true;
                        timer1.Enabled = true;
                    }
                    else
                    {
                        Util.MensajePersonalizado(
                            "El empleado se encuentra deshabilitado.",
                            "Ingreso al Sistema",
                            0,
                            16);

                        txtUsu.Focus();
                    }
                }
                else
                {
                    Util.MensajePersonalizado(
                        "Usuario o contraseña incorrectos.",
                        "Ingreso al Sistema",
                        0,
                        16);

                    txtUsu.Clear();
                    txtCla.Clear();
                    txtUsu.Focus();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = Util.MensajePersonalizado(
               "¿Está seguro que desea salir del sistema?",
               "Ingreso al Sistema",
               4,
               32);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            pgbInicio.Value += 10;

            if (pgbInicio.Value >= 100)
            {
                timer1.Enabled = false;

                pgbInicio.Refresh();

                await Task.Delay(650);

                Util.MensajePersonalizado(
                    "Bienvenido al Sistema Fertec.",
                    "Ingreso al Sistema",
                    0,
                    48);

                EmpleadoBO empleadologin = empleados[0];

                frmmenuprincipal formulario =
                    new frmmenuprincipal(empleadologin);

                Hide();

                formulario.Show();
            }
        }
    }
}
