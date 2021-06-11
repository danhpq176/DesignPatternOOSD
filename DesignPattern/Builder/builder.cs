using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public interface UserBuilder
    {
        UserBuilder setId(string id);

        UserBuilder setFirstName(string firstName);

        UserBuilder setLastName(string lastName);

        UserBuilder setDayOfBirth(string dayOfBirth);

        UserBuilder setCurrentClass(string currentClass);

        UserBuilder setPhone(string phone);

        UserBuilder setEmail(string email);
        UserBuilder setIsTeacher(bool isTeacher);

        User build();
    }
}
