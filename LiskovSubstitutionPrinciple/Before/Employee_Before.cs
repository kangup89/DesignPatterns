using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Before
{
    public class Employee_Before
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Employee_Before Manager { get; set; } = null;
        public decimal Salary { get; set; }

        public virtual void AssignManager(Employee_Before manager)
        {
            // Simulate doing other tasks here - otherwise, this should be a property set statement, not a method.
            Manager = manager;
        }

        public virtual void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 12.50M;

            Salary = baseAmount + (rank * 2);
        }
    }
}
