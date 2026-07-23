namespace pe.com.fertec.ui.marca
{
    partial class habilitarMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(habilitarMarca));
            dgvHabilitarMarca = new DataGridView();
            btnRegresar = new Button();
            btnDeshabilitar = new Button();
            btnHabilitar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHabilitarMarca).BeginInit();
            SuspendLayout();
            // 
            // dgvHabilitarMarca
            // 
            dgvHabilitarMarca.BackgroundColor = SystemColors.InactiveCaption;
            dgvHabilitarMarca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHabilitarMarca.Location = new Point(12, 73);
            dgvHabilitarMarca.Name = "dgvHabilitarMarca";
            dgvHabilitarMarca.Size = new Size(776, 356);
            dgvHabilitarMarca.TabIndex = 7;
            dgvHabilitarMarca.CellClick += dgvHabilitarMarca_CellClick;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(214, 21);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 23);
            btnRegresar.TabIndex = 6;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnDeshabilitar
            // 
            btnDeshabilitar.Location = new Point(112, 21);
            btnDeshabilitar.Name = "btnDeshabilitar";
            btnDeshabilitar.Size = new Size(81, 23);
            btnDeshabilitar.TabIndex = 5;
            btnDeshabilitar.Text = "Deshabilitar";
            btnDeshabilitar.UseVisualStyleBackColor = true;
            btnDeshabilitar.Click += btnDeshabilitar_Click;
            // 
            // btnHabilitar
            // 
            btnHabilitar.Location = new Point(12, 21);
            btnHabilitar.Name = "btnHabilitar";
            btnHabilitar.Size = new Size(75, 23);
            btnHabilitar.TabIndex = 4;
            btnHabilitar.Text = "Habilitar";
            btnHabilitar.UseVisualStyleBackColor = true;
            btnHabilitar.Click += btnHabilitar_Click;
            // 
            // habilitarMarca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(dgvHabilitarMarca);
            Controls.Add(btnRegresar);
            Controls.Add(btnDeshabilitar);
            Controls.Add(btnHabilitar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "habilitarMarca";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Habilitar Marca";
            Load += habilitarMarca_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHabilitarMarca).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvHabilitarMarca;
        private Button btnRegresar;
        private Button btnDeshabilitar;
        private Button btnHabilitar;
    }
}