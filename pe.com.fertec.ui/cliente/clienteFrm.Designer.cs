namespace pe.com.fertec.ui
{
    partial class clienteFrm
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtApellidoPaterno = new TextBox();
            txtApellidoMaterno = new TextBox();
            cboTipoDocumento = new ComboBox();
            txtNumeroDocumento = new TextBox();
            cboSexo = new ComboBox();
            cboDistrito = new ComboBox();
            lblTipoDocumentoActual = new Label();
            lblSexoActual = new Label();
            lblDistritoActual = new Label();
            dtpFechaRegistro = new DateTimePicker();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtCelular = new TextBox();
            txtCorreo = new TextBox();
            chkEstado = new CheckBox();
            lblRelaciones = new Label();
            label15 = new Label();
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
            dgvClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            //
            // textBox1
            //
            textBox1.BackColor = SystemColors.MenuBar;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(620, 12);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(150, 39);
            textBox1.TabIndex = 0;
            textBox1.TabStop = false;
            textBox1.Text = "Cliente";
            textBox1.TextAlign = HorizontalAlignment.Center;
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Location = new Point(27, 70);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Código";
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Location = new Point(251, 70);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombres";
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Location = new Point(563, 70);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 3;
            label3.Text = "Apellido paterno";
            //
            // label4
            //
            label4.AutoSize = true;
            label4.Location = new Point(902, 70);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 4;
            label4.Text = "Apellido materno";
            //
            // label5
            //
            label5.AutoSize = true;
            label5.Location = new Point(27, 111);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 5;
            label5.Text = "Tipo documento";
            //
            // label6
            //
            label6.AutoSize = true;
            label6.Location = new Point(371, 111);
            label6.Name = "label6";
            label6.Size = new Size(110, 15);
            label6.TabIndex = 6;
            label6.Text = "Número documento";
            //
            // label7
            //
            label7.AutoSize = true;
            label7.Location = new Point(704, 111);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 7;
            label7.Text = "Sexo";
            //
            // label8
            //
            label8.AutoSize = true;
            label8.Location = new Point(1010, 111);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 8;
            label8.Text = "Distrito";
            //
            // label9
            //
            label9.AutoSize = true;
            label9.Location = new Point(27, 174);
            label9.Name = "label9";
            label9.Size = new Size(101, 15);
            label9.TabIndex = 9;
            label9.Text = "Fecha de registro";
            //
            // label10
            //
            label10.AutoSize = true;
            label10.Location = new Point(302, 174);
            label10.Name = "label10";
            label10.Size = new Size(57, 15);
            label10.TabIndex = 10;
            label10.Text = "Dirección";
            //
            // label11
            //
            label11.AutoSize = true;
            label11.Location = new Point(846, 174);
            label11.Name = "label11";
            label11.Size = new Size(52, 15);
            label11.TabIndex = 11;
            label11.Text = "Teléfono";
            //
            // label12
            //
            label12.AutoSize = true;
            label12.Location = new Point(1083, 174);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 12;
            label12.Text = "Celular";
            //
            // label13
            //
            label13.AutoSize = true;
            label13.Location = new Point(27, 215);
            label13.Name = "label13";
            label13.Size = new Size(43, 15);
            label13.TabIndex = 13;
            label13.Text = "Correo";
            //
            // label14
            //
            label14.AutoSize = true;
            label14.Location = new Point(515, 215);
            label14.Name = "label14";
            label14.Size = new Size(42, 15);
            label14.TabIndex = 14;
            label14.Text = "Estado";
            //
            // txtCodigo
            //
            txtCodigo.Location = new Point(91, 66);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(130, 23);
            txtCodigo.TabIndex = 15;
            //
            // txtNombre
            //
            txtNombre.Location = new Point(320, 66);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(214, 23);
            txtNombre.TabIndex = 16;
            //
            // txtApellidoPaterno
            //
            txtApellidoPaterno.Location = new Point(672, 66);
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(200, 23);
            txtApellidoPaterno.TabIndex = 17;
            //
            // txtApellidoMaterno
            //
            txtApellidoMaterno.Location = new Point(1015, 66);
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(337, 23);
            txtApellidoMaterno.TabIndex = 18;
            //
            // cboTipoDocumento
            //
            cboTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoDocumento.FormattingEnabled = true;
            cboTipoDocumento.Location = new Point(134, 107);
            cboTipoDocumento.Name = "cboTipoDocumento";
            cboTipoDocumento.Size = new Size(214, 23);
            cboTipoDocumento.TabIndex = 19;
            //
            // txtNumeroDocumento
            //
            txtNumeroDocumento.Location = new Point(494, 107);
            txtNumeroDocumento.Name = "txtNumeroDocumento";
            txtNumeroDocumento.Size = new Size(180, 23);
            txtNumeroDocumento.TabIndex = 20;
            //
            // cboSexo
            //
            cboSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSexo.FormattingEnabled = true;
            cboSexo.Location = new Point(749, 107);
            cboSexo.Name = "cboSexo";
            cboSexo.Size = new Size(214, 23);
            cboSexo.TabIndex = 21;
            //
            // cboDistrito
            //
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(1068, 107);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(284, 23);
            cboDistrito.TabIndex = 22;
            //
            // lblTipoDocumentoActual
            //
            lblTipoDocumentoActual.AutoSize = true;
            lblTipoDocumentoActual.ForeColor = Color.DimGray;
            lblTipoDocumentoActual.Location = new Point(134, 134);
            lblTipoDocumentoActual.Name = "lblTipoDocumentoActual";
            lblTipoDocumentoActual.Size = new Size(0, 15);
            lblTipoDocumentoActual.TabIndex = 23;
            //
            // lblSexoActual
            //
            lblSexoActual.AutoSize = true;
            lblSexoActual.ForeColor = Color.DimGray;
            lblSexoActual.Location = new Point(749, 134);
            lblSexoActual.Name = "lblSexoActual";
            lblSexoActual.Size = new Size(0, 15);
            lblSexoActual.TabIndex = 24;
            //
            // lblDistritoActual
            //
            lblDistritoActual.AutoSize = true;
            lblDistritoActual.ForeColor = Color.DimGray;
            lblDistritoActual.Location = new Point(1068, 134);
            lblDistritoActual.Name = "lblDistritoActual";
            lblDistritoActual.Size = new Size(0, 15);
            lblDistritoActual.TabIndex = 25;
            //
            // dtpFechaRegistro
            //
            dtpFechaRegistro.Format = DateTimePickerFormat.Short;
            dtpFechaRegistro.Location = new Point(141, 170);
            dtpFechaRegistro.Name = "dtpFechaRegistro";
            dtpFechaRegistro.Size = new Size(130, 23);
            dtpFechaRegistro.TabIndex = 26;
            //
            // txtDireccion
            //
            txtDireccion.Location = new Point(372, 170);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(444, 23);
            txtDireccion.TabIndex = 27;
            //
            // txtTelefono
            //
            txtTelefono.Location = new Point(911, 170);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(139, 23);
            txtTelefono.TabIndex = 28;
            //
            // txtCelular
            //
            txtCelular.Location = new Point(1139, 170);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(213, 23);
            txtCelular.TabIndex = 29;
            //
            // txtCorreo
            //
            txtCorreo.Location = new Point(91, 211);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(390, 23);
            txtCorreo.TabIndex = 30;
            //
            // chkEstado
            //
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(573, 214);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(59, 19);
            chkEstado.TabIndex = 31;
            chkEstado.Text = "Activo";
            chkEstado.UseVisualStyleBackColor = true;
            //
            // lblRelaciones
            //
            lblRelaciones.AutoSize = true;
            lblRelaciones.ForeColor = Color.DarkOrange;
            lblRelaciones.Location = new Point(27, 243);
            lblRelaciones.Name = "lblRelaciones";
            lblRelaciones.Size = new Size(0, 15);
            lblRelaciones.TabIndex = 32;
            //
            // label15
            //
            label15.AutoSize = true;
            label15.Location = new Point(27, 270);
            label15.Name = "label15";
            label15.Size = new Size(84, 15);
            label15.TabIndex = 33;
            label15.Text = "Buscar código";
            //
            // txtBuscar
            //
            txtBuscar.Location = new Point(117, 266);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(139, 23);
            txtBuscar.TabIndex = 34;
            //
            // btnBuscar
            //
            btnBuscar.Location = new Point(271, 265);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 25);
            btnBuscar.TabIndex = 35;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            //
            // btnMostrar
            //
            btnMostrar.Location = new Point(356, 265);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 25);
            btnMostrar.TabIndex = 36;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            //
            // chkMostrarTodos
            //
            chkMostrarTodos.AutoSize = true;
            chkMostrarTodos.Location = new Point(451, 269);
            chkMostrarTodos.Name = "chkMostrarTodos";
            chkMostrarTodos.Size = new Size(107, 19);
            chkMostrarTodos.TabIndex = 37;
            chkMostrarTodos.Text = "Mostrar todos";
            chkMostrarTodos.UseVisualStyleBackColor = true;
            chkMostrarTodos.CheckedChanged += chkMostrarTodos_CheckedChanged;
            //
            // btnNuevo
            //
            btnNuevo.Location = new Point(27, 306);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(90, 27);
            btnNuevo.TabIndex = 38;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            //
            // btnRegistrar
            //
            btnRegistrar.Location = new Point(133, 306);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(90, 27);
            btnRegistrar.TabIndex = 39;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            //
            // btnActualizar
            //
            btnActualizar.Location = new Point(239, 306);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(90, 27);
            btnActualizar.TabIndex = 40;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            //
            // btnInhabilitar
            //
            btnInhabilitar.Location = new Point(345, 306);
            btnInhabilitar.Name = "btnInhabilitar";
            btnInhabilitar.Size = new Size(90, 27);
            btnInhabilitar.TabIndex = 41;
            btnInhabilitar.Text = "Inhabilitar";
            btnInhabilitar.UseVisualStyleBackColor = true;
            btnInhabilitar.Click += btnInhabilitar_Click;
            //
            // btnHabilitar
            //
            btnHabilitar.Location = new Point(451, 306);
            btnHabilitar.Name = "btnHabilitar";
            btnHabilitar.Size = new Size(90, 27);
            btnHabilitar.TabIndex = 42;
            btnHabilitar.Text = "Habilitar";
            btnHabilitar.UseVisualStyleBackColor = true;
            btnHabilitar.Click += btnHabilitar_Click;
            //
            // btnCancelar
            //
            btnCancelar.Location = new Point(557, 306);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 27);
            btnCancelar.TabIndex = 43;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            //
            // btnSalir
            //
            btnSalir.Location = new Point(1262, 306);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(90, 27);
            btnSalir.TabIndex = 44;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            //
            // dgvClientes
            //
            dgvClientes.BackgroundColor = SystemColors.Window;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(27, 349);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(1325, 324);
            dgvClientes.TabIndex = 45;
            dgvClientes.CellClick += dgvClientes_CellClick;
            //
            // clienteFrm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(1380, 700);
            Controls.Add(dgvClientes);
            Controls.Add(btnSalir);
            Controls.Add(btnCancelar);
            Controls.Add(btnHabilitar);
            Controls.Add(btnInhabilitar);
            Controls.Add(btnActualizar);
            Controls.Add(btnRegistrar);
            Controls.Add(btnNuevo);
            Controls.Add(chkMostrarTodos);
            Controls.Add(btnMostrar);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(label15);
            Controls.Add(lblRelaciones);
            Controls.Add(chkEstado);
            Controls.Add(txtCorreo);
            Controls.Add(txtCelular);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(dtpFechaRegistro);
            Controls.Add(lblDistritoActual);
            Controls.Add(lblSexoActual);
            Controls.Add(lblTipoDocumentoActual);
            Controls.Add(cboDistrito);
            Controls.Add(cboSexo);
            Controls.Add(txtNumeroDocumento);
            Controls.Add(cboTipoDocumento);
            Controls.Add(txtApellidoMaterno);
            Controls.Add(txtApellidoPaterno);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "clienteFrm";
            Text = "Cliente";
            Load += clienteFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtApellidoPaterno;
        private TextBox txtApellidoMaterno;
        private ComboBox cboTipoDocumento;
        private TextBox txtNumeroDocumento;
        private ComboBox cboSexo;
        private ComboBox cboDistrito;
        private Label lblTipoDocumentoActual;
        private Label lblSexoActual;
        private Label lblDistritoActual;
        private DateTimePicker dtpFechaRegistro;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtCelular;
        private TextBox txtCorreo;
        private CheckBox chkEstado;
        private Label lblRelaciones;
        private Label label15;
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
        private DataGridView dgvClientes;
    }
}
