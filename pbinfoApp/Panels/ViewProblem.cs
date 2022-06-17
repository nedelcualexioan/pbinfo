using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace pbinfoApp.Panels
{
    public class ViewProblem : Panel
    {
        private Label lblTitle;

        private Label lblProblem;
        private Label lblSolution;

        private Panel pnlProblem;
        private Panel pnlSolution;

        private TextBox txtProblem;
        private TextBox txtSolution;

        public ViewProblem(Control par, String title, String path)
        {
            this.Parent = par;
            this.Location = new Point(220, 0);
            this.BackColor = Color.White;
            this.Size = new Size(par.Width - 220, par.Height);
            this.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            Initialize(title, path);
        }

        private void Initialize(String title, String path)
        {
            lblTitle = new Label
            {
                Parent = this,
                AutoSize = true,
                Font = new Font("Lucida Sans Unicode", 14.25f, FontStyle.Regular),
                Location = new Point(6, 6),
                Text = title
            };

            pnlProblem = new Panel
            {
                Parent = this,
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top,
                AutoScroll = true,
                Location = new Point(14, 77),
                Size = new Size(830, 184),
                BackColor = Color.White
            };

            pnlSolution = new Panel
            {
                Parent = this,
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top,
                AutoScroll = true,
                Location = new Point(14, 290),
                Size = new Size(834, 276),
                BackColor = Color.Blue
            };

            lblProblem = new Label
            {
                Parent = this,
                AutoSize = true,
                Font = new Font("Lucida Sans Unicode", 14.25f, FontStyle.Regular),
                Location = new Point(14, 51),
                Text = "Cerinta:"
            };

            txtProblem = new TextBox
            {
                Parent = pnlProblem,
                Multiline = true,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                Font = new Font("Lucida Sans Unicode", 11.25f, FontStyle.Regular),
                Location = new Point(0, 0),
                BorderStyle = BorderStyle.None,
                Enabled = false,
                Size = new Size(pnlProblem.Width, 300),
                Text = File.ReadAllText(path + @"\cerinta.txt"),
                BackColor = Color.White
            };

            lblSolution = new Label
            {
                Parent = this,
                Anchor = AnchorStyles.Left | AnchorStyles.Top,
                AutoSize = true,
                Font = new Font("Lucida Sans Unicode", 14.25f, FontStyle.Regular),
                Location = new Point(14, 264),
                Text = "Rezolvare:"
            };

            txtSolution = new TextBox
            {
                Parent = pnlSolution,
                Multiline = true,
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                Font = new Font("Lucida Sans Unicode", 11.25f, FontStyle.Regular),
                Location = new Point(0, 0),
                BorderStyle = BorderStyle.None,
                Enabled = false,
                Size = new Size(pnlSolution.Width, 700),
                Text = File.ReadAllText(path + @"\rezolvare.txt"),
                BackColor = Color.White
            };

        }
    }
}