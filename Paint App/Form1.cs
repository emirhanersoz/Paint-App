using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_App
{
    public partial class Form1 : Form
    {
        Color selectionColor = Color.Black;
        string strColor = "black";
        string shape;
        int x, y;
        int index = 0;
        bool draw = false;
        bool choose = false;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void rectanglePanel_Paint(object sender, PaintEventArgs e)
        {
            DrawMenuShape.DrawMenu(rectanglePanel, "Rectangle", Color.DarkOrange, 17, 8, 45, 45);
        }

        private void circlePanel_Paint(object sender, PaintEventArgs e)
        {
            DrawMenuShape.DrawMenu(circlePanel, "Circle", Color.DarkOrange, 17, 8, 45, 45);
        }

        private void trianglePanel_Paint(object sender, PaintEventArgs e)
        {
            Point[] trianglePoints = { new Point(39, 8), new Point(17, 53), new Point(61, 53) };
            DrawMenuShape.DrawMenu(trianglePanel, Color.DarkOrange, trianglePoints);
        }

        private void hexagonPanel_Paint(object sender, PaintEventArgs e)
        {
            Point[] hexagonPoints = { new Point(33, 8), new Point(18, 32), new Point(33, 55), new Point(54, 55), new Point(68, 30), new Point(54, 8) };
            DrawMenuShape.DrawMenu(hexagonPanel, Color.DarkOrange, hexagonPoints);
        }

        private void drawPanel_MouseUp(object sender, MouseEventArgs e)
        {
            DrawShape.drawShapeUp();
            if (!choose)
            {
                if (index == 1)
                {
                    Point[] rectanglePoints = { new Point(x, y), new Point(x, e.Y), new Point(e.X, e.Y), new Point(e.X, y) };
                    SaveFile.Polygon(strColor, rectanglePoints);
                }

                else if (index == 2)
                {
                    SaveFile.Circle(strColor, (2 * x - e.X), (2 * y - e.Y), (2 * (e.X - x)), (2 * (e.Y - y)));
                }

                else if (index == 3)
                {
                    Point[] triangleSeries = { new Point(x, y), new Point(Math.Abs(x - (e.X - x)), e.Y), new Point(e.X, e.Y) };
                    SaveFile.Polygon(strColor, triangleSeries);
                }

                else if (index == 4)
                {
                    Point[] hexagonPoints = { new Point(Math.Abs((x - (e.X - x) / 2)), Math.Abs(y - Math.Abs(e.Y - y))), new Point(Math.Abs(2 * x - e.X), y), new Point(Math.Abs((x - (e.X - x) / 2)), e.Y), new Point((x + (e.X - x) / 2), e.Y), new Point(e.X, y), new Point((x + (e.X - x) / 2), Math.Abs(y - Math.Abs(e.Y - y))) };
                    SaveFile.Polygon(strColor, hexagonPoints);
                }

                else
                    return;
            }
            draw = false;
        }

        private void drawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(draw)
            DrawShape.drawShape(drawPanel, e, selectionColor, strColor);
        }

        private void drawPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (!choose)
            draw = true;
            if (choose)
            DrawShape.drawShape(e);
            x = e.X;
            y = e.Y;
        }

        private void rectanglePanel_MouseClick(object sender, MouseEventArgs e)
        {
            shape = "R";
            DrawShape.drawShapes("rectangle");
            MenuBackgroundColor.ChgangeBackground(rectanglePanel, Color.SeaGreen);
            MenuBackgroundColor.ChgangeBackground(trianglePanel, Color.MistyRose);
            MenuBackgroundColor.ChgangeBackground(circlePanel, Color.MistyRose);
            MenuBackgroundColor.ChgangeBackground(hexagonPanel, Color.MistyRose);
            index = 1;
        }

        private void circlePanel_MouseClick(object sender, MouseEventArgs e)
        {
            shape = "C";
            DrawShape.drawShapes("circle");
            MenuBackgroundColor.ChgangeBackground(rectanglePanel, Color.MistyRose);
            MenuBackgroundColor.ChgangeBackground(trianglePanel, Color.MistyRose);
            MenuBackgroundColor.ChgangeBackground(circlePanel, Color.SeaGreen);
            MenuBackgroundColor.ChgangeBackground(hexagonPanel, Color.MistyRose);
            index = 2;
        }

        private void trianglePanel_MouseClick(object sender, MouseEventArgs e)
        {
            shape = "T";
            DrawShape.drawShapes("triangle");
            MenuBackgroundColor.ChgangeBackground(rectanglePanel, Color.MistyRose);
            MenuBackgroundColor.ChgangeBackground(trianglePanel, Color.SeaGreen);
            MenuBackgroundColor.ChgangeBackground(circlePanel, Color.MistyRose);
            MenuBackgroundColor.ChgangeBackground(hexagonPanel, Color.MistyRose);
            index = 3;
        }

        private void hexagonPanel_MouseClick(object sender, MouseEventArgs e)
        {
            shape = "H";
            DrawShape.drawShapes("hexagon");
            MenuBackgroundColor.ChgangeBackground(rectanglePanel, Color.MistyRose);
            MenuBackgroundColor.ChgangeBackground(trianglePanel, Color.MistyRose);
            MenuBackgroundColor.ChgangeBackground(circlePanel, Color.MistyRose);
            MenuBackgroundColor.ChgangeBackground(hexagonPanel, Color.SeaGreen);
            index = 4;
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            strColor = "red";
            selectionColor = Color.Red;

            if (choose)
                MarkShape.Recolor(strColor, drawPanel);
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            strColor = "blue";
            selectionColor = Color.Blue;

            if (choose)
                MarkShape.Recolor(strColor, drawPanel);
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            strColor = "green";
            selectionColor = Color.Green;

            if (choose)
                MarkShape.Recolor(strColor, drawPanel);
        }

        private void orangeButton_Click(object sender, EventArgs e)
        {
            strColor = "orange";
            selectionColor = Color.Orange;

            if (choose)
                MarkShape.Recolor(strColor, drawPanel);
        }

        private void blackButton_Click(object sender, EventArgs e)
        {
            strColor = "black";
            selectionColor = Color.Black;

            if (choose)
                MarkShape.Recolor(strColor, drawPanel);
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            strColor = "yellow";
            selectionColor = Color.Yellow;

            if (choose)
                MarkShape.Recolor(strColor, drawPanel);
        }

        private void purpleButton_Click(object sender, EventArgs e)
        {
            strColor = "purple";
            selectionColor = Color.Purple;

            if (choose)
                MarkShape.Recolor(strColor, drawPanel);
        }

        private void brownButton_Click(object sender, EventArgs e)
        {
            strColor = "brown";
            selectionColor = Color.Brown;

            if (choose)
                MarkShape.Recolor(strColor, drawPanel);
        }

        private void whiteButton_Click(object sender, EventArgs e)
        {
            strColor = "white";
            selectionColor = Color.White;

            if (choose)
                MarkShape.Recolor(strColor, drawPanel);
        }

        private void choosePanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (choosePanel.BackColor == Color.YellowGreen)
                MenuBackgroundColor.ChgangeBackground(choosePanel, Color.White);

            else
            {
                MenuBackgroundColor.ChgangeBackground(choosePanel, Color.YellowGreen);
                MenuBackgroundColor.ChgangeBackground(deletePanel, Color.White);
                index = 0;
                MenuBackgroundColor.ChgangeBackground(rectanglePanel, Color.MistyRose);
                MenuBackgroundColor.ChgangeBackground(trianglePanel, Color.MistyRose);
                MenuBackgroundColor.ChgangeBackground(circlePanel, Color.MistyRose);
                MenuBackgroundColor.ChgangeBackground(hexagonPanel, Color.MistyRose);
            }

            if (choose == false)
            {
                draw = false;
                choose = true;
            }

            else
            {
                draw = true;
                choose = false;
            }
        }

        private void deletePanel_MouseClick(object sender, MouseEventArgs e)
        {
            MarkShape.delete(drawPanel);
            choose = false;
            MenuBackgroundColor.ChgangeBackground(choosePanel, Color.White);
        }

        private void openFilePanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (openFilePanel.BackColor == Color.YellowGreen)
            {
                MenuBackgroundColor.ChgangeBackground(openFilePanel, Color.White);
            }
            else
            {
                MenuBackgroundColor.ChgangeBackground(openFilePanel, Color.YellowGreen);
                MenuBackgroundColor.ChgangeBackground(saveFilePanel, Color.White);
            }
            OpenFileDialog read = new OpenFileDialog();
            if (read.ShowDialog() == DialogResult.OK)
            {
                ReadFromButton.read(drawPanel, read);
            }
            MenuBackgroundColor.ChgangeBackground(openFilePanel, Color.White);
        }

        private void saveFilePanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (saveFilePanel.BackColor == Color.YellowGreen)
            {
                MenuBackgroundColor.ChgangeBackground(saveFilePanel, Color.White);
            }

            else
            {
                MenuBackgroundColor.ChgangeBackground(saveFilePanel, Color.YellowGreen);
                MenuBackgroundColor.ChgangeBackground(openFilePanel, Color.White);
            }

            SaveFileDialog save = new SaveFileDialog();

            if (save.ShowDialog() == DialogResult.OK)
            {
                SaveFile.saveWithButton(save);
            }
        }

        private void drawPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if(choose)
            MarkShape.Select(e, drawPanel);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveFile.clearFile();
        }

        private void choosePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deletePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}