using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.Contracts;

namespace 第十章
{
    [Serializable]
   public class Person
    {
        private string name;
        public Person(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
