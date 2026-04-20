using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Control_de_Ventas_Diarias 
{
    public partial class Form1 : Form
    {
        
        private readonly string rutaLog = "bitacora_ventas.txt";

        public Form1()
        {
            InitializeComponent();
        }

       
        struct RegistroVenta
        {
            public string Codigo;
            public double Importe;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Captura de datos
            string idIngresado = txtID.Text.Trim();
            double montoIngresado = (double)numMonto.Value;

            if (string.IsNullOrEmpty(idIngresado))
            {
                MessageBox.Show("Debe asignar un identificador.", "Error de entrada");
                return;
            }

            try
            {
                // Guardamos usando un separador de "flecha" para que sea visualmente distinto
                string nuevaLinea = $"{idIngresado} => {montoIngresado}";

                using (StreamWriter sw = new StreamWriter(rutaLog, true))
                {
                    sw.WriteLine(nuevaLinea);
                }

                // Limpieza de interfaz
                txtID.Clear();
                numMonto.Value = 0;
                txtID.Focus();

                MessageBox.Show("Operación guardada.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo al guardar: " + ex.Message);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            lstHistorial.Items.Clear();
            double totalGeneral = 0;

            if (!File.Exists(rutaLog))
            {
                MessageBox.Show("No se encontraron registros previos.");
                return;
            }

            try
            {
                // Leemos usando un método más moderno
                string[] contenido = File.ReadAllLines(rutaLog);

                foreach (string fila in contenido)
                {
                    if (fila.Contains(" => "))
                    {
                        // Separamos por la "flecha" que definimos arriba
                        string[] datos = fila.Split(new string[] { " => " }, StringSplitOptions.None);

                        string id = datos[0];
                        double valor = double.Parse(datos[1]);

                        // Agregamos al ListBox con un formato limpio
                        lstHistorial.Items.Add($"Transacción: {id} | Total: {valor:F2}");

                        totalGeneral += valor;
                    }
                }

                // Actualizamos el label