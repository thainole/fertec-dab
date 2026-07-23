namespace pe.com.fertec.ui.empleado
{
    partial class frmhabilitarempleado
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
            dgvEmpleado = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleado).BeginInit();
            SuspendLayout();
            // 
            // btnHabilitar
            // 
            btnHabilitar.Location = new Point(68, 55);
            btnHabilitar.Name = "btnHabilitar";
            btnHabilitar.Size = new Size(75, 23);
            btnHabilitar.TabIndex = 0;
            btnHabilitar.Text = "Habilitar";
            btnHabilitar.UseVisualStyleBackColor = true;
            btnHabilitar.Click += btnHabilitar_Click;
            // 
            // btnDeshabilitar
            // 
            btnDeshabilitar.Location = new Point(176, 55);
            btnDeshabilitar.Name = "btnDeshabilitar";
            btnDeshabilitar.Size = new Size(75, 23);
            btnDeshabilitar.TabIndex = 1;
            btnDeshabilitar.Text = "Deshabilitar";
            btnDeshabilitar.UseVisualStyleBackColor = true;
            btnDeshabilitar.Click += btnDeshabilitar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(281, 55);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 23);
            btnRegresar.TabIndex = 2;
            btnRegresar.Text = "regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // dgvEmpleado
            // 
            dgvEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleado.Location = new Point(46, 120);
            dgvEmpleado.Name = "dgvEmpleado";
            dgvEmpleado.Size = new Size(1186, 585);
            dgvEmpleado.TabIndex = 3;
            dgvEmpleado.CellClick += dgvEmpleado_CellClick;
            // 
            // frmhabilitarempleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1302, 765);
            Controls.Add(dgvEmpleado);
            Controls.Add(btnRegresar);
            Controls.Add(btnDeshabilitar);
            Controls.Add(btnHabilitar);
            Name = "frmhabilitarempleado";
            Text = "frmhabilitarempleado";
            ((System.ComponentModel.ISupportInitialize)dgvEmpleado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnHabilitar;
        private Button btnDeshabilitar;
        private Button btnRegresar;
        private DataGridView dgvEmpleado;
    }
}