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
        public categoriaFrm()
        {
            InitializeComponent();
        }
        private void categoriaFrm_Load(object sender, EventArgs e)
        {
            Listar();
            CargarCodigo();
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
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text)) return;

            int id = Convert.ToInt32(txtCodigo.Text);

            if (bal.enable(id))
            {
                MessageBox.Show("Categoría habilitada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listar();
                Limpiar();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese una descripción.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text)) return;

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
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtCodigo.Text)) return;



            int id = Convert.ToInt32(txtCodigo.Text);



            if (bal.delete(id))

            {

                MessageBox.Show("Categoría inhabilitada correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Listar();

                Limpiar();

            }

        }


        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvCategorias.Rows[e.RowIndex];
                txtCodigo.Text = fila.Cells["codigo"].Value.ToString();
                txtNombre.Text = fila.Cells["nombre"].Value.ToString();
                chkEstado.Checked = Convert.ToBoolean(fila.Cells["estado"].Value);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
