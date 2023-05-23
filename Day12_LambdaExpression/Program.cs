using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_LambdaExpression
{
    public class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Student>()
            {
                 new Student(){ Id= 1, Age=29, Name="Subhash", City="Jalgaon"},
                 new Student(){ Id= 2, Age=20, Name="Vinesh", City="Chopda" },
                 new Student(){ Id= 3, Age=24, Name="Rahul", City="Nanded" },
                 new Student(){ Id= 4, Age=15, Name="Aptab", City="Pune" },
                 new Student(){ Id= 5, Age=25, Name="Mansi", City="Nashik" },
                 new Student(){ Id= 6, Age=18 , Name="Mayur", City="Nashik"},
                 new Student(){ Id= 7, Age=30 , Name="Rajesh", City="Nashik"},
            };
            Console.WriteLine("1: Create Student List And Display The Record");
            Console.WriteLine("Enter the choice");
            int choice=int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        LambdaExpression lambda = new LambdaExpression();
                        lambda.Display_Record(list);
                        break;
                    }
            }
        }
    }
}
