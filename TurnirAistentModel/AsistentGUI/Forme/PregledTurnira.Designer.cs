namespace AsistentGUI.Forme
{
    partial class PregledTurnira
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
            this.lblTurnir = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblKolo = new System.Windows.Forms.Label();
            this.cmbKolo = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblPrvaEkipa = new System.Windows.Forms.Label();
            this.lblRezultatPrveEkipe = new System.Windows.Forms.Label();
            this.txtRezultatPrveEkipe = new System.Windows.Forms.TextBox();
            this.txtRezultatDrugeEkipe = new System.Windows.Forms.TextBox();
            this.lblRezultatDrugeEkipe = new System.Windows.Forms.Label();
            this.lblDrugaEkipa = new System.Windows.Forms.Label();
            this.lblVS = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTurnir
            // 
            this.lblTurnir.AutoSize = true;
            this.lblTurnir.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTurnir.Location = new System.Drawing.Point(36, 23);
            this.lblTurnir.Name = "lblTurnir";
            this.lblTurnir.Size = new System.Drawing.Size(100, 33);
            this.lblTurnir.TabIndex = 0;
            this.lblTurnir.Text = "Turnir:";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaziv.Location = new System.Drawing.Point(125, 23);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(118, 33);
            this.lblNaziv.TabIndex = 1;
            this.lblNaziv.Text = "<naziv>";
            // 
            // lblKolo
            // 
            this.lblKolo.AutoSize = true;
            this.lblKolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKolo.Location = new System.Drawing.Point(36, 83);
            this.lblKolo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKolo.Name = "lblKolo";
            this.lblKolo.Size = new System.Drawing.Size(81, 33);
            this.lblKolo.TabIndex = 2;
            this.lblKolo.Text = "Kolo:";
            // 
            // cmbKolo
            // 
            this.cmbKolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbKolo.FormattingEnabled = true;
            this.cmbKolo.Location = new System.Drawing.Point(121, 80);
            this.cmbKolo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbKolo.Name = "cmbKolo";
            this.cmbKolo.Size = new System.Drawing.Size(261, 41);
            this.cmbKolo.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(47, 127);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(335, 33);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Prikaži neodigrane utakmice";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(43, 166);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(339, 294);
            this.listBox1.TabIndex = 5;
            // 
            // lblPrvaEkipa
            // 
            this.lblPrvaEkipa.AutoSize = true;
            this.lblPrvaEkipa.Location = new System.Drawing.Point(419, 210);
            this.lblPrvaEkipa.Name = "lblPrvaEkipa";
            this.lblPrvaEkipa.Size = new System.Drawing.Size(148, 29);
            this.lblPrvaEkipa.TabIndex = 6;
            this.lblPrvaEkipa.Text = "<prvaEkipa>";
            this.lblPrvaEkipa.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblRezultatPrveEkipe
            // 
            this.lblRezultatPrveEkipe.AutoSize = true;
            this.lblRezultatPrveEkipe.Location = new System.Drawing.Point(419, 248);
            this.lblRezultatPrveEkipe.Name = "lblRezultatPrveEkipe";
            this.lblRezultatPrveEkipe.Size = new System.Drawing.Size(105, 29);
            this.lblRezultatPrveEkipe.TabIndex = 7;
            this.lblRezultatPrveEkipe.Text = "Rezultat:";
            // 
            // txtRezultatPrveEkipe
            // 
            this.txtRezultatPrveEkipe.Location = new System.Drawing.Point(530, 245);
            this.txtRezultatPrveEkipe.Name = "txtRezultatPrveEkipe";
            this.txtRezultatPrveEkipe.Size = new System.Drawing.Size(133, 35);
            this.txtRezultatPrveEkipe.TabIndex = 8;
            // 
            // txtRezultatDrugeEkipe
            // 
            this.txtRezultatDrugeEkipe.Location = new System.Drawing.Point(530, 366);
            this.txtRezultatDrugeEkipe.Name = "txtRezultatDrugeEkipe";
            this.txtRezultatDrugeEkipe.Size = new System.Drawing.Size(133, 35);
            this.txtRezultatDrugeEkipe.TabIndex = 11;
            // 
            // lblRezultatDrugeEkipe
            // 
            this.lblRezultatDrugeEkipe.AutoSize = true;
            this.lblRezultatDrugeEkipe.Location = new System.Drawing.Point(419, 369);
            this.lblRezultatDrugeEkipe.Name = "lblRezultatDrugeEkipe";
            this.lblRezultatDrugeEkipe.Size = new System.Drawing.Size(105, 29);
            this.lblRezultatDrugeEkipe.TabIndex = 10;
            this.lblRezultatDrugeEkipe.Text = "Rezultat:";
            // 
            // lblDrugaEkipa
            // 
            this.lblDrugaEkipa.AutoSize = true;
            this.lblDrugaEkipa.Location = new System.Drawing.Point(419, 331);
            this.lblDrugaEkipa.Name = "lblDrugaEkipa";
            this.lblDrugaEkipa.Size = new System.Drawing.Size(164, 29);
            this.lblDrugaEkipa.TabIndex = 9;
            this.lblDrugaEkipa.Text = "<drugaEkipa>";
            // 
            // lblVS
            // 
            this.lblVS.AutoSize = true;
            this.lblVS.Location = new System.Drawing.Point(495, 292);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(60, 29);
            this.lblVS.TabIndex = 12;
            this.lblVS.Text = "-VS-";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(692, 292);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(130, 41);
            this.btnSpremi.TabIndex = 13;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(359, 495);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(130, 41);
            this.btnOdustani.TabIndex = 14;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.button1_Click);
            // 
            // PregledTurnira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 548);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.lblVS);
            this.Controls.Add(this.txtRezultatDrugeEkipe);
            this.Controls.Add(this.lblRezultatDrugeEkipe);
            this.Controls.Add(this.lblDrugaEkipa);
            this.Controls.Add(this.txtRezultatPrveEkipe);
            this.Controls.Add(this.lblRezultatPrveEkipe);
            this.Controls.Add(this.lblPrvaEkipa);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cmbKolo);
            this.Controls.Add(this.lblKolo);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblTurnir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "PregledTurnira";
            this.Text = "Pregled Turnira";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTurnir;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblKolo;
        private System.Windows.Forms.ComboBox cmbKolo;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblPrvaEkipa;
        private System.Windows.Forms.Label lblRezultatPrveEkipe;
        private System.Windows.Forms.TextBox txtRezultatPrveEkipe;
        private System.Windows.Forms.TextBox txtRezultatDrugeEkipe;
        private System.Windows.Forms.Label lblRezultatDrugeEkipe;
        private System.Windows.Forms.Label lblDrugaEkipa;
        private System.Windows.Forms.Label lblVS;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
    }
}

