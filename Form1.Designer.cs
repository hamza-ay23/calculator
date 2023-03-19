namespace calculator
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
            this.btnartı = new System.Windows.Forms.Button();
            this.btneksi = new System.Windows.Forms.Button();
            this.btnçarp = new System.Windows.Forms.Button();
            this.btnböl = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnartı
            // 
            this.btnartı.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnartı.Location = new System.Drawing.Point(49, 193);
            this.btnartı.Name = "btnartı";
            this.btnartı.Size = new System.Drawing.Size(75, 34);
            this.btnartı.TabIndex = 0;
            this.btnartı.Text = "+";
            this.btnartı.UseVisualStyleBackColor = true;
            this.btnartı.Click += new System.EventHandler(this.btnartı_Click);
            // 
            // btneksi
            // 
            this.btneksi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btneksi.Location = new System.Drawing.Point(130, 193);
            this.btneksi.Name = "btneksi";
            this.btneksi.Size = new System.Drawing.Size(75, 34);
            this.btneksi.TabIndex = 1;
            this.btneksi.Text = "-";
            this.btneksi.UseVisualStyleBackColor = true;
            this.btneksi.Click += new System.EventHandler(this.btneksi_Click);
            // 
            // btnçarp
            // 
            this.btnçarp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnçarp.Location = new System.Drawing.Point(211, 193);
            this.btnçarp.Name = "btnçarp";
            this.btnçarp.Size = new System.Drawing.Size(75, 34);
            this.btnçarp.TabIndex = 2;
            this.btnçarp.Text = "*";
            this.btnçarp.UseVisualStyleBackColor = true;
            this.btnçarp.Click += new System.EventHandler(this.btnçarp_Click);
            // 
            // btnböl
            // 
            this.btnböl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnböl.Location = new System.Drawing.Point(292, 193);
            this.btnböl.Name = "btnböl";
            this.btnböl.Size = new System.Drawing.Size(75, 34);
            this.btnböl.TabIndex = 3;
            this.btnböl.Text = "/";
            this.btnböl.UseVisualStyleBackColor = true;
            this.btnböl.Click += new System.EventHandler(this.btnböl_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(49, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(318, 23);
            this.textBox2.TabIndex = 5;
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblsonuc.Location = new System.Drawing.Point(338, 282);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(29, 32);
            this.lblsonuc.TabIndex = 6;
            this.lblsonuc.Text = "0";
            this.lblsonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(401, 450);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnböl);
            this.Controls.Add(this.btnçarp);
            this.Controls.Add(this.btneksi);
            this.Controls.Add(this.btnartı);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnartı;
        private Button btneksi;
        private Button btnçarp;
        private Button btnböl;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblsonuc;
    }
}