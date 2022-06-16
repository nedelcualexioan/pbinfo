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
        private Panel containerVariants;
        public ViewProblems(Form par)
        {
            this.Parent = par;
            this.Location = new Point(220, 0);
            this.BackColor = Color.White;
            this.Size = new Size(par.Width - 220, par.Height);
            this.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            Initialize();

            directories = new List<String>();

            directories.AddRange(Directory.GetDirectories(Application.StartupPath + @"\Variante"));

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

        private void Populate()
        {
            int y = 10;

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

                y += 20;

            }
            
        }
    }
}