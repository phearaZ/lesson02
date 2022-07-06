using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson02lap1
{

    class Employee
    {
        public string strName;
        private float fltSalary;
        public float Salary
        {
            get { return fltSalary; }
            set { if(value>0) 
                fltSalary = value; }
        }
    }
    internal class Program
    {
            static void Main(string[] args)
            {
                Employee empObj = new Employee();
                Console.Write("Enter your name: ");
                empObj.strName = Console.ReadLine();

                Console.Write("Enter your salary: ");
                empObj.Salary= float.Parse(Console.ReadLine());

                Console.WriteLine("Name = {0}, Salary = {1}", empObj.strName, empObj.Salary.ToString());
            }
        

    }
       
}
