using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Json
{
    public class Developers
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string DeveloperType { get; set; }
        public string TaxType { get; set; }
        public decimal MonthlySalary { get; set; }
        public decimal AnnualSalary { get; set; }
        public decimal AnnualTaxes { get; set; }
    }
}
