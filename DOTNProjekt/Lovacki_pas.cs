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
    public partial class Lovacki_pas : Form
    {
        private ZivotinjeEntities _zivotinje = new ZivotinjeEntities();
        public Lovacki_pas()
        {
            InitializeComponent();
        }

        private void Lovacki_pas_Load(object sender, EventArgs e)
        {
            var lovpsi = from pas in _zivotinje.psi
                         join drzava in _zivotinje.drzave
                         on pas.drzava_id equals drzava.id
                         where pas.vrsta == "Lovački pas"
                         orderby pas.pasmina
                         select new { Ime = pas.ime, Pasmina = pas.pasmina, Cijena_u_kn = pas.cijena, Država = drzava.naziv};
            dw_1.DataSource = lovpsi.ToList();
        }
    }
}
