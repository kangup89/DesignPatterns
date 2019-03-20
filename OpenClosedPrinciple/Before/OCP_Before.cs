using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Before
{
    class OCP_Before
    {
        /*static void Main(string[] args)
        {
            List<PersonModel_Before> applicants = new List<PersonModel_Before>
            {
                new PersonModel { FirstName = "Tim", LastName = "Corey"},
                new PersonModel { FirstName = "Sue", LastName = "Storm", TypeOfEmployee = EmployeeType.Manager},
                new PersonModel { FirstName = "Nancy", LastName = "Roman", TypeOfEmployee = EmployeeType.Executive}
            };

            List<EmployeeModel_Before> employees = new List<EmployeeModel_Before>();
            Accounts_Before accountProcessor = new Accounts_Before();

            foreach (var person in applicants)
            {
                employees.Add(accountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{ emp.FirstName } { emp.LastName }: { emp.EmailAddress } IsManager: { emp.IsManager } IsExecutive: { emp.IsExecutive }");
            }

            Console.ReadLine();
        }*/
    }
}
