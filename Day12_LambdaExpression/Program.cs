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
                 new Student(){ Id= 1, Name="Subhash",PhoneNumber="9065567412", Address="Jalgaon", Age=15},
                 new Student(){ Id= 2,  Name="Vinesh",PhoneNumber="8765567456", Address="Chopda",Age=20, },
                 new Student(){ Id= 3, Name="Rahul",PhoneNumber="8345567456", Address="Nanded", Age=24 },
                 new Student(){ Id= 4, Name="Aptab",PhoneNumber="9749549323", Address="Pune", Age=15 },
                 new Student(){ Id= 5, Name="Mansi",PhoneNumber="775567434", Address="Nashik", Age=25 },
                 new Student(){ Id= 6, Name="Mayur",PhoneNumber="9765567498", Address="Nashik", Age=18 },
                 new Student(){ Id= 7, Name="Rajesh",PhoneNumber="9965567443", Address="Nashik", Age=30 },
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
