using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ClassLibrary.Models.EntityModels
{
    public class CustomerEntity
    {
        [Key]
        public int Id { get; set; }
        public string Company { get; set; } = string.Empty;
        public string Closing_Date { get; set; } = string.Empty;
        public string Software { get; set; } = string.Empty;
        public string Vat_Period { get; set; } = string.Empty;

    }
}

