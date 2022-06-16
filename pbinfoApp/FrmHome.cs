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
        }

        private void btnClick(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button.Text.Contains("Home"))
            {
                pnlProblems.Hide();
                pnlHome.Show(); 
            }
            else
            {
                pnlHome.Hide();
                pnlProblems.Show();
            }
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }
    }
}
