using pe.com.fertec.bal;
using pe.com.fertec.bo;
using pe.com.fertec.ui.marca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pe.com.fertec.ui
{
    public partial class marcaFrm : Form
    {
        private MarcaBAL bal = new MarcaBAL();
        private int indice = -1;

        public marcaFrm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Habilitar(false);
            SoloLectura();
            ConfigurarDGV();
        }

        private void marcaFrm_Load(object sender, EventArgs e)
        {
            Listar();
            CargarCodigo();
        }

        private void ConfigurarDGV()
        {
            dgvMarcas.AllowUserToAddRows = false;
            dgvMarcas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvMarcas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMarcas.AutoGenerateColumns = false;
            dgvMarcas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMarcas.MultiSelect = false;
            dgvMarcas.ReadOnly = true;
            dgvMarcas.Columns.Clear();
            dgvMarcas.ClearSelection();
            dgvMarcas.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvMarcas.GridColor = System.Drawing.Color.LightGray;
            dgvMarcas.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue;

            dgvMarcas.Columns.Add("codigo", "Código");
            dgvMarcas.Columns["codigo"].DataPropertyName = "codigo";
            dgvMarcas.Columns.Add("nombre", "Nombre");
            dgvMarcas.Columns["nombre"].DataPropertyName = "nombre";

            DataGridViewTextBoxColumn colEstado = new DataGridViewTextBoxColumn
            {
                Name = "estado",
                HeaderText = "Estado",
                DataPropertyName = "estado"
            };
            dgvMarcas.Columns.Add(colEstado);

            dgvMarcas.CellFormatting += (s, e) =>
            {
                if (dgvMarcas.Columns[e.ColumnIndex].Name == "estado" && e.Value != null)
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
            dgvMarcas.DataSource = null;
            dgvMarcas.DataSource = bal.findAll();
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

            MarcaBO obj = new MarcaBO()
            {
                nombre = txtNombre.Text.Trim(),
                estado = chkEstado.Checked
            };

            if (bal.add(obj))
            {
                MessageBox.Show("Marca registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Seleccione un elemento de la lista.", "Actualizar marca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvMarcas.Focus();
                return;
            }

            int id = Convert.ToInt32(txtCodigo.Text);
            MarcaBO obj = new MarcaBO()
            {
                codigo = id,
                nombre = txtNombre.Text.Trim(),
                estado = chkEstado.Checked
            };

            if (bal.update(obj, id))
            {
                MessageBox.Show("Marca actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listar();
                Limpiar();
                Habilitar(false);
                btnNuevo.Enabled = true;
                indice = -1;
            }
        }

        //private void btnEliminar_Click(object sender, EventArgs e)
        //{
        //    if (indice < 0)
        //    {
        //        MessageBox.Show("Seleccione un elemento de la lista.", "Inhabilitar marca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        dgvMarcas.Focus();
        //        return;
        //    }

        //    int id = Convert.ToInt32(txtCodigo.Text);
        //    DialogResult resultado = MessageBox.Show("¿Desea inhabilitar la marca?", "Inhabilitar marca", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (resultado == DialogResult.Yes)
        //    {
        //        if (bal.delete(id))
        //        {
        //            MessageBox.Show("Marca inhabilitada correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            Listar();
        //            Limpiar();
        //            Habilitar(false);
        //            btnNuevo.Enabled = true;
        //            indice = -1;
        //        }
        //    }
        //}

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            habilitarMarca formulario = new habilitarMarca();
            formulario.ShowDialog();
            Listar();
            //if (indice < 0)
            //{
            //    MessageBox.Show("Seleccione un elemento de la lista.", "Habilitar marca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    dgvMarcas.Focus();
            //    return;
            //}

            //int id = Convert.ToInt32(txtCodigo.Text);
            //if (bal.enable(id))
            //{
            //    MessageBox.Show("Marca habilitada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    Listar();
            //    Limpiar();
            //    Habilitar(false);
            //    btnNuevo.Enabled = true;
            //    indice = -1;
            //}
        }

        private void dgvMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            if (indice >= 0)
            {
                Habilitar(true);
                btnRegistrar.Enabled = false;
                btnNuevo.Enabled = true;
                DataGridViewRow fila = dgvMarcas.Rows[indice];
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
