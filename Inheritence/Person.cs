using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    internal class Person
    {

        public Person()
        {

        }

        public Person(string ad, string soyad)
        {
            Name = ad;
            Surname = soyad;
        }

        public Person(string ad, string soyad, string tcno)
        {
            Name = ad;
            Surname = soyad;
            TcNo = tcno;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string TcNo { get; set; }
        public string Gsm { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }

    }
}
