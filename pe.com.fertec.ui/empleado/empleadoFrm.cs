using pe.com.fertec.bal;
using pe.com.fertec.bo;
using System.Net.Mail;

namespace pe.com.fertec.ui
{
    public partial class empleadoFrm : Form
    {
        private readonly EmpleadoBAL bal = new EmpleadoBAL();
        private readonly DistritoBAL distritoBAL = new DistritoBAL();
        private readonly SexoBAL sexoBAL = new SexoBAL();
        private readonly TipoDocumentoBAL tipoDocumentoBAL = new TipoDocumentoBAL();
        private readonly RolBAL rolBAL = new RolBAL();
        private int indice = -1;

        public empleadoFrm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Habilitar(false);
            SoloLectura();
            ConfigurarDGV();
        }

        private void empleadoFrm_Load(object sender, EventArgs e)
        {
            CargarTiposDocumento();
            CargarSexos();
            CargarDistritos();
            CargarRoles();
            Listar();
            CargarCodigo();
        }

        private void ConfigurarDGV()
        {
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.AutoGenerateColumns = false;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.MultiSelect = false;
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.Columns.Clear();
            dgvEmpleados.ClearSelection();
            dgvEmpleados.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvEmpleados.GridColor = Color.LightGray;
            dgvEmpleados.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            dgvEmpleados.Columns.Add(CrearColumna("codigo", "Código", "codigo", 70));
            dgvEmpleados.Columns.Add(CrearColumna("nombre", "Nombres", "nombre", 130));
            dgvEmpleados.Columns.Add(CrearColumna(
                "apellidopaterno", "Apellido paterno", "apellidopaterno", 125));
            dgvEmpleados.Columns.Add(CrearColumna(
                "apellidomaterno", "Apellido materno", "apellidomaterno", 125));
            dgvEmpleados.Columns.Add(CrearColumna(
                "tipodocumento", "Tipo documento", "tipodocumento", 120));
            dgvEmpleados.Columns.Add(CrearColumna(
                "numerodocumento", "N.º documento", "numerodocumento", 115));
            dgvEmpleados.Columns.Add(CrearColumna("sexo", "Sexo", "sexo", 90));
            dgvEmpleados.Columns.Add(CrearColumna("distrito", "Distrito", "distrito", 120));
            dgvEmpleados.Columns.Add(CrearColumna("rol", "Rol", "rol", 120));

            DataGridViewTextBoxColumn columnaNacimiento =
                CrearColumna("fechanacimiento", "Fecha nacimiento", "fechanacimiento", 115);
            columnaNacimiento.DefaultCellStyle =
                new DataGridViewCellStyle { Format = "dd/MM/yyyy" };
            dgvEmpleados.Columns.Add(columnaNacimiento);

            DataGridViewTextBoxColumn columnaIngreso =
                CrearColumna("fechaingreso", "Fecha ingreso", "fechaingreso", 105);
            columnaIngreso.DefaultCellStyle =
                new DataGridViewCellStyle { Format = "dd/MM/yyyy" };
            dgvEmpleados.Columns.Add(columnaIngreso);

            dgvEmpleados.Columns.Add(CrearColumna("direccion", "Dirección", "direccion", 180));
            dgvEmpleados.Columns.Add(CrearColumna("telefono", "Teléfono", "telefono", 95));
            dgvEmpleados.Columns.Add(CrearColumna("celular", "Celular", "celular", 95));
            dgvEmpleados.Columns.Add(CrearColumna("correo", "Correo", "correo", 170));
            dgvEmpleados.Columns.Add(CrearColumna("usuario", "Usuario", "usuario", 110));

            DataGridViewTextBoxColumn columnaSueldo =
                CrearColumna("sueldo", "Sueldo", "sueldo", 95);
            columnaSueldo.DefaultCellStyle = new DataGridViewCellStyle
            {
                Format = "C2",
                Alignment = DataGridViewContentAlignment.MiddleRight
            };
            dgvEmpleados.Columns.Add(columnaSueldo);

            dgvEmpleados.Columns.Add(CrearColumna("estado", "Estado", "estado", 100));
            dgvEmpleados.CellFormatting += dgvEmpleados_CellFormatting;
        }

        private static DataGridViewTextBoxColumn CrearColumna(
            string nombre, string encabezado, string propiedad, int ancho)
        {
            return new DataGridViewTextBoxColumn
            {
                Name = nombre,
                HeaderText = encabezado,
                DataPropertyName = propiedad,
                Width = ancho
            };
        }

        private void dgvEmpleados_CellFormatting(
            object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.Value == null)
            {
                return;
            }

            string nombreColumna = dgvEmpleados.Columns[e.ColumnIndex].Name;

            if (nombreColumna == "estado" && e.Value is bool estado)
            {
                e.Value = estado ? "Habilitado" : "Deshabilitado";
                e.FormattingApplied = true;
            }
            else if (nombreColumna == "distrito" && e.Value is DistritoBO distrito)
            {
                e.Value = distrito.nombre;
                e.FormattingApplied = true;
            }
            else if (nombreColumna == "sexo" && e.Value is SexoBO sexo)
            {
                e.Value = sexo.nombre;
                e.FormattingApplied = true;
            }
            else if (nombreColumna == "tipodocumento" &&
                e.Value is TipoDocumentoBO tipoDocumento)
            {
                e.Value = tipoDocumento.nombre;
                e.FormattingApplied = true;
            }
            else if (nombreColumna == "rol" && e.Value is RolBO rol)
            {
                e.Value = rol.nombre;
                e.FormattingApplied = true;
            }
        }

        private void Habilitar(bool habilitado)
        {
            txtNombre.Enabled = habilitado;
            txtApellidoPaterno.Enabled = habilitado;
            txtApellidoMaterno.Enabled = habilitado;
            cboTipoDocumento.Enabled = habilitado;
            txtNumeroDocumento.Enabled = habilitado;
            cboSexo.Enabled = habilitado;
            cboDistrito.Enabled = habilitado;
            cboRol.Enabled = habilitado;
            dtpFechaNacimiento.Enabled = habilitado;
            dtpFechaIngreso.Enabled = habilitado;
            txtDireccion.Enabled = habilitado;
            txtTelefono.Enabled = habilitado;
            txtCelular.Enabled = habilitado;
            txtCorreo.Enabled = habilitado;
            txtUsuario.Enabled = habilitado;
            txtClave.Enabled = habilitado;
            txtSueldo.Enabled = habilitado;
            chkEstado.Enabled = habilitado;
            btnRegistrar.Enabled = habilitado;
            btnActualizar.Enabled = habilitado;
            btnInhabilitar.Enabled = habilitado;
            btnHabilitar.Enabled = habilitado;
            btnCancelar.Enabled = habilitado;
        }

        private void SoloLectura()
        {
            txtCodigo.ReadOnly = true;
        }

        private void CargarTiposDocumento()
        {
            try
            {
                List<TipoDocumentoBO>? tiposDocumento = tipoDocumentoBAL.findAllCustom();
                cboTipoDocumento.DisplayMember = "nombre";
                cboTipoDocumento.ValueMember = "codigo";
                cboTipoDocumento.DataSource = tiposDocumento;
                cboTipoDocumento.SelectedIndex = -1;

                if (tiposDocumento == null)
                {
                    MostrarError("No se pudieron cargar los tipos de documento.");
                }
            }
            catch (Exception ex)
            {
                cboTipoDocumento.DataSource = null;
                MostrarError($"No se pudieron cargar los tipos de documento. {ex.Message}");
            }
        }

        private void CargarSexos()
        {
            try
            {
                List<SexoBO>? sexos = sexoBAL.findAllCustom();
                cboSexo.DisplayMember = "nombre";
                cboSexo.ValueMember = "codigo";
                cboSexo.DataSource = sexos;
                cboSexo.SelectedIndex = -1;

                if (sexos == null)
                {
                    MostrarError("No se pudieron cargar los sexos.");
                }
            }
            catch (Exception ex)
            {
                cboSexo.DataSource = null;
                MostrarError($"No se pudieron cargar los sexos. {ex.Message}");
            }
        }

        private void CargarDistritos()
        {
            try
            {
                List<DistritoBO>? distritos = distritoBAL.findAllCustom();
                cboDistrito.DisplayMember = "nombre";
                cboDistrito.ValueMember = "codigo";
                cboDistrito.DataSource = distritos;
                cboDistrito.SelectedIndex = -1;

                if (distritos == null)
                {
                    MostrarError("No se pudieron cargar los distritos.");
                }
            }
            catch (Exception ex)
            {
                cboDistrito.DataSource = null;
                MostrarError($"No se pudieron cargar los distritos. {ex.Message}");
            }
        }

        private void CargarRoles()
        {
            try
            {
                List<RolBO>? roles = rolBAL.findAllCustom();
                cboRol.DisplayMember = "nombre";
                cboRol.ValueMember = "codigo";
                cboRol.DataSource = roles;
                cboRol.SelectedIndex = -1;

                if (roles == null)
                {
                    MostrarError("No se pudieron cargar los roles.");
                }
            }
            catch (Exception ex)
            {
                cboRol.DataSource = null;
                MostrarError($"No se pudieron cargar los roles. {ex.Message}");
            }
        }

        private void Listar()
        {
            try
            {
                List<EmpleadoBO>? empleados = chkMostrarTodos.Checked
                    ? bal.findAll()
                    : bal.findAllCustom();

                dgvEmpleados.DataSource = null;
                dgvEmpleados.DataSource = empleados;
                dgvEmpleados.ClearSelection();
                indice = -1;

                if (empleados == null)
                {
                    MostrarError("No se pudo obtener la lista de empleados.");
                }
            }
            catch (Exception ex)
            {
                dgvEmpleados.DataSource = null;
                MostrarError($"No se pudo obtener la lista de empleados. {ex.Message}");
            }
        }

        private void CargarCodigo()
        {
            try
            {
                txtCodigo.Text = bal.setCode().ToString();
            }
            catch (Exception ex)
            {
                txtCodigo.Clear();
                MostrarError($"No se pudo obtener el siguiente código. {ex.Message}");
            }
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtNumeroDocumento.Clear();
            dtpFechaNacimiento.Value = DateTime.Today;
            dtpFechaIngreso.Value = DateTime.Today;
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCelular.Clear();
            txtCorreo.Clear();
            txtUsuario.Clear();
            txtClave.Clear();
            txtSueldo.Clear();
            chkEstado.Checked = true;
            cboTipoDocumento.SelectedIndex = -1;
            cboSexo.SelectedIndex = -1;
            cboDistrito.SelectedIndex = -1;
            cboRol.SelectedIndex = -1;
            lblTipoDocumentoActual.Text = "";
            lblSexoActual.Text = "";
            lblDistritoActual.Text = "";
            lblRolActual.Text = "";
            lblRelaciones.Text = "";
            CargarCodigo();
            txtNombre.Focus();
        }

        private void PrepararNuevo()
        {
            Habilitar(true);
            Limpiar();
            btnNuevo.Enabled = false;
            btnRegistrar.Enabled = true;
            btnActualizar.Enabled = false;
            btnInhabilitar.Enabled = false;
            btnHabilitar.Enabled = false;
            indice = -1;
        }

        private void PrepararEdicion(EmpleadoBO empleado)
        {
            Habilitar(true);
            btnNuevo.Enabled = true;
            btnRegistrar.Enabled = false;
            btnActualizar.Enabled = true;
            btnInhabilitar.Enabled = empleado.estado;
            btnHabilitar.Enabled = !empleado.estado;

            txtCodigo.Text = empleado.codigo.ToString();
            txtNombre.Text = empleado.nombre;
            txtApellidoPaterno.Text = empleado.apellidopaterno;
            txtApellidoMaterno.Text = empleado.apellidomaterno;
            txtNumeroDocumento.Text = empleado.numerodocumento;
            dtpFechaNacimiento.Value = empleado.fechanacimiento;
            dtpFechaIngreso.Value = empleado.fechaingreso;
            txtDireccion.Text = empleado.direccion;
            txtTelefono.Text = empleado.telefono;
            txtCelular.Text = empleado.celular;
            txtCorreo.Text = empleado.correo;
            txtUsuario.Text = empleado.usuario;
            txtClave.Text = empleado.clave;
            txtSueldo.Text = empleado.sueldo.ToString("0.00");
            chkEstado.Checked = empleado.estado;

            lblTipoDocumentoActual.Text =
                $"Actual: {empleado.tipodocumento?.nombre}";
            lblSexoActual.Text = $"Actual: {empleado.sexo?.nombre}";
            lblDistritoActual.Text = $"Actual: {empleado.distrito?.nombre}";
            lblRolActual.Text = $"Actual: {empleado.rol?.nombre}";

            bool tipoDocumentoSeleccionado =
                SeleccionarValor(cboTipoDocumento, empleado.tipodocumento?.codigo ?? 0);
            bool sexoSeleccionado =
                SeleccionarValor(cboSexo, empleado.sexo?.codigo ?? 0);
            bool distritoSeleccionado =
                SeleccionarValor(cboDistrito, empleado.distrito?.codigo ?? 0);
            bool rolSeleccionado =
                SeleccionarValor(cboRol, empleado.rol?.codigo ?? 0);

            if (!tipoDocumentoSeleccionado || !sexoSeleccionado ||
                !distritoSeleccionado || !rolSeleccionado)
            {
                lblRelaciones.Text =
                    "Seleccione TipoDocumento, Sexo, Distrito y Rol antes de actualizar; el DAL actual no devuelve sus códigos.";
            }
            else
            {
                lblRelaciones.Text = "";
            }
        }

        private static bool SeleccionarValor(ComboBox comboBox, int codigo)
        {
            comboBox.SelectedIndex = -1;

            if (codigo <= 0)
            {
                return false;
            }

            comboBox.SelectedValue = codigo;
            return comboBox.SelectedIndex >= 0;
        }

        private bool ValidarDatos(
            out decimal sueldo,
            out int codigoTipoDocumento,
            out int codigoSexo,
            out int codigoDistrito,
            out int codigoRol)
        {
            sueldo = 0;
            codigoTipoDocumento = 0;
            codigoSexo = 0;
            codigoDistrito = 0;
            codigoRol = 0;

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MostrarAdvertencia("Ingrese el nombre del empleado.", txtNombre);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellidoPaterno.Text))
            {
                MostrarAdvertencia("Ingrese el apellido paterno.", txtApellidoPaterno);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNumeroDocumento.Text))
            {
                MostrarAdvertencia("Ingrese el número de documento.", txtNumeroDocumento);
                return false;
            }

            if (!int.TryParse(
                    cboTipoDocumento.SelectedValue?.ToString(), out codigoTipoDocumento))
            {
                MostrarAdvertencia("Seleccione un tipo de documento.", cboTipoDocumento);
                return false;
            }

            if (!int.TryParse(cboSexo.SelectedValue?.ToString(), out codigoSexo))
            {
                MostrarAdvertencia("Seleccione un sexo.", cboSexo);
                return false;
            }

            if (!int.TryParse(cboDistrito.SelectedValue?.ToString(), out codigoDistrito))
            {
                MostrarAdvertencia("Seleccione un distrito.", cboDistrito);
                return false;
            }

            if (!int.TryParse(cboRol.SelectedValue?.ToString(), out codigoRol))
            {
                MostrarAdvertencia("Seleccione un rol.", cboRol);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MostrarAdvertencia("Ingrese el usuario del empleado.", txtUsuario);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MostrarAdvertencia("Ingrese la contraseña del empleado.", txtClave);
                return false;
            }

            if (!decimal.TryParse(txtSueldo.Text.Trim(), out sueldo))
            {
                MostrarAdvertencia("Ingrese un sueldo válido.", txtSueldo);
                return false;
            }

            if (sueldo < 0)
            {
                MostrarAdvertencia("El sueldo debe ser mayor o igual a cero.", txtSueldo);
                return false;
            }

            if (dtpFechaNacimiento.Value.Date > DateTime.Today)
            {
                MostrarAdvertencia(
                    "La fecha de nacimiento no puede ser posterior a hoy.",
                    dtpFechaNacimiento);
                return false;
            }

            if (dtpFechaIngreso.Value.Date < dtpFechaNacimiento.Value.Date)
            {
                MostrarAdvertencia(
                    "La fecha de ingreso no puede ser anterior a la fecha de nacimiento.",
                    dtpFechaIngreso);
                return false;
            }

            string correo = txtCorreo.Text.Trim();
            if (correo.Length > 0 && !MailAddress.TryCreate(correo, out _))
            {
                MostrarAdvertencia("Ingrese un correo válido.", txtCorreo);
                return false;
            }

            string telefono = txtTelefono.Text.Trim();
            if (telefono.Length > 0 && !telefono.All(char.IsDigit))
            {
                MostrarAdvertencia(
                    "El teléfono solo debe contener números.", txtTelefono);
                return false;
            }

            string celular = txtCelular.Text.Trim();
            if (celular.Length > 0 && !celular.All(char.IsDigit))
            {
                MostrarAdvertencia(
                    "El celular solo debe contener números.", txtCelular);
                return false;
            }

            return true;
        }

        private EmpleadoBO CrearEmpleado(
            decimal sueldo,
            int codigoTipoDocumento,
            int codigoSexo,
            int codigoDistrito,
            int codigoRol)
        {
            return new EmpleadoBO
            {
                codigo = int.TryParse(txtCodigo.Text, out int codigo) ? codigo : 0,
                nombre = txtNombre.Text.Trim(),
                apellidopaterno = txtApellidoPaterno.Text.Trim(),
                apellidomaterno = txtApellidoMaterno.Text.Trim(),
                numerodocumento = txtNumeroDocumento.Text.Trim(),
                fechanacimiento = dtpFechaNacimiento.Value.Date,
                fechaingreso = dtpFechaIngreso.Value.Date,
                direccion = txtDireccion.Text.Trim(),
                telefono = txtTelefono.Text.Trim(),
                celular = txtCelular.Text.Trim(),
                correo = txtCorreo.Text.Trim(),
                usuario = txtUsuario.Text.Trim(),
                clave = txtClave.Text,
                sueldo = sueldo,
                estado = chkEstado.Checked,
                distrito = new DistritoBO { codigo = codigoDistrito },
                sexo = new SexoBO { codigo = codigoSexo },
                tipodocumento = new TipoDocumentoBO { codigo = codigoTipoDocumento },
                rol = new RolBO { codigo = codigoRol }
            };
        }

        private void FinalizarOperacion()
        {
            Listar();
            RestablecerModoConsulta();
        }

        private void RestablecerModoConsulta()
        {
            Limpiar();
            Habilitar(false);
            btnNuevo.Enabled = true;
            dgvEmpleados.ClearSelection();
            indice = -1;
        }

        private static void MostrarAdvertencia(string mensaje, Control control)
        {
            MessageBox.Show(
                mensaje, "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
        }

        private static void MostrarError(string mensaje)
        {
            MessageBox.Show(
                mensaje, "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            PrepararNuevo();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos(
                    out decimal sueldo,
                    out int codigoTipoDocumento,
                    out int codigoSexo,
                    out int codigoDistrito,
                    out int codigoRol))
            {
                return;
            }

            EmpleadoBO empleado = CrearEmpleado(
                sueldo, codigoTipoDocumento, codigoSexo, codigoDistrito, codigoRol);

            try
            {
                if (bal.add(empleado))
                {
                    MessageBox.Show(
                        "Empleado registrado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    FinalizarOperacion();
                }
                else
                {
                    MostrarError(
                        "No se pudo registrar el empleado. Verifique si el documento o usuario ya existe y que los datos sean válidos.");
                }
            }
            catch (Exception ex)
            {
                MostrarError($"No se pudo registrar el empleado. {ex.Message}");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (indice < 0 || !int.TryParse(txtCodigo.Text, out int id))
            {
                MostrarAdvertencia("Seleccione un empleado de la lista.", dgvEmpleados);
                return;
            }

            if (!ValidarDatos(
                    out decimal sueldo,
                    out int codigoTipoDocumento,
                    out int codigoSexo,
                    out int codigoDistrito,
                    out int codigoRol))
            {
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Desea actualizar el empleado?",
                "Actualizar empleado",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            EmpleadoBO empleado = CrearEmpleado(
                sueldo, codigoTipoDocumento, codigoSexo, codigoDistrito, codigoRol);

            try
            {
                if (bal.update(empleado, id))
                {
                    MessageBox.Show(
                        "Empleado actualizado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    FinalizarOperacion();
                }
                else
                {
                    MostrarError(
                        "No se pudo actualizar el empleado. Verifique si el documento o usuario ya existe y que los datos sean válidos.");
                }
            }
            catch (Exception ex)
            {
                MostrarError($"No se pudo actualizar el empleado. {ex.Message}");
            }
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            if (indice < 0 || !int.TryParse(txtCodigo.Text, out int id))
            {
                MostrarAdvertencia("Seleccione un empleado de la lista.", dgvEmpleados);
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Desea inhabilitar el empleado?",
                "Inhabilitar empleado",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            try
            {
                if (bal.delete(id))
                {
                    MessageBox.Show(
                        "Empleado inhabilitado correctamente.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    FinalizarOperacion();
                }
                else
                {
                    MostrarError("No se pudo inhabilitar el empleado.");
                }
            }
            catch (Exception ex)
            {
                MostrarError($"No se pudo inhabilitar el empleado. {ex.Message}");
            }
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            if (indice < 0 || !int.TryParse(txtCodigo.Text, out int id))
            {
                MostrarAdvertencia("Seleccione un empleado de la lista.", dgvEmpleados);
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Desea habilitar el empleado?",
                "Habilitar empleado",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            try
            {
                if (bal.enable(id))
                {
                    MessageBox.Show(
                        "Empleado habilitado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    FinalizarOperacion();
                }
                else
                {
                    MostrarError("No se pudo habilitar el empleado.");
                }
            }
            catch (Exception ex)
            {
                MostrarError($"No se pudo habilitar el empleado. {ex.Message}");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBuscar.Text.Trim(), out int codigo) || codigo <= 0)
            {
                MostrarAdvertencia(
                    "Ingrese un código de empleado válido.", txtBuscar);
                return;
            }

            RestablecerModoConsulta();

            try
            {
                EmpleadoBO? empleado = bal.findById(codigo);

                if (empleado == null || empleado.codigo <= 0)
                {
                    dgvEmpleados.DataSource = null;
                    MessageBox.Show(
                        "No se encontró el empleado.",
                        "Buscar empleado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                dgvEmpleados.DataSource = new List<EmpleadoBO> { empleado };
                dgvEmpleados.ClearSelection();
                indice = -1;
            }
            catch (Exception ex)
            {
                MostrarError($"No se pudo buscar el empleado. {ex.Message}");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            Listar();
            RestablecerModoConsulta();
        }

        private void chkMostrarTodos_CheckedChanged(object sender, EventArgs e)
        {
            Listar();
            RestablecerModoConsulta();
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;

            if (indice >= 0 &&
                dgvEmpleados.Rows[indice].DataBoundItem is EmpleadoBO empleado)
            {
                PrepararEdicion(empleado);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            RestablecerModoConsulta();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
