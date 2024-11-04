using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Ryzen_Shipments
{
    public partial class Form1 : Form
    {
        private Timer animationTimer;
        private int targetHeight;
        private Panel targetPanel;

        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            animationTimer = new Timer();
            animationTimer.Interval = 15; // Adjust for animation speed
            animationTimer.Tick += AnimationTimer_Tick;
        }

        private void pnlOpen(Panel Pnl, Button Btn)
        {
            targetPanel = Pnl;
            targetHeight = ((Pnl.Controls.OfType<Button>().Count() - 1) * 30) + 45;

            Btn.BackColor = Color.FromArgb(19, 164, 150);
            animationTimer.Start();
        }

        private void pnlClos(Button Btn)
        {
            foreach (var pnl in PnlMenu.Controls.OfType<Panel>())
            {
                if (pnl != targetPanel)
                {
                    pnl.Height = 45; // Reset others
                    foreach (var button in pnl.Controls.OfType<Button>())
                    {
                        button.Left = -30;
                        button.BackColor = Color.FromArgb(136, 6, 56);
                    }
                }
            }

            Btn.BackColor = Color.FromArgb(136, 6, 56);
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (targetPanel.Height < targetHeight)
            {
                targetPanel.Height += 5; // Adjust speed
                if (targetPanel.Height >= targetHeight)
                {
                    targetPanel.Height = targetHeight; // Snap to target
                    animationTimer.Stop();
                }
            }
            else
            {
                targetPanel.Height -= 5; // Collapse
                if (targetPanel.Height <= 45)
                {
                    targetPanel.Height = 45;
                    animationTimer.Stop();
                }
            }
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            pnlClos(BtnHome);
            BtnHome.Location = new Point(0, 2);
            BtnHome.BackColor = Color.FromArgb(19, 164, 150);
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            pnlClos(BtnCustomers);
            pnlOpen(PnlCustomers, BtnCustomers);
        }

        /*private void BtnCompanies_Click(object sender, EventArgs e)
        {
            pnlClos(BtnCompanies);
            pnlOpen(PnlCompanies, BtnCompanies);
        }*/
    }
}
