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
            if (e.KeyCode == Keys.Right && Settings.directions != "left") right = true;
            if (e.KeyCode == Keys.Up && Settings.directions != "down") up = true;
            if (e.KeyCode == Keys.Down && Settings.directions != "up") down = true;
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            //samma sak fast tvärtom, om left key is up är left key också false
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
            //Setting the directions
            if (left)
            {
                Settings.directions = "left";
            }
            if (right)
            {
                Settings.directions = "right";
            }
            if (up)
            {
                Settings.directions = "up";
            }
            if (down)
            {
                Settings.directions = "down";
            }
            //end of directions

            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.directions)
                    {
                        case "left": //när ormen rör sig åt vänster tar vi bort en cirkel i X led
                            Snake[i].x--;
                            break;
                        case "right": //när ormen rör sig åt höger lägger vi till en cirkel i X led
                            Snake[i].x++;
                            break;
                        case "up":
                            Snake[i].y--;
                            break;
                        case "down":
                            Snake[i].y++;
                            break;
                    }
                    if (Snake[i].x < 0)
                    {
                        Snake[i].x = maxWidth;
                    }
                    if (Snake[i].x > maxWidth)
                    {
                        Snake[i].x = 0;
                    }
                    if (Snake[i].y < 0)
                    {
                        Snake[i].y = maxHeight;
                    }
                    if (Snake[i].y > maxHeight)
                    {
                        Snake[i].y = 0;
                    }
                    //om snakes huvud har samma position som food kallar vi på eat metoden
                    if (Snake[i].x == food.x && Snake[i].y == food.y)
                    {
                        Eat();
                    }
                    //kollar om head kolliderar med någon cirkel i body
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        //om snake head har samma position som snake body i x och y led kallar vi på GameOver()
                        if (Snake[i].x == Snake[j].x && Snake[i].y == Snake[j].y)
                        {
                            GameOver();
                        }
                    }

                }
                //får varje cirkel i kroppen att följa varandra.
                else
                {
                    Snake[i].x = Snake[i - 1].x;
                    Snake[i].y = Snake[i - 1].y;
                }
            }
            picCanvas.Invalidate();
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
                //definera x och y, alltså bredden och höjden till snake
                canvas.FillEllipse(snakeColour, new Rectangle(Snake[i].x * Settings.width, Snake[i].y * Settings.height, Settings.width, Settings.height));
            }
            //definera x och y, alltså bredden och höjden till food
            canvas.FillEllipse(Brushes.Red, new Rectangle(food.x * Settings.width, food.y * Settings.height, Settings.width, Settings.height));
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //avslutar program
            Environment.Exit(1);
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void RestartGame()
        {
            //defalt values vi vill ha när spelet börjar
            maxWidth = picCanvas.Width / Settings.width - 1; // -1 är padding för ormen så den inte kommer för nära väggarna
            maxHeight = picCanvas.Height / Settings.height - 1;
            //rensar a child objekt om de finns från snake list
            Snake.Clear();
            //om starbutton är Enable när spelet startar går de inte att använda up, ner, höger, vänster pilarna
            StartButton.Enabled = false;
            score = 0;
            txtscoore.Text = "Score: " + score;

            //skapar head av instansen circle och ger han en startposition
            Circle head = new Circle { x = 10, y = 5 };
            Snake.Add(head); //lägger till head i listan snake

            for (int i = 0; i < 2; i++)
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
            score += 1;
            txtscoore.Text = "Score: " + score;
            Circle body = new Circle
            {
                x = Snake[Snake.Count - 1].x,
                y = Snake[Snake.Count - 1].y,
            };
            Snake.Add(body);
            //när du har ätit en circel så skapas en ny
            food = new Circle { x = rand.Next(2, maxWidth), y = rand.Next(2, maxHeight) };

            //varje food du äter ökar spelets hastighet
            gameTimer.Interval = gameTimer.Interval - 1;
        }
        private void GameOver()
        {
            gameTimer.Interval = 40;
            gameTimer.Stop(); //stannar speltimern när spelet är över
            StartButton.Enabled = true; //enable start knappen igen så man kan starta ett nytt spel efter man har förlorat

            if (score > highScore)
            {
                highScore = score;
                txtHighScore.Text = "High score: " + highScore;
                txtHighScore.ForeColor = Color.Red;
            }
        }
    }
}
