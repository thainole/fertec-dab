namespace pe.com.fertec.ui
{
    partial class frmventa
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
            cmbCliente = new ComboBox();
            cmbProducto = new ComboBox();
            txtCantidad = new TextBox();
            btnAgregar = new Button();
            dgvDetalle = new DataGridView();
            lblCliente = new Label();
            btnRegistrar = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(134, 47);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(210, 23);
            cmbCliente.TabIndex = 0;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(134, 54);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(210, 23);
            cmbProducto.TabIndex = 1;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(134, 108);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(210, 23);
            txtCantidad.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ButtonHighlight;
            btnAgregar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(416, 108);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 30);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvDetalle
            // 
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(12, 302);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.Size = new Size(1198, 500);
            dgvDetalle.TabIndex = 4;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(19, 55);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(44, 15);
            lblCliente.TabIndex = 5;
            lblCliente.Text = "Cliente";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(1100, 758);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbCliente);
            groupBox1.Controls.Add(lblCliente);
            groupBox1.Location = new Point(4, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1198, 112);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la Venta";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cmbProducto);
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(txtCantidad);
            groupBox2.Location = new Point(4, 130);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1198, 166);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Agregar Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 111);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 5;
            label2.Text = "Cantidad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 57);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 4;
            label1.Text = "Producto";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(955, 760);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(107, 21);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "Total: S/.0.00";
            // 
            // frmventa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 804);
            Controls.Add(lblTotal);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnRegistrar);
            Controls.Add(dgvDetalle);
            Name = "frmventa";
            Text = "Módulo de Ventas - Fertec";
            Load += frmventa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCliente;
        private ComboBox cmbProducto;
        private TextBox txtCantidad;
        private Button btnAgregar;
        private DataGridView dgvDetalle;
        private Label lblCliente;
        private Button btnRegistrar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label1;
        private Label lblTotal;
    }
}