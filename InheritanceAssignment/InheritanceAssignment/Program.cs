using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    abstract class Employee
    {
        public string Name { get; set; }

        public int EmpNo { get; }

        private short _deptNo;
        public short DeptNo
        {
            get { return _deptNo; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("DeptNo must be greater than 0");
                _deptNo = value;
            }
        }

        public abstract decimal Basic { get; set; }

        private static int lastEmpNo = 0;

        public Employee(string name, short deptNo)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be blank");

            Name = name;
            DeptNo = deptNo;
            EmpNo = ++lastEmpNo;
        }

        public abstract decimal CalcNetSalary();
    }

    class Manager : Employee
    {
        private string _designation;
        public string Designation
        {
            get { return _designation; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Designation can't be blank");
                _designation = value;
            }
        }

        private decimal _basic;
        public override decimal Basic
        {
            get { return _basic; }
            set
            {
                if (value < 10000)
                    throw new ArgumentException("Basic for Manager must be >= 10000");
                _basic = value;
            }
        }

        public Manager(string name, short deptNo, string designation, decimal basic)
            : base(name, deptNo)
        {
            Designation = designation;
            Basic = basic;
        }

        public override decimal CalcNetSalary()
        {
            return Basic + 5000;
        }
    }

    class GeneralManager : Manager
    {
        public string Perks { get; set; }

        public GeneralManager(string name, short deptNo, string designation, decimal basic, string perks)
            : base(name, deptNo, designation, basic)
        {
            Perks = perks;
        }

        public override decimal CalcNetSalary()
        {
            return Basic + 10000;
        }
    }

    class CEO : Employee
    {
        private decimal _basic;
        public override decimal Basic
        {
            get { return _basic; }
            set
            {
                if (value < 20000)
                    throw new ArgumentException("Basic for CEO must be >= 20000");
                _basic = value;
            }
        }

        public CEO(string name, short deptNo, decimal basic)
            : base(name, deptNo)
        {
            Basic = basic;
        }

        public sealed override decimal CalcNetSalary()
        {
            return Basic + 20000;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Manager m = new Manager("Ali", 1, "Lead", 15000);
                Console.WriteLine($"Manager: {m.Name}, Salary: {m.CalcNetSalary()}");

                GeneralManager gm = new GeneralManager("Zara", 2, "GM", 18000, "Car, Bonus");
                Console.WriteLine($"General Manager: {gm.Name}, Salary: {gm.CalcNetSalary()}");

                CEO ceo = new CEO("Adeel", 3, 30000);
                Console.WriteLine($"CEO: {ceo.Name}, Salary: {ceo.CalcNetSalary()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
