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
    public partial class Unos_drzave : Form
    {
        private ZivotinjeEntities _zivotinje = new ZivotinjeEntities();
        public Unos_drzave()
        {
            InitializeComponent();
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_1.Text != "")
                {
                    lb_2.Text = string.Empty;
                    drzave Drzava = new drzave();
                    Drzava.naziv = tb_1.Text;
                    _zivotinje.drzave.Add(Drzava);
                    _zivotinje.SaveChanges();
                }
                else
                {
                    lb_2.Text = "Pogrešan unos!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška u unosu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
