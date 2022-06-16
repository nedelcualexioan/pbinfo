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
            this.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.BackColor = Color.White;

            this.Size = new Size(par.Width - 220, par.Height);

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
                Top = 181
            };

            pctLogo.Left = (pctLogo.Parent.Width - pctLogo.Width) / 2;

            lblJoke = new Label
            {
                Parent = this,
                Anchor = AnchorStyles.None,
                Location = new Point(0, pctLogo.Top + 100),
                AutoSize = false,
                Size = new Size(this.Width, 50),
                Font = new Font("Lucida Sans Unicode", 15.75f, FontStyle.Regular),
                Text= "De ce confundă programatorii Halloween-ul cu Crăciunul?\nPentru că Oct 31 = Dec 25",
                TextAlign = ContentAlignment.MiddleCenter
            };
        }
    }
}