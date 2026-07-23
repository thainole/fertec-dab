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

namespace pe.com.fertec.ui.empleado
{
    public partial class frmempleado : Form
    {
        // BAL
        private EmpleadoBAL bal = new EmpleadoBAL();

        private DistritoBAL baldis = new DistritoBAL();

        private RolBAL balrol = new RolBAL();

        private SexoBAL balsex = new SexoBAL();

        private TipoDocumentoBAL baltipd = new TipoDocumentoBAL();

        // Objetos
        private EmpleadoBO obj = new EmpleadoBO();

        private DistritoBO objdis = new DistritoBO();

        private RolBO objrol = new RolBO();

        private SexoBO objsex = new SexoBO();

        private TipoDocumentoBO objtipd = new TipoDocumentoBO();

        // Variables
        private int cod = 0,
            coddis = 0,
            codrol = 0,
            codsex = 0,
            codtipd = 0,
            indice = -1;

        private string nom = "",
            apep = "",
            apem = "",
            numdoc = "",
            dir = "",
            tel = "",
            cel = "",
            cor = "",
            usu = "",
            cla = "";

        private decimal sue = 0;

        private DateTime fecnac,
            fecing;

        private bool est = false,
            res = false;
        public frmempleado()
        {
            InitializeComponent();
            CargarEmpleado();
            CargarCombos();
            LimpiarFecha();
            Bloquear();
            SoloLectura();
        }
        private void CargarEmpleado()
        {

            dgvEmpleado.AllowUserToAddRows = false;
            dgvEmpleado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmpleado.AutoGenerateColumns = false;
            dgvEmpleado.Columns.Clear();
            dgvEmpleado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleado.MultiSelect = false;

            dgvEmpleado.ClearSelection();
            dgvEmpleado.ReadOnly = true;


            dgvEmpleado.Columns.Add("codigo", "Código");
            dgvEmpleado.Columns.Add("nombre", "Nombre");
            dgvEmpleado.Columns.Add("apellidopaterno", "Apellido Paterno");
            dgvEmpleado.Columns.Add("apellidomaterno", "Apellido Materno");
            dgvEmpleado.Columns.Add("numerodocumento", "N° Documento");
            dgvEmpleado.Columns.Add("fechanacimiento", "Fecha Nacimiento");
            dgvEmpleado.Columns.Add("fechaingreso", "Fecha Ingreso");
            dgvEmpleado.Columns.Add("direccion", "Dirección");
            dgvEmpleado.Columns.Add("telefono", "Teléfono");
            dgvEmpleado.Columns.Add("celular", "Celular");
            dgvEmpleado.Columns.Add("correo", "Correo");
            dgvEmpleado.Columns.Add("usuario", "Usuario");
            dgvEmpleado.Columns.Add("clave", "Clave");
            dgvEmpleado.Columns.Add("sueldo", "Sueldo");
            dgvEmpleado.Columns.Add("distrito", "Distrito");
            dgvEmpleado.Columns.Add("rol", "Rol");
            dgvEmpleado.Columns.Add("sexo", "Sexo");
            dgvEmpleado.Columns.Add("tipodocumento", "Tipo Documento");

            DataGridViewTextBoxColumn colestado = new DataGridViewTextBoxColumn
            {
                Name = "estado",
                HeaderText = "Estado",
                DataPropertyName = "estado"
            };

            dgvEmpleado.Columns.Add(colestado);

            List<EmpleadoBO> empleados = bal.findAllCustom();

            for (int i = 0; i < empleados.Count; i++)
            {
                EmpleadoBO empleado = empleados[i];

                dgvEmpleado.Rows.Add();

                dgvEmpleado.Rows[i].Cells["codigo"].Value = empleado.codigo;
                dgvEmpleado.Rows[i].Cells["nombre"].Value = empleado.nombre;
                dgvEmpleado.Rows[i].Cells["apellidopaterno"].Value = empleado.apellidopaterno;
                dgvEmpleado.Rows[i].Cells["apellidomaterno"].Value = empleado.apellidomaterno;
                dgvEmpleado.Rows[i].Cells["numerodocumento"].Value = empleado.numerodocumento;
                dgvEmpleado.Rows[i].Cells["fechanacimiento"].Value = empleado.fechanacimiento;
                dgvEmpleado.Rows[i].Cells["fechaingreso"].Value = empleado.fechaingreso;
                dgvEmpleado.Rows[i].Cells["direccion"].Value = empleado.direccion;
                dgvEmpleado.Rows[i].Cells["telefono"].Value = empleado.telefono;
                dgvEmpleado.Rows[i].Cells["celular"].Value = empleado.celular;
                dgvEmpleado.Rows[i].Cells["correo"].Value = empleado.correo;
                dgvEmpleado.Rows[i].Cells["usuario"].Value = empleado.usuario;
                dgvEmpleado.Rows[i].Cells["clave"].Value = empleado.clave;
                dgvEmpleado.Rows[i].Cells["sueldo"].Value = empleado.sueldo;
                dgvEmpleado.Rows[i].Cells["distrito"].Value = empleado.distrito.nombre;
                dgvEmpleado.Rows[i].Cells["rol"].Value = empleado.rol.nombre;
                dgvEmpleado.Rows[i].Cells["sexo"].Value = empleado.sexo.nombre;
                dgvEmpleado.Rows[i].Cells["tipodocumento"].Value = empleado.tipodocumento.nombre;
                dgvEmpleado.Rows[i].Cells["estado"].Value =
                    empleado.estado ? "Habilitado" : "Deshabilitado";
            }

            // ===== Estilo =====
            dgvEmpleado.EnableHeadersVisualStyles = false;

            dgvEmpleado.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvEmpleado.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvEmpleado.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);

            dgvEmpleado.ColumnHeadersHeight = 35;

            dgvEmpleado.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            dgvEmpleado.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvEmpleado.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            dgvEmpleado.RowHeadersVisible = false;

            dgvEmpleado.BorderStyle = BorderStyle.FixedSingle;
            dgvEmpleado.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEmpleado.GridColor = Color.LightGray;
        }

        private void CargarCombos()
        {
            // Distrito
            List<DistritoBO> distritos = baldis.findAllCustom();

            DistritoBO distrito = new DistritoBO()
            {
                codigo = 0,
                nombre = "Seleccione distrito",
                estado = true
            };

            distritos.Insert(0, distrito);

            cboDistrito.DataSource = distritos;
            cboDistrito.DisplayMember = "nombre";
            cboDistrito.ValueMember = "codigo";

            // Rol
            List<RolBO> roles = balrol.findAllCustom();

            RolBO rol = new RolBO()
            {
                codigo = 0,
                nombre = "Seleccione rol",
                estado = true
            };

            roles.Insert(0, rol);

            cboRol.DataSource = roles;
            cboRol.DisplayMember = "nombre";
            cboRol.ValueMember = "codigo";

            // Sexo
            List<SexoBO> sexos = balsex.findAllCustom();

            SexoBO sexo = new SexoBO()
            {
                codigo = 0,
                nombre = "Seleccione sexo",
                estado = true
            };

            sexos.Insert(0, sexo);

            cboSexo.DataSource = sexos;
            cboSexo.DisplayMember = "nombre";
            cboSexo.ValueMember = "codigo";

            // Tipo Documento
            List<TipoDocumentoBO> tipodocumentos = baltipd.findAllCustom();

            TipoDocumentoBO tipodocumento = new TipoDocumentoBO()
            {
                codigo = 0,
                nombre = "Seleccione tipo documento",
                estado = true
            };

            tipodocumentos.Insert(0, tipodocumento);

            cboTipoDocumento.DataSource = tipodocumentos;
            cboTipoDocumento.DisplayMember = "nombre";
            cboTipoDocumento.ValueMember = "codigo";

            // Solo lectura
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        // Limpiar fechas
        private void LimpiarFecha()
        {
            dtpFecNac.Format = DateTimePickerFormat.Custom;
            dtpFecNac.CustomFormat = " ";

            dtpFecIng.Format = DateTimePickerFormat.Custom;
            dtpFecIng.CustomFormat = " ";
        }

        // Bloquear
        private void Bloquear()
        {
            txtCod.Enabled = false;
            txtNom.Enabled = false;
            txtApeP.Enabled = false;
            txtApeM.Enabled = false;
            txtNumDoc.Enabled = false;
            txtDir.Enabled = false;
            txtTel.Enabled = false;
            txtCel.Enabled = false;
            txtCor.Enabled = false;
            txtUsu.Enabled = false;
            txtCla.Enabled = false;
            txtSue.Enabled = false;

            dtpFecNac.Enabled = false;
            dtpFecIng.Enabled = false;

            cboDistrito.Enabled = false;
            cboRol.Enabled = false;
            cboSexo.Enabled = false;
            cboTipoDocumento.Enabled = false;

            chkEstado.Enabled = false;

            btnRegistrar.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        // Desbloquear
        private void Desbloquear()
        {
            txtCod.Enabled = true;
            txtNom.Enabled = true;
            txtApeP.Enabled = true;
            txtApeM.Enabled = true;
            txtNumDoc.Enabled = true;
            txtDir.Enabled = true;
            txtTel.Enabled = true;
            txtCel.Enabled = true;
            txtCor.Enabled = true;
            txtUsu.Enabled = true;
            txtCla.Enabled = true;
            txtSue.Enabled = true;

            dtpFecNac.Enabled = true;
            dtpFecIng.Enabled = true;

            cboDistrito.Enabled = true;
            cboRol.Enabled = true;
            cboSexo.Enabled = true;
            cboTipoDocumento.Enabled = true;

            chkEstado.Enabled = true;

            btnRegistrar.Enabled = true;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        // Solo lectura
        private void SoloLectura()
        {
            txtCod.ReadOnly = true;
        }

        // Limpiar
        private void Limpiar()
        {
            txtCod.Text = "";
            txtNom.Text = "";
            txtApeP.Text = "";
            txtApeM.Text = "";
            txtNumDoc.Text = "";
            txtDir.Text = "";
            txtTel.Text = "";
            txtCel.Text = "";
            txtCor.Text = "";
            txtUsu.Text = "";
            txtCla.Text = "";
            txtSue.Text = "";

            LimpiarFecha();

            cboDistrito.SelectedIndex = 0;
            cboRol.SelectedIndex = 0;
            cboSexo.SelectedIndex = 0;
            cboTipoDocumento.SelectedIndex = 0;

            chkEstado.Checked = false;
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
                    Util.MensajePersonalizado("Ingresa el nombre", "Registro Empleado", 0, 48);
                    txtNom.Focus();
                }
                else if (txtApeP.Text == "")
                {
                    Util.MensajePersonalizado("Ingresa apellido paterno", "Registro Empleado", 0, 48);
                    txtApeP.Focus();
                }
                else if (txtApeM.Text == "")
                {
                    Util.MensajePersonalizado("Ingresa apellido materno", "Registro Empleado", 0, 48);
                    txtApeM.Focus();
                }
                else if (txtNumDoc.Text == "")
                {
                    Util.MensajePersonalizado("Ingresa número de documento", "Registro Empleado", 0, 48);
                    txtNumDoc.Focus();
                }
                else if (txtDir.Text == "")
                {
                    Util.MensajePersonalizado("Ingresa dirección", "Registro Empleado", 0, 48);
                    txtDir.Focus();
                }
                else if (txtTel.Text == "")
                {
                    Util.MensajePersonalizado("Ingresa teléfono", "Registro Empleado", 0, 48);
                    txtTel.Focus();
                }
                else if (txtCel.Text == "")
                {
                    Util.MensajePersonalizado("Ingresa celular", "Registro Empleado", 0, 48);
                    txtCel.Focus();
                }
                else if (txtCor.Text == "")
                {
                    Util.MensajePersonalizado("Ingresa correo", "Registro Empleado", 0, 48);
                    txtCor.Focus();
                }
                else if (txtUsu.Text == "")
                {
                    Util.MensajePersonalizado("Ingresa usuario", "Registro Empleado", 0, 48);
                    txtUsu.Focus();
                }
                else if (txtCla.Text == "")
                {
                    Util.MensajePersonalizado("Ingresa clave", "Registro Empleado", 0, 48);
                    txtCla.Focus();
                }
                else if (dtpFecNac.CustomFormat == " ")
                {
                    Util.MensajePersonalizado("Seleccione fecha de nacimiento", "Registro Empleado", 0, 48);
                    dtpFecNac.Focus();
                }
                else if (dtpFecIng.CustomFormat == " ")
                {
                    Util.MensajePersonalizado("Seleccione fecha de ingreso", "Registro Empleado", 0, 48);
                    dtpFecIng.Focus();
                }
                else if (txtSue.Text == "")
                {
                    Util.MensajePersonalizado("Ingresa sueldo", "Registro Empleado", 0, 48);
                    txtSue.Focus();
                }
                else if (cboDistrito.SelectedIndex == 0)
                {
                    Util.MensajePersonalizado("Seleccione distrito", "Registro Empleado", 0, 48);
                    cboDistrito.Focus();
                }
                else if (cboRol.SelectedIndex == 0)
                {
                    Util.MensajePersonalizado("Seleccione rol", "Registro Empleado", 0, 48);
                    cboRol.Focus();
                }
                else if (cboSexo.SelectedIndex == 0)
                {
                    Util.MensajePersonalizado("Seleccione sexo", "Registro Empleado", 0, 48);
                    cboSexo.Focus();
                }
                else if (cboTipoDocumento.SelectedIndex == 0)
                {
                    Util.MensajePersonalizado("Seleccione tipo de documento", "Registro Empleado", 0, 48);
                    cboTipoDocumento.Focus();
                }
                else
                {
                    // Capturar datos
                    nom = txtNom.Text;
                    apep = txtApeP.Text;
                    apem = txtApeM.Text;
                    numdoc = txtNumDoc.Text;
                    dir = txtDir.Text;
                    tel = txtTel.Text;
                    cel = txtCel.Text;
                    cor = txtCor.Text;
                    usu = txtUsu.Text;
                    cla = txtCla.Text;

                    fecnac = dtpFecNac.Value;
                    fecing = dtpFecIng.Value;

                    sue = Convert.ToDecimal(txtSue.Text);

                    coddis = Convert.ToInt32(cboDistrito.SelectedValue);
                    codrol = Convert.ToInt32(cboRol.SelectedValue);
                    codsex = Convert.ToInt32(cboSexo.SelectedValue);
                    codtipd = Convert.ToInt32(cboTipoDocumento.SelectedValue);

                    est = chkEstado.Checked;

                    // Objeto
                    obj.nombre = nom;
                    obj.apellidopaterno = apep;
                    obj.apellidomaterno = apem;
                    obj.numerodocumento = numdoc;
                    obj.fechanacimiento = fecnac;
                    obj.fechaingreso = fecing;
                    obj.direccion = dir;
                    obj.telefono = tel;
                    obj.celular = cel;
                    obj.correo = cor;
                    obj.usuario = usu;
                    obj.clave = cla;
                    obj.sueldo = sue;
                    obj.estado = est;

                    // Foreign Keys
                    objdis.codigo = coddis;
                    obj.distrito = objdis;

                    objrol.codigo = codrol;
                    obj.rol = objrol;

                    objsex.codigo = codsex;
                    obj.sexo = objsex;

                    objtipd.codigo = codtipd;
                    obj.tipodocumento = objtipd;

                    // Registrar
                    res = bal.add(obj);

                    if (res)
                    {
                        Util.MensajePersonalizado(
                            "Se registró el empleado",
                            "Registro Empleado",
                            0,
                            64);

                        CargarEmpleado();
                        Limpiar();
                        Bloquear();

                        btnNuevo.Enabled = true;
                    }
                    else
                    {
                        Util.MensajePersonalizado(
                            "No se registró el empleado",
                            "Registro Empleado",
                            0,
                            16);
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
                Util.MensajePersonalizado(
                    "Seleccione un elemento de la lista",
                    "Actualizar Empleado",
                    0,
                    48);

                dgvEmpleado.Focus();
            }
            else
            {
                cod = Convert.ToInt32(txtCod.Text);

                nom = txtNom.Text;
                apep = txtApeP.Text;
                apem = txtApeM.Text;
                numdoc = txtNumDoc.Text;
                dir = txtDir.Text;
                tel = txtTel.Text;
                cel = txtCel.Text;
                cor = txtCor.Text;
                usu = txtUsu.Text;
                cla = txtCla.Text;

                fecnac = dtpFecNac.Value;
                fecing = dtpFecIng.Value;

                sue = Convert.ToDecimal(txtSue.Text);

                coddis = Convert.ToInt32(cboDistrito.SelectedValue);
                codrol = Convert.ToInt32(cboRol.SelectedValue);
                codsex = Convert.ToInt32(cboSexo.SelectedValue);
                codtipd = Convert.ToInt32(cboTipoDocumento.SelectedValue);

                est = chkEstado.Checked;

                // Objeto
                obj.codigo = cod;
                obj.nombre = nom;
                obj.apellidopaterno = apep;
                obj.apellidomaterno = apem;
                obj.numerodocumento = numdoc;
                obj.fechanacimiento = fecnac;
                obj.fechaingreso = fecing;
                obj.direccion = dir;
                obj.telefono = tel;
                obj.celular = cel;
                obj.correo = cor;
                obj.usuario = usu;
                obj.clave = cla;
                obj.sueldo = sue;
                obj.estado = est;

                // Foreign Keys
                objdis.codigo = coddis;
                obj.distrito = objdis;

                objrol.codigo = codrol;
                obj.rol = objrol;

                objsex.codigo = codsex;
                obj.sexo = objsex;

                objtipd.codigo = codtipd;
                obj.tipodocumento = objtipd;

                // Actualizar
                res = bal.update(obj, cod);

                if (res)
                {
                    Util.MensajePersonalizado(
                        "Se actualizó el empleado",
                        "Actualización Empleado",
                        0,
                        64);

                    CargarEmpleado();
                    Limpiar();
                    Bloquear();

                    btnNuevo.Enabled = true;
                }
                else
                {
                    Util.MensajePersonalizado(
                        "No se actualizó el empleado",
                        "Actualización Empleado",
                        0,
                        16);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (indice < 0)
            {
                Util.MensajePersonalizado(
                    "Seleccione un elemento de la lista",
                    "Eliminar Empleado",
                    0,
                    48);

                dgvEmpleado.Focus();
            }
            else
            {
                cod = Convert.ToInt32(txtCod.Text);

                obj.codigo = cod;

                DialogResult resultado =
                    Util.MensajePersonalizado(
                        "¿Quieres eliminar el empleado?",
                        "Eliminar Empleado",
                        4,
                        16);

                if (resultado == DialogResult.Yes)
                {
                    res = bal.delete(cod);

                    if (res)
                    {
                        Util.MensajePersonalizado(
                            "Se eliminó el empleado",
                            "Eliminar Empleado",
                            0,
                            64);

                        CargarEmpleado();
                        Limpiar();
                        Bloquear();

                        btnNuevo.Enabled = true;
                    }
                    else
                    {
                        Util.MensajePersonalizado(
                            "No se puede eliminar el empleado",
                            "Eliminar Empleado",
                            0,
                            16);
                    }
                }
            }
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            frmhabilitarempleado formulario = new frmhabilitarempleado();
            formulario.Show();
            Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmbuscarempleado formulario = new frmbuscarempleado();
            formulario.ShowDialog();
        }

        private void dgvEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;

            if (indice >= 0)
            {
                Desbloquear();

                btnRegistrar.Enabled = false;

                DataGridViewRow filaseleccionada =
                    dgvEmpleado.Rows[indice];

                txtCod.Text =
                    filaseleccionada.Cells["codigo"].Value.ToString();

                txtNom.Text =
                    filaseleccionada.Cells["nombre"].Value.ToString();

                txtApeP.Text =
                    filaseleccionada.Cells["apellidopaterno"].Value.ToString();

                txtApeM.Text =
                    filaseleccionada.Cells["apellidomaterno"].Value.ToString();

                txtNumDoc.Text =
                    filaseleccionada.Cells["numerodocumento"].Value.ToString();

                txtDir.Text =
                    filaseleccionada.Cells["direccion"].Value.ToString();

                txtTel.Text =
                    filaseleccionada.Cells["telefono"].Value.ToString();

                txtCel.Text =
                    filaseleccionada.Cells["celular"].Value.ToString();

                txtCor.Text =
                    filaseleccionada.Cells["correo"].Value.ToString();

                txtUsu.Text =
                    filaseleccionada.Cells["usuario"].Value.ToString();

                txtCla.Text =
                    filaseleccionada.Cells["clave"].Value.ToString();

                txtSue.Text =
                    filaseleccionada.Cells["sueldo"].Value.ToString();

                // Fecha nacimiento
                string fecnac =
                    filaseleccionada.Cells["fechanacimiento"].Value.ToString();

                dtpFecNac.Value =
                    Convert.ToDateTime(fecnac);

                dtpFecNac.CustomFormat = "dd/MM/yyyy";

                // Fecha ingreso
                string fecing =
                    filaseleccionada.Cells["fechaingreso"].Value.ToString();

                dtpFecIng.Value =
                    Convert.ToDateTime(fecing);

                dtpFecIng.CustomFormat = "dd/MM/yyyy";

                // Combo Distrito
                string distritoseleccionado =
                    filaseleccionada.Cells["distrito"].Value.ToString();

                List<DistritoBO> distritos =
                    baldis.findAllCustom();

                DistritoBO distritoenc =
                    distritos.FirstOrDefault(
                        d => d.nombre.Equals(
                            distritoseleccionado,
                            StringComparison.OrdinalIgnoreCase));

                int coddistrito = -1;

                if (distritoenc != null)
                    coddistrito = distritoenc.codigo;

                cboDistrito.SelectedValue = coddistrito;

                // Combo Rol
                string rolseleccionado =
                    filaseleccionada.Cells["rol"].Value.ToString();

                List<RolBO> roles =
                    balrol.findAllCustom();

                RolBO rolenc =
                    roles.FirstOrDefault(
                        r => r.nombre.Equals(
                            rolseleccionado,
                            StringComparison.OrdinalIgnoreCase));

                int codrolenc = -1;

                if (rolenc != null)
                    codrolenc = rolenc.codigo;

                cboRol.SelectedValue = codrolenc;

                // Combo Sexo
                string sexoseleccionado =
                    filaseleccionada.Cells["sexo"].Value.ToString();

                List<SexoBO> sexos =
                    balsex.findAllCustom();

                SexoBO sexoenc =
                    sexos.FirstOrDefault(
                        s => s.nombre.Equals(
                            sexoseleccionado,
                            StringComparison.OrdinalIgnoreCase));

                int codsexoenc = -1;

                if (sexoenc != null)
                    codsexoenc = sexoenc.codigo;

                cboSexo.SelectedValue = codsexoenc;

                // Combo Tipo Documento
                string tipodocumentoseleccionado =
                    filaseleccionada.Cells["tipodocumento"].Value.ToString();

                List<TipoDocumentoBO> tipodocumentos =
                    baltipd.findAllCustom();

                TipoDocumentoBO tipodocumentoenc =
                    tipodocumentos.FirstOrDefault(
                        td => td.nombre.Equals(
                            tipodocumentoseleccionado,
                            StringComparison.OrdinalIgnoreCase));

                int codtipdoc = -1;

                if (tipodocumentoenc != null)
                    codtipdoc = tipodocumentoenc.codigo;

                cboTipoDocumento.SelectedValue = codtipdoc;

                // Estado
                chkEstado.Checked =
                    filaseleccionada.Cells["estado"].Value.ToString() == "Habilitado";
            }
        }

        private void dtpFecNac_ValueChanged(object sender, EventArgs e)
        {
            dtpFecNac.CustomFormat = "dd/MM/yyyy";
        }

        private void dtpFecIng_ValueChanged(object sender, EventArgs e)
        {
            dtpFecIng.CustomFormat = "dd/MM/yyyy";
        }
    }
}
