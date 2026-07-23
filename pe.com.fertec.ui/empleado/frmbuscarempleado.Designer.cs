namespace pe.com.fertec.ui.empleado
{
    partial class frmbuscarempleado
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
            txtValor = new TextBox();
            dgvEmpleado = new DataGridView();
            btnRegresar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleado).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(497, 23);
            label1.Name = "label1";
            label1.Size = new Size(237, 27);
            label1.TabIndex = 0;
            label1.Text = "Buscar Empleado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 114);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Valor:";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(194, 106);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(408, 23);
            txtValor.TabIndex = 2;
            txtValor.TextChanged += txtValor_TextChanged;
            // 
            // dgvEmpleado
            // 
            dgvEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleado.Location = new Point(34, 172);
            dgvEmpleado.Name = "dgvEmpleado";
            dgvEmpleado.Size = new Size(1262, 473);
            dgvEmpleado.TabIndex = 3;
            dgvEmpleado.CellClick += dgvEmpleado_CellClick;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(722, 106);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 23);
            btnRegresar.TabIndex = 4;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // frmbuscarempleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1321, 670);
            Controls.Add(btnRegresar);
            Controls.Add(dgvEmpleado);
            Controls.Add(txtValor);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmbuscarempleado";
            Text = "frmbuscarempleado";
            ((System.ComponentModel.ISupportInitialize)dgvEmpleado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtValor;
        private DataGridView dgvEmpleado;
        private Button btnRegresar;
    }
}