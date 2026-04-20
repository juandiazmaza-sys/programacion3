namespace Control_de_Ventas_Diarias
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
            groupBox1 = new GroupBox();
            btnGuardar = new Button();
            label2 = new Label();
            numMonto = new NumericUpDown();
            txtID = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lblTotal = new Label();
            btnCargar = new Button();
            lstHistorial = new ListBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMonto).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(numMonto);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(40, 28);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(491, 193);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nueva Venta";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.Highlight;
            btnGuardar.Location = new Point(248, 98);
            btnGuardar.Margin = new Padding(4, 4, 4, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(196, 36);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar Transaccion";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 98);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 3;
            label2.Text = "Monton ($)";
            // 
            // numMonto
            // 
            numMonto.Location = new Point(22, 138);
            numMonto.Margin = new Padding(4, 4, 4, 4);
            numMonto.Name = "numMonto";
            numMonto.Size = new Size(188, 31);
            numMonto.TabIndex = 2;
            // 
            // txtID
            // 
            txtID.Location = new Point(28, 58);
            txtID.Margin = new Padding(4, 4, 4, 4);
            txtID.Name = "txtID";
            txtID.Size = new Size(155, 31);
            txtID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 0;
            label1.Text = "ID transaccion";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblTotal);
            groupBox2.Controls.Add(btnCargar);
            groupBox2.Controls.Add(lstHistorial);
            groupBox2.Location = new Point(62, 229);
            groupBox2.Margin = new Padding(4, 4, 4, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 4, 4, 4);
            groupBox2.Size = new Size(455, 274);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Historial";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = Color.MediumSpringGreen;
            lblTotal.Location = new Point(8, 189);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(124, 25);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "TOTAL : $ 0.00";
            // 
            // btnCargar
            // 
            btnCargar.BackColor = SystemColors.Highlight;
            btnCargar.Location = new Point(179, 220);
            btnCargar.Margin = new Padding(4, 4, 4, 4);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(118, 36);
            btnCargar.TabIndex = 1;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // lstHistorial
            // 
            lstHistorial.FormattingEnabled = true;
            lstHistorial.Location = new Point(25, 45);
            lstHistorial.Margin = new Padding(4, 4, 4, 4);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(410, 129);
            lstHistorial.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMonto).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private NumericUpDown numMonto;
        private TextBox txtID;
        private Label label1;
        private Button btnGuardar;
        private GroupBox groupBox2;
        private Label lblTotal;
        private Button btnCargar;
        private ListBox lstHistorial;
    }
}
