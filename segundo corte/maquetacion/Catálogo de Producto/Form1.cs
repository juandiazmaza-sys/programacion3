namespace Catálogo_de_Producto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            numCantidad.Value = 1;
            numCantidad.Minimum = 1;
        }

        private void btnañadir_Click(object sender, EventArgs e)
        {
            decimal cantidad = numCantidad.Value;
            double total = 299.99 * (double)cantidad;

            // Feedback visual al usuario
            MessageBox.Show($"Has añadido {cantidad} unidad(es) al carrito.\nTotal: ${total:F2}",
                            "Carrito de Compras",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
