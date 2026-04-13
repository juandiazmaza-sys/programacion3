namespace REGISTRO_EMPLEADOS
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombres = new TextBox();
            txtApellidos = new TextBox();
            txtIdentificacion = new TextBox();
            txtEmail = new TextBox();
            label7 = new Label();
            label8 = new Label();
            cmbDepartamento = new ComboBox();
            lblResultadoSueldo = new Label();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            groupBox1 = new GroupBox();
            numSueldoBase = new NumericUpDown();
            errorProvider1 = new ErrorProvider(components);
            txtResultadoNeto = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSueldoBase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(179, 25);
            label1.TabIndex = 0;
            label1.Text = "Informacion Personal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 70);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 134);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 2;
            label3.Text = "Apellidos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 198);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(119, 25);
            label4.TabIndex = 3;
            label4.Text = "IDentificacion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 275);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(149, 25);
            label5.TabIndex = 4;
            label5.Text = "Correo Eletronico";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 294);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 5;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(23, 99);
            txtNombres.Margin = new Padding(4);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(265, 31);
            txtNombres.TabIndex = 6;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(21, 160);
            txtApellidos.Margin = new Padding(4);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(265, 31);
            txtApellidos.TabIndex = 7;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(21, 240);
            txtIdentificacion.Margin = new Padding(4);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(265, 31);
            txtIdentificacion.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(15, 313);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(265, 31);
            txtEmail.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.Location = new Point(40, 42);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(114, 25);
            label7.TabIndex = 11;
            label7.Text = "Sueldo Base";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label8.Location = new Point(336, 42);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(135, 25);
            label8.TabIndex = 12;
            label8.Text = "Departamento";
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.FormattingEnabled = true;
            cmbDepartamento.Items.AddRange(new object[] { "Ventas", "IT", "Recursos Humanos", "Contabilidad" });
            cmbDepartamento.Location = new Point(339, 84);
            cmbDepartamento.Margin = new Padding(4);
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size(188, 33);
            cmbDepartamento.TabIndex = 13;
            cmbDepartamento.Text = "...";
            // 
            // lblResultadoSueldo
            // 
            lblResultadoSueldo.AutoSize = true;
            lblResultadoSueldo.Location = new Point(26, 545);
            lblResultadoSueldo.Margin = new Padding(4, 0, 4, 0);
            lblResultadoSueldo.Name = "lblResultadoSueldo";
            lblResultadoSueldo.Size = new Size(112, 25);
            lblResultadoSueldo.TabIndex = 14;
            lblResultadoSueldo.Text = "Sueldo neto:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(192, 0, 192);
            btnRegistrar.Location = new Point(382, 613);
            btnRegistrar.Margin = new Padding(4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(118, 36);
            btnRegistrar.TabIndex = 15;
            btnRegistrar.Text = "registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Red;
            btnLimpiar.Location = new Point(97, 613);
            btnLimpiar.Margin = new Padding(4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(118, 36);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numSueldoBase);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cmbDepartamento);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(5, 352);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(628, 156);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion Laboral";
            // 
            // numSueldoBase
            // 
            numSueldoBase.Location = new Point(22, 84);
            numSueldoBase.Margin = new Padding(4);
            numSueldoBase.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numSueldoBase.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSueldoBase.Name = "numSueldoBase";
            numSueldoBase.Size = new Size(188, 31);
            numSueldoBase.TabIndex = 14;
            numSueldoBase.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // txtResultadoNeto
            // 
            txtResultadoNeto.BackColor = SystemColors.Window;
            txtResultadoNeto.ForeColor = Color.LawnGreen;
            txtResultadoNeto.Location = new Point(162, 545);
            txtResultadoNeto.Name = "txtResultadoNeto";
            txtResultadoNeto.ReadOnly = true;
            txtResultadoNeto.Size = new Size(150, 31);
            txtResultadoNeto.TabIndex = 18;
            txtResultadoNeto.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 718);
            Controls.Add(txtResultadoNeto);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(btnLimpiar);
            Controls.Add(label4);
            Controls.Add(btnRegistrar);
            Controls.Add(label5);
            Controls.Add(lblResultadoSueldo);
            Controls.Add(txtNombres);
            Controls.Add(txtApellidos);
            Controls.Add(txtIdentificacion);
            Controls.Add(label6);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Sistema de Registro de Empleados";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSueldoBase).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtNombres;
        private TextBox txtApellidos;
        private TextBox txtIdentificacion;
        private TextBox txtEmail;
        private ComboBox cmbDepartamento;
        private Label lblResultadoSueldo;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private GroupBox groupBox1;
        private NumericUpDown numSueldoBase;
        private ErrorProvider errorProvider1;
        private TextBox txtResultadoNeto;
    }
}
