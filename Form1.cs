using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ryzen_Shipments
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void pnlOpen(Panel Pnl, Button Btn)
        {
            if (Pnl.Height == 45)
            {
                Pnl.Height = ((Pnl.Controls.OfType<Button>().Count() - 1)*30) + 45;
            }
            Btn.Location = new Point(0, 2);
            Btn.BackColor = Color.FromArgb(19, 164, 150);
        }   

        void pnlClos(Panel Pnl, Button Btn)

        {
            foreach (var pnl in PnlMenu.Controls.OfType<Panel>())
            {
                pnl.Height = 45;
                foreach (var btn in pnl.Controls.OfType<Button>().Where(a=>a.Height == 40))
                {
                    btn.Left = -30;
                    btn.BackColor = Color.FromArgb(136, 6, 56);
                }
                foreach (var btn in pnl.Controls.OfType<Button>().Where(a => a.Height == 30))
                {
                    btn.Left = -30;
                    btn.BackColor = Color.FromArgb(237, 49, 93);
                }
            }
            Btn.Location= new Point(-30, 2);
            Btn.BackColor = Color.FromArgb(136, 6, 56);
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            pnlClos(BtnHome);
            BtnHome.BackColor = Color.FromArgb(19, 164, 150);
            BtnHome.Location = new Point(0, 2);

        }
        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            pnlClos(BtnCustomers);
            pnlOpen(PnlCustomers, BtnCustomers);
        }
        //Here it was an error for "pnlClos"
         private void pnlClos(Button btnCustomers)
        {
            throw new NotImplementedException();
        }

        private void BtnCompanies_Click(object sender, EventArgs e)
        {
            pnlClos(BtnCompanies);
            pnlOpen(PnlCustomers, BtnCompanies);
        }
    }
}
