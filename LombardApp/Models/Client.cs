using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LombardApp.Models
{
    /// Client model
    
    [Table("clients")]
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long PESEL { get; set; }
        public string TelNumber { get; set; }
        public string Address { get; set; }
    }
}
