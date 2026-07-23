namespace pe.com.fertec.ui
{
    partial class categoriaFrm
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            chkEstado = new CheckBox();
            btnNuevo = new Button();
            btnRegistrar = new Button();
            btnActualizar = new Button();
            btnHabilitar = new Button();
            btnSalir = new Button();
            dgvCategorias = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuBar;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(332, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 39);
            textBox1.TabIndex = 0;
            textBox1.Text = "Categoría";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 69);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 96);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            label2.Click += label2_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(113, 61);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(139, 23);
            txtCodigo.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(113, 90);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(139, 23);
            txtNombre.TabIndex = 4;
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(42, 134);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(58, 19);
            chkEstado.TabIndex = 5;
            chkEstado.Text = "activo";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(27, 183);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 6;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(138, 183);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(257, 183);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnHabilitar
            // 
            btnHabilitar.Location = new Point(363, 183);
            btnHabilitar.Name = "btnHabilitar";
            btnHabilitar.Size = new Size(75, 23);
            btnHabilitar.TabIndex = 11;
            btnHabilitar.Text = "Habilitar";
            btnHabilitar.UseVisualStyleBackColor = true;
            btnHabilitar.Click += btnHabilitar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(647, 183);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvCategorias
            // 
            dgvCategorias.BackgroundColor = SystemColors.Window;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(27, 236);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.Size = new Size(723, 202);
            dgvCategorias.TabIndex = 13;
            dgvCategorias.CellClick += dgvCategorias_CellClick;
            // 
            // categoriaFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCategorias);
            Controls.Add(btnSalir);
            Controls.Add(btnHabilitar);
            Controls.Add(btnActualizar);
            Controls.Add(btnRegistrar);
            Controls.Add(btnNuevo);
            Controls.Add(chkEstado);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "categoriaFrm";
            Text = "categoríaFrm";
            Load += categoriaFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private CheckBox chkEstado;
        private Button btnNuevo;
        private Button btnRegistrar;
        private Button btnActualizar;
        private Button btnHabilitar;
        private Button btnSalir;
        private DataGridView dgvCategorias;
    }
}