using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_LambdaExpression
{
    public class LambdaExpression
    {
        List<Student> list = new List<Student>();
        public void Display_Record(List<Student> list)
        {
            foreach (var item in list)
            {               
               
                Console.WriteLine("Id : "+item.Id + " Name : "+ item.Name + " City : " + item.PhoneNumber+" City : " + item.Address+" City : " + item.Age);
            }
        }
    }
}
