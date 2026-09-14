namespace Concesionario
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbValorFabric = new System.Windows.Forms.TextBox();
            this.numModelo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numAñoCalc = new System.Windows.Forms.NumericUpDown();
            this.tbVidaUtil = new System.Windows.Forms.TextBox();
            this.tbTasDepre = new System.Windows.Forms.TextBox();
            this.rbLineal = new System.Windows.Forms.RadioButton();
            this.rbAnual = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numModelo)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAñoCalc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numModelo);
            this.groupBox1.Controls.Add(this.tbValorFabric);
            this.groupBox1.Controls.Add(this.tbMarca);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del vehiculo";
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(244, 30);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(100, 20);
            this.tbMarca.TabIndex = 0;
            // 
            // tbValorFabric
            // 
            this.tbValorFabric.Location = new System.Drawing.Point(244, 112);
            this.tbValorFabric.Name = "tbValorFabric";
            this.tbValorFabric.Size = new System.Drawing.Size(100, 20);
            this.tbValorFabric.TabIndex = 1;
            // 
            // numModelo
            // 
            this.numModelo.Location = new System.Drawing.Point(244, 72);
            this.numModelo.Maximum = new decimal(new int[] {
            2027,
            0,
            0,
            0});
            this.numModelo.Minimum = new decimal(new int[] {
            1956,
            0,
            0,
            0});
            this.numModelo.Name = "numModelo";
            this.numModelo.Size = new System.Drawing.Size(100, 20);
            this.numModelo.TabIndex = 2;
            this.numModelo.Value = new decimal(new int[] {
            1956,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor fabricacion $";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.rbAnual);
            this.groupBox2.Controls.Add(this.rbLineal);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numAñoCalc);
            this.groupBox2.Controls.Add(this.tbVidaUtil);
            this.groupBox2.Controls.Add(this.tbTasDepre);
            this.groupBox2.Location = new System.Drawing.Point(12, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(525, 262);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del vehiculo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vida util";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Año a calcular";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tasa depreciacion";
            // 
            // numAñoCalc
            // 
            this.numAñoCalc.Location = new System.Drawing.Point(242, 69);
            this.numAñoCalc.Maximum = new decimal(new int[] {
            2027,
            0,
            0,
            0});
            this.numAñoCalc.Minimum = new decimal(new int[] {
            1956,
            0,
            0,
            0});
            this.numAñoCalc.Name = "numAñoCalc";
            this.numAñoCalc.Size = new System.Drawing.Size(117, 20);
            this.numAñoCalc.TabIndex = 2;
            this.numAñoCalc.Value = new decimal(new int[] {
            1956,
            0,
            0,
            0});
            // 
            // tbVidaUtil
            // 
            this.tbVidaUtil.Location = new System.Drawing.Point(242, 157);
            this.tbVidaUtil.Name = "tbVidaUtil";
            this.tbVidaUtil.Size = new System.Drawing.Size(117, 20);
            this.tbVidaUtil.TabIndex = 1;
            // 
            // tbTasDepre
            // 
            this.tbTasDepre.Location = new System.Drawing.Point(242, 112);
            this.tbTasDepre.Name = "tbTasDepre";
            this.tbTasDepre.Size = new System.Drawing.Size(117, 20);
            this.tbTasDepre.TabIndex = 0;
            // 
            // rbLineal
            // 
            this.rbLineal.AutoSize = true;
            this.rbLineal.Location = new System.Drawing.Point(139, 33);
            this.rbLineal.Name = "rbLineal";
            this.rbLineal.Size = new System.Drawing.Size(53, 17);
            this.rbLineal.TabIndex = 6;
            this.rbLineal.TabStop = true;
            this.rbLineal.Text = "Lineal";
            this.rbLineal.UseVisualStyleBackColor = true;
            this.rbLineal.CheckedChanged += new System.EventHandler(this.rbLineal_CheckedChanged);
            // 
            // rbAnual
            // 
            this.rbAnual.AutoSize = true;
            this.rbAnual.Location = new System.Drawing.Point(257, 33);
            this.rbAnual.Name = "rbAnual";
            this.rbAnual.Size = new System.Drawing.Size(52, 17);
            this.rbAnual.TabIndex = 7;
            this.rbAnual.TabStop = true;
            this.rbAnual.Text = "Anual";
            this.rbAnual.UseVisualStyleBackColor = true;
            this.rbAnual.CheckedChanged += new System.EventHandler(this.rbAnual_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 495);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numModelo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAñoCalc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numModelo;
        private System.Windows.Forms.TextBox tbValorFabric;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbAnual;
        private System.Windows.Forms.RadioButton rbLineal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numAñoCalc;
        private System.Windows.Forms.TextBox tbVidaUtil;
        private System.Windows.Forms.TextBox tbTasDepre;
        private System.Windows.Forms.Button button1;
    }
}

