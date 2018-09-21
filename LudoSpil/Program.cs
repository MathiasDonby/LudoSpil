using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoSpil
{
    class Program
    {
        public static Players.Player p1 = new Players.Player(1);
        public static Players.Player p2 = new Players.Player(2);
        public static Players.Player p3 = new Players.Player(3);
        public static Players.Player p4 = new Players.Player(4);

        public static Employee Employee1 = new Employee { Name = "Bobby", Salary = 20000 };

        static void Main(string[] args)
        {
            
            Console.WriteLine("{0} tjener {1}", Employee1.Name, Employee1.Salary);
            Console.ReadLine();
            Employee1.Salary = Employee1.Bonus(1.10);
            Console.WriteLine("{0} tjener {1}", Employee1.Name, Employee1.Salary);
            Console.ReadLine();
            Employee1.Salary = Employee1.Bonus();
            Console.WriteLine("{0} tjener {1}", Employee1.Name, Employee1.Salary);
            Console.ReadLine();

        }
    }
}
