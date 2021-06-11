
using System;

namespace DesignPattern
{
    public abstract class Account
    {
        protected Notification notification;

        public Account(Notification notification)
        {
            this.notification = notification;
        }

        public abstract void addNotification();
    }
    public class TeacherAccount : Account
    {

        public TeacherAccount(Notification notification) : base(notification)
        {

        }

        public override void addNotification()
        {
            Console.Write("I'm a teacher and when i add noti, it will show: ");
            notification.addNotification();
        }
    }
    public class StudentAccount : Account
    {

        public StudentAccount(Notification notification) : base(notification)
        {
        }

        public override void addNotification()
        {
            Console.Write("I'm a student and when i add noti, it will show: ");
            notification.addNotification();
        }
    }
}
