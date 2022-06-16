using System.Drawing;
using System.Windows.Forms;

namespace pbinfoApp.Panels
{
    public class ViewHome : Panel
    {
        private TitleBar pnlTitleBar;

        private PictureBox pctLogo;
        private Label lblJoke;

        public ViewHome(Form par)
        {
            this.Parent = par;
            this.Location = new Point(220, 0);
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.White;

            Initialize();
        }

        private void Initialize()
        {
            pnlTitleBar = new TitleBar(this);

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