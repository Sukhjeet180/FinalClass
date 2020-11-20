using System;

namespace FinalTest
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Person[] persons=new Person[2];
            persons[0] = new Adult("Sukhjeet","Kaur");
            persons[1] = new Child("Moninder","Singh");

            foreach(Person p in persons)
            {
                Console.WriteLine(p.FirstName +" "+p.LastName);
            }

        }
   

    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        

    }

    public class Adult : Person
    {
        public Adult(string fname,string lname)
        {
            FirstName = fname;
            LastName = lname;
        }
    }

    public class Child : Person
    {
        public Child(string fname, string lname)
        {
            FirstName = fname;
            LastName = lname;
        }

    }

}
