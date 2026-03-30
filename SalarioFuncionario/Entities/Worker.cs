using System;
using System.Collections.Generic;
using SalarioFuncionario.Entities.WorkerLevel;
using SalarioFuncionario.Entities.HourContract;
using SalarioFuncionario.Entities.Department;

namespace SalarioFuncionario.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel level { get; set; }
        public double BaseSalary { get; set; }

        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        public Department department { get; set; };

        public Worker()
        {}

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            WorkerLevel = workerLevel;
            BaseSalary = baseSalary;
            department = department;
        }

        public void AddContract(HourContract contract)
        {

        }

        public void Remove(HourContract contract)
        {

        }

        public double Income(int year, int month)
        {

        }

    }
}
