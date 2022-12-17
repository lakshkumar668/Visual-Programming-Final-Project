using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP__Semester_Project
{
    public partial class Form1 : Form
    {
        int Speed = 3;
        int gravity = 3;
        int score = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeButtom.Left -= Speed;
            pipeTop.Left -= Speed;
            pipeButtom1.Left -= Speed;
            pipeTop1.Left -= Speed;
            pipeButtom2.Left -= Speed;
            pipeTop2.Left -= Speed;
            scoreText.Text = "Score : " + score;

            if (pipeButtom.Left < -28 || pipeTop.Left < -28 )
            {
                addPipe();
            }
           else if (pipeButtom1.Left < -28 || pipeTop1.Left < -28)
            {
                addPipe1();
            }
            else if (pipeButtom2.Left < -28 || pipeTop2.Left < -28)
            {
                addPipe2();
            }

            if (flappyBird.Bounds.IntersectsWith(pipeButtom.Bounds) || flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) || flappyBird.Bounds.IntersectsWith(pipeGround.Bounds) || flappyBird.Top < -25)
            {
                Draw();
            }

            if (flappyBird.Bounds.IntersectsWith(pipeButtom1.Bounds) || flappyBird.Bounds.IntersectsWith(pipeTop1.Bounds) || flappyBird.Bounds.IntersectsWith(pipeGround.Bounds) || flappyBird.Top < -25)
            {
                Draw();
            }
            if (flappyBird.Bounds.IntersectsWith(pipeButtom2.Bounds) || flappyBird.Bounds.IntersectsWith(pipeTop2.Bounds) || flappyBird.Bounds.IntersectsWith(pipeGround.Bounds) || flappyBird.Top < -25)
            {
                Draw();
            }
            
        }

        private void keyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }
        public void Draw()
        {
            gametimer.Stop();
            MessageBox.Show("GameOver" +"\n" + "\n" + "your Socre is : "+ score);
        }
        public void addPipe()
        {
            pipeButtom.Left = 750;
            pipeTop.Left = 750;
            score++;
        }
        public void addPipe1()
        {
            pipeButtom1.Left = 750;
            pipeTop1.Left = 750;
            score++;
        }
        public void addPipe2()
        {
            pipeButtom2.Left = 750;
            pipeTop2.Left = 750;
            score++;
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.ShowDialog();

        }

        
    }
}
