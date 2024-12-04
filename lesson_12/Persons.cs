using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_12
{
    internal class Persons
    {
        public void personlist(string name)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i + name);
            }
                
        }
    }
}
