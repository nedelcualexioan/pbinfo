using System.Drawing;
using System.Windows.Forms;

namespace pbinfoApp.Panels
{
    public class ViewHome : Panel
    {
        private Panel pnlTitleBar;
        private Label lblTItle;

        private PictureBox pctLogo;
        private Label lblJoke;

        public ViewHome(Form par)
        {
            this.Parent = par;
            this.Location = new Point(220, 0);
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.White;

            Initialize(par as FrmHome);

        }

        private void Initialize(FrmHome home)
        {
            pnlTitleBar = new Panel
            {
                Parent = this,
                Location = new Point(0,0),
                Size = new Size(this.Width, 80),
                Dock = DockStyle.Top,
                BackColor = Color.FromArgb(0, 150, 136)
            };

            lblTItle = new Label
            {
                AutoSize = true,
                Anchor = AnchorStyles.None,
                Font = new Font("Lucida Sans Unicode", 15.75f, FontStyle.Regular),
                ForeColor = Color.White,
                Location = new Point(610, 27),
                TabIndex = 0,
                 Text = "HOME",
                TextAlign = ContentAlignment.MiddleCenter
            };
            pnlTitleBar.Controls.Add(lblTItle);

            pctLogo = new PictureBox
            {
                Parent = this,
                Anchor = AnchorStyles.None,
                Size = new Size(461, 83),
                SizeMode = PictureBoxSizeMode.Zoom,
                ImageLocation = Application.StartupPath + @"\Images\pbinfo5.png",
                Location = new Point(400,181)
            };

            lblJoke = new Label
            {
                Parent = this,
                Anchor = AnchorStyles.None,
                AutoSize = true,
                Font = new Font("Lucida Sans Unicode", 15.75f, FontStyle.Regular),
                Location = new Point(pctLogo.Left - 62, 295),
                 Text= "De ce confundă programatorii Halloween-ul cu Crăciunul?\nPentru că Oct 31 = Dec 25",
                 TextAlign = ContentAlignment.MiddleCenter
            };
        }
    }
}