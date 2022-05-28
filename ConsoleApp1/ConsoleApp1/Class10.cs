using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class sample
    {
        public int a;
    }
    class Employee
    {
        private string Name;
        private int id;
        private string Gender;
        private int salary;
        private string job;

        public Employee()
        {
            job = "Analyst";
        }
        ~Employee()
        {

        }
        public void GetData()
        {
            Console.WriteLine("please enter Employee details");
            Console.WriteLine("please enter employee Name");
            Name = Console.ReadLine();
            Console.WriteLine("please enter employee id");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter employee Gender");
            Gender = Console.ReadLine();
            Console.WriteLine("please enter employee salary");
            salary = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintData()
        {
            Console.WriteLine("Employee details are");
            Console.WriteLine(Name);
            Console.WriteLine(id);
            Console.WriteLine(Gender);
            Console.WriteLine(salary);
            Console.WriteLine(job);
        }
    }
    class class10
    {
        static void Main(string[] args)
        {
            // sample e1 = new sample();
            // e1.a = 4;
            //Console.WriteLine(e1.a);
            //  Employee e = new Employee();
            Employee[] Employeelist = new Employee[2];
            for (int i = 0; i < Employeelist.Length; i++)
            {
                Employee e = new Employee();
                e.GetData();
                Employeelist[i] = e;
            }
            for(int i = 0; i < Employeelist.Length; i++)
            {
                Employeelist[i].PrintData();
            }
        }
    }
}

