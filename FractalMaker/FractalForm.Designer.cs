namespace FractalMaker
{
    partial class FractalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.trackBarZoom = new System.Windows.Forms.TrackBar();
            this.txtBoxRec = new System.Windows.Forms.TextBox();
            this.lblRec = new System.Windows.Forms.Label();
            this.lblZoom = new System.Windows.Forms.Label();
            this.lbl1x = new System.Windows.Forms.Label();
            this.lbl2x = new System.Windows.Forms.Label();
            this.lbl3x = new System.Windows.Forms.Label();
            this.lbl4x = new System.Windows.Forms.Label();
            this.lbl5x = new System.Windows.Forms.Label();
            this.btnFolder = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.txtBoxImageName = new System.Windows.Forms.TextBox();
            this.lblImageSave = new System.Windows.Forms.Label();
            this.txtBoxDirectory = new System.Windows.Forms.TextBox();
            this.lblDirectory = new System.Windows.Forms.Label();
            this.lblFormat = new System.Windows.Forms.Label();
            this.cBoxFormat = new System.Windows.Forms.ComboBox();
            this.cBoxFractal = new System.Windows.Forms.ComboBox();
            this.lblFractal = new System.Windows.Forms.Label();
            this.lblColor1 = new System.Windows.Forms.Label();
            this.cBoxColor1 = new System.Windows.Forms.ComboBox();
            this.lblColor2 = new System.Windows.Forms.Label();
            this.cBoxColor2 = new System.Windows.Forms.ComboBox();
            this.trackBarDeg1 = new System.Windows.Forms.TrackBar();
            this.trackBarDeg2 = new System.Windows.Forms.TrackBar();
            this.lblDeg1 = new System.Windows.Forms.Label();
            this.lblDeg2 = new System.Windows.Forms.Label();
            this.lblDeg3 = new System.Windows.Forms.Label();
            this.lblDeg4 = new System.Windows.Forms.Label();
            this.lblDeg5 = new System.Windows.Forms.Label();
            this.lblDegLeft = new System.Windows.Forms.Label();
            this.lblDegRight = new System.Windows.Forms.Label();
            this.lblKof = new System.Windows.Forms.Label();
            this.txtBoxKof = new System.Windows.Forms.TextBox();
            this.panelFrac = new System.Windows.Forms.Panel();
            this.panelColor = new System.Windows.Forms.Panel();
            this.panelImage = new System.Windows.Forms.Panel();
            this.panelZoom = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDeg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDeg2)).BeginInit();
            this.panelFrac.SuspendLayout();
            this.panelColor.SuspendLayout();
            this.panelImage.SuspendLayout();
            this.panelZoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(382, 51);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(700, 700);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.DoubleClick += new System.EventHandler(this.pictureBox_DoubleClick);
            // 
            // btnDraw
            // 
            this.btnDraw.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDraw.Location = new System.Drawing.Point(10, 706);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(366, 45);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "Нарисовать";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // trackBarZoom
            // 
            this.trackBarZoom.Location = new System.Drawing.Point(7, 30);
            this.trackBarZoom.Maximum = 5;
            this.trackBarZoom.Minimum = 1;
            this.trackBarZoom.Name = "trackBarZoom";
            this.trackBarZoom.Size = new System.Drawing.Size(356, 56);
            this.trackBarZoom.TabIndex = 2;
            this.trackBarZoom.Value = 1;
            this.trackBarZoom.Scroll += new System.EventHandler(this.trackBarZoom_Scroll);
            // 
            // txtBoxRec
            // 
            this.txtBoxRec.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxRec.Location = new System.Drawing.Point(175, 668);
            this.txtBoxRec.Name = "txtBoxRec";
            this.txtBoxRec.Size = new System.Drawing.Size(201, 31);
            this.txtBoxRec.TabIndex = 3;
            this.txtBoxRec.Text = "10";
            // 
            // lblRec
            // 
            this.lblRec.AutoSize = true;
            this.lblRec.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRec.Location = new System.Drawing.Point(9, 669);
            this.lblRec.Name = "lblRec";
            this.lblRec.Size = new System.Drawing.Size(163, 25);
            this.lblRec.TabIndex = 4;
            this.lblRec.Text = "Глубина рекурсии:";
            // 
            // lblZoom
            // 
            this.lblZoom.AutoSize = true;
            this.lblZoom.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblZoom.Location = new System.Drawing.Point(11, 2);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(183, 25);
            this.lblZoom.TabIndex = 4;
            this.lblZoom.Text = "Увеличение рисунка:";
            // 
            // lbl1x
            // 
            this.lbl1x.AutoSize = true;
            this.lbl1x.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl1x.Location = new System.Drawing.Point(10, 61);
            this.lbl1x.Name = "lbl1x";
            this.lbl1x.Size = new System.Drawing.Size(30, 25);
            this.lbl1x.TabIndex = 4;
            this.lbl1x.Text = "1x";
            // 
            // lbl2x
            // 
            this.lbl2x.AutoSize = true;
            this.lbl2x.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl2x.Location = new System.Drawing.Point(85, 61);
            this.lbl2x.Name = "lbl2x";
            this.lbl2x.Size = new System.Drawing.Size(30, 25);
            this.lbl2x.TabIndex = 4;
            this.lbl2x.Text = "2x";
            // 
            // lbl3x
            // 
            this.lbl3x.AutoSize = true;
            this.lbl3x.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl3x.Location = new System.Drawing.Point(168, 61);
            this.lbl3x.Name = "lbl3x";
            this.lbl3x.Size = new System.Drawing.Size(30, 25);
            this.lbl3x.TabIndex = 4;
            this.lbl3x.Text = "3x";
            // 
            // lbl4x
            // 
            this.lbl4x.AutoSize = true;
            this.lbl4x.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl4x.Location = new System.Drawing.Point(248, 61);
            this.lbl4x.Name = "lbl4x";
            this.lbl4x.Size = new System.Drawing.Size(30, 25);
            this.lbl4x.TabIndex = 4;
            this.lbl4x.Text = "4x";
            // 
            // lbl5x
            // 
            this.lbl5x.AutoSize = true;
            this.lbl5x.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl5x.Location = new System.Drawing.Point(329, 61);
            this.lbl5x.Name = "lbl5x";
            this.lbl5x.Size = new System.Drawing.Size(30, 25);
            this.lbl5x.TabIndex = 4;
            this.lbl5x.Text = "5x";
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(335, 397);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(35, 35);
            this.btnFolder.TabIndex = 5;
            this.btnFolder.Text = "...";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Location = new System.Drawing.Point(4, 110);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(357, 47);
            this.btnSaveImage.TabIndex = 6;
            this.btnSaveImage.Text = "Сохранить как изображение";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // txtBoxImageName
            // 
            this.txtBoxImageName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxImageName.Location = new System.Drawing.Point(106, 4);
            this.txtBoxImageName.Name = "txtBoxImageName";
            this.txtBoxImageName.Size = new System.Drawing.Size(213, 31);
            this.txtBoxImageName.TabIndex = 7;
            // 
            // lblImageSave
            // 
            this.lblImageSave.AutoSize = true;
            this.lblImageSave.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblImageSave.Location = new System.Drawing.Point(4, 7);
            this.lblImageSave.Name = "lblImageSave";
            this.lblImageSave.Size = new System.Drawing.Size(94, 25);
            this.lblImageSave.TabIndex = 4;
            this.lblImageSave.Text = "Название:";
            // 
            // txtBoxDirectory
            // 
            this.txtBoxDirectory.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxDirectory.Location = new System.Drawing.Point(122, 41);
            this.txtBoxDirectory.Name = "txtBoxDirectory";
            this.txtBoxDirectory.ReadOnly = true;
            this.txtBoxDirectory.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtBoxDirectory.Size = new System.Drawing.Size(238, 31);
            this.txtBoxDirectory.TabIndex = 7;
            this.txtBoxDirectory.Text = "-";
            // 
            // lblDirectory
            // 
            this.lblDirectory.AutoSize = true;
            this.lblDirectory.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDirectory.Location = new System.Drawing.Point(4, 44);
            this.lblDirectory.Name = "lblDirectory";
            this.lblDirectory.Size = new System.Drawing.Size(115, 25);
            this.lblDirectory.TabIndex = 4;
            this.lblDirectory.Text = "Директория:";
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFormat.Location = new System.Drawing.Point(4, 79);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(80, 25);
            this.lblFormat.TabIndex = 4;
            this.lblFormat.Text = "Формат:";
            // 
            // cBoxFormat
            // 
            this.cBoxFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxFormat.FormattingEnabled = true;
            this.cBoxFormat.Items.AddRange(new object[] {
            ".png",
            ".bmp",
            ".jpg",
            ".jpeg"});
            this.cBoxFormat.Location = new System.Drawing.Point(93, 78);
            this.cBoxFormat.Name = "cBoxFormat";
            this.cBoxFormat.Size = new System.Drawing.Size(267, 28);
            this.cBoxFormat.TabIndex = 8;
            // 
            // cBoxFractal
            // 
            this.cBoxFractal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxFractal.FormattingEnabled = true;
            this.cBoxFractal.Items.AddRange(new object[] {
            "Дерево Пифагора",
            "Обдуваемое дерево",
            "Кривая Коха",
            "Ковер Серпинского",
            "Треугольник Серпинского",
            "Множество Кантора"});
            this.cBoxFractal.Location = new System.Drawing.Point(93, 7);
            this.cBoxFractal.Name = "cBoxFractal";
            this.cBoxFractal.Size = new System.Drawing.Size(271, 28);
            this.cBoxFractal.TabIndex = 8;
            this.cBoxFractal.SelectedIndexChanged += new System.EventHandler(this.cBoxFractal_SelectedIndexChanged);
            // 
            // lblFractal
            // 
            this.lblFractal.AutoSize = true;
            this.lblFractal.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFractal.Location = new System.Drawing.Point(8, 8);
            this.lblFractal.Name = "lblFractal";
            this.lblFractal.Size = new System.Drawing.Size(83, 25);
            this.lblFractal.TabIndex = 4;
            this.lblFractal.Text = "Фрактал:";
            // 
            // lblColor1
            // 
            this.lblColor1.AutoSize = true;
            this.lblColor1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblColor1.Location = new System.Drawing.Point(5, 11);
            this.lblColor1.Name = "lblColor1";
            this.lblColor1.Size = new System.Drawing.Size(157, 25);
            this.lblColor1.TabIndex = 4;
            this.lblColor1.Text = "Цвет градиента 1:";
            // 
            // cBoxColor1
            // 
            this.cBoxColor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxColor1.FormattingEnabled = true;
            this.cBoxColor1.Location = new System.Drawing.Point(158, 10);
            this.cBoxColor1.Name = "cBoxColor1";
            this.cBoxColor1.Size = new System.Drawing.Size(203, 28);
            this.cBoxColor1.TabIndex = 8;
            this.cBoxColor1.SelectedIndexChanged += new System.EventHandler(this.cBoxColor1_SelectedIndexChanged);
            // 
            // lblColor2
            // 
            this.lblColor2.AutoSize = true;
            this.lblColor2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblColor2.Location = new System.Drawing.Point(5, 45);
            this.lblColor2.Name = "lblColor2";
            this.lblColor2.Size = new System.Drawing.Size(157, 25);
            this.lblColor2.TabIndex = 4;
            this.lblColor2.Text = "Цвет градиента 2:";
            // 
            // cBoxColor2
            // 
            this.cBoxColor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxColor2.FormattingEnabled = true;
            this.cBoxColor2.Location = new System.Drawing.Point(158, 44);
            this.cBoxColor2.Name = "cBoxColor2";
            this.cBoxColor2.Size = new System.Drawing.Size(203, 28);
            this.cBoxColor2.TabIndex = 8;
            this.cBoxColor2.SelectedIndexChanged += new System.EventHandler(this.cBoxColor2_SelectedIndexChanged);
            // 
            // trackBarDeg1
            // 
            this.trackBarDeg1.Location = new System.Drawing.Point(11, 119);
            this.trackBarDeg1.Maximum = 5;
            this.trackBarDeg1.Minimum = 1;
            this.trackBarDeg1.Name = "trackBarDeg1";
            this.trackBarDeg1.Size = new System.Drawing.Size(354, 56);
            this.trackBarDeg1.TabIndex = 2;
            this.trackBarDeg1.Value = 3;
            this.trackBarDeg1.Scroll += new System.EventHandler(this.trackBarDeg1_Scroll);
            // 
            // trackBarDeg2
            // 
            this.trackBarDeg2.Location = new System.Drawing.Point(11, 173);
            this.trackBarDeg2.Maximum = 5;
            this.trackBarDeg2.Minimum = 1;
            this.trackBarDeg2.Name = "trackBarDeg2";
            this.trackBarDeg2.Size = new System.Drawing.Size(354, 56);
            this.trackBarDeg2.TabIndex = 2;
            this.trackBarDeg2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarDeg2.Value = 3;
            this.trackBarDeg2.Scroll += new System.EventHandler(this.trackBarDeg2_Scroll);
            // 
            // lblDeg1
            // 
            this.lblDeg1.AutoSize = true;
            this.lblDeg1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDeg1.Location = new System.Drawing.Point(13, 150);
            this.lblDeg1.Name = "lblDeg1";
            this.lblDeg1.Size = new System.Drawing.Size(39, 25);
            this.lblDeg1.TabIndex = 4;
            this.lblDeg1.Text = "15°";
            // 
            // lblDeg2
            // 
            this.lblDeg2.AutoSize = true;
            this.lblDeg2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDeg2.Location = new System.Drawing.Point(93, 150);
            this.lblDeg2.Name = "lblDeg2";
            this.lblDeg2.Size = new System.Drawing.Size(39, 25);
            this.lblDeg2.TabIndex = 4;
            this.lblDeg2.Text = "30°";
            // 
            // lblDeg3
            // 
            this.lblDeg3.AutoSize = true;
            this.lblDeg3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDeg3.Location = new System.Drawing.Point(173, 150);
            this.lblDeg3.Name = "lblDeg3";
            this.lblDeg3.Size = new System.Drawing.Size(39, 25);
            this.lblDeg3.TabIndex = 4;
            this.lblDeg3.Text = "45°";
            // 
            // lblDeg4
            // 
            this.lblDeg4.AutoSize = true;
            this.lblDeg4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDeg4.Location = new System.Drawing.Point(253, 150);
            this.lblDeg4.Name = "lblDeg4";
            this.lblDeg4.Size = new System.Drawing.Size(39, 25);
            this.lblDeg4.TabIndex = 4;
            this.lblDeg4.Text = "60°";
            // 
            // lblDeg5
            // 
            this.lblDeg5.AutoSize = true;
            this.lblDeg5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDeg5.Location = new System.Drawing.Point(337, 195);
            this.lblDeg5.Name = "lblDeg5";
            this.lblDeg5.Size = new System.Drawing.Size(39, 25);
            this.lblDeg5.TabIndex = 4;
            this.lblDeg5.Text = "75°";
            // 
            // lblDegLeft
            // 
            this.lblDegLeft.AutoSize = true;
            this.lblDegLeft.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDegLeft.Location = new System.Drawing.Point(71, 93);
            this.lblDegLeft.Name = "lblDegLeft";
            this.lblDegLeft.Size = new System.Drawing.Size(243, 25);
            this.lblDegLeft.TabIndex = 4;
            this.lblDegLeft.Text = "Градусная мера левого угла";
            // 
            // lblDegRight
            // 
            this.lblDegRight.AutoSize = true;
            this.lblDegRight.BackColor = System.Drawing.SystemColors.Control;
            this.lblDegRight.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDegRight.Location = new System.Drawing.Point(68, 205);
            this.lblDegRight.Name = "lblDegRight";
            this.lblDegRight.Size = new System.Drawing.Size(255, 25);
            this.lblDegRight.TabIndex = 4;
            this.lblDegRight.Text = "Градусная мера правого угла";
            // 
            // lblKof
            // 
            this.lblKof.AutoSize = true;
            this.lblKof.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKof.Location = new System.Drawing.Point(8, 49);
            this.lblKof.Name = "lblKof";
            this.lblKof.Size = new System.Drawing.Size(191, 25);
            this.lblKof.TabIndex = 4;
            this.lblKof.Text = "Отношение отрезков:";
            // 
            // txtBoxKof
            // 
            this.txtBoxKof.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxKof.Location = new System.Drawing.Point(205, 46);
            this.txtBoxKof.Name = "txtBoxKof";
            this.txtBoxKof.Size = new System.Drawing.Size(160, 31);
            this.txtBoxKof.TabIndex = 3;
            this.txtBoxKof.Text = "0,7";
            // 
            // panelFrac
            // 
            this.panelFrac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFrac.Controls.Add(this.txtBoxKof);
            this.panelFrac.Controls.Add(this.lblKof);
            this.panelFrac.Controls.Add(this.lblDegRight);
            this.panelFrac.Controls.Add(this.lblDegLeft);
            this.panelFrac.Controls.Add(this.lblDeg4);
            this.panelFrac.Controls.Add(this.lblDeg3);
            this.panelFrac.Controls.Add(this.lblDeg2);
            this.panelFrac.Controls.Add(this.lblDeg1);
            this.panelFrac.Controls.Add(this.trackBarDeg2);
            this.panelFrac.Controls.Add(this.trackBarDeg1);
            this.panelFrac.Controls.Add(this.lblFractal);
            this.panelFrac.Controls.Add(this.cBoxFractal);
            this.panelFrac.Location = new System.Drawing.Point(6, 52);
            this.panelFrac.Name = "panelFrac";
            this.panelFrac.Size = new System.Drawing.Size(370, 245);
            this.panelFrac.TabIndex = 9;
            // 
            // panelColor
            // 
            this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor.Controls.Add(this.cBoxColor2);
            this.panelColor.Controls.Add(this.lblColor2);
            this.panelColor.Controls.Add(this.cBoxColor1);
            this.panelColor.Controls.Add(this.lblColor1);
            this.panelColor.Location = new System.Drawing.Point(6, 304);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(370, 83);
            this.panelColor.TabIndex = 10;
            // 
            // panelImage
            // 
            this.panelImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelImage.Controls.Add(this.cBoxFormat);
            this.panelImage.Controls.Add(this.lblFormat);
            this.panelImage.Controls.Add(this.lblDirectory);
            this.panelImage.Controls.Add(this.txtBoxDirectory);
            this.panelImage.Controls.Add(this.lblImageSave);
            this.panelImage.Controls.Add(this.txtBoxImageName);
            this.panelImage.Controls.Add(this.btnSaveImage);
            this.panelImage.Location = new System.Drawing.Point(6, 394);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(370, 161);
            this.panelImage.TabIndex = 11;
            // 
            // panelZoom
            // 
            this.panelZoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelZoom.Controls.Add(this.lbl5x);
            this.panelZoom.Controls.Add(this.lbl4x);
            this.panelZoom.Controls.Add(this.lbl3x);
            this.panelZoom.Controls.Add(this.lbl2x);
            this.panelZoom.Controls.Add(this.lbl1x);
            this.panelZoom.Controls.Add(this.trackBarZoom);
            this.panelZoom.Controls.Add(this.lblZoom);
            this.panelZoom.Location = new System.Drawing.Point(6, 562);
            this.panelZoom.Name = "panelZoom";
            this.panelZoom.Size = new System.Drawing.Size(370, 98);
            this.panelZoom.TabIndex = 12;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(6, 12);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(166, 31);
            this.btnHelp.TabIndex = 13;
            this.btnHelp.Text = "Справка";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.Location = new System.Drawing.Point(382, 6);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(313, 38);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "Построение фракталов";
            // 
            // FractalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1093, 760);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.panelZoom);
            this.Controls.Add(this.panelImage);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.panelFrac);
            this.Controls.Add(this.lblDeg5);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.lblRec);
            this.Controls.Add(this.txtBoxRec);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.pictureBox);
            this.Name = "FractalForm";
            this.Text = "FractalForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FractalForm_FormClosed);
            this.Load += new System.EventHandler(this.FractalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDeg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDeg2)).EndInit();
            this.panelFrac.ResumeLayout(false);
            this.panelFrac.PerformLayout();
            this.panelColor.ResumeLayout(false);
            this.panelColor.PerformLayout();
            this.panelImage.ResumeLayout(false);
            this.panelImage.PerformLayout();
            this.panelZoom.ResumeLayout(false);
            this.panelZoom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.TrackBar trackBarZoom;
        private System.Windows.Forms.TextBox txtBoxRec;
        private System.Windows.Forms.Label lblRec;
        private System.Windows.Forms.Label lblZoom;
        private System.Windows.Forms.Label lbl1x;
        private System.Windows.Forms.Label lbl2x;
        private System.Windows.Forms.Label lbl3x;
        private System.Windows.Forms.Label lbl4x;
        private System.Windows.Forms.Label lbl5x;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.TextBox txtBoxImageName;
        private System.Windows.Forms.Label lblImageSave;
        private System.Windows.Forms.TextBox txtBoxDirectory;
        private System.Windows.Forms.Label lblDirectory;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.ComboBox cBoxFormat;
        private System.Windows.Forms.ComboBox cBoxFractal;
        private System.Windows.Forms.Label lblFractal;
        private System.Windows.Forms.Label lblColor1;
        private System.Windows.Forms.ComboBox cBoxColor1;
        private System.Windows.Forms.Label lblColor2;
        private System.Windows.Forms.ComboBox cBoxColor2;
        private System.Windows.Forms.TrackBar trackBarDeg1;
        private System.Windows.Forms.TrackBar trackBarDeg2;
        private System.Windows.Forms.Label lblDeg1;
        private System.Windows.Forms.Label lblDeg2;
        private System.Windows.Forms.Label lblDeg3;
        private System.Windows.Forms.Label lblDeg4;
        private System.Windows.Forms.Label lblDeg5;
        private System.Windows.Forms.Label lblDegLeft;
        private System.Windows.Forms.Label lblDegRight;
        private System.Windows.Forms.Label lblKof;
        private System.Windows.Forms.TextBox txtBoxKof;
        private System.Windows.Forms.Panel panelFrac;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.Panel panelZoom;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblHeader;
    }
}