using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vozila.Model;

//DZ- 
//1.Proširiti spremanje Automobila i brodova 
//2.Na listama prikazati vrijednosti svih svojstav
//3. Napraviti labelu (na dnu ekrana) na kojoj će se ispisati sadržaj koji je odabran na bilo kojoj listi
namespace Vozila.Win32
{
    public partial class Form1 : Form
    {
        private List<Automobil> _auti = new List<Automobil>();
        private List<Brod> _brodovi = new List<Brod>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {


                if (rbtAuti.Checked)
                {
                    //Spremamo aute
                    Automobil noviAuto = new Automobil();
                    //Dohvat podataka iz kontrola
                    noviAuto.Naziv = txtNaziv.Text;
                    noviAuto.Boja = txtBoja.Text;
                    noviAuto.KS = int.Parse(txtKS.Text);
                    noviAuto.Ccm = decimal.Parse(txtCcm.Text);

                    _auti.Add(noviAuto);
                }
                else
                {
                    //spremamo brodove


                    Brod noviBrod = new Brod
                    {
                        Naziv = txtNaziv.Text,
                        Boja = txtBoja.Text,
                        KS = int.Parse(txtKS.Text),
                        Istisnina = decimal.Parse(txtIstisnina.Text)
                    };

                    _brodovi.Add(noviBrod);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Ispis();
        }

        private void Ispis()
        {
            lstAutomobili.Items.Clear();

            foreach(Automobil auto in _auti)
            {
                lstAutomobili.Items.Add(auto.ToString());
            }

            lstBrodovi.Items.Clear();
            foreach(Brod br in _brodovi)
            {
                lstBrodovi.Items.Add(br.Detalji());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        //   rbtAuti.Checked = true;
        }

        private void rbtBrodovi_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtBrodovi.Checked)
            {
                txtCcm.Visible = false;
                lblCcm.Visible = false;

                txtIstisnina.Visible = true;
                lblIstisnina.Visible = true;
            }
            else
            {
                txtCcm.Visible = true;
                lblCcm.Visible = true;

                txtIstisnina.Visible = false;
                lblIstisnina.Visible = false;
            }
        }

        private void lstBrodovi_Click(object sender, EventArgs e)
        {
            var send = (ListBox)sender;

            if (send.SelectedItem != null)
            {

                txtSelected.Text = send.Text;
                txtRedniBroj.Text = (send.Items.IndexOf(send.SelectedItem) + 1).ToString();
            }
        }

        private void Selektirano_Click(object sender, EventArgs e)
        {

        }

        private void lstAutomobili_Click(object sender, EventArgs e)
        {
            var send = (ListBox)sender;

            if (send.SelectedItem != null)
            {
                txtSelected.Text = send.Text;
                txtRedniBroj.Text = (send.Items.IndexOf(send.SelectedItem) + 1).ToString();
            }
        }
    }
}
