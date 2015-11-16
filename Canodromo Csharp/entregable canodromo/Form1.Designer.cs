namespace entregable_canodromo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PistaImg = new System.Windows.Forms.PictureBox();
            this.Perro1 = new System.Windows.Forms.PictureBox();
            this.Perro4 = new System.Windows.Forms.PictureBox();
            this.Perro3 = new System.Windows.Forms.PictureBox();
            this.Perro2 = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericDinero = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericPerro = new System.Windows.Forms.NumericUpDown();
            this.Botonapuesta = new System.Windows.Forms.Button();
            this.Botonya = new System.Windows.Forms.Button();
            this.Cancela1 = new System.Windows.Forms.Button();
            this.Cancela2 = new System.Windows.Forms.Button();
            this.Cancela3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PistaImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Perro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Perro4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Perro3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Perro2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDinero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPerro)).BeginInit();
            this.SuspendLayout();
            // 
            // PistaImg
            // 
            this.PistaImg.Image = ((System.Drawing.Image)(resources.GetObject("PistaImg.Image")));
            this.PistaImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("PistaImg.InitialImage")));
            this.PistaImg.Location = new System.Drawing.Point(-2, 0);
            this.PistaImg.Name = "PistaImg";
            this.PistaImg.Size = new System.Drawing.Size(599, 200);
            this.PistaImg.TabIndex = 0;
            this.PistaImg.TabStop = false;
            // 
            // Perro1
            // 
            this.Perro1.Image = ((System.Drawing.Image)(resources.GetObject("Perro1.Image")));
            this.Perro1.Location = new System.Drawing.Point(12, 12);
            this.Perro1.Name = "Perro1";
            this.Perro1.Size = new System.Drawing.Size(74, 21);
            this.Perro1.TabIndex = 1;
            this.Perro1.TabStop = false;
            // 
            // Perro4
            // 
            this.Perro4.Image = ((System.Drawing.Image)(resources.GetObject("Perro4.Image")));
            this.Perro4.Location = new System.Drawing.Point(12, 163);
            this.Perro4.Name = "Perro4";
            this.Perro4.Size = new System.Drawing.Size(74, 21);
            this.Perro4.TabIndex = 2;
            this.Perro4.TabStop = false;
            // 
            // Perro3
            // 
            this.Perro3.Image = ((System.Drawing.Image)(resources.GetObject("Perro3.Image")));
            this.Perro3.Location = new System.Drawing.Point(12, 111);
            this.Perro3.Name = "Perro3";
            this.Perro3.Size = new System.Drawing.Size(74, 21);
            this.Perro3.TabIndex = 3;
            this.Perro3.TabStop = false;
            // 
            // Perro2
            // 
            this.Perro2.Image = ((System.Drawing.Image)(resources.GetObject("Perro2.Image")));
            this.Perro2.Location = new System.Drawing.Point(12, 54);
            this.Perro2.Name = "Perro2";
            this.Perro2.Size = new System.Drawing.Size(74, 21);
            this.Perro2.TabIndex = 4;
            this.Perro2.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 220);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(125, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Jugador1 tiene 100 €";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 265);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(125, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Text = "Jugador2 tiene 100 €";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(12, 305);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(125, 17);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.Text = "Jugador3 tiene 100 €";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(211, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 15);
            this.label1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(211, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 15);
            this.label2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(211, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 15);
            this.label3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Jugador 1 apuesta ";
            // 
            // numericDinero
            // 
            this.numericDinero.Location = new System.Drawing.Point(117, 422);
            this.numericDinero.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericDinero.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericDinero.Name = "numericDinero";
            this.numericDinero.Size = new System.Drawing.Size(32, 20);
            this.numericDinero.TabIndex = 12;
            this.numericDinero.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericDinero.ValueChanged += new System.EventHandler(this.numericDinero_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "€ en el perro ";
            // 
            // numericPerro
            // 
            this.numericPerro.Location = new System.Drawing.Point(239, 422);
            this.numericPerro.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericPerro.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericPerro.Name = "numericPerro";
            this.numericPerro.Size = new System.Drawing.Size(33, 20);
            this.numericPerro.TabIndex = 14;
            this.numericPerro.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Botonapuesta
            // 
            this.Botonapuesta.Location = new System.Drawing.Point(281, 349);
            this.Botonapuesta.Name = "Botonapuesta";
            this.Botonapuesta.Size = new System.Drawing.Size(75, 23);
            this.Botonapuesta.TabIndex = 15;
            this.Botonapuesta.Text = "APOSTAR";
            this.Botonapuesta.UseVisualStyleBackColor = true;
            this.Botonapuesta.Click += new System.EventHandler(this.Botonapuesta_Click);
            // 
            // Botonya
            // 
            this.Botonya.Location = new System.Drawing.Point(473, 349);
            this.Botonya.Name = "Botonya";
            this.Botonya.Size = new System.Drawing.Size(75, 23);
            this.Botonya.TabIndex = 16;
            this.Botonya.Text = "YA!";
            this.Botonya.UseVisualStyleBackColor = true;
            this.Botonya.Click += new System.EventHandler(this.button2_Click);
            // 
            // Cancela1
            // 
            this.Cancela1.Location = new System.Drawing.Point(554, 217);
            this.Cancela1.Name = "Cancela1";
            this.Cancela1.Size = new System.Drawing.Size(31, 25);
            this.Cancela1.TabIndex = 17;
            this.Cancela1.Text = "X";
            this.Cancela1.UseVisualStyleBackColor = true;
            this.Cancela1.Click += new System.EventHandler(this.Cancela1_Click);
            // 
            // Cancela2
            // 
            this.Cancela2.Location = new System.Drawing.Point(554, 261);
            this.Cancela2.Name = "Cancela2";
            this.Cancela2.Size = new System.Drawing.Size(31, 25);
            this.Cancela2.TabIndex = 18;
            this.Cancela2.Text = "X";
            this.Cancela2.UseVisualStyleBackColor = true;
            this.Cancela2.Click += new System.EventHandler(this.Cancela2_Click);
            // 
            // Cancela3
            // 
            this.Cancela3.Location = new System.Drawing.Point(554, 301);
            this.Cancela3.Name = "Cancela3";
            this.Cancela3.Size = new System.Drawing.Size(31, 25);
            this.Cancela3.TabIndex = 19;
            this.Cancela3.Text = "X";
            this.Cancela3.UseVisualStyleBackColor = true;
            this.Cancela3.Click += new System.EventHandler(this.Cancela3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 449);
            this.Controls.Add(this.Cancela3);
            this.Controls.Add(this.Cancela2);
            this.Controls.Add(this.Cancela1);
            this.Controls.Add(this.Botonya);
            this.Controls.Add(this.Botonapuesta);
            this.Controls.Add(this.numericPerro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericDinero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Perro2);
            this.Controls.Add(this.Perro3);
            this.Controls.Add(this.Perro4);
            this.Controls.Add(this.Perro1);
            this.Controls.Add(this.PistaImg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PistaImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Perro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Perro4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Perro3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Perro2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDinero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPerro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PistaImg;
        private System.Windows.Forms.PictureBox Perro1;
        private System.Windows.Forms.PictureBox Perro4;
        private System.Windows.Forms.PictureBox Perro3;
        private System.Windows.Forms.PictureBox Perro2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericDinero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericPerro;
        private System.Windows.Forms.Button Botonapuesta;
        private System.Windows.Forms.Button Botonya;
        private System.Windows.Forms.Button Cancela1;
        private System.Windows.Forms.Button Cancela2;
        private System.Windows.Forms.Button Cancela3;
    }
}

