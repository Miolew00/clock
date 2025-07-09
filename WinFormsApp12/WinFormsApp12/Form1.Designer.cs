namespace WinFormsApp9
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelSetAlarm;
        private System.Windows.Forms.TextBox textBoxAlarm;
        private System.Windows.Forms.Button buttonSetAlarm;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer flashTimer; // допълнителен таймер за мигане

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelTime = new Label();
            labelSetAlarm = new Label();
            textBoxAlarm = new TextBox();
            buttonSetAlarm = new Button();
            timer = new System.Windows.Forms.Timer(components);
            flashTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
           
            labelTime.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            labelTime.Location = new Point(23, 15);
            labelTime.Margin = new Padding(2, 0, 2, 0);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(264, 52);
            labelTime.TabIndex = 0;
            labelTime.Text = "00:00:00";
            labelTime.TextAlign = ContentAlignment.MiddleCenter;
           
            labelSetAlarm.AutoSize = true;
            labelSetAlarm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSetAlarm.Location = new Point(11, 83);
            labelSetAlarm.Margin = new Padding(2, 0, 2, 0);
            labelSetAlarm.Name = "labelSetAlarm";
            labelSetAlarm.Size = new Size(128, 21);
            labelSetAlarm.TabIndex = 1;
            labelSetAlarm.Text = "Задай аларма :";
            
            textBoxAlarm.Font = new Font("Segoe UI", 12F);
            textBoxAlarm.Location = new Point(156, 80);
            textBoxAlarm.Margin = new Padding(2, 2, 2, 2);
            textBoxAlarm.Name = "textBoxAlarm";
            textBoxAlarm.Size = new Size(110, 29);
            textBoxAlarm.TabIndex = 2;
          
            buttonSetAlarm.BackColor = Color.MediumSeaGreen;
            buttonSetAlarm.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonSetAlarm.ForeColor = Color.White;
            buttonSetAlarm.Location = new Point(101, 120);
            buttonSetAlarm.Margin = new Padding(2, 2, 2, 2);
            buttonSetAlarm.Name = "buttonSetAlarm";
            buttonSetAlarm.Size = new Size(109, 30);
            buttonSetAlarm.TabIndex = 3;
            buttonSetAlarm.Text = "Задай аларма";
            buttonSetAlarm.UseVisualStyleBackColor = false;
            buttonSetAlarm.Click += buttonSetAlarm_Click;
           
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
             
            flashTimer.Interval = 500;
            flashTimer.Tick += flashTimer_Tick;
          
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(311, 188);
            Controls.Add(labelTime);
            Controls.Add(labelSetAlarm);
            Controls.Add(textBoxAlarm);
            Controls.Add(buttonSetAlarm);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Часовник с аларма";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
