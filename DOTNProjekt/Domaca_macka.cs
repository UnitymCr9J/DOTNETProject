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
    public partial class Domaca_macka : Form
    {
        private ZivotinjeEntities _zivotinje = new ZivotinjeEntities();
        public Domaca_macka()
        {
            InitializeComponent();
        }

        private void Domaca_macka_Load(object sender, EventArgs e)
        {
            var domacka = from macka in _zivotinje.macke
                          join drzava in _zivotinje.drzave
                          on macka.drzava_id equals drzava.id
                          orderby macka.ime
                          select new { Ime = macka.ime, Cijena_u_kn = macka.cijena, Država = drzava.naziv };
            dw_1.DataSource = domacka.ToList();
        }
    }
}
