using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyStat.EnititiesClasses
{
    public class ProfitsAndSpendings
    {
        public int ID { get; set; }
        [Required]
        public float Value { get; set; }
        [Required]
        public int TypeID { get; set; }
        [Required]
        public int CategoryID { get; set; }
        [StringLength(350)]
        public string Description { get; set; }
        [Required]
        public DateTime Date { get; set; }


        public virtual Categories Category { get; set; }
        public virtual Types Type { get; set; }
    }
}
