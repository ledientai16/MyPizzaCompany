using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPizzaCompany.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string name { get; set; }
        public Boolean isComplete { get; set; }
    }
}
