namespace Vozila.Win32
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
            this.rbtAuti = new System.Windows.Forms.RadioButton();
            this.rbtBrodovi = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtBoja = new System.Windows.Forms.TextBox();
            this.txtKS = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.lstAutomobili = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstBrodovi = new System.Windows.Forms.ListBox();
            this.lblCcm = new System.Windows.Forms.Label();
            this.txtCcm = new System.Windows.Forms.TextBox();
            this.txtIstisnina = new System.Windows.Forms.TextBox();
            this.lblIstisnina = new System.Windows.Forms.Label();
            this.Selektirano = new System.Windows.Forms.Label();
            this.txtSelected = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRedniBroj = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rbtAuti
            // 
            this.rbtAuti.AutoSize = true;
            this.rbtAuti.Location = new System.Drawing.Point(38, 13);
            this.rbtAuti.Name = "rbtAuti";
            this.rbtAuti.Size = new System.Drawing.Size(73, 17);
            this.rbtAuti.TabIndex = 4;
            this.rbtAuti.Text = "Automobili";
            this.rbtAuti.UseVisualStyleBackColor = true;
            // 
            // rbtBrodovi
            // 
            this.rbtBrodovi.AutoSize = true;
            this.rbtBrodovi.Checked = true;
            this.rbtBrodovi.Location = new System.Drawing.Point(117, 13);
            this.rbtBrodovi.Name = "rbtBrodovi";
            this.rbtBrodovi.Size = new System.Drawing.Size(61, 17);
            this.rbtBrodovi.TabIndex = 1;
            this.rbtBrodovi.TabStop = true;
            this.rbtBrodovi.Text = "Brodovi";
            this.rbtBrodovi.UseVisualStyleBackColor = true;
            this.rbtBrodovi.CheckedChanged += new System.EventHandler(this.rbtBrodovi_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Boja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "KS:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(56, 53);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(139, 20);
            this.txtNaziv.TabIndex = 5;
            this.txtNaziv.Text = "Jugić";
            // 
            // txtBoja
            // 
            this.txtBoja.Location = new System.Drawing.Point(56, 86);
            this.txtBoja.Name = "txtBoja";
            this.txtBoja.Size = new System.Drawing.Size(139, 20);
            this.txtBoja.TabIndex = 6;
            // 
            // txtKS
            // 
            this.txtKS.Location = new System.Drawing.Point(56, 120);
            this.txtKS.Name = "txtKS";
            this.txtKS.Size = new System.Drawing.Size(139, 20);
            this.txtKS.TabIndex = 7;
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.Orange;
            this.btnSpremi.Location = new System.Drawing.Point(75, 184);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(92, 23);
            this.btnSpremi.TabIndex = 8;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // lstAutomobili
            // 
            this.lstAutomobili.FormattingEnabled = true;
            this.lstAutomobili.Location = new System.Drawing.Point(276, 43);
            this.lstAutomobili.Name = "lstAutomobili";
            this.lstAutomobili.Size = new System.Drawing.Size(222, 290);
            this.lstAutomobili.TabIndex = 9;
            this.lstAutomobili.Click += new System.EventHandler(this.lstAutomobili_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Automobili:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(527, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Brodovi:";
            // 
            // lstBrodovi
            // 
            this.lstBrodovi.FormattingEnabled = true;
            this.lstBrodovi.Location = new System.Drawing.Point(530, 43);
            this.lstBrodovi.Name = "lstBrodovi";
            this.lstBrodovi.Size = new System.Drawing.Size(220, 290);
            this.lstBrodovi.TabIndex = 12;
            this.lstBrodovi.Click += new System.EventHandler(this.lstBrodovi_Click);
            // 
            // lblCcm
            // 
            this.lblCcm.AutoSize = true;
            this.lblCcm.Location = new System.Drawing.Point(19, 161);
            this.lblCcm.Name = "lblCcm";
            this.lblCcm.Size = new System.Drawing.Size(31, 13);
            this.lblCcm.TabIndex = 13;
            this.lblCcm.Text = "Ccm:";
            // 
            // txtCcm
            // 
            this.txtCcm.Location = new System.Drawing.Point(56, 158);
            this.txtCcm.Name = "txtCcm";
            this.txtCcm.Size = new System.Drawing.Size(139, 20);
            this.txtCcm.TabIndex = 14;
            // 
            // txtIstisnina
            // 
            this.txtIstisnina.Location = new System.Drawing.Point(56, 158);
            this.txtIstisnina.Name = "txtIstisnina";
            this.txtIstisnina.Size = new System.Drawing.Size(139, 20);
            this.txtIstisnina.TabIndex = 16;
            // 
            // lblIstisnina
            // 
            this.lblIstisnina.AutoSize = true;
            this.lblIstisnina.Location = new System.Drawing.Point(2, 161);
            this.lblIstisnina.Name = "lblIstisnina";
            this.lblIstisnina.Size = new System.Drawing.Size(48, 13);
            this.lblIstisnina.TabIndex = 15;
            this.lblIstisnina.Text = "Istisnina:";
            // 
            // Selektirano
            // 
            this.Selektirano.AutoSize = true;
            this.Selektirano.Location = new System.Drawing.Point(89, 252);
            this.Selektirano.Name = "Selektirano";
            this.Selektirano.Size = new System.Drawing.Size(63, 13);
            this.Selektirano.TabIndex = 17;
            this.Selektirano.Text = "Selektirano:";
            this.Selektirano.Click += new System.EventHandler(this.Selektirano_Click);
            // 
            // txtSelected
            // 
            this.txtSelected.Location = new System.Drawing.Point(5, 278);
            this.txtSelected.Name = "txtSelected";
            this.txtSelected.ReadOnly = true;
            this.txtSelected.Size = new System.Drawing.Size(238, 20);
            this.txtSelected.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Redni Broj Selektiranog Itema:";
            // 
            // txtRedniBroj
            // 
            this.txtRedniBroj.Location = new System.Drawing.Point(158, 313);
            this.txtRedniBroj.Name = "txtRedniBroj";
            this.txtRedniBroj.ReadOnly = true;
            this.txtRedniBroj.Size = new System.Drawing.Size(85, 20);
            this.txtRedniBroj.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 372);
            this.Controls.Add(this.txtRedniBroj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSelected);
            this.Controls.Add(this.Selektirano);
            this.Controls.Add(this.txtIstisnina);
            this.Controls.Add(this.lblIstisnina);
            this.Controls.Add(this.txtCcm);
            this.Controls.Add(this.lblCcm);
            this.Controls.Add(this.lstBrodovi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstAutomobili);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtKS);
            this.Controls.Add(this.txtBoja);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtBrodovi);
            this.Controls.Add(this.rbtAuti);
            this.Name = "Form1";
            this.Text = "Unos vozila";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtAuti;
        private System.Windows.Forms.RadioButton rbtBrodovi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtBoja;
        private System.Windows.Forms.TextBox txtKS;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.ListBox lstAutomobili;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstBrodovi;
        private System.Windows.Forms.Label lblCcm;
        private System.Windows.Forms.TextBox txtCcm;
        private System.Windows.Forms.TextBox txtIstisnina;
        private System.Windows.Forms.Label lblIstisnina;
        private System.Windows.Forms.Label Selektirano;
        private System.Windows.Forms.TextBox txtSelected;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRedniBroj;
    }
}

