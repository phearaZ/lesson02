using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson02lap3
{
    class Circle
    {
        private float fltRadius;
        private string strColor;

        public float Radius
        { get { return fltRadius; }  //to read from Radius
          set { if (value>0)
                    fltRadius = value; } } //to write to Radius
        public string Color 
        { get { return strColor; }  
          set { strColor = value; } }
    }
    interenal class program
    { 
        static void Main(string[] args)
        {
            Circle cObj = new Circle();

            Console.Write("Enter the radius: ");
            cObj.Radius = float.Parse(Console.ReadLine());
            Console.Write("Enter the color: ");
            cObj.Color = Console.ReadLine();

            Console.WriteLine("radius = {0}, color = {1}", cObj.Radius.ToString(), cObj.Color);
        }
    }
}
