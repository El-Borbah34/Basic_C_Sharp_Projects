using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataTimeAssignment
{
    public class User
    {
        public User(string name) : this(name, 30)
        {

        }
        public User(string name, int yearsold)
        {
            Name = name;
            age = yearsold;
        }

        public int age { get; set; }
        public string Name { get; set; }
        public int cashAmount { get; set; }
    }
}
