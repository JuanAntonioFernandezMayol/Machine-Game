using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Matching_Game
{
    public partial class Form1 : Form
    {
        List<string> icons = new List<string>()
        {
            "!", "!", "N", "N", "K", "K", "X", "X",
            "O", "O", "P", "P", "Q", "Q", "R", "R"
        };

        Label firstClicked = null;
        Label secondClicked = null;

        public Form1()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }

        private void AssignIconsToSquares()
        {
            Random random = new Random();

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Label label)
                {
                    int randomIndex = random.Next(icons.Count);
                    label.Text = icons[randomIndex];
                    label.ForeColor = label.BackColor;
                    icons.RemoveAt(randomIndex);
                }
            }
        }

        private void label_Click(object sender, EventArgs e)
        {
            if (firstClicked != null && secondClicked != null)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel == null || clickedLabel.ForeColor == Color.White)
                return;

            clickedLabel.ForeColor = Color.Black;

            if (firstClicked == null)
            {
                firstClicked = clickedLabel;
                return;
            }

            secondClicked = clickedLabel;

            CheckForMatch();
        }

        private void CheckForMatch()
        {
            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
                return;
            }

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 750;
            timer.Tick += (s, e) =>
            {
                firstClicked.ForeColor = firstClicked.BackColor;
                secondClicked.ForeColor = secondClicked.BackColor;

                firstClicked = null;
                secondClicked = null;
                timer.Stop();
            };

            timer.Start();
        }
    }
}
