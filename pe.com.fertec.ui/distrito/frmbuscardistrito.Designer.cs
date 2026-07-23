namespace pe.com.fertec.ui.distrito
{
    partial class frmbuscardistrito
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
            dgvDistrito = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDistrito).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(353, 22);
            label1.Name = "label1";
            label1.Size = new Size(237, 27);
            label1.TabIndex = 0;
            label1.Text = "BUSCAR DISTRITO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 101);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Buscar:";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(147, 93);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(335, 23);
            txtValor.TabIndex = 2;
            txtValor.TextChanged += txtValor_TextChanged;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(693, 88);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 23);
            btnRegresar.TabIndex = 3;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // dgvDistrito
            // 
            dgvDistrito.BackgroundColor = SystemColors.ControlLight;
            dgvDistrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDistrito.Location = new Point(40, 136);
            dgvDistrito.Name = "dgvDistrito";
            dgvDistrito.Size = new Size(872, 392);
            dgvDistrito.TabIndex = 4;
            // 
            // frmbuscardistrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 540);
            Controls.Add(dgvDistrito);
            Controls.Add(btnRegresar);
            Controls.Add(txtValor);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmbuscardistrito";
            Text = "frmbuscardistrito";
            ((System.ComponentModel.ISupportInitialize)dgvDistrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtValor;
        private Button btnRegresar;
        private DataGridView dgvDistrito;
    }
}