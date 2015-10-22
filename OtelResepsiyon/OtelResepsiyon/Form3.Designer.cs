namespace OtelResepsiyon
{
    partial class Form3
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
            this.rezervButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.adTextBox = new System.Windows.Forms.TextBox();
            this.soyadTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tipComboBox = new System.Windows.Forms.ComboBox();
            this.paketComboBox = new System.Windows.Forms.ComboBox();
            this.girisPicker = new System.Windows.Forms.DateTimePicker();
            this.cikisPicker = new System.Windows.Forms.DateTimePicker();
            this.fiyat = new System.Windows.Forms.Label();
            this.fiyatButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rezervButton
            // 
            this.rezervButton.Location = new System.Drawing.Point(215, 283);
            this.rezervButton.Name = "rezervButton";
            this.rezervButton.Size = new System.Drawing.Size(150, 23);
            this.rezervButton.TabIndex = 0;
            this.rezervButton.Text = "Rezervasyon yap";
            this.rezervButton.UseVisualStyleBackColor = true;
            this.rezervButton.Click += new System.EventHandler(this.rezervButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad :";
            // 
            // adTextBox
            // 
            this.adTextBox.Location = new System.Drawing.Point(157, 24);
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(100, 20);
            this.adTextBox.TabIndex = 2;
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.Location = new System.Drawing.Point(157, 50);
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(100, 20);
            this.soyadTextBox.TabIndex = 3;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.Location = new System.Drawing.Point(157, 76);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Telefon :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = " Giriş Tarihi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Çıkış Tarihi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Oda Tipi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Paket Özelliği :";
            // 
            // tipComboBox
            // 
            this.tipComboBox.Location = new System.Drawing.Point(157, 154);
            this.tipComboBox.Name = "tipComboBox";
            this.tipComboBox.Size = new System.Drawing.Size(121, 21);
            this.tipComboBox.TabIndex = 22;
            // 
            // paketComboBox
            // 
            this.paketComboBox.Location = new System.Drawing.Point(157, 181);
            this.paketComboBox.Name = "paketComboBox";
            this.paketComboBox.Size = new System.Drawing.Size(121, 21);
            this.paketComboBox.TabIndex = 21;
            // 
            // girisPicker
            // 
            this.girisPicker.Location = new System.Drawing.Point(157, 105);
            this.girisPicker.Name = "girisPicker";
            this.girisPicker.Size = new System.Drawing.Size(200, 20);
            this.girisPicker.TabIndex = 17;
            // 
            // cikisPicker
            // 
            this.cikisPicker.Location = new System.Drawing.Point(157, 131);
            this.cikisPicker.Name = "cikisPicker";
            this.cikisPicker.Size = new System.Drawing.Size(200, 20);
            this.cikisPicker.TabIndex = 18;
            // 
            // fiyat
            // 
            this.fiyat.AutoSize = true;
            this.fiyat.Location = new System.Drawing.Point(187, 235);
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(29, 13);
            this.fiyat.TabIndex = 19;
            this.fiyat.Text = "Fiyat";
            this.fiyat.Visible = false;
            // 
            // fiyatButton
            // 
            this.fiyatButton.Location = new System.Drawing.Point(41, 283);
            this.fiyatButton.Name = "fiyatButton";
            this.fiyatButton.Size = new System.Drawing.Size(140, 23);
            this.fiyatButton.TabIndex = 20;
            this.fiyatButton.Text = "Fiyat Hesapla";
            this.fiyatButton.UseVisualStyleBackColor = true;
            this.fiyatButton.Click += new System.EventHandler(this.fiyatButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 328);
            this.Controls.Add(this.fiyatButton);
            this.Controls.Add(this.fiyat);
            this.Controls.Add(this.cikisPicker);
            this.Controls.Add(this.girisPicker);
            this.Controls.Add(this.paketComboBox);
            this.Controls.Add(this.tipComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(this.soyadTextBox);
            this.Controls.Add(this.adTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rezervButton);
            this.Name = "Form3";
            this.Text = "Rezervasyon Yap";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rezervButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adTextBox;
        private System.Windows.Forms.TextBox soyadTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox tipComboBox;
        private System.Windows.Forms.ComboBox paketComboBox;
        private System.Windows.Forms.DateTimePicker girisPicker;
        private System.Windows.Forms.DateTimePicker cikisPicker;
        private System.Windows.Forms.Label fiyat;
        private System.Windows.Forms.Button fiyatButton;
    }
}