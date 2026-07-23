using pe.com.fertec.bal;
using pe.com.fertec.bo;
using pe.com.fertec.ui.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pe.com.fertec.ui.tipodocumento
{
    public partial class frmhabilitartipodedocumento : Form
    {
        private TipoDocumentoBAL bal = new TipoDocumentoBAL();
        private TipoDocumentoBO obj = new TipoDocumentoBO();

        //declaramos variables
        private int cod = 0, indice = -1;
        private bool res = false;
        public frmhabilitartipodedocumento()
        {
            InitializeComponent();

            CargarTipoDocumento();

            PersonalizarDataGridView();
        }

       
        private void CargarTipoDocumento()
        {
            List<TipoDocumentoBO> documentos = bal.findAll();

            dgvTipoDocumento.DataSource = documentos;
        }

        private void PersonalizarDataGridView()
        {
            dgvTipoDocumento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            dgvTipoDocumento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dgvTipoDocumento.AutoGenerateColumns = false;


            dgvTipoDocumento.Columns.Clear();


            dgvTipoDocumento.ClearSelection();


            dgvTipoDocumento.ReadOnly = true;


            DataGridViewTextBoxColumn colcodigo = new DataGridViewTextBoxColumn
            {
                Name = "codigo",
                HeaderText = "Código",
                DataPropertyName = "codigo"
            };

            DataGridViewTextBoxColumn colnombre = new DataGridViewTextBoxColumn
            {
                Name = "nombre",
                HeaderText = "Nombre",
                DataPropertyName = "nombre"
            };


            DataGridViewTextBoxColumn colestado = new DataGridViewTextBoxColumn
            {
                Name = "estado",
                HeaderText = "Estado",
                DataPropertyName = "estado"
            };


            dgvTipoDocumento.Columns.Add(colcodigo);
            dgvTipoDocumento.Columns.Add(colnombre);
            dgvTipoDocumento.Columns.Add(colestado);

            //================ ESTILO =================
            dgvTipoDocumento.RowHeadersVisible = false;
            dgvTipoDocumento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTipoDocumento.MultiSelect = false;
            dgvTipoDocumento.AllowUserToAddRows = false;
            dgvTipoDocumento.AllowUserToResizeRows = false;

            dgvTipoDocumento.EnableHeadersVisualStyles = false;
            dgvTipoDocumento.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvTipoDocumento.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTipoDocumento.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            dgvTipoDocumento.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvTipoDocumento.DefaultCellStyle.SelectionForeColor = Color.White;
            //=========================================


            dgvTipoDocumento.CellFormatting += (s, e) =>
            {
                if (dgvTipoDocumento.Columns[e.ColumnIndex].Name == "estado" && e.Value != null)
                {
                    e.Value = (bool)e.Value ? "Habilitado" : "Deshabilitado";
                    e.FormattingApplied = true;
                }
            };
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            if (indice < 0)
            {
                Util.MensajePersonalizado(
                    "Seleccione un elemento de la lista",
                    "Habilitar Tipo Documento",
                    0,
                    48);

                dgvTipoDocumento.Focus();
            }
            else
            {
                obj.codigo = cod;

                DialogResult resultado = Util.MensajePersonalizado(
                    "¿Quieres habilitar el tipo documento?",
                    "Habilitar Tipo Documento",
                    4,
                    16);

                if (resultado == DialogResult.Yes)
                {
                    res = bal.enable(cod);

                    if (res == true)
                    {
                        Util.MensajePersonalizado(
                            "Se habilito el tipo documento",
                            "Habilitar Tipo Documento",
                            0,
                            64);

                        CargarTipoDocumento();
                    }
                    else
                    {
                        Util.MensajePersonalizado(
                            "No se puede habilitar el tipo documento",
                            "Habilitar Tipo Documento",
                            0,
                            16);
                    }
                }
            }
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            if (indice < 0)
            {
                Util.MensajePersonalizado(
                    "Seleccione un elemento de la lista",
                    "Deshabilitar Tipo Documento",
                    0,
                    48);

                dgvTipoDocumento.Focus();
            }
            else
            {
                obj.codigo = cod;

                DialogResult resultado = Util.MensajePersonalizado(
                    "¿Quieres deshabilitar el tipo documento?",
                    "Deshabilitar Tipo Documento",
                    4,
                    16);

                if (resultado == DialogResult.Yes)
                {
                    res = bal.delete(cod);

                    if (res == true)
                    {
                        Util.MensajePersonalizado(
                            "Se deshabilito el tipo documento",
                            "Deshabilitar Tipo Documento",
                            0,
                            64);

                        CargarTipoDocumento();
                    }
                    else
                    {
                        Util.MensajePersonalizado(
                            "No se puede deshabilitar el tipo documento",
                            "Deshabilitar Tipo Documento",
                            0,
                            16);
                    }
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmTipoDocumento formulario = new frmTipoDocumento();

            formulario.Show();

            Hide();
        }

        private void dgvTipoDocumento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;

            if (indice >= 0)
            {
                DataGridViewRow filaseleccionada = dgvTipoDocumento.Rows[indice];

                cod = Convert.ToInt32(
                    filaseleccionada.Cells["codigo"].Value.ToString());
            }
        }
    }
}
