namespace AsistentGUI
{
    partial class KreiranjeTurnira
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
            this.lblAkontacija = new System.Windows.Forms.Label();
            this.txtAkotancija = new System.Windows.Forms.TextBox();
            this.lblNazivTima = new System.Windows.Forms.Label();
            this.cmbNazivTima = new System.Windows.Forms.ComboBox();
            this.btnNapraviTim = new System.Windows.Forms.Button();
            this.btnUcitajTim = new System.Windows.Forms.Button();
            this.lblListaTimova = new System.Windows.Forms.Label();
            this.lstListaTimova = new System.Windows.Forms.ListBox();
            this.btnIzbrisiTim = new System.Windows.Forms.Button();
            this.btnUrediTim = new System.Windows.Forms.Button();
            this.btnUrediNagradu = new System.Windows.Forms.Button();
            this.btnIzbrisiNagradu = new System.Windows.Forms.Button();
            this.lstNagrada = new System.Windows.Forms.ListBox();
            this.lblNagrada = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnDodajNagradu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAkontacija
            // 
            this.lblAkontacija.AutoSize = true;
            this.lblAkontacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAkontacija.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblAkontacija.Location = new System.Drawing.Point(63, 58);
            this.lblAkontacija.Name = "lblAkontacija";
            this.lblAkontacija.Size = new System.Drawing.Size(118, 25);
            this.lblAkontacija.TabIndex = 0;
            this.lblAkontacija.Text = "Akontacija:";
            // 
            // txtAkotancija
            // 
            this.txtAkotancija.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAkotancija.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtAkotancija.Location = new System.Drawing.Point(199, 55);
            this.txtAkotancija.Name = "txtAkotancija";
            this.txtAkotancija.Size = new System.Drawing.Size(158, 31);
            this.txtAkotancija.TabIndex = 1;
            this.txtAkotancija.TextChanged += new System.EventHandler(this.txtAkotancija_TextChanged);
            // 
            // lblNazivTima
            // 
            this.lblNazivTima.AutoSize = true;
            this.lblNazivTima.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazivTima.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblNazivTima.Location = new System.Drawing.Point(63, 105);
            this.lblNazivTima.Name = "lblNazivTima";
            this.lblNazivTima.Size = new System.Drawing.Size(53, 25);
            this.lblNazivTima.TabIndex = 2;
            this.lblNazivTima.Text = "Tim:";
            // 
            // cmbNazivTima
            // 
            this.cmbNazivTima.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbNazivTima.ForeColor = System.Drawing.Color.DarkOrange;
            this.cmbNazivTima.FormattingEnabled = true;
            this.cmbNazivTima.Location = new System.Drawing.Point(128, 102);
            this.cmbNazivTima.Name = "cmbNazivTima";
            this.cmbNazivTima.Size = new System.Drawing.Size(229, 33);
            this.cmbNazivTima.TabIndex = 3;
            // 
            // btnNapraviTim
            // 
            this.btnNapraviTim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnNapraviTim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnNapraviTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNapraviTim.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnNapraviTim.Location = new System.Drawing.Point(151, 148);
            this.btnNapraviTim.Name = "btnNapraviTim";
            this.btnNapraviTim.Size = new System.Drawing.Size(159, 47);
            this.btnNapraviTim.TabIndex = 4;
            this.btnNapraviTim.Text = "Napravi tim";
            this.btnNapraviTim.UseVisualStyleBackColor = true;
            // 
            // btnUcitajTim
            // 
            this.btnUcitajTim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnUcitajTim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnUcitajTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUcitajTim.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnUcitajTim.Location = new System.Drawing.Point(151, 202);
            this.btnUcitajTim.Name = "btnUcitajTim";
            this.btnUcitajTim.Size = new System.Drawing.Size(159, 47);
            this.btnUcitajTim.TabIndex = 5;
            this.btnUcitajTim.Text = "Učitaj tim";
            this.btnUcitajTim.UseVisualStyleBackColor = true;
            // 
            // lblListaTimova
            // 
            this.lblListaTimova.AutoSize = true;
            this.lblListaTimova.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblListaTimova.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblListaTimova.Location = new System.Drawing.Point(479, 26);
            this.lblListaTimova.Name = "lblListaTimova";
            this.lblListaTimova.Size = new System.Drawing.Size(140, 25);
            this.lblListaTimova.TabIndex = 6;
            this.lblListaTimova.Text = "Lista Timova:";
            // 
            // lstListaTimova
            // 
            this.lstListaTimova.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lstListaTimova.ForeColor = System.Drawing.Color.DarkOrange;
            this.lstListaTimova.FormattingEnabled = true;
            this.lstListaTimova.ItemHeight = 25;
            this.lstListaTimova.Location = new System.Drawing.Point(484, 55);
            this.lstListaTimova.Name = "lstListaTimova";
            this.lstListaTimova.Size = new System.Drawing.Size(300, 229);
            this.lstListaTimova.TabIndex = 7;
            // 
            // btnIzbrisiTim
            // 
            this.btnIzbrisiTim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnIzbrisiTim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnIzbrisiTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbrisiTim.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnIzbrisiTim.Location = new System.Drawing.Point(812, 108);
            this.btnIzbrisiTim.Name = "btnIzbrisiTim";
            this.btnIzbrisiTim.Size = new System.Drawing.Size(145, 35);
            this.btnIzbrisiTim.TabIndex = 8;
            this.btnIzbrisiTim.Text = "Izbriši";
            this.btnIzbrisiTim.UseVisualStyleBackColor = true;
            // 
            // btnUrediTim
            // 
            this.btnUrediTim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnUrediTim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnUrediTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUrediTim.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnUrediTim.Location = new System.Drawing.Point(812, 173);
            this.btnUrediTim.Name = "btnUrediTim";
            this.btnUrediTim.Size = new System.Drawing.Size(145, 35);
            this.btnUrediTim.TabIndex = 9;
            this.btnUrediTim.Text = "Uredi";
            this.btnUrediTim.UseVisualStyleBackColor = true;
            // 
            // btnUrediNagradu
            // 
            this.btnUrediNagradu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnUrediNagradu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnUrediNagradu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUrediNagradu.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnUrediNagradu.Location = new System.Drawing.Point(812, 447);
            this.btnUrediNagradu.Name = "btnUrediNagradu";
            this.btnUrediNagradu.Size = new System.Drawing.Size(145, 35);
            this.btnUrediNagradu.TabIndex = 13;
            this.btnUrediNagradu.Text = "Uredi";
            this.btnUrediNagradu.UseVisualStyleBackColor = true;
            // 
            // btnIzbrisiNagradu
            // 
            this.btnIzbrisiNagradu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnIzbrisiNagradu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnIzbrisiNagradu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbrisiNagradu.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnIzbrisiNagradu.Location = new System.Drawing.Point(812, 382);
            this.btnIzbrisiNagradu.Name = "btnIzbrisiNagradu";
            this.btnIzbrisiNagradu.Size = new System.Drawing.Size(145, 35);
            this.btnIzbrisiNagradu.TabIndex = 12;
            this.btnIzbrisiNagradu.Text = "Izbriši";
            this.btnIzbrisiNagradu.UseVisualStyleBackColor = true;
            // 
            // lstNagrada
            // 
            this.lstNagrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lstNagrada.ForeColor = System.Drawing.Color.DarkOrange;
            this.lstNagrada.FormattingEnabled = true;
            this.lstNagrada.ItemHeight = 25;
            this.lstNagrada.Location = new System.Drawing.Point(484, 329);
            this.lstNagrada.Name = "lstNagrada";
            this.lstNagrada.Size = new System.Drawing.Size(300, 229);
            this.lstNagrada.TabIndex = 11;
            // 
            // lblNagrada
            // 
            this.lblNagrada.AutoSize = true;
            this.lblNagrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNagrada.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblNagrada.Location = new System.Drawing.Point(479, 300);
            this.lblNagrada.Name = "lblNagrada";
            this.lblNagrada.Size = new System.Drawing.Size(100, 25);
            this.lblNagrada.TabIndex = 10;
            this.lblNagrada.Text = "Nagrada:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnOdustani.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnOdustani.Location = new System.Drawing.Point(400, 569);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(158, 47);
            this.btnOdustani.TabIndex = 21;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            // 
            // btnDodajNagradu
            // 
            this.btnDodajNagradu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnDodajNagradu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnDodajNagradu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajNagradu.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnDodajNagradu.Location = new System.Drawing.Point(141, 397);
            this.btnDodajNagradu.Name = "btnDodajNagradu";
            this.btnDodajNagradu.Size = new System.Drawing.Size(181, 47);
            this.btnDodajNagradu.TabIndex = 22;
            this.btnDodajNagradu.Text = "Dodaj nagradu";
            this.btnDodajNagradu.UseVisualStyleBackColor = true;
            // 
            // KreiranjeTurnira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 628);
            this.Controls.Add(this.btnDodajNagradu);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnUrediNagradu);
            this.Controls.Add(this.btnIzbrisiNagradu);
            this.Controls.Add(this.lstNagrada);
            this.Controls.Add(this.lblNagrada);
            this.Controls.Add(this.btnUrediTim);
            this.Controls.Add(this.btnIzbrisiTim);
            this.Controls.Add(this.lstListaTimova);
            this.Controls.Add(this.lblListaTimova);
            this.Controls.Add(this.btnUcitajTim);
            this.Controls.Add(this.btnNapraviTim);
            this.Controls.Add(this.cmbNazivTima);
            this.Controls.Add(this.lblNazivTima);
            this.Controls.Add(this.txtAkotancija);
            this.Controls.Add(this.lblAkontacija);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "KreiranjeTurnira";
            this.Text = "Kreiranje turnira";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAkontacija;
        private System.Windows.Forms.TextBox txtAkotancija;
        private System.Windows.Forms.Label lblNazivTima;
        private System.Windows.Forms.ComboBox cmbNazivTima;
        private System.Windows.Forms.Button btnNapraviTim;
        private System.Windows.Forms.Button btnUcitajTim;
        private System.Windows.Forms.Label lblListaTimova;
        private System.Windows.Forms.ListBox lstListaTimova;
        private System.Windows.Forms.Button btnIzbrisiTim;
        private System.Windows.Forms.Button btnUrediTim;
        private System.Windows.Forms.Button btnUrediNagradu;
        private System.Windows.Forms.Button btnIzbrisiNagradu;
        private System.Windows.Forms.ListBox lstNagrada;
        private System.Windows.Forms.Label lblNagrada;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnDodajNagradu;
    }
}