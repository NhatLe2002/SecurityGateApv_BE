using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Domain.Interfaces.Notifications
{
    public interface INotifications
    {
        public Task SendMessage();
    }
}
