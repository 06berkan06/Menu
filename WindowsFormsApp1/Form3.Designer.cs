namespace WindowsFormsApp1
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
            System.Windows.Forms.Label label1;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Müşteri = new System.Windows.Forms.TabPage();
            this.Sipariş = new System.Windows.Forms.TabPage();
            this.Hesap = new System.Windows.Forms.TabPage();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nCorba = new System.Windows.Forms.NumericUpDown();
            this.nSalata = new System.Windows.Forms.NumericUpDown();
            this.nYemek = new System.Windows.Forms.NumericUpDown();
            this.nTatli = new System.Windows.Forms.NumericUpDown();
            this.listbox = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Müşteri.SuspendLayout();
            this.Sipariş.SuspendLayout();
            this.Hesap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCorba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSalata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nYemek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTatli)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Müşteri);
            this.tabControl1.Controls.Add(this.Sipariş);
            this.tabControl1.Controls.Add(this.Hesap);
            this.tabControl1.Location = new System.Drawing.Point(207, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(321, 232);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Müşteri
            // 
            this.Müşteri.Controls.Add(this.label3);
            this.Müşteri.Controls.Add(this.label2);
            this.Müşteri.Controls.Add(label1);
            this.Müşteri.Controls.Add(this.txtAdres);
            this.Müşteri.Controls.Add(this.txtTelefon);
            this.Müşteri.Controls.Add(this.txtAdSoyad);
            this.Müşteri.Location = new System.Drawing.Point(4, 22);
            this.Müşteri.Name = "Müşteri";
            this.Müşteri.Padding = new System.Windows.Forms.Padding(3);
            this.Müşteri.Size = new System.Drawing.Size(313, 206);
            this.Müşteri.TabIndex = 0;
            this.Müşteri.Text = "Müşteri";
            this.Müşteri.UseVisualStyleBackColor = true;
            this.Müşteri.Click += new System.EventHandler(this.Müşteri_Click);
            // 
            // Sipariş
            // 
            this.Sipariş.Controls.Add(this.nTatli);
            this.Sipariş.Controls.Add(this.nYemek);
            this.Sipariş.Controls.Add(this.nSalata);
            this.Sipariş.Controls.Add(this.nCorba);
            this.Sipariş.Controls.Add(this.label7);
            this.Sipariş.Controls.Add(this.label6);
            this.Sipariş.Controls.Add(this.label5);
            this.Sipariş.Controls.Add(this.label4);
            this.Sipariş.Location = new System.Drawing.Point(4, 22);
            this.Sipariş.Name = "Sipariş";
            this.Sipariş.Padding = new System.Windows.Forms.Padding(3);
            this.Sipariş.Size = new System.Drawing.Size(313, 206);
            this.Sipariş.TabIndex = 1;
            this.Sipariş.Text = "Sipariş";
            this.Sipariş.UseVisualStyleBackColor = true;
            // 
            // Hesap
            // 
            this.Hesap.Controls.Add(this.listbox);
            this.Hesap.Location = new System.Drawing.Point(4, 22);
            this.Hesap.Name = "Hesap";
            this.Hesap.Size = new System.Drawing.Size(313, 206);
            this.Hesap.TabIndex = 2;
            this.Hesap.Text = "Hesap";
            this.Hesap.UseVisualStyleBackColor = true;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(93, 36);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(163, 20);
            this.txtAdSoyad.TabIndex = 0;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(93, 62);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(163, 20);
            this.txtTelefon.TabIndex = 0;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(93, 88);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(163, 20);
            this.txtAdres.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(20, 36);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(53, 13);
            label1.TabIndex = 2;
            label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Çorba";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Salata";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ana yemek";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tatlı";
            // 
            // nCorba
            // 
            this.nCorba.Location = new System.Drawing.Point(110, 33);
            this.nCorba.Name = "nCorba";
            this.nCorba.Size = new System.Drawing.Size(120, 20);
            this.nCorba.TabIndex = 4;
            // 
            // nSalata
            // 
            this.nSalata.Location = new System.Drawing.Point(110, 66);
            this.nSalata.Name = "nSalata";
            this.nSalata.Size = new System.Drawing.Size(120, 20);
            this.nSalata.TabIndex = 5;
            // 
            // nYemek
            // 
            this.nYemek.Location = new System.Drawing.Point(110, 97);
            this.nYemek.Name = "nYemek";
            this.nYemek.Size = new System.Drawing.Size(120, 20);
            this.nYemek.TabIndex = 6;
            // 
            // nTatli
            // 
            this.nTatli.Location = new System.Drawing.Point(110, 127);
            this.nTatli.Name = "nTatli";
            this.nTatli.Size = new System.Drawing.Size(120, 20);
            this.nTatli.TabIndex = 7;
            // 
            // listbox
            // 
            this.listbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listbox.FormattingEnabled = true;
            this.listbox.Location = new System.Drawing.Point(0, 0);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(313, 206);
            this.listbox.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tabControl1.ResumeLayout(false);
            this.Müşteri.ResumeLayout(false);
            this.Müşteri.PerformLayout();
            this.Sipariş.ResumeLayout(false);
            this.Sipariş.PerformLayout();
            this.Hesap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nCorba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSalata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nYemek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTatli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Müşteri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TabPage Sipariş;
        private System.Windows.Forms.TabPage Hesap;
        private System.Windows.Forms.NumericUpDown nTatli;
        private System.Windows.Forms.NumericUpDown nYemek;
        private System.Windows.Forms.NumericUpDown nSalata;
        private System.Windows.Forms.NumericUpDown nCorba;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listbox;
    }
}