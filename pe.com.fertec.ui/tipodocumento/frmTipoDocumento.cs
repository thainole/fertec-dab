using pe.com.fertec.bal;
using pe.com.fertec.bo;
using pe.com.fertec.ui.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pe.com.fertec.ui.tipodocumento
{
    public partial class frmTipoDocumento : Form
    {

        private TipoDocumentoBAL bal = new TipoDocumentoBAL();


        private TipoDocumentoBO obj = new TipoDocumentoBO();

        private int cod = 0, indice = -1;
        private string nom = "";
        private bool est = false, res = false;


        private void Bloquear()
        {
            txtCod.Enabled = false;
            txtNom.Enabled = false;
            chkEst.Enabled = false;
            btnRegistrar.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }


        private void Desbloquear()
        {
            txtCod.Enabled = true;
            txtNom.Enabled = true;
            chkEst.Enabled = true;
            btnRegistrar.Enabled = true;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void SoleLectura()
        {
            txtCod.ReadOnly = true;
        }


        private void Limpiar()
        {
            txtCod.Text = "";
            txtNom.Text = "";
            chkEst.Checked = false;
        }


        private void CargarTipoDocumento()
        {

            List<TipoDocumentoBO> tipodocumentos = bal.findAllCustom();

            dgvTipoDeDocumento.DataSource = tipodocumentos;
        }


        private void PersonalizarDataGridView()
        {

            dgvTipoDeDocumento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            dgvTipoDeDocumento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dgvTipoDeDocumento.AutoGenerateColumns = false;


            dgvTipoDeDocumento.Columns.Clear();


            dgvTipoDeDocumento.ClearSelection();


            dgvTipoDeDocumento.ReadOnly = true;


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


            dgvTipoDeDocumento.Columns.Add(colcodigo);
            dgvTipoDeDocumento.Columns.Add(colnombre);
            dgvTipoDeDocumento.Columns.Add(colestado);

            //========== ESTILO ==========
            dgvTipoDeDocumento.RowHeadersVisible = false;
            dgvTipoDeDocumento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTipoDeDocumento.MultiSelect = false;
            dgvTipoDeDocumento.AllowUserToAddRows = false;
            dgvTipoDeDocumento.AllowUserToResizeRows = false;

            dgvTipoDeDocumento.EnableHeadersVisualStyles = false;
            dgvTipoDeDocumento.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvTipoDeDocumento.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTipoDeDocumento.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            dgvTipoDeDocumento.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvTipoDeDocumento.DefaultCellStyle.SelectionForeColor = Color.White;
            //============================


            dgvTipoDeDocumento.CellFormatting += (s, e) =>
            {
                if (dgvTipoDeDocumento.Columns[e.ColumnIndex].Name == "estado" && e.Value != null)
                {
                    e.Value = (bool)e.Value ? "Habilitado" : "Deshabilitado";
                    e.FormattingApplied = true;
                }
            };
        }
        public frmTipoDocumento()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;


            Bloquear();

            SoleLectura();


            CargarTipoDocumento();


            PersonalizarDataGridView();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            Desbloquear();


            Limpiar();


            btnNuevo.Enabled = false;


            txtCod.Text = bal.setCode().ToString();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNom.Text == "")
                {
                    Util.MensajePersonalizado("Ingresa el nombre",
                        "Registro de Tipo Documento", 0, 48);

                    txtNom.Focus();
                }
                else
                {
                    nom = txtNom.Text;
                    est = chkEst.Checked;

                    obj.nombre = nom;
                    obj.estado = est;

                    res = bal.add(obj);

                    if (res == true)
                    {
                        Util.MensajePersonalizado("Se registro el tipo documento",
                            "Registro de Tipo Documento", 0, 64);

                        CargarTipoDocumento();
                        Limpiar();
                        Bloquear();
                        btnNuevo.Enabled = true;
                    }
                    else
                    {
                        Util.MensajePersonalizado("No se registro el tipo documento",
                            "Registro de Tipo Documento", 0, 16);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (indice < 0)
            {
                Util.MensajePersonalizado("Seleccione un elemento de la lista",
                    "Actualizar Tipo Documento", 0, 48);

                dgvTipoDeDocumento.Focus();
            }
            else
            {
                cod = Convert.ToInt32(txtCod.Text);
                nom = txtNom.Text;
                est = chkEst.Checked;

                obj.codigo = cod;
                obj.nombre = nom;
                obj.estado = est;

                res = bal.update(obj, cod);

                if (res == true)
                {
                    Util.MensajePersonalizado("Se actualizo el tipo documento",
                        "Actualizar Tipo Documento", 0, 64);

                    CargarTipoDocumento();
                    Limpiar();
                    Bloquear();
                    btnNuevo.Enabled = true;
                }
                else
                {
                    Util.MensajePersonalizado("No se puede actualizar el tipo documento",
                        "Actualizar Tipo Documento", 0, 16);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (indice < 0)
            {
                Util.MensajePersonalizado("Seleccione un elemento de la lista",
                    "Eliminar Tipo Documento", 0, 48);

                dgvTipoDeDocumento.Focus();
            }
            else
            {
                cod = Convert.ToInt32(txtCod.Text);

                obj.codigo = cod;

                DialogResult resultado = Util.MensajePersonalizado(
                    "¿Quieres eliminar el tipo documento?", "Eliminar Tipo Documento",
                    4, 16);

                if (resultado == DialogResult.Yes)
                {
                    res = bal.delete(cod);

                    if (res == true)
                    {
                        Util.MensajePersonalizado("Se elimino el tipo documento",
                            "Eliminar Tipo Documento", 0, 64);

                        CargarTipoDocumento();
                        Limpiar();
                        Bloquear();
                        btnNuevo.Enabled = true;
                    }
                    else
                    {
                        Util.MensajePersonalizado("No se puede eliminar el tipo documento",
                            "Eliminar Tipo Documento", 0, 16);
                    }
                }
            }
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            frmhabilitartipodedocumento formulario = new frmhabilitartipodedocumento();
            formulario.Show();
            Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmbuscartipodocumento formulario = new frmbuscartipodocumento();
            formulario.ShowDialog();
        }

        private void dgvTipoDeDocumento_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            indice = e.RowIndex;


            if (indice >= 0)
            {
                Desbloquear();

                btnRegistrar.Enabled = false;

                DataGridViewRow filaseleccionada = dgvTipoDeDocumento.Rows[indice];

                txtCod.Text = filaseleccionada.Cells["codigo"].Value.ToString();

                txtNom.Text = filaseleccionada.Cells["nombre"].Value.ToString();

                if (Convert.ToBoolean(filaseleccionada.Cells["estado"].Value))
                {
                    chkEst.Checked = true;
                }
                else
                {
                    chkEst.Checked = false;
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
