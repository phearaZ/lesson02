using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson02lap2
{
    class Phone
    {
        public string strModel;
        private float fltScreenSize;

        public float ScreenSize
        {
            get { return fltScreenSize; }
            set { if(value>0)
                fltScreenSize = value; }
        }
    }
    internal class program
    {
        static void Main(string[] args)
        {
            Phone pObj = new Phone();
            Console.Write("Enter the model: ");
            pObj.strModel = Console.ReadLine();

            Console.Write("enter the screen size: ");
            pObj.ScreenSize = float.Parse(Console.ReadLine());

            Console.WriteLine("model = {0}, screen size = {1}", pObj.strModel, pObj.ScreenSize.ToString();
        }

    }



}
