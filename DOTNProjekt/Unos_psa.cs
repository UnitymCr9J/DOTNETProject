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
    public partial class Unos_psa : Form
    {
        private ZivotinjeEntities _zivotinje = new ZivotinjeEntities();
        public Unos_psa()
        {
            InitializeComponent();
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_1.Text != "" && tb_2.Text != "")
                {
                    lb_6.Text = string.Empty;
                    psi Pas = new psi();
                    Pas.ime = tb_1.Text;
                    string pasmine = cb_1.SelectedItem.ToString();
                    Pas.pasmina = pasmine;
                    string vrste = cb_2.SelectedItem.ToString();
                    Pas.vrsta = vrste;
                    Pas.cijena = double.Parse(tb_2.Text);
                    drzave drzava = (drzave)cb_3.SelectedItem;
                    Pas.drzave = drzava;
                    _zivotinje.psi.Add(Pas);
                    _zivotinje.SaveChanges();
                }
                else
                {
                    lb_6.Text = "Pogrešan Unos!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška u unosu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Unos_psa_Load(object sender, EventArgs e)
        {
            var pasmine = (from Pasmine in _zivotinje.psi
                          select Pasmine.pasmina).Distinct();
            var vrste = (from Vrste in _zivotinje.psi
                        select Vrste.vrsta).Distinct();
            cb_1.DataSource = pasmine.ToList();
            cb_1.DisplayMember= "pasmina";
            cb_2.DataSource = vrste.ToList();
            cb_2.DisplayMember = "vrsta";
            cb_3.DataSource = _zivotinje.drzave.ToList<drzave>();
            cb_3.DisplayMember = "naziv";
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
