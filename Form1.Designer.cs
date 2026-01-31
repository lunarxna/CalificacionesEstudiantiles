namespace WinFormsApp1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            txtNota3 = new TextBox();
            txtNota4 = new TextBox();
            txtPromedio = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtComple = new TextBox();
            label8 = new Label();
            txtExtra = new TextBox();
            button1 = new Button();
            labelResultado = new Label();
            groupBox1 = new GroupBox();
            txtPromedioIni = new TextBox();
            txtEstado = new TextBox();
            txtPromedioExtra = new TextBox();
            txtPromedioComple = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(226, 25);
            label1.Name = "label1";
            label1.Size = new Size(349, 31);
            label1.TabIndex = 0;
            label1.Text = "Cálculo de notas estudiantiles";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 64);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 1;
            label2.Text = "Nota 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 103);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 2;
            label3.Text = "Nota 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(55, 143);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 3;
            label4.Text = "Nota 3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(55, 182);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 4;
            label5.Text = "Nota 4";
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(127, 65);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(73, 27);
            txtNota1.TabIndex = 5;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(127, 104);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(73, 27);
            txtNota2.TabIndex = 6;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(127, 144);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(73, 27);
            txtNota3.TabIndex = 7;
            // 
            // txtNota4
            // 
            txtNota4.Location = new Point(127, 183);
            txtNota4.Name = "txtNota4";
            txtNota4.Size = new Size(73, 27);
            txtNota4.TabIndex = 8;
            // 
            // txtPromedio
            // 
            txtPromedio.Location = new Point(155, 248);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.ReadOnly = true;
            txtPromedio.Size = new Size(76, 27);
            txtPromedio.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(55, 248);
            label6.Name = "label6";
            label6.Size = new Size(94, 25);
            label6.TabIndex = 10;
            label6.Text = "Promedio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(399, 84);
            label7.Name = "label7";
            label7.Size = new Size(146, 20);
            label7.TabIndex = 11;
            label7.Text = "Nota del completivo";
            // 
            // txtComple
            // 
            txtComple.Enabled = false;
            txtComple.Location = new Point(551, 81);
            txtComple.Name = "txtComple";
            txtComple.Size = new Size(76, 27);
            txtComple.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(399, 128);
            label8.Name = "label8";
            label8.Size = new Size(165, 20);
            label8.TabIndex = 13;
            label8.Text = "Nota del extraordinario";
            // 
            // txtExtra
            // 
            txtExtra.Enabled = false;
            txtExtra.Location = new Point(570, 125);
            txtExtra.Name = "txtExtra";
            txtExtra.Size = new Size(76, 27);
            txtExtra.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(319, 354);
            button1.Name = "button1";
            button1.Size = new Size(110, 45);
            button1.TabIndex = 15;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelResultado.Location = new Point(6, 26);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(142, 25);
            labelResultado.TabIndex = 16;
            labelResultado.Text = "Promedio inicial:";
            labelResultado.Click += label9_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPromedioIni);
            groupBox1.Controls.Add(txtEstado);
            groupBox1.Controls.Add(txtPromedioExtra);
            groupBox1.Controls.Add(txtPromedioComple);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(labelResultado);
            groupBox1.Location = new Point(399, 171);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(334, 159);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resultados...";
            // 
            // txtPromedioIni
            // 
            txtPromedioIni.Location = new Point(147, 24);
            txtPromedioIni.Name = "txtPromedioIni";
            txtPromedioIni.ReadOnly = true;
            txtPromedioIni.Size = new Size(67, 27);
            txtPromedioIni.TabIndex = 23;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(190, 120);
            txtEstado.Name = "txtEstado";
            txtEstado.ReadOnly = true;
            txtEstado.Size = new Size(117, 27);
            txtEstado.TabIndex = 22;
            txtEstado.TextChanged += textBox3_TextChanged;
            // 
            // txtPromedioExtra
            // 
            txtPromedioExtra.Location = new Point(218, 84);
            txtPromedioExtra.Name = "txtPromedioExtra";
            txtPromedioExtra.ReadOnly = true;
            txtPromedioExtra.Size = new Size(67, 27);
            txtPromedioExtra.TabIndex = 21;
            // 
            // txtPromedioComple
            // 
            txtPromedioComple.Location = new Point(199, 51);
            txtPromedioComple.Name = "txtPromedioComple";
            txtPromedioComple.ReadOnly = true;
            txtPromedioComple.Size = new Size(67, 27);
            txtPromedioComple.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(6, 119);
            label11.Name = "label11";
            label11.Size = new Size(186, 25);
            label11.TabIndex = 19;
            label11.Text = "Estado del estudiante:";
            label11.Click += label11_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(6, 86);
            label10.Name = "label10";
            label10.Size = new Size(209, 25);
            label10.TabIndex = 18;
            label10.Text = "Promedio Extraordinario:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(6, 58);
            label9.Name = "label9";
            label9.Size = new Size(191, 25);
            label9.TabIndex = 17;
            label9.Text = "Promedio Completivo:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(txtExtra);
            Controls.Add(label8);
            Controls.Add(txtComple);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtPromedio);
            Controls.Add(txtNota4);
            Controls.Add(txtNota3);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private TextBox txtNota3;
        private TextBox txtNota4;
        private TextBox txtPromedio;
        private Label label6;
        private Label label7;
        private TextBox txtComple;
        private Label label8;
        private TextBox txtExtra;
        private Button button1;
        private Label labelResultado;
        private GroupBox groupBox1;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox txtEstado;
        private TextBox txtPromedioExtra;
        private TextBox txtPromedioComple;
        private TextBox txtPromedioIni;
    }
}
