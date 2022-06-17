using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pbinfoApp.Panels;
using Menu = pbinfoApp.Panels.Menu;

namespace pbinfoApp
{
    public partial class FrmHome : Form
    {

        private Menu pnlMenu;
        private ViewHome pnlHome;
        private ViewProblems pnlProblems;
        private ViewProblem pnlProblem;
        public FrmHome()
        {
            InitializeComponent();

            this.Size = new Size(1092, 620);
            this.Text = "PbInfo";

            pnlMenu = new Menu(this);
            pnlHome = new ViewHome(this);
            pnlProblems = new ViewProblems(this);

            foreach (Control c in this.Controls)
            {
                c.Hide();
            }
            
            pnlMenu.Show();
            pnlHome.Show();

            pnlMenu.menuClick += btnClick;
            pnlProblems.problemClick += lblProblem_Click;
        }

        private void btnClick(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button.Text.Contains("Home"))
            {
                if (pnlHome.Visible)
                    return;
                
                if (pnlProblems.Visible)
                {
                    pnlProblems.Hide();
                    pnlHome.Show();
                }
                else if (pnlProblem != null && pnlProblem.Visible)
                {
                    pnlProblem.Hide();
                    pnlHome.Show();
                }
            }
            else
            {

                if (pnlProblem != null && pnlProblem.Visible)
                {
                    pnlProblem.Hide();
                    pnlProblems.Populate();
                    pnlProblems.Show();
                }
                else
                {
                    pnlHome.Hide();
                    pnlProblems.Populate();
                    pnlProblems.Show();
                }
            }
        }

        private void lblProblem_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;

            pnlProblem = new ViewProblem(this, lbl.Text + " / " + pnlProblems.Variant,
                Application.StartupPath + @"\Variante\" + pnlProblems.Variant + "\\" +
                lbl.Text.Replace("=> Exercitiul ", ""));
            
            pnlProblems.Hide();
            pnlProblem.Show();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }
    }
}
