using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LombardApp.Models
{
    /// Items model

    [Table("items")]
    public class PledgedItems
    {
        [Key]
        public int Id { get; set; }
        public string ItemName { get; set; }
        public int ClientId { get; set; }
        public int Price { get; set; }
        public string DatePledge { get; set; }
        public string EndDatePledge { get; set; }
    }
}
