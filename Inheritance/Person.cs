using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritance
{
    public class Person
    {
        //field
        string name;
        int age;

        //constructor
        public Person(string n, int a)
        {
            this.name = n;
            this.age = a;
        }

        //properties
        public string Name;

        public int Age;

        //fungsi
        public void InfoPerson()
        {
            Console.WriteLine("Nama saya {0}, dan umur saya {1} tahun", name, age);
        }
    }

    //class turunan
    public class Karyawan : Person 
    {
        string Subject;
        string karyawanid;

        //constructor
        public Karyawan(string kid, string sbj, string n, int a) : base(n, a)
        {
            karyawanid = kid;
            Subject = sbj;
        }

        //properties
        public string karyawanID;

        public string subject;


        //override
        public void InfoKaryawan(string kid, string sbj)
        {
            //fungsi
            Console.WriteLine("Dengan ID {0}, \nSaya disini sebagai {1} ", kid, sbj);
        }
        public void InfoPerson(string name, int age)
        {
            Console.WriteLine("Nama saya {0}, dan umur saya {1} tahun", name, age);
        }
    }
}
