namespace pe.com.fertec.ui
{
    partial class frmmenuprincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmenuprincipal));
            menuStrip1 = new MenuStrip();
            tsmArchivo = new ToolStripMenuItem();
            tsmiCerrarSesion = new ToolStripMenuItem();
            tsmiSalir = new ToolStripMenuItem();
            tsmMantenimientoSimple = new ToolStripMenuItem();
            tsmiCategoria = new ToolStripMenuItem();
            tsmiMarca = new ToolStripMenuItem();
            tsmiRol = new ToolStripMenuItem();
            tsmiDistrito = new ToolStripMenuItem();
            tsmiSexo = new ToolStripMenuItem();
            tsmiTipoDocumento = new ToolStripMenuItem();
            tsmMantenimientoPrincipal = new ToolStripMenuItem();
            tsmiProducto = new ToolStripMenuItem();
            tsmiCliente = new ToolStripMenuItem();
            tsmiEmpleado = new ToolStripMenuItem();
            tsmProceso = new ToolStripMenuItem();
            tsmiVenta = new ToolStripMenuItem();
            tsmiListadoVenta = new ToolStripMenuItem();
            tsmReporte = new ToolStripMenuItem();
            tsmUtilidades = new ToolStripMenuItem();
            blockDeNotasToolStripMenuItem = new ToolStripMenuItem();
            wordToolStripMenuItem = new ToolStripMenuItem();
            calculadoraToolStripMenuItem = new ToolStripMenuItem();
            excelToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblUsu = new ToolStripStatusLabel();
            lblEmpleado = new ToolStripStatusLabel();
            lblCargo = new ToolStripStatusLabel();
            lblReloj = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(22, 22);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmArchivo, tsmMantenimientoSimple, tsmMantenimientoPrincipal, tsmProceso, tsmReporte, tsmUtilidades });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1608, 32);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmArchivo
            // 
            tsmArchivo.DropDownItems.AddRange(new ToolStripItem[] { tsmiCerrarSesion, tsmiSalir });
            tsmArchivo.Name = "tsmArchivo";
            tsmArchivo.Size = new Size(77, 26);
            tsmArchivo.Text = "Archivo";
            // 
            // tsmiCerrarSesion
            // 
            tsmiCerrarSesion.Name = "tsmiCerrarSesion";
            tsmiCerrarSesion.Size = new Size(195, 30);
            tsmiCerrarSesion.Text = "Cerrar Sesion";
            tsmiCerrarSesion.Click += tsmiCerrarSesion_Click;
            // 
            // tsmiSalir
            // 
            tsmiSalir.Name = "tsmiSalir";
            tsmiSalir.Size = new Size(195, 30);
            tsmiSalir.Text = "Salir";
            tsmiSalir.Click += tsmiSalir_Click;
            // 
            // tsmMantenimientoSimple
            // 
            tsmMantenimientoSimple.DropDownItems.AddRange(new ToolStripItem[] { tsmiCategoria, tsmiMarca, tsmiRol, tsmiDistrito, tsmiSexo, tsmiTipoDocumento });
            tsmMantenimientoSimple.Name = "tsmMantenimientoSimple";
            tsmMantenimientoSimple.Size = new Size(189, 26);
            tsmMantenimientoSimple.Text = "Mantenimiento Simples";
            // 
            // tsmiCategoria
            // 
            tsmiCategoria.Name = "tsmiCategoria";
            tsmiCategoria.Size = new Size(237, 30);
            tsmiCategoria.Text = "Categoria";
            tsmiCategoria.Click += tsmiCategoria_Click;
            // 
            // tsmiMarca
            // 
            tsmiMarca.Name = "tsmiMarca";
            tsmiMarca.Size = new Size(237, 30);
            tsmiMarca.Text = "Marca";
            tsmiMarca.Click += tsmiMarca_Click;
            // 
            // tsmiRol
            // 
            tsmiRol.Name = "tsmiRol";
            tsmiRol.Size = new Size(237, 30);
            tsmiRol.Text = "Rol";
            tsmiRol.Click += tsmiRol_Click;
            // 
            // tsmiDistrito
            // 
            tsmiDistrito.Name = "tsmiDistrito";
            tsmiDistrito.Size = new Size(237, 30);
            tsmiDistrito.Text = "Distrito";
            tsmiDistrito.Click += tsmiDistrito_Click;
            // 
            // tsmiSexo
            // 
            tsmiSexo.Name = "tsmiSexo";
            tsmiSexo.Size = new Size(237, 30);
            tsmiSexo.Text = "Sexo";
            tsmiSexo.Click += tsmiSexo_Click;
            // 
            // tsmiTipoDocumento
            // 
            tsmiTipoDocumento.Name = "tsmiTipoDocumento";
            tsmiTipoDocumento.Size = new Size(237, 30);
            tsmiTipoDocumento.Text = "Tipo de Documento";
            tsmiTipoDocumento.Click += tsmiTipoDocumento_Click;
            // 
            // tsmMantenimientoPrincipal
            // 
            tsmMantenimientoPrincipal.DropDownItems.AddRange(new ToolStripItem[] { tsmiProducto, tsmiCliente, tsmiEmpleado });
            tsmMantenimientoPrincipal.Name = "tsmMantenimientoPrincipal";
            tsmMantenimientoPrincipal.Size = new Size(209, 26);
            tsmMantenimientoPrincipal.Text = "Mantenimiento Principales";
            // 
            // tsmiProducto
            // 
            tsmiProducto.Name = "tsmiProducto";
            tsmiProducto.Size = new Size(170, 30);
            tsmiProducto.Text = "Producto";
            tsmiProducto.Click += tsmiProducto_Click;
            // 
            // tsmiCliente
            // 
            tsmiCliente.Name = "tsmiCliente";
            tsmiCliente.Size = new Size(170, 30);
            tsmiCliente.Text = "Cliente";
            tsmiCliente.Click += tsmiCliente_Click;
            // 
            // tsmiEmpleado
            // 
            tsmiEmpleado.Name = "tsmiEmpleado";
            tsmiEmpleado.Size = new Size(170, 30);
            tsmiEmpleado.Text = "Empleado";
            tsmiEmpleado.Click += tsmiEmpleado_Click;
            // 
            // tsmProceso
            // 
            tsmProceso.DropDownItems.AddRange(new ToolStripItem[] { tsmiVenta, tsmiListadoVenta });
            tsmProceso.Name = "tsmProceso";
            tsmProceso.Size = new Size(79, 26);
            tsmProceso.Text = "Proceso";
            // 
            // tsmiVenta
            // 
            tsmiVenta.Name = "tsmiVenta";
            tsmiVenta.Size = new Size(243, 30);
            tsmiVenta.Size = new Size(180, 22);
            tsmiVenta.Text = "Venta ";
            tsmiVenta.Click += tsmiVenta_Click;
            // 
            // tsmiListadoVenta
            // 
            tsmiListadoVenta.Name = "tsmiListadoVenta";
            tsmiListadoVenta.Size = new Size(243, 30);
            tsmiListadoVenta.Size = new Size(180, 22);
            tsmiListadoVenta.Text = "Listado de Venta";
            tsmiListadoVenta.Click += tsmiListadoVenta_Click;
            // 
            // tsmReporte
            // 
            tsmReporte.Name = "tsmReporte";
            tsmReporte.Size = new Size(86, 26);
            tsmReporte.Text = "Reportes";
            // 
            // tsmUtilidades
            // 
            tsmUtilidades.DropDownItems.AddRange(new ToolStripItem[] { blockDeNotasToolStripMenuItem, wordToolStripMenuItem, calculadoraToolStripMenuItem, excelToolStripMenuItem });
            tsmUtilidades.Name = "tsmUtilidades";
            tsmUtilidades.Size = new Size(93, 26);
            tsmUtilidades.Text = "Utilidades";
            // 
            // blockDeNotasToolStripMenuItem
            // 
            blockDeNotasToolStripMenuItem.Name = "blockDeNotasToolStripMenuItem";
            blockDeNotasToolStripMenuItem.Size = new Size(201, 30);
            blockDeNotasToolStripMenuItem.Text = "Block de notas";
            // 
            // wordToolStripMenuItem
            // 
            wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            wordToolStripMenuItem.Size = new Size(201, 30);
            wordToolStripMenuItem.Text = "Word";
            // 
            // calculadoraToolStripMenuItem
            // 
            calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            calculadoraToolStripMenuItem.Size = new Size(201, 30);
            calculadoraToolStripMenuItem.Text = "Calculadora";
            // 
            // excelToolStripMenuItem
            // 
            excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            excelToolStripMenuItem.Size = new Size(201, 30);
            excelToolStripMenuItem.Text = "Excel";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(22, 22);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblUsu, lblEmpleado, lblCargo, lblReloj });
            statusStrip1.Location = new Point(0, 998);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 18, 0);
            statusStrip1.Size = new Size(1608, 28);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblUsu
            // 
            lblUsu.Name = "lblUsu";
            lblUsu.Size = new Size(58, 21);
            lblUsu.Text = " lblUsu";
            // 
            // lblEmpleado
            // 
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(96, 21);
            lblEmpleado.Text = "lblEmpleado";
            // 
            // lblCargo
            // 
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(69, 21);
            lblCargo.Text = "lblCargo";
            // 
            // lblReloj
            // 
            lblReloj.Name = "lblReloj";
            lblReloj.Size = new Size(62, 21);
            lblReloj.Text = "lblReloj";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // frmmenuprincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1608, 1026);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "frmmenuprincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "menu principal";
            Load += frmmenuprincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem tsmArchivo;
        private ToolStripMenuItem tsmiCerrarSesion;
        private ToolStripMenuItem tsmiSalir;
        private ToolStripMenuItem tsmMantenimientoSimple;
        private ToolStripMenuItem tsmMantenimientoPrincipal;
        private ToolStripMenuItem tsmProceso;
        private ToolStripMenuItem tsmiVenta;
        private ToolStripMenuItem tsmiListadoVenta;
        private ToolStripMenuItem tsmiCategoria;
        private ToolStripMenuItem tsmiMarca;
        private ToolStripMenuItem tsmiRol;
        private ToolStripMenuItem tsmiDistrito;
        private ToolStripMenuItem tsmiSexo;
        private ToolStripMenuItem tsmiTipoDocumento;
        private ToolStripMenuItem tsmiProducto;
        private ToolStripMenuItem tsmiCliente;
        private ToolStripMenuItem tsmiEmpleado;
        private ToolStripMenuItem tsmReporte;
        private ToolStripMenuItem tsmUtilidades;
        private ToolStripMenuItem blockDeNotasToolStripMenuItem;
        private ToolStripMenuItem wordToolStripMenuItem;
        private ToolStripMenuItem calculadoraToolStripMenuItem;
        private ToolStripMenuItem excelToolStripMenuItem;
        private ToolStripStatusLabel lblReloj;
        private ToolStripStatusLabel lblCargo;
        private ToolStripStatusLabel lblUsu;
        private System.Windows.Forms.Timer timer1;
        private ToolStripStatusLabel lblEmpleado;
    }
}