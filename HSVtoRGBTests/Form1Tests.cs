using Microsoft.VisualStudio.TestTools.UnitTesting;
using HSVtoRGB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Design;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace HSVtoRGB.Tests
{
    [TestClass()]
    public class Form1Tests

    {
        // Тесты с табличными заначениями(сайт rgb.to), цвет в названии метода
        // hsv -> rgb
        [TestMethod()]
        public void hsv_to_rgb_SetterTest_Red()
        {
            Hsv hsv = new Hsv();
            RGB rgb;
            RGB test;
            test.r = 255;
            test.g = 0;
            test.b = 0;
            hsv.Hue = 0;
            hsv.Saturation = 100;
            hsv.Value = 100;
            rgb = hsv.Solver();
            Assert.AreEqual(rgb, test);
        }
        [TestMethod()]
        public void hsv_to_rgb_SetterTest_White()
        {
            Hsv hsv = new Hsv();
            RGB rgb;
            RGB test;
            test.r = 255;
            test.g = 255;
            test.b = 255;
            hsv.Hue = 0;
            hsv.Saturation = 0;
            hsv.Value = 100;
            rgb = hsv.Solver();
            Assert.AreEqual(rgb, test);
        }
        [TestMethod()]
        public void hsv_to_rgb_SetterTest_Black()
        {
            Hsv hsv = new Hsv();
            RGB rgb;
            RGB test;
            test.r = 0;
            test.g = 0;
            test.b = 0;
            hsv.Hue = 0;
            hsv.Saturation = 0;
            hsv.Value = 0;
            rgb = hsv.Solver();
            Assert.AreEqual(rgb, test);
        }

        [TestMethod()]
        public void hsv_to_rgb_SetterTest_Cyan()
        {
            Hsv hsv = new Hsv();
            RGB rgb;
            RGB test;
            test.r = 0;
            test.g = 255;
            test.b = 255;
            hsv.Hue = 180;
            hsv.Saturation = 100;
            hsv.Value = 100;
            rgb = hsv.Solver();
            Assert.AreEqual(rgb, test);
        }
        [TestMethod()]
        public void hsv_to_rgb_SetterTest_Yellow()
        {
            Hsv hsv = new Hsv();
            RGB rgb;
            RGB test;
            test.r = 255;
            test.g = 255;
            test.b = 0;
            hsv.Hue = 60;
            hsv.Saturation = 100;
            hsv.Value = 100;
            rgb = hsv.Solver();
            Assert.AreEqual(rgb, test);
        }
        [TestMethod()]
        public void hsv_to_rgb_SetterTest_Blue()
        {
            Hsv hsv = new Hsv();
            RGB rgb;
            RGB test;
            test.r = 0;
            test.g = 0;
            test.b = 255;
            hsv.Hue = 240;
            hsv.Saturation = 100;
            hsv.Value = 100;
            rgb = hsv.Solver();
            Assert.AreEqual(rgb, test);
        }
        [TestMethod()]
        public void hsv_to_rgb_SetterTest_Lime()
        {
            Hsv hsv = new Hsv();
            RGB rgb;
            RGB test;
            test.r = 0;
            test.g = 255;
            test.b = 0;
            hsv.Hue = 120;
            hsv.Saturation = 100;
            hsv.Value = 100;
            rgb = hsv.Solver();
            Assert.AreEqual(rgb, test);
        }

        [TestMethod()]
        public void hsv_to_rgb_SetterTest_Navy()
        {
            Hsv hsv = new Hsv();
            RGB rgb;
            RGB test;
            test.r = 0;
            test.g = 0;
            test.b = 128;
            hsv.Hue = 240;
            hsv.Saturation = 100;
            hsv.Value = 50;
            rgb = hsv.Solver();
            Assert.AreEqual(rgb, test);
        }
        [TestMethod()]
        public void hsv_to_rgb_SetterTest_Teal()
        {
            Hsv hsv = new Hsv();
            RGB rgb;
            RGB test;
            test.r = 0;
            test.g = 128;
            test.b = 128;
            hsv.Hue = 180;
            hsv.Saturation = 100;
            hsv.Value = 50;
            rgb = hsv.Solver();
            Assert.AreEqual(rgb, test);
        }
        [TestMethod()]
        public void hsv_to_rgb_SetterTest_Purple()
        {
            Hsv hsv = new Hsv();
            RGB rgb;
            RGB test;
            test.r = 128;
            test.g = 0;
            test.b = 128;
            hsv.Hue = 300;
            hsv.Saturation = 100;
            hsv.Value = 50;
            rgb = hsv.Solver();
            Assert.AreEqual(rgb, test);
        }


        [TestMethod()]
        public void hsv_to_rgb_SetterTest_Green()
        {
            Hsv hsv = new Hsv();
            RGB rgb;
            RGB test;
            test.r = 0;
            test.g = 128;
            test.b = 0;
            hsv.Hue = 120;
            hsv.Saturation = 100;
            hsv.Value = 50;
            rgb = hsv.Solver();
            Assert.AreEqual(rgb, test);
        }
        [TestMethod()]
        public void hsv_to_rgb_SetterTest_Olive()
        {
            Hsv hsv = new Hsv();
            RGB rgb;
            RGB test;
            test.r = 128;
            test.g = 128;
            test.b = 0;
            hsv.Hue = 60;
            hsv.Saturation = 100;
            hsv.Value = 50;
            rgb = hsv.Solver();
            Assert.AreEqual(rgb, test);
        }
        [TestMethod()]
        public void hsv_to_rgb_SetterTest_Maroon()
        {
            Hsv hsv = new Hsv();
            RGB rgb;
            RGB test;
            test.r = 128;
            test.g = 0;
            test.b = 0;
            hsv.Hue = 0;
            hsv.Saturation = 100;
            hsv.Value = 50;
            rgb = hsv.Solver();
            Assert.AreEqual(rgb, test);
        }
        [TestMethod()]
        public void hsv_to_rgb_SetterTest_Gray()
        {
            Hsv hsv = new Hsv();
            RGB rgb;
            RGB test;
            test.r = 128;
            test.g = 128;
            test.b = 128;
            hsv.Hue = 0;
            hsv.Saturation = 0;
            hsv.Value = 50;
            rgb = hsv.Solver();
            Assert.AreEqual(rgb, test);
        }
        [TestMethod()]
        public void hsv_to_rgb_SetterTest_Silver()
        {
            Hsv hsv = new Hsv();
            RGB rgb;
            RGB test;
            test.r = 192;
            test.g = 192;
            test.b = 192;
            hsv.Hue = 0;
            hsv.Saturation = 0;
            hsv.Value = 75;
            rgb = hsv.Solver();
            Assert.AreEqual(rgb, test);
        }
        [TestMethod()]
        public void hsv_to_rgb_SetterTest_Magenta()
        {
            Hsv hsv = new Hsv();
            RGB rgb;
            RGB test;
            test.r = 255;
            test.g = 0;
            test.b = 255;
            hsv.Hue = 300;
            hsv.Saturation = 100;
            hsv.Value = 100;
            rgb = hsv.Solver();
            Assert.AreEqual(rgb, test);
        }


        // Тесты с табличными заначениями(сайт rgb.to), цвет в названии метода
        //  rgb -> hsv
        [TestMethod()]
        public void rgb_to_hsv_SetterTest_Red()
        {
            var rgb = new Rgb();
            HSV hsv;
            HSV test;
            rgb.Red = 255;
            rgb.Green = 0;
            rgb.Blue = 0;
            test.Hue = 0;
            test.Saturation = 100;
            test.Value = 100;
            hsv = rgb.Solver();
            Assert.AreEqual(hsv, test);
        }
        [TestMethod()]
        public void rgb_to_hsv_SetterTest_White()
        {
            var rgb = new Rgb();
            HSV hsv;
            HSV test;
            rgb.Red = 255;
            rgb.Green = 255;
            rgb.Blue = 255;
            test.Hue = 0;
            test.Saturation = 0;
            test.Value = 100;
            hsv = rgb.Solver();
            Assert.AreEqual(hsv, test);
        }
        [TestMethod()]
        public void rgb_to_hsv_SetterTest_Black()
        {
            var rgb = new Rgb();
            HSV hsv;
            HSV test;
            rgb.Red = 0;
            rgb.Green = 0;
            rgb.Blue = 0;
            test.Hue = 0;
            test.Saturation = 0;
            test.Value = 0;
            hsv = rgb.Solver();
            Assert.AreEqual(hsv, test);
        }

        [TestMethod()]
        public void rgb_to_hsv_SetterTest_Cyan()
        {
            var rgb = new Rgb();
            HSV hsv;
            HSV test;
            rgb.Red = 0;
            rgb.Green = 255;
            rgb.Blue = 255;
            test.Hue = 180;
            test.Saturation = 100;
            test.Value = 100;
            hsv = rgb.Solver();
            Assert.AreEqual(hsv, test);
        }
        [TestMethod()]
        public void rgb_to_hsv_SetterTest_Yellow()
        {
            var rgb = new Rgb();
            HSV hsv;
            HSV test;
            rgb.Red = 255;
            rgb.Green = 255;
            rgb.Blue = 0;
            test.Hue = 60;
            test.Saturation = 100;
            test.Value = 100;
            hsv = rgb.Solver();
            Assert.AreEqual(hsv, test);
        }
        [TestMethod()]
        public void rgb_to_hsv_SetterTest_Blue()
        {
            var rgb = new Rgb();
            HSV hsv;
            HSV test;
            rgb.Red = 0;
            rgb.Green = 0;
            rgb.Blue = 255;
            test.Hue = 240;
            test.Saturation = 100;
            test.Value = 100;
            hsv = rgb.Solver();
            Assert.AreEqual(hsv, test);
        }
        [TestMethod()]
        public void rgb_to_hsv_SetterTest_Lime()
        {
            var rgb = new Rgb();
            HSV hsv;
            HSV test;
            rgb.Red = 0;
            rgb.Green = 255;
            rgb.Blue = 0;
            test.Hue = 120;
            test.Saturation = 100;
            test.Value = 100;
            hsv = rgb.Solver();
            Assert.AreEqual(hsv, test);
        }

        [TestMethod()]
        public void rgb_to_hsv_SetterTest_Navy()
        {
            var rgb = new Rgb();
            HSV hsv;
            HSV test;
            rgb.Red = 0;
            rgb.Green = 0;
            rgb.Blue = 128;
            test.Hue = 240;
            test.Saturation = 100;
            test.Value = 50;
            hsv = rgb.Solver();
            Assert.AreEqual(hsv, test);
        }
        [TestMethod()]
        public void rgb_to_hsv_SetterTest_Teal()
        {
            var rgb = new Rgb();
            HSV hsv;
            HSV test;
            rgb.Red = 0;
            rgb.Green = 128;
            rgb.Blue = 128;
            test.Hue = 180;
            test.Saturation = 100;
            test.Value = 50;
            hsv = rgb.Solver();
            Assert.AreEqual(hsv, test);
        }
        [TestMethod()]
        public void rgb_to_hsv_SetterTest_Purple()
        {
            var rgb = new Rgb();
            HSV hsv;
            HSV test;
            rgb.Red = 128;
            rgb.Green = 0;
            rgb.Blue = 128;
            test.Hue = 300;
            test.Saturation = 100;
            test.Value = 50;
            hsv = rgb.Solver();
            Assert.AreEqual(hsv, test);
        }


        [TestMethod()]
        public void rgb_to_hsv_SetterTest_Green()
        {
            var rgb = new Rgb();
            HSV hsv;
            HSV test;
            rgb.Red = 0;
            rgb.Green = 128;
            rgb.Blue = 0;
            test.Hue = 120;
            test.Saturation = 100;
            test.Value = 50;
            hsv = rgb.Solver();
            Assert.AreEqual(hsv, test);
        }
        [TestMethod()]
        public void rgb_to_hsv_SetterTest_Olive()
        {
            var rgb = new Rgb();
            HSV hsv;
            HSV test;
            rgb.Red = 128;
            rgb.Green = 128;
            rgb.Blue = 0;
            test.Hue = 60;
            test.Saturation = 100;
            test.Value = 50;
            hsv = rgb.Solver();
            Assert.AreEqual(hsv, test);
        }
        [TestMethod()]
        public void rgb_to_hsv_SetterTest_Maroon()
        {
            var rgb = new Rgb();
            HSV hsv;
            HSV test;
            rgb.Red = 128;
            rgb.Green = 0;
            rgb.Blue = 0;
            test.Hue = 0;
            test.Saturation = 100;
            test.Value = 50;
            hsv = rgb.Solver();
            Assert.AreEqual(hsv, test);
        }
        [TestMethod()]
        public void rgb_to_hsv_SetterTest_Gray()
        {
            var rgb = new Rgb();
            HSV hsv;
            HSV test;
            rgb.Red = 128;
            rgb.Green = 128;
            rgb.Blue = 128;
            test.Hue = 0;
            test.Saturation = 0;
            test.Value = 50;
            hsv = rgb.Solver();
            Assert.AreEqual(hsv, test);
        }
        [TestMethod()]
        public void rgb_to_hsv_SetterTest_Silver()
        {
            var rgb = new Rgb();
            HSV hsv;
            HSV test;
            rgb.Red = 192;
            rgb.Green = 192;
            rgb.Blue = 192;
            test.Hue = 0;
            test.Saturation = 0;
            test.Value = 75;
            hsv = rgb.Solver();
            Assert.AreEqual(hsv, test);
        }
        [TestMethod()]
        public void rgb_to_hsv_SetterTest_Magenta()
        {
            var rgb = new Rgb();
            HSV hsv;
            HSV test;
            rgb.Red = 255;
            rgb.Green = 0;
            rgb.Blue = 255;
            test.Hue = 300;
            test.Saturation = 100;
            test.Value = 100;
            hsv = rgb.Solver();
            Assert.AreEqual(hsv, test);
        }
    }
}