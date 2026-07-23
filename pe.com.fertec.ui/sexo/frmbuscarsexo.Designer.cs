namespace pe.com.fertec.ui.sexo
{
    partial class frmbuscarsexo
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
            btnRegresar = new Button();
            dgvSexo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSexo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(309, 15);
            label1.Name = "label1";
            label1.Size = new Size(177, 27);
            label1.TabIndex = 0;
            label1.Text = "Buscar Sexo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 82);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Buscar:";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(154, 76);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(342, 23);
            txtValor.TabIndex = 2;
            txtValor.TextChanged += txtValor_TextChanged;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(567, 78);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 23);
            btnRegresar.TabIndex = 3;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // dgvSexo
            // 
            dgvSexo.BackgroundColor = SystemColors.ControlLight;
            dgvSexo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSexo.Location = new Point(39, 150);
            dgvSexo.Name = "dgvSexo";
            dgvSexo.Size = new Size(757, 313);
            dgvSexo.TabIndex = 4;
            // 
            // frmbuscarsexo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 510);
            Controls.Add(dgvSexo);
            Controls.Add(btnRegresar);
            Controls.Add(txtValor);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmbuscarsexo";
            Text = "frmbuscarsexo";
            ((System.ComponentModel.ISupportInitialize)dgvSexo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtValor;
        private Button btnRegresar;
        private DataGridView dgvSexo;
    }
}