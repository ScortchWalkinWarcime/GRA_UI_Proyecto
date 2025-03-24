namespace FrmFractal01
{
    partial class Fractales
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
            PictureBoxMandelbrot = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PictureBoxMandelbrot).BeginInit();
            SuspendLayout();
            // 
            // PictureBoxMandelbrot
            // 
            PictureBoxMandelbrot.Location = new Point(26, 25);
            PictureBoxMandelbrot.Name = "PictureBoxMandelbrot";
            PictureBoxMandelbrot.Size = new Size(550, 550);
            PictureBoxMandelbrot.TabIndex = 0;
            PictureBoxMandelbrot.TabStop = false;
            // 
            // Fractales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 621);
            Controls.Add(PictureBoxMandelbrot);
            Name = "Fractales";
            Text = "Fractales";
            Load += Fractales_Load;
            ((System.ComponentModel.ISupportInitialize)PictureBoxMandelbrot).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PictureBoxMandelbrot;
    }
}