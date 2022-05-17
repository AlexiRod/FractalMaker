using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FractalMaker
{
    class FractalCarpet : Fractal
    {
        // Ручка для удаления элементов.
        Pen PenToFill { get; set; }
        public FractalCarpet() : base(0, 0, new PictureBox(), new Bitmap(1, 1), Color.Black, Color.Black)
        {
            PenToFill = new Pen(Color.White, Pen.Width);
        }

        // Универсальный конструктор.
        public FractalCarpet(int maxC, float maxL, PictureBox pb, Bitmap bitmap, Color c1, Color c2)
            : base(maxC, maxL, pb, bitmap, c1, c2)
        {
            PenToFill = new Pen(Color.White, Pen.Width);
        }

        /// <summary>
        /// Рекурсивный метод.
        /// </summary>
        /// <param name="point">Верхняя левая точка квадрата.</param>
        /// <param name="side">Сторона квадрата.</param>
        public void MakeRecursion(PointF point, float side)
        {
            using (graphics = Graphics.FromImage(Bitmap))
            {
                graphics.Clear(Color.White);

                DrawCarpet(point, side, 1);
            }
        }

        /// <summary>
        /// Метод для отрисовки.
        /// </summary>
        /// <param name="point">Верхняя левая точка квадрата.</param>
        /// <param name="side">Сторона квадрата.</param>
        /// <param name="rec">Текущая глубина.</param>
        public void DrawCarpet(PointF point, float side, int rec)
        {
            if (rec > MaxCount || side < 2)
                return;

            try
            { Pen.Color = colors[rec]; }
            catch (Exception) { }

            if (rec == 1)
            {
                Pen.Color = colors[0];
                graphics.Clear(Color.White);
                graphics.FillRectangle(Pen.Brush, point.X, point.Y, side, side);
                DrawCarpet(point, side, rec+1);
            }

            float side2 = side / 3;
            PointF point2 = new PointF(point.X + side2, point.Y + side2);

            for (int i = 0; i < colors.Count; i++)
            {
                Pen = new Pen(colors[colors.Count - 1 - i], Pen.Width);
                graphics.FillRectangle(Pen.Brush, point.X, point.Y + side*i / colors.Count, side, side / colors.Count);
            }
            graphics.FillRectangle(PenToFill.Brush, point2.X, point2.Y, side2, side2);

            float x = point.X, y = point.Y;
            DrawCarpet(new PointF(x, y), side2, rec + 1);
            DrawCarpet(new PointF(x + side2, y), side2, rec + 1);
            DrawCarpet(new PointF(x + side2*2, y), side2, rec + 1);
            DrawCarpet(new PointF(x, y + side2), side2, rec + 1);
            DrawCarpet(new PointF(x + side2*2, y + side2), side2, rec + 1);
            DrawCarpet(new PointF(x, y + side2*2), side2, rec + 1);
            DrawCarpet(new PointF(x + side2, y + side2*2), side2, rec + 1);
            DrawCarpet(new PointF(x + side2*2, y + side2*2), side2, rec + 1);
        }
    }
}
