using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public class Tile : Label
    {
        public string? TileName { get; set; }

        public int TileX { get; set; }

        public int TileY { get; set; }

        public int MinesNear { get; set; } = 0;

        public bool IsMine { get; set; } = false;

        public bool IsFlag { get; set; } = false;

        public bool IsRevealed { get; set; } = false;

        public void SetTileProps()
        {
            TileName = Name;
            Size = new Size(35, 35);
            AutoSize = false;
            Margin = new Padding(0);
            Padding = new Padding(0);
            Location = new Point(TileX * 35 + 10, TileY * 35 + 105);
            BackColor = Color.LightGray;
            ForeColor = Color.LightGray;
            Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            TextAlign = ContentAlignment.TopCenter;
            Cursor = Cursors.Hand;
            SendToBack();
            BorderStyle = BorderStyle.Fixed3D;
            FlatStyle = FlatStyle.Popup;
            TextAlign = ContentAlignment.MiddleCenter;
        }

        public void ResetTile()
        {
            Text = null;
            BackColor = Color.LightGray;
            ForeColor = Color.LightGray;
            BorderStyle = BorderStyle.Fixed3D;
            FlatStyle = FlatStyle.Popup;
            IsFlag = false;
            IsMine = false;
            MinesNear = 0;
            IsRevealed = false;
        }

        public void SetTileAsMine()
        {
            IsMine = true;
            Text = "💣";
            Font = new Font("Segeo UI",10F);
        }

        public void SetTileAsNumber(int minesNear)
        {
            MinesNear = minesNear;
            if (minesNear > 0)
                Text = minesNear.ToString();
        }

        public void RevealTile()
        {
            if (IsFlag)
                return;

            if (IsMine)
            {
                BackColor = Color.LightCoral;
                ForeColor = Color.Black;
            }
            else
            {
                BackColor = Color.White;
                BorderStyle = BorderStyle.FixedSingle;
                FlatStyle = FlatStyle.Flat;
                ForeColor = MinesNear switch
                {
                    0 => Color.White,
                    1 => Color.Blue,
                    2 => Color.Green,
                    3 => Color.Red,
                    4 => Color.DarkBlue,
                    5 => Color.DarkRed,
                    6 => Color.Cyan,
                    _ => Color.Black,
                };
            }

            IsRevealed = true;
            Cursor = Cursors.Default;
            Click += null;
        }

        public void FlagTile()
        {
            IsFlag = !IsFlag;

            if (IsFlag)
            {
                Text = "🚩";
                ForeColor = Color.Red;

            }
            else
            {
                ForeColor = Color.LightGray;
                Text = MinesNear.ToString();
            }
        }
    }


}
