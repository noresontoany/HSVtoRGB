using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HSVtoRGB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            calculus();
        }

        public void calculus()
        {

            try
            {
                // считали значени€ с полей дл€ ввода и сконвертили в числа
                var firstValue = float.Parse(numericUpDown1.Text);
                var secondValue = float.Parse(numericUpDown2.Text);
                var tgirdValue = float.Parse(numericUpDown3.Text);

                // на основании значений создали экземпл€ры нашего класса Length 
                var hsv = new Hsv();
                RGB rgb;
                hsv.H = firstValue;
                hsv.S = secondValue;
                hsv.V = tgirdValue;
                rgb = hsv.solver();

                // записали в поле txtResult длину в строковом виде
                label1.Text = Convert.ToString(rgb.r);
                label2.Text = Convert.ToString(rgb.g);
                label3.Text = Convert.ToString(rgb.b);


                pictureBox1.BackColor = Color.FromArgb((int)rgb.r,(int)rgb.b,(int)rgb.b);
            }
            catch (FormatException)
            {
                // если тип преобразовать не смогли
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            calculus();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            calculus();
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
        public float H;
        //{
        //    get
        //    {
        //        return h;
        //    }
        //    set
        //    {
        //        h = value;
        //    }
        //}
        public float S;
        //{
        //    get
        //    {
        //        return s;
        //    }
        //    set
        //    {
        //        s = value;
        //    }
        //}
        public float V;
        //{
        //    get
        //    {
        //        return v;
        //    }
        //    set
        //    {
        //        v = value;
        //    }
        //}
        //private double Setrech(double h)
        //{
        //    if (h <= 360)
        //    {

        //        return h;

        //    }

        //    return Setrech(h - 360);
        //}

        //private double Settecp(double per)
        //{
        //    if (per <= 100)
        //    {
        //        return per;
        //    }
        //    return Settecp(per - 100);
        //}

        public RGB solver()
        {
            float r, g, b;

            float h = H / 60;

            float s = S / 100;

            float v = V / 100;

            int Hi = (int)Math.Floor(h);

            float Vmin = v * (1 - s);

            float a = (v - Vmin) * (H % 60) / 60;

            float Vinc = Vmin + a;

            float Vdec = v - a;


            switch (Hi % 6)
            {
                case 0:
                    r = v;
                    g = Vinc;
                    b = Vmin;
                    break;
                case 1:
                    r = Vdec;
                    g = v;
                    b = Vmin;
                    break;
                case 2:
                    r = Vmin;
                    g = v;
                    b = Vinc;
                    break;
                case 3:
                    r = Vmin;
                    g = Vdec;
                    b = v;
                    break;
                case 4:
                    r = Vinc;
                    g = Vmin;
                    b = v;
                    break;
                case 5:
                default:
                    r = v;
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
