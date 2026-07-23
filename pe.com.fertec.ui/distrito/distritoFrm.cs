using pe.com.fertec.bal;
using pe.com.fertec.bo;
using pe.com.fertec.ui.distrito;
using pe.com.fertec.ui.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pe.com.fertec.ui
{
    public partial class distritoFrm : Form
    {
        //creamos un objeto de DistritoBAL
        private DistritoBAL bal = new DistritoBAL();

        //creamos un objeto de DistritoBO
        private DistritoBO obj = new DistritoBO();

        //declaramos variables
        private int cod = 0, indice = -1;
        private string nom = "";
        private bool est = false, res = false;

        //creamos un procedimiento para bloquear
        private void Bloquear()
        {
            txtCodigo.Enabled = false;
            txtNombre.Enabled = false;
            chkEstado.Enabled = false;
            btnRegistrar.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        //creamos un procedimiento para desbloquear
        private void Desbloquear()
        {
            txtCodigo.Enabled = true;
            txtNombre.Enabled = true;
            chkEstado.Enabled = true;
            btnRegistrar.Enabled = true;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        //creamos un procedimiento de solo lectura
        private void SoleLectura()
        {
            txtCodigo.ReadOnly = true;
        }

        //creamos un procedimiento para limpiar
        private void Limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            chkEstado.Checked = false;
        }

        //creamos un procedimiento para cargar Distrito
        private void CargarDistrito()
        {
            //creamos una lista para almacenar los valores
            List<DistritoBO> distritos = bal.findAllCustom();

            //asignamos los valores al DataGridView
            dgvDistrito.DataSource = distritos;
        }

        //creamos un procedimiento para personalizar el DataGridView
        private void PersonalizarDataGridView()
        {
            //Ajustar el tamaño de las columnas
            dgvDistrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //Ajustar el ancho para llenar el DataGridView
            dgvDistrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Evitar que las columnas se autogeneren
            dgvDistrito.AutoGenerateColumns = false;

            //Limpiar las columnas existentes
            dgvDistrito.Columns.Clear();

            //Eliminar la selección inicial
            dgvDistrito.ClearSelection();

            //Hacer que el DataGridView sea de solo lectura
            dgvDistrito.ReadOnly = true;

            //Código
            DataGridViewTextBoxColumn colcodigo = new DataGridViewTextBoxColumn
            {
                Name = "codigo",
                HeaderText = "Código",
                DataPropertyName = "codigo"
            };

            //Nombre
            DataGridViewTextBoxColumn colnombre = new DataGridViewTextBoxColumn
            {
                Name = "nombre",
                HeaderText = "Nombre",
                DataPropertyName = "nombre"
            };

            //Estado
            DataGridViewTextBoxColumn colestado = new DataGridViewTextBoxColumn
            {
                Name = "estado",
                HeaderText = "Estado",
                DataPropertyName = "estado"
            };

            //Agregar columnas
            dgvDistrito.Columns.Add(colcodigo);
            dgvDistrito.Columns.Add(colnombre);
            dgvDistrito.Columns.Add(colestado);

            //========== ESTILO ==========
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
            //============================

            //Aplicar formato para la columna Estado
            dgvDistrito.CellFormatting += (s, e) =>
            {
                if (dgvDistrito.Columns[e.ColumnIndex].Name == "estado" && e.Value != null)
                {
                    e.Value = (bool)e.Value ? "Habilitado" : "Deshabilitado";
                    e.FormattingApplied = true;
                }
            };
        }

        public distritoFrm()
        {
            InitializeComponent();

            //centrar el formulario
            this.StartPosition = FormStartPosition.CenterScreen;

            //bloqueamos los controles
            Bloquear();

            //hacemos las caja de solo lectura
            SoleLectura();

            //llamamos al procedimiento para cargar distrito
            CargarDistrito();

            //llamamos a la personalizacion del DataGridView
            PersonalizarDataGridView();
        }

        private void distritoFrm_Load(object sender, EventArgs e)
        {

        }



        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //llamamos al metodo para desbloquear
            Desbloquear();

            //llamamos al metodo para limpiar
            Limpiar();

            //bloqueamos el boton nuevo
            btnNuevo.Enabled = false;

            //mostramos el siguiente codigo
            txtCodigo.Text = bal.setCode().ToString();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "")
                {
                    Util.MensajePersonalizado("Ingresa el nombre",
                        "Registro de Distrito", 0, 48);

                    txtNombre.Focus();
                }
                else
                {
                    nom = txtNombre.Text;
                    est = chkEstado.Checked;

                    obj.nombre = nom;
                    obj.estado = est;

                    res = bal.add(obj);

                    if (res == true)
                    {
                        Util.MensajePersonalizado("Se registro el distrito",
                            "Registro de Distrito", 0, 64);

                        CargarDistrito();
                        Limpiar();
                        Bloquear();
                        btnNuevo.Enabled = true;
                    }
                    else
                    {
                        Util.MensajePersonalizado("No se registro el distrito",
                            "Registro de Distrito", 0, 16);
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
                    "Actualizar Distrito", 0, 48);

                dgvDistrito.Focus();
            }
            else
            {
                cod = Convert.ToInt32(txtCodigo.Text);
                nom = txtNombre.Text;
                est = chkEstado.Checked;

                obj.codigo = cod;
                obj.nombre = nom;
                obj.estado = est;

                res = bal.update(obj, cod);

                if (res == true)
                {
                    Util.MensajePersonalizado("Se actualizo el distrito",
                        "Actualizar Distrito", 0, 64);

                    CargarDistrito();
                    Limpiar();
                    Bloquear();
                    btnNuevo.Enabled = true;
                }
                else
                {
                    Util.MensajePersonalizado("No se puede actualizar el distrito",
                        "Actualizar Distrito", 0, 16);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (indice < 0)
            {
                Util.MensajePersonalizado("Seleccione un elemento de la lista",
                    "Eliminar Distrito", 0, 48);

                dgvDistrito.Focus();
            }
            else
            {
                cod = Convert.ToInt32(txtCodigo.Text);

                obj.codigo = cod;

                DialogResult resultado = Util.MensajePersonalizado(
                    "¿Quieres eliminar el distrito?", "Eliminar Distrito",
                    4, 16);

                if (resultado == DialogResult.Yes)
                {
                    res = bal.delete(cod);

                    if (res == true)
                    {
                        Util.MensajePersonalizado("Se elimino el distrito",
                            "Eliminar Distrito", 0, 64);

                        CargarDistrito();
                        Limpiar();
                        Bloquear();
                        btnNuevo.Enabled = true;
                    }
                    else
                    {
                        Util.MensajePersonalizado("No se puede eliminar el distrito",
                            "Eliminar Distrito", 0, 16);
                    }
                }
            }
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            frmhabilitardistrito formulario = new frmhabilitardistrito();
            formulario.Show();
            Hide();
        }

        private void dgvDistrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //capturamos el indice seleccionado
            indice = e.RowIndex;

            //verificamos que se seleccione un valor
            if (indice >= 0)
            {
                Desbloquear();

                btnRegistrar.Enabled = false;

                DataGridViewRow filaseleccionada = dgvDistrito.Rows[indice];

                txtCodigo.Text = filaseleccionada.Cells["codigo"].Value.ToString();

                txtNombre.Text = filaseleccionada.Cells["nombre"].Value.ToString();

                if (Convert.ToBoolean(filaseleccionada.Cells["estado"].Value))
                {
                    chkEstado.Checked = true;
                }
                else
                {
                    chkEstado.Checked = false;
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmbuscardistrito formulario = new frmbuscardistrito();
            formulario.ShowDialog();
        }
    }
}
