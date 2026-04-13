using System.Text.RegularExpressions;

namespace Gestión_de_Inventario_de_Productos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Regla: Fecha de vencimiento deshabilitada por defecto
            dtpFechaVencimiento.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // 1. Limpiar campos de error antes de empezar
            errorProvider1.Clear();

            // 2. Ejecutar validación
            if (ValidarTodo())
            {
                // Si pasa las validaciones, procesamos la lógica
                string tipoIva = rbExento.Checked ? "Exento (0%)" :
                                 rbGeneral.Checked ? "General (19%)" : "Reducido (5%)";

                string mensaje = $"Producto Registrado:\n" +
                                 $"Código: {txtCodigo.Text}\n" +
                                 $"IVA: {tipoIva}\n" +
                                 $"Stock: {numStockInicial.Value}";

                MessageBox.Show(mensaje, "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidarTodo()
        {
            bool esValido = true;

            // Validación 1: Código PROD-0000
            if (!Regex.IsMatch(txtCodigo.Text, @"^PROD-\d{4}$"))
            {
                errorProvider1.SetError(txtCodigo, "Formato inválido. Debe ser PROD- seguido de 4 números.");
                esValido = false;
            }

            // Validación 2: Nombre vacío
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                errorProvider1.SetError(txtNombreProducto, "El nombre del producto es obligatorio.");
                esValido = false;
            }

            // Validación 3: Categoría seleccionada
            if (cmbCategoria.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbCategoria, "Seleccione una categoría válida.");
                esValido = false;
            }

            // Validación 4: Validación Cruzada (Stock Inicial < Stock Mínimo)
            if (numStockInicial.Value < numStockMinimo.Value)
            {
                errorProvider1.SetError(numStockInicial, "El stock inicial no puede ser menor al stock mínimo.");
                esValido = false;
            }

            // Validación 5: RadioButtons de IVA
            if (!rbExento.Checked && !rbGeneral.Checked && !rbReducido.Checked)
            {
                // Ponemos el error en el GroupBox para que sea visible
                errorProvider1.SetError(gbIVA, "Debe seleccionar un tipo de IVA.");
                esValido = false;
            }

            // Validación 6: Fecha de vencimiento (si es perecedero)
            if (chkEsPerecedero.Checked && dtpFechaVencimiento.Value.Date < DateTime.Now.Date)
            {
                errorProvider1.SetError(dtpFechaVencimiento, "La fecha de vencimiento no puede ser anterior a hoy.");
                esValido = false;
            }

            return esValido;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNombreProducto.Clear();
            cmbCategoria.SelectedIndex = -1;
            numStockInicial.Value = 0;
            numStockMinimo.Value = 0;
            chkEsPerecedero.Checked = false;
            rbExento.Checked = false;
            rbGeneral.Checked = false;
            rbReducido.Checked = false;
            errorProvider1.Clear();
        }

        private void chkEsPerecedero_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaVencimiento.Enabled = chkEsPerecedero.Checked;

            // Si deja de ser perecedero, limpiamos posibles errores de fecha
            if (!chkEsPerecedero.Checked)
            {
                errorProvider1.SetError(dtpFechaVencimiento, "");
            }
        }
    }
}
