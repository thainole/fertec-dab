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

namespace pe.com.fertec.ui.empleado
{
    public partial class frmhabilitarempleado : Form
    {
        // Objetos BAL
        private EmpleadoBAL bal = new EmpleadoBAL();

        private DistritoBAL baldis = new DistritoBAL();

        private RolBAL balrol = new RolBAL();

        private SexoBAL balsex = new SexoBAL();

        private TipoDocumentoBAL baltipd = new TipoDocumentoBAL();

        // Objetos BO
        private EmpleadoBO obj = new EmpleadoBO();

        private DistritoBO objdis = new DistritoBO();

        private RolBO objrol = new RolBO();

        private SexoBO objsex = new SexoBO();

        private TipoDocumentoBO objtipd = new TipoDocumentoBO();

        // Variables
        private int cod = 0;
        private int indice = -1;

        private bool res = false;



        private void CargarEmpleado()
        {
            dgvEmpleado.AllowUserToAddRows = false;

            dgvEmpleado.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvEmpleado.AutoGenerateColumns = false;

            dgvEmpleado.Columns.Clear();

            dgvEmpleado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleado.MultiSelect = false;

            dgvEmpleado.ClearSelection();

            dgvEmpleado.ReadOnly = true;

            // Columnas
            dgvEmpleado.Columns.Add("codigo", "Código");
            dgvEmpleado.Columns.Add("nombre", "Nombre");
            dgvEmpleado.Columns.Add("apellidopaterno", "Apellido Paterno");
            dgvEmpleado.Columns.Add("apellidomaterno", "Apellido Materno");
            dgvEmpleado.Columns.Add("numerodocumento", "N° Documento");
            dgvEmpleado.Columns.Add("fechanacimiento", "Fecha Nacimiento");
            dgvEmpleado.Columns.Add("fechaingreso", "Fecha Ingreso");
            dgvEmpleado.Columns.Add("direccion", "Dirección");
            dgvEmpleado.Columns.Add("telefono", "Teléfono");
            dgvEmpleado.Columns.Add("celular", "Celular");
            dgvEmpleado.Columns.Add("correo", "Correo");
            dgvEmpleado.Columns.Add("usuario", "Usuario");
            dgvEmpleado.Columns.Add("clave", "Clave");
            dgvEmpleado.Columns.Add("sueldo", "Sueldo");
            dgvEmpleado.Columns.Add("distrito", "Distrito");
            dgvEmpleado.Columns.Add("rol", "Rol");
            dgvEmpleado.Columns.Add("sexo", "Sexo");
            dgvEmpleado.Columns.Add("tipodocumento", "Tipo Documento");

            DataGridViewTextBoxColumn colestado =
                new DataGridViewTextBoxColumn
                {
                    Name = "estado",
                    HeaderText = "Estado",
                    DataPropertyName = "estado"
                };

            dgvEmpleado.Columns.Add(colestado);

            List<EmpleadoBO> empleados = bal.findAll();

            for (int i = 0; i < empleados.Count; i++)
            {
                EmpleadoBO empleado = empleados[i];

                dgvEmpleado.Rows.Add();

                dgvEmpleado.Rows[i].Cells["codigo"].Value = empleado.codigo;
                dgvEmpleado.Rows[i].Cells["nombre"].Value = empleado.nombre;
                dgvEmpleado.Rows[i].Cells["apellidopaterno"].Value = empleado.apellidopaterno;
                dgvEmpleado.Rows[i].Cells["apellidomaterno"].Value = empleado.apellidomaterno;
                dgvEmpleado.Rows[i].Cells["numerodocumento"].Value = empleado.numerodocumento;
                dgvEmpleado.Rows[i].Cells["fechanacimiento"].Value = empleado.fechanacimiento;
                dgvEmpleado.Rows[i].Cells["fechaingreso"].Value = empleado.fechaingreso;
                dgvEmpleado.Rows[i].Cells["direccion"].Value = empleado.direccion;
                dgvEmpleado.Rows[i].Cells["telefono"].Value = empleado.telefono;
                dgvEmpleado.Rows[i].Cells["celular"].Value = empleado.celular;
                dgvEmpleado.Rows[i].Cells["correo"].Value = empleado.correo;
                dgvEmpleado.Rows[i].Cells["usuario"].Value = empleado.usuario;
                dgvEmpleado.Rows[i].Cells["clave"].Value = empleado.clave;
                dgvEmpleado.Rows[i].Cells["sueldo"].Value = empleado.sueldo;
                dgvEmpleado.Rows[i].Cells["distrito"].Value = empleado.distrito.nombre;
                dgvEmpleado.Rows[i].Cells["rol"].Value = empleado.rol.nombre;
                dgvEmpleado.Rows[i].Cells["sexo"].Value = empleado.sexo.nombre;
                dgvEmpleado.Rows[i].Cells["tipodocumento"].Value = empleado.tipodocumento.nombre;
                dgvEmpleado.Rows[i].Cells["estado"].Value =
                    empleado.estado ? "Habilitado" : "Deshabilitado";
                // ===== Estilo =====
                dgvEmpleado.EnableHeadersVisualStyles = false;

                dgvEmpleado.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
                dgvEmpleado.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvEmpleado.ColumnHeadersDefaultCellStyle.Font =
                    new Font("Segoe UI", 9, FontStyle.Bold);

                dgvEmpleado.ColumnHeadersHeight = 35;

                dgvEmpleado.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
                dgvEmpleado.DefaultCellStyle.SelectionForeColor = Color.White;

                dgvEmpleado.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

                dgvEmpleado.RowHeadersVisible = false;

                dgvEmpleado.BorderStyle = BorderStyle.FixedSingle;
                dgvEmpleado.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dgvEmpleado.GridColor = Color.LightGray;
            }
        }
        public frmhabilitarempleado()
        {

            InitializeComponent();

            CargarEmpleado();
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            if (indice < 0)
            {
                Util.MensajePersonalizado(
                    "Seleccione un elemento de la lista",
                    "Habilitar Empleado",
                    0,
                    48);

                dgvEmpleado.Focus();
            }
            else
            {
                obj.codigo = cod;

                DialogResult resultado =
                    Util.MensajePersonalizado(
                        "¿Quieres habilitar el empleado?",
                        "Habilitar Empleado",
                        4,
                        16);

                if (resultado == DialogResult.Yes)
                {
                    res = bal.enable(cod);

                    if (res)
                    {
                        Util.MensajePersonalizado(
                            "Se habilitó el empleado",
                            "Habilitar Empleado",
                            0,
                            64);

                        CargarEmpleado();
                    }
                    else
                    {
                        Util.MensajePersonalizado(
                            "No se pudo habilitar el empleado",
                            "Habilitar Empleado",
                            0,
                            16);
                    }
                }
            }
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            if (indice < 0)
            {
                Util.MensajePersonalizado(
                    "Seleccione un elemento de la lista",
                    "Deshabilitar Empleado",
                    0,
                    48);

                dgvEmpleado.Focus();
            }
            else
            {
                obj.codigo = cod;

                DialogResult resultado =
                    Util.MensajePersonalizado(
                        "¿Quieres deshabilitar el empleado?",
                        "Deshabilitar Empleado",
                        4,
                        16);

                if (resultado == DialogResult.Yes)
                {
                    res = bal.delete(cod);

                    if (res)
                    {
                        Util.MensajePersonalizado(
                            "Se deshabilitó el empleado",
                            "Deshabilitar Empleado",
                            0,
                            64);

                        CargarEmpleado();
                    }
                    else
                    {
                        Util.MensajePersonalizado(
                            "No se pudo deshabilitar el empleado",
                            "Deshabilitar Empleado",
                            0,
                            16);
                    }
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmempleado formulario = new frmempleado();

            formulario.Show();

            Hide();
        }

        private void dgvEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;

            if (indice >= 0)
            {
                DataGridViewRow filaseleccionada =
                    dgvEmpleado.Rows[indice];

                cod = Convert.ToInt32(
                    filaseleccionada.Cells["codigo"]
                    .Value.ToString());
            }
        }
    }
}
