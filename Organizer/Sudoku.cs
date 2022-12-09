using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizer
{
    public partial class Sudoku : Form
    {
        public Sudoku()
        {
            InitializeComponent();

            createCells();

            startNewGame();
        }


        SudokuCell[,] cells = new SudokuCell[9, 9];

        private void createCells()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {

                    cells[i, j] = new SudokuCell();
                    cells[i, j].Font = new Font(SystemFonts.DefaultFont.FontFamily, 20);
                    cells[i, j].Size = new Size(40, 40);
                    cells[i, j].ForeColor = SystemColors.ControlDarkDark;
                    cells[i, j].Location = new Point(i * 40, j * 40);
                    cells[i, j].BackColor = ((i / 3) + (j / 3)) % 2 == 0 ? SystemColors.Control : Color.LightGray;
                    cells[i, j].FlatStyle = FlatStyle.Flat;
                    cells[i, j].FlatAppearance.BorderColor = Color.Black;
                    cells[i, j].X = i;
                    cells[i, j].Y = j;


                    cells[i, j].KeyPress += cell_keyPressed;

                    panel1.Controls.Add(cells[i, j]);
                }
            }
        }

        private void cell_keyPressed(object sender, KeyPressEventArgs e)
        {
            var cell = sender as SudokuCell;


            if (cell.IsLocked)
                return;

            int value;


            if (int.TryParse(e.KeyChar.ToString(), out value))
            {

                if (value == 0)
                    cell.Clear();
                else
                    cell.Text = value.ToString();

                cell.ForeColor = SystemColors.ControlDarkDark;
            }
        }

        private void startNewGame()
        {
            loadValues();

            var hintsCount = 0;
            if (EasyLevel.Checked)
                hintsCount = 45;
            else if (MediumLevel.Checked)
                hintsCount = 30;
            else if (HardLevel.Checked)
                hintsCount = 15;
            showRandomValuesHints(hintsCount);
        }

        private void showRandomValuesHints(int hintsCount)
        {
            for (int i = 0; i < hintsCount; i++)
            {
                var rX = random.Next(9);
                var rY = random.Next(9);
                cells[rX, rY].Text = cells[rX, rY].Value.ToString();
                cells[rX, rY].ForeColor = Color.Black;
                cells[rX, rY].IsLocked = true;
            }
        }

        private void loadValues()
        {

            foreach (var cell in cells)
            {
                cell.Value = 0;
                cell.Clear();
            }
            findValueForNextCell(0, -1);
        }

        Random random = new Random();

        private bool findValueForNextCell(int i, int j)
        {

            if (++j > 8)
            {
                j = 0;
                if (++i > 8)
                    return true;
            }

            var value = 0;
            var numsLeft = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            do
            {
                if (numsLeft.Count < 1)
                {
                    cells[i, j].Value = 0;
                    return false;
                }
                value = numsLeft[random.Next(0, numsLeft.Count)];
                cells[i, j].Value = value;
                numsLeft.Remove(value);
            }
            while (!isValidNumber(value, i, j) || !findValueForNextCell(i, j));

            return true;
        }

        private bool isValidNumber(int value, int x, int y)
        {
            for (int i = 0; i < 9; i++)
            {
                if (i != y && cells[x, i].Value == value)
                    return false;

                if (i != x && cells[i, y].Value == value)
                    return false;
            }


            for (int i = x - (x % 3); i < x - (x % 3) + 3; i++)
            {
                for (int j = y - (y % 3); j < y - (y % 3) + 3; j++)
                {
                    if (i != x && j != y && cells[i, j].Value == value)
                        return false;
                }
            }

            return true;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            var wrongCells = new List<SudokuCell>();


            foreach (var cell in cells)
            {
                if (!string.Equals(cell.Value.ToString(), cell.Text))
                {
                    wrongCells.Add(cell);
                }
            }


            if (wrongCells.Any())
            {

                wrongCells.ForEach(x => x.ForeColor = Color.Red);
                MessageBox.Show("Ошибка: проверьте введённые значения");
            }
            else
            {
                MessageBox.Show("Вы выйграли");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (var cell in cells)
            {

                if (cell.IsLocked == false)
                    cell.Clear();
            }
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            startNewGame();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    

