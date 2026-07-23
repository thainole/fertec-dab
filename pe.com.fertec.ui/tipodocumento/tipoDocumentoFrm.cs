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
    public partial class tipoDocumentoFrm : Form
    {
        private TipoDocumentoBAL bal = new TipoDocumentoBAL();
        private int indice = -1;

        public tipoDocumentoFrm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Habilitar(false);
            SoloLectura();
            ConfigurarDGV();
        }

        private void tipoDocunentoFrm_Load(object sender, EventArgs e)
        {
            Listar();
            CargarCodigo();
        }

        private void ConfigurarDGV()
        {
            dgvTipoDocumento.AllowUserToAddRows = false;
            dgvTipoDocumento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTipoDocumento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTipoDocumento.AutoGenerateColumns = false;
            dgvTipoDocumento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTipoDocumento.MultiSelect = false;
            dgvTipoDocumento.ReadOnly = true;
            dgvTipoDocumento.Columns.Clear();
            dgvTipoDocumento.ClearSelection();
            dgvTipoDocumento.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvTipoDocumento.GridColor = System.Drawing.Color.LightGray;
            dgvTipoDocumento.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue;

            dgvTipoDocumento.Columns.Add("codigo", "Código");
            dgvTipoDocumento.Columns["codigo"].DataPropertyName = "codigo";
            dgvTipoDocumento.Columns.Add("nombre", "Nombre");
            dgvTipoDocumento.Columns["nombre"].DataPropertyName = "nombre";

            DataGridViewTextBoxColumn colEstado = new DataGridViewTextBoxColumn
            {
                Name = "estado",
                HeaderText = "Estado",
                DataPropertyName = "estado"
            };
            dgvTipoDocumento.Columns.Add(colEstado);

            dgvTipoDocumento.CellFormatting += (s, e) =>
            {
                if (dgvTipoDocumento.Columns[e.ColumnIndex].Name == "estado" && e.Value != null)
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
            dgvTipoDocumento.DataSource = null;
            dgvTipoDocumento.DataSource = bal.findAll();
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

            TipoDocumentoBO obj = new TipoDocumentoBO()
            {
                nombre = txtNombre.Text.Trim(),
                estado = chkEstado.Checked
            };

            if (bal.add(obj))
            {
                MessageBox.Show("Tipo de documento registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Seleccione un elemento de la lista.", "Actualizar tipo de documento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvTipoDocumento.Focus();
                return;
            }

            int id = Convert.ToInt32(txtCodigo.Text);
            TipoDocumentoBO obj = new TipoDocumentoBO()
            {
                codigo = id,
                nombre = txtNombre.Text.Trim(),
                estado = chkEstado.Checked
            };

            if (bal.update(obj, id))
            {
                MessageBox.Show("Tipo de documento actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Seleccione un elemento de la lista.", "Inhabilitar tipo de documento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvTipoDocumento.Focus();
                return;
            }

            int id = Convert.ToInt32(txtCodigo.Text);
            DialogResult resultado = MessageBox.Show("¿Desea inhabilitar el tipo de documento?", "Inhabilitar tipo de documento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                if (bal.delete(id))
                {
                    MessageBox.Show("Tipo de documento inhabilitado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Seleccione un elemento de la lista.", "Habilitar tipo de documento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvTipoDocumento.Focus();
                return;
            }

            int id = Convert.ToInt32(txtCodigo.Text);
            if (bal.enable(id))
            {
                MessageBox.Show("Tipo de documento habilitado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listar();
                Limpiar();
                Habilitar(false);
                btnNuevo.Enabled = true;
                indice = -1;
            }
        }

        private void dgvTipoDocumento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            if (indice >= 0)
            {
                Habilitar(true);
                btnRegistrar.Enabled = false;
                btnNuevo.Enabled = true;
                DataGridViewRow fila = dgvTipoDocumento.Rows[indice];
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
