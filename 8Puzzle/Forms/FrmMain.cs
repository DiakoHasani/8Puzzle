using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8Puzzle.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btn_Ids_Click(object sender, EventArgs e)
        {
            new FrmIds().Show();
        }

        private void btn_Accidental_Click(object sender, EventArgs e)
        {
            new FrmAccidental().Show();
        }

        private void btn_BFS_Click(object sender, EventArgs e)
        {
            new FrmBFS().Show();
        }

        private void btn_AStar_Click(object sender, EventArgs e)
        {
            new FrmAStar().Show();
        }
    }
}
