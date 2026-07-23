using pe.com.fertec.bal;
using pe.com.fertec.bo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pe.com.fertec.ui.sexo
{
    public partial class frmbuscarsexo : Form
    {
        // Instancia de la capa de negocio
        private SexoBAL bal = new SexoBAL();

        // Objeto de negocio de apoyo
        private SexoBO obj = new SexoBO();

        // Lista de sexos
        List<SexoBO> listasexo = new List<SexoBO>();

        private void CargarSexo()
        {
            listasexo = bal.findAll();
        }

        private void ConfigurarGrid()
        {
            dgvSexo.AllowUserToAddRows = false;
            dgvSexo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSexo.AutoGenerateColumns = false;
            dgvSexo.Columns.Clear();
            dgvSexo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSexo.ClearSelection();
            dgvSexo.ReadOnly = true;

            //Código
            dgvSexo.Columns.Add("codigo", "Código");

            //Nombre
            dgvSexo.Columns.Add("nombre", "Nombre");

            //Estado
            DataGridViewTextBoxColumn colestado = new DataGridViewTextBoxColumn
            {
                Name = "estado",
                HeaderText = "Estado"
            };

            dgvSexo.Columns.Add(colestado);

            //============= ESTILO =============
            dgvSexo.RowHeadersVisible = false;
            dgvSexo.MultiSelect = false;
            dgvSexo.AllowUserToResizeRows = false;

            dgvSexo.EnableHeadersVisualStyles = false;
            dgvSexo.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvSexo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSexo.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            dgvSexo.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvSexo.DefaultCellStyle.SelectionForeColor = Color.White;
            //==================================
        }

        private void LlenarGrid(List<SexoBO> sexos)
        {
            dgvSexo.Rows.Clear();

            foreach (SexoBO sexo in sexos)
            {
                dgvSexo.Rows.Add(
                    sexo.codigo,
                    sexo.nombre,
                    sexo.estado ? "Habilitado" : "Deshabilitado"
                );
            }

            dgvSexo.ClearSelection();
            dgvSexo.CurrentCell = null;
        }
        public frmbuscarsexo()
        {
            InitializeComponent();

            ConfigurarGrid();
            CargarSexo();
            LlenarGrid(listasexo);
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            string valor = txtValor.Text.Trim().ToLower();

            var resultado = listasexo.Where(
                s => s.codigo.ToString().Contains(valor) ||
                     s.nombre.ToLower().Contains(valor)
            ).ToList();

            LlenarGrid(resultado);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
