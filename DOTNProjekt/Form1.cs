using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOTNProjekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void službeniPasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sluzbeni_pas sluzpas = new Sluzbeni_pas();
            sluzpas.ShowDialog();
        }

        private void unosNoveDržaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unos_drzave drzava = new Unos_drzave();
            drzava.ShowDialog();
        }

        private void unosNoveMačkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unos_macke macka = new Unos_macke();
            macka.ShowDialog();
        }

        private void unosNovogPsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unos_psa pas = new Unos_psa();
            pas.ShowDialog();
        }

        private void terijerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Terijer teri = new Terijer();
            teri.ShowDialog();
        }

        private void lovačkiPasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lovacki_pas lovacpas = new Lovacki_pas();
            lovacpas.ShowDialog();
        }

        private void pasZaPratnjuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pas_za_pratnju pratpas = new Pas_za_pratnju();
            pratpas.ShowDialog();
        }

        private void patuljastiPasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Patuljasti_pas patpas = new Patuljasti_pas();
            patpas.ShowDialog();
        }

        private void hrtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hrt hrt = new Hrt();
            hrt.ShowDialog();
        }

        private void domaćaMačkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Domaca_macka macka = new Domaca_macka();
            macka.ShowDialog();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
