namespace pe.com.fertec.ui
{
    partial class frmingreso
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmingreso));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsu = new TextBox();
            txtCla = new TextBox();
            btnIngresar = new Button();
            btnSalir = new Button();
            pictureBox1 = new PictureBox();
            pgbInicio = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun-ExtG", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(270, 21);
            label1.Name = "label1";
            label1.Size = new Size(231, 24);
            label1.TabIndex = 0;
            label1.Text = "Ingeso al Sistema";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 98);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(69, 160);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 2;
            label3.Text = "Clave:";
            // 
            // txtUsu
            // 
            txtUsu.Location = new Point(148, 95);
            txtUsu.Name = "txtUsu";
            txtUsu.Size = new Size(240, 23);
            txtUsu.TabIndex = 3;
            // 
            // txtCla
            // 
            txtCla.ImeMode = ImeMode.NoControl;
            txtCla.Location = new Point(148, 152);
            txtCla.Name = "txtCla";
            txtCla.PasswordChar = '*';
            txtCla.Size = new Size(240, 23);
            txtCla.TabIndex = 4;
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.Location = new Point(62, 228);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(84, 32);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(313, 228);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(84, 32);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fertec_1;
            pictureBox1.Location = new Point(473, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(265, 296);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pgbInicio
            // 
            pgbInicio.Location = new Point(62, 331);
            pgbInicio.Name = "pgbInicio";
            pgbInicio.Size = new Size(335, 23);
            pgbInicio.Style = ProgressBarStyle.Continuous;
            pgbInicio.TabIndex = 8;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // frmingreso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(pgbInicio);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalir);
            Controls.Add(btnIngresar);
            Controls.Add(txtCla);
            Controls.Add(txtUsu);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmingreso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingreso al Sistema";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsu;
        private TextBox txtCla;
        private Button btnIngresar;
        private Button btnSalir;
        private PictureBox pictureBox1;
        private ProgressBar pgbInicio;
        private System.Windows.Forms.Timer timer1;
    }
}