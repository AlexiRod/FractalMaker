using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace FractalMaker
{
    public class Fractal
    {
        // Глубина рекурсии.
        public int MaxCount { get; set; }
        // Длина отрезка (для некоторых фракталов).
        public float MaxLength { get; set; }
        protected Pen Pen { get; set; }
        protected PictureBox PictureBox { get; set; }
        protected Bitmap Bitmap { get; set; }

        protected static Graphics graphics;
        // Цвета градиента.
        protected List<Color> colors = new List<Color>();

        /// <summary>
        /// Универсальный конструктор.
        /// </summary>
        /// <param name="maxC">Глубина рекурсии.</param>
        /// <param name="maxL">Длина отрезка.</param>
        /// <param name="pb">PictureBox.</param>
        /// <param name="bitmap">Bitmap.</param>
        /// <param name="c1">Цвет градиента 1.</param>
        /// <param name="c2">Цвет градиента 2.</param>
        public Fractal(int maxC, float maxL, PictureBox pb, Bitmap bitmap, Color c1, Color c2)
        {
            MaxCount = maxC;
            MaxLength = maxL;
            PictureBox = pb;
            Pen = new Pen(Color.Black, 2);
            graphics = PictureBox.CreateGraphics();
            Bitmap = bitmap;

            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            if (MaxCount < 2)
            {
                colors.Add(c1);
                return;
            }

            int rMax = c2.R;
            int rMin = c1.R;
            int gMax = c2.G;
            int gMin = c1.G;
            int bMax = c2.B;
            int bMin = c1.B;
            
            for (int i = 0; i <= MaxCount; i++)
            {
                var rAverage = rMin + (int)((rMax - rMin) * i / MaxCount);
                var gAverage = gMin + (int)((gMax - gMin) * i / MaxCount);
                var bAverage = bMin + (int)((bMax - bMin) * i / MaxCount);
                colors.Add(Color.FromArgb(rAverage, gAverage, bAverage));
            }
        }

        /// <summary>
        /// Метод для переопределения.
        /// </summary>
        public virtual void Recursion()
        {

        }

    }
}
