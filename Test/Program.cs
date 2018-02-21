using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method1();
            //Method2();
            barcode();
            Console.ReadKey();  
        }

        public static void barcode()
        {
            string barCode = "21223345";
            

            using (Bitmap bitMap = new Bitmap(barCode.Length * 30, 70))
            {
                using (Graphics graphics = Graphics.FromImage(bitMap))
                {
                    Font oFont = new Font("Free 3 of 9", 40);
                    var rect = new Rectangle(0, 0, bitMap.Width, bitMap.Height);

                    SolidBrush blackBrush = new SolidBrush(Color.Black);
                    SolidBrush whiteBrush = new SolidBrush(Color.White);

                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Center;

                    graphics.FillRectangle(whiteBrush, 0, 0, bitMap.Width, bitMap.Height);
                    graphics.DrawString("*" + barCode + "*", oFont, blackBrush, rect, stringFormat);
                }

                bitMap.Save(@"E:\Test\Logo\barcode\test.gif", System.Drawing.Imaging.ImageFormat.Gif);

                //using (MemoryStream ms = new MemoryStream())
                //{
                //    bitMap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                //    byte[] byteImage = ms.ToArray();

                //    Convert.ToBase64String(byteImage);
                //    imgBarCode.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(byteImage);
                //}

                
            }
        }

        //public class test
        //{
        //    public string str { get; set; }
        //}

        //public static async void Method1()
        //{
        //    var t = new test();
        //    t.str = "hello";

        //    for (int i = 0; i < 100; i++)
        //    {
        //        await Method3(t);
        //        Console.WriteLine(t.str);
        //    }
        //}

        //public static async Task Method3(test t)
        //{
        //    await Task.Run(() =>
        //    {
        //        Thread.Sleep(1000);
        //        t.str = "Method3";
        //        Console.WriteLine(" Method 1");
        //    });
        //}

        //public static void Method3(test t)
        //{
        //    Thread.Sleep(1000);
        //    t.str = "Method3";
        //    Console.WriteLine(" Method 1");
        //}

        //public static void Method2()
        //{
        //    for (int i = 0; i < 25; i++)
        //    {
        //        Console.WriteLine(" Method 2");
        //    }
        //}  
    }
}
