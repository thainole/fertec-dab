using pe.com.fertec.bal;
using pe.com.fertec.bo;
using pe.com.fertec.ui.rol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pe.com.fertec.ui
{
    public partial class rolFrm : Form
    {
        private RolBAL bal = new RolBAL();
        private int indice = -1;

        public rolFrm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Habilitar(false);
            SoloLectura();
            ConfigurarDGV();
        }

        private void rolForm_Load_1(object sender, EventArgs e)
        {
            Listar();
            CargarCodigo();
        }

        private void ConfigurarDGV()
        {
            dgvRol.AllowUserToAddRows = false;
            dgvRol.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvRol.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRol.AutoGenerateColumns = false;
            dgvRol.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRol.MultiSelect = false;
            dgvRol.ReadOnly = true;
            dgvRol.Columns.Clear();
            dgvRol.ClearSelection();
            dgvRol.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvRol.GridColor = System.Drawing.Color.LightGray;
            dgvRol.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue;

            dgvRol.Columns.Add("codigo", "Código");
            dgvRol.Columns["codigo"].DataPropertyName = "codigo";
            dgvRol.Columns.Add("nombre", "Nombre");
            dgvRol.Columns["nombre"].DataPropertyName = "nombre";

            DataGridViewTextBoxColumn colEstado = new DataGridViewTextBoxColumn
            {
                Name = "estado",
                HeaderText = "Estado",
                DataPropertyName = "estado"
            };
            dgvRol.Columns.Add(colEstado);

            dgvRol.CellFormatting += (s, e) =>
            {
                if (dgvRol.Columns[e.ColumnIndex].Name == "estado" && e.Value != null)
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
            //btnEliminar.Enabled = habilitado;
            btnHabilitar.Enabled = habilitado;
        }

        private void SoloLectura()
        {
            txtCodigo.ReadOnly = true;
        }

        private void Listar()
        {
            dgvRol.DataSource = null;
            dgvRol.DataSource = bal.findAll();
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

            RolBO obj = new RolBO()
            {
                nombre = txtNombre.Text.Trim(),
                estado = chkEstado.Checked
            };

            if (bal.add(obj))
            {
                MessageBox.Show("Rol registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Seleccione un elemento de la lista.", "Actualizar rol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvRol.Focus();
                return;
            }

            int id = Convert.ToInt32(txtCodigo.Text);
            RolBO obj = new RolBO()
            {
                codigo = id,
                nombre = txtNombre.Text.Trim(),
                estado = chkEstado.Checked
            };

            if (bal.update(obj, id))
            {
                MessageBox.Show("Rol actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listar();
                Limpiar();
                Habilitar(false);
                btnNuevo.Enabled = true;
                indice = -1;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            /*if (indice < 0)
            {
                MessageBox.Show("Seleccione un elemento de la lista.", "Inhabilitar rol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvRol.Focus();
                return;
            }

            int id = Convert.ToInt32(txtCodigo.Text);
            DialogResult resultado = MessageBox.Show("¿Desea inhabilitar el rol?", "Inhabilitar rol", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                if (bal.delete(id))
                {
                    MessageBox.Show("Rol inhabilitado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listar();
                    Limpiar();
                    Habilitar(false);
                    btnNuevo.Enabled = true;
                    indice = -1;
                }
            }*/
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            habilitarRol formulario = new habilitarRol();
            formulario.ShowDialog();
            Listar();
            /*if (indice < 0)
            {
                MessageBox.Show("Seleccione un elemento de la lista.", "Habilitar rol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvRol.Focus();
                return;
            }

            int id = Convert.ToInt32(txtCodigo.Text);
            if (bal.enable(id))
            {
                MessageBox.Show("Rol habilitado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listar();
                Limpiar();
                Habilitar(false);
                btnNuevo.Enabled = true;
                indice = -1;
            }*/
        }

        private void dgvRol_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            if (indice >= 0)
            {
                Habilitar(true);
                btnRegistrar.Enabled = false;
                btnNuevo.Enabled = true;
                DataGridViewRow fila = dgvRol.Rows[indice];
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
