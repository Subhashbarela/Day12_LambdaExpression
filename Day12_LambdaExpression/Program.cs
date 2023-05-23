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
                 new Student(){ Id= 1, Name="Subhash",PhoneNumber="9065567412", Address="Jalgaon", Age=15,TotalMarks=30},
                 new Student(){ Id= 2,  Name="Vinesh",PhoneNumber="8765567456", Address="Chopda",Age=20,TotalMarks=45 },
                 new Student(){ Id= 3, Name="Rahul",PhoneNumber="8345567456", Address="Nanded", Age=24 , TotalMarks = 65},
                 new Student(){ Id= 4, Name="Aptab",PhoneNumber="9749549323", Address="Pune", Age=15, TotalMarks=42 },
                 new Student(){ Id= 5, Name="Mansi",PhoneNumber="775567434", Address="Nashik", Age=10,TotalMarks=35 },
                 new Student(){ Id= 6, Name="Mayur",PhoneNumber="9765567498", Address="Nashik", Age=18,TotalMarks=56 },
                 new Student(){ Id= 7, Name="Rajesh",PhoneNumber="9965567443", Address="Nashik", Age=12,TotalMarks=75 },
                 new Student(){ Id= 8, Name="Pranit",PhoneNumber="768543334", Address="Mumbai", Age=6,TotalMarks=66 },
                 new Student(){ Id= 9, Name="Vinesh",PhoneNumber="9965567443", Address="Nashik", Age=30,TotalMarks=88 },
            };
            Console.WriteLine("1: Create Student List And Display The Record \n2: Retrive Particular Record Using Linq " +
                "\n3: Fetch DataBased On TotalMarks\n4: Display the Address od Student");
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
                case 2:
                    {
                        LambdaExpression lambda = new LambdaExpression();
                        lambda.Retrive_Records_Using_Linq(list);
                        break;
                    }
                case 3:
                    {
                        LambdaExpression lambda = new LambdaExpression();
                        lambda.Sort_Records_Based_On_Marks(list);
                        break;
                    }
                case 4:
                    {
                        LambdaExpression lambda = new LambdaExpression();
                        lambda.Display_Address_Of_Student_List(list);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Please insert the invalid input");
                        break;
                    }
            }
        }
    }
}
