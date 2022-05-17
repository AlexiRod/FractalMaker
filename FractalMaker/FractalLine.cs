using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FractalMaker
{
    class FractalLine : Fractal
    {
        // Ручка для удаления (с цветом фона).
        Pen PenToFill { get; set; }

        public FractalLine() : base(0, 0, new PictureBox(), new Bitmap(1, 1), Color.Black, Color.Black)
        {
            PenToFill = new Pen(Color.White, Pen.Width);
        }

        // Универсальный конструктор.
        public FractalLine(int maxC, float maxL, PictureBox pb, Bitmap bitmap, Color c1, Color c2)
            : base(maxC, maxL, pb, bitmap, c1, c2)
        {
            PenToFill = new Pen(Color.White, Pen.Width);
        }

        /// <summary>
        /// Рекурсивный метод.
        /// </summary>
        /// <param name="point1">Точка начала отрезка.</param>
        /// <param name="point2">Точка конца отрезка.</param>
        /// <param name="rec">Глубина рекурсии.</param>
        public void MakeRecursion(PointF point1, PointF point2, int rec)
        {
            using (graphics = Graphics.FromImage(Bitmap))
            {
                graphics.Clear(Color.White);

                PointF point3 = new PointF(point1.X + (point2.X - point1.X) / 2, point1.Y + (point2.X - point1.X) * (float)Math.Sqrt(3) / 2);
                DrawLine(point1, point2, point3, rec + 1);
            }
        }


        /// <summary>
        /// Метод отрисовки.
        /// </summary>
        /// <param name="p1">Текущая первая точка.</param>
        /// <param name="p2">Текущая вторая точка.</param>
        /// <param name="p3">Текущая вспомогательная точка.</param>
        /// <param name="rec">Текущая глубина.</param>
        public void DrawLine(PointF p1, PointF p2, PointF p3, int rec)
        {
            if (Math.Abs(p1.X - p2.X) < 2 || Math.Abs(p1.X - p3.X) < 2 || Math.Abs(p3.X - p2.X) < 2)
                return;

            if (rec == MaxCount + 1)
            {
                Pen.Color = colors[0];
                graphics.Clear(Color.White);
                graphics.DrawLine(Pen, p1, p2);
                DrawLine(p1, p2, p3, rec - 1);

            }
            else if (rec >= 1)
            {
                try
                { Pen.Color = colors[rec]; }
                catch (Exception) { }

                PointF p4 = new PointF((p2.X + 2 * p1.X) / 3, (p2.Y + 2 * p1.Y) / 3);
                PointF p5 = new PointF((2 * p2.X + p1.X) / 3, (2 * p2.Y + p1.Y) / 3);
                PointF p6 = new PointF((p2.X + p1.X) / 2, (p2.Y + p1.Y) / 2);
                PointF p7 = new PointF((4 * p6.X - p3.X) / 3, (4 * p6.Y - p3.Y) / 3);
                graphics.DrawLine(Pen, p4, p7);
                graphics.DrawLine(Pen, p5, p7);
                graphics.DrawLine(PenToFill, p4, p5);

                DrawLine(p4, p7, p5, rec - 1);
                DrawLine(p7, p5, p4, rec - 1);

                DrawLine(p1, p4, new PointF((2 * p1.X + p3.X) / 3, (2 * p1.Y + p3.Y) / 3), rec - 1);
                DrawLine(p5, p2, new PointF((2 * p2.X + p3.X) / 3, (2 * p2.Y + p3.Y) / 3), rec - 1);
            }
        }
    }
}
