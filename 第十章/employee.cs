using System;
using System.Collections.Generic;
using System.Text;

namespace 第十章
{
    [Serializable]
    public class Employee
    {
        private string name;
        private decimal salary;
        private readonly EmployeeId id;

        public Employee(EmployeeId id, string name, decimal salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public override string ToString()
        {
            return String.Format("{0}: {1, -20} {2:C}",
                  id.ToString(), name, salary);
        }
    }
}
