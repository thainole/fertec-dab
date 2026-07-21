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
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmArchivo, tsmMantenimientoSimple, tsmMantenimientoPrincipal, tsmProceso, tsmReporte, tsmUtilidades });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1251, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmArchivo
            // 
            tsmArchivo.DropDownItems.AddRange(new ToolStripItem[] { tsmiCerrarSesion, tsmiSalir });
            tsmArchivo.Name = "tsmArchivo";
            tsmArchivo.Size = new Size(60, 20);
            tsmArchivo.Text = "Archivo";
            // 
            // tsmiCerrarSesion
            // 
            tsmiCerrarSesion.Name = "tsmiCerrarSesion";
            tsmiCerrarSesion.Size = new Size(143, 22);
            tsmiCerrarSesion.Text = "Cerrar Sesion";
            tsmiCerrarSesion.Click += tsmiCerrarSesion_Click;
            // 
            // tsmiSalir
            // 
            tsmiSalir.Name = "tsmiSalir";
            tsmiSalir.Size = new Size(143, 22);
            tsmiSalir.Text = "Salir";
            tsmiSalir.Click += tsmiSalir_Click;
            // 
            // tsmMantenimientoSimple
            // 
            tsmMantenimientoSimple.DropDownItems.AddRange(new ToolStripItem[] { tsmiCategoria, tsmiMarca, tsmiRol, tsmiDistrito, tsmiSexo, tsmiTipoDocumento });
            tsmMantenimientoSimple.Name = "tsmMantenimientoSimple";
            tsmMantenimientoSimple.Size = new Size(145, 20);
            tsmMantenimientoSimple.Text = "Mantenimiento Simples";
            // 
            // tsmiCategoria
            // 
            tsmiCategoria.Name = "tsmiCategoria";
            tsmiCategoria.Size = new Size(180, 22);
            tsmiCategoria.Text = "Categoria";
            tsmiCategoria.Click += tsmiCategoria_Click;
            // 
            // tsmiMarca
            // 
            tsmiMarca.Name = "tsmiMarca";
            tsmiMarca.Size = new Size(180, 22);
            tsmiMarca.Text = "Marca";
            // 
            // tsmiRol
            // 
            tsmiRol.Name = "tsmiRol";
            tsmiRol.Size = new Size(180, 22);
            tsmiRol.Text = "Rol";
            // 
            // tsmiDistrito
            // 
            tsmiDistrito.Name = "tsmiDistrito";
            tsmiDistrito.Size = new Size(180, 22);
            tsmiDistrito.Text = "Distrito";
            // 
            // tsmiSexo
            // 
            tsmiSexo.Name = "tsmiSexo";
            tsmiSexo.Size = new Size(180, 22);
            tsmiSexo.Text = "Sexo";
            // 
            // tsmiTipoDocumento
            // 
            tsmiTipoDocumento.Name = "tsmiTipoDocumento";
            tsmiTipoDocumento.Size = new Size(180, 22);
            tsmiTipoDocumento.Text = "Tipo de Documento";
            // 
            // tsmMantenimientoPrincipal
            // 
            tsmMantenimientoPrincipal.DropDownItems.AddRange(new ToolStripItem[] { tsmiProducto, tsmiCliente, tsmiEmpleado });
            tsmMantenimientoPrincipal.Name = "tsmMantenimientoPrincipal";
            tsmMantenimientoPrincipal.Size = new Size(161, 20);
            tsmMantenimientoPrincipal.Text = "Mantenimiento Principales";
            // 
            // tsmiProducto
            // 
            tsmiProducto.Name = "tsmiProducto";
            tsmiProducto.Size = new Size(127, 22);
            tsmiProducto.Text = "Producto";
            // 
            // tsmiCliente
            // 
            tsmiCliente.Name = "tsmiCliente";
            tsmiCliente.Size = new Size(127, 22);
            tsmiCliente.Text = "Cliente";
            // 
            // tsmiEmpleado
            // 
            tsmiEmpleado.Name = "tsmiEmpleado";
            tsmiEmpleado.Size = new Size(127, 22);
            tsmiEmpleado.Text = "Empleado";
            // 
            // tsmProceso
            // 
            tsmProceso.DropDownItems.AddRange(new ToolStripItem[] { tsmiVenta, tsmiListadoVenta });
            tsmProceso.Name = "tsmProceso";
            tsmProceso.Size = new Size(61, 20);
            tsmProceso.Text = "Proceso";
            // 
            // tsmiVenta
            // 
            tsmiVenta.Name = "tsmiVenta";
            tsmiVenta.Size = new Size(160, 22);
            tsmiVenta.Text = "Venta ";
            // 
            // tsmiListadoVenta
            // 
            tsmiListadoVenta.Name = "tsmiListadoVenta";
            tsmiListadoVenta.Size = new Size(160, 22);
            tsmiListadoVenta.Text = "Listado de Venta";
            // 
            // tsmReporte
            // 
            tsmReporte.Name = "tsmReporte";
            tsmReporte.Size = new Size(65, 20);
            tsmReporte.Text = "Reportes";
            // 
            // tsmUtilidades
            // 
            tsmUtilidades.DropDownItems.AddRange(new ToolStripItem[] { blockDeNotasToolStripMenuItem, wordToolStripMenuItem, calculadoraToolStripMenuItem, excelToolStripMenuItem });
            tsmUtilidades.Name = "tsmUtilidades";
            tsmUtilidades.Size = new Size(71, 20);
            tsmUtilidades.Text = "Utilidades";
            // 
            // blockDeNotasToolStripMenuItem
            // 
            blockDeNotasToolStripMenuItem.Name = "blockDeNotasToolStripMenuItem";
            blockDeNotasToolStripMenuItem.Size = new Size(151, 22);
            blockDeNotasToolStripMenuItem.Text = "Block de notas";
            // 
            // wordToolStripMenuItem
            // 
            wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            wordToolStripMenuItem.Size = new Size(151, 22);
            wordToolStripMenuItem.Text = "Word";
            // 
            // calculadoraToolStripMenuItem
            // 
            calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            calculadoraToolStripMenuItem.Size = new Size(151, 22);
            calculadoraToolStripMenuItem.Text = "Calculadora";
            // 
            // excelToolStripMenuItem
            // 
            excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            excelToolStripMenuItem.Size = new Size(151, 22);
            excelToolStripMenuItem.Text = "Excel";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblUsu, lblEmpleado, lblCargo, lblReloj });
            statusStrip1.Location = new Point(0, 711);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1251, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblUsu
            // 
            lblUsu.Name = "lblUsu";
            lblUsu.Size = new Size(43, 17);
            lblUsu.Text = " lblUsu";
            // 
            // lblEmpleado
            // 
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(73, 17);
            lblEmpleado.Text = "lblEmpleado";
            // 
            // lblCargo
            // 
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(52, 17);
            lblCargo.Text = "lblCargo";
            // 
            // lblReloj
            // 
            lblReloj.Name = "lblReloj";
            lblReloj.Size = new Size(46, 17);
            lblReloj.Text = "lblReloj";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // frmmenuprincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 733);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
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