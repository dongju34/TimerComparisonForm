
namespace TimerComparisonForm
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblWF;
        private System.Windows.Forms.Label lblTimers;
        private System.Windows.Forms.Label lblThreading;
        private System.Windows.Forms.Button btnBlockUI;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblWF = new System.Windows.Forms.Label();
            this.lblTimers = new System.Windows.Forms.Label();
            this.lblThreading = new System.Windows.Forms.Label();
            this.btnBlockUI = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblWF
            this.lblWF.AutoSize = true;
            this.lblWF.Location = new System.Drawing.Point(12, 9);
            this.lblWF.Name = "lblWF";
            this.lblWF.Size = new System.Drawing.Size(111, 13);
            this.lblWF.TabIndex = 0;
            this.lblWF.Text = "WinForms.Timer: 0";

            // lblTimers
            this.lblTimers.AutoSize = true;
            this.lblTimers.Location = new System.Drawing.Point(12, 35);
            this.lblTimers.Name = "lblTimers";
            this.lblTimers.Size = new System.Drawing.Size(119, 13);
            this.lblTimers.TabIndex = 1;
            this.lblTimers.Text = "System.Timers.Timer: 0";

            // lblThreading
            this.lblThreading.AutoSize = true;
            this.lblThreading.Location = new System.Drawing.Point(12, 61);
            this.lblThreading.Name = "lblThreading";
            this.lblThreading.Size = new System.Drawing.Size(133, 13);
            this.lblThreading.TabIndex = 2;
            this.lblThreading.Text = "System.Threading.Timer: 0";

            // btnBlockUI
            this.btnBlockUI.Location = new System.Drawing.Point(12, 90);
            this.btnBlockUI.Name = "btnBlockUI";
            this.btnBlockUI.Size = new System.Drawing.Size(150, 30);
            this.btnBlockUI.TabIndex = 3;
            this.btnBlockUI.Text = "UI 5초 멈춤 시작";
            this.btnBlockUI.UseVisualStyleBackColor = true;
            this.btnBlockUI.Click += new System.EventHandler(this.btnBlockUI_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(284, 131);
            this.Controls.Add(this.btnBlockUI);
            this.Controls.Add(this.lblThreading);
            this.Controls.Add(this.lblTimers);
            this.Controls.Add(this.lblWF);
            this.Name = "Form1";
            this.Text = "Timer Comparison with UI Block";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

