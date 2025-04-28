using System;
using System.Windows.Forms;

namespace Meditation
{
    public partial class Form1 : Form
    {
        private Timer breathingTimer;
        private int countDown;
        private bool isInhalePhase;

        public Form1()
        {
            InitializeComponent();

            breathingTimer = new Timer { Interval = 1000 };
            breathingTimer.Tick += BreathingTimer_Tick;
            countDown = 4;
            isInhalePhase = true;

            breathingTimer.Start();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            breathingTimer.Start(); 
        }

        private void BreathingTimer_Tick(object sender, EventArgs e)
        {
            if (countDown > 0)
            {
                inhaleExhaleLabel.Text = isInhalePhase ? "Вдохните..." : "Выдохните...";
                inhaleExhaleLabel.Refresh();   
                countDown--;
            }
            else
            {
                isInhalePhase = !isInhalePhase;
                countDown = 4;
            }
        }

        private void listBoxStressSigns_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = listBoxStressSigns.SelectedItem.ToString();
            switch (selected)
            {
                case "Бессонница":
                    MessageBox.Show("Рекомендуем максимально расслабиться и выбрать звук АСМР.");
                    break;
                case "Мышечное напряжение":
                    MessageBox.Show("Рекомендуем расслабить тело под звуки моря.");
                    break;
                case "Повышенная тревожность":
                    MessageBox.Show("Рекомендуем восстановить спокойствие под атмосферный звук поля.");
                    break;
                case "Рассеянность":
                    MessageBox.Show("Рекомендуем сосредоточиться под шелест природы.");
                    break;
            }
        }

        private void buttonSea_Click(object sender, EventArgs e)
        {
            mediaPlayer.URL = @"D:\aves_sea_gull.mp3";
            mediaPlayer.Ctlcontrols.play();
        }

        private void buttonNature_Click(object sender, EventArgs e)
        {
            mediaPlayer.URL = @"D:\leaves_autumn_leaves_rustling_02.mp3";
            mediaPlayer.Ctlcontrols.play();
        }

        private void buttonField_Click(object sender, EventArgs e)
        {
            mediaPlayer.URL = @"D:\135472_1050391-lq.mp3";
            mediaPlayer.Ctlcontrols.play();
        }

        private void buttonASMR_Click(object sender, EventArgs e)
        {
            mediaPlayer.URL = @"D:\asmr-whats.mp3";
            mediaPlayer.Ctlcontrols.play();
        }
    }
}
