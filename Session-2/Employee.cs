using System.Collections;

namespace Session_2
{

    class EmployeeCompererName : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Employee X = (Employee)x;
            Employee Y = (Employee)y;
            return X.Name.CompareTo(Y.Name);

        }
    }



    internal class Employee : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public int CompareTo(object? other)
        {
            Employee E = (Employee)other;
            return this.Age.CompareTo(E.Age);
        }

        public override string ToString()
        {
            return $"Id : {Id} , Name : {Name} , Salary : {Salary} , Age : {Age}";
        }
    }

}
