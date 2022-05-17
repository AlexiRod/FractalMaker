using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FractalMaker
{
    class FractalTriangle : Fractal
    {
        public FractalTriangle() : base(0, 0, new PictureBox(), new Bitmap(1, 1), Color.Black, Color.Black)
        {
        }

        // Универсальный конструктор
        public FractalTriangle(int maxC, float maxL, PictureBox pb, Bitmap bitmap, Color c1, Color c2)
            : base(maxC, maxL, pb, bitmap, c1, c2)
        {
        }

        /// <summary>
        /// Рекурсивный метод
        /// </summary>
        /// <param name="point1">Первая точка треугольника.</param>
        /// <param name="point2">Вторая точка треугольника.</param>
        /// <param name="point3">Третья точка треугольника.</param>
        public void MakeRecursion(PointF point1, PointF point2, PointF point3)
        {
            using (graphics = Graphics.FromImage(Bitmap))
            {
                graphics.Clear(Color.White);

                DrawTriangle(point1, point2, point3, 1);
            }
        }

        /// <summary>
        /// Метод для отрисовки
        /// </summary>
        /// <param name="point1">Первая точка треугольника.</param>
        /// <param name="point2">Вторая точка треугольника.</param>
        /// <param name="point3">Третья точка треугольника.</param>
        /// <param name="rec">Текущая глубина.</param>
        public void DrawTriangle(PointF point1, PointF point2, PointF point3, int rec)
        {

            if (rec > MaxCount)
                return;


            if (rec == 1)
            {
                Pen.Color = colors[0];
                graphics.Clear(Color.White);

                Triangle(point1, point2, point3);
                DrawTriangle(FindMiddle(point1, point2), FindMiddle(point3, point2), point2, rec + 1);
                DrawTriangle(FindMiddle(point1, point2), FindMiddle(point3, point1), point1, rec + 1);
                DrawTriangle(FindMiddle(point1, point3), FindMiddle(point3, point2), point3, rec + 1);
                return;
            }

            try
            {
                Pen.Color = colors[rec];
                if (rec == MaxCount)
                    Pen.Color = colors[colors.Count - 1];
            }
            catch (Exception) { }

            Triangle(point1, point2, point3);
            DrawTriangle(FindMiddle(point1, point2), FindMiddle(point3, point2), point2, rec + 1);
            DrawTriangle(FindMiddle(point1, point2), FindMiddle(point3, point1), point1, rec + 1);
            DrawTriangle(FindMiddle(point1, point3), FindMiddle(point3, point2), point3, rec + 1);
        }

        public void Triangle(PointF point1, PointF point2, PointF point3)
        {
            graphics.DrawLine(Pen, point1, point2);
            graphics.DrawLine(Pen, point3, point2);
            graphics.DrawLine(Pen, point1, point3);
        }

        public PointF FindMiddle(PointF p1, PointF p2)
        {
            return new PointF((p2.X + p1.X) / 2, (p2.Y + p1.Y) / 2);
        }
    }
}

