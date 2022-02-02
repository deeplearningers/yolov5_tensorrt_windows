using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace testdll3
{
    class Program
    {

        [DllImport("D:\\yolo\\yolov52\\x64\\Release\\yolov5.dll")]
        private extern static string yolov5trt();

        static void Main(string[] args)
        {
            DateTime beforeDT = System.DateTime.Now;
            string index = yolov5trt();
            Console.WriteLine(index);

            DateTime afterDT = System.DateTime.Now;
            TimeSpan ts = afterDT.Subtract(beforeDT);
            Console.WriteLine("time consume is: {0}ms", ts.TotalMilliseconds);

            Console.Read();
        }
    }
}
