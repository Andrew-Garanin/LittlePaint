using System;
using System.Drawing;
using System.Windows.Forms;

namespace LittlePaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SolidBrush br = new SolidBrush(Color.Black);// Кисть для рисования
        Point startPoint;// Начальная точка

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Graphics gr = e.Graphics;
            // e.Graphics.FillRectangle(Brushes.Black, 200, 200, 2, 2);

            //Pen p = new Pen(Color.Blue, 5);// цвет линии и ширина
            //Point p1 = new Point(5, 10);// первая точка
            //Point p2 = new Point(40, 100);// вторая точка
            //gr.DrawLine(p, p1, p2);// рисуем линию
            //gr.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            //DigitalDifferencialAnalizator(20, 20, 200, 600);
        }// Мусор

        private void plot(Point point)
        {
            Graphics gr = this.CreateGraphics();
            PaintEventArgs paintEvArgs = new PaintEventArgs(gr, this.ClientRectangle);
            paintEvArgs.Graphics.FillRectangle(br, point.X, point.Y, 2, 2);
        }

        private void DigitalDifferencialAnalizator(int startX, int startY, int finishX, int finishY)
        {
            // т.к. у нас начальная точка может не быть нулем, 
            // мы должны параллельным переносом сдвинуть наш будущий отрезок в начало координат
            int a = finishX - startX;// координаты конца отрезка(сдвинутые в начало координат)
            int b = finishY - startY;
            double err = Math.Abs((double)b / (double)a);// текущая погрешность по ординате
            double deltaErr;// величина приращения
            Point currentPoint = new Point(0, 0);// координаты текущей точки(тут имеется ввиду, что значение текущей точки сдвинуто
                                                 // в начало координат)
            int octantNum=1;// номер октанта, в котором находится конечная точка          
            int a=Math.Abs(finishX-startX);
            if(finishX-startX >= 0 && finishY-startY >=0 && Math.Abs(((double)finishY-startY)/ ((double)finishX-startX))<=1)
                octantNum = 1;
            if (finishX-startX >= 0 && finishY-startY >= 0 && Math.Abs(((double)finishY-startY) / ((double)finishX-startX)) > 1)
            {
                octantNum = 2;
                a= Math.Abs(finishY - startY);
                err = 1 / err;
            }
            if (finishX-startX < 0 && finishY-startY >= 0 && Math.Abs(((double)finishY-startY) / ((double)finishX-startX)) > 1)
            {
                octantNum = 3;
                a = Math.Abs(finishY - startY);
                err = 1 / err;
            }
            if (finishX-startX < 0 && finishY-startY >= 0 && Math.Abs(((double)finishY-startY) / ((double)finishX-startX)) <= 1)
                octantNum = 4;
            if (finishX-startX < 0 && finishY-startY < 0 && Math.Abs(((double)finishY-startY) / ((double)finishX-startX)) <= 1)
                octantNum = 5;
            if (finishX-startX < 0 && finishY-startY < 0 && Math.Abs(((double)finishY-startY) /((double)finishX-startX)) > 1)
            {
                octantNum = 6;
                a = Math.Abs(finishY - startY);
                err = 1 / err;
            }
            if (finishX-startX >= 0 && finishY-startY < 0 && Math.Abs(((double)finishY-startY) / ((double)finishX-startX)) > 1)
            {
                octantNum = 7;
                a = Math.Abs(finishY - startY);
                err = 1 / err;
            }
            if (finishX-startX >= 0 && finishY-startY < 0 && Math.Abs(((double)finishY-startY) / ((double)finishX-startX)) <= 1)
                octantNum = 8;

            deltaErr = err;
            while (currentPoint.X < a)
            {
                switch (octantNum)
                {
                    case 1:
                        {
                            Point point = new Point(currentPoint.X + startX, currentPoint.Y + startY);
                            plot(point);
                        }
                        break;
                    case 2:
                        {
                            Point point = new Point(currentPoint.Y + startX, currentPoint.X + startY);
                            plot(point);
                        }
                        break;
                    case 3:
                        {
                            Point point = new Point(-currentPoint.Y + startX, currentPoint.X + startY);
                            plot(point);
                        }
                        break;
                    case 4:
                        {
                            Point point = new Point(-currentPoint.X + startX, currentPoint.Y + startY);
                            plot(point);
                        }
                        break;
                    case 5:
                        {
                            Point point = new Point(-currentPoint.X + startX, -currentPoint.Y + startY);
                            plot(point);
                        }
                        break;
                    case 6:
                        {
                            Point point = new Point(-currentPoint.Y + startX, -currentPoint.X + startY);
                            plot(point);
                        }
                        break;
                    case 7:
                        {
                            Point point = new Point(currentPoint.Y + startX, -currentPoint.X + startY);
                            plot(point);
                        }
                        break;
                    case 8:
                        {
                            Point point = new Point(currentPoint.X + startX, -currentPoint.Y + startY);
                            plot(point);
                        }
                        break;
                }

                if(err>1/2)
                {
                    // Диагональное смещение
                    currentPoint.X+=2;
                    currentPoint.Y+=2;

                    // т.к. произошло смещение по y на единицу вверх:
                    err += deltaErr - 1;
                }
                else
                {
                    // Горизонтальное смещение
                    currentPoint.X+=2;
                    err += deltaErr;
                }
            }
        }

        private void colorSelection_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = Color.Red;
            
            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
                br = new SolidBrush(MyDialog.Color);
        }// Диалоговое окно выбора цвета

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint.X = e.X;
            startPoint.Y = e.Y;
            Cursor.Clip = this.RectangleToScreen(this.ClientRectangle);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor.Clip = new Rectangle();
            DigitalDifferencialAnalizator(startPoint.X, startPoint.Y, e.X, e.Y);
        }
    }
}
