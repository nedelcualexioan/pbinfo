using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace pbinfoApp.Panels
{
    public class ViewProblems : Panel
    {
        private TitleBar pnlTitleBar;
        private List<String> directories;
        private Panel containerVar;
        public ViewProblems(Form par)
        {
            this.Parent = par;
            this.Location = new Point(220, 0);
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.White;
            this.Size = new Size(856, 581);

            pnlTitleBar = new TitleBar(this);
            pnlTitleBar.Title = "Variante BAC 2009";
            pnlTitleBar.TitleLocation = new Point(540, 27);

            directories = new List<String>();

            directories.AddRange(Directory.GetDirectories(Application.StartupPath + @"\Variante"));

            containerVar = new Panel
            {
                Parent = this,
                Location = new Point(0, pnlTitleBar.Height),
                Size = new Size(this.Width, this.Height - pnlTitleBar.Height),
                Dock = DockStyle.Fill
            };

            Label lbl = new Label();

            lbl.Parent = containerVar;
            lbl.AutoSize = true;
            lbl.Location = new Point(15, 15);
            lbl.Text = "akndsapdos";
            lbl.BackColor=Color.Black;
            
            containerVar.Controls.Add(lbl);

            Populate();
        }

        private void Populate()
        {
            int y = 80;

            foreach (String s in directories)
            {

                Label lbl = new Label();

                lbl.Parent = containerVar;
                lbl.AutoSize = true;
                lbl.Location = new Point(15, 15);
                lbl.Text = "akndsapdos";

            }
        }
    }
}