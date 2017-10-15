namespace HesapMakinasi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxSayi1 = new System.Windows.Forms.TextBox();
            this.txtBoxSayi2 = new System.Windows.Forms.TextBox();
            this.txtBoxSonuc = new System.Windows.Forms.TextBox();
            this.cmbBoxIslem = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHesap = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayi1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sayi2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sonuç";
            // 
            // txtBoxSayi1
            // 
            this.txtBoxSayi1.Location = new System.Drawing.Point(34, 58);
            this.txtBoxSayi1.Name = "txtBoxSayi1";
            this.txtBoxSayi1.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSayi1.TabIndex = 3;
            // 
            // txtBoxSayi2
            // 
            this.txtBoxSayi2.Location = new System.Drawing.Point(206, 58);
            this.txtBoxSayi2.Name = "txtBoxSayi2";
            this.txtBoxSayi2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSayi2.TabIndex = 4;
            // 
            // txtBoxSonuc
            // 
            this.txtBoxSonuc.Location = new System.Drawing.Point(387, 58);
            this.txtBoxSonuc.Name = "txtBoxSonuc";
            this.txtBoxSonuc.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSonuc.TabIndex = 5;
            // 
            // cmbBoxIslem
            // 
            this.cmbBoxIslem.FormattingEnabled = true;
            this.cmbBoxIslem.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.cmbBoxIslem.Location = new System.Drawing.Point(150, 58);
            this.cmbBoxIslem.Name = "cmbBoxIslem";
            this.cmbBoxIslem.Size = new System.Drawing.Size(34, 21);
            this.cmbBoxIslem.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(328, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "=";
            // 
            // btnHesap
            // 
            this.btnHesap.Location = new System.Drawing.Point(34, 130);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Size = new System.Drawing.Size(75, 23);
            this.btnHesap.TabIndex = 8;
            this.btnHesap.Text = "Hesapla";
            this.btnHesap.UseVisualStyleBackColor = true;
            this.btnHesap.Click += new System.EventHandler(this.btnHesap_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(136, 130);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 9;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 261);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnHesap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBoxIslem);
            this.Controls.Add(this.txtBoxSonuc);
            this.Controls.Add(this.txtBoxSayi2);
            this.Controls.Add(this.txtBoxSayi1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxSayi1;
        private System.Windows.Forms.TextBox txtBoxSayi2;
        private System.Windows.Forms.TextBox txtBoxSonuc;
        private System.Windows.Forms.ComboBox cmbBoxIslem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHesap;
        private System.Windows.Forms.Button btnTemizle;
    }
}

