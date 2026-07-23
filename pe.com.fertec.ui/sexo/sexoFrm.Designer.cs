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
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSexo).BeginInit();
            SuspendLayout();
            // 
            // dgvSexo
            // 
            dgvSexo.BackgroundColor = SystemColors.Window;
            dgvSexo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSexo.GridColor = SystemColors.Window;
            dgvSexo.Location = new Point(49, 337);
            dgvSexo.Margin = new Padding(4, 4, 4, 4);
            dgvSexo.Name = "dgvSexo";
            dgvSexo.RowHeadersWidth = 56;
            dgvSexo.Size = new Size(931, 259);
            dgvSexo.TabIndex = 52;
            dgvSexo.CellClick += dgvSexo_CellClick;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(883, 276);
            btnSalir.Margin = new Padding(4, 4, 4, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(96, 32);
            btnSalir.TabIndex = 51;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnHabilitar
            // 
            btnHabilitar.Location = new Point(627, 276);
            btnHabilitar.Margin = new Padding(4, 4, 4, 4);
            btnHabilitar.Name = "btnHabilitar";
            btnHabilitar.Size = new Size(96, 32);
            btnHabilitar.TabIndex = 50;
            btnHabilitar.Text = "Habilitar";
            btnHabilitar.UseVisualStyleBackColor = true;
            btnHabilitar.Click += btnHabilitar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(501, 276);
            btnEliminar.Margin = new Padding(4, 4, 4, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(96, 32);
            btnEliminar.TabIndex = 49;
            btnEliminar.Text = "Inhabilitar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(361, 276);
            btnActualizar.Margin = new Padding(4, 4, 4, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(96, 32);
            btnActualizar.TabIndex = 48;
            btnActualizar.Text = "Actuatlizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(226, 276);
            btnRegistrar.Margin = new Padding(4, 4, 4, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(96, 32);
            btnRegistrar.TabIndex = 47;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(78, 276);
            btnNuevo.Margin = new Padding(4, 4, 4, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(96, 32);
            btnNuevo.TabIndex = 46;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(63, 224);
            chkEstado.Margin = new Padding(4, 4, 4, 4);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(73, 25);
            chkEstado.TabIndex = 45;
            chkEstado.Text = "activo";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(145, 154);
            txtNombre.Margin = new Padding(4, 4, 4, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(127, 29);
            txtNombre.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 165);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 43;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 113);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 42;
            label1.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(145, 109);
            txtCodigo.Margin = new Padding(4, 4, 4, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(127, 29);
            txtCodigo.TabIndex = 41;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Yu Gothic Medium", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(95, 35);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 63);
            textBox1.TabIndex = 40;
            textBox1.Text = "Sexo";
            // 
            // sexoFrm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
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
            Controls.Add(textBox1);
            Margin = new Padding(4, 4, 4, 4);
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
        private TextBox textBox1;
    }
}