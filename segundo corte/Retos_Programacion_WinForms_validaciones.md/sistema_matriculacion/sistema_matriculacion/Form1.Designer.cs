namespace sistema_matriculacion
{
    partial class FrmMatricula
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbInfoAcademica = new System.Windows.Forms.GroupBox();
            this.nudCreditos = new System.Windows.Forms.NumericUpDown();
            this.nudPromedio = new System.Windows.Forms.NumericUpDown();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbBeca = new System.Windows.Forms.GroupBox();
            this.gbTipoBeca = new System.Windows.Forms.GroupBox();
            this.rbExcelencia = new System.Windows.Forms.RadioButton();
            this.rbDeportiva = new System.Windows.Forms.RadioButton();
            this.rbSocioeconomica = new System.Windows.Forms.RadioButton();
            this.chkBeca = new System.Windows.Forms.CheckBox();
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.rtbResultados = new System.Windows.Forms.RichTextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gbDatosPersonales.SuspendLayout();
            this.gbInfoAcademica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCreditos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPromedio)).BeginInit();
            this.gbBeca.SuspendLayout();
            this.gbTipoBeca.SuspendLayout();
            this.gbResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatosPersonales
            // 
            this.gbDatosPersonales.Controls.Add(this.txtCorreo);
            this.gbDatosPersonales.Controls.Add(this.txtCarnet);
            this.gbDatosPersonales.Controls.Add(this.txtApellido);
            this.gbDatosPersonales.Controls.Add(this.label4);
            this.gbDatosPersonales.Controls.Add(this.label3);
            this.gbDatosPersonales.Controls.Add(this.label2);
            this.gbDatosPersonales.Controls.Add(this.txtNombre);
            this.gbDatosPersonales.Controls.Add(this.label1);
            this.gbDatosPersonales.Location = new System.Drawing.Point(12, 34);
            this.gbDatosPersonales.Name = "gbDatosPersonales";
            this.gbDatosPersonales.Size = new System.Drawing.Size(459, 159);
            this.gbDatosPersonales.TabIndex = 0;
            this.gbDatosPersonales.TabStop = false;
            this.gbDatosPersonales.Text = "Datos Personales";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(150, 119);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(303, 26);
            this.txtCorreo.TabIndex = 8;
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(150, 87);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(303, 26);
            this.txtCarnet.TabIndex = 7;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(150, 55);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(303, 26);
            this.txtApellido.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Correo Institucional:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Carnet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(150, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(303, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // gbInfoAcademica
            // 
            this.gbInfoAcademica.Controls.Add(this.nudCreditos);
            this.gbInfoAcademica.Controls.Add(this.nudPromedio);
            this.gbInfoAcademica.Controls.Add(this.cmbCarrera);
            this.gbInfoAcademica.Controls.Add(this.label7);
            this.gbInfoAcademica.Controls.Add(this.label6);
            this.gbInfoAcademica.Controls.Add(this.label5);
            this.gbInfoAcademica.Location = new System.Drawing.Point(477, 34);
            this.gbInfoAcademica.Name = "gbInfoAcademica";
            this.gbInfoAcademica.Size = new System.Drawing.Size(311, 145);
            this.gbInfoAcademica.TabIndex = 1;
            this.gbInfoAcademica.TabStop = false;
            this.gbInfoAcademica.Text = "Información Académica";
            // 
            // nudCreditos
            // 
            this.nudCreditos.Location = new System.Drawing.Point(177, 106);
            this.nudCreditos.Maximum = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.nudCreditos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCreditos.Name = "nudCreditos";
            this.nudCreditos.Size = new System.Drawing.Size(120, 26);
            this.nudCreditos.TabIndex = 5;
            this.nudCreditos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudPromedio
            // 
            this.nudPromedio.DecimalPlaces = 2;
            this.nudPromedio.Location = new System.Drawing.Point(177, 71);
            this.nudPromedio.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudPromedio.Name = "nudPromedio";
            this.nudPromedio.Size = new System.Drawing.Size(120, 26);
            this.nudPromedio.TabIndex = 4;
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Location = new System.Drawing.Point(79, 26);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(219, 28);
            this.cmbCarrera.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Créditos a Matricular:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Promedio Acumulado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Carrera:";
            // 
            // gbBeca
            // 
            this.gbBeca.Controls.Add(this.gbTipoBeca);
            this.gbBeca.Controls.Add(this.chkBeca);
            this.gbBeca.Location = new System.Drawing.Point(22, 212);
            this.gbBeca.Name = "gbBeca";
            this.gbBeca.Size = new System.Drawing.Size(766, 188);
            this.gbBeca.TabIndex = 2;
            this.gbBeca.TabStop = false;
            this.gbBeca.Text = "Beca";
            // 
            // gbTipoBeca
            // 
            this.gbTipoBeca.Controls.Add(this.rbExcelencia);
            this.gbTipoBeca.Controls.Add(this.rbDeportiva);
            this.gbTipoBeca.Controls.Add(this.rbSocioeconomica);
            this.gbTipoBeca.Enabled = false;
            this.gbTipoBeca.Location = new System.Drawing.Point(6, 55);
            this.gbTipoBeca.Name = "gbTipoBeca";
            this.gbTipoBeca.Size = new System.Drawing.Size(293, 127);
            this.gbTipoBeca.TabIndex = 1;
            this.gbTipoBeca.TabStop = false;
            this.gbTipoBeca.Text = "Tipo de Beca";
            // 
            // rbExcelencia
            // 
            this.rbExcelencia.AutoSize = true;
            this.rbExcelencia.Location = new System.Drawing.Point(17, 97);
            this.rbExcelencia.Name = "rbExcelencia";
            this.rbExcelencia.Size = new System.Drawing.Size(110, 24);
            this.rbExcelencia.TabIndex = 2;
            this.rbExcelencia.TabStop = true;
            this.rbExcelencia.Text = "Excelencia";
            this.rbExcelencia.UseVisualStyleBackColor = true;
            // 
            // rbDeportiva
            // 
            this.rbDeportiva.AutoSize = true;
            this.rbDeportiva.Location = new System.Drawing.Point(17, 67);
            this.rbDeportiva.Name = "rbDeportiva";
            this.rbDeportiva.Size = new System.Drawing.Size(102, 24);
            this.rbDeportiva.TabIndex = 1;
            this.rbDeportiva.TabStop = true;
            this.rbDeportiva.Text = "Deportiva";
            this.rbDeportiva.UseVisualStyleBackColor = true;
            // 
            // rbSocioeconomica
            // 
            this.rbSocioeconomica.AutoSize = true;
            this.rbSocioeconomica.Location = new System.Drawing.Point(17, 37);
            this.rbSocioeconomica.Name = "rbSocioeconomica";
            this.rbSocioeconomica.Size = new System.Drawing.Size(151, 24);
            this.rbSocioeconomica.TabIndex = 0;
            this.rbSocioeconomica.TabStop = true;
            this.rbSocioeconomica.Text = "Socioeconómica";
            this.rbSocioeconomica.UseVisualStyleBackColor = true;
            // 
            // chkBeca
            // 
            this.chkBeca.AutoSize = true;
            this.chkBeca.Location = new System.Drawing.Point(23, 25);
            this.chkBeca.Name = "chkBeca";
            this.chkBeca.Size = new System.Drawing.Size(132, 24);
            this.chkBeca.TabIndex = 0;
            this.chkBeca.Text = "Aplica a Beca";
            this.chkBeca.UseVisualStyleBackColor = true;
            // 
            // gbResultados
            // 
            this.gbResultados.Controls.Add(this.rtbResultados);
            this.gbResultados.Location = new System.Drawing.Point(28, 406);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Size = new System.Drawing.Size(760, 70);
            this.gbResultados.TabIndex = 1;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "Resultados";
            // 
            // rtbResultados
            // 
            this.rtbResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbResultados.Location = new System.Drawing.Point(3, 22);
            this.rtbResultados.Name = "rtbResultados";
            this.rtbResultados.ReadOnly = true;
            this.rtbResultados.Size = new System.Drawing.Size(754, 45);
            this.rtbResultados.TabIndex = 0;
            this.rtbResultados.Text = "";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalcular.Location = new System.Drawing.Point(220, 482);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(176, 37);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Matricular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Red;
            this.btnLimpiar.Location = new System.Drawing.Point(472, 482);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(176, 37);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // FrmMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 531);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gbResultados);
            this.Controls.Add(this.gbBeca);
            this.Controls.Add(this.gbInfoAcademica);
            this.Controls.Add(this.gbDatosPersonales);
            this.MaximizeBox = false;
            this.Name = "FrmMatricula";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Portal de Matrícula Universitaria";
            this.gbDatosPersonales.ResumeLayout(false);
            this.gbDatosPersonales.PerformLayout();
            this.gbInfoAcademica.ResumeLayout(false);
            this.gbInfoAcademica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCreditos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPromedio)).EndInit();
            this.gbBeca.ResumeLayout(false);
            this.gbBeca.PerformLayout();
            this.gbTipoBeca.ResumeLayout(false);
            this.gbTipoBeca.PerformLayout();
            this.gbResultados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosPersonales;
        private System.Windows.Forms.GroupBox gbInfoAcademica;
        private System.Windows.Forms.GroupBox gbBeca;
        private System.Windows.Forms.GroupBox gbResultados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudCreditos;
        private System.Windows.Forms.NumericUpDown nudPromedio;
        private System.Windows.Forms.GroupBox gbTipoBeca;
        private System.Windows.Forms.CheckBox chkBeca;
        private System.Windows.Forms.RadioButton rbExcelencia;
        private System.Windows.Forms.RadioButton rbDeportiva;
        private System.Windows.Forms.RadioButton rbSocioeconomica;
        private System.Windows.Forms.RichTextBox rtbResultados;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

