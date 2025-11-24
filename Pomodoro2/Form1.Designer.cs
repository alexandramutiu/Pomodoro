using System;
using System.Drawing;
using System.Windows.Forms;

namespace PomodoroGUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.comboMode = new System.Windows.Forms.ComboBox();
            this.circularProgress = new CircularProgressBar();
            this.SuspendLayout();

            // Form background (gradient)
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);

            // labelTitle
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = Color.FromArgb(40, 40, 40);
            this.labelTitle.Location = new System.Drawing.Point(0, 10);
            this.labelTitle.Size = new System.Drawing.Size(420, 50);
            this.labelTitle.Text = "Pomodoro Timer";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // circularProgress
            this.circularProgress.Location = new System.Drawing.Point(90, 70);
            this.circularProgress.Size = new System.Drawing.Size(240, 240);

            // labelTime
            this.labelTime.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.labelTime.ForeColor = Color.FromArgb(30, 30, 30);
            this.labelTime.BackColor = Color.Transparent;
            this.labelTime.Location = new System.Drawing.Point(0, 125);
            this.labelTime.Size = new System.Drawing.Size(420, 80);
            this.labelTime.Text = "25:00";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Mode dropdown
            this.comboMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMode.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.comboMode.Location = new System.Drawing.Point(140, 330);
            this.comboMode.Size = new System.Drawing.Size(150, 30);

            // Buttons (modern)
            SetupButton(this.btnStart, 50, 380, "Start", this.btnStart_Click);
            SetupButton(this.btnStop, 160, 380, "Stop", this.btnStop_Click);
            SetupButton(this.btnReset, 270, 380, "Reset", this.btnReset_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(420, 460);
            this.Controls.Add(this.circularProgress);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.comboMode);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnReset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; // rounded corners
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.ResumeLayout(false);
        }

        private void SetupButton(Button btn, int x, int y, string text, EventHandler click)
        {
            btn.Font = new System.Drawing.Font("Segoe UI", 11F, FontStyle.Bold);
            btn.BackColor = Color.FromArgb(56, 132, 255);
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Size = new System.Drawing.Size(100, 40);
            btn.Location = new System.Drawing.Point(x, y);
            btn.Text = text;
            btn.Click += click;
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox comboMode;
        private CircularProgressBar circularProgress;
    }
}
