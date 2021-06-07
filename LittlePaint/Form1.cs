using System;
using System.Collections.Generic;
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
        int LEFT = 1;/* двоичное 0001 */
        int RIGHT = 2;/* двоичное 0010 */
        int BOT = 4;/* двоичное 0100 */
        int TOP = 8;/* двоичное 1000 */

        Rectangle rect;// Черный прямоугольник

        List<PointF> pointList = new List<PointF>(); // Исходный массив точек

        SolidBrush br = new SolidBrush(Color.Black);// Кисть для рисования

        Point startPoint;// Начальная точка

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            rect = new Rectangle(100, 100, 200, 200);
            BrezenkhemAlgoritmLine(rect.Right, rect.Top, rect.Right, rect.Bottom);
            BrezenkhemAlgoritmLine(rect.Right, rect.Bottom, rect.Left, rect.Bottom);
            BrezenkhemAlgoritmLine(rect.Left, rect.Bottom, rect.Left, rect.Top);
            BrezenkhemAlgoritmLine(rect.Left, rect.Top, rect.Right, rect.Top);
        }

        private void Plot(Point point)// функция рисования пикселя
        {
            Graphics gr = this.CreateGraphics();
            PaintEventArgs paintEvArgs = new PaintEventArgs(gr, this.ClientRectangle);
            int pixelSize = 2;
            paintEvArgs.Graphics.FillRectangle(br, point.X, point.Y, pixelSize, pixelSize);
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
            int octantNum = 0;// номер октанта, в котором находится конечная точка

            /* Далее происходит выбор октанта в котором находится конечная точка.
               В октантах 2,3,6,7 необходимо так же заменить точку a на точку b
               и вместо обычной погрешности по оординате взять обратную к ней.
               Это необходимо из-за того, что в этих октантах |x|<=|y|.
             */
            if (a >= 0 && b >= 0 && Math.Abs((double)b / (double)a) <= 1)
                octantNum = 1;
            if (a >= 0 && b >= 0 && Math.Abs((double)b / (double)a) > 1)
            {
                octantNum = 2;
                a = b;
                err = 1 / err;
            }
            if (a < 0 && b >= 0 && Math.Abs((double)b / (double)a) > 1)
            {
                octantNum = 3;
                a = b;
                err = 1 / err;
            }
            if (a < 0 && b >= 0 && Math.Abs((double)b / (double)a) <= 1)
                octantNum = 4;
            if (a < 0 && b < 0 && Math.Abs((double)b / (double)a) <= 1)
                octantNum = 5;
            if (a < 0 && b < 0 && Math.Abs((double)b / (double)a) > 1)
            {
                octantNum = 6;
                a = b;
                err = 1 / err;
            }
            if (a >= 0 && b < 0 && Math.Abs((double)b / (double)a) > 1)
            {
                octantNum = 7;
                a = b;
                err = 1 / err;
            }
            if (a >= 0 && b < 0 && Math.Abs((double)b / (double)a) <= 1)
                octantNum = 8;

            deltaErr = err;
            while (currentPoint.X < Math.Abs(a))
            {
                switch (octantNum)
                {
                    case 1:
                        {
                            Point point = new Point(currentPoint.X + startX, currentPoint.Y + startY);
                            Plot(point);
                        }
                        break;
                    case 2:
                        {
                            Point point = new Point(currentPoint.Y + startX, currentPoint.X + startY);
                            Plot(point);
                        }
                        break;
                    case 3:
                        {
                            Point point = new Point(-currentPoint.Y + startX, currentPoint.X + startY);
                            Plot(point);
                        }
                        break;
                    case 4:
                        {
                            Point point = new Point(-currentPoint.X + startX, currentPoint.Y + startY);
                            Plot(point);
                        }
                        break;
                    case 5:
                        {
                            Point point = new Point(-currentPoint.X + startX, -currentPoint.Y + startY);
                            Plot(point);
                        }
                        break;
                    case 6:
                        {
                            Point point = new Point(-currentPoint.Y + startX, -currentPoint.X + startY);
                            Plot(point);
                        }
                        break;
                    case 7:
                        {
                            Point point = new Point(currentPoint.Y + startX, -currentPoint.X + startY);
                            Plot(point);
                        }
                        break;
                    case 8:
                        {
                            Point point = new Point(currentPoint.X + startX, -currentPoint.Y + startY);
                            Plot(point);
                        }
                        break;
                }

                if (err > 1 / 2)
                {
                    // Диагональное смещение
                    currentPoint.X += 2;
                    currentPoint.Y += 2;

                    // т.к. произошло смещение по y на единицу вверх:
                    err += deltaErr - 1;
                }
                else
                {
                    // Горизонтальное смещение
                    currentPoint.X += 2;
                    err += deltaErr;
                }
            }
        }// Прямая

        private void BrezenkhemAlgoritmLine(int startX, int startY, int finishX, int finishY)
        {
            // т.к. у нас начальная точка может не быть нулем, 
            // мы должны параллельным переносом сдвинуть наш будущий отрезок в начало координат
            int a = finishX - startX;// координаты конца отрезка(сдвинутые в начало координат)
            int b = finishY - startY;
            double err = Math.Abs(2 * b) - Math.Abs(a);// текущая погрешность по ординате
            double deltaErrDiagonal;// величина приращения по диагонали
            double deltaErrHorizontal;// величина приращения по горизонтали
            Point currentPoint = new Point(0, 0);// координаты текущей точки(тут имеется ввиду, что значение текущей точки сдвинуто
                                                 // в начало координат)
            int octantNum = 0;// номер октанта, в котором находится конечная точка

            /* Далее происходит выбор октанта в котором находится конечная точка.
               В октантах 2,3,6,7 необходимо так же заменить точку a на точку b
               и вместо обычной погрешности по ординате поставить "противоположную ей".
               Это необходимо из-за того, что в этих октантах |x|<=|y|.
             */

            if (a >= 0 && b >= 0 && Math.Abs((double)b / (double)a) <= 1)
                octantNum = 1;
            if (a >= 0 && b >= 0 && Math.Abs((double)b / (double)a) > 1)
            {
                octantNum = 2;
                err = Math.Abs(2 * a) - Math.Abs(b);
                a = b;
            }
            if (a < 0 && b >= 0 && Math.Abs((double)b / (double)a) > 1)
            {
                octantNum = 3;
                err = Math.Abs(2 * a) - Math.Abs(b);
                a = b;
            }
            if (a < 0 && b >= 0 && Math.Abs((double)b / (double)a) <= 1)
                octantNum = 4;
            if (a < 0 && b < 0 && Math.Abs((double)b / (double)a) <= 1)
                octantNum = 5;
            if (a < 0 && b < 0 && Math.Abs((double)b / (double)a) > 1)
            {
                octantNum = 6;
                err = Math.Abs(2 * a) - Math.Abs(b);
                a = b;
            }
            if (a >= 0 && b < 0 && Math.Abs((double)b / (double)a) > 1)
            {
                octantNum = 7;
                err = Math.Abs(2 * a) - Math.Abs(b);
                a = b;
            }
            if (a >= 0 && b < 0 && Math.Abs((double)b / (double)a) <= 1)
                octantNum = 8;

            deltaErrDiagonal = err - Math.Abs(a);
            deltaErrHorizontal = err + Math.Abs(a);

            while (currentPoint.X < Math.Abs(a))
            {
                switch (octantNum)
                {
                    case 1:
                        {
                            Point point = new Point(currentPoint.X + startX, currentPoint.Y + startY);
                            Plot(point);
                        }
                        break;
                    case 2:
                        {
                            Point point = new Point(currentPoint.Y + startX, currentPoint.X + startY);
                            Plot(point);
                        }
                        break;
                    case 3:
                        {
                            Point point = new Point(-currentPoint.Y + startX, currentPoint.X + startY);
                            Plot(point);
                        }
                        break;
                    case 4:
                        {
                            Point point = new Point(-currentPoint.X + startX, currentPoint.Y + startY);
                            Plot(point);
                        }
                        break;
                    case 5:
                        {
                            Point point = new Point(-currentPoint.X + startX, -currentPoint.Y + startY);
                            Plot(point);
                        }
                        break;
                    case 6:
                        {
                            Point point = new Point(-currentPoint.Y + startX, -currentPoint.X + startY);
                            Plot(point);
                        }
                        break;
                    case 7:
                        {
                            Point point = new Point(currentPoint.Y + startX, -currentPoint.X + startY);
                            Plot(point);
                        }
                        break;
                    case 8:
                        {
                            Point point = new Point(currentPoint.X + startX, -currentPoint.Y + startY);
                            Plot(point);
                        }
                        break;
                }

                if (err > 0)
                {
                    // Диагональное смещение
                    currentPoint.X += 2;
                    currentPoint.Y += 2;

                    // т.к. произошло смещение по y на единицу вверх:
                    err += deltaErrDiagonal;
                }
                else
                {
                    // Горизонтальное смещение
                    currentPoint.X += 2;
                    err += deltaErrHorizontal;
                }
            }
        } // Прямая

        void BrezenkhemAlgoritmCircle(Point mid, int radius)
        {
            int x = 0;
            int y = radius;
            int delta = 1 - 2 * radius;
            int error = 0;
            while (y >= 0)
            {
                Plot(new Point(mid.X + x, mid.Y + y));
                Plot(new Point(mid.X + x, mid.Y - y));
                Plot(new Point(mid.X - x, mid.Y + y));
                Plot(new Point(mid.X - x, mid.Y - y));
                error = 2 * (delta + y) - 1;
                if (delta < 0 && error <= 0)
                {
                    x++;
                    delta += 2 * x + 1;
                    continue;
                }
                error = 2 * (delta - x) - 1;
                if (delta > 0 && error > 0)
                {
                    y--;
                    delta += 1 - 2 * y;
                    continue;
                }
                x++;
                delta += 2 * (x - y);
                y--;
            }
        }// Круг

        static int Fuctorial(int n)
        {
            int res = 1;
            for (int i = 1; i <= n; i++)
                res *= i;
            return res;
        }// Вычисление факториала для бизье

        static float BernshteynPolinom(int i, int n, float t)// Функция вычисления полинома Бернштейна для бизье
        {
            return (Fuctorial(n) / (Fuctorial(i) * Fuctorial(n - i))) * (float)Math.Pow(t, i) * (float)Math.Pow(1 - t, n - i);
        }

        void DecasteldjoAlgoritmBusier()
        {
            int j = 0;
            float step = 0.01f;

            PointF[] result = new PointF[101];//Конечный массив точек кривой
            for (float t = 0; t < 1; t += step)
            {
                float ytmp = 0;
                float xtmp = 0;
                for (int i = 0; i < pointList.Count; i++)
                { // проходим по каждой точке
                    float b = BernshteynPolinom(i, pointList.Count - 1, t); // вычисляем наш полином Бернштейна
                    xtmp += pointList[i].X * b; // записываем и прибавляем результат
                    ytmp += pointList[i].Y * b;
                }
                result[j] = new PointF(xtmp, ytmp);
                j++;

            }
            this.Refresh();
            for (int i = 0; i < result.Length - 1; i++)
            {
                BrezenkhemAlgoritmLine((int)result[i].X, (int)result[i].Y, (int)result[i + 1].X, (int)result[i + 1].Y);
            }
        }// Бизье

        int PointCode(Rectangle r, Point p)// Для алгоритма Коэна-Сазерленда и средней точки
        {
            return (p.X < r.Left ? LEFT : 0) + (p.X > r.Right ? RIGHT : 0) + (p.Y > (r.Bottom) ? BOT : 0) + (p.Y < (r.Top) ? TOP : 0);
        }

        int cohen_sutherland(Rectangle r, Point a, Point b)
        {
            int code_a, code_b, code; /* код концов отрезка */
            Point c; /* одна из точек */

            code_a = PointCode(r, a);
            code_b = PointCode(r, b);

            /* пока одна из точек отрезка вне прямоугольника */
            while ((code_a | code_b) != 0)
            {
                /* если обе точки с одной стороны прямоугольника, то отрезок не пересекает прямоугольник */
                if ((code_a & code_b) != 0)
                    return -1;

                /* выбираем точку c с ненулевым кодом */
                if (code_a != 0)
                {
                    code = code_a;
                    c = a;
                }
                else
                {
                    code = code_b;
                    c = b;
                }
                if ((code & LEFT) != 0)
                {
                    c.Y += (a.Y - b.Y) * (r.Left - c.X) / (a.X - b.X);
                    c.X = r.Left;
                }
                else if ((code & RIGHT) != 0)
                {
                    c.Y += (a.Y - b.Y) * (r.Right - c.X) / (a.X - b.X);
                    c.X = r.Right;
                }
                else if ((code & BOT) != 0)
                {
                    c.X += (a.X - b.X) * (r.Bottom - c.Y) / (a.Y - b.Y);
                    c.Y = r.Bottom;
                }
                else if ((code & TOP) != 0)
                {
                    c.X += (a.X - b.X) * (r.Top - c.Y) / (a.Y - b.Y);
                    c.Y = r.Top;
                }

                /* обновляем код */
                if (code == code_a)
                {
                    a = c;
                    code_a = PointCode(r, a);
                }
                else
                {
                    b = c;
                    code_b = PointCode(r, b);
                }
            }
            /* оба кода равны 0, следовательно обе точки в прямоугольнике */
            BrezenkhemAlgoritmLine(a.X, a.Y, b.X, b.Y);
            return 0;
        }// Отсечение отрезка

        private void Form1_MouseDown(object sender, MouseEventArgs e)
                {
                    startPoint.X = e.X;
                    startPoint.Y = e.Y;
                    //Cursor.Clip = this.RectangleToScreen(this.ClientRectangle);
                }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor.Clip = new Rectangle();
            if (this.lineButton.Checked)
            {
                //DigitalDifferencialAnalizator(startPoint.X, startPoint.Y, e.X, e.Y);
                BrezenkhemAlgoritmLine(startPoint.X, startPoint.Y, e.X, e.Y);
            }
            if (this.circleButton.Checked)
            {
                BrezenkhemAlgoritmCircle(new Point(startPoint.X, startPoint.Y), (int)Math.Sqrt(Math.Pow(e.X - startPoint.X, 2) + Math.Pow(e.Y - startPoint.Y, 2)));
            }
            if (this.bezierButton.Checked)
            {
                if (pointList.Count == 10)// Максимум 10 точек
                    return;
                pointList.Add(new PointF(e.X, e.Y));
                DecasteldjoAlgoritmBusier();
            }
            if (this.cutterButton.Checked)
            {
                // Алгоритм Коэна-Сазерленда
                cohen_sutherland(rect, new Point(startPoint.X, startPoint.Y), new Point(e.X, e.Y));

                // Алгоритм Кируса-Бека
                //Polygon pol = new Polygon();
                //pol.Add(new PointF(rect.Right, rect.Top));
                //pol.Add(new PointF(rect.Right, rect.Bottom));
                //pol.Add(new PointF(rect.Left, rect.Bottom));
                //pol.Add(new PointF(rect.Left, rect.Top));
                //Segment seg = new Segment(new PointF(startPoint.X, startPoint.Y), new PointF(e.X, e.Y));
                //if (pol.CyrusBeckClip(ref seg))
                //    BrezenkhemAlgoritmLine((int)seg.A.X, (int)seg.A.Y, (int)seg.B.X, (int)seg.B.Y);

                // Алгоритм средней точки
                //MidpointAlgorithm(startPoint, new Point(e.X,e.Y));
            }

        }

        void MidpointAlgorithm(Point a, Point b)
        {
            if (Math.Sqrt((b.X - a.X) * (b.X - a.X) + (b.Y - a.Y) * (b.Y - a.Y)) < 2)
                return;
            int code_a = PointCode(rect, a);
            int code_b = PointCode(rect, b);
            if ((code_a & code_b) != 0)
                return;
            if ((code_a | code_b) == 0)//AB лежит внутри отсекающего прямоугольника
            {
                BrezenkhemAlgoritmLine(a.X,a.Y,b.X,b.Y);
                return;
            }
            MidpointAlgorithm(a, new Point((a.X+b.X)/2,(a.Y+b.Y)/2));
            MidpointAlgorithm(new Point((a.X + b.X) / 2, (a.Y + b.Y) / 2), b);
        }// Алгоритм средней точки отсечения отрезка

        private void LineButton_Click(object sender, EventArgs e)
        {
            if (this.lineButton.Checked)
            {
                this.circleButton.Checked = false;
                this.bezierButton.Checked = false;
                this.cutterButton.Checked = false;
            }
        }

        private void CircleButton_Click(object sender, EventArgs e)
        {
            if (this.circleButton.Checked)
            {
                this.lineButton.Checked = false;
                this.bezierButton.Checked = false;
                this.cutterButton.Checked = false;
            }
        }

        private void BezierButton_Click(object sender, EventArgs e)
        {
            if (this.bezierButton.Checked)
            {
                this.lineButton.Checked = false;
                this.circleButton.Checked = false;
                this.cutterButton.Checked = false;
            }
        }

        private void ColorButton_Click(object sender, EventArgs e)
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

        private void CutterButton_Click(object sender, EventArgs e)
        {
            if (this.cutterButton.Checked)
            {
                this.lineButton.Checked = false;
                this.circleButton.Checked = false;
                this.bezierButton.Checked = false;
            }
        }
    }

    public struct Segment
    {
        public readonly PointF A, B;

        public Segment(PointF a, PointF b)
        {
            A = a;
            B = b;
        }

        public bool OnLeft(PointF p)
        {
            var ab = new PointF(B.X - A.X, B.Y - A.Y);
            var ap = new PointF(p.X - A.X, p.Y - A.Y);
            return ab.Cross(ap) >= 0;
        }

        public PointF Normal {
            get {
                return new PointF(B.Y - A.Y, A.X - B.X);
            }
        }

        public PointF Direction {
            get {
                return new PointF(B.X - A.X, B.Y - A.Y);
            }
        }

        public float IntersectionParameter(Segment that)
        {
            var segment = this;
            var edge = that;

            var segmentToEdge = edge.A.Sub(segment.A);
            var segmentDir = segment.Direction;
            var edgeDir = edge.Direction;

            var t = edgeDir.Cross(segmentToEdge) / edgeDir.Cross(segmentDir);

            if (float.IsNaN(t))
            {
                t = 0;
            }

            return t;
        }

        public Segment Morph(float tA, float tB)
        {
            var d = Direction;
            return new Segment(A.Add(d.Mul(tA)), A.Add(d.Mul(tB)));
        }
    }

    public class Polygon : List<PointF>
    {
        public Polygon()
            : base()
        { }

        public Polygon(int capacity)
            : base(capacity)
        { }

        public Polygon(IEnumerable<PointF> collection)
            : base(collection)
        { }

        public bool IsConvex {
            get {
                if (Count >= 3)
                {
                    for (int a = Count - 2, b = Count - 1, c = 0; c < Count; a = b, b = c, ++c)
                    {
                        if (!new Segment(this[a], this[b]).OnLeft(this[c]))
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
        }

        public IEnumerable<Segment> Edges {
            get {
                if (Count >= 2)
                {
                    for (int a = Count - 1, b = 0; b < Count; a = b, ++b)
                    {
                        yield return new Segment(this[a], this[b]);
                    }
                }
            }
        }

        public bool CyrusBeckClip(ref Segment subject)// Алгоритм Кируса-Бека
        {
            var subjDir = subject.Direction;
            var tA = 0.0f;
            var tB = 1.0f;
            foreach (var edge in Edges)
            {
                switch (Math.Sign(edge.Normal.Dot(subjDir)))
                {
                    case -1:
                        {
                            var t = subject.IntersectionParameter(edge);
                            if (t > tA)
                            {
                                tA = t;
                            }
                            break;
                        }
                    case +1:
                        {
                            var t = subject.IntersectionParameter(edge);
                            if (t < tB)
                            {
                                tB = t;
                            }
                            break;
                        }
                    case 0:
                        {
                            if (!edge.OnLeft(subject.A))
                            {
                                return false;
                            }
                            break;
                        }
                }
            }
            if (tA > tB)
            {
                return false;
            }
            subject = subject.Morph(tA, tB);
            return true;
        }
    }

    public static class PointExtensions
    {
        public static PointF Add(this PointF a, PointF b)
        {
            return new PointF(a.X + b.X, a.Y + b.Y);
        }

        public static PointF Sub(this PointF a, PointF b)
        {
            return new PointF(a.X - b.X, a.Y - b.Y);
        }

        public static PointF Mul(this PointF a, float b)
        {
            return new PointF(a.X * b, a.Y * b);
        }

        public static float Dot(this PointF a, PointF b)
        {
            return a.X * b.X + a.Y * b.Y;
        }

        public static float Cross(this PointF a, PointF b)
        {
            return a.X * b.Y - a.Y * b.X;
        }
    }
}
