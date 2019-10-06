using System;
using System.Collections.Generic;
using System.Text;

namespace 第六章
{
    public enum PersonComparerType
    {
        FirstName,
        LastName
    }
    public class PersonComparer:IComparer<Person>
    {
        private PersonComparerType comparerType;
        public PersonComparer(PersonComparerType comparerType)
        {
            this.comparerType = comparerType;
        }
        public int Compare(Person x,Person y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return 1;
            if (y == null) return -1;

            switch(comparerType)
            {
                case PersonComparerType.FirstName:
                    return string.Compare(x.FirstName, y.FirstName);
                case PersonComparerType.LastName:
                    return string.Compare(x.LastName, y.LastName);
                default:
                    throw new ArgumentException("unexpected compare type");
            }
        }
    }
}
