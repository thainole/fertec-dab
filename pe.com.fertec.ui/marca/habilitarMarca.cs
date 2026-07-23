using pe.com.fertec.bal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pe.com.fertec.ui.marca
{
    public partial class habilitarMarca : Form
    {
        private MarcaBAL bal = new MarcaBAL();
        private int indice = -1;
        private int idSeleccionado = -1;

        public habilitarMarca()
        {
            InitializeComponent();
            ConfigurarDGV();
            EstadoBotones(false);
        }

        private void habilitarMarca_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void ConfigurarDGV()
        {
            dgvHabilitarMarca.AllowUserToAddRows = false;
            dgvHabilitarMarca.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHabilitarMarca.AutoGenerateColumns = false;
            dgvHabilitarMarca.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHabilitarMarca.MultiSelect = false;
            dgvHabilitarMarca.ReadOnly = true;
            dgvHabilitarMarca.Columns.Clear();
            dgvHabilitarMarca.ClearSelection();
            dgvHabilitarMarca.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvHabilitarMarca.GridColor = Color.LightGray;
            dgvHabilitarMarca.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            dgvHabilitarMarca.Columns.Add("codigo", "Código");
            dgvHabilitarMarca.Columns["codigo"].DataPropertyName = "codigo";

            dgvHabilitarMarca.Columns.Add("nombre", "Nombre");
            dgvHabilitarMarca.Columns["nombre"].DataPropertyName = "nombre";

            DataGridViewTextBoxColumn colEstado = new DataGridViewTextBoxColumn
            {
                Name = "estado",
                HeaderText = "Estado",
                DataPropertyName = "estado"
            };
            dgvHabilitarMarca.Columns.Add(colEstado);

            dgvHabilitarMarca.CellFormatting += (s, e) =>
            {
                if (dgvHabilitarMarca.Columns[e.ColumnIndex].Name == "estado" && e.Value != null)
                {
                    e.Value = (bool)e.Value ? "Habilitado" : "Deshabilitado";
                    e.FormattingApplied = true;
                }
            };
        }

        private void Listar()
        {
            dgvHabilitarMarca.DataSource = null;
            // Carga la lista completa (Habilitados e Inhabilitados)
            dgvHabilitarMarca.DataSource = bal.findAll();
        }

        private void EstadoBotones(bool seleccionado)
        {
            btnHabilitar.Enabled = seleccionado;
            btnDeshabilitar.Enabled = seleccionado;
        }

        private void dgvHabilitarMarca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            if (indice >= 0)
            {
                DataGridViewRow fila = dgvHabilitarMarca.Rows[indice];
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
                MessageBox.Show("Seleccione una marca de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (bal.enable(idSeleccionado))
            {
                MessageBox.Show("marca habilitada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Seleccione una marca de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult res = MessageBox.Show("¿Desea inhabilitar la marca seleccionada?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                if (bal.delete(idSeleccionado))
                {
                    MessageBox.Show("Marca inhabilitada correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listar();
                    indice = -1;
                    idSeleccionado = -1;
                    EstadoBotones(false);
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            marcaFrm formulario = new marcaFrm();
            formulario.Show();
            Hide();
        }
    }
}
