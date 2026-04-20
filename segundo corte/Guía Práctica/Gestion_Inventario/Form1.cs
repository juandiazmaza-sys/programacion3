using System;
using System.IO;
using System.Windows.Forms;
using System.Text; 

namespace Gestión_de_Inventario
{
    public partial class Form1 : Form
    {
        
        private readonly string RUTA_ALMACEN = "bodega_datos.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            RegistrarNuevoItem();
        }

        private void RegistrarNuevoItem()
        {
            
            var art = txtNombre.Text.Trim();
            var sku = txtCodigo.Text.Trim();
            var precioUnidad = numCosto.Value;
            var stock = (int)numCantidad.Value;

            // Validación básica
            if (string.IsNullOrEmpty(art) || string.IsNullOrEmpty(sku))
            {
                MessageBox.Show("Nombre y Código son requeridos.");
                return;
            }

            try
            {
               
                StringBuilder constructorFila = new StringBuilder();
                constructorFila.Append($"ITEM:{art} | ");
                constructorFila.Append($"SKU:{sku} | ");
                constructorFila.Append($"VALOR:{precioUnidad} | ");
                constructorFila.Append($"QTY:{stock}");

                using (StreamWriter sw = new StreamWriter(RUTA_ALMACEN, true))
                {
                    sw.WriteLine(constructorFila.ToString());
                }

                LimpiarInterfaz();
                MessageBox.Show("Inventario actualizado en el sistema.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo de escritura: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            RefrescarLista();
        }

        private void RefrescarLista()
        {
            lstProductos.Items.Clear();

            if (!File.Exists(RUTA_ALMACEN))
            {
                MessageBox.Show("La base de datos está vacía.");
                return;
            }

            try
            {
                var registros = File.ReadLines(RUTA_ALMACEN);

                foreach (var registro in registros)
                {
                    if (!string.IsNullOrWhiteSpace(registro))
                    {
                        
                        lstProductos.Items.Add("-> " + registro);
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error al acceder al disco: " + ex.Message);
            }
        }

        private void LimpiarInterfaz()
        {
            txtNombre.Clear();
            txtCodigo.Clear();
            numCosto.Value = 0;
            numCantidad.Value = 0;
            txtNombre.Focus();
        }
    }
}
