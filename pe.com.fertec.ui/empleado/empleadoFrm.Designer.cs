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
            chkEstado = new CheckBox();
            lblRelaciones = new Label();
            chkMostrarTodos = new CheckBox();
            dgvEmpleados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold | FontStyle.Italic);
            lblTitulo.Location = new Point(670, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(145, 40);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Empleado";
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Checked = true;
            chkEstado.CheckState = CheckState.Checked;
            chkEstado.Location = new Point(1390, 211);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(61, 19);
            chkEstado.TabIndex = 18;
            chkEstado.Text = "Estado";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // lblRelaciones
            // 
            lblRelaciones.ForeColor = Color.DarkRed;
            lblRelaciones.Location = new Point(25, 244);
            lblRelaciones.Name = "lblRelaciones";
            lblRelaciones.Size = new Size(1350, 23);
            lblRelaciones.TabIndex = 19;
            // 
            // chkMostrarTodos
            // 
            chkMostrarTodos.AutoSize = true;
            chkMostrarTodos.Location = new Point(470, 278);
            chkMostrarTodos.Name = "chkMostrarTodos";
            chkMostrarTodos.Size = new Size(100, 19);
            chkMostrarTodos.TabIndex = 22;
            chkMostrarTodos.Text = "Mostrar todos";
            chkMostrarTodos.UseVisualStyleBackColor = true;
            chkMostrarTodos.CheckedChanged += chkMostrarTodos_CheckedChanged;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmpleados.BackgroundColor = Color.White;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(25, 375);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersVisible = false;
            dgvEmpleados.Size = new Size(1425, 420);
            dgvEmpleados.TabIndex = 30;
            dgvEmpleados.CellClick += dgvEmpleados_CellClick;
            // 
            // empleadoFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(1480, 825);
            Controls.Add(lblTitulo);
            Controls.Add(chkEstado);
            Controls.Add(lblRelaciones);
            Controls.Add(chkMostrarTodos);
            Controls.Add(dgvEmpleados);
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
