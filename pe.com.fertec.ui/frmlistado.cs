using pe.com.fertec.bal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pe.com.fertec.ui
{
    public partial class frmlistado : Form
    {
        private VentaBAL objVenta = new VentaBAL();
        public frmlistado()
        {
            InitializeComponent();
        }

        private void frmlistado_Load(object sender, EventArgs e)
        {
            dgvListado.Columns.Clear();
            dgvListado.Columns.Add("numventa", "N° Venta");
            dgvListado.Columns.Add("fecha", "Fecha");
            dgvListado.Columns.Add("cliente", "Cliente");
            dgvListado.Columns.Add("empleado", "Empleado");
            dgvListado.Columns.Add("total", "Total (S/)");

            dgvListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListado.AllowUserToAddRows = false;
            dgvListado.ReadOnly = true;

            var listaVentas = objVenta.findAll();

            if (listaVentas != null)
            {
                foreach (var v in listaVentas)
                {
                    dgvListado.Rows.Add(
                        v.numventa,
                        v.fecha.ToString("dd/MM/yyyy"),
                        v.cliente.nombre,
                        v.empleado.nombre,
                        v.total.ToString("0.00")
                    );
                }
            }
        }
    }
}
