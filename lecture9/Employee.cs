using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture9
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }

        public  Employee(int iD, string name, DateTime dateTime)
        {
            ID = iD;
            Name = name;
            DateTime = dateTime;
        }
        public string employeeinfo()
        {
            return "name : " + Name + " \n" + " Id : " + ID + "\n" + "Birth: " + DateTime.Date.ToString();
        }
    }
}
