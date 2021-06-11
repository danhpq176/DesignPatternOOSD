using System;

namespace DesignPattern
{
    public class SubjectFactory
    {

        private SubjectFactory()
        {
        }
        public static Subject getAccount(AccountType accountType)
        {
            switch (accountType)
            {
                case AccountType.TEACHER:
                    return new TeacherSubject();
                case AccountType.STUDENT:
                    return new StudentSubject();
                default:
                    return new StudentSubject();
            }
        }

    }
}
