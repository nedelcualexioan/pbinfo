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

        public FrmHome()
        {
            InitializeComponent();

            this.Size = new Size(1092, 620);
            this.Text = "PbInfo";

            foreach (Control c in this.Controls)
            {
                c.Hide();
            }

            pnlMenu = new Menu(this);
            pnlHome = new ViewHome(this);

            pnlMenu.Show();
            pnlHome.Show();
            

        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }
    }
}
