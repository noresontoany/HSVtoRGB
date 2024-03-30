using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HSVtoRGB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void HueValueChanged(object sender, EventArgs e)
        {
            hsv_to_rgb_Setter();
        }
        private void saturationValueChanged(object sender, EventArgs e)
        {
            hsv_to_rgb_Setter();
        }

        private void brightnessValueChanged(object sender, EventArgs e)
        {
            hsv_to_rgb_Setter();
        }

        public void hsv_to_rgb_Setter()
        {

            try
            {
                // ������� �������� � ����� ��� ����� � ����������� � �����
                var firstValue = float.Parse(numHue.Text);
                var secondValue = float.Parse(numSaturation.Text);
                var tgirdValue = float.Parse(numValueBrightness.Text);

                // �� ��������� �������� ������� ���������� ������ ������ Length 
                var hsv = new Hsv();
                RGB rgb;
                hsv.Hue = firstValue;
                hsv.Saturation = secondValue;
                hsv.Value = tgirdValue;
                rgb = hsv.solver();

                // �������� � ���� txtResult ����� � ��������� ����
                numRed.Text = Convert.ToString(rgb.r);
                numGreen.Text = Convert.ToString(rgb.g);
                numBlue.Text = Convert.ToString(rgb.b);


                pictureBox1.BackColor = Color.FromArgb((int)rgb.r, (int)rgb.b, (int)rgb.b);
            }
            catch (FormatException)
            {
                // ���� ��� ������������� �� ������
            }
        }

    }


    public struct RGB
    {
        public double r;
        public double g;
        public double b;
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

        public RGB solver()
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
