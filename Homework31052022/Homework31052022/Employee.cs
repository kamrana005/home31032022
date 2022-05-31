using System;
using System.Collections.Generic;
using System.Text;

namespace Homework31052022
{
    internal class Employee : Human
    {
        public  Employee (string FullName):base(FullName)
        {

        }
        public double Salary;
        public string Position;
    }
}
