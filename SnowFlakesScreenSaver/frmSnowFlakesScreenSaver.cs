using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SnowFlakesScreenSaver
{
    public partial class SnowFlakesScreenSaver : Form
    {
        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        static extern IntPtr GetWindowLongPtr(IntPtr hWnd, int nIndex);

        Random rnd = new Random();
        const int W = 1920;
        const int H = 1080;
        const int snowFlakeSize = 5;

        public SnowFlakesScreenSaver()
        {
            InitializeComponent();
            BackColor = Color.Blue;
            TransparencyKey = Color.Blue;
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            Size = new Size(300, 300);
            Location = new Point(810, 390);

            btnLetItSnow.Visible = false;
            btnLetItSnow.Enabled = false;
            btnLetItSnow.BackColor = Color.DarkGray;
            btnLetItSnow.ForeColor = Color.Black;
            btnLetItSnow.Size = new Size(300, 300);
            btnLetItSnow.Location = new Point(0, 0);
            btnLetItSnow.Cursor = Cursors.Hand;
            btnLetItSnow.Enabled = true;
            btnLetItSnow.Visible = true;
        }

        private void btnLetItSnow_Click(object sender, EventArgs e)
        {
            Controls.Remove(btnLetItSnow);

            Size = new Size(W, H);
            Location = new Point((1920 - W) / 2, (1080 - H) / 2);

            int initialStyle = (int)GetWindowLongPtr(this.Handle, -20);
            SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20);

            Timer tmr = new Timer();
            tmr.Interval = 50;

            tmr.Tick += (s, evArgs) =>
            {
                bool snowFlakeToRemove = false;
                int snowFlakeIndex=0;
                foreach (Panel snowFlake in Controls)
                {
                    snowFlake.Location = new Point(snowFlake.Location.X, snowFlake.Location.Y + snowFlakeSize);
                    if (snowFlake.Location.Y > H)
                    {
                        snowFlakeIndex = Controls.IndexOf(snowFlake);
                        snowFlakeToRemove = true;
                    }
                }
                if (snowFlakeToRemove)
                {
                    Controls.RemoveAt(snowFlakeIndex);
                }

                int x = rnd.Next(W - 1);
                Panel newSnowFlake = new Panel()
                {
                    BackColor = Color.White,
                    Size = new Size(snowFlakeSize, snowFlakeSize),
                    BorderStyle = BorderStyle.None,
                    Location = new Point(x, 0)
                };
                Controls.Add(newSnowFlake);
                newSnowFlake.BringToFront();
            };

            tmr.Start();
        }
    }
}
