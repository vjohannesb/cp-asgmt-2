using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Repository.Models
{
    internal class Animal
    {
        public string Name { get; set; }
        public Customer Owner { get; set; }
    }
}
