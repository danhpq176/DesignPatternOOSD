using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public class User
    {
        private string id;
        private string firstName;
        private string lastName;
        private string dayOfBirth;
        private string currentClass;
        private string phone;

        private string email;
        private bool isTeacher;


        public User(string id, string firstName, string lastName, string dayOfBirth, string currentClass, string phone, string email, bool isTeacher)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dayOfBirth = dayOfBirth;
            this.currentClass = currentClass;
            this.phone = phone;
            this.email = email;
            this.isTeacher = isTeacher;
        }
    }
}
