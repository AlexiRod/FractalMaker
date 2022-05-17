using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FractalMaker
{
    class FractalSet : Fractal
    {
        // Отступ между линиями (равен высоте этих линий)
        float Indent { get; set; }
        // Ручка для удаления элементов.
        Pen PenToFill { get; set; }
        public FractalSet() : base(0, 0, new PictureBox(), new Bitmap(1, 1), Color.Black, Color.Black)
        {
            Indent = 20;
            PenToFill = new Pen(Color.White, Pen.Width);
        }

        // Универсальный конструктор + отступ.
        public FractalSet(int maxC, float maxL, float indent, PictureBox pb, Bitmap bitmap, Color c1, Color c2)
            : base(maxC, maxL, pb, bitmap, c1, c2)
        {
            Indent = indent;
            PenToFill = new Pen(Color.White, Pen.Width);
        }

        /// <summary>
        /// Рекурсивный метод.
        /// </summary>
        /// <param name="point1">Первая точка линии (Верхняя левая).</param>
        /// <param name="point2">Вторая точка линии (Нижняя правая).</param>
        public void MakeRecursion(PointF point1, PointF point2)
        {
            using (graphics = Graphics.FromImage(Bitmap))
            {
                graphics.Clear(Color.White);

                DrawSet(point1, point2, 1);
            }
        }

        /// <summary>
        /// Метод для отрисовки.
        /// </summary>
        /// <param name="point1">Первая точка линии (Верхняя левая).</param>
        /// <param name="point2">Вторая точка линии (Нижняя правая).</param>
        /// <param name="rec">Текущая глубина.</param>
        public void DrawSet(PointF point1, PointF point2, int rec)
        {
            float len = Math.Abs(point2.X - point1.X);
            PointF p1 = new PointF(point1.X + len/3, point1.Y);
            PointF p11 = new PointF(point1.X + len/3, point2.Y);
            PointF p2 = new PointF(point1.X + len*2/3, point1.Y);
            PointF p21 = new PointF(point1.X + len*2/3, point2.Y);


            if (rec > MaxCount)
                return;

            try
            { Pen.Color = colors[rec]; }
            catch (Exception) { }

            if (rec == 1)
            {
                Pen.Color = colors[0];
                graphics.Clear(Color.White);
            }
            if (rec == MaxCount)
                Pen.Color = colors[colors.Count - 1];
            

            graphics.FillRectangle(Pen.Brush, new Rectangle((int)point1.X, (int)point1.Y, (int)(point2.X - point1.X), (int)Indent/2));
            graphics.FillRectangle(PenToFill.Brush, new Rectangle((int)p1.X, (int)p1.Y, (int)(p21.X - p1.X), (int)Indent/2));
            DrawSet(new PointF(point1.X, p11.Y + Indent), new PointF(p11.X, p11.Y + 2*Indent), rec + 1);
            DrawSet(new PointF(p2.X, p21.Y + Indent), new PointF(point2.X, point2.Y + 2*Indent), rec + 1);

        }
    }
}
