using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Sistema_de_Reserva_de_Hotel
{
  
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConfiguracionInicial();
        }

        private void ConfiguracionInicial()
        {
            // Valores por defecto al iniciar
            dtpEntrada.Value = DateTime.Today;
            dtpSalida.Value = DateTime.Today.AddDays(1);
            numPersonas.Value = 1;
            txtCliente.Focus();
        }

        private void btnCalcularReserva_Click(object sender, EventArgs e)
        {
            // 1. Limpiar notificaciones de error previas
            errorProvider1.Clear();

            // 2. Validar si los datos ingresados son correctos
            if (ValidarFormulario())
            {
                EjecutarCalculoReserva();
            }
        }

        private bool ValidarFormulario()
        {
            bool esValido = true;

            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                errorProvider1.SetError(txtCliente, "El nombre del cliente es necesario.");
                esValido = false;
            }

            if (dtpEntrada.Value.Date < DateTime.Today)
            {
                errorProvider1.SetError(dtpEntrada, "No se puede reservar en fechas pasadas.");
                esValido = false;
            }

            if (dtpSalida.Value.Date <= dtpEntrada.Value.Date)
            {
                errorProvider1.SetError(dtpSalida, "La salida debe ser después de la entrada.");
                esValido = false;
            }

            return esValido;
        }

        private void EjecutarCalculoReserva()
        {
            // Creamos el objeto de la clase lógica (abajo definida)
            CalculadoraReserva calculadora = new CalculadoraReserva();

            // Pasamos los datos del formulario a la lógica
            calculadora.NombreHuesped = txtCliente.Text.Trim();
            calculadora.DiasEstancia = (dtpSalida.Value.Date - dtpEntrada.Value.Date).Days;
            calculadora.CantidadPersonas = (int)numPersonas.Value;

            // Recorremos el CheckedListBox para los servicios
            foreach (var item in clbServicios.CheckedItems)
            {
                calculadora.ServiciosEspeciales.Add(item.ToString());
            }

            // Mostramos el resultado final
            ImprimirResumen(calculadora);
        }

        private void ImprimirResumen(CalculadoraReserva cal)
        {
            rtbResumen.Clear();
            StringBuilder reporte = new StringBuilder();

            reporte.AppendLine("   ╔═════════════════════════════════╗");
            reporte.AppendLine("      CONFIRMACIÓN DE RESERVACIÓN     ");
            reporte.AppendLine("   ╚═════════════════════════════════╝");
            reporte.AppendLine($"   CLIENTE: {cal.NombreHuesped.ToUpper()}");
            reporte.AppendLine($"   NOCHES:  {cal.DiasEstancia}");
            reporte.AppendLine($"   GRUPO:   {cal.CantidadPersonas} persona(s)");

            string serviciosTexto = cal.ServiciosEspeciales.Count > 0
                ? string.Join(", ", cal.ServiciosEspeciales)
                : "Ninguno";

            reporte.AppendLine($"   EXTRAS:  {serviciosTexto}");
            reporte.AppendLine("   -----------------------------------");
            reporte.AppendLine($"   VALOR TOTAL: {cal.ObtenerTotal():C2}");
            reporte.AppendLine("   -----------------------------------");

            rtbResumen.Text = reporte.ToString();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            // Resetear todos los controles
            txtCliente.Clear();
            ConfiguracionInicial();
            rtbResumen.Clear();
            errorProvider1.Clear();

            for (int i = 0; i < clbServicios.Items.Count; i++)
            {
                clbServicios.SetItemChecked(i, false);
            }
        }

        private void Form1_Load(object sender, EventArgs e) { }
    }

    
    public class CalculadoraReserva
    {
        // Propiedades de datos
        public string NombreHuesped { get; set; }
        public int DiasEstancia { get; set; }
        public int CantidadPersonas { get; set; }
        public List<string> ServiciosEspeciales { get; set; } = new List<string>();

        // Precios fijos (puedes cambiarlos aquí si necesitas)
        private const decimal PRECIO_POR_NOCHE = 50.00m;
        private const decimal RECARGO_POR_PERSONA = 15.00m;
        private const decimal PRECIO_POR_SERVICIO = 10.00m;

        public decimal ObtenerTotal()
        {
            // 1. Costo base del alojamiento
            decimal totalHospedaje = DiasEstancia * PRECIO_POR_NOCHE;

            // 2. Si hay más de una persona, sumamos el extra por noche
            decimal totalExtra = 0;
            if (CantidadPersonas > 1)
            {
                totalExtra = (CantidadPersonas - 1) * RECARGO_POR_PERSONA * DiasEstancia;
            }

            // 3. Servicios adicionales multiplicados por la duración
            decimal totalServicios = ServiciosEspeciales.Count * PRECIO_POR_SERVICIO * DiasEstancia;

            return totalHospedaje + totalExtra + totalServicios;
        }
    }
}