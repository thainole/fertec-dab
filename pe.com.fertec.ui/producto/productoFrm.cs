using pe.com.fertec.bal;
using pe.com.fertec.bo;
using System.Globalization;

namespace pe.com.fertec.ui
{
    public partial class productoFrm : Form
    {
        private readonly ProductoBAL bal = new ProductoBAL();
        private readonly CategoriaBAL categoriaBAL = new CategoriaBAL();
        private readonly MarcaBAL marcaBAL = new MarcaBAL();
        private int indice = -1;

        public productoFrm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Habilitar(false);
            SoloLectura();
            ConfigurarDGV();
        }

        private void productoFrm_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            CargarMarcas();
            Listar();
            CargarCodigo();
        }

        private void ConfigurarDGV()
        {
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.MultiSelect = false;
            dgvProductos.ReadOnly = true;
            dgvProductos.Columns.Clear();
            dgvProductos.ClearSelection();
            dgvProductos.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvProductos.GridColor = Color.LightGray;
            dgvProductos.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "codigo",
                HeaderText = "Código",
                DataPropertyName = "codigo",
                Width = 70
            });
            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "nombre",
                HeaderText = "Nombre",
                DataPropertyName = "nombre",
                Width = 140
            });
            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "descripcion",
                HeaderText = "Descripción",
                DataPropertyName = "descripcion",
                Width = 210
            });
            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "precio",
                HeaderText = "Precio",
                DataPropertyName = "precio",
                Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });
            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "stock",
                HeaderText = "Stock",
                DataPropertyName = "stock",
                Width = 70
            });
            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "fecharegistro",
                HeaderText = "Fecha de registro",
                DataPropertyName = "fecharegistro",
                Width = 115,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });
            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "estado",
                HeaderText = "Estado",
                DataPropertyName = "estado",
                Width = 95
            });
            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "categoria",
                HeaderText = "Categoría",
                DataPropertyName = "categoria",
                Width = 130
            });
            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "marca",
                HeaderText = "Marca",
                DataPropertyName = "marca",
                Width = 130
            });

            dgvProductos.CellFormatting += dgvProductos_CellFormatting;
        }

        private void dgvProductos_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.Value == null)
            {
                return;
            }

            string nombreColumna = dgvProductos.Columns[e.ColumnIndex].Name;

            if (nombreColumna == "estado" && e.Value is bool estado)
            {
                e.Value = estado ? "Habilitado" : "Deshabilitado";
                e.FormattingApplied = true;
            }
            else if (nombreColumna == "categoria" && e.Value is CategoriaBO categoria)
            {
                e.Value = categoria.nombre;
                e.FormattingApplied = true;
            }
            else if (nombreColumna == "marca" && e.Value is MarcaBO marca)
            {
                e.Value = marca.nombre;
                e.FormattingApplied = true;
            }
        }

        private void Habilitar(bool habilitado)
        {
            txtCodigo.Enabled = habilitado;
            txtNombre.Enabled = habilitado;
            txtDescripcion.Enabled = habilitado;
            txtPrecio.Enabled = habilitado;
            txtStock.Enabled = habilitado;
            dtpFechaRegistro.Enabled = habilitado;
            chkEstado.Enabled = habilitado;
            cboCategoria.Enabled = habilitado;
            cboMarca.Enabled = habilitado;
            btnRegistrar.Enabled = habilitado;
            btnActualizar.Enabled = habilitado;
            btnInhabilitar.Enabled = habilitado;
            btnHabilitar.Enabled = habilitado;
            btnCancelar.Enabled = habilitado;
        }

        private void SoloLectura()
        {
            txtCodigo.ReadOnly = true;
        }

        private void CargarCategorias()
        {
            try
            {
                List<CategoriaBO>? categorias = categoriaBAL.findAllCustom();
                cboCategoria.DataSource = categorias;
                cboCategoria.DisplayMember = "nombre";
                cboCategoria.ValueMember = "codigo";
                cboCategoria.SelectedIndex = -1;

                if (categorias == null)
                {
                    MessageBox.Show("No se pudieron cargar las categorías.", "Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                cboCategoria.DataSource = null;
                MessageBox.Show($"No se pudieron cargar las categorías. {ex.Message}", "Producto",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarMarcas()
        {
            try
            {
                List<MarcaBO>? marcas = marcaBAL.findAllCustom();
                cboMarca.DataSource = marcas;
                cboMarca.DisplayMember = "nombre";
                cboMarca.ValueMember = "codigo";
                cboMarca.SelectedIndex = -1;

                if (marcas == null)
                {
                    MessageBox.Show("No se pudieron cargar las marcas.", "Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                cboMarca.DataSource = null;
                MessageBox.Show($"No se pudieron cargar las marcas. {ex.Message}", "Producto",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Listar()
        {
            try
            {
                List<ProductoBO>? productos = chkMostrarTodos.Checked
                    ? bal.findAll()
                    : bal.findAllCustom();

                dgvProductos.DataSource = null;
                dgvProductos.DataSource = productos;
                dgvProductos.ClearSelection();
                indice = -1;

                if (productos == null)
                {
                    MessageBox.Show("No se pudo obtener la lista de productos.", "Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                dgvProductos.DataSource = null;
                MessageBox.Show($"No se pudo obtener la lista de productos. {ex.Message}", "Producto",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCodigo()
        {
            try
            {
                txtCodigo.Text = bal.setCode().ToString();
            }
            catch (Exception ex)
            {
                txtCodigo.Clear();
                MessageBox.Show($"No se pudo obtener el siguiente código. {ex.Message}", "Producto",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            dtpFechaRegistro.Value = DateTime.Today;
            chkEstado.Checked = true;
            cboCategoria.SelectedIndex = -1;
            cboMarca.SelectedIndex = -1;
            lblCategoriaActual.Text = "";
            lblMarcaActual.Text = "";
            lblRelaciones.Text = "";
            CargarCodigo();
            txtNombre.Focus();
        }

        private void PrepararNuevo()
        {
            Habilitar(true);
            Limpiar();
            btnNuevo.Enabled = false;
            btnRegistrar.Enabled = true;
            btnActualizar.Enabled = false;
            btnInhabilitar.Enabled = false;
            btnHabilitar.Enabled = false;
            indice = -1;
        }

        private void PrepararEdicion(ProductoBO producto)
        {
            Habilitar(true);
            btnNuevo.Enabled = true;
            btnRegistrar.Enabled = false;
            btnActualizar.Enabled = true;
            btnInhabilitar.Enabled = producto.estado;
            btnHabilitar.Enabled = !producto.estado;

            txtCodigo.Text = producto.codigo.ToString();
            txtNombre.Text = producto.nombre;
            txtDescripcion.Text = producto.descripcion;
            txtPrecio.Text = producto.precio.ToString("0.00", CultureInfo.CurrentCulture);
            txtStock.Text = producto.stock.ToString();
            dtpFechaRegistro.Value = producto.fecharegistro;
            chkEstado.Checked = producto.estado;

            lblCategoriaActual.Text = $"Actual: {producto.categoria?.nombre}";
            lblMarcaActual.Text = $"Actual: {producto.marca?.nombre}";

            bool categoriaSeleccionada = SeleccionarValor(cboCategoria, producto.categoria?.codigo ?? 0);
            bool marcaSeleccionada = SeleccionarValor(cboMarca, producto.marca?.codigo ?? 0);

            if (!categoriaSeleccionada || !marcaSeleccionada)
            {
                lblRelaciones.Text = "Seleccione categoría y marca antes de actualizar; el DAL actual no devuelve sus códigos.";
            }
            else
            {
                lblRelaciones.Text = "";
            }
        }

        private static bool SeleccionarValor(ComboBox comboBox, int codigo)
        {
            comboBox.SelectedIndex = -1;

            if (codigo <= 0)
            {
                return false;
            }

            comboBox.SelectedValue = codigo;
            return comboBox.SelectedIndex >= 0;
        }

        private bool ValidarDatos(out decimal precio, out int stock,
            out int codigoCategoria, out int codigoMarca)
        {
            precio = 0;
            stock = 0;
            codigoCategoria = 0;
            codigoMarca = 0;

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del producto.", "Producto",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrecio.Text.Trim(), NumberStyles.Number,
                    CultureInfo.CurrentCulture, out precio))
            {
                MessageBox.Show("Ingrese un precio numérico válido.", "Producto",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return false;
            }

            if (precio < 0)
            {
                MessageBox.Show("El precio debe ser mayor o igual que cero.", "Producto",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return false;
            }

            if (!int.TryParse(txtStock.Text.Trim(), out stock))
            {
                MessageBox.Show("Ingrese un stock entero válido.", "Producto",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStock.Focus();
                return false;
            }

            if (stock < 0)
            {
                MessageBox.Show("El stock debe ser mayor o igual que cero.", "Producto",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStock.Focus();
                return false;
            }

            if (!int.TryParse(cboCategoria.SelectedValue?.ToString(), out codigoCategoria))
            {
                MessageBox.Show("Seleccione una categoría.", "Producto",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCategoria.Focus();
                return false;
            }

            if (!int.TryParse(cboMarca.SelectedValue?.ToString(), out codigoMarca))
            {
                MessageBox.Show("Seleccione una marca.", "Producto",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMarca.Focus();
                return false;
            }

            return true;
        }

        private ProductoBO CrearProducto(decimal precio, int stock,
            int codigoCategoria, int codigoMarca)
        {
            return new ProductoBO
            {
                codigo = int.TryParse(txtCodigo.Text, out int codigo) ? codigo : 0,
                nombre = txtNombre.Text.Trim(),
                descripcion = txtDescripcion.Text.Trim(),
                precio = precio,
                stock = stock,
                fecharegistro = dtpFechaRegistro.Value.Date,
                estado = chkEstado.Checked,
                categoria = new CategoriaBO { codigo = codigoCategoria },
                marca = new MarcaBO { codigo = codigoMarca }
            };
        }

        private void FinalizarOperacion()
        {
            Listar();
            Limpiar();
            Habilitar(false);
            btnNuevo.Enabled = true;
            indice = -1;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            PrepararNuevo();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos(out decimal precio, out int stock,
                    out int codigoCategoria, out int codigoMarca))
            {
                return;
            }

            ProductoBO producto = CrearProducto(precio, stock, codigoCategoria, codigoMarca);

            try
            {
                if (bal.add(producto))
                {
                    MessageBox.Show("Producto registrado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FinalizarOperacion();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el producto.", "Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo registrar el producto. {ex.Message}", "Producto",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (indice < 0 || !int.TryParse(txtCodigo.Text, out int id))
            {
                MessageBox.Show("Seleccione un producto de la lista.", "Actualizar producto",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvProductos.Focus();
                return;
            }

            if (!ValidarDatos(out decimal precio, out int stock,
                    out int codigoCategoria, out int codigoMarca))
            {
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Desea actualizar el producto?",
                "Actualizar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            ProductoBO producto = CrearProducto(precio, stock, codigoCategoria, codigoMarca);

            try
            {
                if (bal.update(producto, id))
                {
                    MessageBox.Show("Producto actualizado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FinalizarOperacion();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el producto.", "Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo actualizar el producto. {ex.Message}", "Producto",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            if (indice < 0 || !int.TryParse(txtCodigo.Text, out int id))
            {
                MessageBox.Show("Seleccione un producto de la lista.", "Inhabilitar producto",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvProductos.Focus();
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Desea inhabilitar el producto?",
                "Inhabilitar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            try
            {
                if (bal.delete(id))
                {
                    MessageBox.Show("Producto inhabilitado correctamente.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FinalizarOperacion();
                }
                else
                {
                    MessageBox.Show("No se pudo inhabilitar el producto.", "Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo inhabilitar el producto. {ex.Message}", "Producto",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            if (indice < 0 || !int.TryParse(txtCodigo.Text, out int id))
            {
                MessageBox.Show("Seleccione un producto de la lista.", "Habilitar producto",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvProductos.Focus();
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Desea habilitar el producto?",
                "Habilitar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            try
            {
                if (bal.enable(id))
                {
                    MessageBox.Show("Producto habilitado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FinalizarOperacion();
                }
                else
                {
                    MessageBox.Show("No se pudo habilitar el producto.", "Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo habilitar el producto. {ex.Message}", "Producto",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBuscar.Text.Trim(), out int codigo) || codigo <= 0)
            {
                MessageBox.Show("Ingrese un código de producto válido.", "Buscar producto",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBuscar.Focus();
                return;
            }

            try
            {
                ProductoBO? producto = bal.findById(codigo);

                if (producto == null || producto.codigo <= 0)
                {
                    dgvProductos.DataSource = null;
                    MessageBox.Show("No se encontró el producto.", "Buscar producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dgvProductos.DataSource = new List<ProductoBO> { producto };
                dgvProductos.ClearSelection();
                indice = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo buscar el producto. {ex.Message}", "Buscar producto",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            Listar();
        }

        private void chkMostrarTodos_CheckedChanged(object sender, EventArgs e)
        {
            Listar();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;

            if (indice >= 0 && dgvProductos.Rows[indice].DataBoundItem is ProductoBO producto)
            {
                PrepararEdicion(producto);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Habilitar(false);
            btnNuevo.Enabled = true;
            dgvProductos.ClearSelection();
            indice = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
