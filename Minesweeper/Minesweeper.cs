using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Minesweeper : Form
    {
        #region Properties
        static private int BOMBS = 32;
        static private int ROWS = 16;
        static private int COLS = 16;
        static private int NON_BOMB_TILES = (ROWS * COLS) - BOMBS;

        private readonly List<Tile> bombsList = [];
        private readonly List<Tile> tileList = [];
        private readonly List<List<Tile>> board = [];

        private int bombsCount = BOMBS;
        private int nonBombTilesCount = NON_BOMB_TILES;
        private int timeCount = 0;
        private bool isFirstClick = true;
        #endregion

        #region Constructor & Game Setup
        public Minesweeper()
        {
            InitializeComponent();
        }

        private void Minesweeper_Load(object sender, EventArgs e)
        {
            SetGameMode();
            BuildBoard();

            nonMineTiles.Visible = false;
            winGame.Visible = false;
            flipAll.Visible = false;
            formSize.Visible = false;
        }

        private void SetGameMode()
        {
            GameSettings settings = new();
            settings.ShowDialog();

            BOMBS = settings.Mines;
            ROWS = settings.Rows;
            COLS = settings.Columns;
            NON_BOMB_TILES = settings.NonMineTiles;

            Size = ROWS switch
            {
                9 => new Size(368, 510),
                16 => new Size(612, 745),
                30 => new Size(1102, 745),
                _ => new Size(612, 745)
            };

        }
        #endregion

        #region Board Creation
        private void BuildBoard()
        {
            ClearBoard();

            for (int row = 0; row < ROWS; row++)
            {
                List<Tile> tempList = new();
                for (int col = 0; col < COLS; col++)
                {
                    Tile tile = new();
                    tile.Name = $"tile{row}{col}";
                    tile.TileX = row;
                    tile.TileY = col;
                    tile.Click += RevealTile;
                    tile.SetTileProps();

                    tileList.Add(tile);
                    tempList.Add(tile);
                    Controls.Add(tile);
                }

                board.Add(tempList);
            }

            bombsRemaining.Text = bombsCount.ToString("000");
            gameTime.Text = timeCount.ToString("000");
            nonMineTiles.Text = $"Tiles Remaining: {nonBombTilesCount}";
        }

        private void BuildBombLayer(Tile tile)
        {
            SetBombs(tile);
            SetNumbers();
        }

        private void ClearBoard()
        {
            foreach (Label l in tileList)
                Controls.Remove(l);

            bombsCount = BOMBS;
            nonBombTilesCount = NON_BOMB_TILES;
            timeCount = 0;
            bombsList.Clear();
            tileList.Clear();
            board.Clear();
            isFirstClick = true;
        }

        private void SetBombs(Tile tile)
        {
            int bombs = 0;
            Random rand = new();
            List<int> bombLocation = [];
            int firstTile = tileList.IndexOf(tile);

            while (bombs < BOMBS)
            {
                int randNum = rand.Next(ROWS * COLS);

                if (bombLocation.Contains(randNum) || randNum == firstTile)
                    continue;

                bombLocation.Add(randNum);
                bombs++;
            }

            foreach (int i in bombLocation)
            {
                tileList[i].SetTileAsMine();
                bombsList.Add(tileList[i]);
            }

            bombsCount = bombs;
        }

        private void SetNumbers()
        {
            List<int> finalBoard = [];

            for (int row = 0; row < board.Count; row++)
            {
                for (int col = 0; col < board[row].Count; col++)
                {
                    Tile tile = board[row][col];

                    if (tile.IsMine)
                    {
                        finalBoard.Add(-1);
                        continue;
                    }

                    finalBoard.Add(CountBombs(row, col));
                }
            }

            for (int i = 0; i < finalBoard.Count; i++)
            {
                if (finalBoard[i] >= 0)
                    tileList[i].SetTileAsNumber(finalBoard[i]);
            }
        }

        private int CountBombs(int x, int y)
        {
            int bombs = 0;
            int rows = board.Count;
            int cols = board[0].Count;

            int[] dx = [-1, -1, -1, 0, 0, 1, 1, 1];
            int[] dy = [-1, 0, 1, -1, 1, -1, 0, 1];

            for (int i = 0; i < 8; i++)
            {
                int newRow = x + dx[i];
                int newCol = y + dy[i];

                if (newRow >= 0 && newRow < rows && newCol >= 0 && newCol < cols)
                {
                    if (board[newRow][newCol].IsMine)
                    {
                        bombs++;
                    }
                }
            }

            return bombs;
        }
        #endregion

        #region Game Logic
        private void RevealTile(object? sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Tile tile = (Tile)sender!;

            if (isFirstClick)
            {
                BuildBombLayer(tile);
                timer.Enabled = true;
                timer.Start();
                isFirstClick = false;

                if (tile.MinesNear == 0)
                {
                    RevealBlanks(tile.TileX, tile.TileY);
                    return;
                }

                tile.RevealTile();
                DecreaseTileCount();
                return;
            }

            if (tile.IsRevealed)
                return;

            if (me.Button == MouseButtons.Right)
            {
                if (tile.IsFlag)
                    bombsCount++;
                else
                    bombsCount--;

                bombsRemaining.Text = bombsCount.ToString("000");

                tile.FlagTile();
                return;
            }

            if (tile.IsFlag)
                return;

            if (tile.MinesNear == 0 && !tile.IsMine)
            {
                RevealBlanks(tile.TileX, tile.TileY);
                return;
            }

            tile.RevealTile();

            DecreaseTileCount();

            if (tile.IsMine)
                EndGame(false);

            if (nonBombTilesCount == 0)
                EndGame(true);
        }

        private void RevealBlanks(int row, int col)
        {
            if (row < 0 || col < 0 || row >= board.Count || col >= board[row].Count || board[row][col].IsRevealed)
                return;

            if (board[row][col].MinesNear != 0 || board[row][col].IsMine || board[row][col].IsFlag)
                return;

            board[row][col].RevealTile();
            DecreaseTileCount();

            int[] dx = [-1, -1, -1, 0, 0, 1, 1, 1];
            int[] dy = [-1, 0, 1, -1, 1, -1, 0, 1];

            for (int i = 0; i < 8; i++)
            {
                int newRow = row + dx[i];
                int newCol = col + dy[i];

                if (newRow >= 0 && newRow < board.Count && newCol >= 0 && newCol < board[newRow].Count)
                {
                    Tile neighbor = board[newRow][newCol];
                    if (neighbor.MinesNear > 0 && !neighbor.IsRevealed && !neighbor.IsMine && !neighbor.IsFlag)
                    {
                        neighbor.RevealTile();
                        DecreaseTileCount();
                    }
                }
            }

            for (int i = 0; i < 8; i++)
            {
                int newRow = row + dx[i];
                int newCol = col + dy[i];
                RevealBlanks(newRow, newCol);
            }
        }

        private void EndGame(bool win)
        {
            timer.Stop();
            string msg = string.Empty;

            if (win)
            {
                msg = "Winner! You defused all the mines!";
            }
            else
            {
                foreach (Tile t in bombsList)
                {
                    if (t.IsFlag && t.IsMine)
                    {
                        t.Text = "💣";
                    }
                    t.RevealTile();
                    msg = "Game Over!";
                }
            }

            MessageBox.Show(msg, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            BuildBoard();
        }
        #endregion

        #region Event Handlers
        private void DecreaseTileCount()
        {
            nonBombTilesCount--;
            nonMineTiles.Text = $"Tiles Remaining: {nonBombTilesCount}";
        }

        private void resetBombs_Click(object sender, EventArgs e)
        {
            BuildBoard();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeCount++;
            //TimeSpan t = TimeSpan.FromSeconds(timeCount);
            gameTime.Text = timeCount.ToString("000");
        }

        private void changeSettings_Click(object sender, EventArgs e)
        {
            SetGameMode();
            BuildBoard();
        }

        private void help_Click(object sender, EventArgs e)
        {
            Help help = new();

            if (timeCount > 0)
                timer.Stop();

            help.ShowDialog();

            if (timeCount > 0)
                timer.Start();
        }
        #endregion

        #region Dev Tools
        private void winGame_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < board.Count; i++)
            {
                for (int j = 0; j < board[i].Count; j++)
                {
                    if (board[i][j].IsMine || board[i][j].IsRevealed)
                        continue;

                    board[i][j].RevealTile();
                    DecreaseTileCount();
                }
            }

            if (nonBombTilesCount <= 0)
                EndGame(true);
        }

        private void flipAll_Click(object sender, EventArgs e)
        {
            foreach (Tile t in tileList)
            {
                t.RevealTile();
            }
        }

        private void Minesweeper_Resize(object sender, EventArgs e)
        {
            formSize.Text = $"W:{Size.Width}, H:{Size.Height}";
        }


        #endregion
    }
}
