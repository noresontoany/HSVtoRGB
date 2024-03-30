using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HSVtoRGB
{
    public partial class Form1 : Form



    {
        public Form1()
        {
            InitializeComponent();
        }

        bool EvenIsGoing;
        private void HueValueChanged(object sender, EventArgs e)
        {
            if (!EvenIsGoing)
            {
                hsv_to_rgb_Setter();
            }
            
        }
        private void saturationValueChanged(object sender, EventArgs e)
        {
            if (!EvenIsGoing)
            {
                hsv_to_rgb_Setter();
            }
        }

        private void brightnessValueChanged(object sender, EventArgs e)
        {
            if (!EvenIsGoing)
            {
                hsv_to_rgb_Setter();
            }
        }

        private void numRed_ValueChanged(object sender, EventArgs e)
        {
            if (!EvenIsGoing)
            {
                rgb_to_hsv_Setter();
            }
        }

        private void numGreen_ValueChanged(object sender, EventArgs e)
        {
            if (!EvenIsGoing)
            {
                rgb_to_hsv_Setter();
            }
        }

        private void numBlue_ValueChanged(object sender, EventArgs e)
        {
            if (!EvenIsGoing)
            {
                rgb_to_hsv_Setter();
            }
        }


        public void hsv_to_rgb_Setter()
        {

            try
            {
                EvenIsGoing = true;
                // считали значени€ с полей дл€ ввода и сконвертили в числа
                var HueValue = float.Parse(numHue.Text);
                var SaturationValue = float.Parse(numSaturation.Text);
                var BrightnessValue = float.Parse(numValueBrightness.Text);

                // на основании значений создали экземпл€ры нашего класса Length 
                var hsv = new Hsv();
                RGB rgb;
                hsv.Hue = HueValue;
                hsv.Saturation = SaturationValue;
                hsv.Value = BrightnessValue;
                rgb = hsv.Solver();

                // записали в поле txtResult длину в строковом виде
                numRed.Text = Convert.ToString(rgb.r);
                numGreen.Text = Convert.ToString(rgb.g);
                numBlue.Text = Convert.ToString(rgb.b);


                labelHue.Text = Convert.ToString(rgb.r);
                labelSaturation.Text = Convert.ToString(rgb.g);
                labelValueBrightness.Text = Convert.ToString(rgb.b);


                pictureBox1.BackColor = Color.FromArgb((int)rgb.r, (int)rgb.b, (int)rgb.b);


                EvenIsGoing = false;
            }
            catch (FormatException)
            {
                // если тип преобразовать не смогли
            }
        }
        public void rgb_to_hsv_Setter()
        {

            try
            {
                EvenIsGoing = true;
                var RedValue = float.Parse(numRed.Text);
                var GreenValue = float.Parse(numGreen.Text);
                var BlueValue = float.Parse(numBlue.Text);


                var rgb = new Rgb();
                HSV hsv;

                rgb.Red = RedValue;
                rgb.Green = GreenValue;
                rgb.Blue = BlueValue;

                hsv = rgb.Solver();

                numHue.Text = Convert.ToString((int)hsv.Hue);
                numSaturation.Text = Convert.ToString((int)hsv.Saturation);
                numValueBrightness.Text = Convert.ToString((int)hsv.Value);


                labelHue.Text = Convert.ToString((int)hsv.Hue);
                labelSaturation.Text = Convert.ToString((int)hsv.Saturation);
                labelValueBrightness.Text = Convert.ToString((int)hsv.Value);




                pictureBox1.BackColor = Color.FromArgb((int)RedValue, (int)GreenValue, (int)BlueValue);

                EvenIsGoing = false;
            }
            catch (FormatException)
            {
                // если тип преобразовать не смогли
            }
        }

        
    }

    public struct RGB
    {
        public double r;
        public double g;
        public double b;
    }

    public struct HSV
    {
        public double Hue;
        public double Saturation;
        public double Value;
    }

    public class Rgb
    {
        private float red;

        private float green;
        
        private float blue; 

        public float Red
        {
            get
            {
                return red;
            }
            set
            {
                red = value / 255;
            }
        }

        public float Green
        {
            get
            {
                return green;
            }

            set
            {
                green = value / 255;    
            }

        }

        public float Blue
        {
            get
            {
                return blue;
            }
            set
            {
                blue = value / 255;
            }
        }


        public HSV Solver()
        {
            HSV hsv;
            float Cmax = Math.Max(this.red, Math.Max(this.green, this.blue));
            float Cmin = Math.Min(this.red, Math.Min(this.green, this.blue));
            float Delta = Cmax - Cmin;

            hsv.Hue = -1;

            if (Delta == 0)
            {
                hsv.Hue = 0;
            }
            else if (Cmax == this.red)
                hsv.Hue = (60 * ((this.green - this.blue) / Delta) + 360) % 360;

            else if (Cmax == this.green)
                hsv.Hue = (60 * ((this.blue - this.red) / Delta) + 120) % 360;


            else if (Cmax == this.blue)
                hsv.Hue = (60 * ((this.red - this.green) / Delta) + 240) % 360;

            if (Cmax == 0)
            {
                hsv.Saturation = 0;
            }
            else
            {
                hsv.Saturation = Delta / Cmax;
            }

            hsv.Value = Cmax;



            hsv.Saturation *= 100;
            hsv.Value *= 100;
            return hsv; 
        }




    }

    public class Hsv
    {
        private float hue;

        public float Hue
        {
            get
            {
                return hue;
            }
            set
            {
                hue = value;
            }
        }
        private float saturation;
        public float Saturation
        {
            get
            {
                return saturation;
            }
            set
            {
                saturation = value / 100;
            }
        }
        private float valueB;
        public float Value
        {
            get
            {
                return valueB;
            }
            set
            {
                valueB = value / 100;
            }
        }

        public RGB Solver()
        {
            float r, g, b;

            float h = hue / 60;

            int Hi = (int)Math.Floor(h);

            float Vmin = valueB * (1 - saturation);

            float a = (valueB - Vmin) * (hue % 60) / 60;

            float Vinc = Vmin + a;

            float Vdec = valueB - a;


            switch (Hi % 6)
            {
                case 0:
                    r = valueB;
                    g = Vinc;
                    b = Vmin;
                    break;
                case 1:
                    r = Vdec;
                    g = valueB;
                    b = Vmin;
                    break;
                case 2:
                    r = Vmin;
                    g = valueB;
                    b = Vinc;
                    break;
                case 3:
                    r = Vmin;
                    g = Vdec;
                    b = valueB;
                    break;
                case 4:
                    r = Vinc;
                    g = Vmin;
                    b = valueB;
                    break;
                case 5:
                default:
                    r = valueB;
                    g = Vmin;
                    b = Vdec;
                    break;
            }

            RGB rgb;
            rgb.r = Math.Ceiling(r * 255);
            rgb.g = Math.Ceiling(g * 255);
            rgb.b = Math.Ceiling(b * 255);

            Console.WriteLine(rgb.r);
            Console.WriteLine(rgb.g);
            Console.WriteLine(rgb.b);

            return rgb;
        }




    }



    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var hsv = new Hsv();

    //        hsv.H = 300;
    //        hsv.S = 100;
    //        hsv.V = 50;
    //        hsv.solver();

    //    }

    //}
}
