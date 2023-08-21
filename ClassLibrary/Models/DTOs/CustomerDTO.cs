using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models.DTOs
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string ClosingDate { get; set; }
        public string Software { get; set; }
        public string VatPeriod { get; set; }
    }
}
