using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public void Student()
        {
            Console.WriteLine($"Öğrencinin adı: {FirstName} \nSoyadı: {LastName} \nDoğum tarihi: {BirthDate.ToShortDateString()}");
        }
        public void Teacher()
        {
            Console.WriteLine($"Öğretmenin adı: {FirstName} \nSoyadı: {LastName} \nDoğum tarihi: {BirthDate.ToShortDateString()}");
        }
    }
}
