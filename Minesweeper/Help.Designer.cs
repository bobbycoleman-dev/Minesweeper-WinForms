namespace Minesweeper
{
    partial class Help
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
            listBox1 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            listBox2 = new ListBox();
            label4 = new Label();
            listBox3 = new ListBox();
            ok = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("ROG Fonts", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(364, 26);
            label1.Name = "label1";
            label1.Size = new Size(258, 34);
            label1.TabIndex = 0;
            label1.Text = "How to Play";
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.AppWorkspace;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 30;
            listBox1.Items.AddRange(new object[] { "💣Reveal all non-mine tiles", "💣Either flag or leave all mine tiles unturned" });
            listBox1.Location = new Point(84, 129);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(446, 60);
            listBox1.TabIndex = 1;
            listBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(55, 96);
            label2.Name = "label2";
            label2.Size = new Size(132, 30);
            label2.TabIndex = 2;
            label2.Text = "How to Win";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(55, 217);
            label3.Name = "label3";
            label3.Size = new Size(66, 30);
            label3.TabIndex = 3;
            label3.Text = "Rules";
            // 
            // listBox2
            // 
            listBox2.BackColor = SystemColors.AppWorkspace;
            listBox2.BorderStyle = BorderStyle.None;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 30;
            listBox2.Items.AddRange(new object[] { "💣First click is always safe; reveals either a number or a blank tile", "💣Single click to reveal tile", "💣Right-click to flag a tile; right-click a flag to un-flag", "💣Flagging reduces mine count but does not indicate a mine; mine count can be negative", "💣Revealing a blank tile will reveal all adjacent blank tiles and touching number tiles", "💣Revealing a mine loses the game" });
            listBox2.Location = new Point(84, 250);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(844, 210);
            listBox2.TabIndex = 4;
            listBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(55, 463);
            label4.Name = "label4";
            label4.Size = new Size(223, 30);
            label4.TabIndex = 5;
            label4.Text = "What Numbers Mean";
            // 
            // listBox3
            // 
            listBox3.BackColor = SystemColors.AppWorkspace;
            listBox3.BorderStyle = BorderStyle.None;
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 30;
            listBox3.Items.AddRange(new object[] { "💣Tiles that have numbers will be 1 - 8", "💣The number indicates the amiunt of mines adjacent to that tile; a tile has 8 surrounding tiles ", "💣A 1 means only 1 mine occupies a surrounding tile to the revealed tile, etc." });
            listBox3.Location = new Point(84, 496);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(902, 90);
            listBox3.TabIndex = 6;
            listBox3.TabStop = false;
            // 
            // ok
            // 
            ok.Location = new Point(844, 607);
            ok.Name = "ok";
            ok.Size = new Size(131, 40);
            ok.TabIndex = 7;
            ok.Text = "I Got This";
            ok.UseVisualStyleBackColor = true;
            // 
            // Help
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            CancelButton = ok;
            ClientSize = new Size(987, 659);
            Controls.Add(ok);
            Controls.Add(listBox3);
            Controls.Add(label4);
            Controls.Add(listBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Help";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Help";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Label label2;
        private Label label3;
        private ListBox listBox2;
        private Label label4;
        private ListBox listBox3;
        private Button ok;
    }
}