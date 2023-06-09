﻿using System;
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
               
                Console.WriteLine("Id : "+item.Id + " Name : "+ item.Name + " Phone Number : " + item.PhoneNumber+" Address : " +
                    item.Address+" Age : " + item.Age+ " Total Marks : " + item.TotalMarks);
            }
        }
        public void Retrive_Records_Using_Linq(List<Student> list)
        {
            var record=from student in list where student.Age >=12 && student.Age <=18 select student;
            foreach (var item in record)
            {

                Console.WriteLine("Id : " + item.Id + " Name : " + item.Name + " PhoneNumber : " + item.PhoneNumber + " Address : " + 
                    item.Address + " Age : " + item.Age + " Total Marks : " + item.TotalMarks);
            }
        } 
        public void Sort_Records_Based_On_Marks(List<Student> list)
        {
            var order = list.OrderByDescending(x => x.TotalMarks);
            foreach (var item in order)
            {

                Console.WriteLine("Id : " + item.Id + " Name : " + item.Name + " PhoneNumber : " + item.PhoneNumber + " Address : " +
                    item.Address + " Age : " + item.Age + " Total Marks : " + item.TotalMarks);
            }
        }
        public void Display_Address_Of_Student_List(List<Student> list)
        {
            var addr = list.Select(x => x.Address);
            Console.WriteLine("Address Of Student");
            foreach (var item in addr)
            {
                Console.WriteLine(item);  
            }
        }
        public void Display_First_Three_Record_From_List(List<Student> list)
        {
            var record = list.Select(x => x).Take(3);
            foreach (var item in record)
            {

                Console.WriteLine("Id : " + item.Id + " Name : " + item.Name + " PhoneNumber : " + item.PhoneNumber + " Address : " +
                    item.Address + " Age : " + item.Age + " Total Marks : " + item.TotalMarks);
            }
        }
        public void Display_Record_Based_On_Name(List<Student> list,string str)
        {           
            var record = list.Where(x => x.Name==str);
            foreach (var item in record)
            {

                Console.WriteLine("Id : " + item.Id + " Name : " + item.Name + " PhoneNumber : " + item.PhoneNumber + " Address : " +
                    item.Address + " Age : " + item.Age + " Total Marks : " + item.TotalMarks);
            }
        }
    }
}
