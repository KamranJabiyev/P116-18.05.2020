using System;

namespace ClassObject
{
    class Person
    {
        //field
        public string Name;
        public string Surname;
        public int Age;
        public string FatherName;

        //constructor - class adi ile eyni olan methoddur.Const - 
        //chagirmaq olmur,instance alinanda ilk ishe dushen methoddur. Const - return olmur.
        //public Person()
        //{
        //    Console.WriteLine("Person created");
        //}

        public Person(string name,string surname)
        {
            Name = name;
            Surname = surname;
        }

        public Person(string name, string surname,int age):this(name,surname)
        {
            Age = age;
        }
        //method
        public string GetFullName()
        {
            return $"{Name} {Surname}";
        }

        public virtual string GetFullInfo()
        {
            return $"{GetFullName()} {Age}";
        }
    }
}
