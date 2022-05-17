namespace FractalMaker
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFractal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFractal
            // 
            this.btnFractal.BackColor = System.Drawing.Color.White;
            this.btnFractal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFractal.Location = new System.Drawing.Point(157, 27);
            this.btnFractal.Name = "btnFractal";
            this.btnFractal.Size = new System.Drawing.Size(317, 67);
            this.btnFractal.TabIndex = 0;
            this.btnFractal.Text = "Создать фрактал";
            this.btnFractal.UseVisualStyleBackColor = false;
            this.btnFractal.Click += new System.EventHandler(this.btnFractal_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(643, 121);
            this.Controls.Add(this.btnFractal);
            this.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Fractal Maker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFractal;
    }
}

