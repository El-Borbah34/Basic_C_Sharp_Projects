using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employees> employeeList = new List<Employees>();
            List<Employees> JoeList = new List<Employees>();
            List<Employees> JoeList2 = new List<Employees>();
            List<Employees> idListOver5 = new List<Employees>();

            employeeList.Add(new Employees() { name = "Pierson", lastName = "Han", iD = 34 });
            employeeList.Add(new Employees() { name = "Joe", lastName = "Barredo", iD = 2 });
            employeeList.Add(new Employees() { name = "Joe", lastName = "Teck", iD = 5 });
            employeeList.Add(new Employees() { name = "Sarah", lastName = "Wehrle", iD = 7 });
            employeeList.Add(new Employees() { name = "Jake", lastName = "Dawe", iD = 14 });
            employeeList.Add(new Employees() { name = "Jason", lastName = "Squallante", iD = 45 });
            employeeList.Add(new Employees() { name = "Adrian", lastName = "Cassidy", iD = 67 });
            employeeList.Add(new Employees() { name = "Nasty", lastName = "NeckFace", iD = 12 });
            employeeList.Add(new Employees() { name = "Charles", lastName = "Burns", iD = 46 });
            employeeList.Add(new Employees() { name = "Daniel", lastName = "Clowes", iD = 34 });

            JoeList = employeeList.Where(x => x.name == "Joe").ToList();

            foreach (Employees employees in employeeList)
            {
                if (employees.name == "Joe")
                {
                    JoeList2.Add(employees);
                }
            }

            idListOver5 = employeeList.Where(x => x.iD > 5).ToList();
        }
    }
}
