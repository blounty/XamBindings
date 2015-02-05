using System;
using Foundation;

namespace NotificationHub
{
    public enum NotificationAnimationType{
        Pop,
        Blink,
        Bump,
        None
    }
    public partial class Notifier : NSObject
    {

        public int CurrentCount
        {
            get {
                return Count();
            }
        }

        public void Increment(NotificationAnimationType animationType = NotificationAnimationType.None)
        {
            Increment(1, animationType);
        }

        public void Increment(int amount, NotificationAnimationType animationType = NotificationAnimationType.None)
        {
            Increment(amount);

            Animate(animationType);
        }

        public void Decrement(NotificationAnimationType animationType = NotificationAnimationType.None)
        {
            Decrement(1, animationType);
        }

        public void Decrement(int amount, NotificationAnimationType animationType = NotificationAnimationType.None)
        {
            Decrement(amount);

            Animate(animationType);

        }

        public void SetCount(int count, NotificationAnimationType animationType = NotificationAnimationType.None)
        {
            SetCount(count);

            Animate(animationType);
        }

        public void Animate(NotificationAnimationType animationType)
        {
            switch (animationType)
            {
                case NotificationAnimationType.Pop:
                    Pop();
                    break;
                case NotificationAnimationType.Blink:
                    Blink();
                    break;
                case NotificationAnimationType.Bump:
                    Bump();
                    break;
            }
        }
    }
}

