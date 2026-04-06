namespace Catálogo_de_Producto
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
            panel1 = new Panel();
            btnañadir = new Button();
            numCantidad = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnañadir);
            panel1.Controls.Add(numCantidad);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(26, 55);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 387);
            panel1.TabIndex = 0;
            // 
            // btnañadir
            // 
            btnañadir.BackColor = Color.Blue;
            btnañadir.Cursor = Cursors.Hand;
            btnañadir.FlatStyle = FlatStyle.Flat;
            btnañadir.ForeColor = Color.Snow;
            btnañadir.Location = new Point(39, 285);
            btnañadir.Margin = new Padding(4, 4, 4, 4);
            btnañadir.Name = "btnañadir";
            btnañadir.Size = new Size(186, 41);
            btnañadir.TabIndex = 5;
            btnañadir.Text = "Añadir al carrito";
            btnañadir.UseVisualStyleBackColor = false;
            btnañadir.Click += btnañadir_Click;
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(39, 226);
            numCantidad.Margin = new Padding(4, 4, 4, 4);
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(143, 31);
            numCantidad.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(39, 158);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(143, 45);
            label2.TabIndex = 3;
            label2.Text = "$299.99";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(64, 16);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(206, 38);
            label1.TabIndex = 1;
            label1.Text = "Monitor Gamer";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(49, 68);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(258, 86);
            textBox1.TabIndex = 2;
            textBox1.Text = "Monitor con tasa de refresco\r\nde 144Hz y panel IPS...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 506);
            Controls.Add(panel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private Button btnañadir;
        private NumericUpDown numCantidad;
        private Label label2;
    }
}
