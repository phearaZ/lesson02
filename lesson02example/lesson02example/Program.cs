using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson02example
{
    class House
    {
        public string strType;
        private string strAddress;

        public string Address
        {
            get { return strAddress; }
            set { strAddress = value; }
        }
        private float fltPrice;
        public float Price
        {
            get { return fltPrice; }
            set { fltPrice = value; }
        }
    }
    internal class Program 
    {
        static void Main(string[] args)
        {
            House hObj = new House();
            Console.WriteLine("Enter the types of House: ");
            hObj.strType = Console.ReadLine();
            Console.WriteLine("Enter the address: ");
            hObj.Address = Console.ReadLine();

            Console.WriteLine("Enter the price: ");
            hObj.Price = float.Parse(Console.ReadLine());
            Console.WriteLine("Type = {0}, Address = {1}, and Price = {2}"
                   , hObj.strType, hObj.Address, hObj.Price); 
        }
    }
}
