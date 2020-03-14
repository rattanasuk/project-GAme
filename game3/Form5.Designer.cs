namespace game3
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.endText1 = new System.Windows.Forms.Label();
            this.scoreText = new System.Windows.Forms.Label();
            this.endText2 = new System.Windows.Forms.Label();
            this.gameDesigner = new System.Windows.Forms.Label();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.FlappyBird = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 15;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // endText1
            // 
            this.endText1.AutoSize = true;
            this.endText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endText1.Location = new System.Drawing.Point(1, 21);
            this.endText1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endText1.Name = "endText1";
            this.endText1.Size = new System.Drawing.Size(181, 69);
            this.endText1.TabIndex = 6;
            this.endText1.Text = "score";
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Yellow;
            this.scoreText.Font = new System.Drawing.Font("Algerian", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(145, 315);
            this.scoreText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(315, 54);
            this.scoreText.TabIndex = 5;
            this.scoreText.Text = "Game Over!";
            // 
            // endText2
            // 
            this.endText2.AutoSize = true;
            this.endText2.BackColor = System.Drawing.Color.Yellow;
            this.endText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endText2.Location = new System.Drawing.Point(135, 394);
            this.endText2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endText2.Name = "endText2";
            this.endText2.Size = new System.Drawing.Size(335, 39);
            this.endText2.TabIndex = 7;
            this.endText2.Text = "Your final score is : ";
            // 
            // gameDesigner
            // 
            this.gameDesigner.AutoSize = true;
            this.gameDesigner.BackColor = System.Drawing.Color.Yellow;
            this.gameDesigner.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameDesigner.Location = new System.Drawing.Point(136, 464);
            this.gameDesigner.Name = "gameDesigner";
            this.gameDesigner.Size = new System.Drawing.Size(360, 31);
            this.gameDesigner.TabIndex = 8;
            this.gameDesigner.Text = "Game Designed By your name here:";
            // 
            // ground
            // 
            this.ground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ground.BackgroundImage")));
            this.ground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ground.Image = global::game3.Properties.Resources.ground2;
            this.ground.Location = new System.Drawing.Point(3, 649);
            this.ground.Margin = new System.Windows.Forms.Padding(4);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(644, 98);
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pipeBottom.BackgroundImage")));
            this.pipeBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipeBottom.Location = new System.Drawing.Point(547, 394);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(100, 262);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 2;
            this.pipeBottom.TabStop = false;
            this.pipeBottom.Click += new System.EventHandler(this.pipeBottom_Click);
            // 
            // pipeTop
            // 
            this.pipeTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pipeTop.BackgroundImage")));
            this.pipeTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipeTop.Image = global::game3.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(385, -5);
            this.pipeTop.Margin = new System.Windows.Forms.Padding(4);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(111, 222);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 1;
            this.pipeTop.TabStop = false;
            this.pipeTop.Click += new System.EventHandler(this.pipeTop_Click);
            // 
            // FlappyBird
            // 
            this.FlappyBird.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FlappyBird.BackgroundImage")));
            this.FlappyBird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FlappyBird.Location = new System.Drawing.Point(13, 338);
            this.FlappyBird.Margin = new System.Windows.Forms.Padding(4);
            this.FlappyBird.Name = "FlappyBird";
            this.FlappyBird.Size = new System.Drawing.Size(75, 58);
            this.FlappyBird.TabIndex = 0;
            this.FlappyBird.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(647, 740);
            this.Controls.Add(this.gameDesigner);
            this.Controls.Add(this.endText2);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.endText1);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.FlappyBird);
            this.Name = "Form5";
            this.Text = "FlappyBird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FlappyBird;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label endText1;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Label endText2;
        private System.Windows.Forms.Label gameDesigner;
    }
}