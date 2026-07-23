namespace pe.com.fertec.ui.tipodocumento
{
    partial class frmhabilitartipodedocumento
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
            btnHabilitar = new Button();
            btnDeshabilitar = new Button();
            btnRegresar = new Button();
            dgvTipoDocumento = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTipoDocumento).BeginInit();
            SuspendLayout();
            // 
            // btnHabilitar
            // 
            btnHabilitar.Location = new Point(61, 33);
            btnHabilitar.Name = "btnHabilitar";
            btnHabilitar.Size = new Size(75, 23);
            btnHabilitar.TabIndex = 0;
            btnHabilitar.Text = "Habilitar";
            btnHabilitar.UseVisualStyleBackColor = true;
            btnHabilitar.Click += btnHabilitar_Click;
            // 
            // btnDeshabilitar
            // 
            btnDeshabilitar.Location = new Point(171, 33);
            btnDeshabilitar.Name = "btnDeshabilitar";
            btnDeshabilitar.Size = new Size(75, 23);
            btnDeshabilitar.TabIndex = 1;
            btnDeshabilitar.Text = "Deshabilitar";
            btnDeshabilitar.UseVisualStyleBackColor = true;
            btnDeshabilitar.Click += btnDeshabilitar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(292, 33);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 23);
            btnRegresar.TabIndex = 2;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // dgvTipoDocumento
            // 
            dgvTipoDocumento.BackgroundColor = SystemColors.ControlLight;
            dgvTipoDocumento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTipoDocumento.Location = new Point(55, 78);
            dgvTipoDocumento.Name = "dgvTipoDocumento";
            dgvTipoDocumento.Size = new Size(1026, 501);
            dgvTipoDocumento.TabIndex = 3;
            dgvTipoDocumento.CellClick += dgvTipoDocumento_CellClick;
            // 
            // frmhabilitartipodedocumento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 603);
            Controls.Add(dgvTipoDocumento);
            Controls.Add(btnRegresar);
            Controls.Add(btnDeshabilitar);
            Controls.Add(btnHabilitar);
            Name = "frmhabilitartipodedocumento";
            Text = "frmhabilitartipodedocumento";
            ((System.ComponentModel.ISupportInitialize)dgvTipoDocumento).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnHabilitar;
        private Button btnDeshabilitar;
        private Button btnRegresar;
        private DataGridView dgvTipoDocumento;
    }
}