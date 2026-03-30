using System;
using System.Collections.Generic;

namespace SalarioFuncionario.Entities
{
    internal class Department
    {
        public string Name { get; set; }

        public Department()
        {}

        public Department(string name)
        {
            Name = name;
        }
    }
}
