using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace TreinamentoOOP78
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee()
        {

        }

        public Employee(int Id, string Name, double Salary)
        {
            this.Name = Name;
            this.Id = Id;
            this.Salary = Salary;
        }

        public void IncreaseSalary(double porcentagem)
        {
            double a = Salary * porcentagem / 100;
            Salary = Salary + a;

        }

        public override string ToString()
        {
            return Id + ", "
                + Name + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);

        }
    }


}




