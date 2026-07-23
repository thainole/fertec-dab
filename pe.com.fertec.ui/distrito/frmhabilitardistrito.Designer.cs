namespace pe.com.fertec.ui.distrito
{
    partial class frmhabilitardistrito
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
            dgvDistrito = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDistrito).BeginInit();
            SuspendLayout();
            // 
            // btnHabilitar
            // 
            btnHabilitar.Location = new Point(67, 43);
            btnHabilitar.Name = "btnHabilitar";
            btnHabilitar.Size = new Size(75, 23);
            btnHabilitar.TabIndex = 0;
            btnHabilitar.Text = "Habilitar";
            btnHabilitar.UseVisualStyleBackColor = true;
            btnHabilitar.Click += btnHabilitar_Click;
            // 
            // btnDeshabilitar
            // 
            btnDeshabilitar.Location = new Point(175, 43);
            btnDeshabilitar.Name = "btnDeshabilitar";
            btnDeshabilitar.Size = new Size(83, 23);
            btnDeshabilitar.TabIndex = 1;
            btnDeshabilitar.Text = "Deshabilitar";
            btnDeshabilitar.UseVisualStyleBackColor = true;
            btnDeshabilitar.Click += btnDeshabilitar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(291, 43);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 23);
            btnRegresar.TabIndex = 2;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // dgvDistrito
            // 
            dgvDistrito.BackgroundColor = SystemColors.ControlLight;
            dgvDistrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDistrito.Location = new Point(57, 96);
            dgvDistrito.Name = "dgvDistrito";
            dgvDistrito.Size = new Size(752, 371);
            dgvDistrito.TabIndex = 3;
            dgvDistrito.CellClick += dgvDistrito_CellClick;
            // 
            // frmhabilitardistrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 524);
            Controls.Add(dgvDistrito);
            Controls.Add(btnRegresar);
            Controls.Add(btnDeshabilitar);
            Controls.Add(btnHabilitar);
            Name = "frmhabilitardistrito";
            Text = "frmhabilitardistrito";
            ((System.ComponentModel.ISupportInitialize)dgvDistrito).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnHabilitar;
        private Button btnDeshabilitar;
        private Button btnRegresar;
        private DataGridView dgvDistrito;
    }
}