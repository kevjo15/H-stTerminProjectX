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

        int maxWidth;
        int maxHeight;

        int score;
        int highScore;

        bool left, right, up, down;

        Random rand = new Random();



        public txtScore()
        {
            InitializeComponent();
            new Settings();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
                //om key left är nertryckt och direction inte är höger, så svänger den vänster
                if (e.KeyCode == Keys.Left && Settings.directions != "right") left = true;
                if (e.KeyCode == Keys.Left && Settings.directions != "right") left = true;
                if (e.KeyCode == Keys.Right && Settings.directions != "left") right = true;
                if (e.KeyCode == Keys.Up && Settings.directions != "down") up = true;
                if (e.KeyCode == Keys.Down && Settings.directions != "upp") down = true;
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
                //samma sak fast tvärom, om left key is up är left key också false
                if (e.KeyCode == Keys.Left) left = false;
                if (e.KeyCode == Keys.Left) left = false;
                if (e.KeyCode == Keys.Right) right = false;
                if (e.KeyCode == Keys.Up) up = false;
                if (e.KeyCode == Keys.Down) down = false;
        }

        private void StartGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {

        }

        private void UpdateMapGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            Brush snakeColour;

            //går igenom snake litsan
            for (int i = 0; i < Snake.Count; i++)
            {
                //första indexen i snake listan är huvudet och den blir då svart
                if (i == 0)
                {
                    snakeColour = Brushes.Black;
                }
                else
                {
                    snakeColour = Brushes.Purple; // resten av kroppen blir lila
                }
                canvas.FillEllipse(snakeColour, new Rectangle(Snake[i].x * Settings.width, Snake[i].y * Settings.height, Settings.width, Settings.height));
            }
        }

        private void RestartGame()
        {
            //defalt values vi vill ha när spelet börjar
            maxWidth = picCanvas.Width / Settings.width -1; // -1 är padding för ormen så den inte kommer för nära väggarna
            maxHeight = picCanvas.Height / Settings.height -1;
            //rensar a child objekt om de finns från snake list
            Snake.Clear();
            //om starbutton är Enable när spelet startar går de inte att använda up, ner, höger, vänster pilarna
            StartButton.Enabled = false;
            score = 0;
            txtscoore.Text = "Score: " + score;

            //skapar head av instansen circle och ger han en startposition
            Circle head = new Circle { x = 10, y = 5 };
            Snake.Add(head); //lägger till head i listan snake

            for (int i = 0; i < 10; i++)
            {
                //skapar objekt body av instansen circle
                Circle body = new Circle();
                Snake.Add(body); //lägger till body till listan snake
            }
            //skapar ny object food av instansen circle, och ger den en random spanpoint.
            food = new Circle { x = rand.Next(2, maxWidth), y = rand.Next(2, maxHeight) }; //  2an här är padding från väggen
            
            gameTimer.Start(); // Startar speltimer

        }

        private void Eat()
        {

        }
        private void GameOver()
        {

        }
    }
}
