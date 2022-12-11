namespace Snake
{
    partial class txtScore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.restartButton = new System.Windows.Forms.ToolStripMenuItem();
            this.exitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.StartButton = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.txtscoore = new System.Windows.Forms.Label();
            this.txtHighScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(878, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuButton
            // 
            this.menuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartButton,
            this.exitButton});
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(73, 32);
            this.menuButton.Text = "Menu";
            // 
            // restartButton
            // 
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(168, 34);
            this.restartButton.Text = "Restart";
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(168, 34);
            this.exitButton.Text = "Exit";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(718, 65);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(126, 71);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartGame);
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picCanvas.Location = new System.Drawing.Point(45, 65);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(650, 500);
            this.picCanvas.TabIndex = 3;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdateMapGraphics);
            // 
            // txtscoore
            // 
            this.txtscoore.AutoSize = true;
            this.txtscoore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscoore.Location = new System.Drawing.Point(714, 165);
            this.txtscoore.Name = "txtscoore";
            this.txtscoore.Size = new System.Drawing.Size(102, 29);
            this.txtscoore.TabIndex = 4;
            this.txtscoore.Text = "Score: 0";
            // 
            // txtHighScore
            // 
            this.txtHighScore.AutoSize = true;
            this.txtHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHighScore.Location = new System.Drawing.Point(714, 218);
            this.txtHighScore.Name = "txtHighScore";
            this.txtHighScore.Size = new System.Drawing.Size(154, 29);
            this.txtHighScore.TabIndex = 5;
            this.txtHighScore.Text = "High score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 120;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // txtScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 645);
            this.Controls.Add(this.txtHighScore);
            this.Controls.Add(this.txtscoore);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "txtScore";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuButton;
        private System.Windows.Forms.ToolStripMenuItem restartButton;
        private System.Windows.Forms.ToolStripMenuItem exitButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label txtscoore;
        private System.Windows.Forms.Label txtHighScore;
        private System.Windows.Forms.Timer gameTimer;
    }
}

