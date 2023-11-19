﻿using _8Puzzle.Core;
using _8Puzzle.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8Puzzle
{
    public partial class Form1 : Form, IPrintService
    {
        private readonly IPuzzle _puzzle;
        private IIds _ids;
        int[,] _board;

        public Form1()
        {
            InitializeComponent();
            _board = new int[3, 3] { { 3, 8, 1 }, { 6, 2, 5 }, { 0, 4, 7 } };
            _puzzle = new Puzzle(_board);
            _ids = new Ids(this);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await PrintBoard(_puzzle.GetBoard());
            await _ids.IterativeDeepeningSearch(_puzzle.GetBoard());
        }

        private async Task Run()
        {
            _board = new int[3, 3] { { 3, 8, 1 }, { 6, 2, 5 }, { 0, 4, 7 } };
            _puzzle.SetBoard(_board);
            _ids = new Ids(this);
            lbl_depth.Text = "0";
            lbl_iterations.Text = "0";
            lbl_nodesGenerated.Text = "0";
            await _ids.IterativeDeepeningSearch(_puzzle.GetBoard());
        }

        public async Task PrintBoard(int[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    await Task.Delay(50);

                    SetTextPrintBoard(i, j, board[i, j]);
                    SetColorPrintBoard(i, j, board[i, j]);
                }
            }
        }

        public void SetTextPrintBoard(int row, int col, int value)
        {
            if (row == 0 && col == 0)
            {
                btn_00.Text = value.ToString();
            }
            else if (row == 0 && col == 1)
            {
                btn_01.Text = value.ToString();
            }
            else if (row == 0 && col == 2)
            {
                btn_02.Text = value.ToString();
            }
            else if (row == 1 && col == 0)
            {
                btn_10.Text = value.ToString();
            }
            else if (row == 1 && col == 1)
            {
                btn_11.Text = value.ToString();
            }
            else if (row == 1 && col == 2)
            {
                btn_12.Text = value.ToString();
            }
            else if (row == 2 && col == 0)
            {
                btn_20.Text = value.ToString();
            }
            else if (row == 2 && col == 1)
            {
                btn_21.Text = value.ToString();
            }
            else if (row == 2 && col == 2)
            {
                btn_22.Text = value.ToString();
            }
        }

        public void SetColorPrintBoard(int row, int col, int value)
        {
            if (row == 0 && col == 0)
            {
                btn_00.BackColor = GetColorElementByValue(value);
            }
            else if (row == 0 && col == 1)
            {
                btn_01.BackColor = GetColorElementByValue(value);
            }
            else if (row == 0 && col == 2)
            {
                btn_02.BackColor = GetColorElementByValue(value);
            }
            else if (row == 1 && col == 0)
            {
                btn_10.BackColor = GetColorElementByValue(value);
            }
            else if (row == 1 && col == 1)
            {
                btn_11.BackColor = GetColorElementByValue(value);
            }
            else if (row == 1 && col == 2)
            {
                btn_12.BackColor = GetColorElementByValue(value);
            }
            else if (row == 2 && col == 0)
            {
                btn_20.BackColor = GetColorElementByValue(value);
            }
            else if (row == 2 && col == 1)
            {
                btn_21.BackColor = GetColorElementByValue(value);
            }
            else if (row == 2 && col == 2)
            {
                btn_22.BackColor = GetColorElementByValue(value);
            }
        }

        public Color GetColorElementByValue(int value)
        {
            return value == 0 ? Color.Gold : Color.White;
        }

        public void PrintStats(int iterations, int nodesGenerated, int depth)
        {
            lbl_iterations.Text = iterations.ToString();
            lbl_nodesGenerated.Text = nodesGenerated.ToString();
            lbl_depth.Text = depth.ToString();
        }

        private async void btn_refresh_Click(object sender, EventArgs e)
        {
            await Run();
        }
    }
}
