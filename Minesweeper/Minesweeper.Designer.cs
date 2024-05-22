namespace Minesweeper
{
    partial class Minesweeper
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
            components = new System.ComponentModel.Container();
            resetBombs = new Button();
            flipAll = new Button();
            winGame = new Button();
            nonMineTiles = new Label();
            timer = new System.Windows.Forms.Timer(components);
            gameTime = new Label();
            formSize = new Label();
            changeSettings = new Button();
            bombsRemaining = new Label();
            help = new Button();
            SuspendLayout();
            // 
            // resetBombs
            // 
            resetBombs.Anchor = AnchorStyles.Top;
            resetBombs.BackColor = SystemColors.AppWorkspace;
            resetBombs.FlatAppearance.BorderColor = Color.DimGray;
            resetBombs.FlatAppearance.BorderSize = 4;
            resetBombs.FlatStyle = FlatStyle.Popup;
            resetBombs.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            resetBombs.ForeColor = Color.Black;
            resetBombs.Location = new Point(412, 46);
            resetBombs.Name = "resetBombs";
            resetBombs.Size = new Size(61, 52);
            resetBombs.TabIndex = 0;
            resetBombs.Text = "😎";
            resetBombs.UseVisualStyleBackColor = false;
            resetBombs.Click += resetBombs_Click;
            // 
            // flipAll
            // 
            flipAll.Location = new Point(12, 712);
            flipAll.Name = "flipAll";
            flipAll.Size = new Size(131, 40);
            flipAll.TabIndex = 2;
            flipAll.Text = "Flip All";
            flipAll.UseVisualStyleBackColor = true;
            flipAll.Click += flipAll_Click;
            // 
            // winGame
            // 
            winGame.Location = new Point(12, 663);
            winGame.Name = "winGame";
            winGame.Size = new Size(131, 40);
            winGame.TabIndex = 3;
            winGame.Text = "Win Game";
            winGame.UseVisualStyleBackColor = true;
            winGame.Click += winGame_Click;
            // 
            // nonMineTiles
            // 
            nonMineTiles.Anchor = AnchorStyles.Bottom;
            nonMineTiles.AutoSize = true;
            nonMineTiles.Cursor = Cursors.Hand;
            nonMineTiles.Location = new Point(404, 673);
            nonMineTiles.Name = "nonMineTiles";
            nonMineTiles.Size = new Size(68, 30);
            nonMineTiles.TabIndex = 4;
            nonMineTiles.Text = "label1";
            nonMineTiles.TextAlign = ContentAlignment.TopCenter;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // gameTime
            // 
            gameTime.BackColor = SystemColors.ActiveCaptionText;
            gameTime.BorderStyle = BorderStyle.Fixed3D;
            gameTime.Font = new Font("ROG Fonts", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gameTime.ForeColor = Color.Red;
            gameTime.Location = new Point(12, 46);
            gameTime.Name = "gameTime";
            gameTime.Size = new Size(119, 52);
            gameTime.TabIndex = 5;
            gameTime.Text = "000";
            gameTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formSize
            // 
            formSize.Anchor = AnchorStyles.Bottom;
            formSize.AutoSize = true;
            formSize.Location = new Point(397, 13);
            formSize.Name = "formSize";
            formSize.Size = new Size(68, 30);
            formSize.TabIndex = 6;
            formSize.Text = "label1";
            // 
            // changeSettings
            // 
            changeSettings.BackColor = SystemColors.AppWorkspace;
            changeSettings.FlatAppearance.BorderSize = 0;
            changeSettings.FlatStyle = FlatStyle.Flat;
            changeSettings.Location = new Point(3, 3);
            changeSettings.Name = "changeSettings";
            changeSettings.Size = new Size(81, 40);
            changeSettings.TabIndex = 7;
            changeSettings.Text = "Game";
            changeSettings.UseVisualStyleBackColor = false;
            changeSettings.Click += changeSettings_Click;
            // 
            // bombsRemaining
            // 
            bombsRemaining.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bombsRemaining.BackColor = SystemColors.ActiveCaptionText;
            bombsRemaining.BorderStyle = BorderStyle.Fixed3D;
            bombsRemaining.Font = new Font("ROG Fonts", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bombsRemaining.ForeColor = Color.Red;
            bombsRemaining.Location = new Point(753, 46);
            bombsRemaining.Name = "bombsRemaining";
            bombsRemaining.Size = new Size(119, 52);
            bombsRemaining.TabIndex = 8;
            bombsRemaining.Text = "032";
            bombsRemaining.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // help
            // 
            help.BackColor = SystemColors.AppWorkspace;
            help.FlatAppearance.BorderSize = 0;
            help.FlatStyle = FlatStyle.Flat;
            help.Location = new Point(90, 3);
            help.Name = "help";
            help.Size = new Size(81, 40);
            help.TabIndex = 9;
            help.Text = "Help";
            help.UseVisualStyleBackColor = false;
            help.Click += help_Click;
            // 
            // Minesweeper
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(884, 764);
            Controls.Add(help);
            Controls.Add(bombsRemaining);
            Controls.Add(changeSettings);
            Controls.Add(formSize);
            Controls.Add(gameTime);
            Controls.Add(nonMineTiles);
            Controls.Add(winGame);
            Controls.Add(flipAll);
            Controls.Add(resetBombs);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Minesweeper";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Minesweeper";
            Load += Minesweeper_Load;
            Resize += Minesweeper_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button resetBombs;
        private Button flipAll;
        private Button winGame;
        private Label nonMineTiles;
        private System.Windows.Forms.Timer timer;
        private Label gameTime;
        private Label formSize;
        private Button changeSettings;
        private Label bombsRemaining;
        private Button help;
    }
}