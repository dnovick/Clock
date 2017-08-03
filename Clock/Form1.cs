using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    //Added a comment by Baruch

    public partial class Form1 : Form
    {

        Timer _timer;

        //These are the borderless dimensions.
        int _initWidth;
        int _initHeight;


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            _timer = new Timer();
            _timer.Interval = 10;
            _timer.Tick += _timer_Tick;
            _timer.Start();

            //There appears to be a bug in the VS 2017 designer (might be in older versions too).
            //Even though the designer has been set for RightToLeft.No, the menu still displays right to left.
            //Therefore we explicitly set it on load.
            //ctxMenu.RightToLeft = RightToLeft.No;
            _initWidth = this.Width;
            _initHeight = this.Height;

         

        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            int hours = DateTime.Now.TimeOfDay.Hours;
            if (hours > 12)
            {

                hours -= 12;
            }

            int minutes = DateTime.Now.TimeOfDay.Minutes;
            int seconds = DateTime.Now.TimeOfDay.Seconds;

            int ms = DateTime.Now.TimeOfDay.Milliseconds;

            string strTime = String.Format("{0}:{1}:{2}:{3}", hours.ToString().PadLeft(2, '0'), minutes.ToString().PadLeft(2, '0'), seconds.ToString().PadLeft(2, '0'), ms.ToString().PadLeft(3, '0'));

            lblTime.Text = strTime;



        }


        private void miTransparent_Click(object sender, EventArgs e)
        {
            //miTransparent.Checked = !miTransparent.Checked;



            if (miTransparent.Checked)
            {
                this.Opacity = .30;
            }
            else
            {
                this.Opacity = 1.0;
            }

        }

        protected void centerToScreen()
        {
            Screen screen = Screen.FromControl(this);

            Rectangle workingArea = screen.WorkingArea;
            this.Location = new Point()
            {
                X = Math.Max(workingArea.X, workingArea.X + (workingArea.Width - this.Width) / 2),
                Y = Math.Max(workingArea.Y, workingArea.Y + (workingArea.Height - this.Height) / 2)
            };
        }

        private void resizeClock(bool full)
        {
            Screen s = Screen.FromControl(this);

            if (full)
            {
                this.Width = 2500;
                this.Height = 400;
                              

                lblTime.Font = new Font(lblTime.Font.FontFamily, 250);

               
            }
            else
            {
                this.Width = _initWidth;
                this.Height = _initHeight;


                lblTime.Font = new Font(lblTime.Font.FontFamily, 28);

            }

            centerToScreen();
        }

        private void miFullSize_Click(object sender, EventArgs e)
        {

            //miFullSize.Checked = !miFullSize.Checked;

            resizeClock(miFullSize.Checked);



        }


        private void miMove_Click(object sender, EventArgs e)
        {
            if (miMove.Checked)
            {
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;

            }
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void miHide_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
          
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;

            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }
    }
}