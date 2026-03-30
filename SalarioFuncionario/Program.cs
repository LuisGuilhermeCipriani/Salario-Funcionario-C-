using SalarioFuncionario.Entities;
using SalarioFuncionario.Entities.Enums;
using System;
using System.Globalization;

namespace SalarioFuncionario
{
    class Project
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o nome do departamento: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Entre com os dados do funcionário:");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Nível (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Salário base: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos contratos para este funcionário? ");
            Department department = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, department);
            int qtd = int.Parse(Console.ReadLine());

            for(int i = 0; i < qtd; i++)
            {
                Console.WriteLine("Entre com os dados do contrato #" + i);
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duração (horas): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.Write("\nEntre com o mês e o ano para calcular o salário (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0,2));
            int year = int.Parse(monthAndYear.Substring(3));
            worker.Income(year, month);
            Console.WriteLine(worker.returnDates(monthAndYear));
        }
    }
}