namespace PatikaOrtalamaHesaplama
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
            this.btnHesapla = new System.Windows.Forms.Button();
            this.nudDerinlik = new System.Windows.Forms.NumericUpDown();
            this.txtOrt = new System.Windows.Forms.TextBox();
            this.lblDerinlik = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.lblOrt = new System.Windows.Forms.Label();
            this.txtToplam = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudDerinlik)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(11, 242);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(136, 23);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // nudDerinlik
            // 
            this.nudDerinlik.Location = new System.Drawing.Point(66, 218);
            this.nudDerinlik.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.nudDerinlik.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudDerinlik.Name = "nudDerinlik";
            this.nudDerinlik.Size = new System.Drawing.Size(81, 20);
            this.nudDerinlik.TabIndex = 1;
            this.nudDerinlik.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDerinlik.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // txtOrt
            // 
            this.txtOrt.Location = new System.Drawing.Point(66, 190);
            this.txtOrt.Name = "txtOrt";
            this.txtOrt.ReadOnly = true;
            this.txtOrt.Size = new System.Drawing.Size(81, 20);
            this.txtOrt.TabIndex = 2;
            this.txtOrt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDerinlik
            // 
            this.lblDerinlik.AutoSize = true;
            this.lblDerinlik.Location = new System.Drawing.Point(14, 221);
            this.lblDerinlik.Name = "lblDerinlik";
            this.lblDerinlik.Size = new System.Drawing.Size(42, 13);
            this.lblDerinlik.TabIndex = 3;
            this.lblDerinlik.Text = "Derinlik";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Turquoise;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(2, 295);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(500, 88);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "\r\n* Uygulama derinlik bilgisini vermiş olduğunuz sayıda Fibonacci sayılarının ort" +
    "alamasını verir.\r\n\r\n*Derinlik bilgisi 2-65000 aralığında bir değer alabilir.";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.Location = new System.Drawing.Point(12, 274);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(76, 18);
            this.lblAciklama.TabIndex = 5;
            this.lblAciklama.Text = "Açıklama";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(14, 169);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(42, 13);
            this.lblToplam.TabIndex = 6;
            this.lblToplam.Text = "Toplam";
            // 
            // lblOrt
            // 
            this.lblOrt.AutoSize = true;
            this.lblOrt.Location = new System.Drawing.Point(14, 197);
            this.lblOrt.Name = "lblOrt";
            this.lblOrt.Size = new System.Drawing.Size(49, 13);
            this.lblOrt.TabIndex = 7;
            this.lblOrt.Text = "Ortalama";
            // 
            // txtToplam
            // 
            this.txtToplam.Location = new System.Drawing.Point(66, 162);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.ReadOnly = true;
            this.txtToplam.Size = new System.Drawing.Size(81, 20);
            this.txtToplam.TabIndex = 8;
            this.txtToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PatikaOrtalamaHesaplama.Properties.Resources.Leonardo_Fibonacci;
            this.ClientSize = new System.Drawing.Size(502, 378);
            this.Controls.Add(this.txtToplam);
            this.Controls.Add(this.lblOrt);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDerinlik);
            this.Controls.Add(this.txtOrt);
            this.Controls.Add(this.nudDerinlik);
            this.Controls.Add(this.btnHesapla);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudDerinlik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.NumericUpDown nudDerinlik;
        private System.Windows.Forms.TextBox txtOrt;
        private System.Windows.Forms.Label lblDerinlik;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label lblOrt;
        private System.Windows.Forms.TextBox txtToplam;
    }
}