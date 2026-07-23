using pe.com.fertec.bal;
using pe.com.fertec.bo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pe.com.fertec.ui.tipodocumento
{

    public partial class frmbuscartipodocumento : Form
    {
        // Instancia de la capa de negocio
        private TipoDocumentoBAL bal = new TipoDocumentoBAL();

        // Objeto de negocio de apoyo
        private TipoDocumentoBO obj = new TipoDocumentoBO();

        // Lista de tipos de documento
        List<TipoDocumentoBO> listatipodocumento =
            new List<TipoDocumentoBO>();

        private void CargarTipoDocumento()
        {
            listatipodocumento = bal.findAll();
        }

        private void ConfigurarGrid()
        {
            dgvTipoDeDocumento.AllowUserToAddRows = false;
            dgvTipoDeDocumento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTipoDeDocumento.AutoGenerateColumns = false;
            dgvTipoDeDocumento.Columns.Clear();
            dgvTipoDeDocumento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTipoDeDocumento.ClearSelection();
            dgvTipoDeDocumento.ReadOnly = true;

            //Código
            dgvTipoDeDocumento.Columns.Add("codigo", "Código");

            //Nombre
            dgvTipoDeDocumento.Columns.Add("nombre", "Nombre");

            //Estado
            DataGridViewTextBoxColumn colestado = new DataGridViewTextBoxColumn
            {
                Name = "estado",
                HeaderText = "Estado"
            };

            dgvTipoDeDocumento.Columns.Add(colestado);

            //============= ESTILO =============
            dgvTipoDeDocumento.RowHeadersVisible = false;
            dgvTipoDeDocumento.MultiSelect = false;
            dgvTipoDeDocumento.AllowUserToResizeRows = false;

            dgvTipoDeDocumento.EnableHeadersVisualStyles = false;
            dgvTipoDeDocumento.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvTipoDeDocumento.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTipoDeDocumento.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            dgvTipoDeDocumento.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvTipoDeDocumento.DefaultCellStyle.SelectionForeColor = Color.White;
            //==================================
        }

        private void LlenarGrid(
            List<TipoDocumentoBO> tipodocumentos)
        {
            dgvTipoDeDocumento.Rows.Clear();

            foreach (TipoDocumentoBO tipodocumento
                     in tipodocumentos)
            {
                dgvTipoDeDocumento.Rows.Add(
                    tipodocumento.codigo,
                    tipodocumento.nombre,
                    tipodocumento.estado ?
                    "Habilitado" : "Deshabilitado"
                );
            }

            dgvTipoDeDocumento.ClearSelection();
            dgvTipoDeDocumento.CurrentCell = null;
        }
        public frmbuscartipodocumento()
        {
            InitializeComponent();

            ConfigurarGrid();
            CargarTipoDocumento();
            LlenarGrid(listatipodocumento);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            string valor =
                txtValor.Text.Trim().ToLower();

            var resultado = listatipodocumento.Where(
                td => td.codigo.ToString().Contains(valor) ||
                      td.nombre.ToLower().Contains(valor)
            ).ToList();

            LlenarGrid(resultado);
        }
    }
}
