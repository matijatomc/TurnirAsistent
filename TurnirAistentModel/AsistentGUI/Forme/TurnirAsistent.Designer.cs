namespace AsistentGUI.Forme
{
    partial class TurnirAsistent
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
            this.lblNazivTurnira = new System.Windows.Forms.Label();
            this.cmbNazivTurnira = new System.Windows.Forms.ComboBox();
            this.btnUcitajTurnir = new System.Windows.Forms.Button();
            this.btnKreirajNoviTurnir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNazivTurnira
            // 
            this.lblNazivTurnira.AutoSize = true;
            this.lblNazivTurnira.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazivTurnira.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblNazivTurnira.Location = new System.Drawing.Point(305, 104);
            this.lblNazivTurnira.Name = "lblNazivTurnira";
            this.lblNazivTurnira.Size = new System.Drawing.Size(91, 31);
            this.lblNazivTurnira.TabIndex = 0;
            this.lblNazivTurnira.Text = "Naziv:";
            // 
            // cmbNazivTurnira
            // 
            this.cmbNazivTurnira.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbNazivTurnira.ForeColor = System.Drawing.Color.DarkOrange;
            this.cmbNazivTurnira.FormattingEnabled = true;
            this.cmbNazivTurnira.Location = new System.Drawing.Point(402, 101);
            this.cmbNazivTurnira.Name = "cmbNazivTurnira";
            this.cmbNazivTurnira.Size = new System.Drawing.Size(175, 39);
            this.cmbNazivTurnira.TabIndex = 1;
            // 
            // btnUcitajTurnir
            // 
            this.btnUcitajTurnir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnUcitajTurnir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnUcitajTurnir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUcitajTurnir.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnUcitajTurnir.Location = new System.Drawing.Point(273, 146);
            this.btnUcitajTurnir.Name = "btnUcitajTurnir";
            this.btnUcitajTurnir.Size = new System.Drawing.Size(341, 85);
            this.btnUcitajTurnir.TabIndex = 2;
            this.btnUcitajTurnir.Text = "Učitaj postoječi turnir";
            this.btnUcitajTurnir.UseVisualStyleBackColor = true;
            // 
            // btnKreirajNoviTurnir
            // 
            this.btnKreirajNoviTurnir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnKreirajNoviTurnir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnKreirajNoviTurnir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKreirajNoviTurnir.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnKreirajNoviTurnir.Location = new System.Drawing.Point(273, 249);
            this.btnKreirajNoviTurnir.Name = "btnKreirajNoviTurnir";
            this.btnKreirajNoviTurnir.Size = new System.Drawing.Size(341, 85);
            this.btnKreirajNoviTurnir.TabIndex = 3;
            this.btnKreirajNoviTurnir.Text = "Kreiraj Novi Turnir";
            this.btnKreirajNoviTurnir.UseVisualStyleBackColor = true;
            // 
            // TurnirAsistent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(927, 503);
            this.Controls.Add(this.btnKreirajNoviTurnir);
            this.Controls.Add(this.btnUcitajTurnir);
            this.Controls.Add(this.cmbNazivTurnira);
            this.Controls.Add(this.lblNazivTurnira);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TurnirAsistent";
            this.Text = "Turnir asistent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazivTurnira;
        private System.Windows.Forms.ComboBox cmbNazivTurnira;
        private System.Windows.Forms.Button btnUcitajTurnir;
        private System.Windows.Forms.Button btnKreirajNoviTurnir;
    }
}