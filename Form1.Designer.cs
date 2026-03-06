namespace Formulario_de_Estudiantes
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
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtn1 = new TextBox();
            txtn2 = new TextBox();
            txtn3 = new TextBox();
            txtn4 = new TextBox();
            groupBox2 = new GroupBox();
            txtp = new TextBox();
            label6 = new Label();
            groupBox3 = new GroupBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtc = new TextBox();
            txte = new TextBox();
            txtf = new TextBox();
            buttonc = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(257, 44);
            label1.Name = "label1";
            label1.Size = new Size(196, 15);
            label1.TabIndex = 0;
            label1.Text = "Cárculo de Promedio del Estudiante";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtn4);
            groupBox1.Controls.Add(txtn3);
            groupBox1.Controls.Add(txtn2);
            groupBox1.Controls.Add(txtn1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(39, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 168);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Notas del Estudiantes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 31);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Nota 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 65);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 3;
            label3.Text = "Nota 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 102);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 4;
            label4.Text = "Nota 3";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 137);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 5;
            label5.Text = "Nota 4";
            label5.Click += label5_Click;
            // 
            // txtn1
            // 
            txtn1.Location = new Point(68, 28);
            txtn1.Name = "txtn1";
            txtn1.Size = new Size(94, 23);
            txtn1.TabIndex = 2;
            // 
            // txtn2
            // 
            txtn2.Location = new Point(68, 62);
            txtn2.Name = "txtn2";
            txtn2.Size = new Size(94, 23);
            txtn2.TabIndex = 6;
            // 
            // txtn3
            // 
            txtn3.Location = new Point(68, 99);
            txtn3.Name = "txtn3";
            txtn3.Size = new Size(94, 23);
            txtn3.TabIndex = 2;
            // 
            // txtn4
            // 
            txtn4.Location = new Point(68, 134);
            txtn4.Name = "txtn4";
            txtn4.Size = new Size(94, 23);
            txtn4.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtp);
            groupBox2.Location = new Point(298, 127);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 77);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Promedio";
            // 
            // txtp
            // 
            txtp.Location = new Point(26, 34);
            txtp.Name = "txtp";
            txtp.Size = new Size(137, 23);
            txtp.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 92);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 7;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtf);
            groupBox3.Controls.Add(txte);
            groupBox3.Controls.Add(txtc);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(539, 99);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(238, 168);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Evaluación Adicinal";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 36);
            label7.Name = "label7";
            label7.Size = new Size(98, 15);
            label7.TabIndex = 5;
            label7.Text = "Nota Completivo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 70);
            label8.Name = "label8";
            label8.Size = new Size(108, 15);
            label8.TabIndex = 6;
            label8.Text = "Nota Extraordinaria";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 110);
            label9.Name = "label9";
            label9.Size = new Size(61, 15);
            label9.TabIndex = 7;
            label9.Text = "Nota Final";
            // 
            // txtc
            // 
            txtc.Location = new Point(132, 33);
            txtc.Name = "txtc";
            txtc.Size = new Size(100, 23);
            txtc.TabIndex = 5;
            // 
            // txte
            // 
            txte.Location = new Point(132, 70);
            txte.Name = "txte";
            txte.Size = new Size(100, 23);
            txte.TabIndex = 8;
            // 
            // txtf
            // 
            txtf.Location = new Point(96, 102);
            txtf.Name = "txtf";
            txtf.Size = new Size(100, 23);
            txtf.TabIndex = 9;
            // 
            // buttonc
            // 
            buttonc.Location = new Point(378, 228);
            buttonc.Name = "buttonc";
            buttonc.Size = new Size(75, 23);
            buttonc.TabIndex = 10;
            buttonc.Text = "Calcular";
            buttonc.UseVisualStyleBackColor = true;
            buttonc.Click += buttonc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonc);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtn4;
        private TextBox txtn3;
        private TextBox txtn2;
        private TextBox txtn1;
        private GroupBox groupBox2;
        private Label label6;
        private TextBox txtp;
        private GroupBox groupBox3;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtf;
        private TextBox txte;
        private TextBox txtc;
        private Button buttonc;
    }
}
