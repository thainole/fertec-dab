using pe.com.fertec.bal;
using pe.com.fertec.bo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pe.com.fertec.ui.categoria
{
    public partial class habilitarCategoria : Form
    {
        private CategoriaBAL bal = new CategoriaBAL();
        private int indice = -1;
        private int idSeleccionado = -1;

        public habilitarCategoria()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            ConfigurarDGV();
            EstadoBotones(false);
        }

        private void habilitarCategoria_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void ConfigurarDGV()
        {
            dgvHabilitarCategoria.AllowUserToAddRows = false;
            dgvHabilitarCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHabilitarCategoria.AutoGenerateColumns = false;
            dgvHabilitarCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHabilitarCategoria.MultiSelect = false;
            dgvHabilitarCategoria.ReadOnly = true;
            dgvHabilitarCategoria.Columns.Clear();
            dgvHabilitarCategoria.ClearSelection();
            dgvHabilitarCategoria.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvHabilitarCategoria.GridColor = Color.LightGray;
            dgvHabilitarCategoria.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            dgvHabilitarCategoria.Columns.Add("codigo", "Código");
            dgvHabilitarCategoria.Columns["codigo"].DataPropertyName = "codigo";

            dgvHabilitarCategoria.Columns.Add("nombre", "Nombre");
            dgvHabilitarCategoria.Columns["nombre"].DataPropertyName = "nombre";

            DataGridViewTextBoxColumn colEstado = new DataGridViewTextBoxColumn
            {
                Name = "estado",
                HeaderText = "Estado",
                DataPropertyName = "estado"
            };
            dgvHabilitarCategoria.Columns.Add(colEstado);

            dgvHabilitarCategoria.CellFormatting += (s, e) =>
            {
                if (dgvHabilitarCategoria.Columns[e.ColumnIndex].Name == "estado" && e.Value != null)
                {
                    e.Value = (bool)e.Value ? "Habilitado" : "Deshabilitado";
                    e.FormattingApplied = true;
                }
            };
        }

        private void Listar()
        {
            dgvHabilitarCategoria.DataSource = null;
            // Carga la lista completa (Habilitados e Inhabilitados)
            dgvHabilitarCategoria.DataSource = bal.findAll();
        }

        private void EstadoBotones(bool seleccionado)
        {
            btnHabilitar.Enabled = seleccionado;
            btnDeshabilitar.Enabled = seleccionado;
        }

        private void dgvHabilitarCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            if (indice >= 0)
            {
                DataGridViewRow fila = dgvHabilitarCategoria.Rows[indice];
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
                MessageBox.Show("Seleccione una categoría de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (bal.enable(idSeleccionado))
            {
                MessageBox.Show("Categoría habilitada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Seleccione una categoría de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult res = MessageBox.Show("¿Desea inhabilitar la categoría seleccionada?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                if (bal.delete(idSeleccionado))
                {
                    MessageBox.Show("Categoría inhabilitada correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listar();
                    indice = -1;
                    idSeleccionado = -1;
                    EstadoBotones(false);
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            categoriaFrm formulario = new categoriaFrm();
            formulario.Show();
            Hide();
        }
    }
}