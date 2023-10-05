using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRace
{
    public class Horse : Button
    {

        public static string hResult; //static result in horse

        private bool isFinished = false;
        private bool isStarted = false;
        private int interval = 100;
        private int displacement = 50;

        private Timer timer;
        //private PictureBox finishLine;

        public bool IsFinished
        {
            get => isFinished; 
            set
            {
                isFinished = value;
                if (IsFinished)
                {
                    timer.Enabled = false;
                }
            }
        }
        public bool IsStarted
        {
            get => isStarted; 
            set
            {
                isStarted = value;
                if (isStarted)
                {
                    timer.Enabled = true;
                }
            }
        }

        //public Horse(PictureBox finishLine, int interval, int displacement, ref string result)

        private GameForm owner;
        public Horse(GameForm owner, int interval, int displacement)
        {
            //this.finishLine = finishLine;
            this.owner = owner;
            this.interval = interval;
            this.displacement = displacement;
            timer = new Timer();
            timer.Interval = interval;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Left += displacement;
            if(this.Right >= owner.pbFinishLine.Left)
            {
                IsFinished = true; // we have two variables, if u use isFinished instead, timer won't stop
                //winning list will go here
                owner.result += this.Text + "\n";
                hResult += this.Text + "\n";
                GameForm.fResult += this.Text + "\n";
            }
        }
    }

}
