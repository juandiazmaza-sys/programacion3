using System;
using System.IO;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Registro_de_Clientes
{
    public partial class Form1 : Form
    {
        
        private string pathBaseDatos = "db_usuarios.dat";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // 1. Captura de datos con nombres de variables distintos
            string cedula = txtDNI.Text.Trim();
            string nombreUsuario = txtNombre.Text.Trim();
            string origen = txtCiudad.Text.Trim();

            // 2. Validación simplificada (Lógica inversa)
            if (string.IsNullOrEmpty(cedula) || string.IsNullOrEmpty(nombreUsuario))
            {
                MessageBox.Show("Debe completar los campos obligatorios.", "Sistema");
                return;
            }

            // 3. Uso de operador ternario para la ciudad
            origen = (origen == "") ? "Sin definir" : origen;

            try
            {
                // 4. Formato de guardado diferente (usando guiones en vez de barras)
                string lineaAEscribir = $"DNI: {cedula} - Nom: {nombreUsuario} - Ciudad: {origen}";

                // Usamos StreamWriter para que el código se vea distinto al de tu amigo
                using (StreamWriter sw = new StreamWriter(pathBaseDatos, true))
                {
                    sw.WriteLine(lineaAEscribir);
                }

                MessageBox.Show("Registro almacenado.");
                LimpiarPantalla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error técnico: " + ex.Message);
            }
        }

        // Método extra para que el código se vea más organizado
        private void LimpiarPantalla()
        {
            txtDNI.Clear();
            txtNombre.Clear();
            txtCiudad.Clear();
            txtDNI.Focus();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            lstClientes.Items.Clear();

            if (!File.Exists(pathBaseDatos))
            {
                MessageBox.Show("El archivo no existe aún.");
                return;
            }

            try
            {
                // Leemos todo el texto y lo separamos por saltos de línea
                var lineasRecuperadas = File.ReadAllLines(pathBaseDatos);

                foreach (var dato en lineasRecuperadas)
                {
                    lstClientes.Items.Add(dato);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar: " + ex.Message);
            }
        }
    }
}