using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Paint_App
{
    class MenuBackgroundColor
    {
        public static void ChgangeBackground(Panel panel, Color color)
        {
            panel.BackColor = color;
        }
    }


    class DrawMenuShape
    {
        private static Graphics graphics;
        private static Brush brush;

        public static void DrawMenu(Panel panel, Color brushColor, Point[] points)
        {
            graphics = panel.CreateGraphics();
            brush = new SolidBrush(brushColor);
            graphics.FillPolygon(brush, points);
        }

        public static void DrawMenu(Panel panel, string shapeName, Color brushColor, int x, int y, int w, int h)
        {
            graphics = panel.CreateGraphics();
            brush = new SolidBrush(brushColor);

            if (shapeName == "Rectangle")
                graphics.FillRectangle(brush, x, y, w, h);

            else if (shapeName == "Circle")
                graphics.FillEllipse(brush, x, y, w, h);

            else
                return;
        }
    }


    class DrawShape : SaveFile
    {
        static int a = 0;

        protected static Graphics graphics;
        protected static Brush brush;

        private static int index = 0;
        private static int draw = 0;

        private static int x, y;

        public static void drawShapes(string shapeName)
        {
            if (shapeName == "rectangle")
                index = 1;

            else if (shapeName == "circle")
                index = 2;

            else if (shapeName == "triangle")
                index = 3;

            else if (shapeName == "hexagon")
                index = 4;

            else
                return;
        }

        public static void drawShapeUp()
        {
            draw = 0;
            a = 1;
        }

        public static void drawShape(MouseEventArgs startXY)
        {
            draw = 1;
            x = startXY.X;
            y = startXY.Y;
        }

        public static void drawShape(Panel panel, MouseEventArgs moveXY, Color color, string strColor)
        {
            if (draw == 1 && index == 1)
            {
                graphics = panel.CreateGraphics();
                brush = new SolidBrush(color);
                graphics.Clear(Color.Gainsboro);
                readFile(panel);
                Point[] rectanglePoints = { new Point(x, y), new Point(x, moveXY.Y), new Point(moveXY.X, moveXY.Y), new Point(moveXY.X, y) };
                graphics.FillPolygon(brush, rectanglePoints);
            }

            else if (draw == 1 && index == 2)
            {
                graphics = panel.CreateGraphics();
                brush = new SolidBrush(color);
                graphics.Clear(Color.Gainsboro);
                readFile(panel);
                graphics.FillEllipse(brush, 2 * x - moveXY.X, 2 * y - moveXY.Y, 2 * (moveXY.X - x), 2 * (moveXY.Y - y));
            }

            else if (draw == 1 && index == 3)
            {
                graphics = panel.CreateGraphics();
                brush = new SolidBrush(color);
                graphics.Clear(Color.Gainsboro);
                readFile(panel);
                Point[] trianglePoints = { new Point(x, y), new Point(x - (moveXY.X - x), moveXY.Y), new Point(moveXY.X, moveXY.Y) };
                graphics.FillPolygon(brush, trianglePoints);
            }

            else if (draw == 1 && index == 4)
            {
                graphics = panel.CreateGraphics();
                brush = new SolidBrush(color);
                graphics.Clear(Color.Gainsboro);
                readFile(panel);
                Point[] hexagonPoints = { new Point((x - (moveXY.X - x) / 2), y - Math.Abs(moveXY.Y - y)), new Point(2 * x - moveXY.X, y), new Point((x - (moveXY.X - x) / 2), moveXY.Y), new Point((x + (moveXY.X - x) / 2), moveXY.Y), new Point(moveXY.X, y), new Point((x + (moveXY.X - x) / 2), y - Math.Abs(moveXY.Y - y)) };
                graphics.FillPolygon(brush, hexagonPoints);
            }

            else
                return;
        }
    }


    class SaveFile
    {

        private static FileStream writeFile;
        private static StreamWriter write;
        protected static string filePath;
        public static void clearFile()
        {
            filePath = Application.StartupPath.ToString() + "\\temporary.tmp";
            writeFile = new FileStream(filePath, FileMode.Truncate);
            write = new StreamWriter(writeFile);

            write.Write("");
            write.Close();
            writeFile.Close();
        }

        public static void readFile(Panel panel)
        {
            Graphics graphics = panel.CreateGraphics();
            Brush brush;

            Color color = Color.Black;
            string[] readed;
            readed = File.ReadAllLines(Application.StartupPath.ToString() + "\\temporary.tmp");
            string[] readedSeries = new string[30];


            for (int j = 0; j < readed.Length; j++)
            {
                if ((readed[j].Split(','))[1] == "red")
                {
                    color = Color.Red;
                }

                else if ((readed[j].Split(','))[1] == "brown")
                {
                    color = Color.Brown;
                }

                else if ((readed[j].Split(','))[1] == "blue")
                {
                    color = Color.Blue;
                }

                else if ((readed[j].Split(','))[1] == "green")
                {
                    color = Color.Green;
                }

                else if ((readed[j].Split(','))[1] == "yellow")
                {
                    color = Color.Yellow;
                }

                else if ((readed[j].Split(','))[1] == "orange")
                {
                    color = Color.Orange;
                }

                else if ((readed[j].Split(','))[1] == "purple")
                {
                    color = Color.Purple;
                }

                else if ((readed[j].Split(','))[1] == "black")
                {
                    color = Color.Black;
                }

                else if ((readed[j].Split(','))[1] == "white")
                {
                    color = Color.White;
                }


                if ((readed[j].Split(','))[0] == "C") //Okunan veriden, şekil tespit edilir.
                {
                    for (int i = 0; i < 6; i++)
                    {
                        readedSeries[i] = Convert.ToString((readed[j].Split(','))[i]); //Şeklin koordinatları bir diziye aktarılır.
                    }

                    brush = new SolidBrush(color);
                    graphics.FillEllipse(brush, Convert.ToInt16(readedSeries[2]), Convert.ToInt16(readedSeries[3]), Convert.ToInt16(readedSeries[4]), Convert.ToInt16(readedSeries[5]));   //Okunulan verilere göre şekil ekrana çizdirilir.
                }

                else if ((readed[j].Split(','))[0] == "T")
                {
                    for (int i = 0; i < 8; i++)
                    {
                        readedSeries[i] = Convert.ToString((readed[j].Split(','))[i]);
                    }

                    Point[] noktalar = { new Point(Convert.ToInt16(readedSeries[2]), Convert.ToInt16(readedSeries[3])), new Point(Convert.ToInt16(readedSeries[4]), Convert.ToInt16(readedSeries[5])), new Point(Convert.ToInt16(readedSeries[6]), Convert.ToInt16(readedSeries[7])) };
                    brush = new SolidBrush(color);
                    graphics.FillPolygon(brush, noktalar);

                }

                else if ((readed[j].Split(','))[0] == "H")
                {
                    for (int i = 0; i < 14; i++)
                    {
                        readedSeries[i] = Convert.ToString((readed[j].Split(','))[i]);
                    }

                    Point[] points = { new Point(Convert.ToInt16(readedSeries[2]), Convert.ToInt16(readedSeries[3])), new Point(Convert.ToInt16(readedSeries[4]), Convert.ToInt16(readedSeries[5])), new Point(Convert.ToInt16(readedSeries[6]), Convert.ToInt16(readedSeries[7])), new Point(Convert.ToInt16(readedSeries[8]), Convert.ToInt16(readedSeries[9])), new Point(Convert.ToInt16(readedSeries[10]), Convert.ToInt16(readedSeries[11])), new Point(Convert.ToInt16(readedSeries[12]), Convert.ToInt16(readedSeries[13])) };
                    brush = new SolidBrush(color);
                    graphics.FillPolygon(brush, points);
                }

                else if ((readed[j].Split(','))[0] == "R")
                {
                    for (int i = 0; i < 10; i++)
                    {
                        readedSeries[i] = Convert.ToString((readed[j].Split(','))[i]);
                    }

                    Point[] points = { new Point(Convert.ToInt16(readedSeries[2]), Convert.ToInt16(readedSeries[3])), new Point(Convert.ToInt16(readedSeries[4]), Convert.ToInt16(readedSeries[5])), new Point(Convert.ToInt16(readedSeries[6]), Convert.ToInt16(readedSeries[7])), new Point(Convert.ToInt16(readedSeries[8]), Convert.ToInt16(readedSeries[9])) };
                    brush = new SolidBrush(color);
                    graphics.FillPolygon(brush, points);
                }
            }
        }


        public static void Circle(string color, int n1, int n2, int n3, int n4)
        {
            filePath = Application.StartupPath.ToString() + "\\temporary.tmp";
            writeFile = new FileStream(filePath, FileMode.Append);
            write = new StreamWriter(writeFile);
            string nn1, nn2, nn3, nn4;

            nn1 = Convert.ToString(n1);
            nn2 = Convert.ToString(n2);
            nn3 = Convert.ToString(n3);
            nn4 = Convert.ToString(n4);

            write.WriteLine("C," + color + "," + nn1 + "," + nn2 + "," + nn3 + "," + nn4);
            write.Close();
            writeFile.Close();
        }


        public static void Polygon(string color, Point[] points)
        {
            filePath = Application.StartupPath.ToString() + "\\temporary.tmp";
            writeFile = new FileStream(filePath, FileMode.Append);
            write = new StreamWriter(writeFile);
            int x = points.Length;
            if (points.Length == 4)
            {
                write.Write("R,");
            }
            else if (points.Length == 3)
            {
                write.Write("T,");
            }
            else if (points.Length == 6)
            {
                write.Write("H,");
            }

            write.Write(color);

            for (int i = 0; i < x; i++)
            {
                if (i == x - 1)
                {
                    write.WriteLine("," + points[i].X + "," + points[i].Y);
                }

                else
                {
                    write.Write("," + points[i].X + "," + points[i].Y);
                }
            }
            write.Close();
            writeFile.Close();
        }

        public static void saveWithButton(SaveFileDialog dia)
        {
            StreamWriter sw = new StreamWriter(dia.FileName);
            FileStream fs = new FileStream(Application.StartupPath.ToString() + "\\temporary.tmp", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string write = sr.ReadLine();

            while (write != null)
            {
                sw.WriteLine(write);
                write = sr.ReadLine();
            }

            sw.Close();
            sr.Close();
            fs.Close();
        }
    }

    class ReadFromButton : SaveFile  //Manuel olarak kaydedilen dosyayı açmak için kullanılan sınıf.
    {

        public static void read(Panel panel, OpenFileDialog ofd)
        {
            clearFile();
            Graphics graphics = panel.CreateGraphics();
            Brush brush;
            graphics.Clear(Color.Gainsboro);

            try
            {
                Color color = Color.Black;
                string[] readed;
                readed = File.ReadAllLines(ofd.FileName);
                string[] readedSeries = new string[30];
                string f_readed;
                f_readed = File.ReadAllText(ofd.FileName);
                File.WriteAllText(Application.StartupPath.ToString() + "\\temporary.tmp", f_readed);

                for (int j = 0; j < readed.Length; j++)
                {

                    if ((readed[j].Split(','))[1] == "kirmizi")
                    {
                        color = Color.Red;
                    }

                    else if ((readed[j].Split(','))[1] == "kkirmizi")
                    {
                        color = Color.DarkRed;
                    }

                    else if ((readed[j].Split(','))[1] == "mavi")
                    {
                        color = Color.Blue;
                    }

                    else if ((readed[j].Split(','))[1] == "yesil")
                    {
                        color = Color.Green;
                    }

                    else if ((readed[j].Split(','))[1] == "sari")
                    {
                        color = Color.Yellow;
                    }

                    else if ((readed[j].Split(','))[1] == "turuncu")
                    {
                        color = Color.Orange;
                    }

                    else if ((readed[j].Split(','))[1] == "mor")
                    {
                        color = Color.Purple;
                    }

                    else if ((readed[j].Split(','))[1] == "siyah")
                    {
                        color = Color.Black;
                    }

                    else if ((readed[j].Split(','))[1] == "beyaz")
                    {
                        color = Color.White;
                    }

                    if ((readed[j].Split(','))[0] == "C")
                    {
                        for (int i = 0; i < 6; i++)
                        {
                            readedSeries[i] = Convert.ToString((readed[j].Split(','))[i]);
                        }
                        brush = new SolidBrush(color);
                        graphics.FillEllipse(brush, Convert.ToInt16(readedSeries[2]), Convert.ToInt16(readedSeries[3]), Convert.ToInt16(readedSeries[4]), Convert.ToInt16(readedSeries[5]));
                    }

                    else if ((readed[j].Split(','))[0] == "T")
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            readedSeries[i] = Convert.ToString((readed[j].Split(','))[i]);
                        }

                        Point[] noktalar = { new Point(Convert.ToInt16(readedSeries[2]), Convert.ToInt16(readedSeries[3])), new Point(Convert.ToInt16(readedSeries[4]), Convert.ToInt16(readedSeries[5])), new Point(Convert.ToInt16(readedSeries[6]), Convert.ToInt16(readedSeries[7])) };
                        brush = new SolidBrush(color);
                        graphics.FillPolygon(brush, noktalar);

                    }

                    else if ((readed[j].Split(','))[0] == "H")
                    {
                        for (int i = 0; i < 14; i++)
                        {
                            readedSeries[i] = Convert.ToString((readed[j].Split(','))[i]);
                        }

                        Point[] points = { new Point(Convert.ToInt16(readedSeries[2]), Convert.ToInt16(readedSeries[3])), new Point(Convert.ToInt16(readedSeries[4]), Convert.ToInt16(readedSeries[5])), new Point(Convert.ToInt16(readedSeries[6]), Convert.ToInt16(readedSeries[7])), new Point(Convert.ToInt16(readedSeries[8]), Convert.ToInt16(readedSeries[9])), new Point(Convert.ToInt16(readedSeries[10]), Convert.ToInt16(readedSeries[11])), new Point(Convert.ToInt16(readedSeries[12]), Convert.ToInt16(readedSeries[13])) };
                        brush = new SolidBrush(color);
                        graphics.FillPolygon(brush, points);
                    }

                    else if ((readed[j].Split(','))[0] == "R")
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            readedSeries[i] = Convert.ToString((readed[j].Split(','))[i]);
                        }

                        Point[] points = { new Point(Convert.ToInt16(readedSeries[2]), Convert.ToInt16(readedSeries[3])), new Point(Convert.ToInt16(readedSeries[4]), Convert.ToInt16(readedSeries[5])), new Point(Convert.ToInt16(readedSeries[6]), Convert.ToInt16(readedSeries[7])), new Point(Convert.ToInt16(readedSeries[8]), Convert.ToInt16(readedSeries[9])) };
                        brush = new SolidBrush(color);
                        graphics.FillPolygon(brush, points);
                    }
                }
            }

            catch (Exception)
            {
                throw;
            }
        }
    }


    class MarkShape
    {
        private static string selectedShape = null;
        public static void Select(MouseEventArgs e, Panel panel)
        {
            int bnX = e.X;
            int bnY = e.Y;

            bool inside = false;

            string[] read = File.ReadAllLines(Application.StartupPath.ToString() + "\\temporary.tmp");

            for(int i = 0; i < read.Length; i++)
            {
                if ((read[i].Split(','))[0] == "C")
                {
                    if (bnX > Convert.ToInt16((read[i].Split(','))[2]) && bnY > Convert.ToInt16((read[i].Split(','))[3]) && bnX < (Convert.ToInt16((read[i].Split(','))[4]) + Convert.ToInt16((read[i].Split(','))[2])) && bnY < ((Convert.ToInt16((read[i].Split(','))[5]) + Convert.ToInt16((read[i].Split(','))[3]))))
                    {
                        selectedShape = read[i];
                        inside = true;
                        Graphics graphics = panel.CreateGraphics();
                        Pen pen = new Pen(Color.HotPink, 3);
                        graphics.Clear(Color.Gainsboro);
                        SaveFile.readFile(panel);
                        graphics.DrawRectangle(pen, Convert.ToInt16((read[i].Split(','))[2]) - 16, Convert.ToInt16((read[i].Split(','))[3]) - 16, Convert.ToInt16((read[i].Split(','))[4]) + 32, Convert.ToInt16((read[i].Split(','))[5]) + 32);
                    }
                }

                else if ((read[i].Split(','))[0] == "R")
                {
                    if (bnX > Convert.ToInt16((read[i].Split(','))[2]) && bnY > Convert.ToInt16((read[i].Split(','))[3]) && bnX < (Convert.ToInt16((read[i].Split(','))[6])) && bnY < ((Convert.ToInt16((read[i].Split(','))[5]))))
                    {
                        selectedShape = read[i];
                        inside = true;
                        Graphics graphics = panel.CreateGraphics();
                        Pen pen = new Pen(Color.HotPink, 3);
                        graphics.Clear(Color.Gainsboro);
                        SaveFile.readFile(panel);
                        graphics.DrawRectangle(pen, Convert.ToInt16((read[i].Split(','))[2]) - 16, Convert.ToInt16((read[i].Split(','))[3]) - 16, Convert.ToInt16((read[i].Split(','))[8]) - Convert.ToInt16((read[i].Split(','))[2]) + 32, Convert.ToInt16((read[i].Split(','))[5]) - Convert.ToInt16((read[i].Split(','))[3]) + 32);
                    }
                }

                else if ((read[i].Split(','))[0] == "H")
                {
                    if (bnX > Convert.ToInt16((read[i].Split(','))[4]) && bnY > Convert.ToInt16((read[i].Split(','))[3]) && bnX < (Convert.ToInt16((read[i].Split(','))[10])) && bnY < ((Convert.ToInt16((read[i].Split(','))[6]))))
                    {
                        selectedShape = read[i];
                        inside = true;
                        Graphics graphics = panel.CreateGraphics();
                        Pen kalem = new Pen(Color.HotPink, 3);
                        graphics.Clear(Color.Gainsboro);
                        SaveFile.readFile(panel);
                        graphics.DrawRectangle(kalem, Convert.ToInt16((read[i].Split(','))[4]) - 16, Convert.ToInt16((read[i].Split(','))[3]) - 16, Convert.ToInt16((read[i].Split(','))[10]) - Convert.ToInt16((read[i].Split(','))[4]) + 32, Convert.ToInt16((read[i].Split(','))[7]) - Convert.ToInt16((read[i].Split(','))[13]) + 32);
                    }
                }

                else if ((read[i].Split(','))[0] == "T")
                {
                    if (bnX > Convert.ToInt16((read[i].Split(','))[4]) && bnY > Convert.ToInt16((read[i].Split(','))[3]) && bnX < (Convert.ToInt16((read[i].Split(','))[6])) && bnY < ((Convert.ToInt16((read[i].Split(','))[7]))))
                    {
                        selectedShape = read[i];
                        inside = true;
                        Graphics graphics = panel.CreateGraphics();
                        Pen pen = new Pen(Color.HotPink, 3);
                        graphics.Clear(Color.Gainsboro);
                        SaveFile.readFile(panel);
                        graphics.DrawRectangle(pen, Convert.ToInt16((read[i].Split(','))[4]) - 16, Convert.ToInt16((read[i].Split(','))[3]) - 16, Convert.ToInt16((read[i].Split(','))[6]) - Convert.ToInt16((read[i].Split(','))[4]) + 32, Convert.ToInt16((read[i].Split(','))[5]) - Convert.ToInt16((read[i].Split(','))[3]) + 32);
                    }
                }

                else
                    return;

            }
        }

        public static void delete(Panel panel)
        {
            if (selectedShape != null)
            {
                try
                {
                    FileStream writeFile;
                    StreamWriter write;
                    writeFile = new FileStream(Application.StartupPath.ToString() + "\\temporaryDel.tmp", FileMode.Truncate);
                    write = new StreamWriter(writeFile);
                    string[] tempRead = File.ReadAllLines(Application.StartupPath.ToString() + "\\temporary.tmp");

                    for (int i = 0; i < tempRead.Length; i++)
                    {
                        if (tempRead[i] != selectedShape)
                        {
                            write.WriteLine(tempRead[i]);
                        }

                    }

                    write.Close();
                    writeFile.Close();
                    writeFile = new FileStream(Application.StartupPath.ToString() + "\\temporary.tmp", FileMode.Truncate);
                    write = new StreamWriter(writeFile);
                    write.Write(File.ReadAllText(Application.StartupPath.ToString() + "\\temporaryDel.tmp"));

                    write.Close();
                    writeFile.Close();
                    Graphics graphics = panel.CreateGraphics();
                    graphics.Clear(Color.Gainsboro);
                    SaveFile.readFile(panel);

                }

                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static void Recolor(string color, Panel panel)
        {
            if (selectedShape != null)
            {
                try
                {
                    FileStream writeFile;
                    StreamWriter write;
                    writeFile = new FileStream(Application.StartupPath.ToString() + "\\temporaryDel.tmp", FileMode.Truncate);
                    write = new StreamWriter(writeFile);
                    string[] tempRead = File.ReadAllLines(Application.StartupPath.ToString() + "\\temporary.tmp");
                    string[] neu = new string[tempRead.Length];

                    for (int i = 0; i < tempRead.Length; i++)
                    {
                        if (tempRead[i] != selectedShape)
                        {
                            write.WriteLine(tempRead[i]);
                        }

                        else
                        {
                            write.WriteLine(tempRead[i].Replace(tempRead[i].Split(',')[1], color));
                        }
                    }

                    write.Close();
                    writeFile.Close();
                    writeFile = new FileStream(Application.StartupPath.ToString() + "\\temporary.tmp", FileMode.Truncate);
                    write = new StreamWriter(writeFile);
                    write.Write(File.ReadAllText(Application.StartupPath.ToString() + "\\temporaryDel.tmp"));

                    write.Close();
                    writeFile.Close();
                    Graphics graphics = panel.CreateGraphics();
                    graphics.Clear(Color.Gainsboro);
                    SaveFile.readFile(panel);

                }

                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
