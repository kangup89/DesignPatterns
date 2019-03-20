using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.After
{
    public interface IManager : IEmployee
    {
        void GeneratePerformanceReview();
    }
}
