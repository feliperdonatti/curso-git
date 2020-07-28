using System;
using System.Collections.Generic;
using System.Text;

namespace Cap6Exercicio1
{
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }

        public override string ToString()
        {
            return Room + ": " + Name + ", " + Email;
        }


    }
}
