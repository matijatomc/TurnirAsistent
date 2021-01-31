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
        private List<OsobaModel> dostupniClanociTima = GlobalConfig.Konekcija.DobiOsobu_Sve();
        private List<OsobaModel> odabraniClanoviTima = new List<OsobaModel>();

        public KreiranjeTima()
        {
            InitializeComponent();

            //StvoriSampleData();

            SpojitList();
        }

        private void StvoriSampleData()
        {
            dostupniClanociTima.Add(new OsobaModel { Ime = "Matija", Prezime = "Tomc" });
            dostupniClanociTima.Add(new OsobaModel { Ime = "Tim", Prezime = "Corey" });

            odabraniClanoviTima.Add(new OsobaModel { Ime = "Jane", Prezime = "Smith" });
            odabraniClanoviTima.Add(new OsobaModel { Ime = "Bill", Prezime = "Jones" });
        }

        private void SpojitList()
        {
            cmbNoviIgrac.DataSource = null;

            cmbNoviIgrac.DataSource = dostupniClanociTima;
            cmbNoviIgrac.DisplayMember = "PunoIme";

            lstIgraca.DataSource = null;

            lstIgraca.DataSource = odabraniClanoviTima;
            lstIgraca.DisplayMember = "PunoIme";

            cmbNoviIgrac.Refresh();
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

                p = GlobalConfig.Konekcija.StvoriOsobu(p);

                odabraniClanoviTima.Add(p);

                SpojitList();

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

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            OsobaModel p = (OsobaModel)cmbNoviIgrac.SelectedItem;

            if (p!=null)
            {
                dostupniClanociTima.Remove(p);
                odabraniClanoviTima.Add(p);

                SpojitList(); 
            }
        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            OsobaModel p = (OsobaModel)lstIgraca.SelectedItem;

            if (p!=null)
            {
                odabraniClanoviTima.Remove(p);
                dostupniClanociTima.Add(p);

                SpojitList(); 
            }
        }
    }
}
