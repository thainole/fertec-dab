using pe.com.fertec.bal;
using pe.com.fertec.bo;
using pe.com.fertec.ui.sexo;
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
    public partial class sexoFrm : Form
    {
        //creamos un objeto de SexoBAL
        private SexoBAL bal = new SexoBAL();

        //creamos un objeto de SexoBO
        private SexoBO obj = new SexoBO();

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

        //creamos un procedimiento para cargar Sexo
        private void CargarSexo()
        {
            //creamos una lista para almacenar los valores
            List<SexoBO> sexos = bal.findAllCustom();

            //asignamos los valores al DataGridView
            dgvSexo.DataSource = sexos;
        }

        //creamos un procedimiento para personalizar el DataGridView
        private void PersonalizarDataGridView()
        {
            //Ajustar el tamaño de las columnas
            dgvSexo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //Ajustar el ancho para llenar el DataGridView
            dgvSexo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Evitar que las columnas se autogeneren
            dgvSexo.AutoGenerateColumns = false;

            //Limpiar las columnas existentes
            dgvSexo.Columns.Clear();

            //Eliminar la selección inicial
            dgvSexo.ClearSelection();

            //Hacer que el DataGridView sea de solo lectura
            dgvSexo.ReadOnly = true;

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
            dgvSexo.Columns.Add(colcodigo);
            dgvSexo.Columns.Add(colnombre);
            dgvSexo.Columns.Add(colestado);

            //========== ESTILO ==========
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
            //============================

            //Aplicar formato para la columna Estado
            dgvSexo.CellFormatting += (s, e) =>
            {
                if (dgvSexo.Columns[e.ColumnIndex].Name == "estado" && e.Value != null)
                {
                    e.Value = (bool)e.Value ? "Habilitado" : "Deshabilitado";
                    e.FormattingApplied = true;
                }
            };
        }
        public sexoFrm()
        {
            InitializeComponent();

            //centrar el formulario
            this.StartPosition = FormStartPosition.CenterScreen;

            //bloqueamos los controles
            Bloquear();

            //hacemos las caja de solo lectura
            SoleLectura();

            //llamamos al procedimiento para cargar sexo
            CargarSexo();

            //llamamos a la personalizacion del DataGridView
            PersonalizarDataGridView();
        }

        private void sexoFrm_Load(object sender, EventArgs e)
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
                        "Registro de Sexo", 0, 48);

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
                        Util.MensajePersonalizado("Se registro el sexo",
                            "Registro de Sexo", 0, 64);

                        CargarSexo();
                        Limpiar();
                        Bloquear();
                        btnNuevo.Enabled = true;
                    }
                    else
                    {
                        Util.MensajePersonalizado("No se registro el sexo",
                            "Registro de Sexo", 0, 16);
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
                    "Actualizar Sexo", 0, 48);

                dgvSexo.Focus();
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
                    Util.MensajePersonalizado("Se actualizo el sexo",
                        "Actualizar Sexo", 0, 64);

                    CargarSexo();
                    Limpiar();
                    Bloquear();
                    btnNuevo.Enabled = true;
                }
                else
                {
                    Util.MensajePersonalizado("No se puede actualizar el sexo",
                        "Actualizar Sexo", 0, 16);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (indice < 0)
            {
                Util.MensajePersonalizado("Seleccione un elemento de la lista",
                    "Eliminar Sexo", 0, 48);

                dgvSexo.Focus();
            }
            else
            {
                cod = Convert.ToInt32(txtCodigo.Text);

                obj.codigo = cod;

                DialogResult resultado = Util.MensajePersonalizado(
                    "¿Quieres eliminar el sexo?", "Eliminar Sexo",
                    4, 16);

                if (resultado == DialogResult.Yes)
                {
                    res = bal.delete(cod);

                    if (res == true)
                    {
                        Util.MensajePersonalizado("Se elimino el sexo",
                            "Eliminar Sexo", 0, 64);

                        CargarSexo();
                        Limpiar();
                        Bloquear();
                        btnNuevo.Enabled = true;
                    }
                    else
                    {
                        Util.MensajePersonalizado("No se puede eliminar el sexo",
                            "Eliminar Sexo", 0, 16);
                    }
                }
            }
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            frmhabilitarsexo formulario = new frmhabilitarsexo();
            formulario.Show();
            Hide();
        }

        private void dgvSexo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //capturamos el indice seleccionado
            indice = e.RowIndex;

            //verificamos que se seleccione un valor
            if (indice >= 0)
            {
                Desbloquear();

                btnRegistrar.Enabled = false;

                DataGridViewRow filaseleccionada = dgvSexo.Rows[indice];

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
            frmbuscarsexo formulario = new frmbuscarsexo();
            formulario.ShowDialog();
        }
    }
}
