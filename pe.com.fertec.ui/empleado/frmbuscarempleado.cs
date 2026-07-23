using pe.com.fertec.bal;
using pe.com.fertec.bo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pe.com.fertec.ui.empleado
{
    public partial class frmbuscarempleado : Form
    {
        // Instancia de la capa de negocio
        private EmpleadoBAL bal = new EmpleadoBAL();

        // Objeto de negocio
        private EmpleadoBO obj = new EmpleadoBO();

        // Lista de empleados
        List<EmpleadoBO> listaempleado = new List<EmpleadoBO>();

        private void CargarEmpleado()
        {
            listaempleado = bal.findAll();

        }
        public frmbuscarempleado()
        {
            InitializeComponent();

            ConfigurarGrid();
            CargarEmpleado();
            LlenarGrid(listaempleado);
        }
        private void ConfigurarGrid()
        {
            dgvEmpleado.AllowUserToAddRows = false;
            dgvEmpleado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmpleado.AutoGenerateColumns = false;
            dgvEmpleado.Columns.Clear();

            dgvEmpleado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleado.MultiSelect = false;
            dgvEmpleado.ClearSelection();

            dgvEmpleado.ReadOnly = true;

            // ===== Estilo =====
            dgvEmpleado.EnableHeadersVisualStyles = false;

            dgvEmpleado.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvEmpleado.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvEmpleado.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);

            dgvEmpleado.ColumnHeadersHeight = 35;
            dgvEmpleado.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvEmpleado.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            dgvEmpleado.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvEmpleado.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            dgvEmpleado.RowHeadersVisible = false;

            dgvEmpleado.BorderStyle = BorderStyle.FixedSingle;
            dgvEmpleado.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEmpleado.GridColor = Color.LightGray;

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

            DataGridViewTextBoxColumn colestado = new DataGridViewTextBoxColumn
            {
                Name = "estado",
                HeaderText = "Estado"
            };

            dgvEmpleado.Columns.Add(colestado);
        }

        private void LlenarGrid(List<EmpleadoBO> empleados)
        {
            dgvEmpleado.Rows.Clear();

            foreach (EmpleadoBO empleado in empleados)
            {
                dgvEmpleado.Rows.Add(
                    empleado.codigo,
                    empleado.nombre,
                    empleado.apellidopaterno,
                    empleado.apellidomaterno,
                    empleado.numerodocumento,
                    empleado.fechanacimiento,
                    empleado.fechaingreso,
                    empleado.direccion,
                    empleado.telefono,
                    empleado.celular,
                    empleado.correo,
                    empleado.usuario,
                    empleado.clave,
                    empleado.sueldo,
                    empleado.distrito.nombre,
                    empleado.rol.nombre,
                    empleado.sexo.nombre,
                    empleado.tipodocumento.nombre,
                    empleado.estado ? "Habilitado" : "Deshabilitado"
                );
            }

            dgvEmpleado.ClearSelection();
            dgvEmpleado.CurrentCell = null;
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            string valor = txtValor.Text.Trim().ToLower();

            var resultado = listaempleado.Where(
                e1 => e1.codigo.ToString().Contains(valor) ||
                      e1.nombre.ToLower().Contains(valor) ||
                      e1.apellidopaterno.ToLower().Contains(valor) ||
                      e1.apellidomaterno.ToLower().Contains(valor) ||
                      e1.numerodocumento.Contains(valor) ||
                      e1.distrito.nombre.ToLower().Contains(valor) 
                      
            ).ToList();

            LlenarGrid(resultado);
        }
    }
}
