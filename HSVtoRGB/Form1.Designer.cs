
namespace HSVtoRGB
{
    partial class Form1
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
            numHue = new NumericUpDown();
            numSaturation = new NumericUpDown();
            numValueBrightness = new NumericUpDown();
            pictureBox1 = new PictureBox();
            numRed = new NumericUpDown();
            numGreen = new NumericUpDown();
            numBlue = new NumericUpDown();
            labelRed = new Label();
            labelGreen = new Label();
            labelBlue = new Label();
            labelHue = new Label();
            labelSaturation = new Label();
            labelValueBrightness = new Label();
            ((System.ComponentModel.ISupportInitialize)numHue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSaturation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numValueBrightness).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBlue).BeginInit();
            SuspendLayout();
            // 
            // numHue
            // 
            numHue.Location = new Point(176, 65);
            numHue.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            numHue.Name = "numHue";
            numHue.Size = new Size(180, 31);
            numHue.TabIndex = 0;
            numHue.ValueChanged += HueValueChanged;
            numHue.KeyDown += keyDown;
            // 
            // numSaturation
            // 
            numSaturation.Location = new Point(176, 155);
            numSaturation.Name = "numSaturation";
            numSaturation.Size = new Size(180, 31);
            numSaturation.TabIndex = 1;
            numSaturation.ValueChanged += saturationValueChanged;
            numSaturation.KeyDown += keyDown;
            // 
            // numValueBrightness
            // 
            numValueBrightness.Location = new Point(176, 270);
            numValueBrightness.Name = "numValueBrightness";
            numValueBrightness.Size = new Size(180, 31);
            numValueBrightness.TabIndex = 2;
            numValueBrightness.ValueChanged += brightnessValueChanged;
            numValueBrightness.KeyDown += keyDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(941, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 247);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // numRed
            // 
            numRed.Location = new Point(647, 58);
            numRed.Margin = new Padding(4, 5, 4, 5);
            numRed.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numRed.Name = "numRed";
            numRed.Size = new Size(171, 31);
            numRed.TabIndex = 7;
            numRed.ValueChanged += numRed_ValueChanged;
            numRed.KeyDown += keyDown;
            // 
            // numGreen
            // 
            numGreen.Location = new Point(647, 155);
            numGreen.Margin = new Padding(4, 5, 4, 5);
            numGreen.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numGreen.Name = "numGreen";
            numGreen.Size = new Size(171, 31);
            numGreen.TabIndex = 8;
            numGreen.ValueChanged += numGreen_ValueChanged;
            numGreen.KeyDown += keyDown;
            // 
            // numBlue
            // 
            numBlue.Location = new Point(647, 270);
            numBlue.Margin = new Padding(4, 5, 4, 5);
            numBlue.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numBlue.Name = "numBlue";
            numBlue.Size = new Size(171, 31);
            numBlue.TabIndex = 9;
            numBlue.ValueChanged += numBlue_ValueChanged;
            numBlue.KeyDown += keyDown;
            // 
            // labelRed
            // 
            labelRed.AutoSize = true;
            labelRed.Location = new Point(497, 60);
            labelRed.Margin = new Padding(4, 0, 4, 0);
            labelRed.Name = "labelRed";
            labelRed.Size = new Size(42, 25);
            labelRed.TabIndex = 10;
            labelRed.Text = "Red";
            // 
            // labelGreen
            // 
            labelGreen.AutoSize = true;
            labelGreen.Location = new Point(481, 158);
            labelGreen.Margin = new Padding(4, 0, 4, 0);
            labelGreen.Name = "labelGreen";
            labelGreen.Size = new Size(58, 25);
            labelGreen.TabIndex = 11;
            labelGreen.Text = "Green";
            // 
            // labelBlue
            // 
            labelBlue.AutoSize = true;
            labelBlue.Location = new Point(493, 283);
            labelBlue.Margin = new Padding(4, 0, 4, 0);
            labelBlue.Name = "labelBlue";
            labelBlue.Size = new Size(45, 25);
            labelBlue.TabIndex = 12;
            labelBlue.Text = "Blue";
            // 
            // labelHue
            // 
            labelHue.AutoSize = true;
            labelHue.Location = new Point(77, 65);
            labelHue.Margin = new Padding(4, 0, 4, 0);
            labelHue.Name = "labelHue";
            labelHue.Size = new Size(56, 25);
            labelHue.TabIndex = 13;
            labelHue.Text = "Hue °";
            // 
            // labelSaturation
            // 
            labelSaturation.AutoSize = true;
            labelSaturation.Location = new Point(28, 161);
            labelSaturation.Margin = new Padding(4, 0, 4, 0);
            labelSaturation.Name = "labelSaturation";
            labelSaturation.Size = new Size(113, 25);
            labelSaturation.TabIndex = 14;
            labelSaturation.Text = "Saturation %";
            // 
            // labelValueBrightness
            // 
            labelValueBrightness.AutoSize = true;
            labelValueBrightness.Location = new Point(59, 272);
            labelValueBrightness.Margin = new Padding(4, 0, 4, 0);
            labelValueBrightness.Name = "labelValueBrightness";
            labelValueBrightness.Size = new Size(74, 25);
            labelValueBrightness.TabIndex = 15;
            labelValueBrightness.Text = "Value %";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 455);
            Controls.Add(labelValueBrightness);
            Controls.Add(labelSaturation);
            Controls.Add(labelHue);
            Controls.Add(labelBlue);
            Controls.Add(labelGreen);
            Controls.Add(labelRed);
            Controls.Add(numBlue);
            Controls.Add(numGreen);
            Controls.Add(numRed);
            Controls.Add(pictureBox1);
            Controls.Add(numValueBrightness);
            Controls.Add(numSaturation);
            Controls.Add(numHue);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numHue).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSaturation).EndInit();
            ((System.ComponentModel.ISupportInitialize)numValueBrightness).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBlue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private NumericUpDown numHue;
        private NumericUpDown numSaturation;
        private NumericUpDown numValueBrightness;
        private PictureBox pictureBox1;
        private NumericUpDown numRed;
        private NumericUpDown numGreen;
        private NumericUpDown numBlue;
        private Label labelRed;
        private Label labelGreen;
        private Label labelBlue;
        private Label labelHue;
        private Label labelSaturation;
        private Label labelValueBrightness;
    }
}
