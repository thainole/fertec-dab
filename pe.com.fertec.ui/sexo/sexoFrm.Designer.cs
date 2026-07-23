namespace pe.com.fertec.ui
{
    partial class sexoFrm
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
            dgvSexo = new DataGridView();
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
            btnBuscar = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSexo).BeginInit();
            SuspendLayout();
            // 
            // dgvSexo
            // 
            dgvSexo.BackgroundColor = SystemColors.ControlLight;
            dgvSexo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSexo.GridColor = SystemColors.Window;
            dgvSexo.Location = new Point(38, 241);
            dgvSexo.Name = "dgvSexo";
            dgvSexo.RowHeadersWidth = 56;
            dgvSexo.Size = new Size(758, 269);
            dgvSexo.TabIndex = 52;
            dgvSexo.CellClick += dgvSexo_CellClick;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(687, 197);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 51;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnHabilitar
            // 
            btnHabilitar.Location = new Point(412, 197);
            btnHabilitar.Name = "btnHabilitar";
            btnHabilitar.Size = new Size(75, 23);
            btnHabilitar.TabIndex = 50;
            btnHabilitar.Text = "Habilitar";
            btnHabilitar.UseVisualStyleBackColor = true;
            btnHabilitar.Click += btnHabilitar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(321, 197);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 49;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(234, 197);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 48;
            btnActualizar.Text = "Actuatlizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(144, 197);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 47;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(49, 197);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 46;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(49, 157);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(71, 19);
            chkEstado.TabIndex = 45;
            chkEstado.Text = "Habilitar";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(144, 110);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(252, 23);
            txtNombre.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 118);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 43;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 86);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 42;
            label1.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(144, 78);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(177, 23);
            txtCodigo.TabIndex = 41;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(493, 197);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 53;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(251, 9);
            label3.Name = "label3";
            label3.Size = new Size(312, 27);
            label3.TabIndex = 54;
            label3.Text = "Mantenimiento - Sexo";
            // 
            // sexoFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 537);
            Controls.Add(label3);
            Controls.Add(btnBuscar);
            Controls.Add(dgvSexo);
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
            Name = "sexoFrm";
            Text = "sexoFrm";
            Load += sexoFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSexo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSexo;
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
        private Button btnBuscar;
        private Label label3;
    }
}