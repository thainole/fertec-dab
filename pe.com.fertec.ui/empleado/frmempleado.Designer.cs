namespace pe.com.fertec.ui.empleado
{
    partial class frmempleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtCod = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dtpFecNac = new DateTimePicker();
            dtpFecIng = new DateTimePicker();
            txtTel = new TextBox();
            txtDir = new TextBox();
            txtApeM = new TextBox();
            txtApeP = new TextBox();
            txtNom = new TextBox();
            label7 = new Label();
            txtNumDoc = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            dgvEmpleado = new DataGridView();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            txtCel = new TextBox();
            txtCor = new TextBox();
            txtUsu = new TextBox();
            txtCla = new TextBox();
            txtSue = new TextBox();
            chkEstado = new CheckBox();
            cboDistrito = new ComboBox();
            cboSexo = new ComboBox();
            cboTipoDocumento = new ComboBox();
            cboRol = new ComboBox();
            btnNuevo = new Button();
            btnRegistrar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnHabilitar = new Button();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleado).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun-ExtB", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(407, 9);
            label1.Name = "label1";
            label1.Size = new Size(462, 27);
            label1.TabIndex = 0;
            label1.Text = "Mantenimiento Cruzado-Empleado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 63);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Codigo:";
            // 
            // txtCod
            // 
            txtCod.Location = new Point(157, 55);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(123, 23);
            txtCod.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 100);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 3;
            label3.Text = "nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 133);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 4;
            label4.Text = "apellido paterno:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 178);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 5;
            label5.Text = "apellido materno:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 218);
            label6.Name = "label6";
            label6.Size = new Size(117, 15);
            label6.TabIndex = 6;
            label6.Text = "numero documento:";
            // 
            // dtpFecNac
            // 
            dtpFecNac.Location = new Point(157, 256);
            dtpFecNac.Name = "dtpFecNac";
            dtpFecNac.Size = new Size(218, 23);
            dtpFecNac.TabIndex = 7;
            dtpFecNac.ValueChanged += dtpFecNac_ValueChanged;
            // 
            // dtpFecIng
            // 
            dtpFecIng.Location = new Point(625, 170);
            dtpFecIng.Name = "dtpFecIng";
            dtpFecIng.Size = new Size(218, 23);
            dtpFecIng.TabIndex = 8;
            dtpFecIng.ValueChanged += dtpFecIng_ValueChanged;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(157, 347);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(218, 23);
            txtTel.TabIndex = 9;
            // 
            // txtDir
            // 
            txtDir.Location = new Point(157, 303);
            txtDir.Name = "txtDir";
            txtDir.Size = new Size(218, 23);
            txtDir.TabIndex = 10;
            // 
            // txtApeM
            // 
            txtApeM.Location = new Point(157, 170);
            txtApeM.Name = "txtApeM";
            txtApeM.Size = new Size(218, 23);
            txtApeM.TabIndex = 11;
            // 
            // txtApeP
            // 
            txtApeP.Location = new Point(157, 125);
            txtApeP.Name = "txtApeP";
            txtApeP.Size = new Size(218, 23);
            txtApeP.TabIndex = 12;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(157, 92);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(218, 23);
            txtNom.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 262);
            label7.Name = "label7";
            label7.Size = new Size(118, 15);
            label7.TabIndex = 14;
            label7.Text = "fecha de nacimiento:";
            // 
            // txtNumDoc
            // 
            txtNumDoc.Location = new Point(157, 210);
            txtNumDoc.Name = "txtNumDoc";
            txtNumDoc.Size = new Size(218, 23);
            txtNumDoc.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(37, 311);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 16;
            label8.Text = "direccion:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(44, 355);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 17;
            label9.Text = "Telefono:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(44, 390);
            label10.Name = "label10";
            label10.Size = new Size(47, 15);
            label10.TabIndex = 18;
            label10.Text = "Celular:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(47, 444);
            label11.Name = "label11";
            label11.Size = new Size(46, 15);
            label11.TabIndex = 19;
            label11.Text = "Correo:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(494, 63);
            label12.Name = "label12";
            label12.Size = new Size(50, 15);
            label12.TabIndex = 20;
            label12.Text = "Usuario:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(494, 95);
            label13.Name = "label13";
            label13.Size = new Size(39, 15);
            label13.TabIndex = 21;
            label13.Text = "Clave:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(494, 128);
            label14.Name = "label14";
            label14.Size = new Size(46, 15);
            label14.TabIndex = 22;
            label14.Text = "Sueldo:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(494, 173);
            label15.Name = "label15";
            label15.Size = new Size(99, 15);
            label15.TabIndex = 23;
            label15.Text = "Fecha de ingreso:";
            // 
            // dgvEmpleado
            // 
            dgvEmpleado.BackgroundColor = SystemColors.Control;
            dgvEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleado.Location = new Point(12, 481);
            dgvEmpleado.Name = "dgvEmpleado";
            dgvEmpleado.Size = new Size(1280, 341);
            dgvEmpleado.TabIndex = 24;
            dgvEmpleado.CellClick += dgvEmpleado_CellClick;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(495, 218);
            label16.Name = "label16";
            label16.Size = new Size(48, 15);
            label16.TabIndex = 25;
            label16.Text = "Distrito:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(494, 311);
            label17.Name = "label17";
            label17.Size = new Size(34, 15);
            label17.TabIndex = 26;
            label17.Text = "Sexo:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(494, 350);
            label18.Name = "label18";
            label18.Size = new Size(112, 15);
            label18.TabIndex = 27;
            label18.Text = "tipo de documento:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(495, 264);
            label19.Name = "label19";
            label19.Size = new Size(27, 15);
            label19.TabIndex = 28;
            label19.Text = "Rol:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(494, 398);
            label20.Name = "label20";
            label20.Size = new Size(45, 15);
            label20.TabIndex = 29;
            label20.Text = "Estado:";
            // 
            // txtCel
            // 
            txtCel.Location = new Point(157, 390);
            txtCel.Name = "txtCel";
            txtCel.Size = new Size(218, 23);
            txtCel.TabIndex = 30;
            // 
            // txtCor
            // 
            txtCor.Location = new Point(157, 436);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(218, 23);
            txtCor.TabIndex = 31;
            // 
            // txtUsu
            // 
            txtUsu.Location = new Point(625, 55);
            txtUsu.Name = "txtUsu";
            txtUsu.Size = new Size(218, 23);
            txtUsu.TabIndex = 32;
            // 
            // txtCla
            // 
            txtCla.Location = new Point(625, 87);
            txtCla.Name = "txtCla";
            txtCla.Size = new Size(218, 23);
            txtCla.TabIndex = 33;
            // 
            // txtSue
            // 
            txtSue.Location = new Point(625, 125);
            txtSue.Name = "txtSue";
            txtSue.Size = new Size(218, 23);
            txtSue.TabIndex = 34;
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(650, 397);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(71, 19);
            chkEstado.TabIndex = 37;
            chkEstado.Text = "Habilitar";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // cboDistrito
            // 
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(625, 215);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(218, 23);
            cboDistrito.TabIndex = 38;
            // 
            // cboSexo
            // 
            cboSexo.FormattingEnabled = true;
            cboSexo.Location = new Point(625, 303);
            cboSexo.Name = "cboSexo";
            cboSexo.Size = new Size(218, 23);
            cboSexo.TabIndex = 39;
            // 
            // cboTipoDocumento
            // 
            cboTipoDocumento.FormattingEnabled = true;
            cboTipoDocumento.Location = new Point(625, 342);
            cboTipoDocumento.Name = "cboTipoDocumento";
            cboTipoDocumento.Size = new Size(218, 23);
            cboTipoDocumento.TabIndex = 40;
            // 
            // cboRol
            // 
            cboRol.FormattingEnabled = true;
            cboRol.Location = new Point(625, 254);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(218, 23);
            cboRol.TabIndex = 41;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(1022, 86);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 42;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(1022, 133);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 43;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(1022, 178);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 44;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(1022, 218);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 45;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnHabilitar
            // 
            btnHabilitar.Location = new Point(1022, 271);
            btnHabilitar.Name = "btnHabilitar";
            btnHabilitar.Size = new Size(75, 23);
            btnHabilitar.TabIndex = 46;
            btnHabilitar.Text = "Habilitar";
            btnHabilitar.UseVisualStyleBackColor = true;
            btnHabilitar.Click += btnHabilitar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(1022, 321);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(116, 23);
            btnBuscar.TabIndex = 47;
            btnBuscar.Text = "Buscar Empleado";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // frmempleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1319, 834);
            Controls.Add(btnBuscar);
            Controls.Add(btnHabilitar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnRegistrar);
            Controls.Add(btnNuevo);
            Controls.Add(cboRol);
            Controls.Add(cboTipoDocumento);
            Controls.Add(cboSexo);
            Controls.Add(cboDistrito);
            Controls.Add(chkEstado);
            Controls.Add(txtSue);
            Controls.Add(txtCla);
            Controls.Add(txtUsu);
            Controls.Add(txtCor);
            Controls.Add(txtCel);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(dgvEmpleado);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtNumDoc);
            Controls.Add(label7);
            Controls.Add(txtNom);
            Controls.Add(txtApeP);
            Controls.Add(txtApeM);
            Controls.Add(txtDir);
            Controls.Add(txtTel);
            Controls.Add(dtpFecIng);
            Controls.Add(dtpFecNac);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtCod);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmempleado";
            Text = "frmempleado";
            ((System.ComponentModel.ISupportInitialize)dgvEmpleado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCod;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpFecNac;
        private DateTimePicker dtpFecIng;
        private TextBox txtTel;
        private TextBox txtDir;
        private TextBox txtApeM;
        private TextBox txtApeP;
        private TextBox txtNom;
        private Label label7;
        private TextBox txtNumDoc;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private DataGridView dgvEmpleado;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private TextBox txtCel;
        private TextBox txtCor;
        private TextBox txtUsu;
        private TextBox txtCla;
        private TextBox txtSue;
        private CheckBox chkEstado;
        private ComboBox cboDistrito;
        private ComboBox cboSexo;
        private ComboBox cboTipoDocumento;
        private ComboBox cboRol;
        private Button btnNuevo;
        private Button btnRegistrar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnHabilitar;
        private Button btnBuscar;
    }
}