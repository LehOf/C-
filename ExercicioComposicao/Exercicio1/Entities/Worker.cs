using System;
using System.Collections.Generic;
using System.Text;
using Exercicio1.Entities.Enum;

namespace Exercicio1.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; private set; } = new List<HourContract>(); //criando uma lista

        public Worker()
        {

        }
        public Worker(string Name, WorkerLevel Level, double BaseSalary, Department department)
        {
            this.Name = Name;
            this.Level = Level;
            this.BaseSalary = BaseSalary;
            this.Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);

        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);

        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }

            }
            return sum;

        }
    }
}
