namespace pe.com.fertec.ui.categoria
{
    partial class habilitarCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(habilitarCategoria));
            btnHabilitar = new Button();
            btnDeshabilitar = new Button();
            btnRegresar = new Button();
            dgvHabilitarCategoria = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvHabilitarCategoria).BeginInit();
            SuspendLayout();
            // 
            // btnHabilitar
            // 
            btnHabilitar.Location = new Point(12, 30);
            btnHabilitar.Name = "btnHabilitar";
            btnHabilitar.Size = new Size(75, 23);
            btnHabilitar.TabIndex = 0;
            btnHabilitar.Text = "Habilitar";
            btnHabilitar.UseVisualStyleBackColor = true;
            btnHabilitar.Click += btnHabilitar_Click;
            // 
            // btnDeshabilitar
            // 
            btnDeshabilitar.Location = new Point(112, 30);
            btnDeshabilitar.Name = "btnDeshabilitar";
            btnDeshabilitar.Size = new Size(81, 23);
            btnDeshabilitar.TabIndex = 1;
            btnDeshabilitar.Text = "Deshabilitar";
            btnDeshabilitar.UseVisualStyleBackColor = true;
            btnDeshabilitar.Click += btnDeshabilitar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(214, 30);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 23);
            btnRegresar.TabIndex = 2;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // dgvHabilitarCategoria
            // 
            dgvHabilitarCategoria.BackgroundColor = SystemColors.InactiveCaption;
            dgvHabilitarCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHabilitarCategoria.Location = new Point(12, 82);
            dgvHabilitarCategoria.Name = "dgvHabilitarCategoria";
            dgvHabilitarCategoria.Size = new Size(776, 356);
            dgvHabilitarCategoria.TabIndex = 3;
            dgvHabilitarCategoria.CellClick += dgvHabilitarCategoria_CellClick;
            // 
            // habilitarCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(dgvHabilitarCategoria);
            Controls.Add(btnRegresar);
            Controls.Add(btnDeshabilitar);
            Controls.Add(btnHabilitar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "habilitarCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Habilitar Categoria";
            Load += habilitarCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHabilitarCategoria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnHabilitar;
        private Button btnDeshabilitar;
        private Button btnRegresar;
        private DataGridView dgvHabilitarCategoria;
    }
}