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

namespace pe.com.fertec.ui.distrito
{
    public partial class frmhabilitardistrito : Form
    {
        private DistritoBAL bal = new DistritoBAL();
        private DistritoBO obj = new DistritoBO();

        private int cod = 0, indice = -1;
        private bool res = false;
        public frmhabilitardistrito()
        {
            InitializeComponent();

            CargarDistrito();

            PersonalizarDataGridView();
        }

       
        private void CargarDistrito()
        {
            List<DistritoBO> distritos = bal.findAll();

            dgvDistrito.DataSource = distritos;
        }

      
        private void PersonalizarDataGridView()
        {
           
            dgvDistrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

          
            dgvDistrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

          
            dgvDistrito.AutoGenerateColumns = false;

        
            dgvDistrito.Columns.Clear();

          
            dgvDistrito.ClearSelection();

          
            dgvDistrito.ReadOnly = true;

     
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


            dgvDistrito.Columns.Add(colcodigo);
            dgvDistrito.Columns.Add(colnombre);
            dgvDistrito.Columns.Add(colestado);

            //================ ESTILO =================
            dgvDistrito.RowHeadersVisible = false;
            dgvDistrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDistrito.MultiSelect = false;
            dgvDistrito.AllowUserToAddRows = false;
            dgvDistrito.AllowUserToResizeRows = false;

            dgvDistrito.EnableHeadersVisualStyles = false;
            dgvDistrito.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvDistrito.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDistrito.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            dgvDistrito.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvDistrito.DefaultCellStyle.SelectionForeColor = Color.White;
            //=========================================

        
            dgvDistrito.CellFormatting += (s, e) =>
            {
                if (dgvDistrito.Columns[e.ColumnIndex].Name == "estado" && e.Value != null)
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
                    "Habilitar Distrito",
                    0,
                    48);

                dgvDistrito.Focus();
            }
            else
            {
                obj.codigo = cod;

                DialogResult resultado = Util.MensajePersonalizado(
                    "¿Quieres habilitar el distrito?",
                    "Habilitar Distrito",
                    4,
                    16);

                if (resultado == DialogResult.Yes)
                {
                    res = bal.enable(cod);

                    if (res == true)
                    {
                        Util.MensajePersonalizado(
                            "Se habilito el distrito",
                            "Habilitar Distrito",
                            0,
                            64);

                        CargarDistrito();
                    }
                    else
                    {
                        Util.MensajePersonalizado(
                            "No se puede habilitar el distrito",
                            "Habilitar Distrito",
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
                    "Deshabilitar Distrito",
                    0,
                    48);

                dgvDistrito.Focus();
            }
            else
            {
                obj.codigo = cod;

                DialogResult resultado = Util.MensajePersonalizado(
                    "¿Quieres deshabilitar el distrito?",
                    "Deshabilitar Distrito",
                    4,
                    16);

                if (resultado == DialogResult.Yes)
                {
                    res = bal.delete(cod);

                    if (res == true)
                    {
                        Util.MensajePersonalizado(
                            "Se deshabilito el distrito",
                            "Deshabilitar Distrito",
                            0,
                            64);

                        CargarDistrito();
                    }
                    else
                    {
                        Util.MensajePersonalizado(
                            "No se puede deshabilitar el distrito",
                            "Deshabilitar Distrito",
                            0,
                            16);
                    }
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            distritoFrm formulario = new distritoFrm();

            formulario.Show();

            Close();
        }

        private void dgvDistrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;

            if (indice >= 0)
            {
                DataGridViewRow filaseleccionada = dgvDistrito.Rows[indice];

                cod = Convert.ToInt32(
                    filaseleccionada.Cells["codigo"].Value.ToString());
            }
        }
    }
}
