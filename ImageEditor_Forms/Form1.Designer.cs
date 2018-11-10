namespace ImageEditor_Forms
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Point_button = new System.Windows.Forms.Button();
            this.Circle_button = new System.Windows.Forms.Button();
            this.Ellipse_button = new System.Windows.Forms.Button();
            this.Square_button = new System.Windows.Forms.Button();
            this.Bezier_button = new System.Windows.Forms.Button();
            this.Polygon_button = new System.Windows.Forms.Button();
            this.Slice_button = new System.Windows.Forms.Button();
            this.Bow_button = new System.Windows.Forms.Button();
            this.Eraser_button = new System.Windows.Forms.Button();
            this.LineThickness_numeric = new System.Windows.Forms.NumericUpDown();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Color_button = new System.Windows.Forms.Button();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.Color_indicator = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LineThickness_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Color_indicator)).BeginInit();
            this.SuspendLayout();
            // 
            // Point_button
            // 
            this.Point_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Point_button.Location = new System.Drawing.Point(12, 12);
            this.Point_button.Name = "Point_button";
            this.Point_button.Size = new System.Drawing.Size(32, 32);
            this.Point_button.TabIndex = 0;
            this.Point_button.Text = "🖊";
            this.Point_button.UseVisualStyleBackColor = true;
            // 
            // Circle_button
            // 
            this.Circle_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Circle_button.Location = new System.Drawing.Point(50, 12);
            this.Circle_button.Name = "Circle_button";
            this.Circle_button.Size = new System.Drawing.Size(32, 32);
            this.Circle_button.TabIndex = 1;
            this.Circle_button.Text = "◯ ";
            this.Circle_button.UseVisualStyleBackColor = true;
            // 
            // Ellipse_button
            // 
            this.Ellipse_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Ellipse_button.Location = new System.Drawing.Point(50, 50);
            this.Ellipse_button.Name = "Ellipse_button";
            this.Ellipse_button.Size = new System.Drawing.Size(32, 32);
            this.Ellipse_button.TabIndex = 3;
            this.Ellipse_button.Text = "⬯";
            this.Ellipse_button.UseVisualStyleBackColor = true;
            // 
            // Square_button
            // 
            this.Square_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Square_button.Location = new System.Drawing.Point(12, 50);
            this.Square_button.Name = "Square_button";
            this.Square_button.Size = new System.Drawing.Size(32, 32);
            this.Square_button.TabIndex = 2;
            this.Square_button.Text = "⬜";
            this.Square_button.UseVisualStyleBackColor = true;
            // 
            // Bezier_button
            // 
            this.Bezier_button.Location = new System.Drawing.Point(50, 126);
            this.Bezier_button.Name = "Bezier_button";
            this.Bezier_button.Size = new System.Drawing.Size(32, 32);
            this.Bezier_button.TabIndex = 7;
            this.Bezier_button.Text = "B";
            this.Bezier_button.UseVisualStyleBackColor = true;
            // 
            // Polygon_button
            // 
            this.Polygon_button.Location = new System.Drawing.Point(12, 126);
            this.Polygon_button.Name = "Polygon_button";
            this.Polygon_button.Size = new System.Drawing.Size(32, 32);
            this.Polygon_button.TabIndex = 6;
            this.Polygon_button.Text = "P";
            this.Polygon_button.UseVisualStyleBackColor = true;
            // 
            // Slice_button
            // 
            this.Slice_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Slice_button.Location = new System.Drawing.Point(50, 88);
            this.Slice_button.Name = "Slice_button";
            this.Slice_button.Size = new System.Drawing.Size(32, 32);
            this.Slice_button.TabIndex = 5;
            this.Slice_button.Text = "◔";
            this.Slice_button.UseVisualStyleBackColor = true;
            // 
            // Bow_button
            // 
            this.Bow_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Bow_button.Location = new System.Drawing.Point(12, 88);
            this.Bow_button.Name = "Bow_button";
            this.Bow_button.Size = new System.Drawing.Size(32, 32);
            this.Bow_button.TabIndex = 4;
            this.Bow_button.Text = "◡";
            this.Bow_button.UseVisualStyleBackColor = true;
            // 
            // Eraser_button
            // 
            this.Eraser_button.Location = new System.Drawing.Point(12, 164);
            this.Eraser_button.Name = "Eraser_button";
            this.Eraser_button.Size = new System.Drawing.Size(70, 23);
            this.Eraser_button.TabIndex = 8;
            this.Eraser_button.Text = "Gumka";
            this.Eraser_button.UseVisualStyleBackColor = true;
            // 
            // LineThickness_numeric
            // 
            this.LineThickness_numeric.Location = new System.Drawing.Point(12, 193);
            this.LineThickness_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LineThickness_numeric.Name = "LineThickness_numeric";
            this.LineThickness_numeric.Size = new System.Drawing.Size(70, 20);
            this.LineThickness_numeric.TabIndex = 9;
            this.LineThickness_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Color_button
            // 
            this.Color_button.Location = new System.Drawing.Point(12, 219);
            this.Color_button.Name = "Color_button";
            this.Color_button.Size = new System.Drawing.Size(41, 23);
            this.Color_button.TabIndex = 10;
            this.Color_button.Text = "Kolor";
            this.Color_button.UseVisualStyleBackColor = true;
            // 
            // Canvas
            // 
            this.Canvas.Location = new System.Drawing.Point(88, 12);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(230, 230);
            this.Canvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Canvas.TabIndex = 12;
            this.Canvas.TabStop = false;
            // 
            // Color_indicator
            // 
            this.Color_indicator.Location = new System.Drawing.Point(60, 220);
            this.Color_indicator.Name = "Color_indicator";
            this.Color_indicator.Size = new System.Drawing.Size(22, 22);
            this.Color_indicator.TabIndex = 13;
            this.Color_indicator.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 254);
            this.Controls.Add(this.Color_indicator);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.Color_button);
            this.Controls.Add(this.LineThickness_numeric);
            this.Controls.Add(this.Eraser_button);
            this.Controls.Add(this.Bezier_button);
            this.Controls.Add(this.Polygon_button);
            this.Controls.Add(this.Slice_button);
            this.Controls.Add(this.Bow_button);
            this.Controls.Add(this.Ellipse_button);
            this.Controls.Add(this.Square_button);
            this.Controls.Add(this.Circle_button);
            this.Controls.Add(this.Point_button);
            this.MinimumSize = new System.Drawing.Size(346, 293);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.LineThickness_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Color_indicator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Point_button;
        private System.Windows.Forms.Button Circle_button;
        private System.Windows.Forms.Button Ellipse_button;
        private System.Windows.Forms.Button Square_button;
        private System.Windows.Forms.Button Bezier_button;
        private System.Windows.Forms.Button Polygon_button;
        private System.Windows.Forms.Button Slice_button;
        private System.Windows.Forms.Button Bow_button;
        private System.Windows.Forms.Button Eraser_button;
        private System.Windows.Forms.NumericUpDown LineThickness_numeric;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button Color_button;
        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.PictureBox Color_indicator;
    }
}

