using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Random R = new Random();

        int[,] A;         // main array
        int[,] A_new;     // next array
        int[,] A_last;      // for draw()y

        int f_size;         // field size

        bool start = false; // is model loop started

        const int Z = 8;    // neighbours

        int ptSize = 0;  // data point

        int t; // step;


        void A_fill_random()
        {
            for (int x = 0; x < f_size; x++)
            {
                for (int y = 0; y < f_size; y++)
                {
                    A[x, y] = Clamp(Convert.ToInt32(R.Next(-2, 2)), 0, 1);  // 0, 0 or 1
                }
            }
        }

        void A_fill_void()
        {
            for (int x = 0; x < f_size; x++)
            {
                for (int y = 0; y < f_size; y++)
                {
                    A[x, y] = 0;
                }
            }
        }


        void Draw()
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

            for (int x = 0; x < f_size; x++)
            {
                for (int y = 0; y < f_size; y++)
                {
                    chart1.Series[A[x, y]].Points.AddXY(x + 1, y + 1); // 1...f_size
                }
            }
            if (!checkNotEmpty())
            { buttStart.Enabled = false; start = false; buttStop_Click(this, EventArgs.Empty); }
        }

        private void buttBuild_Click(object sender, EventArgs e)
        {
            t = 0;
            start = false;
            try
            {
                f_size = Clamp(Convert.ToInt32(tbSize.Text), 10, 100);
                tbSize.Text = f_size.ToString();
            }
            catch (FormatException) { }

            A = new int[f_size, f_size];
            A_new = new int[f_size, f_size];

            A_fill_void();

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = f_size + 1;
            chart1.ChartAreas[0].AxisY.Maximum = f_size + 1;

            if (checkNotEmpty()) buttStart.Enabled = true; else buttStart.Enabled = false;

            if (Convert.ToInt32(tbSize.Text) < 40)
                cbUseTimer.Checked = true;
            else cbUseTimer.Checked = false;

            ChartScale();
            Draw();
        }

        private bool checkNotEmpty()
        {
            for (int x = 0; x < f_size; x++)
            {
                for (int y = 0; y < f_size; y++)
                {
                    if (A[x, y] == 1) return true;
                }
            }
            return false;
        }



        private void timerMain_Tick(object sender, EventArgs e) // one-time tick
        {
            if (start)
            {
                Process();
                t++;
                Draw();
            }
            else
                timerMain.Enabled = false;
        }




        ////////////////////////  now backend  ///////////////////////



        double rnd()
        {
            return R.NextDouble();
        }


        int BC(int index, int N)
        {
            int bc = index;
            if (index < 0) bc = index + N;
            if (index > N - 1) bc = index - N;

            return bc;
        }


        int nbrCount(int x, int y)
        {
            int n = 0;
            for (int a = x - 1; a <= x + 1; a++)
            {
                for (int b = y - 1; b <= y + 1; b++)
                {
                    if (a != x || b != y)
                        if (A[BC(a, f_size), BC(b, f_size)] == 1) n++;
                }
            }
            return n;
        }



        void Process()
        {
            for (int x = 0; x < f_size; x++)
            {
                for (int y = 0; y < f_size; y++)
                {
                    if (nbrCount(x, y) < 2) A_new[x, y] = 0;
                    if (nbrCount(x, y) == 2) A_new[x, y] = A[x, y];
                    if (nbrCount(x, y) == 3) A_new[x, y] = 1;
                    if (nbrCount(x, y) > 3) A_new[x, y] = 0;
                }
            }
            A = (int[,])A_new.Clone();
        }



        private void buttStop_Click(object sender, EventArgs e)
        {
            start = false;
            buttStart.Visible = true;
            if (checkNotEmpty()) buttStart.Enabled = true; else buttStart.Enabled = false;
            buttStop.Visible = false;
            buttBuild.Enabled = true;
            button1.Enabled = true;
        }



        private void buttStart_Click(object sender, EventArgs e)
        {
            start = true;

            buttBuild.Enabled = false;
            button1.Enabled = false;

            buttStart.Visible = false;
            buttStop.Visible = true;

            try
            {
                timerMain.Interval = Clamp(Convert.ToInt32(tbTimerMS.Text.Replace(",", "").Replace(".", "")), 40, 5000);
                tbTimerMS.Text = timerMain.Interval.ToString();
            }
            catch (FormatException) { }

            if (cbUseTimer.Checked) timerMain.Enabled = true;
            else
                while (start)
                {
                    Process();
                    Draw();
                    t++;
                    Application.DoEvents();
                }
        }



        int Clamp(int a, int min, int max)
        {
            return Math.Min(Math.Max(a, min), max);
        }

        void ChartScale()
        {
            chart1.Width = chart1.Height;
            int w = chart1.Width + chart1.Location.X + 16;
            this.Width = w;

            ptSize = (int)((chart1.Height / (f_size + 1.9)) * .97);

            chart1.Series[0].MarkerSize = ptSize;
            chart1.Series[1].MarkerSize = ptSize;
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            ChartScale();
        }


        private void chart1_MouseDown(object sender, MouseEventArgs e)
        {
            if (cbMouseDraw.Checked)
            {
                try
                {
                    var chartArea = chart1.ChartAreas[0];
                    int x = Clamp((int)(chartArea.AxisX.PixelPositionToValue(e.X) + 0.5), 1, f_size);
                    int y = Clamp((int)(chartArea.AxisY.PixelPositionToValue(e.Y) + 0.5), 1, f_size);

                    x--; y--;
                    if (A[x, y] == 0) A[x, y] = 1; else A[x, y] = 0;
                    Draw();
                }
                catch (Exception) { }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;

            try
            {
                timerMain.Interval = Clamp(Convert.ToInt32(tbTimerMS.Text.Replace(",", "").Replace(".", "")), 50, 5000);
            }
            catch (FormatException) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t = 0;
            start = false;

            try
            {
                f_size = Clamp(Convert.ToInt32(tbSize.Text), 10, 100);
                tbSize.Text = f_size.ToString();
            }
            catch (FormatException) { }

            A = new int[f_size, f_size];
            A_new = new int[f_size, f_size];

            A_fill_random();

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = f_size + 1;
            chart1.ChartAreas[0].AxisY.Maximum = f_size + 1;


            if (Convert.ToInt32(tbSize.Text) < 40)
                cbUseTimer.Checked = true;
            else cbUseTimer.Checked = false;

            ChartScale();
            Draw();
            buttStart.Enabled = true;
        }

        private void chart1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!start)
            {
                if (checkNotEmpty()) buttStart.Enabled = true; else buttStart.Enabled = false;
            }
        }
    }
}
