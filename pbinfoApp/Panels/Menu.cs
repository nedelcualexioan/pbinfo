using System;
using System.Drawing;
using System.Windows.Forms;

namespace pbinfoApp.Panels
{
    public class Menu : Panel
    {
        private Label lblTitle;
        private PictureBox pctLogo;

        private Panel pnlLogo;
        private Button btnHome;
        private Button btnProblems;

        public Menu(Form par)
        {
            this.Parent = par;
            this.Dock = DockStyle.Left;
            this.BackColor = Color.FromArgb(51, 51, 76);
            this.Width = 220;

            Initialize();

            btnHome.Click += new EventHandler(btnClick);
            btnProblems.Click += new EventHandler(btnClick);
        }

        private void Initialize()
        {
            btnProblems = new Button
            {
                Parent = this,
                Dock = DockStyle.Top,
                FlatAppearance = { BorderSize = 0 },
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular),
                ForeColor = Color.Gainsboro,
                Image = Image.FromFile(Application.StartupPath + @"\Images\monitor.png"),
                ImageAlign = ContentAlignment.MiddleLeft,
                Location = new Point(0, 140),
                Padding = new Padding(12, 0, 0, 0),
                Size = new Size(220, 60),
                Text = "   Variante 2009",
                TextImageRelation = TextImageRelation.ImageBeforeText
            };

            btnHome = new Button
            {
                Parent = this,
                Dock = DockStyle.Top,
                FlatAppearance = { BorderSize = 0 },
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular),
                ForeColor = Color.Gainsboro,
                Image = Image.FromFile(Application.StartupPath + @"\Images\coding.png"),
                ImageAlign = ContentAlignment.MiddleLeft,
                Location = new Point(0, 140),
                Padding = new Padding(12, 0, 0, 0),
                Size = new Size(220, 60),
                Text = "   Home",
                TextImageRelation = TextImageRelation.ImageBeforeText
            };

            pnlLogo = new Panel
            {
                Parent = this,
                Dock = DockStyle.Top,
                BackColor = Color.FromArgb(39, 39, 58),
                Height = 80
            };

            lblTitle = new Label
            {
                Parent = pnlLogo,
                Size = new Size(62, pnlLogo.Height),
                Location = new Point(106, 0),
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Text = "PbInfo"
            };

            pctLogo = new PictureBox
            {
                Parent = pnlLogo,
                ImageLocation = Application.StartupPath + @"\Images\logo.png",
                 SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(12, 0),
                Size = new Size(97, pnlLogo.Height)
            };
        }

        private void btnClick(object sender, EventArgs e)
        { 
            Button button = sender as Button;

            if (button.ForeColor == SystemColors.ActiveCaption)
                return;

            if (sender.Equals(btnHome))
            {
                EnableButton(btnHome);
                DisableButton(btnProblems);
            }
            else
            {
                EnableButton(btnProblems);
                DisableButton(btnHome); 
            }
        }

        private void EnableButton(Button btn)
        {
            btn.BackColor = Color.LightSlateGray;
            btn.Font = new Font("Microsoft Sans Serif", 12.5f, FontStyle.Regular);
        }

        private void DisableButton(Button btn)
        {
            btn.BackColor = Color.FromArgb(51, 51, 76);
            btn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular);
        }


    }
}