using System;
using System.Collections.Generic;
using System.Text;

namespace lekcija3._1
{
    class Person
    {
     
        private string _name;
        private string _lastName;
        private DateTime _dateOfBirth;
        private string _hobby;
        private string _gender;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }
        public string Hobby
        {
            get { return _hobby; }
            set { _hobby = value; }
        }
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        
        public Person(string name, string lastName, DateTime dateOfBirth, string hobby, string gender)
        {
            _name = name;
            _lastName = lastName;
            _dateOfBirth = dateOfBirth;
            _hobby = hobby;
            _gender = gender;
        }

        public void SayHello()
        {
            var now = DateTime.Now;
            var age = now.Year - _dateOfBirth.Year;
            Console.WriteLine($"Hello there! My name is {_name} {_lastName} and I am {age} years old.");
        }
    }
}
