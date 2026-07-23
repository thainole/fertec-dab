namespace pe.com.fertec.ui
{
    partial class frmlistado
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
            dgvListado = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvListado).BeginInit();
            SuspendLayout();
            // 
            // dgvListado
            // 
            dgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListado.Location = new Point(1, 2);
            dgvListado.Name = "dgvListado";
            dgvListado.Size = new Size(1256, 634);
            dgvListado.TabIndex = 0;
            // 
            // frmlistado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 637);
            Controls.Add(dgvListado);
            Name = "frmlistado";
            Text = "frmlistado";
            Load += frmlistado_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListado;
    }
}