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
    public partial class sexoFrm : Form
    {
        private SexoBAL bal = new SexoBAL();
        private int indice = -1;

        public sexoFrm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Habilitar(false);
            SoloLectura();
            ConfigurarDGV();
        }

        private void sexoFrm_Load(object sender, EventArgs e)
        {
            Listar();
            CargarCodigo();
        }

        private void ConfigurarDGV()
        {
            dgvSexo.AllowUserToAddRows = false;
            dgvSexo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSexo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSexo.AutoGenerateColumns = false;
            dgvSexo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSexo.MultiSelect = false;
            dgvSexo.ReadOnly = true;
            dgvSexo.Columns.Clear();
            dgvSexo.ClearSelection();
            dgvSexo.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvSexo.GridColor = System.Drawing.Color.LightGray;
            dgvSexo.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue;

            dgvSexo.Columns.Add("codigo", "Código");
            dgvSexo.Columns["codigo"].DataPropertyName = "codigo";
            dgvSexo.Columns.Add("nombre", "Nombre");
            dgvSexo.Columns["nombre"].DataPropertyName = "nombre";

            DataGridViewTextBoxColumn colEstado = new DataGridViewTextBoxColumn
            {
                Name = "estado",
                HeaderText = "Estado",
                DataPropertyName = "estado"
            };
            dgvSexo.Columns.Add(colEstado);

            dgvSexo.CellFormatting += (s, e) =>
            {
                if (dgvSexo.Columns[e.ColumnIndex].Name == "estado" && e.Value != null)
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
            dgvSexo.DataSource = null;
            dgvSexo.DataSource = bal.findAll();
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

            SexoBO obj = new SexoBO()
            {
                nombre = txtNombre.Text.Trim(),
                estado = chkEstado.Checked
            };

            if (bal.add(obj))
            {
                MessageBox.Show("Sexo registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Seleccione un elemento de la lista.", "Actualizar sexo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvSexo.Focus();
                return;
            }

            int id = Convert.ToInt32(txtCodigo.Text);
            SexoBO obj = new SexoBO()
            {
                codigo = id,
                nombre = txtNombre.Text.Trim(),
                estado = chkEstado.Checked
            };

            if (bal.update(obj, id))
            {
                MessageBox.Show("Sexo actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Seleccione un elemento de la lista.", "Inhabilitar sexo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvSexo.Focus();
                return;
            }

            int id = Convert.ToInt32(txtCodigo.Text);
            DialogResult resultado = MessageBox.Show("¿Desea inhabilitar el sexo?", "Inhabilitar sexo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                if (bal.delete(id))
                {
                    MessageBox.Show("Sexo inhabilitado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Seleccione un elemento de la lista.", "Habilitar sexo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvSexo.Focus();
                return;
            }

            int id = Convert.ToInt32(txtCodigo.Text);
            if (bal.enable(id))
            {
                MessageBox.Show("Sexo habilitado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listar();
                Limpiar();
                Habilitar(false);
                btnNuevo.Enabled = true;
                indice = -1;
            }
        }

        private void dgvSexo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            if (indice >= 0)
            {
                Habilitar(true);
                btnRegistrar.Enabled = false;
                btnNuevo.Enabled = true;
                DataGridViewRow fila = dgvSexo.Rows[indice];
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
