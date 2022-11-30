using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class txtScore : Form
    {
        //skapar en lista av circle som kallas snake
        private List<Circle> Snake = new List<Circle>();
        //skapar en instans av klassen circle
        private Circle food = new Circle();

        int maxWith;
        int maxHeight;

        int score;
        int highScore;

        bool left, right, up, down;

        Random rand = new Random();


        public txtScore()
        {
            InitializeComponent();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {

        }

        private void StartGame(object sender, EventArgs e)
        {

        }

        private void GameTimerEvent(object sender, EventArgs e)
        {

        }

        private void UpdateMapGraphics(object sender, PaintEventArgs e)
        {

        }

        private void RestartGame()
        {

        }

        private void Eat()
        {

        }
        private void GameOver()
        {

        }
    }
}
