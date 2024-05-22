using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class GameSettings : Form
    {
        public GameSettings()
        {
            InitializeComponent();
        }

        private int _Rows;
        public int Rows
        {
            get { return _Rows; }
        }

        private int _Columns;
        public int Columns
        {
            get { return _Columns; }
        }

        private int _Mines;
        public int Mines
        {
            get { return _Mines; }
        }

        private int _NonMineTiles;
        public int NonMineTiles
        {
            get { return _NonMineTiles; }
        }

        private void play_Click(object sender, EventArgs e)
        {
            if (modeEasy.Checked)
            {
                _Rows = 9;
                _Columns = 9;
                _Mines = 10;
            }

            if (modeMedium.Checked)
            {
                _Rows = 16;
                _Columns = 16;
                _Mines = 32;
            }

            if (modeHard.Checked)
            {
                _Rows = 30;
                _Columns = 16;
                _Mines = 60;
            }

            _NonMineTiles = (_Rows * _Columns) - _Mines;

            Close();
        }
    }
}
