using System;
using System.Drawing;
using System.Windows.Forms;

namespace pbinfoApp.Panels
{
    public class TitleBar : Panel
    {
        private Label lblTitle;

        public String Title
        {
            get => this.lblTitle.Text;
            set => this.lblTitle.Text = value;
        }

        public TitleBar(Control control)
        {
            this.Parent = control;

            this.Location = new Point(0, 0);
            this.Size = new Size(control.Width, 80);
            this.Dock = DockStyle.Top;
            this.BackColor = Color.FromArgb(0, 150, 136);

            lblTitle = new Label
            {
                AutoSize = false,
                Size = this.Size,
                TextAlign = ContentAlignment.MiddleCenter,
                Anchor = AnchorStyles.None,
                Font = new Font("Lucida Sans Unicode", 15.75f, FontStyle.Regular),
                ForeColor = Color.White,
                Location = new Point(0, 0),
                TabIndex = 0,
                Text = "HOME"
            };

            this.Controls.Add(lblTitle);

        }
    }
}