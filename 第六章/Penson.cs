using System;
using System.Collections.Generic;
using System.Text;

namespace 第六章
{
    public class Person : IComparable<Person>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return string.Format("{0}  {1}", FirstName, LastName);
        }
        public int CompareTo(Person other)
        {
            if (other == null) return 1;
            int result = string.Compare(this.LastName, other.LastName);
            if (result == 0)
            {
                result = string.Compare(this.FirstName, other.FirstName);
            }
            return result;
        }
    }
}
