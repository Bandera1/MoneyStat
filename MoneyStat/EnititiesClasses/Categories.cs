using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyStat.EnititiesClasses
{
    public class Categories
    {
        public int ID { get; set; }
        [StringLength(30)]
        public string Name { get; set; }
    }
}
