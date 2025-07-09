using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp9
{
    public partial class Form1 : Form
    {
        private string alarmTime = "";
        private bool alarmTriggered = false;

        private bool isFlashing = false;
        private Color originalBackColor;
        private bool colorToggle = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
            originalBackColor = this.BackColor;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");

            if (!string.IsNullOrEmpty(alarmTime) && !alarmTriggered)
            {
                if (DateTime.Now.ToString("HH:mm") == alarmTime)
                {
                    alarmTriggered = true;
                    System.Media.SystemSounds.Beep.Play();

                 
                    flashTimer.Start();
                }
            }
        }

        private void flashTimer_Tick(object sender, EventArgs e)
        {
            if (colorToggle)
                this.BackColor = Color.Red;
            else
                this.BackColor = Color.Yellow;

            colorToggle = !colorToggle;
        }

        private void buttonSetAlarm_Click(object sender, EventArgs e)
        {
            string input = textBoxAlarm.Text.Trim();

            if (TimeSpan.TryParse(input, out _))
            {
                alarmTime = input;
                alarmTriggered = false;
                flashTimer.Stop(); 
                this.BackColor = originalBackColor;
                MessageBox.Show("Алармата е зададена за " + alarmTime, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Моля, въведи валиден час във формат час и минути ", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
