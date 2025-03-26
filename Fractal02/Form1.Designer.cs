namespace Fractal02
{
    partial class Fractal2
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxFractal2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFractal2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFractal2
            // 
            this.pictureBoxFractal2.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxFractal2.Name = "pictureBoxFractal2";
            this.pictureBoxFractal2.Size = new System.Drawing.Size(550, 550);
            this.pictureBoxFractal2.TabIndex = 0;
            this.pictureBoxFractal2.TabStop = false;
            // 
            // Fractal2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 590);
            this.Controls.Add(this.pictureBoxFractal2);
            this.Name = "Fractal2";
            this.Text = "Fractal2";
            this.Load += new System.EventHandler(this.Fractal2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFractal2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFractal2;
    }
}

