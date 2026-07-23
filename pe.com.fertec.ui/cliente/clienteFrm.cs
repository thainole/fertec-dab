using pe.com.fertec.bal;
using pe.com.fertec.bo;
using System.Net.Mail;

namespace pe.com.fertec.ui
{
    public partial class clienteFrm : Form
    {
        private readonly ClienteBAL bal = new ClienteBAL();
        private readonly DistritoBAL distritoBAL = new DistritoBAL();
        private readonly SexoBAL sexoBAL = new SexoBAL();
        private readonly TipoDocumentoBAL tipoDocumentoBAL = new TipoDocumentoBAL();
        private int indice = -1;

        public clienteFrm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Habilitar(false);
            SoloLectura();
            ConfigurarDGV();
        }

        private void clienteFrm_Load(object sender, EventArgs e)
        {
            CargarTiposDocumento();
            CargarSexos();
            CargarDistritos();
            Listar();
            CargarCodigo();
        }

        private void ConfigurarDGV()
        {
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.MultiSelect = false;
            dgvClientes.ReadOnly = true;
            dgvClientes.Columns.Clear();
            dgvClientes.ClearSelection();
            dgvClientes.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvClientes.GridColor = Color.LightGray;
            dgvClientes.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            dgvClientes.Columns.Add(CrearColumna("codigo", "Código", "codigo", 70));
            dgvClientes.Columns.Add(CrearColumna("nombre", "Nombres", "nombre", 130));
            dgvClientes.Columns.Add(CrearColumna("apellidopaterno", "Apellido paterno", "apellidopaterno", 125));
            dgvClientes.Columns.Add(CrearColumna("apellidomaterno", "Apellido materno", "apellidomaterno", 125));
            dgvClientes.Columns.Add(CrearColumna("tipodocumento", "Tipo documento", "tipodocumento", 120));
            dgvClientes.Columns.Add(CrearColumna("numerodocumento", "N.º documento", "numerodocumento", 115));
            dgvClientes.Columns.Add(CrearColumna("sexo", "Sexo", "sexo", 90));
            dgvClientes.Columns.Add(CrearColumna("distrito", "Distrito", "distrito", 120));
            dgvClientes.Columns.Add(CrearColumna("direccion", "Dirección", "direccion", 180));
            dgvClientes.Columns.Add(CrearColumna("telefono", "Teléfono", "telefono", 95));
            dgvClientes.Columns.Add(CrearColumna("celular", "Celular", "celular", 95));
            dgvClientes.Columns.Add(CrearColumna("correo", "Correo", "correo", 170));

            DataGridViewTextBoxColumn columnaFecha =
                CrearColumna("fecharegistro", "Fecha de registro", "fecharegistro", 115);
            columnaFecha.DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" };
            dgvClientes.Columns.Add(columnaFecha);

            dgvClientes.Columns.Add(CrearColumna("estado", "Estado", "estado", 95));
            dgvClientes.CellFormatting += dgvClientes_CellFormatting;
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

        private void dgvClientes_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.Value == null)
            {
                return;
            }

            string nombreColumna = dgvClientes.Columns[e.ColumnIndex].Name;

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
            else if (nombreColumna == "tipodocumento" && e.Value is TipoDocumentoBO tipoDocumento)
            {
                e.Value = tipoDocumento.nombre;
                e.FormattingApplied = true;
            }
        }

        private void Habilitar(bool habilitado)
        {
            txtCodigo.Enabled = habilitado;
            txtNombre.Enabled = habilitado;
            txtApellidoPaterno.Enabled = habilitado;
            txtApellidoMaterno.Enabled = habilitado;
            txtNumeroDocumento.Enabled = habilitado;
            dtpFechaRegistro.Enabled = habilitado;
            txtDireccion.Enabled = habilitado;
            txtTelefono.Enabled = habilitado;
            txtCelular.Enabled = habilitado;
            txtCorreo.Enabled = habilitado;
            chkEstado.Enabled = habilitado;
            cboDistrito.Enabled = habilitado;
            cboSexo.Enabled = habilitado;
            cboTipoDocumento.Enabled = habilitado;
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

        private void Listar()
        {
            try
            {
                List<ClienteBO>? clientes = chkMostrarTodos.Checked
                    ? bal.findAll()
                    : bal.findAllCustom();

                dgvClientes.DataSource = null;
                dgvClientes.DataSource = clientes;
                dgvClientes.ClearSelection();
                indice = -1;

                if (clientes == null)
                {
                    MostrarError("No se pudo obtener la lista de clientes.");
                }
            }
            catch (Exception ex)
            {
                dgvClientes.DataSource = null;
                MostrarError($"No se pudo obtener la lista de clientes. {ex.Message}");
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
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCelular.Clear();
            txtCorreo.Clear();
            dtpFechaRegistro.Value = DateTime.Today;
            chkEstado.Checked = true;
            cboTipoDocumento.SelectedIndex = -1;
            cboSexo.SelectedIndex = -1;
            cboDistrito.SelectedIndex = -1;
            lblTipoDocumentoActual.Text = "";
            lblSexoActual.Text = "";
            lblDistritoActual.Text = "";
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

        private void PrepararEdicion(ClienteBO cliente)
        {
            Habilitar(true);
            btnNuevo.Enabled = true;
            btnRegistrar.Enabled = false;
            btnActualizar.Enabled = true;
            btnInhabilitar.Enabled = cliente.estado;
            btnHabilitar.Enabled = !cliente.estado;

            txtCodigo.Text = cliente.codigo.ToString();
            txtNombre.Text = cliente.nombre;
            txtApellidoPaterno.Text = cliente.apellidopaterno;
            txtApellidoMaterno.Text = cliente.apellidomaterno;
            txtNumeroDocumento.Text = cliente.numerodocumento;
            dtpFechaRegistro.Value = cliente.fecharegistro;
            txtDireccion.Text = cliente.direccion;
            txtTelefono.Text = cliente.telefono;
            txtCelular.Text = cliente.celular;
            txtCorreo.Text = cliente.correo;
            chkEstado.Checked = cliente.estado;

            lblTipoDocumentoActual.Text = $"Actual: {cliente.tipodocumento?.nombre}";
            lblSexoActual.Text = $"Actual: {cliente.sexo?.nombre}";
            lblDistritoActual.Text = $"Actual: {cliente.distrito?.nombre}";

            bool tipoDocumentoSeleccionado =
                SeleccionarValor(cboTipoDocumento, cliente.tipodocumento?.codigo ?? 0);
            bool sexoSeleccionado = SeleccionarValor(cboSexo, cliente.sexo?.codigo ?? 0);
            bool distritoSeleccionado =
                SeleccionarValor(cboDistrito, cliente.distrito?.codigo ?? 0);

            if (!tipoDocumentoSeleccionado || !sexoSeleccionado || !distritoSeleccionado)
            {
                lblRelaciones.Text =
                    "Seleccione TipoDocumento, Sexo y Distrito antes de actualizar; el DAL actual no devuelve sus códigos.";
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

        private bool ValidarDatos(out int codigoTipoDocumento, out int codigoSexo,
            out int codigoDistrito)
        {
            codigoTipoDocumento = 0;
            codigoSexo = 0;
            codigoDistrito = 0;

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MostrarAdvertencia("Ingrese el nombre del cliente.", txtNombre);
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

            if (!int.TryParse(cboTipoDocumento.SelectedValue?.ToString(),
                    out codigoTipoDocumento))
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

            string correo = txtCorreo.Text.Trim();
            if (correo.Length > 0 && !MailAddress.TryCreate(correo, out _))
            {
                MostrarAdvertencia("Ingrese un correo válido.", txtCorreo);
                return false;
            }

            string telefono = txtTelefono.Text.Trim();
            if (telefono.Length > 0 && !telefono.All(char.IsDigit))
            {
                MostrarAdvertencia("El teléfono solo debe contener números.", txtTelefono);
                return false;
            }

            string celular = txtCelular.Text.Trim();
            if (celular.Length > 0 && !celular.All(char.IsDigit))
            {
                MostrarAdvertencia("El celular solo debe contener números.", txtCelular);
                return false;
            }

            return true;
        }

        private ClienteBO CrearCliente(int codigoTipoDocumento, int codigoSexo,
            int codigoDistrito)
        {
            return new ClienteBO
            {
                codigo = int.TryParse(txtCodigo.Text, out int codigo) ? codigo : 0,
                nombre = txtNombre.Text.Trim(),
                apellidopaterno = txtApellidoPaterno.Text.Trim(),
                apellidomaterno = txtApellidoMaterno.Text.Trim(),
                numerodocumento = txtNumeroDocumento.Text.Trim(),
                fecharegistro = dtpFechaRegistro.Value.Date,
                direccion = txtDireccion.Text.Trim(),
                telefono = txtTelefono.Text.Trim(),
                celular = txtCelular.Text.Trim(),
                correo = txtCorreo.Text.Trim(),
                estado = chkEstado.Checked,
                distrito = new DistritoBO { codigo = codigoDistrito },
                sexo = new SexoBO { codigo = codigoSexo },
                tipodocumento = new TipoDocumentoBO { codigo = codigoTipoDocumento }
            };
        }

        private void FinalizarOperacion()
        {
            Listar();
            Limpiar();
            Habilitar(false);
            btnNuevo.Enabled = true;
            indice = -1;
        }

        private static void MostrarAdvertencia(string mensaje, Control control)
        {
            MessageBox.Show(mensaje, "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
        }

        private static void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            PrepararNuevo();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos(out int codigoTipoDocumento, out int codigoSexo,
                    out int codigoDistrito))
            {
                return;
            }

            ClienteBO cliente =
                CrearCliente(codigoTipoDocumento, codigoSexo, codigoDistrito);

            try
            {
                if (bal.add(cliente))
                {
                    MessageBox.Show("Cliente registrado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FinalizarOperacion();
                }
                else
                {
                    MostrarError(
                        "No se pudo registrar el cliente. Verifique que el documento no esté duplicado y que los datos sean válidos.");
                }
            }
            catch (Exception ex)
            {
                MostrarError($"No se pudo registrar el cliente. {ex.Message}");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (indice < 0 || !int.TryParse(txtCodigo.Text, out int id))
            {
                MostrarAdvertencia("Seleccione un cliente de la lista.", dgvClientes);
                return;
            }

            if (!ValidarDatos(out int codigoTipoDocumento, out int codigoSexo,
                    out int codigoDistrito))
            {
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Desea actualizar el cliente?",
                "Actualizar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            ClienteBO cliente =
                CrearCliente(codigoTipoDocumento, codigoSexo, codigoDistrito);

            try
            {
                if (bal.update(cliente, id))
                {
                    MessageBox.Show("Cliente actualizado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FinalizarOperacion();
                }
                else
                {
                    MostrarError(
                        "No se pudo actualizar el cliente. Verifique que el documento no esté duplicado y que los datos sean válidos.");
                }
            }
            catch (Exception ex)
            {
                MostrarError($"No se pudo actualizar el cliente. {ex.Message}");
            }
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            if (indice < 0 || !int.TryParse(txtCodigo.Text, out int id))
            {
                MostrarAdvertencia("Seleccione un cliente de la lista.", dgvClientes);
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Desea inhabilitar el cliente?",
                "Inhabilitar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            try
            {
                if (bal.delete(id))
                {
                    MessageBox.Show("Cliente inhabilitado correctamente.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FinalizarOperacion();
                }
                else
                {
                    MostrarError("No se pudo inhabilitar el cliente.");
                }
            }
            catch (Exception ex)
            {
                MostrarError($"No se pudo inhabilitar el cliente. {ex.Message}");
            }
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            if (indice < 0 || !int.TryParse(txtCodigo.Text, out int id))
            {
                MostrarAdvertencia("Seleccione un cliente de la lista.", dgvClientes);
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Desea habilitar el cliente?",
                "Habilitar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            try
            {
                if (bal.enable(id))
                {
                    MessageBox.Show("Cliente habilitado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FinalizarOperacion();
                }
                else
                {
                    MostrarError("No se pudo habilitar el cliente.");
                }
            }
            catch (Exception ex)
            {
                MostrarError($"No se pudo habilitar el cliente. {ex.Message}");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBuscar.Text.Trim(), out int codigo) || codigo <= 0)
            {
                MostrarAdvertencia("Ingrese un código de cliente válido.", txtBuscar);
                return;
            }

            try
            {
                ClienteBO? cliente = bal.findById(codigo);

                if (cliente == null || cliente.codigo <= 0)
                {
                    dgvClientes.DataSource = null;
                    MessageBox.Show("No se encontró el cliente.", "Buscar cliente",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dgvClientes.DataSource = new List<ClienteBO> { cliente };
                dgvClientes.ClearSelection();
                indice = -1;
            }
            catch (Exception ex)
            {
                MostrarError($"No se pudo buscar el cliente. {ex.Message}");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            Listar();
        }

        private void chkMostrarTodos_CheckedChanged(object sender, EventArgs e)
        {
            Listar();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;

            if (indice >= 0 && dgvClientes.Rows[indice].DataBoundItem is ClienteBO cliente)
            {
                PrepararEdicion(cliente);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Habilitar(false);
            btnNuevo.Enabled = true;
            dgvClientes.ClearSelection();
            indice = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
