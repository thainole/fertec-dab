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
            lblCodigo = new Label();
            lblNombre = new Label();
            lblApellidoPaterno = new Label();
            lblApellidoMaterno = new Label();
            lblTipoDocumento = new Label();
            lblNumeroDocumento = new Label();
            lblSexo = new Label();
            lblDistrito = new Label();
            lblRol = new Label();
            lblFechaNacimiento = new Label();
            lblFechaIngreso = new Label();
            lblDireccion = new Label();
            lblTelefono = new Label();
            lblCelular = new Label();
            lblCorreo = new Label();
            lblUsuario = new Label();
            lblClave = new Label();
            lblSueldo = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtApellidoPaterno = new TextBox();
            txtApellidoMaterno = new TextBox();
            cboTipoDocumento = new ComboBox();
            txtNumeroDocumento = new TextBox();
            cboSexo = new ComboBox();
            cboDistrito = new ComboBox();
            cboRol = new ComboBox();
            dtpFechaNacimiento = new DateTimePicker();
            dtpFechaIngreso = new DateTimePicker();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtCelular = new TextBox();
            txtCorreo = new TextBox();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            txtSueldo = new TextBox();
            chkEstado = new CheckBox();
            lblTipoDocumentoActual = new Label();
            lblSexoActual = new Label();
            lblDistritoActual = new Label();
            lblRolActual = new Label();
            lblRelaciones = new Label();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnMostrar = new Button();
            chkMostrarTodos = new CheckBox();
            btnNuevo = new Button();
            btnRegistrar = new Button();
            btnActualizar = new Button();
            btnInhabilitar = new Button();
            btnHabilitar = new Button();
            btnCancelar = new Button();
            btnSalir = new Button();
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

            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(25, 67);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(125, 67);
            lblNombre.Name = "lblNombre";
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombres";
            lblApellidoPaterno.AutoSize = true;
            lblApellidoPaterno.Location = new Point(365, 67);
            lblApellidoPaterno.Name = "lblApellidoPaterno";
            lblApellidoPaterno.TabIndex = 0;
            lblApellidoPaterno.Text = "Apellido paterno";
            lblApellidoMaterno.AutoSize = true;
            lblApellidoMaterno.Location = new Point(565, 67);
            lblApellidoMaterno.Name = "lblApellidoMaterno";
            lblApellidoMaterno.TabIndex = 0;
            lblApellidoMaterno.Text = "Apellido materno";
            lblTipoDocumento.AutoSize = true;
            lblTipoDocumento.Location = new Point(25, 116);
            lblTipoDocumento.Name = "lblTipoDocumento";
            lblTipoDocumento.TabIndex = 0;
            lblTipoDocumento.Text = "Tipo documento";
            lblNumeroDocumento.AutoSize = true;
            lblNumeroDocumento.Location = new Point(245, 116);
            lblNumeroDocumento.Name = "lblNumeroDocumento";
            lblNumeroDocumento.TabIndex = 0;
            lblNumeroDocumento.Text = "Número documento";
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(415, 116);
            lblSexo.Name = "lblSexo";
            lblSexo.TabIndex = 0;
            lblSexo.Text = "Sexo";
            lblDistrito.AutoSize = true;
            lblDistrito.Location = new Point(575, 116);
            lblDistrito.Name = "lblDistrito";
            lblDistrito.TabIndex = 0;
            lblDistrito.Text = "Distrito";
            lblRol.AutoSize = true;
            lblRol.Location = new Point(785, 116);
            lblRol.Name = "lblRol";
            lblRol.TabIndex = 0;
            lblRol.Text = "Rol";
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(985, 116);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.TabIndex = 0;
            lblFechaNacimiento.Text = "Fecha de nacimiento";
            lblFechaIngreso.AutoSize = true;
            lblFechaIngreso.Location = new Point(1190, 116);
            lblFechaIngreso.Name = "lblFechaIngreso";
            lblFechaIngreso.TabIndex = 0;
            lblFechaIngreso.Text = "Fecha de ingreso";
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(25, 191);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.TabIndex = 0;
            lblDireccion.Text = "Dirección";
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(385, 191);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.TabIndex = 0;
            lblTelefono.Text = "Teléfono";
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(535, 191);
            lblCelular.Name = "lblCelular";
            lblCelular.TabIndex = 0;
            lblCelular.Text = "Celular";
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(685, 191);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.TabIndex = 0;
            lblCorreo.Text = "Correo";
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(935, 191);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            lblClave.AutoSize = true;
            lblClave.Location = new Point(1105, 191);
            lblClave.Name = "lblClave";
            lblClave.TabIndex = 0;
            lblClave.Text = "Contraseña";
            lblSueldo.AutoSize = true;
            lblSueldo.Location = new Point(1275, 191);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.TabIndex = 0;
            lblSueldo.Text = "Sueldo";

            txtCodigo.BackColor = SystemColors.ControlLight;
            txtCodigo.Location = new Point(25, 85);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(80, 23);
            txtCodigo.TabIndex = 0;
            txtNombre.Location = new Point(125, 85);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(220, 23);
            txtNombre.TabIndex = 1;
            txtApellidoPaterno.Location = new Point(365, 85);
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(180, 23);
            txtApellidoPaterno.TabIndex = 2;
            txtApellidoMaterno.Location = new Point(565, 85);
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(180, 23);
            txtApellidoMaterno.TabIndex = 3;
            cboTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoDocumento.FormattingEnabled = true;
            cboTipoDocumento.Location = new Point(25, 134);
            cboTipoDocumento.Name = "cboTipoDocumento";
            cboTipoDocumento.Size = new Size(200, 23);
            cboTipoDocumento.TabIndex = 4;
            txtNumeroDocumento.Location = new Point(245, 134);
            txtNumeroDocumento.Name = "txtNumeroDocumento";
            txtNumeroDocumento.Size = new Size(150, 23);
            txtNumeroDocumento.TabIndex = 5;
            cboSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSexo.FormattingEnabled = true;
            cboSexo.Location = new Point(415, 134);
            cboSexo.Name = "cboSexo";
            cboSexo.Size = new Size(140, 23);
            cboSexo.TabIndex = 6;
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(575, 134);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(190, 23);
            cboDistrito.TabIndex = 7;
            cboRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRol.FormattingEnabled = true;
            cboRol.Location = new Point(785, 134);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(180, 23);
            cboRol.TabIndex = 8;
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(985, 134);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(185, 23);
            dtpFechaNacimiento.TabIndex = 9;
            dtpFechaIngreso.Format = DateTimePickerFormat.Short;
            dtpFechaIngreso.Location = new Point(1190, 134);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(185, 23);
            dtpFechaIngreso.TabIndex = 10;
            txtDireccion.Location = new Point(25, 209);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(340, 23);
            txtDireccion.TabIndex = 11;
            txtTelefono.Location = new Point(385, 209);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(130, 23);
            txtTelefono.TabIndex = 12;
            txtCelular.Location = new Point(535, 209);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(130, 23);
            txtCelular.TabIndex = 13;
            txtCorreo.Location = new Point(685, 209);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(230, 23);
            txtCorreo.TabIndex = 14;
            txtUsuario.Location = new Point(935, 209);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(150, 23);
            txtUsuario.TabIndex = 15;
            txtClave.Location = new Point(1105, 209);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(150, 23);
            txtClave.TabIndex = 16;
            txtClave.UseSystemPasswordChar = true;
            txtSueldo.Location = new Point(1275, 209);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(100, 23);
            txtSueldo.TabIndex = 17;
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

            lblTipoDocumentoActual.AutoSize = true;
            lblTipoDocumentoActual.ForeColor = Color.DimGray;
            lblTipoDocumentoActual.Location = new Point(25, 161);
            lblTipoDocumentoActual.Name = "lblTipoDocumentoActual";
            lblTipoDocumentoActual.TabIndex = 0;
            lblTipoDocumentoActual.Text = "";
            lblSexoActual.AutoSize = true;
            lblSexoActual.ForeColor = Color.DimGray;
            lblSexoActual.Location = new Point(415, 161);
            lblSexoActual.Name = "lblSexoActual";
            lblSexoActual.TabIndex = 0;
            lblSexoActual.Text = "";
            lblDistritoActual.AutoSize = true;
            lblDistritoActual.ForeColor = Color.DimGray;
            lblDistritoActual.Location = new Point(575, 161);
            lblDistritoActual.Name = "lblDistritoActual";
            lblDistritoActual.TabIndex = 0;
            lblDistritoActual.Text = "";
            lblRolActual.AutoSize = true;
            lblRolActual.ForeColor = Color.DimGray;
            lblRolActual.Location = new Point(785, 161);
            lblRolActual.Name = "lblRolActual";
            lblRolActual.TabIndex = 0;
            lblRolActual.Text = "";

            lblRelaciones.AutoSize = false;
            lblRelaciones.ForeColor = Color.DarkRed;
            lblRelaciones.Location = new Point(25, 244);
            lblRelaciones.Name = "lblRelaciones";
            lblRelaciones.Size = new Size(1350, 23);
            lblRelaciones.TabIndex = 19;

            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(25, 278);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar por código";
            txtBuscar.Location = new Point(140, 275);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(110, 23);
            txtBuscar.TabIndex = 19;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(260, 273);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(90, 32);
            btnBuscar.TabIndex = 20;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            btnMostrar.FlatStyle = FlatStyle.Flat;
            btnMostrar.Location = new Point(360, 273);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(90, 32);
            btnMostrar.TabIndex = 21;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;

            chkMostrarTodos.AutoSize = true;
            chkMostrarTodos.Location = new Point(470, 278);
            chkMostrarTodos.Name = "chkMostrarTodos";
            chkMostrarTodos.Size = new Size(96, 19);
            chkMostrarTodos.TabIndex = 22;
            chkMostrarTodos.Text = "Mostrar todos";
            chkMostrarTodos.UseVisualStyleBackColor = true;
            chkMostrarTodos.CheckedChanged += chkMostrarTodos_CheckedChanged;

            btnNuevo.BackColor = Color.FromArgb(0, 123, 255);
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(555, 321);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(105, 32);
            btnNuevo.TabIndex = 23;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            btnRegistrar.BackColor = Color.FromArgb(40, 167, 69);
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(670, 321);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(105, 32);
            btnRegistrar.TabIndex = 24;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            btnActualizar.BackColor = Color.FromArgb(255, 193, 7);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Location = new Point(785, 321);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(105, 32);
            btnActualizar.TabIndex = 25;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            btnInhabilitar.BackColor = Color.FromArgb(220, 53, 69);
            btnInhabilitar.FlatStyle = FlatStyle.Flat;
            btnInhabilitar.ForeColor = Color.White;
            btnInhabilitar.Location = new Point(900, 321);
            btnInhabilitar.Name = "btnInhabilitar";
            btnInhabilitar.Size = new Size(105, 32);
            btnInhabilitar.TabIndex = 26;
            btnInhabilitar.Text = "Inhabilitar";
            btnInhabilitar.UseVisualStyleBackColor = false;
            btnInhabilitar.Click += btnInhabilitar_Click;
            btnHabilitar.BackColor = Color.FromArgb(23, 162, 184);
            btnHabilitar.FlatStyle = FlatStyle.Flat;
            btnHabilitar.ForeColor = Color.White;
            btnHabilitar.Location = new Point(1015, 321);
            btnHabilitar.Name = "btnHabilitar";
            btnHabilitar.Size = new Size(105, 32);
            btnHabilitar.TabIndex = 27;
            btnHabilitar.Text = "Habilitar";
            btnHabilitar.UseVisualStyleBackColor = false;
            btnHabilitar.Click += btnHabilitar_Click;
            btnCancelar.BackColor = Color.FromArgb(108, 117, 125);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(1130, 321);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 32);
            btnCancelar.TabIndex = 28;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            btnSalir.BackColor = Color.FromArgb(52, 58, 64);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(1245, 321);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(105, 32);
            btnSalir.TabIndex = 29;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
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
            dgvEmpleados.TabIndex = 30;
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
