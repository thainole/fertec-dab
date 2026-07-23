namespace pe.com.fertec.ui
{
    partial class distritoFrm
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
            dgvDistrito = new DataGridView();
            btnSalir = new Button();
            btnHabilitar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnRegistrar = new Button();
            btnNuevo = new Button();
            chkEstado = new CheckBox();
            txtNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtCodigo = new TextBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDistrito).BeginInit();
            SuspendLayout();
            // 
            // dgvDistrito
            // 
            dgvDistrito.BackgroundColor = SystemColors.Window;
            dgvDistrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDistrito.GridColor = SystemColors.Window;
            dgvDistrito.Location = new Point(38, 241);
            dgvDistrito.Name = "dgvDistrito";
            dgvDistrito.Size = new Size(724, 185);
            dgvDistrito.TabIndex = 39;
            dgvDistrito.CellContentClick += dgvDistrito_CellContentClick;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(687, 197);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 38;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnHabilitar
            // 
            btnHabilitar.Location = new Point(488, 197);
            btnHabilitar.Name = "btnHabilitar";
            btnHabilitar.Size = new Size(75, 23);
            btnHabilitar.TabIndex = 37;
            btnHabilitar.Text = "Habilitar";
            btnHabilitar.UseVisualStyleBackColor = true;
            btnHabilitar.Click += btnHabilitar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(390, 197);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 36;
            btnEliminar.Text = "Inhabilitar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(281, 197);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 35;
            btnActualizar.Text = "Actuatlizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(176, 197);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 34;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(61, 197);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 33;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(49, 160);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(58, 19);
            chkEstado.TabIndex = 32;
            chkEstado.Text = "activo";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(113, 110);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 118);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 30;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 81);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 29;
            label1.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(113, 78);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 28;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Yu Gothic Medium", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(74, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 47);
            textBox1.TabIndex = 27;
            textBox1.Text = "Distrito";
            // 
            // distritoFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDistrito);
            Controls.Add(btnSalir);
            Controls.Add(btnHabilitar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnRegistrar);
            Controls.Add(btnNuevo);
            Controls.Add(chkEstado);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCodigo);
            Controls.Add(textBox1);
            Name = "distritoFrm";
            Text = "distritoFrm";
            Load += distritoFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDistrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDistrito;
        private Button btnSalir;
        private Button btnHabilitar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnRegistrar;
        private Button btnNuevo;
        private CheckBox chkEstado;
        private TextBox txtNombre;
        private Label label2;
        private Label label1;
        private TextBox txtCodigo;
        private TextBox textBox1;
    }
}