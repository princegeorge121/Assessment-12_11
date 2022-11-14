using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_12_11
{
    internal class Employee
    {
        public string Name { get; set; }

        private string _designation;
        public string Designation
        {
            get
            {
                return _designation;
            }
            set
            {

                if (value == "Manager")
                {
                    _designation = value;
                    _salary = 450000;

                }
                else if (value == "Senior Developer")
                {
                    _designation = value;
                    _salary = 50000;
                }
                else if (value == "Trainee")
                {
                    _designation = value;
                    _salary = 15000;
                }
                else
                {
                    Console.WriteLine("Invalid Designation");

                }
            }
        }

        public string Department { get; set; }

        private int _salary;

        public int Salary
        {
            get { return _salary; }

        }

        public void GetData()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Department : " + Department);
            Console.WriteLine("Designation : " + Designation);
            Console.WriteLine("Salary : " + Salary);

        }
        public void SetData()
        {

            Console.WriteLine("Enter Name : ");
            Name = Console.ReadLine();
            Console.WriteLine("Department : ");
            Department = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Designation : ");
                Designation = Console.ReadLine();
                if (Designation == "Trainee" || Designation == "Senior Developer" || Designation == "Manager")
                {
                    break;
                }

            }

        }
    }
}
