using ChessBoardModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessBoardGUI
{
    public partial class Form1 : Form
    {

        static Board myBoard = new Board(8);

        public Button[,] btnGrid = new Button[myBoard.size, myBoard.size];



        public Form1()
        {
            InitializeComponent();
            populateBoard();
        }

        public void populateBoard()
        {
            int btnSize = panel1.Width / myBoard.size;

            panel1.Height = panel1.Width;

            for (int i = 0; i < myBoard.size; i++)
            {
                for (int j = 0; j < myBoard.size; j++)
                {
                    btnGrid[i, j] = new Button();
                    btnGrid[i, j].Width = btnSize;
                    btnGrid[i, j].Height = btnSize;

                    btnGrid[i, j].Click += Grid_Button_Click;
                    panel1.Controls.Add(btnGrid[i,j]);

                    btnGrid[i, j].Location = new Point(i * btnSize, j * btnSize);

                    btnGrid[i, j].Text = i + "|" + j;
                    btnGrid[i, j].Tag = new Point(i, j);

                }
            }
        }

        private void Grid_Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button) sender;
            Point location = (Point)  clickedButton.Tag;

            int x = location.X;
            int y = location.Y;

            Cell current = myBoard.theGrid[x, y];

            myBoard.markNextLegalMoves(current, cmbbx_pieces.Text);

            for (int i = 0; i < myBoard.size; i++)
            {
                for (int j = 0; j < myBoard.size; j++)
                {

                    btnGrid[i, j].Text = "";
                    if (myBoard.theGrid[i,j].currentlyOccupied == true)
                    {
                        btnGrid[i, j].Text = "" + cmbbx_pieces.Text;
                    }
                    else if (myBoard.theGrid[i,j].legalNextMove == true)
                    {
                        btnGrid[i, j].Text = "Legal";
                    }
                    
                }
            }

        }
    }
}
