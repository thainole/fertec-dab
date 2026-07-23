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

namespace pe.com.fertec.ui.sexo
{
    public partial class frmhabilitarsexo : Form
    {
        private SexoBAL bal = new SexoBAL();
        private SexoBO obj = new SexoBO();

        //declaramos variables
        private int cod = 0, indice = -1;
        private bool res = false;


        public frmhabilitarsexo()
        {
            InitializeComponent();

            CargarSexo();

            PersonalizarDataGridView();
        }
        private void CargarSexo()
        {
            List<SexoBO> sexos = bal.findAll();

            dgvSexo.DataSource = sexos;
        }

        //creamos un procedimiento para personalizar el DataGridView
        private void PersonalizarDataGridView()
        {
            dgvSexo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            dgvSexo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dgvSexo.AutoGenerateColumns = false;


            dgvSexo.Columns.Clear();


            dgvSexo.ClearSelection();


            dgvSexo.ReadOnly = true;


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


            dgvSexo.Columns.Add(colcodigo);
            dgvSexo.Columns.Add(colnombre);
            dgvSexo.Columns.Add(colestado);

            //================ ESTILO =================
            dgvSexo.RowHeadersVisible = false;
            dgvSexo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSexo.MultiSelect = false;
            dgvSexo.AllowUserToAddRows = false;
            dgvSexo.AllowUserToResizeRows = false;

            dgvSexo.EnableHeadersVisualStyles = false;
            dgvSexo.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvSexo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSexo.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            dgvSexo.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvSexo.DefaultCellStyle.SelectionForeColor = Color.White;
            //=========================================


            dgvSexo.CellFormatting += (s, e) =>
            {
                if (dgvSexo.Columns[e.ColumnIndex].Name == "estado" && e.Value != null)
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
                    "Habilitar Sexo",
                    0,
                    48);

                dgvSexo.Focus();
            }
            else
            {
                obj.codigo = cod;

                DialogResult resultado = Util.MensajePersonalizado(
                    "¿Quieres habilitar el sexo?",
                    "Habilitar Sexo",
                    4,
                    16);

                if (resultado == DialogResult.Yes)
                {
                    res = bal.enable(cod);

                    if (res == true)
                    {
                        Util.MensajePersonalizado(
                            "Se habilito el sexo",
                            "Habilitar Sexo",
                            0,
                            64);

                        CargarSexo();
                    }
                    else
                    {
                        Util.MensajePersonalizado(
                            "No se puede habilitar el sexo",
                            "Habilitar Sexo",
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
                    "Deshabilitar Sexo",
                    0,
                    48);

                dgvSexo.Focus();
            }
            else
            {
                obj.codigo = cod;

                DialogResult resultado = Util.MensajePersonalizado(
                    "¿Quieres deshabilitar el sexo?",
                    "Deshabilitar Sexo",
                    4,
                    16);

                if (resultado == DialogResult.Yes)
                {
                    res = bal.delete(cod);

                    if (res == true)
                    {
                        Util.MensajePersonalizado(
                            "Se deshabilito el sexo",
                            "Deshabilitar Sexo",
                            0,
                            64);

                        CargarSexo();
                    }
                    else
                    {
                        Util.MensajePersonalizado(
                            "No se puede deshabilitar el sexo",
                            "Deshabilitar Sexo",
                            0,
                            16);
                    }
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            sexoFrm formulario = new sexoFrm();

            formulario.Show();

            Close();
        }

        private void dgvSexo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;

            if (indice >= 0)
            {
                DataGridViewRow filaseleccionada = dgvSexo.Rows[indice];

                cod = Convert.ToInt32(
                    filaseleccionada.Cells["codigo"].Value.ToString());
            }
        }
    }
}
