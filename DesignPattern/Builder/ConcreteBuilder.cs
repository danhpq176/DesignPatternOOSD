using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    class ConcreteBuilder : UserBuilder
    {
        private string id;
        private string firstName;
        private string lastName;
        private string dayOfBirth;
        private string currentClass;
        private string phone;
        private string email;
        private bool isTeacher;
        public UserBuilder setId(string id)
        {
            this.id = id;
            return this;
        }

        public UserBuilder setFirstName(string firstName)
        {
            this.firstName = firstName;
            return this;
        }

        public UserBuilder setLastName(string lastName)
        {
            this.lastName = lastName;
            return this;
        }

        public UserBuilder setDayOfBirth(string dayOfBirth)
        {
            this.dayOfBirth = dayOfBirth;
            return this;
        }

        public UserBuilder setCurrentClass(string currentClass)
        {
            this.currentClass = currentClass;
            return this;
        }

        public UserBuilder setPhone(string phone)
        {
            this.phone = phone;
            return this;
        }
        public UserBuilder setEmail(string email)
        {
            this.email = email;
            return this;
        }

        public UserBuilder setIsTeacher(bool isTeacher)
        {
            this.isTeacher = isTeacher;
            return this;
        }

        public User build()
        {
            if (id != null)
            {
                Console.WriteLine("Register with Id: " + id.ToString());
            }
            if (firstName != null)
            {
                Console.WriteLine("Register with first name: " + firstName.ToString());
            }
            if (lastName != null)
            {
                Console.WriteLine("Register with last name: " + lastName.ToString());
            }
            if (dayOfBirth != null)
            {
                Console.WriteLine("Register with date of birth: " + dayOfBirth.ToString());
            }

            return new User(id, firstName, lastName, dayOfBirth, currentClass, phone, email, isTeacher);
        }
    }
}
