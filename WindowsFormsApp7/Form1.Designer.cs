namespace WindowsFormsApp7
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.wynik_box = new System.Windows.Forms.TextBox();
            this.z_box = new System.Windows.Forms.TextBox();
            this.x1_box = new System.Windows.Forms.TextBox();
            this.x2_box = new System.Windows.Forms.TextBox();
            this.aaaaa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(648, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 81);
            this.button1.TabIndex = 0;
            this.button1.Text = "OBLICZ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patryk krawczak zadanie 7 c#";
            // 
            // wynik_box
            // 
            this.wynik_box.Location = new System.Drawing.Point(301, 41);
            this.wynik_box.Multiline = true;
            this.wynik_box.Name = "wynik_box";
            this.wynik_box.Size = new System.Drawing.Size(487, 164);
            this.wynik_box.TabIndex = 2;
            this.wynik_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // z_box
            // 
            this.z_box.Location = new System.Drawing.Point(34, 129);
            this.z_box.Name = "z_box";
            this.z_box.Size = new System.Drawing.Size(58, 26);
            this.z_box.TabIndex = 3;
            // 
            // x1_box
            // 
            this.x1_box.Location = new System.Drawing.Point(34, 211);
            this.x1_box.Name = "x1_box";
            this.x1_box.Size = new System.Drawing.Size(58, 26);
            this.x1_box.TabIndex = 4;
            // 
            // x2_box
            // 
            this.x2_box.Location = new System.Drawing.Point(34, 284);
            this.x2_box.Name = "x2_box";
            this.x2_box.Size = new System.Drawing.Size(58, 26);
            this.x2_box.TabIndex = 5;
            // 
            // aaaaa
            // 
            this.aaaaa.AutoSize = true;
            this.aaaaa.Location = new System.Drawing.Point(30, 185);
            this.aaaaa.Name = "aaaaa";
            this.aaaaa.Size = new System.Drawing.Size(25, 20);
            this.aaaaa.TabIndex = 6;
            this.aaaaa.Text = "x1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "x2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "z";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aaaaa);
            this.Controls.Add(this.x2_box);
            this.Controls.Add(this.x1_box);
            this.Controls.Add(this.z_box);
            this.Controls.Add(this.wynik_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox wynik_box;
        private System.Windows.Forms.TextBox z_box;
        private System.Windows.Forms.TextBox x1_box;
        private System.Windows.Forms.TextBox x2_box;
        private System.Windows.Forms.Label aaaaa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

