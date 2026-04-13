namespace Sistema_de_Reserva_de_Hotel
{
    public partial class Form1 : Form
    {
        // --- CONSTANTES DE COSTO (Faltaban en tu código) ---
        const decimal COSTO_NOCHE_BASE = 50m;
        const decimal COSTO_PERSONA_EXTRA = 15m;
        const decimal COSTO_SERVICIO_DIARIO = 10m;
        public Form1()
        {
            InitializeComponent();
            dtpEntrada.Value = DateTime.Today;
            dtpSalida.Value = DateTime.Today.AddDays(1);
        }

        private void btnCalcularReserva_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            rtbResumen.Clear();

            if (ValidarReserva())
            {
                CalcularYMostrarResumen();
            }
        }


        private bool ValidarReserva()
        {
            bool esValido = true;

            // 1. Validar nombre del cliente
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                errorProvider1.SetError(txtCliente, "El nombre del cliente es obligatorio.");
                esValido = false;
            }

            // 2. Validar Fecha de Entrada (No anterior a hoy)
            if (dtpEntrada.Value.Date < DateTime.Today)
            {
                errorProvider1.SetError(dtpEntrada, "La fecha de entrada no puede ser anterior a hoy.");
                esValido = false;
            }

            // 3. Validar Fecha de Salida (Al menos un día después de entrada)
            if (dtpSalida.Value.Date <= dtpEntrada.Value.Date)
            {
                errorProvider1.SetError(dtpSalida, "La fecha de salida debe ser al menos un día posterior a la entrada.");
                esValido = false;
            }

            return esValido;
        }


        private void CalcularYMostrarResumen()
        {
            // Cálculo de días usando TimeSpan
            TimeSpan diferencia = dtpSalida.Value.Date - dtpEntrada.Value.Date;
            int noches = diferencia.Days;

            // Lógica de Costos
            decimal costoHospedaje = noches * COSTO_NOCHE_BASE;

            // Personas adicionales (a partir de la segunda)
            decimal costoPersonasExtra = 0;
            if (numPersonas.Value > 1)
            {
                costoPersonasExtra = (numPersonas.Value - 1) * COSTO_PERSONA_EXTRA * noches;
            }

            // Servicios adicionales (CheckedListBox)
            decimal costoServicios = 0;
            List<string> serviciosSeleccionados = new List<string>();

            foreach (var item in clbServicios.CheckedItems)
            {
                serviciosSeleccionados.Add(item.ToString());
                costoServicios += COSTO_SERVICIO_DIARIO * noches;
            }

            decimal totalFinal = costoHospedaje + costoPersonasExtra + costoServicios;

            // Construcción del Resumen en el RichTextBox
            rtbResumen.AppendText("--- RESUMEN DE RESERVA ---\n");
            rtbResumen.AppendText($"Cliente: {txtCliente.Text}\n");
            rtbResumen.AppendText($"Estancia: {noches} noches.\n");
            rtbResumen.AppendText($"Personas: {numPersonas.Value}\n");
            rtbResumen.AppendText($"Servicios: {(serviciosSeleccionados.Count > 0 ? string.Join(", ", serviciosSeleccionados) : "Ninguno")}\n");
            rtbResumen.AppendText("--------------------------\n");
            rtbResumen.AppendText($"TOTAL A PAGAR: {totalFinal:C2}");
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            dtpEntrada.Value = DateTime.Today;
            dtpSalida.Value = DateTime.Today.AddDays(1);
            numPersonas.Value = 1;
            rtbResumen.Clear();
            errorProvider1.Clear();

            // Desmarcar todos los servicios del CheckedListBox
            for (int i = 0; i < clbServicios.Items.Count; i++)
            {
                clbServicios.SetItemChecked(i, false);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
