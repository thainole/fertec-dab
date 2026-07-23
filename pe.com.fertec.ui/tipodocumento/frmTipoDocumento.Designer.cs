namespace pe.com.fertec.ui.tipodocumento
{
    partial class frmTipoDocumento
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
            label3 = new Label();
            txtCod = new TextBox();
            txtNom = new TextBox();
            chkEst = new CheckBox();
            label4 = new Label();
            dgvTipoDeDocumento = new DataGridView();
            btnNuevo = new Button();
            btnRegistrar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnHabilitar = new Button();
            btnBuscar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTipoDeDocumento).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display Semib", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(277, 20);
            label1.Name = "label1";
            label1.Size = new Size(460, 36);
            label1.TabIndex = 0;
            label1.Text = "Mantenimiento- Tipo De Documento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 80);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Codigo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 126);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 2;
            label3.Text = "Tipo de documento:";
            // 
            // txtCod
            // 
            txtCod.Location = new Point(200, 77);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(207, 23);
            txtCod.TabIndex = 3;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(200, 123);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(228, 23);
            txtNom.TabIndex = 4;
            // 
            // chkEst
            // 
            chkEst.AutoSize = true;
            chkEst.Location = new Point(200, 191);
            chkEst.Name = "chkEst";
            chkEst.Size = new Size(71, 19);
            chkEst.TabIndex = 5;
            chkEst.Text = "Habilitar";
            chkEst.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 195);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 6;
            label4.Text = "Estado:";
            // 
            // dgvTipoDeDocumento
            // 
            dgvTipoDeDocumento.BackgroundColor = SystemColors.ControlLight;
            dgvTipoDeDocumento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTipoDeDocumento.Location = new Point(32, 326);
            dgvTipoDeDocumento.Name = "dgvTipoDeDocumento";
            dgvTipoDeDocumento.Size = new Size(946, 361);
            dgvTipoDeDocumento.TabIndex = 7;
            dgvTipoDeDocumento.CellClick += dgvTipoDeDocumento_CellClick;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(73, 263);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 8;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(171, 263);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(277, 263);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 10;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(378, 263);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnHabilitar
            // 
            btnHabilitar.Location = new Point(484, 263);
            btnHabilitar.Name = "btnHabilitar";
            btnHabilitar.Size = new Size(75, 23);
            btnHabilitar.TabIndex = 12;
            btnHabilitar.Text = "Habilitar";
            btnHabilitar.UseVisualStyleBackColor = true;
            btnHabilitar.Click += btnHabilitar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(599, 263);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 13;
            btnBuscar.Text = "Buscar ";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(844, 266);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmTipoDocumento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 766);
            Controls.Add(btnSalir);
            Controls.Add(btnBuscar);
            Controls.Add(btnHabilitar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnRegistrar);
            Controls.Add(btnNuevo);
            Controls.Add(dgvTipoDeDocumento);
            Controls.Add(label4);
            Controls.Add(chkEst);
            Controls.Add(txtNom);
            Controls.Add(txtCod);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmTipoDocumento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "tipoDocumentoFrm";
            ((System.ComponentModel.ISupportInitialize)dgvTipoDeDocumento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCod;
        private TextBox txtNom;
        private CheckBox chkEst;
        private Label label4;
        private DataGridView dgvTipoDeDocumento;
        private Button btnNuevo;
        private Button btnRegistrar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnHabilitar;
        private Button btnBuscar;
        private Button btnSalir;
    }
}