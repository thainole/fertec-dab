using pe.com.fertec.bal;
using pe.com.fertec.bo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pe.com.fertec.ui
{
    public partial class categoriaFrm : Form
    {
        private CategoriaBAL bal = new CategoriaBAL();
        private int indice = -1;

        public categoriaFrm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Habilitar(false);
            SoloLectura();
            ConfigurarDGV();
        }

        private void categoriaFrm_Load(object sender, EventArgs e)
        {
            Listar();
            CargarCodigo();
        }

        private void ConfigurarDGV()
        {
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategorias.AutoGenerateColumns = false;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.MultiSelect = false;
            dgvCategorias.ReadOnly = true;
            dgvCategorias.Columns.Clear();
            dgvCategorias.ClearSelection();
            dgvCategorias.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvCategorias.GridColor = System.Drawing.Color.LightGray;
            dgvCategorias.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue;

            dgvCategorias.Columns.Add("codigo", "Código");
            dgvCategorias.Columns["codigo"].DataPropertyName = "codigo";
            dgvCategorias.Columns.Add("nombre", "Nombre");
            dgvCategorias.Columns["nombre"].DataPropertyName = "nombre";

            DataGridViewTextBoxColumn colEstado = new DataGridViewTextBoxColumn
            {
                Name = "estado",
                HeaderText = "Estado",
                DataPropertyName = "estado"
            };
            dgvCategorias.Columns.Add(colEstado);

            dgvCategorias.CellFormatting += (s, e) =>
            {
                if (dgvCategorias.Columns[e.ColumnIndex].Name == "estado" && e.Value != null)
                {
                    e.Value = (bool)e.Value ? "Habilitado" : "Deshabilitado";
                    e.FormattingApplied = true;
                }
            };
        }

        private void Habilitar(bool habilitado)
        {
            txtCodigo.Enabled = habilitado;
            txtNombre.Enabled = habilitado;
            chkEstado.Enabled = habilitado;
            btnRegistrar.Enabled = habilitado;
            btnActualizar.Enabled = habilitado;
            btnEliminar.Enabled = habilitado;
            btnHabilitar.Enabled = habilitado;
        }

        private void SoloLectura()
        {
            txtCodigo.ReadOnly = true;
        }

        private void Listar()
        {
            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = bal.findAll();
        }

        private void CargarCodigo()
        {
            txtCodigo.Text = bal.setCode().ToString();
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            chkEstado.Checked = true;
            CargarCodigo();
            txtNombre.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            Limpiar();
            btnNuevo.Enabled = false;
            indice = -1;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese una descripción.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            CategoriaBO obj = new CategoriaBO
            {
                nombre = txtNombre.Text.Trim(),
                estado = chkEstado.Checked
            };

            if (bal.add(obj))
            {
                MessageBox.Show("Categoría registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listar();
                Limpiar();
                Habilitar(false);
                btnNuevo.Enabled = true;
                indice = -1;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (indice < 0)
            {
                MessageBox.Show("Seleccione un elemento de la lista.", "Actualizar categoría", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvCategorias.Focus();
                return;
            }

            int id = Convert.ToInt32(txtCodigo.Text);
            CategoriaBO obj = new CategoriaBO
            {
                codigo = id,
                nombre = txtNombre.Text.Trim(),
                estado = chkEstado.Checked
            };

            if (bal.update(obj, id))
            {
                MessageBox.Show("Categoría actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listar();
                Limpiar();
                Habilitar(false);
                btnNuevo.Enabled = true;
                indice = -1;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (indice < 0)
            {
                MessageBox.Show("Seleccione un elemento de la lista.", "Inhabilitar categoría", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvCategorias.Focus();
                return;
            }

            int id = Convert.ToInt32(txtCodigo.Text);
            DialogResult resultado = MessageBox.Show("¿Desea inhabilitar la categoría?", "Inhabilitar categoría", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                if (bal.delete(id))
                {
                    MessageBox.Show("Categoría inhabilitada correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listar();
                    Limpiar();
                    Habilitar(false);
                    btnNuevo.Enabled = true;
                    indice = -1;
                }
            }
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            if (indice < 0)
            {
                MessageBox.Show("Seleccione un elemento de la lista.", "Habilitar categoría", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvCategorias.Focus();
                return;
            }

            int id = Convert.ToInt32(txtCodigo.Text);
            if (bal.enable(id))
            {
                MessageBox.Show("Categoría habilitada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listar();
                Limpiar();
                Habilitar(false);
                btnNuevo.Enabled = true;
                indice = -1;
            }
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            if (indice >= 0)
            {
                Habilitar(true);
                btnRegistrar.Enabled = false;
                btnNuevo.Enabled = true;
                DataGridViewRow fila = dgvCategorias.Rows[indice];
                txtCodigo.Text = fila.Cells["codigo"].Value.ToString();
                txtNombre.Text = fila.Cells["nombre"].Value.ToString();
                chkEstado.Checked = Convert.ToBoolean(fila.Cells["estado"].Value);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e) { }
    }
}
