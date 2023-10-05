using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRace
{
    public partial class GameForm : Form
    {
        public string result; //instance result in form
        public static string fResult; //static result in form
        public GameForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int numberOfHorses;
            int.TryParse(txtNumberOfHorses.Text, out numberOfHorses);
            int startX = 10;
            int startY = 60;

            Random r = new Random(123);
            const int MIN_SPEED = 5;
            const int MAX_SPEED = 10;
            const int MIN_INTERVAL = 200;
            const int MAX_INTERVAL = 500;
            const int HORSE_WIDTH = 30;
            const int HORSE_HEIGHT = 20;

            for (int i = 0; i < numberOfHorses; i++)
            {
                int interval = r.Next(MIN_INTERVAL,MAX_INTERVAL); // min is inclusive, max is exclusive
                int speed = r.Next(MIN_SPEED, MAX_SPEED);
                Horse h = new Horse(this, interval, speed);
                h.Left = startX;
                h.Top = startY;

                h.Width = HORSE_WIDTH;
                h.Height = HORSE_HEIGHT;
                this.Controls.Add(h);
                h.IsStarted = true;
                h.Text = i.ToString();
                startY += HORSE_WIDTH;

            }
        }

        private void btnNewRace_Click(object sender, EventArgs e)
        {
            GameForm f = new GameForm();
            f.Show();
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(result);
            //MessageBox.Show(Horse.hResult);
            MessageBox.Show(fResult);
        }
    }
}
