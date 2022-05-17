using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FractalMaker
{
    class FractalTree : Fractal
    {
        // Коэфициент отношения отрезков.
        private float kof;
        // Углы поворотов.
        private float degLeft;
        private float degRight;

        float DegreeLeft
        {
            get { return degLeft; }
            set
            {
                if (value < (Math.PI / 2) && value > float.Epsilon)
                {
                    degLeft = value;
                }
            }
        }
        float DegreeRight
        {
            get { return degRight; }
            set
            {
                if (value < (Math.PI / 2) && value > float.Epsilon)
                {
                    degRight = value;
                }
            }
        }
        float Kof
        {
            get { return kof; }
            set
            {
                if (value < 1 && value > 0.1)
                {
                    kof = value;
                }
            }
        }


        public FractalTree() : base(0, 0, new PictureBox(), new Bitmap(1, 1), Color.Black, Color.Black)
        {

        }

        // Универсальный конструктор + коэффициент и два угла.
        public FractalTree(int maxC, float maxL, float k, float degL, float degR, PictureBox pb, Bitmap bitmap, Color c1, Color c2)
            : base(maxC, maxL, pb, bitmap, c1, c2)
        {
            Kof = k;
            DegreeLeft = degL;
            DegreeRight = degR;
        }

        public float angle = (float)Math.PI / 2; //Угол поворота (90 градусов).
        /// <summary>
        /// Рекурсивный метод.
        /// </summary>
        /// <param name="point">Точка начала.</param>
        /// <param name="length">Максимальная длина отрезка.</param>
        public void MakeRecursion(PointF point, float length)
        {
            using (graphics = Graphics.FromImage(Bitmap))
            {
                graphics.Clear(Color.White);
                Pen.Color = colors[0];
                DrawTree(point, angle, length, 0);
            }
        }

        /// <summary>
        /// Метод отрисовки
        /// </summary>
        /// <param name="point">Текущая точка.</param>
        /// <param name="angle">Текущий угол отклонения.</param>
        /// <param name="length">Текущая длина.</param>
        /// <param name="rec">Текущая глубина.</param>
        public void DrawTree(PointF point, float angle, float length, int rec)
        {
            if (length < 2 || rec == MaxCount)
                return;

            length *= Kof;
            try
            {
                Pen.Color = colors[rec];
                if (rec == MaxCount-1)
                    Pen.Color = colors[colors.Count-1];
            }
            catch (Exception) { }
            rec++;


            float xnew = (float)Math.Round(point.X + length * Math.Cos(angle));
            float ynew = (float)Math.Round(point.Y - length * Math.Sin(angle));

            graphics.DrawLine(Pen, new PointF(point.X, point.Y), new PointF(xnew, ynew));

            point.X = xnew;
            point.Y = ynew;

            DrawTree(point, angle + degLeft, length, rec);
            DrawTree(point, angle - degRight, length, rec);

        }
    }
}
