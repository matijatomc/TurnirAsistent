using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurnirAistentModel;
using TurnirAistentModel.Modeli;

namespace AsistentGUI.Forme
{
    public partial class KreiranjeTima : Form
    {
        public KreiranjeTima()
        {
            InitializeComponent();
        }

        private void btnDodajIgrac_Click(object sender, EventArgs e)
        {
            if (potvrdiFormu())
            {
                OsobaModel p = new OsobaModel();

                p.Ime = txtIme.Text;
                p.Prezime = txtPrezime.Text;
                p.EmailAdresa = txtEmail.Text;
                p.BrojMobitela = txtBrojMobitela.Text;

                GlobalConfig.Konekcija.StvoriOsobu(p);

                txtIme.Text = "";
                txtPrezime.Text = "";
                txtEmail.Text = "";
                txtBrojMobitela.Text = "";
            }
            else
            {
                MessageBox.Show("Trebate ispunit sva polja");
            }
        }

        private bool potvrdiFormu()
        {
            if (txtIme.Text.Length == 0)
            {
                return false;
            }

            if (txtPrezime.Text.Length == 0)
            {
                return false;
            }

            if (txtEmail.Text.Length == 0)
            {
                return false;
            }

            if (txtBrojMobitela.Text.Length == 0)
            {
                return false;
            }

            return true;
        }
    }
}
