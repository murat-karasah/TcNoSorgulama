
namespace TcNoSorgulama
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dogumYili_txtBox = new System.Windows.Forms.TextBox();
            this.soyisim_txtBox = new System.Windows.Forms.TextBox();
            this.isim_txtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tcNo_txtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Kontrol = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dogumYili_txtBox);
            this.groupBox1.Controls.Add(this.soyisim_txtBox);
            this.groupBox1.Controls.Add(this.isim_txtBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tcNo_txtBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişisel Bilgiler";
            // 
            // dogumYili_txtBox
            // 
            this.dogumYili_txtBox.Location = new System.Drawing.Point(9, 175);
            this.dogumYili_txtBox.Name = "dogumYili_txtBox";
            this.dogumYili_txtBox.Size = new System.Drawing.Size(135, 20);
            this.dogumYili_txtBox.TabIndex = 2;
            // 
            // soyisim_txtBox
            // 
            this.soyisim_txtBox.Location = new System.Drawing.Point(9, 135);
            this.soyisim_txtBox.Name = "soyisim_txtBox";
            this.soyisim_txtBox.Size = new System.Drawing.Size(135, 20);
            this.soyisim_txtBox.TabIndex = 2;
            // 
            // isim_txtBox
            // 
            this.isim_txtBox.Location = new System.Drawing.Point(9, 87);
            this.isim_txtBox.Name = "isim_txtBox";
            this.isim_txtBox.Size = new System.Drawing.Size(135, 20);
            this.isim_txtBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Doğum Tarihi YYYY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Soyisim";
            // 
            // tcNo_txtBox
            // 
            this.tcNo_txtBox.Location = new System.Drawing.Point(9, 37);
            this.tcNo_txtBox.Name = "tcNo_txtBox";
            this.tcNo_txtBox.Size = new System.Drawing.Size(135, 20);
            this.tcNo_txtBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "İsim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "T.C Kimlik Numarası";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Kontrol);
            this.groupBox2.Location = new System.Drawing.Point(12, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlem";
            // 
            // btn_Kontrol
            // 
            this.btn_Kontrol.Location = new System.Drawing.Point(36, 19);
            this.btn_Kontrol.Name = "btn_Kontrol";
            this.btn_Kontrol.Size = new System.Drawing.Size(98, 65);
            this.btn_Kontrol.TabIndex = 0;
            this.btn_Kontrol.Text = "Kontrol Et";
            this.btn_Kontrol.UseVisualStyleBackColor = true;
            this.btn_Kontrol.Click += new System.EventHandler(this.btn_Kontrol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 355);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "TC Sorgulama";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dogumYili_txtBox;
        private System.Windows.Forms.TextBox soyisim_txtBox;
        private System.Windows.Forms.TextBox isim_txtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tcNo_txtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Kontrol;
    }
}

