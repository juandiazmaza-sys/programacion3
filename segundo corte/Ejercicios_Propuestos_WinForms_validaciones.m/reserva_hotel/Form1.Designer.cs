namespace Sistema_de_Reserva_de_Hotel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtCliente = new TextBox();
            dtpEntrada = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            dtpSalida = new DateTimePicker();
            label4 = new Label();
            numPersonas = new NumericUpDown();
            clbServicios = new CheckedListBox();
            label5 = new Label();
            rtbResumen = new RichTextBox();
            label6 = new Label();
            btnCalcularReserva = new Button();
            Limpiar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)numPersonas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 16);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(30, 51);
            txtCliente.Margin = new Padding(4);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(278, 31);
            txtCliente.TabIndex = 1;
            // 
            // dtpEntrada
            // 
            dtpEntrada.Location = new Point(30, 152);
            dtpEntrada.Margin = new Padding(4);
            dtpEntrada.Name = "dtpEntrada";
            dtpEntrada.Size = new Size(312, 31);
            dtpEntrada.TabIndex = 2;
            dtpEntrada.Value = new DateTime(2026, 4, 9, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 116);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 3;
            label2.Text = "entrada";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(413, 51);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 4;
            label3.Text = "salida";
            // 
            // dtpSalida
            // 
            dtpSalida.Location = new Point(413, 95);
            dtpSalida.Margin = new Padding(4);
            dtpSalida.Name = "dtpSalida";
            dtpSalida.Size = new Size(340, 31);
            dtpSalida.TabIndex = 5;
            dtpSalida.Value = new DateTime(2026, 4, 9, 23, 32, 50, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 208);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(177, 25);
            label4.TabIndex = 6;
            label4.Text = "Numero de Personas";
            // 
            // numPersonas
            // 
            numPersonas.Location = new Point(39, 236);
            numPersonas.Margin = new Padding(4);
            numPersonas.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numPersonas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPersonas.Name = "numPersonas";
            numPersonas.Size = new Size(188, 31);
            numPersonas.TabIndex = 7;
            numPersonas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // clbServicios
            // 
            clbServicios.FormattingEnabled = true;
            clbServicios.Items.AddRange(new object[] { "WiFi Premium", "Desayuno Buffet", "Estacionamiento", "Spa" });
            clbServicios.Location = new Point(39, 341);
            clbServicios.Margin = new Padding(4);
            clbServicios.Name = "clbServicios";
            clbServicios.Size = new Size(186, 116);
            clbServicios.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 312);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(173, 25);
            label5.TabIndex = 9;
            label5.Text = "Servicios adicionales";
            // 
            // rtbResumen
            // 
            rtbResumen.Location = new Point(327, 271);
            rtbResumen.Margin = new Padding(4);
            rtbResumen.Name = "rtbResumen";
            rtbResumen.ReadOnly = true;
            rtbResumen.Size = new Size(403, 149);
            rtbResumen.TabIndex = 10;
            rtbResumen.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(346, 208);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(196, 25);
            label6.TabIndex = 11;
            label6.Text = "Resumen de Operacion";
            // 
            // btnCalcularReserva
            // 
            btnCalcularReserva.BackColor = SystemColors.AppWorkspace;
            btnCalcularReserva.Location = new Point(134, 513);
            btnCalcularReserva.Margin = new Padding(4);
            btnCalcularReserva.Name = "btnCalcularReserva";
            btnCalcularReserva.Size = new Size(195, 36);
            btnCalcularReserva.TabIndex = 12;
            btnCalcularReserva.Text = "calcular";
            btnCalcularReserva.UseVisualStyleBackColor = false;
            btnCalcularReserva.Click += btnCalcularReserva_Click;
            // 
            // Limpiar
            // 
            Limpiar.BackColor = SystemColors.ButtonShadow;
            Limpiar.Location = new Point(413, 513);
            Limpiar.Margin = new Padding(4);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(175, 36);
            Limpiar.TabIndex = 13;
            Limpiar.Text = "limpiar";
            Limpiar.UseVisualStyleBackColor = false;
            Limpiar.Click += Limpiar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 562);
            Controls.Add(Limpiar);
            Controls.Add(btnCalcularReserva);
            Controls.Add(label6);
            Controls.Add(rtbResumen);
            Controls.Add(label5);
            Controls.Add(clbServicios);
            Controls.Add(numPersonas);
            Controls.Add(label4);
            Controls.Add(dtpSalida);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpEntrada);
            Controls.Add(txtCliente);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Sistema de Reserva de Hotel";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numPersonas).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCliente;
        private DateTimePicker dtpEntrada;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpSalida;
        private Label label4;
        private NumericUpDown numPersonas;
        private CheckedListBox clbServicios;
        private Label label5;
        private RichTextBox rtbResumen;
        private Label label6;
        private Button btnCalcularReserva;
        private Button Limpiar;
        private ErrorProvider errorProvider1;
    }
}
