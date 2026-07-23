using pe.com.fertec.bal;
using pe.com.fertec.bo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pe.com.fertec.ui.distrito
{
    public partial class frmbuscardistrito : Form
    { 
        private DistritoBAL bal = new DistritoBAL();

        
        private DistritoBO obj = new DistritoBO();

        
        List<DistritoBO> listadistrito = new List<DistritoBO>();

        private void CargarDistrito()
        {
            listadistrito = bal.findAll();
        }

        private void ConfigurarGrid()
        {
            dgvDistrito.AllowUserToAddRows = false;
            dgvDistrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDistrito.AutoGenerateColumns = false;
            dgvDistrito.Columns.Clear();
            dgvDistrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDistrito.ClearSelection();
            dgvDistrito.ReadOnly = true;

          
            dgvDistrito.Columns.Add("codigo", "Código");

            
            dgvDistrito.Columns.Add("nombre", "Nombre");

            
            DataGridViewTextBoxColumn colestado = new DataGridViewTextBoxColumn
            {
                Name = "estado",
                HeaderText = "Estado"
            };

            dgvDistrito.Columns.Add(colestado);

            //============= ESTILO =============
            dgvDistrito.RowHeadersVisible = false;
            dgvDistrito.MultiSelect = false;
            dgvDistrito.AllowUserToResizeRows = false;

            dgvDistrito.EnableHeadersVisualStyles = false;
            dgvDistrito.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvDistrito.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDistrito.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            dgvDistrito.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvDistrito.DefaultCellStyle.SelectionForeColor = Color.White;
            //==================================
        }

        private void LlenarGrid(List<DistritoBO> distritos)
        {
            dgvDistrito.Rows.Clear();

            foreach (DistritoBO distrito in distritos)
            {
                dgvDistrito.Rows.Add(
                    distrito.codigo,
                    distrito.nombre,
                    distrito.estado ? "Habilitado" : "Deshabilitado"
                );
            }

            dgvDistrito.ClearSelection();
            dgvDistrito.CurrentCell = null;
        }

        public frmbuscardistrito()
        {
            InitializeComponent();

            ConfigurarGrid();
            CargarDistrito();
            LlenarGrid(listadistrito);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            string valor = txtValor.Text.Trim().ToLower();

            var resultado = listadistrito.Where(
                d => d.nombre.ToLower().Contains(valor) ||
                     d.codigo.ToString().Contains(valor)
            ).ToList();

            LlenarGrid(resultado);
        }
    }
}
