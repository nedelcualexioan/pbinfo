using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbinfoApp.Mockupuri
{
    public partial class BasicMockup : Form
    {
        private ListBox lbxProblems;
        public BasicMockup()
        {
            InitializeComponent();

            lbxProblems = new ListBox
            {
                Parent = this,
                Anchor = AnchorStyles.None,
                BorderStyle = BorderStyle.None,
                Dock = DockStyle.Fill,
                Font = new Font("Lucida Sans Unicode", 14.25F, FontStyle.Regular),
                Location = new Point(0, 80),
                Size = new Size(856, 501),
                ForeColor = SystemColors.WindowText,
                ItemHeight = 16
            };

            lbxProblems.Items.Add("item1");
            lbxProblems.Items.Add("item2");
            lbxProblems.Items.Add("item3");
        }

        private void BasicMockup_Load(object sender, EventArgs e)
        {

        }
    }
}
