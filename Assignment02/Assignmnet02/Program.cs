using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnet02
{
    public struct Students
    {
        private string name;
        private bool gender;
        private int age;
        private int std;
        private char div;
        private double marks;

        public double Marks
        {
            get { return marks; }
            set { marks = value; }
        }


        public char Div
        {
            get { return div; }
            set { div = value; }
        }


        public int Std
        {
            get { return std; }
            set { std = value; }
        }


        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public bool Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Students(string Name, bool Gender, int Age, int Std, char Div, double Marks)
        {
            name= Name;
            gender = Gender;
            age =Age;
            std = Std;
            div = Div;
            marks = Marks;

        }

        public void AcceptDetails()
        {
            Console.WriteLine("Enter Name-");
            string name=Console.ReadLine();
            Console.WriteLine("Enter Gender-");
            bool gender = false;
            Console.WriteLine("Enter Age-");
            int age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Std-");
            int std = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Div-");
            char div = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks-");
            double marks=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Name:{name}");
            Console.WriteLine($"Gender:{gender}");
            Console.WriteLine($"Age:{age}");
            Console.WriteLine($"Std:{std}");
            Console.WriteLine($"Dv:{div}");
            Console.WriteLine($"Marks:{marks}");

        }

        public void PrintDetails(string name,bool gender,int age,int std,char div,double marks)
        {
            Console.WriteLine("Student details-");
            Console.WriteLine($"Name:{name}");
            Console.WriteLine($"Gender:{gender}");
            Console.WriteLine($"Age:{age}");
            Console.WriteLine($"Std:{std}");
            Console.WriteLine($"Dv:{div}");
            Console.WriteLine($"Marks:{marks}");
        }
  }
    internal class Program
    {
        static void Main(string[] args)
        {
         Students students = new Students();
            students.AcceptDetails();
            students.AcceptDetails();

            Console.ReadLine();

        }
    }
}
