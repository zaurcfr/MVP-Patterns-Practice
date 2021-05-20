using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Patterns_Practice.Models
{
    public class Payment
    {
        [Key]
        public string Name { get; set; }
        public string Liter { get; set; }
        public string Price { get; set; }
        public string PricePerLiter { get; set; }
        public DateTime DateTime { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Liter}L - {Price}USD - {DateTime}";
        }
    }
}
