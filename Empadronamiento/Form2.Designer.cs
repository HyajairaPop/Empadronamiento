namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dpi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.depto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.municipio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.correo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.correo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.municipio);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.depto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dpi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.fecha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.apellido);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Purple;
            this.groupBox1.Location = new System.Drawing.Point(29, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 427);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DE REGISTRO PARA NUEVO EMPADRONAMIENTO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(84, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRES";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(271, 38);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(365, 32);
            this.nombre.TabIndex = 1;
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(271, 76);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(365, 32);
            this.apellido.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(84, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "APELLIDOS";
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(271, 114);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(365, 32);
            this.fecha.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(84, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "FECHA DE NACIMIENTO";
            // 
            // dpi
            // 
            this.dpi.Location = new System.Drawing.Point(271, 152);
            this.dpi.Name = "dpi";
            this.dpi.Size = new System.Drawing.Size(365, 32);
            this.dpi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(82, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "NUMERO DE DPI";
            // 
            // depto
            // 
            this.depto.Location = new System.Drawing.Point(271, 190);
            this.depto.Name = "depto";
            this.depto.Size = new System.Drawing.Size(365, 32);
            this.depto.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label5.Location = new System.Drawing.Point(82, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "DEPTO. RESIDENCIA";
            // 
            // municipio
            // 
            this.municipio.Location = new System.Drawing.Point(271, 228);
            this.municipio.Name = "municipio";
            this.municipio.Size = new System.Drawing.Size(365, 32);
            this.municipio.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label6.Location = new System.Drawing.Point(82, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "MUNICIPIO RESIDENCIA";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // correo
            // 
            this.correo.Location = new System.Drawing.Point(271, 266);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(365, 32);
            this.correo.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label7.Location = new System.Drawing.Point(82, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "CORREO ELECTRONICO";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Location = new System.Drawing.Point(178, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "REGISTRAR ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button2.Location = new System.Drawing.Point(370, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 40);
            this.button2.TabIndex = 15;
            this.button2.Text = "REGRESAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 393);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox municipio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox depto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dpi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}