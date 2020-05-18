using System;
using System.Collections.Generic;
using System.Text;

namespace HW23_Solid.DependencyInversionPrinciple
{
    public interface IMessenger
    {
        void Send();
    }

    public class Email : IMessenger
    {
        public void Send()
        {
            // код для отправки email-письма
        }
    }

    public class SMS : IMessenger
    {
        public void Send()
        {
            // код для отправки SMS
        }
    }

    // Уведомление
    public class Notification
    {
        private IMessenger _messenger;
        public Notification()
        {
            _messenger = new Email();
        }

        public void DoNotify()
        {
            _messenger.Send();
        }
    }
}
