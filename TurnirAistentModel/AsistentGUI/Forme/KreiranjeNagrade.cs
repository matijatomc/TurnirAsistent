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
using TurnirAistentModel.Konekcije;
using TurnirAistentModel.Modeli;

namespace AsistentGUI.Forme
{
    public partial class KreiranjeNagrade : Form
    {
        public KreiranjeNagrade()
        {
            InitializeComponent();
        }

        private void btnUnesiNagradu_Click(object sender, EventArgs e)
        {
            if (potvrdiFormu())
            {
                NagradaModel model = new NagradaModel(
                    txtOsvojenoMjesto.Text,
                    txtNazivNagrade.Text,
                    txtIznosNagrade.Text,
                    txtPostotakNagrade.Text);

                GlobalConfig.Konekcija.StvoriNagradu(model);
                
                txtOsvojenoMjesto.Text = "";
                txtNazivNagrade.Text = "";
                txtIznosNagrade.Text = "0";
                txtPostotakNagrade.Text = "0";
            }
            else
            {
                MessageBox.Show("Ova forma ima nepravilne podatke. Molim ves provjerite i probajte opet.");
            }
        }

        private bool potvrdiFormu()
        {
            bool output = true;
            int osvojenoMjesto = 0;
            bool potvrdiOsvojenoMjedto = int.TryParse(txtOsvojenoMjesto.Text, out osvojenoMjesto);

            if (!potvrdiOsvojenoMjedto)
            {
                output = false;
            }

            if (osvojenoMjesto < 1)
            {
                output = false;
            }

            if (txtOsvojenoMjesto.Text.Length == 0)
            {
                output = false;
            }

            if (txtIznosNagrade.Text.Length == 0)
            {
                output = false;
            }

            decimal iznosNagrade = 0;
            double postotakNagrade = 0;

            bool potvrdiIznosNagrade = decimal.TryParse(txtIznosNagrade.Text, out iznosNagrade);
            bool potvrdiPostotakNagrade = double.TryParse(txtPostotakNagrade.Text, out postotakNagrade);

            if (!potvrdiIznosNagrade || !potvrdiPostotakNagrade)
            {
                output = false;
            }

            if (iznosNagrade <= 0 && postotakNagrade <= 0)
            {
                output = false;
            }

            if (postotakNagrade < 0 || postotakNagrade > 100)
            {
                output = false;
            }

            return output;
        }
    }
}
