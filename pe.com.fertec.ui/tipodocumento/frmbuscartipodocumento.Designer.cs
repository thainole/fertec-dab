namespace pe.com.fertec.ui.tipodocumento
{
    partial class frmbuscartipodocumento
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
            btnRegresar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtValor = new TextBox();
            dgvTipoDeDocumento = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTipoDeDocumento).BeginInit();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(713, 93);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 23);
            btnRegresar.TabIndex = 0;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(428, 21);
            label1.Name = "label1";
            label1.Size = new Size(283, 24);
            label1.TabIndex = 1;
            label1.Text = "Buscar Tipo Documento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 97);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "buscar:";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(154, 89);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(511, 23);
            txtValor.TabIndex = 3;
            txtValor.TextChanged += txtValor_TextChanged;
            // 
            // dgvTipoDeDocumento
            // 
            dgvTipoDeDocumento.BackgroundColor = SystemColors.ControlLight;
            dgvTipoDeDocumento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTipoDeDocumento.Location = new Point(60, 156);
            dgvTipoDeDocumento.Name = "dgvTipoDeDocumento";
            dgvTipoDeDocumento.Size = new Size(1012, 443);
            dgvTipoDeDocumento.TabIndex = 4;
            // 
            // frmbuscartipodocumento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 663);
            Controls.Add(dgvTipoDeDocumento);
            Controls.Add(txtValor);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegresar);
            Name = "frmbuscartipodocumento";
            Text = "frmbuscartipodocumento";
            ((System.ComponentModel.ISupportInitialize)dgvTipoDeDocumento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegresar;
        private Label label1;
        private Label label2;
        private TextBox txtValor;
        private DataGridView dgvTipoDeDocumento;
    }
}