namespace pe.com.fertec.ui
{
    partial class tipoDocunentoFrm
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
            dgvTipoDocumento = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dgvTipoDocumento).BeginInit();
            SuspendLayout();
            // 
            // dgvTipoDocumento
            // 
            dgvTipoDocumento.BackgroundColor = SystemColors.Window;
            dgvTipoDocumento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTipoDocumento.GridColor = SystemColors.Window;
            dgvTipoDocumento.Location = new Point(38, 241);
            dgvTipoDocumento.Name = "dgvTipoDocumento";
            dgvTipoDocumento.Size = new Size(724, 185);
            dgvTipoDocumento.TabIndex = 65;
            dgvTipoDocumento.CellContentClick += dgvTipoDocumento_CellContentClick;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(687, 197);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 64;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnHabilitar
            // 
            btnHabilitar.Location = new Point(488, 197);
            btnHabilitar.Name = "btnHabilitar";
            btnHabilitar.Size = new Size(75, 23);
            btnHabilitar.TabIndex = 63;
            btnHabilitar.Text = "Habilitar";
            btnHabilitar.UseVisualStyleBackColor = true;
            btnHabilitar.Click += btnHabilitar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(390, 197);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 62;
            btnEliminar.Text = "Inhabilitar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(281, 197);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 61;
            btnActualizar.Text = "Actuatlizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(176, 197);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 60;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(61, 197);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 59;
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
            chkEstado.TabIndex = 58;
            chkEstado.Text = "activo";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(113, 110);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 57;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 118);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 56;
            label2.Text = "Tipo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 81);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 55;
            label1.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(113, 78);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 54;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Yu Gothic Medium", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(38, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(291, 47);
            textBox1.TabIndex = 53;
            textBox1.Text = "Tipo de Documento";
            // 
            // tipoDocunentoFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvTipoDocumento);
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
            Name = "tipoDocunentoFrm";
            Text = "tipoDocunentoFrm";
            Load += tipoDocunentoFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTipoDocumento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTipoDocumento;
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