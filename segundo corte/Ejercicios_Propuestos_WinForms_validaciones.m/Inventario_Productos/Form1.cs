using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Gestión_de_Inventario_de_Productos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Estado inicial: fecha desactivada
            dtpFechaVencimiento.Enabled = false;
        }

        
       
        public class ProductoData
        {
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public string Categoria { get; set; }
            public int Stock { get; set; }
            public string Iva { get; set; }
            public bool Perecedero { get; set; }
            public DateTime Vencimiento { get; set; }

            public string ObtenerResumen()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(" REGISTRO EXITOSO");
                sb.AppendLine("=======================");
                sb.AppendLine($"ID: {Codigo}");
                sb.AppendLine($"Producto: {Nombre}");
                sb.AppendLine($"Impuesto: {Iva}");
                sb.AppendLine($"Stock Actual: {Stock}");
                if (Perecedero)
                    sb.AppendLine($"Expira el: {Vencimiento.ToShortDateString()}");

                return sb.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (RealizarValidaciones())
            {
                // Creamos el objeto con los datos
                ProductoData nuevoProd = new ProductoData
                {
                    Codigo = txtCodigo.Text.Trim(),
                    Nombre = txtNombreProducto.Text.Trim(),
                    Categoria = cmbCategoria.Text,
                    Stock = (int)numStockInicial.Value,
                    Iva = ConsultarIvaSeleccionado(),
                    Perecedero = chkEsPerecedero.Checked,
                    Vencimiento = dtpFechaVencimiento.Value
                };

                MessageBox.Show(nuevoProd.ObtenerResumen(), "Inventario",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string ConsultarIvaSeleccionado()
        {
            if (rbExento.Checked) return "Exento (0%)";
            if (rbReducido.Checked) return "Reducido (5%)";
            return "General (19%)";
        }

        private bool RealizarValidaciones()
        {
            errorProvider1.Clear();
            bool validado = true;

            // 1. Validar Código (PROD-0000)
            if (!Regex.IsMatch(txtCodigo.Text, @"^PROD-\d{4}$"))
            {
                errorProvider1.SetError(txtCodigo, "Formato incorrecto (PROD-1234)");
                validado = false;
            }

            // 2. Validar Nombre
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                errorProvider1.SetError(txtNombreProducto, "Escriba el nombre del producto");
                validado = false;
            }

            // 3. Validar Categoría
            if (cmbCategoria.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbCategoria, "Seleccione una categoría");
                validado = false;
            }

            // 4. Comparación de Stocks
            if (numStockInicial.Value < numStockMinimo.Value)
            {
                errorProvider1.SetError(numStockInicial, "El stock inicial no puede ser menor al mínimo");
                validado = false;
            }

            // 5. Validar RadioButtons de IVA
            if (!rbExento.Checked && !rbGeneral.Checked && !rbReducido.Checked)
            {
                errorProvider1.SetError(gbIVA, "Elija una opción de IVA");
                validado = false;
            }

            // 6. Validar Fecha si es perecedero
            if (chkEsPerecedero.Checked && dtpFechaVencimiento.Value.Date < DateTime.Today)
            {
                errorProvider1.SetError(dtpFechaVencimiento, "La fecha no puede ser pasada");
                validado = false;
            }

            return validado;
        }

        private void chkEsPerecedero_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaVencimiento.Enabled = chkEsPerecedero.Checked;
            if (!chkEsPerecedero.Checked) errorProvider1.SetError(dtpFechaVencimiento, "");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpieza inteligente de controles
            txtCodigo.Clear();
            txtNombreProducto.Clear();
            cmbCategoria.SelectedIndex = -1;
            numStockInicial.Value = 0;
            numStockMinimo.Value = 0;
            chkEsPerecedero.Checked = false;
            rbExento.Checked = rbGeneral.Checked = rbReducido.Checked = false;
            errorProvider1.Clear();
            txtCodigo.Focus();
        }
    }
}