namespace pe.com.fertec.ui.sexo
{
    partial class frmhabilitarsexo
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
            dgvSexo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSexo).BeginInit();
            SuspendLayout();
            // 
            // btnHabilitar
            // 
            btnHabilitar.Location = new Point(60, 40);
            btnHabilitar.Name = "btnHabilitar";
            btnHabilitar.Size = new Size(75, 23);
            btnHabilitar.TabIndex = 0;
            btnHabilitar.Text = "Habilitar";
            btnHabilitar.UseVisualStyleBackColor = true;
            btnHabilitar.Click += btnHabilitar_Click;
            // 
            // btnDeshabilitar
            // 
            btnDeshabilitar.Location = new Point(176, 40);
            btnDeshabilitar.Name = "btnDeshabilitar";
            btnDeshabilitar.Size = new Size(83, 23);
            btnDeshabilitar.TabIndex = 1;
            btnDeshabilitar.Text = "Deshabilitar";
            btnDeshabilitar.UseVisualStyleBackColor = true;
            btnDeshabilitar.Click += btnDeshabilitar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(290, 40);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 23);
            btnRegresar.TabIndex = 2;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // dgvSexo
            // 
            dgvSexo.BackgroundColor = SystemColors.ControlLight;
            dgvSexo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSexo.Location = new Point(62, 94);
            dgvSexo.Name = "dgvSexo";
            dgvSexo.Size = new Size(806, 413);
            dgvSexo.TabIndex = 3;
            dgvSexo.CellClick += dgvSexo_CellClick;
            // 
            // frmhabilitarsexo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 529);
            Controls.Add(dgvSexo);
            Controls.Add(btnRegresar);
            Controls.Add(btnDeshabilitar);
            Controls.Add(btnHabilitar);
            Name = "frmhabilitarsexo";
            Text = "frmhabilitarsexo";
            ((System.ComponentModel.ISupportInitialize)dgvSexo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnHabilitar;
        private Button btnDeshabilitar;
        private Button btnRegresar;
        private DataGridView dgvSexo;
    }
}