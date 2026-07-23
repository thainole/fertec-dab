namespace pe.com.fertec.ui
{
    partial class empleadoFrm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblCodigo = CrearEtiqueta("Código", 25, 67);
            lblNombre = CrearEtiqueta("Nombres", 125, 67);
            lblApellidoPaterno = CrearEtiqueta("Apellido paterno", 365, 67);
            lblApellidoMaterno = CrearEtiqueta("Apellido materno", 565, 67);
            lblTipoDocumento = CrearEtiqueta("Tipo documento", 25, 116);
            lblNumeroDocumento = CrearEtiqueta("Número documento", 245, 116);
            lblSexo = CrearEtiqueta("Sexo", 415, 116);
            lblDistrito = CrearEtiqueta("Distrito", 575, 116);
            lblRol = CrearEtiqueta("Rol", 785, 116);
            lblFechaNacimiento = CrearEtiqueta("Fecha de nacimiento", 985, 116);
            lblFechaIngreso = CrearEtiqueta("Fecha de ingreso", 1190, 116);
            lblDireccion = CrearEtiqueta("Dirección", 25, 191);
            lblTelefono = CrearEtiqueta("Teléfono", 385, 191);
            lblCelular = CrearEtiqueta("Celular", 535, 191);
            lblCorreo = CrearEtiqueta("Correo", 685, 191);
            lblUsuario = CrearEtiqueta("Usuario", 935, 191);
            lblClave = CrearEtiqueta("Contraseña", 1105, 191);
            lblSueldo = CrearEtiqueta("Sueldo", 1275, 191);

            txtCodigo = CrearTexto(25, 85, 80);
            txtNombre = CrearTexto(125, 85, 220);
            txtApellidoPaterno = CrearTexto(365, 85, 180);
            txtApellidoMaterno = CrearTexto(565, 85, 180);
            cboTipoDocumento = CrearCombo(25, 134, 200);
            txtNumeroDocumento = CrearTexto(245, 134, 150);
            cboSexo = CrearCombo(415, 134, 140);
            cboDistrito = CrearCombo(575, 134, 190);
            cboRol = CrearCombo(785, 134, 180);
            dtpFechaNacimiento = CrearFecha(985, 134, 185);
            dtpFechaIngreso = CrearFecha(1190, 134, 185);
            txtDireccion = CrearTexto(25, 209, 340);
            txtTelefono = CrearTexto(385, 209, 130);
            txtCelular = CrearTexto(535, 209, 130);
            txtCorreo = CrearTexto(685, 209, 230);
            txtUsuario = CrearTexto(935, 209, 150);
            txtClave = CrearTexto(1105, 209, 150);
            txtSueldo = CrearTexto(1275, 209, 100);
            chkEstado = new CheckBox();
            lblTipoDocumentoActual = CrearEtiqueta("", 25, 161);
            lblSexoActual = CrearEtiqueta("", 415, 161);
            lblDistritoActual = CrearEtiqueta("", 575, 161);
            lblRolActual = CrearEtiqueta("", 785, 161);
            lblRelaciones = new Label();
            lblBuscar = CrearEtiqueta("Buscar por código", 25, 278);
            txtBuscar = CrearTexto(140, 275, 110);
            btnBuscar = CrearBoton("Buscar", 260, 273, 90);
            btnMostrar = CrearBoton("Mostrar", 360, 273, 90);
            chkMostrarTodos = new CheckBox();
            btnNuevo = CrearBoton("Nuevo", 555, 321, 105);
            btnRegistrar = CrearBoton("Registrar", 670, 321, 105);
            btnActualizar = CrearBoton("Actualizar", 785, 321, 105);
            btnInhabilitar = CrearBoton("Inhabilitar", 900, 321, 105);
            btnHabilitar = CrearBoton("Habilitar", 1015, 321, 105);
            btnCancelar = CrearBoton("Cancelar", 1130, 321, 105);
            btnSalir = CrearBoton("Salir", 1245, 321, 105);
            dgvEmpleados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();

            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font(
                "Segoe UI Semibold", 21.75F, FontStyle.Bold | FontStyle.Italic);
            lblTitulo.Location = new Point(670, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(145, 40);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Empleado";

            txtCodigo.BackColor = SystemColors.ControlLight;
            txtCodigo.Name = "txtCodigo";
            txtNombre.Name = "txtNombre";
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            cboTipoDocumento.Name = "cboTipoDocumento";
            txtNumeroDocumento.Name = "txtNumeroDocumento";
            cboSexo.Name = "cboSexo";
            cboDistrito.Name = "cboDistrito";
            cboRol.Name = "cboRol";
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            txtDireccion.Name = "txtDireccion";
            txtTelefono.Name = "txtTelefono";
            txtCelular.Name = "txtCelular";
            txtCorreo.Name = "txtCorreo";
            txtUsuario.Name = "txtUsuario";
            txtClave.Name = "txtClave";
            txtClave.UseSystemPasswordChar = true;
            txtSueldo.Name = "txtSueldo";
            txtSueldo.TextAlign = HorizontalAlignment.Right;

            chkEstado.AutoSize = true;
            chkEstado.Checked = true;
            chkEstado.CheckState = CheckState.Checked;
            chkEstado.Location = new Point(1390, 211);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(61, 19);
            chkEstado.TabIndex = 18;
            chkEstado.Text = "Estado";
            chkEstado.UseVisualStyleBackColor = true;

            lblTipoDocumentoActual.ForeColor = Color.DimGray;
            lblTipoDocumentoActual.Name = "lblTipoDocumentoActual";
            lblSexoActual.ForeColor = Color.DimGray;
            lblSexoActual.Name = "lblSexoActual";
            lblDistritoActual.ForeColor = Color.DimGray;
            lblDistritoActual.Name = "lblDistritoActual";
            lblRolActual.ForeColor = Color.DimGray;
            lblRolActual.Name = "lblRolActual";

            lblRelaciones.AutoSize = false;
            lblRelaciones.ForeColor = Color.DarkRed;
            lblRelaciones.Location = new Point(25, 244);
            lblRelaciones.Name = "lblRelaciones";
            lblRelaciones.Size = new Size(1350, 23);
            lblRelaciones.TabIndex = 19;

            txtBuscar.Name = "txtBuscar";
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Click += btnBuscar_Click;
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Click += btnMostrar_Click;

            chkMostrarTodos.AutoSize = true;
            chkMostrarTodos.Location = new Point(470, 278);
            chkMostrarTodos.Name = "chkMostrarTodos";
            chkMostrarTodos.Size = new Size(96, 19);
            chkMostrarTodos.TabIndex = 23;
            chkMostrarTodos.Text = "Mostrar todos";
            chkMostrarTodos.UseVisualStyleBackColor = true;
            chkMostrarTodos.CheckedChanged += chkMostrarTodos_CheckedChanged;

            btnNuevo.BackColor = Color.FromArgb(0, 123, 255);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Click += btnNuevo_Click;
            btnRegistrar.BackColor = Color.FromArgb(40, 167, 69);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Click += btnRegistrar_Click;
            btnActualizar.BackColor = Color.FromArgb(255, 193, 7);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Click += btnActualizar_Click;
            btnInhabilitar.BackColor = Color.FromArgb(220, 53, 69);
            btnInhabilitar.ForeColor = Color.White;
            btnInhabilitar.Name = "btnInhabilitar";
            btnInhabilitar.Click += btnInhabilitar_Click;
            btnHabilitar.BackColor = Color.FromArgb(23, 162, 184);
            btnHabilitar.ForeColor = Color.White;
            btnHabilitar.Name = "btnHabilitar";
            btnHabilitar.Click += btnHabilitar_Click;
            btnCancelar.BackColor = Color.FromArgb(108, 117, 125);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Click += btnCancelar_Click;
            btnSalir.BackColor = Color.FromArgb(52, 58, 64);
            btnSalir.ForeColor = Color.White;
            btnSalir.Name = "btnSalir";
            btnSalir.Click += btnSalir_Click;

            dgvEmpleados.Anchor =
                AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left |
                AnchorStyles.Right;
            dgvEmpleados.BackgroundColor = Color.White;
            dgvEmpleados.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(25, 375);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersVisible = false;
            dgvEmpleados.Size = new Size(1425, 420);
            dgvEmpleados.TabIndex = 31;
            dgvEmpleados.CellClick += dgvEmpleados_CellClick;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(1480, 825);
            Controls.AddRange(new Control[]
            {
                lblTitulo,
                lblCodigo,
                lblNombre,
                lblApellidoPaterno,
                lblApellidoMaterno,
                lblTipoDocumento,
                lblNumeroDocumento,
                lblSexo,
                lblDistrito,
                lblRol,
                lblFechaNacimiento,
                lblFechaIngreso,
                lblDireccion,
                lblTelefono,
                lblCelular,
                lblCorreo,
                lblUsuario,
                lblClave,
                lblSueldo,
                txtCodigo,
                txtNombre,
                txtApellidoPaterno,
                txtApellidoMaterno,
                cboTipoDocumento,
                txtNumeroDocumento,
                cboSexo,
                cboDistrito,
                cboRol,
                dtpFechaNacimiento,
                dtpFechaIngreso,
                txtDireccion,
                txtTelefono,
                txtCelular,
                txtCorreo,
                txtUsuario,
                txtClave,
                txtSueldo,
                chkEstado,
                lblTipoDocumentoActual,
                lblSexoActual,
                lblDistritoActual,
                lblRolActual,
                lblRelaciones,
                lblBuscar,
                txtBuscar,
                btnBuscar,
                btnMostrar,
                chkMostrarTodos,
                btnNuevo,
                btnRegistrar,
                btnActualizar,
                btnInhabilitar,
                btnHabilitar,
                btnCancelar,
                btnSalir,
                dgvEmpleados
            });
            MinimumSize = new Size(1200, 700);
            Name = "empleadoFrm";
            Text = "Empleado";
            Load += empleadoFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private static Label CrearEtiqueta(string texto, int x, int y)
        {
            return new Label
            {
                AutoSize = true,
                Location = new Point(x, y),
                Text = texto
            };
        }

        private static TextBox CrearTexto(int x, int y, int ancho)
        {
            return new TextBox
            {
                Location = new Point(x, y),
                Size = new Size(ancho, 23)
            };
        }

        private static ComboBox CrearCombo(int x, int y, int ancho)
        {
            return new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                FormattingEnabled = true,
                Location = new Point(x, y),
                Size = new Size(ancho, 23)
            };
        }

        private static DateTimePicker CrearFecha(int x, int y, int ancho)
        {
            return new DateTimePicker
            {
                Format = DateTimePickerFormat.Short,
                Location = new Point(x, y),
                Size = new Size(ancho, 23)
            };
        }

        private static Button CrearBoton(string texto, int x, int y, int ancho)
        {
            return new Button
            {
                FlatStyle = FlatStyle.Flat,
                Location = new Point(x, y),
                Size = new Size(ancho, 32),
                Text = texto,
                UseVisualStyleBackColor = false
            };
        }

        #endregion

        private Label lblTitulo;
        private Label lblCodigo;
        private Label lblNombre;
        private Label lblApellidoPaterno;
        private Label lblApellidoMaterno;
        private Label lblTipoDocumento;
        private Label lblNumeroDocumento;
        private Label lblSexo;
        private Label lblDistrito;
        private Label lblRol;
        private Label lblFechaNacimiento;
        private Label lblFechaIngreso;
        private Label lblDireccion;
        private Label lblTelefono;
        private Label lblCelular;
        private Label lblCorreo;
        private Label lblUsuario;
        private Label lblClave;
        private Label lblSueldo;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtApellidoPaterno;
        private TextBox txtApellidoMaterno;
        private ComboBox cboTipoDocumento;
        private TextBox txtNumeroDocumento;
        private ComboBox cboSexo;
        private ComboBox cboDistrito;
        private ComboBox cboRol;
        private DateTimePicker dtpFechaNacimiento;
        private DateTimePicker dtpFechaIngreso;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtCelular;
        private TextBox txtCorreo;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private TextBox txtSueldo;
        private CheckBox chkEstado;
        private Label lblTipoDocumentoActual;
        private Label lblSexoActual;
        private Label lblDistritoActual;
        private Label lblRolActual;
        private Label lblRelaciones;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnMostrar;
        private CheckBox chkMostrarTodos;
        private Button btnNuevo;
        private Button btnRegistrar;
        private Button btnActualizar;
        private Button btnInhabilitar;
        private Button btnHabilitar;
        private Button btnCancelar;
        private Button btnSalir;
        private DataGridView dgvEmpleados;
    }
}
