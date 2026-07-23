using pe.com.fertec.bal;
using pe.com.fertec.bo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pe.com.fertec.ui
{
    public partial class frmventa : Form
    {
        private VentaBAL objVenta = new VentaBAL();
        private ClienteBAL objCliente = new ClienteBAL();
        private ProductoBAL objProducto = new ProductoBAL();
        private decimal totalVenta = 0;
        public frmventa()
        {
            InitializeComponent();
        }

        private void frmventa_Load(object sender, EventArgs e)
        {
            dgvDetalle.Columns.Clear();
            dgvDetalle.Columns.Add("codpro", "Código");
            dgvDetalle.Columns.Add("nompro", "Producto");
            dgvDetalle.Columns.Add("cantidad", "Cantidad");
            dgvDetalle.Columns.Add("precio", "Precio");
            dgvDetalle.Columns.Add("subtotal", "Subtotal");

            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalle.AllowUserToAddRows = false;

            cmbCliente.DataSource = objCliente.findAllCustom();
            cmbCliente.DisplayMember = "nombre";
            cmbCliente.ValueMember = "codigo";
            cmbCliente.SelectedIndex = -1;

            cmbProducto.DataSource = objProducto.findAllCustom();
            cmbProducto.DisplayMember = "nombre";
            cmbProducto.ValueMember = "codigo";
            cmbProducto.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex == -1 || string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Seleccione un producto y digite la cantidad.");
                return;
            }

            ProductoBO prodSeleccionado = (ProductoBO)cmbProducto.SelectedItem;

            int codProducto = prodSeleccionado.codigo;
            string nomProducto = prodSeleccionado.nombre;
            decimal precio = prodSeleccionado.precio;
            int cantidad = Convert.ToInt32(txtCantidad.Text);

            decimal subtotal = cantidad * precio;

            dgvDetalle.Rows.Add(codProducto, nomProducto, cantidad, precio, subtotal);

            totalVenta += subtotal;
            lblTotal.Text = "Total: S/ " + totalVenta.ToString("0.00");

            cmbProducto.SelectedIndex = -1;
            txtCantidad.Clear();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en el carrito para registrar.");
                return;
            }

            if (cmbCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un cliente en la parte superior.");
                return;
            }

            VentaBO nuevaVenta = new VentaBO();
            nuevaVenta.estado = true;

            nuevaVenta.cliente = new ClienteBO();
            nuevaVenta.cliente.codigo = Convert.ToInt32(cmbCliente.SelectedValue);


            nuevaVenta.empleado = new EmpleadoBO();
            nuevaVenta.empleado.codigo = 1;

            nuevaVenta.detalles = new List<DetalleVentaBO>();

            foreach (DataGridViewRow fila in dgvDetalle.Rows)
            {
                DetalleVentaBO detalle = new DetalleVentaBO();
                detalle.codigoproducto = Convert.ToInt32(fila.Cells["codpro"].Value);
                detalle.cantidad = Convert.ToInt32(fila.Cells["cantidad"].Value);
                detalle.precio = Convert.ToDecimal(fila.Cells["precio"].Value);

                nuevaVenta.detalles.Add(detalle);
            }

            bool exito = objVenta.add(nuevaVenta);

            if (exito)
            {
                MessageBox.Show("¡Venta registrada correctamente en la base de datos!");

                dgvDetalle.Rows.Clear();
                totalVenta = 0;
                lblTotal.Text = "Total: S/ 0.00";
                cmbCliente.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Ocurrió un error al registrar la venta.");
            }
        }
    }
}
