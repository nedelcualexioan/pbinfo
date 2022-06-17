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
        private Panel containerVariants;
        private Label lblBack;

        private String variant;
        
        public String Variant
        {
            get => variant.Replace("=> ", "");
        }
        public event EventHandler problemClick;
        
        public ViewProblems(Form par)
        {
            this.Parent = par;
            this.Location = new Point(220, 0);
            this.BackColor = Color.White;
            this.Size = new Size(par.Width - 220, par.Height);
            this.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            Initialize();

            Populate();
        }
        private void Initialize()
        {
            pnlTitleBar = new TitleBar(this)
            {
                Title = "Variante BAC"
            };

            containerVariants = new Panel
            {
                Parent = this,
                Location = new Point(0, pnlTitleBar.Height),
                Size = new Size(this.Width, this.Height - pnlTitleBar.Height),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top
            };
        }

        public void Populate()
        {
            containerVariants.Controls.Clear();

            int y = 10;

            String[] directories = Directory.GetDirectories(Application.StartupPath + @"\Variante");

            foreach (String path in directories)
            {

                Label lblVariant = new Label();

                DirectoryInfo info = new DirectoryInfo(path);

                lblVariant = new Label
                {
                    Parent = containerVariants,
                    Anchor = AnchorStyles.Top | AnchorStyles.Left,
                    AutoSize = true,
                    Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular),
                    Location = new Point(15, y),
                    Text = "=> " + info.Name,
                    Cursor = Cursors.Hand
                };

                lblVariant.Click += new EventHandler(lblVariant_Click);

                y += 20;

            }
            
        }

        private void PopulateProblems(String path)
        {
            String[] list = Directory.GetDirectories(path);

            int y = 40;

            Label lblBack = new Label
            {
                Parent = containerVariants,
                Anchor = AnchorStyles.Top | AnchorStyles.Left,
                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold),
                Location = new Point(6, 7),
                Text = "<= Back",
                Cursor = Cursors.Hand
            };

            lblBack.Click += new EventHandler(lblBack_Click);

            foreach (String dir in list)
            {
                
                Label lblProblem = new Label();

                DirectoryInfo info = new DirectoryInfo(dir);

                lblProblem = new Label
                {
                    Parent = containerVariants,
                    Anchor = AnchorStyles.Top | AnchorStyles.Left,
                    AutoSize = true,
                    Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular),
                    Location = new Point(15, y),
                    Text = "=> Exercitiul " + info.Name,
                    Cursor = Cursors.Hand
                };

                lblProblem.Click += new EventHandler(lblProblem_Click);

                y += 20;

            }
        }

        private void lblVariant_Click(object sender, EventArgs e)
        {
            Label str = sender as Label;

            containerVariants.Controls.Clear();

            PopulateProblems(Application.StartupPath + @"\Variante\" + str.Text.Replace("=> ", ""));

            variant = str.Text;
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            Populate();
        }

        private void lblProblem_Click(object sender, EventArgs e)
        {
            if (problemClick != null)
            {
                problemClick(sender, null);
            }
        }
    }
}