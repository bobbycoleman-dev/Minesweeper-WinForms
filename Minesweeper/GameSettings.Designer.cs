namespace Minesweeper
{
    partial class GameSettings
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
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            modeHard = new RadioButton();
            modeMedium = new RadioButton();
            modeEasy = new RadioButton();
            play = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(269, 27);
            label1.Name = "label1";
            label1.Size = new Size(262, 51);
            label1.TabIndex = 0;
            label1.Text = "Minesweeper";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(306, 105);
            label2.Name = "label2";
            label2.Size = new Size(188, 30);
            label2.TabIndex = 1;
            label2.Text = "Choose a Difficulty";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(modeHard);
            groupBox1.Controls.Add(modeMedium);
            groupBox1.Controls.Add(modeEasy);
            groupBox1.Location = new Point(83, 150);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(635, 131);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(475, 71);
            label5.Name = "label5";
            label5.Size = new Size(97, 30);
            label5.TabIndex = 5;
            label5.Text = "60 Mines";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(271, 71);
            label4.Name = "label4";
            label4.Size = new Size(97, 30);
            label4.TabIndex = 4;
            label4.Text = "32 Mines";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 71);
            label3.Name = "label3";
            label3.Size = new Size(97, 30);
            label3.TabIndex = 3;
            label3.Text = "10 Mines";
            // 
            // modeHard
            // 
            modeHard.AutoSize = true;
            modeHard.Location = new Point(441, 34);
            modeHard.Name = "modeHard";
            modeHard.Size = new Size(155, 34);
            modeHard.TabIndex = 2;
            modeHard.Text = "Hard (16x30)";
            modeHard.UseVisualStyleBackColor = true;
            // 
            // modeMedium
            // 
            modeMedium.AutoSize = true;
            modeMedium.Checked = true;
            modeMedium.Location = new Point(220, 34);
            modeMedium.Name = "modeMedium";
            modeMedium.Size = new Size(187, 34);
            modeMedium.TabIndex = 1;
            modeMedium.TabStop = true;
            modeMedium.Text = "Medium (16x16)";
            modeMedium.UseVisualStyleBackColor = true;
            // 
            // modeEasy
            // 
            modeEasy.AutoSize = true;
            modeEasy.Location = new Point(35, 34);
            modeEasy.Name = "modeEasy";
            modeEasy.Size = new Size(129, 34);
            modeEasy.TabIndex = 0;
            modeEasy.Text = "Easy (9x9)";
            modeEasy.UseVisualStyleBackColor = true;
            // 
            // play
            // 
            play.Location = new Point(335, 311);
            play.Name = "play";
            play.Size = new Size(131, 40);
            play.TabIndex = 3;
            play.Text = "Play";
            play.UseVisualStyleBackColor = true;
            play.Click += play_Click;
            // 
            // GameSettings
            // 
            AcceptButton = play;
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 383);
            Controls.Add(play);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "GameSettings";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Minesweeper";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Button play;
        private Label label4;
        private Label label3;
        private RadioButton modeHard;
        private RadioButton modeMedium;
        private RadioButton modeEasy;
        private Label label5;
    }
}