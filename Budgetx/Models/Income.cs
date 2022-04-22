using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Income
    {
        public decimal Salary { get; set; }
        public decimal ExtraWages { get; set; }
        public decimal StateTax { get; set; }
        public decimal FederalTax { get; set; }
    }
}
