using System;
using System.Drawing; // Para personalización de colores
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace REGISTRO_EMPLEADOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Configuramos el rango del sueldo por seguridad
            numSueldoBase.Minimum = 1000;
            numSueldoBase.Maximum = 10000;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Limpiamos errores anteriores
            errorProvider1.Clear();

            // 1. Validaciones
            if (!ValidarCampos()) return;

            try
            {
                // 2. Lógica de Negocio
                decimal sueldoBase = numSueldoBase.Value;
                decimal retencion = sueldoBase * 0.10m; // 10% de impuestos
                decimal sueldoNeto = sueldoBase - retencion;

                // 3. Mostrar resultado en el cuadro (TextBox)
                // "C2" aplica formato de moneda según la región del sistema
                txtResultadoNeto.Text = sueldoNeto.ToString("C2");

                // Cambiamos el color del texto para que resalte el éxito
                txtResultadoNeto.ForeColor = Color.DarkGreen;
                txtResultadoNeto.Font = new Font(txtResultadoNeto.Font, FontStyle.Bold);

                MessageBox.Show("Empleado registrado y cálculo finalizado.", "Sistema",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el proceso: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            bool esValido = true;

            // Nombres y Apellidos
            if (string.IsNullOrWhiteSpace(txtNombres.Text))
            {
                errorProvider1.SetError(txtNombres, "Ingrese los nombres");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                errorProvider1.SetError(txtApellidos, "Ingrese los apellidos");
                esValido = false;
            }

            // Departamento
            if (cmbDepartamento.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbDepartamento, "Seleccione un departamento");
                esValido = false;
            }

            // Email con Regex mejorado
            string patronEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(txtEmail.Text, patronEmail))
            {
                errorProvider1.SetError(txtEmail, "Correo no válido");
                esValido = false;
            }

            // Identificación (Exactamente 10 dígitos)
            if (!Regex.IsMatch(txtIdentificacion.Text, @"^\d{10}$"))
            {
                errorProvider1.SetError(txtIdentificacion, "La identificación debe tener 10 números");
                esValido = false;
            }

            return esValido;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar cajas de texto
            txtNombres.Clear();
            txtApellidos.Clear();
            txtEmail.Clear();
            txtIdentificacion.Clear();

            // Resetear controles de selección
            numSueldoBase.Value = 1000;
            cmbDepartamento.SelectedIndex = -1;

            // Limpiar cuadro de resultado
            txtResultadoNeto.Clear();
            txtResultadoNeto.ForeColor = SystemColors.WindowText; // Volver al color normal

            // Limpiar alertas
            errorProvider1.Clear();

            // Poner el foco en el primer campo
            txtNombres.Focus();
        }
    }
}