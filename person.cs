using System;

namespace library
{
    public abstract class Person
    {
        public String name { get; set; }
        public String email { get; set; }

        protected Person(String Name, String Email)
        {
            this.email = Email;
            this.name = Name;
        }

        public abstract void PersonInformation();

     }
}