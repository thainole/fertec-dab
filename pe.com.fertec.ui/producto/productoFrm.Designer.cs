namespace pe.com.fertec.ui
{
    partial class productoFrm
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
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            dtpFechaRegistro = new DateTimePicker();
            chkEstado = new CheckBox();
            cboCategoria = new ComboBox();
            cboMarca = new ComboBox();
            lblCategoriaActual = new Label();
            lblMarcaActual = new Label();
            lblRelaciones = new Label();
            btnNuevo = new Button();
            btnRegistrar = new Button();
            btnActualizar = new Button();
            btnInhabilitar = new Button();
            btnHabilitar = new Button();
            btnCancelar = new Button();
            btnSalir = new Button();
            label10 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnMostrar = new Button();
            chkMostrarTodos = new CheckBox();
            dgvProductos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            //
            // textBox1
            //
            textBox1.BackColor = SystemColors.MenuBar;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(505, 12);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(150, 39);
            textBox1.TabIndex = 0;
            textBox1.TabStop = false;
            textBox1.Text = "Producto";
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
            label2.Location = new Point(271, 70);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Location = new Point(581, 70);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 3;
            label3.Text = "Descripción";
            //
            // label4
            //
            label4.AutoSize = true;
            label4.Location = new Point(27, 111);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 4;
            label4.Text = "Precio";
            //
            // label5
            //
            label5.AutoSize = true;
            label5.Location = new Point(271, 111);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 5;
            label5.Text = "Stock";
            //
            // label6
            //
            label6.AutoSize = true;
            label6.Location = new Point(581, 111);
            label6.Name = "label6";
            label6.Size = new Size(101, 15);
            label6.TabIndex = 6;
            label6.Text = "Fecha de registro";
            //
            // label7
            //
            label7.AutoSize = true;
            label7.Location = new Point(27, 154);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 7;
            label7.Text = "Categoría";
            //
            // label8
            //
            label8.AutoSize = true;
            label8.Location = new Point(389, 154);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 8;
            label8.Text = "Marca";
            //
            // label9
            //
            label9.AutoSize = true;
            label9.Location = new Point(758, 154);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 9;
            label9.Text = "Estado";
            //
            // txtCodigo
            //
            txtCodigo.Location = new Point(91, 66);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(139, 23);
            txtCodigo.TabIndex = 10;
            //
            // txtNombre
            //
            txtNombre.Location = new Point(337, 66);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(214, 23);
            txtNombre.TabIndex = 11;
            //
            // txtDescripcion
            //
            txtDescripcion.Location = new Point(664, 66);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(473, 23);
            txtDescripcion.TabIndex = 12;
            //
            // txtPrecio
            //
            txtPrecio.Location = new Point(91, 107);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(139, 23);
            txtPrecio.TabIndex = 13;
            //
            // txtStock
            //
            txtStock.Location = new Point(337, 107);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(139, 23);
            txtStock.TabIndex = 14;
            //
            // dtpFechaRegistro
            //
            dtpFechaRegistro.Format = DateTimePickerFormat.Short;
            dtpFechaRegistro.Location = new Point(698, 107);
            dtpFechaRegistro.Name = "dtpFechaRegistro";
            dtpFechaRegistro.Size = new Size(139, 23);
            dtpFechaRegistro.TabIndex = 15;
            //
            // chkEstado
            //
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(816, 153);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(59, 19);
            chkEstado.TabIndex = 18;
            chkEstado.Text = "Activo";
            chkEstado.UseVisualStyleBackColor = true;
            //
            // cboCategoria
            //
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(91, 150);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(214, 23);
            cboCategoria.TabIndex = 16;
            //
            // cboMarca
            //
            cboMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMarca.FormattingEnabled = true;
            cboMarca.Location = new Point(445, 150);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(214, 23);
            cboMarca.TabIndex = 17;
            //
            // lblCategoriaActual
            //
            lblCategoriaActual.AutoSize = true;
            lblCategoriaActual.ForeColor = Color.DimGray;
            lblCategoriaActual.Location = new Point(91, 177);
            lblCategoriaActual.Name = "lblCategoriaActual";
            lblCategoriaActual.Size = new Size(0, 15);
            lblCategoriaActual.TabIndex = 19;
            //
            // lblMarcaActual
            //
            lblMarcaActual.AutoSize = true;
            lblMarcaActual.ForeColor = Color.DimGray;
            lblMarcaActual.Location = new Point(445, 177);
            lblMarcaActual.Name = "lblMarcaActual";
            lblMarcaActual.Size = new Size(0, 15);
            lblMarcaActual.TabIndex = 20;
            //
            // lblRelaciones
            //
            lblRelaciones.AutoSize = true;
            lblRelaciones.ForeColor = Color.DarkOrange;
            lblRelaciones.Location = new Point(27, 202);
            lblRelaciones.Name = "lblRelaciones";
            lblRelaciones.Size = new Size(0, 15);
            lblRelaciones.TabIndex = 21;
            //
            // btnNuevo
            //
            btnNuevo.Location = new Point(27, 257);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(90, 27);
            btnNuevo.TabIndex = 26;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            //
            // btnRegistrar
            //
            btnRegistrar.Location = new Point(133, 257);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(90, 27);
            btnRegistrar.TabIndex = 27;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            //
            // btnActualizar
            //
            btnActualizar.Location = new Point(239, 257);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(90, 27);
            btnActualizar.TabIndex = 28;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            //
            // btnInhabilitar
            //
            btnInhabilitar.Location = new Point(345, 257);
            btnInhabilitar.Name = "btnInhabilitar";
            btnInhabilitar.Size = new Size(90, 27);
            btnInhabilitar.TabIndex = 29;
            btnInhabilitar.Text = "Inhabilitar";
            btnInhabilitar.UseVisualStyleBackColor = true;
            btnInhabilitar.Click += btnInhabilitar_Click;
            //
            // btnHabilitar
            //
            btnHabilitar.Location = new Point(451, 257);
            btnHabilitar.Name = "btnHabilitar";
            btnHabilitar.Size = new Size(90, 27);
            btnHabilitar.TabIndex = 30;
            btnHabilitar.Text = "Habilitar";
            btnHabilitar.UseVisualStyleBackColor = true;
            btnHabilitar.Click += btnHabilitar_Click;
            //
            // btnCancelar
            //
            btnCancelar.Location = new Point(557, 257);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 27);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            //
            // btnSalir
            //
            btnSalir.Location = new Point(1047, 257);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(90, 27);
            btnSalir.TabIndex = 32;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            //
            // label10
            //
            label10.AutoSize = true;
            label10.Location = new Point(27, 226);
            label10.Name = "label10";
            label10.Size = new Size(84, 15);
            label10.TabIndex = 22;
            label10.Text = "Buscar código";
            //
            // txtBuscar
            //
            txtBuscar.Location = new Point(117, 222);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(139, 23);
            txtBuscar.TabIndex = 23;
            //
            // btnBuscar
            //
            btnBuscar.Location = new Point(271, 221);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 25);
            btnBuscar.TabIndex = 24;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            //
            // btnMostrar
            //
            btnMostrar.Location = new Point(356, 221);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 25);
            btnMostrar.TabIndex = 25;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            //
            // chkMostrarTodos
            //
            chkMostrarTodos.AutoSize = true;
            chkMostrarTodos.Location = new Point(451, 225);
            chkMostrarTodos.Name = "chkMostrarTodos";
            chkMostrarTodos.Size = new Size(107, 19);
            chkMostrarTodos.TabIndex = 25;
            chkMostrarTodos.Text = "Mostrar todos";
            chkMostrarTodos.UseVisualStyleBackColor = true;
            chkMostrarTodos.CheckedChanged += chkMostrarTodos_CheckedChanged;
            //
            // dgvProductos
            //
            dgvProductos.BackgroundColor = SystemColors.Window;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(27, 302);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(1110, 346);
            dgvProductos.TabIndex = 33;
            dgvProductos.CellClick += dgvProductos_CellClick;
            //
            // productoFrm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(1168, 672);
            Controls.Add(dgvProductos);
            Controls.Add(chkMostrarTodos);
            Controls.Add(btnMostrar);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(label10);
            Controls.Add(btnSalir);
            Controls.Add(btnCancelar);
            Controls.Add(btnHabilitar);
            Controls.Add(btnInhabilitar);
            Controls.Add(btnActualizar);
            Controls.Add(btnRegistrar);
            Controls.Add(btnNuevo);
            Controls.Add(lblRelaciones);
            Controls.Add(lblMarcaActual);
            Controls.Add(lblCategoriaActual);
            Controls.Add(cboMarca);
            Controls.Add(cboCategoria);
            Controls.Add(chkEstado);
            Controls.Add(dtpFechaRegistro);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
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
            Name = "productoFrm";
            Text = "Producto";
            Load += productoFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
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
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private DateTimePicker dtpFechaRegistro;
        private CheckBox chkEstado;
        private ComboBox cboCategoria;
        private ComboBox cboMarca;
        private Label lblCategoriaActual;
        private Label lblMarcaActual;
        private Label lblRelaciones;
        private Button btnNuevo;
        private Button btnRegistrar;
        private Button btnActualizar;
        private Button btnInhabilitar;
        private Button btnHabilitar;
        private Button btnCancelar;
        private Button btnSalir;
        private Label label10;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnMostrar;
        private CheckBox chkMostrarTodos;
        private DataGridView dgvProductos;
    }
}
