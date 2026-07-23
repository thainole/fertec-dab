using pe.com.fertec.bal;
using pe.com.fertec.dal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pe.com.fertec.ui.rol
{
    public partial class habilitarRol : Form
    {
        private RolBAL bal = new RolBAL();
        private int indice = -1;
        private int idSeleccionado = -1;

        public habilitarRol()
        {
            InitializeComponent();
            ConfigurarDGV();
            EstadoBotones(false);
        }

        private void habilitarRol_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void ConfigurarDGV()
        {
            dgvHabilitarRol.AllowUserToAddRows = false;
            dgvHabilitarRol.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHabilitarRol.AutoGenerateColumns = false;
            dgvHabilitarRol.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHabilitarRol.MultiSelect = false;
            dgvHabilitarRol.ReadOnly = true;
            dgvHabilitarRol.Columns.Clear();
            dgvHabilitarRol.ClearSelection();
            dgvHabilitarRol.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvHabilitarRol.GridColor = Color.LightGray;
            dgvHabilitarRol.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            dgvHabilitarRol.Columns.Add("codigo", "Código");
            dgvHabilitarRol.Columns["codigo"].DataPropertyName = "codigo";

            dgvHabilitarRol.Columns.Add("nombre", "Nombre");
            dgvHabilitarRol.Columns["nombre"].DataPropertyName = "nombre";

            DataGridViewTextBoxColumn colEstado = new DataGridViewTextBoxColumn
            {
                Name = "estado",
                HeaderText = "Estado",
                DataPropertyName = "estado"
            };
            dgvHabilitarRol.Columns.Add(colEstado);

            dgvHabilitarRol.CellFormatting += (s, e) =>
            {
                if (dgvHabilitarRol.Columns[e.ColumnIndex].Name == "estado" && e.Value != null)
                {
                    e.Value = (bool)e.Value ? "Habilitado" : "Deshabilitado";
                    e.FormattingApplied = true;
                }
            };
        }

        private void Listar()
        {
            dgvHabilitarRol.DataSource = null;
            // Carga la lista completa (Habilitados e Inhabilitados)
            dgvHabilitarRol.DataSource = bal.findAll();
        }

        private void EstadoBotones(bool seleccionado)
        {
            btnHabilitar.Enabled = seleccionado;
            btnDeshabilitar.Enabled = seleccionado;
        }

        private void dgvHabilitaRol_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            if (indice >= 0)
            {
                DataGridViewRow fila = dgvHabilitarRol.Rows[indice];
                idSeleccionado = Convert.ToInt32(fila.Cells["codigo"].Value);
                EstadoBotones(true);
            }
            else
            {
                idSeleccionado = -1;
                EstadoBotones(false);
            }
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            if (indice < 0 || idSeleccionado <= 0)
            {
                MessageBox.Show("Seleccione un rol de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (bal.enable(idSeleccionado))
            {
                MessageBox.Show("rol habilitada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listar();
                indice = -1;
                idSeleccionado = -1;
                EstadoBotones(false);
            }
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            if (indice < 0 || idSeleccionado <= 0)
            {
                MessageBox.Show("Seleccione una rol de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult res = MessageBox.Show("¿Desea inhabilitar el rol seleccionada?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                if (bal.delete(idSeleccionado))
                {
                    MessageBox.Show("rol inhabilitada correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listar();
                    indice = -1;
                    idSeleccionado = -1;
                    EstadoBotones(false);
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            rolFrm formulario = new rolFrm();
            formulario.Show();
            Hide();
        }
    }
}
