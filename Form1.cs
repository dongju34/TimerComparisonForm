using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TimerComparisonForm
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer wfTimer;
        private System.Timers.Timer timersTimer;
        private System.Threading.Timer threadingTimer;

        private int wfCount = 0;
        private int timersCount = 0;
        private int threadingCount = 0;

        private bool isBlocked = false;

        public Form1()
        {
            InitializeComponent();
            InitTimers();
        }

        private void InitTimers()
        {
            // WinForms.Timer (UI 스레드 기반)
            wfTimer = new System.Windows.Forms.Timer();
            wfTimer.Interval = 100;
            wfTimer.Tick += (s, e) =>
            {
                wfCount++;
                lblWF.Text = $"WinForms.Timer: {wfCount}";
            };
            wfTimer.Start();

            // System.Timers.Timer (백그라운드)
            timersTimer = new System.Timers.Timer(100);
            timersTimer.Elapsed += (s, e) =>
            {
                this.Invoke((Action)(() =>
                {
                    timersCount++;
                    lblTimers.Text = $"System.Timers.Timer: {timersCount}";
                }));
            };
            timersTimer.Start();

            // System.Threading.Timer (스레드풀)
            threadingTimer = new System.Threading.Timer(_ =>
            {
                this.Invoke((Action)(() =>
                {
                    threadingCount++;
                    lblThreading.Text = $"System.Threading.Timer: {threadingCount}";
                }));
            }, null, 0, 100);
        }

        private void btnBlockUI_Click(object sender, EventArgs e)
        {
            if (isBlocked) return;
            isBlocked = true;
            wfCount = timersCount = threadingCount = 0;
            lblWF.Text = lblTimers.Text = lblThreading.Text = "Starting...";

            // UI 스레드 5초간 블로킹
            StopwatchBlock(5000);

            isBlocked = false;
        }

        private void StopwatchBlock(int milliseconds)
        {
            var sw = System.Diagnostics.Stopwatch.StartNew();
            while (sw.ElapsedMilliseconds < milliseconds)
            {
                // 의도적 블로킹
                //Application.DoEvents(); // 넣으면 UI 응답 유지, 빼면 완전 멈춤
            }
            sw.Stop();
        }
    }
}
