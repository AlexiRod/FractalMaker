using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FractalMaker
{
    public partial class FractalForm : Form
    {

        #region Базовые настройки

        public FractalForm()
        {
            InitializeComponent();
        }


        private Fractal fractal = new FractalTree();
        private int baseW, baseH, count;
        private Color c1, c2;
        private float deg1, deg2, kof = 0.7f;
        private string pathToImage = "-";

        private List<Color> colors = new List<Color>() { Color.Blue, Color.Red, Color.Yellow, Color.Green,
            Color.Lime, Color.Magenta,  Color.YellowGreen, Color.Cyan, Color.Chocolate, Color.Purple, Color.Gray, Color.Black };


        private void FractalForm_Load(object sender, EventArgs e)
        {
            foreach (var color in colors)
            {
                cBoxColor1.Items.Add(color);
                cBoxColor2.Items.Add(color);
            }
            cBoxColor1.SelectedIndex = 0;
            cBoxColor2.SelectedIndex = 1;
            trackBarDeg1.Value = 3;
            trackBarDeg2.Value = 3;
            deg1 = (float)Math.PI * trackBarDeg1.Value / 12;
            deg2 = (float)Math.PI * trackBarDeg2.Value / 12;
            cBoxFormat.SelectedIndex = 0;
            cBoxFractal.SelectedIndex = 0;
            baseW = pictureBox.Width;
            baseH = pictureBox.Height;
            MinimumSize = Size;
            UpdateImage();
        }

        #endregion



        #region Отрисовка

        // Метод для перерисовки фрактала.
        private void UpdateImage()
        {
            try
            {
                if (pictureBox.Image != null)
                    pictureBox.Image.Dispose();
                int w = pictureBox.Width;
                int h = pictureBox.Height;

                Bitmap myBitmap = new Bitmap(w, h);
                using (Graphics g = Graphics.FromImage(myBitmap))
                {
                    g.Clear(Color.White);

                    if (fractal is FractalTree)
                    {
                        FractalTree fractalTree = new FractalTree(count, h / 3, kof, deg1, deg2, pictureBox, myBitmap, c1, c2);
                        fractalTree.MakeRecursion(new Point(w / 2, (int)(h * 0.96)), fractalTree.MaxLength);
                    }
                    if (fractal is FractalLine)
                    {
                        FractalLine fractalLine = new FractalLine(count, h / 3, pictureBox, myBitmap, c1, c2);
                        fractalLine.MakeRecursion(new Point((int)(w * 0.05), (int)(h * 0.96)), new Point((int)(w * 0.95), (int)(h * 0.96)), fractalLine.MaxCount);
                    }
                    if (fractal is FractalCarpet)
                    {
                        float side = Math.Min(pictureBox.Height, pictureBox.Width) * 0.95f;
                        FractalCarpet fractalCarpet = new FractalCarpet(count, side, pictureBox, myBitmap, c1, c2);
                        side = Math.Min(pictureBox.Height, pictureBox.Width) * 0.95f - Math.Min(pictureBox.Height, pictureBox.Width) * 0.05f;
                        fractalCarpet.MakeRecursion(new PointF(pictureBox.Width * 0.05f, pictureBox.Height * 0.05f), side);
                    }
                    if (fractal is FractalTriangle)
                    {
                        float side = Math.Min(pictureBox.Height, pictureBox.Width) * 0.95f;
                        FractalTriangle fractalTriangle = new FractalTriangle(count, side, pictureBox, myBitmap, c1, c2);

                        PointF p1 = new PointF(pictureBox.Width * 0.05f, pictureBox.Height * 0.95f);
                        PointF p2 = new PointF(pictureBox.Width * 0.95f, pictureBox.Height * 0.95f);
                        PointF p3 = new PointF(p1.X + (p2.X - p1.X) / 2, p1.Y - (p2.X - p1.X) * (float)Math.Sqrt(3) / 2);

                        fractalTriangle.MakeRecursion(p1, p2, p3);
                    }
                    if (fractal is FractalSet)
                    {

                        FractalSet fractalSet = new FractalSet(count, 0, kof, pictureBox, myBitmap, c1, c2);

                        PointF p1 = new PointF(pictureBox.Width * 0.05f, pictureBox.Height * 0.05f);
                        PointF p2 = new PointF(pictureBox.Width * 0.95f, pictureBox.Height * 0.05f + kof);

                        fractalSet.MakeRecursion(p1, p2);
                    }
                }

                myBitmap.Save("test.bmp");
                pictureBox.Image = Image.FromFile("test.bmp");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла ошибка при работе с программой. Перезапустите ее и попробуйте снова: " + ex.Message, "Внимание!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtBoxRec.Text, out count) || count < 1 || count > 15)
                {
                    MessageBox.Show("Глубина рекурсии должна быть целым числом в диапозоне [1; 15].\nУчтите также, что при большой " +
                        "глубине есть шанс долгой работы программы.", "Неверный ввод.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!(fractal is FractalSet) && txtBoxKof.Visible)
                {
                    if (!float.TryParse(txtBoxKof.Text, out kof) || kof < 0.1 || kof > 0.9)
                    {
                        MessageBox.Show("Отношение отрезков на двух последующих иттерациях рекурсии должно быть числом из диапозона [0,1; 0,9].",
                            "Неверный ввод.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else if ((!float.TryParse(txtBoxKof.Text, out kof) || kof < 10 || kof > 100) && txtBoxKof.Visible)
                {
                    MessageBox.Show("Расстояние между отрезками на двух последующих иттерациях рекурсии должно быть числом из диапозона [10; 100]." +
                        " Учтите также, что при определенных значениях расстояния последние линии множества могут вылезать за границы холста.",
                        "Неверный ввод.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                btnDraw.Text = "Идет отрисовка...";
                btnDraw.Enabled = false;
                UpdateImage();
                btnDraw.Text = "Нарисовать";
                btnDraw.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла ошибка при работе с программой. Перезапустите ее и попробуйте снова: " + ex.Message, "Внимание!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void cBoxFractal_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cBoxFractal.SelectedIndex)
            {
                default:
                case 0:
                    fractal = new FractalTree();
                    trackBarDeg1.Value = 3;
                    trackBarDeg2.Value = 3;
                    deg1 = (float)Math.PI * trackBarDeg1.Value / 12;
                    deg2 = (float)Math.PI * trackBarDeg2.Value / 12;
                    lblKof.Visible = true;
                    txtBoxKof.Visible = true;
                    lblKof.Text = "Отношение отрезков:";
                    txtBoxKof.Text = "0,7";
                    ChangeVisibleOfDegrees(false);
                    break;

                case 1:
                    fractal = new FractalTree();
                    ChangeVisibleOfDegrees(true);
                    lblKof.Visible = true;
                    txtBoxKof.Visible = true;
                    lblKof.Text = "Отношение отрезков:";
                    txtBoxKof.Text = "0,7";
                    break;

                case 2:
                    fractal = new FractalLine();
                    ChangeVisibleOfDegrees(false);
                    lblKof.Visible = false;
                    txtBoxKof.Visible = false;
                    break;
                case 3:
                    fractal = new FractalCarpet();
                    ChangeVisibleOfDegrees(false);
                    lblKof.Visible = false;
                    txtBoxKof.Visible = false;
                    break;
                case 4:
                    fractal = new FractalTriangle();
                    ChangeVisibleOfDegrees(false);
                    lblKof.Visible = false;
                    txtBoxKof.Visible = false;
                    break;
                case 5:
                    fractal = new FractalSet();
                    ChangeVisibleOfDegrees(false);
                    lblKof.Visible = true;
                    txtBoxKof.Visible = true;
                    lblKof.Text = "Расстояние (в пкс):";
                    txtBoxKof.Text = "20";
                    break;
            }
        }

        // Изменение видимости нескольких элементов формы.
        private void ChangeVisibleOfDegrees(bool value)
        {
            trackBarDeg1.Visible = value;
            trackBarDeg2.Visible = value;
            lblDeg1.Visible = value;
            lblDeg2.Visible = value;
            lblDeg3.Visible = value;
            lblDeg4.Visible = value;
            lblDeg5.Visible = value;
            lblDegLeft.Visible = value;
            lblDegRight.Visible = value;
        }

        #endregion



        #region Сохранение изображения

        private void btnFolder_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dialog = new FolderBrowserDialog())
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        pathToImage = dialog.SelectedPath;
                        txtBoxDirectory.Text = pathToImage;
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при работе с проводником! " + ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(pathToImage))
                {
                    if (txtBoxImageName.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Введите название файла в соответствующее окно.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    Image myImg = pictureBox.Image;
                    string path = Path.Combine(pathToImage, txtBoxImageName.Text.Trim() + cBoxFormat.SelectedItem.ToString());
                    myImg.Save(path);
                    MessageBox.Show("Файл успешно сохранен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else MessageBox.Show("Указанная директория задана неверно.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при работе с файлом! " + ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion



        #region Управление элементами

        private void pictureBox_DoubleClick(object sender, EventArgs e)
        {
            this.HorizontalScroll.Value = Cursor.Position.X;
            this.VerticalScroll.Value = Cursor.Position.Y;
        }
        private void trackBarZoom_Scroll(object sender, EventArgs e)
        {
            pictureBox.Width = baseW * trackBarZoom.Value;
            pictureBox.Height = baseH * trackBarZoom.Value;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приветствую в создателе фракталов! Здесь можно построить один из предложенных фракталов, а также задать для него " +
                "параметры. Для дополнительного выделения можно выбрать два цвета, в которые градиентным способом будут окрашиваться части" +
                " фрактала на разных иттерациях. Для того, чтобы рассмотреть изображение получше, можно поменять размер картинки, а затем " +
                "заново нажать кнопку \"Нарисовать\" - тогда оно перерисуется в другом масштабе. Для сохранения изображения необходимо указать " +
                "директорию, название и формат файла. Учтите, что из-за определенных параметров (например, глубина рекурсии или отношение отрезков)" +
                " программа может работать долго, а также фрактал может не помещаться в границы картинки, так как программа спецаильно разработана " +
                "так, чтобы построение происходило исходя из размеров и положения картинки. Для более удобной работы форму можно развернуть на полный " +
                "экран. При двойном нажатии на нее курсором, полосы прокрутки перместятся в соответствующую точку (знаю, что реализовано криво).",
                "Справка", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void trackBarDeg1_Scroll(object sender, EventArgs e)
        {
            deg1 = (float)Math.PI * trackBarDeg1.Value / 12;
        }
        private void trackBarDeg2_Scroll(object sender, EventArgs e)
        {
            deg2 = (float)Math.PI * trackBarDeg2.Value / 12;
        }

        private void cBoxColor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1 = (Color)cBoxColor1.SelectedItem;
        }

        private void cBoxColor2_SelectedIndexChanged(object sender, EventArgs e)
        {
            c2 = (Color)cBoxColor2.SelectedItem;
        }

        private void FractalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (pictureBox.Image != null)
                pictureBox.Image.Dispose();
        }

        #endregion

    }
}
