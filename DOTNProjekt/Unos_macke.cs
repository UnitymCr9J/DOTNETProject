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
    public partial class Unos_macke : Form
    {
        private ZivotinjeEntities _zivotinje = new ZivotinjeEntities();
        public Unos_macke()
        {
            InitializeComponent();
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_1.Text != "" && tb_2.Text != "")
                {
                    lb_4.Text = string.Empty;
                    macke Macka = new macke();
                    Macka.ime = tb_1.Text;
                    Macka.cijena = double.Parse(tb_2.Text);
                    drzave drzava = (drzave)cb_1.SelectedItem;
                    Macka.drzave = drzava;
                    _zivotinje.macke.Add(Macka);
                    _zivotinje.SaveChanges();
                }
                else
                {
                    lb_4.Text = "Pogrešan unos!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška u unosu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Unos_macke_Load(object sender, EventArgs e)
        {
            cb_1.DataSource = _zivotinje.drzave.ToList<drzave>();
            cb_1.DisplayMember = "naziv";
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
