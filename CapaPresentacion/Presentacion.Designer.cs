namespace CapaPresentacion
{
    partial class Presentacion
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.cbox1 = new System.Windows.Forms.ComboBox();
            this.btnsueldo = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(278, 25);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(146, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "PLANILLA TRABAJADORES";
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(113, 73);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(132, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "NOMBRE TRABAJADOR:";
            this.lbl2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(206, 122);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(39, 13);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "SEXO:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(162, 178);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(83, 13);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "ESTADO CIVIL:";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(205, 233);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(40, 13);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "EDAD:";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(204, 275);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(41, 13);
            this.lbl6.TabIndex = 5;
            this.lbl6.Text = "HIJOS:";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(274, 70);
            this.txt1.MaximumSize = new System.Drawing.Size(200, 40);
            this.txt1.MinimumSize = new System.Drawing.Size(150, 28);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(150, 28);
            this.txt1.TabIndex = 6;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(274, 226);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(150, 20);
            this.txt3.TabIndex = 7;
            this.txt3.TextChanged += new System.EventHandler(this.txt3_TextChanged);
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(274, 268);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(150, 20);
            this.txt4.TabIndex = 8;
            this.txt4.TextChanged += new System.EventHandler(this.txt4_TextChanged);
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(254, 382);
            this.txt5.MaximumSize = new System.Drawing.Size(200, 50);
            this.txt5.MinimumSize = new System.Drawing.Size(200, 50);
            this.txt5.Name = "txt5";
            this.txt5.ReadOnly = true;
            this.txt5.Size = new System.Drawing.Size(200, 50);
            this.txt5.TabIndex = 9;
            this.txt5.TextChanged += new System.EventHandler(this.txt5_TextChanged);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(274, 119);
            this.txt2.MaximumSize = new System.Drawing.Size(150, 28);
            this.txt2.MinimumSize = new System.Drawing.Size(150, 28);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(150, 28);
            this.txt2.TabIndex = 10;
            this.txt2.TextChanged += new System.EventHandler(this.txt2_TextChanged);
            // 
            // cbox1
            // 
            this.cbox1.FormattingEnabled = true;
            this.cbox1.Items.AddRange(new object[] {
            "CASADO",
            "SOLTERO",
            "VIUDO",
            "DIVORCIADO"});
            this.cbox1.Location = new System.Drawing.Point(274, 175);
            this.cbox1.Name = "cbox1";
            this.cbox1.Size = new System.Drawing.Size(150, 21);
            this.cbox1.TabIndex = 11;
            this.cbox1.SelectedIndexChanged += new System.EventHandler(this.cbox1_SelectedIndexChanged);
            // 
            // btnsueldo
            // 
            this.btnsueldo.Location = new System.Drawing.Point(274, 321);
            this.btnsueldo.Name = "btnsueldo";
            this.btnsueldo.Size = new System.Drawing.Size(131, 24);
            this.btnsueldo.TabIndex = 12;
            this.btnsueldo.Text = "CALCULAR SUELDO";
            this.btnsueldo.UseVisualStyleBackColor = true;
            this.btnsueldo.Click += new System.EventHandler(this.btnsueldo_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(471, 321);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(131, 24);
            this.btnnuevo.TabIndex = 13;
            this.btnnuevo.Text = "NUEVO";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Respuesta:";
            // 
            // Presentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 497);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btnsueldo);
            this.Controls.Add(this.cbox1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Presentacion";
            this.Text = "Presentacion";
            this.Load += new System.EventHandler(this.Presentacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.ComboBox cbox1;
        private System.Windows.Forms.Button btnsueldo;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt5;
    }
}