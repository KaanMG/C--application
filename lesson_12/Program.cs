using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Console.WriteLine("Hello");
            //Console.Write("World");

            //string word = "26 Ekim";
            //Console.WriteLine(word);

            //int number = 5;
            //Console.WriteLine(number);

            //Message msg = new Message();
            //msg.text();

            //Persons ps = new Persons();
            //ps.personlist(".Person");

            //string nsn;

            //Console.WriteLine("Enter a name =");
            //nsn = Console.ReadLine();
            //ps.personlist("." + nsn);

            //process operation = new process();
            //int number1, number2, number3;
            //Console.WriteLine("Enter the number1");
            //number1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the number2");
            //number2 = Convert.ToInt32(Console.ReadLine());
            //number3 = operation.add(number1, number2);
            //Console.WriteLine("Addition = " + number3); 

            ID id = new ID();

            id.NAME = "MELiH";
            id.SURNAME = "gnecdogan";
            id.COUNTRY = "Adana";

            Console.WriteLine(id.NAME);
            Console.WriteLine(id.SURNAME);
            Console.WriteLine(id.COUNTRY);
            Console.WriteLine(id.AGE);
            Console.WriteLine(id.GENDER);


            Console.ReadKey();
        }
    }
}
