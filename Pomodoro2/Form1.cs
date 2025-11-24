using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PomodoroGUI
{
    public partial class Form1 : Form
    {
        private PomodoroTimer pomodoro;

        public Form1()
        {
            InitializeComponent();
            pomodoro = new PomodoroTimer();

            pomodoro.OnTick += UpdateUI;
            pomodoro.OnFinished += TimerFinished;

            comboMode.Items.Add("Focus (25 min)");
            comboMode.Items.Add("Break (5 min)");
            comboMode.SelectedIndex = 0;

            circularProgress.Minimum = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int minutes = comboMode.SelectedIndex == 0 ? 25 : 5;
            pomodoro.Start(minutes);

            circularProgress.Maximum = pomodoro.TotalSeconds;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            pomodoro.Stop();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            pomodoro.Reset();
        }

        private void UpdateUI()
        {
            int min = pomodoro.RemainingSeconds / 60;
            int sec = pomodoro.RemainingSeconds % 60;

            labelTime.Text = $"{min:D2}:{sec:D2}";
            circularProgress.MaxValue = pomodoro.TotalSeconds;
            circularProgress.Value = pomodoro.TotalSeconds - pomodoro.RemainingSeconds;
            circularProgress.Invalidate();
        }

        private void TimerFinished()
        {
            Console.Beep(1000, 300);
            MessageBox.Show("Session finished!");
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(250, 250, 255),
                Color.FromArgb(220, 230, 255),
                90F);

            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= 0x00020000; // CS_DROPSHADOW
                return cp;
            }
        }
    }
}
